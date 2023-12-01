Terrasoft.configuration.Structures["SSPConfItemInAccountDetail"] = {innerHierarchyStack: ["SSPConfItemInAccountDetail"], structureParent: "ConfItemInAccountDetail"};
define('SSPConfItemInAccountDetailStructure', ['SSPConfItemInAccountDetailResources'], function(resources) {return {schemaUId:'2932d08f-807e-49e2-a6f6-12946eda30df',schemaCaption: "Configuration items in Account at SSP", parentSchemaName: "ConfItemInAccountDetail", packageName: "PortalITILService", schemaName:'SSPConfItemInAccountDetail',parentSchemaUId:'e916d43c-ba4d-49de-b752-88dbf599140a',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("SSPConfItemInAccountDetail", [],
	function() {
		return {
			entitySchemaName: "ConfItemUser",
			methods: {
				getToolsVisible: function() {
					return false;
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


