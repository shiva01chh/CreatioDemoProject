Terrasoft.configuration.Structures["BasePageTemplate"] = {innerHierarchyStack: ["BasePageTemplate"], structureParent: "BaseTemplate"};
define('BasePageTemplateStructure', ['BasePageTemplateResources'], function(resources) {return {schemaUId:'1a29b42d-f75e-48e5-b227-0b29bf0e676d',schemaCaption: "Base page template", parentSchemaName: "BaseTemplate", packageName: "CrtUIv2", schemaName:'BasePageTemplate',parentSchemaUId:'c6a6e333-21c2-4f43-b6fb-cf4b0369b09f',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
// Parent: BaseTemplate
define("BasePageTemplate", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "SaveButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.Button",
					"clicked": {
						"request": "crt.SaveRecordRequest"
					},
					"color": "accent",
					"caption": "$Resources.Strings.SaveButton",
					"visible": "$IsChanged"
				}
			},
			{
				"operation": "insert",
				"name": "CancelButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.Button",
					"clicked": {
						"request": "crt.CancelRecordChangesRequest"
					},
					"caption":"$Resources.Strings.CancelButton",
					"visible": "$IsChanged"
				}
			},
			{
				"operation": "insert",
				"name": "CloseButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 2,
				"values": {
					"type": "crt.Button",
					"clicked": {
						"request": "crt.ClosePageRequest"
					},
					"color": "primary",
					"caption":"$Resources.Strings.CloseButton",
					"visible": "$IsChanged | crt.InvertBooleanValue"
				}
			},
			{
				"operation": "merge",
				"name": "MainHeader",
				"values": {
					"type": "crt.HeaderContainer",
					"borderRadius": "medium",
					"gap": "small",
					"padding": {
						"bottom": "large",
						"right": "large",
						"left": "large"
					}
				}
			},
			{
				"operation": "insert",
				"name": "CardToggleContainer",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.FlexContainer",
					"justifyContent": "end",
					"items": []
				}
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"IsChanged": {
					"value": false
				},
				"IsChangesTrackingEnabled": {
					"value": false
				},
				"CardState": {}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/
	};
});


