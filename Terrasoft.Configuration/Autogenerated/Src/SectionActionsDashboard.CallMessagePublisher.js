﻿define("SectionActionsDashboard", ["SectionActionsDashboardResources", "CallMessagePublisherModule"],
	function(resources) {
		return {
			attributes: {},
			messages: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.ActionsDashboard#getExtendedConfig
				 * @overridden
				 */
				getExtendedConfig: function() {
					var config = this.callParent(arguments);
					var lczImages = resources.localizableImages;
					config.CallMessageTab = {
						"ImageSrc": this.Terrasoft.ImageUrlBuilder.getUrl(lczImages.CallMessageTabImage),
						"MarkerValue": "call-message-tab",
						"Align": this.Terrasoft.Align.RIGHT,
						"Visible": this.getExtraActionDashboadTabVisible(),
						"Tag": "Call"
					};
					return config;
				},

				/**
				 * @inheritdoc Terrasoft.BaseActionsDashboard#getAllowedTabs7x
				 * @override
				 */
				getAllowedTabs7x: function() {
					var result = this.callParent(arguments);
					result.push("CallMessageTab");
					return result;
				},

				/**
				 * @inheritdoc Terrasoft.ActionsDashboard#onGetRecordInfoForPublisher
				 * @overridden
				 */
				onGetRecordInfoForPublisher: function() {
					var info = this.callParent(arguments);
					info.additionalInfo.contact = this.getContactEntityParameterValue(info.relationSchemaName);
					return info;
				},

				/**
				 * Returns entity parameter value for contact.
				 * @return {String} Contact
				 */
				getContactEntityParameterValue: function(relationSchemaName) {
					var contact;
					if (relationSchemaName === "Contact" && this.get("EntitySchemaName") === relationSchemaName) {
						var id = this.getMasterEntityParameterValue("Id");
						var name = this.getMasterEntityParameterValue("Name");
						if (id && name) {
							contact = {value: id, displayValue: name};
						}
					} else {
						contact = this.getMasterEntityParameterValue("Contact");
					}
					return contact;
				},

				/**
				 * @inheritdoc Terrasoft.MessagePublisher.SectionActionsDashboard#getSectionPublishers
				 * @overridden
				 */
				getSectionPublishers: function() {
					var publishers = this.callParent(arguments);
					publishers.push("Call");
					return publishers;
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "CallMessageTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "CallMessageTabContainer",
					"parentName": "CallMessageTab",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["call-message-content"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "CallMessageModule",
					"parentName": "CallMessageTab",
					"propertyName": "items",
					"values": {
						"classes": {
							"wrapClassName": ["call-message-module", "message-module"]
						},
						"itemType": this.Terrasoft.ViewItemType.MODULE,
						"moduleName": "callMessagePublisherModule",
						"afterrender": {
							"bindTo": "onMessageModuleRendered"
						},
						"afterrerender": {
							"bindTo": "onMessageModuleRendered"
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
