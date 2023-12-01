define("CampaignUpdateObjectSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignUpdateObjectSchema",
				resourceItemName: "TitleImage",
				hash: "187306549ffbb611f087f59b4a85ac2b",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignUpdateObjectSchema",
				resourceItemName: "LargeImage",
				hash: "de7464e4a19b4e6dc583da56d288203d",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignUpdateObjectSchema",
				resourceItemName: "SmallImage",
				hash: "a8aca9cf4e6b9e0eeb552bdb9973c7bb",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});