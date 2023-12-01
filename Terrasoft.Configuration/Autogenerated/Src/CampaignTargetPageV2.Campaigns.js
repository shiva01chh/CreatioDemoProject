define("CampaignTargetPageV2", [], function() {
		return {
			entitySchemaName: "CampaignTarget",
			attributes: {
				"Campaign": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP
				},
				"Contact": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						filters: [
							function() {
								var campaign = this.get("Campaign");
								var filterGroup = Ext.create("Terrasoft.FilterGroup");
								var existsSubFilters = this.Terrasoft.createFilterGroup();
								existsSubFilters.addItem(this.Terrasoft.createColumnFilterWithParameter(
									Terrasoft.ComparisonType.EQUAL, "Campaign", campaign.value));
								filterGroup.add("Exists",
									Terrasoft.createNotExistsFilter("[CampaignTarget:Contact].Id",
										existsSubFilters));
								return filterGroup;
							}
						]
					}
				}
			},
			details: /**SCHEMA_DETAILS*/{
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Campaign",
					"values": {
						"bindTo": "Campaign",
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"enabled": false
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Contact",
					"values": {
						"bindTo": "Contact",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "remove",
					"name": "actions"
				}
			]/**SCHEMA_DIFF*/
		};
	});
