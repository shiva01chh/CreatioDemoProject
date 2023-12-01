define("EmailPageV2", ["LinkOrderFilterMixin", "ConfigurationConstants"],
	function() {
		return {
			entitySchemaName: "Activity",
			methods: {
				/**
				 * ######## ######## ####### ## ##### # ####### ######.
				 * @overridden
				 * @param {Object} entity ##### ##########.
				 */
				copyEntityColumnValues: function(entity) {
					var order = entity.get("Order");
					if (order) {
						this.set("Order", order);
					}
					this.callParent(arguments);
				},

				/**
				 * ########## ###### ########### #######.
				 * @private
				 * @overridden
				 * @return {Array} ###### #######.
				 */
				getEmailSelectColumns: function() {
					var columnsArray = this.callParent(arguments);
					columnsArray.push("Order");
					return columnsArray;
				}
			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
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
			rules: {}
		};
	});
