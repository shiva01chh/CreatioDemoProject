Terrasoft.configuration.Structures["ServiceEngineerEditPage"] = {innerHierarchyStack: ["ServiceEngineerEditPage"], structureParent: "BaseModulePageV2"};
define('ServiceEngineerEditPageStructure', ['ServiceEngineerEditPageResources'], function(resources) {return {schemaUId:'77f07677-6107-467d-93c5-0973a21ce59b',schemaCaption: "Service Engineer Edit Page", parentSchemaName: "BaseModulePageV2", packageName: "CrtSLMITILService7x", schemaName:'ServiceEngineerEditPage',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceEngineerEditPage", [],
	function() {
		return {
			entitySchemaName: "ServiceEngineer",
			attributes: {
				"Engineer": {
					"lookupListConfig": {
						"hideActions": true
					}
				}
			}
		};
	});


