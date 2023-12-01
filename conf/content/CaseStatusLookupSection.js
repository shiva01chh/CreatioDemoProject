Terrasoft.configuration.Structures["CaseStatusLookupSection"] = {innerHierarchyStack: ["CaseStatusLookupSection"], structureParent: "BaseLookupConfigurationSection"};
define('CaseStatusLookupSectionStructure', ['CaseStatusLookupSectionResources'], function(resources) {return {schemaUId:'e231aa20-bc42-4ec3-a54b-77ee6df3c2cc',schemaCaption: "Lookup section page schema - Case status", parentSchemaName: "BaseLookupConfigurationSection", packageName: "CrtCase7x", schemaName:'CaseStatusLookupSection',parentSchemaUId:'c8c39e3b-de05-4d01-814a-45c7981e139f',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseStatusLookupSection", ["CaseStatusLookupSectionResources"],
	function(resources) {
		return {
			entitySchemaName: "CaseStatus",
			attributes: {},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			messages: {},
			mixins: {},
			methods: {}
		};
	});


