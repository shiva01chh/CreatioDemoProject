define("ForecastModule", ["ForecastLczResourcesResources","BaseSchemaModuleV2", "ViewGeneratorV2", "ForecastTab"],
	function(resources) {
		Ext.define("Terrasoft.configuration.ForecastModule", {
			extend: "Terrasoft.BaseSchemaModule",
			alternateClassName: "Terrasoft.ForecastModule",

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
			 * @inheritdoc BaseSchemaModuleV2#initSchemaName
			 * @overridden
			 */
			initSchemaName: function() {
				this.schemaName = "ForecastTab";
			},

			/**
			 * @inheritdoc BaseSchemaModuleV2#render
			 * @overridden
			 */
			render: function() {
				this.callParent(arguments);
				this._initControlResources();
			},

			/**
			 * @inheritdoc BaseSchemaModuleV2#initHistoryState
			 * @overridden
			 */
			initHistoryState: Terrasoft.emptyFn,

			/**
			 * @private
			 */
			_initControlResources: function() {
				var customEvent = this.mixins.customEvent;
				customEvent.init();
				this.moduleResources.InfoDialog = {
					OK: this.moduleResources.localizableStrings.OkButtonCaption,
				};
				this.moduleResources.ForecastButtons = {
					GoToSectionCaption: this.moduleResources.localizableStrings.GoToSectionCaption
				};
				customEvent.publish(this.getControlResourcesEventName, this.moduleResources);
			}

		});
		return Terrasoft.ForecastModule;
	}
);
