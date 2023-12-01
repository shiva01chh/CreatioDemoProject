Terrasoft.configuration.Structures["HistoryForecastModule"] = {innerHierarchyStack: ["HistoryForecastModule"]};
define("HistoryForecastModule", ["ForecastComponent", "css!HistoryForecastModule", "HistoryForecast", "MiniPageUtilities",
	"ForecastItemViewModel"], function() {
	Ext.define("Terrasoft.configuration.HistoryForecastModule", {
		extend: "Terrasoft.configuration.BaseModule",
		alternateClassName: "Terrasoft.HistoryForecastModule",

		Ext: null,
		sandbox: null,
		Terrasoft: null,

		view: null,
		model: null,

		messages: {
			/**
			 * @message GetForecastConfig
			 * Returns forecast config.
			 */
			"GetForecastConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message RefreshForecast
			 * Refresh forecast.
			 */
			"RefreshForecast": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message RefreshForecastColumns
			 * Refresh forecast columns.
			 */
			"RefreshForecastColumns": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},
		},

		/**
		 * @private
		 */
		_loadData: function() {
			this.model.$Command = "load";
		},

		/**
		 * Renders forecast application.
		 * @param {Object} renderTo Element to rendering.
		 * @private
		 */
		_renderForecast: function(renderTo) {
			this.view = Ext.create("Terrasoft.HistoryForecast", {
				forecastId: { "bindTo": "ForecastId" },
				periodsId: { "bindTo": "PeriodsId" },
				snapshotId: { "bindTo": "SnapshotId" },
				command: { "bindTo": "Command" },
				commandFinished: { "bindTo": "onCommandFinished" },
				baseUrl: { "bindTo": "BaseUrl" },
				imagesList: { "bindTo": "Images" },
				maxDisplayedRecords: { "bindTo": "MaxDisplayedRecords" },
				parentComponent: renderTo.id
			});
			this.view.bind(this.model);
			this.view.render(renderTo);
		},

		/**
		 * @private
		 */
		_updateConfig: function() {
			const config = this.sandbox.publish("GetForecastConfig", null, [this.sandbox.id]);
			if (!config) {
				return;
			}
			this.model.$PeriodsId = config.periodsId;
			this.model.$SnapshotId = config.snapshotId;
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#init
		 * @override
		 */
		init: function() {
			this.sandbox.registerMessages(this.messages);
			this.subscribeMessages();
			const config = this.sandbox.publish("GetForecastConfig", null, [this.sandbox.id]);
			this.model = Ext.create("Terrasoft.ForecastItemViewModel", {
				sandbox: this.sandbox,
				Ext: this.Ext,
				Terrasoft: this.Terrasoft
			});
			if (!config) {
				return;
			}
			this.model.$BaseUrl = Terrasoft.workspaceBaseUrl;
			this.model.$ForecastId = config.forecastId;
			this.model.$PeriodsId = config.periodsId;
			this.model.$SnapshotId = config.snapshotId;
			this.model.$ForecastSourceItemName = config.forecastSourceItemName;
			this.model.$MaxDisplayedRecords = config.maxDisplayedRecords;
			this.model.$Command = "";
			this.callParent(arguments);
		},

		/**
		 * Refresh forecast data.
		 * @param {Boolean} overdueData Overdue forecast data.
		 */
		refreshForecast: function() {
			this._updateConfig();
			this._loadData();
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
			this._renderForecast(renderTo);
			this._loadData();
		},

		/**
		 * Refresh forecast columns.
		 */
		refreshForecastColumns: function() {
			this._updatePeriods();
			this.model.$Command = "refreshcolumns";
		},

		/**
		 * @private
		 */
		_updatePeriods: function() {
			const config = this.sandbox.publish("GetForecastConfig", null, [this.sandbox.id]);
			this.model.$PeriodsId = config.periodsId;
		},

		/**
		 * Subscribes to messages of the module.
		 * @private
		 */
		subscribeMessages: function() {
			this.sandbox.subscribe("RefreshForecast", this.refreshForecast, this, [this.sandbox.id]);
			this.sandbox.subscribe("RefreshForecastColumns", this.refreshForecastColumns, this, [this.sandbox.id]);
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

	});

	return Terrasoft.HistoryForecastModule;

});


