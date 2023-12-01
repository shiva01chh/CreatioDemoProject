define("CampaignSplitGatewaySchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Random split",
		AsyncWithoutIncomingsMessage: "There are elements without inbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewaySchema",
				resourceItemName: "LargeImage",
				hash: "53191f1757a9cc31aca22bcc8c4538e2",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewaySchema",
				resourceItemName: "SmallImage",
				hash: "b6949e8c33b3375e856386b539131e27",
				resourceItemExtension: ".svg"
			}
		},
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewaySchema",
				resourceItemName: "TitleImage",
				hash: "7ac8ffec7b05a6925af727a837764754",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});