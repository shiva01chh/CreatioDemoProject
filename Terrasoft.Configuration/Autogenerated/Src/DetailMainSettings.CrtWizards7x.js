﻿define("DetailMainSettings", ["terrasoft", "BaseSectionMainSettingsResources", "DetailDesignerUtils", "DetailMainSettingsResources", "DetailManager", "DesignTimeEnums",
	"ConfigurationEnums", "ConfigurationEnumsV2", "BaseWizardStepSchemaMixin"
], function(Terrasoft, baseSectionResources) {
	return {
		messages: {

			/**
			 * @message UpdateWizardConfig
			 * Publishing message for updating wizard steps configuration.
			 */
			"UpdateWizardConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message GetPackageUId
			 * Publishing message for package identifier request.
			 */
			"GetPackageUId": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message OnAfterSave
			 * Subscribing message after detail save.
			 */
			"OnAfterSave": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message NewDetailPageCreated
			 * Publishing message after new detail page created.
			 */
			"NewDetailPageCreated": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

		},
		mixins: {
			BaseWizardStepSchemaMixin: "Terrasoft.BaseWizardStepSchemaMixin"
		},
		attributes: {

			/**
			 * Caption.
			 */
			Caption: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				size: 250,
				isRequired: true
			},

			/**
			 * Entity schema UId.
			 */
			EntitySchemaUId: {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
			},

			/**
			 * Detail manager item.
			 */
			DetailManagerItem: {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Package identifier.
			 */
			PackageUId: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Top control group header.
			 */
			TopControlGroupHeader: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: null
			},

			HasConfigurationGrid: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			},

			CanChangeGridType: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: false
			},

			IsNewDetail: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: null
			},

			IsUseExistingLookupForDetail: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: true
			},

			NewSchemaCaption: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				size: Terrasoft.DesignTimeEnums.SysModuleColumnSizes.MAX_CAPTION_SIZE,
				value: null
			},

			NewSchemaName: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				size: Terrasoft.EntitySchemaManager.getMaxEntitySchemaNameLength() -
					Terrasoft.DesignTimeEnums.SysModuleColumnSizes.MAX_ENTITY_SCHEMA_NAME_SUFFIX,
				value: Terrasoft.ClientUnitSchemaManager.schemaNamePrefix
			}
		},
		methods: {

			// region Methods: Private

			/**
			 * @private
			 */
			_generateSchemaNameUniquePart: function() {
				return Terrasoft.generateGUID().substring(0, 8);
			},

			/**
			 * @private
			 */
			_isNewDetail: function() {
				var detailManagerItem = this.get("DetailManagerItem");
				return detailManagerItem && detailManagerItem.getIsNew();
			},

			/**
			 * @private
			 */
			_validateNewSchemaNameLength: function(value, column) {
				let invalidMessage = "";
				let isValid = true;
				if (!Ext.isEmpty(value)) {
					const valueSize = value.length;
					const columnSize = column.size;
					const messageTemplate = baseSectionResources.localizableStrings.SchemaCodeIsTooLongMessage;
					isValid = valueSize <= columnSize;
					invalidMessage = isValid ? "" : Ext.String.format(messageTemplate, valueSize, columnSize);
				}
				return { invalidMessage, isValid };
			},

			/**
			 * @private
			 */
			_validateNewSchemaNameValue: function(value) {
				let invalidMessage = "";
				let isValid = true;
				if (!Ext.isEmpty(value)) {
					const regExp = new RegExp("^[a-zA-Z]{1}[a-zA-Z0-9_]{0," + value.length + "}$");
					isValid = regExp.test(value);
					invalidMessage = isValid ? "" : baseSectionResources.localizableStrings.WrongCodeMessage;
				}
				return { invalidMessage, isValid };
			},

			/**
			 * @private
			 */
			_validateNewSchemaNamePrefix: function(value) {
				const schemaNamePrefix = Terrasoft.ClientUnitSchemaManager.schemaNamePrefix;
				const prefixReqExp = new RegExp("^" + schemaNamePrefix + ".*$");
				const isValid = prefixReqExp.test(value);
				const invalidMessage = isValid ? "" : Ext.String.format(baseSectionResources.localizableStrings.WrongPrefixMessage, schemaNamePrefix);
				return {invalidMessage, isValid};
			},

			/**
			 * @private
			 */
			_updateDetailManagerItem: function({detailSchema, entitySchema}) {
				const managerItem = this.$DetailManagerItem;
				managerItem.setPropertyValue('detailSchemaName', detailSchema.getName());
				managerItem.setPropertyValue('detailSchemaUId', detailSchema.uId);
				managerItem.setPropertyValue('entitySchemaName', entitySchema.getName());
				managerItem.setPropertyValue('entitySchemaUId', entitySchema.uId);
			},

			/**
			 * @private
			 */
			_saveDetailWithNewObject: function(callback, scope) {
				let entitySchema, sysModuleEntityId, detailSchema;
				const packageUId = this.getPackageUId();
				const hasConfigurationGrid = this.get("HasConfigurationGrid");
				const data = {
					schemaCaption: this.get("NewSchemaCaption"),
					schemaName: this.get("NewSchemaName"),
					packageUId
				};
				const schemaType = Terrasoft.DetailDesignerUtils.getDetailSchemaType(hasConfigurationGrid);
				Terrasoft.chain(
					(next) => {
						Terrasoft.ApplicationStructureWizardUtils.createNewSchemaWithPrimaryDisplayColumn(data, next, this);
					},
					(next, entitySchemaArg) => {
						entitySchema = entitySchemaArg;
						const entitySchemaUId = entitySchema.uId;
						this.registerSysModuleEntity({entitySchemaUId}, next, this);
					},
					(next, sysModuleEntityArg) => {
						sysModuleEntityId = sysModuleEntityArg.id;
						const name = Terrasoft.ClientUnitSchemaManager.generateUniqueSchemaName("Schema{0}Detail");
						Terrasoft.ApplicationStructureWizardUtils.createClientUnitSchema({
							name,
							packageUId,
							entitySchema,
							caption: entitySchema.caption,
							schemaType: Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,
							parentSchemaUId: Terrasoft.DesignTimeEnums.BaseSchemaUId.BASE_GRID_DETAIL,
							bodyTemplate: Terrasoft.ClientUnitSchemaBodyTemplate[schemaType]
						}, next, this);
					},
					(next, detailSchemaArg) => {
						detailSchema = detailSchemaArg;
						this.registerSysModuleEdit({sysModuleEntityId, entitySchema}, next, this);
					},
					() => {
						this._updateDetailManagerItem({detailSchema, entitySchema});
						Ext.callback(callback, scope);
					}
				);
			},

			/**
			 * @private
			 */
			_setEntitySchemaValue: function(detailManagerItem) {
				const entitySchemaUId = detailManagerItem.getEntitySchemaUId();
				const entitySchemaItems = Terrasoft.EntitySchemaManager.getItems();
				const foundEntitySchemaItems = entitySchemaItems.filterByFn((item) => item.uId === entitySchemaUId && !item.extendParent);
				const entitySchemaItem = foundEntitySchemaItems.getByIndex(0);
				const entitySchemaLookupValue = entitySchemaItem ?
					this.getLookupValue(entitySchemaUId, entitySchemaItem.caption):
					null;
				this.set("EntitySchemaUId", entitySchemaLookupValue);
			},

			/**
			 * @private
			 */
			_onAfterSave: function() {
				const detailManagerItem = this.get("DetailManagerItem");
				this._setEntitySchemaValue(detailManagerItem);
				this.set("IsUseExistingLookupForDetail", true);
				this.set("IsNewDetail", false);
				this.sandbox.publish("NewDetailPageCreated", null, [this.sandbox.id]);
			},

			/**
			 * @private
			 */
			_isEnabledCreateDetailByNewObject: function() {
				return Terrasoft.Features.getIsDisabled("DisableCreateDetailByNewObject");
			},

			/**
			 * @private
			 */
			_isVisibleNewObjectPropertiesControlGroup: function() {
				return this._isEnabledCreateDetailByNewObject() && this.get("IsNewDetail");
			},

			// endregion

			// region Methods: Protected

			/**
			 * Initializes detail wizard main settings step.
			 * @param {Function} callback Callback.
			 * @param {Object} scope Context.
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.showBodyMask();
					this.mixins.BaseWizardStepSchemaMixin.init.call(this, function() {
						const config = {
							detailManagerItem: this.get("DetailManagerItem"),
							packageUId: this.getPackageUId()
						};
						Terrasoft.DetailDesignerUtils.getGridTypeInfo(config, (info) => {
							this.$CanChangeGridType = info.canChangeType;
							this.$HasConfigurationGrid = info.hasConfigurationGrid;
							Ext.callback(callback, scope);
						}, this);
					}, this);
				}, this]);
			},

			/**
			 * Sets top control group settings label to viewModel.
			 * @protected
			 */
			setTopControlGroupHeader: function() {
				var labelCaption = this._isNewDetail()
					? this.get("Resources.Strings.TopControlGroupSettingsNewDetailLabel")
					: this.get("Resources.Strings.TopControlGroupSettingsExistingDetaulLabel");
				this.set("TopControlGroupHeader", labelCaption);
			},

			/**
			 * Sets properties to viewModel.
			 * @protected
			 * @param {Object} config detail configuration.
			 */
			setPropertyValue: function(config) {
				var detailManagerItem = config.applicationStructureItem;
				this.setTopControlGroupHeader();
				Terrasoft.chain(
					(next) => {
						var detailCaption = detailManagerItem.getCaption() || null;
						this.set("DetailManagerItem", detailManagerItem);
						var caption = this.get("Caption");
						if (detailCaption && detailCaption !== caption) {
							this.set("Caption", detailCaption);
						}
						Terrasoft.EntitySchemaManager.initialize(next, this);
					},
					() => {
						this.set("IsNewDetail", this._isNewDetail());
						this._setEntitySchemaValue(detailManagerItem);
					}, this
				);
			},

			/**
			 * Returns EntitySchema field enabled flag.
			 * @protected
			 * @return {Boolean}
			 */
			getIsEntitySchemaFieldEnabled: function() {
				return this._isNewDetail();
			},

			/**
			 * Return lookup value by parameters.
			 * @protected
			 * @param  {String} value Value.
			 * @param {String} displayValue Display value.
			 * @return {Object}
			 */
			getLookupValue: function(value, displayValue) {
				return {
					value: value,
					displayValue: displayValue
				};
			},

			/**
			 * Fill EntitySchema list.
			 * @protected
			 * @param {String} filter Filter.
			 * @param {Terrasoft.Collection} list List.
			 */
			prepareEntitySchemaUIdList: function(filter, list) {
				if (list === null) {
					return;
				}
				list.clear();
				list.loadAll(this.getEntitySchemaUIdList());
			},

			/**
			 * Returns list of EntitySchemas.
			 * @protected
			 * @return {Object}
			 */
			getEntitySchemaUIdList: function() {
				var schemaItems = Terrasoft.EntitySchemaManager.getItems();
				schemaItems.sort("caption", Terrasoft.OrderDirection.ASC);
				var resultConfig = {};
				schemaItems.each(function(schemaItem) {
					if (schemaItem.getExtendParent()) {
						return;
					}
					var schemaUId = schemaItem.getUId();
					resultConfig[schemaUId] = {
						value: schemaUId,
						displayValue: schemaItem.getCaption()
					};
				}, this);
				return resultConfig;
			},

			/**
			 * GetModuleConfig message handler.
			 * @protected
			 */
			onGetModuleConfigResult: function(detailConfig, next, scope) {
				this.setPropertyValue(detailConfig);
				this.on("change:EntitySchemaUId", this.onEntitySchemaUIdChange, this);
				this.on("change:Caption", this.onCaptionChange, this);
				this.hideBodyMask();
				Ext.callback(next, scope);
			},

			/**
			 * EntitySchemaChange message handler.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} model ViewModel.
			 * @param {String} changedValue Changed value.
			 */
			onEntitySchemaUIdChange: function(model, changedValue) {
				var entitySchemaUId = changedValue && changedValue.value;
				var detailManagerItem = this.get("DetailManagerItem");
				detailManagerItem.setEntitySchemaUId(entitySchemaUId);
				this.sandbox.publish("UpdateWizardConfig", detailManagerItem, [this.sandbox.id]);
			},

			/**
			 * Handler for caption change event.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} model ViewModel.
			 * @param {String} changedValue Changed value.
			 */
			onCaptionChange: function(model, changedValue) {
				var detailManagerItem = this.get("DetailManagerItem");
				detailManagerItem.setCaption(changedValue);
			},

			/**
			 * Validate handler.
			 * @protected
			 */
			onValidate: function() {
				this.mixins.BaseWizardStepSchemaMixin.publishValidationResult.call(this, this.validate());
			},

			/**
			 * Validate handler.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			saveNewDetail: function(callback, scope) {
				if (this.get("IsUseExistingLookupForDetail") || !this._isNewDetail()) {
					this.detailSaveProcess(callback, scope);
				} else {
					this._saveDetailWithNewObject(callback, scope);
				}
			},

			/**
			 * Save detail.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			onSave: function(callback, scope) {
				if (this.validate()) {
					this.showBodyMask();
					Terrasoft.chain(
						function(next) {
							if (this._isEnabledCreateDetailByNewObject()) {
								this.saveNewDetail(next, this);
							} else {
								this.detailSaveProcess(next, this);
							}
						},
						function() {
							this.hideBodyMask();
							this.mixins.BaseWizardStepSchemaMixin
								.publishSavingResult.call(this, this.get("DetailManagerItem"));
							this.sandbox.subscribe("OnAfterSave", this._onAfterSave, this, [this.sandbox.id]);
							if (callback) {
								callback.call(scope);
							}
						},
						this
					);
				}
			},

			/**
			 * Method for process save detail.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			detailSaveProcess: function(callback, scope) {
				const detailManagerItem = this.get("DetailManagerItem");
				const entitySchemaUIdLookupValue = this.get("EntitySchemaUId");
				const entitySchemaUId = entitySchemaUIdLookupValue && entitySchemaUIdLookupValue.value;
				let entitySchema, sysModuleEntityId;
				const schemaUId = detailManagerItem.getDetailSchemaUId();
				Terrasoft.chain(
					function(next) {
						Terrasoft.EntitySchemaManager.getInstanceByUId(entitySchemaUId, next, this);
					},
					function(next, schema) {
						entitySchema = schema;
						if (schemaUId) {
							this.updateDetailSchema({schemaUId, entitySchema}, next, this);
							if (detailManagerItem.getIsNew()) {
								next();
							}
						} else {
							var createDetailSchemaConfig = {entitySchema: entitySchema};
							this.createDetailSchema(createDetailSchemaConfig, function(detailSchema) {
								detailManagerItem.setDetailSchemaUId(detailSchema.getPropertyValue("uId"));
								next();
							}, this);
						}
					},
					function(next) {
						detailManagerItem.getSysModuleEntityManagerItem(next, this);
					},
					function(next, sysModuleEntityManagerItem) {
						if (sysModuleEntityManagerItem) {
							next(sysModuleEntityManagerItem);
						} else {
							var registerSysModuleEntityConfig = {entitySchemaUId: entitySchemaUId};
							this.registerSysModuleEntity(registerSysModuleEntityConfig, next, this);
						}
					},
					function(next, sysModuleEntityManagerItem) {
						sysModuleEntityId = sysModuleEntityManagerItem.getId();
						sysModuleEntityManagerItem.getSysModuleEditManagerItems(next, this);
					},
					function(next, sysModuleEditManagerItems) {
						if (sysModuleEditManagerItems.getCount() > 0) {
							next();
						} else {
							var registerSysModuleEditConfig = {
								sysModuleEntityId: sysModuleEntityId,
								entitySchema: entitySchema
							};
							this.registerSysModuleEdit(registerSysModuleEditConfig, next, this);
						}
					},
					function() {
						Ext.callback(callback, scope);
					}, this
				);
			},

			/**
			 * Update detail schema by config.
			 * @protected
			 * @param {Object} config Save detail method settings.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			updateDetailSchema: function(config, callback, scope) {
				const getPackageSchemaConfig = {
					packageUId: this.getPackageUId(),
					schemaUId: config.schemaUId
				};
				const caption = this.get("Caption");
				Terrasoft.ClientUnitSchemaManager.forceGetPackageSchema(getPackageSchemaConfig, function(schema) {
					schema.localizableStrings.removeByKey("Caption");
					schema.localizableStrings.add("Caption", this.getLocalizableString(caption));
					const schemaCaption = this.getDetailSchemaCaption(caption);
					schema.setLocalizableStringPropertyValue("caption", schemaCaption);
					const schemaBody = schema.getPropertyValue("body");
					const hasConfigurationGrid = this.$HasConfigurationGrid;
					if (!schemaBody) {
						const schemaName = schema.getPropertyValue("name");
						const entitySchema = config.entitySchema;
						const entitySchemaName = entitySchema.getPropertyValue("name");
						const schemaType = Terrasoft.DetailDesignerUtils.getDetailSchemaType(hasConfigurationGrid);
						const bodyTemplate = Terrasoft.ClientUnitSchemaBodyTemplate[schemaType];
						const body = Ext.String.format(bodyTemplate, schemaName, entitySchemaName);
						schema.setPropertyValue("body", body);
					} else if (this.$CanChangeGridType) {
						const detailManagerItem = this.get("DetailManagerItem");
						Terrasoft.DetailDesignerUtils.updateDataGridType(detailManagerItem, schema, hasConfigurationGrid);
					}
					const schemaUId = schema.getPropertyValue("uId");
					if (!Terrasoft.ClientUnitSchemaManager.findItem(schemaUId)) {
						Terrasoft.ClientUnitSchemaManager.addSchema(schema);
					}
					schema.define(function() {
						callback.call(scope);
					}, this);
				}, this);
			},

			/**
			 * Method create detail schema
			 * @protected
			 * @param {Object} config Create detail config.
			 * @param {Terrasoft.EntitySchema} config.entitySchema Entity schema.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope  Callback function context.
			 * @return {Terrasoft.ClientUnitSchema} Detail schema.
			 */
			createDetailSchema: function(config, callback, scope) {
				const schemaType = Terrasoft.DetailDesignerUtils.getDetailSchemaType(this.$HasConfigurationGrid);
				const bodyTemplate =
					Terrasoft.ClientUnitSchemaBodyTemplate[schemaType];
				var entitySchema = config.entitySchema;
				var entitySchemaName = entitySchema.getPropertyValue("name");
				var packageUId = this.getPackageUId();
				Terrasoft.ClientUnitSchemaManager.initialize(function() {
					var detailSchemaNameTemplate = "Schema{0}Detail";
					var detailSchemaName = this.getClientUnitSchemaName(detailSchemaNameTemplate);
					var detailCaption = this.get("Caption");
					var detailSchemaCaption = this.getDetailSchemaCaption(detailCaption);
					var schema = Terrasoft.ClientUnitSchemaManager.createSchema({
						uId: Terrasoft.generateGUID(),
						name: detailSchemaName,
						packageUId: packageUId,
						caption: {
							"ru-RU": detailSchemaCaption
						},
						extendParent: false,
						body: Ext.String.format(bodyTemplate, detailSchemaName, entitySchemaName),
						schemaType: Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,
						parentSchemaUId: Terrasoft.DesignTimeEnums.BaseSchemaUId.BASE_GRID_DETAIL
					});
					schema.localizableStrings.add("Caption", this.getLocalizableString(detailCaption));
					Terrasoft.ClientUnitSchemaManager.addSchema(schema);
					schema.define(function() {
						callback.call(scope, schema);
					}, this);
				}, this);
			},

			/**
			 * Returns caption for detail schema.
			 * @protected
			 * @param {String} detailCaption Detail caption.
			 * @return {String} Detail schema caption.
			 */
			getDetailSchemaCaption: function(detailCaption) {
				var detailSchemaCaptionTemplate =
					this.get("Resources.Strings.DetailSchemaCaptionTemplate");
				return Ext.String.format(detailSchemaCaptionTemplate, detailCaption);
			},

			/**
			 * Returns localizable string.
			 * @protected
			 * @param {String} value String.
			 * @return {Terrasoft.LocalizableString} Localizable string.
			 */
			getLocalizableString: function(value) {
				var localizableString = Ext.create("Terrasoft.LocalizableString");
				localizableString.setValue(value);
				return localizableString;
			},

			/**
			 * Returns ClientUnitSchema name by template.
			 * @protected
			 * @param {String} schemaNameTemplate Schema name template.
			 * @return {String} Schema name.
			 */
			getClientUnitSchemaName: function(schemaNameTemplate) {
				const schemaNamePrefix = Terrasoft.ClientUnitSchemaManager.schemaNamePrefix || "";
				if (Terrasoft.useSchemaUniqueNameRandomGenerator) {
					const uniqueSchemaNamePart = this._generateSchemaNameUniquePart();
					return schemaNamePrefix + Ext.String.format(schemaNameTemplate, uniqueSchemaNamePart);
				}
				var clientUnitSchemaManagerItems = Terrasoft.ClientUnitSchemaManager.getItems();
				var schemaName;
				for (var i = 1, iterations = clientUnitSchemaManagerItems.getCount(); i < iterations; i++) {
					schemaName = schemaNamePrefix + Ext.String.format(schemaNameTemplate, i);
					var foundItems = this.findClientUnitSchemaManagerItemsByName(schemaName);
					if (foundItems.isEmpty()) {
						break;
					}
				}
				return schemaName;
			},

			/**
			 * Returns list of elements from manager of client unit schema.
			 * @protected
			 * @param {String} name Schema item name.
			 * @return {Terrasoft.Collection} Found items.
			 */
			findClientUnitSchemaManagerItemsByName: function(name) {
				var clientUnitSchemaManagerItems = Terrasoft.ClientUnitSchemaManager.getItems();
				return clientUnitSchemaManagerItems.filterByFn(function(item) {
					return item.getName() === name;
				}, this);
			},

			/**
			 * Returns package identifier.
			 * @protected
			 * @return {String} Package identifier
			 */
			getPackageUId: function() {
				var packageUId = this.get("PackageUId");
				if (!packageUId) {
					packageUId = this.sandbox.publish("GetPackageUId", null, [this.sandbox.id]);
					this.set("PackageUId", packageUId);
				}
				return packageUId;
			},

			/**
			 * Registered EntitySchema of module.
			 * @protected
			 * @param {Object} config Config.
			 * @param {String} config.entitySchemaUId Entity schema identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 * @return {Terrasoft.SysModuleEntityManagerItem} EntitySchema module item.
			 */
			registerSysModuleEntity: function(config, callback, scope) {
				var entitySchemaUId = config.entitySchemaUId;
				Terrasoft.SysModuleEntityManager.createItem(null, function(item) {
					item.setEntitySchemaUId(entitySchemaUId);
					Terrasoft.SysModuleEntityManager.addItem(item);
					callback.call(scope, item);
				}, this);
			},

			/**
			 * Method for registration cluentUntiSchema for Entity as Page.
			 * @protected
			 * @param {Object} config Config.
			 * @param {String} config.sysModuleEntityId EntitySchema module identifier.
			 * @param {Terrasoft.EntitySchema} config.entitySchema EntitySchema.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 * @return {Terrasoft.SysModuleEditManagerItem}
			 */
			registerSysModuleEdit: function(config, callback, scope) {
				var sysModuleEntityId = config.sysModuleEntityId;
				var entitySchema = config.entitySchema;
				Terrasoft.chain(
					function(next) {
						var createPageSchemaConfig = {
							entitySchema: entitySchema
						};
						this.createPageSchema(createPageSchemaConfig, next, this);
					},
					function(next, pageSchema) {
						Terrasoft.SysModuleEditManager.createItem(null, function(item) {
							item.setSysModuleEntityId(sysModuleEntityId);
							item.setCardSchemaUId(pageSchema.getPropertyValue("uId"));
							var entitySchemaCaption = this.getEntitySchemaCaption(entitySchema);
							this.setSysModuleEditManagerItemCaption(item, pageSchema, entitySchemaCaption);
							Terrasoft.SysModuleEditManager.addItem(item);
							callback.call(scope, item);
						}, this);
					},
					this
				);
			},

			/**
			 * Sets sysModuleEditManagerItem caption.
			 * @protected
			 * @param {Terrasoft.SysModuleEditManagerItem} item Manager item.
			 * @param {Terrasoft.ClientUnitSchemaManagerItem} pageSchema ClientUnitSchemaManagerItem.
			 * @param {String} entitySchemaCaption Entity schema caption.
			 */
			setSysModuleEditManagerItemCaption: function(item, pageSchema, entitySchemaCaption) {
				var dataManagerItem = item.getDataManagerItem();
				var column = dataManagerItem.getColumnByName("PageCaption");
				var size = column.size;
				var pageSchemaCaption = this.getPageSchemaCaption(pageSchema);
				if (pageSchemaCaption.length > size) {
					var extraSize = pageSchemaCaption.length - size;
					pageSchemaCaption = this.getShortCutPageCaption(entitySchemaCaption, extraSize);
					this.updateNewPageSchemaCaptionByUId(pageSchemaCaption, pageSchema.uId);
				}
				item.setPageCaption(pageSchemaCaption);
			},

			/**
			 * Update new page schema caption.
			 * @protected
			 * @param {String} newCaption New page schema caption.
			 * @param {String} pageSchemaUId New page schema uId.
			 */
			updateNewPageSchemaCaptionByUId: function(newCaption, pageSchemaUId) {
				var newPageSchema = Terrasoft.ClientUnitSchemaManager.getItem(pageSchemaUId);
				newPageSchema.setLocalizableStringPropertyValue("caption", newCaption);
				newPageSchema.caption = newCaption;
			},

			/**
			 * Returns page schema caption.
			 * @param {Terrasoft.ClientUnitSchemaManagerItem} pageSchema ClientUnitSchemaManagerItem.
			 * @return {String} ClientUnitSchemaManagerItem page caption.
			 */
			getPageSchemaCaption: function(pageSchema) {
				var pageCaptionLcz = pageSchema.getPropertyValue("caption");
				return pageCaptionLcz.getValue();
			},

			/**
			 * Returns shortcut caption.
			 * @protected
			 * @param {String} entitySchemaCaption Entity schema caption.
			 * @param {Number} extraSize Extra size.
			 * @return {String} Shortcut caption.
			 */
			getShortCutPageCaption: function(entitySchemaCaption, extraSize) {
				extraSize += 1;
				var slicedEntitySchemaCaption = entitySchemaCaption.slice(0, -extraSize);
				return Ext.String.format(this.get("Resources.Strings.DetailPageCaptionTemplate"),
					slicedEntitySchemaCaption + "\u2026");
			},

			/**
			 * Returns entity schema caption.
			 * @param {Object} entitySchema Entity schema.
			 * @return {String} Entity schema page caption
			 */
			getEntitySchemaCaption: function(entitySchema) {
				var entitySchemaCaptionLcz = entitySchema.getPropertyValue("caption");
				return entitySchemaCaptionLcz.getValue();
			},

			/**
			 * Create ClientUnitSchema of Page.
			 * @protected
			 * @param {Object} config Config.
			 * @param {Terrasoft.EntitySchema} config.entitySchema EntitySchema.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 * @return {Terrasoft.ClientUnitSchema} ClientUnitSchema of Page.
			 */
			createPageSchema: function(config, callback, scope) {
				var bodyTemplate =
					Terrasoft.ClientUnitSchemaBodyTemplate[Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA];
				var entitySchema = config.entitySchema;
				var entitySchemaName = entitySchema.getPropertyValue("name");
				var packageUId = this.getPackageUId();
				Terrasoft.ClientUnitSchemaManager.initialize(function() {
					var pageSchemaNameTemplate = entitySchemaName + "{0}Page";
					var pageSchemaName = this.getClientUnitSchemaName(pageSchemaNameTemplate);
					var entitySchemaCaptionLcz = entitySchema.getPropertyValue("caption");
					var entitySchemaCaption = entitySchemaCaptionLcz.getValue();
					var detailPageCaptionTemplate =
						this.get("Resources.Strings.DetailPageCaptionTemplate");
					var detailPageCaption = Ext.String.format(detailPageCaptionTemplate, entitySchemaCaption);
					var schema = Terrasoft.ClientUnitSchemaManager.createSchema({
						uId: Terrasoft.generateGUID(),
						name: pageSchemaName,
						packageUId: packageUId,
						caption: {},
						body: Ext.String.format(bodyTemplate, pageSchemaName, entitySchemaName),
						schemaType: Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,
						parentSchemaUId: Terrasoft.DesignTimeEnums.BaseSchemaUId.BASE_PAGE
					});
					schema.setLocalizableStringPropertyValue("caption", detailPageCaption);
					Terrasoft.ClientUnitSchemaManager.addSchema(schema);
					schema.define(function() {
						callback.call(scope, schema);
					}, this);
				}, this);
			},

			/**
			 * @inheritDoc BaseSchemaViewModel#setValidationConfig
			 * @override
			 */
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("Caption", this.captionLengthValidator);
				if (this._isEnabledCreateDetailByNewObject()) {
					this.addColumnValidator("NewSchemaCaption", this.captionLengthValidator);
					this.addColumnValidator("NewSchemaName", this._validateNewSchemaNamePrefix);
					this.addColumnValidator("NewSchemaName", this._validateNewSchemaNameLength);
					this.addColumnValidator("NewSchemaName", this._validateNewSchemaNameValue);
				}
			},

			/**
			 * Method for validate detail caption length.
			 * @protected
			 * @param {String} value Caption value.
			 * @param {Object} column Column.
			 * @return {Object} Response of validate.
			 */
			captionLengthValidator: function(value, column) {
				var result = {
					invalidMessage: ""
				};
				if (Ext.isEmpty(value)) {
					return result;
				}
				var size = column.size;
				var valueSize = value.length;
				if (valueSize > size) {
					var message = Terrasoft.Resources.BaseViewModel.columnIncorrectTextRangeValidationMessage;
					message += " (" + valueSize + "/" + size + ")";
					result.invalidMessage = message;
				}
				return result;
			},

			/**
			 * Returns caption of enable grid control.
			 * @return {String}
			 */
			getEnableGridCaption: function() {
				return Terrasoft.DetailDesignerUtils.getEnableGridCaption();
			},

			/**
			 * Returns true if feature DisableEditableDetailOption is disabled.
			 * @return {Boolean}
			 */
			getShowEditableDetailOption: function() {
				return Terrasoft.Features.getIsDisabled("DisableEditableDetailOption");
			}

			// endregion

		},
		diff: [
			{
				"operation": "insert",
				"name": "DetailPropertiesControlGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["detail-properties-control-group-container"],
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "TopControlGroupText",
				"parentName": "DetailPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "TopControlGroupHeader"},
					"labelClass": ["top-control-group-label"]
				}
			},
			{
				"operation": "insert",
				"name": "Caption",
				"parentName": "DetailPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"bindTo": "Caption",
					"labelConfig": {
						"visible": true,
						"caption": {"bindTo": "Resources.Strings.CaptionLabel"}
					}
				}
			},

			{
				"operation": "insert",
				"name": "NewObjectPropertiesControlGroup",
				"propertyName": "items",
				"parentName": "DetailPropertiesControlGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"visible": {
						"bindTo": "_isVisibleNewObjectPropertiesControlGroup",
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "IsUseExistingLookupForDetailCaption",
				"parentName": "NewObjectPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.IsUseExistingLookupForDetailCaption"},
				}
			},
			{
				"operation": "insert",
				"name": "IsUseExistingLookupForDetail",
				"parentName": "NewObjectPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"value": {"bindTo": "IsUseExistingLookupForDetail"},
					"itemType": Terrasoft.ViewItemType.RADIO_GROUP,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "IsUseExistingLookupForDetail",
				"propertyName": "items",
				"name": "IsUseExistingLookupForDetailTrue",
				"values": {
					"caption": {"bindTo": "Resources.Strings.IsUseExistingLookupForDetailTrueCaption"},
					"markerValue": "IsUseExistingLookupForDetailTrue",
					"value": true
				}
			},
			{
				"operation": "insert",
				"parentName": "IsUseExistingLookupForDetail",
				"propertyName": "items",
				"name": "IsUseExistingLookupForDetailFalse",
				"values": {
					"caption": {"bindTo": "Resources.Strings.IsUseExistingLookupForDetailFalseCaption"},
					"markerValue": "IsUseExistingLookupForDetailFalse",
					"value": false
				}
			},

			{
				"operation": "insert",
				"name": "NewSchemaCaption",
				"parentName": "NewObjectPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"labelConfig": {
						"caption": {"bindTo": "Resources.Strings.CaptionLabel"}
					},
					"isRequired": {
						"bindTo": "IsUseExistingLookupForDetail",
						"bindConfig": { "converter": "invertBooleanValue" }
					},
					"visible": {
						"bindTo": "IsUseExistingLookupForDetail",
						"bindConfig": { "converter": "invertBooleanValue" }
					}
				}
			},
			{
				"operation": "insert",
				"name": "NewSchemaName",
				"parentName": "NewObjectPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"labelConfig": {
						"caption": {"bindTo": "Resources.Strings.CodeLabel"}
					},
					"isRequired": {
						"bindTo": "IsUseExistingLookupForDetail",
						"bindConfig": { "converter": "invertBooleanValue" }
					},
					"visible": {
						"bindTo": "IsUseExistingLookupForDetail",
						"bindConfig": { "converter": "invertBooleanValue" }
					}
				}
			},
			{
				"operation": "insert",
				"name": "EntitySchemaUId",
				"parentName": "DetailPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"visible": {
						"bindTo": "IsUseExistingLookupForDetail"
					},
					"isRequired": {
						"bindTo": "IsUseExistingLookupForDetail",
					},
					"dataValueType": Terrasoft.DataValueType.ENUM,
					"enabled": { "bindTo": "IsNewDetail"},
					"labelConfig": {
						"caption": {"bindTo": "Resources.Strings.entitySchemaLabel"}
					},
					"controlConfig": {
						"prepareList": {"bindTo": "prepareEntitySchemaUIdList"}
					}
				}
			},
			{
				"operation": "insert",
				"name": "IsEditable",
				"parentName": "DetailPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"enabled": {"bindTo": "CanChangeGridType"},
					"visible": {"bindTo": "getShowEditableDetailOption"},
					"controlConfig": {
						"className": "Terrasoft.CheckBoxEdit",
						"checked": {"bindTo": "HasConfigurationGrid"}
					},
					"caption": {"bindTo": "getEnableGridCaption"},
					"wrapClass": ["style-input", "reverse-label"]
				}
			}
		]
	};
});
