﻿Terrasoft.configuration.Structures["MobileDesignerManifestColumnResolver"] = {innerHierarchyStack: ["MobileDesignerManifestColumnResolver"]};
define("MobileDesignerManifestColumnResolver", ["sandbox", "EntityStructureHelperMixin"],
	function(sandbox) {

		/**
		 * @class Terrasoft.MobileDesignerManifestColumnResolver
		 * Class that computes the configuration of the manifest model.
		 */
		Ext.define("Terrasoft.MobileDesignerManifestColumnResolver", {

			mixins: {
				EntityStructureHelper: "Terrasoft.EntityStructureHelperMixin"
			},

			config: {

				modelName: null

			},

			//region Properties: Private

			/**
			 * @private
			 */
			gridPageColumnNames: null,

			/**
			 * @private
			 */
			recordPageColumnNames: null,

			/**
			 * @private
			 */
			embeddedDetails: null,

			/**
			 * @private
			 */
			standartDetails: null,

			/**
			 * @private
			 */
			loadedEntitySchemas: null,

			/**
			 * @private
			 */
			sandbox: Ext.create(sandbox),

			/**
			 * @private
			 */
			schema: null,

			/**
			 * @private
			 */
			lookupSubcolumns: null,

			//endregion

			//region Methods: Private

			/**
			 * @private
			 */
			isLookupColumn: function(columnConfig) {
				if (!columnConfig) {
					return false;
				}
				return Terrasoft.isLookupDataValueType(columnConfig.dataValueType);
			},

			/**
			 * @private
			 */
			isLookupSubColumn: function(columnName) {
				return columnName.indexOf(".") !== -1;
			},

			/**
			 * @private
			 */
			loadEntitySchemas: function(callback) {
				var primaryModelName = this.getModelName();
				var modelNames = Ext.Array.union(Object.keys(this.embeddedDetails || {}), Object.keys(this.standartDetails || {}));
				if (!Terrasoft.utils.array.contains(modelNames, primaryModelName)) {
					modelNames.push(primaryModelName);
				}
				var total = modelNames.length;
				var loaded = 0;
				var callbackFn = function() {
					loaded++;
					if (loaded === total) {
						Ext.callback(callback, this);
					}
				};
				for (var i = 0, ln = total; i < ln; i++) {
					this.loadEntitySchema(modelNames[i], callbackFn);
				}
			},

			/**
			 * @private
			 */
			resolveLookupSubcolumnsForAllModels: function(callback) {
				var lookupSubcolumns = this.lookupSubcolumns;
				var lookupSubcolumnModelNames = Object.keys(lookupSubcolumns);
				var totalModels = lookupSubcolumnModelNames.length;
				if (totalModels === 0) {
					Ext.callback(callback, this);
					return;
				}
				var processedModels = 0;
				var callbackFn = function() {
					processedModels++;
					if (processedModels === totalModels) {
						Ext.callback(callback, this);
					}
				};
				for (var i = 0; i < totalModels; i++) {
					var modelName = lookupSubcolumnModelNames[i];
					this.resolveLookupSubcolumnsForModel({
						modelName: modelName,
						callback: callbackFn
					});
				}
			},

			/**
			 * @private
			 */
			resolveLookupSubcolumnsForModel: function(config) {
				var modelName = config.modelName;
				var lookupSubcolumns = this.lookupSubcolumns;
				var modelsSubcolumns = lookupSubcolumns[modelName];
				var modelsSubcolumnNames = Object.keys(modelsSubcolumns);
				var totalSubcolumns = modelsSubcolumnNames.length;
				if (totalSubcolumns === 0) {
					Ext.callback(config.callback, this);
					return;
				}
				var precessedSubcolumns = 0;
				var callbackFn = function() {
					precessedSubcolumns++;
					if (precessedSubcolumns === totalSubcolumns) {
						Ext.callback(config.callback, this);
					}
				};
				for (var i = 0; i < totalSubcolumns; i++) {
					this.resolveLookupSubcolumnModels({
						modelName: modelName,
						columnName: modelsSubcolumnNames[i],
						callback: callbackFn
					});
				}
			},

			/**
			 * @private
			 */
			resolveLookupSubcolumnModels: function(config) {
				var currentColumnIndex = config.currentColumnIndex;
				var columnNames = config.columnNames;
				var numberOfColumns = config.numberOfColumns;
				if (!Ext.isNumber(currentColumnIndex)) {
					columnNames = config.columnNames = config.columnName.split(".");
					currentColumnIndex = config.currentColumnIndex = 0;
					numberOfColumns = config.numberOfColumns = columnNames.length;
				}
				var currentModelName = config.modelName;
				this.addRequiredModel(currentModelName);
				var columnName = columnNames[currentColumnIndex];
				this.addColumnToRequiredModel(currentModelName, columnName);
				this.loadEntitySchema(currentModelName, function(schema) {
					var column = schema.columns[columnName];
					config.currentColumnIndex++;
					var referenceSchemaName = column.referenceSchemaName;
					if (config.currentColumnIndex === numberOfColumns || !referenceSchemaName) {
						Ext.callback(config.callback, this);
					} else {
						config.modelName = referenceSchemaName;
						this.resolveLookupSubcolumnModels(config);
					}
				});
			},

			/**
			 * @private
			 */
			loadEntitySchema: function(modelName, callback) {
				var loadedSchema = this.loadedEntitySchemas[modelName];
				if (!loadedSchema) {
					this.getEntitySchema(modelName, function(schema) {
						this.loadedEntitySchemas[modelName] = schema;
						Ext.callback(callback, this, [schema]);
					}, this);
				} else {
					Ext.callback(callback, this, [loadedSchema]);
				}
			},

			/**
			 * @private
			 */
			processGridPageColumns: function() {
				var modelName = this.getModelName();
				var schema = this.loadedEntitySchemas[modelName];
				var columnNames = this.gridPageColumnNames;
				var schemaColumns = schema.columns;
				for (var i = 0, ln = columnNames.length; i < ln; i++) {
					var columnName = columnNames[i];
					var column = schemaColumns[columnName];
					if (this.isLookupSubColumn(columnName)) {
						this.addLookupSubcolumn(modelName, columnName);
					} else {
						if (this.isLookupColumn(column)) {
							this.addRequiredModelFromColumn(column);
						}
						this.addColumnToRequiredModel(modelName, columnName);
					}
				}
			},

			/**
			 * @private
			 */
			processRecordPageColumns: function(modelName, usedColumnNames) {
				this.addRequiredModel(modelName);
				var schema = this.loadedEntitySchemas[modelName];
				var schemaColumns = schema.columns;
				var allColumnNames = Object.keys(schemaColumns);
				allColumnNames = Ext.Array.union(allColumnNames, usedColumnNames);
				for (var i = 0, ln = allColumnNames.length; i < ln; i++) {
					var columnName = allColumnNames[i];
					var column = schemaColumns[columnName];
					var islookupColumn = this.isLookupColumn(column);
					if (this.isLookupSubColumn(columnName)) {
						this.addLookupSubcolumn(modelName, columnName);
						continue;
					} else if (Terrasoft.utils.array.contains(usedColumnNames, columnName)) {
						if (islookupColumn) {
							this.addRequiredModelFromColumn(column);
						}
						this.addColumnToRequiredModel(modelName, columnName);
					}
					var defValueConfig = column.defaultValue || {};
					var columnDefValueSource = defValueConfig.source;
					var columnDefValueSettingsName = defValueConfig.value;
					if (islookupColumn && columnDefValueSource === Terrasoft.core.enums.EntitySchemaColumnDefSource.SETTINGS) {
						this.requiredSysSettings[columnDefValueSettingsName] = true;
						this.addRequiredModelFromColumn(column);
					} else if (islookupColumn && columnDefValueSource === Terrasoft.core.enums.EntitySchemaColumnDefSource.CONST) {
						this.addRequiredModelFromColumn(column);
					}
				}
			},

			/**
			 * @private
			 */
			addRequiredModelFromColumn: function(column) {
				this.addRequiredModel(column.referenceSchemaName);
			},

			/**
			 * @private
			 */
			addRequiredModel: function(modelName) {
				var modelConfig = this.requiredModels[modelName];
				if (!modelConfig) {
					modelConfig = this.requiredModels[modelName] = {
						columns: []
					};
				}
				this.requiredModels[modelName] = modelConfig;
			},

			/**
			 * @private
			 */
			addColumnToRequiredModel: function(modelName, columnName) {
				var modelConfig = this.requiredModels[modelName];
				modelConfig.columns = Ext.Array.union(modelConfig.columns, [columnName]);
			},

			/**
			 * @private
			 */
			addFilterToRequiredModel: function(modelName, filter) {
				var modelConfig = this.requiredModels[modelName];
				modelConfig.filter = filter;
			},

			/**
			 * @private
			 */
			addLookupSubcolumn: function(modelName, columnPath) {
				var lookupSubcolumnsForModel = this.lookupSubcolumns[modelName];
				if (!lookupSubcolumnsForModel) {
					lookupSubcolumnsForModel = this.lookupSubcolumns[modelName] = {};
				}
				lookupSubcolumnsForModel[columnPath] = true;
			},

			//endregion

			//region Methods: Public

			constructor: function(config) {
				this.initConfig(config);
				this.gridPageColumnNames = [];
				this.recordPageColumnNames = [];
				this.embeddedDetails = {};
			},

			/**
			 * Computes the configuration of the manifest model.
			 * @param {Object} config Configuration object.
			 * @param {Function} config.callback Callback function.
			 * @param {Object} config.scope Scope for callback function.
			 */
			resolve: function(config) {
				var modelName = this.getModelName();
				this.requiredModels = {};
				this.requiredSysSettings = {};
				this.loadedEntitySchemas = {};
				this.lookupSubcolumns = {};
				this.loadEntitySchemas(function() {
					this.addRequiredModel(modelName);
					this.processGridPageColumns();
					this.processRecordPageColumns(modelName, this.recordPageColumnNames);
					Terrasoft.each(this.standartDetails, function(detailColumnNames, detailModelName) {
						this.processRecordPageColumns(detailModelName, detailColumnNames);
					}, this);
					Terrasoft.each(this.embeddedDetails, function(config, detailModelName) {
						this.processRecordPageColumns(detailModelName, config.SyncColumns);
						if (config.QueryFilter) {
							this.addFilterToRequiredModel(detailModelName, config.QueryFilter);
						}
					}, this);
					this.resolveLookupSubcolumnsForAllModels(function() {
						var resolvedConfig = {
							requiredModels: this.requiredModels,
							requiredSysSettings: Object.keys(this.requiredSysSettings)
						};
						Ext.callback(config.callback, config.scope, [this, resolvedConfig]);
					});
				}, this);
			},

			/**
			 * Sets grid columns.
			 * @param {String[]} columnNames Array of names.
			 */
			setGridPageColumns: function(columnNames) {
				this.gridPageColumnNames = columnNames;
			},

			/**
			 * Sets page columns.
			 * @param {String[]} columnNames Array of names.
			 */
			setRecordPageColumns: function(columnNames) {
				this.recordPageColumnNames = columnNames;
			},

			/**
			 * Sets configs for embeded details.
			 * @param {Object[]} embeddedDetails Array of configs.
			 */
			setEmbeddedDetails: function(embeddedDetails) {
				this.embeddedDetails = embeddedDetails;
			},

			/**
			 * Sets configs for standard details.
			 * @param {Object} details Array of configs.
			 */
			setStandartDetails: function(details) {
				this.standartDetails = details;
			}

			//endregion

		});

		return Terrasoft.MobileDesignerManifestColumnResolver;

	}
);


