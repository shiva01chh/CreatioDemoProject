define("CampaignElementSchemaManager", ["CampaignBaseAudienceSchema", "ProcessCampaignSequenceFlowSchema",
		"ProcessCampaignConditionalSequenceFlowSchema", "AddCampaignParticipantSchema", "ExitFromCampaignSchema",
		"CampaignTimerSchema", "CampaignStartSignalSchema", "CampaignAddObjectSchema", "CampaignUpdateObjectSchema",
		"CampaignSplitGatewaySchema", "CampaignDeduplicatorSchema", "ProcessSplitGatewayTransitionSchema"],
	function() {
		Ext.define("Terrasoft.manager.CampaignElementSchemaManager", {
			extend: "Terrasoft.BaseProcessFlowElementSchemaManager",
			alternateClassName: "Terrasoft.CampaignElementSchemaManager",
			singleton: true,

			/**
			 * @inheritdoc Terrasoft.BaseSchemaManager#managerName
			 * @protected
			 * @overridden
			 */
			managerName: "CampaignElementSchemaManager",

			/**
			 * Returns if element can be copied.
			 * @param {Terrasoft.ProcessBaseElementSchema} element Element to be copied.
			 * @return {Boolean} Returns true if element can be copied.
			 */
			allowElementCopy: function(element) {
				return !!(element && element.managerItemUId);
			},

			/**
			 * @inheritdoc Terrasoft.BaseProcessFlowElementSchemaManager#initialize
			 * @protected
			 * @overridden
			 */
			initialize: function() {
				this._initCoreElementClassNames();
				this.callParent(arguments);
			},

			/**
			 * Fills coreElementClassNames property
			 * with default Campaign designer element class names.
			 * @private
			 */
			_initCoreElementClassNames: function() {
				this.coreElementClassNames = _.union([
					{ itemType: "Terrasoft.ProcessLaneSetSchema" },
					{ itemType: "Terrasoft.ProcessCampaignSequenceFlowSchema" },
					{ itemType: "Terrasoft.ProcessCampaignConditionalSequenceFlowSchema" },
					{ itemType: "Terrasoft.ProcessSplitGatewayTransitionSchema" },
					{ itemType: "Terrasoft.AddCampaignParticipantSchema" },
					{ itemType: "Terrasoft.CampaignStartSignalSchema" },
					{ itemType: "Terrasoft.CampaignAddObjectSchema" },
					{ itemType: "Terrasoft.CampaignUpdateObjectSchema" },
					{ itemType: "Terrasoft.CampaignDeduplicatorSchema" },
					{ itemType: "Terrasoft.CampaignSplitGatewaySchema" },
					{ itemType: "Terrasoft.CampaignTimerSchema" },
					{ itemType: "Terrasoft.ExitFromCampaignSchema" }
				], this.coreElementClassNames);
			}
		});
	}
);
