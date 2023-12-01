Terrasoft.configuration.Structures["CampaignAddToEventPage"] = {innerHierarchyStack: ["CampaignAddToEventPage"], structureParent: "CampaignBaseEventPage"};
define('CampaignAddToEventPageStructure', ['CampaignAddToEventPageResources'], function(resources) {return {schemaUId:'c8140bf2-2f45-e707-8a93-c4dbafa3d503',schemaCaption: "Edit page for add to event element", parentSchemaName: "CampaignBaseEventPage", packageName: "CrtEventInCampaign7x", schemaName:'CampaignAddToEventPage',parentSchemaUId:'8d3dc052-22b7-c899-0dad-b23308e67487',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Schema of campaign add to event element page
 * Parent: CampaignBaseEventPage
 */
define("CampaignAddToEventPage", [],
	function() {
		return {
			methods: {
				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#getContextHelpCode
				 * @override
				 */
				getContextHelpCode: function() {
					return "CampaignAddToEventElement";
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);


