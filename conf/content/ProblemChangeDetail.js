Terrasoft.configuration.Structures["ProblemChangeDetail"] = {innerHierarchyStack: ["ProblemChangeDetail"], structureParent: "BaseOneToManyGridDetail"};
define('ProblemChangeDetailStructure', ['ProblemChangeDetailResources'], function(resources) {return {schemaUId:'795eccf1-a209-4c50-9de9-aa6bbc407a4f',schemaCaption: "Detail schema - Problem in \"Change\" section", parentSchemaName: "BaseOneToManyGridDetail", packageName: "Change", schemaName:'ProblemChangeDetail',parentSchemaUId:'3adfc7da-b598-4c02-8af7-9be9fd542248',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ProblemChangeDetail", ["ConfigurationEnums"],
	function() {
		return {
			entitySchemaName: "Problem",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = "Problem";
					config.sectionEntitySchema = "Change";
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


