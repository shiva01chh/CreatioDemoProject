﻿define("ClientContactProfileSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProfileHeaderCaption: "\u041A\u043B\u0438\u0435\u043D\u0442"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "ClientContactProfileSchema",
				resourceItemName: "BlankSlateIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		},
		ClearButton: {
			source: 3,
			params: {
				schemaName: "ClientContactProfileSchema",
				resourceItemName: "ClearButton",
				hash: "e469377aa2358c21942fe57d0e1fef21",
				resourceItemExtension: ".png"
			}
		},
		ProfileIcon: {
			source: 3,
			params: {
				schemaName: "ClientContactProfileSchema",
				resourceItemName: "ProfileIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});