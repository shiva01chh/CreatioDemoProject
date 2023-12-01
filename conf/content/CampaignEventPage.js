Terrasoft.configuration.Structures["CampaignEventPage"] = {innerHierarchyStack: ["CampaignEventPage"], structureParent: "CampaignBaseEventPage"};
define('CampaignEventPageStructure', ['CampaignEventPageResources'], function(resources) {return {schemaUId:'d6ad5dda-bfe6-4367-9186-93f959d244eb',schemaCaption: "CampaignEventPage", parentSchemaName: "CampaignBaseEventPage", packageName: "CampaignElements.UI", schemaName:'CampaignEventPage',parentSchemaUId:'8d3dc052-22b7-c899-0dad-b23308e67487',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Schema of campaign Event element page
 * Parent: CampaignBaseEventPage
 */
define("CampaignEventPage", [],
	function() {
		return {
			methods: {
				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#getContextHelpCode
				 * @override
				 */
				getContextHelpCode: function() {
					return "CampaignEventElement";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


