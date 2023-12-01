 define("CampaignDeduplicatorSchema", ["CampaignDeduplicatorSchemaResources",
	"CampaignEnums", "CampaignBaseElementSchema", "CampaignElementMixin"],
		function(resources, CampaignEnums) {
	/**
	 * @class Terrasoft.manager.CampaignDeduplicatorSchema
	 * Schema of deduplicator element.
	 */
	Ext.define("Terrasoft.manager.CampaignDeduplicatorSchema", {
		extend: "Terrasoft.CampaignBaseElementSchema",
		alternateClassName: "Terrasoft.CampaignDeduplicatorSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "155B4655-38D5-486C-95DE-BF77FD5218EA",

		/**
		 * @inheritdoc Terrasoft.manager.CampaignStartSignalSchema#name
		 */
		name: "CampaignDeduplicator",

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#caption
		 */
		caption: resources.localizableStrings.Caption,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#TitleImage
		 */
		titleImage: resources.localizableImages.TitleImage,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#LargeImage
		 */
		largeImage: resources.localizableImages.LargeImage,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#SmallImage
		 */
		smallImage: resources.localizableImages.SmallImage,

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
		 */
		editPageSchemaName: "CampaignDeduplicatorPage",

		/**
		 * Type of element
		 * @type {string}
		 */
		elementType: CampaignEnums.CampaignSchemaElementTypes.CAMPAIGN_DEDUPLICATOR,

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
		 * @override
		 */
		typeName: "Terrasoft.Configuration.CampaignDeduplicatorElement, Terrasoft.Configuration",

		/**
		 * Background fill color.
		 * @protected
		 * @type {String}
		 */
		color: "rgba(132, 157, 195, 1)",

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
		 * @overridden
		 */
		width: 69,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#height
		 * @overridden
		 */
		height: 55,

		/**
		 * Identifier of the entity schema
		 */
		entitySchemaUId: null,

		/**
		 * Path to column duplicates search by.
		 * @type {String}
		 */
		columnPath: null,

		/**
		 * Flag to indicate that element can suspend participants with empty column values.
		 * @type {Boolean}
		 */
		suspendParticipantsWithEmptyValues: false,

		/**
		 * @inheritdoc Terrasoft.CampaignBaseElementSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["entitySchemaUId", "columnPath",
				"suspendParticipantsWithEmptyValues"]);
		},

		/**
		 * @inheritdoc CampaignBaseElementSchema#validate
		 * @override
		 */
		validate: function() {
			var results = Ext.create("Terrasoft.Collection");
			if (this.getIncomingSequenceFlows().length === 0) {
				results.add(CampaignEnums.CampaignFlowSchemaValidationRules.ASYNC_WITHOUT_INCOMINGS,
					resources.localizableStrings.AsyncWithoutIncomingsMessage);
			}
			return results;
		}
	});
	return Terrasoft.CampaignDeduplicatorSchema;
});
