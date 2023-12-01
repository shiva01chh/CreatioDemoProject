﻿Terrasoft.configuration.Structures["ActivityParticipantDetailV2"] = {innerHierarchyStack: ["ActivityParticipantDetailV2CrtUIv2", "ActivityParticipantDetailV2"], structureParent: "BaseGridDetailV2"};
define('ActivityParticipantDetailV2CrtUIv2Structure', ['ActivityParticipantDetailV2CrtUIv2Resources'], function(resources) {return {schemaUId:'3f36b33f-a6aa-47fc-b145-2743cdbcca76',schemaCaption: "ActivityParticipantDetailV2", parentSchemaName: "BaseGridDetailV2", packageName: "IntegrationV2", schemaName:'ActivityParticipantDetailV2CrtUIv2',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ActivityParticipantDetailV2Structure', ['ActivityParticipantDetailV2Resources'], function(resources) {return {schemaUId:'75c6e187-8f13-4bb8-99e9-a398a251b756',schemaCaption: "ActivityParticipantDetailV2", parentSchemaName: "ActivityParticipantDetailV2CrtUIv2", packageName: "IntegrationV2", schemaName:'ActivityParticipantDetailV2',parentSchemaUId:'3f36b33f-a6aa-47fc-b145-2743cdbcca76',extendParent:true,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ActivityParticipantDetailV2CrtUIv2",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ActivityParticipantDetailV2CrtUIv2Resources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ActivityParticipantDetailV2CrtUIv2", ["ConfigurationConstants", "ConfigurationEnums", "EntityResponseValidationMixin"],
	function(ConfigurationConstants, configurationEnums) {
		return {
			entitySchemaName: "ActivityParticipant",

			attributes: {
				/**
				 * Has current user exchange appointment integration.
				 */
				"HasExchangeAppointmentIntegration": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN
				},

				/**
				 * Is current user owner or organizer of master activity.
				 */
				"IsOwnerOrOrganizer": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN
				},

				/**
				 * Master activity owner.
				 */
				"Owner": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP
				},

				/**
				 * Master activity organizer.
				 */
				"Organizer": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP
				}
			},

			messages: {
				/**
				 * @message GetColumnsValues
				 * Master record columns values request message.
				 */
				"GetColumnsValues": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},

			mixins: {
				/**
				 * @class EntityResponseValidationMixin Validates server response. Returns true or false depending on
				 * the server response, generates error message and fires dialog in case of an error.
				 */
				EntityResponseValidationMixin: "Terrasoft.EntityResponseValidationMixin"
			},

			methods: {
				/**
				 * @inheritdoc Terrasoft.configuration.mixins.GridUtilities#deselectRows
				 * @overridden
				 */
				deselectRows: function() {
					this.set("SelectedRows", []);
					this.set("ActiveRow", "");
				},

				/**
				 * @inheritdoc Terrasoft.configuration.mixins.GridUtilities#getGridDataColumns
				 * @overridden
				 */
				getGridDataColumns: function() {
					return {
						"Id": {path: "Id"},
						"Participant": {path: "Participant"},
						"Participant.Name": {path: "Participant.Name"},
						"Participant.JobTitle": {path: "Participant.JobTitle"},
						"Participant.Phone": {path: "Participant.Phone"},
						"Participant.MobilePhone": {path: "Participant.MobilePhone"},
						"Participant.Email": {path: "Participant.Email"},
						"Role": {path: "Role"},
						"InviteParticipant": {path: "InviteParticipant"},
						"InviteResponse": {path: "InviteResponse"}
					};
				},

				/**
				 * Opens contacts lookup window.
				 * @private
				 */
				openContactLookup: function() {
					var Terrasoft = this.Terrasoft;
					var activityId = this.get("MasterRecordId");
					var roleId = ConfigurationConstants.Activity.ParticipantRole.Participant;
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					esq.addColumn("Id");
					esq.addColumn("Participant.Id", "ContactId");
					esq.filters.add("filterActivity", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Activity", activityId));
					esq.filters.add("filterRole", this.Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Role", roleId));
					esq.getEntityCollection(function(result) {
						var existsContactsCollection = [];
						if (result.success) {
							result.collection.each(function(item) {
								existsContactsCollection.push(item.get("ContactId"));
							});
						}
						var config = {
							entitySchemaName: "Contact",
							multiSelect: true,
							columns: ["JobTitle", "MobilePhone", "Email", "[SysAdminUnit:Contact].Id"]
						};
						if (existsContactsCollection.length > 0) {
							var existsFilter = Terrasoft.createColumnInFilterWithParameters("Id",
								existsContactsCollection);
							existsFilter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
							existsFilter.Name = "existsFilter";
							config.filters = existsFilter;
						}
						this.openLookup(config, this.addCallBack, this);
					}, this);
				},

				/**
				 * @overridden
				 */
				onCardSaved: function() {
					this.openContactLookup();
				},

				/**
				* Opens contact lookup window if activity page saved, calls activity page save otherwise.
				* @overridden
				**/
				addRecord: function() {
					var masterCardState = this.sandbox.publish("GetCardState", null, [this.sandbox.id]);
					var isNewRecord = (masterCardState.state === configurationEnums.CardStateV2.ADD ||
						masterCardState.state === configurationEnums.CardStateV2.COPY);
					if (isNewRecord === true) {
						var args = {
							isSilent: true,
							messageTags: [this.sandbox.id]
						};
						this.sandbox.publish("SaveRecord", args, [this.sandbox.id]);
						return;
					}
					this.openContactLookup();
				},

				/**
				* Creates activity participants from selected values.
				* @protected
				**/
				addCallBack: function(args) {
					var bq = this.Ext.create("Terrasoft.BatchQuery");
					var activityId = this.get("MasterRecordId");
					this.selectedRows = args.selectedRows.getItems();
					this.selectedItems = [];
					this.selectedRows.forEach(function(item) {
						item.ActivityId = activityId;
						bq.add(this.getContactInsertQuery(item));
						this.selectedItems.push(item.value);
					}, this);
					if (bq.queries.length) {
						this.showBodyMask.call(this);
						bq.execute(this.onContactInsert, this);
					}
				},

				/**
				* Creates activity participant insert query.
				* @param {Object} item Actitity and contact unique id {ActivityId, value}
				* @private
				**/
				getContactInsertQuery: function(item) {
					var roleId = ConfigurationConstants.Activity.ParticipantRole.Participant;
					var insert = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: this.entitySchemaName
					});
					insert.setParameterValue("Activity", item.ActivityId, this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Participant", item.value, this.Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Role", roleId, this.Terrasoft.DataValueType.GUID);
					return insert;
				},

				/**
				* Add created participants into grid.
				* @protected
				**/
				onContactInsert: function(response) {
					this.hideBodyMask.call(this);
					var isSuccess = this.mixins.EntityResponseValidationMixin.validateResponse.apply(this, arguments);
 					if (!isSuccess || this.get("IsGridLoading")) {
						return;
					}
					this.beforeLoadGridData();
					var filterCollection = [];
					response.queryResults.forEach(function(item) {
						filterCollection.push(item.id);
					});
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: this.entitySchemaName
					});
					this.initQueryColumns(esq);
					esq.filters.add("recordId", Terrasoft.createColumnInFilterWithParameters("Id", filterCollection));
					esq.getEntityCollection(function(response) {
						this.afterLoadGridData();
						if (response.success) {
							var responseCollection = response.collection;
							this.prepareResponseCollection(responseCollection);
							this.getGridData().loadAll(responseCollection);
						}
					}, this);
				},

				/**
				 * Checks can delete participant.
				 * @param {Object} owner Activity owner.
				 * @param {Object} participant Activity participant.
				 * @returns {boolean}
				 */
				canDeleteParticipant: function(owner, participant) {
					return (this.Ext.isEmpty(owner) || participant.value !== owner);
				},

				/**
				 * Deletes selected records, except Owner and Organizer.
				 * @overridden
				 **/
				deleteRecords: function() {
					var selectedRows = this.getSelectedItems();
					var deleteRows = [];
					var gridData = this.getGridData();
					var owner = this.get("Owner");
					owner = owner && owner.value;
					var isResponsibleExists = false;
					selectedRows.forEach(function(rowId) {
						var row = gridData.get(rowId);
						var participant = row.get("Participant");
						if (this.canDeleteParticipant(owner, participant)) {
							deleteRows.push(rowId);
						} else {
							isResponsibleExists = true;
						}
					}, this);
					if (isResponsibleExists) {
						this.showInformationDialog(this.get("Resources.Strings.WarningResponsibleDelete"));
					}
					if (deleteRows.length > 0) {
						this.set("SelectedRows", deleteRows);
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * Returns filtration column name.
				 * @overridden
				 * @return {String} Column name.
				 */
				getFilterDefaultColumnName: function() {
					return "Participant";
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.initOwnerAndOrganizerProperties();
					this.callParent([function() {
						this.initHasExchangeIntegrationProperty(callback, scope);
					}, this]);
				},

				/**
				 * Initializes HasExchangeAppointmentIntegration attribute.
				 * @param {Function} callback Callback function
				 * @param {Object} scope Callback function scope.
				 */
				initHasExchangeIntegrationProperty: function(callback, scope) {
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ActivitySyncSettings"
					});
					select.filters.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"MailboxSyncSettings.SysAdminUnit", this.Terrasoft.SysValue.CURRENT_USER.value));
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"ImportAppointments", true));
					filterGroup.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"ExportActivities", true));
					select.filters.addItem(filterGroup);
					select.getEntityCollection(function(response) {
						var result = response.success ? !response.collection.isEmpty() : false;
						this.set("HasExchangeAppointmentIntegration", result);
						callback.call(scope);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#initToolsButtonMenu
				 * @overridden
				 */
				initToolsButtonMenu: function() {
					this.callParent(arguments);
					var toolsButtonMenu = this.get("ToolsButtonMenu");
					var inviteParticipant = this.getInviteParticipantMenuItem();
					toolsButtonMenu.addItem(inviteParticipant);
					var notInviteParticipant = this.getNotInviteParticipantMenuItem();
					toolsButtonMenu.addItem(notInviteParticipant);
					var inviteSelectedParticipants = this.getInviteSelectedParticipantsMenuItem();
					toolsButtonMenu.addItem(inviteSelectedParticipants);
					var dontInviteSelectedParticipants = this.getDontInviteSelectedParticipantsMenuItem();
					toolsButtonMenu.addItem(dontInviteSelectedParticipants);
				},

				/**
				 * Generates "Invite participant" menu item.
				 * @return {Terrasoft.BaseViewModel}
				 */
				getInviteParticipantMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.InviteParticipant"},
						Click: {"bindTo": "setInviteSelectedParticipants"},
						Tag: true,
						Visible: {bindTo: "isInviteParticipantActionVisible"},
						Enabled: {bindTo: "isInviteParticipantEnabled"}
					});
				},

				/**
				 * Generates "Don't invite participant" menu item.
				 * @return {Terrasoft.BaseViewModel}
				 */
				getNotInviteParticipantMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.DontInviteParticipant"},
						Click: {"bindTo": "setInviteSelectedParticipants"},
						Visible: {bindTo: "isDontInviteParticipantActionVisible"},
						Enabled: {bindTo: "isInviteParticipantEnabled"}
					});
				},

				/**
				 * Generates "Invite selected participants" menu item.
				 * @return {Terrasoft.BaseViewModel}
				 */
				getInviteSelectedParticipantsMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.InviteSelectedParticipants"},
						Click: {"bindTo": "setInviteSelectedParticipants"},
						Tag: true,
						Visible: {bindTo: "isInviteParticipantsActionVisible"},
						Enabled: {bindTo: "isInviteParticipantEnabled"}
					});
				},

				/**
				 * Generates "Don't invite selected participants" menu item.
				 * @return {Terrasoft.BaseViewModel}
				 */
				getDontInviteSelectedParticipantsMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.DontInviteSelectedParticipants"},
						Click: {"bindTo": "setInviteSelectedParticipants"},
						Visible: {bindTo: "isInviteParticipantsActionVisible"},
						Enabled: {bindTo: "isInviteParticipantEnabled"}
					});
				},

				/**
				 * Checks, if invite participant menu items enabled.
				 * @return {Boolean} Menu item enabled.
				 */
				isInviteParticipantEnabled: function() {
					var selectedRows = this.getSelectedRowsWithoutOwnerAndOrganizer();
					return !this.Ext.isEmpty(selectedRows);
				},

				/**
				 * Returns "Invite participant" tools button menu item visibility.
				 * @return {Boolean} "Invite participant" tools button menu item visibility.
				 */
				isInviteParticipantActionVisible: function() {
					var multiSelect = this.get("MultiSelect");
					var hasIntegration = this.get("HasExchangeAppointmentIntegration");
					var isOwnerOrOrganizer = this.get("IsOwnerOrOrganizer");
					var isVisible = hasIntegration && isOwnerOrOrganizer && !multiSelect;
					if (!isVisible) {
						return false;
					}
					var primaryColumnValue = this.get("ActiveRow");
					if (!primaryColumnValue) {
						return isVisible;
					}
					var gridData = this.getGridData();
					var selectedRow = gridData.get(primaryColumnValue);
					var inviteSelected = selectedRow.get("InviteParticipant");
					return isVisible && !inviteSelected;
				},

				/**
				 * Returns "Don't invite participant" tools button menu item visibility.
				 * @return {Boolean} "Don't invite participant" tools button menu item visibility.
				 */
				isDontInviteParticipantActionVisible: function() {
					var multiSelect = this.get("MultiSelect");
					var hasIntegration = this.get("HasExchangeAppointmentIntegration");
					var primaryColumnValue = this.get("ActiveRow");
					var isOwnerOrOrganizer = this.get("IsOwnerOrOrganizer");
					var isVisible = hasIntegration && isOwnerOrOrganizer && !multiSelect;
					if (!isVisible || !primaryColumnValue) {
						return false;
					}
					var gridData = this.getGridData();
					var selectedRow = gridData.get(primaryColumnValue);
					var inviteSelected = selectedRow.get("InviteParticipant");
					return isVisible && inviteSelected;
				},

				/**
				 * Returns "Invite participants", "Don't invite participants" tools button menu item visibility.
				 * @return {Boolean} "Invite participants", "Don't invite participants" tools button menu item
				 * visibility.
				 */
				isInviteParticipantsActionVisible: function() {
					var multiSelect = this.get("MultiSelect");
					var hasIntegration = this.get("HasExchangeAppointmentIntegration");
					var isOwnerOrOrganizer = this.get("IsOwnerOrOrganizer");
					var isVisible = hasIntegration && isOwnerOrOrganizer && multiSelect;
					return isVisible;
				},

				/**
				 * Set "InviteParticipant" column value for selected participants.
				 * @param {Boolean|*} tag Value to set.
				 */
				setInviteSelectedParticipants: function(tag) {
					if (!this.isAnySelected()) {
						return;
					}
					var setValue = tag || false;
					var selectedRows = this.getSelectedRowsWithoutOwnerAndOrganizer();
					if (this.Ext.isEmpty(selectedRows)) {
						return;
					}
					var update = this.Ext.create("Terrasoft.UpdateQuery", {rootSchemaName: this.entitySchemaName});
					update.filters.add("SelectedParticipantsFilter",
						this.Terrasoft.createColumnInFilterWithParameters("Id", selectedRows));
					update.setParameterValue("InviteParticipant", setValue, this.Terrasoft.DataValueType.BOOLEAN);
					this.showBodyMask();
					update.execute(this.onInviteParticipantSaved, this);
				},

				/**
				 * Checks if contact is owner or organizer of master record.
				 * @param {Guid} contactId Contact id.
				 * @return {boolean} True, if contact is owner or organizer of master record, false otherwise.
				 */
				isContactOwnerOrOrganizer: function(contactId) {
					var organizer = this.get("Organizer");
					organizer = organizer ? organizer.value : null;
					var owner = this.get("Owner");
					owner = owner ? owner.value : null;
					if ((!this.Ext.isEmpty(organizer) && organizer === contactId) ||
							(!this.Ext.isEmpty(owner) && owner === contactId)) {
						return true;
					}
					return false;
				},

				/**
				 * Handles "InviteParticipant" column update response.
				 */
				onInviteParticipantSaved: function() {
					this.hideBodyMask();
					this.updateDetail({reloadAll: true});
				},

				/**
				 * Initializes Owner, Organizer and IsOwnerOrOrganizer attributes.
				 */
				initOwnerAndOrganizerProperties: function() {
					var sandbox = this.sandbox;
					var columns = ["Owner", "Organizer"];
					var isOwnerOrOrganizer = false;
					var currentContact = this.Terrasoft.SysValue.CURRENT_USER_CONTACT;
					var values = sandbox.publish("GetColumnsValues", columns, [sandbox.id]);
					this.Terrasoft.each(columns, function(column) {
						if (values.hasOwnProperty(column) && !this.Ext.isEmpty(values[column])) {
							var columnValue = values[column];
							this.set(column, columnValue);
							if (currentContact.value === columnValue.value) {
								isOwnerOrOrganizer = true;
							}
						}
					}, this);
					this.set("IsOwnerOrOrganizer", isOwnerOrOrganizer);
				},

				/**
				 * Returns selected rows, except owner and organizer participants.
				 * @return {Array} Selected rows, except owner and organizer participants.
				 */
				getSelectedRowsWithoutOwnerAndOrganizer: function() {
					var selectedRows = this.getSelectedItems();
					if (this.Ext.isEmpty(selectedRows)) {
						return null;
					}
					var gridData = this.getGridData();
					selectedRows = selectedRows.filter(function(rowId) {
						var row = gridData.get(rowId);
						var inviteResponse = row.get("InviteResponse");
						var inviteConfirmation = ConfigurationConstants.Activity.ParticipantInviteResponse;
						var contact = row.get("Participant");
						return !Terrasoft.contains([inviteConfirmation.Confirmed, inviteConfirmation.Declined],
								inviteResponse.value) && !this.isContactOwnerOrOrganizer(contact.value);
					}, this);
					return selectedRows;
				},

				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#updateDetail
				 * @overridden
				 */
				updateDetail: function(config) {
					this.callParent(arguments);
					if (config.reloadAll) {
						this.initOwnerAndOrganizerProperties();
					}
				},

				/**
				 * @inheritDoc Terrasoft.BaseDetailV2#getToolsVisible
				 */
				getToolsVisible: function() {
					return this.callParent(arguments) && this.get("CanEditMasterRecord");
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"type": "listed",
						"primaryDisplayColumnName": "Participant.Name",
						"listedConfig": {
							"name": "DataGridListedConfig",
							"items": [
								{
									"name": "ParticipantListedGridColumn",
									"bindTo": "Participant",
									"position": {
										"column": 1,
										"colSpan": 12
									}
								},
								{
									"name": "ParticipantJobTitleListedGridColumn",
									"bindTo": "Participant.JobTitle",
									"position": {
										"column": 13,
										"colSpan": 12
									}
								},
								{
									"name": "RoleListedGridColumn",
									"bindTo": "Role",
									"position": {
										"column": 25,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantPhoneListedGridColumn",
									"bindTo": "Participant.Phone",
									"position": {
										"column": 33,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantMobilePhoneListedGridColumn",
									"bindTo": "Participant.MobilePhone",
									"position": {
										"column": 41,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantEmailListedGridColumn",
									"bindTo": "Participant.Email",
									"position": {
										"column": 49,
										"colSpan": 8
									}
								}
							]
						},
						"tiledConfig": {
							"name": "DataGridTiledConfig",
							"grid": {
								"columns": 24,
								"rows": 3
							},
							"items": [
								{
									"name": "ParticipantTiledGridColumn",
									"bindTo": "Participant",
									"position": {
										"row": 1,
										"column": 1,
										"colSpan": 12
									}
								},
								{
									"name": "ParticipantJobTitleTiledGridColumn",
									"bindTo": "Participant.JobTitle",
									"position": {
										"row": 1,
										"column": 13,
										"colSpan": 12
									}
								},
								{
									"name": "RoleTiledGridColumn",
									"bindTo": "Role",
									"position": {
										"row": 1,
										"column": 25,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantPhoneTiledGridColumn",
									"bindTo": "Participant.Phone",
									"position": {
										"row": 1,
										"column": 33,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantMobilePhoneTiledGridColumn",
									"bindTo": "Participant.MobilePhone",
									"position": {
										"row": 1,
										"column": 41,
										"colSpan": 8
									}
								},
								{
									"name": "ParticipantEmailTiledGridColumn",
									"bindTo": "Participant.Email",
									"position": {
										"row": 1,
										"column": 49,
										"colSpan": 8
									}
								}
							]
						}
					}
				},
				{
					"operation": "merge",
					"name": "AddRecordButton",
					"values": {
						"visible": {"bindTo": "getToolsVisible"}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);

define("ActivityParticipantDetailV2", ["ActivityParticipantDetailV2Resources", "ControlGridModule",
		"ActivityParticipantGridViewModel", "ActivityParticipantDetailGridGenerator", "MeetingInvitationsMixin"],
		function(resources, informationButtonResources) {
	return {
		entitySchemaName: "ActivityParticipant",
		mixins: {
			"MeetingInvitationsMixin": "Terrasoft.MeetingInvitationsMixin"
		},
		attributes: {

			/**
			 * Hint about disabled synchronization.
			 */
			"SynchronizationNotEnabledHint": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": Terrasoft.emptyString
			},

			/**
			 * Id of the article about Exchange calendars at the academy.
			 */
			 "ExchangeCalendarArticleId": {
				"dataValueType": Terrasoft.DataValueType.INTEGER,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": 1421
			},

			/**
			 * Id of the article about Google caledars at the academy.
			 */
			"GoogleCalendarArticleId": {
				"dataValueType": Terrasoft.DataValueType.INTEGER,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": 1424
			},

			/**
			 * Invitation button visibility enabled.
			 */
			"InvitationButtonEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * Flag that indicates meeting participants exist.
			 */
			"ParticipantsExist": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * Flag that indicates a notification has already been sent to participants.
			 */
			"ParticipantsInvited": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * Flag that indicates the meeting has been exported to an external calendar.
			 */
			"MeetingExported": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * Meeting is out of date.
			 */
			"OutdatedMeeting": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * Meeting calendar synchronization since date.
			 */
			"CalendarSyncSinceDate": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": ""
			}
		},
		methods: {

			// region Methods: Private

			/**
			 * Get a link to the academy by identifier.
			 * @param {Number} articleId Article identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			_getAcademyUrl: function(articleId, callback, scope) {
				const config = {
					scope: scope || this,
					contextHelpId: articleId,
					callback: callback
				};
				Terrasoft.AcademyUtilities.getUrl(config);
			},

			/**
			 * Generate a hint about disabled synchronization.
			 */
			_initSynchronizationNotEnabledHint: function() {
				Terrasoft.chain(
					function(next) {
						this._getAcademyUrl(this.get("ExchangeCalendarArticleId"), next, this);
					},
					function(next, exchangeArticleUrl) {
						this._getAcademyUrl(this.get("GoogleCalendarArticleId"), function(googleArticleUrl) {
							next(exchangeArticleUrl, googleArticleUrl);
						}, this);
					},
					function(next, exchangeArticleUrl, googleArticleUrl) {
						this.set("SynchronizationNotEnabledHint", 
							Ext.String.format(resources.localizableStrings.SynchronizationNotEnabledHintTemplate, exchangeArticleUrl,
								googleArticleUrl));
					}, this
				);
			},

			/**
			 * Checking that the current user is the meeting organizer.
			 * @returns {Boolean} True if user is organizer.
			 * @private
			 */
			_userIsOrganizer: function() {
				const organizer = this.get("Organizer");
				return this.isNotEmpty(organizer) &&
					organizer.value === Terrasoft.SysValue.CURRENT_USER_CONTACT.value; 
			},

			// endregion

			// region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent(arguments);
				if (this.getIsFeatureEnabled("MeetingInvitation")) {
					this.subscribeServerChannelEvents();
					this._initSynchronizationNotEnabledHint();
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
			 * @overridden
			 */
			destroy: function() {
				this.unsubscribeServerChannelEvents();
				this.callParent(arguments);
			},

			/**
			 * Removes viewmodel subscription to server messages.
			 * @protected
			 */
			unsubscribeServerChannelEvents: function() {
				this.Terrasoft.ServerChannel.un(this.Terrasoft.EventName.ON_MESSAGE,
					this.onServerChannelMessage, this);
			},

			/**
			 * Subscribes viewmodel to server messages.
			 * @protected
			 */
			subscribeServerChannelEvents: function() {
				this.Terrasoft.ServerChannel.on(this.Terrasoft.EventName.ON_MESSAGE,
					this.onServerChannelMessage, this);
			},

			/**
			 * Server message handler.
			 * @protected
			 * @param {Object} scope Message scope.
			 * @param {Object} message Server messsage.
			 */
			 onServerChannelMessage: function(scope, message) {
				if (this.isEmpty(message) || (!this.isEmpty(message) && !this.isEmpty(message.Header) &&
					message.Header.Sender !== "RecordOperationsNotificator")) {
					return;
				}
				const body = this.Ext.decode(message.Body);
				const activityRecordChangeMessage = Ext.String.format("{0}RecordChange", this.$DetailColumnName);
				switch (message.Header.BodyTypeName) {
					case activityRecordChangeMessage:
						if (body.RecordId === this.get("MasterRecordId")) {
							this.reloadGridData();
						}
						break;
					default:
						break;
				}
			},

			/**
			 * Check send invitations button visibility.
			 * @protected
			 */
			getInvitationButtonVisible: function() {
				if (!this._userIsOrganizer() || this.getIsFeatureDisabled("MeetingInvitation") ||
					!this.get("ParticipantsExist")) {
					return false;
				}
				return !this.get("InvitationButtonEnabled") || this.get("MeetingExported");
			},

			/**
			 * Send invitations to activity participants.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			onSendInvitationsClick: function(callback, scope) {
				const meetingId = this.get("MasterRecordId");
				Terrasoft.chain(
					function(next) {
						if (this.get("OutdatedMeeting")) {
							this.showConfirmationDialog(resources.localizableStrings.SendingInvitationToOldMeeting,
								function (returnCode) {
									if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode) {
										next();
									}
								}, [Terrasoft.MessageBoxButtons.YES, Terrasoft.MessageBoxButtons.NO]);
						} else {
							next();
						}
					},
					function(next) {
						this.sendInvitations(meetingId, next, this);
					},
					function() {
						this.reloadGridData();
						Ext.callback(callback, scope);
					},
				this);
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#onGridLoaded
			 * @protected
			 * @override
			 */
			onGridLoaded: function() {
				this.callParent(arguments);
				if (this.getIsFeatureEnabled("MeetingInvitation")) {
					this.initMeetingInvitationInfo(this.get("MasterRecordId"), Terrasoft.emptyFn, this);
				}
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
			 * @overridden
			 */
			getGridRowViewModelClassName: function() {
				return "Terrasoft.ActivityParticipantGridViewModel";
			},

			/**
			 * Creates participant column control config.
			 * @protected
			 * @param {Object} control Column control options object.
			 */
			getParticipantControlConfig: function(control) {
				const participantNameLabel = {
					"className": "Terrasoft.Hyperlink",
					"caption": {"bindTo": "Participant"},
					"markerValue": {"bindTo": "getParticipantName"},
					"href": {"bindTo": "getParticipantLink"},
					"linkMouseOver": {bindTo: "linkMouseOver"},
					"target": "_self",
					"classes": {
						"hyperlinkClass": ["name-label"]
					},
					"tag": {
						"columnName": "Participant",
						"referenceSchemaName": "Contact"
					}
				};
				control.config = {
					"className": "Terrasoft.Container",
					"classes": {
						"wrapClassName": ["participant-name-container"]
					},
					"items": [
						participantNameLabel,
						{
							"className": "Terrasoft.Button",
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"markerValue": {"bindTo": "getStateIconMarekValue"},
							"imageConfig": {"bindTo": "getStateIconConfig"},
							"classes": {
								"wrapperClass": ["invitation-state"]
							},
							"visible": {"bindTo": "InviteParticipant"},
							"tips": [{"tip": {"content": {"bindTo": "getStateIconTip"}}}]
						}
					]
				};
			},

			/**
			 * @inheritdoc Terrasoft.ActivityParticipantDetailV2#onContactInsert
			 * @overridden
			 */
			onContactInsert: function() {
				const parentMethod = this.getParentMethod();
				const parentArgs = arguments;
				if (this.isInvitationsSent()) {
					this.sendInvitations(this.$MasterRecordId, function () {
						Ext.callback(parentMethod, this, parentArgs)
					}, this);
				} else {
					Ext.callback(parentMethod, this, parentArgs)
				}
			},

			/**
			 * @inheritdoc Terrasoft.ActivityParticipantDetailV2#openContactLookup
			 * @overridden
			 */
			openContactLookup: function() {
				const parentMethod = this.getParentMethod();
				const parentArgs = arguments;
				if (this.getIsFeatureEnabled("MeetingInvitation") && this.isInvitationsSent()) {
					if (this._userIsOrganizer()) {
						const columnsValues = this.sandbox.publish("GetColumnsValues", ["DueDate"], [this.sandbox.id]);
						const dialogMessage = columnsValues.DueDate > new Date()
							? resources.localizableStrings.CanUserChangeMeetingResolveMessage
							: resources.localizableStrings.CanUserChangeObsolteMeetingResolveMessage;
						return this.showConfirmationDialog(dialogMessage,
							function(returnCode) {
								if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode) {
									Ext.callback(parentMethod, this, parentArgs);
								}
						}, [Terrasoft.MessageBoxButtons.YES, Terrasoft.MessageBoxButtons.NO]);
					} else {
						return this.showInformationDialog(resources.localizableStrings.CanNotChangeMeetingMessage);
					}
				}
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getDeleteConfirmationMessage
			 * @overridden
			 */
			getDeleteConfirmationMessage: function(items, callback, scope) {
				const startDate = this.sandbox.publish("GetColumnsValues", ["StartDate"], [this.sandbox.id]);
				if (this.getIsFeatureEnabled("MeetingInvitation") && this.isInvitationsSent() && items
						&& items.length && startDate.StartDate >= new Date(this.$CalendarSyncSinceDate)) {
					if (this._userIsOrganizer()) {
						const message = (items.length > 1)
							? resources.localizableStrings.MultiDeleteMeetingWithInvitationsConfirmationMessage
							: resources.localizableStrings.DeleteMeetingWithInvitationsConfirmationMessage;
						return Ext.callback(callback, scope || this, [message]);
					} else {
						return this.showInformationDialog(resources.localizableStrings.CanNotChangeMeetingMessage);
					}
				}
				this.callParent(arguments);
			}

			// endregion

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"generator": "ActivityParticipantDetailGridGenerator.generatePartial",
					"type": "listed"
				}
			},
			{
				"operation": "insert",
				"name": "SendInvitationsButton",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"caption": {
						"bindTo": "ParticipantsInvited",
						"bindConfig": {
							"converter": function(participantsInvited) {
								return participantsInvited
									? resources.localizableStrings.ResendInvitationsButtonCaption
									: resources.localizableStrings.SendInvitationsButtonCaption;
							}
						}
					},
					"imageConfig": {
						"bindTo": "ParticipantsInvited",
						"bindConfig": {
							"converter": function(participantsInvited) {
								return participantsInvited
									? resources.localizableImages.ResendInvitationsImage
									: resources.localizableImages.SendInvitationsImage;
							}
						}
					},
					"enabled": { "bindTo": "InvitationButtonEnabled" },
					"visible": { "bindTo": "getInvitationButtonVisible" },
					"click": { "bindTo": "onSendInvitationsClick" },
					"hint": {
						"bindTo": "InvitationButtonEnabled",
						"bindConfig": {
							"converter": function(invitationButtonEnabled) {
								return invitationButtonEnabled
									? Terrasoft.emptyString
									: this.get("SynchronizationNotEnabledHint");
							}
						}
					},
					"style": Terrasoft.controls.ButtonEnums.style.DEFAULT
				},
				"parentName": "Detail",
				"propertyName": "tools"
			}
		]/**SCHEMA_DIFF*/
	};
});


