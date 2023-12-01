﻿Terrasoft.configuration.Structures["PageWithRightAreaAndTabsTemplate"] = {innerHierarchyStack: ["PageWithRightAreaAndTabsTemplate"], structureParent: "BasePageTemplate"};
define('PageWithRightAreaAndTabsTemplateStructure', ['PageWithRightAreaAndTabsTemplateResources'], function(resources) {return {schemaUId:'98ca84c1-5f6a-4a55-9c3f-d668ce12378c',schemaCaption: "Tabbed page with right area", parentSchemaName: "BasePageTemplate", packageName: "CrtUIv2", schemaName:'PageWithRightAreaAndTabsTemplate',parentSchemaUId:'1a29b42d-f75e-48e5-b227-0b29bf0e676d',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("PageWithRightAreaAndTabsTemplate", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "CardContentWrapper",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(64px, 1fr)",
						"298px"
					],
					"rows": "1fr",
					"gap": {
						"columnGap": "small",
						"rowGap": "small"
					},
					"stretch": true,
					"fitContent": true,
					"items": []
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CardContentContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"stretch": true,
					"items": []
				},
				"parentName": "CardContentWrapper",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Tabs",
				"values": {
					"layoutConfig": {
						"basis": "100%"
					},
					"type": "crt.TabPanel",
					"items": []
				},
				"parentName": "CardContentContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GeneralInfoTab",
				"values": {
					"caption": "#ResourceString(GeneralInfoTab_caption)#",
					"type": "crt.GridContainer",
					"rows": "minmax(32px, max-content)",
					"columns": [
						"minmax(64px, 1fr)",
						"minmax(64px, 1fr)"
					],
					"gap": {
						"columnGap": "large"
					},
					"items": []
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RightModulesContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"items": []
				},
				"parentName": "CardContentWrapper",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RightAreaProfileContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": "minmax(64px, 1fr)",
					"gap": {
						"columnGap": "large"
					},
					"padding": {
						"top": "large",
						"right": "large",
						"bottom": "large",
						"left": "large"
					},
					"layoutConfig": {
						"basis": "fit-content"
					},
					"color": "primary",
					"borderRadius": "medium",
					"items": []
				},
				"parentName": "RightModulesContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RightAreaContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(35px, 1fr)"
					],
					"gap": {
						"columnGap": "large"
					},
					"padding": {
						"top": "large",
						"right": "large",
						"bottom": "large",
						"left": "large"
					},
					"layoutConfig": {
						"basis": "fit-content"
					},
					"color": "primary",
					"borderRadius": "medium",
					"stretch": true,
					"items": []
				},
				"parentName": "RightModulesContainer",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});


