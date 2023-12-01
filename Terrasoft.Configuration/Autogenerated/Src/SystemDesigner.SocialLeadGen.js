 define("SystemDesigner", ["SystemDesignerResources"], function(resources) {
	return {
		attributes: {
			/**
			 * Flag that indicates feature "Tracking" enabled.
			 */
			"IsSocialLeadGenSectionEnabled": {
				dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			}
		},
		methods: {
			/**
			 * @inheritodoc SystemDesigner#setDefaultParameters
			 * @overridden
			 */
			setDefaultParameters: function() {
				this.callParent(arguments);
				var isEnabled = this.getIsFeatureEnabled("SocialLeadGenSection");
				this.$IsSocialLeadGenSectionEnabled = isEnabled;
			},

			/**
			 * Navigate to the Tracking settings.
			 * @private
			 */
			_navigateToSocialLeadGenSection: function() {
				const url = Terrasoft.workspaceBaseUrl + "/ClientApp/#/SocialLeadgen";
				window.open(url, "_blank");
			}

		},
		diff: [
			{
				"operation": "insert",
				"propertyName": "items",
				"parentName": "IntegrationTile",
				"name": "SocialLeadGenSection",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.SocialLeadGenLinkCaption"},
					"tag": "_navigateToSocialLeadGenSection",
					"click": "$invokeOperation",
					"visible": "$IsSocialLeadGenSectionEnabled"
				}
			}
		]
	};
});
