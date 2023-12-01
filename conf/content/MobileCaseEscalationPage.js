Terrasoft.configuration.Structures["MobileCaseEscalationPage"] = {innerHierarchyStack: ["MobileCaseEscalationPage"]};
/* globals Case: false */
Terrasoft.PageCache.addItem("CaseEscalationPage", {
	controllerName: "Terrasoft.configuration.controller.CaseEscalationPage",
	pageSchemaName: "CaseEscalationPage",
	viewXClass: "Terrasoft.configuration.view.CaseEscalationPage"
});

/**
 * @class Terrasoft.configuration.view.CaseEscalationPage
 */
Ext.define("Terrasoft.configuration.view.CaseEscalationPage", {
	extend: "Terrasoft.view.BaseEditPage",

	config: {

		/**
		 * @inheritdoc
		 */
		id: "CaseEscalationPage"

	}

});

/**
 * @class Terrasoft.configuration.controller.CaseEscalationPage
 */
Ext.define("Terrasoft.configuration.controller.CaseEscalationPage", {
	extend: "Terrasoft.configuration.controller.EditPage",

	config: {

		refs: {

			/**
			 * @inheritdoc
			 */
			view: "#CaseEscalationPage"

		},

		pageType: Terrasoft.PageTypes.Custom,

		/**
		 * @inheritdoc
		 */
		businessRuleConfigs: [{
			name: "CaseEscalationOwnerOrGroupRequirementRule",
			ruleType: Terrasoft.RuleTypes.Requirement,
			requireType: Terrasoft.RequirementTypes.OneOf,
			events: [Terrasoft.BusinessRuleEvents.Save, Terrasoft.BusinessRuleEvents.ValueChanged],
			triggeredByColumns: ["Owner", "Group"]
		}],

		/**
		 * @inheritdoc
		 */
		columnConfigs: [
			{
				name: "SupportLevel"
			},
			{
				name: "Owner",
				customEditConfig: {
					required: true
				}
			},
			{
				name: "Group",
				customEditConfig: {
					required: true
				}
			}
		]

	},

	statics: {

		/**
		 * @inheritdoc
		 */
		Model: Case

	},

	/**
	 * @inheritdoc
	 * @protected
	 * @overridden
	 */
	getCustomTitle: function() {
		return Terrasoft.LS.CaseEscalationPageTitle;
	}

});


