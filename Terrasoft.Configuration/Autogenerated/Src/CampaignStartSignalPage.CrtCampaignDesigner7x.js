define("CampaignStartSignalPage", ["LookupUtilities", "MultilineLabel", "CampaignElementTemplateMixin",
		"ContainerReadOnlyControlsMixin", "css!MultilineLabel"], function(LookupUtilities) {
	return {
		mixins: {
			parametrizedProcessSchemaElement: "Terrasoft.ParametrizedProcessSchemaElement",
			elementTemplateMixin: "Terrasoft.CampaignElementTemplateMixin",
			readOnlyControls: "Terrasoft.ContainerReadOnlyControlsMixin"
		},
		properties: {
			/**
			 * Unique identifier of page editors container.
			 * @type {String}
			 */
			editorsContainerId: "CampaignStartSignalPage_ReadOnlyContainerId"
		},
		messages: {
			/**
			 * @message IsDesignerReadOnlyMode
			 */
			"IsDesignerReadOnlyMode": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		attributes: {
			/**
			 * Flag to indicate that element can save properties.
			 * @type {Boolean}
			 */
			"CanSaveElementConfig": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#RecordId
			 * @override
			 */
			"RecordId": {
				"dataValueType": this.Terrasoft.DataValueType.MAPPING,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"doAutoSave": true,
				"initMethod": null
			},

			/**
			 * Returns is entity columns info button visible.
			 * @private
			 * @type {Boolean}
			 */
			"EntityColumnsInfoButtonVisible": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},

			/**
			 * List of campaign signal entities to select.
			 * @protected
			 * @type {Object}
			 */
			"SignalEntities": {
				"dataValueType": this.Terrasoft.DataValueType.CUSTOM_OBJECT,
				"value": {}
			},

			/**
			 * Flag to indicate state of participants' recurring entrance by signal.
			 * @type {Boolean}
			 */
			"IsRecurring": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"value": false,
				"onChange": "onIsRecurringChanged"
			},

			/**
			 * Flag to indicate readonly state of designer.
			 */
			"IsReadOnly": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			}
		},
		methods: {

			/**
			 * Initializes information text.
			 * @private
			 */
			_initInfoText: function() {
				var academyUrl = this.get("AcademyUrl");
				var informationText = this.get("Resources.Strings.ProcessInformationText");
				informationText = this.Ext.String.format(informationText, academyUrl);
				this.set("Resources.Strings.ProcessInformationText", informationText);
			},

			/**
			 * Returns a caption of entity schema.
			 * @private
			 * @param {Guid} schemaUId Unique identifier of entity schema.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope The callback execution context.
			 * @return {String} The caption of entity schema.
			 */
			_getSchemaCaptionByUId: function(schemaUId, callback, scope) {
				Terrasoft.EntitySchemaManager.findItemByUId(schemaUId, function(item) {
					callback.call(scope, item.getCaption());
				}, this);
			},

			/**
			 * Creates ESQ for signal entities.
			 * @private
			 * @return {Terrasoft.EntitySchemaQuery} The info of signal entity.
			 */
			_createSignalESQ: function() {
				var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "CampaignSignalEntity"
				});
				esq.addColumn("Id");
				esq.addColumn("EntityObject");
				esq.addColumn("Caption");
				return esq;
			},

			/**
			 * Returns info of signal entity.
			 * @private
			 * @param {Guid} signalEntityId Unique identifier of signal entity.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope The callback execution context.
			 * @return {String} The info of signal entity.
			 */
			_getSignalEntityInfo: function(signalEntityId, callback, scope) {
				var esq = this._createSignalESQ();
				esq.getEntity(signalEntityId, function(response) {
					var entity = response.entity;
					var schemaUId = entity.get("EntityObject").value;
					var caption = entity.get("Caption");
					var signalEntityInfo = {
						value: signalEntityId,
						displayValue: caption,
						schemaUId: schemaUId
					};
					if (Ext.isEmpty(caption)) {
						this._getSchemaCaptionByUId(schemaUId, function(schemaCaption) {
							signalEntityInfo.displayValue = schemaCaption;
							callback.call(scope, signalEntityInfo);
						}, this);
					} else {
						callback.call(scope, signalEntityInfo);
					}
				}, scope);
			},

			/**
			 * Creates a list of entity schemas for drop-down.
			 * @param {Terrasoft.Collection} schemaItems The data for the drop-down list.
			 * @return {Object} The list of entity schemas.
			 */
			_createEntitySelectList: function(schemaItems) {
				var resultList = {};
				schemaItems.each(function(schemaItem) {
					var id = schemaItem.get("Id");
					resultList[id] = {
						value: id,
						displayValue: schemaItem.get("Caption"),
						schemaUId: schemaItem.get("EntityObject").value
					};
				}, this);
				return resultList;
			},

			/**
			 * @private
			 */
			_isRecurringAllowed: function() {
				return Terrasoft.Features.getIsEnabled("CampaignSignalRecurringEntrance");
			},

			/**
			 * @inheritdoc Terrasoft.BaseProcessSchemaElementPropertiesPage#init
			 * @override
			 */
			init: function() {
				this.callParent(arguments);
				this.initAcademyUrl(this._initInfoText, this);
				this.$IsReadOnly = this.sandbox.publish("IsDesignerReadOnlyMode");
				this.$CanSaveElementConfig = true;
			},

			/**
			 * Handles change of recurring sign
			 * @public
			 */
			onIsRecurringChanged: function(model, value) {
				var element = this.get("ProcessElement");
				element.isRecurring = value;
				element.updateMarkers();
			},

			/**
			 * @inheritdoc ProcessSchemaElementEditable#onElementDataLoad
			 * @override
			 */
			onElementDataLoad: function(element, callback, scope) {
				var parentMethod = this.getParentMethod();
				this.initSignalEntityList(function() {
					parentMethod.call(this, element, function() {
						callback.call(scope);
						if (this.$IsReadOnly) {
							this.setControlsReadOnly(this.$IsReadOnly, this.editorsContainerId);
						}
					}, this);
				}, this);
			},

			/**
			 * Initializes url to the academy.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope The callback execution context.
			 * @protected
			 */
			initAcademyUrl: function(callback, scope) {
				Terrasoft.AcademyUtilities.getUrl({
					contextHelpCode: this.getContextHelpCode(),
					callback: function(academyUrl) {
						this.set("AcademyUrl", academyUrl);
						this.Ext.callback(callback, scope);
					},
					scope: this
				});
			},

			/**
			 * Returns code of the context help.
			 * @protected
			 * @return {String}
			 */
			getContextHelpCode: function() {
				return "CampaignSignalElement";
			},

			/**
			 * Returns a list of signal entities.
			 * @return {Terrasoft.Collection} The signal entities.
			 */
			getSignalEntityList: function(callback, scope) {
				var esq = this._createSignalESQ();
				esq.getEntityCollection(function(response) {
					callback.call(scope, response.collection);
				}, scope);
			},

			/**
			 * Fills signal entity caption when it is empty.
			 * @param {Terrasoft.Collection} signalEntities The list of signal entities.
			 */
			fillSignalEntityCaption: function(signalEntities) {
				Terrasoft.map(signalEntities.getItems(), function(entity) {
					var caption = entity.get("Caption");
					if (Ext.isEmpty(caption)) {
						this._getSchemaCaptionByUId(entity.get("EntitySchemaUId"), function(schemaCaption) {
							entity.set("Caption", schemaCaption);
						}, this);
					}
				}, this);
			},

			/**
			 * Initializes collection of campaign signal entities to select.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Context.
			 */
			initSignalEntityList: function(callback, scope) {
				this.getSignalEntityList(function(signalEntities) {
					this.fillSignalEntityCaption(signalEntities);
					signalEntities.sort("$Caption", this.Terrasoft.OrderDirection.ASC);
					this.$SignalEntities = this._createEntitySelectList(signalEntities);
					callback.call(scope);
				}, this);
			},

			/**
			 * The event handler for preparing of the data drop-down Entity.
			 * @param {Object} filter Filters for data preparation.
			 * @param {Terrasoft.Collection} list The data for the drop-down list.
			 */
			prepareSignalEntityList: function(filter, list) {
				if (list === null) {
					return;
				}
				list.reloadAll(this.$SignalEntities);
			},

			/**
			 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#saveParameters
			 * @override
			 */
			saveParameters: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#initParameters
			 * @override
			 */
			initParameters: function(element) {
				this.callParent(arguments);
				this.$IsRecurring = element.isRecurring;
			},

			/**
			 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#saveValues
			 * @override
			 */
			saveValues: function() {
				this.callParent(arguments);
				var element = this.$ProcessElement;
				element.isRecurring = this.$IsRecurring;
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#initSignalTypeList
			 * @override
			 */
			initSignalTypeList: function() {
				this.set("WaitingRandomSignal", false);
				this.set("WaitingEntitySignal", true);
				var objectSignalType = {
					value: Terrasoft.process.constants.SignalType.ObjectSignal,
					displayValue: this.get("Resources.Strings.ObjectSignalCaption")
				};
				this.set("SignalType", objectSignalType);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#getEntityChangeTypeList
			 * @override
			 */
			getEntityChangeTypeList: function() {
				var list = this.callParent(arguments);
				delete list[this.Terrasoft.EntityChangeType.Deleted];
				return list;
			},

			/**
			 * Handles change of entity schema columns controls list.
			 * @private
			 */
			_onEntitySchemaColumnsControlsSelectChanged: function() {
				var entityChangeType = this.$EntityChangeType;
				if (entityChangeType === Terrasoft.EntityChangeType.Updated) {
					var controlList = this.$EntitySchemaColumnsControlsSelect;
					this.set("EntityColumnsInfoButtonVisible", controlList.collection.length === 0);
				}
			},

			/**
			 * @inheritdoc Terrasoft.EntitySchemaSelectMixin#initEntitySchemaColumnsSelect
			 * @override
			 */
			initEntitySchemaColumnsSelect: function(entityColumns, callback, scope) {
				var controlList = this.$EntitySchemaColumnsControlsSelect;
				var entityChangeType = this.get("EntityChangeType");
				entityChangeType = Ext.isObject(entityChangeType) ? entityChangeType.value : entityChangeType;
				this.set("EntityColumnsInfoButtonVisible", entityChangeType === Terrasoft.EntityChangeType.Updated);
				controlList.on("changed", this._onEntitySchemaColumnsControlsSelectChanged.bind(this), this);
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.FilterModuleMixin#getFilterModuleConfig
			 * @override
			 */
			getFilterModuleConfig: function(entitySchemaName) {
				var baseConfig = this.callParent(arguments);
				var config = {
					rightExpressionMenuAligned: true
				};
				return Ext.apply(baseConfig, config);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#onExpectChangesChanged
			 * @override
			 */
			onExpectChangesChanged: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#onEntityChangeTypeChanged
			 * @override
			 */
			onEntityChangeTypeChanged: function() {
				var entityChangeType = this.get("EntityChangeType");
				if (Ext.isEmpty(entityChangeType)) {
					this.unloadFilterUnitModule();
				}
				entityChangeType = Ext.isObject(entityChangeType) ? entityChangeType.value : entityChangeType;
				if (entityChangeType === Terrasoft.EntityChangeType.Updated) {
					var expectChanges = {
						value: Terrasoft.process.constants.SignalExpectChanges.AnySelectedField,
						displayValue: this.get("Resources.Strings.AnySelectedFieldCaption")
					};
					this.set("ExpectChanges", expectChanges, {
						silent: true
					});
					this.set("EntityColumnsInfoButtonVisible", true);
				} else {
					this.clearAttributes(["ExpectChanges"]);
					this.validAttributes(["ExpectChanges"]);
					this.clearEntitySchemaColumns();
					this.set("EntityColumnsInfoButtonVisible", false);
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#initSignalEntity
			 * @override
			 */
			initSignalEntity: function(element) {
				this.set("EntitySchemaSelect", element.signalEntityId, {silent: true});
				this.set("ReferenceSchemaUId", element.entitySchemaUId);
				this.set("EntitySignal", element.entitySignal);
				this.set("HasEntityColumnChange", element.hasEntityColumnChange);
				this.set("NewEntityChangedColumns", element.newEntityChangedColumns);
				this.set("HasEntityFilters", element.hasEntityFilters);
				this.set("EntityFilters", element.entityFilters);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#onEntitySchemaSelectChanged
			 * @override
			 */
			onEntitySchemaSelectChanged: function() {
				this.callParent(arguments);
				var entity = this.get("EntitySchemaSelect");
				var entitySchemaUId = Ext.isObject(entity) ? entity.schemaUId : entity;
				this.set("EntitySchemaUId", entitySchemaUId);
			},

			/**
			 * @inheritdoc Terrasoft.EntitySchemaSelectMixin#getEntitySchemaColumnsSelect
			 * @override
			 */
			getEntitySchemaColumnsSelect: function(callback, scope) {
				scope = scope || this;
				var entitySchemaColumns = this.get("EntitySchemaColumnsSelect");
				if (!entitySchemaColumns) {
					entitySchemaColumns = this.Ext.create("Terrasoft.Collection");
					this.set("EntitySchemaColumnsSelect", entitySchemaColumns);
				}
				var schemaUId = this.get("ReferenceSchemaUId");
				if (!schemaUId || !entitySchemaColumns.isEmpty()) {
					if (this.Ext.isFunction(callback)) {
						callback.call(scope, entitySchemaColumns);
					}
					return;
				}
				this.getEntitySchemaColumns(schemaUId, callback, scope);
			},

			/**
			 * @inheritdoc Terrasoft.EntitySchemaSelectMixin#initEntitySchemaSelect
			 * @override
			 */
			initEntitySchemaSelect: function(callback, scope) {
				var signalEntityId = this.get("EntitySchemaSelect");
				if (!this.Ext.isEmpty(signalEntityId)) {
					this._getSignalEntityInfo(signalEntityId, function(item) {
						this.set("EntitySchemaSelect", item);
						this.on("change:EntitySchemaSelect", this.onEntitySchemaSelectChanged, this);
						callback.call(scope);
					}, this);
				} else {
					this.on("change:EntitySchemaSelect", this.onEntitySchemaSelectChanged, this);
					callback.call(scope);
				}
			},

			/**
			 * @inheritdoc Terrasoft.FilterModuleMixin#initReferenceSchemaUId
			 * @override
			 */
			initReferenceSchemaUId: function() {
				var entity = this.get("EntitySchemaSelect");
				entity = Ext.isObject(entity) ? entity.schemaUId : entity;
				this.set("ReferenceSchemaUId", entity);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#saveEntity
			 * @override
			 */
			saveEntity: function(element) {
				var entity = this.get("EntitySchemaSelect");
				var entityId = Ext.isObject(entity) ? entity.value : entity;
				var entitySchemaUId = Ext.isObject(entity) ? entity.schemaUId : entity;
				element.signalEntityId = entityId;
				element.entitySchemaUId = entitySchemaUId;
				this.set("EntitySchemaUId", entitySchemaUId);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSignalEventPropertiesPage#saveEntityColumns
			 * @override
			 */
			saveEntityColumns: function(element) {
				var controlList = this.$EntitySchemaColumnsControlsSelect;
				var changedColumns = controlList.mapArray(function(control) {
						return control.get("Id");
					}, this);
				this.$NewEntityChangedColumns = changedColumns;
				element.newEntityChangedColumns = changedColumns;
				var anySelectedField = Terrasoft.process.constants.SignalExpectChanges.AnySelectedField;
				var anyField = Terrasoft.process.constants.SignalExpectChanges.AnyField;
				var expectChanges = changedColumns.length === 0 ? anyField : anySelectedField;
				var expectChangesList = this.getExpectChangesList();
				this.$ExpectChanges = expectChangesList[expectChanges];
				element.hasEntityColumnChange = expectChanges === anySelectedField;
			},

			/**
			 * @inheritdoc Terrasoft.BaseProcessSchemaElementPropertiesPage#setValidationState
			 * @override
			 */
			setValidationState: function(isElementValid) {
				var element = this.$ProcessElement;
				element.setPropertyValue("isValidateExecuted", true, {
					silent: true
				});
				element.setPropertyValue("isValid", isElementValid, {
					silent: !isElementValid
				});
			},

			/**
			 * Handles element properties loaded event.
			 * @param {String} elementConfig Serialized config of campaign element.
			 */
			onElementConfigLoaded: function(elementConfig) {
				element = JSON.parse(elementConfig);
				this.initSignalEntity(element);
				this._getSignalEntityInfo(element.signalEntityId, function(item) {
					this.set("EntitySchemaSelect", item);
					var entityChangeTypeList = this.getEntityChangeTypeList();
					var entityChangeType = entityChangeTypeList[element.entitySignal];
					this.set("EntityChangeType", entityChangeType);
					this.set("EntityColumnsInfoButtonVisible", entityChangeType === Terrasoft.EntityChangeType.Updated);
					var index = element.hasEntityColumnChange ? 1 : 0;
					var expectChangesList = this.getExpectChangesList();
					var expectChanges = expectChangesList[index];
					this.set("ExpectChanges", expectChanges);
					var entityColumns = JSON.parse(element.newEntityChangedColumns);
					if (this.Ext.isArray(entityColumns) && entityColumns.length > 0) {
						var controlList = this.get("EntitySchemaColumnsControlsSelect");
						controlList.clear();
						this.addEntitySchemaColumnControlSelect(entityColumns, Terrasoft.emptyFn, this);
					}
					var filterValue = this.deserializeFilterEditData(element.entityFilters);
					this.onFilterDataDeserialized(filterValue, element,
						Terrasoft.emptyFn, this, "FilterEditData");
					this.$IsRecurring = element.isRecurring;
				}, this);
			},

			/**
			 * Handles click on Select from lookup element properties button.
			 * @protected
			 */
			onSelectElementConfigClick: function() {
				var config = this.getElementLookupConfig();
				LookupUtilities.Open(this.sandbox, config, this.onElementConfigSelected, this, null, false, false);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "RecommendationLabel"
			},
			{
				"operation": "remove",
				"name": "SignalType"
			},
			{
				"operation": "remove",
				"name": "EntitySchemaSelect"
			},
			{
				"operation": "insert",
				"name": "ActionsContainer",
				"propertyName": "items",
				"parentName": "EditorsContainer",
				"className": "Terrasoft.GridLayoutEdit",
				"index": 0,
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"visible": "$getCanSaveElementConfig",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ElementConfigContainer",
				"parentName": "ActionsContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"colSpan": 24,
						"row": 0
					},
					"id": "ElementSettingsContainer",
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ElementConfigTextLabel",
				"parentName": "ElementConfigContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.ElementConfigCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc", "element-settings-label"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "ElementConfigHint",
				"parentName": "ElementConfigContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"content": "$Resources.Strings.ElementConfigHintText",
					"controlConfig": {
						"classes": {
							"wrapperClass": "information-button"
						}
					}
				}
			},
			{
				"operation": "insert",
				"name": "ElementConfigActionsContainer",
				"parentName": "ActionsContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"colSpan": 24,
						"row": 1
					},
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"wrapClass": ["element-properties-actions-wrap"]
				}
			},
			{
				"operation": "insert",
				"name": "SelectElementConfigButton",
				"parentName": "ElementConfigActionsContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"imageConfig": "$Resources.Images.SelectButtonIcon",
					"caption": "$Resources.Strings.SelectFromLookupButtonText",
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"click": "$onSelectElementConfigClick",
					"classes": {
						wrapperClass: ["action-button-control"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "SaveElementConfigButton",
				"parentName": "ElementConfigActionsContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"imageConfig": "$Resources.Images.SaveButtonIcon",
					"caption": "$Resources.Strings.SaveTemplateButtonText",
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"click": "$onSaveElementConfigClick",
					"classes": {
						wrapperClass: ["action-button-control"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "ObjectSignalEntityControlGroup",
				"parentName": "MainControlGroup",
				"propertyName": "items",
				"values": {
					"layout": {
						"row": 1,
						"column": 0,
						"rowSpan": 1,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "EntityTextLabel",
				"parentName": "ObjectSignalEntityControlGroup",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.ObjectEntityCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "EntitySchemaSelect",
				"parentName": "ObjectSignalEntityControlGroup",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"rowSpan": 1,
						"colSpan": 24
					},
					"contentType": this.Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": "$prepareSignalEntityList",
						"filterComparisonType": this.Terrasoft.StringFilterType.CONTAIN
					},
					"labelConfig": {
						"visible": false
					},
					"wrapClass": ["top-caption-control"]
				}
			},
			{
				"operation": "remove",
				"name": "ExpectChanges",
				"values": {
				}
			},
			{
				"operation": "remove",
				"name": "useBackgroundMode"
			},
			{
				"operation": "insert",
				"name": "EntityColumnsLabel",
				"parentName": "ObjectSignalPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 23
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.ExpectChangesCaption"},
					"visible": "$getExpectChangesVisible",
					"classes": {
						"labelClass": ["label-small"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "EntityColumnsInfoButtonContainer",
				"parentName": "ObjectSignalPropertiesControlGroup",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 23,
						"row": 2,
						"colSpan": 1
					},
					"visible": {
						"bindTo": "EntityColumnsInfoButtonVisible"
					},
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"markerValue": "EntityColumnsInfoButtonContainer",
					"wrapClass": ["filter-info-button-container"]
				}
			},
			{
				"operation": "insert",
				"name": "EntityColumnsInfoButton",
				"parentName": "EntityColumnsInfoButtonContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"content": {
						"bindTo": "Resources.Strings.EntityColumnsInformationText"
					}
				}
			},
			{
				"operation": "merge",
				"name": "EntityColumnsContainer",
				"values": {
					"visible": "$getExpectChangesVisible"
				}
			},
			{
				"operation": "remove",
				"parentName": "ToolsContainer",
				"name": "ToolsButton"
			},
			{
				"operation": "insert",
				"name": "RecurringAddContainer",
				"parentName": "MainControlContainer",
				"propertyName": "items",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"visible": "$_isRecurringAllowed",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "RecurringAddLayout",
				"propertyName": "items",
				"parentName": "RecurringAddContainer",
				"className": "Terrasoft.GridLayoutEdit",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "IsRecurringLabel",
				"parentName": "RecurringAddLayout",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0
					},
					"itemType": this.Terrasoft.ViewItemType.LABEL,
					"caption": "$Resources.Strings.IsRecurringLabel",
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "IsRecurring",
				"parentName": "RecurringAddLayout",
				"propertyName": "items",
				"values": {
					"wrapClass": ["t-checkbox-control"],
					"caption": "$Resources.Strings.IsRecurringCaption",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 23
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "RecurringAddLayout",
				"propertyName": "items",
				"name": "RecurringAddHint",
				"values": {
					"layout": {"column": 23, "row": 1, "colSpan": 1},
					"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"content": "$Resources.Strings.IsRecurringHint",
					"controlConfig": {
						"classes": {
							"wrapperClass": "t-checkbox-information-button"
						}
					}
				}
			},
			{
				"operation": "merge",
				"parentName": "PropertiesContainer",
				"propertyName": "items",
				"name": "EditorsContainer",
				"values": {
					"id": "CampaignStartSignalPage_ReadOnlyContainerId"
				}
			},
			{
				"operation": "merge",
				"parentName": "TitleContainer",
				"name": "caption",
				"values": {
					"enabled": {
						bindTo: "IsReadOnly",
						bindConfig: {converter: "invertBooleanValue"}
					},
					"wrapClass": ["campaign-properties-title-wrap"]
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
