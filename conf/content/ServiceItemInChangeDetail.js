Terrasoft.configuration.Structures["ServiceItemInChangeDetail"] = {innerHierarchyStack: ["ServiceItemInChangeDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ServiceItemInChangeDetailStructure', ['ServiceItemInChangeDetailResources'], function(resources) {return {schemaUId:'e7ae2d9a-ddb2-4e15-8f7c-98a9e516963e',schemaCaption: "Detail schema - Services in \"Changes\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Change", schemaName:'ServiceItemInChangeDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceItemInChangeDetail", ["ServiceItemInChangeDetailResources"],
	function(resourses) {
		return {
			entitySchemaName: "ChangeServiceItem",
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
				 * Returns an element of combobox list of functional button which is responsible for SRM.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.BaseViewModel} An element of combobox list of functional button.
				 */
				getOpenServiceModelMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: resourses.localizableStrings.OpenServiceModelModuleCaption,
						Click: {"bindTo": "openServiceModelModule"},
						Enabled: {"bindTo": "getOpenServiceModelButtonEnabled"}
					});
				},

				/**
				 * Returns the availability of "Show dependencies" button.
				 * @return {Boolean}
				 */
				getOpenServiceModelButtonEnabled: function() {
					var selectedItems = this.getSelectedItems();
					return selectedItems && (selectedItems.length === 1);
				},

				/**
				 * "Show dependencies" action event handler.
				 * Open page of SRM by pressing the button "Show dependencies".
				 */
				openServiceModelModule: function() {
					var activeRow = this.getActiveRow();
					if (!activeRow) {
						return;
					}
					var defaultValues = [{
						"id": activeRow.get("ServiceItem").value,
						"schemaName": "ServiceItem",
						"name": activeRow.get("ServiceItem").displayValue
					}];
					var openCardConfig = {
						moduleId: this.sandbox.id + "_CardModule",
						schemaName: "ServiceModelPage",
						operation: "edit",
						isSeparateMode: false,
						defaultValues: defaultValues,
						id: activeRow.get("ServiceItem").value
					};
					this.sandbox.publish("OpenCard", openCardConfig, [this.sandbox.id]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,
				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: this.Terrasoft.emptyFn,
				/**
				 * Initialize detail config.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ServiceItem";
					config.lookupConfig.hideActions = true;
					config.sectionEntitySchema = "Change";
				},
				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#init
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
					return "ServiceItem";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});


