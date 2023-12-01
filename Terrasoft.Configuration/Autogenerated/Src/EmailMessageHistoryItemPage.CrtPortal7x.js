define("EmailMessageHistoryItemPage", ["css!EmailMessageHistoryItemPageCSS"],
	function() {
		return {
			entitySchemaName: "BaseMessageHistory",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			attributes: {

				/**
				 * Is message visible on portal value.
				 */
				"IsMessageVisibleOnPortal": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN
				}
			},
			methods: {

				/**
				 * @inheritdoc BasePageV2#init
				 * @override
				 */
				init: function() {
					this.callParent(arguments);
					this.set("IsMessageVisibleOnPortal",
							!this.Ext.isEmpty(this.get("[PortalEmailMessage:CaseMessageHistory:Id].Id")));
				},

				/**
				 * Returns "Hide email on portal" label visibility.
				 * @public
				 * @returns {Boolean} "Hide email on portal" label visibility.
				 */
				isHideEmailOnPortalLabelVisible: function() {
					if (!this.isShowEmailOnPortalEnabled()) {
						return false;
					}
					return this.get("IsMessageVisibleOnPortal");
				},

				/**
				 * Returns "Show email on portal" label visibility.
				 * @public
				 * @returns {Boolean} "Show email on portal" label visibility.
				 */
				isShowEmailOnPortalLabelVisible: function() {
					if (!this.isShowEmailOnPortalEnabled()) {
						return false;
					}
					return !this.get("IsMessageVisibleOnPortal");
				},

				/**
				 * Hides email message on portal.
				 * @public
				 */
				hideEmailMessageOnPortal: function() {
					this._showPortalEmailMessageButtonDialog(this.get("Resources.Strings.HideEmailConfirmationMessage"),
							false);
				},

				/**
				 * Shows email message on portal.
				 * @public
				 */
				showEmailMessageOnPortal: function() {
					this._showPortalEmailMessageButtonDialog(this.get("Resources.Strings.ShowEmailConfirmationMessage"),
							true);
				},

				/**
				 * Shows confirmation dialog before.
				 * @param {String} message Dialog message.
				 * @param {Boolean} showEmailOnPortal Sets message visibility.
				 * @private
				 */
				_showPortalEmailMessageButtonDialog: function(message, showEmailOnPortal) {
					this.showConfirmationDialog(message,
							function(result) {
								if (result === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
									this.updatePortalEmailMessage(showEmailOnPortal);
								}
							},
							["yes", "no"]);
				},

				/**
				 * Updates portal email message.
				 * @public
				 * @param {Boolean} showEmailOnPortal Sets message visibility.
				 */
				updatePortalEmailMessage: function(showEmailOnPortal) {
					if (showEmailOnPortal) {
						this._addPortalEmailMessage();
					} else {
						this._deletePortalEmailMessage();
					}
					this.set("IsMessageVisibleOnPortal", showEmailOnPortal);
				},

				/**
				 * Deletes portal email message from messages available on the portal.
				 * @private
				 */
				_deletePortalEmailMessage: function() {
					var deleteQuery = Ext.create("Terrasoft.DeleteQuery", {
						rootSchemaName: "PortalEmailMessage"
					});
					deleteQuery.filters.add(deleteQuery.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "CaseMessageHistory", this.get("Id")));
					deleteQuery.execute(function(response) {
						if(!response.success) {
							this.showConfirmationDialog(this.get("Resources.Strings.HideMessageError"));
						}
					}, this);
				},

				/**
				 * Adds portal email message to messages available on the portal.
				 * @private
				 */
				_addPortalEmailMessage: function() {
					var insert = Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: "PortalEmailMessage"
					});
					insert.setParameterValue("CaseMessageHistory", this.get("Id"),
							Terrasoft.DataValueType.GUID);
					insert.setParameterValue("Recipient", this.get(this.$ConnectionColumnsPath + ".Recepient"),
							Terrasoft.DataValueType.TEXT);
					insert.setParameterValue("Sender", this.getActivitySenderDisplayValue(),
							Terrasoft.DataValueType.TEXT);
					insert.setParameterValue("SendDate", this.get(this.$ConnectionColumnsPath + ".SendDate"),
							Terrasoft.DataValueType.DATE_TIME);
					insert.setParameterValue("IsHtmlBody", this.get(this.$ConnectionColumnsPath + ".IsHtmlBody"),
							Terrasoft.DataValueType.BOOLEAN);
					insert.setParameterValue("MessageTypeId",
						this.get(this.$ConnectionColumnsPath + ".MessageType").value, Terrasoft.DataValueType.GUID);
					insert.execute(function(response){
						if(!response.success){
							this.showConfirmationDialog(this.get("Resources.Strings.ShowMessageError"));
						}
					}, this);
				},

				/**
				 * Checks if ShowEmailOnPortal feature enabled.
				 * @protected
				 * @virtual
				 * @returns {Boolean} Is feature enabled.
				 */
				isShowEmailOnPortalEnabled: function() {
					return this.getIsFeatureEnabled("ShowEmailOnPortal");
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#historyMessageEsqApply
				 * @override
				 */
				historyMessageEsqApply: function(esq) {
					this.callParent(arguments);
					esq.addColumn("[PortalEmailMessage:CaseMessageHistory:Id].Id");
				},

				/**
				 * @inheritdoc Terrasoft.EmailMessageHistoryPage#getIsNeedToColor
				 * @override
				 */
				getIsNeedToColor: function() {
					const parentValue = this.callParent(arguments);
					return parentValue && (this.$IsMessageVisibleOnPortal === false);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "PortalEmailMessageVisibilityContainer",
					"parentName": "MessageContentContainer",
					"propertyName": "items",
					"values": {
						"id": "PortalEmailMessageVisibilityContainer",
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24,
							"rowSpan": 1
						},
						"markerValue": "PortalEmailMessageVisibilityContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["PortalEmailMessageVisibilityContainer"],
						"items": []
					},
					"index": 3
				},
				{
					"operation": "insert",
					"name": "HideEmailOnPortalLabel",
					"parentName": "PortalEmailMessageVisibilityContainer",
					"propertyName": "items",
					"values": {
						"id": "HideEmailOnPortalLabel",
						"labelClass": ["portalEmailMessageVisibilityLabel"],
						"markerValue": "HideEmailOnPortalLabel",
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.HideEmailOnPortalString"
						},
						"visible": {
							"bindTo": "isHideEmailOnPortalLabelVisible"
						},
						"click": {
							"bindTo": "hideEmailMessageOnPortal"
						}
					}
				},
				{
					"operation": "insert",
					"name": "ShowEmailOnPortalLabel",
					"parentName": "PortalEmailMessageVisibilityContainer",
					"propertyName": "items",
					"values": {
						"id": "ShowEmailOnPortalLabel",
						"labelClass": ["portalEmailMessageVisibilityLabel"],
						"markerValue": "ShowEmailOnPortalLabel",
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.ShowEmailOnPortalString"
						},
						"visible": {
							"bindTo": "isShowEmailOnPortalLabelVisible"
						},
						"click": {
							"bindTo": "showEmailMessageOnPortal"
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
