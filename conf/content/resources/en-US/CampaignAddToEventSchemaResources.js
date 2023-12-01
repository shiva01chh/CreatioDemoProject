define("CampaignAddToEventSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Add to event",
		AsyncWithoutIncomingsMessage: "There are elements without inbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "TitleImage",
				hash: "e7412153f08bc0a42f1060c5e6112a85",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "SmallImage",
				hash: "aa1ab4e230a9158eb3e8ae03c77c6593",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "LargeImage",
				hash: "50874aef26b9e59b6f0f74e459a416d9",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});