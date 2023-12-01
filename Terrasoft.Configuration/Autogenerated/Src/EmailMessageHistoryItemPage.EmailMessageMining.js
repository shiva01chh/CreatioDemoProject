define("EmailMessageHistoryItemPage", ["EmailMessageEnrichmentMixin", "css!EmailMessageEnrichmentHistoryItemStyle"],
	function() {
		return {
			messages: {

				/**
				 * Update contact enrichment page visibility.
				 */
				"ContactEnrichmentPageVisibilityChanged": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * Message to get contact page response after saving.
				 */
				"ContactPageV2OnSavedResponse": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetHistoryState
				 * Message asks current history state.
				 */
				"GetHistoryState": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * Update case contact.
				 */
				"CaseContactUpdate": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {

				/**
				 * @class Terrasoft.EmailEnrichmentMixin
				 * Email enrichment mixin.
				 */
				EmailMessageEnrichmentMixin: "Terrasoft.EmailMessageEnrichmentMixin"
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.getContactsFromServer(function(response) {
							var result = response && response.CloudStateResponse;
							this.set("Response", result);
							this.loadSenderData();
							this.initEnrichmentCollection();
							this.Ext.callback(callback, scope);
						}, this);
					}, this]);
				},

				/**
				 * Returns actions button icon.
				 * @param {Boolean} isCloudVisible Is cloud icon visible.
				 * @return {Object} Actions button icon.
				 */
				getActionsButtonImage: function(isCloudVisible) {
					if (isCloudVisible) {
						return this.get("Resources.Images.ContactEnrichmentIcon");
					}
					return this.callParent(arguments);
				},

				/**
				 * Returns actions button marker value.
				 * @param {Boolean} isCloudVisible Is cloud icon visible.
				 * @return {String} Actions button marker value.
				 */
				getActionsButtonMarkerValue: function(isCloudVisible) {
					var markerValue = isCloudVisible ? "ShowCloud " : "HideCloud ";
					return markerValue + this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#historyMessageEsqApply
				 * @overridden
				 */
				historyMessageEsqApply: function(esq) {
					this.callParent(arguments);
					esq.addColumn("Case.Contact", "CaseContact");
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "EmailAction",
					"values": {
						"imageConfig": {
							"bindTo": "isCloudVisible",
							"bindConfig": {
								"converter": "getActionsButtonImage"
							}
						},
						"markerValue": {
							"bindTo": "isCloudVisible",
							"bindConfig": {
								"converter": "getActionsButtonMarkerValue"
							}
						}
					}
				},
				{
					"operation": "merge",
					"name": "EmailSender",
					"values": {
						"visible": {
							"bindTo": "showSenderLabel"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "EmailSenderWrapContainer",
					"propertyName": "items",
					"name": "EmailSenderContact",
					"values": {
						"itemType": Terrasoft.ViewItemType.HYPERLINK,
						"caption": {bindTo: "SenderName"},
						"classes": {
							"hyperlinkClass": ["t-label", "label-link", "label-url", "email-sender-contact"]
						},
						"click": {bindTo: "openContactPage"},
						"markerValue": {bindTo: "ContactSenderName"},
						"visible": {bindTo: "showSenderLink"}
					},
					"index": 2
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
