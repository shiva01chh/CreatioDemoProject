﻿define("IFramePageLoader", ["ext-base", "terrasoft", "BaseViewModule", "AngularPostMessageConnector"], function() {

	Ext.define("Terrasoft.configuration.IFramePageLoader", {
		extend: "Terrasoft.BaseViewModule",
		alternateClassName: "Terrasoft.IFramePageLoader",

		messageChannel: null,
		messageChannelName: '',

		requestConfigMessageName: '',
		responseConfigMessageName: '',

		initialConfig: null,

		/**
		 * @inheritDoc
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			this._registerMessages();
			this.messageChannel = Ext.create('Terrasoft.AngularPostMessageConnector', {
				channelName: this.messageChannelName,
				target: window.parent
			});
		},

		/**
		 * @private
		 */
		_registerMessages: function () {
			const messages = this.getSandboxMessages();
			this.sandbox.registerMessages(messages);
		},

		/**
		 * @private
		 */
		_unRegisterMessages: function () {
			const messages = this.getSandboxMessages();
			this.sandbox.unRegisterMessages(messages);
		},

		/**
		 * @private
		 */
		_isStructureExplorerExist: function(target) {
			const structureExplorerElName = 'ts-structure-explorer'
			return target.getElementsByTagName?.(structureExplorerElName).length > 0 ||
				target?.tagName?.toLowerCase() === structureExplorerElName;
		},

		/**
		 * @private
		 */
		_getModalOpening: function(target, oldValue) {
			return !this.isPopupOpened && (this._isStructureExplorerExist(target) ||
				target?.classList?.contains('ts-modalbox-opened') ||
				oldValue?.includes('ts-messagebox-box'));
		},

		/**
		 * @private
		 */
		_getModalClosing: function(target, oldValue) {
			return this.isPopupOpened && (target?.classList?.contains('close') ||
				oldValue?.includes('ts-modalbox-opened') ||
				(target?.className === 'ts-messagebox-cover' && target?.style?.display === 'none') ||
				(this._isStructureExplorerExist(target) && oldValue?.includes('display: none')));
	 	},

		/**
		 * @protected
		 */
		loadContent: Terrasoft.emptyFn,
		
		/**
		 * @protected
		 */
		getSandboxMessages: function() {
			return {
				"LoadModule": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RefreshCacheHash": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"NavigationModuleLoaded": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"HistoryStateChanged": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"GetHistoryState": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"PushHistoryState": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"PageLoaded": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"ModalOpening": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"ModalClosing": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"ESCPressed": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				}
			};
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		initHomePage: function(callback, scope) {
			Ext.callback(callback, scope);
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		loadMainPanelsModules: Terrasoft.emptyFn,

		/**
		 * @protected
		 */
		subscribeSandboxMessages: function() {
			const moduleId = this.getLoaderModuleId();
			this.sandbox.subscribe("PageLoaded", () => {
				this.messageChannel.sendMessage("DesignerLoaded");
			}, this, [moduleId]);
			this.sandbox.subscribe("ModalOpening", () => {
				this.messageChannel.sendMessage("ModalOpening");
			}, this, [moduleId]);
			this.sandbox.subscribe("ModalClosing", () => {
				this.messageChannel.sendMessage("ModalClosing");
			}, this, [moduleId]);
		},

		/**
		 * @abstract
		 */
		getLoaderModuleId: Terrasoft.abstractFn,

		/**
		 * @inheritDoc
		 * @overridden
		 */
		init: function (callback, scope) {
			this.subscribeSandboxMessages();
			this.callParent([() => {
				this.messageChannel.connect(result => {
					if (result === false) {
						throw Ext.create("Terrasoft.InvalidOperationException");
					}
					this.initFrameConfig(callback, scope);
				});
				document.onkeydown = this.onKeyDown.bind(this);
			}]);
		},

		/**
		 * @protected
		 */
		initFrameConfig: function (callback, scope) {
			this.messageChannel.on(this.responseConfigMessageName, function(config) {
				this.initialConfig = config;
				Ext.callback(callback, scope);
			}, this);
			this.messageChannel.sendMessage(this.requestConfigMessageName);
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		onDestroy: function () {
			this._unRegisterMessages();
			this.callParent(arguments);
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			this.loadContent(renderTo);
			this.observeBodyMutations();
		},

		/**
		 * On document key down.
		 * @param {Event} event 
		 */
		onKeyDown: function(event) {
			if(event.key === 'Escape') {
				this.messageChannel.sendMessage('ESCPressed');
			}
		},

		/**
		 * @protected
		 */
		observeBodyMutations: function () {
			this.mutationObserver = new MutationObserver((mutations) => {
				if (!mutations) {
					return;
				}
				for (let mutation of mutations) {
					const { target, oldValue } = mutation;
					const isModalOpening = this._getModalOpening(target, oldValue);
					const isModalClosing = this._getModalClosing(target, oldValue);

					if (isModalOpening) {
						this.messageChannel.sendMessage("ModalOpening");
						this.isPopupOpened = true;
						break;
					} else if (isModalClosing) {
						this.messageChannel.sendMessage("ModalClosing");
						this.isPopupOpened = false;
						break;
					}
				}
			});
			this.mutationObserver.observe(document.querySelector('body'), {
				characterData: true,
				attributeOldValue: true,
				subtree: true,
			});
		},

	});
	
	return Terrasoft.IFramePageLoader;
 });
