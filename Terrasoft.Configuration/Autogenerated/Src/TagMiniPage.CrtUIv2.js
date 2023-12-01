﻿define("TagMiniPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "ContinueInOtherPageButton"
			},
			{
				"operation": "insert",
				"name": "Name",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.Name",
					"labelPosition": "above",
					"control": "$Name"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Color",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ColorPicker",
					"label": "$Resources.Strings.Color",
					"labelPosition": "above",
					"control": "$Color",
					"pickerMode": "extended"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "TagAccess",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.TagAccess",
					"labelPosition": "above",
					"control": "$TagAccess",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "SetRecordRightsFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": false,
					"alignItems": "flex-start",
					"justifyContent": "center",
					"gap": "none",
					"wrap": "nowrap",
					"padding": {
						"top": "small",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"color": "transparent",
					"borderRadius": "none"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "SetRecordRightsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(SetRecordRightsButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "left-icon",
					"visible": false,
					"icon": "contact-lock-icon",
					"clicked": {
						"request": "crt.SetRecordRightsRequest",
						"params": {
							"openInModalWindow": true
						}
					},
					"clickMode": "default",
					"layoutConfig": {}
				},
				"parentName": "SetRecordRightsFlexContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"Name": {
						"modelConfig": {
							"path": "TagDS.Name"
						}
					},
					"Color": {
						"modelConfig": {
							"path": "TagDS.Color"
						}
					},
					"TagAccess": {
						"modelConfig": {
							"path": "TagDS.TagAccess"
						}
					},
					"EntitySchemaName": {
						"modelConfig": {
							"path": "TagDS.EntitySchemaName"
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
						"TagDS": {
							"type": "crt.EntityDataSource",
							"scope": "page",
							"config": {
								"entitySchemaName": "Tag"
							}
						}
					},
					"primaryDataSourceName": "TagDS"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});