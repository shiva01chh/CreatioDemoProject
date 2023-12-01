define("SalesReadyLeadLifecycleMixin", [],
	function() {
		Ext.define("Terrasoft.configuration.mixins.SalesReadyLeadLifecycleMixin", {
			alternateClassName: "Terrasoft.SalesReadyLeadLifecycleMixin",

			//region Methods: Protected

			/**
			 * Loads value of system setting.
			 * @protected
			 */
			loadSalesReadyLeadLifecycleSysSetting: function(callback, scope) {
				this.Terrasoft.SysSettings.querySysSettingsItem(["UseTheSalesReadyLeadLifecycle"], function(value) {
					this.set("UseTheSalesReadyLeadLifecycle", value)
					this.Ext.callback(callback, scope);
				}, this);
			},

			//endregion
		});
	});
