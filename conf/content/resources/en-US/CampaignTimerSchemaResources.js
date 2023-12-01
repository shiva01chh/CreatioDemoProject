define("CampaignTimerSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		IntermediatesGroupCaption: "Intermediate elements",
		Caption: "Timer"
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