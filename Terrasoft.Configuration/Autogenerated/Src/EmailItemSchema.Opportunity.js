﻿define("EmailItemSchema", ["BusinessRuleModule", "EmailConstants"], function(BusinessRuleModule, EmailConstants) {
	return {
		entitySchemaName: EmailConstants.entitySchemaName,
		attributes: {
			"Opportunity": {
				"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
				lookupListConfig: {
					columns: ["Contact", "Account"],
					filters: [
						function() {
							var contact = this.get("Contact");
							var account = this.get("Account");
							var filterGroup = Ext.create("Terrasoft.FilterGroup");
							if (!this.Ext.isEmpty(contact) || !this.Ext.isEmpty(account)) {
								var byContactOrAccountFilterGroup = Ext.create("Terrasoft.FilterGroup");
								byContactOrAccountFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
								if (!this.Ext.isEmpty(contact)) {
									byContactOrAccountFilterGroup.add("FilterByContact",
										this.Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
											"Contact", contact.value));
								}
								if (!this.Ext.isEmpty(account)) {
									byContactOrAccountFilterGroup.add("FilterByAccount",
										this.Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
											"Account", account.value));
								}
								filterGroup.add("ByContactOrAccountFilterGroup", byContactOrAccountFilterGroup);
							}
							return filterGroup;
						}
					]
				},
				dependencies: [
					{
						columns: ["Opportunity"],
						methodName: "onOpportunityChanged"
					}
				]
			}
		},
		methods: {
			/**
			 * On opportunity changed event handler
			 */
			onOpportunityChanged: function() {
				var opportunity = this.get("Opportunity");
				if (!opportunity) {
					return;
				}
				var account = this.get("Account");
				var contact = this.get("Contact");
				var newAccount = opportunity && opportunity.Account || null;
				var newContact = opportunity && opportunity.Contact || null;
				if (this.Ext.isEmpty(account) && this.Ext.isEmpty(contact)) {
					if (newAccount) {
						this.set("Account", newAccount);
					} else if (newContact) {
						this.set("Contact", newContact);
					}
				}
			}
		},
		rules: {}
	};
});
