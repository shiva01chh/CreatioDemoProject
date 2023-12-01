define("PartnershipPage", ["terrasoft"],
		function() {
			return {
				entitySchemaName: "Partnership",
				details: /**SCHEMA_DETAILS*/{
					"MarketingActivitiesDetail": {
						"schemaName": "PartnershipPageMktgActivityDetail",
						"entitySchemaName": "MktgActivity",
						"filter": {
							"detailColumn": "Partnership",
							"masterColumn": "Id"
						}
					}
				}/**SCHEMA_DETAILS*/,
				attributes: {
					"MarketingActivities": {
						"dataValueType": Terrasoft.DataValueType.INTEGER,
						"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						"caption": {
							"bindTo": "Resources.Strings.MarketingActivitiesCaption"
						}
					}
				},
				methods: {

					/**
					 * @inheritdoc Terrasoft.BaseViewModel#getEntitySchemaQuery
					 * @overridden
					 */
					getEntitySchemaQuery: function() {
						var esq = this.callParent(arguments);
						this.addMarketingActivitiesColumn(esq);
						return esq;
					},

					/**
					 * @inheritDoc BaseViewModel#setColumnValues
					 * @overridden
					 */
					setColumnValues: function(entity) {
						this.set("MarketingActivities", entity.get("MarketingActivities"));
						this.callParent(arguments);
					},

					/**
					 * Adds total Marketing Activities Column to esq.
					 * @protected
					 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
					 */
					addMarketingActivitiesColumn: function(esq) {
						var expressionConfig = {
							columnPath: "[PartnershipParameter:Partnership].IntValue",
							parentCollection: this
						};
						var column = Ext.create("Terrasoft.SubQueryExpression", expressionConfig);
						var marketingActivityFilter = Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "PartnerParamCategory",
								Terrasoft.PRMEnums.PartnerParamCategory.MarketingActivities);
						column.subFilters.addItem(marketingActivityFilter);
						var partnershipParameterTypeFilter = esq.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL,
								"PartnershipParameterType", Terrasoft.PRMEnums.PartnershipParamType.Current);
						column.subFilters.addItem(partnershipParameterTypeFilter);
						var parameterTypeFilter = esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
								"ParameterType", Terrasoft.PRMEnums.ParameterType.Obligation);
						column.subFilters.addItem(parameterTypeFilter);
						var esqColumn = esq.addColumn("MarketingActivities");
						esqColumn.expression = column;
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "MarketingActivities",
						"values": {
							"layout": {
								"colSpan": 12,
								"column": 12,
								"row": 0
							},
							"enabled": false
						},
						"parentName": "PartnershipGeneralInfoBlock",
						"propertyName": "items"
					},
					{
						"operation": "insert",
						"name": "MarketingActivitiesTab",
						"values": {
							"caption": {"bindTo": "Resources.Strings.MarketingActivitiesTabCaption"},
							"items": []
						},
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 1
					},
					{
						"operation": "insert",
						"name": "MarketingActivitiesDetail",
						"values": {
							"itemType": 2,
							"markerValue": "added-detail"
						},
						"parentName": "MarketingActivitiesTab",
						"propertyName": "items",
						"index": 3
					}
				]/**SCHEMA_DIFF*/,
				rules: {},
				userCode: {}
			};
		});
