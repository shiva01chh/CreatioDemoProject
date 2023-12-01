Ext.ns("Terrasoft.utils.sso");

Ext.define("Terrasoft.utils.sso.providers.OpenIdStartSsoClientProvider", {
    alternateClassName: "Terrasoft.OpenIdStartSsoClientProvider",
    singleton: true,

    _baseViewModulePath: Terrasoft.BaseViewModulePath || window.baseViewModulePath,
    _autoOpenIdLoginParamName: "autoOpenIdLogin",
    _autoOpenSsoLoginParamName: "autoSsoLogin",

    _getRootUrl: function (address) {
        if (!address) {
            return null;
        }
        const removeEndingSlashRegex = /\/$/;
        let url = Terrasoft.workspaceBaseUrl.replace(removeEndingSlashRegex, "");
        const appSegment = Terrasoft.appFramework === "NETCOREAPP" ? "/": "/0/";
        return url + appSegment + address;
    },

    _updateQueryStringParameter: function (uri, key, value) {
        const re = new RegExp("([?&])" + key + "=.*?(&|$)", "i");
        const separator = uri.indexOf('?') !== -1 ? "&" : "?";
        const updatedUri = uri.match(re)
            ? uri.replace(re, '$1' + key + "=" + value + '$2')
            : uri + separator + key + "=" + value;
        return updatedUri;
    },

    _tryParse: function (str) {
        try {
            return JSON.parse(str);
        } catch {
            return {};
        }
    },

    getRedirectUrlWithAutoOpenIdLogin: function(providerCode) {
        const redirectUrl = Terrasoft.LoginModelUtils.getWindowQueryStringWithoutHash(window.location);
        const location = window.location;
        const hasQueryString = Terrasoft.LoginModelUtils.containsIgnoreCase(location.pathname, redirectUrl);
        const hasSimpleLogin = Terrasoft.LoginModelUtils.containsIgnoreCase(redirectUrl, Terrasoft.simpleLoginTag);
        let newLocation = redirectUrl;
        if (hasQueryString || hasSimpleLogin) {
            if (Terrasoft.openIdRootUrl) {
                return this._getRootUrl(Terrasoft.openIdRootUrl);
            }
            newLocation = this._getRootUrl(this._baseViewModulePath);
        }
        newLocation = providerCode
            ? this._updateQueryStringParameter(newLocation, this._autoOpenSsoLoginParamName, providerCode)
            : this._updateQueryStringParameter(newLocation, this._autoOpenIdLoginParamName, true);
        if (location.hash) {
            newLocation = newLocation + location.hash;
        }
        return newLocation;
    },

    redirectToOpenIdAuthorizeEndpoint: function (providerCode) {
        const returnUrl = this.getRedirectUrlWithAutoOpenIdLogin(providerCode);
        const requestData = {
            returnUrl: returnUrl,
            providerCode: providerCode
        };
        const config = {
            url: Terrasoft.workspaceBaseUrl + "/ServiceModel/AuthService.svc/GetOpenIdAuthorizeUrl",
            jsonData: JSON.stringify(requestData),
            method: "POST",
            callback: function (options, success, response) {
                const responseObj = this._tryParse(response.responseText);
                if (!success) {
                    const msg = responseObj.Message;
                    if (msg) {
                        Terrasoft.showErrorMessage(msg);
                    }
                    return;
                }
                window.location.replace(responseObj);
            },
            scope: this
        };
        Terrasoft.AjaxProvider.request(config);
    },

    startSso: function (provider) {
        const config = {
            url: Terrasoft.workspaceBaseUrl + "/ServiceModel/AuthService.svc/Logout",
            method: "POST",
            callback: function () {
                this.redirectToOpenIdAuthorizeEndpoint(provider?.code);
            },
            scope: this
        };
        Terrasoft.AjaxProvider.request(config);
    }
});
