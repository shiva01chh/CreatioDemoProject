 define("ConfidenceLevelWidgetViewModel", ["ConfidenceLevelWidgetViewModelResources", "GoogleTagManagerUtilities"],
	function(resources, GoogleTagManagerUtilities) {
		Ext.define("Terrasoft.configuration.ConfidenceLevelWidgetViewModel", {
			extend: "Terrasoft.BaseViewModel",
			alternateClassName: "Terrasoft.ConfidenceLevelWidgetViewModel",
			Ext: null,
			Terrasoft: null,
			sandbox: null,
			isOpeningPage: false,
			
			columns: {
				Caption: { dataValueType: Terrasoft.DataValueType.TEXT },
				SliderConfig: { dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT },
				Metrics: { dataValueType: Terrasoft.DataValueType.COLLECTION },
				ConfidenceIcons: { dataValueType: Terrasoft.DataValueType.COLLECTION },
			},
			mixins: {},
			messages: {},
			
			/**
			 * Handles slider change value event.
			 * @param {Object} data Widget data.
			 */
			onSliderValueChanged: function(data) {
				this.sandbox.publish("SliderValueChanged", data, [this.sandbox.id]) || {};
			},			
			
			/**
			 * Handles confidence icon change value event.
			 * @param {String} iconId Icon identifier.
			 */
			onConfidenceIconChanged: function(iconId) {
				this.sandbox.publish("ConfidenceIconChanged", iconId, [this.sandbox.id]) || {};
			},
		
		});

		return Terrasoft.ConfidenceLevelWidgetViewModel;

	});