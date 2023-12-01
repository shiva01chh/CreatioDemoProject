﻿define("ActivityPageV2", ["BaseFiltersGenerateModule", "BusinessRuleModule", "ConfigurationConstants",
		"ConfigurationEnums", "ActivityDatesMixin", "ActivityTimezoneMixin", "css!ActivityTimezoneMixin",
		"TimezoneGenerator"],
	function(BaseFiltersGenerateModule, BusinessRuleModule, ConfigurationConstants, Enums) {
		return {
			entitySchemaName: "Activity",
			mixins: {
				/**
				 * @class ActivityDatesMixin
				 * MiniPage Activity dates mixin.
				 */
				ActivityDatesMixin: Terrasoft.ActivityDatesMixin,

				/**
				 * @class ActivityTimezoneMixin
				 * Activity time zone mixin.
				 */
				ActivityTimezoneMixin: Terrasoft.ActivityTimezoneMixin
			},
			messages: {
				/**
				 * @message GetScheduleItemTitle
				 * ########## ######### ########## # ###### ######## #########
				 */
				"GetScheduleItemTitle": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {
				"IsProcessMode": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				"Author": {
					"isRequired": true
				},
				"Status": {
					"isRequired": true,
					lookupListConfig: {
						columns: ["Finish"]
					},
					dependencies: [
						{
							columns: ["Status"],
							methodName: "onStatusChanged"
						}
					]
				},
				/**
				 * Date and time of start activity.
				 */
				"StartDate": {
					dataValueType: this.Terrasoft.DataValueType.DATE_TIME,
					dependencies: [
						{
							columns: ["StartDate"],
							methodName: "clearSeconds"
						},
						{
							columns: ["StartDate"],
							methodName: "onStartDateChanged"
						},
						{
							columns: ["StartDate"],
							methodName: "setOffsetDates"
						},
						{
							columns: ["StartDate"],
							methodName: "setRemindDates"
						}
					]
				},
				/**
				 * Date and time activity completion.
				 */
				"DueDate": {
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					dependencies: [
						{
							columns: ["DueDate"],
							methodName: "clearSeconds"
						},
						{
							columns: ["DueDate"],
							methodName: "onDueDateChanged"
						},
						{
							columns: ["DueDate"],
							methodName: "setOffsetDates"
						}
					]
				},
				/**
				 * Remind to author attribute.
				 * @type {Boolean}
				 */
				"RemindToAuthor": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					dependencies: [
						{
							columns: ["RemindToAuthor"],
							methodName: "onRemindToAuthorChanged"
						}
					]
				},
				/**
				 * Remind to owner attribute.
				 * @type {Boolean}
				 */
				"RemindToOwner": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					dependencies: [
						{
							columns: ["RemindToOwner"],
							methodName: "onRemindToOwnerChanged"
						}
					]
				},
				"ActivityCategory": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					dependencies: [
						{
							columns: ["ActivityCategory"],
							methodName: "onActivityCategoryChange"
						}
					]
				},
				"Result": {
					lookupListConfig: {
						filters: [
							function() {
								var type = this.get("ActivityCategory");
								var filterGroup = Ext.create("Terrasoft.FilterGroup");
								filterGroup.add("ActivityCategory",
									Terrasoft.createColumnFilterWithParameter(
										Terrasoft.ComparisonType.EQUAL,
										"[ActivityCategoryResultEntry:ActivityResult].ActivityCategory",
										type.value));
								filterGroup.add("BusinessProcessOnly",
									Terrasoft.createColumnFilterWithParameter(
										Terrasoft.ComparisonType.EQUAL,
										"BusinessProcessOnly",
										0));
								return filterGroup;
							}
						]
					}
				},
				/**
				 * Activity owner role.
				 */
				"OwnerRole": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					dependencies: [
						{
							columns: ["OwnerRole"],
							methodName: "onOwnerRoleChange"
						}
					]
				},
				/**
				 * Activity owner.
				 */
				"Owner": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						filter: function() {
							const roleId = this.getLookupValue("OwnerRole");
							return this._getIsUseProcessPerformerAssignment()
								? BaseFiltersGenerateModule.OwnersInRoleFilter(roleId)
								: BaseFiltersGenerateModule.OwnerFilter();
						}
					}
				},
				/**
				 * View name "Schedule" section Activities.
				 */
				"SchedulerDataViewName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "SchedulerDataView"
				},
				/**
				 * Owners list.
				 */
				"Participants": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					value: null
				},
				/**
				 * Date and time start activity with offset.
				 */
				"OffsetStartDate": {
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					dependencies: [
						{
							columns: ["OffsetStartDate"],
							methodName: "onStartDateOffsetChanged"
						}
					]
				},
				/**
				 * Date and time activity completion with offset.
				 */
				"OffsetDueDate": {
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					dependencies: [
						{
							columns: ["OffsetDueDate"],
							methodName: "onDueDateOffsetChanged"
						}
					]
				},
				/**
				 * Time zone.
				 */
				"TimeZone": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					dependencies: [
						{
							columns: ["TimeZone"],
							methodName: "onTimezoneChanged"
						}
					],
					lookupListConfig: {
						columns: ["Code"]
					}
				},
				/**
				 * Container of time zone visible state.
				 */
				"TimezoneContainerVisible": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				/**
				 * Mask for custom result container visible state.
				 */
				"CustomResultMaskVisible": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				}
			},
			details: /**SCHEMA_DETAILS*/{
				Files: {
					schemaName: "FileDetailV2",
					entitySchemaName: "ActivityFile",
					filter: {
						masterColumn: "Id",
						detailColumn: "Activity"
					}
				},
				ActivityParticipant: {
					schemaName: "ActivityParticipantDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Activity"
					}
				},
				EntityConnections: {
					schemaName: "EntityConnectionsDetailV2",
					entitySchemaName: "EntityConnection",
					filter: {
						masterColumn: "Id",
						detailColumn: "SysModuleEntity"
					}
				},
				EmailDetailV2: {
					schemaName: "EmailDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "ActivityConnection"
					},
					filterMethod: "emailDetailFilter"
				}
			}/**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onGetPageTips
				 * @overridden
				 */
				onGetPageTips: function() {
					return {
						"Contact": this.get("Resources.Strings.ContactTip"),
						"Opportunity": this.get("Resources.Strings.OpportunityTip"),
						"Order": this.get("Resources.Strings.OrderTip"),
						"Invoice": this.get("Resources.Strings.InvoiceTip"),
						"Document": this.get("Resources.Strings.DocumentTip")
					};
				},

				/**
				 * @protected
				 * @inheritdoc BaseSchemaViewModel#setValidationConfig
				 * @overridden
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("OffsetDueDate", this.validateOffsetDueDate);

				},

				/**
				 * ######## ####### ########### #### ##########.
				 * @overridden
				 * @return {Boolean}
				 */
				getAddButtonMenuVisible: function() {
					return true;
				},

				/**
				 * ############## ########### #######.
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1010);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					if (this.isAddMode()) {
						this.setDefActivityValues();
					} else {
						this.onDueDateChanged();
					}
					this.callParent(arguments);
					const scheduleItemTitle = this.sandbox.publish("GetScheduleItemTitle");
					if (scheduleItemTitle && this.get("IsSeparateMode") && !this.get("IsProcessMode") &&
						this.get("Operation") !== Enums.CardStateV2.ADD &&
						this.get("Operation") !== Enums.CardStateV2.COPY) {
						this.set("Title", scheduleItemTitle);
					}
					this.mixins.ActivityTimezoneMixin.init.call(this);
					if (this.getIsFeatureEnabled("ShowAllContactsAsOwner")) {
						this._applyLookupListConfigToOwnerColumn();
					}
				},

				/**
				 * @private
				 */
				_getOwnerColumnFilter: function(isPerformerAssignmentEnabled) {
					const roleId = this.getLookupValue("OwnerRole");
					return isPerformerAssignmentEnabled
						? BaseFiltersGenerateModule.UsersInRoleFilter(roleId)
						: BaseFiltersGenerateModule.AllUsersFilter();
				},

				/**
				 * @private
				 */
				_applyLookupListConfigToOwnerColumn: function() {
					const ownerColumn = this.getColumnByName("Owner");
					const performerAssignmentEnabled = this._getIsUseProcessPerformerAssignment();
					ownerColumn.lookupListConfig = {
						filter: this._getOwnerColumnFilter.bind(this, performerAssignmentEnabled),
						orders: [
							{
								columnPath: "[VwSystemUsers:Contact].ConnectionType",
								direction: Terrasoft.OrderDirection.ASC
							}
						]
					};
				},

				/**
				 * ##### ## ####### #### ########### ######. ############### ## ###### ######### ######.
				 * @return {Boolean} ########## true ### ######## ########## #### ###########.
				 */
				validate: function() {
					var isValid = this.callParent(arguments);
					if (!isValid) {
						return false;
					}
					return this.validateDueDate();
				},

				/**
				 * ####### ######### ######### ##########
				 * ######### #### IsProcessMode # ############ ####.
				 * @return {{fullInvalidMessage: string, invalidMessage: string}} ########## ######### #########.
				 */
				activityResultValidator: function() {
					var invalidMessage = "";
					if (this.get("IsProcessMode") && this.Ext.isEmpty(this.get("Result"))) {
						invalidMessage = this.get("Resources.Strings.ActivityResultInProcessModeRequire");
					}
					return {
						fullInvalidMessage: invalidMessage,
						invalidMessage: invalidMessage
					};
				},

				/**
				 * ######### ######## ####### "##########".
				 * ####### ######### # ######, #### #### ##### "##########" ###### "######".
				 * @private
				 * @return {Boolean} ######### #########
				 */
				validateDueDate: function() {
					var startDate = this.get("StartDate");
					var dueDate = this.get("DueDate");
					if (this.Ext.isEmpty(startDate) || this.Ext.isEmpty(dueDate)) {
						return false;
					}
					if (startDate > dueDate && !this.get("TimezoneContainerVisible")) {
						this.showInformationDialog(this.get("Resources.Strings.StartDateGreaterDueDate"));
						return false;
					}
					return true;
				},

				/**
				 * ########## ####### ######## ## ######## ##### ######.
				 * @protected
				 * @return {boolean}
				 */
				isCall: function() {
					return this.get("Type").value === ConfigurationConstants.Activity.Type.Call;
				},

				/**
				 * ######### ######## ############## ########## ## ##.
				 * @protected
				 */
				edit: function() {
					var procElId = this.get("ProcessElementId");
					var recordId = this.get("Id");
					if (procElId && !this.Terrasoft.isEmptyGUID(procElId)) {
						this.sandbox.publish("ProcessExecDataChanged", {
							procElUId: procElId,
							recordId: recordId,
							scope: this,
							parentMethodArguments: null,
							parentMethod: function() {
								return false;
							}
						});
						return true;
					}
					return false;
				},

				/**
				 * Clear seconds from model date value.
				 * @protected
				 * @param {Object} argument Dependency attribute argument.
				 * @param {String} columnName Model column name.
				 * @param {Boolean} [silent] Is silent set column value tag.
				 */
				clearSeconds: function(argument, columnName, silent) {
					var date = this.get(columnName);
					if (!this.Ext.isDate(date)) {
						return;
					}
					date = this.Terrasoft.clearSeconds(date);
					this.set(columnName, date, {
						silent: Ext.isBoolean(silent) ? silent : true
					});
				},

				/**
				 * Sets remind dates after change activity start date.
				 * @private
				 */
				setRemindDates: function() {
					var previousStartDate = this.getPrevious("StartDate");
					var startDate = this.get("StartDate");
					var remindToOwner = this.get("RemindToOwner");
					var remindToAuthor = this.get("RemindToAuthor");
					if (this.Ext.isEmpty(previousStartDate) || this.Ext.isEmpty(startDate)) {
						if (remindToOwner) {
							this.set("RemindToOwnerDate", startDate);
						}
						if (remindToAuthor) {
							this.set("RemindToAuthorDate", startDate);
						}
						return;
					}
					var timeDiff = previousStartDate.getTime() - startDate.getTime();
					if (remindToOwner) {
						this.setRemindDate("RemindToOwnerDate", timeDiff);
					}
					if (remindToAuthor) {
						this.setRemindDate("RemindToAuthorDate", timeDiff);
					}
				},

				/**
				 * Sets remind date attribute value.
				 * @private
				 * @param {String} remindDateAttribute Remind date attribute.
				 * @param {Number} timeDiff Time difference.
				 */
				setRemindDate: function(remindDateAttribute, timeDiff) {
					var remindDate = this.get(remindDateAttribute);
					if (remindDate) {
						var newRemindToOwnerDate = new Date(remindDate.getTime() - timeDiff);
						this.set(remindDateAttribute, newRemindToOwnerDate);
					} else {
						this.set(remindDateAttribute, this.get("StartDate"));
					}
				},
				/**
				 * ########## ####### ######### #### #### ######.
				 * @protected
				 */
				onStartDateChanged: function() {
					var startDate = this.Terrasoft.deepClone(this.get("StartDate"));
					if (!this.Ext.isDate(startDate)) {
						return;
					}
					var differStartDueDate = this.get("DifferStartDueDate");
					if (!differStartDueDate) {
						differStartDueDate = this.getDefaultTimeInterval();
					}
					this.set("DueDate", new Date(startDate.getTime() + differStartDueDate));
				},

				/**
				 * ########## ####### ######### #### #### ##########.
				 * @protected
				 */
				onDueDateChanged: function() {
					var startDate = this.Terrasoft.deepClone(this.get("StartDate"));
					var dueDate = this.Terrasoft.deepClone(this.get("DueDate"));
					if (!this.validateDueDate() || !this.Ext.isDate(startDate) || !this.Ext.isDate(dueDate)) {
						return;
					}
					this.setDifferStartDueDate(startDate, dueDate);
				},

				/**
				 * ############# ######## #######.
				 * @param {Date} startDate #### ######.
				 * @param {Date} dueDate #### ##########.
				 */
				setDifferStartDueDate: function(startDate, dueDate) {
					var difference = {};
					if (startDate.getTime() < dueDate.getTime()) {
						difference = dueDate.getTime() - startDate.getTime();
					} else {
						difference = this.getDefaultTimeInterval();
					}
					this.set("DifferStartDueDate", difference);
				},

				/**
				 * ########## ############ ######## ######### ####### # 180000 ##.
				 * @protected
				 */
				getDefaultTimeInterval: function() {
					return this.Terrasoft.TimeScale.THIRTY_MINUTES * this.Terrasoft.DateRate.MILLISECONDS_IN_MINUTE;
				},

				/**
				 * ########## ####### ######### #### ######### ##########
				 * @protected
				 */
				onActivityCategoryChange: function() {
					var activityCategory = this.get("ActivityCategory");
					if (activityCategory &&
						activityCategory.value === ConfigurationConstants.Activity.ActivityCategory.Meeting) {
						this.set("ShowInScheduler", true);
					}
				},

				/**
				 * Event handler for property OwnerRole change
				 * @protected
				 */
				onOwnerRoleChange: function() {
					const roleId = this.getLookupValue("OwnerRole");
					if (Terrasoft.isNotEmpty(roleId)) {
						this.set("Owner", null);
					}
				},

				/**
				 * ############# ######## ### #### ######### ##########
				 * @virtual
				 */
				setActivityCategory: function() {
					if (this.getIsFeatureEnabled("AutoSetActivityCategoryFromPage")) {
						var type = this.get("Type");
						var activity = ConfigurationConstants.Activity;
						var activityCategory = activity.ActivityCategory;
						var category = (type.value === activity.Type.Task)
							? activityCategory.DoIt
							: activityCategory.Call;
						this.loadLookupDisplayValue("ActivityCategory", category);
					}
					this.getVisibleCallDirectionByCategory();
				},

				/**
				 * Set default activity values.
				 * @protected
				 */
				setDefActivityValues: function() {
					this.setActivityCategory();
					this.clearSeconds(null, "StartDate", false);
					this.clearSeconds(null, "DueDate", false);
					var startDate = this.get("StartDate");
					var dueDate = this.get("DueDate");
					var millisecondsInMinute = this.Terrasoft.core.enums.DateRate.MILLISECONDS_IN_MINUTE;
					var defaultTimeInterval = this.getDefaultTimeInterval();
					if (!dueDate || this.Ext.Date.getElapsed(startDate, dueDate) < 4 * millisecondsInMinute) {
						var defaultDueDate = this.Ext.Date.add(startDate, this.Ext.Date.MILLI, defaultTimeInterval);
						this.set("DueDate", defaultDueDate);
					} else {
						this.setDifferStartDueDate(startDate, dueDate);
					}
					var currentViewName = this.sandbox.publish("GetActiveViewName");
					this.set("ShowInScheduler", (currentViewName === "SchedulerDataView"));
				},

				/**
				 * ########## ####### ######### #### ######.
				 * @protected
				 */
				onStatusChanged: function() {
					var status = this.get("Status");
					if (status && status.Finish === false) {
						this.set("Result", null);
						this.set("DetailedResult", null);
					}
				},

				/**
				 * Result button click handler.
				 * @param {Object} event DOM event.
				 * @param {Object} dom Button DOM element.
				 * @param {Object} options DOM event options..
				 * @param {Object} tag Button tag value.
				 */
				resultButtonClick: function(event, dom, options, tag) {
					var columnsConfig = {
						"Status": tag.status.value,
						"Result": tag.result.value
					};
					this.$CustomResultMaskVisible = true;
					this.loadLookupColumnValues(columnsConfig, function(columnValues) {
						this.$CustomResultMaskVisible = false;
						this.set("Status", columnValues.Status || tag.status);
						this.set("Result", columnValues.Result || tag.result);
						this.set("ResultSelected", true);
					}, this);
				},

				/**
				 * ########## ####### ####### ## ###### ###### ## ###### #########.
				 */
				resultCancelButtonClick: function() {
					this.set("Status", null);
					this.set("Result", null);
					this.set("DetailedResult", null);
					this.set("ResultSelected", false);
				},

				/**
				 * ########## ######## ######## "#########" ### ############ ##### ##### "#########".
				 * @param {Boolean} allowedResult ###### ######### ########### ### ######.
				 * @return {Boolean} ######## ######## "#########" ### ############ ##### ##### "#########".
				 */
				getIsCustomResultVisible: function(allowedResult) {
					return this.get("IsProcessMode") && !this.Ext.isEmpty(allowedResult);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#sendSaveCardModuleResponse
				 * @overridden
				 */
				sendSaveCardModuleResponse: function(args) {
					if (!this.callParent([args.success || args])) {
						var config = {
							entitySchemaName: this.entitySchemaName,
							primaryColumnValue: this.get(this.primaryColumnName),
							isInChain: args.isInChain || true
						};
						this.sandbox.publish("ReloadGridAfterAdd", config);
					}
				},

				/**
				 * ####### ############ ##### onSave.
				 * @private
				 */
				callParentOnSave: function() {
					this.set("callParentOnSave", true);
					this.save(this.get("ParentOnSaveArguments"));
				},

				/**
				 * ########## ## ############# ##########
				 * ######### ############# # #########.
				 * @private
				 */
				askAddedParticipants: function() {
					this.showConfirmationDialog(this.get("Resources.Strings.InsertParticipantsMessage"),
						function(returnCode) {
							if (returnCode === this.Terrasoft.MessageBoxButtons.NO.returnCode) {
								this.set("Participants", null);
							}
							this.callParentOnSave();
						},
						[this.Terrasoft.MessageBoxButtons.YES.returnCode,
							this.Terrasoft.MessageBoxButtons.NO.returnCode],
						null);
				},

				/**
				 * ######### ######.
				 * @overridden
				 */
				save: function() {
					if (this.get("callParentOnSave")) {
						this.callParent(arguments);
					} else {
						if (this.isEditMode() || Ext.isEmpty(this.get("Participants"))) {
							this.callParent(arguments);
						} else {
							this.set("ParentOnSaveArguments", arguments);
							this.askAddedParticipants();
						}
					}
				},

				/**
				 * ########## ###### ## ########## ######## ##########.
				 * @param {Object} args ############# ########## # ######### # ########### ####### {ActivityId, value}
				 * @private
				 */
				getParticipantInsertQuery: function(item) {
					var roleId = ConfigurationConstants.Activity.ParticipantRole.Participant;
					var activityId = this.get("Id");
					var insert = Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: "ActivityParticipant"
					});
					insert.setParameterValue("Activity", activityId, this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Participant", item, this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Role", roleId, this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/*
				 * Execute queries to add activity participants.
				 * @private
				 */
				insertParticipants: function() {
					var participants = this.get("Participants");
					if (participants) {
						var bq = Ext.create("Terrasoft.BatchQuery");
						participants.forEach(function(item) {
							bq.add(this.getParticipantInsertQuery(item.value));
						}, this);
						if (bq.queries.length) {
							bq.execute();
						}
					}
				},

				/*
				 * # ###### ####### Participants ######### ########## ##########,
				 * ######## ############ ##### onSaved # ######### ###### ########## ##########.
				 * @private
				 */
				onSavedActivity: function(response, config) {
					config = (config && config.length === 1) ? config[0] : (config || {});
					config.callParent = true;
					this.insertParticipants();
					this.onSaved(response, config);
					this.updateDetail({detail: "ActivityParticipant"});
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function(response, config) {
					if (config && config.callParent === true) {
						this.callParent(arguments);
					} else if (this.isCopyMode()) {
						var requestConfig = {
							serviceName: "EntityUtilsService",
							methodName: "CopyEntities",
							data: {
								sourceEntityId: this.get("SourceEntityPrimaryColumnValue"),
								recipientEntityId: this.get("Id"),
								columnName: "Activity",
								entitySchemaName: "Activity",
								sourceEntitySchemaNames: ["ActivityParticipant"]
							}
						};
						this.callService(requestConfig, function() {
							this.onSavedActivity(response, config);
						}, this);
					} else {
						this.onSavedActivity(response, config);
					}
				},

				/**
				 * ########## ####### ######### #### ######### # ########### ## #### ##########.
				 * @param {Object} value ### ##########.
				 * @return {boolean} ####### ######### #### ######### # ########### ## #### ##########.
				 */
				getVisibleCategoryByType: function(value) {
					return (value && (value.value === ConfigurationConstants.Activity.Type.Task));
				},

				/**
				 * Gets visibility attribute for field CallDirection depends on activity category.
				 * @param {Object} value Activity type.
				 * @return {boolean} visibility attribute for field CallDirection depends on activity category.
				 */
				getVisibleCallDirectionByCategory: function(value) {
					return (value &&
						((value.value === ConfigurationConstants.Activity.ActivityCategory.CallAsTask) ||
						(value.value === ConfigurationConstants.Activity.ActivityCategory.Call)));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#addChangeDataViewOptions
				 * @overridden
				 */
				addChangeDataViewOptions: function(viewOptions) {
					this.addSchedulerDataViewOption(viewOptions);
					this.addGridDataViewOption(viewOptions);
					this.callParent(arguments);
				},

				/**
				 * ######### ##### "####### # ##########" # ######### #### ###### "###".
				 * @protected
				 * @param {Object} viewOptions ######### ####### ####.
				 */
				addSchedulerDataViewOption: function(viewOptions) {
					viewOptions.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.SchedulerDataViewCaption"},
						"Click": {"bindTo": "changeDataView"},
						"Visible": {"bindTo": "getSchedulerDataViewOptionVisible"},
						"Tag": this.get("SchedulerDataViewName")
					}));
				},

				/**
				 * ######### ##### "####### # ###### #######" # ######### #### ###### "###".
				 * @protected
				 * @param {Object} viewOptions ######### ####### ####.
				 */
				addGridDataViewOption: function(viewOptions) {
					viewOptions.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.GridDataViewCaption"},
						"Click": {"bindTo": "changeDataView"},
						"Visible": {"bindTo": "getGridDataViewOptionVisible"},
						"Tag": this.get("GridDataViewName")
					}));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#addListSettingsOption
				 * @overridden
				 */
				addListSettingsOption: function(viewOptions) {
					viewOptions.addItem(this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.OpenListSettingsCaption"},
						"Click": {"bindTo": "openGridSettings"},
						"Visible": {"bindTo": "getListSettingsOptionVisible"}
					}));
				},

				/**
				 * Create filters function for email detail.
				 * @protected
				 * @return {createFilterGroup}
				 */
				emailDetailFilter: function() {
					var recordId = this.get("Id");
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("ActivityConnectionNotNull", this.Terrasoft.createColumnIsNotNullFilter("ActivityConnection"));
					filterGroup.add("ActivityConnection", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ActivityConnection", recordId));
					filterGroup.add("ActivityType", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Type", ConfigurationConstants.Activity.Type.Email));
					return filterGroup;
				},

				/**
				 * ########## ######## ## #########, ############ # ##### ###### ########## #######.
				 * @param {string} columnName ### #######.
				 * @overridden
				 * @return {Array} ###### ######## ## #########.
				 */
				getLookupValuePairs: function(columnName) {
					var valuePairs = [];
					var column = this.getColumnByName(columnName);
					if (!this.Ext.isEmpty(column) && !this.Ext.isEmpty(column.referenceSchemaName) &&
						column.referenceSchemaName === "Contact") {
						var account = this.get("Account");
						if (!this.Ext.isEmpty(account)) {
							valuePairs.push({
								name: "Account",
								value: account.value
							});
						}
					}
					return valuePairs;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeDetailEvents
				 */
				subscribeDetailEvents: function(detailConfig, detailName) {
					this.callParent(arguments);
					var detailId = this.getDetailId(detailName);
					this.sandbox.subscribe("GetLookupValuePairs", this.getLookupValuePairs, this, [detailId]);
				},

				/**
				 * @private
				 */
				_getIsUseProcessPerformerAssignment: function() {
					return this.getIsFeatureEnabled("UseProcessPerformerAssignment");
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"name": "GeneralInfoTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.GeneralInfoTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"name": "ActivityParticipantTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ActivityParticipantTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ActivityParticipantTab",
					"propertyName": "items",
					"name": "ActivityParticipant",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"name": "ActivityFileNotesTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.ActivityFileNotesTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"name": "EmailTab",
					"values": {
						"caption": {"bindTo": "Resources.Strings.EmailTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "EmailTab",
					"propertyName": "items",
					"name": "EmailDetailV2",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"name": "TitleInformationContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"layout": {"column": 0, "row": 0, "colSpan": 23, "rowSpan": 1},
						"id": "TitleInformationContainer",
						"selectors": {"wrapEl": "#TitleInformationContainer"}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"name": "InformationOnStepButtonContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"layout": {"column": 23, "row": 0, "colSpan": 1, "rowSpan": 1},
						"id": "InformationOnStepButtonContainer",
						"selectors": {"wrapEl": "#InformationOnStepButtonContainer"}
					}
				},
				{
					"operation": "insert",
					"parentName": "TitleInformationContainer",
					"propertyName": "items",
					"name": "Title",
					"values": {
						"bindTo": "Title",
						"contentType": Terrasoft.ContentType.LONG_TEXT
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "StartDate",
					"values": {
						"bindTo": "StartDate",
						"name": "StartDate",
						"generator": "TimezoneGenerator.generateTimezoneButton",
						"layout": {"column": 0, "row": 1, "colSpan": 12}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "DueDate",
					"values": {
						"bindTo": "DueDate",
						"layout": {"column": 0, "row": 2, "colSpan": 12},
						"controlConfig": {
							"timeEdit": {
								"controlConfig": {
									"prepareList": {
										"bindTo": "loadDueDateList"
									}
								}
							}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "OwnerRole",
					"values": {
						"bindTo": "OwnerRole",
						"layout": {"column": 12, "row": 1, "colSpan": 12},
						"visible": {
							"bindTo": "_getIsUseProcessPerformerAssignment"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Owner",
					"values": {
						"bindTo": "Owner",
						"layout": {"column": 12, "row": 2, "colSpan": 12},
						"tip": {
							"content": {"bindTo": "Resources.Strings.OwnerTip"}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Status",
					"values": {
						"bindTo": "Status",
						"layout": {"column": 0, "row": 3, "colSpan": 12},
						"contentType": Terrasoft.ContentType.ENUM

					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Author",
					"values": {
						"bindTo": "Author",
						"layout": {"column": 12, "row": 3, "colSpan": 12},
						"enabled": false
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"name": "ResultControlGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {"bindTo": "Resources.Strings.ResultControlGroupCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlGroup",
					"propertyName": "items",
					"name": "CustomResultControlBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": [],
						"visible": {
							"bindTo": "AllowedResult",
							"bindConfig": {
								"converter": "getIsCustomResultVisible"
							}
						},
						"maskVisible": {
							"bindTo": "CustomResultMaskVisible"
						},
						"controlConfig": { "classes": ["custom-activity-result"] }
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlGroup",
					"propertyName": "items",
					"name": "CustomSelectedResultControlBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"visible": {
							"bindTo": "ResultSelected"
						},
						"controlConfig": {
							"collapseEmptyRow": true
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlGroup",
					"propertyName": "items",
					"name": "CustomActionSelectedResultControlBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"visible": {
							"bindTo": "ResultSelected"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlGroup",
					"propertyName": "items",
					"name": "ResultControlBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"controlConfig": {
							"collapseEmptyRow": true
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "EntityConnections",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "ActivityCategory",
					"values": {
						"bindTo": "ActivityCategory",
						"layout": {"column": 12, "row": 5, "colSpan": 12},
						"visible": {
							"bindTo": "Type",
							"bindConfig": {
								"converter": "getVisibleCategoryByType"
							}
						},
						"contentType": Terrasoft.ContentType.ENUM

					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "CallDirection",
					"values": {
						"bindTo": "CallDirection",
						"layout": {"column": 12, "row": 6, "colSpan": 12},
						"visible": {
							"bindTo": "ActivityCategory",
							"bindConfig": {
								"converter": "getVisibleCallDirectionByCategory"
							}
						},
						"contentType": Terrasoft.ContentType.ENUM

					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Priority",
					"values": {
						"bindTo": "Priority",
						"layout": {"column": 12, "row": 4, "colSpan": 12},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "ShowInScheduler",
					"values": {
						"bindTo": "ShowInScheduler",
						"layout": {"column": 0, "row": 4, "colSpan": 12}
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlBlock",
					"propertyName": "items",
					"name": "Result",
					"values": {
						"bindTo": "Result",
						"layout": {"column": 0, "row": 0, "colSpan": 24},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultControlBlock",
					"propertyName": "items",
					"name": "DetailedResult",
					"values": {
						"bindTo": "DetailedResult",
						"layout": {"column": 0, "row": 1, "colSpan": 24, "rowSpan": 3},
						"contentType": Terrasoft.ContentType.LONG_TEXT
					}
				},
				{
					"operation": "insert",
					"parentName": "CustomSelectedResultControlBlock",
					"propertyName": "items",
					"name": "CustomDetailedResult",
					"values": {
						"bindTo": "DetailedResult",
						"layout": {"column": 0, "row": 0, "colSpan": 12, "rowSpan": 3},
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"labelWrapConfig": {
							"classes": {
								"wrapClassName": "justify-top"
							}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "CustomActionSelectedResultControlBlock",
					"propertyName": "items",
					"name": "CustomActionSelectedResultControlGroup",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"layout": {"column": 0, "row": 0, "colSpan": 24},
						"items": [],
						"visible": {
							"bindTo": "ResultSelected"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "CustomActionSelectedResultControlGroup",
					"propertyName": "items",
					"name": "ResultSaveButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"click": {"bindTo": "save"},
						"caption": {"bindTo": "Resources.Strings.SaveButtonCaption"},
						"style": Terrasoft.controls.ButtonEnums.style.BLUE
					}
				},
				{
					"operation": "insert",
					"parentName": "CustomActionSelectedResultControlGroup",
					"propertyName": "items",
					"name": "ResultCancelButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"click": {"bindTo": "resultCancelButtonClick"},
						"caption": {"bindTo": "Resources.Strings.CancelButtonCaption"}
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"name": "RemindControlGroup",
					"propertyName": "items",

					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {"bindTo": "Resources.Strings.RemindControlGroupCaption"},
						"controlConfig": {},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "RemindControlGroup",
					"propertyName": "items",
					"name": "RemindControlBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "RemindControlBlock",
					"propertyName": "items",
					"name": "RemindToOwner",
					"values": {
						"bindTo": "RemindToOwner",
						"layout": {"column": 0, "row": 0, "colSpan": 12},
						"labelConfig": {
							"caption": {"bindTo": "Resources.Strings.RemindToOwnerCaption"}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RemindControlBlock",
					"propertyName": "items",
					"name": "RemindToOwnerDate",
					"values": {
						"bindTo": "RemindToOwnerDate",
						"layout": {"column": 12, "row": 0, "colSpan": 12},
						"enabled": {"bindTo": "RemindToOwnerDateEnabled"},
						"labelConfig": {
							"caption": {"bindTo": "Resources.Strings.RemindDateCaption"}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RemindControlBlock",
					"propertyName": "items",
					"name": "RemindToAuthor",
					"values": {
						"bindTo": "RemindToAuthor",
						"layout": {"column": 0, "row": 1, "colSpan": 12},
						"labelConfig": {
							"caption": {"bindTo": "Resources.Strings.RemindToAuthorCaption"}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RemindControlBlock",
					"propertyName": "items",
					"name": "RemindToAuthorDate",
					"values": {
						"bindTo": "RemindToAuthorDate",
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12
						},
						"enabled": {"bindTo": "RemindToAuthorDateEnabled"},
						"labelConfig": {
							"caption": {"bindTo": "Resources.Strings.RemindDateCaption"}
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ActivityFileNotesTab",
					"propertyName": "items",
					"name": "Files",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "ActivityNotesControlGroup",
					"parentName": "ActivityFileNotesTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {"bindTo": "Resources.Strings.NotesGroupCaption"}
					}
				},
				{
					"operation": "insert",
					"parentName": "ActivityNotesControlGroup",
					"propertyName": "items",
					"name": "Notes",
					"values": {
						"contentType": Terrasoft.ContentType.RICH_TEXT,
						"layout": {"column": 0, "row": 0, "colSpan": 24},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"ActivityCategory": {
					"BindParameterVisibleActivityCategoryToType": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Type"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": "fbe0acdc-cfc0-df11-b00f-001d60e938c6"
								}
							}
						]
					},
					"FiltrationActivityCategoryByActivityType": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "ActivityType",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Type"
					}
				},
				"Result": {
					"BindParameterEnabledResultToStatus": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Status",
									"attributePath": "Finish"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								}
							}
						]
					},
					"BindParameterRequiredResultToStatus": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"logical": Terrasoft.LogicalOperatorType.AND,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Status",
									"attributePath": "Finish"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								}
							},
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "IsProcessMode"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								}
							}
						]
					}
				},
				"DetailedResult": {
					"BindParameterEnabledDetailedResultToStatus": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Status",
									"attributePath": "Finish"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								}
							}
						]
					}
				},
				"Contact": {
					"FiltrationContactByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "Account",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Account"
					}
				}
			}
		};
	});
