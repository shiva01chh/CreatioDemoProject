﻿Terrasoft.configuration.Structures["BaseDesktop"] = {innerHierarchyStack: ["BaseDesktop"]};
define('BaseDesktopStructure', ['BaseDesktopResources'], function(resources) {return {schemaUId:'c47278cc-0296-4e9e-8491-1cf4b943e95c',schemaCaption: "", parentSchemaName: "", packageName: "CrtUIv2", schemaName:'BaseDesktop',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("BaseDesktop", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "Main",
				"values": {
					"type": "crt.GridContainer",
					"rows": "64px",
					"columns": [
						"minmax(125px, 1fr)",
						"minmax(125px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)",
						"minmax(35px, 1fr)"
					],
					"gap": 8,
					"items": [],
					"sealed": true,
					"fitContent": false
				},
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});


