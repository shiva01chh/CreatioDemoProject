define("ActivityReleaseDetailResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityReleaseDetail",
				resourceItemName: "BackButtonImage",
				hash: "96d05bdc934e78ab86fd88b37ba48fe9",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityReleaseDetail",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});