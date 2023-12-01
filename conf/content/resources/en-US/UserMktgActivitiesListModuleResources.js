define("UserMktgActivitiesListModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ListHeaderCaption: "My marketing activities",
		CreateButtonCaption: "New",
		EmptyInfoTitle: "You do not have any activities",
		EmptyInfoRecommendation: "Create a {0}new activity{1}."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "UserMktgActivitiesListModule",
				resourceItemName: "EmptyInfoImage"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});