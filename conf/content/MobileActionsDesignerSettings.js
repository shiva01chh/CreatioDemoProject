﻿Terrasoft.configuration.Structures["MobileActionsDesignerSettings"] = {innerHierarchyStack: ["MobileActionsDesignerSettings"], structureParent: "MobileBaseDesignerSettings"};
define("MobileActionsDesignerSettings", ["ext-base", "MobileBaseDesignerSettings"],
	function(Ext) {

		/**
		 * @class Terrasoft.configuration.MobileActionsDesignerSettings
		 * Класс настройки действий.
		 */
		var module = Ext.define("Terrasoft.configuration.MobileActionsDesignerSettings", {
			alternateClassName: "Terrasoft.MobileActionsDesignerSettings",
			extend: "Terrasoft.MobileBaseDesignerSettings",

			/**
			 * Массив конфигураций действий.
			 * @type {Object[]}
			 */
			items: null,

			/**
			 * @private
			 * In some modules there is no need to add default actions, cause this modules have own customized actions.
			 */
			notConfigurableModels: ["SocialMessage"],

			/**
			 * @private
			 */
			getDefaultItems: function() {
				if (Ext.Array.contains(this.notConfigurableModels, this.entitySchema.name)) {
					return [];
				}
				return [
					{
						name: "Terrasoft.configuration.action.ShareLink"
					},
					{
						name: "Terrasoft.ActionCopy"
					},
					{
						name: "Terrasoft.ActionDelete"
					}
				];
			},

			/**
			 * @inheritDoc Terrasoft.MobileBaseDesignerSettings#initializeDefaultValues
			 * @overridden
			 */
			initializeDefaultValues: function() {
				this.callParent(arguments);
				if (!this.items) {
					this.items = this.getDefaultItems();
				}
			},

			/**
			 * @inheritDoc Terrasoft.MobileBaseDesignerSettings#getSettingsConfig
			 * @overridden
			 */
			getSettingsConfig: function() {
				var settingsConfig = this.callParent(arguments);
				settingsConfig.items = this.items;
				return settingsConfig;
			}

		});
		return module;

	});


