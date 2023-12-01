Terrasoft.configuration.Structures["CaseInProblemDetail"] = {innerHierarchyStack: ["CaseInProblemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('CaseInProblemDetailStructure', ['CaseInProblemDetailResources'], function(resources) {return {schemaUId:'5a01143c-7beb-4d34-b3dd-61e89290764b',schemaCaption: "Case in problem detail", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Problem", schemaName:'CaseInProblemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseInProblemDetail", ["CaseInProblemDetailResources"],
function() {
	return {
		entitySchemaName: "ProblemInCase",
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
				config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Case";
				config.sectionEntitySchema = "Problem";
				config.lookupConfig.multiselect = true;
				config.lookupConfig.hideActions = true;
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
				return "Case";
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


