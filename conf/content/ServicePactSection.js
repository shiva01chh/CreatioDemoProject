Terrasoft.configuration.Structures["ServicePactSection"] = {innerHierarchyStack: ["ServicePactSection"], structureParent: "BaseSectionV2"};
define('ServicePactSectionStructure', ['ServicePactSectionResources'], function(resources) {return {schemaUId:'02f46ed8-831e-4f7d-a393-a2cb193d3201',schemaCaption: "Page schema - Service contracts section", parentSchemaName: "BaseSectionV2", packageName: "SLMITILService", schemaName:'ServicePactSection',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServicePactSection", ["GridUtilitiesV2"],
function() {
	return {
		entitySchemaName: "ServicePact",
		contextHelpId: "1001",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		messages: {},
		methods: {

			/**
			 * ############# ############# ########### #######.
			 * @protected
			 */
			initContextHelp: function() {
				this.set("ContextHelpId", 1062);
				this.callParent(arguments);
			}
		}
	};
});


