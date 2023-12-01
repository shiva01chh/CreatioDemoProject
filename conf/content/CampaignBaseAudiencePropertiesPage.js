﻿Terrasoft.configuration.Structures["CampaignBaseAudiencePropertiesPage"] = {innerHierarchyStack: ["CampaignBaseAudiencePropertiesPage"], structureParent: "BaseCampaignSchemaElementPage"};
define('CampaignBaseAudiencePropertiesPageStructure', ['CampaignBaseAudiencePropertiesPageResources'], function(resources) {return {schemaUId:'17fd5389-0014-4c8d-942a-b1b2315915f7',schemaCaption: "CampaignBaseAudiencePropertiesPage", parentSchemaName: "BaseCampaignSchemaElementPage", packageName: "CrtCampaignDesigner7x", schemaName:'CampaignBaseAudiencePropertiesPage',parentSchemaUId:'13b73e23-fb4d-41fb-850b-0f4ae4c3e9f1',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Schema of campaign base audience properties page.
 */
define("CampaignBaseAudiencePropertiesPage", ["LookupUtilities",
		"MarketingEnums", "DropdownLookupMixin"],
	function(LookupUtilities, MarketingEnums) {
		return {
			messages: {
				"GetFilterModuleConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"OnFiltersChanged": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"SetFilterModuleConfig": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			properties: {
				defaultAudienceSchemaName: "Contact",
			},
			mixins: {
				campaignElementMixin: "Terrasoft.CampaignElementMixin",
				dropdownLookupMixin: "Terrasoft.DropdownLookupMixin"
			},
			attributes: {
				/**
				 * Folder linked to current element.
				 */
				"Folder": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"referenceSchemaName": "ContactFolder",
					"onChange": "onFolderChanged"
				},

				/**
				 * Collection of folders to display.
				 */
				"FolderCollection": {
					"dataValueType": this.Terrasoft.DataValueType.COLLECTION,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Types of audience source to process participants.
				 * @type {Object}
				 */
				"AudienceSourceEnum": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: {
						Folder: {
							value: 0,
							caption: "Resources.Strings.AudienceSourceFolderCaption"
						},
						Filter: {
							value: 1,
							caption: "Resources.Strings.AudienceSourceFilterCaption"
						}
					}
				},

				/**
				 * Lookup for AudienceSource.
				 * @type {Lookup}
				 */
				"AudienceSource": {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true,
					"onChange": "onAudienceSourceChanged"
				},

				/**
				 * Values collection of lookup for AudienceSource.
				 * @type {Terrasoft.Collection}
				 */
				"AudienceSourceCollection": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: Ext.create("Terrasoft.Collection")
				},

				/**
				 * Flag to indicate select folder posibility for current audience schema.
				 * @type {Boolean}
				 */
				"CanSelectFolder": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: true
				}
			},
			methods: {

				/**
				 * @private
				 */
				_initAudienceSourceLookup: function() {
					var collection = new Terrasoft.Collection();
					Terrasoft.each(this.$AudienceSourceEnum, function(item) {
						var source = {
							value: item.value,
							displayValue: this.get(item.caption)
						};
						collection.add(item.value, source);
					}, this);
					this.$AudienceSourceCollection.reloadAll(collection);
					this.on("change:AudienceSource", this._onAudienceSourceLookupChanged, this);
				},

				/**
				 * @private
				 */
				_onAudienceSourceLookupChanged: function(model, audienceSource) {
					if (!audienceSource || audienceSource.value !== this.$AudienceSourceEnum.Filter.value) {
						this.sandbox.unloadModule(this._getFilterEditModuleId());
					} else {
						this.loadFilterModule();
					}
				},

				/**
				 * @private
				 * @param {Object} source Audience source to check state.
				 */
				_checkAudienceSource: function(source) {
					return Boolean(this.$AudienceSource
						&& this.$AudienceSource.value === source.value);
				},

				/**
				 * @private
				 */
				_isAudienceSourceFolder: function() {
					return this._checkAudienceSource(this.$AudienceSourceEnum.Folder);
				},

				/**
				 * @private
				 */
				_isAudienceSourceFilter: function() {
					return this._checkAudienceSource(this.$AudienceSourceEnum.Filter);
				},

				/**
				 * @private
				 */
				_getFilterEditModuleId: function() {
					return this.sandbox.id + "_AudienceFilterEditModule";
				},

				/**
				 * @inheritdoc Terrasoft.BaseProcessSchemaElementPropertiesPage#init
				 * @override
				 */
				init: function() {
					this.callParent(arguments);
					this.$CanSaveElementConfig = true;
					this.initAcademyUrl(this.onAcademyUrlInitialized, this);
				},

				/**
				 * @protected
				 */
				updateMarkers: function() {
					var element = this.get("ProcessElement");
					element.hasFilter = this._isAudienceSourceFilter();
					element.updateMarkers();
				},

				/**
				 * @inheritdoc Terrasoft.Component#onRender
				 * @override
				 */
				onRender: function() {
					if (this._isAudienceSourceFilter()) {
						this.loadFilterModule();
					}
					this.callParent(arguments);
				},

				/**
				 * Returns data for get contact folder info request.
				 * @protected
				 * @param {Terrasoft.CampaignBaseElementSchema} element Current element schema.
				 */
				getFolderInfoData: function(element) {
					return {
						folderId: element.folderId,
						folderSchemaName: "ContactFolder"
					};
				},

				/**
				 * Loads folder info data.
				 * @protected
				 * @param {Terrasoft.CampaignBaseElementSchema} element Current element schema.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Context.
				 */
				loadFolderEntity: function(element, callback, scope) {
					if (!this.$CanSelectFolder) {
						callback.call(scope);
						return;
					}
					var config = {
						serviceName: "CampaignService",
						methodName: "GetContactFolderInfo",
						data: this.getFolderInfoData(element)
					};
					this.callService(config, function(response) {
						var folderInfo = response.GetContactFolderInfoResult;
						if (folderInfo) {
							var folderItem = {
								Id: folderInfo.Id,
								displayValue: folderInfo.DisplayValue
							};
							this.set("Folder", folderItem);
						}
						callback.call(scope);
					}, this);
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#initPageAsync
				 * @override
				 */
				initPageAsync: function(element, callback, scope) {
					this._initAudienceSourceLookup();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#initElementProperties.
				 * @override
				 */
				 initElementProperties: function(element, callback, scope) {
					var parentMethod = this.getParentMethod();
					this.set("AudienceSource", null, { silent: true });
					this.set("FilterData", element.filter);
					var audienceSource = element.hasFilter
						? this.$AudienceSourceEnum.Filter
						: this.$AudienceSourceEnum.Folder;
					var source = {
						value: audienceSource.value,
						displayValue: this.get(audienceSource.caption)
					};
					this.set("AudienceSource", source, { silent: !this.$PageLoaded });
					if (!Ext.isEmpty(element.folderId)) {
						this.loadFolderEntity(element, function() {
							parentMethod.call(this, element, callback, scope);
						}, scope);
					} else {
						this.set("Folder", null);
						this.callParent(arguments);
					}
					this.$PageLoaded = true;
				 },

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
				 * @overridden
				 */
				saveValues: function() {
					this.callParent(arguments);
					var element = this.get("ProcessElement");
					element.hasFilter = this._isAudienceSourceFilter();
					element.filter = this.$FilterData;
				},

				/**
				 * Handles change of Folder property
				 * @public
				 */
				onFolderChanged: function(model, value) {
					var element = this.get("ProcessElement");
					element.folderId = !Ext.isEmpty(value) ? value.Id : null;
					element.hasFolder = this._isAudienceSourceFolder() && (element.folderId !== null);
					this.updateMarkers();
				},

				/**
				 * @protected
				 */
				onAudienceSourceChanged: function() {
					this.updateMarkers();
				},

				/**
				 * Loads values into audience source combobox.
				 * @protected
				 * @param {Object} filter ComboboxEdit value.
				 * @param {Terrasoft.Collection} list List of comboboxEdit values.
				 */
				onPrepareAudienceSourceList: function(filter, list) {
					list.reloadAll(this.$AudienceSourceCollection);
				},

				/**
				 * Loads Filter module to display filters.
				 * @protected
				 */
				loadFilterModule: function() {
					var sandbox = this.sandbox;
					var moduleId = this._getFilterEditModuleId();
					sandbox.subscribe("OnFiltersChanged", this.onFiltersChanged, this, [moduleId]);
					sandbox.subscribe("GetFilterModuleConfig",
						this.getFilterModuleConfig, this, [moduleId]);
					sandbox.loadModule("FilterEditModule", {renderTo: "AudienceExtendedFiltersContainer", id: moduleId});
				},

				/**
				 * Returns root schema name for filter.
				 * @protected
				 * @returns {String} Root schema name.
				 */
				getFilterRootSchemaName: function() {
					return this.defaultAudienceSchemaName;
				},

				/**
				 * Returns FilterModuleConfig to load filter module.
				 * @protected
				 * @return {object} Filter module config.
				 */
				getFilterModuleConfig: function() {
					return {
						rootSchemaName: this.getFilterRootSchemaName(),
						rightExpressionMenuAligned: true,
						filters: this.get("FilterData"),
						filterProviderClassName: "Terrasoft.EntitySchemaFilterProvider"
					};
				},

				/**
				 * Listener on filters changed.
				 * Sets value of FilterData attribute.
				 * If filter was not changed compare initial and current filter values to check filter changes.
				 * @param {object} args { filter: object, serializedFilter: string } Filters.
				 * @protected
				 */
				onFiltersChanged: function(args) {
					this.set("FilterData", args.serializedFilter);
					var element = this.get("ProcessElement");
					element.filter = this.$FilterData;
					this.updateMarkers();
				},

				/**
				 * Loads entity to init selected ContactFolder property
				 * @return void
				 */
				loadContactFolderSchemaLookup: function() {
					var self = this;
					var config = this.getFolderLookupConfig();
					LookupUtilities.Open(this.sandbox, config, function(args) {
						var collection = args.selectedRows;
						if (collection.getCount() > 0) {
							var selectedItem = collection.getItems()[0];
							self.set("Folder", selectedItem);
						}
					}, this, null, false, false);
				},

				/**
				 * Gets ContactFolder lookup config
				 * @protected
				 * @return {object}
				 */
				getFolderLookupConfig: function() {
					var config = this.getLookupConfig();
					config.entitySchemaName = "ContactFolder";
					var filters = this.getCustomLookupFilters();
					if (filters) {
						config.filters = filters;
					}
					return config;
				},

				/**
				 * Inits custom lookup filters
				 * to not select CampaignFilters folder and its children.
				 * @private
				 * @return {Terrasoft.FilterGroup} custom FilterGroup
				 */
				getCustomLookupFilters: function() {
					var filters = Terrasoft.createFilterGroup();
					filters.logicalOperation = Terrasoft.LogicalOperatorType.AND;
					filters.addItem(Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.NOT_EQUAL, "Parent", MarketingEnums.ContactFolder.CAMPAIGN_FILTERS));
					filters.addItem(Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.NOT_EQUAL, "Id", MarketingEnums.ContactFolder.CAMPAIGN_FILTERS));
					return filters;
				},

				/**
				 * Loads data to init source collection of ContactFolder to display.
				 * @private
				 * @param {string} filterParameter text to search.
				 * @param {Terrasoft.Collection} list collection of items to display.
				 * @param {string} columnName Name of root schema for Folder lookup.
				 */
				prepareFolderList: function(filterParameter, list, columnName) {
					if (list && list instanceof Terrasoft.Collection) {
						list.clear();
					}
					var filters = this.getCustomLookupFilters();
					this.prepareLookupList(filters, filterParameter, columnName,
						"FolderCollection", this);
				},

				/**
				 * Sets Folder lookup selected value as dropdown list item.
				 * @param {object} selectedItem Selected ContactFolder lookup item.
				 */
				onLookupChange: function(selectedItem) {
					this.set("Folder", selectedItem);
				}
			},
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "insert",
					"name": "ContentContainer",
					"propertyName": "items",
					"parentName": "EditorsContainer",
					"className": "Terrasoft.GridLayoutEdit",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "AudienceSourceLayout",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"row": 1,
							"column": 0,
							"rowSpan": 1,
							"colSpan": 24
						},
						"visible": "$CanSelectFolder",
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "AudienceSourceLabel",
					"parentName": "AudienceSourceLayout",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.AudienceSourceTypeLabel",
						"classes": {
							"labelClass": ["t-title-label-proc"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "AudienceSource",
					"parentName": "AudienceSourceLayout",
					"propertyName": "items",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": "$onPrepareAudienceSourceList"
						},
						"isRequired": true,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"]
					}
				},
				{
					"operation": "insert",
					"name": "AudienceSourceContainer",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FolderSourceContainer",
					"parentName": "AudienceSourceContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": "$_isAudienceSourceFolder",
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FolderAudienceSourceLayout",
					"propertyName": "items",
					"parentName": "FolderSourceContainer",
					"className": "Terrasoft.GridLayoutEdit",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FolderLabel",
					"parentName": "FolderAudienceSourceLayout",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 22
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.FolderText"
						},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "Folder",
					"parentName": "FolderAudienceSourceLayout",
					"propertyName": "items",
					"values": {
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"isRequired": true,
						"controlConfig": {
							"loadVocabulary": {
								"bindTo": "loadContactFolderSchemaLookup"
							},
							"prepareList": {
								"bindTo": "prepareFolderList"
							},
							"list": {
								"bindTo": "FolderCollection"
							},
							"tag": "ContactFolder"
						},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"]
					}
				},
				{
					"operation": "insert",
					"name": "FilterSourceContainer",
					"parentName": "AudienceSourceContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "AudienceExtendedFiltersContainer",
					"parentName": "FilterSourceContainer",
					"propertyName": "items",
					"values": {
						"id": "AudienceExtendedFiltersContainer",
						"selectors": {"wrapEl": "#AudienceExtendedFiltersContainer"},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}
			] /**SCHEMA_DIFF*/
		};
	});


