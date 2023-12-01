 define("ConfidenceLevelWidget", ["ConfidenceLevelWidgetComponent"], function() {
	/**
	 * Component for rendering ConfidenceLevel widget
	 */
	Ext.define("Terrasoft.control.ConfidenceLevelWidget", {
		extend: "Terrasoft.controls.Component",
		alternateClassName: "Terrasoft.ConfidenceLevelWidget",
		snapshotId: null,
		domAttributes: [],
		caption: null,
		sliderConfig: null,
		metrics: [],
		confidenceIcons: [],
		styles: {},
		parentComponent: Ext.emptyString,

		/**
		 * @inheritDoc Terrasoft.Component#tpl
		 * @override
		 */
		tpl: [
			/*jshint white:false */
			/*jshint quotmark:true */
			//jscs:disable
			'<crt-confidence-level-widget-component id=\\"{id}-wrap\\"></crt-confidence-level-widget-component>',			
			//jscs:enable
			/*jshint quotmark:false */
			/*jshint white:true */
		],

		/**
		 * @inheritDoc Terrasoft.Component#init
		 * @override
		 */
		init: function() {
			this.callParent(arguments);
			this.addEvents(
				"sliderValueChanged",
				"confidenceIconChanged"
			);
		},

		/**
		 * @inheritDoc Terrasoft.Component#initDomEvents
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			const el = this.wrapEl;
			if (el) {
				el.on("sliderValueChanged", this.onSliderValueChanged, this);
				el.on("confidenceIconChanged", this.onConfidenceIconChanged, this);
			}
		},

		/**
		 * @inheritDoc Terrasoft.Component#clearDomListeners
		 * @override
		 */
		clearDomListeners: function() {
			this.callParent(arguments);
			const el = this.wrapEl;
			if (el) {
				el.un("sliderValueChanged", this.onSliderValueChanged, this);
				el.un("confidenceIconChanged", this.onConfidenceIconChanged, this);
			}
		},
		
		/**
		 * Handles slider change value event
		 * @param {Object} event Event data.
		 */
		onSliderValueChanged: function(event) {
			const data = event && event.browserEvent && event.browserEvent.detail || {};
			this.fireEvent("sliderValueChanged", data);
		},		
		
		/**
		 * Handles confidence icon change value event
		 * @param {Object} event Event data.
		 */
		onConfidenceIconChanged: function(event) {
			const iconId = event && event.browserEvent && event.browserEvent.detail || {};
			this.fireEvent("confidenceIconChanged", iconId);
		},

		/**
		 * @inheritDoc Terrasoft.Component#getSelectors
		 * @override
		 */
		getSelectors: function() {
			return {
				wrapEl: "#" + this.id + "-wrap",
			};
		},

		/**
		 *  Sets the attribute to tpl.
		 */
		setAttribute: function(name, value) {
			if (this.rendered) {
				this.wrapEl.dom.setAttribute(name, value);
			}
		},
		
		/**
		 *  Sets the property to the element.
		 */
		setProperty: function(name, value) {
			if (this.rendered) {
				this.wrapEl.dom[name] = value;
			}
		},
		
		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			return tplData;
		},

		/**
		 * @inheritDoc Terrasoft.Component#render
		 * @override
		 */
		render: function() {
			this.callParent(arguments);
			if (this.wrapEl && this.wrapEl.dom) {
				this.wrapEl.dom.caption = this.caption;
				this.wrapEl.dom.sliderConfig = this.sliderConfig;
				this.wrapEl.dom.metrics = this.metrics;
				this.wrapEl.dom.confidenceIcons = this.confidenceIcons;
			}
		},

		/**
		 * @inheritDoc Terrasoft.Component#getBindConfig
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const confidenceLevelBindConfig = {
				sliderConfig: {
					changeMethod: "setSliderConfig"
				},
				metrics: {
					changeMethod: "setMetrics"
				},
				caption: {
					changeMethod: "setCaption"
				},
				confidenceIcons: {
					changeMethod: "setConfidenceIcons"
				}
			};
			Ext.apply(confidenceLevelBindConfig, bindConfig);
			return confidenceLevelBindConfig;
		},
		
		/**
		 * Sets slider config.
		 * @param {object} sliderConfig Slider config.
		 */
		setSliderConfig: function(sliderConfig) {
			if (this.sliderConfig === sliderConfig) {
				return;
			}
			this.sliderConfig = sliderConfig;
			this.setProperty("sliderConfig", this.sliderConfig);
		},
		
		/**
		 * Sets widget metrics.
		 * @param {array} metrics Widget metrics array.
		 */
		setMetrics: function(metrics) {
			if (this.metrics === metrics) {
				return;
			}
			this.metrics = metrics
			this.setProperty("metrics", this.metrics);
		},
		
		/**
		 * Sets widget caption.
		 * @param {String} caption Widget caption.
		 */
		setCaption: function(caption) {
			if (this.caption === caption) {
				return;
			}
			this.caption = caption
			this.setProperty("caption", this.caption);
		},

		/**
		 * Sets widget confidence icons collection.
		 * @param {Array} confidenceIcons Confidence icons.
		 */
		setConfidenceIcons: function(confidenceIcons) {
			if (this.confidenceIcons === confidenceIcons) {
				return;
			}
			this.confidenceIcons = confidenceIcons
			this.setProperty("confidenceIcons", this.confidenceIcons);
		},
	});

	return Terrasoft.ConfidenceLevelWidget;

});
