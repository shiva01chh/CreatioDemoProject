Terrasoft.configuration.Structures["ProblemInCaseDetail"] = {innerHierarchyStack: ["ProblemInCaseDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ProblemInCaseDetailStructure', ['ProblemInCaseDetailResources'], function(resources) {return {schemaUId:'758e3842-7bc3-4a03-b6e8-79dd76cd2b3f',schemaCaption: "Problem in case detail", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Problem", schemaName:'ProblemInCaseDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ProblemInCaseDetail", ["ProblemInCaseDetailResources"],
function() {
	return {
		entitySchemaName: "ProblemInCase",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"rowDataItemMarkerColumnName": "Problem.Number"
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		messages: {},
		methods: {
			/**
			 * @inheritDoc Terrasoft.BaseManyToManyGridDetail#initConfig
			 * @overridden
			 */
			initConfig: function() {
				this.callParent(arguments);
				var config = this.getConfig();
				config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Problem";
				config.sectionEntitySchema = "Case";
				config.lookupConfig.multiselect = true;
			},

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#init
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this.initConfig();
			},

			/**
			 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
			 * @overridden
			 */
			getFilterDefaultColumnName: function() {
				return "Problem";
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
			 * @overridden
			 */
			addDetailWizardMenuItems: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: this.Terrasoft.emptyFn
		}
	};
});


