define("FullscreenForecastTabResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ForecastModuleCaption: "\u041F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		BlankSlateDescription: "\u0411\u0440\u0430\u0443\u0437\u0435\u0440 \u043D\u0435 \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u0438\u0432\u0430\u0435\u0442\u0441\u044F\n\n\u041C\u044B \u0440\u0435\u043A\u043E\u043C\u0435\u043D\u0434\u0443\u0435\u043C \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u0440\u0430\u0437\u0434\u0435\u043B \u041F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0432 \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0445 \u0431\u0440\u0430\u0443\u0437\u0435\u0440\u0430\u0445:\nChrome       Firefox       Safari"
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