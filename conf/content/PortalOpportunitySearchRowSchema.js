Terrasoft.configuration.Structures["PortalOpportunitySearchRowSchema"] = {innerHierarchyStack: ["PortalOpportunitySearchRowSchema"], structureParent: "BaseSearchRowSchema"};
define('PortalOpportunitySearchRowSchemaStructure', ['PortalOpportunitySearchRowSchemaResources'], function(resources) {return {schemaUId:'9d88b2e2-3316-4a7b-bc8d-4bccd0b1c130',schemaCaption: "PortalOpportunitySearchRowSchema", parentSchemaName: "BaseSearchRowSchema", packageName: "PRMPortal", schemaName:'PortalOpportunitySearchRowSchema',parentSchemaUId:'254c5d91-bad1-44be-a75e-1d511f816dc0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalOpportunitySearchRowSchema", [], function() {
	return {
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
						"row": 2,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataContainer",
				"propertyName": "items",
				"name": "Stage",
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
				"name": "Owner",
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
				"name": "LeadType",
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
				"name": "DueDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 6
					}
				}
			},
		]/**SCHEMA_DIFF*/
	};
});


