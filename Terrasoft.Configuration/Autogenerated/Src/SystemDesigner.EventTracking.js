define("SystemDesigner", function() {
	return {
		methods: {

			/**
			 * Gets is event tracking visible.
			 * @returns {boolean} Returns true if EnableSiteEventTracking feature enable.
			 */
			getIsEventTrackingSetupVisible: function() {
				return this.getIsFeatureEnabled("EnableSiteEventTracking");
			},

			/**
			 * @inheritodoc SystemDesigner#getOperationRightsDecoupling
			 * @overridden
			 */
			getOperationRightsDecoupling: function() {
				var operationRights = this.callParent(arguments);
				operationRights.navigateToEventTracking = "CanManageEventTracking";
				return operationRights;
			},

			/**
			 * Navigates to "EventTracking" section.
			 * @private
			 */
			navigateToEventTracking: function() {
				if (this.get("CanManageEventTracking") === true) {
					this.sandbox.publish("PushHistoryState", {hash: "SectionModuleV2/SiteEventTypeSection"});
				} else {
					this.showPermissionsErrorMessage("CanManageEventTracking");
				}
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "IntegrationTile",
				"name": "EventTrackingSetup",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.SiteEventTypeCaption"},
					"tag": "navigateToEventTracking",
					"click": {"bindTo": "invokeOperation"},
					"visible": {"bindTo": "getIsEventTrackingSetupVisible"}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
