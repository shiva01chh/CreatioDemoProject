define("PivotTableResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		NotFilledValue: "(blank)",
		LimitExceededMessage: "You have reached the limit on the number of displayed rows or columns. Please change the field settings for the pivot table to work correctly.",
		LoadingErrorMessage: "Error during calculations in the pivot table."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});