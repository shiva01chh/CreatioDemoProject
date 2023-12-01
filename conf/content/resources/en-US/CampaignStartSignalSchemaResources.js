define("CampaignStartSignalSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddAudienceWithoutOutgoingsMessage: "There are elements without outbound connections in your campaign",
		Caption: "Triggered adding"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalSchema",
				resourceItemName: "TitleImage",
				hash: "c275c53adcf0d453c2cc8cc2610a273d",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalSchema",
				resourceItemName: "LargeImage",
				hash: "fd768254cfd573968f5873792182fe4e",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalSchema",
				resourceItemName: "SmallImage",
				hash: "a8614b3d59c0f46a5c98c49a684669eb",
				resourceItemExtension: ".svg"
			}
		},
		TitleIsRecurringImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalSchema",
				resourceItemName: "TitleIsRecurringImage",
				hash: "c4921a4ead1f8ff70d6ad01015b3d0e2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});