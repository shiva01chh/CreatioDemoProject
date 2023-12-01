﻿define("EmailItemSchema", ["BusinessRuleModule", "EmailConstants"], function(BusinessRuleModule, EmailConstants) {
	return {
		entitySchemaName: EmailConstants.entitySchemaName,
		methods: {},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		rules: {
			"Document": {
				"FiltrationDocumentByOpportunity": {
					"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
					"autocomplete": true,
					"autoClean": true,
					"baseAttributePatch": "Opportunity",
					"comparisonType": Terrasoft.ComparisonType.EQUAL,
					"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					"attribute": "Opportunity"
				}
			}
		}
	};
});
