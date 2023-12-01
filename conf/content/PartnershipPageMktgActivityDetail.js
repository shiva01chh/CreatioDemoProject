Terrasoft.configuration.Structures["PartnershipPageMktgActivityDetail"] = {innerHierarchyStack: ["PartnershipPageMktgActivityDetail"], structureParent: "BaseGridDetailV2"};
define('PartnershipPageMktgActivityDetailStructure', ['PartnershipPageMktgActivityDetailResources'], function(resources) {return {schemaUId:'9304a6e1-1da1-4ac6-9955-a22349774b6b',schemaCaption: "MktgActivity - detail", parentSchemaName: "BaseGridDetailV2", packageName: "PRMMktgActivitiesPortal", schemaName:'PartnershipPageMktgActivityDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PartnershipPageMktgActivityDetail", [], function() {
	return {
		entitySchemaName: "MktgActivity",
		mixins: {},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {

			/**
			 * Checks if current user is Ssp user.
			 * @private
			 * @return {Boolean} True if type of current user is ssp, otherwise - false.
			 */
			_isSspCurrentUser: function() {
				return Terrasoft.utils.common.isCurrentUserSsp();
			},

			/**
			 * @inheritDoc BaseGridDetailV2#getAddRecordButtonVisible
			 * @protected
			 */
			getAddRecordButtonVisible: function() {
				return !this._isSspCurrentUser();
			},

			getEditRecordMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},
			
			getCopyRecordMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},
			
			getDeleteRecordMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},
			
			getRecordRightsSetupMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getSwitchGridModeMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getExportToExcelFileMenuItem: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getShowQuickFilterButton: function() {
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			}
		}
	};
});


