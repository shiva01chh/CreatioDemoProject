Terrasoft.configuration.Structures["ServiceItemInReleaseDetail"] = {innerHierarchyStack: ["ServiceItemInReleaseDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ServiceItemInReleaseDetailStructure', ['ServiceItemInReleaseDetailResources'], function(resources) {return {schemaUId:'3ec87821-7272-403c-8be5-5f532f7772ab',schemaCaption: "Detail schema - \"Services\" in \"Releases\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Release", schemaName:'ServiceItemInReleaseDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceItemInReleaseDetail", [],
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
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ServiceItem";
					config.sectionEntitySchema = "Release";
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
					return "ServiceItem";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


