﻿define("MobileDesignerApplicationManifest", ["MobileDesignerManifestColumnResolver"],
	function() {

		Ext.define("Terrasoft.MobileDesignerApplicationManifest", {

			config: {

				manifests: null,

				localizableStrings: null

			},

			//region Properties: Private

			/**
			 * @private
			 */
			mergedManifests: null,

			/**
			 * @private
			 */
			mergedLocalizableStrings: null,

			/**
			 * @private
			 */
			currentManifest: null,

			/**
			 * @private
			 */
			currentManifestLocalizableStrings: null,

			/**
			 * @private
			 */
			gridLookupColumns: null,

			/**
			 * @private
			 */
			resolversAsyncConfig: null,

			/**
			 * @private
			 */
			resolvers: null,

			//endregion

			//region Methods: Private

			/**
			 * @private
			 */
			getModelConfig: function(modelName) {
				var modelConfig = this.addModelConfigIfNotExists(modelName);
				this.applyDefaultModelConfigs(modelConfig);
				return modelConfig;
			},

			/**
			 * @private
			 */
			addModelConfigIfNotExists: function(modelName) {
				var currentManifestModels = this.getCurrentManifestModels();
				var modelConfig = currentManifestModels[modelName];
				if (!modelConfig) {
					modelConfig = currentManifestModels[modelName] = {};
				}
				this.applyDefaultModelConfigs(modelConfig);
				return modelConfig;
			},

			/**
			 * @private
			 */
			applyDefaultModelConfigs: function(modelConfig) {
				var defaultModelConfig = {
					RequiredModels: [],
					ModelExtensions: [],
					PagesExtensions: []
				};
				Ext.applyIf(modelConfig, defaultModelConfig);
			},

			/**
			 * @private
			 */
			getSyncOptions: function() {
				return this.currentManifest.SyncOptions;
			},

			/**
			 * @private
			 */
			getModelDataImportConfig: function() {
				return this.getSyncOptions().ModelDataImportConfig;
			},

			/**
			 * @private
			 */
			getModelResolver: function(modelName) {
				var resolver = this.resolvers[modelName];
				if (!resolver) {
					resolver = this.resolvers[modelName] = Ext.create("Terrasoft.MobileDesignerManifestColumnResolver", {
						modelName: modelName
					});
				}
				return resolver;
			},

			/**
			 * @private
			 */
			addPropertyIfNotExists: function(config, propertyName, defaultValue) {
				if (config[propertyName] === undefined) {
					config[propertyName] = defaultValue;
				}
			},

			/**
			 * @private
			 */
			addArrayPropertyIfNotExists: function(config, propertyName) {
				this.addPropertyIfNotExists(config, propertyName, []);
			},

			/**
			 * @private
			 */
			addObjectPropertyIfNotExists: function(config, propertyName) {
				this.addPropertyIfNotExists(config, propertyName, {});
			},

			/**
			 * @private
			 */
			applyFeatures: function(manifest) {
				var features = manifest.Features;
				if (features) {
					Terrasoft.each(features, function(feature, featureCode) {
						if (Terrasoft.Features.getIsEnabled(featureCode)) {
							manifest = this.merge(manifest, feature);
						}
					}.bind(this));
					delete manifest.Features;
				}
				return manifest;
			},

			/**
			 * @private
			 */
			mergeManifests: function() {
				var manifests = this.getManifests();
				var mergedManifests = {};
				var localizableStrings = this.getLocalizableStrings();
				var mergedLocalizableStrings = {};
				for (var i = 0, ln = manifests.length; i < ln; i++) {
					var manifest = this.applyFeatures(manifests[i]);
					mergedManifests = this.merge(mergedManifests, manifest);
					mergedLocalizableStrings = Ext.apply(mergedLocalizableStrings, localizableStrings[i]);
				}
				this.mergedManifests = mergedManifests;
				this.mergedLocalizableStrings = mergedLocalizableStrings;
			},

			/**
			 * @private
			 */
			findObjectInArrayByName: function(targetArray, name) {
				var foundObject = null;
				var foundIndex = -1;
				for (var i = 0, ln = targetArray.length; i < ln; i++) {
					var element = targetArray[i];
					if ((Ext.isObject(element) && (element.Name === name)) ||
						(Ext.isString(element) && (element === name))) {
						foundObject = element;
						foundIndex = i;
						break;
					}
				}
				return {
					foundObject: foundObject,
					foundIndex: foundIndex
				};
			},

			/**
			 * @private
			 */
			merge: function(target, src) {
				var isArray = Ext.isArray(src);
				var result = isArray && [] || {};
				if (isArray) {
					target = target || [];
					result = result.concat(target);
					for (var i = 0, ln = src.length; i < ln; i++) {
						var element = src[i];
						if (Ext.isObject(element) || Ext.isString(element)) {
							var elementName = (Ext.isObject(element)) ? element.Name : element;
							var existingObject = this.findObjectInArrayByName(target, elementName);
							if (existingObject && existingObject.foundObject) {
								var foundObject = existingObject.foundObject;
								var foundIndex = existingObject.foundIndex;
								if (Ext.isObject(foundObject) && Ext.isObject(element)) {
									result[foundIndex] = this.merge(foundObject, element);
								} else {
									result[foundIndex] = element;
								}
							} else {
								result.push(element);
							}
						} else if (target.indexOf(element) === -1) {
							result.push(element);
						}
					}
				} else {
					if (target && Ext.isObject(target)) {
						Ext.each(Object.keys(target), function(key) {
							result[key] = target[key];
						});
					}
					Ext.each(Object.keys(src), function(key) {
						if (typeof src[key] !== "object" || !src[key]) {
							result[key] = src[key];
						} else {
							if (!target[key]) {
								result[key] = src[key];
							} else {
								result[key] = this.merge(target[key], src[key]);
							}
						}
					}, this);
				}
				return result;
			},

			/**
			 * @private
			 */
			validateCurrentManifest: function() {
				var manifest = this.currentManifest;
				this.addObjectPropertyIfNotExists(manifest, "SyncOptions");
				this.addArrayPropertyIfNotExists(manifest.SyncOptions, "SysSettingsImportConfig");
				this.addArrayPropertyIfNotExists(manifest.SyncOptions, "ModelDataImportConfig");
				this.addObjectPropertyIfNotExists(manifest, "Modules");
				this.addObjectPropertyIfNotExists(manifest, "Models");
				this.addObjectPropertyIfNotExists(manifest, "ModuleGroups");
				this.addObjectPropertyIfNotExists(manifest.ModuleGroups, "main");
				this.addPropertyIfNotExists(manifest, "UseUTC", true);
			},

			/**
			 * @private
			 */
			applyModuleConfig: function(modelName, moduleConfig) {
				var currentManifestModules = this.currentManifest.Modules;
				this.addObjectPropertyIfNotExists(currentManifestModules, modelName);
				Ext.apply(currentManifestModules[modelName], moduleConfig);
				this.mergeManifests();
			},

			/**
			 * @private
			 */
			addLocalizableString: function(name, value) {
				this.currentManifestLocalizableStrings[name] = value;
			},

			/**
			 * @private
			 */
			union: function(object, propertyName, values) {
				var originalValue = object[propertyName];
				object[propertyName] = Ext.Array.union(originalValue, values);
			},

			/**
			 * @private
			 */
			findImportConfigForModel: function(modelName) {
				var currentManifestModelDataImportConfig = this.getModelDataImportConfig();
				return Ext.Array.findBy(currentManifestModelDataImportConfig, function(item) {
					return item === modelName || item.Name === modelName;
				});
			},

			/**
			 * @private
			 */
			addImportConfigForModel: function(modelName, syncColumns, filters) {
				var currentManifestModelDataImportConfig = this.getModelDataImportConfig();
				var modelImportConfig = {
					Name: modelName,
					SyncColumns: syncColumns || [],
					QueryFilter: filters
				};
				currentManifestModelDataImportConfig.push(modelImportConfig);
				return modelImportConfig;
			},

			/**
			 * @private
			 */
			updateModelDataImportConfigSection: function(resolverModelConfigs, parentModelName) {
				var currentManifestModelDataImportConfig = this.getModelDataImportConfig();
				Terrasoft.each(resolverModelConfigs, function(resolverModelConfig, modelName) {
					var syncColumns = resolverModelConfigs[modelName].columns;
					var filter = resolverModelConfigs[modelName].filter;
					var modelImportConfig = this.findImportConfigForModel(modelName);
					if (!modelImportConfig) {
						modelImportConfig = this.addImportConfigForModel(modelName, syncColumns, filter);
						if (modelName === "SysFile") {
							modelImportConfig.SyncColumns = Ext.Array.merge(modelImportConfig.SyncColumns,
								["Name", "Type", "Data", "Size", "RecordSchemaName"]);
						}
					} else if (Ext.isString(modelImportConfig)) {
						var configIndex = currentManifestModelDataImportConfig.indexOf(modelImportConfig);
						currentManifestModelDataImportConfig.splice(configIndex, 1);
						modelImportConfig = this.addImportConfigForModel(modelName, syncColumns, filter);
					} else if (syncColumns.length > 0) {
						var currentSyncColumns = modelImportConfig.SyncColumns || [];
						modelImportConfig.SyncColumns = Ext.Array.merge(currentSyncColumns, syncColumns);
					}
					if (modelName === "SysFile" && !filter) {
						this.addSysFileDefaultFilter(modelImportConfig, parentModelName);
					}
				}, this);
			},

			/**
			 * @private
			 */
			addSysFileDefaultFilter: function(modelImportConfig, parentModelName) {
				var defaultFilter;
				var addParentModelFilter = false;
				if (!modelImportConfig.QueryFilter) {
					defaultFilter = {
						filterType: 4,
						comparisonType: 3,
						isEnabled: true,
						trimDateTimeParameterToDate: false,
						leftExpression: {
							expressionType: 0,
							columnPath: "RecordSchemaName"
						},
						rightExpressions: []
					};
					modelImportConfig.QueryFilter = {
						items: {
							DesignerDefaultRecordSchemaNameFilter: defaultFilter
						},
						logicalOperation: 0,
						isEnabled: true,
						filterType: 6
					};
					addParentModelFilter = true;
				} else {
					defaultFilter = modelImportConfig.QueryFilter.items.DesignerDefaultRecordSchemaNameFilter;
					if (defaultFilter) {
						addParentModelFilter = true;
						for (var i = 0; i < defaultFilter.rightExpressions.length; i++) {
							if (defaultFilter.rightExpressions[i].parameter.value === parentModelName) {
								addParentModelFilter = false;
								break;
							}
						}
					}
				}
				if (addParentModelFilter) {
					defaultFilter.rightExpressions.push({
						expressionType: 2,
						parameter: {
							dataValueType: 1,
							value: parentModelName
						}
					});
				}
			},

			/**
			 * @private
			 */
			onResolverCompleted: function(resolver, resolvedConfig) {
				var requiredModelsConfig = resolvedConfig.requiredModels;
				var requiredModels = Object.keys(requiredModelsConfig);
				var requiredSysSettings = resolvedConfig.requiredSysSettings;
				var modelConfig = this.getModelConfig(resolver.getModelName());
				var syncOptions = this.getSyncOptions();
				this.union(modelConfig, "RequiredModels", requiredModels);
				this.updateModelDataImportConfigSection(requiredModelsConfig, resolver.getModelName());
				this.union(syncOptions, "SysSettingsImportConfig", requiredSysSettings);
				var config = this.resolversAsyncConfig;
				config.resolved++;
				if (config.resolved === config.total) {
					Ext.callback(config.callback, config.scope);
				}
			},

			//endregion

			//region Methods: Public

			constructor: function(config) {
				this.initConfig(config);
				this.resolvers = {};
				var manifests = config.manifests;
				var localizableStrings = config.localizableStrings;
				this.currentManifest = manifests[manifests.length - 1];
				this.currentManifestLocalizableStrings = localizableStrings[localizableStrings.length - 1];
				this.mergeManifests();
				this.validateCurrentManifest();
			},

			/**
			 * ########## ###### ########, ################## ## #### ########## ########## ##########.
			 * @return {Array} ###### ################ ######## ########.
			 */
			getModuleList: function() {
				var mergedManifest = this.mergedManifests;
				var mergedLocalizableStrings = this.mergedLocalizableStrings;
				var mobileModules = [];
				var modules = (mergedManifest) ? mergedManifest.Modules : {};
				Terrasoft.each(modules, function(moduleConfig) {
					moduleConfig = Ext.clone(moduleConfig);
					if (!moduleConfig.Hidden) {
						var localizableStringName = moduleConfig.Title;
						moduleConfig.Title = mergedLocalizableStrings[localizableStringName];
						mobileModules.push(moduleConfig);
					}
				});
				mobileModules.sort(function(a, b) {
					return a.Position - b.Position;
				});
				for (var i = 0, ln = mobileModules.length; i < ln; i++) {
					mobileModules[i].Position = i;
				}
				return mobileModules;
			},

			/**
			 * Adds module to manifest.
			 * @param {String} modelName Model name.
			 * @param {Object} moduleConfig Configuration object.
			 */
			addModule: function(modelName, moduleConfig) {
				var title = moduleConfig.title;
				var position = moduleConfig.position || 0;
				var moduleTitleLocalizableStringName = modelName + "SectionTitle";
				var newModuleConfig = {
					Group: "main",
					Model: modelName,
					Position: position,
					isStartPage: false,
					Title: moduleTitleLocalizableStringName,
					Hidden: false
				};
				if (!Ext.isEmpty(moduleConfig.screens)) {
					newModuleConfig.screens = moduleConfig.screens;
				}
				this.addLocalizableString(moduleTitleLocalizableStringName, title);
				this.applyModuleConfig(modelName, newModuleConfig);
				if (moduleConfig.addModel !== false) {
					this.addModelConfigIfNotExists(modelName);
				}
			},

			/**
			 * Hides module in manifest.
			 * @param {String} modelName ### ######.
			 */
			hideModule: function(modelName) {
				this.applyModuleConfig(modelName, {
					Hidden: true
				});
			},

			/**
			 * Gets screens in module config.
			 * @param {String} modelName Model name.
			 * @returns Screens comfig.
			 */
			getScreens: function(modelName) {
				var module = this.currentManifest.Modules[modelName];
				if (module && module.screens) {
					return module.screens;
				} else {
					module = this.mergedManifests.Modules[modelName];
					if (module) {
						return module.screens;
					} else {
						return null;
					}
				}
			},

			/**
			 * Sets screens in module config.
			 * @param {String} modelName Model name.
			 * @param screensConfig Screens comfig.
			 */
			setScreens: function(modelName, screensConfig) {
				this.applyModuleConfig(modelName, {
					screens: screensConfig
				});
			},

			/**
			 * ########## ##### ######## #######.
			 * @param {String} modelName ### ###### #######.
			 * @returns {String} ##### ######## #######.
			 */
			getModuleConfig: function(modelName) {
				return Ext.clone(this.getModelConfig(modelName));
			},

			/**
			 * ########## ######### ####### ## ######## #########.
			 * @param {String} modelName ### ###### #######.
			 * @returns {String} ##### ######## #######.
			 */
			getCurrentModuleConfig: function(modelName) {
				return this.currentManifest.Modules[modelName];
			},

			/**
			 * ############# ####### ####### # #########.
			 * @param {String} modelName ### ######.
			 * @param {Number} newPosition ##### ####### #######.
			 */
			changeModulePosition: function(modelName, newPosition) {
				this.applyModuleConfig(modelName, {
					Position: newPosition
				});
			},

			/**
			 * ######### ######## ######## # ###### #### ######.
			 * @param {String} modelName ### ######.
			 * @param {String} pageName ### ########.
			 */
			addSettingsPage: function(modelName, pageName) {
				var modelConfig = this.getModelConfig(modelName);
				var pagesExtensions = modelConfig.PagesExtensions;
				var settingsPageExists = pagesExtensions.indexOf(pageName) !== -1;
				if (!settingsPageExists) {
					modelConfig.PagesExtensions.unshift(pageName);
				}
			},

			/**
			 * ####### ######## ######## ## ####### #### ######.
			 * @param {String} modelName ### ######.
			 * @param {String} pageName ### ########.
			 */
			removeSettingsPage: function(modelName, pageName) {
				var modelConfig = this.getModelConfig(modelName);
				var pagesExtensions = modelConfig.PagesExtensions;
				var settingsPageIndex = pagesExtensions.indexOf(pageName);
				if (settingsPageIndex !== -1) {
					modelConfig.PagesExtensions.splice(settingsPageIndex, 1);
				}
			},

			/**
			 * ############# ####### ####### ### ######.
			 * @param {String} modelName ### ######.
			 * @param {Array} columnNames ##### ####### #######.
			 */
			setGridPageColumns: function(modelName, columnNames) {
				var resolver = this.getModelResolver(modelName);
				resolver.setGridPageColumns(columnNames);
			},

			/**
			 * ############# ####### ######## ### ######.
			 * @param {String} modelName ### ######.
			 * @param {Array} columnNames ##### ####### #######.
			 */
			setRecordPageColumns: function(modelName, columnNames) {
				var resolver = this.getModelResolver(modelName);
				resolver.setRecordPageColumns(columnNames);
			},

			/**
			 * ############# ############ ###### ### ######.
			 * @param {String} modelName ### ######.
			 * @param {Array} embeddedDetails ############ ############ #######.
			 */
			setEmbeddedDetails: function(modelName, embeddedDetails) {
				var resolver = this.getModelResolver(modelName);
				resolver.setEmbeddedDetails(embeddedDetails);
			},

			/**
			 * ######### # ######## ###### ########### #######
			 * @param {String} modelName ### ######.
			 * @param {Object} details ####### ####### ########### #######.
			 */
			setStandartDetails: function(modelName, details) {
				var detailModelNames = Object.keys(details);
				for (var i = 0, ln = detailModelNames.length; i < ln; i++) {
					var detailModelName = detailModelNames[i];
					this.addModelConfigIfNotExists(detailModelName);
				}
				var resolver = this.getModelResolver(modelName);
				resolver.setStandartDetails(details);
			},

			/**
			 * ######### ########### ###### # ######### ######### #########.
			 * @param {Object} config ################ ###### # ########### ###### ######:
			 * @param {Object} config.manifest ###### #########.
			 * @param {Function} config.callback ####### ######### ######.
			 * @param {Object} config.scope ######## ####### ######### ######.
			 */
			resolveManifest: function(config) {
				var resolvers = this.resolvers;
				var totalResolvers = Object.keys(resolvers).length;
				if (totalResolvers === 0) {
					Ext.callback(config.callback, config.scope);
					return;
				}
				this.resolversAsyncConfig = {
					callback: config.callback,
					scope: config.scope,
					resolved: 0,
					total: totalResolvers
				};
				Terrasoft.each(resolvers, function(resolver) {
					resolver.resolve({
						callback: this.onResolverCompleted,
						scope: this
					});
				}, this);
			},

			/**
			 * ########## ####### ########.
			 * @returns {Object} ####### ########.
			 */
			getCurrentManifest: function() {
				return this.currentManifest;
			},

			/**
			 * ########## ###### ######## #########.
			 * @returns {Object} ###### ######## #########.
			 */
			getCurrentManifestModels: function() {
				var currentManifest = this.getCurrentManifest();
				return currentManifest.Models;
			},

			/**
			 * ######### ################ ###### #########.
			 * @returns {Object} ################ ###### #########.
			 */
			getCurrentManifestLocalizableStrings: function() {
				return this.currentManifestLocalizableStrings;
			}

			//endregion

		});

		return Terrasoft.MobileDesignerApplicationManifest;

	}
);
