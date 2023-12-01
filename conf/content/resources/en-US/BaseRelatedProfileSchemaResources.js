﻿define("BaseRelatedProfileSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "BaseRelatedProfileSchema",
				resourceItemName: "BlankSlateIcon",
				hash: "4c80007219dc08f0c626835219a12963",
				resourceItemExtension: ".png"
			}
		},
		ClearButton: {
			source: 3,
			params: {
				schemaName: "BaseRelatedProfileSchema",
				resourceItemName: "ClearButton",
				hash: "e469377aa2358c21942fe57d0e1fef21",
				resourceItemExtension: ".png"
			}
		},
		ProfileIcon: {
			source: 3,
			params: {
				schemaName: "BaseRelatedProfileSchema",
				resourceItemName: "ProfileIcon",
				hash: "4b177430ad9dfd06fb56c61bfd4f9b60",
				resourceItemExtension: ".jpg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});