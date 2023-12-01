define("MarketingEmailSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Marketing email",
		AsyncWithoutIncomingsMessage: "There are elements without inbound connections in your campaign"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "MarketingEmailSchema",
				resourceItemName: "TitleImage",
				hash: "fb671ba0bf99224b10d5e804ebada097",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "MarketingEmailSchema",
				resourceItemName: "LargeImage",
				hash: "195aa0473d0795c6711022d753155bf6",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "MarketingEmailSchema",
				resourceItemName: "SmallImage",
				hash: "3668bd054fc7cba9d8b1665256afe401",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});