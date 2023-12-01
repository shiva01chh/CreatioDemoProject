define("PortalCasePage", ["PortalCasePageResources", "BusinessRuleModule", "ConfigurationEnums", "ServiceDeskConstants",
			"CaseServiceContractUtility", "CaseConfItemUtility"],
		function(resources, BusinessRuleModule, Enums, Constants) {
			return {
				entitySchemaName: "Case",
				mixins: {
					CaseServiceContractUtility: "Terrasoft.CaseServiceContractUtility",
					CaseConfItemUtility: "Terrasoft.CaseConfItemUtility"
				},
				attributes: {
					"ServicePact": {
						dataValueType: this.Terrasoft.DataValueType.LOOKUP,
						lookupListConfig: {
							filter: function() {
								return this.getServicePactFilter();
							}
						},
						dependencies: []
					},
					"ServiceItem": {
						lookupListConfig: {
							filter: function() {
								return this.getServiceItemFilters();
							}
						},
						dependencies: [
							{
								columns: ["ServicePact"],
								methodName: "onServicePactChanged"
							},
							{
								columns: ["Category"],
								methodName: "onCategoryChanged"
							}
						]
					},
					"ConfItem": {
						dataValueType: this.Terrasoft.DataValueType.LOOKUP,
						lookupListConfig: {
							hideActions: true,
							filter: function() {
								return this.getConfItemFilters();
							}
						}
					}
				},
				details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "merge",
						"name": "ServiceItem",
						"values": {
							"layout": {
								"column": 0,
								"row": 4,
								"colSpan": 24,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "insert",
						"name": "ServicePact",
						"values": {
							"bindTo": "ServicePact",
							"layout": {
								"column": 0,
								"row": 3,
								"colSpan": 24,
								"rowSpan": 1
							},
							"contentType": this.Terrasoft.ContentType.ENUM
						},
						"parentName": "ProfileContainer",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "ConfItem",
						"values": {
							"layout": {
								"column": 0,
								"row": 5,
								"colSpan": 24,
								"rowSpan": 1
							},
							"enabled": {
								"bindTo": "getConfItemEnabled"
							},
							"controlConfig": {
								"prepareList": {"bindTo": "onPrepareConfItem"}
							},
							"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
						},
						"parentName": "ProfileContainer",
						"propertyName": "items"
					}
				]/**SCHEMA_DIFF*/,
				methods: {
					/**
					 * @inheritDoc BasePageV2#onEntityInitialized
					 * @overridden
					 */
					onEntityInitialized: function() {
						this.callParent(arguments);
						this.setInitialValues();
					},

					/**
					 * @inheritdoc Terrasoft.PortalCasePage#getServiceCategoryFilters
					 * @overridden
					 */
					getServiceCategoryFilters: function() {
						var filtersCollection = this.Terrasoft.createFilterGroup();
						var servicePact = this.get("ServicePact");
						if (!servicePact) {
							return filtersCollection;
						}
						var servicePactFilter = this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL,
								"[ServiceItem:Category:Id].[ServiceInServicePact:ServiceItem].ServicePact",
								servicePact.value);
						filtersCollection.add("ServicePactFilter", servicePactFilter);
						return filtersCollection;
					},
					/**
					 * Returns configuration item control enabled.
					 * @protected
					 * @return {Boolean} Configuration item control enabled.
					 */
					getConfItemEnabled: function() {
						var status = this.get("Status");
						if (!status || !status.value) {
							return false;
						}
						return status.value === Constants.CaseState.NewRequest;
					},
					/**
					 * @inheritdoc this.Terrasoft.CaseServiceUtility#prepareServiceTermCalcultorConditions
					 * @overriden
					 */
					prepareServiceTermCalcultorConditions: function() {
						var conditions = this.callParent(arguments);
						if (conditions == null) {
							return null;
						}
						var servicePact = this.get("ServicePact");
						if (!servicePact) {
							return conditions;
						}
						conditions.push(this.prepareConditionItem("ServicePact", servicePact.value));
						return conditions;
					}
				},
				rules: {
					"ServicePact": {
						"DisabledOnEdit": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Operation"
								},
								comparisonType: this.Terrasoft.ComparisonType.NOT_EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: Enums.CardStateV2.EDIT
								}
							}]
						}
					},
					"ServiceItem": {
						"BindingServiceItemToServicePact": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"logical": this.Terrasoft.LogicalOperatorType.AND,
							"property": BusinessRuleModule.enums.Property.ENABLED,
							"conditions": [
								{
									"leftExpression": {
										"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										"attribute": "ServicePact"
									},
									"comparisonType": this.Terrasoft.ComparisonType.IS_NOT_NULL
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "Operation"
									},
									comparisonType: this.Terrasoft.ComparisonType.NOT_EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: Enums.CardStateV2.EDIT
									}
								}
							]
						}
					}
				}
			};
		});
