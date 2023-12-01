define("SectionMainSettingsResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultIcon: {
			source: 3,
			params: {
				schemaName: "SectionMainSettings",
				resourceItemName: "DefaultIcon",
				hash: "4c421e204b17018308c36c5d9105b121",
				resourceItemExtension: ".svg"
			}
		},
		SectionIcon: {
			source: 3,
			params: {
				schemaName: "SectionMainSettings",
				resourceItemName: "SectionIcon",
				hash: "640e80bd309c99f2b2328b669dd276d5",
				resourceItemExtension: ".svg"
			}
		},
		SelectExistObjectIcon: {
			source: 3,
			params: {
				schemaName: "SectionMainSettings",
				resourceItemName: "SelectExistObjectIcon",
				hash: "5809267db2e06ea2f6aa9cb11f4aa297",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});