define("HistoryForecast", ["BaseForecast"], function() {
	/**
	 * Component for rendering history-forecast web components
	 */
	Ext.define("Terrasoft.control.HistoryForecast", {
		extend: "Terrasoft.controls.Component",
		alternateClassName: "Terrasoft.HistoryForecast",

		snapshotId: null,
		domAttributes: [],

		styles: {},
		parentComponent: Ext.emptyString,
		mixins: {
			"BaseForecast": "Terrasoft.BaseForecast"
		},

		/**
		 * Wait timespan from resize.
		 * @type {Number}
		 * @private
		 */
		_wait: 250,

		/**
		 * @inheritDoc Terrasoft.Component#tpl
		 * @override
		 */
		tpl: [
			/*jshint white:false */
			/*jshint quotmark:true */
			//jscs:disable
			'<div id=\"{id}-wrap\" style=\"{styles}\">',
			'<ts-history-forecast id=\"{id}\" ' +
			'class="ts-forecast-component" ' +
			'forecast-id = \"{forecastId}\"  snapshot-id = \"{snapshotId}\" ' +
			'command = \"{command}\"',
			'base-url = \"{baseUrl}\" periods-id=\"{periodsId}\" images=\"{imagesList}\"',
			'max-displayed-records="{maxDisplayedRecords}">',
			'</ts-historyforecast>',
			'</div>',
			//jscs:enable
			/*jshint quotmark:false */
			/*jshint white:true */
		],

		/**
		 * @inheritDoc Terrasoft.Component#getSelectors
		 * @override
		 */
		getSelectors: function() {
			return {
				wrapEl: "#" + this.id + "-wrap",
				bpmForecastEl: "#" + this.id
			};
		},

		/**
		 * @inheritDoc Terrasoft.Component#init
		 * @override
		 */
		init: function() {
			this.callParent(arguments);
			this.addEvents(
				"commandFinished",
			);
			this.updateDirection(this.name);
			this.setStyles();
		},

		/**
		 * @inheritDoc Terrasoft.Component#initDomEvents
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			const el = this.bpmForecastEl;
			if (el) {
				el.on("commandFinished", this.onCommandFinished, this);
			}

			this.debounceWindowResize = Terrasoft.debounce(this.updateWrapHeight, this._wait);
			Ext.EventManager.addListener(window, "resize", this.debounceWindowResize, this);
		},

		/**
		 * @inheritDoc Terrasoft.Component#clearDomListeners
		 * @override
		 */
		clearDomListeners: function() {
			this.callParent(arguments);
			const el = this.bpmForecastEl;
			if (el) {
				el.un("commandFinished", this.onCommandFinished, this);
			}
			Ext.EventManager.removeListener(window, "resize", this.debounceWindowResize, this);
		},

		/**
		 * Handler of command finished.
		 * @protected
		 */
		onCommandFinished: function(event) {
			this.fireEvent("commandFinished", event);
		},

		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			const forecastTplData = {
				forecastId: this.forecastId,
				command: this.command,
				periodsId: this.periodsId,
				snapshotId: this.snapshotId,
				baseUrl: this.baseUrl,
				imagesList: this.imagesList,
				styles: this.styles,
				maxDisplayedRecords: this.maxDisplayedRecords
			};
			Ext.apply(tplData, forecastTplData);
			return tplData;
		},

		/**
		 * @inheritDoc Terrasoft.Component#getBindConfig
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const forecastBindConfig = {
				forecastId: {
					changeMethod: "setForecastId"
				},
				command: {
					changeMethod: "setCommand"
				},
				periodsId: {
					changeMethod: "setPeriodsId"
				},
				snapshotId: {
					changeMethod: "setSnapshotId"
				},
				baseUrl: {
					changeMethod: "setBaseUrl"
				},
				imagesList: {
					changeMethod: "setImagesList"
				},
				maxDisplayedRecords: {
					changeMethod: "setMaxDisplayedRecords"
				}
			};
			Ext.apply(forecastBindConfig, bindConfig);
			return forecastBindConfig;
		},

		/**
		 * Sets snapshot id.
		 * @param {String} snapshotId Periods identifiers.
		 */
		setSnapshotId: function(snapshotId) {
			if (this.snapshotId === snapshotId) {
				return;
			}
			this.snapshotId = snapshotId;
			this.setAttribute("snapshot-id", this.snapshotId);
		},
	});

	return Terrasoft.HistoryForecast;

});
