﻿define("CaseListCustomModule", ["CustomProcessPageV2Utilities"],
	function() {
		return {
			entitySchemaName: "Case",
			messages: {
				/**
				 * @message DetailActiveRowChanged
				 * Notifies page about detail active row change.
				 * @param {Object} Page config.
				 */
				"DetailActiveRowChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				BaseProcessViewModel: "Terrasoft.CustomProcessPageV2Utilities"
			},
			attributes: {},
			details: /**SCHEMA_DETAILS*/{
				Cases: {
					schemaName: "CaseDetailSelectModule",
					captionName: "CaseDetailCaption",
					filterMethod: "getCaseFilters"
				}
			}/**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * Returns case filters.
				 * @private
				 * @return {Terrasoft.FilterGroup} Case filters.
				 */
				getCaseFilters: function() {
					var parameters = this.get("ProcessData").parameters;
					var caseCollectionString = parameters.CaseCollectionParam;
					var caseCollection = caseCollectionString.split("|");
					var filters = this.Terrasoft.createFilterGroup();
					filters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					filters.addItem(this.Terrasoft.createColumnInFilterWithParameters(
						"Id", caseCollection));
					return filters;
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#getPageHeaderCaption
				 * @overridden
				 */
				getPageHeaderCaption: function() {
					return this.get("Resources.Strings.PageCaption");
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#loadVocabulary
				 * @overridden
				 */
				loadVocabulary: function(args, tag) {
					args.schemaName = this.columns[tag].referenceSchemaName;
					this.callParent(arguments);
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BasePageV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.setInitialValues();
						var subscribersIds = this.getSaveRecordMessagePublishers();
						this.sandbox.subscribe("DetailActiveRowChanged", function(config) {
							return this.onDetailActiveRowChanged(config);
						}, this, subscribersIds);
						callback.call(scope || this);
					}, this]);
				},

				/**
				 * On detail active row change handler.
				 * Sets selected case.
				 * @protected
				 */
				onDetailActiveRowChanged: function(config) {
					if (config.activeRow) {
						var activeRow = config.activeRow;
						var activeRowValue = {
							value: activeRow.get(activeRow.primaryColumnName),
							displayValue: activeRow.get(activeRow.primaryDisplayColumnName)
						};
						var caseId = activeRowValue.value;
						this.set("Result", caseId);
					}
				},

				/**
				 * Sets page initial values.
				 * @protected
				 * @virtual
				 */
				setInitialValues: function() {
					this.processParameters.push({
						key: "Result",
						value: this.Terrasoft.GUID_EMPTY
					});
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.CustomProcessPageV2Utilities#completeProcess
				 * @overridden
				 */
				completeProcess: function() {
					this.completeExecution(arguments);
				},

				/**
				 * On select button click handler.
				 * @protected
				 */
				onSelectButtonClick: function() {
					this.processParameters.push({
						key: "Result",
						value: this.get("Result")
					});
					this.completeProcess();
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "CaseTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.CaseTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "CaseTab",
					"propertyName": "items",
					"name": "Cases",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"markerValue": "CaseList"
					}
				},
				{
					"operation": "merge",
					"name": "SaveButton",
					"values": {
						"caption": {"bindTo": "Resources.Strings.SelectButtonCaption"},
						"click": {"bindTo": "onSelectButtonClick"}
					}
				},
				{
					"operation": "remove",
					"name": "CloseButton"
				},
				{
					"operation": "remove",
					"name": "DelayExecutionButton"
				},
				{
					"operation": "remove",
					"name": "actions"
				}

			]/**SCHEMA_DIFF*/,
			rules: {}
		};
	});
