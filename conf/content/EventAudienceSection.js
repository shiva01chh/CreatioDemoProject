Terrasoft.configuration.Structures["EventAudienceSection"] = {innerHierarchyStack: ["EventAudienceSection"], structureParent: "BaseManageAudienceSection"};
define('EventAudienceSectionStructure', ['EventAudienceSectionResources'], function(resources) {return {schemaUId:'5d820006-f7e0-cea0-74e5-3965ce311bd9',schemaCaption: "Section to manage event audience", parentSchemaName: "BaseManageAudienceSection", packageName: "MarketingCampaign", schemaName:'EventAudienceSection',parentSchemaUId:'3f3e590a-d695-4b60-a585-24f7c571a320',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
 define("EventAudienceSection", ["EventAudienceSectionResources"],
	function() {
		return {
			entitySchemaName: "EventTarget",
			properties: {
				masterRecordEntitySchemaName: "Event",
				rowsLimitForQuickQueue: 20
			},
			methods: {
				/**
				 * Returns specific config for event audience service to provide remove audience action.
				 * @protected
				 * @param {Number} sourceType Source type for remove action.
				 * @param {Array} sourceCollection Source data collection to remove.
				 * @param {Number} estimatedCount Estimated records count to remove.
				 * @param {String} esqSerialized Serialized esq to filter records for remove.
				 * @returns {Object}
				 */
				getRemoveAudienceConfig: function(sourceType, sourceCollection, estimatedCount, esqSerialized) {
					return {
						serviceName: "EventAudience",
						methodName: "Remove",
						data: {
							EventId: this.$RecordId,
							SourceCollection: sourceCollection || [],
							EstimatedEntitiesCount: estimatedCount || 0,
							SourceType: sourceType,
							EsqSerialized: esqSerialized
						}
					};
				},

				/**
				 * Handler on WebSocket channel message received event.
				 * @inheritdoc Terrasoft.BaseManageAudienceSection#onChannelMessageReceived
				 * @override
				 */
				onChannelMessageReceived: function(channel, message) {
					if (message.Header.Sender !== "EventQueueMessageNotifier") {
						return;
					}
					var messageBody = Terrasoft.decode(message.Body);
					if (messageBody.EventId === this.$RecordId) {
						this.updateSection();
					}
				}
			},
			diff: []
		};
	}
);


