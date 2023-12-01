﻿Terrasoft.configuration.Structures["PageDesignerHeaderViewConfig"] = {innerHierarchyStack: ["PageDesignerHeaderViewConfig"]};
define('PageDesignerHeaderViewConfigStructure', ['PageDesignerHeaderViewConfigResources'], function(resources) {return {schemaUId:'245b698a-b42e-480f-aa88-108238930318',schemaCaption: "PageDesignerHeaderViewConfig", parentSchemaName: "", packageName: "CrtWizards7x", schemaName:'PageDesignerHeaderViewConfig',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PageDesignerHeaderViewConfig", [
	"PageDesignerHeaderViewConfigResources",
	"PageDesignerHeaderModule"
], function(resources) {
	/**
	 * Class for PageDesignerHeaderViewConfig.
	 */
	Ext.define("Terrasoft.configuration.PageDesignerHeaderViewConfig", {
		extend: "Terrasoft.configuration.WizardHeaderViewConfig",
		alternateClassName: "Terrasoft.PageDesignerHeaderViewConfig",

		/**
		 * @inheritdoc WizardHeaderViewConfig#getUtilsContainerViewConfig
		 * @override
		 */
		getUtilsContainerViewConfig: function() {
			var config = this.callParent();
			config.items.push(this.getUtilsToolsContainerViewConfig());
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.WizardHeaderViewConfig#getUtilsLeftContainerViewConfig
		 * @override
		 */
		getUtilsLeftContainerViewConfig: function() {
			var config = this.callParent();
			config.items.push({
				itemType: Terrasoft.ViewItemType.BUTTON,
				name: "ActionsButton",
				caption: "Actions",
				visible: {bindTo: "isActionsButtonVisible"},
				classes: {
					textClass: ["utils-button"],
					wrapperClass: ["utils-button"]
				},
				menu: [
					{
						caption: "Source Code (Ctrl+K)",
						click: {bindTo: "onOpenSourceCode"}
					},
					{
						caption: "View Metadata (Ctrl+M)",
						click: {bindTo: "onOpenMetaData"}
					},
					{
						caption: "Export Metadata",
						click: {bindTo: "onExportMetaData"}
					}
				]
			});
			return config;
		},

		/**
		 * @protected
		 */
		getUtilsToolsContainerViewConfig: function() {
			return {
				"name": "utilsToolsContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"wrapClass": ["utils-tools"],
				"items": [{
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"name": "PropertyPageWizardButton",
					"classes": {"wrapperClass": "schema-properties-button"},
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"click": {"bindTo": "onShowPropertyPage"},
					"markerValue": "SchemaPropertiesButton",
					"imageConfig": resources.localizableImages.PageWizardPropertiesPageIcon,
					"hint": resources.localizableStrings.SchemaPropertiesButtonHint
				}]
			};
		}
	});

});


