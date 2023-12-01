Terrasoft.configuration.Structures["ConfItemInContactDetail"] = {innerHierarchyStack: ["ConfItemInContactDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ConfItemInContactDetailStructure', ['ConfItemInContactDetailResources'], function(resources) {return {schemaUId:'598b1ddf-2956-4b3d-b884-46ca201a0bfa',schemaCaption: "Detail schema - Configuration items in Contacts section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "CMDB", schemaName:'ConfItemInContactDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemInContactDetail", ["ServiceDeskConstants"],
	function(ServiceDeskConstants) {
		return {
			entitySchemaName: "ConfItemUser",
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseManyToManyGridDetail#initConfig
				 * @overridden
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ConfItem";
					config.sectionEntitySchema = "Contact";
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initConfig();
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "ConfItem";
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseManyToManyGridDetail#getSchemaInsertQuery
				 * @overridden
				 */
				getSchemaInsertQuery: function() {
					var insert = this.callParent(arguments);
					insert.setParameterValue("Type", ServiceDeskConstants.ServiceObjectType.Contact,
						this.Terrasoft.DataValueType.GUID);
					return insert;
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


