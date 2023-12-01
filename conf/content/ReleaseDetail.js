Terrasoft.configuration.Structures["ReleaseDetail"] = {innerHierarchyStack: ["ReleaseDetail"], structureParent: "BaseGridDetailV2"};
define('ReleaseDetailStructure', ['ReleaseDetailResources'], function(resources) {return {schemaUId:'f15c8932-c6f8-41e5-991a-8a17dd187404',schemaCaption: "Detail schema - \"Releases\" section", parentSchemaName: "BaseGridDetailV2", packageName: "Release", schemaName:'ReleaseDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ReleaseDetail", ["terrasoft"],
		function() {
			return {
				entitySchemaName: "Release",
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


