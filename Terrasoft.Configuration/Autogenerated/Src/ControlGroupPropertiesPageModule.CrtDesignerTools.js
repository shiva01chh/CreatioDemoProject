﻿define("ControlGroupPropertiesPageModule", [
  	"ControlGroupPropertiesPageModuleResources",
	"PageItemPropertiesPageModule"
	],
	function(resources) {
		Ext.define("Terrasoft.ControlGroupPropertiesPageModule", {
			extend: "Terrasoft.PageItemPropertiesPageModule",

			messages: {
				/**
				 * @message GetControlGroupConfig
				 */
				"GetControlGroupConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message SaveControlGroupConfig
				 */
				"SaveControlGroupConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},

			/**
			 * @inheritdoc PageItemPropertiesPageModule#getItemConfigMessageName
			 * @override
			 */
			getItemConfigMessageName: "GetControlGroupConfig",

			/**
			 * @inheritdoc PageItemPropertiesPageModule#saveItemConfigMessageName
			 * @override
			 */
			saveItemConfigMessageName: "SaveControlGroupConfig",

			/**
			 * @inheritdoc BasePropertiesPageModule#getPageItemType
			 * @override
			 */
			getPageItemType: function() {
				return "controlGroup";
			},

			/**
			 * @inheritdoc PageItemPropertiesPageModule#getPageItemConfig
			 */
			getPageItemConfig: function() {
				const config = this.sandbox.publish(this.getItemConfigMessageName, null, [this.sandbox.id]);
				const customEvent = this.mixins.customEvent;
				const validationConfig = this.getValidationConfig(config);
				this.getCaptionStringModel(config, (caption) => {
					customEvent.publish("GetColumnConfig", {
						itemType: this.getPageItemType(),
						validationConfig,
						name: config.name,
						caption,
						disableNameEditing: !config.canEditName,
						allowEmptyCaption: true,
					}, this);
				}, this);
			},

			/**
			 * @inheritdoc PageItemPropertiesPageModule#getPropertiesPageTranslation
			 * @override
			 */
			getPropertiesPageTranslation: function() {
				const baseConfig = this.callParent(arguments);
				const config = {
					"caption": this.resources.localizableStrings.ControlGroupModalBoxHeader,
				};
				return Object.assign({}, baseConfig, config);
			},

			/**
			 * @override
			 */
			init: function() {
				this.initResources(resources);
				this.callParent(arguments);
			}

		});
		return Terrasoft.ControlGroupPropertiesPageModule;
	});
