Terrasoft.configuration.Structures["SsoSamlBase_FormPage"] = {innerHierarchyStack: ["SsoSamlBase_FormPage"], structureParent: "BasePageFreedomTemplate"};
define('SsoSamlBase_FormPageStructure', ['SsoSamlBase_FormPageResources'], function(resources) {return {schemaUId:'0979a9b2-a613-45c6-980e-327ce1b51b0c',schemaCaption: "Custom SAML settings form", parentSchemaName: "BasePageFreedomTemplate", packageName: "SsoSettings", schemaName:'SsoSamlBase_FormPage',parentSchemaUId:'ec5fd902-66ce-4139-a241-10ebd8addc40',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("SsoSamlBase_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MainHeaderTop",
				"values": {
					"wrap": "wrap",
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "small",
						"left": "none"
					},
					"direction": "row",
					"alignItems": "stretch",
					"gap": "small"
				}
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "merge",
				"name": "SetRecordRightsButton",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "remove",
				"name": "CardToolsContainer"
			},
			{
				"operation": "remove",
				"name": "CardToggleContainer"
			},
			{
				"operation": "remove",
				"name": "MainHeaderBottom"
			},
			{
				"operation": "remove",
				"name": "MainContainer"
			},
			{
				"operation": "remove",
				"name": "CardContentWrapper"
			},
			{
				"operation": "insert",
				"name": "Button_TestSignIn",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_TestSignIn_caption)#",
					"color": "accent",
					"disabled": false,
					"size": "large",
					"iconPosition": "right-icon",
					"visible": "$IsChanged | crt.InvertBooleanValue",
					"icon": "open-button-icon",
					"clicked": {
						"request": "crt.TestSsoRequest"
					},
					"clickMode": "default"
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "MainContainer_total",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": false,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "small",
						"bottom": "none",
						"left": "small"
					},
					"stretch": true,
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "MainContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"stretch": true,
					"fitContent": true,
					"items": [],
					"visible": true,
					"color": "primary",
					"borderRadius": "medium",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap",
					"layoutConfig": {}
				},
				"parentName": "MainContainer_total",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SetIdentityStep_ExpansionPanel",
				"values": {
					"layoutConfig": {},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(SetIdentityStep_ExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": true,
					"titleWidth": "50",
					"padding": {
						"top": "small",
						"bottom": "none",
						"left": "medium",
						"right": "medium"
					},
					"visible": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_9utbflj",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "SetIdentityStep_ExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_v9ldmtn",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_9utbflj",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_TopExpansionPanel",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"fitContent": true
				},
				"parentName": "SetIdentityStep_ExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RegisterInIdentity_Label",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 3,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(RegisterInIdentity_Label)#)#",
					"labelType": "body",
					"labelThickness": "normal",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "GridContainer_TopExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GetMetadata_Button",
				"values": {
					"layoutConfig": {
						"column": 4,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Button",
					"caption": "#ResourceString(GetMetadata_Button_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"clicked": {
						"request": "crt.LoadSamlMetadataRequest"
					}
				},
				"parentName": "GridContainer_TopExpansionPanel",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SamlEndpoints_ExpansionPanel",
				"values": {
					"layoutConfig": {},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(SamlEndpoints_ExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": true,
					"titleWidth": "50",
					"padding": {
						"top": "none",
						"bottom": "none",
						"left": "medium",
						"right": "medium"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_rxre251",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "SamlEndpoints_ExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_28ur764",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_rxre251",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_t5t8p9y",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "SamlEndpoints_ExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SetSamlParams_Label",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(SetSamlParams_Label_caption)#)#",
					"labelType": "body",
					"labelThickness": "normal",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "GridContainer_t5t8p9y",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "PartnerIdentityName",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.PartnerIdentityName",
					"labelPosition": "auto",
					"control": "$PartnerIdentityName"
				},
				"parentName": "GridContainer_t5t8p9y",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SingleSignOnServiceUrl",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.SingleSignOnServiceUrl",
					"labelPosition": "auto",
					"control": "$SingleSignOnServiceUrl"
				},
				"parentName": "GridContainer_t5t8p9y",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "SingleLogoutServiceUrl",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.SingleLogoutServiceUrl",
					"labelPosition": "auto",
					"control": "$SingleLogoutServiceUrl"
				},
				"parentName": "GridContainer_t5t8p9y",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AdditionalParameters_ExpansionPanel",
				"values": {
					"layoutConfig": {},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(AdditionalParameters_ExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": true,
					"titleWidth": "50",
					"padding": {
						"top": "none",
						"bottom": "large",
						"left": "medium",
						"right": "medium"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridContainer_pnm1a55",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "AdditionalParameters_ExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_cxto3x2",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_pnm1a55",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_f07ddif",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": 0
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": []
				},
				"parentName": "AdditionalParameters_ExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DisplayName",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.DisplayName",
					"labelPosition": "auto",
					"control": "$DisplayName"
				},
				"parentName": "GridContainer_f07ddif",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "IsDefault",
				"values": {
					"type": "crt.Checkbox",
					"label": "$Resources.Strings.IsDefault",
					"labelPosition": "auto",
					"control": "$IsDefault"
				},
				"parentName": "AdditionalParameters_ExpansionPanel",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"Id": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.Id"
					}
				},
				"PartnerIdentityName": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.EntityID"
					},
					"validators": {
						"IsUrlValidator": {
							"type": "crt.StringUrlValidator"
						}
					}
				},
				"DisplayName": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.Name"
					}
				},
				"SingleLogoutServiceUrl": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.SingleLogoutServiceUrl"
					},
					"validators": {
						"IsUrlValidator": {
							"type": "crt.StringUrlValidator"
						}
					}
				},
				"SingleSignOnServiceUrl": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.SingleSignOnServiceUrl"
					},
					"validators": {
						"IsUrlValidator": {
							"type": "crt.StringUrlValidator"
						}
					}
				},
				"Code": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.Code"
					}
				},
				"IsDefault": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.IsDefault"
					}
				},
				"Type": {
					"modelConfig": {
						"path": "SsoSamlProviderDS.SsoSettingsTemplate"
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"SsoSamlProviderDS": {
					"type": "crt.EntityDataSource",
					"scope": "page",
					"config": {
						"entitySchemaName": "SsoSamlProvider"
					}
				}
			},
			"primaryDataSourceName": "SsoSamlProviderDS"
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

