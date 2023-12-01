﻿Terrasoft.configuration.Structures["MLRecommendationModelPage"] = {innerHierarchyStack: ["MLRecommendationModelPage"], structureParent: "MLModelPage"};
define('MLRecommendationModelPageStructure', ['MLRecommendationModelPageResources'], function(resources) {return {schemaUId:'b88db39d-a111-a491-65fb-26af91d58880',schemaCaption: "ML recommendation model page", parentSchemaName: "MLModelPage", packageName: "ML", schemaName:'MLRecommendationModelPage',parentSchemaUId:'e198e03f-20ef-49bf-9167-0faa7be3f977',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("MLRecommendationModelPage", ["ConfigurationEnums", "css!MLModelPageCSS", "MLListPredictionMixin"],
	function() {
		return {
			entitySchemaName: "MLModel",
			attributes: {
				"BatchPredictionEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"TargetColumnEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				},

				/**
				 * Virtual column for CFUserColumnPath.
				 */
				"CFUserColumn": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "getVirtualColumnPathCaption"}
				},

				/**
				 * Virtual column for CFItemColumnPath.
				 */
				"CFItemColumn": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "getVirtualColumnPathCaption"}
				},

				/**
				 * Virtual column for CFInteractionValueColumnPath.
				 */
				"CFInteractionValueColumn": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "getCFInteractionValueColumnCaption"}
				},
				/**
				 * Lookup selection column for ListPredictResultSchemaUId.
				 */
				"ListPredictResultSchema": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Virtual column for ListPredictResultSchemaUId.
				 */
				"ListPredictResultSchemaUId": {
					"dependencies": [
						{
							"columns": ["ListPredictResultSchema"],
							"methodName": "onListPredictionResultSchemaChanged"
						}
					]
				},

				/**
				 * Lookup selection column for ListPredictResultSubjectColumn.
				 */
				"ListPredictResultSubjectColumnLookup": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "Resources.Strings.CFResultUserCaption"}
				},

				/**
				 * Virtual column for ListPredictResultSubjectColumn.
				 */
				"ListPredictResultSubjectColumn": {
					"dependencies": [
						{
							"columns": ["ListPredictResultSubjectColumnLookup"],
							"methodName": "onListPredictionResultColumnLookupAttributeChange"
						}
					]
				},

				/**
				 * Lookup selection column ListPredictResultItemColumn.
				 */
				"ListPredictResultObjectColumnLookup": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": {"bindTo": "Resources.Strings.CFResultItemCaption"}
				},

				/**
				 * Virtual column for ListPredictResultItemColumn.
				 */
				"ListPredictResultObjectColumn": {
					"dependencies": [
						{
							"columns": ["ListPredictResultObjectColumnLookup"],
							"methodName": "onListPredictionResultColumnLookupAttributeChange"
						}
					]
				},

				/**
				 * Lookup selection column for ListPredictResultValueColumn.
				 */
				"ListPredictResultValueColumnLookup": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Virtual column for ListPredictResultValueColumn.
				 */
				"ListPredictResultValueColumn": {
					"dependencies": [
						{
							"columns": ["ListPredictResultValueColumnLookup"],
							"methodName": "onListPredictionResultColumnLookupAttributeChange"
						}
					]
				},

				/**
				 * Lookup selection column for ListPredictResultModelColumn.
				 */
				"ListPredictResultModelColumnLookup": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Virtual column for ListPredictResultModelColumn.
				 */
				"ListPredictResultModelColumn": {
					"dependencies": [
						{
							"columns": ["ListPredictResultModelColumnLookup"],
							"methodName": "onListPredictionResultColumnLookupAttributeChange"
						}
					]
				},

				/**
				 * Lookup selection column for ListPredictResultTimestampColumn.
				 */
				"ListPredictResultDateColumnLookup": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Virtual column for ListPredictResultTimestampColumn
				 */
				"ListPredictResultTimestampColumn": {
					"dependencies": [
						{
							"columns": ["ListPredictResultDateColumnLookup"],
							"methodName": "onListPredictionResultColumnLookupAttributeChange"
						}
					]
				},

				/**
				 * Indicates load state of list prediction result schema.
				 */
				"ListPredictResultSchemaInitialized": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Search config for list predict subject column autocompletion.
				 */
				"ListPredictSubjectColumnSearchConfig": {
					"dataValueType": Terrasoft.DataValueType.OBJECT,
					"value": {
						"columnPathAttribute": "CFUserColumnPath"
					}
				},

				/**
				 * Search config for list predict object column autocompletion.
				 */
				"ListPredictObjectColumnSearchConfig": {
					"dataValueType": Terrasoft.DataValueType.OBJECT,
					"value": {
						"columnPathAttribute": "CFItemColumnPath"
					}
				}
			},
			mixins: {
				MLListPredictionMixin: "Terrasoft.MLListPredictionMixin"
			},
			methods: {

				getTrainColumnsSelectionModuleConfig: function() {
					return {};
				},

				/**
				 * Loads captions for CF columns paths.
				 * @private
				 */
				_initializeCFColumnCaptions: function() {
					if (Ext.isEmpty(this.$RootSchema)) {
						return;
					}
					const schemaName = this.$RootSchema.name;
					const serviceParameters = [
						{
							schemaName: schemaName,
							columnPath: this.$CFUserColumnPath,
							key: "CFUserColumn"
						},
						{
							schemaName: schemaName,
							columnPath: this.$CFItemColumnPath,
							key: "CFItemColumn"
						},
						{
							schemaName: schemaName,
							columnPath: this.$CFInteractionValueColumnPath,
							key: "CFInteractionValueColumn"
						}
					];
					this.getColumnPathCaption(this.Ext.JSON.encode(serviceParameters), function(captionConfigs) {
						Terrasoft.each(captionConfigs, function(captionConfig) {
							this.set(captionConfig.key, captionConfig.columnCaption);
						}, this);
					}, this);
				},

				/**
				 * @inheritDoc
				 * @overriden
				 */
				initializeAdditionalSchemas: function() {
					this.initializeListPredictionResultSchema();
				},

				onEntityInitialized: function() {
					this.callParent(arguments);
					this.initializeListPredictionResultSchemaColumns(function() {
						this._initializeListPredictionResultColumns();
						this._initializeCFColumnCaptions();
					}, this);
				},

				columnChanged: function() {
					this._updateTrainButtonConfig();
				},

				/**
				 * Returns caption of CF column.
				 * @return {String}
				 */
				getCFColumnCaption: function(columnName) {
					return this.getEntityColumnCaption(columnName + "Path");
				},

				/**
				 * Returns caption of CFInteractionValueColumn.
				 * @return {String}
				 */
				getCFInteractionValueColumnCaption: function() {
					return this.getEntityColumnCaption("CFInteractionValueColumnPath");
				},

				/**
				 * Returns hint of CFInteractionValueColumn.
				 * @return {String}
				 */
				getCFInteractionValueColumnHint: function() {
					return this.get("Resources.Strings.CFInteractionValueColumnHint");
				},

				/**
				 * Returns RootSchema column caption depending on problem type.
				 * @return {String}
				 */
				getRootSchemaCaption: function() {
					return this.get("Resources.Strings.CFRootSchemaCaption");
				},

				/**
				 * Returns RootSchema column hint depending on problem type.
				 * @return {String}
				 */
				getRootSchemaHint: function() {
					return this.get("Resources.Strings.CFRootSchemaHint");
				},

				/**
				 * Returns Target expression group caption.
				 * @return {String}
				 */
				getTargetColumnGroupCaption: function() {
					return this.get("Resources.Strings.TargetColumnGroup_Filters_Caption");
				},

				/**
				 * Returns Target expression group tip content.
				 * @return {String}
				 */
				getTargetColumnGroupInfoButtonContent: function() {
					return this.get("Resources.Strings.TargetColumnGroupInfoButton_Filters_Content");
				},

				/**
				 * @inheritDoc
				 * @overriden
				 */
				getColumnSelectionModulesSandboxTags: function() {
					return [];
				}
			},
			diff: [
				{
					"name": "MLExplanationContainer",
					"operation": "remove"
				},
				{
					"name": "TargetColumnGroup",
					"operation": "remove"
				},
				{
					"name": "PredictedResultColumnGroup",
					"operation": "remove"
				},
				{
					"operation": "remove",
					"name": "TrainingQueryColumnSelectionModule"
				},
				{
					"name": "CFUserColumn",
					"parentName": "ProfileContainer",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.SHORT_TEXT,
						"enabled": {"bindTo": "isAddMode"}
					}
				},
				{
					"name": "CFItemColumn",
					"parentName": "ProfileContainer",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.SHORT_TEXT,
						"enabled": {"bindTo": "isAddMode"}
					}
				},
				{
					"name": "CFInteractionValueColumn",
					"parentName": "ProfileContainer",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.SHORT_TEXT,
						"tip": {
							"content": {"bindTo": "getCFInteractionValueColumnHint"}
						},
						"enabled": {"bindTo": "isAddMode"}
					}
				},
				{
					"name": "CFAcademyUrl",
					"operation": "insert",
					"parentName": "FaqUrls",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"classes": {
							"textClass": ["faq-button", "base-edit-link"]
						},
						"click": {"bindTo": "onFaqClick"},
						"caption": "$Resources.Strings.RecommendationAcademyCaption",
						"tag": {"contextHelpId": 2077}
					}
				},
				{
					"name": "FactorsCountsEdit",
					"parentName": "AdvancedModelParametersGroup",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"bindTo": "FactorsCounts",
						"tip": {
							"content": "$Resources.Strings.ParametersAutofittingTipContent"
						}
					}
				},
				{
					"name": "RegularizationValuesEdit",
					"parentName": "AdvancedModelParametersGroup",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"bindTo": "RegularizationValues",
						"tip": {
							"content": "$Resources.Strings.ParametersAutofittingTipContent"
						}
					}
				},
				{
					"name": "CFResultSavingGroup",
					"parentName": "ModelSettingsTab",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {
							"bindTo": "Resources.Strings.CFResultGroupCaption"
						},
						"tools": [],
						"items": [],
						"controlConfig": {}
					}
				},
				{
					"name": "CFResultSavingGridLayout",
					"parentName": "CFResultSavingGroup",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"name": "ListPredictResultSchema",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareRootSchemaList"
							}
						},
						"bindTo": "ListPredictResultSchema",
						"caption": {
							"bindTo": "Resources.Strings.CFResultSchemaCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM
					}
				},
				{
					"name": "ListPredictResultSubjectColumnLookup",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						},
						"bindTo": "ListPredictResultSubjectColumnLookup",
						"caption": {
							"bindTo": "Resources.Strings.CFResultUserCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareListPredictionSchemaColumnLookupList"
							}
						},
						"isRequired": {
							"bindTo": "ListPredictResultSchema",
							"bindConfig": {
								"converter": "setListPredictionResultSubjectColumnRequired"
							}
						}
					}
				},
				{
					"name": "ListPredictResultObjectColumnLookup",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"bindTo": "ListPredictResultObjectColumnLookup",
						"caption": {
							"bindTo": "Resources.Strings.CFResultItemCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareListPredictionSchemaColumnLookupList"
							}
						},
						"isRequired": {
							"bindTo": "ListPredictResultSchema",
							"bindConfig": {
								"converter": "setListPredictionResultObjectColumnRequired"
							}
						}
					}
				},
				{
					"name": "ListPredictResultValueColumnLookup",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12
						},
						"bindTo": "ListPredictResultValueColumnLookup",
						"caption": {
							"bindTo": "Resources.Strings.CFResultValueCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareListPredictionSchemaColumnLookupList"
							}
						}
					}
				},
				{
					"name": "ListPredictResultModelColumnLookup",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12
						},
						"bindTo": "ListPredictResultModelColumnLookup",
						"caption": {
							"bindTo": "Resources.Strings.CFResultModelCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareListPredictionSchemaColumnLookupList"
							}
						}
					}
				},
				{
					"name": "ListPredictResultDateColumnLookup",
					"parentName": "CFResultSavingGridLayout",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 12
						},
						"bindTo": "ListPredictResultDateColumnLookup",
						"caption": {
							"bindTo": "Resources.Strings.CFResultTimestampCaption"
						},
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareListPredictionSchemaColumnLookupList"
							}
						}
					}
				}
			]
		};
	});


