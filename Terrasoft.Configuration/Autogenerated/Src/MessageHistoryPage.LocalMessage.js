﻿define("MessageHistoryPage", ["LocalMessageConstants", "css!LocalMessageHistoryPageCSS"],
	function(LocalMessageConstants) {
		return {
			messages: {
				/**
				 * @message ShowSystemMessages
				 * Message of informing history its need show system messages.
				 */
				"ShowSystemMessages": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message HideSystemMessages
				 * Message of informing history its need hide system messages.
				 */
				"HideSystemMessages": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			attributes: {
				/**
				 * True, if need show system messages.
				 */
				"NeedShowSystemMessages": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				}
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.MessageHistoryPage#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("ShowSystemMessages", this.showSystemMessages, this, [this.sandbox.id]);
					this.sandbox.subscribe("HideSystemMessages", this.hideSystemMessages, this, [this.sandbox.id]);
				},

				/**
				 * Hides system message.
				 * @private
				 */
				hideSystemMessages: function() {
					this.set("NeedShowSystemMessages", false);
					this.reloadHistory();
				},

				/**
				 * Shows system message.
				 * @private
				 */
				showSystemMessages: function() {
					this.set("NeedShowSystemMessages", true);
					this.reloadHistory();
				},

				/**
				 * Reloads history.
				 * @private
				 */
				reloadHistory: function() {
					if (this.getIsFeatureEnabled("UseMessageHistoryPagination")) {
						this.$MessagesOffsetCount = 0;
					}
					var history = this.get("HistoryMessages");
					history.clear();
					this.set("SortColumnLastValue", null);
					var historyBySectionFilter = this.get("historyBySectionFilter");
					var initMessageCount = this.get("InitMessageCount");
					this.loadMessages(initMessageCount, historyBySectionFilter);
				},

				/**
				 * @inheritDoc Terrasoft.MessageHistoryUtilities#getHistoryMessageEsq
				 * @overridden
				 */
				getHistoryMessageEsq: function() {
					var esq = this.callParent(arguments);
					if (!this.get("NeedShowSystemMessages")) {
						esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL,
							"MessageNotifier", LocalMessageConstants.MessageNotifier.Local));
					}
					return esq;
				},
				/**
				 * Returns visibility of show system message button.
				 * @return {Boolean} Visibility of hide system message button.
				 */
				getShowSystemMessagesLabelVisible: function() {
					return !this.get("NeedShowSystemMessages") && this.getIsMessageHistoryV2FeatureEnabled() &&
						this.get("AreNotifiersInitialized");
				},

				/**
				 * Returns visibility of hide system message button.
				 * @return {Boolean} Visibility of hide system message button.
				 */
				getHideSystemMessagesLabelVisible: function() {
					return this.get("NeedShowSystemMessages") && this.getIsMessageHistoryV2FeatureEnabled() &&
						this.get("AreNotifiersInitialized");
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "ShowSystemMessagesLabel",
					"parentName": "MessageHistoryContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.ShowSystemMessagesString"
						},
						"labelClass": ["systemMessage-button-label"],
						"visible": {
							"bindTo": "getShowSystemMessagesLabelVisible"
						},
						"click": {
							"bindTo": "showSystemMessages"
						}
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HideSystemMessagesLabel",
					"parentName": "MessageHistoryContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.HideSystemMessagesString"
						},
						"labelClass": ["systemMessage-button-label"],
						"visible": {
							"bindTo": "getHideSystemMessagesLabelVisible"
						},
						"click": {
							"bindTo": "hideSystemMessages"
						}
					},
					"index": 1
				}
			]
		};
	}
);
