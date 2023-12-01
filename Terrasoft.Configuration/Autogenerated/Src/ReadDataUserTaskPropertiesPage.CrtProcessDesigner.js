﻿/**
 * Parent: BaseDataModificationUserTaskPropertiesPage
 */
define("ReadDataUserTaskPropertiesPage", ["terrasoft", "ProcessUserTaskConstants",
			"ReadDataUserTaskPropertiesPageResources", "BusinessRuleModule", "ProcessSchemaUserTaskUtilities",
			"ConfigurationItemGenerator", "SortingOrderControlsMixin"],
		function(Terrasoft, ProcessUserTaskConstants, resources, businessRuleModule, userTaskUtilities) {
	return {
		messages: {},
		mixins: {
			sortingOrderControlsMixin: "Terrasoft.SortingOrderControlsMixin"
		},
		attributes: {

			/**
			 * Data read modes.
			 * @protected
			 * @type {Object}
			 */
			"DataReadModeEnum": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: {
					FirstRecordFromTheSample: "0",
					ConsiderTheFunction: "1",
					CalculateTheNumberOfRecords: "2",
					ReadCollection: "3"
				}
			},

			/**
			 * Aggregate functions.
			 * @protected
			 * @type {Object}
			 */
			"AggregateFunctionEnum": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: {
					Count: Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.COUNT),
					Sum: Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.SUM),
					Average: Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.AVG),
					Minimum: Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.MIN),
					Maximum: Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.MAX)
				}
			},

			/**
			 * Column select modes.
			 * @protected
			 * @type {Object}
			 */
			"ColumnSelectModeEnum": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: {
					ReadAllColumns: 0,
					ReadOnlySelectedColumns: 1
				}
			},

			/**
			 * Attribute names that triggers update of next elements suggestions.
			 * @protected
			 * @type {Object}
			 */
			"SuggestionsTriggerAttributes": {
				dataValueType: Terrasoft.DataValueType.COLLECTION,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: [
					{
						name: "ReferenceSchemaUId",
						predictionParameterName: "entitySchemaUId"
					}
				]
			},

			/**
			 * Data read mode.
			 * @protected
			 * @type {Object}
			 */
			"DataReadMode": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isRequired: true
			},

			/**
			 * Aggregate function.
			 * @protected
			 * @type {Object}
			 */
			"AggregateFunction": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Aggregate column.
			 * @protected
			 * @type {Object}
			 */
			"AggregateColumn": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Column select mode.
			 * @protected
			 * @type {Object}
			 */
			"ColumnSelectMode": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isRequired: true
			},

			/**
			 * The primary display entity schema column.
			 * @protected
			 * @type {Object}
			 */
			"PrimaryDisplayEntitySchemaColumn": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Number of rows to be in result.
			 */
			"NumberOfRecords": {
				dataValueType: Terrasoft.DataValueType.INTEGER,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Collection of the sorting order.
			 * @protected
			 * @type {Terrasoft.ObjectCollection}
			 */
			"SortingOrderDirections": {
				dataValueType: Terrasoft.DataValueType.COLLECTION,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isCollection: true
			},

			/**
			 * Sorting order view config.
			 * @protected
			 * @type {Object}
			 */
			"SortingOrderViewConfig": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
			},

			/**
			 * View models of sorting orders.
			 * @protected
			 * @type {Terrasoft.ObjectCollection}
			 */
			"SortingOrderControls": {
				dataValueType: Terrasoft.DataValueType.COLLECTION,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isCollection: true,
				value: this.Ext.create("Terrasoft.ObjectCollection")
			},

			/**
			 * Indicates if the sorting order container is visible.
			 * @protected
			 * @type {Boolean}
			 */
			"IsOrderDirectionContainerVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Indicates if the entity schema columns container is visible.
			 * @protected
			 * @type {Boolean}
			 */
			"IsEntitySchemaColumnsContainerVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Indicates if the column select mode is visible.
			 * @protected
			 * @type {Boolean}
			 */
			"IsColumnSelectModeVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Indicates if select controls for aggregate functions are visible.
			 * @protected
			 * @type {Boolean}
			 */
			"IsSelectAggregateFunctionContainerVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Flag that indicates whether filters are required.
			 * @protected
			 * @type {Boolean}
			 */
			"IsFiltersRequired": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			},

			/**
			 * Flag that indicates whether read collection mode enabled.
			 */
			"IsReadCollectionModeVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			}
		},
		rules: {
			"AggregateFunction": {
				"BindAggregateFunctionRequiredToDataReadMode": {
					"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": businessRuleModule.enums.Property.REQUIRED,
					"conditions": [{
						"leftExpression": {
							"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
							"attribute": "DataReadMode"
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": businessRuleModule.enums.ValueType.CONSTANT,
							"value": "1"
						}
					}]
				}
			},
			"AggregateColumn": {
				"BindAggregateColumnRequiredToDataReadMode": {
					"ruleType": businessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": businessRuleModule.enums.Property.REQUIRED,
					"conditions": [{
						"leftExpression": {
							"type": businessRuleModule.enums.ValueType.ATTRIBUTE,
							"attribute": "DataReadMode"
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": businessRuleModule.enums.ValueType.CONSTANT,
							"value": "1"
						}
					}]
				}
			}
		},
		properties: {
			_defaultNumberOfRecords: 20
		},
		methods: {

			//region Methods: Private

			/**
			 * @private
			 */
			_isReadCollectionMode: function() {
				const dataReadModeValue = this.$DataReadMode && this.$DataReadMode.value;
				return dataReadModeValue === this.$DataReadModeEnum.ReadCollection;
			},

			/**
			 * @private
			 */
			_actualizeSelectedEntitySchemaColumns: function() {
				const mappedElements = this._findLinksToMappedElements();
				const columns = this._isReadCollectionMode()
					? this._getSourceParameterTags(mappedElements)
					: this._getColumnsByDependentParametersSourceValue(mappedElements);
				if (!Ext.isEmpty(columns)) {
					this.initSelectedEntitySchemaColumns(columns, Terrasoft.emptyFn, this);
				}
			},

			/**
			 * @private
			 */
			_getSourceParameterTags: function(mappedElements) {
				const filteredElements = mappedElements.filter(function(item) {
					return item.sourceParameter && item.sourceParameter.tag;
				});
				return filteredElements.map(function(item) {
					return item.sourceParameter.tag;
				});
			},

			/**
			 * @private
			 */
			_getColumnsByDependentParametersSourceValue: function(mappedElements) {
				const filteredElements = mappedElements.filter(function(item) {
					return item.dependentParameter && item.dependentParameter.sourceValue &&
						item.dependentParameter.sourceValue.value;
				});
				return filteredElements.map(function(item) {
					return this._getColumnBySourceValue(item.dependentParameter.sourceValue.value);
				}, this);
			},

			/**
			 * @private
			 */
			_findLinksToMappedElements: function() {
				const element = this.$ProcessElement;
				const process = element.parentSchema;
				return process.findLinksToElements([element.name]);
			},

			/**
			 * @private
			 */
			_getColumnBySourceValue: function(value) {
				const regex = /EntityColumn:{(.*?)}/i;
				const result = regex.exec(value);
				return result[1];
			},

			/**
			 * @private
			 */
			_canRemoveElementValidator: function() {
				const validationResult = { isValid: true };
				const element = this.$ProcessElement;
				const process = element.parentSchema;
				const checkResult = process.canRemoveElements([element.name]);
				validationResult.isValid = checkResult.canRemove;
				validationResult.validationInfo = checkResult.validationInfo;
				return validationResult;
			},

			/**
			 * @private
			 */
			_elementChangeValidationHandler: function(validationResult, validHandler, invalidHandler, scope) {
				if (validationResult.isValid) {
					validHandler.call(scope);
				} else {
					Terrasoft.ProcessSchemaDesignerUtilities.showProcessMessageBox({
						caption: this.get("Resources.Strings.InvalidEntitySchemaChange"),
						message: validationResult.validationInfo
					});
					Terrasoft.defer(invalidHandler, scope);
				}
			},

			/**
			 * @private
			 */
			_onEntitySchemaColumnsControlsSelectRemove: function(removedItem, columnUId) {
				const validate = this.$DataReadMode && this.$DataReadMode.value ===
					this.$DataReadModeEnum.ReadCollection;
				const validationResult = { isValid: true };
				if (validate) {
					const element = this.$ProcessElement;
					const process = element.parentSchema;
					const parameter = element.parameters.findByPath("tag", columnUId);
					const checkResult = process.canRemoveParameter(parameter);
					validationResult.isValid = checkResult.canRemove;
					validationResult.validationInfo = checkResult.validationInfo;
				}
				this._elementChangeValidationHandler(
					validationResult,
					this.onSyncronizeResultCompositeObjectList,
					function() {
						this.$EntitySchemaColumnsSelect.find(columnUId).selected = true;
						this.$EntitySchemaColumnsControlsSelect.add(columnUId, removedItem);
					},
					this
				);
			},

		 	/**
			 * Handler for loading selected columns to read data.
			 * @protected
			 */
			onSyncronizeResultCompositeObjectList: function() {
				const element = this.$ProcessElement;
				const resultCompositeObjectListParameter =
					element.findParameterByName("ResultCompositeObjectList");
				if (resultCompositeObjectListParameter) {
					const columnParameters = resultCompositeObjectListParameter.itemProperties;
					if (this.$EntitySchema && this.$DataReadMode &&
							this.$DataReadMode.value === this.$DataReadModeEnum.ReadCollection) {
						const entityColumnsToRead = this._getEntityColumnsToRead();
						this._updateExistingColumnParameters(entityColumnsToRead, columnParameters);
						this._addNewColumnParameters(entityColumnsToRead, columnParameters);
					} else {
						columnParameters.clear();
					}
				}
			},

			/**
			 * @private
			 */
			_getEntityColumnsToRead: function() {
				const entityColumns = this.$EntitySchema.columns;
				const entityColumnMetaPaths = this.$EntitySchemaColumnsControlsSelect.getKeys();
				const readOnlySelectedRows = this.$ColumnSelectMode.value ===
					this.$ColumnSelectModeEnum.ReadOnlySelectedColumns;
				if (readOnlySelectedRows && !Ext.isEmpty(entityColumnMetaPaths)) {
					return entityColumns.filterByFn(function(column) {
						return Terrasoft.contains(entityColumnMetaPaths, column.uId);
					});
				}
				return entityColumns;
			},

			/**
			 * @private
			 */
			_updateExistingColumnParameters: function(entityColumns, parameters) {
				const updatedParameters = {};
				parameters.each(function(parameter) {
					const sourceColumn = entityColumns.find(parameter.tag);
					if (sourceColumn) {
						const updParameter = this._createColumnParameter(sourceColumn);
						updatedParameters[updParameter.uId] = updParameter;
					}
				}, this);
				parameters.clear();
				Terrasoft.each(updatedParameters, function(parameter) {
					parameters.add(parameter.uId, parameter);
				}, this);
			},

			/**
			 * @private
			 */
			_addNewColumnParameters: function(entityColumns, parameters) {
				const dataValueTypes = Terrasoft.DataValueType;
				const exceptedDataValueTypes = [dataValueTypes.BLOB];
				const existingColumnParameters = parameters.map(function(parameter) {
					return parameter.tag;
				}, this);
				const columnsToAdd = entityColumns.filterByFn(function(entityColumn) {
					return !Terrasoft.contains(existingColumnParameters.getItems(), entityColumn.uId) &&
						!Terrasoft.contains(exceptedDataValueTypes, entityColumn.dataValueType);
				}, this);
				columnsToAdd.each(function(columnToAdd) {
					const parameter = this._createColumnParameter(columnToAdd);
					parameters.add(parameter.uId, parameter);
				}, this);
			},

			/**
			 * @private
			 * @param column
			 * @return {Terrasoft.ProcessSchemaParameter}
			 */
			_createColumnParameter: function(column) {
				return Ext.create("Terrasoft.ProcessSchemaParameter", {
					name: column.name,
					uId: column.uId,
					caption: column.caption.clone(),
					dataValueType: column.dataValueType,
					referenceSchemaUId: column.referenceSchemaUId,
					tag: column.uId,
					direction: Terrasoft.process.enums.ProcessSchemaParameterDirection.OUT,
					containerUId: this.$ProcessElement.uId,
					processFlowElementSchema: this.$ProcessElement
				});
			},

			/**
			 * @private
			 */
			_subscribeOnEntitySchemaColumnsControlsSelectEvents: function() {
				this.$EntitySchemaColumnsControlsSelect.on("dataLoaded",
					this.onSyncronizeResultCompositeObjectList, this);
				this.$EntitySchemaColumnsControlsSelect.on("remove",
					this._onEntitySchemaColumnsControlsSelectRemove, this);
			},

			/**
			 * @private
			 */
			_initDefaultNumberOfRecords: function(callback, scope) {
				Terrasoft.SysSettings.querySysSettings(["ReadDataChunkSize"], function(sysSettings) {
					if (!Ext.isEmpty(sysSettings.ReadDataChunkSize)) {
						this._defaultNumberOfRecords = sysSettings.ReadDataChunkSize;
					}
					callback.call(scope || this);
				}, this);
			},

			/**
			 * @private
			 */
			_initNumberOfRecords: function(element) {
				const parameter = element.findParameterByName("NumberOfRecords");
				if (parameter) {
					const rowsCount = parameter.getValue();
					if (Ext.isEmpty(rowsCount)) {
						this.$NumberOfRecords = this._defaultNumberOfRecords;
					} else {
						this.$NumberOfRecords = rowsCount !== "0" ? Number(rowsCount) : null;
					}
				}
			},

			/**
			 * Returns entity column metaPaths.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @return {String[]} The array of column metaPaths.
			 */
			getEntityColumnMetapaths: function(element) {
				const parameter = element.findParameterByName("EntityColumnMetaPathes");
				const value = parameter.getValue();
				let columnMetaPaths = [];
				if (!this.Ext.isEmpty(value)) {
					columnMetaPaths = value.split(";");
				}
				return columnMetaPaths;
			},

			/**
			 * Initializes the primary display column.
			 * @private
			 * @param {Function} callback Callback function.
			 * @param {Object} [scope] Callback scope.
			 */
			initPrimaryDisplayColumn: function(callback, scope) {
				this.set("PrimaryDisplayEntitySchemaColumn", null);
				const referenceSchemaUId = this.get("ReferenceSchemaUId");
				if (Ext.isEmpty(referenceSchemaUId)) {
					callback.call(scope || this);
					return;
				}
				const config = {
					schemaUId: referenceSchemaUId
				};
				const utils = this.getEntitySchemaDesignerUtilities();
				utils.findEntitySchemaInstance(config, function(entitySchema) {
					if (entitySchema) {
						this.set("EntitySchema", entitySchema);
						let primaryDisplayColumn = entitySchema.primaryDisplayColumn;
						if (primaryDisplayColumn) {
							primaryDisplayColumn = this.getEntitySchemaColumnSelect(primaryDisplayColumn);
							this.set("PrimaryDisplayEntitySchemaColumn", primaryDisplayColumn);
						}
					}
					callback.call(scope || this);
				}, this);
			},

			/**
			 * Initializes data read mode.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			initDataReadMode: function(element) {
				let parameter = element.findParameterByName("ResultType");
				let value = parameter.getValue();
				let dataReadMode;
				switch (value) {
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.FUNCTION:
						parameter = element.findParameterByName("FunctionType");
						value = parameter.getValue();
						dataReadMode = value === this.$AggregateFunctionEnum.Count
							? this.$DataReadModeEnum.CalculateTheNumberOfRecords
							: this.$DataReadModeEnum.ConsiderTheFunction;
						break;
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY_COLLECTION:
						dataReadMode = this.$DataReadModeEnum.ReadCollection;
						break;
					default:
						dataReadMode = this.$DataReadModeEnum.FirstRecordFromTheSample;
						break;
				}
				const dataReadModes = this.getDataReadModes();
				this.$DataReadMode = dataReadModes[dataReadMode];
				this.on("change:DataReadMode", this.onDataReadModeChanged, this);
			},

			/**
			 * Initializes aggregate function.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			initAggregateFunction: function(element) {
				const parameter = element.findParameterByName("FunctionType");
				const value = parameter.getValue();
				if (!value) {
					return;
				}
				const aggregateFunctions = this.getAggregateFunctions();
				this.set("AggregateFunction", aggregateFunctions[value]);
				this.on("change:AggregateFunction", this.onAggregateFunctionChanged, this);
			},

			/**
			 * Initializes aggregate column.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			initAggregateColumn: function(element) {
				const parameter = element.findParameterByName("AggregationColumnName");
				const columnName = parameter.getValue();
				if (!columnName) {
					return;
				}
				let aggregateColumn = null;
				const columns = this.get("EntitySchemaColumnsSelect");
				columns.each(function(column) {
					if (column.name === columnName) {
						aggregateColumn = column;
						return false;
					}
				}, this);
				this.set("AggregateColumn", aggregateColumn);
			},

			/**
			 * Initializes column selection mode.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			initColumnSelectMode: function(element) {
				const parameter = element.findParameterByName("EntityColumnMetaPathes");
				const value = parameter.getValue();
				const columnSelectModeEnum = this.get("ColumnSelectModeEnum");
				const columnSelectMode = this.Ext.isEmpty(value)
					? columnSelectModeEnum.ReadAllColumns
					: columnSelectModeEnum.ReadOnlySelectedColumns;
				const columnSelectModes = this.getColumnSelectModes();
				this.set("ColumnSelectMode", columnSelectModes[columnSelectMode]);
				this.on("change:ColumnSelectMode", this.onColumnSelectModeChanged, this);
			},

			/**
			 * Returns aggregate functions.
			 * @private
			 * @return {Object}
			 */
			getAggregateFunctions: function() {
				const aggregateFunctions = {};
				const aggregateFunctionEnum = this.get("AggregateFunctionEnum");
				const localizableStrings = resources.localizableStrings;
				this.Terrasoft.each(aggregateFunctionEnum, function(aggregateFunction) {
					if (aggregateFunction === aggregateFunctionEnum.Count) {
						return true;
					}
					const functionCaption = "AggregateFunction" + aggregateFunction + "Caption";
					aggregateFunctions[aggregateFunction] = {
						value: aggregateFunction,
						displayValue: localizableStrings[functionCaption]
					};
				}, this);
				return aggregateFunctions;
			},

			/**
			 * Fills out the drop down list of data read modes.
			 * @private
			 * @param {String} filter Filter value.
			 * @param {Terrasoft.Collection} list The drop down list.
			 */
			prepareDataReadModes: function(filter, list) {
				if (list === null) {
					return;
				}
				const dataReadModes = this.getDataReadModes();
				list.clear();
				list.loadAll(dataReadModes);
			},

			/**
			 * Fills out the drop down list of aggregate functions.
			 * @private
			 * @param {String} filter Filter value.
			 * @param {Terrasoft.Collection} list The drop down list.
			 */
			prepareAggregateFunctionList: function(filter, list) {
				if (list === null) {
					return;
				}
				const aggregateFunctions = this.getAggregateFunctions();
				list.clear();
				list.loadAll(aggregateFunctions);
			},

			/**
			 * Fills out the drop down list of aggregate column names.
			 * @private
			 * @param {String} filter Filter value.
			 * @param {Terrasoft.Collection} list The drop down list.
			 */
			prepareAggregateColumnList: function(filter, list) {
				if (list === null) {
					return;
				}
				const columns = this.get("EntitySchemaColumnsSelect");
				const aggregateFunctionEnum = this.get("AggregateFunctionEnum");
				let aggregateFunction = this.get("AggregateFunction");
				aggregateFunction = aggregateFunction.value;
				const aggregateColumns = {};
				columns.each(function(column) {
					const dataValueType = column.dataValueType;
					if (!this.Terrasoft.isNumberDataValueType(dataValueType) &&
						!this.Terrasoft.isDateDataValueType(dataValueType)) {
						return true;
					}
					if ((aggregateFunction === aggregateFunctionEnum.Average ||
							aggregateFunction === aggregateFunctionEnum.Sum) &&
						!this.Terrasoft.isNumberDataValueType(dataValueType)) {
						return true;
					}
					aggregateColumns[column.name] = column;
				}, this);
				list.clear();
				list.loadAll(aggregateColumns);
			},

			/**
			 * Returns column select modes.
			 * @private
			 * @return {Object}
			 */
			getColumnSelectModes: function() {
				const columnSelectModes = {};
				const columnSelectModeEnum = this.get("ColumnSelectModeEnum");
				const localizableStrings = resources.localizableStrings;
				columnSelectModes[columnSelectModeEnum.ReadAllColumns] = {
					value: columnSelectModeEnum.ReadAllColumns,
					displayValue: localizableStrings.ReadAllColumnsCaption
				};
				columnSelectModes[columnSelectModeEnum.ReadOnlySelectedColumns] = {
					value: columnSelectModeEnum.ReadOnlySelectedColumns,
					displayValue: localizableStrings.ReadOnlySelectedColumnsCaption
				};
				return columnSelectModes;
			},

			/**
			 * Fills out the drop down list of column select modes.
			 * @private
			 * @param {String} filter Filter value.
			 * @param {Terrasoft.Collection} list The drop down list.
			 */
			prepareColumnSelectModes: function(filter, list) {
				if (list === null) {
					return;
				}
				const columnSelectModes = this.getColumnSelectModes();
				list.clear();
				list.loadAll(columnSelectModes);
			},

			/**
			 * Saves entity column meta paths.
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @private
			 */
			saveEntityColumnMetaPaths: function(element) {
				let columnMetaPaths = null;
				const entitySchemaColumnControls = this.get("EntitySchemaColumnsControlsSelect");
				if (entitySchemaColumnControls && !entitySchemaColumnControls.isEmpty()) {
					entitySchemaColumnControls.each(function(entitySchemaColumnControl) {
						const id = entitySchemaColumnControl.get("Id");
						columnMetaPaths = !columnMetaPaths ? id : columnMetaPaths + ";" + id;
					}, this);
				}
				const parameter = element.findParameterByName("EntityColumnMetaPathes");
				const parameterValue = {
					source: !columnMetaPaths
						? this.Terrasoft.ProcessSchemaParameterValueSource.None
						: this.Terrasoft.ProcessSchemaParameterValueSource.ConstValue,
					value: columnMetaPaths
				};
				parameter.setMappingValue(parameterValue);
			},


			/**
			 * Saves the type of reading result.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			saveResultType: function(element) {
				if (!this.isAttributeChanged("DataReadMode")) {
					return;
				}
				let resultType;
				if (this.$DataReadMode) {
					switch (this.$DataReadMode.value) {
						case this.$DataReadModeEnum.FirstRecordFromTheSample:
							resultType = ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY;
							break;
						case this.$DataReadModeEnum.CalculateTheNumberOfRecords:
						case this.$DataReadModeEnum.ConsiderTheFunction:
							resultType = ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.FUNCTION;
							break;
						case this.$DataReadModeEnum.ReadCollection:
							resultType = ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY_COLLECTION;
							break;
						default:
							resultType = ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY;
							break;
					}
				}
				const parameter = element.findParameterByName("ResultType");
				const sourceValue = {
					value: resultType,
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue
				};
				parameter.setMappingValue(sourceValue);
			},

			/**
			 * Saves type of the aggregate function.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			saveAggregateFunctionType: function(element) {
				let aggregateFunction = this.get("AggregateFunction");
				const aggregateFunctionEnum = this.get("AggregateFunctionEnum");
				aggregateFunction = aggregateFunction ? aggregateFunction.value : aggregateFunctionEnum.Count;
				const parameter = element.findParameterByName("FunctionType");
				const sourceValue = {
					value: aggregateFunction,
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue
				};
				parameter.setMappingValue(sourceValue);
			},

			/**
			 * Saves aggregate column name.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 */
			saveAggregateColumnName: function(element) {
				const aggregateColumn = this.get("AggregateColumn");
				let source = this.Terrasoft.ProcessSchemaParameterValueSource.None;
				let aggregateColumnName = null;
				if (aggregateColumn) {
					source = this.Terrasoft.ProcessSchemaParameterValueSource.ConstValue;
					aggregateColumnName = aggregateColumn.name;
				}
				const parameter = element.findParameterByName("AggregationColumnName");
				const sourceValue = {
					value: aggregateColumnName,
					source: source
				};
				parameter.setMappingValue(sourceValue);
			},

			/**
			 * @private
			 */
			saveNumberOfRecords: function(element) {
				const rowsCount = this.$NumberOfRecords && this.$NumberOfRecords.toString();
				let parameter = element.findParameterByName("NumberOfRecords");
				parameter.setMappingValue({
					value: rowsCount,
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue
				});
				parameter = element.findParameterByName("ReadSomeTopRecords");
				parameter.setMappingValue({
					value: rowsCount !== 0,
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue
				});
			},

			/**
			 * Initializes collection of the entity schema column.
			 * @private
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			initEntitySchemaColumns: function(callback, scope) {
				this.getEntitySchemaColumnsSelect(callback, scope);
			},

			/**
			 * Initializes collection of selected entity schema column.
			 * @private
			 * @param {Array} columnMetaPaths List of the column meta path.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			initSelectedEntitySchemaColumns: function(columnMetaPaths, callback, scope) {
				this.initEntitySchemaColumnsSelect(columnMetaPaths, callback, scope);
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc ProcessSchemaElementEditable#onElementDataLoad
			 * @overridden
			 */
			onElementDataLoad: function(element, callback, scope) {
				this.callParent([element, function() {
					this.$ProcessSchema = element.parentSchema;
					this.initDataReadMode(element);
					this.initColumnSelectMode(element);
					this.initAggregateFunction(element);
					this.Terrasoft.chain(
						function(next) {
							const columnMetaPaths = this.getEntityColumnMetapaths(element);
							if (!this.Ext.isEmpty(columnMetaPaths)) {
								this.initSelectedEntitySchemaColumns(columnMetaPaths, next, this);
							} else {
								this.initEntitySchemaColumns(next, this);
							}
						},
						function(next) {
							this.initPrimaryDisplayColumn(next, this);
						},
						this._initDefaultNumberOfRecords,
						function() {
							this._initNumberOfRecords(element);
							this.initAggregateColumn(element);
							this.initSortingOrderControlsMixin(element);
							this.updateContainersVisibility();
							this._subscribeOnEntitySchemaColumnsControlsSelectEvents();
							callback.call(scope || this);
						},
						this);
				}, this]);
			},

			/**
			 * @inheritdoc FilterModuleMixin#initReferenceSchemaUId
			 * @overridden
			 */
			initReferenceSchemaUId: function(element) {
				const parameter = element.findParameterByName("ResultEntity");
				const value = parameter.referenceSchemaUId;
				this.set("ReferenceSchemaUId", value);
			},

			/**
			 * @inheritdoc BaseDataModificationUserTaskPropertiesPage#updateReferenceSchema
			 * @overridden
			 */
			onUpdatedEntitySchema: function() {
				this.callParent(arguments);
				const value = this.get("EntitySchemaColumnsSelect");
				if (value) {
					value.clear();
				}
				this.getEntitySchemaColumnsSelect(function() {
					this.initPrimaryDisplayColumn(function() {
						this.clearAndSetDefValues();
						this.updateContainersVisibility();
						this.onSyncronizeResultCompositeObjectList();
					}, this);
				}, this);
			},

			/**
			 * @inheritdoc EntitySchemaSelectMixin#getEntitySchemaColumnSelect
			 * @overridden
			 */
			getEntitySchemaColumnSelect: function(config) {
				const columnDescriptor = this.callParent(arguments);
				columnDescriptor.dataValueType = config.dataValueType;
				return columnDescriptor;
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
			 * @overridden
			 */
			saveValues: function() {
				const element = this.get("ProcessElement");
				this.saveResultType(element);
				this.saveAggregateFunctionType(element);
				this.saveAggregateColumnName(element);
				this.saveEntityColumnMetaPaths(element);
				this.saveSortingOrderInfo(element);
				this.saveNumberOfRecords(element);
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc FilterModuleMixin#saveReferenceSchemaUId
			 * @overridden
			 */
			saveReferenceSchemaUId: function(element) {
				if (!this.isAttributeChanged("ReferenceSchemaUId")) {
					return;
				}
				const referenceSchemaUId = this.get("ReferenceSchemaUId");
				const parameter = element.findParameterByName("ResultEntity");
				const dataReadMode = this.get("DataReadMode");
				const dataReadModeEnum = this.get("DataReadModeEnum");
				parameter.isResult = dataReadMode.value === dataReadModeEnum.FirstRecordFromTheSample;
				const parameterValue = {
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue,
					referenceSchemaUId: referenceSchemaUId
				};
				parameter.setMappingValue(parameterValue);
			},

			/**
			 * Updates visibility of containers.
			 * @protected
			 */
			updateContainersVisibility: function() {
				let isVisible = Boolean(this.$EntitySchemaSelect);
				let dataReadMode = this.$DataReadMode;
				dataReadMode = dataReadMode
					? dataReadMode.value
					: this.$DataReadModeEnum.FirstRecordFromTheSample;
				this.$IsSelectAggregateFunctionContainerVisible =
					isVisible && dataReadMode === this.$DataReadModeEnum.ConsiderTheFunction;
				isVisible = isVisible && (dataReadMode === this.$DataReadModeEnum.FirstRecordFromTheSample ||
					dataReadMode === this.$DataReadModeEnum.ReadCollection);
				this.$IsReadCollectionModeVisible =
					isVisible && dataReadMode === this.$DataReadModeEnum.ReadCollection;
				this.$IsOrderDirectionContainerVisible = isVisible;
				this.$IsColumnSelectModeVisible = isVisible;
				isVisible = isVisible && this.$ColumnSelectMode &&
					this.$ColumnSelectMode.value === this.$ColumnSelectModeEnum.ReadOnlySelectedColumns;
				this.$IsEntitySchemaColumnsContainerVisible = isVisible;
			},

			/**
			 * Handles modification event of the column selection mode.
			 * @protected
			 */
			onColumnSelectModeChanged: function() {
				const previous = this.getPrevious("ColumnSelectMode");
				const previousValue = previous && previous.value;
				if (previousValue === this.$ColumnSelectModeEnum.ReadAllColumns) {
					this._actualizeSelectedEntitySchemaColumns();
				} else {
					const value = this.get("EntitySchemaColumnsControlsSelect");
					if (value) {
						value.clear();
					}
					const columns = this.get("EntitySchemaColumnsSelect");
					if (columns) {
						columns.each(function (column) {
							column.selected = false;
						}, this);
					}
				}
				this.updateContainersVisibility();
				this.onSyncronizeResultCompositeObjectList();
			},

			/**
			 * Handles modification event of the aggregate function.
			 * @protected
			 */
			onAggregateFunctionChanged: function() {
				this.set("AggregateColumn", null);
			},

			/**
			 * Handles modification event of the data read mode.
			 * @protected
			 */
			onDataReadModeChanged: function(model, value, options) {
				if (options && options.ignoreHandling) {
					return;
				}
				const previousValue = this.getPrevious("DataReadMode");
				const validate = previousValue && previousValue.value;
				const validationResult = validate ? this._canRemoveElementValidator() : { isValid: true };
				this._elementChangeValidationHandler(
					validationResult,
					function() {
						this.onSyncronizeResultCompositeObjectList();
						if (this.$DataReadMode) {
							this.clearAndSetDefValues();
							this.updateContainersVisibility();
						}
					},
					function() {
						this.set("DataReadMode", previousValue, {
							ignoreHandling: true
						});
					},
					this
				);
			},

			/**
			 * Clears attribute values.
			 * @protected
			 */
			clearValues: function() {
				let value = this.get("EntitySchemaColumnsControlsSelect");
				if (value) {
					value.clear();
				}
				value = this.get("SortingOrderControls");
				if (value) {
					value.clear();
				}
			},

			/**
			 * Clears and determines default values.
			 * @protected
			 */
			clearAndSetDefValues: function() {
				this.clearValues();
				const aggregateFunctionList = this.getAggregateFunctions();
				const columnSelectModes = this.getColumnSelectModes();
				this.$AggregateFunction = aggregateFunctionList[this.$AggregateFunctionEnum.Count];
				this.$ColumnSelectMode = columnSelectModes[this.$ColumnSelectModeEnum.ReadAllColumns];
				switch (this.$DataReadMode.value) {
					case this.$DataReadModeEnum.FirstRecordFromTheSample:
						this.addSortingOrderStatement();
						break;
					case this.$DataReadModeEnum.ConsiderTheFunction:
						this.$AggregateFunction = aggregateFunctionList[this.$AggregateFunctionEnum.Sum];
						this.setValidationInfo("AggregateFunction", true, null);
						break;
					default:
						break;
				}
				this.$AggregateColumn = null;
				this.setValidationInfo("AggregateColumn", true, null);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#setValidationConfig
			 * @overridden
			 */
			setValidationConfig: function() {
				this.callParent(arguments);
				const rowsCountRangeValidator = userTaskUtilities.validateRowsCountRange;
				this.addColumnValidator("NumberOfRecords", rowsCountRangeValidator);
			},

			/**
			 * @inheritdoc Terrasoft.BaseObject#onDestroy
			 * @overridden
			 */
			onDestroy: function() {
				if (this.$EntitySchemaColumnsControlsSelect) {
					this.$EntitySchemaColumnsControlsSelect.destroy();
				}
				this.callParent(arguments);
			},

			//endregion

			//region Methods: Public

			/**
			 * Returns data read modes.
			 * @public
			 * @return {Object}
			 */
			getDataReadModes: function() {
				const dataReadModeEnum = this.get("DataReadModeEnum");
				const localizableStrings = resources.localizableStrings;
				const dataReadModes = {};
				dataReadModes[dataReadModeEnum.FirstRecordFromTheSample] = {
					value: dataReadModeEnum.FirstRecordFromTheSample,
					displayValue: localizableStrings.FirstRecordFromTheSampleCaption
				};
				dataReadModes[dataReadModeEnum.ConsiderTheFunction] = {
					value: dataReadModeEnum.ConsiderTheFunction,
					displayValue: localizableStrings.ConsiderTheFunctionCaption
				};
				dataReadModes[dataReadModeEnum.CalculateTheNumberOfRecords] = {
					value: dataReadModeEnum.CalculateTheNumberOfRecords,
					displayValue: localizableStrings.CalculateTheNumberOfRecordsCaption
				};
				if (!this.isProcessSchemaCompiled() &&
					(Terrasoft.isDebug || this.getIsFeatureEnabled("ProcessParameterCollections"))) {
					dataReadModes[dataReadModeEnum.ReadCollection] = {
						value: dataReadModeEnum.ReadCollection,
						displayValue: localizableStrings.ReadCollectionCaption
					};
				}
				return dataReadModes;
			}

			//endregion

		},
		diff: [
			{
				"operation": "insert",
				"name": "DataReadModeLabelContainer",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"classes": {
						"wrapClassName": ["not-compile", "label-container"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataReadModeLabel",
				"parentName": "DataReadModeLabelContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.DataReadModeCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DataReadModeLabelContainer",
				"propertyName": "items",
				"name": "DataReadModeLabelInfoButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"content": Terrasoft.Resources.ProcessSchemaDesigner.Messages.CollectionInCompileProcessInfoText,
					"controlConfig": {
						"visible": "$isProcessSchemaCompiled"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "DataReadMode",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareDataReadModes"
						}
					},
					"labelConfig": {
						"visible": false
					},
					"wrapClass": ["no-caption-control"]
				}
			},
			{
				"operation": "merge",
				"name": "RecommendationLabel",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "merge",
				"name": "EntitySchemaSelect",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"name": "SelectAggregateFunctionLabel",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.SelectAggregateFunctionCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"visible": {
						"bindTo": "IsSelectAggregateFunctionContainerVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "AggregateFunction",
				"values": {
					"layout": {
						"column": 0,
						"row": 5,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {"bindTo": "prepareAggregateFunctionList"}
					},
					"labelConfig": {
						"visible": false
					},
					"wrapClass": ["no-caption-control"],
					"visible": {
						"bindTo": "IsSelectAggregateFunctionContainerVisible"
					}
				}
			},
			{
				"operation": "insert",
				"name": "SelectAggregateColumnLabel",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 6,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.SelectAggregateColumnCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"visible": {
						"bindTo": "IsSelectAggregateFunctionContainerVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "AggregateColumn",
				"values": {
					"layout": {
						"column": 0,
						"row": 7,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareAggregateColumnList"
						}
					},
					"labelConfig": {
						"visible": false
					},
					"wrapClass": ["no-caption-control"],
					"visible": {
						"bindTo": "IsSelectAggregateFunctionContainerVisible"
					},
					"enabled": {
						"bindTo": "AggregateFunction",
						"bindConfig": {
							"converter": function(aggregateFunction) {
								const aggregateFunctionEnum = this.get("AggregateFunctionEnum");
								return aggregateFunction && aggregateFunction.value !== aggregateFunctionEnum.Count;
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "FilterUnitLabel",
				"values": {
					"layout": {
						"column": 0,
						"row": 8,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "merge",
				"name": "ExtendedFiltersContainer",
				"values": {
					"layout": {
						"column": 0,
						"row": 9,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "RowCountContainer",
				"values": {
					"layout": {
						"column": 0,
						"row": 10,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["row-count-container"],
					"visible": {"bindTo": "IsReadCollectionModeVisible"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "RowCountContainer",
				"propertyName": "items",
				"name": "NumberOfRecords",
				"values": {
					"bindTo": "NumberOfRecords",
					"dataValueType": Terrasoft.DataValueType.INTEGER,
					"caption": "$Resources.Strings.ReadOnlyCaption"
				}
			},
			{
				"operation": "insert",
				"name": "MoreLabel",
				"parentName": "RowCountContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": "$Resources.Strings.RecordsCaption"
				}
			},
			{
				"operation": "insert",
				"name": "OrderDirectionLabel",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 11,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.OrderDirectionCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"visible": {
						"bindTo": "IsOrderDirectionContainerVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "SortingOrderContainer",
				"values": {
					"layout": {
						"column": 0,
						"row": 12,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": {
						"bindTo": "IsOrderDirectionContainerVisible"
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "SortingOrderContainer",
				"propertyName": "items",
				"name": "SelectedSortingOrderContainer",
				"values": {
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Id",
					"collection": "SortingOrderControls",
					"onGetItemConfig": "getSelectedSortingOrderViewConfig",
					"classes": {
						"wrapClassName": ["record-column-values-container", "grid-layout"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "SortingOrderContainer",
				"propertyName": "items",
				"name": "AddSortingOrderButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "Resources.Strings.AddSortingOrderButtonCaption"
					},
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					},
					"classes": {
						"wrapperClass": ["add-record-column-values-button"]
					},
					"click": {
						"bindTo": "onAddSortingOrderButtonClick"
					}
				}
			},
			{
				"operation": "insert",
				"name": "ColumnSelectModeLabel",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 13,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.ColumnSelectModeCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"visible": {
						"bindTo": "IsColumnSelectModeVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "BaseDataModificationLayout",
				"propertyName": "items",
				"name": "ColumnSelectMode",
				"values": {
					"layout": {
						"column": 0,
						"row": 14,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareColumnSelectModes"
						}
					},
					"labelConfig": {
						"visible": false
					},
					"wrapClass": ["no-caption-control"],
					"visible": {
						"bindTo": "IsColumnSelectModeVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "EditorsContainer",
				"propertyName": "items",
				"name": "EntityColumnsContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 0,
						"row": 15,
						"colSpan": 24
					},
					"items": [],
					"visible": {
						"bindTo": "IsEntitySchemaColumnsContainerVisible"
					},
					"wrapClass": ["entity-columns-container", "no-caption-control"]
				}
			},
			{
				"operation": "insert",
				"parentName": "EntityColumnsContainer",
				"propertyName": "items",
				"name": "RecordColumnValuesContainer",
				"values": {
					"generator": "ConfigurationItemGenerator.generateContainerList",
					"idProperty": "Id",
					"collection": "EntitySchemaColumnsControlsSelect",
					"onGetItemConfig": "getEntitySchemaColumnsControlsSelectViewConfig",
					"itemPrefix": "Id",
					"classes": {
						"wrapClassName": ["record-column-values-container", "grid-layout"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "EntityColumnsContainer",
				"propertyName": "items",
				"name": "AddRecordColumnValuesButton",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.BUTTON,
					"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {
						"bindTo": "Resources.Images.AddButtonImage"
					},
					"caption": {
						"bindTo": "Resources.Strings.AddEntitySchemaColumnButtonCaption"
					},
					"classes": {
						"wrapperClass": ["add-record-column-values-button"]
					},
					"click": {
						"bindTo": "onAddEntitySchemaColumnControlSelect"
					}
				}
			}
		]
	};
});
