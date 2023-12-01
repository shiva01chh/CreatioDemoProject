﻿define("BaseParameterListItemViewModelResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CustomMacro: "Custom macro",
		InputValue: "Input value"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		RemoveIcon: {
			source: 3,
			params: {
				schemaName: "BaseParameterListItemViewModel",
				resourceItemName: "RemoveIcon",
				hash: "91236d2465874e8e2cece2164d8e6bf2",
				resourceItemExtension: ".svg"
			}
		},
		ValueIcon: {
			source: 3,
			params: {
				schemaName: "BaseParameterListItemViewModel",
				resourceItemName: "ValueIcon",
				hash: "d7d2ac17804e9871a629fb0e7b9a904d",
				resourceItemExtension: ".svg"
			}
		},
		MacrosIcon: {
			source: 3,
			params: {
				schemaName: "BaseParameterListItemViewModel",
				resourceItemName: "MacrosIcon",
				hash: "d294aa661f282450a25f9085195b3eae",
				resourceItemExtension: ".png"
			}
		},
		InputIcon: {
			source: 3,
			params: {
				schemaName: "BaseParameterListItemViewModel",
				resourceItemName: "InputIcon",
				hash: "00d6b9c06c07a868e4c81de698cee79b",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});