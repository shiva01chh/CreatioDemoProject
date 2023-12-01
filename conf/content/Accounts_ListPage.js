﻿Terrasoft.configuration.Structures["Accounts_ListPage"] = {innerHierarchyStack: ["Accounts_ListPage"], structureParent: "ListFreedomTemplate"};
define('Accounts_ListPageStructure', ['Accounts_ListPageResources'], function(resources) {return {schemaUId:'f537fd79-9bdc-43ea-a9ce-b068c29d0b22',schemaCaption: "Accounts list page", parentSchemaName: "ListFreedomTemplate", packageName: "CrtCustomer360App", schemaName:'Accounts_ListPage',parentSchemaUId:'3f1f3f38-a0a4-4549-b895-249fb08f554a',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("Accounts_ListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "AddButton",
				"values": {
					"size": "large"
				}
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
				"operation": "merge",
				"name": "SectionContentWrapper",
				"values": {
					"direction": "row",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "start",
					"gap": "small",
					"wrap": "nowrap"
				}
			},
			{
				"operation": "merge",
				"name": "DataTable",
				"values": {
					"columns": [
						{
							"id": "8a438b24-e88d-1e5c-93b7-d16e119ae24b",
							"code": "PDS_Name",
							"path": "Name",
							"caption": "#ResourceString(PDS_Name)#",
							"dataValueType": 28,
							"sticky": true
						},
						{
							"id": "dcfcc335-4e9b-39b4-33f2-49a953c68ab4",
							"code": "PDS_PrimaryContact",
							"path": "PrimaryContact",
							"caption": "#ResourceString(PDS_PrimaryContact)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact",
							"width": 224
						},
						{
							"id": "66f5baa6-0698-c4e5-1922-696fe8045ac1",
							"code": "PDS_Type",
							"path": "Type",
							"caption": "#ResourceString(PDS_Type)#",
							"dataValueType": 10,
							"referenceSchemaName": "AccountType",
							"width": 165
						},
						{
							"id": "f3cdea55-a23b-6ccf-8b28-af100a050ebe",
							"code": "PDS_AccountCategory",
							"path": "AccountCategory",
							"caption": "#ResourceString(PDS_AccountCategory)#",
							"dataValueType": 10,
							"referenceSchemaName": "AccountCategory",
							"width": 114
						},
						{
							"id": "38f3839b-174b-1712-e038-1ced6640b25a",
							"code": "PDS_Industry",
							"path": "Industry",
							"caption": "#ResourceString(PDS_Industry)#",
							"dataValueType": 10,
							"referenceSchemaName": "AccountIndustry"
						},
						{
							"id": "d48c4425-1677-6d87-9400-b6ee1c316105",
							"code": "PDS_Web",
							"path": "Web",
							"caption": "#ResourceString(PDS_Web)#",
							"dataValueType": 28,
							"width": 238
						},
						{
							"id": "ab2ff5af-56dd-cf88-a644-a77fdb9ebd73",
							"code": "PDS_Country",
							"path": "Country",
							"caption": "#ResourceString(PDS_Country)#",
							"dataValueType": 10,
							"referenceSchemaName": "Country",
							"width": 229
						},
						{
							"id": "987816a7-0e0f-d51f-e040-5374f3d2b8db",
							"code": "PDS_CreatedOn",
							"path": "CreatedOn",
							"caption": "#ResourceString(PDS_CreatedOn)#",
							"dataValueType": 7
						}
					],
					"layoutConfig": {
						"basis": "100%",
						"width": 300
					},
					"primaryColumnName": "PDS_Id",
					"sorting": "$ItemsSorting | crt.ToDataTableSortingConfig: 'Items'"
				}
			},
			{
				"operation": "insert",
				"name": "MenuItem_ImportFromExel",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(MenuItem_ImportFromExel_caption)#",
					"visible": true,
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "Account"
						}
					},
					"icon": "import-button-icon"
				},
				"parentName": "ActionButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "MainFilterContainer",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "medium",
						"rowGap": "none"
					},
					"items": [],
					"color": "primary",
					"borderRadius": "none",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"fitContent": true
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeftFilterContainer",
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
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "large"
					},
					"justifyContent": "start",
					"gap": "medium",
					"alignItems": "center"
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FolderTreeActions",
				"values": {
					"type": "crt.FolderTreeActions",
					"caption": "#ResourceString(FolderTreeActions_caption)#",
					"folderTree": "FolderTree"
				},
				"parentName": "LeftFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RightFilterContainer",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "medium",
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "end",
					"gap": "medium",
					"alignItems": "center"
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(SearchFilter_placeholder)#",
					"targetAttributes": [
						"Items"
					]
				},
				"parentName": "RightFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(RefreshButtonCaption)#",
					"color": "default",
					"disabled": false,
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload"
							},
							"dataSourceName": "PDS"
						}
					},
					"iconPosition": "only-icon",
					"icon": "reload-button-icon",
					"clickMode": "default"
				},
				"parentName": "RightFilterContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FolderTree",
				"values": {
					"type": "crt.FolderTree",
					"caption": "#ResourceString(FolderTree_caption)#",
					"sourceSchemaName": "FolderTree",
					"rootSchemaName": "Account",
					"layoutConfig": {
						"width": 328.125
					},
					"classes": [
						"section-folder-tree"
					]
				},
				"parentName": "SectionContentWrapper",
				"propertyName": "items",
				"index": 0
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
							"PDS_PrimaryContact": {
								"modelConfig": {
									"path": "PDS.PrimaryContact"
								}
							},
							"PDS_Type": {
								"modelConfig": {
									"path": "PDS.Type"
								}
							},
							"PDS_AccountCategory": {
								"modelConfig": {
									"path": "PDS.AccountCategory"
								}
							},
							"PDS_Industry": {
								"modelConfig": {
									"path": "PDS.Industry"
								}
							},
							"PDS_Web": {
								"modelConfig": {
									"path": "PDS.Web"
								}
							},
							"PDS_Country": {
								"modelConfig": {
									"path": "PDS.Country"
								}
							},
							"PDS_CreatedOn": {
								"modelConfig": {
									"path": "PDS.CreatedOn"
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
									"direction": "asc",
									"columnName": "Type"
								}
							]
						},
						"filterAttributes": [
							{
								"loadOnChange": true,
								"name": "FolderTree_active_folder_filter"
							},
							{
								"name": "Items_PredefinedFilter",
								"loadOnChange": true
							}
						]
					}
				},
				"ItemsSorting": {},
				"FolderTree_visible": {
					"value": false
				},
				"FolderTree_items": {
					"isCollection": true,
					"viewModelConfig": {
						"attributes": {
							"Id": {
								"modelConfig": {
									"path": "FolderTree_items_DS.Id"
								}
							},
							"Name": {
								"modelConfig": {
									"path": "FolderTree_items_DS.Name"
								}
							},
							"ParentId": {
								"modelConfig": {
									"path": "FolderTree_items_DS.Parent.Id"
								}
							},
							"FilterData": {
								"modelConfig": {
									"path": "FolderTree_items_DS.FilterData"
								}
							}
						}
					},
					"modelConfig": {
						"path": "FolderTree_items_DS",
						"filterAttributes": [
							{
								"name": "FolderTree_items_DS_filter",
								"loadOnChange": true
							}
						]
					},
					"embeddedModel": {
						"name": "FolderTree_items_DS",
						"config": {
							"type": "crt.EntityDataSource",
							"config": {
								"entitySchemaName": "FolderTree"
							}
						}
					}
				},
				"FolderTree_active_folder_id": {},
				"FolderTree_active_folder_name": {},
				"FolderTree_active_folder_filter": {
					"value": {}
				},
				"FolderTree_items_DS_filter": {
					"value": {
						"isEnabled": true,
						"trimDateTimeParameterToDate": false,
						"filterType": 6,
						"logicalOperation": 0,
						"items": {
							"3714ebf4-41a3-9a82-8e8b-039d9ac03ce1": {
								"isEnabled": true,
								"trimDateTimeParameterToDate": false,
								"filterType": 1,
								"comparisonType": 3,
								"leftExpression": {
									"expressionType": 0,
									"columnPath": "EntitySchemaName"
								},
								"rightExpression": {
									"expressionType": 2,
									"parameter": {
										"dataValueType": 1,
										"value": "Account"
									}
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
					"type": "crt.EntityDataSource",
					"hiddenInPageDesigner": true,
					"config": {
						"entitySchemaName": "Account",
						"attributes": {
							"Name": {
								"path": "Name"
							},
							"PrimaryContact": {
								"path": "PrimaryContact"
							},
							"Type": {
								"path": "Type"
							},
							"AccountCategory": {
								"path": "AccountCategory"
							},
							"Industry": {
								"path": "Industry"
							},
							"Web": {
								"path": "Web"
							},
							"Country": {
								"path": "Country"
							},
							"CreatedOn": {
								"path": "CreatedOn"
							}
						}
					},
					"scope": "viewElement"
				}
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

