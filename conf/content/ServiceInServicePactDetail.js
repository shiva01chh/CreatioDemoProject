Terrasoft.configuration.Structures["ServiceInServicePactDetail"] = {innerHierarchyStack: ["ServiceInServicePactDetail"], structureParent: "BaseManyToManyGridDetail"};
define('ServiceInServicePactDetailStructure', ['ServiceInServicePactDetailResources'], function(resources) {return {schemaUId:'8e9e8077-4265-4871-9f9b-d2fbfabf9df9',schemaCaption: "Detail schema - Services in service contract section", parentSchemaName: "BaseManyToManyGridDetail", packageName: "CrtSLMITILService7x", schemaName:'ServiceInServicePactDetail',parentSchemaUId:'2ff3b2fa-5b9d-4e9a-8831-ce498329d553',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceInServicePactDetail", [],
	function() {
		return {
			entitySchemaName: "ServiceInServicePact",
			methods: {
				/**
				 * ############## ######### ######.
				 */
				initConfig: function() {
					this.callParent(arguments);
					var config = this.getConfig();
					config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "ServiceItem";
					config.sectionEntitySchema = "ServicePact";
				},
				/**
				 * ######### #############.
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
					return "ServiceItem";
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "EditRecordMenu",
					"parentName": "ActionsButton",
					"propertyName": "menu",
					"index": 0,
					"values": {
						"caption": {"bindTo": "Resources.Strings.EditMenuCaption"},
						"click": {"bindTo": "editRecord"},
						"enabled": {"bindTo": "getEditRecordButtonEnabled"}

					}
				}
			]/**SCHEMA_DIFF*/
		};
	});


