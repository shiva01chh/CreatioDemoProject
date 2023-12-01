Terrasoft.configuration.Structures["CampaignElementSchemaManagerEx"] = {innerHierarchyStack: ["CampaignElementSchemaManagerExCrtCampaignDesigner7x", "CampaignElementSchemaManagerExCrtEventInCampaign7x", "CampaignElementSchemaManagerExCrtEngagementInCampaign7x", "CampaignElementSchemaManagerExCrtEmailInCampaign7x", "CampaignElementSchemaManagerEx"]};
define('CampaignElementSchemaManagerExCrtCampaignDesigner7xStructure', ['CampaignElementSchemaManagerExCrtCampaignDesigner7xResources'], function(resources) {return {schemaUId:'d506eecc-d27e-4752-8539-e36907bb1561',schemaCaption: "CampaignElementSchemaManagerEx", parentSchemaName: "", packageName: "CampaignElements.UI", schemaName:'CampaignElementSchemaManagerExCrtCampaignDesigner7x',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CampaignElementSchemaManagerExCrtEventInCampaign7xStructure', ['CampaignElementSchemaManagerExCrtEventInCampaign7xResources'], function(resources) {return {schemaUId:'b3f02759-89b3-4d47-903d-2de5ceb75e72',schemaCaption: "CampaignElementSchemaManagerEx", parentSchemaName: "CampaignElementSchemaManagerExCrtCampaignDesigner7x", packageName: "CampaignElements.UI", schemaName:'CampaignElementSchemaManagerExCrtEventInCampaign7x',parentSchemaUId:'d506eecc-d27e-4752-8539-e36907bb1561',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CampaignElementSchemaManagerExCrtCampaignDesigner7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CampaignElementSchemaManagerExCrtEngagementInCampaign7xStructure', ['CampaignElementSchemaManagerExCrtEngagementInCampaign7xResources'], function(resources) {return {schemaUId:'9860a514-ed19-44fd-aee8-da2ea6d36a4d',schemaCaption: "CampaignElementSchemaManagerEx", parentSchemaName: "CampaignElementSchemaManagerExCrtEventInCampaign7x", packageName: "CampaignElements.UI", schemaName:'CampaignElementSchemaManagerExCrtEngagementInCampaign7x',parentSchemaUId:'b3f02759-89b3-4d47-903d-2de5ceb75e72',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CampaignElementSchemaManagerExCrtEventInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CampaignElementSchemaManagerExCrtEmailInCampaign7xStructure', ['CampaignElementSchemaManagerExCrtEmailInCampaign7xResources'], function(resources) {return {schemaUId:'363d54ad-6c8e-41c2-bdf8-06accbf20b1d',schemaCaption: "CampaignElementSchemaManagerEx", parentSchemaName: "CampaignElementSchemaManagerExCrtEngagementInCampaign7x", packageName: "CampaignElements.UI", schemaName:'CampaignElementSchemaManagerExCrtEmailInCampaign7x',parentSchemaUId:'9860a514-ed19-44fd-aee8-da2ea6d36a4d',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CampaignElementSchemaManagerExCrtEngagementInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CampaignElementSchemaManagerExStructure', ['CampaignElementSchemaManagerExResources'], function(resources) {return {schemaUId:'53240ce2-6467-457f-aef8-bced350fd1e0',schemaCaption: "CampaignElementSchemaManagerEx", parentSchemaName: "CampaignElementSchemaManagerExCrtEmailInCampaign7x", packageName: "CampaignElements.UI", schemaName:'CampaignElementSchemaManagerEx',parentSchemaUId:'363d54ad-6c8e-41c2-bdf8-06accbf20b1d',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CampaignElementSchemaManagerExCrtEmailInCampaign7x",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CampaignElementSchemaManagerExCrtCampaignDesigner7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("CampaignElementSchemaManagerExCrtCampaignDesigner7x", ["CampaignElementSchemaManager"],
	function() {
		return {
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});

define('CampaignElementSchemaManagerExCrtEventInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
 require(["CampaignElementSchemaManager", 
			"ProcessEventConditionalTransitionSchema",
		  	"CampaignStartEventSchema", "CampaignAddToEventSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessEventConditionalTransitionSchema" },
		{ itemType: "Terrasoft.CampaignStartEventSchema" },
		{ itemType: "Terrasoft.CampaignAddToEventSchema" }
	);
});
define('CampaignElementSchemaManagerExCrtEngagementInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
 require(["CampaignElementSchemaManager", 
		  	"ProcessLandingConditionalTransitionSchema", 
			"CampaignLandingSchema",
		  	"CampaignStartLandingSchema", 
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessLandingConditionalTransitionSchema" },
		{ itemType: "Terrasoft.CampaignStartLandingSchema" },
		{ itemType: "Terrasoft.CampaignLandingSchema" }
	);
});
define('CampaignElementSchemaManagerExCrtEmailInCampaign7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
  require(["CampaignElementSchemaManager", 
			"ProcessEmailConditionalTransitionSchema",
			"MarketingEmailSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessEmailConditionalTransitionSchema" },
		{ itemType: "Terrasoft.MarketingEmailSchema" }
	);
});
  require(["CampaignElementSchemaManager", "CampaignEventSchema"], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.CampaignEventSchema" }
	);
});

