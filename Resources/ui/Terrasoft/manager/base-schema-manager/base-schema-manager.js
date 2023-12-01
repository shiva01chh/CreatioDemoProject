﻿/**
 * @abstract
 */
Ext.define("Terrasoft.manager.BaseSchemaManager", {
	extend: "Terrasoft.manager.BaseManager",
	alternateClassName: "Terrasoft.BaseSchemaManager",

	//region Properties: Private

	/**
	 * Bundle-schema cache.
	 * @private
	 * @type {Object}
	 */
	_bundleSchemaCache: {},

	// endregion

	//region Properties: Protected

	/**
	 * Flag that indicates whether manager is initialized or not.
	 * @protected
	 * @type {Boolean}
	 */
	initialized: false,

	/**
	 * Indicates whether manager is in initialization process.
	 * @protected
	 * @type {Boolean}
	 */
	initializing: false,

	/**
	 * @inheritdoc Terrasoft.BaseManager#itemClassName
	 * @protected
	 * @override
	 */
	itemClassName: "Terrasoft.BaseSchemaManagerItem",

	/**
	 * Server's manager name.
	 * @protected
	 * @type {String}
	 */
	managerName: "",

	/**
	 * Schema name prefix.
	 * @protected
	 * @type {String}
	 */
	schemaNamePrefix: "",

	/**
	 * Name of the schema manager service.
	 * @protected
	 * @type {String}
	 */
	schemaManagerServiceName: "ServiceModel/SchemaManagerService.svc",

	/**
	 * Workspace column path.
	 * @type {Object}
	 */
	sysWorkspaceColumnPath: "SysPackage.SysWorkspace",

	// endregion

	//region Properties: Public

	/**
	 * Properties to columns mapping.
	 * @type {Object}
	 */
	propertyColumnNames: null,

	/**
	 * Instance class name of item.
	 * @type {String}
	 */
	itemInstanceClassName: null,

	/**
	 * Entity schema name.
	 * @protected
	 * @type {String}
	 */
	entitySchemaName: "SysSchema",

	/**
	 * UId of the base schema.
	 * @type {String}
	 */
	defSchemaUId: "",

	// endregion

	//region Methods: Private

	/**
	 * @private
	 */
	_getCachingGroupKey: function() {
		return this.managerName + "CachingGroupKey";
	},

	/**
	 * Creates new schema instance.
	 * @param {Object} config Schema primary info config.
	 * @param {String} config.uId Schema identifier.
	 * @param {String} config.packageUId Package identifier.
	 * @param {String} config.parentUId Parent schema identifier.
	 * @param {Function} callback The callback function.
	 * @param {Terrasoft.BaseSchema} callback.schema Schema instance.
	 * @param {Terrasoft.BaseSchemaManagerItem} callback.managerItem Created manager item.
	 * @param {String} callback.errorMessage Error message if server request wasn't successful.
	 * @param {Object} scope The scope of callback function.
	 */
	_createSchemaInstance: function(config, callback, scope) {
		Terrasoft.chain(
			function(next) {
				if (config.name && config.caption) {
					next();
				} else {
					this.getUniqueNameAndCaption({}, next, this);
				}
			},
			function(next, name, caption, errorMessage) {
				if (errorMessage) {
					callback.call(scope, null, null, errorMessage);
					return;
				}
				const schema = this.createSchema(Ext.apply({
					name: name,
					caption: caption
				}, config));
				const managerItem = this.addSchema(schema);
				callback.call(scope, schema, managerItem, errorMessage);
			}, this
		);
	},

	/**
	 * @param {String} packageUId
	 * @param {Function} callback
	 * @param {Object} scope
	 * @private
	 */
	_buildPackageHierarchy: function(packageUId, callback, scope) {
		Terrasoft.SchemaDesignerUtilities.buildPackageHierarchy({
			packageUId: packageUId,
			useCache: true
		}, callback, scope);
	},

	/**
	 * Returns schema instance class name.
	 * @private
	 * @return {String}
	 */
	getItemInstanceClassName: function() {
		const managerItemClass = Ext.ClassManager.get(this.itemClassName);
		return managerItemClass.prototype.instanceClassName;
	},

	/**
	 * Init manager items.
	 * @protected
	 * @virtual
	 * @param {Object} collection Items collection ViewModelCollection.
	 */
	initItems: function(collection) {
		collection.each(function(itemEntity) {
			const initialConfig = {};
			Terrasoft.each(this.propertyColumnNames, function(columnName, propertyName) {
				initialConfig[propertyName] = itemEntity.get(columnName);
			}, this);
			initialConfig.status = Terrasoft.ModificationStatus.NOT_MODIFIED;
			const managerItem = this.createManagerItem(initialConfig);
			this.addItem(managerItem);
		}, this);
	},

	/**
	 * Initializes manager items from service request.
	 * @protected
	 * @virtual
	 * @param {Array} items Items.
	 */
	initServiceItems: function(items) {
		Terrasoft.each(items, (initialConfig) => {
			const config = {
				status: Terrasoft.ModificationStatus.NOT_MODIFIED
			};
			Object.keys(initialConfig).forEach((key) => {
				config[Terrasoft.toLowerCamelCase(key)] = initialConfig[key];
			});
			const managerItem = this.createManagerItem(config);
			this.addItem(managerItem);
		});
	},

	/**
	 * Returns query for select manager objects.
	 * @protected
	 * @return {Terrasoft.EntitySchemaQuery}
	 */
	getSelectQuery: function() {
		const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
			rootSchemaName: this.entitySchemaName
		});
		Terrasoft.each(this.propertyColumnNames, (columnName) => esq.addColumn(columnName), this);
		esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
			this.sysWorkspaceColumnPath, Terrasoft.SysValue.CURRENT_WORKSPACE.value));
		this.addManagerNameFilter(esq);
		return esq;
	},

	/**
	 * Adds filter to select items query by manager name.
	 * @protected
	 * @param {Terrasoft.EntitySchemaQuery} esq Select items query.
	 */
	addManagerNameFilter: function(esq) {
		esq.filters.addItem(Terrasoft.createColumnFilterWithParameter(
			Terrasoft.ComparisonType.EQUAL, "ManagerName", this.managerName));
	},

	/**
	 * Initializes schema name prefix.
	 * @protected
	 * @param {Function} next The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	initializeSchemaNamePrefix: function(next, scope) {
		Terrasoft.SysSettings.querySysSettings(["SchemaNamePrefix"], function(settings) {
			this.schemaNamePrefix = settings.SchemaNamePrefix;
			Ext.callback(next, scope);
		}, this);
	},

	/**
	 * Returns schema by packageUId from filtering items.
	 * @private
	 * @param {Function} filteringFunction Schema manager item filtering function.
	 * @param {String} packageUId Package UId.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function context.
	 */
	findPackageSchemaUId: function(filteringFunction, packageUId, callback, scope) {
		const filteredSchemaManagerItems = this.items.filter(filteringFunction);
		this._buildPackageHierarchy(packageUId, function(packageHierarchy) {
			let item = null;
			Terrasoft.each(packageHierarchy, function(hierarchyPackageUId) {
				item = filteredSchemaManagerItems.findByPath("packageUId", hierarchyPackageUId);
				return Ext.isEmpty(item);
			});
			callback.call(scope, item && item.getUId());
		}, this);
	},

	/**
	 * Returns error message from unsuccessful response.
	 * @private
	 * @param {Object} response Response object.
	 */
	getResponseErrorMessage: function(response) {
		return response.errorInfo ? response.errorInfo.toString() : response.statusText;
	},

	/**
	 * Returns unique name and caption of the schema.
	 * @param {Object} config Configuration object.
	 * @param {String} [config.namePrefix] Name prefix.
	 * @param {String} [config.captionPrefix] Caption prefix.
	 * @param {Function} callback The callback function.
	 * @param {String} callback.name New unique schema name.
	 * @param {String} callback.caption New unique schema caption.
	 * @param {String} callback.errorMessage Error message if server request wasn't successful.
	 * @param {Object} scope The scope of callback function.
	 */
	getUniqueNameAndCaption: function(config, callback, scope) {
		if (Ext.isFunction(config)) {
			callback = config;
			scope = callback;
			config = {};
		}
		const request = Ext.create("Terrasoft.BaseSchemaManagerRequest", {
			serviceName: "ServiceModel/SchemaManagerService.svc",
			methodName: "GetUniqueNameAndCaption",
			urlParameters: {
				managerName: this.managerName,
				namePrefix: config.namePrefix,
				captionPrefix: config.captionPrefix
			}
		});
		request.execute(function(result, errorMessage) {
			if (errorMessage) {
				callback.call(scope, null, null, errorMessage);
			} else {
				callback.call(scope, result.name, result.caption);
			}
		}, this);
	},

	/**
	 * @private
	 */
	_resetBundleInstanceCache(item) {
		const rootItem = this.findRootSchemaItemByName(item.name);
		if (rootItem) {
			let cacheSchemaKey = this._getSchemaCacheKey(rootItem.uId, item.packageUId);
			delete this._bundleSchemaCache[cacheSchemaKey];
			cacheSchemaKey = this._getSchemaCacheKey(rootItem.uId, Terrasoft.GUID_EMPTY);
			delete this._bundleSchemaCache[cacheSchemaKey];
		}
	},

	/**
	 * @private
	 */
	_getSchemaCacheKey: function (schemaUId, packageUId) {
		return schemaUId + "_" + packageUId;
	},

	/**
	 * @private
	 */
	_packageItemsByHierarchyComparer: function(o1, o2, packageHierarchy) {
		const name1 = o1.getName();
		const name2 = o2.getName();
		if (name1 === name2) {
			const packageUId1 = o1.packageUId;
			const packageUId2 = o2.packageUId;
			return packageHierarchy.indexOf(packageUId2) - packageHierarchy.indexOf(packageUId1);
		}
		return 0;
	},

	/**
	 * @private
	 */
	_getRequestClassName: function() {
		const managerItemClass = Ext.ClassManager.get(this.itemClassName);
		return managerItemClass.prototype.requestClassName;
	},

	/**
	 * @private
	 */
	_getAggregatedRequestClassName: function() {
		const requestClassname = this._getRequestClassName();
		const index = "Terrasoft.".length;
		return requestClassname.substring(0, index) + "Aggregated" +
			requestClassname.substring(index, requestClassname.length);
	},

	/**
	 * @private
	 */
	_getInstanceRequest: function(requestClassName, schemaUId, packageUId) {
		return Ext.create(requestClassName, {
			uId: schemaUId,
			packageUId: packageUId
		});
	},

	/**
	 * @private
	 */
	_findPackageItems: function(packageUId, filterFn, callback, scope) {
		Terrasoft.chain(
			this.initialize,
			function(next) {
				this._buildPackageHierarchy(packageUId, next, this);
			},
			function(next, packageHierarchy) {
				const items = new Terrasoft.Collection({
					getKey: (item) => item?.getUId()
				});
				let itemsToLoad = this.items;
				if (!Terrasoft.isEmptyGUID(packageUId)) {
					itemsToLoad = this.items.filter((item) => Terrasoft.contains(packageHierarchy, item.packageUId));
				}
				items.loadAll(itemsToLoad);
				next(items, packageHierarchy);
			},
			function(next, items, packageHierarchy) {
				if (Terrasoft.Features.getIsDisabled("DisableSortPackageItemsByHierarchy")) {
					items.sort("name", Terrasoft.OrderDirection.ASC);
					items.sortByFn((o1, o2) => this._packageItemsByHierarchyComparer(o1, o2, packageHierarchy), this);
				}
				next(items);
			},
			function(next, items) {
				const result = Ext.isFunction(filterFn) ? items.filterByFn(filterFn, scope) : items;
				callback.call(scope, result);
			},
			this
		);
	},

	/**
	 * @private
	 */
	_findSchemaInstance: function(config, callback, scope) {
		const schemaUId = config.schemaUId;
		const item = this.findItem(schemaUId);
		if (item && item.isNew()) {
			item.getInstance(callback, scope);
			return;
		}
		const packageUId = config.packageUId;
		const cacheSchemaKey = this._getSchemaCacheKey(schemaUId, packageUId);
		const cachedSchema = (config.useCache !== false) && this._bundleSchemaCache[cacheSchemaKey];
		if (cachedSchema) {
			callback.call(scope, cachedSchema);
			return;
		}
		const request = this._getInstanceRequest(config.requestClassName, schemaUId, packageUId);
		request.execute(function(response) {
			let schema;
			if (response && response.success) {
				schema = response.schema;
				this._bundleSchemaCache[cacheSchemaKey] = schema;
			} else {
				const message = config.getErrorMessage();
				this.error(message);
			}
			callback.call(scope, schema);
		}, this);
	},

	// endregion

	//region Methods: Protected

	/**
	 * Queries manager items.
	 * @protected
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	queryItems: function(callback, scope) {
		const itemsQuery = this.getSelectQuery();
		itemsQuery.getEntityCollection(callback, scope);
	},

	/**
	 * Processes response from server with items for initialize.
	 * @protected
	 * @param {Function} callback The callback function.
	 * @param {Object} response Response.
	 */
	processItemsQueryResponse: function(callback, response) {
		if (response.success) {
			this.initItems(response.collection);
		} else {
			throw new Terrasoft.InvalidOperationException({message: response.errorInfo});
		}
		callback.call(this);
	},

	/**
	 * Async initialize.
	 * @returns {Promise<void>}
	 */
	initializeAsync: async function() {
		await new Promise((next) => this.initialize(next, this));
	},

	/**
	 * Init manager.
	 * @protected
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	initialize: function(callback, scope) {
		if (this.initialized) {
			if (this.isOutdated) {
				if (this.hasModifiedItems()) {
					console.warn(this.alternateClassName +
						" is outdated. It can't be reinitialized, because it has modified items.");
					Ext.callback(callback, scope);
				} else {
					this.reInitialize(callback, scope);
				}
			} else {
				Ext.callback(callback, scope);
			}
			return;
		}
		if (this.initializing) {
			this.on("initialized", function() {
				Ext.callback(callback, scope);
			}, this, {
				single: true
			});
			return;
		}
		this.initializing = true;
		Terrasoft.chain(
			this.queryItems,
			this.processItemsQueryResponse,
			this.initializeSchemaNamePrefix,
			function() {
				this.initialized = true;
				this.initializing = false;
				this.isOutdated = false;
				Ext.callback(callback, scope);
				this.fireEvent("initialized");
			}, this
		);
	},

	/**
	 * @inheritdoc Terrasoft.BaseManager#clear
	 * @protected
	 * @override
	 */
	clear: function() {
		this.callParent(arguments);
		this.initialized = false;
	},

	/**
	 * Saves schema by unique identifier.
	 * @protected
	 * @param {String} schemaUId Schema unique identifier.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	saveSchema: function(schemaUId, callback, scope) {
		if (this.initialized) {
			this.findItemByUId(schemaUId, function(item) {
				const config = {};
				if (item) {
					item.save(config, callback, scope);
				} else {
					Ext.callback(callback, scope);
				}
			}, this);
		} else {
			const safeCallback = this.getSafeCallback(callback, scope);
			safeCallback();
		}
	},

	/**
	 * @inheritdoc Terrasoft.BaseManager#save
	 * @protected
	 * @override
	 */
	save: function(callback, scope) {
		const changedItemsCollection = this.getItems({
			useFilterFn: true
		});
		const managerSaveResponse = {
			success: true,
			items: changedItemsCollection
		};
		Terrasoft.chain(
			function(next) {
				this.getSaveSequence(changedItemsCollection.getItems(), next, this);
			},
			function(next, changedItems) {
				let saveChainArguments = [];
				if (this.initialized) {
					const stepFunction = function (nextStep) {
						const config = {};
						const item = changedItems.pop();
						item.save(config, function (itemSaveResponse) {
							if (itemSaveResponse && itemSaveResponse.success) {
								this._resetBundleInstanceCache(item);
								nextStep();
							} else {
								Ext.apply(managerSaveResponse, itemSaveResponse);
								managerSaveResponse.failedItem = item;
								callback.call(scope, managerSaveResponse);
							}
						}, this);
					};
					saveChainArguments = changedItems.map(function() {
						return stepFunction;
					}, this);
				}
				saveChainArguments.push(function() {
					callback.call(scope, managerSaveResponse);
				});
				saveChainArguments.push(this);
				Terrasoft.chain.apply(this, saveChainArguments);
			}, this
		);
	},

	/**
	 * Handler for remove item from collection.
	 * @protected
	 * @param {Terrasoft.BaseSchemaManagerItem} item Collection item.
	 */
	onItemRemoved: function(item) {
		if (item) {
			item.un("removed", this.onItemRemoved, this);
			this.items.remove(item);
			item.destroy();
		}
	},

	/**
	 * Handler for outdated item event.
	 * @protected
	 * @param {Object} event Outdated event.
	 */
	onItemOutdated: function(event) {
		this.notify(this.outdatedEventName, {
			status: event.status,
			uId: event.uId,
			name: event.name,
			caption: event.caption
		});
	},

	/**
	 * Returns a sequence of elements of management schemes for the conservation of objects schemes.
	 * @param {Terrasoft.EntitySchemaManagerItems[]} changedItems Array elements management schemes objects.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 * @return {Terrasoft.EntitySchemaManagerItems[]}
	 */
	getSaveSequence: function(changedItems, callback, scope) {
		callback.call(scope, changedItems);
	},

	/**
	 * Checks manager itialized stage.
	 * @protected
	 * @throws {Terrasoft.InvalidObjectState}
	 */
	checkIsInitialized: function() {
		if (!this.initialized) {
			throw new Terrasoft.InvalidObjectState({
				message: Terrasoft.Resources.Managers.Exceptions.ManagerIsNotInitialized
			});
		}
	},

	/**
	 * Creates schema request instance.
	 * @protected
	 * @param {String} schemaUId Schema UId.
	 * @param {String} packageUId Package UId.
	 * @return {Object} Object for request instance of schema.
	 */
	getBundleInstanceRequest: function(schemaUId, packageUId) {
		const requestClassName = this._getRequestClassName();
		return this._getInstanceRequest(requestClassName, schemaUId, packageUId);
	},

	// endregion

	//region Methods: Public

	/**
	 * Returns schemaNamePrefix.
	 * @return {String}
	 */
	getSchemaNamePrefix: function() {
		return this.schemaNamePrefix;
	},

	/**
	 * @inheritdoc Terrasoft.BaseManager#addItem
	 * @protected
	 * @override
	 */
	addItem: function(item) {
		if (!item) {
			throw new Terrasoft.NullOrEmptyException();
		}
		Terrasoft.validateObjectClass(item, this.itemClassName);
		item.on("removed", this.onItemRemoved, this);
		item.on("outdated", this.onItemOutdated, this);
		return this.items.add(item.uId, item);
	},

	/**
	 * Function schema changes filtration.
	 * @type{Function}
	 */
	filterFn: function(item) {
		return item.isModified();
	},

	/**
	 * @inheritdoc Terrasoft.manager.BaseManager#constructor
	 * @override
	 */
	constructor: function() {
		this.callParent(arguments);
		this.itemInstanceClassName = this.getItemInstanceClassName();
		this.propertyColumnNames = {
			id: "Id",
			name: "Name",
			caption: "Caption",
			uId: "UId",
			packageUId: "SysPackage.UId",
			parentUId: "Parent.UId",
			extendParent: "ExtendParent"
		};
	},

	/**
	 * Refresh every manager item.
	 */
	refresh: function(callback, scope) {
		let saveChainArguments = [];
		if (this.initialized) {
			const changedItems = this.getItems({
				useFilterFn: true
			}).getItems();
			const stepFunction = function (next) {
				const item = changedItems.pop();
				item.refresh(next, this);
			};
			saveChainArguments = changedItems.map(function() {
				return stepFunction;
			}, this);
		}
		const safeCallback = this.getSafeCallback(callback, scope);
		saveChainArguments.push(safeCallback);
		saveChainArguments.push(this);
		Terrasoft.chain.apply(this, saveChainArguments);
	},

	/**
	 * Returns item by schema UId.
	 * @throws {Terrasoft.ItemNotFoundException}
	 * Throws exception {@link Terrasoft.ItemNotFoundException} if item was not found.
	 * @param {String} schemaUId Schema unique identifier.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	getItemByUId: function(schemaUId, callback, scope) {
		Terrasoft.chain(
			function(next) {
				if (!this.initialized) {
					this.initialize(next, this);
				} else {
					next();
				}
			},
			function() {
				const item = this.items.get(schemaUId);
				Ext.callback(callback, scope, [item]);
			}, this
		);
	},

	/**
	 * Returns schema instance by UId.
	 * @throws {Terrasoft.ItemNotFoundException} if item with same key not found.
	 * @param {String} schemaUId Schema unique identifier.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	getInstanceByUId: function(schemaUId, callback, scope) {
		if (arguments.length > 3) {
			const obsoleteMessage = Ext.String.format(Terrasoft.Resources.ObsoleteMessages.MethodFormatObsolete,
				"getInstanceByUId", "schemaUId, callback, scope, config", "schemaUId, callback, scope");
			this.log(obsoleteMessage, Terrasoft.LogMessageType.WARNING);
		}
		this.findInstanceByUId(schemaUId, function(instance) {
			if (instance == null) {
				throw Terrasoft.ItemNotFoundException();
			}
			callback.call(scope, instance);
		}, this);
	},

	/**
	 * Returns schema instance by UId. If manager item not found, returns null.
	 * @param {String} schemaUId Schema unique identifier.
	 * @param {Function} callback The callback function.
	 * @param {null|Object} callback.schema Schema instance.
	 * @param {Object} scope The scope for the callback.
	 */
	findInstanceByUId: function(schemaUId, callback, scope) {
		Terrasoft.chain(
			function(next) {
				this.findItemByUId(schemaUId, next, this);
			},
			function(next, item) {
				if (item && item.status !== Terrasoft.ModificationStatus.REMOVED) {
					item.getInstance(callback, scope);
				} else {
					callback.call(scope, null);
				}
			},
			this
		);
	},

	/**
	 * Returns from server instance of schema by UId.
	 * @throws {Terrasoft.ItemNotFoundException}
	 * Throws exception {@link Terrasoft.ItemNotFoundException} if item was not found.
	 * @param {String} schemaUId Schema unique identifier.
	 * @param {Function} callback The callback function.
	 * @param {Object} callback.instance Schema instance.
	 * @param {Object} scope The scope for the callback.
	 */
	forceGetInstanceByUId: function(schemaUId, callback, scope) {
		Terrasoft.chain(
			function(next) {
				this.getItemByUId(schemaUId, next);
			},
			function(next, item) {
				if (item.status === Terrasoft.ModificationStatus.REMOVED) {
					throw Terrasoft.ItemNotFoundException();
				}
				item.forceGetInstance(function(itemInstance) {
					callback.call(scope, itemInstance);
				}, this);
			},
			this
		);
	},

	/**
	 * Returns manager item by schema UId.
	 * @param {String} schemaUId Schema UId.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	findItemByUId: function(schemaUId, callback, scope) {
		Terrasoft.chain(this.initialize,
			function() {
				const item = this.items.find(schemaUId);
				callback.call(scope, item);
			},
			this
		);
	},

	/**
	 * Returns root manager item by schema identifier.
	 * @param {String} uId Schema real UId.
	 * @return {Terrasoft.BaseSchemaManagerItem} Manager item.
	 */
	findRootItemByUId: function(uId) {
		return this.items.findByFn(function(item) {
			return !item.extendParent && item.uId === uId;
		}, this);
	},

	/**
	 * Returns manager item of root schema by name.
	 * @param {String} schemaName Schema name.
	 * @return {Terrasoft.BaseSchemaManagerItem} Manager item.
	 */
	findRootSchemaItemByName: function(schemaName) {
		if (this.initialized) {
			return this.items.firstOrDefault(function(item) {
				return item.name === schemaName && !item.getExtendParent();
			}, this);
		} else {
			return null;
		}
	},

	/**
	 * Generates unique name of manager item using prefix.
	 * @param {String} prefix Prefix.
	 * @return {String}
	 */
	generateItemUniqueName: function(prefix) {
		const template = prefix + "{0}";
		return this.getUniqueNameByTemplate(template);
	},

	/**
	 * Generates unique name of manager item using template.
	 * @param {String} template Name template.
	 * @return {String}
	 * Example
	 *
	 * Items:
	 *      Schema1Item
	 *      Schema2Item
	 * getUniqueNameByTemplate("Schema{0}Item")
	 * Result: Schema3Item
	 *
	 */
	getUniqueNameByTemplate: function(template) {
		let name;
		let foundItem;
		let i = 0;
		do {
			i++;
			name = Ext.String.format(template, i);
			foundItem = this.items.findByPath("name", name);
		} while (foundItem);
		return name;
	},

	/**
	 * Generates unique caption of manager item using prefix.
	 * @param {String} prefix Prefix.
	 * @return {String}
	 */
	generateItemUniqueCaption: function(prefix) {
		let caption = prefix + " 1";
		let counter = 1;
		const filterFn = function (item) {
			if (item.caption.getValue) {
				return item.caption.getValue() === caption;
			}
			return item.caption === caption;
		};
		do {
			const filteredItems = this.items.filterByFn(filterFn);
			if (filteredItems.getCount() === 0) {
				return caption;
			}
			counter++;
			caption = prefix + " " + counter;
		} while (true);
	},

	/**
	 * Adds schema.
	 * @throws {Terrasoft.NullOrEmptyException}
	 * Throws exception {@link Terrasoft.NullOrEmptyException} if parameter is empty.
	 * @throws {Terrasoft.UnsupportedTypeException}
	 * Throws exception {@link Terrasoft.UnsupportedTypeException} if there is no corresponding type.
	 * @param {Terrasoft.manager.BaseSchema} schema Schema.
	 * @return {Terrasoft.manager.BaseSchemaManagerItem} Added item.
	 */
	addSchema: function(schema) {
		if (!schema) {
			throw new Terrasoft.NullOrEmptyException();
		}
		Terrasoft.validateObjectClass(schema, this.itemInstanceClassName);
		const managerItemConfig = {};
		Terrasoft.each(Object.keys(this.propertyColumnNames), function(propertyName) {
			if (schema.hasOwnProperty(propertyName)) {
				const property = schema[propertyName];
				const isLocalizableString = Terrasoft.instanceOfClass(property, "Terrasoft.LocalizableString");
				managerItemConfig[propertyName] = isLocalizableString ? property.getValue() : property;
			} else {
				return;
			}
		}, this);
		managerItemConfig.instance = schema;
		const managerItem = this.createManagerItem(managerItemConfig);
		managerItem.setStatus(Terrasoft.ModificationStatus.NEW);
		return this.addItem(managerItem);
	},

	/**
	 * Creates schema.
	 * @param {Object} config Configuration object.
	 * @return {Terrasoft.BaseManagerItem} Schema instance.
	 */
	createSchema: function(config) {
		if (!config.extendParent) {
			this.validateSchemaName(config.name);
		}
		const schemaManagerItem = Ext.create(this.itemClassName);
		return schemaManagerItem.createInstance(config);
	},

	/**
	 * Validates schema name.
	 * @throws {Terrasoft.InvalidOperationException}
	 * Throws exception {@link Terrasoft.InvalidOperationException} if schema name does not contains prefix.
	 * @param {String} schemaName Schema name.
	 */
	validateSchemaName: function(schemaName) {
		if (schemaName && !schemaName.match(this.schemaNamePrefix)) {
			const errorMessage = Ext.String.format(Terrasoft.Resources.Managers.Exceptions.SchemaNamePrefixException,
				this.schemaNamePrefix);
			throw new Terrasoft.InvalidOperationException({message: errorMessage});
		}
	},

	/**
	 * Validates schema as parent.
	 * @throws {Terrasoft.InvalidObjectState}
	 * Throws exception {@link Terrasoft.InvalidObjectState} if schema cannot set as parent.
	 * @param {String} schemaUId Schema UId.
	 */
	validateSchemaAsParent: function(schemaUId) {
		const manager = Terrasoft[this.managerName];
		const items = manager.getItems();
		const foundItems = items.filterByFn(function (item) {
			return item.uId === schemaUId && !item.extendParent;
		});
		if (foundItems.getCount() === 0) {
			throw new Terrasoft.InvalidObjectState();
		}
	},

	/**
	 * Returns schemas of the elements.
	 * @param {Terrasoft.BaseSchemaManagerItem[]} managerItems Manager item array.
	 * @param {Function} callback Callback function.
	 * @param {Object[]} callback.result Array of schemas.
	 * @param {Object} scope Callback function.
	 */
	getInstances: function(managerItems, callback, scope) {
		Terrasoft.eachAsyncAll(managerItems, function(managerItem, next) {
			managerItem.getInstance(next, this);
		}, function() {
			const instances = managerItems.map((managerItem) => managerItem.instance);
			Ext.callback(callback, scope, [instances]);
		});
	},

	/**
	 * Returns schemas for all manager elements.
	 * @param {Function} callback Callback function.
	 * @param {Object[]} callback.result Array of schemas.
	 * @param {Object} scope Callback function call context.
	 */
	getAllInstances: function(callback, scope) {
		const managerItems = this.items.getItems();
		this.getInstances(managerItems, callback, scope);
	},

	/**
	 * Returns schema manager item of package.
	 * @param {Object} config Configuration object.
	 * @param {String} config.packageUId Package UId.
	 * @param {String} config.schemaUId Schema UId.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function context.
	 * @return {Terrasoft.BaseSchemaManagerItem} Manager item.
	 */
	getPackageSchemaManagerItem: function(config, callback, scope) {
		const packageUId = config.packageUId;
		const schemaUId = config.schemaUId;
		Terrasoft.chain(
			function(next) {
				this.getItemByUId(schemaUId, next, this);
			},
			function(next, foundSchema) {
				const items = this.getItems();
				const itemsInPackage = items.filterByFn(function (item) {
					return item.getName() === foundSchema.getName() && item.getPackageUId() === packageUId;
				});
				const schemaManagerItem = itemsInPackage.first();
				callback.call(scope, schemaManagerItem);
			},
			this
		);
	},

	/**
	 * Returns schema manager item of package. If schema does not find in package, extends schema for package.
	 * @param {Object} config Configuration object.
	 * @param {String} config.packageUId Package UId.
	 * @param {Object} config.schemaUId Schema UId.
	 * @param {Function} next Callback function.
	 * @param {Object} scope Callback function context.
	 * @return {Terrasoft.BaseSchemaManagerItem} Manager item.
	 */
	forceGetPackageSchema: function(config, next, scope) {
		this.getPackageSchemaManagerItem(config, function(managerItem) {
			if (!managerItem) {
				this.requestDesignSchema(config, next, scope);
			} else {
				managerItem.getInstance(next, scope);
			}
		}, this);
	},

	/**
	 * Returns parameters for design schema request.
	 * @protected
	 * @returns {Object} Configuration object.
	 * @returns {String} return.contractName Name of design schema request contract name.
	 * @returns {String} return.responseClassName Name of design schema request response class name.
	 */
	getDesignSchemaRequestParameters: function() {
		throw new Terrasoft.NotImplementedException();
	},

	/**
	 * Requests design schema from server.
	 * @private
	 * @param {Object} config Configuration object.
	 * @param {String} config.packageUId Package UId.
	 * @param {String} config.schemaUId Schema UId.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function context.
	 * @returns void
	 */
	requestDesignSchema: function(config, callback, scope) {
		const requestParameters = this.getDesignSchemaRequestParameters();
		const designSchemaRequest = Ext.create("Terrasoft.ParametrizedRequest", {
			contractName: requestParameters.contractName,
			responseClassName: requestParameters.responseClassName,
			config: {
				uId: config.schemaUId,
				packageUId: config.packageUId
			}
		});
		designSchemaRequest.execute(function(result) {
			if (!result.success) {
				throw new Terrasoft.QueryExecutionException({
					message: result.errorInfo.toString()
				});
			}
			callback.call(scope, result.schema);
		});
	},

	/**
	 * Returns array of modified items.
	 * @throws {Terrasoft.InvalidOperationException}.
	 * Throws exception {@link Terrasoft.InvalidOperationException} if manager is not initialized.
	 * @return {Array} Terrasoft.BaseSchemaManagerItem Array of modified items.
	 */
	getModifiedItems: function() {
		const result = [];
		if (this.initialized && !this.initializing) {
			this.items.each(function(item) {
				if (item.isModified()) {
					result.push(item);
				}
			}, this);
			return result;
		} else {
			throw new Terrasoft.InvalidObjectState();
		}
	},

	/**
	 * Returns flag that indicates whether manager has at least one modified item or not.
	 * @return {Boolean}
	 */
	hasModifiedItems: function() {
		if (!this.initialized) {
			return false;
		}
		const changedItem = this.findByFn(function (item) {
			return item.isModified();
		}, this);
		return !Ext.isEmpty(changedItem);
	},

	/**
	 * Returns schema by package UId and schema name.
	 * For example this.items is Terrasoft.Collection which has:
	 *
	 *      {
	 *      		$className: "Terrasoft.BaseSchemaManagerItem",
	 *      		name: "TestSchema",
	 *      		packageUId: "00000000-0000-0000-0000-000000000001",
	 *      		uId: "00000000-0000-0000-0000-000000000011",
	 *      		instance: {...},
	 *      		...
	 *      }
	 *      this.getPackageSchemaInstanceBySchemaName("TestSchema", "00000000-0000-0000-0000-000000000001", callback,
	 *          scope);
	 *
	 * Result:
	 *
	 *      {
	 *      		$className: "Terrasoft.BaseSchema",
	 *      		name: "TestSchema",
	 *      		packageUId: "00000000-0000-0000-0000-000000000001",
	 *      		uId: "00000000-0000-0000-0000-000000000011",
	 *      		...
	 *      }
	 *
	 * @param {String} schemaName Schema name.
	 * @param {String} packageUId Package UId.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function context.
	 */
	getPackageSchemaInstanceBySchemaName: function(schemaName, packageUId, callback, scope) {
		this.findPackageSchemaUId(function(item) {
			return item.name === schemaName;
		}, packageUId, function(schemaUId) {
			this.getInstanceByUId(schemaUId, callback, scope);
		}, this);
	},

	/**
	 * Returns schema by package UId and schema UId.
	 * For example this.items is Terrasoft.Collection which has:
	 *
	 *      {
	 *      		$className: "Terrasoft.BaseSchemaManagerItem",
	 *      		name: "TestSchema",
	 *      		packageUId: "00000000-0000-0000-0000-000000000001",
	 *      		uId: "00000000-0000-0000-0000-000000000011",
	 *      		instance: {...},
	 *      		...
	 *      }
	 *
	 * and
	 *
	 *      {
	 *      		$className: "Terrasoft.BaseSchemaManagerItem",
	 *      		name: "TestSchema",
	 *      		packageUId: "00000000-0000-0000-0000-000000000002",
	 *      		uId: "00000000-0000-0000-0000-000000000012",
	 *      		instance: {...},
	 *      		...
	 *      }
	 *      this.getPackageSchemaInstanceBySchemaUId("00000000-0000-0000-0000-000000000011",
	 *          "00000000-0000-0000-0000-000000000002", callback, scope);
	 *
	 * Result:
	 *
	 *      {
	 *      		$className: "Terrasoft.BaseSchema",
	 *      		name: "TestSchema",
	 *      		packageUId: "00000000-0000-0000-0000-000000000002",
	 *      		uId: "00000000-0000-0000-0000-000000000012",
	 *      		...
	 *      }
	 *
	 * @param {String} schemaUId Parent schema UId.
	 * @param {String} packageUId Package UId.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function context.
	 */
	getPackageSchemaInstanceBySchemaUId: function(schemaUId, packageUId, callback, scope) {
		this.getItemByUId(schemaUId, function(item) {
			const schemaName = item.getName();
			this.getPackageSchemaInstanceBySchemaName(schemaName, packageUId, callback, scope);
		}, this);
	},

	/**
	 * Search schema manager items by filter.
	 * @param {Object} config Config object.
	 * @param {Boolean} [config.includeExtensionItems] Determines whether to include non-root items also.
	 * @param {Function} [config.filterFn] Filter function.
	 * @param {Function} config.callback The callback function.
	 * @param {Terrasoft.Collection} config.callback.collection Collection of items.
	 * @param {Object} config.scope The scope for the callback.
	 */
	findSortedByTopologyItems: function(config) {
		const externalFilter = Ext.isFunction(config.filterFn) ? config.filterFn : () => true;
		const filterFn = config && config.includeExtensionItems
			? config.filterFn 
			: (item) => !item.getExtendParent() && externalFilter(item);
		this._findPackageItems(Terrasoft.GUID_EMPTY, filterFn, config.callback, config.scope);
	},

	/**
	 * Search schema manager items in hierarchy packages.
	 * @param {Object} config Configuration object.
	 * @param {String} config.packageUId Package UId.
	 * @param {Function} [config.filterFn] Filter function.
	 * @param {Function} callback The callback function.
	 * @param {Terrasoft.Collection} callback.collection Collection of items.
	 * @param {Object} scope The scope for the callback.
	 */
	findPackageItems: function(config, callback, scope) {
		let filterFn = config.filterFn;
		let packageUId = config.packageUId;
		if (Ext.isString(config)) {
			filterFn = (item) => !item.getExtendParent();
			packageUId = config;
		}
		this._findPackageItems(packageUId, filterFn, callback, scope);
	},

	/**
	 * Search schema manager item in hierarchy packages. If item not found, returns null.
	 * @param {String} schemaUId Schema UId.
	 * @param {String} packageUId Package UId.
	 * @param {Function} callback The callback function.
	 * @param {Terrasoft.BaseSchemaManagerItem|null} callback.managerItem Base schema manager item.
	 * @param {Object} scope The scope for the callback.
	 */
	findPackageItem: function(schemaUId, packageUId, callback, scope) {
		this.findItemByUId(schemaUId, function(item) {
			if (!item) {
				callback.call(scope);
				return;
			}
			this._buildPackageHierarchy(packageUId, function(packageHierarchy) {
				if (Terrasoft.contains(packageHierarchy, item.packageUId)) {
					callback.call(scope, item);
				} else {
					callback.call(scope);
				}
			}, this);
		}, this);
	},

	/**
	 * Checks whether schema manager item is available in hierarchy packages.
	 * @param {Object} config Configuration object.
	 * @param {String} config.schemaUIds Schema UIds.
	 * @param {String} config.packageUId Package UId.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	getAbsentSchemaItemsInHierarchy: function({schemaUIds, packageUId}, callback, scope) {
		Terrasoft.chain(
			(next) => this.initialize(next, this),
			(next) => this._buildPackageHierarchy(packageUId, next, this),
			(next, packageHierarchy) => {
				const isItemAvailable = (item) => _.contains(packageHierarchy, item.packageUId);
				const isItemChecking = (item) => _.contains(schemaUIds, item.uId);
				const result = this.items
					.getItems()
					.filter((item) => !isItemAvailable(item) && isItemChecking(item));
				callback.call(scope, result);
			}
		);
	},

	/**
	 * Returns schema instance from schema manager by identifier.
	 * @param {String} schemaUId Schema identifier.
	 * @param {Function} callback Callback function.
	 * @param {Terrasoft.BaseSchema} callback.schema Schema instance.
	 * @param {Terrasoft.BaseSchemaManagerItem} callback.managerItem Created manager item.
	 * @param {String} callback.errorMessage Error message if server request wasn't successful.
	 * @param {Object} scope Callback function scope.
	 */
	getSchemaInstance: function(schemaUId, callback, scope) {
		let managerItem = this.findItem(schemaUId);
		if (!managerItem) {
			managerItem = this.createManagerItem({uId: schemaUId});
		}
		managerItem.getInstance(function(schema, response) {
			if (schema) {
				callback.call(scope, schema, managerItem);
			} else {
				const errorMessage = this.getResponseErrorMessage(response);
				callback.call(scope, null, null, errorMessage);
			}
		}, this);
	},

	/**
	 * Creates new schema instance.
	 * @param {String} schemaUId Schema identifier.
	 * @param {String} packageUId Package identifier.
	 * @param {Function} callback The callback function.
	 * @param {Terrasoft.BaseSchema} callback.schema Schema instance.
	 * @param {Terrasoft.BaseSchemaManagerItem} callback.managerItem Created manager item.
	 * @param {String} callback.errorMessage Error message if server request wasn't successful.
	 * @param {Object} scope The scope of callback function.
	 */
	createSchemaInstance: function(schemaUId, packageUId, callback, scope) {
		if (Ext.isObject(schemaUId)) {
			const config = schemaUId;
			scope = callback;
			callback = packageUId;
			this._createSchemaInstance(config, callback, scope);
		} else {
			this._createSchemaInstance({
				uId: schemaUId,
				packageUId: packageUId
			}, callback, scope);
		}
	},

	/**
	 * Check ability for edit schema.
	 * @param {String} schemaUId Schema identifier.
	 * @param {Function} callback The callback function.
	 * @param {Boolean} callback.success Schema has no foreign lock.
	 * @param {Boolean} callback.lockMessage Version control lock message.
	 * @param {Boolean} [callback.errorMessage] Server response error message.
	 * @param {Object} scope The scope of callback function.
	 */
	getCanEditSchema: function(schemaUId, callback, scope) {
		const request = Ext.create("Terrasoft.BaseSchemaManagerRequest", {
			serviceName: "ServiceModel/SchemaManagerService.svc",
			methodName: "CheckHasNoForeignLock",
			urlParameters: {
				managerName: this.managerName,
				schemaUId: schemaUId
			}
		});
		request.execute(function(result, errorMessage) {
			if (errorMessage) {
				callback.call(scope, null, null, errorMessage);
			} else {
				callback.call(scope, result.success, result.message);
			}
		}, this);
	},

	/**
	 * Replaces property value of object.
	 * @private
	 * @param {Object} obj Simple object which can encode to string.
	 * @param {String|String[]} properties Names of properties.
	 * @param {String} oldValue Old property value.
	 * @param {String} newValue New property value.
	 * @return {Object}
	 */
	replaceObjectProperty: function(obj, properties, oldValue, newValue) {
		let str = Terrasoft.encode(obj);
		properties.forEach(function(property) {
			const regExp = new RegExp("\"" + property + "\"\:\"" + oldValue + "\"", "gi");
			str = str.replace(regExp, "\"" + property + "\"\:\"" + newValue + "\"");
		});
		return Terrasoft.decode(str);
	},

	/**
	 * Copies localizable resources from source schema to target.
	 * @private
	 * @param {Terrasoft.manager.BaseSchema} sourceSchema Source schema.
	 * @param {Terrasoft.manager.BaseSchema} targetSchema Target schema
	 */
	copyLocalizableResources: function(sourceSchema, targetSchema) {
		const targetSchemaUId = targetSchema.uId;
		targetSchema.uId = sourceSchema.uId;
		const resources = {};
		sourceSchema.getLocalizableValues(resources);
		targetSchema.loadLocalizableValuesByUIds(resources);
		targetSchema.uId = targetSchemaUId;
	},

	/**
	 * Copies schema.
	 * @param {Terrasoft.manager.BaseSchema} sourceSchema Schema instance for copy.
	 * @return {Terrasoft.manager.BaseSchemaManagerItem} Returns added manager item with copy of schema.
	 */
	copySchema: function(sourceSchema) {
		const schemaUId = Terrasoft.generateGUID();
		let config = {};
		sourceSchema.getSerializableObject(config);
		const propertiesToReplace = ["createdInSchemaUId", "modifiedInSchemaUId"];
		config = this.replaceObjectProperty(config, propertiesToReplace, sourceSchema.uId, schemaUId);
		config.uId = schemaUId;
		const schema = Ext.create(this.itemInstanceClassName, config);
		this.copyLocalizableResources(sourceSchema, schema);
		return this.addSchema(schema);
	},

	/**
	 * Resets and initializes manager.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The scope for the callback.
	 */
	reInitialize: function(callback, scope) {
		this.clear();
		this.initialize(callback, scope);
	},

	/**
	 * Builds schema due to package hierarchy.
	 * If schema not found, returns null.
	 * @param {Object} config Configuration object.
	 * @param {String} config.schemaUId Schema UId.
	 * @param {String} config.packageUId Package UId.
	 * @param {Boolean} [config.useCache=true] Using cache.
	 * @param {Function} callback The callback function.
	 * @param {Object|null} callback.schema Schema instance.
	 * @param {Object} scope The scope for the callback function.
	 */
	findBundleSchemaInstance: function(config, callback, scope) {
		const schemaInstanceConfig = {
			schemaUId: config.schemaUId,
			packageUId: config.packageUId,
			useCache: config.useCache,
			requestClassName: this._getRequestClassName(),
			getErrorMessage: function() {
				return  Ext.String.format(Terrasoft.Resources.BaseSchemaManager.Exceptions.SchemaNotFoundMessage,
					config.schemaUId, config.packageUId);
				}
		};
		this._findSchemaInstance(schemaInstanceConfig, callback, scope);
	},

	/**
	 * Returns aggregated schema ignoring package hierarchy. If schema not found, returns null.
	 * @param {Object} config Configuration object.
	 * @param {String} config.schemaUId Schema UId.
	 * @param {Boolean} [config.useCache=true] Using cache.
	 * @param {Function} callback The callback function.
	 * @param {Object|null} callback.schema Schema instance.
	 * @param {Object} scope The scope for the callback function.
	 */
	findAggregatedSchemaInstance: function(config, callback, scope) {
		const schemaInstanceConfig = {
			schemaUId: config.schemaUId,
			packageUId: Terrasoft.GUID_EMPTY,
			useCache: config.useCache,
			requestClassName: this._getAggregatedRequestClassName(),
			getErrorMessage: function() {
				return  Ext.String.format(Terrasoft.Resources.BaseSchemaManager.Exceptions.SchemaNotFoundByUIdMessage,
					config.schemaUId);
			}
		};
		this._findSchemaInstance(schemaInstanceConfig, callback, scope);
	},

	/**
	 * Returns flag that indicates if schema is inherited from specified parent schema.
	 * @param {String} uId Schema identifier.
	 * @param {String} parentUId Parent schema identifier.
	 * @returns {Boolean}
	 */
	isInheritedFrom: function(uId, parentUId) {
		const parent = this.findRootItemByUId(parentUId);
		if (parent) {
			let page = this.findRootItemByUId(uId);
			while (page) {
				if (page.parentUId === parent.uId) {
					return true;
				}
				page = this.findRootItemByUId(page.parentUId);
			}
		}
		return false;
	},

	/**
	 * Returns SysSchema UId by Id.
	 * @param {String} id SysSchema.Id column value.
	 * @param {Function} callback The callback function.
	 * @param {Object} scope The callback functionCallback function.
	 */
	getSchemaUIdById: function(id, callback, scope) {
		const esq = new Terrasoft.EntitySchemaQuery("SysSchema");
		esq.addColumn("UId");
		esq.filters.addItem(esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "SysWorkspace",
			Terrasoft.SysValue.CURRENT_WORKSPACE.value
		));
		esq.getEntity(id, function(response) {
			if (response.entity) {
				Ext.callback(callback, scope, [response.entity.$UId]);
			} else {
				const template = Terrasoft.Resources.ProcessDiagram.Messages.ProcessSchemaNotFound;
				const message = Ext.String.format(template, id);
				this.warning(message);
				Terrasoft.showErrorMessage(message);
			}
		}, this);
	},

	/**
	 * Checks if the schema start with prefix.
	 * @param {String} schemaName Schema name.
	 * @return {Boolean}
	 */
	startWithPrefix: function(schemaName) {
		const prefix = this.getSchemaNamePrefix();
		return schemaName.startsWith(prefix);
	},

	/**
	 * Generates unique schema name.
	 * @param {string} template
	 * @return {string}
	 */
	generateUniqueSchemaName: function(template) {
		const schemaNamePrefix = this.schemaNamePrefix || "";
		if (Terrasoft.useSchemaUniqueNameRandomGenerator) {
			const uniqueSchemaNamePart = Terrasoft.generateGUID().substring(0, 8);
			return schemaNamePrefix + Ext.String.format(template, uniqueSchemaNamePart);
		}
		const items = this.getItems();
		let schemaName = schemaNamePrefix + Ext.String.format(template, 1);
		for (let i = 1, iterations = items.getCount(); i < iterations; i++) {
			schemaName = schemaNamePrefix + Ext.String.format(template, i);
			const foundItems = items.filterByPath("name", schemaName);
			if (foundItems.isEmpty()) {
				break;
			}
		}
		return schemaName;
	},

	/**
	 * Generates name with schemaNamePrefix if it defined.
	 * @param {string} name
	 * @return {string}
	 */
	generateNameWithPrefix: function(name) {
		if (!this.isInitialized) {
			throw new Error("Manager is not initialized");
		}
		return name.startsWith(this.schemaNamePrefix) ? name : this.schemaNamePrefix + name;
	},

	/**
	 * Reset bundle instance cache.
	 * @public
	 */
	resetBundleInstanceCache: function() {
		this._bundleSchemaCache = {};
	}

	// endregion

});

Object.defineProperty(Terrasoft.BaseSchemaManager.prototype, "isInitialized", {
	get: function() {
		return this.initialized;
	},
	set: function(value) {
		this.initialized = value;
	}
});

Object.defineProperty(Terrasoft.BaseSchemaManager.prototype, "isInitializing", {
	get: function() {
		return this.initializing;
	},
	set: function(value) {
		this.initializing = value;
	}
});
