﻿define("FundPage", [], function() {
	return {
		entitySchemaName: "Fund",
		methods: {

			/**
			 * @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#setValidationConfig
			 * @overridden
			 */
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("DueDate", this.validateDueDate);
			},

			/**
			 * Validates due date.
			 * @protected
			 * @param {Date} value Due date value.
			 * @return {Object} Validation information.
			 */
			validateDueDate: function(value) {
				var invalidMessage = null;
				if (value < this.getCurrentDate()) {
					invalidMessage = this.get("Resources.Strings.InvalidDueDateMessage");
				}
				return {
					invalidMessage: invalidMessage
				};
			},

			/**
			 * Returns current date.
			 * @protected
			 * @return {Date}
			 */
			getCurrentDate: function() {
				return Terrasoft.clearTime(new Date());
			},

			/**
			 * @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#setDefaultValues
			 * @overridden
			 */
			setDefaultValues: function(callback, scope) {
				this.callParent([function() {
					this.set("DueDate", Terrasoft.endOfYear(this.getCurrentDate()));
					callback.call(scope);
				}, this]);
			}

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "FundType",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 0},
					"enabled": {
						"bindTo": "isNewMode"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Amount",
				"values": {
					"layout": {"column": 0, "row": 1},
					"enabled": false
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "DueDate",
				"values": {
					"layout": {"column": 0, "row": 2}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Description",
				"values": {
					"layout": {"column": 0, "row": 3, "rowSpan": 3},
					"contentType": Terrasoft.ContentType.LONG_TEXT
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
