Terrasoft.configuration.Structures["ConfItemRelationshipDetail"] = {innerHierarchyStack: ["ConfItemRelationshipDetail"], structureParent: "BaseServiceModelRelationshipDetail"};
define('ConfItemRelationshipDetailStructure', ['ConfItemRelationshipDetailResources'], function(resources) {return {schemaUId:'c76ce9dd-0479-4a23-83bb-7634a2fe1556',schemaCaption: "\"Connected configuration items\" detail schema in the \"Configuration items\" section", parentSchemaName: "BaseServiceModelRelationshipDetail", packageName: "ServiceModel", schemaName:'ConfItemRelationshipDetail',parentSchemaUId:'d20907cd-a859-435d-a2ea-c5c8d80c2b19',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemRelationshipDetail", ["ConfigurationGrid", "ConfigurationGridGenerator", "ConfigurationGridUtilities"],
	function() {
		return {
			entitySchemaName: "VwConfItemRelationship"
		};
	});


