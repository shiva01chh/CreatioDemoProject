define("ProcessSplitGatewayTransitionSchema", ["CampaignEnums", "ProcessSplitGatewayTransitionSchemaResources",
		"ProcessCampaignSequenceFlowSchema"],
	function(CampaignEnums) {
		Ext.define("Terrasoft.manager.ProcessSplitGatewayTransitionSchema", {
			extend: "Terrasoft.ProcessCampaignSequenceFlowSchema",
			alternateClassName: "Terrasoft.ProcessSplitGatewayTransitionSchema",

			managerItemUId: "4E725C37-9C37-4072-93CC-F8E0939F6130",

			mixins: {
				parametrizedProcessSchemaElement: "Terrasoft.ParametrizedProcessSchemaElement"
			},

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#typeName
			 * @protected
			 * @overridden
			 */
			typeName: "Terrasoft.Configuration.CampaignSplitGatewayTransitionElement, Terrasoft.Configuration",

			/**
			 * Sequence flow name.
			 * @type {String}
			 */
			connectionUserHandleName: "SplitGatewayTransition",

			/**
			 * @inheritdoc Terrasoft.ProcessBaseElementSchema#editPageSchemaName
			 */
			editPageSchemaName: "CampaignSequenceFlowPropertiesPage",

			/**
			 * Type of element
			 * @type {String}
			 */
			elementType: CampaignEnums.CampaignSchemaElementTypes.CONDITIONAL_TRANSITION,

			/**
			 * Unique key for current transition in current campaign.
			 * @type {Guid}
			 */
			transitionId: null,

			/**
			 * Description text.
			 * @type {String}
			 */
			description: null,

			/**
			 * @inheritdoc Terrasoft.BaseObject#constructor
			 * @override
			 */
			constructor: function() {
				this.transitionId = Terrasoft.generateGUID();
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.configuration.mixins.CampaignElementMixin#getElementSpecificPropertiesNames
			 * @overridden
			 */
			getElementSpecificPropertiesNames: function() {
				return  ["transitionId"];
			},

			/**
			 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
			 * @override
			 */
			getSerializableProperties: function() {
				var baseSerializableProperties = this.callParent(arguments);
				return Ext.Array.push(baseSerializableProperties, ["transitionId"]);
			}
		});
		return Terrasoft.ProcessSplitGatewayTransitionSchema;
	});
