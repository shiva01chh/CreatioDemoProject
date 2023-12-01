﻿Terrasoft.configuration.Structures["LeadClosing_MiniPage"] = {innerHierarchyStack: ["LeadClosing_MiniPage"], structureParent: "BaseMiniPageTemplate"};
define('LeadClosing_MiniPageStructure', ['LeadClosing_MiniPageResources'], function(resources) {return {schemaUId:'8a6b1c77-376a-4bc5-9adb-46e9bf2a7701',schemaCaption: "Lead closing mini page", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtLeadOppMgmtApp", schemaName:'LeadClosing_MiniPage',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("LeadClosing_MiniPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "PageTitle",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "insert",
				"name": "Title",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Title_caption)#)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadDisqualifyReason",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "#ResourceString(LeadDisqualifyReason_label)#",
					"labelPosition": "above",
					"control": "$LookupAttribute_hy6dk0k",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ClosingDetails",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.StringAttribute_sle16hm",
					"labelPosition": "above",
					"control": "$StringAttribute_sle16hm",
					"visible": true,
					"placeholder": "#ResourceString(ClosingDetails_placeholder)#",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"LookupAttribute_hy6dk0k": {
					"modelConfig": {
						"path": "LeadDS.LeadDisqualifyReason"
					}
				},
				"StringAttribute_sle16hm": {
					"modelConfig": {
						"path": "LeadDS.ClosingDetails"
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"LeadDS": {
					"type": "crt.EntityDataSource",
					"scope": "page",
					"config": {
						"entitySchemaName": "Lead"
					}
				}
			},
			"primaryDataSourceName": "LeadDS"
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

