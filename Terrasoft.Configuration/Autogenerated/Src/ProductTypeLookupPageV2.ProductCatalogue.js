﻿define("ProductTypeLookupPageV2", ["ProductTypeLookupPageV2Resources", "ConfigurationEnums"],
	function(resources, ConfigurationEnums) {
		return {
			entitySchemaName: "ProductType",
			attributes: {},
			messages: {},
			methods: {
				/**
				 * Opens the new record page.
				 * @param {String} typeColumnValue Value of column type.
				 * @protected
				 */
				addRecord: function(typeColumnValue) {
					if (!typeColumnValue) {
						var editPages = this.get("EditPages");
						if (editPages.getCount() > 1) {
							return false;
						}
						var tag = this.get("AddRecordButtonTag");
						typeColumnValue = tag || this.Terrasoft.GUID_EMPTY;
					}
					var schemaName = this.getEditPageSchemaName(typeColumnValue);
					this.openCardInChain({
						schemaName: schemaName,
						operation: ConfigurationEnums.CardStateV2.ADD,
						moduleId: this.getChainCardModuleSandboxId(typeColumnValue),
						instanceConfig: {
							useSeparatedPageHeader: this.get("UseSeparatedPageHeader")
						}
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
						var headerTemplate = this.get("Resources.Strings.HeaderCaption");
						return this.Ext.String.format(headerTemplate, this.entitySchema.caption);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});
