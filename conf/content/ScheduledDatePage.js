Terrasoft.configuration.Structures["ScheduledDatePage"] = {innerHierarchyStack: ["ScheduledDatePage"], structureParent: "BasePageV2"};
define('ScheduledDatePageStructure', ['ScheduledDatePageResources'], function(resources) {return {schemaUId:'5d629be7-bd36-4603-bf53-b4e6f3d40419',schemaCaption: "Edit page - Scheduling", parentSchemaName: "BasePageV2", packageName: "Release", schemaName:'ScheduledDatePage',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ScheduledDatePage", ["BusinessRuleModule"],
	function(BusinessRuleModule) {
		return {
			entitySchemaName: "ScheduledDate",
			attributes: {
				"StartDate": {
					dependencies: [
						{
							columns: ["EndDate"],
							methodName: "onEndDateChanged"
						}
					]
				},
				"EndDate": {
					dependencies: [
						{
							columns: ["StartDate"],
							methodName: "onStartDateChanged"
						}
					]
				}
			},
			methods: {
				onEndDateChanged: function() {
					var endDate = this.get("EndDate");
					if (this.get("StartDate") < endDate) {
						return;
					}

					this.set("StartDate", endDate);
				},
				onStartDateChanged: function() {
					var startDate = this.get("StartDate");
					if (startDate < this.get("EndDate")) {
						return;
					}

					this.set("EndDate", startDate);
				}
			},
			rules: {
				"Status": {
					"NotFinal": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "IsFinal",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.CONSTANT,
						"value": false
					},
					"NotDefault": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"baseAttributePatch": "Id",
						"comparisonType": this.Terrasoft.ComparisonType.NOT_EQUAL,
						"type": BusinessRuleModule.enums.ValueType.SYSSETTING,
						"value": "ReleaseStatusDef"
					}
				}
			}
		};
	});


