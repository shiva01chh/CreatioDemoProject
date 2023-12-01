Terrasoft.configuration.Structures["LinkOrderFilterMixin"] = {innerHierarchyStack: ["LinkOrderFilterMixin"]};
  define("LinkOrderFilterMixin", [],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.LinkOrderFilterMixin
		 * Mixin, that implements filtration to lookupListConfig.
		 */
		Ext.define("Terrasoft.configuration.mixins.LinkOrderFilterMixin", {
			alternateClassName: "Terrasoft.LinkOrderFilterMixin",

			/**
			 * Add Contact and Account filters for Order column
			 */
			filterOrderByContactAndAccount: function() {
				let contact = this.get("Contact");
				let account = this.get("Account");
				let filterGroup = this.Ext.create("Terrasoft.FilterGroup");
				if (!this.Ext.isEmpty(contact) || !this.Ext.isEmpty(account)) {
					let byContactOrAccountFilterGroup = Ext.create("Terrasoft.FilterGroup");
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
		});
	});


