﻿define("PortalMktgActivityEditPage", ["PortalMktgActivitiesConstants", "ConfigurationConstants", "terrasoft"],
	function(PortalMktgActivitiesConstants, ConfigurationConstants) {
		return {
			entitySchemaName: "MktgActivity",
			details: /**SCHEMA_DETAILS*/{

			}/**SCHEMA_DETAILS*/,
			attributes: {
				Fund: {
					lookupListConfig: {
						filter: function() {
							return this.getParntershipActiveStatusFilter();
						}
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Fund",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						},
						"visible": false
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Url",
					"values": {
						"layout": {
							"column": 12,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},

				{
					"operation": "insert",
					"name": "MarketingActivityControlGroup",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.MarketingActivityGroupCaption"
						}
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "MarketingActivityControlGroup_GridLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "MarketingActivityControlGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"layout": {
							"column": 1,
							"row": 0,
							"colSpan": 20,
							"rowSpan": 3
						},
						"contentType": this.Terrasoft.ContentType.LONG_TEXT,
						"labelConfig": {
							"visible": false
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						}
					},
					"parentName": "MarketingActivityControlGroup_GridLayout",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/,
			rules: {},
			methods: {

				/**
				 * Create filter for active partnership status.
				 * protected
				 * @returns {Object}
				 */
				getParntershipActiveStatusFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("ActivePartnership", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"Partnership.IsActive", 1));
					return filterGroup;
				},

				/**
				 * Sets MktgActivity default type.
				 * @protected
				 * @virtual
				 */
				setMktgActivityDefaultType: function() {
					this.$MktgActivityType = {
						value: ConfigurationConstants.MktgActivity.Type.PartnersActivityType
					};
				},

				/**
				* @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#setDefaultValues
				* @overriden
				*/
				setDefaultValues: function(callback, scope) {
					this.callParent([function() {
						this.setMktgActivityDefaultType();
						var account = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT.value;
						if (!this.Terrasoft.isEmptyGUID(account)) {
							this.$Account = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT;
							var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
								rootSchemaName: "Fund"
							});
							var typeFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
								"FundType", PortalMktgActivitiesConstants.FundType.Marketing);
							var joinFilter = "=[Partnership:Id:Partnership].Account";
							var filterGroup = new this.Terrasoft.createFilterGroup();
							filterGroup.addItem(
									Terrasoft.createColumnFilterWithParameter(
											Terrasoft.ComparisonType.EQUAL,
											joinFilter,
											account
									)
							);
							filterGroup.addItem(
									Terrasoft.createColumnFilterWithParameter(
											Terrasoft.ComparisonType.EQUAL,
											"=[Partnership:Id:Partnership].IsActive", true));
							esq.filters.addItem(filterGroup);
							esq.filters.addItem(typeFilter);
							esq.getEntityCollection(function(response) {
								if (response && response.success) {
									var collection = response.collection;
									if (collection && collection.getCount() > 0) {
										var mktgFund = collection.getByIndex(0);
										this.set("Fund", {
											value: mktgFund.values.Id
										});
									}
									callback.call(scope);
								}
							}, this);
						} else {
							callback.call(scope);
						}
					}, this]);
				}
			},
			userCode: {}
		};
	});
