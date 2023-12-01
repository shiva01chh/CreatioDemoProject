/**
 * Enums for terms calculation functionality.
 */
Ext.ns("Terrasoft.configuration.TermCalculationInformationEnums");

/**
 * Kind of term.
 * @type {{ReactionTime: number, SolutionTime: number}}
 */
Terrasoft.configuration.TermCalculationInformationEnums.TermKind = {
	ResponseDate: 1,
	SolutionDate: 2
};

define("TermCalculationInformation", [], function() {
	Ext.define("Terrasoft.controls.TermCalculationInformation", {
		alternateClassName: "Terrasoft.TermCalculationInformation",
		extend: "Terrasoft.controls.Component",

		/**
		 * @inheritDoc Terrasoft.Component#tpl
		 * @override
		 */
		tpl: [
			"<div id=\"{id}-wrap\" style=\"{styles}\" class=\"{wrapClassName}\">",
			"<ts-term-calculation id=\"{id}\" is-data-loaded=false calculationParameters=\"\">",
			"</ts-term-calculation>",
			"</div>"
		],

		additionalData: null,

		parentComponent: "TermCalculationInformationContainer",

		styles: {
			"overflow-y": "scroll"
		},

		/**
		 * @inheritDoc Terrasoft.Component#init
		 * @override
		 */
		init: function() {
			this.callParent(arguments);
			this.addEvents("adjustWrapperPosition");
			this._setStyles();
		},

		/**
		 * @inheritDoc Terrasoft.Component#getBindConfig
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const dataBindConfig = {
				calculationData: {
					changeMethod: "setCalculationData"
				}
			};
			Ext.apply(dataBindConfig, bindConfig);
			return dataBindConfig;
		},

		/**
		 * Apply elements selectors.
		 */
		setupSelectors: function() {
			this.selectors = {
				wrapEl: "#" + this.id + "-wrap",
				itemsWrapEl: "#" + this.id + "-items-wrap"
			};
		},

		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @overridden
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.setupSelectors();
			const tpl = {
				styles: this.styles
			};
			Ext.apply(tplData, tpl);
			return tplData;
		},

		/**
		 * Data set handler.
		 * @param {Object} data Term calculation data.
		 */
		setCalculationData: function(data) {
			if (data) {
				this.calculationParameters = data.calculationParameters;
				if (data.additionalData) {
					this.additionalData = data.additionalData;
				}
				this.fireDataLoaded();
			}
		},

		/**
		 * Fire data loaded inner event.
		 */
		fireDataLoaded: function() {
			const el = this._getTsTermCalcElement();
			if (!el) {
				return;
			}
			el.dom.calculationParameters = Terrasoft.encode(this.calculationParameters);
			el.dom.additionalData = Terrasoft.encode(this.additionalData);
			el.dom.setAttribute("is-data-loaded", false);
			el.dom.setAttribute("is-data-loaded", true);
		},

		/**
		 * @inheritDoc Terrasoft.Component#render
		 * @override
		 */
		render: function() {
			this.callParent(arguments);
			this.fireEvent("adjustWrapperPosition", this);
			this.fireDataLoaded();
		},

		/**
		 * @inheritDoc Terrasoft.Component#reRender
		 * @override
		 */
		reRender: function() {
			this.callParent(arguments);
			this.fireEvent("adjustWrapperPosition", this);
			this.fireDataLoaded();
		},

		/**
		 * @private
		 */
		_getTsTermCalcElement: function() {
			const elements = Ext.select("ts-term-calculation#" + this.id);
			return (elements.item(0)) || null;
		},

		/**
		 * @inheritDoc Terrasoft.Component#initDomEvents
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			this.debounceWindowResize = Terrasoft.debounce(this.updateWrapHeight, this._wait);
			Ext.EventManager.addListener(window, "resize", this.debounceWindowResize, this);
		},

		/**
		 * @inheritDoc Terrasoft.Component#clearDomListeners
		 * @override
		 */
		clearDomListeners: function() {
			this.callParent(arguments);
			Ext.EventManager.removeListener(window, "resize", this.debounceWindowResize, this);
		},

		/**
		 * Updates wrap container height.
		 */
		updateWrapHeight: function() {
			const height = this.getCalculatedWrapHeight();
			if (height === 0) {
				return;
			}
			this.wrapEl.setStyle("height", height + "px");
		},

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
			const el = component.getWrapEl();
			if (!el) {
				return 0;
			}
			const elDom = el.dom || {};
			const style = window.getComputedStyle(elDom, null) || {};
			const topOffset = elDom.offsetTop || 0;
			const marginTopOffset = parseInt(style.marginTop || 0);
			const bottomOffset = Ext.getScrollbarSize().height || 0;
			const body = Ext.getBody();
			return body.getHeight() - topOffset - marginTopOffset - bottomOffset - adjustmentValue;
		},

		/**
		 * Sets styles.
		 * @private
		 */
		_setStyles: function() {
			const height = this.getCalculatedWrapHeight();
			if (height === 0) {
				return;
			}
			const styles = {
				height: height + "px"
			};
			Ext.apply(this.styles, styles);
		}
	});

	return Terrasoft.TermCalculationInformation;
});
