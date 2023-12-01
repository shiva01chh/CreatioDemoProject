﻿Terrasoft.configuration.Structures["LandingInCampaignDetail"] = {innerHierarchyStack: ["LandingInCampaignDetail"], structureParent: "BaseGridDetailV2"};
define('LandingInCampaignDetailStructure', ['LandingInCampaignDetailResources'], function(resources) {return {schemaUId:'abab50e0-4c73-4011-90c7-21195baf61e8',schemaCaption: "Landing in campaign detail", parentSchemaName: "BaseGridDetailV2", packageName: "Campaigns", schemaName:'LandingInCampaignDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("LandingInCampaignDetail", [], function() {
		return {
			entitySchemaName: "VwLandingInCampaign",
			attributes: {},
			messages: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
				 * @overridden
				 */
				getDeleteRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getRecordRightsSetupMenuItem
				 * @overridden
				 */
				getRecordRightsSetupMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
				 * @overridden
				 */
				getSwitchGridModeMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
				 * @overridden
				 */
				addDetailWizardMenuItems: Terrasoft.emptyFn
			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	}
);


