 define("BaseCommunicationDetail", [],
	function() {
		return {
			attributes: {},
			messages: {},
			methods: {

				/**
				 * Detail initialization. 
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#init
				 * @overridden
				 */
				init: function() {
					var args = arguments;
					var parentMethod = this.getParentMethod();
					Terrasoft.SysSettings.querySysSettingsItem("UseTheSalesReadyLeadLifecycle", function(value) {
						this.set("UseDESCOrder", value);
						parentMethod.apply(this, args);
					}, this);
				}
			}
		};
	});
