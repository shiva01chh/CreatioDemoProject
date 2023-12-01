Terrasoft.configuration.Structures["AddCampaignParticipantSchema"] = {innerHierarchyStack: ["AddCampaignParticipantSchema"]};
define("AddCampaignParticipantSchema", ["AddCampaignParticipantSchemaResources",
	"CampaignEnums", "CampaignBaseAudienceSchema", "CampaignElementMixin"],
		function(resources, CampaignEnums) {
	/**
	 * @class Terrasoft.manager.AddCampaignParticipantSchema
	 * Schema of base audience element.
	 */
	Ext.define("Terrasoft.manager.AddCampaignParticipantSchema", {
		extend: "Terrasoft.CampaignBaseAudienceSchema",
		alternateClassName: "Terrasoft.AddCampaignParticipantSchema",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin"
		},

		/**
		 * UId of current manager item.
		 */
		managerItemUId: "bbd2372a-66c0-4e4c-9f38-3aeae2e78c66",

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#name
		 */
		name: "AddAudience",

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
		editPageSchemaName: "AddCampaignParticipantPage",

		/**
		 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
		 * @override
		 */
		typeName: "Terrasoft.Configuration.AddCampaignParticipantElement, Terrasoft.Configuration",

		/**
		 * Type of element
		 * @type {string}
		 */
		elementType: CampaignEnums.CampaignSchemaElementTypes.ADD_AUDIENCE,

		/**
		 * Background fill color.
		 * @protected
		 * @type {String}
		 */
		color: "rgba(101, 215, 144, 1)",

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
		 * @override
		 */
		width: 55,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#height
		 * @override
		 */
		height: 55,

		/**
		 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#incomingConnectionsLimit
		 * @override
		 */
		incomingConnectionsLimit: 0,

		/**
		 * FolderId from which participants should be added into campaign.
		 * @type {String}
		 */
		folderId: null,

		/**
		 * Search data string to filter imported audience.
		 * @type {String}
		 */
		filter: null,

		/**
		 * Flag to indicate that audience import is provided by filter.
		 * @type {Boolean}
		 */
		hasFilter: false,

		/**
		 * Flag to indicate that element can do recurring participants add.
		 * @type {Boolean}
		 */
		isRecurring: false,

		/**
		 * Number of days before participant will be added next time.
		 * @type {Number}
		 */
		recurringFrequencyInDays: null,

		/**
		 * AudienceSchemaId of objects to be added into campaign.
		 * @type {String}
		 */
		audienceSchemaId: null,

		/**
		 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
		 * @override
		 */
		getSerializableProperties: function() {
			var baseSerializableProperties = this.callParent(arguments);
			return Ext.Array.push(baseSerializableProperties, ["folderId", "recurringFrequencyInDays", "isRecurring",
				"filter", "hasFilter", "audienceSchemaId"]);
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
			if (this.hasFilter && !Ext.isEmpty(this.filter)) {
				markers.filter = { name: "AddFilter" };
			}
			if (!this.hasFilter && !Ext.isEmpty(this.folderId)) {
				markers.folder = { name: "AddFolder" };
			}
			return markers;
		},

		/**
		 * @inheritDoc Terrasoft.CampaignBaseElementSchema#initTitleImage
		 * @override
		 */
		initTitleImage: function() {
			if (this.hasFilter && !Ext.isEmpty(this.filter)) {
				this.titleImage = this.isRecurring
					? resources.localizableImages.TitleHasFilterIsRecurringImage
					: resources.localizableImages.TitleHasFilterImage;
			} else if (!this.hasFilter && !Ext.isEmpty(this.folderId)) {
				this.titleImage = this.isRecurring
					? resources.localizableImages.TitleRecurringWithFolderImage
					: resources.localizableImages.TitleWithFolderImage;
			} else {
				this.titleImage = this.isRecurring
					? resources.localizableImages.TitleIsRecurringImage
					: resources.localizableImages.TitleImage;
			}
		},

		/**
		 * @inheritDoc Terrasoft.CampaignBaseElementSchema#initLargeImage
		 * @override
		 */
		initLargeImage: function() {
			this.largeImage = this.isRecurring
				? resources.localizableImages.LargeIsRecurringImage
				: resources.localizableImages.LargeImage;
		},

		/**
		 * @inheritdoc CampaignBaseElementSchema#validate
		 * @override
		 */
		validate: function() {
			var results = Ext.create("Terrasoft.Collection");
			if (this.getOutgoingsSequenceFlows().length === 0) {
				results.add(CampaignEnums.CampaignFlowSchemaValidationRules.ADD_AUDIENCE_WITHOUT_OUTGOINGS,
					resources.localizableStrings.AddAudienceWithoutOutgoingsMessage);
			}
			return results;
		}
	});
	return Terrasoft.AddCampaignAudienceSchema;
});


