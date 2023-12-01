Terrasoft.configuration.Structures["ConfItemCaseDetail"] = {innerHierarchyStack: ["ConfItemCaseDetailCMDB", "ConfItemCaseDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ConfItemCaseDetailCMDBStructure', ['ConfItemCaseDetailCMDBResources'], function(resources) {return {schemaUId:'92894b66-77d2-46c4-8e54-681c822de5f2',schemaCaption: "Configuration items detail", parentSchemaName: "BaseManyToManyGridDetail", packageName: "ServiceModel", schemaName:'ConfItemCaseDetailCMDB',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemCaseDetailStructure', ['ConfItemCaseDetailResources'], function(resources) {return {schemaUId:'15524549-b54d-4248-9122-de91b8d23a2d',schemaCaption: "Configuration items detail", parentSchemaName: "ConfItemCaseDetailCMDB", packageName: "ServiceModel", schemaName:'ConfItemCaseDetail',parentSchemaUId:'92894b66-77d2-46c4-8e54-681c822de5f2',extendParent:true,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ConfItemCaseDetailCMDB",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemCaseDetailCMDBResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ConfItemCaseDetailCMDB", ["ConfItemCaseDetailResources"],
	function(resources) {
		return {
			entitySchemaName: "ConfItemInCase",
			attributes: {},
			messages: {
				/**
				 * @message UpdateConfItemOnPage
				 * Update current configuration item on page.
				 * @param {Object} config menu
				 */
				"UpdateConfItemOnPage": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {
				/**
				 * @inheritDoc Terrasoft.BaseManyToManyGridDetail#initConfig
				 * @overridden
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ConfItem";
					config.sectionEntitySchema = "Case";
					config.lookupConfig.multiselect = true;
				},

				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initConfig();
				},

				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "ConfItem";
				},

				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#addRecordOperationsMenuItems
				 * @overridden
				 */
				addRecordOperationsMenuItems: function(toolsButtonMenu) {
					this.callParent(arguments);
					toolsButtonMenu.addItem(this.getButtonMenuSeparator());
					toolsButtonMenu.addItem(this.getSetMajorMenuItem());
				},

				/**
				 * Returns item of tools button, which set major configuration item.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.BaseViewModel} Item of tools button, which set major configuration item.
				 */
				getSetMajorMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "getMajorButtonCaption"},
						Click: {"bindTo": "changeMajorProperty"},
						Enabled: {"bindTo": "getChangeMajorPropertyButtonEnabled"}
					});
				},

				/**
				 * Returns change major button caption.
				 * @return {String}
				 */
				getMajorButtonCaption: function() {
					return resources.localizableStrings.AddTagMajorCaption;
				},

				/**
				 * On click change major button handler.
				 * Changes main property in active row.
				 */
				changeMajorProperty: function() {
					var activeRow = this.getActiveRow();
					if (!activeRow) {
						return;
					}
					var major = activeRow.get("Major");
					activeRow.set("Major", !major);
					this.sandbox.publish("UpdateConfItemOnPage", major ? null : activeRow.get("ConfItem"));
				},

				/**
				 * Returns change major button enabled.
				 * @return {Boolean}
				 */
				getChangeMajorPropertyButtonEnabled: function() {
					var selectedItems = this.getSelectedItems();
					return selectedItems && (selectedItems.length === 1);
				}
			}
		};
	});

define("ConfItemCaseDetail", ["ConfItemCaseDetailResources"],
	function(resourses) {
		return {
			entitySchemaName: "ConfItemInCase",
			methods: {
				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#addRecordOperationsMenuItems
				 * @overridden
				 */
				addRecordOperationsMenuItems: function(toolsButtonMenu) {
					this.callParent(arguments);
					toolsButtonMenu.addItem(this.getButtonMenuSeparator());
					toolsButtonMenu.addItem(this.getOpenServiceModelMenuItem());
				},

				/**
				 * ########## ####### ########### ###### ############## ######, ########## ## ######## ###.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.BaseViewModel} ####### ########### ###### ############## ######, ## ######## ###.
				 */
				getOpenServiceModelMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: resourses.localizableStrings.OpenServiceModelModuleCaption,
						Click: {"bindTo": "openServiceModelModule"},
						Enabled: {"bindTo": "getOpenServiceModelButtonEnabled"}
					});
				},

				/**
				 * ########## ########### ###### "########## ###########".
				 * @return {Boolean}
				 */
				getOpenServiceModelButtonEnabled: function() {
					var selectedItems = this.getSelectedItems();
					return selectedItems && (selectedItems.length === 1);
				},

				/**
				 * ########## ####### ## ######## "########## ###########".
				 * ### ####### ## ###### "########## ###########" ########### ######## ########### ###.
				 */
				openServiceModelModule: function() {
					var activeRow = this.getActiveRow();
					if (!activeRow) {
						return;
					}
					var defaultValues = [{
						"id": activeRow.get("ConfItem").value,
						"schemaName": "ConfItem",
						"name": activeRow.get("ConfItem").displayValue
					}];
					var openCardConfig = {
						moduleId: this.sandbox.id + "_CardModule",
						schemaName: "ServiceModelPage",
						operation: "edit",
						isSeparateMode: false,
						defaultValues: defaultValues,
						id: activeRow.get("ConfItem").value
					};
					this.sandbox.publish("OpenCard", openCardConfig, [this.sandbox.id]);
				}
			}
		};
	});


