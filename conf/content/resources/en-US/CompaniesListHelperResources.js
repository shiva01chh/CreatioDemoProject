﻿define("CompaniesListHelperResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SuggestedCompaniesHeader: "Provided by",
		ProvidedByCompanyName: "Clearbit"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultLogo: {
			source: 3,
			params: {
				schemaName: "CompaniesListHelper",
				resourceItemName: "DefaultLogo",
				hash: "421751696ddf1170585f8f1f05f263fe",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});