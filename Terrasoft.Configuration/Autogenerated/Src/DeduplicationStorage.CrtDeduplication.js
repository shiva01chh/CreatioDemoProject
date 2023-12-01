﻿/**
 * @class Terrasoft.configuration.DeduplicationStorage
 */
define("DeduplicationStorage", ["ServiceHelper"], function(ServiceHelper) {
	Ext.define("Terrasoft.configuration.DeduplicationStorage", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.DeduplicationStorage",

		singleton: true,

		/**
		 * @type Object
		 */
		groups: null,

		/**
		 * Response rows configuration.
		 * @type Object
		 */
		rowConfig: null,

		constructor: function() {
			this.callParent(arguments);
			this._reset();
		},

		/**
		 * @private
		 */
		_reset: function() {
			this.groups = {};
		},

		/**
		 * @param {Array<Object>} groups
		 * @private
		 */
		_mergeGroups: function(groups) {
			const storedGroups = this.groups;
			groups.forEach(function(group) {
				const groupId = group.groupId;
				const findStoredGroup = storedGroups[groupId] = storedGroups[groupId] || {
					rows: [],
					groupId: groupId
				};
				Ext.Array.push(findStoredGroup.rows, group.rows);
			});
		},

		/**
		 * @param {Array<Object>} groups
		 * @private
		 */
		_updateCompleteGroups: function(groups) {
			const groupIdList = Ext.Array.pluck(groups, 'groupId');
			const storedGroupIdList = Ext.Object.getKeys(this.groups);
			if (storedGroupIdList.length === 0) {
				return;
			}
			const firstGroupId = groupIdList.shift();
			const contains = Ext.Array.contains(storedGroupIdList, firstGroupId);
			if (groupIdList.length === 0 && contains) {
				return;
			}
			this._setCompleteGroups();
		},

		/**
		 * @private
		 */
		_setCompleteGroups: function() {
			const storedGroups = this.groups;
			const storedGroupIdList = Ext.Object.getKeys(this.groups);
			storedGroupIdList.forEach(function (groupId) {
				const storeGroup = storedGroups[groupId];
				storeGroup.compled = true;
			});
		},

		_getCompletedItemsCount: function() {
			let count = 0;
			const groupValues = Ext.Object.getValues(this.groups);
			groupValues.forEach(function(group) {
				if (group.compled === true) {
					count += group.rows.length;
				}
			});
			return count;
		},

		/**
		 * @param {Number} clientCount
		 * @param {Number} loadedRecordsCount
		 * @private
		 * @return {Boolean}
		 */
		_needLoadNextPage: function(clientCount, loadedRecordsCount) {
			const nextPageIsEmpty = clientCount > loadedRecordsCount;
			const groupValues = Ext.Object.getValues(this.groups);
			if (nextPageIsEmpty) {
				this._setCompleteGroups();
				return false;
			}
			const completedGroups = groupValues.filter(function(group) {
				return group.compled === true;
			});
			if (completedGroups.length === groupValues.length) {
				return false;
			}
			return clientCount > this._getCompletedItemsCount();
		},

		/**
		 * @param {Number} count
		 * @return {Array}
		 * @private
		 */
		_getResultGroups: function(count) {
			const resultGroups = [];
			let totalCount = 0;
			Terrasoft.each(this.groups, function(group, groupId) {
				if (group.compled) {
					resultGroups.push(group);
					delete this.groups[groupId];
					totalCount += group.rows.length;
				}
				if (totalCount >= count) {
					return false;
				}
			}, this);
			return resultGroups;
		},

		/**
		 * @private
		 */
		_parseDeduplicationResponse: function (response) {
			const resultJson = response && response.result || "{}";
			const result = JSON.parse(resultJson) || {};
			return result;
		},

		/**
		 * @private
		 */
		_callBulkDeduplicationService: function(methodName, config, callback, scope) {
			scope = scope || this;
			ServiceHelper.callService({
				serviceName: "BulkDeduplicationService",
				methodName: methodName,
				timeout: Terrasoft.SysSettings?.getCachedSysSetting("DataServiceQueryTimeout") || 30 * 1000,
				callback: function(response) {
					const result = this._parseDeduplicationResponse(response);
					Ext.callback(callback, scope, [result]);
				}.bind(this),
				data: config,
				scope: scope,
			});
		},

		/**
		 * Load deduplication results.
		 * @param {Object} config Deduplication service handler config.
		 * @param {String} config.entityName Entity name.
		 * @param {String[]} config.columns Columns names.
		 * @param {Number} config.offset Offset.
		 * @param {Number} config.count Count.
		 * @param {Function} callback The callback function.
		 * @param {Object} [scope] The scope for the callback.
		 */
		getDeduplicationResults: function(config, callback, scope) {
			scope = scope || this;
			if (config.offset === 0) {
				this._reset();
			}
			const serviceConfig = {
				serviceName: "BulkDeduplicationService",
				methodName: "GetDuplicateEntities",
				timeout: Terrasoft.SysSettings?.getCachedSysSetting("DataServiceQueryTimeout") || 30 * 1000,
				callback: function(response) {
					const resultJson = response && response.result || "{}";
					const result = JSON.parse(resultJson) || {};
					const totalCountRecords = result.totalCountRecords || 0;
					const groups = result.groups || [];
					this.rowConfig = result.rowConfig || this.rowConfig;
					this._updateCompleteGroups(groups);
					this._mergeGroups(groups);
					if (this._needLoadNextPage(config.count, totalCountRecords)) {
						config.offset = result.nextOffset;
						this.getDeduplicationResults(config, callback, scope);
					} else {
						const resultGroups = this._getResultGroups(config.count);
						const data = {
							groups: resultGroups,
							nextOffset: result.nextOffset || -1,
							allDownloaded: config.count > totalCountRecords || totalCountRecords === 0,
							rowConfig: this.rowConfig
						};
						Ext.callback(callback, scope, [data]);
					}
				}.bind(this),
				data: config,
				scope: this,
			};
			ServiceHelper.callService(serviceConfig);
		},

		/**
		 * Load deduplication results groups.
		 * @param {Object} config Deduplication service handler config.
		 * @param {String} config.entityName Entity name.
		 * @param {String[]} config.columns Columns names.
		 * @param {Number} config.offset Offset.
		 * @param {Number} config.count Count.
		 * @param {Number} config.topDuplicatesPerGroup Count of duplicates rows by group.
		 * @param {Function} callback The callback function.
		 * @param {Object} [scope] The scope for the callback.
		 */
		fetchGroupOfDuplicates: function(config, callback, scope) {
			this._callBulkDeduplicationService("GetGroupsOfDuplicates", config, callback, scope);
		},

		/**
		 * Load group count and duplicates count.
		 * @param {Object} config Deduplication service handler config.
		 * @param {String} config.entityName Entity name.
		 * @param {Function} callback The callback function.
		 * @param {Object} [scope] The scope for the callback.
		 */
		fetchDuplicatesCount: function(config, callback, scope) {
			this._callBulkDeduplicationService("GetDuplicatesCountData", config, callback, scope);
		},

		/**
		 * Load duplicates by group identifier.
		 * @param {Object} config Deduplication service handler config.
		 * @param {String} config.groupId Duplicates group id.
		 * @param {String} config.entityName Entity name.
		 * @param {String[]} config.columns Columns names.
		 * @param {Number} config.offset Offset.
		 * @param {Number} config.count Count.
		 * @param {Function} callback The callback function.
		 * @param {Object} [scope] The scope for the callback.
		 */
		fetchDuplicatesByGroup: function(config, callback, scope) {
			this._callBulkDeduplicationService("GetDuplicateEntitiesByGroup", config, callback, scope);
		}

	});
	return {};
});
