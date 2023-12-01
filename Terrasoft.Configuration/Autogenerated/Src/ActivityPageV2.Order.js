define("ActivityPageV2", ["LinkOrderFilterMixin"], function() {
	return {
		entitySchemaName: "Activity",
		mixins: {
			LinkOrderFilterMixin: "Terrasoft.LinkOrderFilterMixin"
		},
		attributes: {
			"Order": {
				lookupListConfig: {
					columns: ["Contact", "Account"],
					filters: [
						function() {
							return this.filterOrderByContactAndAccount();
						}
					]
				}
			}
		},
		rules: {},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
