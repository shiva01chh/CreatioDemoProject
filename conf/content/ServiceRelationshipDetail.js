Terrasoft.configuration.Structures["ServiceRelationshipDetail"] = {innerHierarchyStack: ["ServiceRelationshipDetail"], structureParent: "BaseServiceModelRelationshipDetail"};
define('ServiceRelationshipDetailStructure', ['ServiceRelationshipDetailResources'], function(resources) {return {schemaUId:'7f270dc1-c3c6-4ea1-8430-a0f8337706bb',schemaCaption: "Detail schema - \"Connected services\" in the Services section", parentSchemaName: "BaseServiceModelRelationshipDetail", packageName: "ServiceModel", schemaName:'ServiceRelationshipDetail',parentSchemaUId:'d20907cd-a859-435d-a2ea-c5c8d80c2b19',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceRelationshipDetail",
	function() {
		return {
			entitySchemaName: "VwServiceRelationship"
		};
	}
);


