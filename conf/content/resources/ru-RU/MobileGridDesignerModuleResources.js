﻿define("MobileGridDesignerModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GridColumnsLabelCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		GridSubtitleColumnsLabelCaption: "\u041F\u043E\u0434\u0437\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		GridGroupColumnsLabelCaption: "\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		AddGridLayoutItemButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		ConfigureControlGroupButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C",
		RemoveControlGroupButtonCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		RemoveGridLayoutItemButtonCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C \u043A\u043E\u043B\u043E\u043D\u043A\u0443"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		MoveUpButtonImage: {
			source: 3,
			params: {
				schemaName: "MobileGridDesignerModule",
				resourceItemName: "MoveUpButtonImage",
				hash: "eb1f9fd18ef6ffa338ffba77770fd4dc",
				resourceItemExtension: ".png"
			}
		},
		MoveDownButtonImage: {
			source: 3,
			params: {
				schemaName: "MobileGridDesignerModule",
				resourceItemName: "MoveDownButtonImage",
				hash: "f153bce1fae18e7c3ca7297e51e192e4",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});