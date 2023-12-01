﻿define("ContactSectionV2", ["SyncSettingsMixin"],
	function() {
		return {
			entitySchemaName: "Contact",
			messages: {
				/**
				 * @message ShowSyncSettingsSetTip
				 * Notify to show tip about completed set sync settings.
				 */
				"ShowSyncSettingsSetTip": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				/**
				 * Activity synchronization mixin.
				 */
				"SyncSettinsMixin": "Terrasoft.SyncSettingsMixin"
			},
			attributes: {
				/**
				 * Flag for visibility of the completed synchronization.
				 */
				"IsSyncSettingsSetTipVisible": {dataValueType: Terrasoft.DataValueType.BOOLEAN}
			},
			methods: {

				/**
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initContactSyncSettings();
					this.sandbox.subscribe("ShowSyncSettingsSetTip", this.updateSyncSettingsSetAndShowTip, this);
				},

				/**
				 * ######### ####### ######## ############# ######### # Exchange
				 * # ############# ############### ######## ######.
				 * @protected
				 */
				initContactSyncSettings: function() {
					this.set("IsExchangeContactSyncExist", false);
					var select = this.getBaseContactSyncSettingsSelect();
					select.addAggregationSchemaColumn("Id", this.Terrasoft.AggregationType.COUNT, "Count");
					select.getEntityCollection(function(response) {
						if (response.success) {
							this.set("IsExchangeContactSyncExist", response.collection.getCount() > 0 &&
								response.collection.getItems()[0].get("Count") > 0);
						}
					}, this);
				},

				/**
				 * ############## ######## # Exchange.
				 * @protected
				 */
				synchronizeExchangeContacts: function() {
					var select = this.getBaseContactSyncSettingsSelect();
					select.addColumn("Id");
					select.addColumn("[MailboxSyncSettings:Id:MailboxSyncSettings].SenderEmailAddress",
						"SenderEmailAddress");
					select.getEntityCollection(function(response) {
						if (response.success) {
							if (response.collection.getCount() < 1) {
								return;
							}
							this.createSyncJobs(response.collection);
						} else {
							this.Terrasoft.utils.showInformation(
								this.get("Resources.Strings.ReadSyncSettingsBadResponse")
							);
						}
					}, this);
				},

				/**
				 * ####### # ########## ############ ###### ## ############# ######### # ####### Exchange.
				 * @private
				 * @param {Terrasoft.Collection} collection ######### ########### #########.
				 */
				createSyncJobs: function(collection) {
					var requestsCount = 0;
					var messageArray = [];
					var requestUrl = this.Terrasoft.workspaceBaseUrl +
						"/rest/MailboxSettingsService/CreateContactSyncJob";
					collection.each(function(item) {
						var data = {
							interval: 0,
							senderEmailAddress: item.get("SenderEmailAddress")
						};
						this.showBodyMask();
						requestsCount++;
						this.Terrasoft.AjaxProvider.request({
							url: requestUrl,
							headers: {
								"Content-Type": "application/json",
								"Accept": "application/json"
							},
							method: "POST",
							jsonData: data,
							scope: this,
							callback: function(request, success, response) {
								if (success) {
									var responseData = Ext.decode(response.responseText);
									if (!Ext.isEmpty(responseData.CreateContactSyncJobResult)) {
										messageArray = messageArray.concat(responseData.CreateContactSyncJobResult);
									}
								}
								if (--requestsCount <= 0) {
									var message = this.get("Resources.Strings.SynchronizeExchangeSuccessMessage");
									if (messageArray.length > 0) {
										message = "";
										this.Terrasoft.each(messageArray, function(element) {
											message = message.concat(element);
										}, this);
									}
									this.hideBodyMask();
									this.Terrasoft.utils.showInformation(message);
								}
							}
						});
					}, this);
				},

				/**
				 * ########## {Terrasoft.EntitySchemaQuery} # ######### ## ############
				 * # ####### #### ############# #########.
				 * @private
				 */
				getBaseContactSyncSettingsSelect: function() {
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ContactSyncSettings"
					});
					select.filters.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"[MailboxSyncSettings:Id:MailboxSyncSettings].SysAdminUnit",
						this.Terrasoft.SysValue.CURRENT_USER.value));
					var filterGroup = select.createFilterGroup();
					filterGroup.name = "SynContactsFilterGroup";
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"ImportContacts", true));
					filterGroup.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"ExportContacts", true));
					select.filters.addItem(filterGroup);
					return select;
				},

				/**
				 * @inheritDoc Terrasoft.BaseSection#getSectionActions
				 * @overridden
				 */
				getSectionActions: function() {
					var actionMenuItems = this.callParent(arguments);
					if (this.get("canUseGoogleOrSocialFeaturesByBuildType")) {
						this.setSyncSectionActions(actionMenuItems);
					}
					return actionMenuItems;
				},

				/**
				 * @inheritdoc Terrasoft.ContactSectionV2#synchronizeNow
				 * @overridden
				 */
				synchronizeNow: function() {
					this.callParent(arguments);
					if (this.get("IsExchangeContactSyncExist")) {
						this.synchronizeExchangeContacts();
					}
				},

				/**
				 * Returns set sync settings section action caption.
				 * @overridden
				 * @return {String} Caption.
				 */
				getSetSyncSettingsCaption: function() {
					return this.get("Resources.Strings.SetUpSynchronization");
				},

				/**
				 * Start synchronization with google account.
				 */
				synchronizeGoogle: function() {
					this.synchronizeWithGoogleContacts();
				},

				/**
				 * Start synchronization with exchange account.
				 */
				synchronizeExchange: function() {
					this.synchronizeExchangeContacts();
				},

				/**
				 * @inheritDoc Terrasoft.SyncSettinsMixin#updateSyncSettingsSetAndShowTip
				 * @overridden
				 */
				updateSyncSettingsSetAndShowTip: function(itemId) {
					if (itemId) {
						this.set("IsExchangeContactSyncExist", true);
					} else {
						this.set("GoogleSyncExists", true);
					}
					this.mixins.SyncSettinsMixin.updateSyncSettingsSetAndShowTip.call(this, itemId);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "SeparateModeActionsButton",
					"values": {
						"tips": []
					}
				},
				{
					"operation": "insert",
					"parentName": "SeparateModeActionsButton",
					"propertyName": "tips",
					"name": "SyncSettingsSetTip",
					"values": {
						"content": {"bindTo": "Resources.Strings.SyncSettingsSetTipCaption"},
						"visible": {"bindTo": "IsSyncSettingsSetTipVisible"},
						"style": Terrasoft.TipStyle.GREEN,
						"linkClicked": {bindTo: "navigateToSyncSettingsWithSyncSettingsUpdate"},
						"behaviour": {
							"displayEvent": Terrasoft.TipDisplayEvent.NONE
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
