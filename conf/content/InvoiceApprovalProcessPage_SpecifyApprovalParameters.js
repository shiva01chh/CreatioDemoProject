Terrasoft.configuration.Structures["InvoiceApprovalProcessPage_SpecifyApprovalParameters"] = {innerHierarchyStack: ["InvoiceApprovalProcessPage_SpecifyApprovalParameters"], structureParent: "BaseMiniPageTemplate"};
define('InvoiceApprovalProcessPage_SpecifyApprovalParametersStructure', ['InvoiceApprovalProcessPage_SpecifyApprovalParametersResources'], function(resources) {return {schemaUId:'68e0ed86-4039-44d0-b3b5-98eb8c89a0e4',schemaCaption: "Invoice approval process page_Specify approval parameters", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtOrderContractMgmtApp", schemaName:'InvoiceApprovalProcessPage_SpecifyApprovalParameters',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{"DelegationPermitted":{"dataValueTypeName":"Boolean","direction":2,"uId":"d9abd13b-a53c-3845-4887-451200a0f9e4","isRequired":false,"referenceSchemaName":null},"VisaOwner":{"dataValueTypeName":"Lookup","direction":2,"uId":"ecec4d4d-699b-f755-efc1-6184c5f6cb01","isRequired":true,"referenceSchemaName":"SysAdminUnit"},"ApprovalObjective":{"dataValueTypeName":"MediumText","direction":2,"uId":"02f32489-1243-f017-40f7-fcdaf8ca6a41","isRequired":false,"referenceSchemaName":null}},schemaDifferences:function(){

}};});
define("InvoiceApprovalProcessPage_SpecifyApprovalParameters", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "PageTitle"
			},
			{
				"operation": "remove",
				"name": "ContinueInOtherPageButton"
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"caption": "#ResourceString(CancelButton_caption)#",
					"color": "default",
					"size": "large",
					"iconPosition": "only-text",
					"clickMode": "default"
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
					"label": "$Resources.Strings.LookupAttribute_xrjjdvx",
					"labelPosition": "above",
					"control": "$LookupAttribute_xrjjdvx",
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
					"label": "$Resources.Strings.StringAttribute_oq7lgmd",
					"labelPosition": "above",
					"control": "$StringAttribute_oq7lgmd",
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
					"label": "$Resources.Strings.BooleanAttribute_8ctti7n",
					"labelPosition": "above",
					"control": "$BooleanAttribute_8ctti7n"
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
					"StringAttribute_oq7lgmd": {
						"modelConfig": {
							"path": "PageParameters.ApprovalObjective"
						}
					},
					"LookupAttribute_xrjjdvx": {
						"modelConfig": {
							"path": "PageParameters.VisaOwner"
						}
					},
					"BooleanAttribute_8ctti7n": {
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

