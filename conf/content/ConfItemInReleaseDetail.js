Terrasoft.configuration.Structures["ConfItemInReleaseDetail"] = {innerHierarchyStack: ["ConfItemInReleaseDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ConfItemInReleaseDetailStructure', ['ConfItemInReleaseDetailResources'], function(resources) {return {schemaUId:'65d3ec99-dd16-4b87-aca4-b5dfa3cf524d',schemaCaption: "Detail schema - \"Configuration items\" in \"Releases\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Release", schemaName:'ConfItemInReleaseDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemInReleaseDetail", [],
	function() {
		return {
			entitySchemaName: "ReleaseConfItem",
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
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ConfItem";
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
					return "ConfItem";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


