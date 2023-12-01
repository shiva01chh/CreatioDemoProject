define("LeadPageV2", function() {
		return {
			entitySchemaName: "Lead",
			details: /**SCHEMA_DETAILS*/{

			}/**SCHEMA_DETAILS*/,
			methods: {

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "LeadPageSourceInfoBlock",
					"propertyName": "items",
					"name": "Campaign",
					"values": {
						"layout": {"column": 12, "row": 2, "colSpan": 12}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageSourceInfoBlock",
					"propertyName": "items",
					"name": "BulkEmail",
					"values": {
						"layout": {"column": 12, "row": 3, "colSpan": 12}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
