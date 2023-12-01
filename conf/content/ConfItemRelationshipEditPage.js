Terrasoft.configuration.Structures["ConfItemRelationshipEditPage"] = {innerHierarchyStack: ["ConfItemRelationshipEditPage"], structureParent: "BaseServiceModelRelationshipEditPage"};
define('ConfItemRelationshipEditPageStructure', ['ConfItemRelationshipEditPageResources'], function(resources) {return {schemaUId:'ae138654-e6a1-4344-8e2c-b9bf466e0022',schemaCaption: "Object edit page - \"Connected configuration items\"", parentSchemaName: "BaseServiceModelRelationshipEditPage", packageName: "ServiceModel", schemaName:'ConfItemRelationshipEditPage',parentSchemaUId:'4eff7ada-ab9f-4197-a389-10bf4e308b2a',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemRelationshipEditPage", [],
	function() {
		return {
			entitySchemaName: "VwConfItemRelationship",
			attributes: {
				"ConfItemB": {
					"lookupListConfig": {
						"filter": function() {
							return this.getLookupFilter("ConfItemB", "ConfItemA");
						}
					}
				},
				"DependencyTypeFilterColumnName": {
					value: "ForConfItemConfItem"
				}
			}
		};
	});


