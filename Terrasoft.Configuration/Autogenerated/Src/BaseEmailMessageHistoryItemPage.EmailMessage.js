define("BaseEmailMessageHistoryItemPage", ["ConfigurationConstants", "EmailActionsMixin",
		"css!EmailMessageHistoryItemStyle"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "BaseMessageHistory",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			attributes: {
				/**
				 * String, that is used for connection message history, activity or another entity.
				 */
				"ConnectionColumnsPath": {
					"dataValueType": this.Terrasoft.DataValueType.TEXT
				}
			},
			mixins: {
				/**
				 * Mixin for actions with email.
				 */
				EmailActionsMixin: "Terrasoft.EmailActionsMixin"
			},
			messages: {},
			methods: {
				/*
				 * Returns columns array for case message history esq.
				 * @protected
				 * @virtual
				 * @return {Array} Array of columns.
				 */
				getHistoryMessageColumns: this.Terrasoft.emptyFn,

				/*
				 * Returns filter by message notifiers.
				 * @protected
				 * @virtual
				 * @param {Object} Esq object.
				 * @return {Object} Esq filter.
				 */
				getNotifierGroup: this.Terrasoft.emptyFn,

				//region Methods: Private

				/**
				 * Replace targets in links to blank page.
				 * @private
				 * @param messageText Source message text.
				 * @returns {String} Text with targeted to blank page links.
				 */
				_changeLinksTargeting: function(messageText) {
					const linkPattern = /<a\b[^>]+?>/gi;
					const links = messageText.match(linkPattern)?.filter((l) => l.indexOf('href=\"mailto') === -1);
					if (!links) {
						return messageText;
					}
					const targetBlankPattern = /\btarget\s*=\s*"_blank"/i;
					const relReplacePattern =/\brel\s*=\s*".*?"/gi
					const targetBlankSubstitute = "target=\"_blank\"";
					const relSubstitute = "rel=\"noopener noreferrer\"";
					const targetBlankReplacePattern = /\btarget\s*=\s*".*?"/gi;
					for (let i = 0; i < links.length; i++) {
						if (!links[i].match(targetBlankPattern)) {
							let modifiedLink = this._getReplaceAttributeValue(links[i], relReplacePattern, relSubstitute);
							modifiedLink = this._getReplaceAttributeValue(modifiedLink, targetBlankReplacePattern, targetBlankSubstitute);
							messageText = messageText.replace(links[i], modifiedLink);
						}
					}
					return messageText;
				},

				/**
				 * Get replace attribute value.
				 * @private
				 * @param tag Opening tag.
				 * @param attributePattern Attribute pattern.
				 * @param attributeValue Attribute value.
				 * @returns {String} replace attribute value.
				 */
				_getReplaceAttributeValue: function (tag, attributePattern, attributeValue) {
					let replaceAttributeValue = tag.replace(attributePattern, attributeValue);
					if (replaceAttributeValue === tag) {
						replaceAttributeValue= tag.replace("<a", "<a " + attributeValue + " ");
					}
					return replaceAttributeValue;
				},

				//endregion

				//region Methods: Public

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#historyMessageEsqApply
				 * @override
				 */
				historyMessageEsqApply: function(esq) {
					var columns = this.getHistoryMessageColumns();
					this.Terrasoft.each(columns, function(column) {
						if (!esq.columns.collection.containsKey(column)) {
							esq.addColumn(column);
						}
					});
					var filterGroup = this.getNotifierGroup(esq);
					esq.filters.addItem(filterGroup);
				},

				/**
				 * Returns wrap container marker value.
				 * @protected
				 * @virtual
				 * @return {String} Wrap container marker value.
				 */
				getWrapContainerMarkerValue: function() {
					var messageType = this.get(this.$ConnectionColumnsPath + ".MessageType");
					if (messageType.value === ConfigurationConstants.Activity.MessageType.Incoming) {
						return "IncomingEmailHistoryMessageWrapContainer";
					} else {
						return "OutgoingEmailHistoryMessageWrapContainer";
					}
				},

				/**
				 * Formats plain text body to html format.
				 * @protected
				 * @virtual
				 * @param {String} message body.
				 * @return {String} Body in html format.
				 */
				formatPlainTextBody: function(message) {
					message = _.escape(message);
					message = message.replace(/(?:\r\n|\r|\n)/g, '<br>');
					return message;
				},

				/**
				 * Message pre-processing.
				 * @protected
				 * @param value Bound message.
				 * @returns {String} Processed message.
				 */
				prepareMessage: function(value) {
					const isHtmlBody = this.get(this.$ConnectionColumnsPath + ".IsHtmlBody");
					if (Ext.isBoolean(isHtmlBody) && !isHtmlBody) {
						value = this.formatPlainTextBody(value);
					}
					value = this.validateMessage(value);
					value = this.replaceImportantHeight(value);
					return this._changeLinksTargeting(value);
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "HistoryMessageWrapContainer",
					"values": {
						"wrapClass": ["historyMessageWrap", "historyEmailMessageWrap"],
						"markerValue": {
							"bindTo": "getWrapContainerMarkerValue"
						}
					}
				},
				{
					"operation": "merge",
					"name": "MessageContentContainer",
					"values": {
						"wrapClass": ["messageContent", "speech-bubble"]
					}
				},
				{
					"operation": "insert",
					"name": "CreatedByLink",
					"parentName": "CreatedByLinkWrapContainer",
					"propertyName": "items",
					"values": {
						"classes": {
							"hyperlinkClass": ["link", "createdByLink", "label-url", "label-link"]
						},
						"caption": {
							"bindTo": "getCreatedByName"
						},
						"markerValue": "CreatedByLink"
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "CreatedByLinkWrapContainer",
					"parentName": "EmailRecepientWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "CreatedByLinkWrapContainer",
						"markerValue": "CreatedByLinkWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["createdByLinkWrap"],
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "EmailRecepientWrapContainer",
					"parentName": "MessageHeaderContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailRecepientWrapContainer",
						"markerValue": "EmailRecepientWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["emailRecepientWrap"],
						"items": []
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "EmailRecepientLabel",
					"parentName": "EmailRecepientWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailRecepientLabel",
						"labelClass": ["emailRecepientLabel"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.ToString"
						}
					},
					"index": 2
				},
				{
					"operation": "insert",
					"name": "EmailRecepient",
					"parentName": "EmailRecepientWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailRecepient",
						"labelClass": ["emailRecepient"],
						"itemType": this.Terrasoft.ViewItemType.LABEL
					},
					"index": 3
				},
				{
					"operation": "insert",
					"name": "EmailSenderWrapContainer",
					"parentName": "MessageHeaderContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailSenderWrapContainer",
						"markerValue": "EmailSenderWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["emailSenderWrap"],
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "EmailSenderLabel",
					"parentName": "EmailSenderWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailSenderLabel",
						"labelClass": ["emailSenderLabel"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.FromString"
						}
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "EmailSender",
					"parentName": "EmailSenderWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailSender",
						"labelClass": ["emailSender"],
						"itemType": this.Terrasoft.ViewItemType.LABEL
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "AdditionalInfoWrapContainer",
					"parentName": "MessageHeaderContainer",
					"propertyName": "items",
					"values": {
						"id": "AdditionalInfoWrapContainer",
						"markerValue": "AdditionalInfoWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["additionalInfoWrap"],
						"items": []
					},
					"index": 2
				},
				{
					"operation": "insert",
					"name": "CreationInfoWrapContainer",
					"parentName": "AdditionalInfoWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "CreationInfoWrapContainer",
						"markerValue": "CreationInfoWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["creationInfoWrap"],
						"items": []
					},
					"index": 3
				},
				{
					"operation": "insert",
					"name": "CreationInfo",
					"parentName": "CreationInfoWrapContainer",
					"propertyName": "items",
					"values": {
						"id": "CreationInfo",
						"labelClass": ["creationInfoLabel"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "getCreationInfo"
						}
					},
					"index": 4
				},

				//NEW DIFF

				{
					"operation": "insert",
					"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
					"name": "HistoryV2CreatedByLink",
					"parentName": "HeaderCenterContainerTopLine",
					"propertyName": "items",
					"values": {
						"classes": {
							"hyperlinkClass": ["link", "createdByLink", "label-url", "label-link"]
						},
						"caption": {
							"bindTo": "getCreatedByName"
						},
						"markerValue": "CreatedByLink"
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailRecepientInfo",
					"parentName": "HeaderCenterContainerTopLine",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["inline-container", "overflow-hidden"],
						"items": []
					},
					"index": 2
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailRecepientsContainer",
					"parentName": "HistoryV2EmailRecepientInfo",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["emailRecepients-container"],
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailRecepientLabel",
					"parentName": "HistoryV2EmailRecepientInfo",
					"propertyName": "items",
					"values": {
						"id": "EmailRecepientLabel",
						"labelClass": ["emailRecepientLabel header-text grayed-text"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.ToString"
						}
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailRecepient",
					"parentName": "HistoryV2EmailRecepientsContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailRecepient",
						"labelClass": ["emailRecepient header-text"],
						"itemType": this.Terrasoft.ViewItemType.LABEL
					},
					"index": 1
				}

			]/**SCHEMA_DIFF*/
		};
	}
);
