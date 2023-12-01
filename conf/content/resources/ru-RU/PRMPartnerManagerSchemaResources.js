﻿define("PRMPartnerManagerSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		YuorManagerText: "\u0412\u0430\u0448 \u043C\u0435\u043D\u0435\u0434\u0436\u0435\u0440"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		ManagerEmptyPhoto: {
			source: 3,
			params: {
				schemaName: "PRMPartnerManagerSchema",
				resourceItemName: "ManagerEmptyPhoto",
				hash: "ed12916b583407914f22afb2a4581d7f",
				resourceItemExtension: ".svg"
			}
		},
		Email: {
			source: 3,
			params: {
				schemaName: "PRMPartnerManagerSchema",
				resourceItemName: "Email",
				hash: "caf9b3525d540f48285d27905f54f350",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});