Terrasoft.configuration.Structures["BaseTemplate"] = {innerHierarchyStack: ["BaseTemplate"]};
define('BaseTemplateStructure', ['BaseTemplateResources'], function(resources) {return {schemaUId:'c6a6e333-21c2-4f43-b6fb-cf4b0369b09f',schemaCaption: "Base Template", parentSchemaName: "", packageName: "CrtUIv2", schemaName:'BaseTemplate',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
 define("BaseTemplate", /**SCHEMA_DEPS*/["css!CardSchemaViewModule"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "MainHeader",
				"values": {
					"type": "crt.HeaderContainer",
					"color": "primary",
					"padding": {
						"right": "large",
						"left": "large"
					},
					"fitContent": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ActionContainer",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": ["minmax(64px, 1fr)"],
					"color": "primary",
					"gap": "small",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ActionButtonsContainer",
				"parentName": "ActionContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"direction": "row",
					"wrap": "nowrap",
					"items": []
				}
			},
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


