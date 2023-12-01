define("CampaignTimerSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		IntermediatesGroupCaption: "\u041F\u0440\u043E\u043C\u0435\u0436\u0443\u0442\u043E\u0447\u043D\u044B\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B",
		Caption: "\u0422\u0430\u0439\u043C\u0435\u0440"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerSchema",
				resourceItemName: "TitleImage",
				hash: "65144e645bcce22159c50d3dc9f9b807",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerSchema",
				resourceItemName: "LargeImage",
				hash: "171e5a4e8a168d6acdc274a5a236631e",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerSchema",
				resourceItemName: "SmallImage",
				hash: "5396e2df602bdf8f1c8826720e6171a9",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});