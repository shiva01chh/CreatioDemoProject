Terrasoft.configuration.Structures["ItemSectionGridRowViewModel"] = {innerHierarchyStack: ["ItemSectionGridRowViewModel"]};
define('ItemSectionGridRowViewModelStructure', ['ItemSectionGridRowViewModelResources'], function(resources) {return {schemaUId:'94272d00-ebf3-4857-9f68-8d72efb83de5',schemaCaption: "View model schema - List string", parentSchemaName: "", packageName: "ServiceModel", schemaName:'ItemSectionGridRowViewModel',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ItemSectionGridRowViewModel", ["ItemSectionGridRowViewModelResources",
		"BaseSectionGridRowViewModel"],
	function(resources) {
		/**
		 * @class Terrasoft.configuration.QueueGridRowViewModel
		 * ##### ###### ############# ###### #######.
		 */
		Ext.define("Terrasoft.configuration.ItemSectionGridRowViewModel", {
			extend: "Terrasoft.BaseSectionGridRowViewModel",
			alternateClassName: "Terrasoft.ItemSectionGridRowViewModel",

			Ext: null,

			Terrasoft: null,

			sandbox: null,

			columns: {},
			/**
			 * ########## ######### ###### ######## ###.
			 * @returns {String} ######### ######.
			 */
			getOpenServiceModelPageCaption: function() {
				return resources.localizableStrings.OpenServiceModelPageCaption;
			}
		});
	});


