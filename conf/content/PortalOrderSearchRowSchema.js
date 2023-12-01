Terrasoft.configuration.Structures["PortalOrderSearchRowSchema"] = {innerHierarchyStack: ["PortalOrderSearchRowSchema"], structureParent: "BaseSearchRowSchema"};
define('PortalOrderSearchRowSchemaStructure', ['PortalOrderSearchRowSchemaResources'], function(resources) {return {schemaUId:'2a0da997-6665-42a0-8f13-3722dcf04036',schemaCaption: "PortalOrderSearchRowSchema", parentSchemaName: "BaseSearchRowSchema", packageName: "PRMOrder", schemaName:'PortalOrderSearchRowSchema',parentSchemaUId:'254c5d91-bad1-44be-a75e-1d511f816dc0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalOrderSearchRowSchema", [], function() {
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
				"name": "Currency",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


