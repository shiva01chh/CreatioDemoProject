Terrasoft.configuration.Structures["CaseChangeDetail"] = {innerHierarchyStack: ["CaseChangeDetail"], structureParent: "BaseOneToManyGridDetail"};
define('CaseChangeDetailStructure', ['CaseChangeDetailResources'], function(resources) {return {schemaUId:'d699457a-bf8a-46f5-9ddd-a32b3d3eb591',schemaCaption: "Cases detail schema in Changes section", parentSchemaName: "BaseOneToManyGridDetail", packageName: "Change", schemaName:'CaseChangeDetail',parentSchemaUId:'3adfc7da-b598-4c02-8af7-9be9fd542248',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseChangeDetail", ["ConfigurationEnums"],
	function() {
		return {
			entitySchemaName: "Case",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = "Case";
					config.lookupConfig.hideActions = true;
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
	});


