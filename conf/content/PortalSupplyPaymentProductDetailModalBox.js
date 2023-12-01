Terrasoft.configuration.Structures["PortalSupplyPaymentProductDetailModalBox"] = {innerHierarchyStack: ["PortalSupplyPaymentProductDetailModalBox"], structureParent: "SupplyPaymentProductDetailModalBox"};
define('PortalSupplyPaymentProductDetailModalBoxStructure', ['PortalSupplyPaymentProductDetailModalBoxResources'], function(resources) {return {schemaUId:'b4566ea3-2fec-414f-846d-e5d7bb189363',schemaCaption: "Detail schema - Installment plan products in modal window (portal)", parentSchemaName: "SupplyPaymentProductDetailModalBox", packageName: "PRMOrder", schemaName:'PortalSupplyPaymentProductDetailModalBox',parentSchemaUId:'dea00993-6141-49d6-bb3e-7262a644c267',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalSupplyPaymentProductDetailModalBox", [], function() {
	return {
		entitySchemaName: "VwSupplyPaymentProduct",
		methods: {
			/**
			 * @inheritdoc Terrasoft.ConfigurationGridUtilities#getCellControlsConfig
			 * @override
			 */
			getCellControlsConfig: function() {
				const controlsConfig = this.callParent(arguments);
				this.Ext.apply(controlsConfig, {
					enabled: false
				});
				return controlsConfig;
			}
		},
		diff: /**SCHEMA_DIFF*/[{
			"operation": "remove",
			"name": "okButton"
		}, {
			"operation": "remove",
			"name": "cancelButton"
		}]/**SCHEMA_DIFF*/
	};
});


