/**
 * Schema of campaign event element.
 */
define("CampaignEventSchema", ["CampaignEventSchemaResources", "CampaignEnums",
		"CampaignBaseEventSchema"],
	function(resources, CampaignEnums) {
		/**
		 * @class Terrasoft.manager.CampaignEventSchema
		 * Schema of event element.
		 */
		Ext.define("Terrasoft.manager.CampaignEventSchema", {
			extend: "Terrasoft.CampaignBaseEventSchema",
			alternateClassName: "Terrasoft.CampaignEventSchema",

			mixins: {
				campaignElementMixin: "Terrasoft.CampaignElementMixin"
			},

			/**
			 * UId of current manager item.
			 */
			managerItemUId: "952B9FDB-9152-4F93-95C6-E20AE37E000C",

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#name
			 */
			name: "CampaignEvent",

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
			 * Type of element
			 * @type {string}
			 */
			elementType: CampaignEnums.CampaignSchemaElementTypes.CAMPAIGN_EVENT,

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
			 * @protected
			 * @overidde
			 */
			typeName: "Terrasoft.Configuration.CampaignEventElement, Terrasoft.Configuration",

						/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
			 */
			editPageSchemaName: "CampaignEventPage",

			/**
			 * Background fill color.
			 * @protected
			 * @type {String}
			 */
			color: "rgba(247, 194, 0, 1)"
		});
		return Terrasoft.CampaignEventSchema;
	});
