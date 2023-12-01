﻿define("LeadPageV2", function() {
	return {
		entitySchemaName: "Lead",
		details: /**SCHEMA_DETAILS*/{
			SiteEvent: {
				schemaName: "SiteEventDetailV2",
				entitySchemaName: "SiteEvent",
				filter: {
					masterColumn: "BpmSessionId",
					detailColumn: "BpmSessionId"
				}
			}
		}/**SCHEMA_DETAILS*/,
		methods: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "LeadEngagementTab",
				"propertyName": "items",
				"name": "SiteEvent",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 0
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "Event",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
