define("PortalCaseSectionActionsDashboard", ["CaseSectionActionsDashboard",
		"PortalCaseSectionActionsDashboardResources", "DcmSectionActionsDashboardMixin"],
	function() {
		return {
			attributes: {},
			messages: {},
			mixins: {
				DcmSectionActionsDashboardMixin: "Terrasoft.DcmSectionActionsDashboardMixin"
			},
			methods: {
				/**
				 * @inheritDoc Terrasoft.DcmSectionActionsDashboardMixin#setDcmAvailableStages
				 * @overridden
				 */
				setDcmAvailableStages: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseActionsDashboard#initDefaultTab
				 * @override
				 */
				initDefaultTab: function() {
					this.set("DefaultTabName", "PortalMessageTab");
					this.callParent(arguments);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "CallMessageTab"
				},
				{
					"operation": "remove",
					"name": "EmailMessageTab"
				},
				{
					"operation": "remove",
					"name": "SocialMessageTab"
				},
				{
					"operation": "remove",
					"name": "TaskMessageTab"
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
