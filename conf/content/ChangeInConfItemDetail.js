Terrasoft.configuration.Structures["ChangeInConfItemDetail"] = {innerHierarchyStack: ["ChangeInConfItemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ChangeInConfItemDetailStructure', ['ChangeInConfItemDetailResources'], function(resources) {return {schemaUId:'e923cae1-168b-4d75-98ca-55e4bb5d7747',schemaCaption: "Change detail schema in Configuration item section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Change", schemaName:'ChangeInConfItemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ChangeInConfItemDetail", [],
	function() {
		return {
			entitySchemaName: "ChangeConfItem",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Change";
					config.sectionEntitySchema = "ConfItem";
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
					return "Change";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});


