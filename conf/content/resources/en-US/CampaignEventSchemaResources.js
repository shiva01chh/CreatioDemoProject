define("CampaignEventSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Event"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignEventSchema",
				resourceItemName: "TitleImage",
				hash: "9d837496697bbbbf2c122d6102727713",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignEventSchema",
				resourceItemName: "LargeImage",
				hash: "58483367021ce81420c936c74ccd39c9",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignEventSchema",
				resourceItemName: "SmallImage",
				hash: "69b56a326596d4c99552dbbd45959560",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});