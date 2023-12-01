/**
 * Schema of campaign base event element.
 */
define("CampaignBaseEventSchema", ["CampaignBaseEventSchemaResources", "CampaignEnums",
		"CampaignBaseAudienceSchema"],
	function(resources, CampaignEnums) {
		/**
		 * @class Terrasoft.manager.CampaignEventSchema
		 * Schema of base event element.
		 */
		Ext.define("Terrasoft.manager.CampaignBaseEventSchema", {
			extend: "Terrasoft.CampaignBaseAudienceSchema",
			alternateClassName: "Terrasoft.CampaignBaseEventSchema",

			mixins: {
				campaignElementMixin: "Terrasoft.CampaignElementMixin"
			},

			/**
			 * UId of current manager item.
			 */
			managerItemUId: "6fb3d10c-9725-4839-a122-c3112ac2a7e3",

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#name
			 */
			name: "CampaignBaseEvent",

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
			editPageSchemaName: "CampaignBaseEventPage",

			/**
			 * Type of element
			 * @type {string}
			 */
			elementType: CampaignEnums.CampaignSchemaElementTypes.CAMPAIGN_EVENT,

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
			 * @protected
			 * @overridden
			 */
			typeName: "Terrasoft.Configuration.CampaignBaseEventElement, Terrasoft.Configuration",

			/**
			 * Background fill color.
			 * @protected
			 * @type {String}
			 */
			color: "rgba(247, 194, 0, 1)",

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
			 * @overridden
			 */
			width: 55,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#height
			 * @overridden
			 */
			height: 55,

			/**
			 * Identifier of the Event entity in campaign event element
			 */
			eventId: null,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessFlowElementSchema#getConnectionUserHandles
			 * @overridden
			 */
			getConnectionUserHandles: function() {
				return ["CampaignSequenceFlow", "EventConditionalTransition"];
			},

			/**
			 * Clears linked event when element copy is created.
			 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
			 * @overridden
			 */
			prepareCopy: function() {
				var copy = this.callParent(arguments);
				copy.eventId = null;
				return copy;
			},

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
			 * @overridden
			 */
			getSerializableProperties: function() {
				var baseSerializableProperties = this.callParent(arguments);
				return Ext.Array.push(baseSerializableProperties, ["eventId"]);
			}
		});
		return Terrasoft.CampaignBaseEventSchema;
	});
