﻿/**
 * Dcm library section.
 * Parent: BaseProcessLibSection
 */
define("VwDcmLibSection", [
	"VwDcmLibSectionResources",
	"ConfigurationEnums",
	"ProcessModuleUtilities",
	"DcmSchemaManager",
	"VwDcmLibSectionGridRowViewModel",
	"NavigationHelper"
], function(resources, ConfigurationEnums) {
	return {
		entitySchemaName: "VwSysDcmLib",

		messages: {
			/**
			 * @message SectionDcmLibraryInitialized
			 * Publishing message for section dcm library initialization
			 */
			"SectionDcmLibraryInitialized": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message AddCase
			 * Publishing message for add case.
			 */
			"AddCase": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message EditCase
			 * Publishing message for edit case.
			 */
			"EditCase": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message ReloadCaseSettings
			 * Subscribing on message for reload case settings.
			 */
			"ReloadDcmLibGridData": {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message EnabledDcmSchemas
			 * Publishing message for enabled schemas.
			 */
			"EnabledDcmSchemas": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message HideBodyMask
			 * Publishing message for hide loading body mask.
			 */
			"HideBodyMask": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},

		attributes: {
			/**
			 * The section identifier.
			 */
			EntitySchemaUId: {
				dataValueType: Terrasoft.DataValueType.GUID,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * The package identifier.
			 */
			PackageUId: {
				dataValueType: Terrasoft.DataValueType.GUID,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * This flag indicates that show a link in the lookup columns.
			 */
			IsShowLookupColumnLinks: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: true
			},

			/**
			 * This flag indicates if selected case is enabled.
			 */
			IsSelectedCaseActive: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: true
			},

			/**
			 * This flag indicates if folder filter menu item visible.
			 */
			UseFolderFilter: {
				value: false
			},

			/**
			 * Section active process column name.
			 */
			ActiveProcessFilterColumnName: {
				value: "IsActive"
			},

			/**
			 * Stage entity schema.
			 */
			"StageEntitySchema": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},

		methods: {

			//region Methods: Private

			/**
			 * Shows response error.
			 * @private
			 * @param {Terrasoft.core.BaseResponse} response Service response.
			 */
			showResponseError: function(response) {
				const message = response.errorInfo.toString();
				this.error(message);
				this.showInformationDialog(message);
			},

			/**
			 * Performs registry entries search for the unique identifier.
			 * @private
			 * @param {String} primaryColumnValue The unique identifier of a record.
			 * @return {Terrasoft.VwProcessLibSectionGridRowViewModel} The object registry entries.
			 */
			findGridRow: function(primaryColumnValue) {
				const gridData = this.getGridData();
				return gridData.find(primaryColumnValue);
			},

			/**
			 * Updates visibility of activate/deactivate button
			 * @private
			 */
			updateIsSelectedCaseActive: function() {
				const activeRow = this.getActiveRow();
				const isActive = activeRow && activeRow.get("IsActive");
				this.set("IsSelectedCaseActive", isActive);
			},

			/**
			 * Updates row display filters.
			 * @private
			 * @param {Terrasoft.Entity} row Grid row.
			 */
			updateRowDisplayFilters: function(row) {
				let filters = row.get("Filters");
				if (!filters) {
					return;
				}
				filters = Terrasoft.deserialize(filters);
				const displayFilters = Terrasoft.DcmUtilities.getStageFiltersDisplayValue(filters, this.$StageEntitySchema);
				row.set("Filters", displayFilters);
			},

			/**
			 * Updates row display filters.
			 * @private
			 * @param {Terrasoft.Entity} row Grid row.
			 */
			updateRowDisplayStageColumn: function(row) {
				const stageColumnUId = row.get("StageColumnUId");
				const entitySchemaUId = this.get("EntitySchemaUId");
				const dots = "\u22ef";
				row.set("StageColumnUId", dots);
				Terrasoft.DcmUtilities.getStageColumnDisplayName(stageColumnUId, entitySchemaUId, function(displayName) {
					row.set("StageColumnUId", displayName);
				}, this);
			},

			/**
			 * Updates displayed values for row columns.
			 * @private
			 * @param {Terrasoft.Entity} row Grid row.
			 */
			updateRowDisplayValues: function(row) {
				this.updateRowDisplayFilters(row);
				this.updateRowDisplayStageColumn(row);
			},

			/**
			 * Sets value property value for current selected dcm schema.
			 * @private
			 * @param {Boolean} enabled Enabled property value.
			 */
			setEnabledDcmSchema: function(enabled) {
				this.showBodyMask();
				const activeRow = this.getActiveRow();
				const schemaUId = activeRow.get("UId");
				const config = {
					items: [schemaUId],
					enabled: enabled
				};
				Terrasoft.DcmSchemaManager.setEnabled(config, function(response) {
					if (response.success) {
						this.reloadGridData();
						if (this.getIsWizardMode()) {
							this.sandbox.publish("EnabledDcmSchemas", config);
						}
					} else {
						this.showResponseError(response);
					}
					this.hideBodyMask();
				}, this);
			},

			/**
			 * Returns enabled dcm schemas for section.
			 * @private
			 * @return {Terrasoft.EntitySchemaQuery}
			 */
			getEnabledDcmSchemasByModuleEntityEsq: function() {
				const activeRow = this.getActiveRow();
				const schemaUId = activeRow.get("UId");
				const sysModuleEntityId = this.get("SysModuleEntityId");
				const esq = Terrasoft.DcmSchemaManager.getEnabledDcmSchemasEsq(schemaUId);
				esq.filters.addItem(esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"[SysDcmSchemaInSettings:SysDcmSchemaUId:UId].SysDcmSettings.SysModuleEntity", sysModuleEntityId));
				return esq;
			},

			/**
			 * Shows confirmation dialog if user deactivates last active case.
			 * @private
			 * @param {Function} callback The callback function.
			 * @param {Boolean} callback.result Returns true if user confirm disable dcm schema.
			 * @param {Object} scope The scope of callback function.
			 */
			confirmDisableSchema: function(callback, scope) {
				const localizableStrings = resources.localizableStrings;
				const message = localizableStrings.DisableLastActiveDcmSchemaMessage;
				const caption = localizableStrings.DisableCase;
				const disableButton = Terrasoft.getBlueButtonConfig("yes", caption);
				this.showConfirmationDialog(message, function(returnCode) {
					callback.call(scope, returnCode === "yes");
				}, [disableButton, "no"]);
			},

			/**
			 * @private
			 */
			_openProcessProperties: function(id) {
				const navigationHelper = this.Ext.create("Terrasoft.NavigationHelper", {
					Ext: this.Ext,
					sandbox: this.sandbox
				});
				const navigationConfig = {
					target: "Page",
					options: {
						newTab: true,
						sectionSchema: "VwDcmLibSection",
						mode: "edit",
						recordId: id
					}
				};
				navigationHelper.navigateTo(navigationConfig);
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#initQueryColumns
			 * @overridden
			 */
			initQueryColumns: function(esq) {
				this.mixins.GridUtilities.initQueryColumns.apply(this, arguments);
				esq.addColumn("Filters", "SerializedFilters");
				esq.addColumn("StageColumnUId", "SchemaStageColumnUId");
			},

			/**
			 * @inheritdoc BaseSection#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					const sandbox = this.sandbox;
					sandbox.publish("SectionDcmLibraryInitialized", null, [sandbox.id]);
					sandbox.subscribe("ReloadDcmLibGridData", this.reloadGridData, this);
					Terrasoft.EntitySchemaManager.getInstanceByUId(this.$EntitySchemaUId, function(schema) {
						this.set("StageEntitySchema", schema);
						Ext.callback(callback, scope || this);
					}, this);
				}, this]);
			},

			/**
			 * @inheritdoc BaseSection#openCard
			 * @overridden
			 */
			openCard: function(schemaName, operation, primaryColumnValue) {
				const activeRow = this.findGridRow(primaryColumnValue);
				if (!activeRow) {
					return;
				}
				const config = {
					schemaUId: activeRow.get("UId")
				};
				if (this.getIsWizardMode()) {
					this.sandbox.publish("EditCase", config, [this.sandbox.id]);
				} else {
					Terrasoft.ProcessModuleUtilities.showCaseSchemaDesigner(config);
				}
			},

			/**
			 * @inheritdoc GridUtilities#getGridDataColumns
			 * @overridden
			 */
			getGridDataColumns: function() {
				const columns = this.callParent(arguments);
				if (!columns.UId) {
					columns.UId = {
						path: "UId"
					};
				}
				if (!columns.Filters) {
					columns.Filters = {
						path: "Filters"
					};
				}
				if (!columns.IsActive) {
					columns.IsActive = {
						path: "IsActive"
					};
				}
				return columns;
			},

			/**
			 * @inheritdoc BaseSection#getFilters
			 * @overridden
			 */
			getFilters: function() {
				const filters = this.callParent(arguments);
				this.addIsActiveVersionFilter(filters);
				const workspaceFilter = "WorkspaceFilter";
				if (!filters.contains(workspaceFilter)) {
					filters.add(workspaceFilter, Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "SysWorkspace",
						Terrasoft.SysValue.CURRENT_WORKSPACE.value));
				}
				const entitySchemaUId = this.get("EntitySchemaUId");
				if (entitySchemaUId) {
					filters.add("EntitySchemaFilter", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "EntitySchemaUId", entitySchemaUId));
				}
				return filters;
			},

			/**
			 * @inheritdoc BaseSection#addSectionDesignerViewOptions
			 * @overridden
			 */
			addSectionDesignerViewOptions: Terrasoft.emptyFn,

			/**
			 * @inheritdoc BaseSection#getDefaultDataViews
			 * @overridden
			 */
			getDefaultDataViews: function() {
				const gridDataView = {
					name: "GridDataView",
					active: true,
					caption: this.getDefaultGridDataViewCaption(),
					icon: this.getDefaultGridDataViewIcon()
				};
				return {
					"GridDataView": gridDataView
				};
			},

			/**
			 * Returns if section module is nested in wizard.
			 * @private
			 * @return {Boolean}
			 */
			getIsWizardMode: function() {
				const entitySchemaUId = this.get("EntitySchemaUId");
				const packageUId = this.get("PackageUId");
				return entitySchemaUId && packageUId;
			},

			/**
			 * @inheritdoc BaseSection#addRecord
			 * @overridden
			 */
			addRecord: function() {
				if (this.getIsWizardMode()) {
					this.sandbox.publish("AddCase", null, [this.sandbox.id]);
				} else {
					Terrasoft.ProcessModuleUtilities.showCaseSchemaDesigner();
				}
			},

			/**
			 * @inheritdoc BaseSection#isMultiSelectVisible
			 * @overridden
			 */
			isMultiSelectVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc GridUtilities#getIsLinkColumn
			 * @overridden
			 */
			getIsLinkColumn: function(entitySchema, column) {
				return this.get("IsShowLookupColumnLinks")
					? this.callParent(arguments)
					: entitySchema.primaryDisplayColumnName === column.columnPath;
			},

			/**
			 * @inheritdoc BaseSection#getSummarySettingsRenderTo
			 * @overridden
			 */
			getSummarySettingsRenderTo: function() {
				return "centerPanel";
			},

			/**
			 * @inheritdoc GridUtilitiesV2#updateLoadedGridData
			 * @overridden
			 */
			updateLoadedGridData: function(response, callback, scope) {
				const rows = response.collection;
				rows.each(this.updateRowDisplayValues, this);
				callback.call(scope, response);
			},

			/**
			 * @inheritdoc BaseSection#getSectionActions
			 * @overridden
			 */
			getSectionActions: function() {
				const actions = this.callParent(arguments);
				actions.addItem(this.getButtonMenuItem({
					"Type": "Terrasoft.MenuSeparator",
					"Caption": ""
				}));
				actions.addItem(this.getButtonMenuItem({
					"Caption": {"bindTo": "Resources.Strings.DisableCase"},
					"Visible": {"bindTo": "IsSelectedCaseActive"},
					"Click": {"bindTo": "onDisableCaseClick"}
				}));
				actions.addItem(this.getButtonMenuItem({
					"Caption": {"bindTo": "Resources.Strings.EnableCase"},
					"Visible": {
						"bindTo": "IsSelectedCaseActive",
						"bindConfig": {
							"converter": function(value) {
								return value === false;
							}
						}
					},
					"Click": {"bindTo": "onEnableCaseClick"}
				}));
				return actions;
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#onActiveRowChange
			 * @overridden
			 */
			onActiveRowChange: function() {
				this.callParent(arguments);
				this.updateIsSelectedCaseActive();
			},

			/**
			 * @inheritdoc BaseSectionV2#onCardModuleResponse
			 * @overridden
			 */
			onCardModuleResponse: function(response) {
				this.set("IsCardInChain", response.isInChain);
				this.loadGridDataRecord(response.primaryColumnValue, this.updateIsSelectedCaseActive);
				return true;
			},

			/**
			 * Handles enable case button click.
			 * @protected
			 */
			onEnableCaseClick: function() {
				const activeRow = this.getActiveRow();
				const schemaUId = activeRow.get("UId");
				const filters = activeRow.get("SerializedFilters");
				const moduleEntityId = this.get("SysModuleEntityId");
				const schemaStageColumnUId = activeRow.get("SchemaStageColumnUId");
				const dcmSettingsItem = Terrasoft.SysDcmSettingsManager.findBySysModuleEntityId(moduleEntityId);
				const dcmSettingsId = dcmSettingsItem.id;
				const sectionStageColumnUId = dcmSettingsItem.getStageColumnUId();
				const localizableStrings = resources.localizableStrings;
				if (schemaStageColumnUId === sectionStageColumnUId) {
					this.showBodyMask();
					Terrasoft.DcmSchemaManager.validateFilters({
						schemaUId: schemaUId,
						filters: filters,
						dcmSettingsId: dcmSettingsId
					}, function(isValid, validationMessage) {
						if (isValid) {
							this.setEnabledDcmSchema(true);
						} else {
							this.hideBodyMask();
							this.showInformationDialog(validationMessage);
						}
					}, this);
				} else {
					const message = localizableStrings.StageColumnIsNotSupportedMessage;
					this.showInformationDialog(message);
				}
			},

			/**
			 * Handles disable case button click.
			 * @protected
			 */
			onDisableCaseClick: function() {
				this.showBodyMask();
				const esq = this.getEnabledDcmSchemasByModuleEntityEsq();
				esq.getEntityCollection(function(response) {
					if (response.collection.isEmpty()) {
						this.hideBodyMask();
						this.confirmDisableSchema(function(result) {
							if (result) {
								this.setEnabledDcmSchema(false);
							}
						}, this);
					} else {
						this.setEnabledDcmSchema(false);
					}
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#onActiveRowAction
			 * @overridden
			 */
			onActiveRowAction: function(buttonTag, id) {
				switch (buttonTag) {
					case "enableCase":
						this.onEnableCaseClick();
						break;
					case "disableCase":
						this.onDisableCaseClick();
						break;
					case "openProcessProperties":
						this._openProcessProperties(id);
						break;
					default:
						this.callParent(arguments);
						break;
				}
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
			 * @overridden
			 */
			getGridRowViewModelClassName: function() {
				return "Terrasoft.VwDcmLibSectionGridRowViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#hideBodyMask
			 * @overridden
			 */
			hideBodyMask: function(config) {
				this.sandbox.publish("HideBodyMask", config);
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#createViewModel
			 * @overridden
			 */
			createViewModel: function(config) {
				const viewModel = this.callParent(arguments);
				viewModel.set("ShowPropertiesButton", Terrasoft.DcmSchemaManager.getCanUseProcessVersions());
			},

			//endregion

		},

		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DeleteRecordMenuItem",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowDeleteAction",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowCopyAction",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowProperties",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"tag": "openProcessProperties",
					"caption": {
						"bindTo": "Resources.Strings.Properties"
					},
					"visible": {
						"bindTo": "ShowPropertiesButton"
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowDisableCase",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"tag": "disableCase",
					"caption": {
						"bindTo": "Resources.Strings.DisableCase"
					},
					"visible": {
						"bindTo": "IsActive"
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowEnableCase",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"tag": "enableCase",
					"caption": {
						"bindTo": "Resources.Strings.EnableCase"
					},
					"visible": {
						"bindTo": "IsActive",
						"bindConfig": {"converter": "invertBooleanValue"}
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
