﻿Terrasoft.configuration.Structures["DcmSchemaStagePropertiesPage"] = {innerHierarchyStack: ["DcmSchemaStagePropertiesPage"], structureParent: "BaseProcessSchemaElementPropertiesPage"};
define('DcmSchemaStagePropertiesPageStructure', ['DcmSchemaStagePropertiesPageResources'], function(resources) {return {schemaUId:'0a0b7364-483f-4546-babe-c41fbd7b13d3',schemaCaption: "DcmSchemaStagePropertiesPage", parentSchemaName: "BaseProcessSchemaElementPropertiesPage", packageName: "DcmDesigner", schemaName:'DcmSchemaStagePropertiesPage',parentSchemaUId:'10a8efdc-8474-4a9a-b28f-ab96ec9bbe4a',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Parent: BaseProcessSchemaElementPropertiesPage
 */
define("DcmSchemaStagePropertiesPage", ["ext-base", "terrasoft", "DcmSchemaStagePropertiesPageResources",
	"ConfigurationItemGenerator", "EditableContainerListMixin", "EditableContainerList", "LookupQuickAddMixin",
	"EditableContainerListItemViewModel", "DcmSchemaStagePermission", "css!DcmSchemaStagePropertiesPageCSS", "DcmConstants", "DcmUtilities"
], function(Ext, Terrasoft, resources) {
	const incomingConnectionsModuleId = "EditableContainerListIncomingConnections";
	const outgoingConnectionsModuleId = "EditableContainerListOutgoingConnections";
	const stagePermissionsModuleId = "EditableContainerListStagePermissions";

	Ext.define("Terrasoft.controls.DcmColorMenuItem", {
		extend: "Terrasoft.controls.ColorMenuItem",
		alternateClassName: "Terrasoft.DcmColorMenuItem",

		colors: Terrasoft.controls.ColorMenuItemConstants.defaultColors.map((color) => Terrasoft.DcmUtilities.convertTo8xStageColor(color))

	});

	return {
		mixins: {
			editableContainerListMixin: "Terrasoft.EditableContainerListMixin",
			LookupQuickAddMixin: "Terrasoft.LookupQuickAddMixin"
		},
		attributes: {
			/**
			 * Attribute for select control.
			 */
			"LookupRecord": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				onChange: "onLookupRecordChange",
				isRequired: true
			},
			/**
			 * Stage entity schema column reference schema.
			 * @protected
			 * @type {Terrasoft.EntitySchema}
			 */
			"StageColumnReferenceEntitySchema": {
				dataValueType: Terrasoft.DataValueType.COLLECTION,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * Attribute for checkBox control.
			 */
			"IsInGroup": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				onChange: "onIsInGroupChange"
			},
			/**
			 * Flag of permissions usage.
			 */
			"UsePermissions": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				onChange: "onUsePermissionsChange"
			},
			/**
			 * Stage permissions.
			 */
			"Permissions": {
				dataValueType: Terrasoft.DataValueType.OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * Group stages lookup.
			 */
			"ParentStage": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#Color
			 * @override
			 */
			"Color": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				onChange: "onColorChange"
			},
			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#caption
			 * @override
			 */
			"caption": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				onChange: "onCaptionChange",
				isRequired: true
			},
			/**
			 * Indicates if stage is successful.
			 * @type {String}
			 */
			"isSuccessful": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				caption: resources.localizableStrings.StageIsSuccessfulCaption
			},
			/**
			 * Property page parent schema.
			 * @type {Terrasoft.Designers.DcmSchema}
			 */
			"ParentSchema": {
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * Schema stage targets.
			 * @type {Terrasoft.DcmSchemaStageConnections}
			 */
			"StageConnections": {
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * Transition type.
			 * @type {Terrasoft.DcmConstants.StageTransitionType}
			 */
			"TransitionType": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				isRequired: true
			}
		},
		modules: {
			"OutgoingConnectionsContainerList": {
				"config": {
					"schemaName": "EditableContainerList",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"showMask": true,
					"autoGeneratedContainerSuffix": "-connections-list",
					"parameters": {
						"viewModelConfig": {
							"ModalBoxCaption": resources.localizableStrings.StageValidToMoveCaption,
							"ModuleId": outgoingConnectionsModuleId
						}
					}
				}
			},
			"IncomingConnectionsContainerList": {
				"config": {
					"schemaName": "EditableContainerList",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"showMask": true,
					"autoGeneratedContainerSuffix": "-connections-list",
					"parameters": {
						"viewModelConfig": {
							"ModalBoxCaption": resources.localizableStrings.WithStageValidMoveCaption,
							"ModuleId": incomingConnectionsModuleId
						}
					}
				}
			},
			"StagePermissionsContainerList": {
				"config": {
					"schemaName": "EditableContainerList",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"showMask": true,
					"autoGeneratedContainerSuffix": "-stage-permissions-list",
					"parameters": {
						"viewModelConfig": {
							"ModalBoxCaption": resources.localizableStrings.StagePermissions,
							"ModuleId": stagePermissionsModuleId,
							"AddButtonCaption": resources.localizableStrings.AddPermissionsButton
						}
					}
				}
			}
		},
		methods: {

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#getPackageUId
			 * @override
			 */
			getPackageUId: function() {
				const stage = this.getCurrentStage();
				const dcmSchema = stage.parentSchema;
				return dcmSchema.getPackageUId();
			},

			/**
			 * @inheritdoc BaseSchemaViewModel#init
			 * @override
			 */
			init: function(callback, scope) {
				this.callParent([
					function() {
						Terrasoft.chain(
							this.initStageColumnReferenceEntitySchema,
							this.initDataManager,
							this._initPermissions,
							function() {
								this.initLookupRecord();
								this.initIsInGroup();
								this.initTransitionType();
								this.subscribeOnStageEvents();
								this.subscribeOnViewModelEvents();
								callback.call(scope);
							}, this);
					}, this
				]);
				this.initContainerListMixin();
			},

			/**
			 * Create schema responsible for the usage current stage permissions.
			 * @private
			 */
			_initPermissions: function(callback, scope) {
				if (this._isFeatureDcmStagesPermissionsDisabled()) {
					return;
				}
				const stagePermissionConfig = this._getStagePermissionConfig();
				const currentStage = this.getCurrentStage();
				const dcmSchemaStagePermission = Ext.create("Terrasoft.DcmSchemaStagePermission", stagePermissionConfig);
				dcmSchemaStagePermission.init(() => {
					this.set("Permissions", dcmSchemaStagePermission);
					this.set("UsePermissions", currentStage.usePermissions);
					Ext.callback(callback, scope);
				});
			},

			/**
			 * Gets config for creating schema of stage permissions.
			 * @private
			 * @return {Object} config for creating schema of stage permissions.
			 */
			_getStagePermissionConfig: function() {
				const currentStage = this.getCurrentStage();
				return {
					permissions: currentStage.permissions
				};
			},

			/**
			 * Subscribes stage events.
			 * @private
			 */
			subscribeOnStageEvents: function() {
				var stage = this.getCurrentStage();
				stage.on("changed", this.onStageChanged, this);
			},

			/**
			 * Subscribes view model events.
			 * @private
			 */
			subscribeOnViewModelEvents: function() {
				this.on("change:ParentStage", this.onParentStageChanged, this);
			},

			/**
			 * Stage changed event handler.
			 * @private
			 */
			onStageChanged: function(properties) {
				this.initIsInGroup();
				this.initCurrentParent();
				this._clearPermissions(properties);
			},

			/**
			 * Clear permissions of current stage.
			 * @param {Object} properties Changed properties of current stage.
			 */
			_clearPermissions: function(properties) {
				if (this._isFeatureDcmStagesPermissionsDisabled() || !properties) {
					return;
				}
				const propertyName = "permissions";
				let propertyValue;
				if (properties.hasOwnProperty(propertyName)) {
					propertyValue = properties[propertyName];
				}
				if (propertyValue === Terrasoft.emptyString) {
					const permissions = this.$Permissions;
					permissions.clearPermissions();
				}
			},

			/**
			 * Initializes LookupRecord attribute.
			 * @protected
			 */
			initLookupRecord: function() {
				var stage = this.getCurrentStage();
				if (stage.stageRecordId) {
					var lookupRecordListConfig = this.getLookupRecordListConfig();
					var lookupRecord = lookupRecordListConfig[stage.stageRecordId];
					if (lookupRecord) {
						this.set("LookupRecord", lookupRecord);
					}
				}
			},

			/**
			 * Initializes IsInGroup attribute.
			 * @private
			 */
			initIsInGroup: function() {
				const currentStage = this.getCurrentStage();
				this.set("IsInGroup", currentStage.parentStageUId != null);
			},

			/**
			 * Initializes TransitionType attribute.
			 * @private
			 */
			initTransitionType: function() {
				const stage = this.getCurrentStage();
				const value = Terrasoft.findWhere(Terrasoft.DcmConstants.StageTransitionType, {
					value: stage.transitionType
				});
				this.set("TransitionType", value);
			},

			/**
			 * Initializes entity schema dependence attribute.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 * @protected
			 */
			initStageColumnReferenceEntitySchema: function(callback, scope) {
				const stage = this.getCurrentStage();
				const dcmSchema = stage.parentSchema;
				const schemaUId = dcmSchema.entitySchemaUId;
				if (!schemaUId) {
					callback.call(scope);
					return;
				}
				const schemaConfig = {
					schemaUId: schemaUId
				};
				const utils = this.getEntitySchemaDesignerUtilities();
				utils.findEntitySchemaInstance(schemaConfig, function(schema) {
					const stageColumnUId = dcmSchema.stageColumnUId;
					if (!stageColumnUId) {
						callback.call(scope);
						return;
					}
					const columns = schema.columns;
					const column = columns.find(stageColumnUId);
					const columnReferenceSchemaUId = column.referenceSchemaUId;
					const config = {
						schemaUId: columnReferenceSchemaUId
					};
					utils.findEntitySchemaInstance(config, function(stageColumnSchema) {
						this.set("StageColumnReferenceEntitySchema", stageColumnSchema);
						callback.call(scope);
					}, this);
				}, this);
			},

			/**
			 * Returns used stage records.
			 * @private
			 * @return {Array} used stage records.
			 */
			getSchemaLookupRecords: function() {
				var records = [];
				var currentStage = this.getCurrentStage();
				var dcmSchema = currentStage.parentSchema;
				var currentStageRecordId = currentStage.stageRecordId;
				dcmSchema.stages.each(function(stage) {
					if (stage.stageRecordId && stage.stageRecordId !== currentStageRecordId) {
						records.push(stage.stageRecordId);
					}
				});
				return records;
			},

			/**
			 * Prepares collection for lookup select grid.
			 * @private
			 * @return {Object} config for lookup record list.
			 */
			getLookupRecordListConfig: function() {
				var resultConfig = {};
				var entitySchema = this.get("StageColumnReferenceEntitySchema");
				if (entitySchema) {
					var primaryColumnName = entitySchema.primaryColumn.name;
					var primaryDisplayColumnName = entitySchema.primaryDisplayColumn.name;
					var dataCollection = Terrasoft.DataManager.getEntitySchemaData(entitySchema.name);
					var stageRecords = this.getSchemaLookupRecords();
					dataCollection.each(function(dataItem) {
						var primaryColumnValue = dataItem.getColumnValue(primaryColumnName);
						if (!Terrasoft.contains(stageRecords, primaryColumnValue)) {
							resultConfig[primaryColumnValue] = {
								value: primaryColumnValue,
								displayValue: dataItem.getColumnValue(primaryDisplayColumnName)
							};
						}
					}, this);
				}
				return Terrasoft.sortObj(resultConfig, "displayValue");
			},

			/**
			 * Initializes collections dataMangerItem.
			 * @private
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 **/
			initDataManager: function(callback, scope) {
				var schema = this.get("StageColumnReferenceEntitySchema");
				if (schema) {
					var config = {
						entitySchemaName: schema.name,
						addToStore: true
					};
					Terrasoft.DataManager.select(config, callback, scope);
				} else {
					callback.call(scope);
				}
			},

			/**
			 * The event handler for preparing of the data drop-down Entity.
			 * @private
			 * @param {Object} filter Filters for data preparation.
			 * @param {Terrasoft.Collection} list The data for the drop-down list.
			 */
			prepareLookupRecordList: function(filter, list) {
				var entitySchema = this.get("StageColumnReferenceEntitySchema");
				if (entitySchema && list) {
					list.clear();
					var items = this.getLookupRecordListConfig();
					var config = {
						objects: items,
						filterValue: filter,
						isLookupEdit: true
					};
					this.onMixinLookupDataLoad(config);
					list.loadAll(items);
				}
			},

			/**
			 * @inheritdoc LookupQuickAddMixin#getLookupEntitySchemaName
			 * @overriden
			 */
			getLookupEntitySchemaName: function() {
				return this.get("StageColumnReferenceEntitySchema");
			},

			/**
			 * Calls lookup quick add mixin on lookup data load.
			 * @private
			 */
			onMixinLookupDataLoad: function(config) {
				config.isLookupEdit = true;
				this.mixins.LookupQuickAddMixin.onLookupDataLoaded.call(this, config);
			},

			/**
			 * The event handler for preparing group stages list.
			 * @private
			 * @param {Object} filter Filters for data preparation.
			 * @param {Terrasoft.Collection} list The data for the drop-down list.
			 */
			prepareParentStageList: function(filter, list) {
				if (!list) {
					return;
				}
				list.clear();
				var stages = this.getParentSchemaStages();
				var itemsConfig = {};
				stages.each(function(stage) {
					if (this.canBeUsedAsParent(stage)) {
						itemsConfig[stage.uId] = {
							value: stage.uId,
							displayValue: stage.getCaption()
						};
					}
				}, this);
				list.loadAll(itemsConfig);
			},

			/**
			 * Parent stage change handler.
			 * @private
			 */
			onParentStageChanged: function(sender, value) {
				var stage = this.getCurrentStage();
				var oldValue = stage.parentStageUId;
				var newValue = value && value.value;
				if (newValue !== oldValue) {
					stage.parentSchema.changeParentStage(stage.uId, oldValue, newValue);
				}
			},

			/**
			 * Returns True if the there're any stages to group with.
			 * @private
			 * @return {boolean} True if stage can be grouped.
			 */
			getIsInGroupEnabled: function() {
				var currentStage = this.getCurrentStage();
				return !currentStage.getIsParent();
			},

			/**
			 * IsInGroup change handler.
			 * @private
			 */
			onIsInGroupChange: function() {
				var isInGroup = this.get("IsInGroup");
				var newParentStage = null;
				if (isInGroup === true) {
					newParentStage = this.findParentStage();
				}
				var value = null;
				if (newParentStage) {
					value = {
						value: newParentStage.uId,
						displayValue: newParentStage.getDisplayValue()
					};
				}
				this.set("ParentStage", value);
			},

			/**
			 * Permissions change handler.
			 * @private
			 */
			onUsePermissionsChange: function() {
				if (this._isFeatureDcmStagesPermissionsDisabled()) {
					return;
				}
				const usePermissions = this.$UsePermissions;
				const stage = this.getCurrentStage();
				stage.setPropertyValue("usePermissions", usePermissions);
			},

			/**
			 * Returns parent stage.
			 * @private
			 * @return {Terrasoft.DcmSchemaStage} Parent stage.
			 */
			findParentStage: function() {
				var previousStage = this.findPreviousStage();
				if (previousStage && previousStage.getIsAlternative()) {
					return previousStage.getParentStage();
				}
				return previousStage;
			},

			/**
			 * Returns previous stage.
			 * @private
			 * @return {Terrasoft.DcmSchemaStage|null} Previous stage.
			 */
			findPreviousStage: function() {
				var stage = this.getCurrentStage();
				var stages = this.getParentSchemaStages();
				var stageIndex = stages.indexOf(stage);
				if (stageIndex === 0) {
					return null;
				}
				return stages.getByIndex(stageIndex - 1);
			},

			/**
			 * Sets current parent stage if exists.
			 * @private
			 */
			initCurrentParent: function() {
				var stage = this.getCurrentStage();
				if (!stage.parentStageUId) {
					return;
				}
				var stages = this.getParentSchemaStages();
				var parentStage = stages.get(stage.parentStageUId);
				var config = {
					value: parentStage.uId,
					displayValue: parentStage.getDisplayValue()
				};
				this.set("ParentStage", config);
			},

			/**
			 * Returns parent schema.
			 * @private
			 * @return {Terrasoft.DcmSchema} Parent schema.
			 */
			getParentSchema: function() {
				var stage = this.getCurrentStage();
				return stage.parentSchema;
			},

			/**
			 * Return Stages collection.
			 * @private
			 * @return {Terrasoft.Collection} Stages collection.
			 */
			getParentSchemaStages: function() {
				var schema = this.getParentSchema();
				return schema.stages;
			},

			/**
			 * Returns current stage.
			 * @private
			 * @return {Terrasoft.DcmSchemaStage} Current stage.
			 */
			getCurrentStage: function() {
				return this.get("ProcessElement");
			},

			/**
			 * Returns true if stage can be a group parent.
			 * @private
			 * @param {Terrasoft.DcmStageViewModel} stage Stage view model.
			 * @return {boolean} True if stage can be a group parent.
			 */
			canBeUsedAsParent: function(stage) {
				var currentStage = this.getCurrentStage();
				var isParentOrNonGrouped = !stage.getIsAlternative() || stage.getIsParent();
				return currentStage.uId !== stage.uId && isParentOrNonGrouped;
			},

			/**
			 * Handler Color attribute change.
			 * @private
			 */
			onColorChange: function() {
				var processElement = this.getCurrentStage();
				var color = this.get("Color");
				processElement.setPropertyValue("color", color);
				Terrasoft.refreshStyleSheetCache();
				Terrasoft.updateStyleSheet(".dcm-schema-stage-properties-page .t-title-label-stage", "color", color);
			},

			/**
			 * Updated display value in lookup.
			 * @private
			 * @param {String} displayValue new display value.
			 */
			updateLookupRecordDisplayValue: function(displayValue) {
				var lookupRecord = this.get("LookupRecord");
				if (lookupRecord) {
					lookupRecord = {
						value: lookupRecord.value,
						displayValue: displayValue
					};
					this.set("LookupRecord", lookupRecord);
				}
			},

			/**
			 * Updated display value in data manager item.
			 * @private
			 * @param {Terrasoft.DcmSchemaStage} stage current stage.
			 * @param {String} value new display value.
			 */
			updateDataManagerItemDisplayValue: function(stage, value) {
				var entitySchema = this.get("StageColumnReferenceEntitySchema");
				if (entitySchema) {
					var dataManagerItems = Terrasoft.DataManager.getEntitySchemaData(entitySchema.name);
					var dataManagerItem = dataManagerItems.find(stage.stageRecordId);
					if (dataManagerItem) {
						dataManagerItem.setColumnValue(entitySchema.primaryDisplayColumn.name, value);
					}

				}
			},

			/**
			 * Handler caption attribute change.
			 * @private
			 */
			onCaptionChange: function() {
				var stage = this.getCurrentStage();
				if (stage.stageRecordId) {
					var caption = this.get("caption");
					this.updateDataManagerItemDisplayValue(stage, caption);
					this.updateLookupRecordDisplayValue(caption);
				}
			},

			/**
			 * Handler for after LookupRecord attribute changed.
			 * @private
			 * @param {Object} lookupRecord Lookup record.
			 */
			onLookupRecordChanged: function(lookupRecord) {
				var processElement = this.getCurrentStage();
				processElement.setPropertyValue("stageRecordId", lookupRecord && lookupRecord.value);
				var dislayValue = lookupRecord && lookupRecord.displayValue;
				if (dislayValue) {
					this.set("caption", dislayValue);
				}
			},

			/**
			 * Returns lookup record view model validation message.
			 * @private
			 * @param {Terrasoft.model.BaseViewModel} viewModel Lookup record view model.
			 * @return {String}
			 */
			getLookupRecordValidationMessage: function(viewModel) {
				var invalidColumnCaption = "";
				var invalidMessage = "";
				var attributes = viewModel.validationInfo.attributes;
				Terrasoft.each(attributes, function(attribute, attributeName) {
					if (!attribute.isValid) {
						var column = viewModel.columns[attributeName];
						invalidColumnCaption = column.caption || column.name;
						invalidMessage = attribute.invalidMessage;
						return false;
					}
				});
				var template = resources.localizableStrings.AddLookupRecordErrorMessage;
				return Ext.String.format(template, invalidColumnCaption, invalidMessage);
			},

			/**
			 * Creates new lookup record item.
			 * @private
			 * @param {Object} lookupRecord New lookup record.
			 */
			createLookupRecord: function(lookupRecord) {
				var newValue = Terrasoft.generateGUID();
				lookupRecord.value = newValue;
				lookupRecord.displayValue = lookupRecord.inputedValue;
				this.createLookupRecordDataManagerItem(lookupRecord, function(dataManagerItem) {
					var isValid = dataManagerItem.viewModel.validate();
					if (isValid) {
						dataManagerItem.id = newValue;
						Terrasoft.DataManager.addItem(dataManagerItem);
						this.set("LookupRecord", lookupRecord, {silent: true});
						this.onLookupRecordChanged(lookupRecord);
					} else {
						this.set("LookupRecord", null);
						var message = this.getLookupRecordValidationMessage(dataManagerItem.viewModel);
						this.showInformationDialog(message);
					}
				}, this);
			},

			/**
			 * Handler for LookupRecord attribute change.
			 * @private
			 * @param {Object} viewModel Lookup viewModel.
			 * @param {Object} lookupRecord New lookup record.
			 */
			onLookupRecordChange: function(viewModel, lookupRecord) {
				var isNewLookupRecord = lookupRecord && Terrasoft.isEmptyGUID(lookupRecord.value);
				if (isNewLookupRecord) {
					this.createLookupRecord(lookupRecord);
				} else {
					this.onLookupRecordChanged(lookupRecord);
				}
			},

			/**
			 * Creates lookup record data manager item.
			 * @private
			 * @param {Object} config Lookup record config.
			 * @param {Function} callback Callback with created data manager item.
			 * @param {Object} scope Callback scope.
			 */
			createLookupRecordDataManagerItem: function(config, callback, scope) {
				var stageColumnReferenceEntitySchema = this.get("StageColumnReferenceEntitySchema");
				var entitySchema = Terrasoft[stageColumnReferenceEntitySchema.name];
				var createConfig = {
					entitySchemaName: stageColumnReferenceEntitySchema.name
				};
				var columnValues = {};
				columnValues[entitySchema.primaryColumnName] = config.value;
				columnValues[entitySchema.primaryDisplayColumnName] = config.displayValue;
				Ext.apply(createConfig, {columnValues: columnValues});
				Terrasoft.DataManager.createItem(createConfig, callback, scope);
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#onElementDataLoad
			 * @override
			 */
			onElementDataLoad: function(element) {
				this.callParent(arguments);
				const parentSchema = element.parentSchema;
				const stageConnections = parentSchema.stageConnections;
				this.set("ParentSchema", parentSchema);
				this.set("StageConnections", stageConnections);
				this.set("isSuccessful", element.isSuccessful);
				this.subscribeForContainerListEvents(outgoingConnectionsModuleId);
				this.subscribeForContainerListEvents(incomingConnectionsModuleId);
				this.subscribeForContainerListStagePermissionsEvents();
				this.subscribeForStagesCollectionChange();
			},

			/**
			 * Subscribes for stage permissions container list events.
			 * @protected
			 */
			subscribeForContainerListStagePermissionsEvents: function() {
				if (this._isFeatureDcmStagesPermissionsDisabled()) {
					return;
				}
				this.sandbox.subscribe("InitEditableContainerListItems",
						this.getEditableContainerStagePermissionsItems, this, [stagePermissionsModuleId]);
				this.sandbox.subscribe("OnSelectedItemsChange", this.onContainerStagePermissionsItemsChange,
						this, [stagePermissionsModuleId]);
			},

			/**
			 * Sends update container list items when container list items are changed.
			 * @protected
			 * @abstract
			 * @param {Object} config On change config.
			 * @param {String} config.moduleId Container list module id.
			 * @param {Terrasoft.Collection} config.items Container list items.
			 */
			onContainerStagePermissionsItemsChange: function(config) {
				const permissions = this.$Permissions;
				const containerListItems = config.items;
				const selectedItems = containerListItems.filterByFn(function(item) {
					return item.selected;
				}, this);
				permissions.reloadPermissions(selectedItems);
			},

			/**
			 * Gets stage permissions items for editable container list.
			 * @protected
			 * @return {Object} Module config.
			 * @return {Terrasoft.Collection} items Container list items.
			 * @return {Function} customGetViewConfig Custom function for item view config generator.
			 */
			getEditableContainerStagePermissionsItems: function(moduleId) {
				const items = this.createContainerStagePermissionsItems(moduleId);
				return {
					items: items,
					setCustomViewConfig: null
				};
			},

			/**
			 * Create stage permissions items for editable container.
			 * @protected
			 * @return {Terrasoft.Collection} Collections of stage permissions items for editable container list.
			 */
			createContainerStagePermissionsItems: function(moduleId) {
				const permissions = this.$Permissions;
				const containerItems = permissions.getContainerItems();
				const collection = Ext.create("Terrasoft.Collection");
				containerItems.each(function(stage) {
					const stageListItem = this.getStageContainerListItem(stage, moduleId);
					collection.add(stageListItem.id, stageListItem);
				}, this);
				return collection;
			},

			/**
			 * Creates container list stage permissions item.
			 * @param {Terrasoft.BaseViewModel} item Stage view model.
			 * @param {String} moduleId Container list module id owner of the item.
			 * @returns {Terrasoft.EditableContainerListItemViewModel} Container list item.
			 */
			getStageContainerListItem: function(item, moduleId) {
				const key = item.get("Id");
				const caption = item.get("Name");
				const permissionsProp = this.$Permissions;
				const selected = permissionsProp.contains(key);
				return this.createContainerListItem(key, caption, selected, null, moduleId);
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#getInitEditableContainerListItems
			 * @override
			 */
			getInitEditableContainerListItems: function(moduleId) {
				const items = this.getEditableContainerListItems(moduleId);
				return {
					items: items,
					setCustomViewConfig: null
				};
			},

			/**
			 * @inheritdoc EditableContainerListMixin#getEditableContainerListItems
			 * @override
			 */
			getEditableContainerListItems: function(moduleId) {
				const parentSchema = this.get("ParentSchema");
				const propertyPageStageUId = this.get("uId");
				const stages = parentSchema.stages;
				const result = Ext.create("Terrasoft.Collection");
				stages
					.filterByFn(function(stage) {
						const stageUId = stage.uId;
						return stageUId !== propertyPageStageUId;
					}, this)
					.each(function(stage) {
						const id = stage.uId;
						const caption = stage.getCaption();
						const connectionConfig = this.getConnectionConfigByModuleId(id, moduleId);
						const selected = connectionConfig.selected;
						const connectionObject = connectionConfig.connectionObject;
						const containerListItem = this.createContainerListItem(id, caption, selected,
							connectionObject, moduleId);
						result.add(id, containerListItem);
					}, this);
				return result;
			},

			/**
			 * @inheritdoc EditableMixin#onContainerListItemsChange
			 * @override
			 */
			onContainerListItemsChange: function(config) {
				const moduleId = config.moduleId;
				const itemsCollection = config.items;
				const itemsArray = itemsCollection.getItems();
				const propertyPageStageUId = this.get("uId");
				const stageConnections = this.get("StageConnections");
				this.clearConnectionsByModuleId(propertyPageStageUId, moduleId);
				itemsArray
					.filter(function(item) {
						return item.selected;
					})
					.forEach(function(item) {
						const connectionObject = item.persistentObject;
						stageConnections.addConnection(connectionObject.source, connectionObject.target);
					}, this);
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
			 * @override
			 */
			saveValues: function() {
				this.callParent(arguments);
				const stage = this.getCurrentStage();
				const transitionType = this.get("TransitionType");
				const permissionsProp = this.$Permissions;
				const transitionTypeValue = transitionType
					? transitionType.value
					: Terrasoft.DcmConstants.StageTransitionType.NONE.value;
				stage.setPropertyValue("isSuccessful", this.get("isSuccessful"));
				stage.setPropertyValue("transitionType", transitionTypeValue);
				stage.setPropertyValue("color", this.get("Color"));
				if (this._isFeatureDcmStagesPermissionsEnabled()) {
					const usePermissions = this.$UsePermissions;
					const permissions = usePermissions ? permissionsProp.getPermissionsString() : Terrasoft.emptyString;
					stage.setPropertyValue("permissions", permissions);
					stage.setPropertyValue("usePermissions", usePermissions);
				}
			},

			/**
			 * Subscribes for schema stage collection change events.
			 * @private
			 */
			subscribeForStagesCollectionChange: function() {
				const parentSchema = this.get("ParentSchema");
				const collection = parentSchema.stages;
				collection.on("add", this.updateIncomingAndOutgoingContainerLists, this);
				collection.on("remove", this.updateIncomingAndOutgoingContainerLists, this);
				collection.on("clear", this.updateIncomingAndOutgoingContainerLists, this);
			},

			/**
			 * Updates container lists when schema stages collection change.
			 * @private
			 */
			updateIncomingAndOutgoingContainerLists: function() {
				this.sandbox.registerMessages({
					"SetEditableContainerListItems": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.PUBLISH
					}
				});
				this.updateEditableContainerListItems(incomingConnectionsModuleId);
				this.updateEditableContainerListItems(outgoingConnectionsModuleId);
			},

			/**
			 * Returns connection config by container list module id.
			 * @param {Terrasoft.DataValueType.GUID} stageUId UId for
			 * @param {String} moduleId Container list module id.
			 * @return {Object} Connection config. Contains item selection and persistentObject.
			 */
			getConnectionConfigByModuleId: function(stageUId, moduleId) {
				let config;
				const propertyPageStageUId = this.get("uId");
				const stageConnections = this.get("StageConnections");
				if (moduleId === incomingConnectionsModuleId) {
					const incomingConnectionsArray = stageConnections.getIncomingConnections(propertyPageStageUId);
					config = this.getConnectionConfig(stageUId, propertyPageStageUId, incomingConnectionsArray);
				} else if (moduleId === outgoingConnectionsModuleId) {
					const outgoingConnectionsArray = stageConnections.getOutgoingConnections(propertyPageStageUId);
					config = this.getConnectionConfig(propertyPageStageUId, stageUId, outgoingConnectionsArray);
				} else {
					throw new Terrasoft.ItemNotFoundException();
				}
				return config;
			},

			/**
			 * Returns connection config from connection array.
			 * @param {Terrasoft.DataValueType.GUID} source Connected from stage uid.
			 * @param {Terrasoft.DataValueType.GUID} target Connected to stage uid.
			 * @param {Array} connectionArray Whole connections array.
			 * @return {Object} Connection config.
			 */
			getConnectionConfig: function(source, target, connectionArray) {
				let selected;
				let connectionConfig;
				const existingConnectionObject = Ext.Array.findBy(connectionArray, function(connection) {
					return connection.source === source && connection.target === target;
				}, this);
				if (existingConnectionObject) {
					selected = true;
					connectionConfig = existingConnectionObject;
				} else {
					selected = false;
					connectionConfig = {
						source: source,
						target: target
					};
				}
				return {
					selected: selected,
					connectionObject: connectionConfig
				};
			},

			/**
			 * Removes connections to given stage, connected in a given direction.
			 * @param  {Terrasoft.DataValueType.GUID} stageUId Stage uId.
			 * @param {String} moduleId Container list module id.
			 */
			clearConnectionsByModuleId: function(stageUId, moduleId) {
				const stageConnections = this.get("StageConnections");
				if (moduleId === incomingConnectionsModuleId) {
					stageConnections.removeAllIncomingConnections(stageUId);
				} else if (moduleId === outgoingConnectionsModuleId) {
					stageConnections.removeAllOutgoingConnections(stageUId);
				} else {
					throw new Terrasoft.ItemNotFoundException();
				}
			},

			/**
			 * Returns flag that indicates final stage or not.
			 * @return {Boolean}
			 */
			getIsFinalStage: function() {
				const stage = this.getCurrentStage();
				const parentSchema = stage.parentSchema;
				return parentSchema.getIsFinalStage(stage);
			},

			/**
			 * Returns True if IsInGroup is disabled.
			 * @private
			 * @return {Boolean}
			 */
			getIsTipVisible: function() {
				return !this.getIsInGroupEnabled();
			},

			/**
			 * Returns True if UsePermissions is enabled.
			 * @private
			 * @return {Boolean} State of UsePermissions attribute.
			 */
			_isUsePermissions: function() {
				return this._isFeatureDcmStagesPermissionsDisabled() ? false : this.$UsePermissions;
			},

			/**
			 * Gets feature DcmStagesPermissions stage.
			 * @private
			 * @return {Boolean} True, if state of feature DcmStagesPermissions is enabled, false otherwise.
			 */
			_isFeatureDcmStagesPermissionsEnabled: function() {
				return this.getIsFeatureEnabled("DcmStagesPermissions");
			},

			/**
			 * Gets feature DcmStagesPermissions invert state.
			 * @private
			 * @return {Boolean} True, if state of feature DcmStagesPermissions is disabled, false otherwise.
			 */
			_isFeatureDcmStagesPermissionsDisabled: function() {
				return !this._isFeatureDcmStagesPermissionsEnabled();
			},

			/**
			 * @inheritdoc Terrasoft.BaseProcessSchemaElementPropertiesPage#onDestroy
			 * @override
			 */
			onDestroy: function() {
				const stage = this.getCurrentStage();
				if (stage) {
					stage.un("changed", this.onStageChanged, this);
				}
				this.callParent(arguments);
			},

			/**
			 * Prepares list of values to display in dropDown list for Transition type field.
			 * @param {String} filter Filter value.
			 * @param {Terrasoft.Collection} list The list that will be to filled in values.
			 */
			onPrepareTransitionTypeList: function(filter, list) {
				list.clear();
				list.loadAll(Terrasoft.DcmConstants.StageTransitionType);
			},

			getStagesPermissionsHint: function() {
				return resources.localizableStrings.AddPermissionsButtonHint;
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "ToolsButton"
			},
			{
				"operation": "insert",
				"parentName": "EditorsContainer",
				"propertyName": "items",
				"name": "DcmSchemaStageLayout",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": [],
					"classes": {
						"wrapClassName": ["base-data-modification-user-task-properties-page",
							"dcm-schema-stage-properties-page"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "StageValueInLookupCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"wrapClass": ["top-caption-control"],
					"caption": {"bindTo": "Resources.Strings.StageValueInLookupCaption"},
					"layout": {"column": 0, "row": 0, "colSpan": 24, "rowSpan": 0},
					"classes": {"labelClass": ["t-title-label-stage"]}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "LookupRecord",
				"values": {
					"layout": {"column": 0, "row": 1, "colSpan": 24},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {"bindTo": "prepareLookupRecordList"},
						"filterComparisonType": Terrasoft.StringFilterType.CONTAIN
					},
					"labelConfig": {"visible": false},
					"wrapClass": ["no-caption-control"]
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "StageValidToMoveCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.StageValidToMoveCaption"},
					"classes": {"labelClass": ["t-title-label-stage"]},
					"layout": {"column": 0, "row": 2, "colSpan": 24, "rowSpan": 1}
				}
			},

			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "OutgoingConnectionsContainerList",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"layout": {"column": 0, "row": 3, "colSpan": 20}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "WithStageValidMoveCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.WithStageValidMoveCaption"},
					"classes": {"labelClass": ["t-title-label-stage"]},
					"layout": {"column": 0, "row": 4, "colSpan": 24, "rowSpan": 1}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "IncomingConnectionsContainerList",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"layout": {"column": 0, "row": 5, "colSpan": 20}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "TransitionTypeCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.TransitionTypeCaption"},
					"classes": {"labelClass": ["t-title-label-stage"]},
					"layout": {"column": 0, "row": 6, "colSpan": 24, "rowSpan": 1}
				}
			},
			{
				"operation": "insert",
				"name": "TransitionType",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"values": {
					"layout": {"column": 0, "row": 7, "colSpan": 24},
					"contentType": Terrasoft.ContentType.ENUM,
					"labelConfig": {"visible": false},
					"controlConfig": {
						"prepareList": {"bindTo": "onPrepareTransitionTypeList"}
					},
					"wrapClass": ["top-caption-control"]
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "AdditionalSettingsCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.AdditionalSettingsCaption"},
					"classes": {"labelClass": ["t-title-label-stage"]},
					"layout": {"column": 0, "row": 8, "colSpan": 24}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "IsInGroup",
				"values": {
					"layout": {"column": 0, "row": 9, "colSpan": 20},
					"caption": {"bindTo": "Resources.Strings.IsGroupWithOtherStageCaption"},
					"enabled": {"bindTo": "getIsInGroupEnabled"},
					"wrapClass": ["t-checkbox-control"]
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "IsInGroupInfoButton",
				"values": {
					"layout": {"column": 21, "row": 9, "colSpan": 4},
					"controlConfig": {
						"classes": {"imageClass": "group-information-btn"},
						"visible": {"bindTo": "getIsTipVisible"}
					},
					"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"content": {"bindTo": "Resources.Strings.StageIsAlreadyInGroupTip"}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "ParentStage",
				"values": {
					"layout": {"column": 0, "row": 10, "colSpan": 24},
					"contentType": Terrasoft.ContentType.ENUM,
					"labelConfig": {"visible": false},
					"controlConfig": {
						"prepareList": {"bindTo": "prepareParentStageList"}
					},
					"visible": {"bindTo": "IsInGroup"},
					"wrapClass": ["no-caption-control"]
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "isSuccessful",
				"values": {
					"layout": {"column": 0, "row": 11, "colSpan": 24, "rowSpan": 0},
					"wrapClass": ["t-checkbox-control"],
					"visible": {"bindTo": "getIsFinalStage"}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "Color",
				"values": {
					"itemType": Terrasoft.ViewItemType.COLOR_BUTTON,
					"menuItemClassName": "Terrasoft.DcmColorMenuItem",
					"classes": {"wrapClasses": ["settings-color-button"]},
					"value": {"bindTo": "Color"},
					"layout": {"column": 7, "row": 13, "colSpan": 6, "rowSpan": 0}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "ColorCaption",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.StageColorCaption"},
					"classes": {"labelClass": ["color-button-label"]},
					"layout": {"column": 0, "row": 13, "colSpan": 7, "rowSpan": 0}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "DcmPermissionsContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"visible": {"bindTo": "_isFeatureDcmStagesPermissionsEnabled"},
					"items": [],
					"layout": {
						"column": 0,
						"row": 15,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmPermissionsContainer",
				"propertyName": "items",
				"name": "UsePermissions",
				"values": {
					"layout": {"column": 0, "row": 0, "colSpan": 20},
					"caption": {"bindTo": "Resources.Strings.StagePermissions"},
					"wrapClass": ["t-checkbox-control"],
					"visible": {"bindTo": "_isFeatureDcmStagesPermissionsEnabled"}
				}
			},
			{
				"name": "ReadRightsGroupInfoButton",
				"parentName": "DcmPermissionsContainer",
				"operation": "insert",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
					"layout": {"column": 20, "row": 0, "colSpan": 4},
					"items": [],
					"content": {
						"bindTo": "getStagesPermissionsHint"
					},
					"behaviour": {
						"displayEvent": Terrasoft.TipDisplayEvent.HOVER
					},
					"controlConfig": {
						"classes": {"imageClass": "group-information-btn"}
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "DcmSchemaStageLayout",
				"propertyName": "items",
				"name": "StagePermissionsContainerList",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE,
					"visible": {"bindTo": "_isUsePermissions"},
					"layout": {"column": 0, "row": 16, "colSpan": 20}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


