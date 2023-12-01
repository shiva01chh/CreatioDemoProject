﻿define("StructureExplorerViewConfigResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		HeaderCaption: "\u0412\u044B\u0431\u043E\u0440 \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		ItemName: "\u041E\u0431\u044A\u0435\u043A\u0442",
		ItemsName: "\u041A\u043E\u043B\u043E\u043D\u043A\u0430",
		ItemsPlaceHolder: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		ElementsPlaceHolder: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043E\u0431\u044A\u0435\u043A\u0442",
		SelectButtonText: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C",
		CancelButtonText: "\u041E\u0442\u043C\u0435\u043D\u0430"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		ExpandImage: {
			source: 3,
			params: {
				schemaName: "StructureExplorerViewConfig",
				resourceItemName: "ExpandImage",
				hash: "ab6bcb78a6be23a9399c7d1c622e9884",
				resourceItemExtension: ".svg"
			}
		},
		CloseImage: {
			source: 3,
			params: {
				schemaName: "StructureExplorerViewConfig",
				resourceItemName: "CloseImage",
				hash: "49bb4ccc176982753926920d03332241",
				resourceItemExtension: ".svg"
			}
		},
		DeleteImage: {
			source: 3,
			params: {
				schemaName: "StructureExplorerViewConfig",
				resourceItemName: "DeleteImage",
				hash: "b8a7008452ec672bd9c284d5e83091c1",
				resourceItemExtension: ".png"
			}
		},
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "StructureExplorerViewConfig",
				resourceItemName: "CloseIcon",
				hash: "bcf2d4125a9751584d37cd8d0be121ca",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});