define("CasePage", ["EmailMiningEnums"], function() {
		return {

			messages: {

				/**
				 * Update case contact.
				 */
				"CaseContactUpdate": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},

			methods: {

				//region Methods: Private

				/**
				 * Returns "UpdateCaseByContact" query.
				 * @private
				 * @param {String} contactId Sender contact identifier.
				 * @return {Object} "UpdateCaseByContact" query.
				 */
				_getUpdateCaseByContactQuery: function(contactId) {
					var update = Ext.create("Terrasoft.UpdateQuery", {
						rootSchemaName: "Case"
					});
					var caseId = this.get("Id");
					update.enablePrimaryColumnFilter(caseId);
					update.setParameterValue("Contact", contactId, this.Terrasoft.DataValueType.LOOKUP);
					return update;
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function() {
					this.subscribeCloudUpdateEvents();
					this.callParent(arguments);
					this.sandbox.subscribe("CaseContactUpdate", function(contactId) {
						this.updateCaseByContact(contactId);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
				 * @overridden
				 */
				destroy: function() {
					this.unsubscribeCloudUpdateEvents();
					this.callParent(arguments);
				},

				/**
				 * Removes viewmodel subscription to server messages.
				 * @protected
				 */
				unsubscribeCloudUpdateEvents: function() {
					this.Terrasoft.ServerChannel.un(this.Terrasoft.EventName.ON_MESSAGE,
						this.onCloudUpdateMessage, this);
				},

				/**
				 * Subscribes viewmodel to server messages.
				 * @protected
				 */
				subscribeCloudUpdateEvents: function() {
					this.Terrasoft.ServerChannel.on(this.Terrasoft.EventName.ON_MESSAGE,
						this.onCloudUpdateMessage, this);
				},


				/**
				 * Server message handler. Reloads contact page after enrich events.
				 * @protected
				 * @param {Object} scope Message scope.
				 * @param {Object} message Server messsage.
				 */
				onCloudUpdateMessage: function(scope, message) {
					var enrichMessageBodyType = this.Terrasoft.EmailMiningEnums.EnrichMessageBodyType.SAVED;
					if (!message || !message.Header || message.Header.Sender !== "EmailMining" ||
							message.Header.BodyTypeName !== enrichMessageBodyType) {
						return;
					}
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Activity"
					});
					esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Case", this.get("Id")));
					esq.getEntityCollection(function(response) {
						if (response.success) {
							var receivedMessage = this.Ext.decode(message.Body);
							response.collection.each(function(item) {
								var activityId = item.get("Id");
								var currentActivityItems = Terrasoft.findItem(receivedMessage, {activityId: activityId});
								if (this.isNotEmpty(currentActivityItems)) {
									var currentActivityItem = currentActivityItems.item;
									var contactId = currentActivityItem.contactId;
									if (this.isEmpty(this.get("Contact")) && this.isNotEmpty(contactId)) {
										this.showSetCaseContactMessageConfirmationDialog(contactId,
											currentActivityItem.contactName);
									} else {
										this.reloadEntity();
									}
									return false;
								}
							}, this);
						}
					}, this);
				},

				/**
				 * Show "Set case contact message" confirmation dialog.
				 * @param {String} contactId Sender contact identifier.
				 * @param {String} contactName Sender contact name.
				 * @protected
				 */
				showSetCaseContactMessageConfirmationDialog: function(contactId, contactName) {
					var setCaseContactMessage = this.Ext.String.format(
						this.get("Resources.Strings.SetCaseContactMessage"), contactName);
					this.showConfirmationDialog(setCaseContactMessage, function(returnCode) {
						if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
							this.updateCaseByContact(contactId);
						} else {
							this.reloadEntity();
						}
					}, ["yes", "no"]);
				},

				/**
				 * Connect selected contact to case.
				 * @param {String} contactId Sender contact identifier.
				 * @protected
				 */
				updateCaseByContact: function(contactId) {
					var update = this._getUpdateCaseByContactQuery(contactId);
					update.execute(this.reloadEntity, this);
				}

				//endregion

			},
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
