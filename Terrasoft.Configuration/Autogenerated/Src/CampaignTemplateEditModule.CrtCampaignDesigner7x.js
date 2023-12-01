/**
 * Module to load CampaignTemplateEditPage.
 */
define("CampaignTemplateEditModule", ["BaseSchemaModuleV2"], function() {
	Ext.define("Terrasoft.configuration.CampaignTemplateEditModule", {
		extend: "Terrasoft.BaseSchemaModule",
		alternateClassName: "Terrasoft.CampaignTemplateEditModule",

		sandbox: null,
		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#generateViewContainerId
		 * @override
		 */
		generateViewContainerId: false,

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initSchemaName
		 * @override
		 */
		initSchemaName: function() {
			this.schemaName = "CampaignTemplateEditPage";
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaModule#initHistoryState
		 * @override
		 */
		initHistoryState: Terrasoft.emptyFn
	});
	return Terrasoft.CampaignTemplateEditModule;
});
