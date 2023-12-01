define("PortalLeadSectionActionsDashboard", ["LeadSectionActionsDashboard",
		"PortalLeadSectionActionsDashboardResources"],
	function() {
		return {
			attributes: {
				/**
				 * Usage state of dashboard.
				 */
				"UseDashboard": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: this.Terrasoft.Features.getIsEnabled("UsePortalLeadPageDashboard")
				}
			},
			methods: {

				/**
				 * @override Terrasoft.BaseActionsDashboard
				 */
				initDefaultTab: function() {
					if (this.isNeedLockDefaultTab()) {
						this.set("DefaultTabName");
						return;
					}
					this.callParent(arguments);
				},

				/**
				 * Checks if need lock default tab.
				 * @return {Boolean}
				 */
				isNeedLockDefaultTab: function() {
					var defaultTabName = this.getDefaultTabName();
					var dashboardTabName = this.get("DashboardTabName");
					var isFeatureEnabled = this.Terrasoft.Features.getIsEnabled("UsePortalLeadPageDashboard");
					return !isFeatureEnabled && defaultTabName === dashboardTabName;
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
					"name": "TaskMessageTab"
				},
				{
					"operation": "remove",
					"name": "SocialMessageTab"
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
