Terrasoft.configuration.Structures["BulkEmailEventLogDetail"] = {innerHierarchyStack: ["BulkEmailEventLogDetail"], structureParent: "BaseGridDetailV2"};
define('BulkEmailEventLogDetailStructure', ['BulkEmailEventLogDetailResources'], function(resources) {return {schemaUId:'c4b3bf0b-6e05-40d5-9d1d-e569a41cd834',schemaCaption: "Detail schema: \"Sending log\"", parentSchemaName: "BaseGridDetailV2", packageName: "MarketingCampaign", schemaName:'BulkEmailEventLogDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("BulkEmailEventLogDetail", [], function() {
	return {
		entitySchemaName: "BulkEmailEventLog",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "AddRecordButton"
			},
			{
				"operation": "remove",
				"name": "AddTypedRecordButton"
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			getCopyRecordMenuItem: Terrasoft.emptyFn,
			getEditRecordMenuItem: Terrasoft.emptyFn,
			getDeleteRecordMenuItem: Terrasoft.emptyFn
		}
	};
});


