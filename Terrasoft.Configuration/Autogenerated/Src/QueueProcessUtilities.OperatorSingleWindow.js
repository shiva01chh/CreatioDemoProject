define("QueueProcessUtilities", ["terrasoft", "ProcessModuleUtilities", "OperatorSingleWindowConstants",
		"ServiceHelper", "MaskHelper", "ConfigurationConstants", "QueueProcessUtilitiesResources"],
	function(Terrasoft, ProcessModuleUtilities, OperatorSingleWindowConstants, ServiceHelper, MaskHelper,
		ConfigurationConstants, resources) {

	/**
	 * @class Terrasoft.configuration.mixins.QueueProcessUtilities
	 * Mixin for queue process utilities.
	 */
	Ext.define("Terrasoft.configuration.mixins.QueueProcessUtilities", {
		alternateClassName: "Terrasoft.QueueProcessUtilities",
		extend: "Terrasoft.core.BaseObject",

		//region Methods: Private

		/**
		 * ######### #######, ######### # ########## ####### ######## #######.
		 * @private
		 * @param {Object} parameters ######### ####### ########.
		 * @param {String} parameters.processName ### ##### ########.
		 * @param {String} parameters.queueItemId ########## ############# ###### ######## #######.
		 * @param {String} parameters.entityRecordId ############# ###### ########## #######.
		 * @param {String} parameters.sysProcessDataId (optional) ############# ###### ########### ########.
		 */
		runQueueItemProcess: function(parameters) {
			const processId = parameters.sysProcessDataId;
			const queueItemId = parameters.queueItemId;
			if (!Ext.isEmpty(processId)) {
				this._continueQueueItemProcess(queueItemId, processId);
				return;
			}
			const processParameters = {
				queueItemId: queueItemId,
				entityRecordId: parameters.entityRecordId
			};
			const runProcessCallback = function (options, success, response) {
				MaskHelper.HideBodyMask();
				const responseText = Ext.decode(response.responseText);
				const responseObject = Ext.decode(responseText);
				const processStatus = responseObject.processStatus;
				const isErrorProcessStatus = processStatus === ConfigurationConstants.SysProcessStatus.Error;
				if (!success || !responseObject.success || isErrorProcessStatus) {
					this.showInformationDialog(resources.localizableStrings.QueueItemNotStartedSuccessfullyMessage);
					return;
				}
				const returnValues = Ext.decode(Ext.decode(response.responseText));
				const processId = returnValues.processId;
				const update = Ext.create("Terrasoft.UpdateQuery", {
					rootSchemaName: "QueueItem"
				});
				update.enablePrimaryColumnFilter(queueItemId);
				update.setParameterValue("SysProcessDataId", processId, Terrasoft.DataValueType.GUID);
				update.execute();
			}.bind(this);
			ProcessModuleUtilities.runProcess(parameters.processName, processParameters, runProcessCallback);
		},

		/**
		 * ######## ### # ######### ### ####### ########, ########## # ########## #######.
		 * @private
		 * @param {String} queueItemId ########## ############# ###### ######## #######.
		 * @param {Boolean} runBySupervisor ####### ####, ### ####### ########### ## #### ###########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} callback.parameters ######### ######## ### ######.
		 * @throws {Terrasoft.ItemNotFoundException} ####### ##########, #### ### ####### ## #######
		 * ### ##### ########.
		 */
		getQueueItemProcess: function(queueItemId, runBySupervisor, callback) {
			const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "QueueItem"
			});
			esq.isDistinct = true;
			esq.addColumn("Queue.[SysSchema:UId:BusinessProcessSchema].Name", "ProcessSchemaName");
			esq.addColumn("EntityRecordId", "EntityRecordId");
			esq.addColumn("SysProcessDataId", "SysProcessDataId");
			esq.addColumn("Operator", "Operator");
			esq.addColumn("Status.IsFinal", "IsFinal");
			esq.filters.add("queueItemId", Terrasoft.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "Id", queueItemId));
			esq.getEntityCollection(function(result) {
				if (result.success === false) {
					return;
				}
				let item;
				let isFinished;
				const resultCollection = result.collection;
				if (resultCollection.isEmpty()) {
					isFinished = true;
				} else {
					item = resultCollection.getByIndex(0);
					isFinished = item.get("IsFinal");
				}
				let warningMessage;
				if (isFinished === true) {
					warningMessage = resources.localizableStrings.QueueItemInFinishedStatusMessage;
				} else {
					if (!runBySupervisor) {
						const operatorItem = item.get("Operator");
						if (!Ext.isEmpty(operatorItem) &&
								(operatorItem.value !== Terrasoft.SysValue.CURRENT_USER_CONTACT.value)) {
							warningMessage = Ext.String.format(
								resources.localizableStrings.OtherOperatorWorkingOnElementMessage,
								operatorItem.displayValue);
						}
					}
				}
				if (!Ext.isEmpty(warningMessage)) {
					this.showInformationDialog(warningMessage, function() {
						callback(null);
					});
					return;
				}
				const processName = item.get("ProcessSchemaName");
				const sysProcessDataId = item.get("SysProcessDataId");
				if (Ext.isEmpty(processName)) {
					this.showInformationDialog(resources.localizableStrings.ProcessSchemaNotFoundOperatorMessage);
					const errorMessage = Ext.String.format(
						resources.localizableStrings.ProcessSchemaNotFoundExceptionMessage, queueItemId);
					throw new Terrasoft.ItemNotFoundException({message: errorMessage});
				}
				const entityRecordId = item.get("EntityRecordId");
				const processParameters = {
					processName: processName,
					queueItemId: queueItemId,
					entityRecordId: entityRecordId,
					sysProcessDataId: sysProcessDataId
				};
				callback(processParameters);
			}.bind(this));
		},

		/**
		 * @private
		 */
		_updateQueueItem: function(queueItemId, callback, scope) {
			const update = Ext.create("Terrasoft.UpdateQuery", {
				rootSchemaName: "QueueItem"
			});
			update.enablePrimaryColumnFilter(queueItemId);
			update.setParameterValue("Operator", Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
				Terrasoft.DataValueType.GUID);
			update.execute(callback, scope);
		},

		/**
		 * @private
		 */
		_continueQueueItemProcess: function(queueItemId, processId) {
			if (Terrasoft.Features.getIsEnabled("UseObsoleteContinueProcessMethod")) {
				this._obsoleteContinueQueueItemProcess(queueItemId, processId);
				return;
			}
			ProcessModuleUtilities.openProcessExecutionPage(processId, function(processFound) {
				if (!processFound) {
					this.showInformationDialog(resources.localizableStrings.ProcessInstanceNotFoundOperatorMessage);
					return;
				}
				this._updateQueueItem(queueItemId);
			}, this);
		},

		/**
		 * @private
		 */
		_obsoleteContinueQueueItemProcess: function(queueItemId, processId) {
			this._checkProcessInstanceExists(processId, function(result) {
				if (!result) {
					this.showInformationDialog(resources.localizableStrings.ProcessInstanceNotFoundOperatorMessage);
					return;
				}
				this._updateQueueItem(queueItemId, function() {
					ProcessModuleUtilities.continueExecuting(processId);
				}, this);
			}, this);
		},

		/**
		 * @private
		 */
		_checkProcessInstanceExists: function(processId, callback, scope) {
			const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "SysProcessData"
			});
			esq.enablePrimaryColumnFilter(processId);
			esq.getEntityCollection(function(response) {
				let result = false;
				if (response.success && response.collection) {
					result = !response.collection.isEmpty();
				}
				Ext.callback(callback, scope, [result]);
			}, this);
		},

		//endregion

		//region Methods: Protected

		/**
		 * Returns queue item process parameters and executes this process.
		 * @protected
		 * @param {String} primaryColumnValue Queue item entity record identifier.
		 * @param {Boolean} runBySupervisor Sign that process is executed in Agent desktop window.
		 * @param {Function} callback Callback function.
		 * @param {Boolean} callback.canRunQueueItemProcess Sign that current operator can run queue item process
		 * element.
		 */
		executeQueueItemProcess: function(primaryColumnValue, runBySupervisor, callback) {
			this.updateQueueItemStatus(primaryColumnValue, function() {
				this.getQueueItemProcess(primaryColumnValue, runBySupervisor, function(processParameters) {
					const canRunQueueItemProcess = !Ext.isEmpty(processParameters);
					if (canRunQueueItemProcess) {
						this.runQueueItemProcess(processParameters);
					}
					callback(canRunQueueItemProcess);
				}.bind(this));
			}.bind(this));
		},

		/**
		 * Updates queue item status and operator.
		 * @protected
		 * @param {String} primaryColumnValue Queue item entity record identifier.
		 * @param {Function} callback Callback function.
		 */
		updateQueueItemStatus: function(primaryColumnValue, callback) {
			const update = Ext.create("Terrasoft.UpdateQuery", {
				rootSchemaName: "QueueItem"
			});
			update.enablePrimaryColumnFilter(primaryColumnValue);
			update.filters.addItem(Terrasoft.createColumnIsNullFilter("Operator"));
			update.setParameterValue("Operator", Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
				Terrasoft.DataValueType.GUID);
			update.setParameterValue("Status", OperatorSingleWindowConstants.QueueItemStatuses.IN_PROGRESS,
				Terrasoft.DataValueType.GUID);
			update.execute(callback);
		}

		//endregion

	});
	return Ext.create("Terrasoft.configuration.mixins.QueueProcessUtilities");
});
