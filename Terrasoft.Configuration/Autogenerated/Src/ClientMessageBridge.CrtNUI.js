﻿/**
 * Parent: BaseMessageBridge
 */
define("ClientMessageBridge", [], function() {
	return {
		attributes: {
			/**
			 * Name for the local storage.
			 */
			"LocalStoreName": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": "SocketMsgHistory"
			},
			/**
			 * Instance of the Terrasoft.LocalStore.
			 */
			"LocalStore": {
				"dataValueType": Terrasoft.DataValueType.CUSTOM_OBJECT
			}
		},
		methods: {
			/**
			 * @inheritdoc Terrasoft.BaseMessageBridge#init
			 * @override
			 */
			init: function() {
				this.callParent(arguments);
				var localStore = this.Ext.create("Terrasoft.LocalStore", {
					storeName: this.get("LocalStoreName"),
					isCache: true
				});
				this.set("LocalStore", localStore);
			},

			/**
			 * @inheritdoc Terrasoft.BaseMessageBridge#saveMessageToHistory
			 * @override
			 */
			saveMessageToHistory: function(sandboxMessageName, webSocketBody) {
				var localStore = this.get("LocalStore");
				var messageLocalStoreKey = this.getMessageLocalStoreKey(sandboxMessageName);
				var savedMessages = this.getMessagesFromHistory(sandboxMessageName);
				savedMessages.push({
					name: sandboxMessageName,
					msg: webSocketBody
				});
				localStore.setItem(messageLocalStoreKey, savedMessages);
			},

			/**
			 * @inheritdoc Terrasoft.BaseMessageBridge#getMessagesFromHistory
			 * @override
			 */
			getMessagesFromHistory: function(sandboxMessageName) {
				var localStore = this.get("LocalStore");
				var messageLocalStoreKey = this.getMessageLocalStoreKey(sandboxMessageName);
				return localStore.getItem(messageLocalStoreKey) || [];
			},

			/**
			 * @inheritdoc Terrasoft.BaseMessageBridge#getMessagesFromHistory
			 * @override
			 */
			deleteSavedMessages: function(sandboxMessageName) {
				var localStore = this.get("LocalStore");
				var messageLocalStoreKey = this.getMessageLocalStoreKey(sandboxMessageName);
				localStore.removeItem(messageLocalStoreKey);
			},

			/**
			 * Returns local storage key for the sandbox message.
			 * @private
			 * @param sandboxMessageName Sandbox message name.
			 * @return {String} Local storage key for the sandbox message.
			 */
			getMessageLocalStoreKey: function(sandboxMessageName) {
				return sandboxMessageName + this.get("LocalStoreName");
			}
		}
	};
});
