﻿/**
 * @class Terrasoft.configuration.ProcessSchemaUserTaskUtilities
 * ProcessSchemaUserTaskUtilities class.
 */
define("ProcessSchemaUserTaskUtilities", ["ext-base", "terrasoft", "ProcessUserTaskConstants",
	"ProcessSchemaUserTaskUtilitiesResources", "Activity"],
	function(Ext, Terrasoft, ProcessUserTaskConstants, resources, activityEntitySchema) {
		const definedClass = Ext.ClassManager.get("Terrasoft.ProcessSchemaUserTaskUtilities");
		if (definedClass) {
			return Ext.create(definedClass);
		}
		const processSchemaUserTaskUtilities = Ext.define("Terrasoft.configuration.ProcessSchemaUserTaskUtilities", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.ProcessSchemaUserTaskUtilities",

			/**
			 * UId of the process read data user task schema manager item.
			 * @type {String}
			 */
			ReadDataUserTaskSchemaUId: "cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f",

			/**
			 * UId of the process object file processing user task schema manager item.
			 * @type {String}
			 */
			ObjectFileProcessingUserTaskSchemaUId: "9387c794-8d84-5925-ab77-c47e7d876286",

			/**
			 * UId of the process report file processing user task schema manager item.
			 * @type {String}
			 */
			ReportFileProcessingUserTaskSchemaUId: "c2bf0416-54c6-6c56-58e0-41162c7795f0",

			/**
			 * UId of the process file processing user task schema manager item.
			 * @type {String}
			 */
			ProcessFileProcessingUserTaskSchemaUId: "6c620dd2-026e-560c-489f-030c5be5f2c3",

			/**
			 * UId of the process change admin rights user task schema manager item.
			 * @type {String}
			 */
			ChangeAdminRightsUserTaskSchemaUId: "0ebbb23c-f6db-45eb-ad13-a1445b7ef081",

			/**
			 * UId of the process autogenerated page user task schema manager item.
			 * @type {String}
			 */
			AutoGeneratedPageUserTaskSchemaUId: "b5936328-09b2-45fd-b763-48d37c265644",

			/**
			 * UId of the process user question user task schema manager item.
			 * @type {String}
			 */
			UserQuestionUserTaskSchemaUId: 'fe10dd95-2d61-4aa1-8111-9fb23b032603',

			/**
			 * UId of the process open edit page user task schema manager item.
			 * @type {String}
			 */
			OpenEditPageUserTaskSchemaUId: 'b0d3ad9f-7a27-46a3-9483-ed70c26872ae',

			/**
			 * UId of the process preconfigured page user task schema manager item.
			 * @type {String}
			 */
			PreconfiguredPageUserTaskSchemaUId: 'ac2ef13c-30dd-4023-9c04-58f580743b48',

			/**
			 * UId of the approval user task schema manager item.
			 * @type {String}
			 */
			ApprovalUserTaskSchemaUId: "51179e03-650d-4492-862d-9943005c26b4",

			/**
			 * UId of the activity user task schema manager item.
			 * @type {String}
			 */
			ActivityUserTaskSchemaUId: "b5c726f2-af5b-4381-bac6-913074144308",

			/**
			 * @private
			 */
			_getResultParameterByResultType: function(element) {
				const parameter = element.findParameterByName("ResultType");
				let resultParameter;
				switch (parameter.getValue()) {
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY:
						resultParameter = element.findParameterByName("ResultEntity");
						break;
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY_COLLECTION:
						resultParameter = element.findParameterByName("ResultCompositeObjectList");
						break;
					default:
						resultParameter = null;
						break;
				}
				return resultParameter;
			},

			/**
			 * @private
			 */
			_findEntitySchemaInstance: function(findSchemaConfig, callback, scope) {
				var isEnabled = Terrasoft.Features.getIsEnabled("AutoAddPackageDependenciesInProcesses");
				if (isEnabled) {
					Terrasoft.EntitySchemaManager.findAggregatedSchemaInstance(findSchemaConfig, callback, scope);
				} else {
					Terrasoft.EntitySchemaManager.findBundleSchemaInstance(findSchemaConfig, callback, scope);
				}
			},

			/**
			 * Finds result data of parameters for read data user task.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @return {Object || null}
			 */
			findReadDataUserTaskSchemaResultInfo: function(element) {
				const resultParameter = this.findResultParameter(element.parameters) ||
					this._getResultParameterByResultType(element);
				if (resultParameter) {
					const resultInfo = {resultParameters: []};
					if (resultParameter.dataValueType === Terrasoft.DataValueType.ENTITY) {
						resultInfo.resultParameter = resultParameter;
						const parameter = element.findParameterByName("EntityColumnMetaPathes");
						let metaPaths = parameter.getValue();
						if (!Ext.isEmpty(metaPaths)) {
							metaPaths = metaPaths.split(";");
							resultInfo.entitySchemaColumnUIds = metaPaths;
						}
						return resultInfo;
					}
					resultInfo.resultParameters = [resultParameter];
					return resultInfo;
				} else {
					return null;
				}
			},

			/**
			 * Returns result data of parameters for read data user task.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			getReadDataUserTaskSchemaResultParametersInfo: function(element, callback, scope) {
				let resultInfo = this.findReadDataUserTaskSchemaResultInfo(element);
				if (resultInfo) {
					callback.call(scope, resultInfo);
					return;
				}
				resultInfo = {
					resultParameters: []
				};
				let resultParameter = null;
				const parameter = element.findParameterByName("FunctionType");
				const functionType = parameter.getValue();
				const aggregationType = Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.COUNT);
				if (functionType === aggregationType) {
					resultParameter = element.findParameterByName("ResultCount");
					resultInfo.resultParameters = [resultParameter];
					callback.call(scope, resultInfo);
					return;
				}
				const aggregateColumnNameParameter = element.findParameterByName("AggregationColumnName");
				const aggregateColumnName = aggregateColumnNameParameter.getValue();
				const resultEntityParameter = element.findParameterByName("ResultEntity");
				const referenceSchemaUId = resultEntityParameter.referenceSchemaUId;
				let dataValueType = null;
				const config = {
					schemaUId: referenceSchemaUId,
					packageUId: element.getPackageUId()
				};
				this._findEntitySchemaInstance(config, function(schema) {
					if (schema) {
						schema.columns.each(function (column) {
							if (column.name === aggregateColumnName) {
								dataValueType = column.dataValueType;
								return false;
							}
						}, this);
					}
					if (dataValueType === Terrasoft.DataValueType.INTEGER) {
						resultParameter = element.findParameterByName("ResultIntegerFunction");
					} else if (Terrasoft.isNumberDataValueType(dataValueType)) {
						resultParameter = element.findParameterByName("ResultFloatFunction");
					} else if (Terrasoft.isDateDataValueType(dataValueType)) {
						resultParameter = element.findParameterByName("ResultDateTimeFunction");
					}
					resultInfo.resultParameters = resultParameter ? [resultParameter] : element.parameters.getItems();
					callback.call(scope, resultInfo);
				}, this);
			},

			/**
			 * @private
			 */
			_getObjectFileProcessingUserTaskResultParametersInfo: function(element, callback, scope) {
				const resultActionType = element.findParameterByName("ResultActionType");
				const resultParameters = [];
				let resultFilesParameterName;
				switch (element.managerItemUId) {
					case this.ReportFileProcessingUserTaskSchemaUId:
						resultFilesParameterName = "ReportFiles";
						break;
					case this.ObjectFileProcessingUserTaskSchemaUId:
						resultFilesParameterName = "ObjectFiles";
						break;
					default:
						break;
				}
				const resultFilesParameter = element.findParameterByName(resultFilesParameterName);
				if (resultFilesParameter) {
					resultParameters.push(resultFilesParameter);
				}
				if (resultActionType && resultActionType.getValue() === Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskResultActionType.SaveToFiles) {
					const createdObjectFileIdsParameter = element.findParameterByName("CreatedObjectFileIds");
					if (createdObjectFileIdsParameter) {
						resultParameters.push(createdObjectFileIdsParameter);
					}
				}
				const resultInfo = {
					resultParameters: resultParameters
				};
				callback.call(scope, resultInfo);
			},

			/**
			 * Returns result parameter if it is found.
			 * @param {Array|Terrasoft.Collection} parameters Parameters of the element.
			 * @return {Terrasoft.ProcessSchemaParameter}
			 */
			findResultParameter: function(parameters) {
				if (!parameters) {
					return null;
				}
				let resultParameter = null;
				const items = parameters instanceof Terrasoft.Collection ? parameters.getItems() : parameters;
				Terrasoft.each(items, function (item) {
					if (item.isResult) {
						resultParameter = item;
						return false;
					}
				}, this);
				return resultParameter;
			},

			/**
			 * @private
			 */
			_activityParameterNames: [
				"ActivityCategory",
				"ActivityPriority",
				"CreateActivity",
				"CurrentActivityId",
				"Duration",
				"DurationPeriod",
				"IsActivityCompleted",
				"RemindBefore",
				"RemindBeforePeriod",
				"ShowInScheduler",
				"StartIn",
				"StartInPeriod"
			],

			/**
			 * Returns EntitySchemaQuery for schema EntityConnection.
			 * @private
			 */
			_getEntityConnectionSchemaQuery: function() {
				const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "EntityConnection",
					clientESQCacheParameters: {
						cacheItemName: activityEntitySchema.uId + "_" + this.name
					}
				});
				esq.addColumn("ColumnUId");
				esq.addColumn("Position");
				esq.filters.addItem(esq.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "SysEntitySchemaUId", activityEntitySchema.uId));
				return esq;
			},

			/**
			 * @private
			 */
			_sortEntityConnections: function(entityConnectionColumns) {
				entityConnectionColumns.sort(null, null, function(item1, item2) {
					const position1 = item1.position;
					const position2 = item2.position;
					if (position1 === position2) {
						const caption1 = item1.caption;
						const caption2 = item2.caption;
						return caption1.localeCompare(caption2);
					}
					return position1 - position2;
				});
			},

			/**
			 * @private
			 */
			_addProjectConnection: function(entityConnections) {
				const project = activityEntitySchema.columns.Project;
				if (project && !entityConnections.contains(project.name)) {
					entityConnections.add(project.name, {
						id: project.uId,
						name: project.name,
						caption: project.caption,
						position: 0
					});
				}
			},

			/**
			 * Loads entity connection columns.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			loadEntityConnectionColumns: function(callback, scope) {
				const entityConnectionColumns = Ext.create("Terrasoft.Collection");
				const esq = this._getEntityConnectionSchemaQuery();
				esq.getEntityCollection(function(result) {
					if (result.success) {
						const entities = result.collection;
						entities.each(function(item) {
							const columnUId = item.get("ColumnUId");
							const entityColumn = activityEntitySchema.findColumnByUId(columnUId);
							if (!entityColumn || entityConnectionColumns.contains(entityColumn.name)) {
								return true;
							}
							const position = item.get("Position");
							entityConnectionColumns.add(entityColumn.name, {
								id: entityColumn.uId,
								name: entityColumn.name,
								caption: entityColumn.caption,
								position: position
							});
						}, this);
						this._sortEntityConnections(entityConnectionColumns);
						this._addProjectConnection(entityConnectionColumns);
					}
					callback.call(scope, entityConnectionColumns);
				}, this);
			},

			/**
			 * @private
			 */
			_removeTechnicalActivityParameters: function(resultParameters, callback, scope) {
				this.loadEntityConnectionColumns(function(columns) {
					resultParameters = Terrasoft.filter(resultParameters, function(parameter) {
						if (Terrasoft.contains(this._activityParameterNames, parameter.name)) {
							return false;
						}
						return !columns.findByFn(f => f.name === parameter.name, this);
					}, this);
					Ext.callback(callback, scope, [{
						resultParameters: resultParameters
					}]);
				}, this);
			},

			/**
			 * @private
			 */
			_getInteractiveUserTaskResultParametersInfo: function(element, callback, scope) {
				let resultParameters = element.getResultParameters();
				const createActivityParameter = element.findParameterByName("CreateActivity");
				const createActivity = createActivityParameter?.getValue() ?? false;
				if (!createActivity) {
					this._removeTechnicalActivityParameters(resultParameters, callback, scope);
					return;
				}
				const resultInfo = {
					resultParameters: resultParameters
				};
				callback.call(scope, resultInfo);
			},

			/**
			 * Returns result data of parameters.
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			getResultParametersInfo: function(element, callback, scope) {
				const managerItemUId = element.managerItemUId;
				switch(managerItemUId) {
					case this.ReadDataUserTaskSchemaUId: {
						this.getReadDataUserTaskSchemaResultParametersInfo(element, callback, scope);
						return;
					}
					case this.ObjectFileProcessingUserTaskSchemaUId:
					case this.ReportFileProcessingUserTaskSchemaUId:
					case this.ProcessFileProcessingUserTaskSchemaUId: {
						this._getObjectFileProcessingUserTaskResultParametersInfo(element, callback, scope);
						return;
					}
					case this.AutoGeneratedPageUserTaskSchemaUId:
					case this.PreconfiguredPageUserTaskSchemaUId:
					case this.OpenEditPageUserTaskSchemaUId:
					case this.UserQuestionUserTaskSchemaUId: {
						this._getInteractiveUserTaskResultParametersInfo(element, callback, scope);
						return;
					}
				}
				const parameters = element.getResultParameters();
				const resultInfo = {
					resultParameters: parameters
				};
				callback.call(scope, resultInfo);
			},

			/**
			 * Generates unique element name by prefix.
			 * @param {String} prefix Prefix name.
			 * @param {Terrasoft.Collection} collection of items.
			 * @param {Function} filterFn Filter function.
			 * @return {String}
			 * @example
			 * var filterFn = function(item, name) {
			 *     return item.name === name;
			 * };
			 * var name = parentSchema.generateItemUniqueName("Button", buttonsCollection, filterFn);
			 */
			generateItemUniqueName: function(prefix, collection, filterFn, startIndex) {
				let counter = startIndex || 1;
				let name = prefix + counter;
				const internalFilterFn = function(item) {
					return filterFn(item, name);
				};
				do {
					const filteredItems = collection.filterByFn(internalFilterFn);
					if (filteredItems.getCount() === 0) {
						return name;
					}
					counter++;
					name = prefix + counter;
				} while (true);
			},

			/**
			 * Validates mapping value.
			 * @public
			 * @param  {Object} value Mapping value.
			 * @return {Object} Validation info.
			 * @return {Object} return.isValid Validation result.
			 * @return {Object} return.invalidMessage Validation message.
			 */
			validateMappingValue: function(value) {
				const fieldValue = Ext.isObject(value) ? value.value : null;
				const isValid = !Ext.isEmpty(fieldValue);
				const message = resources.localizableStrings.ValidateMappingFieldInvalidMessage;
				const validationInfo = {
					isValid: isValid,
					invalidMessage: isValid ? "" : message
				};
				return validationInfo;
			},

			/**
			 * Validates if row count is in range.
			 * @public
			 * @param {Number} value to validate.
			 * @return {Object} Validation result.
			 */
			validateRowsCountRange: function(value) {
				let invalidMessage;
				const minMessage = Terrasoft.Resources.BaseViewModel.columnIncorrectMinNumberValidationMessage;
				const maxMessage = Terrasoft.Resources.BaseViewModel.columnIncorrectMaxNumberValidationMessage;
				const minValue = 1;
				const maxValue = 5000;
				if (value > maxValue) {
					invalidMessage = Ext.String.format(maxMessage, maxValue);
				} else if (value < minValue) {
					invalidMessage = Ext.String.format(minMessage, minValue);
				} else {
					invalidMessage = "";
				}
				return {
					fullInvalidMessage: invalidMessage,
					invalidMessage: invalidMessage
				};
			},

			/**
			 * Validates select value.
			 * @param {Object} value Value to validate.
			 * @return {Object} Validation info.
			 * @return {Object} return.isValid Validation result.
			 * @return {Object} return.invalidMessage Validation message.
			 */
			validateSelectValue: function(value) {
				let isValid = true;
				let invalidMessage = "";
				if (Terrasoft.isEmptyObject(value) || Ext.isEmpty(value.value)) {
					isValid = false;
					invalidMessage = Terrasoft.Resources.BaseViewModel.columnRequiredValidationMessage;
				}
				return {
					isValid: isValid,
					invalidMessage: invalidMessage
				};
			}
		});

		return Ext.create(processSchemaUserTaskUtilities);
	});
