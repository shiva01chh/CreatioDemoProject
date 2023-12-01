﻿Terrasoft.configuration.Structures["IndicatorDesigner"] = {innerHierarchyStack: ["IndicatorDesigner"], structureParent: "BaseAggregationWidgetDesigner"};
define('IndicatorDesignerStructure', ['IndicatorDesignerResources'], function(resources) {return {schemaUId:'f8a522bf-4c2f-4c42-9808-fabf7e5dd788',schemaCaption: "Metric designer", parentSchemaName: "BaseAggregationWidgetDesigner", packageName: "CrtPlatform7x", schemaName:'IndicatorDesigner',parentSchemaUId:'546df09a-8caa-4348-8b0d-ecbbc99f3e1e',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("IndicatorDesigner", ["terrasoft", "IndicatorDesignerResources"],
	function(Terrasoft, resources) {
		var localizableStrings = resources.localizableStrings;
		return {
			messages: {

				/**
				 * ######## ## ######### ### ######### ########## ############# ###### ##########.
				 */
				"GetIndicatorConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * ########## ######### ### ######### ##########.
				 */
				"GenerateIndicator": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}

			},
			attributes: {
				/**
				 * ######### #######.
				 */
				caption: {
					value: localizableStrings.NewWidget
				},

				/**
				 * ##### ##########.
				 */
				style: {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true,
					value: Terrasoft.DashboardEnums.WidgetColor["widget-blue"]
				},

				/**
				 * ##### ##########.
				 */
				fontStyle: {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true,
					value: {
						value: "default-indicator-font-size",
						displayValue: localizableStrings.FontStyleDefault
					}
				},

				/**
				 * ######### #######.
				 */
				formatCaption: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				
				/**
				 * @inheritdoc Terrasoft.BaseAggregationWidgetDesigner#format
				 * @override
				 */
				format: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: false,
					value: {
						"textDecorator": "{0}",
						"thousandSeparator": Terrasoft.Resources.CultureSettings.thousandSeparator,
						"type": Terrasoft.DataValueType.FLOAT,
						"dateFormat": Terrasoft.Resources.CultureSettings.dateFormat
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseAggregationWidgetDesigner#FormatValueSettingsVisible
				 * @override
				 */
				FormatValueSettingsVisible: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: true
				}

			},
			methods: {

				/**
				 * ########## ######## ######### ######### ######## ###### #######.
				 * @protected
				 * @virtual
				 * @return {String} ########## ######## ######### ######### ######## ###### #######.
				 */
				getWidgetConfigMessage: function() {
					return "GetIndicatorConfig";
				},

				/**
				 * ########## ######## ######### ########## #######.
				 * @protected
				 * @virtual
				 * @return {String} ########## ######## ######### ########## #######.
				 */
				getWidgetRefreshMessage: function() {
					return "GenerateIndicator";
				},

				/**
				 * ########## ###### ########### ####### ###### ####### # ###### ######### #######.
				 * @protected
				 * @virtual
				 * @return {Object} ########## ###### ########### ####### ###### ####### # ###### ######### #######.
				 */
				getWidgetModulePropertiesTranslator: function() {
					var widgetModulePropertiesTranslator = {
						aggregationColumn: "columnName",
						style: "style",
						fontStyle: "fontStyle"
					};
					return Ext.apply(this.callParent(arguments), widgetModulePropertiesTranslator);
				},

				/**
				 * ########## ######## ###### #######.
				 * @protected
				 * @virtual
				 * @return {String} ########## ######## ###### #######.
				 */
				getWidgetModuleName: function() {
					return "IndicatorModule";
				},

				/**
				 * @inheritdoc Terrasoft.BaseWidgetDesigner#setAttributeDisplayValue
				 * ############ ######## ### ####### #####.
				 * @protected
				 * @overridden
				 */
				setAttributeDisplayValue: function(propertyName, propertyValue) {
					switch (propertyName) {
						case "style":
							propertyValue = this.getStyleLookupValue(propertyValue);
							break;
						case "fontStyle":
							propertyValue = this.getFontStyleLookupValue(propertyValue);
							break;
						default:
							this.callParent(arguments);
							return;
					}
					this.set(propertyName, propertyValue);
				},

				/**
				 * ########## ###### ######## #####.
				 * @protected
				 * @virtual
				 * @param {String} styleValue ######## #####.
				 * @return {Object} ########## ###### ######## #####.
				 */
				getStyleLookupValue: function(styleValue) {
					var styleDefaultConfig = this.getStyleDefaultConfig();
					return styleDefaultConfig[styleValue];
				},

				/**
				 * ########## ###### ######## ##### #######.
				 * @protected
				 * @virtual
				 * @param {String} fontStyleValue ######## ##### #######.
				 * @return {Object} ########## ###### ######## ##### #######.
				 */
				getFontStyleLookupValue: function(fontStyleValue) {
					var fontStyleDefaultConfig = this.getFontStyleDefaultConfig();
					return fontStyleDefaultConfig[fontStyleValue];
				},

				/**
				 * ########## ###### ######.
				 * @protected
				 * @virtual
				 * @return {Object} ########## ###### ######.
				 */
				getStyleDefaultConfig: function() {
					return Terrasoft.DashboardEnums.WidgetColor;
				},

				/**
				 * ######### ######### ######.
				 * @protected
				 * @virtual
				 * @param {String} filter ###### ##########.
				 * @param {Terrasoft.Collection} list ######.
				 */
				prepareStyleList: function(filter, list) {
					if (list === null) {
						return;
					}
					list.clear();
					list.loadAll(this.getStyleDefaultConfig());
				},

				/**
				 * ########## ###### ###### ########.
				 * @protected
				 * @virtual
				 * @return {Object} ########## ###### ###### ########.
				 */
				getFontStyleDefaultConfig: function() {
					var fontStyleDefaultConfig = {
						"default-indicator-font-size": {
							value: "default-indicator-font-size",
							displayValue: this.get("Resources.Strings.FontStyleDefault")
						},
						"big-indicator-font-size": {
							value: "big-indicator-font-size",
							displayValue: this.get("Resources.Strings.FontStyleBig")
						}
					};
					return fontStyleDefaultConfig;
				},

				/**
				 * ######### ######### ###### ########.
				 * @protected
				 * @virtual
				 * @param {String} filter ###### ##########.
				 * @param {Terrasoft.Collection} list ######.
				 */
				prepareFontStyleList: function(filter, list) {
					if (list === null) {
						return;
					}
					list.clear();
					list.loadAll(this.getFontStyleDefaultConfig());
				},

				/**
				 * @inheritdoc Terrasoft.BaseAggregationWidgetDesigner#getTextdecoratorConfig
				 * @override
				 */
				getTextdecoratorConfig: function() {
					var format = this.get("format");
					return {
						textDecorator: {
							dataValueType: Terrasoft.DataValueType.TEXT,
							caption: this.get("Resources.Strings.FormatTextLabel"),
							value: format.textDecorator,
							description: this.get("Resources.Strings.FormatTextDescription")
						}
					};
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "Style",
					"parentName": "FormatProperties",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"bindTo": "style",
						"labelConfig": {
							"visible": true,
							"caption": {
								"bindTo": "Resources.Strings.StyleLabel"
							}
						},
						"controlConfig": {
							"className": "Terrasoft.ComboBoxEdit",
							"prepareList": {
								"bindTo": "prepareStyleList"
							},
							"list": {
								"bindTo": "styleList"
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "FontStyle",
					"parentName": "FormatProperties",
					"propertyName": "items",
					"values": {
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"bindTo": "fontStyle",
						"labelConfig": {
							"visible": true,
							"caption": {
								"bindTo": "Resources.Strings.FontStyleLabel"
							}
						},
						"controlConfig": {
							"className": "Terrasoft.ComboBoxEdit",
							"prepareList": {
								"bindTo": "prepareFontStyleList"
							},
							"list": {
								"bindTo": "fontStyleList"
							}
						}
					}
				}
			]
		};
	});


