﻿define("DcmSchemaManager", [
	"ext-base",
	"terrasoft",
	"DcmSchemaManagerResources",
	"DcmSchemaManagerItem",
	"DcmElementSchemaManager",
	"DcmSchemaUpdateRequest",
	"DcmSchemaResponse",
	"DcmSchemaRequest",
	"SysDcmSettingsManager",
	"SysDcmSchemaInSettingsManager",
	"SetEnabledDcmSchemaRequest",
	"DcmSchemaInfoRequest",
	"DcmSchemaInfo"
], function(Ext, Terrasoft, resources) {

	/**
	 * Dcm schema manager class.
	 */
	Ext.define("Terrasoft.manager.DcmSchemaManager", {
		extend: "Terrasoft.BaseProcessSchemaManager",
		alternateClassName: "Terrasoft.DcmSchemaManager",
		singleton: true,

		// region Properties: Protected

		/**
		 * Workspace column path.
		 * @type {Object}
		 */
		sysWorkspaceColumnPath: "Package.SysWorkspace",

		// endregion

		// region Properties: Public

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#entitySchemaName
		 * @overridden
		 */
		entitySchemaName: "VwSysDcmLib",

		/**
		 * @inheritdoc Terrasoft.BaseManager#itemClassName
		 * @overridden
		 */
		itemClassName: "Terrasoft.DcmSchemaManagerItem",

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#managerName
		 * @overridden
		 */
		managerName: "DcmSchemaManager",

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#schemaManagerServiceName
		 * @protected
		 * @overridden
		 */
		schemaManagerServiceName: "ServiceModel/DcmSchemaManagerService.svc",

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#defSchemaUId
		 * @overridden
		 */
		defSchemaUId: "51b280eb-d8a3-4932-81b9-ef61a0877aab",

		/**
		 * @inheritdoc Terrasoft.BaseManager#useNotification
		 * @overridden
		 */
		useNotification: true,

		/**
		 * @inheritdoc Terrasoft.BaseManager#outdatedEventName
		 * @overridden
		 */
		outdatedEventName: "DcmSchemaManagerOutdated",

		/**
		 * @private
		 */
		_dcmSchemaInfoItems: null,

		// endregion

		// Constructors

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this._initInfoItemsCollection();
			Ext.apply(this.propertyColumnNames, {
				stageColumnUId: "StageColumnUId",
				entitySchemaUId: "EntitySchemaUId",
				isActive: "IsActive",
				isActiveVersion: "IsActiveVersion",
				versionParentUId: "VersionParentUId",
				filters: "Filters",
				packageUId: "Package.UId"
			});
		},

		// endregion

		// region Methods: Private

		/**
		 * @private
		 */
		_initInfoItemsCollection: function() {
			this._dcmSchemaInfoItems = Ext.create("Terrasoft.Collection");
			this.on("outdated", this._onInfoItemOutdated, this);
		},

		/**
		 * @private
		 */
		_onInfoItemOutdated: function(item) {
			const uId = item.uId;
			this._dcmSchemaInfoItems.removeByKey(uId);
		},

		/**
		 * Adds default stages and elements into schema.
		 * @private
		 * @param {Terrasoft.DcmSchema} schema Schema.
		 */
		addDefSchemaElements: function(schema) {
			const schemaUId = schema.uId;
			const stage1UId = Terrasoft.generateGUID();
			const stage1 = Ext.create("Terrasoft.DcmSchemaStage", {
				uId: stage1UId,
				createdInSchemaUId: schemaUId,
				modifiedInSchemaUId: schemaUId,
				isValid: false,
				isValidateExecuted: false
			});
			stage1.name += "1";
			stage1.caption.setValue(stage1.caption.getValue() + " 1");
			schema.addStage(stage1);
		},

		/**
		 * Returns filter column identifier of DcmSettings by ID.
		 * @private
		 * @param {String} dcmSettingsId Dcm settings ID.
		 * @param {Function} callback The callback function.
		 * @param {String} callback.columnUId Filter column identifier.
		 * @param {Object} scope The scope of callback function.
		 */
		getDcmSettingsFilterColumnUId: function(dcmSettingsId, callback, scope) {
			const sysDcmSettingsEsq = this.getSysDcmSettingsFiltersEsq();
			sysDcmSettingsEsq.getEntity(dcmSettingsId, function(result) {
				let filters = result.entity.get("Filters");
				filters = Ext.JSON.decode(filters, true);
				const columnUId = filters ? filters[0].columnUId : null;
				callback.call(scope, columnUId);
			}, this);
		},

		/**
		 * Returns deserialized filter group.
		 * @private
		 * @param {String} filter Filter.
		 * @return {Terrasoft.FilterGroup|null}
		 */
		getDeserializedFilters: function(filter) {
			if (!filter) {
				return null;
			}
			return Terrasoft.deserialize(filter);
		},

		/**
		 * Returns schemas caption list with equal filters.
		 * @private
		 * @param {Terrasoft.FilterGroup} schemaFilter Dcm schema source filter.
		 * @param {Terrasoft.Collection} schemasInSection Dcm schemas in section list.
		 * @return {String[]}
		 */
		getSchemasWithEqualFilters: function(schemaFilter, schemasInSection) {
			const schemas = [];
			schemasInSection.each(function(item) {
				const targetFilters = this.getDeserializedFilters(item.get("Filters"));
				const targetFilter = targetFilters && targetFilters.first();
				if (schemaFilter && schemaFilter.getIsEquals(targetFilter)) {
					schemas.push(item.get("Caption"));
				}
			}, this);
			return schemas;
		},

		/**
		 * Returns schema enabled request query.
		 * @private
		 * @param {String[]} items Manager items identifiers.
		 * @param {Boolean} enabled Enabled flag.
		 * @return {Terrasoft.SetEnabledDcmSchemaRequest}
		 */
		getEnabledRequest: function(items, enabled) {
			return Ext.create("Terrasoft.SetEnabledDcmSchemaRequest", {
				items: items,
				enabled: enabled
			});
		},

		/**
		 * @private
		 */
		_getSchemaColumn: function(schemaName, columnPath, callback, scope) {
			Terrasoft.require([schemaName], function(entitySchema) {
				callback.call(scope, entitySchema.columns[columnPath]);
			}, this);
		},

		/**
		 * @private
		 */
		_validateFilter: function(config) {
			const filterColumnUId = config.filterColumn.uId;
			if (filterColumnUId === config.stageColumnUId) {
				return resources.localizableStrings.StageColumnUsedInFiltersMessage;
			}
			const settingsFilterColumnUId = config.settingsFilterColumnUId;
			const filterColumnNotEqual = settingsFilterColumnUId && settingsFilterColumnUId !== filterColumnUId;
			const activateSchemaWithFilters = filterColumnUId && !config.schemaSaveMode;
			if (filterColumnNotEqual || (!settingsFilterColumnUId && activateSchemaWithFilters)) {
				return resources.localizableStrings.FilterColumnIsNotSupportedMessage;
			}
			const schemas = this.getSchemasWithEqualFilters(config.filter, config.enabledSchemas);
			if (schemas.length) {
				const messageTemplate = resources.localizableStrings.FilterIsNotUniqueMessage;
				return Ext.String.format(messageTemplate, schemas.join("\", \""));
			}
		},

		/**
		 * @private
		 */
		_validateFirstFilter: function(config, callback, scope) {
			const schemaName = config.filters.rootSchemaName;
			const firstFilter = config.filters.first();
			const filterColumnPath = firstFilter.leftExpression.columnPath;
			this._getSchemaColumn(schemaName, filterColumnPath, function(filterColumn) {
				const filterConfig = Ext.apply({}, config, {
					filterColumn: filterColumn,
					filter: firstFilter
				});
				const message = this._validateFilter(filterConfig);
				const isValid = !message;
				callback.call(scope, isValid, message);
			}, this);
		},

		/**
		 * Returns dcm section settings Esq.
		 * @private
		 * @return {Terrasoft.EntitySchemaQuery}
		 */
		getSysDcmSettingsFiltersEsq: function() {
			const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "SysDcmSettings"
			});
			esq.addColumn("Filters");
			return esq;
		},

		/**
		 * Returns collection of enabled dcm schemas for dcm settings ID.
		 * @private
		 * @param {Object} config Arguments config.
		 * @param {String} config.schemaUId Current schema identifier.
		 * @param {String} config.dcmSettingsId Dcm settings ID.
		 * @param {String} [config.copySourceSchemaId] Copied schema identifier.
		 * @param {Function} callback The callback function.
		 * @param {Terrasoft.Collection} callback.schemas Result schemas collection.
		 * @param {Object} scope The scope of callback function.
		 */
		_getEnabledDcmSchemasByDcmSettingsId: function(config, callback, scope) {
			const esq = this.getEnabledDcmSchemasEsq(config.schemaUId);
			esq.addColumn("VersionParentUId");
			esq.filters.addItem(esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
				"[SysDcmSchemaInSettings:SysDcmSchemaUId:UId].SysDcmSettings.Id", config.dcmSettingsId));
			if (config.copySourceSchemaId) {
				esq.filters.add("ExcludeCopy", esq.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.NOT_EQUAL, "Id", config.copySourceSchemaId));
			}
			esq.getEntityCollection(function(response) {
				const schemas = response.collection;
				callback.call(scope, schemas);
			}, this);
		},

		/**
		 * @private
		 */
		_fetchSchemaInfoItem: function(schemaUId, callback, scope) {
			const request = Ext.create("Terrasoft.DcmSchemaInfoRequest", {
				uId: schemaUId
			});
			request.execute(function(response) {
				let item;
				if (response.success) {
					item = Ext.create("Terrasoft.DcmSchemaInfo", response);
				} else {
					this.error(response.errorInfo.toString());
				}
				Ext.callback(callback, scope, [item]);
			}, this);
		},

		/**
		 * @private
		 */
		_addVersionFilters: function(esq, excludeSchemaUId) {
			esq.filters.add("ActiveVersionFilter", Terrasoft.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "IsActiveVersion", true));
			const versionParentUIdFilter = Terrasoft
				.createNotExistsFilter("[VwSysDcmLib:VersionParentUId:VersionParentUId].Id");
			const subFilter = Terrasoft
				.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, 'UId', excludeSchemaUId);
			versionParentUIdFilter.subFilters.addItem(subFilter);
			esq.filters.add("ExcludeCurrent", versionParentUIdFilter);
		},

		// endregion

		// region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#createSchema
		 * Hides parent implementation.
		 * @protected
		 * @overridden
		 */
		addManagerNameFilter: Terrasoft.emptyFn,

		/**
		 * @inheritdoc Terrasoft.BaseSchemaManager#createSchema
		 * @overridden
		 */
		createSchema: function() {
			const schema = this.callParent(arguments);
			schema.name = "";
			this.addDefSchemaElements(schema);
			return schema;
		},

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchemaManager#queryItems
		 * @override
		 */
		queryItems: function(callback, scope) {
			if (Terrasoft.Features.getIsEnabled('UseDcmServerEndPoint')) {
				const request = new Terrasoft.BaseRequest({
					contractName: 'DcmSchemaManagerRequest'
				});
				return request.execute(callback, scope);
			} else {
				this.callParent(arguments);
			}
		},

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchemaManager#initItems
		 * @override
		 */
		initItems: function(items) {
			if (Terrasoft.Features.getIsEnabled('UseDcmServerEndPoint')) {
				this.initServiceItems(items);
			} else {
				this.callParent(arguments);
			}
		},

		// endregion

		// region Methods: Public

		/**
		 * Returns query for select enabled dcm schemas in section except current.
		 * @param {String} currentSchemaUId Identifier of excluded schema.
		 * @return {Terrasoft.EntitySchemaQuery}
		 */
		getEnabledDcmSchemasEsq: function(currentSchemaUId) {
			const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "VwSysDcmLib"
			});
			esq.addColumn("UId");
			esq.addColumn("Caption");
			esq.addColumn("Filters");
			esq.filters.add("CurrentWorkspace", esq.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "SysWorkspace", Terrasoft.SysValue.CURRENT_WORKSPACE.value));
			esq.filters.add("Enabled", esq.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "IsActive", true));
			if (this.getCanUseProcessVersions()) {
				this._addVersionFilters(esq, currentSchemaUId);
			} else {
				esq.filters.add("ExcludeCurrent", esq.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.NOT_EQUAL, "UId", currentSchemaUId));
			}
			return esq;
		},

		/**
		 * Validates filters of the specified schema.
		 * @param {Object} config Arguments config.
		 * @param {String} config.schemaUId Dcm schema identifier.
		 * @param {String} config.filters Serialized dcm schema filters.
		 * @param {String} config.stageColumnUId Stage column identifier.
		 * @param {String} config.dcmSettingsId Section case settings identifier.
		 * @param {String} config.copySourceSchemaId Copied schema identifier.
		 * @param {Boolean} config.saveMode Saving schema in designer flag.
		 * @param {Function} callback The callback function.
		 * @param {Boolean} callback.isValid Validation flag.
		 * @param {String} callback.message Validation message.
		 * @param {Object} scope The scope of callback function.
		 */
		validateFilters: function(config, callback, scope) {
			let enabledSchemas;
			Terrasoft.chain(
				function(next) {
					this._getEnabledDcmSchemasByDcmSettingsId(config, next, this);
				},
				function(next, schemas) {
					enabledSchemas = schemas;
					this.getDcmSettingsFilterColumnUId(config.dcmSettingsId, next, this);
				},
				function(next, settingsFilterColumnUId) {
					if (this.getCanUseProcessVersions()) {
						Terrasoft.DcmSchemaManager.findItemByUId(config.schemaUId, function(item) {
							enabledSchemas = enabledSchemas.filterByFn(function(filterItem) {
								return filterItem.get("VersionParentUId") !== item.versionParentUId;
							}, this);
							Ext.callback(next, this, [settingsFilterColumnUId]);
						}, this);
					} else {
						Ext.callback(next, this, [settingsFilterColumnUId]);
					}
				},
				function(next, settingsFilterColumnUId) {
					const filters = this.getDeserializedFilters(config.filters);
					if (!filters && !settingsFilterColumnUId &&
							(enabledSchemas.isEmpty() || enabledSchemas.first().get("Id") === config.copySourceSchemaId)) {
						callback.call(scope, true);
						return;
					}
					const filter = filters && filters.first();
					if (filter && filter.getIsCompleted()) {
						this._validateFirstFilter({
							filters: filters,
							enabledSchemas: enabledSchemas,
							settingsFilterColumnUId: settingsFilterColumnUId,
							stageColumnUId: config.stageColumnUId,
							schemaSaveMode: config.saveMode
						}, callback, scope);
					} else {
						callback.call(scope, false, resources.localizableStrings.FilterIsNotCompletedMessage);
					}
				}, this
			);
		},

		/**
		 * Activates/Deactivates specified manager items.
		 * @param {Object} config Arguments config.
		 * @param {String[]} config.items Manager items UIds.
		 * @param {Function} callback The callback function.
		 * @param {Object} scope The scope for the callback.
		 */
		setEnabled: function(config, callback, scope) {
			const query = this.getEnabledRequest(config.items, config.enabled);
			query.execute(function(response) {
				if (response.success) {
					config.items.forEach(function(itemUId) {
						const item = this.items.find(itemUId);
						if (item) {
							item.isActive = config.enabled;
						}
					}, this);
					this.notify(this.outdatedEventName);
				}
				callback.call(scope, response);
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaManager#validateActualVersion
		 * @override
		 * @param {Object} config Arguments config.
		 * @param {Boolean} config.doNotValidate Flag indicating whether to perform validation.
		 * @param {String} config.schemaUId Dcm schema identifier.
		 * @param {String} config.filters Serialized dcm schema filters.
		 * @param {String} config.stageColumnUId Stage column identifier.
		 * @param {String} config.dcmSettingsId Section case settings identifier.
		 * @param {Function} callback The callback function.
		 * @param {Object} scope The scope of callback function.
		 */
		validateActualVersion: function(config, callback, scope) {
			if (config.doNotValidate === true) {
				callback.call(scope, true);
				return;
			}
			this.validateFilters({
				schemaUId: config.schemaUId,
				filters: config.filters,
				stageColumnUId: config.stageColumnUId,
				dcmSettingsId: config.dcmSettingsId
			}, function(isValid, validationMessage) {
				callback.call(scope, isValid, validationMessage);
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaManager#getCanUseProcessVersions
		 * @override
		 * @return {Boolean} True
		 */
		getCanUseProcessVersions: function() {
			return Terrasoft.Features.getIsEnabled("DcmCasesVersioning");
		},

		/**
		 * Returns the corresponding dcm schema info item. 
		 * @param {String} schemaUId Schema unique identifier.
		 * @param {Function} callback Callback function.
		 * @param {Object} scope Callback context.
		 */
		getSchemaInfo: function(schemaUId, callback, scope) {
			const existingInfoItem = this._dcmSchemaInfoItems.find(schemaUId);
			if (Boolean(existingInfoItem)) {
				Ext.callback(callback, scope, [existingInfoItem]);
				return;
			}
			this._fetchSchemaInfoItem(schemaUId, function(item) {
				if (item) {
					this._dcmSchemaInfoItems.add(item.uId, item);
				}
				Ext.callback(callback, scope, [item]);
			}, this);
		}

		// endregion

	});

	return Terrasoft.DcmSchemaManager;
});
