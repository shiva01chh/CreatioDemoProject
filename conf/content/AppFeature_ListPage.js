Terrasoft.configuration.Structures["AppFeature_ListPage"] = {innerHierarchyStack: ["AppFeature_ListPage"], structureParent: "BaseGridSectionTemplate"};
define('AppFeature_ListPageStructure', ['AppFeature_ListPageResources'], function(resources) {return {schemaUId:'78041dff-f909-470e-b8b3-eaf73dd82aeb',schemaCaption: "Feature toggling list page", parentSchemaName: "BaseGridSectionTemplate", packageName: "FeatureToggling", schemaName:'AppFeature_ListPage',parentSchemaUId:'a5678241-e5e0-f691-b825-84b6039d5fa2',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("AppFeature_ListPage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(devkit)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
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
							"id": "c48886b7-a751-986a-7de3-3cb1213fdf7d",
							"code": "PDS_Code",
							"caption": "#ResourceString(PDS_Code)#",
							"dataValueType": 27,
							"width": 434
						},
						{
							"id": "86f5ed6e-d963-d0b7-75cb-c79d407d2828",
							"code": "PDS_State",
							"caption": "#ResourceString(PDS_State)#",
							"dataValueType": 12,
							"width": 140
						},
						{
							"id": "fc067e76-118b-2561-e723-58d79e1922f2",
							"code": "PDS_StateForCurrentUser",
							"caption": "#ResourceString(PDS_StateForCurrentUser)#",
							"dataValueType": 12,
							"width": 301
						},
						{
							"id": "19d4f69f-359f-a3cc-ae68-427e3dffed8b",
							"code": "PDS_Source",
							"caption": "#ResourceString(PDS_Source)#",
							"dataValueType": 30
						},
						{
							"id": "b391c61f-6a19-2bc6-4b16-ba609522dcac",
							"code": "PDS_Description",
							"caption": "#ResourceString(PDS_Description)#",
							"dataValueType": 28
						}
					],
					"layoutConfig": {
						"basis": "100%",
						"width": 300
					},
					"features": {
						"rows": {
							"selection": {
								"multiple": false
							}
						}
					},
					"rowToolbarItems": [
						{
							"type": "crt.MenuItem",
							"caption": "DataGrid.RowToolbar.Open",
							"icon": "edit-row-action",
							"visible": true,
							"disabled": "$Items.PrimaryModelMode | crt.IsEqual : 'create'",
							"clicked": {
								"request": "crt.UpdateRecordRequest",
								"params": {
									"itemsAttributeName": "Items",
									"recordId": "$Items.PDS_Id"
								},
								"useRelativeContext": true
							}
						},
						{
							"type": "crt.MenuItem",
							"caption": "#ResourceString(DeleteFeatureFromDbActionCaption)#",
							"icon": "delete-row-action",
							"visible": "$Items.PDS_Source | crt.CanDeleteFeature",
							"clicked": {
								"request": "crt.DeleteRecordRequest",
								"params": {
									"itemsAttributeName": "Items",
									"recordId": "$Items.PDS_Id"
								},
								"useRelativeContext": false
							}
						}
					],
					"primaryColumnName": "PDS_Id",
					"sorting": "$ItemsSorting | crt.ToDataTableSortingConfig: 'Items'"
				}
			},
			{
				"operation": "insert",
				"name": "GridContainer_fggdwmq",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
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
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "ActionContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "move",
				"name": "AddButton",
				"parentName": "GridContainer_fggdwmq",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "remove",
				"name": "ActionButtonsContainer"
			},
			{
				"operation": "insert",
				"name": "Label_4s6loja",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 11,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#ResourceString(Label_4s6loja_caption)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#DF1F26",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "center"
				},
				"parentName": "GridContainer_fggdwmq",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Label_u3t55vq",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 2,
						"colSpan": 11,
						"rowSpan": 1
					},
					"type": "crt.Label",
					"caption": "#ResourceString(Label_u3t55vq_caption)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "center"
				},
				"parentName": "GridContainer_fggdwmq",
				"propertyName": "items",
				"index": 2
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
					"gap": "medium"
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SearchFilter_11or0eq",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(SearchFilter_11or0eq_placeholder)#",
					"targetAttributes": [
						"Items"
					],
					"layoutConfig": {}
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
					"gap": "none"
				},
				"parentName": "MainFilterContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(RefreshButtonCaption)#",
					"color": "default",
					"disabled": false,
					"clicked": {
						"request": "ft.RefreshFeaturesCacheRequest"
					},
					"iconPosition": "left-icon",
					"icon": "reload-button-icon",
					"clickMode": "default"
				},
				"parentName": "RightFilterContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"Items": {
					"viewModelConfig": {
						"attributes": {
							"PDS_Code": {
								"modelConfig": {
									"path": "PDS.Code"
								}
							},
							"PDS_State": {
								"modelConfig": {
									"path": "PDS.State"
								}
							},
							"PDS_StateForCurrentUser": {
								"modelConfig": {
									"path": "PDS.StateForCurrentUser"
								}
							},
							"PDS_Source": {
								"modelConfig": {
									"path": "PDS.Source"
								}
							},
							"PDS_Description": {
								"modelConfig": {
									"path": "PDS.Description"
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
									"columnName": "Code"
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
				"ItemsSorting": {}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
					"type": "crt.EntityDataSource",
					"hiddenInPageDesigner": true,
					"config": {
						"entitySchemaName": "AppFeature",
						"attributes": {
							"Code": {
								"path": "Code"
							},
							"State": {
								"path": "State"
							},
							"StateForCurrentUser": {
								"path": "StateForCurrentUser"
							},
							"Source": {
								"path": "Source"
							},
							"Description": {
								"path": "Description"
							}
						}
					},
					"scope": "viewElement"
				}
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: "ft.RefreshFeaturesCacheRequest",
				handler: async (request, next) => {
					const httpClientService = new devkit.HttpClientService();
					const endpoint = "/rest/FeatureService/ClearFeaturesCacheForAllUsers/";
					const response = await httpClientService.get(endpoint);
					const handlerChain = devkit.HandlerChainService.instance;
					await handlerChain.process({
						type: 'crt.LoadDataRequest',
						"config": {
							"loadType": "reload"
						},
						"dataSourceName": "PDS",
						$context: request.$context
					});
					Terrasoft.showInformation(response.body);
					return next?.handle(request);
				}
			},
			{
				request: "crt.DeleteRecordRequest",
				handler: async (request) => {
					const handlerChain = devkit.HandlerChainService.instance;
					try {
						const result = await handlerChain.process({
							type: 'crt.DeleteDataRequest',
							$context: request.$context,
							dataSourceName: "PDS",
							parameters: [
								{
									type: devkit.ModelParameterType.PrimaryColumnValue,
									value: '@requestPayload.primaryColumnValue',
								},
							],
							config: {
								payload: {
									primaryColumnValue: request.recordId,
								},
							},
						});
						if (!result.success) {
							Terrasoft.showErrorMessage(result.errorInfo);
							return;
						}
					} catch (e) {
						Terrasoft.showErrorMessage(e?.errorInfo);
						return;
					}
					await handlerChain.process({
						type: 'crt.LoadDataRequest',
						"config": {
							"loadType": "reload"
						},
						"dataSourceName": "PDS",
						$context: request.$context
					});
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{
			"crt.CanDeleteFeature": value => value === 'DbFeatureProvider'
		}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});


