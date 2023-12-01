﻿define("SupplyPaymentTemplateSection", ["ConfigurationEnums", "GridUtilitiesV2"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "SupplyPaymentTemplate",
			contextHelpId: "",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "SeparateModeBackButton",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items",
					"index": 2,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.CloseButtonCaption"},
						"click": {"bindTo": "closeSection"},
						"classes": {
							"textClass": ["actions-button-margin-right"],
							"wrapperClass": ["actions-button-margin-right"]
						},
						"visible": {"bindTo": "SeparateModeActionsButtonVisible"}
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				/**
				 * ####### ######### ######## "######## # ######".
				 * @overridden
				 */
				IsIncludeInFolderButtonVisible: {value: false},

				/**
				 * ####### ######### ######## "######### #####".
				 * @overridden
				 */
				IsSummarySettingsVisible: {value: false},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#UseSeparatedPageHeader
				 * @overridden
				 */
				"UseSeparatedPageHeader": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: true
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#UseSectionHeaderCaption
				 * @overridden
				 */
				"UseSectionHeaderCaption": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: true
				}
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getDefaultDataViews
				 * @overridden
				 */
				getDefaultDataViews: function() {
					var dataViews = this.callParent(arguments);
					delete dataViews.AnalyticsDataView;
					return dataViews;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isMultiSelectVisible
				 * @overridden
				 */
				isMultiSelectVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isSingleSelectVisible
				 * @overridden
				 */
				isSingleSelectVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#isUnSelectVisible
				 * @overridden
				 */
				isUnSelectVisible: function() {
					return false;
				},

				/**
				 * Returns to previous state.
				 * @protected
				 * @virtual
				 */
				closeSection: function() {
					var module = "LookupSection";
					this.sandbox.publish("PushHistoryState", {
						hash: this.Terrasoft.combinePath("SectionModuleV2", module)
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
				 * @overridden
				 */
				getModuleCaption: function() {
					var historyState = this.sandbox.publish("GetHistoryState");
					var state = historyState.state;
					if (state && state.caption) {
						return state.caption;
					}
					if (this.entitySchema) {
						var headerTemplate = this.get("Resources.Strings.HeaderCaptionTemplate");
						return Ext.String.format(headerTemplate, this.entitySchema.caption);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getProfileKey
				 * @overridden
				 */
				getProfileKey: function() {
					var currentTabName = this.getActiveViewName();
					var schemaName = this.name;
					return schemaName + this.entitySchemaName + "GridSettings" + currentTabName;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#addCardHistoryState
				 * @overridden
				 */
				addCardHistoryState: function(schemaName, operation, primaryColumnValue) {
					if (!schemaName) {
						return;
					}
					var cardOperationConfig = {
						schemaName: schemaName,
						operation: operation,
						primaryColumnValue: primaryColumnValue
					};
					var historyState = this.getHistoryStateInfo();
					var stateConfig = this.getCardHistoryStateConfig(cardOperationConfig);
					var eventName = (historyState.workAreaMode === ConfigurationEnums.WorkAreaMode.COMBINED)
							? "ReplaceHistoryState"
							: "PushHistoryState";
					this.sandbox.publish(eventName, stateConfig);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#removeCardHistoryState
				 * @overridden
				 */
				removeCardHistoryState: function() {
					var module = "LookupSectionModule";
					var schema = this.name;
					var historyState = this.sandbox.publish("GetHistoryState");
					var currentState = historyState.state;
					var newState = {
						moduleId: currentState.moduleId
					};
					var hash = [module, schema].join("/");
					this.sandbox.publish("PushHistoryState", {
						hash: hash,
						stateObj: newState,
						silent: true
					});
				}
			}
		};
	});
