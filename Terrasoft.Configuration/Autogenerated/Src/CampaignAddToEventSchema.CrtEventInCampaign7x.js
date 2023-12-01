/**
 * Schema of campaign add to event element.
 */
define("CampaignAddToEventSchema", ["CampaignAddToEventSchemaResources", "CampaignEnums",
		"CampaignBaseEventSchema"],
	function(resources, CampaignEnums) {
		/**
		 * @class Terrasoft.manager.CampaignAddToEventSchema
		 * Schema of add to event element.
		 */
		Ext.define("Terrasoft.manager.CampaignAddToEventSchema", {
			extend: "Terrasoft.CampaignBaseEventSchema",
			alternateClassName: "Terrasoft.CampaignAddToEventSchema",

			/**
			 * UId of current manager item.
			 */
			managerItemUId: "233d5c17-4274-445e-af00-5bf68afc4e4e",

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#name
			 */
			name: "CampaignAddToEvent",

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
			 * @override
			 */
			typeName: "Terrasoft.Configuration.CampaignAddToEventElement, Terrasoft.Configuration",

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
			 */
			editPageSchemaName: "CampaignAddToEventPage",

			/**
			 * Background fill color.
			 * @protected
			 * @type {String}
			 */
			color: "rgba(131, 157, 195, 1)",

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#width
			 * @override
			 */
			width: 69,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessBaseElementSchema#nodeType
			 * @override
			 */
			nodeType: Terrasoft.diagram.UserHandlesConstraint.Node,

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
		return Terrasoft.CampaignAddToEventSchema;
	});
