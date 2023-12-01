Terrasoft.configuration.Structures["CaseConfItemDetail"] = {innerHierarchyStack: ["CaseConfItemDetail"], structureParent: "BaseManyToManyGridDetail"};
define('CaseConfItemDetailStructure', ['CaseConfItemDetailResources'], function(resources) {return {schemaUId:'e4356b91-4801-4239-be92-fb22a28b9976',schemaCaption: "Detail schema - Cases in configuration items", parentSchemaName: "BaseManyToManyGridDetail", packageName: "CMDB", schemaName:'CaseConfItemDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseConfItemDetail", [],
	function() {
		return {
			entitySchemaName: "ConfItemInCase",
			diff: [
				{
					"operation": "remove",
					"name": "AddRecordButton"
				}
			],
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
				 * Initialize details config.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Case";
					config.sectionEntitySchema = "ConfItem";
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
					return "Case";
				}
			}
		};
	});


