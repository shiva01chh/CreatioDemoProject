define("CampaignStartLandingSchema", ["CampaignStartLandingSchemaResources",
	"CampaignEnums", "CampaignStartSignalSchema", "CampaignElementMixin"],
		function(resources, CampaignEnums) {
	/**
	 * @class Terrasoft.manager.CampaignStartLandingSchema
	 * Schema of start landing element.
	 */
	Ext.define("Terrasoft.manager.CampaignStartLandingSchema", {
		extend: "Terrasoft.CampaignStartSignalSchema",
		alternateClassName: "Terrasoft.CampaignStartLandingSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "3A5EC15A-A0C1-42B3-A0C2-2B8CC975E337",

		/**
		 * @inheritdoc Terrasoft.manager.CampaignStartSignalSchema#name
		 */
		name: "CampaignStartLanding",

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
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#editPageSchemaName
		 */
		editPageSchemaName: "CampaignStartLandingPage",

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#typeName
		 * @override
		 */
		typeName: "Terrasoft.Configuration.CampaignStartLandingElement, Terrasoft.Configuration",

		/**
		 * @override
		 * @type {enum}
		 */
		entitySignal: Terrasoft.EntityChangeType.Inserted,

		/**
		 * @override
		 * @type {Boolean}
		 */
		hasEntityFilters: true,

		/**
		 * @override
		 * @type {String}
		 */
		entityFilters: null,

		/**
		 * Identifier of the landing page
		 */
		landingId: null,

		/**
		 * Clears linked landing when element copy is created.
		 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
		 * @override
		 */
		prepareCopy: function() {
			var copy = this.callParent(arguments);
			copy.entityFilters = null;
			copy.landingId = null;
			return copy;
		},

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["landingId"]);
		},

		/**
		 * @inheritdoc Terrasoft.CampaignBaseElementSchema#getElementMarkers
		 * @override
		 */
		getElementMarkers: function() {
			var markers = {};
			if (this.isRecurring) {
				markers.recurring = { name: "Recurring" };
			}
			return markers;
		},

		/**
		 * @inheritDoc Terrasoft.CampaignBaseElementSchema#initTitleImage
		 * @override
		 */
		initTitleImage: function() {
			this.titleImage = this.isRecurring
				? resources.localizableImages.TitleIsRecurringImage
				: resources.localizableImages.TitleImage;
		}
	});
	return Terrasoft.CampaignStartLandingSchema;
});
