﻿define("RawRequestBuilderResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Title: "Request setup from RAW example"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "RawRequestBuilder",
				resourceItemName: "CloseIcon",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		},
		SetupResultImageSuccess: {
			source: 3,
			params: {
				schemaName: "RawRequestBuilder",
				resourceItemName: "SetupResultImageSuccess",
				hash: "1b17b350024ba47e8baa44fbe38860b6",
				resourceItemExtension: ".svg"
			}
		},
		SetupResultImageFail: {
			source: 3,
			params: {
				schemaName: "RawRequestBuilder",
				resourceItemName: "SetupResultImageFail",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});