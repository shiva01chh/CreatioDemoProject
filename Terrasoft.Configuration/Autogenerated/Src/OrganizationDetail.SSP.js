﻿ define("OrganizationDetail", ["ConfigurationConstants"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "VwSspAdminUnit",
			attributes: {},
			methods: {
				/**
				 * @inheritdoc BaseGridDetailV2#getFilters
				 * @overridden
				 */
				getFilters: function () {
					var filters = this.callParent(arguments);
					filters.add("OrganizationFilter", Terrasoft.createColumnIsNotNullFilter("PortalAccount"));
					filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "SysAdminUnitType.Value",
						ConfigurationConstants.SysAdminUnit.Type.Organisation));
					return filters;
				},

				/**
				 * @inheritDoc Terrasoft.BasePageV2#addDetailWizardMenuItems
				 * @override
				 */
				addDetailWizardMenuItems: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @override
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @override
				 */
				getFilterDefaultColumnName: function() {
					return "PortalAccount";
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#addColumnLink
				 * @override
				 */
				addColumnLink: function(item, column) {
					var columnPath = column.columnPath;
					if (columnPath === item.primaryDisplayColumnName) {
						item["on" + columnPath + "LinkClick"] = function() {
							var value = this.get(columnPath);
							return {
								caption: value,
								target: "_self",
								title: value,
								url: window.location.hash
							};
						};
					} else {
						this.callParent(arguments);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);
