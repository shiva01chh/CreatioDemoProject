define("BasePageFreedomTemplate", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "Main",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
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
				"name": "MainHeader",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"padding": {
						"top": "large",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"styles": {
						"border": "none",
						"border-bottom-left-radius": 0,
						"border-bottom-right-radius": 0
					}
				}
			},
			{
				"operation": "insert",
				"name": "MainHeaderTop",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"justifyContent": "space-between",
					"wrap": "nowrap",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "MainHeaderBottom",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"visible": true,
					"justifyContent": "space-between",
					"gap": "medium",
					"wrap": "nowrap"
				}
			},
			{
				"operation": "insert",
				"name": "TitleContainer",
				"parentName": "MainHeaderTop",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "row",
					"justifyContent": "start",
					"alignItems": "flex-start",
					"wrap": "nowrap"
				}
			},
			{
				"operation": "insert",
				"name": "BackButton",
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(BackButton)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "back-button-icon",
					"clicked": {
						"request": "crt.ClosePageRequest"
					}
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
				"operation": "insert",
				"name": "CardToolsContainer",
				"parentName": "MainHeaderBottom",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"alignItems": "center",
					"justifyContent": "start",
					"items": [],
					"padding": {
						"top": "none",
						"right": "small",
						"bottom": "none",
						"left": "small"
					}
				}
			},
			{
				"operation": "insert",
				"name": "SetRecordRightsButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 3,
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(SetRecordRightsButtonCaption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "lock-button-icon",
					"clicked": {
						"request": "crt.SetRecordRightsRequest"
					},
					"clickMode": "default"
				}
			},
			{
				"operation": "move",
				"name": "ActionButtonsContainer",
				"parentName": "MainHeaderTop",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "ActionButtonsContainer",
				"values": {
					"justifyContent": "end"
				}
			},
			{
				"operation": "remove",
				"name": "ActionContainer"
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"color": "primary"
				}
			},
			{
				"operation": "merge",
				"name": "CloseButton",
				"values": {
					"color": "default"
				}
			},
			{
				"operation": "move",
				"name": "CardToggleContainer",
				"parentName": "MainHeaderBottom",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CardContentWrapper",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(64px, 1fr)"
					],
					"rows": "1fr",
					"gap": {
						"columnGap": "small",
						"rowGap": "small"
					},
					"padding": {
						"left": "small",
						"right": "small"
					},
					"stretch": true,
					"fitContent": true,
					"items": []
				},
				"parentName": "MainContainer",
				"propertyName": "items",
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
