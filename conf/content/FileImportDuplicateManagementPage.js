﻿Terrasoft.configuration.Structures["FileImportDuplicateManagementPage"] = {innerHierarchyStack: ["FileImportDuplicateManagementPage"], structureParent: "FileImportWizardStepPage"};
define('FileImportDuplicateManagementPageStructure', ['FileImportDuplicateManagementPageResources'], function(resources) {return {schemaUId:'0f3a039a-d4a7-4538-9d15-8765411ad8d9',schemaCaption: "FileImportDuplicateManagementPage", parentSchemaName: "FileImportWizardStepPage", packageName: "FileImport", schemaName:'FileImportDuplicateManagementPage',parentSchemaUId:'c28ed8d9-a852-43ed-ad8d-f594bb3a094f',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("FileImportDuplicateManagementPage", ["FileImportTemplateMixin"], function() {
	return {
		attributes: {
			SelectedRows: {dataValueType: Terrasoft.DataValueType.COLLECTION},
			NextStepPageName: {
				value: "FileImportProcessingPage"
			},
			IsNeedToSaveTemplate: {
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			ImportTemplateSavingOption: {
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN
			},
			ImportTemplateId: {
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"dataValueType": this.Terrasoft.DataValueType.GUID
			},
			ImportTemplateName: {
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"dataValueType": this.Terrasoft.DataValueType.TEXT
			}
		},
		messages: {
			/**
			 * @message GetModuleInfo
			 * Returns module information.
			 */
			"GetModuleInfo": {
				"mode": Terrasoft.MessageMode.PTP,
				"direction": Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message SetImportTemplateSavingOption
			 * Returns save import template option.
			 */
			"SetImportTemplateSavingOption": {
				"mode": Terrasoft.MessageMode.PTP,
				"direction": Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message SetNewTemplateName
			 * Returns new template name.
			 */
			"SetNewTemplateName": {
				"mode": Terrasoft.MessageMode.PTP,
				"direction": Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		mixins: {
			FileImportTemplateMixin: "Terrasoft.FileImportTemplateMixin"
		},
		methods: {

			//region Methods: Private

			/**
			 * Adds root schema columns to grid.
			 * @private
			 * @param {Array} columns Import columns.
			 */
			addRootSchemaColumns: function(columns) {
				var rootSchema = this.get("RootSchema");
				var collection = this.get("GridData");
				this.set("Columns", columns);
				this.Terrasoft.each(columns, function(column) {
					var destinations = column.destinations;
					this.Terrasoft.each(destinations, function(destination) {
						if (destination.schemaUId !== rootSchema.uId) {
							return;
						}
						var rootSchemaColumn = rootSchema.getColumnByName(destination.columnName);
						var columnMappingItem = this.createColumn(rootSchemaColumn);
						var id = columnMappingItem.get("Id");
						collection.add(id, columnMappingItem);
						if (destination.isKey) {
							var selectedRowIds = this.get("SelectedRows");
							selectedRowIds.push(id);
							this.set("SelectedRows", this.Terrasoft.deepClone(selectedRowIds));
						}
					}, this);
				}, this);
			},

			/**
			 * Initializes import parameters.
			 * @private
			 * @param {Object} response Server response.
			 * @param {Array} response.Columns Import columns.
			 * @param {String} response.RootSchemaName Root schema name.
			 * @param {Function} callback Callback.
			 * @param {Object} scope Callback execution scope.
			 */
			initImportParameters: function(response, callback, scope) {
				this.Terrasoft.require([response.RootSchemaName], function(schema) {
					this.set("RootSchema", schema);
					this.addRootSchemaColumns(response.Columns);
					callback.call(scope);
				}, this);
			},

			/**
			 * Initialize key columns.
			 * @private
			 */
			initKeyColumns: function() {
				var gridData = this.get("GridData");
				var selectedRows = this.get("SelectedRows");
				gridData.each(function(row) {
					var destinationColumnName = row.get("ColumnName");
					var destination = this.findDestinationByName(destinationColumnName);
					var rowId = row.get("Id");
					destination.isKey = (selectedRows.indexOf(rowId) !== -1);
				}, this);
			},

			/**
			 * Finds destination by name.
			 * @private
			 * @param {String} destinationColumnName Destination column name.
			 * @return {Object} Found destination.
			 */
			findDestinationByName: function(destinationColumnName) {
				var columns = this.get("Columns");
				var foundDestination = null;
				this.Terrasoft.each(columns, function(column) {
					this.Terrasoft.each(column.destinations, function(destination) {
						if (destination.columnName === destinationColumnName) {
							foundDestination = destination;
						}
						return this.Ext.isEmpty(foundDestination);
					}, this);
					return this.Ext.isEmpty(foundDestination);
				}, this);
				return foundDestination;
			},

			/**
			 * Starts import of the uploaded file.
			 * @private
			 * @param {Function} [callback] Callback.
			 * @param {Object} [scope] Callback execution scope.
			 */
			startImport: function(callback, scope) {
				var config = {
					contractName: "Import",
					importSessionId: this.get("ImportSessionId")
				};
				this.sendRequest(config, function(response) {
					if (!response.success) {
						this.logRequestError(response.errorInfo);
						return;
					}
					if (callback) {
						callback.call(scope || this, response);
					}
				}, this);
			},

			_validateImportParameters: function(callback, scope) {
				var config = {
					contractName: "Validate",
					serviceName: "FileImportValidationService",
					importSessionId: this.get("ImportSessionId")
				};
				this.sendRequest(config, function(response) {
					if (!response.success && this.isNotEmpty(response.errorInfo)) {
						this.logRequestError(response.errorInfo);
						return;
					}
					Ext.callback(callback, scope || this, [response.CanUseImportEntitiesStorage]);
				}, this);
			},

			/**
			 * @private
			 */
			_isNeedLookDuplicates: function() {
				return this.isNotEmpty(this.get("SelectedRows"));
			},

			/**
			 * @private
			 */
			_saveImportTemplate: function(callback, scope) {
				this.Terrasoft.chain(
					this._chooseImportTemplateToUpdateInChain,
					this._createNewImportTemplateInChain,
					this._updateImportTemplateInChain,
					function() {
						this.Ext.callback(callback, scope);
					},
					this);
			},

			/**
			 * @private
			 */
			_initImportTemplateInChain: function(parentNext) {
				if (!this.isUseFileImportTemplate()) {
					parentNext();
					return;
				}
				this.Terrasoft.chain(
					function(next) {
						this.loadImportTemplateId(this.$ImportSessionId, next, this);
					},
					this._onImportTemplateIdLoadedInChain,
					function(next, name) {
						this.$ImportTemplateName = name;
						parentNext();
					},
					this);
			},

			/**
			 * @private
			 */
			_onImportTemplateIdLoadedInChain: function(next, importTemplateId) {
				this.$ImportTemplateId = importTemplateId;
				if (this.Terrasoft.isGUID(this.$ImportTemplateId) && !this.Terrasoft.isEmptyGUID(this.$ImportTemplateId)) {
					this.loadImportTemplateAdditionalData(this.$ImportTemplateId, next, this);
				} else {
					next();
				}
			},

			/**
			 * @private
			 */
			_chooseImportTemplateToUpdateInChain: function(next) {
				if (!this.Terrasoft.isGUID(this.$ImportTemplateId) || this.Terrasoft.isEmptyGUID(this.$ImportTemplateId)) {
					this.$ImportTemplateSavingOption = true;
					next();
					return;
				}
				this._openModalBox({
					"schemaName": "SaveImportTemplateModalBox",
					"responseMessage": "SetImportTemplateSavingOption",
					"callback": function(importTemplateSavingOption) {
						this.$ImportTemplateSavingOption = importTemplateSavingOption;
						next();
					},
					"scope": this,
					"moduleInfo": {"importTemplateName": this.$ImportTemplateName}
				});
			},

			/**
			 * @private
			 */
			_updateImportTemplateInChain: function(next) {
				this.callImportTemplateService({
					"methodName": "SaveImportTemplate",
					"data": {
						"request": {
							"importSessionId": this.$ImportSessionId,
							"importTemplateId": this.$ImportTemplateId
						}
					},
					"callback": function() {
						next();
					},
					"scope": this
				});
			},

			/**
			 * @private
			 */
			_createNewImportTemplateInChain: function(next) {
				if (!this.$ImportTemplateSavingOption) {
					next();
					return;
				}
				this.Terrasoft.chain(
					this._getNewTemplateNameInChain,
					this._insertNewImportTemplateInChain,
					this._saveImportTemplateIdInChain,
					function() {
						next();
					},
					this);
			},

			/**
			 * @private
			 */
			_getNewTemplateNameInChain: function(next) {
				this._openModalBox({
					"schemaName": "NewImportTemplateModalBox",
					"responseMessage": "SetNewTemplateName",
					"callback": next,
					"scope": this
				});
			},

			/**
			 * @private
			 */
			_insertNewImportTemplateInChain: function(next, name) {
				var importTemplateId = this.Terrasoft.generateGUID();
				var insertQuery = this.Ext.create("Terrasoft.InsertQuery", {
					"rootSchemaName": "FileImportTemplate"
				});
				insertQuery.setParameterValue("Id", importTemplateId, Terrasoft.DataValueType.GUID);
				insertQuery.setParameterValue("Name", name, Terrasoft.DataValueType.TEXT);
				insertQuery.setParameterValue("EntitySchemaUId", this._getRootSchemaUId(), Terrasoft.DataValueType.GUID);
				insertQuery.execute(function(response) {
					if (!response.success) {
						return;
					}
					next(importTemplateId);
				}, this);
			},

			/**
			 * @private
			*/
			_getRootSchemaUId: function() {
				var rootSchema = this.get("RootSchema");
				return rootSchema.uId;
			},

			/**
			 * @private
			 */
			_saveImportTemplateIdInChain: function(next, importTemplateId) {
				this.saveImportTemplateId({
					"importTemplateId": importTemplateId,
					"importSessionId": this.$ImportSessionId
				}, function() {
					this.$ImportTemplateId = importTemplateId;
					next();
				}, this);
			},

			/**
			 * @private
			 */
			_openModalBox: function(config) {
				var modalBoxId = this.sandbox.id + '_' + config.schemaName;
				var moduleInfo = this.Ext.apply({"schemaName": config.schemaName}, config.moduleInfo || {});
				this.sandbox.subscribe("GetModuleInfo", function() {
					return moduleInfo;
				}, this, [modalBoxId]);
				this.sandbox.subscribe(config.responseMessage, config.callback, config.scope, [modalBoxId]);
				this.sandbox.loadModule("ModalBoxSchemaModule", {id: modalBoxId});
			},

			/**
			 * @private
			 */
			_processNextStepClick: function(callback, scope) {
				this.Terrasoft.chain(
					function(next) {
						this._saveChangedColumnsMappingParameters(next, this);
					},
					function(next) {
						if (this.isUseFileImportTemplate() && this.$IsNeedToSaveTemplate) {
							this._saveImportTemplate(next, this);
						} else {
							next();
						}
					},
					function(next) {
						if (this.getIsFeatureEnabled("HighestSpeedFileImport")) {
							this.validate(next, function() {
								this.onValidationFailed(next, this)
							}, this);
							return;
						}
						next();
					},
					function() {
						this.startImport(callback, scope);
					},
					this);
			},

			/**
			 * @private
			 */
			_saveChangedColumnsMappingParameters: function(callback, scope) {
				this.initKeyColumns();
				this.setColumnsMappingParameters(this.$Columns, function(response) {
					if (!response.success) {
						this.logRequestError(response.errorInfo);
						return;
					}
					this.Ext.callback(callback, scope);
				}, this);
			},

			//endregion

			//region Methods: Protected

			/**
			 * Executed when failed validation.
			 * @protected
			 * @param {Function} [callback] Callback function.
			 * @param {Object} [scope] Callback execution scope.
			 */
			onValidationFailed: function(callback, scope) {
				var buttonsConfig = this._getValidationFailedButtons();
				var caption = this.getCaptionConfirmationDialog();
				this.showConfirmationDialog(caption, function(result) {
					if (result === "ProceedToImportSlow") {
						this.Ext.callback(callback, scope);
					}
				}, buttonsConfig);
			},

			/**
			 * Validate key columns settings.
			 * @param {Function} [successCallback] Executed when successful validation callback.
			 * @param {Function} [failedCallback]  Executed when failed validation callback.
			 * @param {Object} [scope] Callback execution scope.
			 */
			validate: function(successCallback, failedCallback, scope) {
				this._validateImportParameters(function(canUseImportEntitiesStorage) {
					var isNeedLookDuplicates = this._isNeedLookDuplicates();
					if (!isNeedLookDuplicates || canUseImportEntitiesStorage) {
						Ext.callback(successCallback, scope);
					} else {
						Ext.callback(failedCallback, scope);
					}
				}, this);
			},

			/**
			 * Get caption for confirmation import dialog.
			 * @protected
			 * @return {String} Caption for confirmation import dialog.
			 */
			getCaptionConfirmationDialog: function() {
				var caption = this.get("Resources.Strings.KeyColumnValidationFailedMessage");
				caption = Ext.String.format(caption, this.$SelectedRows.length);
				return caption;
			},

			_getValidationFailedButtons: function() {
				const buttons = [];
				var backButton = Terrasoft.getBlueButtonConfig("cancel",
						this.get("Resources.Strings.BackToColumnSettingsButtonCaption"));
				const changeSettingButton = Terrasoft.getButtonConfig("ProceedToImportSlow",
						this.get("Resources.Strings.NextButtonCaption"));
				buttons.push(backButton, changeSettingButton);
				return buttons;
			},

			/**
			 * Creates viewModel of schema column for duplicates search.
			 * @protected
			 * @param {Object} rootSchemaColumn Root schema column configuration.
			 * @param {String} rootSchemaColumn.name Column name.
			 * @param {String} rootSchemaColumn.caption Column caption.
			 * @return {Terrasoft.BaseViewModel}
			 */
			createColumn: function(rootSchemaColumn) {
				return this.Ext.create("Terrasoft.BaseViewModel", {
					columns: {
						"Id": {
							dataValueType: Terrasoft.DataValueType.GUID
						},
						"ColumnName": {
							dataValueType: Terrasoft.DataValueType.TEXT
						},
						"ColumnCaption": {
							dataValueType: Terrasoft.DataValueType.TEXT
						}
					},
					values: {
						"Id": this.Terrasoft.generateGUID(),
						"ColumnName": rootSchemaColumn.name,
						"ColumnCaption": rootSchemaColumn.caption
					}
				});
			},

			/**
			 * @inheritdoc Terrasoft.BaseWizardStepPage#saveStep
			 * @overridden
			 */
			saveStep: function(wizardInfo) {
				var parentMethod = this.getParentMethod();
				if (wizardInfo.currentStepIndex > wizardInfo.newStepIndex) {
					this._saveChangedColumnsMappingParameters(function() {
						parentMethod.call(this, [wizardInfo]);
					}, this);
				} else if (wizardInfo.currentStepIndex < wizardInfo.newStepIndex) { 
					this._processNextStepClick(function() {
						parentMethod.call(this, [wizardInfo]);
					}, this);
				} else {
					parentMethod.call(this, [wizardInfo]);
				}
			},

			//endregion

			//region Methods: Public

			/**
			 * @inheritdoc
			 * @overridden
			 */
			init: function(callback, scope) {
				this.set("GridData", this.Ext.create("Terrasoft.BaseViewModelCollection"));
				this.set("SelectedRows", []);
				this.showBodyMask();
				this.callParent([
					function() {
						this.Terrasoft.chain(
							function(next) {
								this.getImportParameters(next, this);
							},
							function(next, importParameters) {
								this.initImportParameters(importParameters, next, this);
							},
							this._initImportTemplateInChain,
							function() {
								this.hideBodyMask();
								this.Ext.callback(callback, scope);
							},
							this)
					}, this
				]);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
			 * @overridden
			 */
			destroy: function() {
				this.callParent(arguments);
			}

			//endregion
		},
		diff: [
			{
				"operation": "merge",
				"name": "HeaderContainer",
				"values": {
					"classes": {
						"wrapClassName": ["header-container", "duplicates"]
					}
				}
			},
			{
				"operation": "merge",
				"name": "CenterContainer",
				"values": {
					"classes": {
						"wrapClassName": ["center-container", "duplicates"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "DuplicateColumnsControlGroup",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"caption": {"bindTo": "Resources.Strings.DuplicateColumnsGroupHeader"},
					"items": [],
					"tools": [],
					"classes": {
						"wrapClass": ["duplicate-columns-group-wrap", "detail"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "DuplicateColumnsGrid",
				"parentName": "DuplicateColumnsControlGroup",
				"propertyName": "items",
				"values": {
					"generateId": false,
					"listedZebra": true,
					"itemType": this.Terrasoft.ViewItemType.GRID,
					"type": "listed",
					"primaryDisplayColumnName": "ColumnCaption",
					"activeRow": {bindTo: "ActiveRow"},
					"selectedRows": {bindTo: "SelectedRows"},
					"multiSelect": true,
					"columnsConfig": [
						{
							cols: 8,
							key: {
								name: "ColumnCaption",
								bindTo: "ColumnCaption",
								type: "text"
							}
						}
					],
					"captionsConfig": [
						{
							cols: 8,
							name: "EmptyCaption"
						}
					],
					"isEmpty": {"bindTo": "IsGridEmpty"},
					"isLoading": {"bindTo": "IsGridLoading"},
					"collection": {"bindTo": "GridData"}
				}
			},
			{
				"operation": "insert",
				"name": "IsNeedToSaveTemplateContainer",
				"parentName": "FooterContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generateId": false,
					"classes": {"wrapClassName": ["is-need-to-save-container"]},
					"items": [],
					"visible": {"bindTo": "isUseFileImportTemplate"}
				}
			},
			{
				"operation": "insert",
				"name": "IsNeedSaveTemplateCheckBoxEdit",
				"parentName": "IsNeedToSaveTemplateContainer",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"markerValue": "IsNeedToSaveTemplateCheckBoxEdit",
					"controlConfig": {
						"className": "Terrasoft.CheckBoxEdit",
						"checked": {"bindTo": "IsNeedToSaveTemplate"}
					},
					"labelConfig": {
						"visible": false
					}
				}
			},
			{
				"operation": "insert",
				"name": "IsNeedSaveTemplateLabel",
				"parentName": "IsNeedToSaveTemplateContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.UpdateTemplateFlagCaption"}
				}
			}
		]
	};
});


