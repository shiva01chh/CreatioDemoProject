﻿define("AccountSectionV2", ["LookupUtilities", "RightUtilities"],
	function(LookupUtilities, RightUtilities) {
		return {
			entitySchemaName: "Account",
			methods: {
				/**
				 * ######### ######## ####### "#####-####" ###### ###########
				 * @protected
				 * @param args
				 */
				setPriceList: function(args) {
					var records = this.getSelectedItems();
					var selectedCount = records.length;
					var collection = args.selectedRows;
					if (records && records.length && collection.getCount() > 0) {
						var priceList = collection.getByIndex(0);
						RightUtilities.checkCanEditRecords({
							schemaName: "Account",
							primaryColumnValues: records
						}, function(result) {
							var items = result;
							var batch = this.Ext.create("Terrasoft.BatchQuery");
							var grid = this.getGridData();
							Terrasoft.each(items, function(item) {
								if (item.Value) {
									var row = grid.find(item.Key);
									if (row) {
										var rowValue = {
											value: priceList.value,
											displayValue: priceList.displayValue
										};
										row.set("PriceList", rowValue);
									}
									var update = this.Ext.create("Terrasoft.UpdateQuery", {
										rootSchemaName: "Account"
									});
									update.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
										this.Terrasoft.ComparisonType.EQUAL, "Id", item.Key));
									update.setParameterValue("PriceList", priceList.Id,
										this.Terrasoft.DataValueType.GUID);
									batch.add(update, function() {}, this);
								}
							}, this);
							if (batch.queries.length) {
								batch.execute(function() {
									this.Terrasoft.showInformation(
										this.Ext.String.format(
											this.get("Resources.Strings.AccountsChangedMessage"),
											items.length, selectedCount));
								}, this);
							}
						}, this);
					}
				},

				/**
				 * ######### ######## ###### ## ########### "#####-#####"
				 * @protected
				 */
				openPriceListLookup: function() {
					var config = {
						entitySchemaName: "Pricelist",
						enableMultiSelect: false,
						hideActions: true
					};
					LookupUtilities.Open(this.sandbox, config, this.setPriceList, this, null, false, false);
				}
			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);
