﻿define("BusinessRuleBindParameterActionDesignerViewModel", ["BusinessRuleBindParameterActionDesignerViewModelResources",
	"BusinessRuleElementDesignerViewModel", "BusinessRuleActionDesignerViewModel", "ExpressionEditVMMixin",
	"BusinessRuleVisibleItemActionWebComponent"
], function(resources) {

	Ext.define("Terrasoft.BusinessRuleBindParameterActionDesignerViewModel", {
		extend: "Terrasoft.BusinessRuleActionDesignerViewModel",
		alternateClassName: "Terrasoft.Designers.BusinessRuleBindParameterActionDesignerViewModel",

		mixins: {
			customEvent: "Terrasoft.mixins.CustomEventDomMixin",
			ExpressionEditVMMixin: "Terrasoft.ExpressionEditVMMixin"
		},

		setItemTypesEventName: "setItemTypesList",
		getItemTypesEventName: "getItemTypesList",
		setDetailsListEventName: "setDetailsList",
		getDetailsListEventName: "getDetailsList",
		setFieldsListEventName: "setFieldsList",
		getFieldsListEventName: "getFieldsList",
		setParametersListEventName: "setParametersList",
		getParametersListEventName: "getParametersList",
		setDataSourcesListEventName: "setDataSourcesList",
		getDataSourcesListEventName: "getDataSourcesList",
		setGroupsListEventName: "setGroupsList",
		getGroupsListEventName: "getGroupsList",
		setTabsListEventName: "setTabsList",
		getTabsListEventName: "getTabsList",
		setModulesListEventName: "setModulesList",
		getModulesListEventName: "getModulesList",
		setAttributesListEventName: "setAttributesList",
		getAttributesListEventName: "getAttributesList",
		setBusinessRuleActionEventName: "setBusinessRuleAction",
		getBusinessRuleActionEventName: "getBusinessRuleAction",
		setBusinessRuleActionCaptionEventName: "setBusinessRuleActionCaption",
		getBusinessRuleActionCaptionEventName: "getBusinessRuleActionCaption",

		//region Methods: Private

		/**
		 * @private
		 */
		_getExpressionTypeList: function() {
			if (this.isEntitySchemaBased()) {
				return [
					Terrasoft.ExpressionEnums.ExpressionType.COLUMN,
					Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE
				];
			} else {
				const types = [Terrasoft.ExpressionEnums.ExpressionType.PARAMETER];
				const dataSource = Terrasoft.BusinessRuleSchemaManager.getDataSourcesConfig(this.pageSchemaUId);
				if (!Terrasoft.isEmptyObject(dataSource)) {
					types.push(Terrasoft.ExpressionEnums.ExpressionType.DATASOURCE);
				}
				types.push(Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE);
				return types;
			}
		},

		/**
		 * @private
		 */
		_convertExpressionTypeToActionSourceType: function(expressionType) {
			switch (expressionType) {
				case Terrasoft.ExpressionEnums.ExpressionType.COLUMN:
					return Terrasoft.BusinessRuleActionSourceType.COLUMN_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.PARAMETER:
					return Terrasoft.BusinessRuleActionSourceType.PARAMETER_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE:
					return Terrasoft.BusinessRuleActionSourceType.ATTRIBUTE_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.GROUP:
					return Terrasoft.BusinessRuleActionSourceType.COUNTROL_GROUP_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.MODULE:
					return Terrasoft.BusinessRuleActionSourceType.MODULE_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.TAB:
					return Terrasoft.BusinessRuleActionSourceType.TAB_SOURCE;
				case Terrasoft.ExpressionEnums.ExpressionType.DETAIL:
					return Terrasoft.BusinessRuleActionSourceType.DETAIL_SOURCE;
				default:
					return null;
			}
		},

		/**
		 * @private
		 */
		_convertActionSourceTypeToExpressionType: function(sourceType) {
			switch (sourceType) {
				case Terrasoft.BusinessRuleActionSourceType.COLUMN_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.COLUMN;
				case Terrasoft.BusinessRuleActionSourceType.PARAMETER_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.PARAMETER;
				case Terrasoft.BusinessRuleActionSourceType.ATTRIBUTE_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE;
				case Terrasoft.BusinessRuleActionSourceType.DETAIL_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.DETAIL;
				case Terrasoft.BusinessRuleActionSourceType.TAB_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.TAB;
				case Terrasoft.BusinessRuleActionSourceType.MODULE_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.MODULE;
				case Terrasoft.BusinessRuleActionSourceType.COUNTROL_GROUP_SOURCE:
					return Terrasoft.ExpressionEnums.ExpressionType.GROUP;
				default:
					return null;
			}
		},

		/**
		 * @private
		 */
		_prepareEntitySchemaColumnExpression: function(config, callback, scope) {
			const fnConfig = {
				entitySchemaUId: this.getEntitySchemaUId(config.dataModelName),
				packageUId: this.packageUId,
				columnName: config.columnName
			};
			this.getEntitySchemaColumnLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaParameterExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				packageUId: this.packageUId,
				parameterName: config.parameterName
			};
			this.getPageSchemaParameterLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaAttributeExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				attributeName: config.attributeName
			};
			this.getAttributeLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaDetailExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				detailName: config.detailName
			};
			this.getDetailLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaModuleExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				moduleName: config.moduleName
			};
			this.getModuleLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaGroupExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				groupName: config.groupName
			};
			this.getGroupLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_preparePageSchemaTabExpression: function(config, callback, scope) {
			const fnConfig = {
				pageSchemaUId: this.pageSchemaUId,
				tabName: config.tabName
			};
			this.getTabLookupValue(fnConfig, function(lookupValue) {
				callback.call(scope, lookupValue);
			}, this);
		},

		/**
		 * @private
		 */
		_convertToLookupArray: function(collection) {
			const result = [];
			if (!collection || collection.getCount() < 1) {
				return result;
			}
			collection.each(function(item) {
				result.push({
					value: item.value,
					name: item.name,
					displayValue: item.displayValue
				});
			});
			return result;
		},

		/**
		 * @private
		 */
		_subscribeGetItems: function(getItemsEventName, setItemsEventName, prepareItemsMethod) {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const itemsCollection = new Terrasoft.Collection();
			const dataGetterConfig = {
				pageSchemaUId: this.pageSchemaUId
			};
			const subscription = customEvent
				.subscribe(getItemsEventName)
				.subscribe(function() {
					Terrasoft.chain(
						function(next) {
							prepareItemsMethod.call(self, dataGetterConfig, itemsCollection, next);
						},
						function() {
							customEvent.publish(setItemsEventName, self._convertToLookupArray(itemsCollection));
						}, this);
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_getSubscriptions: function() {
			if (!this._subscriptions) {
				this._subscriptions = [];
			}
			return this._subscriptions;
		},

		/**
		 * @private
		 */
		_addSubscription: function(subscription) {
			const subscriptions = this._getSubscriptions();
			subscriptions.push(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetBusinessRuleAction: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const subscription = customEvent
				.subscribe(this.getBusinessRuleActionEventName)
				.subscribe(function() {
					customEvent.publish(self.setBusinessRuleActionEventName, self.getBusinessRuleAction());
				});
			this._addSubscription(subscription);
		},

		_subscribeGetBusinessRuleActionCaption: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const subscription = customEvent
				.subscribe(this.getBusinessRuleActionCaptionEventName)
				.subscribe(function() {
					customEvent.publish(self.setBusinessRuleActionCaptionEventName, self.getBusinessRuleActionCaption());
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetTypesList: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const subscription = customEvent
				.subscribe(this.getItemTypesEventName)
				.subscribe(function() {
					customEvent.publish(self.setItemTypesEventName, self.prepareTypesList());
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetDetails: function() {
			this._subscribeGetItems(
				this.getDetailsListEventName,
				this.setDetailsListEventName,
				this.prepareDetailsList);
		},

		/**
		 * @private
		 */
		_subscribeGetFields: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const itemsCollection = new Terrasoft.Collection();
			const subscription = customEvent
				.subscribe(this.getFieldsListEventName)
				.subscribe(function() {
					Terrasoft.chain(
						function(next) {
							self.prepareExpressionEntitySchemaColumnList('', itemsCollection, next);
						},
						function() {
							customEvent.publish(self.setFieldsListEventName, self._convertToLookupArray(itemsCollection));
						}, this);
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetParameters: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const itemsCollection = new Terrasoft.Collection();
			const subscription = customEvent
				.subscribe(this.getParametersListEventName)
				.subscribe(function() {
					Terrasoft.chain(
						function(next) {
							self.prepareExpressionPageSchemaParameterList('', itemsCollection, next);
						},
						function() {
							customEvent.publish(self.setParametersListEventName, self._convertToLookupArray(itemsCollection));
						}, this);
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetDataSources: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const itemsCollection = new Terrasoft.Collection();
			const subscription = customEvent
				.subscribe(this.getDataSourcesListEventName)
				.subscribe(function() {
					self.loadDataSources(itemsCollection);
					customEvent.publish(self.setDataSourcesListEventName, self._convertToLookupArray(itemsCollection));
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetGroups: function() {
			this._subscribeGetItems(
				this.getGroupsListEventName,
				this.setGroupsListEventName,
				this.prepareGroupsList);
		},

		/**
		 * @private
		 */
		_subscribeGetTabs: function() {
			this._subscribeGetItems(
				this.getTabsListEventName,
				this.setTabsListEventName,
				this.prepareTabsList);
		},

		/**
		 * @private
		 */
		_subscribeGetAttributes: function() {
			const self = this;
			const customEvent = this.mixins.customEvent;
			const itemsCollection = new Terrasoft.Collection();
			const subscription = customEvent
				.subscribe(this.getAttributesListEventName)
				.subscribe(function() {
					Terrasoft.chain(
						function(next) {
							self.prepareExpressionAttributesList('', itemsCollection, next);
						},
						function() {
							customEvent.publish(self.setAttributesListEventName, self._convertToLookupArray(itemsCollection));
						}, this);
				});
			this._addSubscription(subscription);
		},

		/**
		 * @private
		 */
		_subscribeGetModules: function() {
			this._subscribeGetItems(
				this.getModulesListEventName,
				this.setModulesListEventName,
				this.prepareModulesList);
		},

		/**
		 * @private
		 */
		_subscribeCustomEvents: function() {
			this.mixins.customEvent.init();
			this._subscribeGetBusinessRuleActionCaption();
			this._subscribeGetBusinessRuleAction();
			this._subscribeGetTypesList();
			this._subscribeGetDetails();
			this._subscribeGetFields();
			this._subscribeGetParameters();
			this._subscribeGetDataSources();
			this._subscribeGetGroups();
			this._subscribeGetTabs();
			this._subscribeGetAttributes();
			this._subscribeGetModules();
		},

		//endregion

		//region Methods: Protected

		/**
		 * @inheritDoc Terrasoft.BaseModel#getModelColumns
		 * @overridden
		 */
		getModelColumns: function() {
			const baseColumns = this.callParent(arguments);
			return this.Ext.apply(baseColumns, {
				"ExpressionItem": {
					"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.core.enums.DataValueType.LOOKUP,
					"value": null,
					"isRequired": true
				},
				"ExpressionItemHint": {
					"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.core.enums.DataValueType.TEXT,
					"value": null
				},
				"ExpressionType": {
					"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.core.enums.DataValueType.TEXT,
					"value": null
				},
				"ExpressionDataModelName": {
					"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.core.enums.DataValueType.TEXT,
					"value": null
				},
				"BusinessRuleMetaItemId": {
					"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
					"dataValueType": Terrasoft.core.enums.DataValueType.GUID,
					"value": null
				}
			});
		},

		/**
		 * Returns left expression items.
		 * @return {Array} Left expression items.
		 */
		getExpressionItem: function() {
			return [{
				"className": "Terrasoft.ExpressionEdit",
				"expressionType": {"bindTo": "ExpressionType"},
				"expressionTypeList": this._getExpressionTypeList(),
				"loadDataSources": {"bindTo": "loadDataSources"},
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"dataModelName": {"bindTo": "ExpressionDataModelName"},
				"placeholder": resources.localizableStrings.ExpressionPlaceholder,
				"wrapClass": "bind-action-expression",
				"contentType": Terrasoft.ContentType.ENUM,
				"prepareEntitySchemaColumnList": {"bindTo": "prepareExpressionEntitySchemaColumnList"},
				"prepareAttributesList": {"bindTo": "prepareExpressionAttributesList"},
				"preparePageSchemaParameterList": {"bindTo": "prepareExpressionPageSchemaParameterList"},
				"value": {"bindTo": "ExpressionItem"}
			}];
		},

		getBusinessRuleVisibleItemActionWebComponent: function() {
			this._subscribeCustomEvents();
			return [{
				"className": "Terrasoft.BusinessRuleVisibleItemActionWebComponent",
				"actionId": {"bindTo": "BusinessRuleMetaItemId"},
				"clear": {"bindTo": "onRemoveButtonClick"},
				"actionChanged": {"bindTo": "onActionChanged"}
			}];
		},

		onRemoveButtonClick: function() {
			this.callParent(arguments);
			const subscriptions = this._getSubscriptions();
			subscriptions.forEach(function(subscription) {
				subscription.unsubscribe();
			}, this);
		},

		onActionChanged: function(actionItem) {
			this.$ExpressionItem = {
				name: actionItem.attributeName
			};
			this.$ExpressionType = actionItem.expressionType;
			this.$ExpressionDataModelName = actionItem.dataModelName;
		},

		/**
		 * @inheritDoc Terrasoft.BusinessRuleActionDesignerViewModel#getActionTitle
		 * @overridden
		 */
		getActionTitle: function() {
			const type = this.get("MetaItemType");
			if (this.Ext.isDefined(type)) {
				const element = Terrasoft.BusinessRuleElementHelper.getElementByType(type);
				return element.designConfig.listCaption;
			}
		},

		/**
		 * Sets expression hint.
		 * @protected
		 */
		setExpressionHint: function() {
			const type = this.get("MetaItemType");
			if (this.Ext.isDefined(type)) {
				const element = Terrasoft.BusinessRuleElementHelper.getElementByType(type);
				const value = element.designConfig.hint;
				this.set("ExpressionItemHint", value);
			}
		},

		/**
		 * @inheritDoc Terrasoft.BusinessRuleElementDesignerViewModel#getAsyncValidateList
		 * @overridden
		 */
		getAsyncValidators: function() {
			const validationMethods = this.callParent();
			validationMethods.push(this.validateBindParameterAction);
			return validationMethods;
		},

		/**
		 * Validates bind parameter action.
		 * @protected
		 * @param {Function} callback Callback function.
		 * @param {Object} validationInfo Validation information.
		 * @param {Boolean} validationInfo.isValid Is view model valid.
		 * @param {Array} validationInfo.messageList Validation message array.
		 */
		validateBindParameterAction: function(callback, validationInfo) {
			const config = {
				expressionType: this.$ExpressionType,
				value: this.$ExpressionItem && this.$ExpressionItem.name,
				columnCaption: this.get("DefaultExpressionCaption"),
				validationInfo: validationInfo
			};
			this.asyncValidateExpression(config, function() {
				callback(validationInfo);
			}, this);
		},

		/**
		 * Sets expression value.
		 * @protected
		 * @param {Function} callback Callback function.
		 * @param {Object} scope Callback function scope.
		 */
		setExpressionValue: function(callback, scope) {
			const metaItem = this.getMetaItem();
			if (metaItem) {
				const attributeName = metaItem.getPropertyValue("attributeName");
				const sourceType = metaItem.getPropertyValue("sourceType");
				const expressionDataModelName = metaItem.getPropertyValue("dataModelName");
				const expressionType = this._convertActionSourceTypeToExpressionType(sourceType);
				Terrasoft.chain(
					function(next) {
						if (attributeName) {
							switch (expressionType) {
								case Terrasoft.ExpressionEnums.ExpressionType.COLUMN:
									this._prepareEntitySchemaColumnExpression({
										dataModelName: expressionDataModelName,
										columnName: attributeName
									}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.PARAMETER:
									this._preparePageSchemaParameterExpression({parameterName: attributeName}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE:
									this._preparePageSchemaAttributeExpression({attributeName: attributeName}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.DETAIL:
									this._preparePageSchemaDetailExpression({
										detailName: attributeName
									}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.MODULE:
									this._preparePageSchemaModuleExpression({
										moduleName: attributeName
									}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.GROUP:
									this._preparePageSchemaGroupExpression({
										groupName: attributeName
									}, next, this);
									break;
								case Terrasoft.ExpressionEnums.ExpressionType.TAB:
									this._preparePageSchemaTabExpression({
										tabName: attributeName
									}, next, this);
									break;
								default:
									next();
							}
						} else {
							next();
						}
					},
					function(next, expression) {
						this.$ExpressionType = expressionType;
						this.$ExpressionDataModelName = expressionDataModelName;
						this.$ExpressionItem = expression;
						this.$BusinessRuleMetaItemId = metaItem.instanceId;
						callback.call(scope);
					},
					this
				);
			}
		},

		/**
		 * @inheritDoc Terrasoft.BusinessRuleElementDesignerViewModel#getMetaItemUpdaters
		 * @overridden
		 */
		getMetaItemUpdaters: function() {
			const updaters = this.callParent(arguments);
			updaters.push(this.updateBindParameterMetaItem);
			return updaters;
		},

		/**
		 * @inheritDoc Terrasoft.BusinessRuleElementDesignerViewModel#getConfigForEmptyMetaItem
		 * @overridden
		 */
		getConfigForEmptyMetaItem: function() {
			const result = this.callParent();
			if (this.isEntitySchemaBased()) {
				Ext.apply(result, {
					attributeName: null,
					sourceType: Terrasoft.BusinessRuleActionSourceType.COLUMN_SOURCE,
					dataModelName: this.getFirstEntitySchemaName()
				});
			} else {
				Ext.apply(result, {
					attributeName: null,
					sourceType: Terrasoft.BusinessRuleActionSourceType.PARAMETER_SOURCE,
					dataModelName: null
				});
			}
			return result;
		},

		/**
		 * Updates bind parameter meta item.
		 * @protected
		 * @param {Function} callback Callback function.
		 * @param {Object} metaItem Meta item.
		 */
		updateBindParameterMetaItem: function(callback, metaItem) {
			const attributeName = this.$ExpressionItem.name;
			const sourceType = this._convertExpressionTypeToActionSourceType(this.$ExpressionType);
			const dataModelName = this.$ExpressionDataModelName;
			metaItem.setPropertyValue("attributeName", attributeName);
			metaItem.setPropertyValue("sourceType", sourceType);
			metaItem.setPropertyValue("dataModelName", dataModelName);
			callback.call(this);
		},

		//endregion

		//region Methods: Public

		/**
		 * @inheritDoc Terrasoft.BaseObject#constructor
		 * @overridden
		 */
		constructor: function() {
			this.callParent(arguments);
			this.setExpressionHint();
			this.setExpressionValue(Terrasoft.emptyFn, this);
		},

		/**
		 * @inheritDoc Terrasoft.BusinessRuleActionDesignerViewModel#enrichViewConfig
		 * @overridden
		 */
		enrichViewConfig: function(config) {
			this.callParent(arguments);
			let showAngularBusinessRuleActionComponent = false;
			if (this.$MetaItemType === "VisibilityBusinessRuleAction") {
				showAngularBusinessRuleActionComponent =
					!Terrasoft.Features.getIsEnabled("DontUseAngularBusinessRuleActionComponent");
			}
			Ext.apply(config, {
				"showAngularBusinessRuleActionComponent": showAngularBusinessRuleActionComponent,
				"businessRuleActionWebComponent": this.getBusinessRuleVisibleItemActionWebComponent(),
				"expressionItemHint": {"bindTo": "ExpressionItemHint"}
			});
			if (!showAngularBusinessRuleActionComponent) {
				Ext.apply(config, {
					"expressionItem": this.getExpressionItem()
				});
			}
		},

		/**
		 * Prepares data source list.
		 * @param {Terrasoft.Collection} list Collection to fill with data source.
		 */
		loadDataSources: function(list) {
			if (list) {
				const dataSource = Terrasoft.BusinessRuleSchemaManager.getDataSourcesConfig(this.pageSchemaUId);
				list.reloadAll(dataSource);
			}
		},

		/**
		 * Prepares entity schema column list.
		 * @param {String} filter Column search value.
		 * @param {Terrasoft.Collection} list Entity schema column list.
		 * @param {Function} callback Callback function
		 */
		prepareExpressionEntitySchemaColumnList: function(filter, list, callback) {
			const builder = Ext.create("Terrasoft.BusinessRuleExpressionDataQueryBuilder");
			const entitySchemaUId = this.getEntitySchemaUId(this.$ExpressionDataModelName);
			this.mixins.ExpressionEditVMMixin.prepareEntitySchemaColumnList.call(this, {
				entitySchemaUId: entitySchemaUId,
				packageUId: this.packageUId
			}, {
				filterValue: filter,
				filterFns: [builder.buildSupportedDataValueTypeFilter()]
			}, list, callback);
		},

		/**
		 * Prepares page schema parameter list.
		 * @param {String} filter Parameter search value.
		 * @param {Terrasoft.Collection} list Parameter list.
		 * @param {Function} callback Callback function
		 */
		prepareExpressionPageSchemaParameterList: function(filter, list, callback) {
			const builder = Ext.create("Terrasoft.BusinessRuleExpressionDataQueryBuilder");
			this.mixins.ExpressionEditVMMixin.preparePageSchemaParameterList.call(this, {
				pageSchemaUId: this.pageSchemaUId,
				packageUId: this.packageUId
			}, {
				filterValue: filter,
				filterFns: [builder.buildNonSystemPageSchemaParameterFilter()]
			}, list, callback);
		},

		/**
		 * Prepares attributes list.
		 * @param {String} filter Attribute search value.
		 * @param {Terrasoft.Collection} list Attributes list.
		 * @param {Function} callback Callback function
		 */
		prepareExpressionAttributesList: function(filter, list, callback) {
			const pageSchemaUId = this.forceGetPageSchemaUId();
			if (pageSchemaUId) {
				const builder = Ext.create("Terrasoft.BusinessRuleExpressionDataQueryBuilder");
				this.mixins.ExpressionEditVMMixin.prepareAttributesList.call(this, {
					pageSchemaUId: pageSchemaUId
				}, {
					filterValue: filter,
					filterFns: [builder.buildSupportedDataValueTypeFilter()]
				}, list, callback);
			} else {
				Terrasoft.showInformation(resources.localizableStrings.FillPageSchemaWarning);
			}
		},

		getBusinessRuleActionCaption: function() {
			return this.getActionTitle();
		},

		getBusinessRuleAction: function() {
			const metaItem = this.$MetaItem;
			const expressionItem = this.$ExpressionItem;
			return {
				id: this.$BusinessRuleMetaItemId,
				enabled: metaItem.enabled,
				attributeName: metaItem.attributeName,
				attributeId: expressionItem ? expressionItem.value : null,
				dataModelName: metaItem.dataModelName,
				expressionType: this.$ExpressionType,
				description: metaItem.description
			};
		},

		/**
		 * Prepares type list.
		 */
		prepareTypesList: function() {
			const types = [{
					value: Terrasoft.ExpressionEnums.ExpressionType.DETAIL,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Detail
				}, {
					value: Terrasoft.ExpressionEnums.ExpressionType.MODULE,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Module
				}, {
					value: Terrasoft.ExpressionEnums.ExpressionType.ATTRIBUTE,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Attribute
				}, {
					value: Terrasoft.ExpressionEnums.ExpressionType.GROUP,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Group
				}, {
					value: Terrasoft.ExpressionEnums.ExpressionType.TAB,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Tab
				}];
			if (this.isEntitySchemaBased()) {
				const dataSource = Object.values(Terrasoft.BusinessRuleSchemaManager.getDataSourcesConfig(this.pageSchemaUId));
				types.unshift({
					value: Terrasoft.ExpressionEnums.ExpressionType.COLUMN,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Column,
					dataModelName: dataSource[0] ? dataSource[0].value : null
				});
			} else {
				const dataSources = Terrasoft.BusinessRuleSchemaManager.getDataSourcesConfig(this.pageSchemaUId);
				if (!Terrasoft.isEmptyObject(dataSources)) {
					types.unshift({
						value: Terrasoft.ExpressionEnums.ExpressionType.DATASOURCE,
						displayValue: Terrasoft.Resources.BusinessRules.Expression.DataSources,
						items: Object.values(dataSources).map(function(dataSource) {
							return {
								value: Terrasoft.ExpressionEnums.ExpressionType.COLUMN,
								displayValue: dataSource.displayValue,
								dataModelName: dataSource.value,
							};
						})
					});
				}
				types.unshift({
					value: Terrasoft.ExpressionEnums.ExpressionType.PARAMETER,
					displayValue: Terrasoft.Resources.BusinessRules.Expression.Parameter
				});
			}
			return types;
		},

		/**
		 * @override
		 */
		onDestroy: function() {
			this.mixins.customEvent.destroy();
			this.callParent(arguments);
		}

		//endregion
	});
	return Terrasoft.BusinessRuleBindParameterActionDesignerViewModel;
});
