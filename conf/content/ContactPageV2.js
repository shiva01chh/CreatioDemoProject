﻿Terrasoft.configuration.Structures["ContactPageV2"] = {innerHierarchyStack: ["ContactPageV2CrtUIv2", "ContactPageV2SocialNetworkIntegration", "ContactPageV2RelationshipDesigner", "ContactPageV2FacebookIntegration", "ContactPageV2EmailMining", "ContactPageV2CTIBase", "ContactPageV2CrtDeduplication", "ContactPageV2Completeness", "ContactPageV2CoreContracts", "ContactPageV2Order", "ContactPageV2Invoice", "ContactPageV2Document", "ContactPageV2CrtTouchPoint7x", "ContactPageV2Lead", "ContactPageV2CoreLead", "ContactPageV2Tracking", "ContactPageV2SiteEvent", "ContactPageV2Opportunity", "ContactPageV2Project", "ContactPageV2PRMBase", "ContactPageV2SalesEnterprise", "ContactPageV2Case", "ContactPageV2EmailMessageMining", "ContactPageV2CMDB", "ContactPageV2SLMITILService", "ContactPageV2MarketingCampaign", "ContactPageV2"], structureParent: "BaseModulePageV2"};
define('ContactPageV2CrtUIv2Structure', ['ContactPageV2CrtUIv2Resources'], function(resources) {return {schemaUId:'8737e39c-ac08-4903-acd0-11570570691d',schemaCaption: "Display schema - Contact card", parentSchemaName: "BaseModulePageV2", packageName: "EventTracking", schemaName:'ContactPageV2CrtUIv2',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2SocialNetworkIntegrationStructure', ['ContactPageV2SocialNetworkIntegrationResources'], function(resources) {return {schemaUId:'34be062d-9b43-4613-8be9-8dd0253aecd9',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CrtUIv2", packageName: "EventTracking", schemaName:'ContactPageV2SocialNetworkIntegration',parentSchemaUId:'8737e39c-ac08-4903-acd0-11570570691d',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CrtUIv2",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2RelationshipDesignerStructure', ['ContactPageV2RelationshipDesignerResources'], function(resources) {return {schemaUId:'c1750c61-2002-4994-9aa2-31a763c62113',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2SocialNetworkIntegration", packageName: "EventTracking", schemaName:'ContactPageV2RelationshipDesigner',parentSchemaUId:'34be062d-9b43-4613-8be9-8dd0253aecd9',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2SocialNetworkIntegration",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2FacebookIntegrationStructure', ['ContactPageV2FacebookIntegrationResources'], function(resources) {return {schemaUId:'7a52efe6-2a82-4bbd-bc52-7ad40d70073b',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2RelationshipDesigner", packageName: "EventTracking", schemaName:'ContactPageV2FacebookIntegration',parentSchemaUId:'c1750c61-2002-4994-9aa2-31a763c62113',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2RelationshipDesigner",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2EmailMiningStructure', ['ContactPageV2EmailMiningResources'], function(resources) {return {schemaUId:'60c234b5-203f-42ff-b455-5efebdfa5a03',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2FacebookIntegration", packageName: "EventTracking", schemaName:'ContactPageV2EmailMining',parentSchemaUId:'7a52efe6-2a82-4bbd-bc52-7ad40d70073b',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2FacebookIntegration",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CTIBaseStructure', ['ContactPageV2CTIBaseResources'], function(resources) {return {schemaUId:'433ec606-b822-4f08-b9d2-1f8749cb26e5',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2EmailMining", packageName: "EventTracking", schemaName:'ContactPageV2CTIBase',parentSchemaUId:'60c234b5-203f-42ff-b455-5efebdfa5a03',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2EmailMining",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CrtDeduplicationStructure', ['ContactPageV2CrtDeduplicationResources'], function(resources) {return {schemaUId:'df5ad376-94d5-4aa1-af80-2fe1d740df66',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CTIBase", packageName: "EventTracking", schemaName:'ContactPageV2CrtDeduplication',parentSchemaUId:'433ec606-b822-4f08-b9d2-1f8749cb26e5',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CTIBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CompletenessStructure', ['ContactPageV2CompletenessResources'], function(resources) {return {schemaUId:'da5fb5d8-27da-4a78-bb40-cbe212df8bae',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CrtDeduplication", packageName: "EventTracking", schemaName:'ContactPageV2Completeness',parentSchemaUId:'df5ad376-94d5-4aa1-af80-2fe1d740df66',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CrtDeduplication",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CoreContractsStructure', ['ContactPageV2CoreContractsResources'], function(resources) {return {schemaUId:'eeca982a-4f4b-483e-bc0e-1711e5b77e36',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Completeness", packageName: "EventTracking", schemaName:'ContactPageV2CoreContracts',parentSchemaUId:'da5fb5d8-27da-4a78-bb40-cbe212df8bae',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Completeness",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2OrderStructure', ['ContactPageV2OrderResources'], function(resources) {return {schemaUId:'84b44fbb-c26d-4fdf-8ca2-05abacea3cb4',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CoreContracts", packageName: "EventTracking", schemaName:'ContactPageV2Order',parentSchemaUId:'eeca982a-4f4b-483e-bc0e-1711e5b77e36',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CoreContracts",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2InvoiceStructure', ['ContactPageV2InvoiceResources'], function(resources) {return {schemaUId:'208ba258-1d5e-4d88-bd07-ce130ffb5573',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Order", packageName: "EventTracking", schemaName:'ContactPageV2Invoice',parentSchemaUId:'84b44fbb-c26d-4fdf-8ca2-05abacea3cb4',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Order",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2DocumentStructure', ['ContactPageV2DocumentResources'], function(resources) {return {schemaUId:'a18a034a-f963-4fc5-8bf3-af5ed06546a9',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Invoice", packageName: "EventTracking", schemaName:'ContactPageV2Document',parentSchemaUId:'208ba258-1d5e-4d88-bd07-ce130ffb5573',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Invoice",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CrtTouchPoint7xStructure', ['ContactPageV2CrtTouchPoint7xResources'], function(resources) {return {schemaUId:'419cee73-416a-4844-96cb-c223cb40f563',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Document", packageName: "EventTracking", schemaName:'ContactPageV2CrtTouchPoint7x',parentSchemaUId:'a18a034a-f963-4fc5-8bf3-af5ed06546a9',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Document",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2LeadStructure', ['ContactPageV2LeadResources'], function(resources) {return {schemaUId:'1a705433-db1b-4304-a9a4-85eabb20cfac',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CrtTouchPoint7x", packageName: "EventTracking", schemaName:'ContactPageV2Lead',parentSchemaUId:'419cee73-416a-4844-96cb-c223cb40f563',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CrtTouchPoint7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CoreLeadStructure', ['ContactPageV2CoreLeadResources'], function(resources) {return {schemaUId:'aec5a97b-6023-48ec-b8d1-13cd199bef28',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Lead", packageName: "EventTracking", schemaName:'ContactPageV2CoreLead',parentSchemaUId:'1a705433-db1b-4304-a9a4-85eabb20cfac',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Lead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2TrackingStructure', ['ContactPageV2TrackingResources'], function(resources) {return {schemaUId:'7da8349f-e021-4821-a6f2-05dda072eaec',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CoreLead", packageName: "EventTracking", schemaName:'ContactPageV2Tracking',parentSchemaUId:'aec5a97b-6023-48ec-b8d1-13cd199bef28',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CoreLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2SiteEventStructure', ['ContactPageV2SiteEventResources'], function(resources) {return {schemaUId:'6808667c-53ff-47f0-8153-9226a0662451',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Tracking", packageName: "EventTracking", schemaName:'ContactPageV2SiteEvent',parentSchemaUId:'7da8349f-e021-4821-a6f2-05dda072eaec',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Tracking",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2OpportunityStructure', ['ContactPageV2OpportunityResources'], function(resources) {return {schemaUId:'2c0bfb19-19e7-4237-99d4-3ee28e7d9224',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2SiteEvent", packageName: "EventTracking", schemaName:'ContactPageV2Opportunity',parentSchemaUId:'6808667c-53ff-47f0-8153-9226a0662451',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2SiteEvent",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2ProjectStructure', ['ContactPageV2ProjectResources'], function(resources) {return {schemaUId:'c7f18f7e-6a5b-48f7-9b1c-5646304ac873',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Opportunity", packageName: "EventTracking", schemaName:'ContactPageV2Project',parentSchemaUId:'2c0bfb19-19e7-4237-99d4-3ee28e7d9224',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Opportunity",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2PRMBaseStructure', ['ContactPageV2PRMBaseResources'], function(resources) {return {schemaUId:'f895a72d-cdae-4e23-af72-6cbda792247c',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Project", packageName: "EventTracking", schemaName:'ContactPageV2PRMBase',parentSchemaUId:'c7f18f7e-6a5b-48f7-9b1c-5646304ac873',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Project",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2SalesEnterpriseStructure', ['ContactPageV2SalesEnterpriseResources'], function(resources) {return {schemaUId:'3272c141-93f9-4f59-beea-0a9c6cd9060e',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2PRMBase", packageName: "EventTracking", schemaName:'ContactPageV2SalesEnterprise',parentSchemaUId:'f895a72d-cdae-4e23-af72-6cbda792247c',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2PRMBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CaseStructure', ['ContactPageV2CaseResources'], function(resources) {return {schemaUId:'4dac5d9b-8bcb-4147-854d-e0e7fbbcf709',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2SalesEnterprise", packageName: "EventTracking", schemaName:'ContactPageV2Case',parentSchemaUId:'3272c141-93f9-4f59-beea-0a9c6cd9060e',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2SalesEnterprise",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2EmailMessageMiningStructure', ['ContactPageV2EmailMessageMiningResources'], function(resources) {return {schemaUId:'b90f6105-5c63-4d8f-989c-7273cff10f5e',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2Case", packageName: "EventTracking", schemaName:'ContactPageV2EmailMessageMining',parentSchemaUId:'4dac5d9b-8bcb-4147-854d-e0e7fbbcf709',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2Case",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CMDBStructure', ['ContactPageV2CMDBResources'], function(resources) {return {schemaUId:'09184d0c-b407-46c1-998b-cf9dec426acc',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2EmailMessageMining", packageName: "EventTracking", schemaName:'ContactPageV2CMDB',parentSchemaUId:'b90f6105-5c63-4d8f-989c-7273cff10f5e',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2EmailMessageMining",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2SLMITILServiceStructure', ['ContactPageV2SLMITILServiceResources'], function(resources) {return {schemaUId:'8a529cee-7f2c-41b3-956e-fd9e705d53b1',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2CMDB", packageName: "EventTracking", schemaName:'ContactPageV2SLMITILService',parentSchemaUId:'09184d0c-b407-46c1-998b-cf9dec426acc',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2CMDB",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2MarketingCampaignStructure', ['ContactPageV2MarketingCampaignResources'], function(resources) {return {schemaUId:'4f507863-1c07-4f80-a58a-278393b58916',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2SLMITILService", packageName: "EventTracking", schemaName:'ContactPageV2MarketingCampaign',parentSchemaUId:'8a529cee-7f2c-41b3-956e-fd9e705d53b1',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2SLMITILService",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2Structure', ['ContactPageV2Resources'], function(resources) {return {schemaUId:'4778f5b5-bb6a-4b1b-8f8d-b84d70becbb4',schemaCaption: "Display schema - Contact card", parentSchemaName: "ContactPageV2MarketingCampaign", packageName: "EventTracking", schemaName:'ContactPageV2',parentSchemaUId:'4f507863-1c07-4f80-a58a-278393b58916',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ContactPageV2MarketingCampaign",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ContactPageV2CrtUIv2Resources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CrtUIv2", ["BaseFiltersGenerateModule", "BusinessRuleModule", "ContactPageV2Resources",
	"ConfigurationConstants", "ContactCareer", "EmailHelper", "FileUploadErrorHandlersResources", "TimezoneGenerator",
	"TimezoneMixin", "CommunicationSynchronizerMixin", "CommunicationOptionsMixin"
], function(BaseFiltersGenerateModule, BusinessRuleModule, resources, ConfigurationConstants, ContactCareer,
	EmailHelper, FileUploadErrorHandlersResources) {
	return {
		entitySchemaName: "Contact",
		messages: {

			/**
			 * @message BirthdateChanged
			 * Notify that BirthDate was changed.
			 */
			"BirthdateChanged": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message SetInitialisationData
			 * Sets initial values for search in social networks.
			 */
			"SetInitialisationData": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message ResultSelectedRows
			 * Returs selected rows in reference.
			 */
			"ResultSelectedRows": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message GetCommunicationsList
			 * Requests communications list.
			 */
			"GetCommunicationsList": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message SyncCommunication
			 * Synchronizes communications.
			 */
			"SyncCommunication": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message GetCommunicationsSynchronizedByDetail
			 * Requests communications synchronized by detail.
			 */
			"GetCommunicationsSynchronizedByDetail": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message CallCustomer
			 * Starts phone call in CTI panel.
			 */
			"CallCustomer": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		attributes: {
			"MaxPhotoFileSize": {
				dataValueType: Terrasoft.DataValueType.INTEGER,
				value: 4 * 1024 * 1024
			},
			"PrimaryContactAdd": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			"SomeCalcField": {
				name: "CalcField",
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			"Owner": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				lookupListConfig: {filter: BaseFiltersGenerateModule.OwnerFilter}
			},
			/**
			 * @deprecated
			 */
			"AccountIsEmpty": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			"JobTitle": {
				dependencies: [
					{
						columns: ["Job"],
						methodName: "jobChanged"
					}
				]
			},
			"canUseSocialFeaturesByBuildType": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: false
			},
			/**
			 * Contact account.
			 */
			"Account": {
				lookupListConfig: {
					columns: ["Type"]
				}
			},
			/**
			 * Email detail visibility flag.
			 */
			"IsEmailDetailVisible": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			/**
			 * Contact communication detail name.
			 */
			"CommunicationDetailName": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "ContactCommunication"
			},
			/**
			 * Actualize age system setting value.
			 */
			"IsAgeActualizationEnabled": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: true
			},
			/**
			 * Contact email.
			 */
			"Email": {
				"dependencies": [
					{
						"columns": ["Email"],
						"methodName": "syncEntityWithCommunicationDetail"
					}
				]
			},
			/**
			 * Contact phone.
			 */
			"Phone": {
				"dependencies": [
					{
						"columns": ["Phone"],
						"methodName": "syncEntityWithCommunicationDetail"
					}
				]
			},
			/**
			 * Contact mobile phone.
			 */
			"MobilePhone": {
				"dependencies": [
					{
						"columns": ["MobilePhone"],
						"methodName": "syncEntityWithCommunicationDetail"
					}
				]
			},
			/**
			 * Contact home phone.
			 */
			"HomePhone": {
				"dependencies": [
					{
						"columns": ["HomePhone"],
						"methodName": "syncEntityWithCommunicationDetail"
					}
				]
			},
			/**
			 * Language column value.
			 */
			"Language": {
				lookupListConfig: {
					filter: function() {
						return Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
							"IsUsed", 1);
					}
				}
			},
			/**
			 * Contact skype.
			 */
			"Skype": {
				"dependencies": [
					{
						"columns": ["Skype"],
						"methodName": "syncEntityWithCommunicationDetail"
					}
				]
			},
			"Age": {
				"dependencies": [
					{
						"columns": ["BirthDate"],
						"methodName": "setAge"
					}
				]
			}
		},
		rules: {
			"Region": {
				"FiltrationRegionByCountry": {
					ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
					autocomplete: true,
					autoClean: true,
					baseAttributePatch: "Country",
					comparisonType: Terrasoft.ComparisonType.EQUAL,
					type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					attribute: "Country"
				}
			},
			"City": {
				"FiltrationCityByCountry": {
					ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
					autocomplete: true,
					autoClean: true,
					baseAttributePatch: "Country",
					comparisonType: Terrasoft.ComparisonType.EQUAL,
					type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					attribute: "Country"
				},
				"FiltrationCityByRegion": {
					ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
					autocomplete: true,
					autoClean: true,
					baseAttributePatch: "Region",
					comparisonType: Terrasoft.ComparisonType.EQUAL,
					type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					attribute: "Region"
				}
			}
		},
		details: /**SCHEMA_DETAILS*/{
			ContactCommunication: {
				schemaName: "ContactCommunicationDetail",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			Activities: {
				schemaName: "ActivityDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				},
				defaultValues: {
					Account: {
						masterColumn: "Account"
					}
				},
				filterMethod: "activitiesDetailFilter"
			},
			Relationships: {
				schemaName: "ContactRelationshipDetailV2",
				filterMethod: "relationshipsDetailFilter",
				defaultValues: {
					ContactA: {
						masterColumn: "Id"
					}
				}
			},
			ContactCareer: {
				schemaName: "ContactCareerDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				},
				defaultValues: {
					Contact: {
						masterColumn: "Id"
					}
				}
			},
			Files: {
				schemaName: "FileDetailV2",
				entitySchemaName: "ContactFile",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			ContactAddress: {
				schemaName: "ContactAddressDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			ContactAnniversary: {
				schemaName: "ContactAnniversaryDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				},
				subscriber: {
					"methodName": "sendSaveCardModuleResponse"
				}
			},
			EmailDetailV2: {
				schemaName: "EmailDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				},
				filterMethod: "emailDetailFilter"
			}
		}/**SCHEMA_DETAILS*/,
		modules: /**SCHEMA_MODULES*/{
			"AccountProfile": {
				"config": {
					"schemaName": "AccountProfileSchema",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"parameters": {
						"viewModelConfig": {
							masterColumnName: "Account"
						}
					}
				}
			},
			"ActionsDashboardModule": {
				"config": {
					"isSchemaConfigInitialized": true,
					"schemaName": "SectionActionsDashboard",
					"useHistoryState": false,
					"parameters": {
						"viewModelConfig": {
							"entitySchemaName": "Contact",
							"dashboardConfig": {
								"Activity": {
									"masterColumnName": "Id",
									"referenceColumnName": "Contact"
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_MODULES*/,
		mixins: {
			/**
			 * @class TimezoneMixin Mixin.
			 */
			TimezoneMixin: "Terrasoft.TimezoneMixin",
			/**
			 * @class CommunicationSynchronizerMixin Mixin, used for sync communications.
			 */
			CommunicationSynchronizerMixin: "Terrasoft.CommunicationSynchronizerMixin",
			/**
			 * @class CommunicationOptionsMixin Mixin, implements communication options usage methods.
			 */
			CommunicationOptionsMixin: "Terrasoft.CommunicationOptionsMixin"
		},
		methods: {

			//region Methods: private

			/**
			 * Returns specification in lead detail id.
			 * @private
			 * @return {String} Detaild id.
			 */
			_getContactAnniversaryDetailId: function() {
				return this.getDetailId("ContactAnniversary");
			},

			//endregion

			//region Methods: protected

			/**
			 * Set/Reset birthday date.
			 * @protected
			 * @param {Date} newBirthdate New birthdate.
			 */
			onBirthdateChanged: function(newBirthdate) {
				var oldBirthDate = this.get("BirthDate");

				if (Ext.isEmpty(newBirthdate) && Ext.isEmpty(oldBirthDate)) {
					return;
				}
				if (Ext.isEmpty(newBirthdate) && !Ext.isEmpty(oldBirthDate)) {
					newBirthdate = null;
					this.set("BirthDate", newBirthdate);
					return;
				}

				this.set("BirthDate", newBirthdate, {silent: true});
				this.setAge(true);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#subscribeSandboxEvents
			 * @override
			 */
			subscribeSandboxEvents: function() {
				this.callParent(arguments);
				var contactAnniversaryDetailId = this._getContactAnniversaryDetailId();
				this.sandbox.subscribe("BirthdateChanged", this.onBirthdateChanged, this, [contactAnniversaryDetailId]);
			},

			/**
			 * Initialize system settings values.
			 * @protected
			 */
			initSysSettingsValues: function() {
				var sysSettingsNameArray = ["BuildType", "ActualizeAge"];
				this.Terrasoft.SysSettings.querySysSettings(sysSettingsNameArray, function(settingValues) {
					var buildTypeSetting = settingValues.BuildType;
					var buildType = buildTypeSetting && buildTypeSetting.value;
					this.set("canUseSocialFeaturesByBuildType",
						(buildType !== ConfigurationConstants.BuildType.Public));

					var isAgeActualizationEnabled = settingValues.ActualizeAge;
					this.set("IsAgeActualizationEnabled", isAgeActualizationEnabled);
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#init
			 * @override
			 */
			init: function() {
				this.callParent(arguments);
				this.initSyncMailboxCount();
				this.initSysSettingsValues();
			},

			/**
			 * Check if birthday has already passed.
			 * @protected
			 * @param {Date} currentDate Current date.
			 * @param {Date} birthdate Birthdate.
			 * @return {Boolean}
			 */
			wasBirthdayThisYear: function(currentDate, birthdate) {
				var monthsDifference = currentDate.getMonth() - birthdate.getMonth();
				var daysDifference = currentDate.getDate() - birthdate.getDate();
				var hasBirthdayMonthPassed = monthsDifference > 0;
				var hasBirthdayPassedThisMonth = monthsDifference === 0 && daysDifference >= 0;

				return hasBirthdayMonthPassed || hasBirthdayPassedThisMonth;
			},

			/**
			 * Returns calcuated age.
			 * @protected
			 * @return {Number}
			 */
			getCalculatedAge: function(birthdate) {
				if (this.isDateGreaterThenCurrent(birthdate)) {
					return 0;
				}
				var currentDate = new Date();
				var fullYearsOld = currentDate.getFullYear() - birthdate.getFullYear();
				return this.wasBirthdayThisYear(currentDate, birthdate) ? fullYearsOld : fullYearsOld - 1;
			},

			/**
			 * Check if input date is greater then current date.
			 * @protected
			 * @param {Date} date Date.
			 * @return {Boolean}
			 */
			isDateGreaterThenCurrent: function(date) {
				return date > new Date();
			},

			/**
			 * Check if age actualization system setting is off.
			 * @protected
			 * @return {Boolean}
			 */
			checkIfAgeActualizationDisabled: function() {
				return !this.get("IsAgeActualizationEnabled");
			},

			/**
			 * Updates contact anniversary detail data.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			updateContactAnniversaryDetail: function(callback, scope) {
				this.updateDetail({detail: "ContactAnniversary"});
				this.Ext.callback(callback, scope);
			},

			/**
			 * Check if current conditions allow to calculate age.
			 * @param {Date} date Date that is checked on emptiness.
			 * @param {Boolean}
			 */
			haveToCalculateAge: function (date) {
				return !(this.checkIfAgeActualizationDisabled() || Ext.isEmpty(date));
			},
			//endregion

			//region Methods: public

			/**
			 * Set contact age.
			 * @param {Boolean} silent Set with silent mode.
			 */
			setAge: function(silent) {
				var date = this.get("BirthDate");
				if (!this.haveToCalculateAge(date)) {
					return;
				}

				var age = this.getCalculatedAge(date);

				this.set("Age", age, {
					silent: silent
				});
			},

			//endregion

			/**
			 * @deprecated
			 */
			fillContactWithSocialNetworksData: function() {
				var confirmationMessage = this.get("Resources.Strings.OpenContactCardQuestion");
				var activeRowId = this.get("Id");
				var facebookId = this.get("FacebookId");
				var linkedInId = this.get("LinkedInId");
				var twitterId = this.get("TwitterId");
				if (facebookId !== "" || linkedInId !== "" || twitterId !== "") {
					this.sandbox.publish("PushHistoryState", {
						hash: "FillContactWithSocialAccountDataModule",
						stateObj: {
							FacebookId: facebookId,
							LinkedInId: linkedInId,
							TwitterId: twitterId,
							ContactId: activeRowId
						}
					});
				} else {
					Terrasoft.utils.showConfirmation(confirmationMessage, Ext.emptyFn, ["ok"], this);
				}
			},

			/**
			 * @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#setValidationConfig
			 * @override
			 */
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("Email", EmailHelper.getEmailValidator);
			},

			/**
			 * Creates filters for activities detail.
			 */
			activitiesDetailFilter: function() {
				return Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"[ActivityParticipant:Activity].Participant.Id", this.get("Id"));
			},

			/**
			 * Creates filters for Email detail.
			 * @return {Terrasoft.FilterGroup} Filters.
			 */
			emailDetailFilter: function() {
				var filterGroup = new Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = Terrasoft.LogicalOperatorType.AND;
				filterGroup.add(
					"ContactFilter",
					Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL,
						"[ActivityParticipant:Activity].Participant.Id",
						this.get("Id")
					)
				);
				filterGroup.add(
					"EmailFilter",
					Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL,
						"Type",
						ConfigurationConstants.Activity.Type.Email
					)
				);
				return filterGroup;
			},

			/**
			 * Creates filters for relationships detail.
			 */
			relationshipsDetailFilter: function() {
				var filterGroup = new Terrasoft.createFilterGroup();
				filterGroup.logicalOperation = Terrasoft.LogicalOperatorType.OR;
				filterGroup.add("ContactFilter", Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Id")));
				return filterGroup;
			},

			/**
			 * Creates filters for history detail.
			 */
			historyDetailFilter: function() {
				var filterGroup = new Terrasoft.createFilterGroup();
				filterGroup.add("ContactFilter", Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Id")));
				filterGroup.add("sysWorkspacedetailFilter", Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL,
					"SysEntity.SysWorkspace", Terrasoft.SysValue.CURRENT_WORKSPACE.value));
				return filterGroup;
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
			 * @override
			 */
			onEntityInitialized: function() {
				this.setIsEmailDetailVisible();
				this.callParent(arguments);
				Terrasoft.delay(this.mixins.TimezoneMixin.init, this, 1000);
			},

			/**
			 * @obsolete
			 */
			getSrcMethod: function() {
				return this.getContactImage();
			},

			/**
			 * ########## web-##### ########## ########.
			 * @private
			 * @return {String} Web-##### ########## ########.
			 */
			getContactImage: function() {
				var primaryImageColumnValue = this.get(this.primaryImageColumnName);
				if (primaryImageColumnValue) {
					return this.getSchemaImageUrl(primaryImageColumnValue);
				}
				return this.getContactDefaultImage();
			},

			/**
			 * ########## web-##### ########## ######## ## #########.
			 * @private
			 * @return {String} Web-##### ########## ######## ## #########.
			 */
			getContactDefaultImage: function() {
				return Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultPhoto"));
			},

			/**
			 * ############ ######### ########## ########.
			 * @private
			 * @param {File} photo ##########.
			 */
			onPhotoChange: function(photo) {
				if (!photo) {
					this.set(this.primaryImageColumnName, null);
					return;
				}
				Terrasoft.ImageApi.upload({
					file: photo,
					onComplete: this.onPhotoUploaded,
					onError: this.onPhotoChangeError,
					scope: this
				});
			},

			onFileSizeOverflow: function() {
				const maxFileSizeInMb = this.$MaxPhotoFileSize && this.$MaxPhotoFileSize / 1024 / 1024;
				const msgTpl = FileUploadErrorHandlersResources.localizableStrings.MaxFileSizeExceededExceptionMessage;
				const fileSizeLimitError = Ext.String.format(msgTpl, maxFileSizeInMb);
				Terrasoft.showMessage(fileSizeLimitError);
			},

			onPhotoChangeError: function(imageId, error, xhr) {
				if (xhr.response) {
					var response = Terrasoft.decode(xhr.response);
					if (response.error) {
						Terrasoft.showMessage(response.error);
					}
				}
			},

			onPhotoUploaded: function(imageId) {
				var imageData = {
					value: imageId,
					displayValue: "Photo"
				};
				this.set(this.primaryImageColumnName, imageData);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#save
			 * @override
			 */
			save: function() {
				this.clearChangedValuesSynchronizedByDetail();
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onSaved
			 * @override
			 */
			onSaved: function() {
				if (this.get("CallParentOnSaved")) {
					this.set("CallParentOnSaved", false);
					this.callParent(arguments);
				} else {
					this.set("ParentOnSavedArguments", arguments);
					Terrasoft.chain(
						this.updateAccountPrimaryContact,
						this.updateCareerDetail,
						this.updateContactAnniversaryDetail,
						this.callParentOnSaved,
						this
					);
				}
			},

			/**
			 * ####### ############ ##### onSaved
			 * @protected
			 */
			callParentOnSaved: function() {
				this.set("CallParentOnSaved", true);
				this.onSaved.apply(this, this.get("ParentOnSavedArguments"));
			},

			/**
			 * Updates contact career detail.
			 * @protected
			 * @param {Function} callback Callback function.
			 */
			updateCareerDetail: function(callback) {
				this.updateDetail({detail: "ContactCareer"});
				callback.call(this);
			},

			/**
			 * ######### ###### ##### ######### ## ###### ####### ########
			 * @deprecated
			 */
			updateCareerDetails: function() {
				this.setAccountIsEmpty();
				this.setIsCareerPropertyChanged();
				this.updateDetails(arguments);
			},

			/**
			 * ######### ######### ########## # ####### ########.
			 * ######### ### ######## ###### ## ###### ####### ########.
			 * 1. #### #### «##########» # ######## ####### - ##### # ###### ###### ## ##### ###########
			 * # ########## «#######» # «########» # # #### ###### ########## #### ########## = ####### ####
			 * # ##### ####### «#######». ###### ######## ## #####.
			 * 2. #### #### «##########» #### ########, # ##### #### #### ######, ## ######### ##### ######
			 * # ###### «#######» ###### ### #### ## #########.
			 * 3. #####, ### ##### ###### ########## # #####
			 * (##########, #########, ###### ######## #########, ###########), ########### # #############
			 * # ####### ## ###### ####### #########: #### ### ###### ###### ##### ## ########## ###### #
			 * ####### # ########## "########" # "#######", ## ########## ######### ##### ###### # #####
			 * ##########. #### ##### ############ ###### ###### # ######### ####### – ####### # ### #######
			 * "#######" # ######### #### ########## ####### #####.
			 * @protected
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			changeCareer: function(callback) {
				var account = this.get("Account");
				var accountWasEmpty = this.get("AccountIsEmpty");
				if (!account && !accountWasEmpty) {
					this.updateCurrentCareerInfo(callback);
					return;
				}
				var addMode = this.isAddMode();
				var copyMode = this.isCopyMode();
				if (account && (accountWasEmpty || addMode || copyMode)) {
					this.addNewCareerInfo(callback);
					return;
				}
				var careerPropertyChanged = this.get("IsCareerPropertyChanged");
				var primaryContactAdd = this.get("PrimaryContactAdd");
				if (careerPropertyChanged && !primaryContactAdd && !copyMode) {
					this.promtAddNewCareerInfo(callback);
					return;
				}
				if (callback) {
					callback.call(this);
				}
			},

			/**
			 * ############ ####### ########## ######### ########## # ####### ########.
			 * ######### ###### ####### ########.
			 * @private
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			onCareerInfoChanged: function(callback) {
				this.updateDetails();
				callback.call(this);
			},

			/**
			 * ###### ###### ############ # ############# ########## ###### ## ###### ####### ########.
			 * @private
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			promtAddNewCareerInfo: function(callback) {
				var message = this.get("Resources.Strings.ContactCareerInfoChanged");
				var buttons = Terrasoft.MessageBoxButtons;
				this.showConfirmationDialog(message, function(returnCode) {
					this.promtAddNewCareerInfoHandler(returnCode, callback);
				}, [buttons.YES.returnCode, buttons.NO.returnCode]);
			},

			/**
			 * ############ ##### ############ ## ###### # ############# ########## ######
			 * ## ###### ####### ########.
			 * @private
			 * @param {String} returnCode ### ########## ######## ######.
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			promtAddNewCareerInfoHandler: function(returnCode, callback) {
				if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode) {
					this.addNewCareerInfo(callback);
					return;
				}
				callback();
			},

			/**
			 * ######### ###### ## ###### ####### ########.
			 * ######### ############ ###### ## ###### # ######### "#######".
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			addNewCareerInfo: function(callback) {
				var addMode = this.isAddMode();
				var copyMode = this.isCopyMode();
				var batchQuery = Ext.create("Terrasoft.BatchQuery");
				if (!addMode || !copyMode) {
					var updateCurrentCareerInfo = this.getUpdateCurrentCareerInfo();
					batchQuery.add(updateCurrentCareerInfo);
				}
				var insertContactCareerQuery = this.getInsertContactCareerQuery();
				batchQuery.add(insertContactCareerQuery);
				batchQuery.execute(function() {
					this.onCareerInfoChanged(callback);
				}, this);
			},

			/**
			 * ######### ############ ###### ## ###### ####### ######## # ######### "#######".
			 * @param {Function} callback ####### ######### ######.
			 * @deprecated
			 */
			updateCurrentCareerInfo: function(callback) {
				var updateCurrentCareerInfo = this.getUpdateCurrentCareerInfo();
				updateCurrentCareerInfo.execute(function() {
					this.onCareerInfoChanged(callback);
				}, this);
			},

			/**
			 * ######### ###### ####### ###### ####### ########.
			 * @return {Terrasoft.InsertQuery} ###### ####### ###### ####### ########.
			 * @deprecated
			 */
			getInsertContactCareerQuery: function() {
				var insert = Ext.create("Terrasoft.InsertQuery", {
					rootSchema: ContactCareer
				});
				var account = this.getLookupValue("Account");
				if (!Ext.isEmpty(account)) {
					insert.setParameterValue("Account", account);
				}
				var job = this.getLookupValue("Job");
				if (!Ext.isEmpty(job)) {
					insert.setParameterValue("Job", job);
				}
				var jobTitle = this.get("JobTitle");
				if (!Ext.isEmpty(jobTitle)) {
					insert.setParameterValue("JobTitle", jobTitle);
				}
				var department = this.getLookupValue("Department");
				if (!Ext.isEmpty(department)) {
					insert.setParameterValue("Department", department);
				}
				var decisionRole = this.getLookupValue("DecisionRole");
				if (!Ext.isEmpty(decisionRole)) {
					insert.setParameterValue("DecisionRole", decisionRole);
				}
				insert.setParameterValue("Contact", this.get("Id"));
				insert.setParameterValue("Current", true);
				insert.setParameterValue("Primary", true);
				return insert;
			},

			/**
			 * @deprecated
			 */
			getUpdateContactCareerQuery: function(notUpdate) {
				var update = Ext.create("Terrasoft.UpdateQuery", {
					rootSchemaName: "ContactCareer"
				});
				var filters = update.filters;
				var idContact = this.get("Id");
				var idFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"Contact", idContact);
				filters.add("IdFilter", idFilter);
				if (notUpdate) {
					update.setParameterValue("Current", false, Terrasoft.DataValueType.BOOLEAN);
					update.setParameterValue("DueDate", new Date(), Terrasoft.DataValueType.DATE);
				} else {
					var currentFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Current", true);
					filters.add("currentFilter", currentFilter);
					var primaryFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Primary", true);
					filters.add("primaryFilter", primaryFilter);
					var account = this.getLookupValue("Account");
					var job = this.getLookupValue("Job");
					var jobTitle = this.get("JobTitle");
					var department = this.getLookupValue("Department");
					if (!Ext.isEmpty(account)) {
						update.setParameterValue("Account", account, Terrasoft.DataValueType.GUID);
					}
					if (!Ext.isEmpty(job)) {
						update.setParameterValue("Job", job, Terrasoft.DataValueType.GUID);
					}
					if (!Ext.isEmpty(jobTitle)) {
						update.setParameterValue("JobTitle", jobTitle, Terrasoft.DataValueType.TEXT);
					}
					if (!Ext.isEmpty(department)) {
						update.setParameterValue("Department", department, Terrasoft.DataValueType.GUID);
					}
				}
				return update;
			},

			/**
			 * ########## ###### ## ########## ############ ####### ## ###### ####### ########
			 * # ######### "#######".
			 * @return {Terrasoft.UpdateQuery} ###### ## ########## ############ ####### ## ###### #######
			 *     ######## # ######### "#######".
			 * @deprecated
			 */
			getUpdateCurrentCareerInfo: function() {
				var query = Ext.create("Terrasoft.UpdateQuery", {
					rootSchema: ContactCareer
				});
				query.filters.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Id")));
				query.filters.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Current", true));
				query.setParameterValue("Current", false);
				query.setParameterValue("DueDate", new Date());
				return query;
			},

			/**
			 * ######### ######## ####### ###########.
			 * @private
			 * @param {Function} callback ####### ######### ######.
			 */
			updateAccountPrimaryContact: function(callback) {
				var account = this.getLookupValue("Account");
				if (!this.isAddMode() || Ext.isEmpty(account) || !this.get("PrimaryContactAdd")) {
					if (callback) {
						callback.call(this);
					}
				} else {
					var update = Ext.create("Terrasoft.UpdateQuery", {rootSchemaName: "Account"});
					update.enablePrimaryColumnFilter(account);
					update.setParameterValue("PrimaryContact", this.get("Id"), Terrasoft.DataValueType.LOOKUP);
					var batch = Ext.create("Terrasoft.BatchQuery");
					batch.add(update, function() {
					}, this);
					batch.execute(function() {
						this.updateDetails();
						if (callback) {
							callback.call(this);
						}
					}, this);
				}
			},

			/**
			 * @deprecated
			 */
			getSelectedButton: function(returnCode, callback) {
				if (returnCode === Terrasoft.MessageBoxButtons.YES.returnCode) {
					var account = this.get("Account");
					var batch = Ext.create("Terrasoft.BatchQuery");
					batch.add(this.getUpdateContactCareerQuery(true), function() {
					}, this);
					if (!Ext.isEmpty(account)) {
						batch.add(this.getInsertContactCareerQuery(), function() {
						}, this);
					}
					batch.execute(function() {
						this.updateCareerDetails();
						if (callback) {
							callback.call(this);
						}
					}, this);
				} else {
					this.getUpdateContactCareerQuery().execute(function() {
						this.updateCareerDetails();
						if (callback) {
							callback.call(this);
						}
					}, this);
				}
			},

			/**
			 * ######### #### ## ######### # ##### ##########, #########, ###### ######## #########,
			 * ###########.
			 * @protected
			 * @return {Boolean} ######### ########.
			 * @deprecated
			 */
			isCareerPropertyChanged: function() {
				var values = this.changedValues;
				return values && (values.Account || values.Job || values.JobTitle || values.Department);
			},

			/**
			 * Sets the flag changes to contact the career fields.
			 * @deprecated
			 */
			setIsCareerPropertyChanged: function() {
				this.set("IsCareerPropertyChanged", this.isCareerPropertyChanged());
			},

			/**
			 * Updates job full title field on job change.
			 */
			jobChanged: function() {
				var job = this.get("Job");
				var jobTitle = this.get("JobTitle");
				if (this.isNotEmpty(job) && this.isEmpty(jobTitle)) {
					this.set("JobTitle", job.displayValue);
				}
			},

			/**
			 * Sets "AccountIsEmpty" tag.
			 * Used when checked account field changes.
			 * @private
			 * @deprecated
			 */
			setAccountIsEmpty: function() {
				this.set("AccountIsEmpty", Ext.isEmpty(this.get("Account")));
			},

			/**
			 * Returns id for contact type employee.
			 * @private
			 * @return {string} Contact type employee id.
			 */
			getEmployeeTypeId: function() {
				return ConfigurationConstants.ContactType.Employee.toLowerCase();
			},

			/**
			 * Returns id for account type our company.
			 * @private
			 * @return {string} Account type our company.
			 */
			getOurCompanyTypeId: function() {
				return ConfigurationConstants.AccountType.OurCompany.toLowerCase();
			},

			/**
			 * Sets email detail visibility.
			 * @protected
			 */
			setIsEmailDetailVisible: function() {
				var contactType = this.get("Type");
				var account = this.get("Account");
				var isContactTypeEmployee = (!Ext.isEmpty(contactType) &&
					contactType.value.toLowerCase() === this.getEmployeeTypeId());
				var isAccountOurCompany = (!Ext.isEmpty(account) && !Ext.isEmpty(account.Type) &&
					account.Type.value.toLowerCase() === this.getOurCompanyTypeId());
				var isDetailVisible = !(isContactTypeEmployee || isAccountOurCompany);
				this.set("IsEmailDetailVisible", isDetailVisible);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onDetailChanged
			 */
			onDetailChanged: function(detail) {
				this.callParent(arguments);
				if (detail.schemaName === "ContactAddressDetailV2") {
					this.updateTimezone();
				}
			},

			/**
			 * Check feature status.
			 */
			isMultiLanguage: function() {
				return this.getIsFeatureEnabled("EmailMessageMultiLanguage") ||
					this.getIsFeatureEnabled("EmailMessageMultiLanguageV2");
			},

			/**
			 * Updates the time zone information.
			 */
			updateTimezone: function() {
				this.mixins.TimezoneMixin.init.call(this);
			},

			/**
			 * Starts call in CTI panel.
			 * @param {String} number Phone number to call.
			 * @return {Boolean} False, to stop click event propagation.
			 */
			onCallClick: function(number) {
				return this.callContact(number, this.$Id, this.$Account);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ActionsDashboardModule",
				"parentName": "ActionDashboardContainer",
				"propertyName": "items",
				"values": {
					"classes": {wrapClassName: ["actions-dashboard-module"]},
					"itemType": Terrasoft.ViewItemType.MODULE
				}
			},
			{
				"operation": "insert",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"name": "AccountProfile",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE
				}
			},
			{
				"operation": "merge",
				"name": "HeaderContainer",
				"values": {
					"wrapClass": ["header-container-margin-bottom", "width-auto"]
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "PhotoTimeZoneContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["photo-timezone-container"],
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "AccountPhotoContainer",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["image-edit-container"],
					"items": []
				},
				"alias": {
					"name": "PhotoContainer",
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "AccountPhotoContainer",
				"propertyName": "items",
				"name": "Photo",
				"values": {
					"getSrcMethod": "getContactImage",
					"onPhotoChange": "onPhotoChange",
					"readonly": false,
					"maxFileSize": "$MaxPhotoFileSize",
					"fileSizeOverflow": { "bindTo": "onFileSizeOverflow" },
					"defaultImage": {"bindTo": "getContactDefaultImage"},
					"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
				}
			},
			{
				"operation": "insert",
				"parentName": "PhotoTimeZoneContainer",
				"propertyName": "items",
				"name": "TimezoneContactPage",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"generator": "TimezoneGenerator.generateTimeZone",
					"wrapClass": ["timezone-container"],
					"visible": true,
					"timeZoneCaption": {"bindTo": "TimeZoneCaption"},
					"timeZoneCity": {"bindTo": "TimeZoneCity"},
					"tips": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "AccountName",
				"values": {
					"bindTo": "Name",
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					}
				},
				"alias": {
					"name": "Name",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "JobTitleProfile",
				"values": {
					"bindTo": "JobTitle",
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "AccountMobilePhone",
				"values": {
					"className": "Terrasoft.PhoneEdit",
					"bindTo": "MobilePhone",
					"showValueAsLink": {"bindTo": "isTelephonyEnabled"},
					"href": {
						"bindTo": "MobilePhone",
						"bindConfig": {converter: "getLinkValue"}
					},
					"linkclick": {
						"bindTo": "onCallClick"
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"controlConfig": {
						// Disable browser auto fill. Set unsupported autocomplete value. CRM-53034
						"autocomplete": Terrasoft.generateGUID()
					}
				},
				"alias": {
					"name": "MobilePhone",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "AccountPhone",
				"values": {
					"className": "Terrasoft.PhoneEdit",
					"bindTo": "Phone",
					"showValueAsLink": {"bindTo": "isTelephonyEnabled"},
					"href": {
						"bindTo": "Phone",
						"bindConfig": {converter: "getLinkValue"}
					},
					"linkclick": {
						"bindTo": "onCallClick"
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 24
					},
					"controlConfig": {
						// Disable browser auto fill. Set unsupported autocomplete value. CRM-53034
						"autocomplete": Terrasoft.generateGUID()
					}
				},
				"alias": {
					"name": "Phone",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "AccountEmail",
				"values": {
					"bindTo": "Email",
					"showValueAsLink": true,
					"href": {
						"bindTo": "Email",
						"bindConfig": {converter: "getLinkValue"}
					},
					"linkclick": {
						"bindTo": "sendEmail"
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 5,
						"colSpan": 24
					},
					"controlConfig": {
						// Disable browser auto fill. Set unsupported autocomplete value. CRM-53034
						"autocomplete": Terrasoft.generateGUID()
					}
				},
				"alias": {
					"name": "Email",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			// tab 1
			{
				"operation": "insert",
				"name": "GeneralInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0,
				"values": {
					"caption": {"bindTo": "Resources.Strings.GeneralInfoTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"name": "ContactGeneralInfoControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoControlGroup",
				"propertyName": "items",
				"name": "ContactGeneralInfoBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": [],
					"collapseEmptyRow": true
				}
			},
			{
				"operation": "insert",
				"name": "JobTabContainer",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1,
				"values": {
					"caption": {"bindTo": "Resources.Strings.JobTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"name": "JobInformationControlGroup",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "JobInformationControlGroup",
				"propertyName": "items",
				"name": "JobInformationBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "HistoryTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {"bindTo": "Resources.Strings.HistoryTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 3,
				"values": {
					"caption": {"bindTo": "Resources.Strings.NotesAndFilesTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "Type",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "Owner",
				"values": {
					"layout": {
						"column": 12,
						"row": 0
					},
					"tip": {
						"content": {"bindTo": "Resources.Strings.OwnerTip"}
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "SalutationType",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "Gender",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "Age",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 0,
						"row": 2
					},
					"enabled": {"bindTo": "checkIfAgeActualizationDisabled"}
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactGeneralInfoBlock",
				"propertyName": "items",
				"name": "Language",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {
						"column": 12,
						"row": 2
					},
					"visible": {
						"bindTo": "isMultiLanguage"
					},
					"tip": {
						"content": {"bindTo": "Resources.Strings.PreferredLanguageTipMessage"}
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobInformationBlock",
				"propertyName": "items",
				"name": "Job",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 0}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobInformationBlock",
				"propertyName": "items",
				"name": "JobTitle",
				"values": {
					"layout": {"column": 12, "row": 0}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobInformationBlock",
				"propertyName": "items",
				"name": "Department",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 1}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobInformationBlock",
				"propertyName": "items",
				"name": "DecisionRole",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 12, "row": 1}
				}
			},
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "Activities",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "EmailDetailV2",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {"bindTo": "IsEmailDetailVisible"}
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "ContactCommunication",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "ContactAddress",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "ContactAnniversary",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "Relationships",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"propertyName": "items",
				"name": "ContactCareer",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"name": "Files",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"name": "NotesControlGroup",
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"caption": {"bindTo": "Resources.Strings.NotesGroupCaption"}
				}
			},
			{
				"operation": "move",
				"name": "Header",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "Header",
				"parentName": "LeftModulesContainer",
				"values": {
					"classes": {
						"wrapClassName": ["profile-container", "autofill-layout"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "NotesControlGroup",
				"propertyName": "items",
				"name": "Notes",
				"values": {
					"contentType": Terrasoft.ContentType.RICH_TEXT,
					"layout": {"column": 0, "row": 0, "colSpan": 24},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"imageLoaded": {
							"bindTo": "insertImagesToNotes"
						},
						"images": {
							"bindTo": "NotesImagesCollection"
						}
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2SocialNetworkIntegrationResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2SocialNetworkIntegration", ["ContactCommunication", "ConfigurationConstants", "ConfigurationFileApi"],
		function(ContactCommunication, ConfigurationConstants) {
	return {
		messages: {
			/**
			 * @message SearchResultBySocialNetworks
			 * ######## ######### ###### ## ########## #####.
			 */
			"SearchResultBySocialNetworks": {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BasePageV2#subscribeSandboxEvents
			 * @overridden
			 */
			subscribeSandboxEvents: function() {
				this.callParent(arguments);
				this.sandbox.subscribe("SearchResultBySocialNetworks", this.onSearchResultBySocialNetworks, this);
			},

			/*
			 * ############ ######## ######## ######## ####### ##### ## ###. #####.
			 * @param {Object} config.selectedItems ###### ####### ####### ####### ##### ## ###. #####.
			 */
			onSearchResultBySocialNetworks: function(config) {
				var collection = config.selectedItems;
				if (collection.isEmpty()) {
					return;
				}
				var socialContact = collection.getByIndex(0);
				this.setPhotoFromSocialNetworks(socialContact);
				this.setNameFromSocialNetworks(socialContact);
			},

			/*
			 * #### # ######## ###### #### "###" ## ############# ### ########
			 * ## ######### ###### ###### ########## ########## ######## ## ###. ####.
			 * @param {Object} socialContact ###### ########## ########## ######## ## ###. ####.
			 */
			setNameFromSocialNetworks: function(socialContact) {
				if (!this.Ext.isEmpty(this.get("Name")) || this.Ext.isEmpty(socialContact)) {
					return;
				}
				var name = socialContact.get("Name");
				if (name) {
					this.set("Name", name);
				}
			},

			/*
			 * #### # ######## ### #### ## ############# ####
			 * ## ######### ###### ###### ########## ########## ######## ## ###. ####.
			 * @param {Object} socialContact ###### ########## ########## ######## ## ###. ####.
			 */
			setPhotoFromSocialNetworks: function(socialContact) {
				var contactPhoto = this.get(this.primaryImageColumnName);
				if (!this.Ext.isEmpty(contactPhoto) || this.Ext.isEmpty(socialContact)) {
					return;
				}
				var isDefaultPhoto = socialContact.get("IsDefaultPhoto");
				var photoUrl = socialContact.get("Photo");
				if (isDefaultPhoto === true || this.Ext.isEmpty(photoUrl)) {
					return;
				}
				this.Terrasoft.ConfigurationFileApi.getImageFile(photoUrl, this.onPhotoChange, this);
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#getActions
			 * @overridden
			 */
			getActions: function() {
				var actionMenuItems = this.callParent(arguments);
				actionMenuItems.addItem(this.getButtonMenuSeparator());
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Tag": "openSocialContactPage",
					"Caption": {bindTo: "Resources.Strings.FillContactWithSocialNetworksDataActionCaption"}
				}));
				return actionMenuItems;
			},

			/**
			 * ######## "########## ####### ## ###. #####".
			 */
			openSocialContactPage: function() {
				this.save({
					callback: function() {
						this.checkCanOpenSocialContactPage(function() {
							this.loadSocialContactPage();
						}, this);
					},
					callBaseSilentSavedActions: true,
					isSilent: true
				});
			},

			/**
			 * #########, ######## ## ####### ## ######## ########## ######## ## ######## #######.
			 * @protected
			 * @virtual
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ###### ####### ######### ######.
			 */
			checkCanOpenSocialContactPage: function(callback, scope) {
				this.checkHasSocialCommunications(function() {
					callback.call(scope);
				}, this);
			},

			/**
			 * #########, ########## ## ######## #####.
			 * @protected
			 * @virtual
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ###### ####### ######### ######.
			 */
			checkHasSocialCommunications: function(callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchema: ContactCommunication
				});
				esq.addAggregationSchemaColumn(
					ContactCommunication.primaryColumnName, this.Terrasoft.AggregationType.COUNT, "Count");
				var contactFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Id"));
				esq.filters.addItem(contactFilter);
				var socialTypeFilter = this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL,
					"[ComTypebyCommunication:CommunicationType:CommunicationType].Communication",
					ConfigurationConstants.Communication.SocialNetwork);
				esq.filters.addItem(socialTypeFilter);
				esq.getEntityCollection(function(response) {
					if (!response.success) {
						throw new Terrasoft.UnknownException();
					}
					var queryResult = response.collection.getByIndex(0);
					var socialCommunicationsCount = queryResult.get("Count");
					if (socialCommunicationsCount === 0) {
						var message = this.get("Resources.Strings.FillContactQuestion");
						return this.showInformationDialog(message);
					}
					callback.call(scope);
				}, this);
			},

			/**
			 * ######### ###### ###### # ########## #####.
			 * @protected
			 */
			loadSocialContactPage: function() {
				var schemaName = "SocialContactPage";
				var primaryColumnValue = this.get("PrimaryColumnValue") || this.get(this.primaryColumnName);
				var hash = this.Terrasoft.combinePath("CardModuleV2", schemaName, "edit", primaryColumnValue);
				this.sandbox.publish("PushHistoryState", {hash: hash});
			}
		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2RelationshipDesignerResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2RelationshipDesigner", ["BusinessRuleModule", "RelationshipDesignerMixin"], function(BusinessRuleModule) {
	return {
		attributes: {
			"UseRelationshipDesigner": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": Terrasoft.Features.getIsEnabled("UseRelationshipDesigner")
			}
		},
		messages: {
			"UpdateRelationshipDesigner": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		mixins: {
			RelationshipDesignerMixin: "Terrasoft.RelationshipDesignerMixin"
		},
		businessRules: {
			RelationshipTabContainer: {
				RelationshipTabVisible: {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.VISIBLE,
					logical: Terrasoft.LogicalOperatorType.AND,
					conditions: [
						{
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "UseRelationshipDesigner"
							},
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}
					]
				},
			},
			Relationships: {
				Relationships: {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.VISIBLE,
					logical: Terrasoft.LogicalOperatorType.AND,
					conditions: [
						{
							comparisonType: Terrasoft.ComparisonType.NOT_EQUAL,
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "UseRelationshipDesigner"
							},
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}
					]
				}
			}
		},
		methods: {

			// region Methods: Protected

			/**
			 * @override Terrasoft.BasePageV2#subscribeSandboxEvents
			 */
			subscribeSandboxEvents: function() {
				this.callParent(arguments);
				this.mixins.RelationshipDesignerMixin.subscribeSandboxEvents.apply(this, arguments);
			},

			/**
			 * @override Terrasoft.BaseSchemaViewModel#getModuleId
			 */
			getModuleId: function(moduleName) {
				if (moduleName === "RelationshipDesigner") {
					return this.mixins.RelationshipDesignerMixin.getRelationshipDesignerModuleSandboxId.apply(this);
				}
				return this.callParent(arguments);
			},

			/**
			 * @override Terrasoft.BaseEntityPage#updateDetails
			 */
			updateDetails: function() {
				this.callParent(arguments);
				this.loadRelationshipDesignerModule();
			},

			// endregion

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "TabsContainer",
				"values": {
					"wrapClass": ["tabs-container"]
				}
			},
			{
				"operation": "insert",
				"name": "RelationshipTabContainer",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.RelationshipTabCaption"
					},
					"items": [],
					"order": 1
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RelationshipContainer",
				"parentName": "RelationshipTabContainer",
				"propertyName": "items",
				"values": {
					"id": "RelationshipContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"afterrerender": { "bindTo": "loadRelationshipDesignerModule" },
					"afterrender": { "bindTo": "loadRelationshipDesignerModule" },
					"visible": {
						"bindTo": "UseRelationshipDesigner"
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2FacebookIntegrationResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2FacebookIntegration", ["FacebookClientUtilities"], function() {
	return {
		mixins: {
			/**
			 * @class FacebookClientUtilities ######### ####### ###### ###### # ###. ##### facebook.
			 */
			FacebookClientUtilities: "Terrasoft.FacebookClientUtilities"
		},
		methods: {
			checkCanOpenSocialContactPage: function(callback, scope) {
				this.callParent([function() {
					this.checkCanFacebookConnectorOperate(callback, scope);
				}, this]);
			}
		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2EmailMiningResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2EmailMining", ["ContactPageV2Resources", "css!ContactPageV2CSS", "EmailEnrichmentMixin"], function() {
		return {
			entitySchemaName: "Contact",
			messages: {

				/**
				 * Update contact enrichment page visibility.
				 */
				"ContactEnrichmentPageVisibilityChanged": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			mixins: {
				/**
				 * @class Terrasoft.EmailEnrichmentMixin
				 * Email enrichment mixin.
				 */
				EmailEnrichmentMixin: "Terrasoft.EmailEnrichmentMixin"
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function() {
					this.set("CallerSource", "ContactPageV2");
					this.subscribeCloudUpdateEvents();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
				 * @overridden
				 */
				destroy: function() {
					this.unsubscribeCloudUpdateEvents();
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					Terrasoft.delay(this.getContactsFromServer, this, 1000);
					this.callParent(arguments);
				},

				/**
				 * Returns additional enrich actions request config.
				 * @protected
				 * @virtual
				 * @return {Object} Aditional enrich actions request config.
				 */
				getAdditionalActionsRequestConfig: function() {
					return {
						methodName: "GetCloudStateForContact",
						data: {
							contactId: this.get("Id")
						}
					};
				},

				/**
				 * Enrich contact button click handler.
				 * @protected
				 * @virtual
				 */
				onEnrichContact: function() {
					var config = this.getOpenWindowConfig({
						ContactId: this.get("Id")
					}, {
						value: this.get("Name")
					});
					var tag = this.Ext.encode(config);
					this.openEnrichmentWindow(tag);
				},

				/**
				 * Removes viewmodel subscription to server messages.
				 * @protected
				 */
				unsubscribeCloudUpdateEvents: function() {
					this.Terrasoft.ServerChannel.un(this.Terrasoft.EventName.ON_MESSAGE,
						this.onCloudUpdateMessage, this);
				},

				/**
				 * Subscribes viewmodel to server messages.
				 * @protected
				 */
				subscribeCloudUpdateEvents: function() {
					this.Terrasoft.ServerChannel.on(this.Terrasoft.EventName.ON_MESSAGE,
						this.onCloudUpdateMessage, this);
				},

				/**
				 * Server message handler. Reloads contact page after enrich events.
				 * @protected
				 * @param {Object} scope Message scope.
				 * @param {Object} message Server messsage.
				 */
				onCloudUpdateMessage: function(scope, message) {
					if (message && message.Header && message.Header.Sender !== "EmailMining") {
						return;
					}
					var receivedMessage = this.Ext.decode(message.Body);
					var contactId = this.get("Id");
					var currentContactItems = this.Ext.Array.findBy(receivedMessage, function(item) {
							return item.contactId === contactId;
						}, this);
					if (message.Header.BodyTypeName === this.Terrasoft.EmailMiningEnums.EnrichMessageBodyType.SAVED &&
							this.isNotEmpty(currentContactItems)) {
						this.reloadEntity();
					}
				},

				/**
				 * Returns visibility of enrichment button.
				 * @protected
				 * @virtual
				 * @return {Boolean} Sign of enrichment button visibility.
				 */
				getCloudVisible: function() {
					return this.get("IsEntityInitialized") && this.get("isCloudVisible");
				}

				//endregion

			},
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "merge",
					"name": "PhotoTimeZoneContainer",
					"values": {
						"classes": {
							"wrapClassName": ["photo-timezone-container", "enrichment"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "PhotoTimeZoneContainer",
					"propertyName": "items",
					"name": "EnrichCloudAndTimezoneContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["timezone-enrichment-container"],
						"items": []
					}
				},
				{
					"operation": "move",
					"name": "TimezoneContactPage",
					"parentName": "EnrichCloudAndTimezoneContainer",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"parentName": "EnrichCloudAndTimezoneContainer",
					"propertyName": "items",
					"name": "EnrichCloudIcon",
					"index": 2,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"imageConfig": {"bindTo": "Resources.Images.EnrichCloudIcon"},
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "EnrichContactButton",
						"click": {bindTo: "onEnrichContact"},
						"visible": {"bindTo": "getCloudVisible"},
						"classes": {
							wrapperClass: ["enrich-contact-cloud"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "EnrichCloudAndTimezoneContainer",
					"propertyName": "items",
					"name": "EnrichCloudCaption",
					"index": 3,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "EnrichContactButtonCaption",
						"click": {bindTo: "onEnrichContact"},
						"visible": {"bindTo": "getCloudVisible"},
						"caption": {"bindTo": "Resources.Strings.EnrichCloudCaption"},
						"classes": {
							textClass: ["enrich-contact-cloud-caption"]
						}
					}
				}
			] /**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2CTIBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CTIBase", [],
function() {
	return {
		entitySchemaName: "Contact",
		messages: {
			/**
			 * @message HistoryTabDeactivated
			 * ######## # ########### ####### "#######".
			 * @param {String} tabName ######## #######.
			 */
			"HistoryTabDeactivated": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		methods: {
			/**
			 * @inheritdoc Terrasoft.BasePageV2#activeTabChange
			 * @overridden
			 */
			activeTabChange: function() {
				var tabName = this.get("ActiveTabName");
				if (tabName === "HistoryTab") {
					var detailId = this.getDetailId("Calls");
					this.sandbox.publish("HistoryTabDeactivated", null, [detailId]);
				}
				this.callParent(arguments);
			}
		},
		details: /**SCHEMA_DETAILS*/{
			Calls: {
				schemaName: "CallDetail",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"index": 1,
				"propertyName": "items",
				"name": "Calls",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2CrtDeduplicationResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CrtDeduplication", ["ContactDuplicateSearchMixin"], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		attributes: {},
		mixins: {
			ContactDuplicateSearchMixin: "Terrasoft.ContactDuplicateSearchMixin"
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.DuplicatesSearchUtilitiesV2#getFilterValue
			 * @override
			 */
			getFilterValue: function(filter) {
				if (this.isDuplicateRuleByName(filter)) {
					return this.getContactNameForSearchDuplicates();
				}
				return this.callParent(arguments);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "move",
				"name": "DuplicatesWidgetContainer",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 0
			},
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2CompletenessResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Completeness", ["ConfigurationConstants", "ConfigurationRectProgressBarGenerator",
		"CompletenessIndicator", "CompletenessMixin", "css!CompletenessCSSV2", "TooltipUtilities"
	],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "Contact",
			attributes: {
				CompletenessValue: {
					dataValueType: Terrasoft.DataValueType.INTEGER,
					value: 0
				},
				MissingParametersCollection: {
					dataValueType: Terrasoft.DataValueType.COLLECTION
				}
			},
			mixins: {
				CompletenessMixin: "Terrasoft.CompletenessMixin",
				TooltipUtilitiesMixin: "Terrasoft.TooltipUtilities"
			},
			details: /**SCHEMA_DETAILS*/ {
				ContactCommunication: {
					schemaName: "ContactCommunicationDetail",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					},
					completeness: {
						isTyped: true,
						typeColumn: "CommunicationType",
						typeSchemaName: "CommunicationType"
					}
				},
				EmailDetailV2: {
					schemaName: "EmailDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					},
					completeness: {
						isTyped: false,
						typeColumn: "Type",
						typeValue: ConfigurationConstants.Activity.Type.Email
					}
				},
				ContactAddress: {
					schemaName: "ContactAddressDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					},
					completeness: {
						isTyped: true,
						typeColumn: "AddressType",
						typeSchemaName: "AddressType"
					}
				},
				Activities: {
					schemaName: "ActivityDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					},
					completeness: {
						isTyped: false,
						typeColumn: "Type",
						typeValue: ConfigurationConstants.Activity.Type.Task
					}
				},
				ContactAnniversary: {
					schemaName: "ContactAnniversaryDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					},
					completeness: {
						isTyped: true,
						typeColumn: "AnniversaryType",
						typeSchemaName: "AnniversaryType"
					}
				}
			} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "merge",
					"name": "Confirmed",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"wrapClass": ["contact-header-container-label"],
						"layout": {
							"column": 4,
							"row": 3,
							"colSpan": 8
						}
					}
				}, {
					"operation": "insert",
					"parentName": "PhotoContainer",
					"propertyName": "items",
					"name": "CompletenessContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				}, {
					"operation": "insert",
					"parentName": "CompletenessContainer",
					"propertyName": "items",
					"name": "CompletenessValue",
					"values": {
						"generator": "ConfigurationRectProgressBarGenerator.generateProgressBar",
						"controlConfig": {
							"value": {
								"bindTo": "CompletenessValue"
							},
							"menu": {
								"items": {
									"bindTo": "MissingParametersCollection"
								}
							},
							"sectorsBounds": {
								"bindTo": "CompletenessSectorsBounds"
							}
						},
						"tips": [],
						"layout": {
							"column": 0,
							"row": 0,
							"rowSpan": 1,
							"colSpan": 1
						}
					}
				}, {
					"operation": "insert",
					"parentName": "CompletenessValue",
					"propertyName": "tips",
					"name": "CompletenessTip",
					"values": {
						"content": {"bindTo": "Resources.Strings.CompletenessHint"}
					}
				}
			] /**SCHEMA_DIFF*/ ,
			methods: {

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.set("MissingParametersCollection", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onDetailChanged
				 * @overridden
				 */
				onDetailChanged: function() {
					this.callParent(arguments);
					this.calculateCompleteness();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					if (this.isEditMode()) {
						var collection = this.get("MissingParametersCollection");
						collection.clear();
						this.set("CompletenessValue", 0);
						this.calculateCompleteness();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function() {
					var callParentOnSaved = this.get("CallParentOnSaved");
					this.callParent(arguments);
					if (!callParentOnSaved && !this.isNewMode() && !this.get("IsProcessMode")) {
						this.calculateCompleteness();
					}
				},

				/**
				 * Starts calculation of the completeness of the data content.
				 * @protected
				 */
				calculateCompleteness: function() {
					var config = {
						recordId: this.get("Id"),
						schemaName: this.entitySchemaName
					};
					this.mixins.CompletenessMixin.getCompleteness.call(this, config, this.calculateCompletenessResponce, this);
				},

				/**
				 * Handles the response from mixin calculation completeness.
				 * @protected
				 * @param {Object} completenessResponce Response from mixin calculation completeness.
				 */
				calculateCompletenessResponce: function(completenessResponce) {
					if (this.Ext.isEmpty(completenessResponce)) {
						return;
					}
					var missingParametersCollection = completenessResponce.missingParametersCollection;
					var completeness = completenessResponce.completenessValue;
					var scale = completenessResponce.scale;
					if (!this.Ext.isEmpty(missingParametersCollection)) {
						var collection = this.get("MissingParametersCollection") || this.Ext.create("Terrasoft.BaseViewModelCollection");
						collection.clear();
						collection.loadAll(missingParametersCollection);
					}
					if (this.Ext.isObject(scale) && this.Ext.isArray(scale.sectorsBounds)) {
						this.set("CompletenessSectorsBounds", scale.sectorsBounds);
					}
					if (this.Ext.isNumber(completeness)) {
						this.set("CompletenessValue", completeness);
					}
				}
			}
		};
	}
);

define('ContactPageV2CoreContractsResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CoreContracts", [],
		function() {
			return {
				entitySchemaName: "Contact",
				details: /**SCHEMA_DETAILS*/{
					Contract: {
						schemaName: "ContractDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "Contact"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Contract",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});

define('ContactPageV2OrderResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Order", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				Order: {
					schemaName: "OrderDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "Order",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2InvoiceResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Invoice", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				Invoice: {
					schemaName: "InvoiceDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "Invoice",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2DocumentResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Document", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				Documents: {
					schemaName: "DocumentDetailV2",
					defaultValues: {
						Account: { masterColumn: "Account" }
					},
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "Documents",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2CrtTouchPoint7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CrtTouchPoint7x", [], function() {
	return {
		entitySchemaName: "Contact",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"FormSubmitDetail": {
				"schemaName": "FormSubmitDetail",
				"entitySchemaName": "FormSubmit",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "Id"
				}
			},
			"TouchDetail": {
				"schemaName": "TouchDetail",
				"entitySchemaName": "Touch",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "Id"
				}
			},
			"TouchActionDetail": {
				"schemaName": "TouchActionDetail",
				"entitySchemaName": "TouchAction",
				"filter": {
					"detailColumn": "Touch.Contact",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "PhotoTimeZoneContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "AccountName",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "JobTitleProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "AccountMobilePhone",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "AccountPhone",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "AccountEmail",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"order": 0
				}
			},
			{
				"operation": "merge",
				"name": "Type",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Owner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "SalutationType",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "Gender",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "Age",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "Language",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "Job",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "JobTitle",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Department",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "DecisionRole",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "EngagementTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.EngagementTabTabCaption"
					},
					"items": [],
					"order": 4
				},
				"parentName": "Tabs",
				"propertyName": "tabs"
			},
			{
				"operation": "insert",
				"name": "FormSubmitDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "EngagementTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TouchDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "EngagementTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "TouchActionDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "EngagementTab",
				"propertyName": "items",
				"index": 2
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2LeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Lead", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				Leads: {
					schemaName: "LeadDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "QualifiedContact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "Leads",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2CoreLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CoreLead", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2TrackingResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Tracking",
	(function () {
		var dependencies = ["ContactPageV2Resources", "css!TrackingContactPageV2CSS"];
		if (!Ext.isIEOrEdge) {
			dependencies.push("TrackingEventsFeedElement");
		}
		return dependencies;
	})(),
	function (resources) {
		return {
			entitySchemaName: "Contact",
			attributes: {

				/**
				 * Is should show blank slate.
				 */
				"IsBlankSlateVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				}
			},
			methods: {

				/**
				 * @private
				 */
				_isBlankSlateInvisible: function () {
					return !this.$IsBlankSlateVisible;
				},

				/**
				 * @private
				 */
				_getTrackingFeatureState: function () {
					return this.Terrasoft.Features.getIsEnabled("Tracking");
				},

				/**
				 * @private
				 */
				_setTrackingTabVisibility: function () {
					if (!this._getTrackingFeatureState()) {
						var tabCollection = this.get("TabsCollection");
						if (tabCollection.contains("TrackingEventsTab")) {
							tabCollection.removeByKey("TrackingEventsTab");
						}
					}
				},

				/**
				 * @private
				 */
				_appendTrackingEventFeedDomElement: function () {
					const element = document.createElement("ts-tracking-events-feed");
					element.entityId = this.$PrimaryColumnValue;
					element.resources = resources;
					element.schema = "CONTACT";
					element.id = "TrackingEventFeed";
					var eventFeedContainer = document.querySelector("#EventsFeedContainer");
					eventFeedContainer.appendChild(element);
				},

				/**
				 * @private
				 */
				_destroyTrackingEventFeedDomElement: function () {
					var trackingEventFeed = Ext.get("TrackingEventFeed");
					trackingEventFeed.destroy();
				},

				/**
				 * @private
				 */
				_recreateTrackingEventFeedDomElement: function () {
					this._destroyTrackingEventFeedDomElement();
					this._appendTrackingEventFeedDomElement();
				},

				/**
				 * @private
				 */
				_afterEventsFeedContainerRender: function () {
					if (this.$IsBlankSlateVisible) {
						return;
					}
					this._appendTrackingEventFeedDomElement();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function () {
					this.callParent(arguments);
					if (this.$ActiveTabName === "TrackingEventsTab" && !this.$IsBlankSlateVisible) {
						this._recreateTrackingEventFeedDomElement();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
				 * @overridden
				 */
				onRender: function () {
					this.callParent(arguments);
					this.$IsBlankSlateVisible = this.Ext.isIEOrEdge;
				},

				/**
				 * Returns blank slate icon url.
				 * @protected
				 * @virtual
				 * @return {String} Blank slate icon url.
				 */
				getBlankSlateIcon: function () {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.BlankSlateIcon"));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @override
				 */
				init: function () {
					this.callParent(arguments);
					this._setTrackingTabVisibility();
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "TrackingEventsTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": "$Resources.Strings.TrackingEventsTabCaption",
						"items": [],
						"styles": {
							"height": "calc(100% - 3.8em)",
							"width": "100%"
						},
						"order": 4
					}
				},
				{
					"operation": "insert",
					"name": "TrackingEventsLayout",
					"parentName": "TrackingEventsTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TrackingEventsContainer",
					"parentName": "TrackingEventsLayout",
					"propertyName": "items",
					"values": {
						"markerValue": "TrackingEventsContainer",
						"id": "TrackingEventsContainer",
						"selectors": { "wrapEl": "#TrackingEventsContainer" },
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"layout": { "column": 0, "row": 0, "rowSpan": 6, "colSpan": 24 },
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoContainer",
					"parentName": "TrackingEventsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"classes": {
							"wrapClassName": ["wrong-browser-info-wrap"]
						},
						"styles": {
							"height": "100%",
							"width": "100%"
						},
						"visible": "$IsBlankSlateVisible",
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoIcon",
					"parentName": "WrongBrowserInfoContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getBlankSlateIcon",
						"readonly": true,
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"classes": {
							"wrapClass": ["wrong-browser-info-icon"]
						},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24,
							"rowSpan": 5
						}
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoDescription",
					"parentName": "WrongBrowserInfoContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.BlankSlateDescription",
						"labelClass": ["wrong-browser-info-description"],
						"layout": {
							"column": 3,
							"row": 6,
							"colSpan": 20,
							"rowSpan": 6
						}
					}
				},
				{
					"operation": "insert",
					"name": "EventsFeedContainer",
					"parentName": "TrackingEventsContainer",
					"propertyName": "items",
					"values": {
						"id": "EventsFeedContainer",
						"items": [],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"afterrender": "$_afterEventsFeedContainerRender",
						"afterrerender": "$_afterEventsFeedContainerRender",
						"visible": "$_isBlankSlateInvisible"
					}
				}
			]
		};
	}
);
define('ContactPageV2SiteEventResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2SiteEvent", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				SiteEventDetail: {
					schemaName: "SiteEventDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "SiteEventDetail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2OpportunityResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Opportunity", [], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			Opportunities: {
				schemaName: "OpportunityDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "Opportunities",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2ProjectResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Project", ["ConfigurationConstants"], function(ConfigurationConstants) {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			Project: {
				schemaName: "ProjectDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			InternalRate: {
				schemaName: "ContactInternalRateDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			},
			ExternalRate: {
				schemaName: "ContactExternalRateDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		methods: {
			getRateDetailsVisible: function() {
				if (this.get("Type")) {
					return this.get("Type").value === ConfigurationConstants.ContactType.Employee && Terrasoft.Features.getIsDisabled("HideSalesProject");
				}
				return false;
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"index": 7,
				"propertyName": "items",
				"name": "Project",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": Terrasoft.Features.getIsDisabled("HideSalesProject")
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"propertyName": "items",
				"name": "InternalRate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "getRateDetailsVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "JobTabContainer",
				"propertyName": "items",
				"name": "ExternalRate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL,
					"visible": {
						"bindTo": "getRateDetailsVisible"
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('ContactPageV2PRMBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2PRMBase", [], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			"Certificate": {
				"schemaName": "CertificateDetail",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "Id"
				}
			},
			"EducationAndCertificate": {
				"schemaName": "EducationAndCertificateDetail",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "EducationAndCertificate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "HistoryTab",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Certificate",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "HistoryTab",
				"propertyName": "items"
			}
		]/**SCHEMA_DIFF*/,
		methods: {},
		rules: {}
	};
});

define('ContactPageV2SalesEnterpriseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2SalesEnterprise", [],
		function() {
			return {
				entitySchemaName: "Contact",
				details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "move",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Activities",
						"index": 0
					},
					{
						"operation": "move",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Contract",
						"index": 1
					},
					{
						"operation": "move",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Documents",
						"index": 7
					}
				]/**SCHEMA_DIFF*/
			};
		});

define('ContactPageV2CaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2Case", [],
function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			Cases: {
				schemaName: "CaseDetail",
				filter: {
					masterColumn: "Id",
					detailColumn: "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"index": 0,
				"propertyName": "items",
				"name": "Cases",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		methods: {},
		rules: {},
		userCode: {}
	};
});

define('ContactPageV2EmailMessageMiningResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2EmailMessageMining", ["ContactPageV2Resources", "css!ContactPageV2CSS", "EmailEnrichmentMixin"], function() {
		return {
			messages: {

				/**
				 * Update contact enrichment page visibility.
				 */
				"ContactPageV2OnSavedResponse": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.PUBLISH
				}
			},

			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onSaved
				 * @overridden
				 */
				onSaved: function(response) {
					var savedRecordConfig = {
						success: response.success,
						contactId: this.getPrimaryColumnValue(),
						contactName: this.getPrimaryDisplayColumnValue()
					};
					this.sandbox.publish("ContactPageV2OnSavedResponse", savedRecordConfig, [this.sandbox.id]);
					this.callParent(arguments);
				}

				//endregion

			}
		};
	});

define('ContactPageV2CMDBResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2CMDB", [],
	function() {
		return {
			entitySchemaName: "Contact",
			details: /**SCHEMA_DETAILS*/{
				"ConfItem": {
					"schemaName": "ConfItemInContactDetail",
					"entitySchemaName": "ConfItemUser",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "ConfItem",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/
		};
	});

define('ContactPageV2SLMITILServiceResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2SLMITILService", ["ServiceFilterMixin"],
function() {
	return {
		entitySchemaName: "Contact",
		mixins: {
			/**
			 * @class Terrasoft.configuration.mixins.ServiceFilterMixin.
			 */
			ServiceFilterMixin: "Terrasoft.ServiceFilterMixin"
		},
		messages: {
			/*
			 * @message
			 * Updates service recipients detail.
			 * */
			"UpdateServiceRecepientsDetail": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		details: /**SCHEMA_DETAILS*/{
			"Services": {
				"schemaName": "ServiceRecepientsDetail",
				"entitySchemaName": "VwServiceRecepients",
				"filterMethod": "getServicesFilter",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Contact"
				}
			},
			"ServicePacts": {
				"schemaName": "ServicePactRecipientsDetail",
				"entitySchemaName": "ServiceObject",
				"filterMethod": "getServicesPactFilter",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ContactPageServiceTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {"bindTo": "Resources.Strings.ContactPageServiceTab"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Services",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "ContactPageServiceTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ServicePacts",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "ContactPageServiceTab",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		methods: {
			/**
			 * @inheritDoc Terrasoft.BasePageV2#onEntityInitialized
			 * @overridden
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.sandbox.subscribe("UpdateServiceRecepientsDetail", this.updateDetails, this);
				this.initServiceFilterMixin();
			},

			/**
			 * Returns service item filter.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getServicesFilter: function() {
				return this.mixins.ServiceFilterMixin.getServicesFilter("Service.Id",
					"[VwServiceRecepients:Service:Id]");
			},

			/**
			 * Returns service pact filter.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getServicesPactFilter: function() {
				return this.mixins.ServiceFilterMixin.getServicesFilter("ServicePact.Id",
					"[ServiceObject:ServicePact:Id]");
			},

			/**
			 * Initialize ServiceFilter mixin.
			 * @protected
			 */
			initServiceFilterMixin: function() {
				this.mixins.ServiceFilterMixin.init({
					contact: this.$Id,
					account: this.$Account,
					department:  this.$Department
				});
			}
		},
		rules: {},
		userCode: {}
	};
});

define('ContactPageV2MarketingCampaignResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ContactPageV2MarketingCampaign", [],
		function() {
			return {
				entitySchemaName: "Contact",
				details: /**SCHEMA_DETAILS*/{
					BulkEmailSubscriptionDetail: {
						schemaName: "BulkEmailSubscriptionDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "Contact"
						}
					},
					EventDetail: {
						schemaName: "ContactInEventDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "Contact"
						}
					},
					BulkEmailDetail: {
						schemaName: "ContactInBulkEmailDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "Contact"
						}
					},
					CampaignDetail: {
						schemaName: "ContactInCampaignDetail",
						filter: {
							masterColumn: "Id",
							detailColumn: "Contact"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "CommunicationChannelsTab",
						"parentName": "Tabs",
						"propertyName": "tabs",
						"values": {
							"caption": {"bindTo": "Resources.Strings.CommunicationChannelsTabCaption"},
							"items": []
						},
						"index": 3
					},
					{
						"operation": "insert",
						"name": "CommunicationChannelsContainer",
						"propertyName": "items",
						"parentName": "CommunicationChannelsTab",
						"values": {
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"name": "DoNotUseEmail",
						"propertyName": "items",
						"parentName": "CommunicationChannelsContainer",
						"values": {
							"layout": {"column": 0, "row": 0},
							"enabled": false
						}
					},
					{
						"operation": "insert",
						"name": "DoNotUseCall",
						"propertyName": "items",
						"parentName": "CommunicationChannelsContainer",
						"values": {
							"layout": {"column": 0, "row": 1},
							"enabled": false
						}
					},
					{
						"operation": "insert",
						"name": "DoNotUseSms",
						"propertyName": "items",
						"parentName": "CommunicationChannelsContainer",
						"values": {
							"layout": {"column": 12, "row": 0},
							"enabled": false
						}
					},
					{
						"operation": "insert",
						"name": "DoNotUseMail",
						"propertyName": "items",
						"parentName": "CommunicationChannelsContainer",
						"values": {
							"layout": {"column": 12, "row": 1},
							"enabled": false
						}
					},
					{
						"operation": "insert",
						"parentName": "CommunicationChannelsTab",
						"propertyName": "items",
						"name": "BulkEmailSubscriptionDetail",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "EventDetail",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "BulkEmailDetail",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "CampaignDetail",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"parentName": "ContactGeneralInfoBlock",
						"propertyName": "items",
						"name": "Dear",
						"values": {
							"layout": {"column": 0, "row": 2}
						}
					},
					{
						"operation": "merge",
						"name": "Age",
						"values": {
							"layout": {"column": 0, "row": 3}
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});

define("ContactPageV2", [], function() {
	return {
		entitySchemaName: "Contact",
		details: /**SCHEMA_DETAILS*/{
			SiteEventDetail: {
				schemaName: "SiteEventDetailV2",
				entitySchemaName: "SiteEvent",
				filter: {
					masterColumn: "Id",
					detailColumn: "[Lead:BpmSessionId:BpmSessionId].QualifiedContact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/ [
			{
				"operation": "move",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "SiteEventDetail",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 0
			}
		] /**SCHEMA_DIFF*/
	};
});


