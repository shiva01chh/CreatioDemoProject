define("CampaignStartEventSchema", ["CampaignStartEventSchemaResources",
	"CampaignEnums", "CampaignStartSignalSchema", "CampaignElementMixin"],
		function(resources, CampaignEnums) {
	/**
	 * @class Terrasoft.manager.CampaignStartEventSchema
	 * Schema of start event element.
	 */
	Ext.define("Terrasoft.manager.CampaignStartEventSchema", {
		extend: "Terrasoft.CampaignStartSignalSchema",
		alternateClassName: "Terrasoft.CampaignStartEventSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "2A30D844-0DC9-42FC-9F02-B7D5A3FABB97",

		/**
		 * @inheritdoc Terrasoft.manager.CampaignStartSignalSchema#name
		 */
		name: "CampaignStartEvent",

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
		editPageSchemaName: "CampaignStartEventPage",

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#typeName
		 * @override
		 */
		typeName: "Terrasoft.Configuration.CampaignStartEventElement, Terrasoft.Configuration",

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
		 * Identifier of the event page
		 */
		eventId: null,

		/**
		 * Clears linked landing when element copy is created.
		 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
		 * @override
		 */
		prepareCopy: function() {
			var copy = this.callParent(arguments);
			copy.entityFilters = null;
			copy.eventId = null;
			return copy;
		},

		/**
		 * @inheritdoc Terrasoft.CampaignStartSignalSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["eventId"]);
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
	return Terrasoft.CampaignStartEventSchema;
});
