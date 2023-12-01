﻿Terrasoft.configuration.Structures["BaseManageAudienceSection"] = {innerHierarchyStack: ["BaseManageAudienceSection"], structureParent: "BaseAudienceSection"};
define('BaseManageAudienceSectionStructure', ['BaseManageAudienceSectionResources'], function(resources) {return {schemaUId:'3f3e590a-d695-4b60-a585-24f7c571a320',schemaCaption: "Base section to manage audience", parentSchemaName: "BaseAudienceSection", packageName: "MarketingCampaign", schemaName:'BaseManageAudienceSection',parentSchemaUId:'95d5be15-5f19-450d-9b9b-8d73a16468aa',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("BaseManageAudienceSection", ["BaseManageAudienceSectionResources"],
	function(resources) {
		return {
			properties: {
				/**
				 * Audience delete mode.
				 * @type {Object}
				 */
				deleteMode: {
					SELECTED: 0,
					FOLDER: 1,
					FILTERED: 2,
					AUDIENCE: 3
				},

				/**
				 * Bulk email audience extended entity schema name.
				 * @type {String}
				 */
				audienceSchemaName: null,

				/**
				 * Audience extended entity schema.
				 * @type {Object}
				 */
				audienceSchema: null,

				/**
				 * Master record entity schema name to filter audience.
				 * @type {String}
				 */
				masterRecordEntitySchemaName: null
			},
			methods: {

				/**
				* @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
				* @override
				*/
				getModuleCaption: function() {
					return Ext.String.format(resources.localizableStrings.SectionCaption, this.$RecordName);
				},

				/**
				* @inheritdoc Terrasoft.BaseDataView#getQuickFilterModuleId
				* @override
				*/
				getQuickFilterModuleId: function() {
					var baseFilterModuleId = this.callParent(arguments);
					return this.audienceSchemaName + baseFilterModuleId;
				},

				/**
				 * @inheritdoc Terrasoft.BaseDataView#getFiltersKey
				 * @override
				 */
				getFiltersKey: function() {
					var baseFilterKey = this.callParent(arguments);
					return this.audienceSchemaName + baseFilterKey;
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#getSessionFiltersKey
				 * @override
				 */
				getSessionFiltersKey: function() {
					var baseSessionFilterKey = this.callParent(arguments);
					return this.audienceSchemaName + baseSessionFilterKey;
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#initSection
				 * @override
				 */
				initSection: function() {
					this.callParent(arguments);
					this.$IsSummarySettingsVisible = false;
					this.$ProcessAudienceButtonCaption = resources.localizableStrings.RemoveAudienceButtonCaption;
				},

				/**
				* @inheritdoc Terrasoft.BaseSectionV2#init
				* @override
				*/
				init: function() {
					Terrasoft.ServerChannel.on(Terrasoft.EventName.ON_MESSAGE,
						this.onChannelMessageReceived, this);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseObject#destroy
				 * @override
				 */
				destroy: function() {
					this.Terrasoft.ServerChannel.un(Terrasoft.EventName.ON_MESSAGE,
						this.onChannelMessageReceived, this);
					this.callParent(arguments);
				},

				/**
				 * Handler on WebSocket channel message received event.
				 * @abstract
				 * @param {Terrasoft.ServerChannel} channel WebSocket channel instance.
				 * @param {Object} message WebSocket message instance.
				 */
				onChannelMessageReceived: Terrasoft.abstractFn,

				/**
				 * @inheritdoc Terrasoft.BaseDataView#getGridDataESQ
				 * @override
				 */
				getGridDataESQ: function() {
					var esq = this.callParent(arguments);
					var recordIdFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, this.masterRecordEntitySchemaName, this.$RecordId);
					esq.filters.addItem(recordIdFilter);
					return esq;
				},

				/**
				 * Returns specific config for bulk email audience service to provide remove audience action.
				 * @protected
				 * @abstract
				 * @param {Number} sourceType Source type for remove action.
				 * @param {Array} sourceCollection Source data collection to remove.
				 * @param {Number} estimatedCount Estimated records count to remove.
				 * @param {String} esqSerialized Serialized esq to filter records for remove.
				 * @returns {Object}
				 */
				getRemoveAudienceConfig: Terrasoft.abstractFn,

				/**
				 * Calls audience service to remove selected records by ids.
				 * @protected
				 */
				processSelectedRecords: function() {
					var estimatedCount = this.$SelectedRows.length;
					var config = this.getRemoveAudienceConfig(this.deleteMode.SELECTED, this.$SelectedRows, estimatedCount);
					this.callService(config, this.onProcessAudienceCompleted, this);
				},

				/**
				 * Calls audience service to remove records by serialized esq with filters.
				 * @protected
				 */
				processRecordsByFilter: function() {
					var esq = this.getEsqWithFilters();
					var estimatedCount = this.$EstimatedRecordsCount;
					var esqJson = esq.serialize();
					var config = this.getRemoveAudienceConfig(this.deleteMode.FILTERED, [], estimatedCount, esqJson);
					this.callService(config, this.onProcessAudienceCompleted, this);
				},

				/**
				 * Handler on remove audience completed event.
				 * @protected
				 * @param {Object} result Service response result.
				 */
				onProcessAudienceCompleted: function(result) {
					if (result.Success) {
						this.updateSection();
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * Returns collection of remove audience button menu items.
				 * @protected
				 * @returns {Terrasoft.BaseViewModelCollection}
				 */
				getRemoveAudienceMenuItems: function() {
					var items = new Terrasoft.BaseViewModelCollection();
					items.add(new Terrasoft.BaseViewModel({
						values: {
							"Caption": "$Resources.Strings.RemoveSelectedMenuItemCaption",
							"Click": "$onProcessSelectedRecordsClick",
							"Enabled": "$isAnyRowSelected",
							"Tag": "removeSelected"
						}
					}));
					items.add(new Terrasoft.BaseViewModel({
						values: {
							"Caption": "$Resources.Strings.RemoveByFilterMenuItemCaption",
							"Click": "$onProcessByFilterClick",
							"Enabled": "$CanProcessByFilter",
							"Tag": "removeByFilter"
						}
					}));
					return items;
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#getProcessSelectedConfirmationMessage
				 * @override
				 */
				getProcessSelectedConfirmationMessage: function() {
					return this.get("Resources.Strings.OnRemoveSelectedRecordsMessage");
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#getProcessByFilterConfirmationMessage
				 * @override
				 */
				getProcessByFilterConfirmationMessage: function() {
					return this.get("Resources.Strings.OnRemoveByFilterMessage");
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#getProcessAudienceButtonCaption
				 * @override
				 */
				getProcessAudienceButtonCaption: function() {
					return this.get("Resources.Strings.RemoveAudienceButtonCaption");
				},

				/**
				 * @inheritdoc Terrasoft.BaseAudienceSection#getSelectedRecordsLimitReachedMessage
				 * @override
				 */
				getSelectedRecordsLimitReachedMessage: function() {
					return this.get("Resources.Strings.SelectedRecordsLimitReachedMessage");
				}
			},
			diff: [
				{
					"operation": "insert",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items",
					"name": "RemoveAudienceButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.GREEN,
						"caption": "$ProcessAudienceButtonCaption",
						"classes": {
							"wrapperClass": ["actions-button-margin-right"]
						},
						"menu": {
							"items": "$getRemoveAudienceMenuItems"
						}
					}
				}
			]
		};
	}
);


