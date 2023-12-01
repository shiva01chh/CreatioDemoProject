﻿define("CenterNotificationSchema", [],
	function() {
		return {
			methods: {
				/**
				 * @inheritDoc Terrasoft.BaseViewModel#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					var isPortalUser = this.Terrasoft.CurrentUser.userType === this.Terrasoft.UserType.SSP;
					if (isPortalUser) {
						this.mixins.TitleNotificationUtilities.blinkIterator = 0;
						this.mixins.TitleNotificationUtilities.blinkInterval = 0;
					}
				},
				/**
				 * @inheritDoc Terrasoft.CenterNotificationSchema#initializeNotifications
				 * @overridden
				 */
				initializeNotifications: function() {
					var isPortalUser = this.Terrasoft.CurrentUser.userType === this.Terrasoft.UserType.SSP;
					if (isPortalUser) {
						return;
					}
					this.callParent(arguments);
				}
			}
		};
	});
