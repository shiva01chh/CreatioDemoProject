define("CampaignAddObjectSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Add data"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddObjectSchema",
				resourceItemName: "TitleImage",
				hash: "c7013e7dbeb3bdafa141a49863070fde",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddObjectSchema",
				resourceItemName: "LargeImage",
				hash: "93b2545dc75c008ce7f6cf866f244749",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddObjectSchema",
				resourceItemName: "SmallImage",
				hash: "b06b1cb6640a921b87b5319d8cc9ef63",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});