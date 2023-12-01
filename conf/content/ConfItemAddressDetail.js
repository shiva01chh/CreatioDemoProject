Terrasoft.configuration.Structures["ConfItemAddressDetail"] = {innerHierarchyStack: ["ConfItemAddressDetail"], structureParent: "BaseGridDetailV2"};
define('ConfItemAddressDetailStructure', ['ConfItemAddressDetailResources'], function(resources) {return {schemaUId:'5caa766b-a9a6-432f-9ab8-3923078422f0',schemaCaption: "Configuration item location detail", parentSchemaName: "BaseGridDetailV2", packageName: "CMDB", schemaName:'ConfItemAddressDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemAddressDetail", [],
	function() {
		return {
			entitySchemaName: "ConfItemAddress",
			messages: {},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,
				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
				 * @overridden
				 */
				getDeleteRecordMenuItem: this.Terrasoft.emptyFn,
				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "Address";
				}
			},
			diff: []
		};
	}
);


