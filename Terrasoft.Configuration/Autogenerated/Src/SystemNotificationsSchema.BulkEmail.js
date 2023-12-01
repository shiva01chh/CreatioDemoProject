define("SystemNotificationsSchema", ["TagConstantsV2", "ModuleUtils", "FileImportServiceRequest",
		"css!SystemNotificationsSchemaCSS"], function(TagConstantsV2, ModuleUtils) {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				var loaderName = this.get("LoaderName");
				if (loaderName !== "ActualizeActiveContactsProcess") {
					this.callParent(arguments);
					return;
				}
				var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "Nui",
					"ViewModule.aspx#DashboardsModule");
				window.open(url, "_blank");
			}
		
		},
		diff: []
	};
});
