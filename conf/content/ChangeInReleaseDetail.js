Terrasoft.configuration.Structures["ChangeInReleaseDetail"] = {innerHierarchyStack: ["ChangeInReleaseDetail"], structureParent: "BaseOneToManyGridDetail"};
define('ChangeInReleaseDetailStructure', ['ChangeInReleaseDetailResources'], function(resources) {return {schemaUId:'d6f94f6a-7f23-49f1-917a-3b69efca4c21',schemaCaption: "Detail schema - \"Changes\" in \"Releases\" section", parentSchemaName: "BaseOneToManyGridDetail", packageName: "Release", schemaName:'ChangeInReleaseDetail',parentSchemaUId:'3adfc7da-b598-4c02-8af7-9be9fd542248',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ChangeInReleaseDetail", [],
	function() {
		return {
			entitySchemaName: "Change",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = "Change";
					config.sectionEntitySchema = "Release";
				},
				/**
				 * ######### #############.
				 */
				init: function() {
					this.callParent(arguments);
					this.initConfig();
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


