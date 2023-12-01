define("BulkEmailSubscriptionPageV2", ["terrasoft"], function(Terrasoft) {
	return {
		entitySchemaName: "BulkEmailSubscription",
		attributes: {
			BulkEmailType: {
				lookupListConfig: {
					filters: [
						function() {
							var contact = this.get("Contact");
							var filterGroup = Ext.create("Terrasoft.FilterGroup");
							filterGroup.add("IsSignable",
								Terrasoft.createColumnFilterWithParameter(
									Terrasoft.ComparisonType.EQUAL,
									"IsSignable",
									1));
							var existsSubFilters = this.Terrasoft.createFilterGroup();
							existsSubFilters.addItem(this.Terrasoft.createColumnFilterWithParameter(
									Terrasoft.ComparisonType.EQUAL, "Contact", contact.value));
							filterGroup.add("Exists",
								Terrasoft.createNotExistsFilter("[BulkEmailSubscription:BulkEmailType].Id",
								existsSubFilters));
							return filterGroup;
						}
					]
				}
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"propertyName": "items",
				"name": "BulkEmailSubscriptionContainer",
				"parentName": "CardContentContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "BulkEmailSubscriptionContainer",
				"propertyName": "items",
				"name": "Contact",
				"values": {
					"layout": {"column": 0, "row": 0},
					"enabled": false
				}
			},
			{
				"operation": "insert",
				"parentName": "BulkEmailSubscriptionContainer",
				"propertyName": "items",
				"name": "BulkEmailType",
				"values": {
					"layout": {"column": 0, "row": 1}
				}
			},
			{
				"operation": "insert",
				"parentName": "BulkEmailSubscriptionContainer",
				"propertyName": "items",
				"name": "BulkEmailSubsStatus",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 2}
				}
			},
			{
				"operation": "remove",
				"name": "actions"
			}
		]/**SCHEMA_DIFF*/
	};
});
