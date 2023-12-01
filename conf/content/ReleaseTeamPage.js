Terrasoft.configuration.Structures["ReleaseTeamPage"] = {innerHierarchyStack: ["ReleaseTeamPage"], structureParent: "BasePageV2"};
define('ReleaseTeamPageStructure', ['ReleaseTeamPageResources'], function(resources) {return {schemaUId:'ab99196f-06e3-485a-8268-54ad1ece18f4',schemaCaption: "Edit page - Release page", parentSchemaName: "BasePageV2", packageName: "Release", schemaName:'ReleaseTeamPage',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ReleaseTeamPage", ["BusinessRuleModule", "BaseFiltersGenerateModule"],
	function(BusinessRuleModule, BaseFiltersGenerateModule) {
		return {
			entitySchemaName: "ReleaseTeam",
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


