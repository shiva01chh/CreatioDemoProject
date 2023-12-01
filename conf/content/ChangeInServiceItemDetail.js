Terrasoft.configuration.Structures["ChangeInServiceItemDetail"] = {innerHierarchyStack: ["ChangeInServiceItemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ChangeInServiceItemDetailStructure', ['ChangeInServiceItemDetailResources'], function(resources) {return {schemaUId:'4ef73b8b-af79-4c62-9873-7c334cd3b47c',schemaCaption: "Detail schema - Changes in Services section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "Change", schemaName:'ChangeInServiceItemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ChangeInServiceItemDetail", [],
		function() {
			return {
				entitySchemaName: "ChangeServiceItem",
				methods: {
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
					 * @overridden
					 */
					getCopyRecordMenuItem: this.Terrasoft.emptyFn,
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
					 * @overridden
					 */
					getEditRecordMenuItem: this.Terrasoft.emptyFn,
					/**
					 * Initialize detail config.
					 */
					initConfig: function() {
						this.callParent(arguments);
						var config = this.getConfig();
						config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Change";
						config.sectionEntitySchema = "ServiceItem";
					},
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#init
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
						return "Change";
					}
				},
				diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
			};
		});


