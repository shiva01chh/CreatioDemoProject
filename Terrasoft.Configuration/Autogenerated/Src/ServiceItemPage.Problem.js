define("ServiceItemPage", [],
	function() {
		return {
			entitySchemaName: "ServiceItem",
			details: /**SCHEMA_DETAILS*/{
				"Problems": {
					"schemaName": "ProblemInServiceItemDetail",
					"entitySchemaName": "Problem",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ServiceItem"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Problems",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 2
				}
			]/**SCHEMA_DIFF*/,
			mixins: {},
			attributes: {},
			methods: {},
			rules: {},
			userCode: {}
		};
	});
