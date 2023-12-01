define("CampaignBaseEventSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "\u041C\u0435\u0440\u043E\u043F\u0440\u0438\u044F\u0442\u0438\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		Title: {
			source: 3,
			params: {
				schemaName: "CampaignBaseEventSchema",
				resourceItemName: "Title",
				hash: "467f71c38a90450d52cf5106d1c32059",
				resourceItemExtension: ".svg"
			}
		},
		Small: {
			source: 3,
			params: {
				schemaName: "CampaignBaseEventSchema",
				resourceItemName: "Small",
				hash: "40534a4bf9c1803cf5f17b3c7713205a",
				resourceItemExtension: ".svg"
			}
		},
		Large: {
			source: 3,
			params: {
				schemaName: "CampaignBaseEventSchema",
				resourceItemName: "Large",
				hash: "234182d10a4b38c104ed496536420293",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});