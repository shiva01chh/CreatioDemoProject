Terrasoft.configuration.Structures["TouchActionPage"] = {innerHierarchyStack: ["TouchActionPage"], structureParent: "BasePageV2"};
define('TouchActionPageStructure', ['TouchActionPageResources'], function(resources) {return {schemaUId:'34073f83-ca04-4502-bcfb-4160b4822b28',schemaCaption: "Card schema: \"Web actions\"", parentSchemaName: "BasePageV2", packageName: "CrtTouchPoint7x", schemaName:'TouchActionPage',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("TouchActionPage", [], function() {
	return {
		entitySchemaName: "TouchAction",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ActionDatec8fc4801-3740-4fd3-80de-3354fb2056a4",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "ActionDate",
					"enabled": true
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Typefc0fa9cf-31f3-42c8-99e8-4ad55100821e",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "Header"
					},
					"bindTo": "Type",
					"enabled": true,
					"contentType": 5
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Url67bc6987-fcf1-4e7c-aaf2-0907ad056f55",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "Url"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 2
			}
		]/**SCHEMA_DIFF*/
	};
});


