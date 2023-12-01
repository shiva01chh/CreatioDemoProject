define("CampaignLandingSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Landing page",
		AsyncWithoutIncomingsMessage: "There are elements without inbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "TitleImage",
				hash: "36509169995b1bd08b81e7601b00cfb6",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "LargeImage",
				hash: "58daf4c89d0ab06ff7b97bb46dd5c30c",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "SmallImage",
				hash: "043b5c058db62b7cd916a1d83da99231",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});