Terrasoft.configuration.Structures["BootstrapModulesV2"] = {innerHierarchyStack: ["BootstrapModulesV2CrtNUI", "BootstrapModulesV2CrtEventInCampaign7x", "BootstrapModulesV2CrtEngagementInCampaign7x", "BootstrapModulesV2CrtEmailInCampaign7x", "BootstrapModulesV2"]};
define('BootstrapModulesV2CrtNUIStructure', ['BootstrapModulesV2CrtNUIResources'], function(resources) {return {schemaUId:'7dc0e82d-cb4a-43ba-9753-1d38501a267a',schemaCaption: "BootstrapModulesV2", parentSchemaName: "", packageName: "CampaignElements.UI", schemaName:'BootstrapModulesV2CrtNUI',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('BootstrapModulesV2CrtEventInCampaign7xStructure', ['BootstrapModulesV2CrtEventInCampaign7xResources'], function(resources) {return {schemaUId:'f8583422-4cbf-4b16-b67a-b5cbf114bb41',schemaCaption: "BootstrapModulesV2", parentSchemaName: "BootstrapModulesV2CrtNUI", packageName: "CampaignElements.UI", schemaName:'BootstrapModulesV2CrtEventInCampaign7x',parentSchemaUId:'7dc0e82d-cb4a-43ba-9753-1d38501a267a',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"BootstrapModulesV2CrtNUI",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('BootstrapModulesV2CrtEngagementInCampaign7xStructure', ['BootstrapModulesV2CrtEngagementInCampaign7xResources'], function(resources) {return {schemaUId:'ee772c2f-2d29-45ff-894e-550914ad5313',schemaCaption: "BootstrapModulesV2", parentSchemaName: "BootstrapModulesV2CrtEventInCampaign7x", packageName: "CampaignElements.UI", schemaName:'BootstrapModulesV2CrtEngagementInCampaign7x',parentSchemaUId:'f8583422-4cbf-4b16-b67a-b5cbf114bb41',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"BootstrapModulesV2CrtEventInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('BootstrapModulesV2CrtEmailInCampaign7xStructure', ['BootstrapModulesV2CrtEmailInCampaign7xResources'], function(resources) {return {schemaUId:'34befb19-2bcf-495f-92e5-e0f79d9b86c4',schemaCaption: "BootstrapModulesV2", parentSchemaName: "BootstrapModulesV2CrtEngagementInCampaign7x", packageName: "CampaignElements.UI", schemaName:'BootstrapModulesV2CrtEmailInCampaign7x',parentSchemaUId:'ee772c2f-2d29-45ff-894e-550914ad5313',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"BootstrapModulesV2CrtEngagementInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('BootstrapModulesV2Structure', ['BootstrapModulesV2Resources'], function(resources) {return {schemaUId:'041621af-ae0a-4044-aaf2-7c143ce09fe7',schemaCaption: "BootstrapModulesV2", parentSchemaName: "BootstrapModulesV2CrtEmailInCampaign7x", packageName: "CampaignElements.UI", schemaName:'BootstrapModulesV2',parentSchemaUId:'34befb19-2bcf-495f-92e5-e0f79d9b86c4',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"BootstrapModulesV2CrtEmailInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('BootstrapModulesV2CrtNUIResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("BootstrapModulesV2CrtNUI", [], function() {
	return {};
});
define('BootstrapModulesV2CrtEventInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("BootstrapModulesV2CrtEventInCampaign7x", ["AdditionalEventCampaignConnectorManager","ProcessEventConditionalTransitionSchema"], function() {});
require(["AdditionalEventCampaignConnectorManager","ProcessEventConditionalTransitionSchema"]);

define('BootstrapModulesV2CrtEngagementInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("BootstrapModulesV2CrtEngagementInCampaign7x", ["AdditionalLandingCampaignConnectorManager","ProcessLandingConditionalTransitionSchema"], function() {});
require(["AdditionalLandingCampaignConnectorManager","ProcessLandingConditionalTransitionSchema"]);

define('BootstrapModulesV2CrtEmailInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("BootstrapModulesV2CrtEmailInCampaign7x", ["AdditionalEmailCampaignConnectorManager","ProcessEmailConditionalTransitionSchema"], function() {});
require(["AdditionalEmailCampaignConnectorManager","ProcessEmailConditionalTransitionSchema"]);

define("BootstrapModulesV2", ["AdditionalElementConnectorManager"], function() {});
require(["AdditionalElementConnectorManager"]);


