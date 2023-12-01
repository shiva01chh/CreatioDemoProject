/**
 * Schema of campaign landing element.
 */
define("CampaignLandingSchema", ["CampaignLandingSchemaResources", "CampaignEnums",
		"CampaignBaseAudienceSchema"],
	function(resources, CampaignEnums) {
		/**
		 * @class Terrasoft.manager.CampaignLandingSchema
		 * Schema of base communication element.
		 */
		Ext.define("Terrasoft.manager.CampaignLandingSchema", {
			extend: "Terrasoft.CampaignBaseElementSchema",
			alternateClassName: "Terrasoft.CampaignLandingSchema",

			mixins: {
				campaignElementMixin: "Terrasoft.CampaignElementMixin"
			},

			/**
			 * UId of current manager item.
			 */
			managerItemUId: "7D2A5E47-415A-49DD-A311-3A11FEC1D553",

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#name
			 */
			name: "CampaignLanding",

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
			editPageSchemaName: "CampaignLandingPage",

			/**
			 * Type of element
			 * @type {string}
			 */
			elementType: CampaignEnums.CampaignSchemaElementTypes.CAMPAIGN_LANDING,

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
			 * @protected
			 * @overridden
			 */
			typeName: "Terrasoft.Configuration.CampaignLandingElement, Terrasoft.Configuration",

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
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#nodeType
			 * @override
			 */
			nodeType: Terrasoft.diagram.UserHandlesConstraint.Gateway,

			/**
			 * Identifier of the landing page
			 */
			landingId: null,

			/**
			 * @inheritdoc Terrasoft.manager.ProcessFlowElementSchema#getConnectionUserHandles
			 * @overridden
			 */
			getConnectionUserHandles: function() {
				return ["CampaignSequenceFlow", "LandingConditionalTransition"];
			},

			/**
			 * Clears linked landing when element copy is created.
			 * @inheritdoc Terrasoft.manager.CampaignBaseElementSchema#prepareCopy
			 * @overridden
			 */
			prepareCopy: function() {
				var copy = this.callParent(arguments);
				copy.landingId = null;
				return copy;
			},

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
			 * @overridden
			 */
			getSerializableProperties: function() {
				var baseSerializableProperties = this.callParent(arguments);
				return Ext.Array.push(baseSerializableProperties, ["landingId"]);
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
		return Terrasoft.CampaignLandingSchema;
	});
