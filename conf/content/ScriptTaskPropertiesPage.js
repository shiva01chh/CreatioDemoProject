﻿Terrasoft.configuration.Structures["ScriptTaskPropertiesPage"] = {innerHierarchyStack: ["ScriptTaskPropertiesPage"], structureParent: "BaseProcessSchemaElementPropertiesPage"};
define('ScriptTaskPropertiesPageStructure', ['ScriptTaskPropertiesPageResources'], function(resources) {return {schemaUId:'629a3ac9-0569-40df-930f-90a77c3b8179',schemaCaption: "ScriptTaskPropertiesPage", parentSchemaName: "BaseProcessSchemaElementPropertiesPage", packageName: "CrtProcessDesigner", schemaName:'ScriptTaskPropertiesPage',parentSchemaUId:'10a8efdc-8474-4a9a-b28f-ab96ec9bbe4a',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * ScriptTask edit page schema.
 * Parent: BaseProcessSchemaElementPropertiesPage
 */
define("ScriptTaskPropertiesPage", ["terrasoft", "ScriptTaskPropertiesPageResources", "SourceCodeEditEnums",
		"SourceCodeEdit"],
	function(Terrasoft, resources, sourceCodeEditEnums) {
		return {
			messages: {
				/**
				 * @message GetValue
				 * Receive source code edit value.
				 */
				"GetValue": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},

				/**
				 * @message GetSourceCodeData
				 * Returns source code edit data. Such as source code value, caption, language etc. For more
				 * information see GetSourceCodeData message in SourceCodeEditPage schema.
				 */
				"GetSourceCodeData": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},

				/**
				 * @message SourceCodeChanged
				 * Receive current source code edit value.
				 */
				"SourceCodeChanged": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				}
			},
			attributes: {

				/**
				 * Can user change script engine.
				 */
				"CanChangeUseFlowEngineScriptVersion": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: true
				},

				/**
				 * Body of ScriptTask element.
				 */
				"Body": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					isRequired: true,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Flag that indicates whether script task used for interpreted process.
				 */
				"UseFlowEngineScriptVersion": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					caption: resources.localizableStrings.UseFlowEngineScriptVersionCaption,
					onChange: "_onUseFlowEngineScriptVersionChanged"
				},

				/**
				 * Flag that indicates whether source code edit page loaded.
				 */
				"SourceCodeEditPageLoaded": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			modules: {
				"SctiptTaskBody": {
					"config": {
						"schemaName": "SourceCodeEditPage",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"showMask": true,
						"autoGeneratedContainerSuffix": "-script-task-body",
						"parameters": {
							"viewModelConfig": {
								"Tag": "Body"
							}
						}
					}
				}
			},
			methods: {

				/**
				 * @private
				 */
				_onUseFlowEngineScriptVersionChanged: function() {
					var scriptTask = this.get("ProcessElement");
					scriptTask.setPropertyValue("useFlowEngineScriptVersion", this.$UseFlowEngineScriptVersion);
					this.$CanChangeUseFlowEngineScriptVersion = this.isNoCompilationFeatureEnableConverter(
						this.$ProcessSchema.shouldBeCompiled());
				},

				/**
				 * @inheritdoc ProcessSchemaElementEditable#onElementDataLoad
				 * @overridden
				 */
				onElementDataLoad: function(scriptTask, callback, scope) {
					this.callParent([scriptTask, function() {
						this.set("Body", scriptTask.body);
						this.$ProcessSchema = scriptTask.parentSchema;
						this.set("UseFlowEngineScriptVersion", scriptTask.useFlowEngineScriptVersion);
						this.$AllowCompileMode = !scriptTask.parentSchema.isEmbedded &&
							scriptTask.parentSchema.shouldBeCompiled();
						this.initMessages();
						callback.call(scope);
					}, this]);
				},

				/**
				 * Subscribes to SourceCodeEditPage schema messages.
				 * @protected
				 * @virtual
				 */
				initMessages: function() {
					Terrasoft.each(this.modules, this.subscribeModuleEvents, this);
				},

				/**
				 * Subscribes for module events.
				 * @protected
				 * @param {Object} moduleConfig Module configuration.
				 * @param {String} moduleName Module name.
				 */
				subscribeModuleEvents: function(moduleConfig, moduleName) {
					var moduleId = this.getModuleId(moduleName);
					this.sandbox.subscribe("GetSourceCodeData", this.onGetSourceCodeData, this, [moduleId]);
					this.sandbox.subscribe("SourceCodeChanged", this.onSourceCodeChanged, this, [moduleId]);
				},

				/**
				 * GetSourceCodeData message handler. Returns source code data.
				 * @protected
				 * @virtual
				 * @return {Object} Source code edit data.
				 * @return {String} return.sourceCode Source code value.
				 * @return {String} return.dataItemMarker Source code edit marker value.
				 * @return {String} return.name Source code edit name.
				 * @return {String} return.caption Source code edit caption to display in expand mode.
				 * @return {String} return.language Source code edit language.
				 */
				onGetSourceCodeData: function() {
					this.set("SourceCodeEditPageLoaded", true);
					var scriptTask = this.get("ProcessElement");
					return {
						sourceCode: this.get("Body"),
						dataItemMarker: "ScriptTaskBody",
						name: scriptTask.name,
						caption: this.get("caption"),
						language: sourceCodeEditEnums.Language.CSHARP
					};
				},

				/**
				 * SourceCodeChanged message handler. Sets Body attribute value.
				 * @param {Object} data Current source code value.
				 * @param {String} data.tag Source code edit page tag.
				 * @param {String} data.sourceCode Source code value.
				 */
				onSourceCodeChanged: function(data) {
					this.set(data.tag, data.sourceCode);
				},

				/**
				 * Get source code edit value by publishing GetValue message. Value sets to Body attribute.
				 * @private
				 */
				getSourceCodeEditValue: function() {
					if (!this.get("SourceCodeEditPageLoaded")) {
						return;
					}
					Terrasoft.each(this.modules, function(moduleConfig, moduleName) {
						var moduleId = this.getModuleId(moduleName);
						var sandbox = this.sandbox;
						var sourceCodeData = sandbox.publish("GetValue", null, [moduleId]);
						this.set(sourceCodeData.tag, sourceCodeData.value);
					}, this);
				},

				/**
				 * Sets default value to 'Body' attribute.
				 * @private
				 */
				setBodyDefValue: function() {
					var body = this.get("Body");
					if (!this.Ext.isEmpty(body)) {
						return;
					}
					this.set("Body", "return true;");
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
				 * @overridden
				 */
				saveValues: function() {
					this.callParent(arguments);
					var scriptTask = this.get("ProcessElement");
					this.getSourceCodeEditValue();
					this.setBodyDefValue();
					scriptTask.setPropertyValue("body", this.get("Body"));
					scriptTask.setPropertyValue("useFlowEngineScriptVersion", this.get("UseFlowEngineScriptVersion"));
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "ControlGroup",
					"propertyName": "items",
					"name": "UseFlowEngineScriptVersionContainer",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24,
							"rowSpan": 1
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"classes": {
							"wrapClassName": ["not-compile", "checkbox-container"]
						},
						"visible": {
							"bindTo": "AllowCompileMode",
							"bindConfig": {
								"converter": "isNoCompilationFeatureEnableConverter"
							}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "UseFlowEngineScriptVersionContainer",
					"propertyName": "items",
					"name": "UseFlowEngineScriptVersion",
					"values": {
						"wrapClass": ["t-checkbox-control"],
						"tip": {
							"content": {
								"bindTo": "Resources.Strings.UseFlowEngineScriptVersionHint"
							}
						},
						"enabled": {
							"bindTo": "CanChangeUseFlowEngineScriptVersion"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "UseFlowEngineScriptVersionContainer",
					"propertyName": "items",
					"name": "UseFlowEngineScriptVersionInfoButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": Terrasoft.Resources.ProcessSchemaDesigner.Messages.DenyMakeProcessCompile,
						"controlConfig": {
							"visible": {
								"bindTo": "CanChangeUseFlowEngineScriptVersion",
								"bindConfig": {
									"converter": "invertBooleanValue"
								}
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "SctiptTaskBody",
					"parentName": "EditorsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE,
						"classes": {
							"wrapClassName": "script-task-body-container"
						},
						"items": []
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});


