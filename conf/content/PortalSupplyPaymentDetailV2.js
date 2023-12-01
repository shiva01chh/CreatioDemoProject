﻿Terrasoft.configuration.Structures["PortalSupplyPaymentDetailV2"] = {innerHierarchyStack: ["PortalSupplyPaymentDetailV2"], structureParent: "SupplyPaymentDetailV2"};
define('PortalSupplyPaymentDetailV2Structure', ['PortalSupplyPaymentDetailV2Resources'], function(resources) {return {schemaUId:'e2030a45-5402-479e-b7a1-0a39c70e007d',schemaCaption: "Installment plan portal detail", parentSchemaName: "SupplyPaymentDetailV2", packageName: "PRMOrder", schemaName:'PortalSupplyPaymentDetailV2',parentSchemaUId:'efa63fa5-d3d2-404a-840e-62b884827a87',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PortalSupplyPaymentDetailV2", [],
	function() {
		return {
			entitySchemaName: "SupplyPaymentElement",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetail#getAddTypedRecordButtonVisible
				 */
				getAddTypedRecordButtonVisible: function() {
					return false;
				},

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
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#getModuleInfoResponse
				 * @override
				 */
				getModuleInfoResponse: function() {
					const parentResponse = this.callParent(arguments);
					parentResponse.schemaName = "PortalSupplyPaymentProductDetailModalBox";
					return parentResponse;
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#getModalBoxProductDetailId
				 * @override
				 */
				getModalBoxProductDetailId: function() {
					return this.sandbox.id + "_PortalSupplyPaymentProductDetailModalBox";
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#onClearProductsButtonClick
				 * @override
				 */
				onClearProductsButtonClick: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
				 * @override
				 */
				getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @override
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @override
				 */
				getEditRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
				 * @override
				 */
				getSwitchGridModeMenuItem: this.Terrasoft.emptyFn
			},
			diff: [
				{
					"operation": "remove",
					"name": "activeRowActionSave"
				},
				{
					"operation": "remove",
					"name": "activeRowActionOpenCard"
				},
				{
					"operation": "remove",
					"name": "activeRowActionCancel"
				},
				{
					"operation": "remove",
					"name": "activeRowActionRemove"
				}
			]
		};
	}
);


