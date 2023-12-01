﻿define("ProcessListenerV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ElementNotFoundByUIdExceptionMessage: "Process item with the \u0022{0}\u0022 identifier not found",
		RunProcessInformationMessage: "Click to continue task \u0022{0}\u0022",
		ModuleStructureNotFoundByNameMessage: "No module structure for entity schema \u0022{0}\u0022 were found"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});