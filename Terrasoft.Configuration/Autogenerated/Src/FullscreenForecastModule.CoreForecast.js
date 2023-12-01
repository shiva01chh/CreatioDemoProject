define("FullscreenForecastModule", ["ForecastLczResourcesResources", "BaseSchemaModuleV2", "FullscreenForecastTab"],
	function(resources) {
		Ext.define("Terrasoft.configuration.FullscreenForecastModule", {
			extend: "Terrasoft.BaseSchemaModule",
			alternateClassName: "Terrasoft.FullscreenForecastModule",

			mixins: {
				customEvent: "Terrasoft.mixins.CustomEventDomMixin"
			},

			/**
			 * The module resources.
			 * @protected
			 */
			moduleResources: resources,

			/**
			 * The control resources receive event name.
			 * @protected
			 */
			getControlResourcesEventName: "getForecastModuleResources",
			
			/**
			 * @inheritdoc BaseSchemaModule#initSchemaName
			 * @override
			 */
			initSchemaName: function() {
				this.schemaName = "FullscreenForecastTab";
			},


			/**
			 * @inheritdoc BaseSchemaModuleV2#render
			 * @overridden
			 */
			render: function() {
				this.callParent(arguments);
				var customEvent = this.mixins.customEvent;
				customEvent.init();
				customEvent.publish(this.getControlResourcesEventName, this.moduleResources);
			}

		});
		return Terrasoft.FullscreenForecastModule;
	});
