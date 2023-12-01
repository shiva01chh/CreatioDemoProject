Terrasoft.configuration.Structures["PortalMktgActivitySearchRowSchema"] = {innerHierarchyStack: ["PortalMktgActivitySearchRowSchema"], structureParent: "BaseSearchRowSchema"};
define('PortalMktgActivitySearchRowSchemaStructure', ['PortalMktgActivitySearchRowSchemaResources'], function(resources) {return {schemaUId:'30cc0f01-1d03-442d-ba98-cee678825aaa',schemaCaption: "PortalMktgActivitySearchRowSchema", parentSchemaName: "BaseSearchRowSchema", packageName: "MktgActivitiesPortal", schemaName:'PortalMktgActivitySearchRowSchema',parentSchemaUId:'254c5d91-bad1-44be-a75e-1d511f816dc0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalMktgActivitySearchRowSchema", [], function() {
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
				"name": "Channel",
				"values": {
					"layout": {
						"column": 18,
						"row": 0,
						"colSpan": 6
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


