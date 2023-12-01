﻿Terrasoft.configuration.Structures["Documents_FormPage"] = {innerHierarchyStack: ["Documents_FormPageCrtDocument", "Documents_FormPage"], structureParent: "PageWithTabsFreedomTemplate"};
define('Documents_FormPageCrtDocumentStructure', ['Documents_FormPageCrtDocumentResources'], function(resources) {return {schemaUId:'7145d010-0a48-49a8-bbe8-a12ff4347664',schemaCaption: "Documents form page", parentSchemaName: "PageWithTabsFreedomTemplate", packageName: "CrtOrderContractInC360", schemaName:'Documents_FormPageCrtDocument',parentSchemaUId:'3b2e117f-8c6b-4ca5-80a2-7ebb497cddf9',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Documents_FormPageStructure', ['Documents_FormPageResources'], function(resources) {return {schemaUId:'87a65957-2e0e-4f26-b5bf-9cc725303b56',schemaCaption: "Documents form page", parentSchemaName: "Documents_FormPageCrtDocument", packageName: "CrtOrderContractInC360", schemaName:'Documents_FormPage',parentSchemaUId:'7145d010-0a48-49a8-bbe8-a12ff4347664',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"Documents_FormPageCrtDocument",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Documents_FormPageCrtDocumentResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("Documents_FormPageCrtDocument", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "SideAreaProfileContainer",
				"values": {
					"columns": [
						"minmax(64px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"visible": true
				}
			},
			{
				"operation": "merge",
				"name": "Tabs",
				"values": {
					"styleType": "default",
					"mode": "tab",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTabContainer",
				"values": {
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				}
			},
			{
				"operation": "merge",
				"name": "CardToggleTabPanel",
				"values": {
					"styleType": "default",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "merge",
				"name": "Feed",
				"values": {
					"dataSourceName": "PDS",
					"entitySchemaName": "Document"
				}
			},
			{
				"operation": "merge",
				"name": "AttachmentList",
				"values": {
					"recordColumnName": "Document",
					"columns": [
						{
							"id": "bc969b60-97fb-4f58-980c-356e96234edc",
							"code": "AttachmentListDS_Name",
							"caption": "#ResourceString(AttachmentListDS_Name)#",
							"dataValueType": 28,
							"width": 200
						}
					]
				}
			},
			{
				"operation": "insert",
				"name": "Number",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.Number",
					"control": "$Number",
					"labelPosition": "above",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Type",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_qxdr098",
					"labelPosition": "above",
					"control": "$LookupAttribute_qxdr098",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Status",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_p5kt1jm",
					"labelPosition": "above",
					"control": "$LookupAttribute_p5kt1jm",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Date",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DateTimePicker",
					"pickerType": "date",
					"label": "$Resources.Strings.DateTimeAttribute_bmnzg2s",
					"labelPosition": "above",
					"control": "$DateTimeAttribute_bmnzg2s",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Owner",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_b2nwy47",
					"labelPosition": "above",
					"control": "$LookupAttribute_b2nwy47",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(Owner_tooltip)#"
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "addRecord_njngkjy",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_njngkjy_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Owner",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Account",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_69lk9cx_zgq7yhm",
					"labelPosition": "auto",
					"control": "$LookupAttribute_69lk9cx_zgq7yhm",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "GeneralInfoTabContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "addRecord_j5xiaof",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_j5xiaof_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Account",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Contact",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_zpcobtx",
					"labelPosition": "auto",
					"control": "$LookupAttribute_zpcobtx",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "GeneralInfoTabContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "addRecord_q5m8gie",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_q5m8gie_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Contact",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsExpansionPanel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(RelatedDocumentsExpansionPanel_title)#",
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
					"visible": true
				},
				"parentName": "GeneralInfoTabContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
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
				"parentName": "RelatedDocumentsExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsToolsFlexContainer",
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
				"parentName": "RelatedDocumentsToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsAddButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(RelatedDocumentsAddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "Document",
							"defaultValues": [
								{
									"attributeName": "Account",
									"value": "$LookupAttribute_69lk9cx_zgq7yhm"
								},
								{
									"attributeName": "Contact",
									"value": "$LookupAttribute_zpcobtx"
								}
							]
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "RelatedDocumentsToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(RelatedDocumentsRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "RelatedDocumentsListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "RelatedDocumentsToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(RelatedDocumentsSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "RelatedDocumentsToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(RelatedDocumentsExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "RelatedDocumentsList"
						}
					},
					"visible": true
				},
				"parentName": "RelatedDocumentsSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(RelatedDocumentsImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "DocumentRelationship"
						}
					},
					"visible": true
				},
				"parentName": "RelatedDocumentsSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(RelatedDocumentsSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_h7omalt"
					]
				},
				"parentName": "RelatedDocumentsToolsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsListContainer",
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
				"parentName": "RelatedDocumentsExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_h7omalt",
					"primaryColumnName": "RelatedDocumentsListDS_Id",
					"columns": [
						{
							"id": "6e15eef7-0d25-1f4e-89e0-eb7d9c5a928f",
							"code": "RelatedDocumentsListDS_DocumentB",
							"path": "DocumentB",
							"caption": "#ResourceString(RelatedDocumentsListDS_DocumentB)#",
							"dataValueType": 10,
							"referenceSchemaName": "Document",
							"width": 181
						},
						{
							"id": "36678c9f-4f7a-f63e-5ff0-534b7115f728",
							"code": "RelatedDocumentsListDS_DocumentBType",
							"path": "DocumentB.Type",
							"caption": "#ResourceString(RelatedDocumentsListDS_DocumentBType)#",
							"dataValueType": 10,
							"referenceSchemaName": "DocumentType",
							"width": 181
						},
						{
							"id": "197fb305-3e0d-da6a-0afa-ea3d1506e6fe",
							"code": "RelatedDocumentsListDS_DocumentBState",
							"path": "DocumentB.State",
							"caption": "#ResourceString(RelatedDocumentsListDS_DocumentBState)#",
							"dataValueType": 10,
							"referenceSchemaName": "DocumentState",
							"width": 179
						},
						{
							"id": "7d8c9b63-351a-4f43-001f-c98876ace6a4",
							"code": "RelatedDocumentsListDS_DocumentBDate",
							"path": "DocumentB.Date",
							"caption": "#ResourceString(RelatedDocumentsListDS_DocumentBDate)#",
							"dataValueType": 8,
							"width": 138
						}
					],
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"bulkActions": []
				},
				"parentName": "RelatedDocumentsListContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsList_ExportToExcelBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Export to Excel",
					"icon": "export-button-icon",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "RelatedDocumentsList",
							"filters": "$GridDetail_h7omalt | crt.ToCollectionFilters : 'GridDetail_h7omalt' : $RelatedDocumentsList_SelectionState | crt.SkipIfSelectionEmpty : $RelatedDocumentsList_SelectionState"
						}
					}
				},
				"parentName": "RelatedDocumentsList",
				"propertyName": "bulkActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RelatedDocumentsList_DeleteBulkAction",
				"values": {
					"type": "crt.MenuItem",
					"caption": "Delete",
					"icon": "delete-button-icon",
					"clicked": {
						"request": "crt.DeleteRecordsRequest",
						"params": {
							"dataSourceName": "RelatedDocumentsListDS",
							"filters": "$GridDetail_h7omalt | crt.ToCollectionFilters : 'GridDetail_h7omalt' : $RelatedDocumentsList_SelectionState | crt.SkipIfSelectionEmpty : $RelatedDocumentsList_SelectionState"
						}
					}
				},
				"parentName": "RelatedDocumentsList",
				"propertyName": "bulkActions",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"Number": {
						"modelConfig": {
							"path": "PDS.Number"
						}
					},
					"DateTimeAttribute_bmnzg2s": {
						"modelConfig": {
							"path": "PDS.Date"
						}
					},
					"LookupAttribute_qxdr098": {
						"modelConfig": {
							"path": "PDS.Type"
						}
					},
					"LookupAttribute_p5kt1jm": {
						"modelConfig": {
							"path": "PDS.State"
						}
					},
					"LookupAttribute_b2nwy47": {
						"modelConfig": {
							"path": "PDS.Owner"
						}
					},
					"LookupAttribute_69lk9cx_zgq7yhm": {
						"modelConfig": {
							"path": "PDS.Account"
						}
					},
					"LookupAttribute_zpcobtx": {
						"modelConfig": {
							"path": "PDS.Contact"
						}
					},
					"GridDetail_h7omalt": {
						"isCollection": true,
						"modelConfig": {
							"path": "RelatedDocumentsListDS",
							"filterAttributes": [
								{
									"loadOnChange": true,
									"name": "GridDetail_h7omalt_PredefinedFilter"
								}
							]
						},
						"viewModelConfig": {
							"attributes": {
								"RelatedDocumentsListDS_DocumentB": {
									"modelConfig": {
										"path": "RelatedDocumentsListDS.DocumentB"
									}
								},
								"RelatedDocumentsListDS_DocumentBType": {
									"modelConfig": {
										"path": "RelatedDocumentsListDS.DocumentBType"
									}
								},
								"RelatedDocumentsListDS_DocumentBState": {
									"modelConfig": {
										"path": "RelatedDocumentsListDS.DocumentBState"
									}
								},
								"RelatedDocumentsListDS_DocumentBDate": {
									"modelConfig": {
										"path": "RelatedDocumentsListDS.DocumentBDate"
									}
								},
								"RelatedDocumentsListDS_Id": {
									"modelConfig": {
										"path": "RelatedDocumentsListDS.Id"
									}
								}
							}
						}
					},
					"GridDetail_h7omalt_PredefinedFilter": {
						"value": null
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Id",
					"modelConfig"
				],
				"values": {
					"path": "PDS.Id"
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"primaryDataSourceName": "PDS",
					"dependencies": {
						"RelatedDocumentsListDS": [
							{
								"attributePath": "DocumentA",
								"relationPath": "PDS.Id"
							}
						]
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"PDS": {
						"type": "crt.EntityDataSource",
						"config": {
							"entitySchemaName": "Document"
						},
						"scope": "page"
					},
					"RelatedDocumentsListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "DocumentRelationship",
							"attributes": {
								"DocumentB": {
									"path": "DocumentB"
								},
								"DocumentBType": {
									"type": "ForwardReference",
									"path": "DocumentB.Type"
								},
								"DocumentBState": {
									"type": "ForwardReference",
									"path": "DocumentB.State"
								},
								"DocumentBDate": {
									"type": "ForwardReference",
									"path": "DocumentB.Date"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"AttachmentListDS",
					"config"
				],
				"values": {
					"entitySchemaName": "DocumentFile"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
define("Documents_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "RelatedDocumentsList",
				"values": {
					"activeRow": "$RelatedDocumentsList_ActiveRow",
					"_filterOptions": {
						"from": [
							"GridDetail_h7omalt",
							"RelatedDocumentsList_ActiveRow"
						],
						"expose": []
					},
					"selectionState": "$RelatedDocumentsList_SelectionState",
					"_selectionOptions": {
						"attribute": "RelatedDocumentsList_SelectionState"
					}
				}
			},
			{
				"operation": "insert",
				"name": "AccountInfoContainer",
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
					"visible": false
				},
				"parentName": "SideContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AccountLabel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(AccountLabel_caption)#)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "AccountInfoContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AccountCompactProfile",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.AccountCompactProfile",
					"readonly": true,
					"visible": true,
					"referenceColumn": "$LookupAttribute_69lk9cx_zgq7yhm"
				},
				"parentName": "AccountInfoContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AccountType",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.AccountType",
					"ariaLabel": "#ResourceString(ComboBox_f52f1vu_ariaLabel)#",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "auto",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$AccountType"
				},
				"parentName": "AccountInfoContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "addRecord_z9aigow",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_z9aigow_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "AccountType",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AccountPrimaryPhone",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.PhoneInput",
					"label": "$Resources.Strings.AccountPhone",
					"control": "$AccountPhone",
					"labelPosition": "auto",
					"placeholder": "",
					"tooltip": "",
					"needHandleSave": false,
					"caption": "#ResourceString(PhoneInput_9rn9yle_caption)#",
					"readonly": true
				},
				"parentName": "AccountInfoContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AccountWeb",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.WebInput",
					"label": "$Resources.Strings.AccountWeb",
					"control": "$AccountWeb",
					"labelPosition": "auto",
					"placeholder": "",
					"tooltip": "",
					"needHandleSave": false,
					"caption": "#ResourceString(WebInput_8h07mv3_caption)#",
					"readonly": true
				},
				"parentName": "AccountInfoContainer",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"AccountWeb": {
						"modelConfig": {
							"path": "PDS.AccountWeb"
						}
					},
					"AccountType": {
						"modelConfig": {
							"path": "PDS.AccountType"
						}
					},
					"AccountPhone": {
						"modelConfig": {
							"path": "PDS.AccountPhone"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"PDS",
					"config"
				],
				"values": {
					"attributes": {
						"AccountWeb": {
							"path": "Account.Web",
							"type": "ForwardReference"
						},
						"AccountType": {
							"path": "Account.Type",
							"type": "ForwardReference"
						},
						"AccountPhone": {
							"path": "Account.Phone",
							"type": "ForwardReference"
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

