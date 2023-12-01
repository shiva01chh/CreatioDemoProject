﻿define("ActivityMiniPage", ["BusinessRuleModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "Activity",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		rules: {
			"Document": {
				"FiltrationDocumentByAccount": {
					"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
					"autocomplete": true,
					"autoClean": true,
					"baseAttributePatch": "Account",
					"comparisonType": Terrasoft.ComparisonType.EQUAL,
					"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					"attribute": "Account"
				},
				"FiltrationDocumentByContact": {
					"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
					"autocomplete": true,
					"autoClean": true,
					"baseAttributePatch": "Contact",
					"comparisonType": Terrasoft.ComparisonType.EQUAL,
					"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					"attribute": "Contact"
				}
			}
		}
	};
});
