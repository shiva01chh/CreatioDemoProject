define("SupportLevelLookupEditPageV2", ["ext-base", "terrasoft", "SupportLevelLookupEditPageV2Resources"],
	function() {
		return {
			entitySchemaName: "SupportLevel",
			details: /**SCHEMA_DETAILS*/{
				"PriorityInSupportLevelDetail": {
					"schemaName": "PriorityInSupportLevelDetailV2",
					"entitySchemaName": "PriorityInSupportLevel",
					"filter": {
						"detailColumn": "SupportLevel",
						"masterColumn": "Id"
					}
				}
			}/**SCHEMA_DETAILS*/,
			methods: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "Name"
				},
				{
					"operation": "remove",
					"name": "Description"
				},
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 7,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 7,
							"rowSpan": 1
						},
						"contentType": this.Terrasoft.ContentType.LONG_TEXT
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "PriorityInSupportLevelTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.PriorityInSupportLevelTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "PriorityInSupportLevelTab",
					"propertyName": "items",
					"name": "PriorityInSupportLevelDetail",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				}
			]/**SCHEMA_DIFF*/
		};
	});
