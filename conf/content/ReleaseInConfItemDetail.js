Terrasoft.configuration.Structures["ReleaseInConfItemDetail"] = {innerHierarchyStack: ["ReleaseInConfItemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ReleaseInConfItemDetailStructure', ['ReleaseInConfItemDetailResources'], function(resources) {return {schemaUId:'f305acea-92d5-446f-b63d-07cf108f955e',schemaCaption: "Detail schema - \"Releases\" in \"Configuration items\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Release", schemaName:'ReleaseInConfItemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ReleaseInConfItemDetail", [],
	function() {
		return {
			entitySchemaName: "ReleaseConfItem",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Release";
					config.sectionEntitySchema = "ConfItem";
					config.lookupConfig.hideActions = true;
				},
				/**
				 * ######### #############.
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


