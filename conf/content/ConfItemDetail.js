Terrasoft.configuration.Structures["ConfItemDetail"] = {innerHierarchyStack: ["ConfItemDetail"], structureParent: "BaseGridDetailV2"};
define('ConfItemDetailStructure', ['ConfItemDetailResources'], function(resources) {return {schemaUId:'9a768071-4585-45db-9517-67fd1ed7f16c',schemaCaption: "Detail Schema - Configuration Items", parentSchemaName: "BaseGridDetailV2", packageName: "CMDB", schemaName:'ConfItemDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ConfItemDetail", ["terrasoft"],
function() {
	return {
		entitySchemaName: "ConfItem",
		attributes: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"type": this.Terrasoft.GridType.LISTED,
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "NameListedGridColumn",
								"bindTo": "Name",
								"type": this.Terrasoft.GridCellType.TEXT,
								"position": {
									"column": 0,
									"colSpan": 24
								}
							}
						]
					},
					"tiledConfig": {
						"name": "DataGridTiledConfig",
						"grid": {
							"columns": 24,
							"rows": 1
						},
						"items": [
							{
								"name": "NameTiledGridColumn",
								"bindTo": "Name",
								"type": this.Terrasoft.GridCellType.TEXT,
								"position": {
									"row": 1,
									"column": 0,
									"colSpan": 24
								},
								"captionConfig": {
									"visible": false
								}
							}
						]
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {},
		messages: {}
	};
});


