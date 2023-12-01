﻿Terrasoft.configuration.Structures["ConfigurationViewModule"] = {innerHierarchyStack: ["ConfigurationViewModule"]};
define("ConfigurationViewModule", [
	"ext-base",
	"sandbox",
	"terrasoft",
	"ConfigurationViewModuleResources",
	"LookupUtilities",
	"ViewModuleHelper",
	"ConfigurationConstants",
	"ConfigurationEnums",
	"LeftPanelUtilitiesV2",
	"ModalBox",
	"WelcomeScreenModule",
	"SspReadOnlyModeModule",
	"BaseViewModule",
	"BaseSchemaModuleV2",
	"NavigationHelper",
	"css!LeftPanelCSS",
	"WindowUnloadWatcher",
	"ImageView"
], function(
	Ext,
	sandbox,
	Terrasoft,
	resources,
	LookupUtilities,
	ViewModuleHelper,
	ConfigurationConstants,
	ConfigurationEnums,
	LeftPanelUtilities,
	ModalBox) {

			/**
			 * @class Terrasoft.configuration.DemoButtons
			 * Class creates demo buttons.
			 */
			Ext.define("Terrasoft.configuration.DemoButtons", {
				extend: "Terrasoft.BaseViewModule",
				alternateClassName: "Terrasoft.DemoButtons",

				/**
				 * Configuration object for the demo buttons.
				 * @type {Object[]}
				 */
				buttonsConfig: null,

				/**
				 * Configuration object for the demo buttons with system setting.
				 * @type {Object[]}
				 */
				buttonsSysSettingConfig: null,

				/**
				 * Distance between buttons.
				 * @type {Number}
				 */
				separatorSize: 5,

				/**
				 * Demo buttons classes.
				 * @type {String[]}
				 */
				buttonClasses: ["demo-btn"],

				/**
				 * Opens window with order of the pesentation.
				 * @protected
				 * @virtual
				 */
				openBuyNowWindow: function() {
					window.open(resources.localizableStrings.BuyNowUrl);
				},

				/**
				 * Opens browser tab with the product trial version.
				 * @protected
				 * @virtual
				 */
				openTrialWindow: function(value) {
					window.open(value);
				},

				/**
				 * Generates string with parameters for the chat dialog.
				 * @protected
				 * @virtual
				 */
				createOnlineHelpButtonParameters: function() {
					var parameters = {
						ttl: document.title && encodeURI(document.title.substring(0, 255)),
						url: encodeURI(window.location.href),
						referrer: encodeURI(encodeURI(document.referrer)),
						cd: window.screen.colorDepth,
						rh: screen.height,
						rw: screen.width
					};
					var parametersArray = [resources.localizableStrings.OnlineHelpUrl];
					Terrasoft.each(parameters, function(parameter, name) {
						parametersArray.push(name + "=" + parameter);
					}, this);
					return parametersArray.join("&");
				},

				/**
				 * Opens chat dialog with the manager.
				 * @protected
				 * @virtual
				 */
				openOnlineHelpWindow: function() {
					/* jshint ignore:start */
					//jscs:disable
					jivo_api.open();
					//jscs:enable
					/* jshint ignore:end */
				},

				/**
				 * Finds and returns current culture.
				 * @protected
				 * @virtual
				 * @return {String} Current culture.
				 */
				getCurrentCulture: function() {
					var cachedSettings = Terrasoft.SysSettings.cachedSettings;
					return cachedSettings.PrimaryCulture.displayValue;
				},

				/**
				 * Creates and shows demo button based on configuration object.
				 * @protected
				 * @virtual
				 * @param {Object} config Configuration object for the button.
				 */
				createDemoButton: function(config) {
					var culture = this.getCurrentCulture();
					var cultureParts = culture.split("-");
					var currentLocalizationImageName = config.localizableImagesPrefix + cultureParts[0].toUpperCase();
					var imageConfig = resources.localizableImages[currentLocalizationImageName];
					var wrapperClass = config.wrapperClass ?
							this.buttonClasses.concat(config.wrapperClass) : this.buttonClasses;
					var element = Ext.create("Terrasoft.Button", {
						renderTo: Ext.getBody(),
						id: config.id,
						imageConfig: imageConfig,
						classes: {
							wrapperClass: wrapperClass,
							imageClass: [config.imageClassPrefix + cultureParts[0]]
						},
						click: {bindTo: config.click}
					});
					element.bind(this);
				},

				/**
				 * Initializes Jivo scripts.
				 * @private
				 */
				initJivoScripts: function() {
					var widgetId = resources.localizableStrings.JivoWidgetId;
					var jivoScript = document.createElement("script");
					jivoScript.type = "text/javascript";
					jivoScript.async = true;
					jivoScript.id = widgetId;
					jivoScript.src = "//code.jivosite.com/script/widget/" + widgetId;
					var scriptEl = document.getElementsByTagName("script")[0];
					scriptEl.parentNode.insertBefore(jivoScript, scriptEl);
				},

				/**
				 * Jivo load scripts callback.
				 * @private
				 */
				jivoOnLoadCallback: function() {
					var hiddenDemoButtons = Ext.select(".demo-btn.hidden-demo-btn");
					if (hiddenDemoButtons) {
						var demoBtnWrapper = hiddenDemoButtons.first();
						demoBtnWrapper.removeCls("hidden-demo-btn");
					}
					this.updateButtonsPosition();
				},

				/**
				 * Initialize online help.
				 * @private
				 */
				initOnlineHelpWindow: function() {
					/* jshint ignore:start */
					window.jivo_onLoadCallback = this.jivoOnLoadCallback.bind(this);
					this.initJivoScripts();
					/* jshint ignore:end */
				},

				/*
				 * Initializes the initial data.
				 * @protected
				 */
				init: function() {
					this.mixins.customEvent.init.call(this);
					this.initButtonsConfig();
					this.initButtons();
				},
				/**
				 * Creates demo buttons configuration.
				 */
				initButtonsConfig: function() {
					if (!this.buttonsConfig) {
						this.buttonsConfig = [];
					}
					this.buttonsConfig.push({
						localizableImagesPrefix: "BuyNow",
						id: "buy-now-btn",
						imageClassPrefix: "buy-now-btn-img-",
						click: "openBuyNowWindow"
					});
					this.buttonsConfig.push({
						localizableImagesPrefix: "OnlineHelp",
						id: "online-help-btn",
						imageClassPrefix: "online-help-btn-img-",
						click: "openOnlineHelpWindow",
						wrapperClass: ["hidden-demo-btn"]
					});
					if (!this.buttonsSysSettingConfig) {
						this.buttonsSysSettingConfig = [];
					}
					this.buttonsSysSettingConfig.push({
						localizableImagesPrefix: "Trial",
						id: "trial-btn",
						imageClassPrefix: "trial-btn-img-",
						position: "0",
						sysSetting: "TrialUrl",
						action: this.openTrialWindow
					});
				},

				/**
				 * Creates demo buttons and actualize position.
				 */
				initButtons: function() {
					Terrasoft.chain(
							this.prepareButtonsConfig,
							function(next) {
								Terrasoft.each(this.buttonsConfig, this.createDemoButton, this);
								next();
							},
							function(next) {
								Ext.EventManager.addListener(window, "resize", this.updateButtonsPosition, this);
								next();
							},
							this.updateButtonsPosition, this);
				},

				/**
				 * Prepares configuration for the demo buttons.
				 * @param {Function} callback Callback function.
				 */
				prepareButtonsConfig: function(callback) {
					var iterator = this.buttonsSysSettingConfig.length;
					Terrasoft.each(this.buttonsSysSettingConfig, function(item) {
						Terrasoft.chain(
								function(next) {
									Terrasoft.SysSettings.querySysSettingsItem(item.sysSetting, function(value) {
										next(value);
									});
								},
								function(next, value) {
									if (value) {
										var prepareButton = {};
										var onClickName = item.localizableImagesPrefix + "Click";
										this[onClickName] = function() {
											item.action(value);
										};
										prepareButton.localizableImagesPrefix = item.localizableImagesPrefix;
										prepareButton.id = item.id;
										prepareButton.imageClassPrefix = item.imageClassPrefix;
										prepareButton.click = onClickName;
										this.buttonsConfig.splice(item.position, 0, prepareButton);
									}
									next();
								},
								function() {
									if (--iterator === 0) {
										callback();
									}
								}, this);
					}, this);
				},

				/**
				 * Actualizes buttons position.
				 * @protected
				 * @virtual
				 */
				updateButtonsPosition: function() {
					var buttons = this.buttonsConfig.map(function(buttonConfig) {
						var element = Ext.getCmp(buttonConfig.id);
						return element.getWrapEl();
					}, this);
					var buttonsWidthSum = 0;
					Terrasoft.each(buttons, function(button) {
						buttonsWidthSum += button.dom.offsetWidth;
					}, this);
					var buttonPosition =
							(window.innerWidth - buttonsWidthSum - (this.separatorSize * (buttons.length - 1))) / 2;
					Terrasoft.each(buttons, function(button) {
						button.setStyle("left", buttonPosition + "px");
						buttonPosition += (button.dom.offsetWidth + this.separatorSize);
					}, this);
				}
			});

			/**
			 * @class Terrasoft.configuration.ViewModule
			 * Class of the visual view module.
			 */
			var viewModule = Ext.define("Terrasoft.configuration.ConfigurationViewModule", {
				extend: "Terrasoft.BaseViewModule",
				alternateClassName: "Terrasoft.ConfigurationViewModule",

				Ext: null,
				sandbox: null,
				Terrasoft: null,

				mixins: {
					customEvent: "Terrasoft.mixins.CustomEventDomMixin"
				},

				/**
				 * Default home page schema.
				 * @type {String}
				 */
				defaultIntroPage: "SimpleIntro",

				/**
				 * Demo buttons.
				 * @type {Terrasoft.configuration.DemoButtons}
				 */
				demoButtons: null,

				diff: [],

				/**
				 * Processes response of the system settings loading result.
				 * @protected
				 * @overridden
				 * @param {Object[]} values System settings value.
				 */
				onSysSettingsResponse: function(values) {
					this.callParent(arguments);
					if (values.ShowDemoLinks) {
						this.prepareDemoLinkButtons();
					}
				},

				/**
				 * Creates and shows "Show presentation" and "On-line chat" buttons.
				 * @protected
				 * @virtual
				 */
				prepareDemoLinkButtons: function() {
					this.demoButtons = this.Ext.create("Terrasoft.DemoButtons");
					this.demoButtons.init();
				},

				/**
				 * Checks, that SspReadOnlyModeModule should be rendered.
				 * @protected
				 * @returns {boolean} True, if module should be rendered.
				 */
				isNeedToShowReadOnlyButton: function() {
					return this.Terrasoft.CurrentUser.userType === this.Terrasoft.UserType.SSP &&
						this.Terrasoft.isSspInReadonlyMode;
				},

				/**
				 * Loads SspReadOnlyModeModule.
				 * @protected
				 */
				loadReadOnlyModule: function() {
					var moduleName = "SspReadOnlyModeModule";
					var moduleId = this.sandbox.id + "_" + moduleName;
					this.sandbox.loadModule(moduleName, {
						id: moduleId,
						renderTo: Ext.getBody()
					});
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.diff = this._getDiff();
					this._tryRedirectToFreedomUI();
					this.callParent([
						function() {
							this.initIntroPage();
							if (Ext.isFunction(ViewModuleHelper.initSettings)) {
								ViewModuleHelper.initSettings();
							}
							LeftPanelUtilities.initCollapsedState();
							if (this.isNeedToShowReadOnlyButton()) {
								this.loadReadOnlyModule();
							}
							callback.call(scope);
						}, this
					]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaModule#render
				 * @protected
				 * @overridden
				 */
				render: function() {
					this.callParent(arguments);
					var demoButtons = this.demoButtons;
					if (demoButtons) {
						demoButtons.initOnlineHelpWindow();
					}
					this._addClass();
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaModule#getMessages
				 * @protected
				 * @overridden
				 */
				getMessages: function() {
					const messages = {
						"NavigateTo": {
							mode: Terrasoft.MessageMode.BROADCAST,
							direction: Terrasoft.MessageDirectionType.SUBSCRIBE
						}
					};
					const parentMessages = this.callParent(arguments);
					return Ext.apply(messages, parentMessages);
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#loadNonVisibleModules
				 * @overridden
				 */
				loadNonVisibleModules: function() {
					this.callParent(arguments);
					var sandbox = this.sandbox;
					sandbox.loadModule("ProcessListener");
					sandbox.loadModule("HotkeysModule");
					sandbox.loadModule("SyncModule");
					sandbox.loadModule("MiniPageListener");
					sandbox.loadModule("ImportNotifierClientModule");
					sandbox.loadModule("AsyncReportNotifier");
					sandbox.loadModule("BaseSchemaModuleV2", {
						id: this.sandbox.id + "_clientMessageBridge",
						instanceConfig: {
							generateViewContainerId: false,
							useHistoryState: false,
							schemaName: "ClientMessageBridge",
							isSchemaConfigInitialized: true
						}
					});
					sandbox.loadModule("OutdatedModuleWatcher");
					sandbox.loadModule("ConfigurationBuildWatcher");
					sandbox.loadModule("BaseSchemaModuleV2", {
						id: this.sandbox.id + "_multiDeleteResultModule",
						instanceConfig: {
							generateViewContainerId: false,
							useHistoryState: false,
							schemaName: "MultiDeleteResultSchema",
							isSchemaConfigInitialized: true
						},
						keepAlive: true
					});
					sandbox.loadModule("BaseSchemaModuleV2", {
						id: this.sandbox.id + "_appLoadWatcherModule",
						instanceConfig: {
							generateViewContainerId: false,
							useHistoryState: false,
							schemaName: "AppLoadWatcherSchema",
							isSchemaConfigInitialized: true
						},
						keepAlive: true
					});
					sandbox.loadModule("BaseSchemaModuleV2", {
						id: this.sandbox.id + "_windowUnloadWatcherModule",
						instanceConfig: {
							generateViewContainerId: false,
							useHistoryState: false,
							schemaName: "WindowUnloadWatcher",
							isSchemaConfigInitialized: true
						},
						keepAlive: true
					});
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#subscribeMessages
				 * @overridden
				 */
				subscribeMessages: function() {
					this.callParent(arguments);
					const sandbox = this.sandbox;
					sandbox.subscribe("SideBarModuleDefInfo", this.onSideBarModuleDefInfo, this);
					sandbox.subscribe("ShowHideRightSidePanel", this.onShowHideRightPanel, this);
					sandbox.subscribe("SideBarVisibilityChanged", this.onSideBarVisibilityChanged, this);
					const navigationHelper = this.Ext.create("Terrasoft.NavigationHelper", {
						Ext: this.Ext,
						sandbox: sandbox
					});
					sandbox.subscribe("NavigateTo", navigationHelper.navigateTo, navigationHelper);
				},

				/**
				 * Initializes intro page.
				 * @protected
				 */
				initIntroPage: function() {
					this.defaultIntroPage = Terrasoft.configuration.defaultIntroPageName || this.defaultIntroPage;
				},

				/**
				 * Generates configuration for the left panel module.
				 * @protected
				 * @virtual
				 */
				onSideBarModuleDefInfo: function() {
					var sideBarConfig = this.sandbox.publish("GetSideBarConfig");
					if (sideBarConfig) {
						this.sandbox.publish("PushSideBarModuleDefInfo", sideBarConfig.items);
					} else {
						var me = this;
						ViewModuleHelper.getSideBarDefaultConfig(function(config) {
							var menuItems = Ext.isObject(config) ? config.items : config;
							me.sandbox.publish("PushSideBarModuleDefInfo", menuItems);
						});
					}
				},

				/**
				 * Changes css class of the element.
				 * @protected
				 * @virtual
				 * @param {String} elementName Element name.
				 * @param {String} oldCssClass Old css class.
				 * @param {String} cssClass New css class.
				 */
				changeItemClass: function(elementName, oldCssClass, cssClass) {
					var element = Ext.get(elementName);
					if (element.hasCls(oldCssClass)) {
						element.removeCls(oldCssClass);
						element.addCls(cssClass);
					}
				},

				/**
				 * Shows or hides left panel.
				 * @protected
				 * @virtual
				 * @param {Object} config Configuration of the action.
				 * @param {Boolean} config.forceShow Flag of the right panel state. If true panel will show,
				 * if false panel will hide.
				 */
				onShowHideRightPanel: function(config) {
					var forceShow = config && config.forceShow;
					var centerPanelClasses = ["center-panel-content", "default-center-panel-content"];
					var rightPanelClasses = ["right-panel", "default-right-panel"];
					var mainHeaderEl = Ext.get("mainHeaderContainer");
					var centerPanelContainerEl = Ext.get("centerPanelContainer");
					var communicationPanelEl = Ext.get("communicationPanel");
					if (Ext.isEmpty(mainHeaderEl) || Ext.isEmpty(centerPanelContainerEl) || Ext.isEmpty(communicationPanelEl)) {
						Terrasoft.delay(this.onShowHideRightPanel, this, 500, [config]);
						return;
					}
					mainHeaderEl.removeCls("opened-right-panel");
					centerPanelContainerEl.removeCls("opened-right-panel");
					communicationPanelEl.removeCls("opened-right-panel");
					if (forceShow) {
						rightPanelClasses.reverse();
						centerPanelClasses.reverse();
						mainHeaderEl.addCls("opened-right-panel");
						communicationPanelEl.addCls("opened-right-panel");
						centerPanelContainerEl.addCls("opened-right-panel");
					}
					this.changeItemClass("rightPanel", rightPanelClasses[0], rightPanelClasses[1]);
					this.changeItemClass("centerPanel", centerPanelClasses[0], centerPanelClasses[1]);
					this.sandbox.publish("ChangeGridUtilitiesContainerSize");
				},

				/**
				 * Hides or loads module into the specified panel.
				 * @pretected
				 * @virtual
				 * @param {Object} args Parameters for the changes visibility.
				 * @param {String} args.panel Panel name.
				 * @param {String} args.moduleName Module name.
				 */
				onSideBarVisibilityChanged: function(args) {
					var panelName = args.panel || "centerPanel";
					if (args.moduleName) {
						this.sandbox.loadModule(args.moduleName, {
							renderTo: panelName
						});
					} else {
						var panel = Ext.getCmp(panelName);
						var panelEl = panel.getWrapEl().el;
						panelEl.setVisibilityMode(Ext.dom.AbstractElement.DISPLAY);
						panelEl.setVisible(false);
					}
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#onLoadModule
				 * @overridden
				 */
				onLoadModule: function(config) {
					if (config.moduleName === "ProcessExecute") {
						this.loadProcessModule();
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * Loads lookup module with the process list for start.
				 * @protected
				 * @virtual
				 */
				loadProcessModule: function() {
					var vwSysProcessFilters = Terrasoft.createFilterGroup();
					vwSysProcessFilters.name = "vwSysProcessFiler";
					var sysWorkspaceFilter = Terrasoft.createColumnFilterWithParameter(
							Terrasoft.ComparisonType.EQUAL, "SysWorkspace",
							Terrasoft.SysValue.CURRENT_WORKSPACE.value);
					vwSysProcessFilters.addItem(sysWorkspaceFilter);
					var isMaxVersionFilter = Terrasoft.createColumnFilterWithParameter(
							Terrasoft.ComparisonType.EQUAL, "IsMaxVersion", 1);
					vwSysProcessFilters.addItem(isMaxVersionFilter);
					var businessProcessTagFilter = Terrasoft.createColumnFilterWithParameter(
							Terrasoft.ComparisonType.EQUAL, "TagProperty",
							ConfigurationConstants.SysProcess.BusinessProcessTag);
					vwSysProcessFilters.addItem(businessProcessTagFilter);
					var config = {
						entitySchemaName: "VwSysProcess",
						mode: "processMode",
						captionLookup: resources.localizableStrings.ProcessPageCaption,
						multiSelect: false,
						columnName: "Caption",
						filters: vwSysProcessFilters,
						commandLineEnabled: true
					};
					var handler = Terrasoft.emptyFn;
					LookupUtilities.OpenLookupPage(this.sandbox, {config: config, handler: handler}, this, null, false);
				},

				/**
				 * Loads the welcome window when log in.
				 * @private
				 */
				loadWelcomeScreen: function() {
					var isFirstLogin = this.Terrasoft.isFirstLogin;
					if (!isFirstLogin) {
						return;
					}
					this.Terrasoft.SysSettings.querySysSettings([
						"UseWelcomeScreen", "BuildType"
					], function(sysSettings) {
						var useWelcomeScreen = sysSettings.UseWelcomeScreen;
						if (!useWelcomeScreen) {
							return;
						}
						var buildType = sysSettings.BuildType;
						if (buildType.value === ConfigurationConstants.BuildType.Public) {
							this.loadWelcomeScreenModule();
						} else {
							this.Terrasoft.require(["profile!WelcomeScreenModule"], function(profile) {
								if (profile && profile.isShown) {
									return;
								}
								this.loadWelcomeScreenModule();
								this.Terrasoft.saveUserProfile("WelcomeScreenModule", {isShown: true});
							}, this);
						}
					}, this);
				},

				/**
				 * Loads module of the welcome screen.
				 * @private
				 */
				loadWelcomeScreenModule: function() {
					var config = {
						minWidth: 100,
						minHeight: 100,
						boxClasses: ["welcome-screen-modal-box"]
					};
					var moduleName = "WelcomeScreenModule";
					var moduleId = this.sandbox.id + "_" + moduleName;
					var renderTo = ModalBox.show(config, function() {
						this.sandbox.unloadModule(moduleId, renderTo);
					}.bind(this));
					this.sandbox.loadModule(moduleName, {
						id: moduleId,
						renderTo: renderTo
					});
				},

				/**
				 * @private
				 */
				_addClass: function() {
					if (Terrasoft.isAngularHost) {
						const centerPanelContainerEl = Ext.get("centerPanelContainer");
						centerPanelContainerEl.addCls("is-angular-host");
					}
				},

				/**
				 * @private
				 */
				_getDiff: function() {
					const diff = [];
					if (!Terrasoft.isAngularHost) {
						diff.push( {
							"operation": "insert",
							"name": "leftPanel",
							"values": {
								"itemType": Terrasoft.ViewItemType.MODULE,
								"moduleName": "SideBarModule",
								"classes": {
									"wrapClassName": ["left-panel", "left-panel-scroll", "fixed"]
								}
							}
						}, {
							"operation": "insert",
							"name": "mainHeader",
							"values": {
								"itemType": Terrasoft.ViewItemType.MODULE,
								"moduleName": "MainHeaderModule",
							}
						});
					}
					if (Terrasoft.isAngularHost) {
						diff.push({
							"operation": "insert",
							"name": "mainHeader",
							"values": {
								"itemType": Terrasoft.ViewItemType.MODULE,
								"moduleName": "MainHeader8xModule",
							}
						});
					}
					diff.push({
						"operation": "insert",
						"name": "centerPanelContainer",
						"values": {
							"itemType": Terrasoft.ViewItemType.CONTAINER,
							"wrapClass": ["center-panel"],
							"id": "centerPanelContainer",
							"selectors": {"wrapEl": "#centerPanelContainer"},
							"items": []
						}
					}, {
						"operation": "move",
						"name": "centerPanel",
						"parentName": "centerPanelContainer",
						"propertyName": "items",
						"index": 0
					}, );
					if (!Terrasoft.isAngularHost) {
						diff.push({
							"operation": "insert",
							"name": "communicationPanel",
							"values": {
								"itemType": Terrasoft.ViewItemType.MODULE,
								"moduleName": "CommunicationPanelModule",
								"classes": {
									"wrapClassName": ["communication-panel", "communication-panel-scroll", "fixed"]
								}
							}
						}, {
							"operation": "insert",
							"parentName": "centerPanelContainer",
							"propertyName": "items",
							"name": "rightPanel",
							"index": 1,
							"values": {
								"itemType": Terrasoft.ViewItemType.MODULE,
								"moduleName": "RightSideBarModule",
								"classes": {
									"wrapClassName": ["default-right-panel", "fixed"]
								}
							}
						});
					}
					return diff;
				},

				/**
				 * @private
				 */
				_tryRedirectToFreedomUI: function() {
					const search = location.search?.toLowerCase();
					if (search?.indexOf("classicui") > 0) {
						return;
					}
					const hash = location.hash;
					const hashArray = hash?.split("/") || [];
					if (!this._tryRedirectToFreedomUIFormPage(hashArray)) {
						this._tryRedirectToFreedomUIListPage(hashArray);
					}
				},

				/**
				 * @private
				 */
				_tryRedirectToFreedomUIFormPage: function(hashArray) {
					if (Terrasoft.Features.getIsEnabled("DisableRedirectToFreedomUIFormPage")) {
						return false;
					}
					const cardState = ConfigurationEnums.CardStateV2
					if (hashArray.length > 3 && (hashArray[2] === cardState.EDIT || hashArray[2] === cardState.COPY)) {
						const editPage = hashArray[1];
						const pageInfo = this._findFreedomUIFormPage(editPage);
						if (pageInfo && pageInfo.cardSchema !== editPage) {
							this._replaceHash(hashArray, pageInfo.cardModuleName, pageInfo.cardSchema);
							return true;
						}
					}
					return false;
				},

				/**
				 * @private
				 */
				_findFreedomUIFormPage: function(classicUIPage) {
					const structure = Terrasoft.ModuleUtils.getEntityStructureBySchemaName(classicUIPage);
					const entityStructure = Terrasoft.ModuleUtils.getEntityStructureByName(structure?.entitySchemaName);
					if (entityStructure?.page8X && entityStructure.pages?.length) {
						const pages = entityStructure.pages;
						const existPage = pages.find((x) => x.cardSchema === classicUIPage);
						const page = existPage || pages[0]
						return {
							cardSchema: page.cardSchema,
							cardModuleName: page.cardModuleName || entityStructure.cardModuleName
						}
					}
					return null;
				},

				/**
				 * @private
				 */
				_tryRedirectToFreedomUIListPage: function(hashArray) {
					if (Terrasoft.Features.getIsDisabled("EnableRedirectToFreedomUIListPage")) {
						return false;
					}
					if (hashArray.length > 1 ) {
						const sectionPage = hashArray[1];
						const pageInfo = this._findFreedomUIListPage(sectionPage);
						if (pageInfo && sectionPage !== pageInfo.sectionSchema) {
							this._replaceHash(hashArray, pageInfo.sectionModule, pageInfo.sectionSchema);
							return true;
						}
					}
					return false;
				},

				/**
				 * @private
				 */
				_replaceHash: function(hashArray, moduleName, schemaName) {
					hashArray[0] = "#" + moduleName;
					hashArray[1] = schemaName;
					location.hash = hashArray.join("/");
				},

				/**
				 * @private
				 */
				_findFreedomUIListPage: function(classicUISection) {
					const structure = Terrasoft.ModuleUtils.getModuleStructureBySectionSchema(classicUISection);
					const moduleStructure = Terrasoft.ModuleUtils.getModuleStructure(structure?.entitySchemaName);
					if (moduleStructure?.section8X) {
						return {
							sectionModule: moduleStructure.sectionModule,
							sectionSchema: moduleStructure.sectionSchema
						};
					}
					return null;
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#getHomeModulePath
				 * @overridden
				 */
				getHomeModulePath: function() {
					return this.Terrasoft.combinePath(this.homeModule, this.defaultIntroPage);
				},

				/**
				 * @inheritDoc Terrasoft.configuration.BaseViewModule#initHistoryState
				 * @overridden
				 */
				initHistoryState: function() {
					if (Terrasoft.isAngularHost) {
						this.mixins.customEvent.publish.call(this, "ConfigurationViewModuleLoaded");
					}
					this.callParent(arguments);
				},
			});
			return viewModule;

		});


