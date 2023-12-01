define("CampaignSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		TypeCaption: "Campaign",
		PropertiesPageCaption: "Campaign",
		LoopWithoutDelayedTransitionsMessage: "You are about to save a campaign with an unconditional closed-cycle diagram. Use a \u201CConditional flow\u201D to connect campaign elements in the cycle and enable a delay before executing the next element. If you save and run this campaign without changes, flow logic could be broken."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchema",
				resourceItemName: "TitleImage",
				hash: "57f1241a319f56e8fa03819ce08d724e",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});