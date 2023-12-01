Terrasoft.configuration.Structures["ReleaseInServiceItemDetail"] = {innerHierarchyStack: ["ReleaseInServiceItemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ReleaseInServiceItemDetailStructure', ['ReleaseInServiceItemDetailResources'], function(resources) {return {schemaUId:'5a966803-154f-4826-9f0e-a82939268b45',schemaCaption: "Detail schema - \"Releases\" in \"Services\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Release", schemaName:'ReleaseInServiceItemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ReleaseInServiceItemDetail", [],
	function() {
		return {
			entitySchemaName: "ReleaseServiceItem",
			methods: {
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
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Release";
					config.sectionEntitySchema = "ServiceItem";
					config.lookupConfig.hideActions = true;
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
					return "Release";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


