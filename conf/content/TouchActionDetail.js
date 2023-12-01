Terrasoft.configuration.Structures["TouchActionDetail"] = {innerHierarchyStack: ["TouchActionDetail"], structureParent: "BaseGridDetailV2"};
define('TouchActionDetailStructure', ['TouchActionDetailResources'], function(resources) {return {schemaUId:'e8ddd30b-3fbb-472e-8e55-41982ca588a2',schemaCaption: "Detail schema: \"Web actions\"", parentSchemaName: "BaseGridDetailV2", packageName: "CrtTouchPoint7x", schemaName:'TouchActionDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("TouchActionDetail", [], function() {
	return {
		entitySchemaName: "TouchAction",
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
                                                },
			getEditRecordMenuItem: function() {
                return false;
                                                }
		}
	};
});


