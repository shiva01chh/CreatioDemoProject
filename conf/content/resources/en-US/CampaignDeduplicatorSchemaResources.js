define("CampaignDeduplicatorSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Eliminate duplicates",
		AsyncWithoutIncomingsMessage: "There are elements without inbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "LargeImage",
				hash: "d2026ba1c9a1accd0aad3cddb484eef6",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "SmallImage",
				hash: "172c06b1e941b5bc823f1fbf36cd4210",
				resourceItemExtension: ".svg"
			}
		},
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "TitleImage",
				hash: "40b6c42e14dd80eea2bec7bad26e0741",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});