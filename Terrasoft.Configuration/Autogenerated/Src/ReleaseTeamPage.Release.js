define("ReleaseTeamPage", ["BusinessRuleModule", "BaseFiltersGenerateModule"],
	function(BusinessRuleModule, BaseFiltersGenerateModule) {
		return {
			entitySchemaName: "ReleaseTeam",
			rules: {
				"Status": {
					"NotFinal": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "IsFinal",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.CONSTANT,
						"value": false
					},
					"NotDefault": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "Id",
						"comparisonType": this.Terrasoft.ComparisonType.NOT_EQUAL,
						"type": BusinessRuleModule.enums.ValueType.SYSSETTING,
						"value": "ReleaseStatusDef"
					}
				}
			}
		};
	});
