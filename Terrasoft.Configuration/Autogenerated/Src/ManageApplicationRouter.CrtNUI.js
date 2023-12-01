define("ManageApplicationRouter", ["NavigationHelper"], function() {
	Ext.define("Terrasoft.configuration.mixins.ManageApplicationRouter", {
		alternateClassName: "Terrasoft.ManageApplicationRouter",

		almPortalUrl: '',
		useNewApplicationManagement: false,

		init: function(callback, scope) {
			if (Terrasoft.CurrentUser.userType === Terrasoft.UserType.SSP) {
				this.Ext.callback(callback, scope || this);
				return;
			}
			Terrasoft.SysSettings.querySysSettings(["UseNewApplicationManagement", "AlmPortalEnvironmentManagementUrl"],
				(sysSettings) => {
					this.useNewApplicationManagement = sysSettings?.UseNewApplicationManagement;
					this.almPortalUrl = sysSettings?.AlmPortalEnvironmentManagementUrl;
					Ext.callback(callback, scope);
			}, this);
		},

		openUrl: function (url) {
			const navigationHelper = this.Ext.create("Terrasoft.NavigationHelper", {
				Ext: this.Ext,
				sandbox: this.sandbox
			});
			const navigationConfig = {
				target: 'Url',
				options: {
					'url': url,
					'newTab': true,
					'newTabId': 'ApplicationManagement',
				}
			};
			navigationHelper.navigateTo(navigationConfig);
		},

		openApplicationManagement: function() {
			let url = '';
			if (!Ext.isEmpty(this.almPortalUrl)) {
				const siteName = window.location.hostname.split('.')[0];
				const delimiter = this.almPortalUrl.endsWith('/') ? '' : '/';
				url = this.Ext.String.format("{0}{1}{2}", this.almPortalUrl, delimiter, siteName);
			} else {
				url = Terrasoft.workspaceBaseUrl + "/ClientApp/#/ApplicationManagement";
			}
			this.openUrl(url);
		},

		openInstaledApplications: function() {
			if (this.useNewApplicationManagement) {
				this.openApplicationManagement();
			} else {
				this.openSection("InstalledAppSection");
			}
		}
	});
	return Ext.create("Terrasoft.ManageApplicationRouter");
});
