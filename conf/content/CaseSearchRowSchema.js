Terrasoft.configuration.Structures["CaseSearchRowSchema"] = {innerHierarchyStack: ["CaseSearchRowSchemaGlobalSearch", "CaseSearchRowSchema"], structureParent: "BaseSearchRowSchema"};
define('CaseSearchRowSchemaGlobalSearchStructure', ['CaseSearchRowSchemaGlobalSearchResources'], function(resources) {return {schemaUId:'02c26eef-7377-4b30-ada1-08f6e0fafe23',schemaCaption: "CaseSearchRowSchema", parentSchemaName: "BaseSearchRowSchema", packageName: "SLMITILService", schemaName:'CaseSearchRowSchemaGlobalSearch',parentSchemaUId:'254c5d91-bad1-44be-a75e-1d511f816dc0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CaseSearchRowSchemaStructure', ['CaseSearchRowSchemaResources'], function(resources) {return {schemaUId:'c0439b3d-8574-4a79-bda6-0a2f52d38de0',schemaCaption: "CaseSearchRowSchema", parentSchemaName: "CaseSearchRowSchemaGlobalSearch", packageName: "SLMITILService", schemaName:'CaseSearchRowSchema',parentSchemaUId:'02c26eef-7377-4b30-ada1-08f6e0fafe23',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CaseSearchRowSchemaGlobalSearch",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CaseSearchRowSchemaGlobalSearchResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("CaseSearchRowSchemaGlobalSearch", [], function() {
	return {
		attributes: {
			"Client": {
				"caption": {"bindTo": "Resources.Strings.ClientColumnCaption"},
				"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
				"multiLookupColumns": ["Contact", "Account"]
			}
		},
		methods: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "EntitySchemaCaption"
			},
			{
				"operation": "merge",
				"name": "FoundColumnsContainerList",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "Subject",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 6
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "ServiceItem",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "Client",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "RegisteredOn",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 6
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "Status",
				"values": {
					"layout": {
						"column": 18,
						"row": 1,
						"colSpan": 6
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "Owner",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define("CaseSearchRowSchema", [], function() {
	return {
		attributes: {},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseSearchRowSchema#initAttributeValues
			 * @overridden
			 */
			initAttributeValues: function() {
				this.callParent(arguments);
				this._initSupportLevel();
			},

			/**
			 * @private
			 */
			_initSupportLevel: function () {
				var primaryColumnValue = this.get(this.primaryColumnName);
				if (!primaryColumnValue) {
					return;
				}
				var esq = this.Ext.create(Terrasoft.EntitySchemaQuery, {
					rootSchemaName: "Case"
				});
				esq.addColumn("SupportLevel");
				esq.enablePrimaryColumnFilter(primaryColumnValue);
				esq.execute(function (response) {
					if (response.success) {
						var caseItem = response.collection.first();
						this.set("SupportLevel", caseItem.get("SupportLevel"));
					}
				}, this);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "SupportLevel",
				"values": {
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 6
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


