 define("ConfidenceLevelWidgetModule", ["ConfidenceLevelWidget", "ConfidenceLevelWidgetViewModel", "css!ConfidenceLevelWidgetModule"], function() {
	Ext.define("Terrasoft.configuration.ConfidenceLevelWidgetModule", {
		extend: "Terrasoft.configuration.BaseModule",
		alternateClassName: "Terrasoft.ConfidenceLevelWidgetModule",
		Ext: null,
		sandbox: null,
		Terrasoft: null,
		view: null,
		model: null,

		messages: {
			/**
			 * @message GetConfidenceLevelWidgetConfig
			 * Returns ConfedenceLevel widget config.
			 */
			"GetConfidenceLevelWidgetConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},
			
			/**
			 * @message SliderValueChanged
			 * Message for slider change value event.
			 */
			"SliderValueChanged": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},			
			
			/**
			 * @message ConfidenceIconChanged
			 * Message for confidence icon change value event.
			 */
			"ConfidenceIconChanged": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message UpdateConfidenceLevelWidgetValues
			 * Refresh ConfidenceLevel widget data.
			 */
			"UpdateConfidenceLevelWidgetValues": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},
		},
		
		//region Methods: Private

		/**
		 * Renders ConfedenceLevel widget.
		 * @param {Object} renderTo Element to rendering.
		 * @private
		 */
		_renderConfidenceLevelWidget: function(renderTo) {
			this.view = this.Ext.create("Terrasoft.ConfidenceLevelWidget", {
				caption: {"bindTo": "Caption"},
				sliderConfig: {"bindTo": "SliderConfig"},
				metrics: {"bindTo": "Metrics"},
				confidenceIcons: {"bindTo": "ConfidenceIcons"},
				sliderValueChanged: {"bindTo": "onSliderValueChanged"},
				confidenceIconChanged: {"bindTo": "onConfidenceIconChanged"},
			});
			this.view.bind(this.model);
			this.view.render(renderTo);
		},

		/**
		 * @private
		 */
		_updateConfig: function() {
			const config = this.sandbox.publish("GetConfidenceLevelWidgetConfig", null, [this.sandbox.id]) || {};
			if (!config) {
				return;
			}
			this.model.$Caption = config.caption;
			this.model.$SliderConfig = config.sliderConfig;
			this.model.$Metrics = config.metrics;
			this.model.$ConfidenceIcons = config.confidenceIcons;
		},
		
		//endregion
		
		//region Methods: Protected

		/**
		 * @inheritDoc Terrasoft.BaseModule#init
		 * @override
		 */
		init: function() {
			this.sandbox.registerMessages(this.messages);
			this.sandbox.subscribe("UpdateConfidenceLevelWidgetValues", function() {
				this.refreshConfidenceLevelWidget();
			}, this, [this.sandbox.id]);
			const config = this.sandbox.publish("GetConfidenceLevelWidgetConfig", null, [this.sandbox.id]) || {};
			this.model = Ext.create("Terrasoft.ConfidenceLevelWidgetViewModel", {
				sandbox: this.sandbox,
				Ext: this.Ext,
				Terrasoft: this.Terrasoft
			});
			this.model.$Caption = config.caption;
			this.model.$SliderConfig = config.sliderConfig;
			this.model.$Metrics = config.metrics;
			this.model.$ConfidenceIcons = config.confidenceIcons;
			this.callParent(arguments);
		},

		/**
		 * Refresh ConfedenceLevel widget data.
		 */
		refreshConfidenceLevelWidget: function() {
			this._updateConfig();
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#render
		 * @override
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			if (!renderTo.dom) {
				renderTo = Ext.get(renderTo.id);
			}
			this._renderConfidenceLevelWidget(renderTo);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#destroy
		 * @override
		 */
		destroy: function() {
			if (this.view) {
				this.view.destroy();
			}
			if (this.model) {
				this.model.destroy();
			}
			this.callParent(arguments);
		}
		
		//endregion

	});

	return Terrasoft.ConfidenceLevelWidgetModule;

});
