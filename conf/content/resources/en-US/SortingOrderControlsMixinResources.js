define("SortingOrderControlsMixinResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SortingOrder2Caption: "Descending",
		SortingOrder1Caption: "Ascending",
		SortingOrder0Caption: "Disabled"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButton: {
			source: 3,
			params: {
				schemaName: "SortingOrderControlsMixin",
				resourceItemName: "CloseButton",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});