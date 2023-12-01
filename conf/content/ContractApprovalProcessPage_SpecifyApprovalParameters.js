Terrasoft.configuration.Structures["ContractApprovalProcessPage_SpecifyApprovalParameters"] = {innerHierarchyStack: ["ContractApprovalProcessPage_SpecifyApprovalParameters"], structureParent: "BaseMiniPageTemplate"};
define('ContractApprovalProcessPage_SpecifyApprovalParametersStructure', ['ContractApprovalProcessPage_SpecifyApprovalParametersResources'], function(resources) {return {schemaUId:'830b526e-8e33-402d-9943-ebc4e80dc8c5',schemaCaption: "Contract approval process page_Specify approval parameters", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtOrderContractMgmtApp", schemaName:'ContractApprovalProcessPage_SpecifyApprovalParameters',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{"ApprovalObjective":{"dataValueTypeName":"MediumText","direction":2,"uId":"ef771379-e607-36d0-2991-f97bda017264","isRequired":false,"referenceSchemaName":null},"VisaOwner":{"dataValueTypeName":"Lookup","direction":2,"uId":"f809c095-91f1-ea57-af6b-8ee6be963d62","isRequired":true,"referenceSchemaName":"SysAdminUnit"},"DelegationPermitted":{"dataValueTypeName":"Boolean","direction":2,"uId":"5821f4a1-f8b0-27e8-5884-5ccf400cc435","isRequired":false,"referenceSchemaName":null}},schemaDifferences:function(){

}};});
define("ContractApprovalProcessPage_SpecifyApprovalParameters", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "PageTitle"
			},
			{
				"operation": "merge",
				"name": "ContinueInOtherPageButton",
				"values": {
					"color": "default"
				}
			},
			{
				"operation": "insert",
				"name": "ApprovalLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(ApprovalLabel_caption)#)#",
					"labelType": "headline-1-small",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "VisaOwner",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_a4spklg",
					"labelPosition": "above",
					"control": "$LookupAttribute_a4spklg",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"mode": "List",
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
				"name": "ApprovalObjective",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.StringAttribute_zo62jy4",
					"labelPosition": "above",
					"control": "$StringAttribute_zo62jy4",
					"multiline": false
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "DelegationPermitted",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Checkbox",
					"label": "$Resources.Strings.BooleanAttribute_77nvkfh",
					"labelPosition": "right",
					"control": "$BooleanAttribute_77nvkfh",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LookupAttribute_a4spklg": {
						"modelConfig": {
							"path": "PageParameters.VisaOwner"
						}
					},
					"StringAttribute_zo62jy4": {
						"modelConfig": {
							"path": "PageParameters.ApprovalObjective"
						}
					},
					"BooleanAttribute_77nvkfh": {
						"modelConfig": {
							"path": "PageParameters.DelegationPermitted"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

