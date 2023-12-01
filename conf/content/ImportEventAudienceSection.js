Terrasoft.configuration.Structures["ImportEventAudienceSection"] = {innerHierarchyStack: ["ImportEventAudienceSection"], structureParent: "BaseImportAudienceSection"};
define('ImportEventAudienceSectionStructure', ['ImportEventAudienceSectionResources'], function(resources) {return {schemaUId:'53858246-2996-b4d9-d5b6-9d3c1a9e1817',schemaCaption: "Event audience import page", parentSchemaName: "BaseImportAudienceSection", packageName: "MarketingCampaign", schemaName:'ImportEventAudienceSection',parentSchemaUId:'822a6930-021d-406c-82ea-57075e9ea68a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ImportEventAudienceSection", ["ImportEventAudienceSectionResources"],
	function() {
		return {
			entitySchemaName: "Contact",
			properties: {
				rowsLimitForQuickQueue: 20
			},
			methods: {
				/**
				 * Returns specific config for event audience service to provide import action.
				 * @protected
				 * @param {Number} sourceType Source type for import action.
				 * @param {Array} sourceCollection Source data collection to import.
				 * @param {Number} estimatedCount Estimated records count to import.
				 * @param {String} esqSerialized Serialized esq to filter records for import.
				 * @returns {Object}
				 */
				getImportConfig: function(sourceType, sourceCollection, estimatedCount, esqSerialized) {
					return {
						serviceName: "EventAudience",
						methodName: "Import",
						data: {
							EventId: this.$RecordId,
							SourceCollection: sourceCollection || [],
							EstimatedEntitiesCount: estimatedCount || 0,
							SourceType: sourceType,
							EsqSerialized: esqSerialized
						}
					};
				}
			},
			diff: []
		};
	}
);


