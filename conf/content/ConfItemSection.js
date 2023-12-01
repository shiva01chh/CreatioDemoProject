Terrasoft.configuration.Structures["ConfItemSection"] = {innerHierarchyStack: ["ConfItemSectionCMDB", "ConfItemSection"], structureParent: "BaseSectionV2"};
define('ConfItemSectionCMDBStructure', ['ConfItemSectionCMDBResources'], function(resources) {return {schemaUId:'9a39d75f-e346-44c1-8485-307f03f4ef6d',schemaCaption: "Page schema - Configuration items section", parentSchemaName: "BaseSectionV2", packageName: "ServiceModel", schemaName:'ConfItemSectionCMDB',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemSectionStructure', ['ConfItemSectionResources'], function(resources) {return {schemaUId:'df79f9c1-09bd-4903-b01c-bf4df00d598c',schemaCaption: "Page schema - Configuration items section", parentSchemaName: "ConfItemSectionCMDB", packageName: "ServiceModel", schemaName:'ConfItemSection',parentSchemaUId:'9a39d75f-e346-44c1-8485-307f03f4ef6d',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ConfItemSectionCMDB",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemSectionCMDBResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ConfItemSectionCMDB", ["GridUtilitiesV2"],
function() {
	return {
		entitySchemaName: "ConfItem",
		contextHelpId: "1001",
		diff: /**SCHEMA_DIFF*/[],/**SCHEMA_DIFF*/
		messages: {},
		methods: {

			/**
			 * ############# ############# ########### #######.
			 * @protected
			 */
			initContextHelp: function() {
				this.set("ContextHelpId", 1065);
				this.callParent(arguments);
			}
		}
	};
});

define("ConfItemSection", ["ItemSectionGridRowViewModel", "GridUtilitiesV2", "css!AdditionalCssModule"],
	function() {
		return {
			entitySchemaName: "ConfItem",
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


