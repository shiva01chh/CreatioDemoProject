Terrasoft.configuration.Structures["ServiceRelationshipEditPage"] = {innerHierarchyStack: ["ServiceRelationshipEditPage"], structureParent: "BaseServiceModelRelationshipEditPage"};
define('ServiceRelationshipEditPageStructure', ['ServiceRelationshipEditPageResources'], function(resources) {return {schemaUId:'e5bba328-19e0-42df-b9db-4692f15fa923',schemaCaption: "\"Connected services\" entity edit page", parentSchemaName: "BaseServiceModelRelationshipEditPage", packageName: "ServiceModel", schemaName:'ServiceRelationshipEditPage',parentSchemaUId:'4eff7ada-ab9f-4197-a389-10bf4e308b2a',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceRelationshipEditPage", [],
	function() {
		return {
			entitySchemaName: "VwServiceRelationship",
			attributes: {
				"ServiceItemB": {
					"lookupListConfig": {
						"filter": function() {
							return this.getLookupFilter("ServiceItemB", "ServiceItemA");
						}
					}
				},
				"DependencyTypeFilterColumnName": {
					value: "ForServiceService"
				}
			}
		};
	});


