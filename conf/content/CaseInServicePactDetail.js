Terrasoft.configuration.Structures["CaseInServicePactDetail"] = {innerHierarchyStack: ["CaseInServicePactDetail"], structureParent: "BaseGridDetailV2"};
define('CaseInServicePactDetailStructure', ['CaseInServicePactDetailResources'], function(resources) {return {schemaUId:'28304f1a-3c03-4fa6-aa1e-98fe87b69a03',schemaCaption: "\"Case\" in the section \"Service Pacts\" detail", parentSchemaName: "BaseGridDetailV2", packageName: "CrtSLMITILService7x", schemaName:'CaseInServicePactDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseInServicePactDetail",
	function() {
		return {
			entitySchemaName: "Case",
			attributes: {},
			methods: {

				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				getEditRecordMenuItem: this.Terrasoft.emptyFn,

				getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

				addDetailWizardMenuItems: this.Terrasoft.emptyFn,

				getSwitchGridModeMenuItem: this.Terrasoft.emptyFn,

				getAddRecordButtonVisible: function() {
					return false;
				}
			},
			messages: {}
		};
	});


