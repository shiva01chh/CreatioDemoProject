Terrasoft.configuration.Structures["FormSubmitDetail"] = {innerHierarchyStack: ["FormSubmitDetail"], structureParent: "BaseGridDetailV2"};
define('FormSubmitDetailStructure', ['FormSubmitDetailResources'], function(resources) {return {schemaUId:'ba1c7d53-b000-4349-be5c-8e299d9373e6',schemaCaption: "Detail schema: \"Submitted forms\"", parentSchemaName: "BaseGridDetailV2", packageName: "CrtTouchPoint7x", schemaName:'FormSubmitDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("FormSubmitDetail", [], function() {
	return {
		entitySchemaName: "FormSubmit",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {
			getAddRecordButtonVisible: function() {
                return false;
                                                },
          	getDeleteRecordMenuItem: function() {
                return false;
                                                },
          	getCopyRecordMenuItem: function() {
                return false;
                                                }
		}
	};
});


