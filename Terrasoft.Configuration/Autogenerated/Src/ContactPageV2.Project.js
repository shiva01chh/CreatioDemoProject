﻿define("ContactPageV2", ["ConfigurationConstants"], function(ConfigurationConstants) {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			Project: {
				schemaName: "ProjectDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			InternalRate: {
				schemaName: "ContactInternalRateDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			ExternalRate: {
				schemaName: "ContactExternalRateDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		methods: {
			getRateDetailsVisible: function() {
				if (this.get("Type")) {
					return this.get("Type").value === ConfigurationConstants.ContactType.Employee && Terrasoft.Features.getIsDisabled("HideSalesProject");
				}
				return false;
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"index": 7,
				"propertyName": "items",
				"name": "Project",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": Terrasoft.Features.getIsDisabled("HideSalesProject")
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"propertyName": "items",
				"name": "InternalRate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "getRateDetailsVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"propertyName": "items",
				"name": "ExternalRate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "getRateDetailsVisible"
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
