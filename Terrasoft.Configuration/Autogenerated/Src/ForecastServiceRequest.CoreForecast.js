define("ForecastServiceRequest", ["ext-base", "terrasoft", "ConfigurationServiceRequest"],
	function(Ext, Terrasoft) {
		Ext.define("Terrasoft.configuration.ForecastServiceRequest", {
			extend: "Terrasoft.ConfigurationServiceRequest",
			alternateClassName: "Terrasoft.ForecastServiceRequest",

			/**
			 * @inheritdoc Terrasoft.configuration.ConfigurationServiceRequest#serviceName
			 * @overridden
			 */
			serviceName: "forecast.api",

			/**
			 * Forecast identifier.
			 */
			forecastId: '',

			/**
			 * @inheritdoc Terrasoft.core.BaseRequest#getSerializableObject
			 * @overridden
			 */
			getSerializableObject: function(serializableObject) {
				this.callParent(arguments);
				serializableObject.forecastId = this.forecastId;
			},

			/**
			 * Returns calculation status.
			 * @param {Function} callback Call back function.
			 * @param {Object} scope Scope.
			 */
			getCalculatedStatus(callback, scope) {
				this.contractName = "forecast/calc/status";
				this.execute(function(response) {
					const result = response ? response.GetCalcStatusResult : null
					callback.call(scope, result);
				}, this);
			}
		});

		return Terrasoft.ForecastServiceRequest;
	});
