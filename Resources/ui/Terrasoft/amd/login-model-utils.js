define("login-model-utils", ["ext-base", "terrasoft"], function(Ext, Terrasoft) {
	const _openIdLogoutCookieName = "OpenIDLogout";
	const _returnUrlCode = "?ReturnUrl=";

	function _deleteDuplicateQueryStrings(url) {
		let resultUrl = "";
		url.split("&").forEach(function(element, index) {
			if (resultUrl.indexOf(element.split("=")[0]) !== -1) {
				return false;
			}
			if (index === 0) {
				resultUrl = resultUrl + element;
				return;
			}
			resultUrl = resultUrl + "&" + element;
		});
		return resultUrl;
	}
	
	Terrasoft.LoginModelUtils = {
		containsIgnoreCase: function(str, searchStr) {
			return str.toUpperCase().indexOf(searchStr.toUpperCase()) !== -1;
		},

		checkOpenIdUnauthorized: function () {
			const errorInfo = {};
			const isOpenIdUnauthorized = Terrasoft.SsoUtils.isOpenIdUnauthorized(errorInfo);
			if (isOpenIdUnauthorized && errorInfo.message) {
				Terrasoft.authenticationException = {
					"message": errorInfo.message
				};
				Ext.util.Cookies.clear(_openIdLogoutCookieName);
			}
		},

		getWindowQueryStringWithoutHash: function(windowLocation) {
			const encodedQueryString = windowLocation.search.replace(_returnUrlCode, "");
			const decodedQueryString = decodeURIComponent(encodedQueryString);
			return _deleteDuplicateQueryStrings(decodedQueryString);
		},

		setAuthenticationException: function(errorCode) {
			const authenticationException = Terrasoft.authenticationException;
			if (authenticationException) {
				return;
			}
			const authErrorExceptions = Terrasoft.AuthErrorExceptions || {};
			const message = authErrorExceptions[errorCode];
			if (message) {
				Terrasoft.authenticationException = {
					"message": message
				};
			}
		},

		tryShowAuthenticationErrorMsg: function(handler) {
			const authenticationException = Terrasoft.authenticationException;
			if (authenticationException) {
				Terrasoft.showMessage({
					caption: authenticationException.message,
					style: Terrasoft.MessageBoxStyles.BLUE,
					buttons: ["ok"],
					defaultButton: 0,
					handler: handler
				});
				return true;
			}
			return false;
		}
	};

	return Terrasoft.LoginModelUtils;
});
