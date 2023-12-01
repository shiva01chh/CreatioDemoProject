Terrasoft.configuration.Structures["LeadGenExtendedLeadInformationDetail"] = {innerHierarchyStack: ["LeadGenExtendedLeadInformationDetail"], structureParent: "BaseGridDetailV2"};
define('LeadGenExtendedLeadInformationDetailStructure', ['LeadGenExtendedLeadInformationDetailResources'], function(resources) {return {schemaUId:'4fa2a7c5-abc3-45ba-9d7f-0e75a33edcaf',schemaCaption: "Detail schema: \"Extended lead information\"", parentSchemaName: "BaseGridDetailV2", packageName: "SocialLeadGen", schemaName:'LeadGenExtendedLeadInformationDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("LeadGenExtendedLeadInformationDetail", [], function() {
	return {
		entitySchemaName: "LeadGenExtendedLeadInformation",
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


