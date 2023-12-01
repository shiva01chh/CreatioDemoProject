Terrasoft.configuration.Structures["BlankPageTemplate"] = {innerHierarchyStack: ["BlankPageTemplate"]};
define('BlankPageTemplateStructure', ['BlankPageTemplateResources'], function(resources) {return {schemaUId:'f691e828-0b36-42a7-898f-c337e9af67d0',schemaCaption: "Blank page", parentSchemaName: "", packageName: "CrtUIv2", schemaName:'BlankPageTemplate',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("BlankPageTemplate", /**SCHEMA_DEPS*/["css!CardSchemaViewModule"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "MainContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"stretch": true,
					"fitContent": false,
					"items": []
				}
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/
	};
});


