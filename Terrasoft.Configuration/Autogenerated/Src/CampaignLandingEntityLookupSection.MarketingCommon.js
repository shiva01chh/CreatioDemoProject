define("CampaignLandingEntityLookupSection", [],
	function() {
		return {
			attributes: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#columnsFiltrationMethod
				 * @override
				 */
				columnsFiltrationMethod: function(column) {
					const dataValueType = column.dataValueType;
					var allowedTypes = [];
					if (this.columnName === "WebFormColumn") {
						allowedTypes = [
							Terrasoft.DataValueType.LOOKUP,
							Terrasoft.DataValueType.GUID
						];
					}
					if (this.columnName === "ContactColumn") {
						allowedTypes = [
							Terrasoft.DataValueType.LOOKUP
						];
					}
					return Ext.Array.contains(allowedTypes, dataValueType);
				},

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#updateColumnHandler
				 * @override
				 */
				updateColumnHandler: function(result, row, columnName) {
					row.set(columnName, result.leftExpressionColumnPath);
				},

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#getIsReadonlyColumn
				 * @override
				 */
				getIsReadonlyColumn: function(columnName) {
					return columnName === "ContactColumn" || columnName === "WebFormColumn";
				}
			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	});
