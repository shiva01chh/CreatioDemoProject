Terrasoft.configuration.Structures["ChangeDetail"] = {innerHierarchyStack: ["ChangeDetail"], structureParent: "BaseGridDetailV2"};
define('ChangeDetailStructure', ['ChangeDetailResources'], function(resources) {return {schemaUId:'1d100935-5f74-4b6a-9068-f26255d6a3bd',schemaCaption: "Detail schema - Changes section", parentSchemaName: "BaseGridDetailV2", packageName: "Change", schemaName:'ChangeDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ChangeDetail", ["terrasoft"],
		function() {
			return {
				entitySchemaName: "Change",
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


