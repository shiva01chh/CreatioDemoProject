define("FullscreenForecastTabResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ForecastModuleCaption: "Forecasts",
		BlankSlateDescription: "Browser is not supported\n\nWe recommend using Forecasts section with one of the following browsers:\nChrome       Firefox       Safari"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CalculateIcon: {
			source: 3,
			params: {
				schemaName: "FullscreenForecastTab",
				resourceItemName: "CalculateIcon",
				hash: "7854e585e89a768384704c2936de6b2a",
				resourceItemExtension: ".svg"
			}
		},
		FullscreenIcon: {
			source: 3,
			params: {
				schemaName: "FullscreenForecastTab",
				resourceItemName: "FullscreenIcon",
				hash: "08d89bd0b1c1162fc12bbbbb97c60f41",
				resourceItemExtension: ".svg"
			}
		},
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "FullscreenForecastTab",
				resourceItemName: "BlankSlateIcon",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});