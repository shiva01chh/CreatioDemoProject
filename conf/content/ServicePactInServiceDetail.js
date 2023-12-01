Terrasoft.configuration.Structures["ServicePactInServiceDetail"] = {innerHierarchyStack: ["ServicePactInServiceDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ServicePactInServiceDetailStructure', ['ServicePactInServiceDetailResources'], function(resources) {return {schemaUId:'de2f7091-0456-40e4-af1c-861fea27873a',schemaCaption: "Detail schema - \"Service contracts\" in \"Services\" section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "CrtSLMITILService7x", schemaName:'ServicePactInServiceDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServicePactInServiceDetail", [],
	function() {
		return {
			entitySchemaName: "ServiceInServicePact",
			methods: {

				/**
				 * Initializes detail parameters.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ServicePact";
					config.sectionEntitySchema = "ServiceItem";
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#init
				 * @overridden
				 **/
				init: function() {
					this.callParent(arguments);
					this.initConfig();
				},
				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "ServicePact";
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "AddRecordButton"
				},
				{
					"operation": "remove",
					"name": "ActionsButton"
				}
			]/**SCHEMA_DIFF*/
		};
	});


