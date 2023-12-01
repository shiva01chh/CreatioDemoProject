Terrasoft.configuration.Structures["ServiceEngineerDetail"] = {innerHierarchyStack: ["ServiceEngineerDetail"], structureParent: "BaseGridDetailV2"};
define('ServiceEngineerDetailStructure', ['ServiceEngineerDetailResources'], function(resources) {return {schemaUId:'35295ca8-9bee-423d-a79b-7a98afdf9ccd',schemaCaption: "Detail schema - Service team in services section", parentSchemaName: "BaseGridDetailV2", packageName: "CrtSLMITILService7x", schemaName:'ServiceEngineerDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceEngineerDetail", ["terrasoft",
		"ConfigurationGrid", "ConfigurationGridGenerator", "ConfigurationGridUtilities"],
	function(Terrasoft) {
		return {
			attributes: {
				"IsEditable": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": true
				}
			},
			mixins: {
				ConfigurationGridUtilites: "Terrasoft.ConfigurationGridUtilities"
			},
			messages: {},
			methods: {},
			diff: [
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"className": "Terrasoft.ConfigurationGrid",
						"generator": "ConfigurationGridGenerator.generatePartial",
						"generateControlsConfig": {"bindTo": "generateActiveRowControlsConfig"},
						"changeRow": {"bindTo": "changeRow"},
						"unSelectRow": {"bindTo": "unSelectRow"},
						"onGridClick": {"bindTo": "onGridClick"},
						"initActiveRowKeyMap": {"bindTo": "initActiveRowKeyMap"},
						"activeRowActions": [
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "save",
								"markerValue": "save",
								"imageConfig": {"bindTo": "Resources.Images.SaveIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "cancel",
								"markerValue": "cancel",
								"imageConfig": {"bindTo": "Resources.Images.CancelIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "remove",
								"markerValue": "remove",
								"imageConfig": {"bindTo": "Resources.Images.RemoveIcon"}
							}
						],
						"listedZebra": true,
						"activeRowAction": {"bindTo": "onActiveRowAction"}
					}
				}
			]
		};
	});


