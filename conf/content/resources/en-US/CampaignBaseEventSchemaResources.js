define("CampaignBaseEventSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Event"
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