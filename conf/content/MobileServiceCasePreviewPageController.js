Terrasoft.configuration.Structures["MobileServiceCasePreviewPageController"] = {innerHierarchyStack: ["MobileServiceCasePreviewPageController"]};
/* globals Case: false */
/**
 * @class Terrasoft.configuration.controller.ServiceCasePreviewPage
 */
Ext.define("Terrasoft.configuration.controller.ServiceCasePreviewPage", {
	extend: "Terrasoft.configuration.controller.CasePreviewPage",
	alternateClassName: "Terrasoft.configuration.ServiceCasePreviewPageController",

	statics: {

		/**
		 * @inheritdoc
		 */
		Model: Case

	},

	/**
	 * Opens case escalation page.
	 * @protected
	 */
	openCaseEscalationPage: function() {
		Terrasoft.util.openCachedPage("CaseEscalationPage", {
			recordId: this.record.getId()
		});
	},

	/**
	 * @inheritdoc
	 * @protected
	 * @overridden
	 */
	onActionExecutionStart: function(action) {
		var config = action.config;
		if (config.name === "escalate") {
			this.openCaseEscalationPage();
		} else {
			this.callParent(arguments);
		}
	},

	/**
	 * @protected
	 * @virtual
	 */
	getEscalateActionConfig: function() {
		return {
			name: "escalate",
			title: Terrasoft.LS.ServiceCasePreviewPageEscalateActionTitle,
			iconCls: "cf-action-escalation-icon",
			useMask: false,
			position: 4
		};
	},

	/**
	 * @inheritdoc
	 * @protected
	 * @overridden
	 */
	getCustomActions: function() {
		var actions = [this.getEscalateActionConfig()];
		var parentActions = this.callParent(arguments);
		if (parentActions) {
			actions = actions.concat(parentActions);
		}
		return actions;
	}

});


