Terrasoft.configuration.Structures["CampaignLandingEntityLookupSection"] = {innerHierarchyStack: ["CampaignLandingEntityLookupSection"], structureParent: "LinkedEntitySchemaLookupSection"};
define('CampaignLandingEntityLookupSectionStructure', ['CampaignLandingEntityLookupSectionResources'], function(resources) {return {schemaUId:'bfabcf30-3a43-103d-c6a7-f4591e188bc6',schemaCaption: "CampaignLandingEntityLookupSection", parentSchemaName: "LinkedEntitySchemaLookupSection", packageName: "MarketingCommon", schemaName:'CampaignLandingEntityLookupSection',parentSchemaUId:'cead7a68-33d8-4818-8be4-a80ec8a1195a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CampaignLandingEntityLookupSection", [],
	function() {
		return {
			attributes: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#columnsFiltrationMethod
				 * @override
				 */
				columnsFiltrationMethod: function(column) {
					const dataValueType = column.dataValueType;
					var allowedTypes = [];
					if (this.columnName === "WebFormColumn") {
						allowedTypes = [
							Terrasoft.DataValueType.LOOKUP,
							Terrasoft.DataValueType.GUID
						];
					}
					if (this.columnName === "ContactColumn") {
						allowedTypes = [
							Terrasoft.DataValueType.LOOKUP
						];
					}
					return Ext.Array.contains(allowedTypes, dataValueType);
				},

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#updateColumnHandler
				 * @override
				 */
				updateColumnHandler: function(result, row, columnName) {
					row.set(columnName, result.leftExpressionColumnPath);
				},

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#getIsReadonlyColumn
				 * @override
				 */
				getIsReadonlyColumn: function(columnName) {
					return columnName === "ContactColumn" || columnName === "WebFormColumn";
				}
			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	});


