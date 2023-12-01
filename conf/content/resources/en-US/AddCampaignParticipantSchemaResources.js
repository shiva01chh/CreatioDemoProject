define("AddCampaignParticipantSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Add audience",
		AddAudienceWithoutOutgoingsMessage: "There are elements without outbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleImage",
				hash: "92b5d2c05abb35f1afa28d7a8ecd48d5",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "SmallImage",
				hash: "2e12a37f6da58327c44fea740fe12fc7",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "LargeImage",
				hash: "acf40191cf516e4bde43d9c6f67da6f1",
				resourceItemExtension: ".svg"
			}
		},
		LargeIsRecurringImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "LargeIsRecurringImage",
				hash: "6f007a58111a8ccd54c1797bdfb30912",
				resourceItemExtension: ".svg"
			}
		},
		TitleIsRecurringImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleIsRecurringImage",
				hash: "3e8aeb1052ff278d52278a6c441b1884",
				resourceItemExtension: ".svg"
			}
		},
		TitleWithFolderImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleWithFolderImage",
				hash: "9a911a559f3fd205f95cd516e3503c10",
				resourceItemExtension: ".svg"
			}
		},
		TitleRecurringWithFolderImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleRecurringWithFolderImage",
				hash: "af584e94f998077b4751539f340a220b",
				resourceItemExtension: ".svg"
			}
		},
		TitleHasFilterImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleHasFilterImage",
				hash: "fdf35f98e06667ea4e346a221cce01d8",
				resourceItemExtension: ".svg"
			}
		},
		TitleHasFilterIsRecurringImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantSchema",
				resourceItemName: "TitleHasFilterIsRecurringImage",
				hash: "b5f8f3a7bdaaab4d6f3b7fbab955ffb5",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});