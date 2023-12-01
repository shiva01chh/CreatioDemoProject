﻿define("MobileBaseDesignerModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ConfigureControlGroupButtonCaption: "Set",
		RemoveControlGroupButtonCaption: "Delete",
		AddGridLayoutItemButtonCaption: "New column",
		RemoveGridLayoutItemButtonCaption: "Delete column"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		MoveUpButtonImage: {
			source: 3,
			params: {
				schemaName: "MobileBaseDesignerModule",
				resourceItemName: "MoveUpButtonImage",
				hash: "eb1f9fd18ef6ffa338ffba77770fd4dc",
				resourceItemExtension: ".png"
			}
		},
		MoveDownButtonImage: {
			source: 3,
			params: {
				schemaName: "MobileBaseDesignerModule",
				resourceItemName: "MoveDownButtonImage",
				hash: "f153bce1fae18e7c3ca7297e51e192e4",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});