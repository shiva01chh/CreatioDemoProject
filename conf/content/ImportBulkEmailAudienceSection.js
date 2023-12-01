Terrasoft.configuration.Structures["ImportBulkEmailAudienceSection"] = {innerHierarchyStack: ["ImportBulkEmailAudienceSection"], structureParent: "BaseImportAudienceSection"};
define('ImportBulkEmailAudienceSectionStructure', ['ImportBulkEmailAudienceSectionResources'], function(resources) {return {schemaUId:'639ae15c-aa98-1896-9f58-54fe2307b4f2',schemaCaption: "Bulk email audience import page", parentSchemaName: "BaseImportAudienceSection", packageName: "MarketingCampaign", schemaName:'ImportBulkEmailAudienceSection',parentSchemaUId:'822a6930-021d-406c-82ea-57075e9ea68a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ImportBulkEmailAudienceSection", ["ImportBulkEmailAudienceSectionResources"],
	function() {
		return {
			methods: {
				/**
				 * Returns specific config for bulk email audience service to provide import action.
				 * @protected
				 * @param {Number} sourceType Source type for import action.
				 * @param {Array} sourceCollection Source data collection to import.
				 * @param {Number} estimatedCount Estimated records count to import.
				 * @param {String} esqSerialized Serialized esq to filter records for import.
				 * @returns {Object}
				 */
				getImportConfig: function(sourceType, sourceCollection, estimatedCount, esqSerialized) {
					return {
						serviceName: "BulkEmailAudience",
						methodName: "Import",
						data: {
							BulkEmailId: this.$RecordId,
							SourceCollection: sourceCollection || [],
							EstimatedEntitiesCount: estimatedCount || 0,
							SourceType: sourceType,
							AudienceSchemaId: this.audienceSchemaId,
							EsqSerialized: esqSerialized
						}
					};
				}
			},
			diff: []
		};
	}
);


