define("SspBusinessRuleSectionResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "SspBusinessRuleSection",
				resourceItemName: "EmptyInfoImage",
				hash: "f7367adb83003fc8600e74023d24be5c",
				resourceItemExtension: ".svg"
			}
		},
		InvalidBusinessRuleSectionImage: {
			source: 3,
			params: {
				schemaName: "SspBusinessRuleSection",
				resourceItemName: "InvalidBusinessRuleSectionImage",
				hash: "f7fdc1e0c5c1c9ee81324ce128972bd4",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});