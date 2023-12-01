Terrasoft.configuration.Structures["PortalCaseSearchRowSchema"] = {innerHierarchyStack: ["PortalCaseSearchRowSchema"], structureParent: "BaseSearchRowSchema"};
define('PortalCaseSearchRowSchemaStructure', ['PortalCaseSearchRowSchemaResources'], function(resources) {return {schemaUId:'9ddf50c5-7af3-4984-828e-497b25064812',schemaCaption: "PortalCaseSearchRowSchema", parentSchemaName: "BaseSearchRowSchema", packageName: "CrtPortal7x", schemaName:'PortalCaseSearchRowSchema',parentSchemaUId:'254c5d91-bad1-44be-a75e-1d511f816dc0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalCaseSearchRowSchema", [], function() {
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
				"name": "Status",
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
				"name": "Subject",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 6
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


