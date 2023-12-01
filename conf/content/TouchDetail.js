Terrasoft.configuration.Structures["TouchDetail"] = {innerHierarchyStack: ["TouchDetail"], structureParent: "BaseGridDetailV2"};
define('TouchDetailStructure', ['TouchDetailResources'], function(resources) {return {schemaUId:'c8501c88-5cf9-46da-ad8c-6da3e19ed43b',schemaCaption: "Detail schema: \"Web sessions\"", parentSchemaName: "BaseGridDetailV2", packageName: "CrtTouchPoint7x", schemaName:'TouchDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("TouchDetail", [], function() {
	return {
		entitySchemaName: "Touch",
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


