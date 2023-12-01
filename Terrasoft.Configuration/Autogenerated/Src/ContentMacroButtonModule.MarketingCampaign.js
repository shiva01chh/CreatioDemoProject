 define("ContentMacroButtonModule", [], function() {
	return {
		attributes: {

			/**
			 * Content item config.
			 */
			Config: {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Name of property to work with.
			 */
			PropertyName: {
				dataValueType: Terrasoft.core.enums.DataValueType.STRING,
				type: Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
				value: ""
			}
		},
		messages: {

			/**
			 * @message OpenMacrosDialog
			 */
			OpenMacrosDialog: {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdateContentItemConfig.
			 * Sets actual content item config.
			 */
			UpdateContentItemConfig: {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message ContentItemConfigChanged.
			 * Actualize current config.
			 */
			ContentItemConfigChanged: {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.BIDIRECTIONAL
			},

			/**
			 * @message GetActualContentItemConfig.
			 * Returns actual item config.
			 */
			GetActualContentItemConfig: {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		methods: {

			/**
			 * @private
			 */
			_onMacroSelected: function(column) {
				if (!column) {
					return;
				}
				var macroValue = Ext.String.format("[#{0}#]", column.leftExpressionColumnPath);
				var propertyName = this.$PropertyName;
				var config =  this.sandbox.publish("GetActualContentItemConfig", null, ["ItemPanel"]);
				config[propertyName] = macroValue;
				var diff = {};
				diff[propertyName] = macroValue;
				var updateConfig = {
					config: diff,
					stylesFilter: null,
					propertyName: propertyName
				};
				this.sandbox.publish("UpdateContentItemConfig", updateConfig, ["PropertyModule"]);
				this.sandbox.publish("ContentItemConfigChanged", config, ["PropertiesPage"]);
			},

			/**
			 * Handler on macro button click. Fires message into content builder.
			 * @protected
			 */
			onMacroButtonClick: function() {
				var messageConfig = {
					macroSelectedHandler: this._onMacroSelected.bind(this)
				};
				this.sandbox.publish("OpenMacrosDialog", messageConfig);
			}
		},
		diff: [{
				"operation": "insert",
				"name": "MacrosButtonLayout",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"wrapClass": ["macro-button-layout"]
				}
			},
			{
				"operation": "insert",
				"name": "MacrosButton",
				"parentName": "MacroButtonLayout",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"click": "$onMacroButtonClick",
					"imageConfig": "$Resources.Images.MacrosIcon"
				}
			}]
	};
});
