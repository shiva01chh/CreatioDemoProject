Terrasoft.configuration.Structures["PRMTransactionDetail"] = {innerHierarchyStack: ["PRMTransactionDetailPRMBase", "PRMTransactionDetail"], structureParent: "BaseGridDetailV2"};
define('PRMTransactionDetailPRMBaseStructure', ['PRMTransactionDetailPRMBaseResources'], function(resources) {return {schemaUId:'254cee25-205f-4f26-90e2-efc026662cd9',schemaCaption: "PRMTransactionDetail", parentSchemaName: "BaseGridDetailV2", packageName: "PRMPortal", schemaName:'PRMTransactionDetailPRMBase',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('PRMTransactionDetailStructure', ['PRMTransactionDetailResources'], function(resources) {return {schemaUId:'f2c07b2c-86c9-4b32-98d9-d737d452db25',schemaCaption: "PRMTransactionDetail", parentSchemaName: "PRMTransactionDetailPRMBase", packageName: "PRMPortal", schemaName:'PRMTransactionDetail',parentSchemaUId:'254cee25-205f-4f26-90e2-efc026662cd9',extendParent:true,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"PRMTransactionDetailPRMBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('PRMTransactionDetailPRMBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("PRMTransactionDetailPRMBase", [],
		function() {
	return {
		entitySchemaName: "PRMTransaction"
	};
});

define("PRMTransactionDetail", [],
		function() {
	return {
		entitySchemaName: "PRMTransaction",
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


