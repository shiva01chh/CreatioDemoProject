﻿Terrasoft.configuration.Structures["PartnershipLeadDetail"] = {innerHierarchyStack: ["PartnershipLeadDetail"], structureParent: "BaseGridDetailV2"};
define('PartnershipLeadDetailStructure', ['PartnershipLeadDetailResources'], function(resources) {return {schemaUId:'889186f4-4152-4a0b-91bb-78a466eb27a6',schemaCaption: "Partners lead", parentSchemaName: "BaseGridDetailV2", packageName: "PRMBase", schemaName:'PartnershipLeadDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PartnershipLeadDetail", ["ConfigurationConstants", "css!PartnershipLeadDetailCss", "css!SummaryModuleV2"],
		function(ConfigurationConstants) {
	return {
		entitySchemaName: "Lead",
		attributes: {
			IsActiveFiltrationButtonPressed: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN
			}
		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ActiveFiltrationButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"caption": {"bindTo": "Resources.Strings.ActiveFiltrationButtonCaption"},
					"pressed": {"bindTo": "IsActiveFiltrationButtonPressed"},
					"click": {"bindTo": "onActiveFiltrationButtonClick"}
				}
			},
			{
				"operation": "insert",
				"name": "summaryItemsContainer",
				"propertyName": "tools",
				"parentName": "Detail",
				"values": {
					"id": "summaryItemContainer",
					"selectors": {"wrapEl": "#summaryItemContainer"},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["summary-item-container"],
					"visible": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "summaryCountCaption",
				"parentName": "summaryItemsContainer",
				"propertyName": "items",
				"values": {
					"caption": {"bindTo": "Resources.Strings.RecordsCountCaption"},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {"labelClass": ["summary-item-caption"]}
				}
			},
			{
				"operation": "insert",
				"name": "summaryCountValue",
				"parentName": "summaryItemsContainer",
				"propertyName": "items",
				"values": {
					"caption": {"bindTo": "RecordsCount"},
					"markerValue": "RecordsCount",
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {"labelClass": ["summary-item-value"]}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			/**
			* Is active filtration button click handler
			*/
			onActiveFiltrationButtonClick: function() {
				this.$IsActiveFiltrationButtonPressed = !this.$IsActiveFiltrationButtonPressed;
				this._saveFiltersToProfile();
				this.reloadGridData();
			},

			/**
			 * Save filters to profile
			 * @private
			 */
			_saveFiltersToProfile: function() {
				const profile = this.getProfile();
				const key = this.getProfileKey();
				if (this.isNotEmpty(profile) && this.isNotEmpty(key)) {
					profile.IsActiveFiltrationButtonPressed = this.$IsActiveFiltrationButtonPressed;
					this.set(this.getProfileColumnName(), profile);
					this.Terrasoft.utils.saveUserProfile(key, profile, false);
				}
			},

			/**
			 * Load filters from profile
			 * @private
			 */
			_loadFiltersFromProfile: function() {
				const profile = this.getProfile();
				if (this.isNotEmpty(profile)) {
					this.$IsActiveFiltrationButtonPressed = Boolean(profile.IsActiveFiltrationButtonPressed);
				}
			},

			/**
			 * @inheritDoc Terrasoft.GridUtilitiesV2#init
			 * @override
			 */
			init: function() {
				this.callParent(arguments);
				this._loadFiltersFromProfile();
			},

			/**
			 * @inheritDoc Terrasoft.GridUtilities#addGridDataColumns
			 * @override
			 */
			addGridDataColumns: function(esq) {
				this.addCountOverColumn(esq);
				this.callParent(arguments);
			},

			/**
			 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilters
			 * @override
			 */
			getFilters: function() {
				const filterGroup = this.callParent(arguments);
				if (this.$IsActiveFiltrationButtonPressed) {
					this._addActiveFilter(filterGroup);
				}
				return filterGroup;
			},

			/**
			 * Add Active filter
			 * @private
			 */
			_addActiveFilter: function(filterGroup) {
				filterGroup.add("ActiveFilter",
				Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "QualifyStatus.IsFinal",
					false));
			},

			/**
			 * @inheritDoc BaseGridDetailV2#addRecord
			 * @override
			 */
			addRecord: function() {
				this.setupDefaultValues();
				this.callParent(arguments);
			},

			/**
			 * Set default values for card opening.
			 * @protected
			 */
			setupDefaultValues: function() {
				const masterPageColumnNames = ["Account"];
				const masterPageValues = this.sandbox.publish("GetColumnsValues", masterPageColumnNames,
					[this.sandbox.id]);
				if (masterPageValues.Account) {
					this.setDefaultValue("Partner", masterPageValues.Account.value);
				}
				this.setDefaultValue("SalesChannel", ConfigurationConstants.Opportunity.Type.PartnerSale);
			},

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @override
			 */
			getEditRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @override
			 */
			getCopyRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @override
			 */
			getDeleteRecordMenuItem: Terrasoft.emptyFn,

			getRecordRightsSetupMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			getSwitchGridModeMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			getExportToExcelFileMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			getShowQuickFilterButton: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			}
		}
	};
});


