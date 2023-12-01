﻿Terrasoft.configuration.Structures["UISwitcherUserGroupSelectionPage"] = {innerHierarchyStack: ["UISwitcherUserGroupSelectionPage"], structureParent: "BlankPageTemplate"};
define('UISwitcherUserGroupSelectionPageStructure', ['UISwitcherUserGroupSelectionPageResources'], function(resources) {return {schemaUId:'82e786df-657c-4bed-9d05-e48f54727871',schemaCaption: "Shell UI type user group selection page", parentSchemaName: "BlankPageTemplate", packageName: "CrtUISwitcher", schemaName:'UISwitcherUserGroupSelectionPage',parentSchemaUId:'f691e828-0b36-42a7-898f-c337e9af67d0',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("UISwitcherUserGroupSelectionPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "GridContainer_Header",
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
					"padding": {
						"top": "medium",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"color": "primary",
					"borderRadius": "medium",
					"visible": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ForTitle",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
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
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "wrap"
				},
				"parentName": "GridContainer_Header",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ForBackButton",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true
				},
				"parentName": "FlexContainer_ForTitle",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BackButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(BackButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "medium",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "back-button-icon",
					"clicked": {
						"request": "crt.ClosePageRequest"
					},
					"clickMode": "default",
					"layoutConfig": {}
				},
				"parentName": "FlexContainer_ForBackButton",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Label_Header",
				"values": {
					"layoutConfig": {},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_Header_caption)#)#",
					"labelType": "headline-1",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "FlexContainer_ForTitle",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_fctlpo0",
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
						"right": "small",
						"bottom": "none",
						"left": "small"
					}
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_ListAndButton",
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
					"padding": {
						"top": "medium",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"color": "primary",
					"borderRadius": "medium",
					"visible": true,
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_fctlpo0",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DataGrid_UISwitcherAdminUnitUIType",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DataGrid",
					"visible": true,
					"fitContent": true,
					"items": "$DataGrid_pfolv3b",
					"primaryColumnName": "DataGrid_pfolv3bDS_Id",
					"columns": [
						{
							"id": "f425fab2-5711-ce41-0d2b-2137e7d7720d",
							"code": "DataGrid_pfolv3bDS_SysAdminUnit",
							"path": "SysAdminUnit",
							"caption": "#ResourceString(DataGrid_pfolv3bDS_SysAdminUnit)#",
							"dataValueType": 10,
							"referenceSchemaName": "SysAdminUnit",
							"width": 362,
							"sticky": false
						},
						{
							"id": "eb111740-2d5d-c585-8aef-8a2e9658b2a3",
							"code": "DataGrid_pfolv3bDS_FreedomUIEnabled",
							"caption": "#ResourceString(DataGrid_pfolv3bDS_FreedomUIEnabled)#",
							"dataValueType": 12,
							"width": 237,
							"sticky": false
						},
						{
							"id": "b1f0f359-a76d-df27-b638-3a6c18e32b3d",
							"code": "DataGrid_pfolv3bDS_Priority",
							"path": "Priority",
							"caption": "#ResourceString(DataGrid_pfolv3bDS_Priority)#",
							"dataValueType": 4,
							"width": 172,
							"sticky": false
						}
					],
					"selectedRows": "$DataGrid_pfolv3b_SelectedRows",
					"_filterOptions": {
						"from": [
							"DataGrid_pfolv3b",
							"DataGrid_UISwitcherAdminUnitUIType_ActiveRow"
						],
						"expose": []
					},
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": true
						}
					},
					"activeRow": "$DataGrid_UISwitcherAdminUnitUIType_ActiveRow",
					"selectionState": "$DataGrid_UISwitcherAdminUnitUIType_SelectionState",
					"_selectionOptions": {
						"attribute": "DataGrid_UISwitcherAdminUnitUIType_SelectionState"
					}
				},
				"parentName": "GridContainer_ListAndButton",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_ForContinieButton",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
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
					"justifyContent": "end",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "wrap"
				},
				"parentName": "GridContainer_ListAndButton",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ContinueButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_vkeb7wh_caption)#",
					"color": "accent",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"clicked": [
						{
							"request": "crt.RunBusinessProcessRequest",
							"params": {
								"processName": "UISwitcherSetUseNewShellForGroup",
								"processRunType": "RegardlessOfThePage"
							}
						},
						{
							"request": "crt.OpenPageRequest",
							"params": {
								"schemaName": "UISwitcherLogoutDialog"
							}
						}
					],
					"clickMode": "default"
				},
				"parentName": "FlexContainer_ForContinieButton",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"attributes": {
						"DataGrid_pfolv3b": {
							"isCollection": true,
							"modelConfig": {
								"path": "DataGrid_pfolv3bDS",
								"filterAttributes": [
									{
										"loadOnChange": true,
										"name": "DataGrid_pfolv3b_PredefinedFilter"
									}
								],
								"sortingConfig": {
									"default": [
										{
											"direction": "asc",
											"columnName": "Priority"
										}
									]
								}
							},
							"viewModelConfig": {
								"attributes": {
									"DataGrid_pfolv3bDS_SysAdminUnit": {
										"modelConfig": {
											"path": "DataGrid_pfolv3bDS.SysAdminUnit"
										}
									},
									"DataGrid_pfolv3bDS_FreedomUIEnabled": {
										"modelConfig": {
											"path": "DataGrid_pfolv3bDS.FreedomUIEnabled"
										}
									},
									"DataGrid_pfolv3bDS_Priority": {
										"modelConfig": {
											"path": "DataGrid_pfolv3bDS.Priority"
										}
									},
									"DataGrid_pfolv3bDS_Id": {
										"modelConfig": {
											"path": "DataGrid_pfolv3bDS.Id"
										}
									}
								}
							}
						},
						"DataGrid_pfolv3b_PredefinedFilter": {
							"value": {
								"items": {
									"5ae86ab5-17ba-4506-8690-de71de1341d3": {
										"filterType": 4,
										"comparisonType": 4,
										"isEnabled": true,
										"trimDateTimeParameterToDate": false,
										"leftExpression": {
											"expressionType": 0,
											"columnPath": "SysAdminUnit"
										},
										"isAggregative": false,
										"dataValueType": 10,
										"referenceSchemaName": "SysAdminUnit",
										"rightExpressions": [
											{
												"expressionType": 2,
												"parameter": {
													"dataValueType": 10,
													"value": {
														"Name": "All external users",
														"Id": "720b771c-e7a7-4f31-9cfb-52cd21c3739f",
														"value": "720b771c-e7a7-4f31-9cfb-52cd21c3739f",
														"displayValue": "All external users"
													}
												}
											}
										]
									}
								},
								"logicalOperation": 0,
								"isEnabled": true,
								"filterType": 6,
								"rootSchemaName": "UISwitcherAdminUnitUIType"
							}
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"DataGrid_pfolv3bDS": {
							"type": "crt.EntityDataSource",
							"scope": "viewElement",
							"config": {
								"entitySchemaName": "UISwitcherAdminUnitUIType",
								"attributes": {
									"SysAdminUnit": {
										"path": "SysAdminUnit"
									},
									"FreedomUIEnabled": {
										"path": "FreedomUIEnabled"
									},
									"Priority": {
										"path": "Priority"
									}
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

