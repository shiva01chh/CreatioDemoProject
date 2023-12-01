Terrasoft.configuration.Structures["FundDetail"] = {innerHierarchyStack: ["FundDetailPRMBase", "FundDetail"], structureParent: "BaseGridDetailV2"};
define('FundDetailPRMBaseStructure', ['FundDetailPRMBaseResources'], function(resources) {return {schemaUId:'d3ab18c6-400c-464b-8df7-daddeff31339',schemaCaption: "FundDetail", parentSchemaName: "BaseGridDetailV2", packageName: "PRMPortal", schemaName:'FundDetailPRMBase',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('FundDetailStructure', ['FundDetailResources'], function(resources) {return {schemaUId:'9f70f657-fea7-427a-bb35-dfb8da7795bd',schemaCaption: "FundDetail", parentSchemaName: "FundDetailPRMBase", packageName: "PRMPortal", schemaName:'FundDetail',parentSchemaUId:'d3ab18c6-400c-464b-8df7-daddeff31339',extendParent:true,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"FundDetailPRMBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('FundDetailPRMBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("FundDetailPRMBase", [],
		function() {
	return {
		entitySchemaName: "Fund",
		methods: {}
	};
});

define("FundDetail", [],
		function() {
	return {
		entitySchemaName: "Fund",
		methods: {

			/**
			 * @inheritDoc BaseGridDetailV2#getAddRecordButtonVisible
			 * @override
			 */
			getAddRecordButtonVisible: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetail#getQuickFilterButton
			 * @override
			 */
			getShowQuickFilterButton: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getGridSortMenuItem
			 * @override
			 */
			getGridSortMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @override
			 */
			getSwitchGridModeMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
			 * @override
			 */
			addDetailWizardMenuItems: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getExportToExcelFileMenuItem
			 * @override
			 */
			getExportToExcelFileMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecordOperationsMenuItems
			 * @override
			 */
			addRecordOperationsMenuItems: function() {
				if (Terrasoft.isCurrentUserSsp()){
					return;
				}
				this.callParent(arguments);
			}
		}
	};
});


