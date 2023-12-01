define("Products_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "insert",
				"name": "UnitsExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(UnitsExpansionPanel_title)#",
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
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "UnitsToolsContainer",
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
				"parentName": "UnitsExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "UnitsToolsFlexContainer",
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
				"parentName": "UnitsToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductUnitListRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductUnitListRefreshButton_caption)#",
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
							"dataSourceName": "GridDetail_snzncmyDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "UnitsToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductUnitListSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductUnitListSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "UnitsToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductUnitListExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductUnitListExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "GridDetail_snzncmy"
						}
					},
					"visible": true
				},
				"parentName": "ProductUnitListSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductUnitListImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductUnitListImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "ProductUnit"
						}
					},
					"visible": true
				},
				"parentName": "ProductUnitListSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductUnitListSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(ProductUnitListSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_snzncmy"
					]
				},
				"parentName": "UnitsToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridContainer_wn2emq0",
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
				"parentName": "UnitsExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductUnitList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_snzncmy",
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "GridDetail_snzncmyDS_Id",
					"columns": [
						{
							"id": "6722d364-3b3f-36ca-73da-6b2184ceebef",
							"code": "GridDetail_snzncmyDS_Unit",
							"path": "Unit",
							"caption": "#ResourceString(GridDetail_snzncmyDS_Unit)#",
							"dataValueType": 10,
							"referenceSchemaName": "Unit",
							"width": 181
						},
						{
							"id": "e98191f4-58f4-1346-38b6-8f8383f90e72",
							"code": "GridDetail_snzncmyDS_UnitShortName",
							"path": "Unit.ShortName",
							"caption": "#ResourceString(GridDetail_snzncmyDS_UnitShortName)#",
							"dataValueType": 27,
							"width": 163
						},
						{
							"id": "dd9776b4-cb41-d363-cced-9735d643d8e6",
							"code": "GridDetail_snzncmyDS_IsBase",
							"path": "IsBase",
							"caption": "#ResourceString(GridDetail_snzncmyDS_IsBase)#",
							"dataValueType": 12,
							"width": 142
						},
						{
							"id": "ec27616a-2c8e-e6c9-64a4-78c4f26c8d6e",
							"code": "GridDetail_snzncmyDS_NumberOfBaseUnits",
							"path": "NumberOfBaseUnits",
							"caption": "#ResourceString(GridDetail_snzncmyDS_NumberOfBaseUnits)#",
							"dataValueType": 33,
							"width": 197
						}
					]
				},
				"parentName": "GridContainer_wn2emq0",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "PricesTab",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(PricesTab_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "PricesExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(PricesExpansionPanel_title)#",
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
				"parentName": "PricesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "PricesToolsContainer",
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
				"parentName": "PricesExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "PricesToolsFlexContainer",
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
				"parentName": "PricesToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductPriceListRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductPriceListRefreshButton_caption)#",
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
							"dataSourceName": "GridDetail_5l564xcDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "PricesToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductPriceListSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductPriceListSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "PricesToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductPriceListExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductPriceListExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "GridDetail_5l564xc"
						}
					},
					"visible": true
				},
				"parentName": "ProductPriceListSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductPriceListImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductPriceListImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "ProductPrice"
						}
					},
					"visible": true
				},
				"parentName": "ProductPriceListSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductPriceListSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(ProductPriceListSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_5l564xc"
					]
				},
				"parentName": "PricesToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridContainer_dg1l0x4",
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
				"parentName": "PricesExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductPriceList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_5l564xc",
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "GridDetail_5l564xcDS_Id",
					"columns": [
						{
							"id": "6ff048fc-e612-e548-fc38-7a13967f5783",
							"code": "GridDetail_5l564xcDS_PriceList",
							"path": "PriceList",
							"caption": "#ResourceString(GridDetail_5l564xcDS_PriceList)#",
							"dataValueType": 10,
							"referenceSchemaName": "Pricelist"
						},
						{
							"id": "3451b62b-5179-e54c-a4d6-138a204d3104",
							"code": "GridDetail_5l564xcDS_Price",
							"path": "Price",
							"caption": "#ResourceString(GridDetail_5l564xcDS_Price)#",
							"dataValueType": 6
						},
						{
							"id": "01a31a6c-3008-c1fd-91bc-a3c8823d32eb",
							"code": "GridDetail_5l564xcDS_Currency",
							"path": "Currency",
							"caption": "#ResourceString(GridDetail_5l564xcDS_Currency)#",
							"dataValueType": 10,
							"referenceSchemaName": "Currency",
							"width": 131
						},
						{
							"id": "9d4afd4d-861d-2e4f-db2e-1d9384b8970f",
							"code": "GridDetail_5l564xcDS_Tax",
							"path": "Tax",
							"caption": "#ResourceString(GridDetail_5l564xcDS_Tax)#",
							"dataValueType": 10,
							"referenceSchemaName": "Tax"
						}
					]
				},
				"parentName": "GridContainer_dg1l0x4",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AvailabilityExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(AvailabilityExpansionPanel_title)#",
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
				"parentName": "PricesTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AvailabilityToolsContainer",
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
				"parentName": "AvailabilityExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AvailabilityToolsFlexContainer",
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
				"parentName": "AvailabilityToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductInStockRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductInStockRefreshButton_caption)#",
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
							"dataSourceName": "GridDetail_u3fligeDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "AvailabilityToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductInStockListSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductInStockListSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "AvailabilityToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductInStockListExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductInStockListExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "GridDetail_u3flige"
						}
					},
					"visible": true
				},
				"parentName": "ProductInStockListSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductInStockListImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductInStockListImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "ProductStockBalance"
						}
					},
					"visible": true
				},
				"parentName": "ProductInStockListSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductInStockListSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(ProductInStockListSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_u3flige"
					]
				},
				"parentName": "AvailabilityToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "GridContainer_bix0awl",
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
				"parentName": "AvailabilityExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridDetail_u3flige",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_u3flige",
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "GridDetail_u3fligeDS_Id",
					"columns": [
						{
							"id": "1763f7f8-5565-17fd-da1c-114fff5bf0cb",
							"code": "GridDetail_u3fligeDS_Warehouse",
							"path": "Warehouse",
							"caption": "#ResourceString(GridDetail_u3fligeDS_Warehouse)#",
							"dataValueType": 10,
							"referenceSchemaName": "Warehouse",
							"width": 213
						},
						{
							"id": "936be66f-236e-9041-3229-cf72222ec416",
							"code": "GridDetail_u3fligeDS_TotalQuantity",
							"path": "TotalQuantity",
							"caption": "#ResourceString(GridDetail_u3fligeDS_TotalQuantity)#",
							"dataValueType": 33
						},
						{
							"id": "5b48c9d1-21ac-469f-835a-bf61c9b87511",
							"code": "GridDetail_u3fligeDS_ReserveQuantity",
							"path": "ReserveQuantity",
							"caption": "#ResourceString(GridDetail_u3fligeDS_ReserveQuantity)#",
							"dataValueType": 33
						},
						{
							"id": "d7614078-78ee-97e7-04c0-8c9c836bbfd8",
							"code": "GridDetail_u3fligeDS_AvailableQuantity",
							"path": "AvailableQuantity",
							"caption": "#ResourceString(GridDetail_u3fligeDS_AvailableQuantity)#",
							"dataValueType": 33
						}
					]
				},
				"parentName": "GridContainer_bix0awl",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"GridDetail_5l564xc": {
					"isCollection": true,
					"modelConfig": {
						"path": "GridDetail_5l564xcDS"
					},
					"viewModelConfig": {
						"attributes": {
							"GridDetail_5l564xcDS_PriceList": {
								"modelConfig": {
									"path": "GridDetail_5l564xcDS.PriceList"
								}
							},
							"GridDetail_5l564xcDS_Price": {
								"modelConfig": {
									"path": "GridDetail_5l564xcDS.Price"
								}
							},
							"GridDetail_5l564xcDS_Currency": {
								"modelConfig": {
									"path": "GridDetail_5l564xcDS.Currency"
								}
							},
							"GridDetail_5l564xcDS_Tax": {
								"modelConfig": {
									"path": "GridDetail_5l564xcDS.Tax"
								}
							},
							"GridDetail_5l564xcDS_Id": {
								"modelConfig": {
									"path": "GridDetail_5l564xcDS.Id"
								}
							}
						}
					}
				},
				"GridDetail_u3flige": {
					"isCollection": true,
					"modelConfig": {
						"path": "GridDetail_u3fligeDS"
					},
					"viewModelConfig": {
						"attributes": {
							"GridDetail_u3fligeDS_Warehouse": {
								"modelConfig": {
									"path": "GridDetail_u3fligeDS.Warehouse"
								}
							},
							"GridDetail_u3fligeDS_TotalQuantity": {
								"modelConfig": {
									"path": "GridDetail_u3fligeDS.TotalQuantity"
								}
							},
							"GridDetail_u3fligeDS_ReserveQuantity": {
								"modelConfig": {
									"path": "GridDetail_u3fligeDS.ReserveQuantity"
								}
							},
							"GridDetail_u3fligeDS_AvailableQuantity": {
								"modelConfig": {
									"path": "GridDetail_u3fligeDS.AvailableQuantity"
								}
							},
							"GridDetail_u3fligeDS_Id": {
								"modelConfig": {
									"path": "GridDetail_u3fligeDS.Id"
								}
							}
						}
					}
				},
				"GridDetail_snzncmy": {
					"isCollection": true,
					"modelConfig": {
						"path": "GridDetail_snzncmyDS",
						"filterAttributes": [
							{
								"loadOnChange": true,
								"name": "GridDetail_snzncmy_PredefinedFilter"
							}
						]
					},
					"viewModelConfig": {
						"attributes": {
							"GridDetail_snzncmyDS_Unit": {
								"modelConfig": {
									"path": "GridDetail_snzncmyDS.Unit"
								}
							},
							"GridDetail_snzncmyDS_UnitShortName": {
								"modelConfig": {
									"path": "GridDetail_snzncmyDS.UnitShortName"
								}
							},
							"GridDetail_snzncmyDS_IsBase": {
								"modelConfig": {
									"path": "GridDetail_snzncmyDS.IsBase"
								}
							},
							"GridDetail_snzncmyDS_NumberOfBaseUnits": {
								"modelConfig": {
									"path": "GridDetail_snzncmyDS.NumberOfBaseUnits"
								}
							},
							"GridDetail_snzncmyDS_Id": {
								"modelConfig": {
									"path": "GridDetail_snzncmyDS.Id"
								}
							}
						}
					}
				},
				"GridDetail_snzncmy_PredefinedFilter": {
					"value": null
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"GridDetail_5l564xcDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "ProductPrice",
						"attributes": {
							"PriceList": {
								"path": "PriceList"
							},
							"Price": {
								"path": "Price"
							},
							"Currency": {
								"path": "Currency"
							},
							"Tax": {
								"path": "Tax"
							}
						}
					}
				},
				"GridDetail_u3fligeDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "ProductStockBalance",
						"attributes": {
							"Warehouse": {
								"path": "Warehouse"
							},
							"TotalQuantity": {
								"path": "TotalQuantity"
							},
							"ReserveQuantity": {
								"path": "ReserveQuantity"
							},
							"AvailableQuantity": {
								"path": "AvailableQuantity"
							}
						}
					}
				},
				"GridDetail_snzncmyDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "ProductUnit",
						"attributes": {
							"Unit": {
								"path": "Unit"
							},
							"UnitShortName": {
								"type": "ForwardReference",
								"path": "Unit.ShortName"
							},
							"IsBase": {
								"path": "IsBase"
							},
							"NumberOfBaseUnits": {
								"path": "NumberOfBaseUnits"
							}
						}
					}
				}
			},
			"dependencies": {
				"GridDetail_5l564xcDS": [
					{
						"attributePath": "Product",
						"relationPath": "PDS.Id"
					}
				],
				"GridDetail_u3fligeDS": [
					{
						"attributePath": "Product",
						"relationPath": "PDS.Id"
					}
				],
				"GridDetail_snzncmyDS": [
					{
						"attributePath": "Product",
						"relationPath": "PDS.Id"
					}
				]
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});