define("QueueOperatorDetailPageV2", [], function() {
	return {
		entitySchemaName: "QueueOperator",
		methods: {
			/**
			 * @inheritdoc Terrasoft.BasePageV2#getDefaultValues
			 * @overridden
			 */
			getDefaultValues: function() {
				var defValues = this.callParent(arguments);
				defValues.push({
						name: "Active",
						value: true
					});
				return defValues;
			},

			/**
			 * @inheritdoc BasePageV2#initActionButtonMenu
			 * @overridden
			 */
			initActionButtonMenu: this.Terrasoft.emptyFn
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Operator",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"bindTo": "Operator",
					"enabled": false,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"name": "Active",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"bindTo": "Active",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
