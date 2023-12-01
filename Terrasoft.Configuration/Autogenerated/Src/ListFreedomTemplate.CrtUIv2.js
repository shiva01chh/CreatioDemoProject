// Parent: BaseGridSectionTemplate
define("ListFreedomTemplate", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "Main",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"gap": "none",
					"stretch": true,
					"fitContent": false,
					"items": []
				}
			},
			{
				"operation": "move",
				"name": "MainHeader",
				"parentName": "Main",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "move",
				"name": "MainContainer",
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"gap": "none"
				}
			},
			{
				"operation": "merge",
				"name": "MainHeader",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"justifyContent": "space-between",
					"wrap": "nowrap",
					"padding": {
						"top": "large",
						"right": "large",
						"bottom": "small",
						"left": "large"
					},
					"color": "primary",
					"alignItems": "flex-start"
				}
			},
			{
				"operation": "insert",
				"name": "TitleContainer",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "row",
					"justifyContent": "start",
					"alignItems": "center"
				}
			},
			{
				"operation": "insert",
				"name": "PageTitle",
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.Label",
					"caption": "$HeaderCaption",
					"labelType": "headline-1",
					"labelThickness": "default",
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				}
			},
			{
				"operation": "merge",
				"name": "ActionButtonsContainer",
				"values": {
					"justifyContent": "end"
				}
			},
			{
				"operation": "move",
				"name": "ActionButtonsContainer",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "remove",
				"name": "ActionContainer"
			},
			{
				"operation": "merge",
				"name": "AddButton",
				"values": {
					"color": "primary",
					"icon": "add-button-icon",
					"iconPosition": "left-icon"
				}
			},
			{
				"operation": "insert",
				"name": "DataImportButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_Data_Import)#",
					"color": "default",
					"disabled": false,
					"layoutConfig": {},
					"size": "large",
					"iconPosition": "left-icon",
					"visible": true,
					"icon": "import-data-button-icon",
					"menuItems": [],
					"clickMode": "menu"
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 1
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
							"entitySchemaName": "#DataSourceEntityName(PDS)#"
						}
					},
					"icon": "import-button-icon"
				},
				"parentName": "DataImportButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpenLandingDesigner",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(OpenLandingDesignerCaption)#",
					"visible": true,
					"clicked": {
						"request": "crt.OpenPageRequest",
						"params": {
							"schemaName": "LandingiDesigner_Page"
						}
					},
					"icon": "webforms-button-icon"
				},
				"parentName": "DataImportButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ActionButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ActionButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "more-button-icon",
					"menuItems": [],
					"clickMode": "menu"
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "MenuItem_ExportToExel",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(MenuItem_ExportToExel_caption)#",
					"visible": true,
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "DataTable"
						}
					},
					"icon": "export-button-icon"
				},
				"parentName": "ActionButton",
				"propertyName": "menuItems",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"HeaderCaption": {
					value: "#ResourceString(DefaultHeaderCaption)#"
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
