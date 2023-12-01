﻿define("BulkEmailHyperlinkPageV2", [],
		function() {
			return {
				entitySchemaName: "BulkEmailHyperlink",
				attributes: {
					"Caption": {
						type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
						name: "Caption",
						columnPath: "Caption",
						dataValueType: Terrasoft.DataValueType.TEXT
					}
				},
				details: /**SCHEMA_DETAILS*/{
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "remove",
						"name": "actions"
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "Caption",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "Url",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12
							},
							"enabled": false
						}
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "ClicksCount",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							},
							"enabled": false
						}
					}
				]/**SCHEMA_DIFF*/
			};
		}
);
