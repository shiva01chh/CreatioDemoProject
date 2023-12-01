Terrasoft.configuration.Structures["ServiceItemSection"] = {innerHierarchyStack: ["ServiceItemSectionSLM", "ServiceItemSection"], structureParent: "BaseSectionV2"};
define('ServiceItemSectionSLMStructure', ['ServiceItemSectionSLMResources'], function(resources) {return {schemaUId:'46be842d-ad07-493e-9e0d-47741bf05901',schemaCaption: "Page schema - \"Services\" section", parentSchemaName: "BaseSectionV2", packageName: "ServiceModel", schemaName:'ServiceItemSectionSLM',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemSectionStructure', ['ServiceItemSectionResources'], function(resources) {return {schemaUId:'da3df136-087b-459c-915c-d68c8227683c',schemaCaption: "Page schema - \"Services\" section", parentSchemaName: "ServiceItemSectionSLM", packageName: "ServiceModel", schemaName:'ServiceItemSection',parentSchemaUId:'46be842d-ad07-493e-9e0d-47741bf05901',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemSectionSLM",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemSectionSLMResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemSectionSLM", [],
function() {
	return {
		entitySchemaName: "ServiceItem",
		ContextHelpId: "1061",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		messages: {},
		methods: {
			/**
			 * ############# ############# ########### #######.
			 * @protected
			 */
			initContextHelp: function() {
				this.set("ContextHelpId", 1061);
				this.callParent(arguments);
			}
		}
	};
});

define("ServiceItemSection", ["ItemSectionGridRowViewModel", "GridUtilitiesV2", "css!AdditionalCssModule"],
	function() {
		return {
			entitySchemaName: "ServiceItem",
			contextHelpId: "1061",
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "DataGridActiveRowOpenServiceModelModuleAction",
					"parentName": "DataGrid",
					"propertyName": "activeRowActions",
					"values": {
						"className": "Terrasoft.Button",
						"style": this.Terrasoft.controls.ButtonEnums.style.BLUE,
						"caption": {"bindTo": "getOpenServiceModelPageCaption"},
						"tag": "openServiceModelPage"
					}
				}
			]/**SCHEMA_DIFF*/,
			messages: {},
			methods: {
				/**
				 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
				 * @overridden
				 */
				getGridRowViewModelClassName: function() {
					return "Terrasoft.ItemSectionGridRowViewModel";
				},
				/**
				 * ########## ####### ## ######## "########## ###########".
				 * ### ####### ## ###### "########## ###########" ########### ######## ########### ###.
				 */
				openServiceModelModule: function() {
					var activeRow = this.getActiveRow();
					var defaultValues = [{
						"id": activeRow.values.Id,
						"schemaName": activeRow.entitySchema.name,
						"name": activeRow.values.Name
					}];
					this.openCardInChain({
						"schemaName": "ServiceModelPage",
						"moduleId": this.sandbox.id + "_ServiceModelPage",
						"isSeparateMode": false,
						"defaultValues": defaultValues
					});
				},
				/**
				 * ########## ####### ###### # ####### #######.
				 * ### ####### ## ###### "########## ###########" ########### ######## ########### ###.
				 * @overridden
				 */
				onActiveRowAction: function(tag) {
					if (tag === "openServiceModelPage") {
						this.openServiceModelModule();
					} else {
						this.callParent(arguments);
					}
				}
			}
		};
	});


