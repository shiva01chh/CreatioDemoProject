define("CasePage", ["BusinessRuleModule", "CaseServiceUtility", "CaseSectionActionsDashboard"],
		function(BusinessRuleModule) {
			return {
				entitySchemaName: "Case",
				details: /**SCHEMA_DETAILS*/{
					CaseLifecycle: {
						schemaName: "CaseLifecycleDetail",
						entitySchemaName: "CaseLifecycle",
						filter: {
							masterColumn: "Id",
							detailColumn: "Case"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "ServiceItem",
						"values": {
							"layout": {
								"column": 0,
								"row": 6,
								"colSpan": 24,
								"rowSpan": 1
							},
							"bindTo": "ServiceItem",
							"tip": {
								"content": {"bindTo": "Resources.Strings.ServiceItemTipMessage"}
							}
						},
						"parentName": "ProfileContainer",
						"propertyName": "items"
					},
					{
						"operation": "merge",
						"name": "CaseGroup",
						"values": {
							"layout": {
								"column": 0,
								"row": 8,
								"colSpan": 24,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "CaseOwner",
						"values": {
							"layout": {
								"column": 0,
								"row": 9,
								"colSpan": 24,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "CaseAssignToMeButton",
						"values": {
							"layout": {
								"column": 0,
								"row": 10,
								"colSpan": 24,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "NewCaseProfileInfoContainer",
						"values": {
							"layout": {
								"column": 0,
								"row": 11,
								"colSpan": 24,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "insert",
						"name": "CaseLifecycle",
						"parentName": "CaseInformationTab",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					}
				]/**SCHEMA_DIFF*/,
				mixins: {
					/**
					 * @class CaseServiceUtility implements work with service item on page.
					 */
					CaseServiceUtility: "Terrasoft.CaseServiceUtility"
				},
				attributes: {

					/**
					 * DcmSchema.
					 */
					"DcmSchema": {
						dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						"dependencies": [
							{
								"columns": ["DcmSchema"],
								"methodName": "initResolvedButton"
							}
						]
					},
					/**
					 * ServiceItem column value.
					 */
					"ServiceItem": {
						"lookupListConfig": {
							filter: function() {
								return this.getServiceItemFilter();
							}
						},
						"dependencies": [
							{
								"columns": ["ServiceItem"],
								"methodName": "onServiceItemChanged"
							}
						]
					},
					/**
					 * Priority column value.
					 */
					"Priority": {
						"dependencies": [
							{
								"columns": ["Priority"],
								"methodName": "onPriorityChanged"
							}
						]
					},

					/**
					 * Check if need save after recalculation for reclassification process.
					 */
					"NeedSaveAfterRecalculation": {
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: Terrasoft.DataValueType.BOOLEAN,
						value: false
					},

					/**
					 * RegisteredOn column value.
					 */
					"RegisteredOn": {
						"dependencies": [
							{
								"columns": ["RegisteredOn"],
								"methodName": "onRegisteredOnChanged"
							}
						]
					},
					"OriginalServiceItem": {
						dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT
					}
				},
				methods: {

					/**
					 * The action which will be invoked after case terms recalculated.
					 * @protected
					 */
					onCaseTermsRecalculated: function(){
						if (this.get("NeedSaveAfterRecalculation")) {
							this.save();
							this.set("NeedSaveAfterRecalculation", false);
						}
					},

					/**
					 * @inheritdoc this.Terrasoft.CasePage#initResolvedButton
					 * @overriden
					 */
					initResolvedButton: function(){
						if(this._isNeedToInitResolvedButton()) {
							this.callParent(arguments);
						}
					},

					/**
					 * Check if initResolvedButton must be called.
					 * @private
					 * @return {Boolean} CaseNextStatusCollection.
					 */
					_isNeedToInitResolvedButton: function() {
						return this.getIsFeatureEnabled("CaseStagesFromDCM") ? this.get("DcmSchema") : true;
					},

					/**
					 * Callback for getDefaultCaseTermStrategy method.
					 * @protected
					 * @abstract
					 */
					getStrategyCallback: Terrasoft.emptyFn,

					/**
					 * @inheritdoc this.Terrasoft.CasePage#setInitialValues
					 * @overriden
					 */
					setInitialValues: function() {
						this.callParent(arguments);
						this.getDefaultCaseTermStrategy(this.getStrategyCallback);
					},

					/**
					 * @inheritdoc Terrasoft.CasePage#handlePausedStatus
					 * @overridden
					 */
					handlePausedStatus: function(status) {
						if (status.IsPaused) {
							this.set("SolutionDateGetter", this.get("SolutionDate"));
							if (!this.getIsFeatureEnabled("ServiceTerms") &&
								this.get("IsOriginalStatusPaused") === false && this.get("SolutionDateGetter")) {
								this.calculateRemains(true);
							}
						} else {
							if (this.get("IsOriginalStatusPaused")) {
								if (this.getIsFeatureEnabled("ServiceTerms")) {
									this.recalculateServiceTerms();
								} else {
									this.calculateDateAfterPause(status.IsResolved);
								}
							}
						}
					},

					/**
					 * @inheritdoc Terrasoft.CasePage#updateOriginals
					 * @overridden
					 */
					updateOriginals: function(cleanOriginalServiceItem) {
						this.set("OriginalServiceItem", cleanOriginalServiceItem ? null : this.get("ServiceItem"));
						this.callParent(arguments);
					}
				},
				modules: {
					ActionsDashboardModule: {
						"config": {
							"isSchemaConfigInitialized": true,
							"schemaName": "CaseSectionActionsDashboard",//Schema name
							"useHistoryState": false,
							"parameters": {
								"viewModelConfig": {//Module schema config
									"entitySchemaName": "Case",
									"actionsConfig": {
										"schemaName": "CaseStatus",
										"columnName": "Status",
										"colorColumnName": "Color",
										"filterColumnName": "IsDisplayed",
										"orderColumnName": "StageNumber",
										"decouplingConfig": {
											"name": "CaseNextStatus",
											"masterColumnName": "Status",
											"referenceColumnName": "NextStatus"
										}
									},
									"dashboardConfig": {//dashboards elements config
										"Activity": {//Config to connect activity and page instance
											"masterColumnName": "Id",//Page instance column name
											"referenceColumnName": "Case"//Activity object column name
										}
									}
								}
							}
						}
					}
				},
				rules: {
					"ServiceItem": {
						"BindingServiceItemToOriginalServiceItem": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"property": BusinessRuleModule.enums.Property.ENABLED,
							"conditions": [{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "OriginalServiceItem"
								},
								"comparisonType": this.Terrasoft.ComparisonType.IS_NULL
							}]
						}
					}
				},
				userCode: {}
			};
		});
