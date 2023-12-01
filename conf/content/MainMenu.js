﻿Terrasoft.configuration.Structures["MainMenu"] = {innerHierarchyStack: ["MainMenu"]};
define("MainMenu", ["ext-base", "terrasoft", "sandbox", "MainMenuResources", "SysModule", "SysModuleFolder",
		"LocalizationUtilities", "ModuleUtils", "GeneratedWebFormUtilities", "MaskHelper", "ServiceHelper",
		"RightUtilities", "PackageHelper", "ConfigurationConstants"],
	function(Ext, Terrasoft, sandbox, resources, SysModule, SysModuleFolder, LocalizationUtilities, ModuleUtils,
		GeneratedWebFormUtilities, MaskHelper, ServiceHelper, RightUtilities, PackageHelper, ConfigurationConstants) {

		var container;
		var isDemoBuild;

		var getLabelConfig = function(cfg) {
			var config = {
				className: "Terrasoft.Label"
			};
			return Ext.apply(config, cfg);
		};

		var getContainerConfig = function(id, stylesClass) {
			return {
				className: "Terrasoft.Container",
				classes: {
					wrapClassName: stylesClass
				},
				items: [],
				id: id,
				selectors: {
					wrapEl: "#" + id
				}
			};
		};

		var getImageConfig = function(name, className, config) {
			var imageConfig = resources.localizableImages[name];
			if (config) {
				imageConfig = config;
			}
			var imageUrl = Terrasoft.ImageUrlBuilder.getUrl(imageConfig);
			var htmlImg = "<img id = '" + name + "-img-control' class = '" + className + "' src='" + imageUrl + "'>";
			return {
				className: "Terrasoft.Component",
				html: htmlImg,
				selectors: {
					wrapEl: "#" + name + "-img-control"
				}
			};
		};

		var getButtonsPanelItems = function() {
			var settingsConfig = getContainerConfig("settingsContainer", "btn-container-user-class");
			var settingsImageConfig = getImageConfig("SettingsIcon2", "img-user-class");
			settingsImageConfig.visible = {
				bindTo: "getSettingsVisibility"
			};
			settingsConfig.items.push(settingsImageConfig);
			settingsConfig.items.push({
				id: "settingsButton",
				className: "Terrasoft.Button",
				style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
				caption: resources.localizableStrings.SettingsButtonCaption2,
				visible: {
					bindTo: "getSettingsVisibility"
				},
				menu: {
					items: [{
						caption: resources.localizableStrings.ConfigurationSettingsMenuCaption2,
						click: {bindTo: "settingsClick"},
						visible: {bindTo: "canAccessConfigurationSettings"}
					}, {
						caption: resources.localizableStrings.WorkplaceSettingsMenuCaption2,
						click: {bindTo: "openWorkplaceSettings"},
						visible: {bindTo: "canManageWorkplaceSettings"}
					}, {
						caption: resources.localizableStrings.ExternalFormsSettingsMenuCaption2,
						click: {bindTo: "openExternalFormsSettings"},
						visible: {bindTo: "canManageWebForms"}
					}, {
						caption: resources.localizableStrings.SysOperationAuditSectionMenuCaption2,
						click: {bindTo: "openSysOperationAuditSection"},
						visible: {bindTo: "canAccessSysAuditOperationsSection"}
					}, {
						caption: resources.localizableStrings.SysProcessLogSectionMenuCaption2,
						click: { bindTo: "openSysProcessLogSection" }
					}, {
						caption: resources.localizableStrings.SectionDesignerMenuItemCaption2,
						visible: { bindTo: "isSectionDesignerAvailable" },
						click: { bindTo: "startSectionDesigner" }
					}, {
						caption: resources.localizableStrings.LookupMenuItemCaption,
						click: { bindTo: "openVocabulary" },
						visible: { bindTo: "canManageLookups" }
					}, {
						caption: resources.localizableStrings.DetailWizardMenuItemCaption,
						visible: { bindTo: "isSectionDesignerAvailable" },
						click: { bindTo: "openDetailWizard" }
					}]
				},
				classes: {
					wrapperClass: ["settings-btn-wrapperClass"],
					innerWrapperClass: ["settings-btn-innerWrapperClass"],
					textClass: ["settings-btn-textClass"],
					menuWrapClass: ["settings-btn-menuWrapClass"],
					menuClass: ["settings-btn-menuClass"],
					markerClass: ["settings-btn-markerClass"]
				},
				markerValue: "settingsButton"
			});
			var profileConfig = getContainerConfig("profileContainer", "btn-container-user-class");
			profileConfig.items.push(getImageConfig("ProfileIcon2", "img-user-class"));
			profileConfig.items.push(getLabelConfig({
				caption: resources.localizableStrings.ProfileButtonCaption2,
				labelClass: "btn-lbl-user-class",
				tag: "ProfileModule",
				click: {
					bindTo: "profileClick"
				},
				markerValue: "profileLabel"
			}));
			var exitConfig = getContainerConfig("exitContainer", "btn-container-user-class");
			exitConfig.items.push(getImageConfig("ExitIcon2", "img-user-class"));
			exitConfig.items.push(getLabelConfig({
				caption: resources.localizableStrings.ExitButtonCaption2,
				labelClass: "btn-lbl-user-class",
				tag: null,
				click: {
					bindTo: "exitClick"
				},
				markerValue: "exitLabel"
			}));
			return [settingsConfig, profileConfig, exitConfig];
		};

		var getView = function(menuItems) {
			var logoImageConfig = {
				params: {
					r: "MenuLogoImage"
				},
				source: Terrasoft.ImageSources.SYS_SETTING
			};
			var logoImage = getImageConfig("MenuLogoImage", "logo-user-class", logoImageConfig);
			var logoConfig = getContainerConfig("headerContainer", "header-container");
			var logoImageContainerConfig = getContainerConfig("logo-image-container", "logo-image-container");
			var logoImageInnerConfig = getContainerConfig("logo-image-inner-container", "logo-image-inner-container");
			logoImageInnerConfig.items.push(logoImage);
			logoImageContainerConfig.items.push(logoImageInnerConfig);
			logoConfig.items.push(logoImageContainerConfig);
			logoConfig.items.push(getContainerConfig("main-menu-command-line-container", "command-line-container"));
			logoConfig.items.push(getContainerConfig("main-menu-context-help-container",
				"main-menu-context-help-container"));
			var leftPanelConfig = getContainerConfig("leftContainer", "left-container-user-class");
			var rightPanelConfig = getContainerConfig("rightContainer", "right-container-user-class");
			Terrasoft.each(menuItems, function(item) {
				if (item.folderLocation) {
					var controlGroups = item.folderLocation === "left" ? leftPanelConfig.items : rightPanelConfig.items;
					var controlGroup = controlGroups.filter(function(group) {
						return group.caption === item.folder.displayValue;
					});
					var label = getLabelConfig({
						caption: item.moduleCaption,
						labelClass: "lbl-user-class",
						tag: ModuleUtils.getModuleTag(item.moduleCode),
						click: {
							bindTo: "sectionClick"
						},
						markerValue: item.moduleCaption
					});
					if (controlGroup && controlGroup.length > 0) {
						controlGroup[0].items.push(label);
						Ext.Array.merge(controlGroups, controlGroup[0]);
					} else {
						controlGroup = {
							bottomLine: false,
							caption: item.folder.displayValue,
							className: "Terrasoft.ControlGroup",
							classes: {
								wrapClass: "ctrl-group-user-class",
								wrapContainerClass: "ctrl-group-container-user-class"
							},
							collapsed: false,
							items: [label]
						};
						controlGroups.push(controlGroup);
					}
				}
			});

			var buttonsPanelConfig = getContainerConfig("buttonsContainer", "buttons-container-user-class");
			buttonsPanelConfig.items = getButtonsPanelItems();

			return Ext.create("Terrasoft.Container", {
				id: "mainMenu",
				selectors: {
					wrapEl: "#mainMenu"
				},
				items: [
					logoConfig,
					leftPanelConfig,
					rightPanelConfig,
					buttonsPanelConfig
				]
			});
		};

		var getViewModel = function() {
			return Ext.create("Terrasoft.BaseViewModel", {
				methods: {
					sectionClick: function(tag) {
						MaskHelper.ShowBodyMask();
						sandbox.publish("PushHistoryState", { hash: tag });
					},
					settingsClick: function() {
						if (isDemoBuild) {
							window.open("../ViewPage.aspx?Id=179558ce-e1f7-4d82-a00a-c6a507ce7e9f");
						} else {
							window.open("../ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
						}
					},
					profileClick: function(tag) {
						sandbox.publish("PushHistoryState", { hash: tag });
					},
					openWorkplaceSettings: function() {
						sandbox.publish("PushHistoryState", { hash: "SectionModuleV2/SysWorkplaceSectionV2" });
					},
					openExternalFormsSettings: function() {
						sandbox.publish("PushHistoryState", { hash: "SectionModuleV2/GeneratedWebFormSectionV2" });
					},
					openSysOperationAuditSection: function() {
						sandbox.publish("PushHistoryState", { hash: "SectionModuleV2/SysOperationAuditSectionV2" });
					},
					openSysProcessLogSection: function() {
						sandbox.publish("PushHistoryState", { hash: "SectionModuleV2/SysProcessLogSectionV2" });
					},
					startSectionDesigner: function() {
						var location = window.location;
						var origin = location.origin || location.protocol + "//" + location.host;
						var url = origin + location.pathname + "#SectionDesigner/";
						require(["SectionDesignerUtils"], function(module) {
							module.start(url, true);
						});
					},
					/**
					 * ######### ######## ############ # ###### UI
					 */
					openVocabulary: function() {
						window.open("../ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a&ActiveTabId=" +
							"PageContainer_c02e0ec6f36b14108882485b39c5f8dd_035063c98180e011afbc00155d04320c" +
							"_790581929880e011afbc00155d04320c");
					},

					/**
					 * ######### ###### ######.
					 */
					openDetailWizard: function() {
						var detailWizardUrl = Terrasoft.workspaceBaseUrl + "/NUI/ViewModule.aspx?vm=DetailWizard#New";
						window.open(detailWizardUrl);
					},

					exitClick: function() {
						ServiceHelper.callService("MainMenuService", "Logout", function() {
							window.logout = true;
							window.location.replace(Terrasoft.loaderBaseUrl);
						}, {}, this);
					},
					getSettingsVisibility: function() {
						var result = false;
						if (Ext.isEmpty(isDemoBuild) || isDemoBuild) {
							result = false;
						} else if (this.get("canAccessConfigurationSettings") ||
							this.get("canManageWorkplaceSettings") || this.get("canManageWebForms") ||
							this.get("canAccessSysAuditOperationsSection") || this.get("isSectionDesignerAvailable")) {
							result = true;
						}
						return result;
					}
				}
			});
		};

		var getIsSectionDesignerAvailable = function(viewModel, callback) {
			PackageHelper.getIsPackageInstalled(ConfigurationConstants.PackageUId.CrtPlatform7x,
				function(isPackageInstalled) {
					if (isPackageInstalled) {
						require(["SectionDesignerUtils"], function(module) {
							module.getCanUseSectionDesigner(function(result) {
								viewModel.set("isSectionDesignerAvailable", result.canUseSectionDesigner);
							});
						});
					} else {
						viewModel.set("isSectionDesignerAvailable", false);
					}
					callback.call();
				});
		};

		var getCanAccessConfigurationSettings = function(viewModel, callback) {
			ServiceHelper.callService("MainMenuService", "GetCanAccessConfigurationSettings", function(response) {
				if (response) {
					var result = response.GetCanAccessConfigurationSettingsResult;
					var value = false;
					if (result && Ext.isBoolean(result)) {
						value = true;
					}
					this.set("canAccessConfigurationSettings", value);
					callback.call();
				}
			}, {}, viewModel);
		};

		var getCanManageLookups = function(scope, callback) {
			scope.set("canManageLookups", false);
			RightUtilities.checkCanExecuteOperation({
				operation: "CanManageLookups"
			}, function(result) {
				var canManageLookups = scope.get("canManageLookups");
				scope.set("canManageLookups", canManageLookups || result);
				callback.call();
			}, scope);
		};

		var getCanAccessSysAuditOperationsSection = function(scope, callback) {
			scope.set("canAccessSysAuditOperationsSection", false);
			RightUtilities.checkCanExecuteOperation({
				operation: "CanViewSysOperationAudit"
			}, function(result) {
				var canAccessSysAuditOperationsSection = scope.get("canAccessSysAuditOperationsSection");
				scope.set("canAccessSysAuditOperationsSection", canAccessSysAuditOperationsSection || result);
			}, scope);
			RightUtilities.checkCanExecuteOperation({
				operation: "CanManageSysOperationAudit"
			}, function(result) {
				var canAccessSysAuditOperationsSection = scope.get("canAccessSysAuditOperationsSection");
				scope.set("canAccessSysAuditOperationsSection", canAccessSysAuditOperationsSection || result);
				callback.call();
			}, scope);
		};

		var getCanManageWorkplaceSettings = function(scope, callback) {
			scope.set("canManageWorkplaceSettings", false);
			RightUtilities.checkCanExecuteOperation({
				operation: "CanManageWorkplaceSettings"
			}, function(result) {
				var canManageWorkplaceSettings = scope.get("canManageWorkplaceSettings");
				scope.set("canManageWorkplaceSettings", canManageWorkplaceSettings || result);
				callback.call();
			}, scope);
		};

		var generate = function() {
			var moduleStructure = Terrasoft.configuration.ModuleStructure;
			var select = Ext.create("Terrasoft.EntitySchemaQuery", {rootSchema: SysModule});
			var folder = select.addColumn("[SysModuleInSysModuleFolder:SysModule].SysModuleFolder");
			var folderLocation = select.addColumn("[SysModuleInSysModuleFolder:SysModule].SysModuleFolder.Location");
			var folderPosition = select.addColumn("[SysModuleInSysModuleFolder:SysModule].SysModuleFolder.Position",
				"FolderPosition");
			var moduleCode = select.addColumn("Code");
			var modulePosition = select.addColumn("[SysModuleInSysModuleFolder:SysModule].Position", "ModulePosition");
			LocalizationUtilities.addLocalizableColumn(select, "Caption");
			select.filters.add("locationFilter", Terrasoft.createColumnInFilterWithParameters(folderLocation.columnPath,
				["left", "right"]));
			select.filters.add("positionFilter", Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.LESS,
				modulePosition.columnPath, "100"));
			folderPosition.orderDirection = Terrasoft.OrderDirection.ASC;
			folderPosition.orderPosition = 1;
			modulePosition.orderDirection = Terrasoft.OrderDirection.ASC;
			modulePosition.orderPosition = 2;
			select.getEntityCollection(function(result) {
				var menuItems = [];
				Terrasoft.each(result.collection.collection.items, function(entity) {
					var code = entity.get(moduleCode.columnPath);
					var moduleConfig = (moduleStructure && moduleStructure[code]) ?
						moduleStructure[code] : null;
					if (!moduleConfig || moduleConfig.showInMainMenu !== "false") {
						menuItems.push({
							folder: entity.get(folder.columnPath),
							folderLocation: entity.get(folderLocation.columnPath),
							moduleCode: code,
							moduleCaption: entity.get("Caption")
						});
					}
				});
				updateMenuItemFolderCaptions(menuItems, function(actualMenuItems) {
					var view = getView(actualMenuItems);
					var viewModel = getViewModel();
					sandbox.publish("InitContextHelp", "0");
					GeneratedWebFormUtilities.initCanManageWebForms(viewModel, function() {
						getCanAccessConfigurationSettings(viewModel, function() {
							getCanManageWorkplaceSettings(viewModel, function() {
								getCanAccessSysAuditOperationsSection(viewModel, function() {
									getIsSectionDesignerAvailable(viewModel, function() {
										getCanManageLookups(viewModel, function() {
											view.bind(viewModel);
											view.render(container);
											sandbox.publish("InitDataViews", {
												settings: {
													isMainMenu: true
												}
											});
											MaskHelper.HideBodyMask();
										});
									});
								});
							});
						});
					});
				}, this);
			}, this);
		};

		function updateMenuItemFolderCaptions(menuItems, callback, scope) {
			var select = Ext.create("Terrasoft.EntitySchemaQuery", {rootSchema: SysModuleFolder});
			LocalizationUtilities.addLocalizableColumn(select, "Caption");
			select.getEntityCollection(function(result) {
				var folders = {};
				if (result.success) {
					Terrasoft.each(result.collection.collection.items, function(entity) {
						folders[entity.get("Id")] = entity.get("Caption");
					});
					var responseCount = 0;
					var requestCount = menuItems.length;
					Terrasoft.each(menuItems, function(item) {
						RightUtilities.getSchemaReadRights(
							{
								schemaName: item.moduleCode
							}, function(result) {
								if (!result) {
									var localizedCaption = folders[item.folder.value];
									if (localizedCaption) {
										item.folder.displayValue = localizedCaption;
									}
								} else {
									var itemIndex = menuItems.indexOf(item);
									if (itemIndex > -1) {
										menuItems.splice(itemIndex, 1);
									}
								}
								responseCount++;
								if (requestCount === responseCount) {
									callback.call(scope, menuItems);
								}
							}, this);
					});
				}
			}, scope);
		}

		var init = function() {
			initHistoryState();
			Terrasoft.SysSettings.querySysSettingsItem("ShowDemoLinks", function(value) {
				isDemoBuild = value;
			}, this);

		};

		var initHistoryState = function() {
			var state = sandbox.publish("GetHistoryState");
			var currentHash = state.hash;
			var currentState = state.state || {};
			if (currentState.moduleId === sandbox.id) {
				return;
			}
			var newState = prepareHistorySate(currentState);
			sandbox.publish("ReplaceHistoryState", {
				stateObj: newState,
				pageTitle: null,
				hash: currentHash.historyState,
				silent: true
			});
		};

		var prepareHistorySate = function(currentState) {
			var newState = Terrasoft.deepClone(currentState);
			newState.moduleId = sandbox.id;
			return newState;
		};

		var render = function(renderTo) {
			container = renderTo;
			generate();
		};

		return {
			init: init,
			render: render
		};
	});


