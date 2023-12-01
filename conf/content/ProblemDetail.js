Terrasoft.configuration.Structures["ProblemDetail"] = {innerHierarchyStack: ["ProblemDetail"], structureParent: "BaseGridDetailV2"};
define('ProblemDetailStructure', ['ProblemDetailResources'], function(resources) {return {schemaUId:'3864c7e8-affd-44b0-864b-b0460de1f878',schemaCaption: "Detail schema - \"Problems\" section", parentSchemaName: "BaseGridDetailV2", packageName: "Problem", schemaName:'ProblemDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ProblemDetail", ["terrasoft"],
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
				}
			]/**SCHEMA_DIFF*/,
			methods: {},
			messages: {}
		};
	});


