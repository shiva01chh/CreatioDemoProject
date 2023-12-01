Terrasoft.configuration.Structures["ProblemInServiceItemDetail"] = {innerHierarchyStack: ["ProblemInServiceItemDetail"], structureParent: "BaseGridDetailV2"};
define('ProblemInServiceItemDetailStructure', ['ProblemInServiceItemDetailResources'], function(resources) {return {schemaUId:'094af9ba-c5fd-454d-bf85-5b5186d8683c',schemaCaption: "Detail schema - Problems in services section", parentSchemaName: "BaseGridDetailV2", packageName: "Problem", schemaName:'ProblemInServiceItemDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ProblemInServiceItemDetail",
	function() {
		return {
			entitySchemaName: "Problem",
			attributes: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"type": "listed",
						"listedConfig": {
							"name": "DataGridListedConfig",
							"items": [
								{
									"name": "NameListedGridColumn",
									"bindTo": "Name",
									"type": "text",
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
									"type": "text",
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
				},
				{
					"operation": "remove",
					"name": "CopyRecordMenu"
				},
				{
					"operation": "remove",
					"name": "EditRecordMenu"
				}
			]/**SCHEMA_DIFF*/,
			methods: {},
			messages: {}
		};
	});


