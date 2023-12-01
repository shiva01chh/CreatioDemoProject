﻿define("LinkPageV2", ["terrasoft", "BusinessRuleModule", "ext-base", "sandbox", "ConfigurationConstants"],
function(Terrasoft, BusinessRuleModule, Ext, sandbox, ConfigurationConstants) {
	return {
		properties: {
			/**
			 * @private
			 */
			_isDenyEditAttachedFileDescriptionEnabled: true
		},

		methods: {

			/**
			 * @inheritdoc
			 * @overridden
			 */
			initHeaderCaption: Terrasoft.emptyFn,

			/**
			 * @inheritdoc
			 * @overridden
			 */
			getHeader: function() {
				return this.entitySchema.caption;
			},

			/**
			 * @inheritdoc
			 * @overridden
			 */
			init: function() {
				var entitySchemaName = this.entitySchema.name;
				this.set("entitySchemaName", entitySchemaName);
				this.callParent(arguments);
				this.set("Type", {
					displayValue: "Type",
					value: ConfigurationConstants.FileType.Link
				});
				this._isDenyEditAttachedFileDescriptionEnabled =
					this.Terrasoft.Features.getIsEnabled("DenyEditAttachedFileDescription");
			},
			/**
			 * @override
			 * @returns {Terrasoft.EntitySchemaQuery}
			 */
			getEntitySchemaQuery: function() {
				let esq = this.callParent(arguments);
				if (!this._isDenyEditAttachedFileDescriptionEnabled) {
					esq.columns.removeByKey("Data");
				}
				return esq;
			}
		},

		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HeaderContainer",
				"propertyName": "items",
				"name": "LinkPageGeneralTabContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "LinkPageGeneralTabContainer",
				"propertyName": "items",
				"name": "LinkPageGeneralBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "LinkPageGeneralBlock",
				"propertyName": "items",
				"name": "Name",
				"values": {
					"bindTo": "Name",
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LinkPageGeneralBlock",
				"propertyName": "items",
				"name": "Notes",
				"values": {
					"bindTo": "Notes",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "remove",
				"name": "actions"
			},
			{
				"operation": "remove",
				"name": "ViewOptionsButton"
			}
		]/**SCHEMA_DIFF*/
	};
});
