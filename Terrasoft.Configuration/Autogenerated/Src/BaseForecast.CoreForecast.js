define("BaseForecast", function() {
	/**
	 * Base mixin for rendering forecast web components
	 */
	Ext.define("Terrasoft.control.BaseForecast", {
		extend: "Terrasoft.controls.Component",
		alternateClassName: "Terrasoft.BaseForecast",

		forecastId: null,
		command: null,
		periodsId: null,
		baseUrl: null,
		imagesList: null,
		maxDisplayedRecords: null,
		maxAllowedContainerHeight: null,
		domAttributes: [],

		styles: {},
		parentComponent: Ext.emptyString,

		//region Methods: Private

		/**
		 * Sets styles.
		 */
		setStyles: function() {
			const height = this.getCalculatedWrapHeight();
			if (height === 0) {
				return;
			}
			const styles = {
				height: height + "px"
			};
			this.setMaxAllowedContainerHeight(height);
			Ext.apply(this.styles, styles);
		},


		/**
		 *  Sets the attribute to tpl.
		 */
		setAttribute: function(name, value) {
			if (this.rendered) {
				this.bpmForecastEl.dom.setAttribute(name, value);
			}
		},

		// endregion

		/**
		 * Returns calculated wrap height.
		 * @return {Number} Calculated height.
		 */
		getCalculatedWrapHeight: function() {
			const component = Ext.getCmp(this.parentComponent);
			if (!component) {
				return 0;
			}
			let adjustmentValue = 10;
			if (Terrasoft.isDebug) {
				adjustmentValue = 0;
			}
			if (Terrasoft.isAngularHost) {
				adjustmentValue = 60;
			}
			const el = component.getWrapEl().dom || {};
			const style = window.getComputedStyle(el, null) || {};
			const topOffset = el.offsetTop || 0;
			const marginTopOffset = parseInt(style.marginTop || 0);
			const bottomOffset = Ext.getScrollbarSize().height || 0;
			const body = Ext.getBody();
			return body.getHeight() - topOffset - marginTopOffset - bottomOffset - adjustmentValue;
		},

		/**
		 * Updates wrap container height.
		 */
		updateWrapHeight: function() {
			const height = this.getCalculatedWrapHeight();
			if (height === 0) {
				return;
			}
			this.setMaxAllowedContainerHeight(height);
			this.wrapEl.setStyle("height", height + "px");
		},

		/**
		 * Sets forecast identifier.
		 * @param {String} forecastId Forecast identifier.
		 */
		setForecastId: function(forecastId) {
			if (this.forecastId === forecastId || Ext.isEmpty(forecastId)) {
				return;
			}
			this.forecastId = forecastId;
			this.setAttribute("forecast-id", this.forecastId);
		},

		/**
		 * Sets command.
		 * @param {String} command Command.
		 */
		setCommand: function(command) {
			if (this.command === command) {
				return;
			}
			this.command = command;
			this.setAttribute("command", this.command);
		},

		/**
		 * Sets periods identifiers.
		 * @param {String} periodsId Periods identifiers.
		 */
		setPeriodsId: function(periodsId) {
			if (this.periodsId === periodsId) {
				return;
			}
			this.periodsId = periodsId;
			this.setAttribute("periods-id", this.periodsId);
		},

		/**
		 * Sets base url.
		 * @param {String} baseUrl Base url.
		 */
		setBaseUrl: function(baseUrl) {
			if (this.baseUrl === baseUrl || Ext.isEmpty(baseUrl)) {
				return;
			}
			this.baseUrl = baseUrl;
			this.setAttribute("base-url", this.baseUrl);
		},

		/**
		 * Sets maximum displayed records.
		 * @param {Number} maxDisplayedRecords Maximum displayed records.
		 */
		setMaxDisplayedRecords: function(maxDisplayedRecords) {
			if (this.maxDisplayedRecords === maxDisplayedRecords || Ext.isEmpty(maxDisplayedRecords)) {
				return;
			}
			this.maxDisplayedRecords = maxDisplayedRecords;
			this.setAttribute("max-displayed-records", this.maxDisplayedRecords);
		},

		/**
		 * Sets images list.
		 * @param {String} imagesList List of images.
		 */
		setImagesList: function(imagesList) {
			if (this.imagesList === imagesList || Ext.isEmpty(imagesList)) {
				return;
			}
			this.imagesList = Terrasoft.encodeHtml(Terrasoft.encode(imagesList));
			this.setAttribute("images", this.imagesList);
		},

		/**
		 * Sets maximum allowed container height.
		 * @param {Number} maxDisplayedRecords Maximum allowed container height.
		 */
		setMaxAllowedContainerHeight: function(maxAllowedContainerHeight) {
			if (this.maxAllowedContainerHeight === maxAllowedContainerHeight || Ext.isEmpty(maxAllowedContainerHeight)) {
				return;
			}
			this.maxAllowedContainerHeight = maxAllowedContainerHeight;
			this.setAttribute("max-allowed-container-height", this.maxAllowedContainerHeight);
		},
	});

	return Terrasoft.BaseForecast;

});
