﻿Terrasoft.configuration.Structures["FullPipelineChartJsConfigBuilder"] = {innerHierarchyStack: ["FullPipelineChartJsConfigBuilder"]};
define("FullPipelineChartJsConfigBuilder", ["FunnelChartJsConfigBuilder"], function() {

	Ext.define("Terrasoft.configuration.FullPipelineChartJsConfigBuilder", {
		extend: "Terrasoft.FunnelChartJsConfigBuilder",
		alternateClassName: "Terrasoft.FullPipelineChartJsConfigBuilder",

		// region Fields: Private

		/**
		 * @private
		 */
		_fullPipelineLayoutOptions: {
			padding: {
				bottom: 40
			}
		},

		// endregion
		
		// region Methods: Protected
		
		/**
		 * Returns label configuration.
		 * @returns {Object} Label configuration.
		 * @protected
		 */
		getLabelConfig: function() {
			return {
				lineHeight: 14
			};
		},
		
		/**
		 * Returns elements configuration.
		 * @returns {Object} Elements configuration.
		 * @protected
		 */
		getElementsConfig: function() {
			return {
				minHeight: 28
			};
		},
		
		/**
		 * @inheritDoc
		 * @override
		 */
		initDefaultOption: function() {
			this.callParent(arguments);
			this.chartJsOptions.labelConfig = {};
			this.chartJsOptions.elements = {};
		},
		
		/**
		 * @inheritDoc
		 * @override
		 */
		getLayoutOptions: function() {
			const layoutOptions = this.callParent(arguments);
			return this.applyOptions(layoutOptions, this._fullPipelineLayoutOptions);
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getLabels: function() {
			const series = this.getHighchartsConfigValueOrDefault("series", []);
			const firstSeriesData = series.length > 0 ? series[0].data : [];
			return firstSeriesData.map(function(data) {
				const firstLabelLine = data.stageName;
				const secondLabelLine = data.displayValue;
				return [firstLabelLine, secondLabelLine];
			});
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getLabelSuffix: function() {
			return Terrasoft.emptyString;
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getDataItemConfig: function(dataItem) {
			const config = this.callParent(arguments);
			return this.applyOptions(config, {
				schemaCaption: dataItem.schemaCaption,
				stageName: dataItem.stageName,
				popupValues: dataItem.popupValues
			});
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getEvents: function() {
			return {};
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getLegendOptions: function() {
			const legendOptions = this.callParent(arguments);
			return this.applyOptions(legendOptions, {
				display: false
			});
		},

		// endregion

		// region Methods: Public
		
		/**
		 * @inheritDoc
		 * @override
		 */
		init: function(chartJsOptions) {
			this.callParent(arguments);
			this.applyOptions(chartJsOptions.labelConfig, this.getLabelConfig());
			this.applyOptions(chartJsOptions.elements, this.getElementsConfig());
		}

		// endregion

	});

	return {};
});


