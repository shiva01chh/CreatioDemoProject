Terrasoft.configuration.Structures["GeneratedWebFormSectionV2"] = {innerHierarchyStack: ["GeneratedWebFormSectionV2WebForm", "GeneratedWebFormSectionV2"], structureParent: "BaseSectionV2"};
define('GeneratedWebFormSectionV2WebFormStructure', ['GeneratedWebFormSectionV2WebFormResources'], function(resources) {return {schemaUId:'44c6ea6f-e551-4fe6-9dbf-5c162aad471c',schemaCaption: "List - Landing pages for external resources", parentSchemaName: "BaseSectionV2", packageName: "CrtTouchPoint7x", schemaName:'GeneratedWebFormSectionV2WebForm',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('GeneratedWebFormSectionV2Structure', ['GeneratedWebFormSectionV2Resources'], function(resources) {return {schemaUId:'2801cfc5-880b-4298-80e8-eb1c03a96134',schemaCaption: "List - Landing pages for external resources", parentSchemaName: "GeneratedWebFormSectionV2WebForm", packageName: "CrtTouchPoint7x", schemaName:'GeneratedWebFormSectionV2',parentSchemaUId:'44c6ea6f-e551-4fe6-9dbf-5c162aad471c',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"GeneratedWebFormSectionV2WebForm",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('GeneratedWebFormSectionV2WebFormResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("GeneratedWebFormSectionV2WebForm", function() {
		return {
			entitySchemaName: "GeneratedWebForm",
			methods: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "CombinedModeViewOptionsButton",
					"values": {
						"visible": {"bindTo": "IsSectionVisible"}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

 define("GeneratedWebFormSectionV2", function() {
		return {
			entitySchemaName: "GeneratedWebForm",
			methods: {
				/**
				 * @inheritDoc Terrasoft.BaseSchemaViewModel#initEditPages
				 * @override
				 */
				 initEditPages: function() {
					if (this.getIsFeatureEnabled("FormSubmitGeneratedWebForm")) {
						return this.callParent(arguments);
					}
					var collection = Ext.create("Terrasoft.BaseViewModelCollection");
					var entityStructure = this.getEntityStructure(this.entitySchemaName);
					if (entityStructure) {
						var editPages = entityStructure.pages.filter(function(page) {
							return page.cardSchema !== "FormSubmitGeneratedWebFormPageV2";
						});
						Terrasoft.each(editPages, function(editPage) {
							var typeUId = editPage.UId || Terrasoft.GUID_EMPTY;
							collection.add(typeUId, Ext.create("Terrasoft.BaseViewModel", {
								values: {
									Id: typeUId,
									Caption: editPage.caption,
									Click: {bindTo: "addRecord"},
									Tag: typeUId,
									SchemaName: editPage.cardSchema
								}
							}));
						}, this);
						this.set("EditPages", collection);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});


