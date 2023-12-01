﻿define("CaseConfItemUtility", [],
	function() {
		/**
		 * @class Terrasoft.configuration.mixins.CaseConfItemUtility
		 * Mixin, that implements work with configuration item on page.
		 */
		Ext.define("Terrasoft.configuration.mixins.CaseConfItemUtility", {
			alternateClassName: "Terrasoft.CaseConfItemUtility",
			/**
			 * Forms configuration item's collection.
			 * @protected
			 * @param {String} filter configuration item's collection filter.
			 * @param {String} list configuration item's collection.
			 */
			onPrepareConfItem: function(filter, list) {
				var contact = this.get("Contact");
				if (!contact || !contact.value) {
					return;
				}
				var query = this.getConfItemQuery(contact.value);
				query.getEntityCollection(function(result) {
					this.fillConfItemCollection(result, list);
				}, this);
			},

			/**
			 * Forms query that select suitable configuration items.
			 * @protected
			 * @param {String} contactId Contact identifier.
			 * @return {Terrasoft.EntitySchemaQuery} Query that select suitable configuration items.
			 */
			getConfItemQuery: function(contactId) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "ConfItem"
				});
				esq.addColumn("Id");
				esq.addColumn("Name");
				esq.filters.add("ConfItemUser", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "[ConfItemUser:ConfItem].Contact", contactId));
				return esq;
			},

			/**
			 * Fills the configuration items collection.
			 * @protected
			 * @param {Function} esq Query that select suitable configuration item.
			 * @param {Terrasoft.BaseSchemaViewModel} scope Execution context of callback function.
			 * @param {String} list Configuration items collection.
			 */
			fillConfItemCollection: function(result, list) {
				var entities = result.collection.getItems();
				var items = {};
				this.Terrasoft.each(entities, function(entity) {
					var primaryValue = entity.get("Id");
					var primaryDisplayValue = entity.get("Name");
					items[primaryValue] = {
						value: primaryValue,
						displayValue: primaryDisplayValue
					};
				});
				list.clear();
				list.loadAll(items);
			},

			/**
			 * Returns configuration item filter group.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getConfItemFilters: function() {
				var filterGroup = new this.Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
				var contact = this.get("Contact");
				this.addConfItemFilterByContact(contact, filterGroup);
				var account = this.get("Account");
				var accounts = this.getConfItemFilterAccounts(contact, account);
				var accountGroup = this.getConfItemFilterByAccount(accounts);
				if (accountGroup) {
					var departmentGroup = this.getConfItemFilterByDepartment(contact);
					accountGroup.addItem(departmentGroup);
					filterGroup.addItem(accountGroup);
				}
				return filterGroup;
			},

			/**
			 * Adds configuration item filter by contact.
			 * @param {String} Contact identifier.
			 * @param {Terrasoft.FilterGroup} Filter group.
			 * @protected
			 */
			addConfItemFilterByContact: function(contact, filterGroup) {
				if (!contact) {
					return null;
				}
				filterGroup.add("ContactFilter", this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "[ConfItemUser:ConfItem].Contact", contact.value));
			},

			/**
			 * Returns configuration item filter by account.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getConfItemFilterByAccount: function(accounts) {
				if (accounts.length === 0) {
					return null;
				}
				var accountFilterGroup = new this.Terrasoft.createFilterGroup();
				accountFilterGroup.add("AccountFilter", this.Terrasoft.createColumnInFilterWithParameters(
					"[ConfItemUser:ConfItem].Account", accounts));
				return accountFilterGroup;
			},

			/**
			 * Returns configuration item filter by department.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getConfItemFilterByDepartment: function(contact) {
				var filters = new this.Terrasoft.createFilterGroup();
				filters.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
				filters.add("DepartmentNullFilter", this.Terrasoft.createColumnIsNullFilter(
					"[ConfItemUser:ConfItem].Department"));
				if (contact) {
					filters.add("DepartmentFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"[ConfItemUser:ConfItem].Department.[Contact:Department:Id].Id", contact.value));
				}
				return filters;
			},

			/**
			 * Returns configuration item filter by account.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getConfItemFilterAccounts: function(contact, account) {
				var accounts = [];
				var contactAccount = null;
				if (contact) {
					contactAccount = contact.Account;
					if (contactAccount && contactAccount.value !== this.Terrasoft.GUID_EMPTY) {
						accounts.push(contactAccount.value);
					}
				}
				if (account && account.value && account.value !== this.Terrasoft.GUID_EMPTY && (!contactAccount ||
					contactAccount.value !== account.value)) {
					accounts.push(account.value);
				}
				return accounts;
			}
		});
	});
