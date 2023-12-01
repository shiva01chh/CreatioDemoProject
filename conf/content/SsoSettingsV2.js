﻿Terrasoft.configuration.Structures["SsoSettingsV2"] = {innerHierarchyStack: ["SsoSettingsV2"], structureParent: "ListFreedomTemplate"};
define('SsoSettingsV2Structure', ['SsoSettingsV2Resources'], function(resources) {return {schemaUId:'07b649a3-f356-47bb-bce0-6728b6024e6e',schemaCaption: "SSO settings page (v. 2)", parentSchemaName: "ListFreedomTemplate", packageName: "SsoSettings", schemaName:'SsoSettingsV2',parentSchemaUId:'3f1f3f38-a0a4-4549-b895-249fb08f554a',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("SsoSettingsV2", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(sdk)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MainHeader",
				"values": {
					"padding": {
						"top": "medium",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"visible": true,
					"borderRadius": "none",
					"gap": "small"
				}
			},
			{
				"operation": "remove",
				"name": "AddButton"
			},
			{
				"operation": "remove",
				"name": "DataImportButton"
			},
			{
				"operation": "remove",
				"name": "MenuItem_ImportFromExel"
			},
			{
				"operation": "remove",
				"name": "OpenLandingDesigner"
			},
			{
				"operation": "remove",
				"name": "ActionButton"
			},
			{
				"operation": "remove",
				"name": "MenuItem_ExportToExel"
			},
			{
				"operation": "remove",
				"name": "MainContainer"
			},
			{
				"operation": "remove",
				"name": "SectionContentWrapper"
			},
			{
				"operation": "remove",
				"name": "DataTable"
			},
			{
				"operation": "insert",
				"name": "BackButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(BackButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"clicked": {
						"request": "crt.ClosePageRequest"
					},
					"clickMode": "default",
					"icon": "back-button-icon"
				},
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_main_external",
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
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap",
					"stretch": true
				},
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "MainFilterContainer",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "1fr",
					"gap": {
						"columnGap": "small",
						"rowGap": "none"
					},
					"items": [],
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "small",
						"bottom": "none",
						"left": "small"
					},
					"fitContent": true,
					"visible": true,
					"layoutConfig": {},
					"stretch": true
				},
				"parentName": "FlexContainer_main_external",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_main",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 9,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "medium",
					"padding": {
						"top": "none",
						"right": "medium",
						"bottom": "none",
						"left": "medium"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap",
					"stretch": true
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ExpansionPanel_SsoProviders",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ExpansionPanel_SsoProviders_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true,
					"stretch": false
				},
				"parentName": "FlexContainer_main",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_SsoProviders_Tools",
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
				"parentName": "ExpansionPanel_SsoProviders",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_SsoProviders_Tools",
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
				"parentName": "GridContainer_SsoProviders_Tools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AddButton",
				"values": {
					"type": "crt.Button",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"itemsAttributeName": "Items"
						}
					},
					"color": "default",
					"caption": "#ResourceString(AddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"size": "medium",
					"layoutConfig": {},
					"menuItems": [],
					"clickMode": "default",
					"visible": true
				},
				"parentName": "FlexContainer_SsoProviders_Tools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_SsoProviders",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true
				},
				"parentName": "ExpansionPanel_SsoProviders",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataTable_SSOProvider",
				"values": {
					"type": "crt.DataGrid",
					"columns": [
						{
							"id": "f252f581-0ccf-44ac-b7c9-c00df2ad9919",
							"code": "PDS_Name",
							"caption": "#ResourceString(PDS_Name)#",
							"dataValueType": 1,
							"width": 281
						},
						{
							"id": "89314675-1423-f1af-587a-ee09fa76d62e",
							"code": "PDS_Saml_EntityID",
							"path": "[SsoSamlSettings:SsoProvider].EntityID",
							"caption": "#ResourceString(EntityID_ColumnCaption)#",
							"dataValueType": 28,
							"referenceSchemaName": "SsoSamlSettings",
							"width": 263
						},
						{
							"id": "f47868ee-4793-68ac-f66e-5cc6878e60f1",
							"code": "PDS_SsoSettingsTemplate",
							"path": "SsoSettingsTemplate",
							"caption": "#ResourceString(SsoSettingsTempate_ColumnCaption)#",
							"dataValueType": 12,
							"width": 286
						}
					],
					"items": "$Items",
					"layoutConfig": {},
					"classes": [
						"section-data-grid"
					],
					"primaryColumnName": "PDS_Id",
					"sorting": "$ItemsSorting | crt.ToDataTableSortingConfig: 'Items'",
					"visible": true,
					"features": {
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"fitContent": true,
					"stretch": false
				},
				"parentName": "FlexContainer_SsoProviders",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Checkbox_UseJIT",
				"values": {
					"layoutConfig": {},
					"type": "crt.Checkbox",
					"label": "#ResourceString(Checkbox_UseJIT_label)#",
					"labelPosition": "right",
					"control": "$SpUseJitAttribute",
					"tooltip": "#ResourceString(Checkbox_UseJIT_tooltip)#",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "FlexContainer_main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ExpansionPanel_SamlProvisioning",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ExpansionPanel_SamlProvisioning_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": true,
					"titleWidth": "90",
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": "$SpUseJitAttribute",
					"layoutConfig": {},
					"stretch": false
				},
				"parentName": "FlexContainer_main",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "FlexContainer_SamlProvisioning",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"stretch": false,
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "ExpansionPanel_SamlProvisioning",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_SamlAttributes",
				"values": {
					"type": "crt.DataGrid",
					"fitContent": true,
					"items": "$DataGrid_SamlAttributes",
					"primaryColumnName": "DataGrid_SamlAttributesDS_Id",
					"columns": [
						{
							"id": "80bbdc53-b0c8-74d1-7fac-682a03279a53",
							"code": "DataGrid_SamlAttributesDS_ContactFieldName",
							"path": "ContactFieldName",
							"caption": "#ResourceString(DataGrid_SamlAttributesDS_ContactFieldName)#",
							"dataValueType": 28
						},
						{
							"id": "23de8abb-dfb5-46a0-cce3-186485269358",
							"code": "DataGrid_SamlAttributesDS_ColumnDefaultValue",
							"path": "ColumnDefaultValue",
							"caption": "#ResourceString(DataGrid_SamlAttributesDS_ColumnDefaultValue)#",
							"dataValueType": 28
						},
						{
							"id": "f1363f3e-516c-9d74-eda7-90e5276d584f",
							"code": "DataGrid_SamlAttributesDS_SAMLFieldName",
							"path": "SAMLFieldName",
							"caption": "#ResourceString(DataGrid_SamlAttributesDS_SAMLFieldName)#",
							"dataValueType": 28
						}
					],
					"rowToolbarItems": [
						{
							"type": "crt.MenuItem",
							"caption": "DataGrid.RowToolbar.Open",
							"icon": "edit-row-action",
							"clicked": {
								"request": "crt.UpdateRecordRequest",
								"params": {
									"itemsAttributeName": "DataGrid_SamlAttributes",
									"recordId": "$DataGrid_SamlAttributes.DataGrid_SamlAttributesDS_Id",
									"scopes": [
										"SsoSettingsV2"
									]
								},
								"useRelativeContext": true
							}
						}
					],
					"features": {
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"layoutConfig": {},
					"visible": true,
					"stretch": false
				},
				"parentName": "FlexContainer_SamlProvisioning",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ExpansionPanel_OpenIdProvisioning",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ExpansionPanel_OpenIdProvisioning_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": true,
					"titleWidth": "90",
					"padding": {
						"top": "small",
						"bottom": "medium",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": "$SpUseJitAttribute",
					"layoutConfig": {},
					"stretch": false
				},
				"parentName": "FlexContainer_main",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "FlexContainer_OpenIdProvisioning",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"stretch": false,
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "ExpansionPanel_OpenIdProvisioning",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_OpenIdAttributes",
				"values": {
					"layoutConfig": {},
					"type": "crt.DataGrid",
					"fitContent": true,
					"items": "$DataGrid_OpenIdAttributes",
					"primaryColumnName": "DataGrid_OpenIdAttributesDS_Id",
					"columns": [
						{
							"id": "3a8c4251-86cb-3656-cf9c-88e40e7adbce",
							"code": "DataGrid_OpenIdAttributesDS_EntityFieldName",
							"path": "EntityFieldName",
							"caption": "#ResourceString(DataGrid_OpenIdAttributesDS_EntityFieldName)#",
							"dataValueType": 28
						},
						{
							"id": "79315df2-7979-b40b-9119-4ee3077762ad",
							"code": "DataGrid_OpenIdAttributesDS_OpenIdClaimName",
							"path": "OpenIdClaimName",
							"caption": "#ResourceString(DataGrid_OpenIdAttributesDS_OpenIdClaimName)#",
							"dataValueType": 28
						}
					],
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": true
						}
					},
					"visible": true,
					"stretch": false
				},
				"parentName": "FlexContainer_OpenIdProvisioning",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_AdditionalInfo",
				"values": {
					"layoutConfig": {
						"column": 10,
						"row": 1,
						"colSpan": 3,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "medium",
					"padding": {
						"top": "medium",
						"right": "none",
						"bottom": "none",
						"left": "medium"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap",
					"stretch": true
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_AdditionalInfo",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "small",
						"left": "none"
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Label_AdditionalInformation",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_AdditionalInformation_caption)#)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true,
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AzureSsoArticleButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_Azure_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"layoutConfig": {},
					"icon": null,
					"clicked": {
						"request": "crt.SsoHelperLinkRequest",
						"params": {
							"contextHelpCode": "AzureSsoSetup"
						}
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AdfsSsoArticleButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_ADFS_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"layoutConfig": {},
					"clicked": {
						"request": "crt.SsoHelperLinkRequest",
						"params": {
							"contextHelpCode": "AdfsSsoSetup"
						}
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "OneLoginSsoArticleButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_OneLogin_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"layoutConfig": {},
					"clicked": {
						"request": "crt.SsoHelperLinkRequest",
						"params": {
							"contextHelpCode": "OneLoginSsoSetup"
						}
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "CognitoSsoArticleButton",
				"values": {
					"layoutConfig": {},
					"type": "crt.Button",
					"caption": "#ResourceString(Button_y1ig7vh_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"clicked": {
						"request": "crt.SsoHelperLinkRequest",
						"params": {
							"contextHelpCode": "CognitoSsoSetup"
						}
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "JitArticleButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_JIT_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"layoutConfig": {},
					"icon": null,
					"clicked": {
						"request": "crt.SsoHelperLinkRequest",
						"params": {
							"contextHelpCode": "JitSsoSetup"
						}
					}
				},
				"parentName": "FlexContainer_AdditionalInfo",
				"propertyName": "items",
				"index": 5
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"Items": {
					"viewModelConfig": {
						"attributes": {
							"PDS_Name": {
								"modelConfig": {
									"path": "PDS.Name"
								}
							},
							"PDS_Saml_EntityID": {
								"modelConfig": {
									"path": "PDS.Saml_EntityID"
								}
							},
							"PDS_SsoSettingsTemplate": {
								"modelConfig": {
									"path": "PDS.SsoSettingsTemplate"
								}
							},
							"PDS_Id": {
								"modelConfig": {
									"path": "PDS.Id"
								}
							}
						}
					},
					"modelConfig": {
						"path": "PDS",
						"pagingConfig": {
							"rowCount": 30
						},
						"sortingConfig": {
							"attributeName": "ItemsSorting",
							"default": [
								{
									"direction": "desc",
									"columnName": "Name"
								}
							]
						},
						"filterAttributes": [
							{
								"name": "Items_PredefinedFilter",
								"loadOnChange": true
							}
						]
					}
				},
				"ItemsSorting": {},
				"DataGrid_SamlAttributes": {
					"isCollection": true,
					"modelConfig": {
						"path": "DataGrid_SamlAttributesDS",
						"filterAttributes": [
							{
								"loadOnChange": true,
								"name": "DataGrid_SamlAttributes_PredefinedFilter"
							}
						],
						"sortingConfig": {
							"default": [
								{
									"direction": "asc",
									"columnName": "ColumnDefaultValue"
								}
							]
						}
					},
					"viewModelConfig": {
						"attributes": {
							"DataGrid_SamlAttributesDS_ContactFieldName": {
								"modelConfig": {
									"path": "DataGrid_SamlAttributesDS.ContactFieldName"
								}
							},
							"DataGrid_SamlAttributesDS_ColumnDefaultValue": {
								"modelConfig": {
									"path": "DataGrid_SamlAttributesDS.ColumnDefaultValue"
								}
							},
							"DataGrid_SamlAttributesDS_SAMLFieldName": {
								"modelConfig": {
									"path": "DataGrid_SamlAttributesDS.SAMLFieldName"
								}
							},
							"DataGrid_SamlAttributesDS_Id": {
								"modelConfig": {
									"path": "DataGrid_SamlAttributesDS.Id"
								}
							}
						}
					}
				},
				"DataGrid_SamlAttributes_PredefinedFilter": {
					"value": null
				},
				"DataGrid_OpenIdAttributes": {
					"isCollection": true,
					"modelConfig": {
						"path": "DataGrid_OpenIdAttributesDS",
						"sortingConfig": {
							"default": [
								{
									"direction": "asc",
									"columnName": "EntityFieldName"
								}
							]
						}
					},
					"viewModelConfig": {
						"attributes": {
							"DataGrid_OpenIdAttributesDS_EntityFieldName": {
								"modelConfig": {
									"path": "DataGrid_OpenIdAttributesDS.EntityFieldName"
								}
							},
							"DataGrid_OpenIdAttributesDS_OpenIdClaimName": {
								"modelConfig": {
									"path": "DataGrid_OpenIdAttributesDS.OpenIdClaimName"
								}
							},
							"DataGrid_OpenIdAttributesDS_Id": {
								"modelConfig": {
									"path": "DataGrid_OpenIdAttributesDS.Id"
								}
							}
						}
					}
				},
				"SpUseJitAttribute": {},
				"SpIdAttribute": {},
				"IsSpChanged": {}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
					"type": "crt.EntityDataSource",
					"hiddenInPageDesigner": true,
					"config": {
						"entitySchemaName": "SsoProvider",
						"attributes": {
							"Name": {
								"path": "Name"
							},
							"Saml_EntityID": {
								"type": "Aggregation",
								"path": "[SsoSamlSettings:SsoProvider].EntityID",
								"aggregationConfig": {
									"aggregationFunction": "TopOne",
									"sortByColumn": "Id",
									"sortByDirection": 1,
									"filter": null
								}
							},
							"SsoSettingsTemplate": {
								"path": "SsoSettingsTemplate"
							}
						}
					},
					"scope": "viewElement"
				},
				"DataGrid_SamlAttributesDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "SAMLFieldNameConverter",
						"attributes": {
							"ContactFieldName": {
								"path": "ContactFieldName"
							},
							"ColumnDefaultValue": {
								"path": "ColumnDefaultValue"
							},
							"SAMLFieldName": {
								"path": "SAMLFieldName"
							}
						}
					}
				},
				"DataGrid_OpenIdAttributesDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "OpenIdFieldNameMap",
						"attributes": {
							"EntityFieldName": {
								"path": "EntityFieldName"
							},
							"OpenIdClaimName": {
								"path": "OpenIdClaimName"
							}
						}
					}
				},
				"SsoProviderDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "SsoProvider",
						"attributes": {
							"Name": {
								"path": "Name"
							},
							"Code": {
								"path": "Code"
							},
							"SsoSettingsTemplate": {
								"path": "SsoSettingsTemplate"
							}
						}
					}
				}
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: 'crt.HandleViewModelInitRequest',
				handler: async (request, next) => {
					const ssoServiceProviderModel = await sdk.Model.create("SsoServiceProvider");
					const data = await ssoServiceProviderModel.load({
						attributes: ['Id', 'UseJit'],
						parameters: [],
						options: {}
					});
					if (data.length > 0) {
						const ssoServiceProvider = data[0];
						request.$context.setValue(
							{
								SpIdAttribute: ssoServiceProvider.Id,
								silent: true
							}
						);
						request.$context.setValue(
							{
								SpUseJitAttribute: ssoServiceProvider.UseJit,
								silent: true
							}
						);
					}
					next.handle(request);
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

