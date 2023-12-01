define("MarketingEmailSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Email-\u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0430",
		AsyncWithoutIncomingsMessage: "\u0412 \u0441\u0445\u0435\u043C\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0435\u0441\u0442\u044C \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0431\u0435\u0437 \u0432\u0445\u043E\u0434\u044F\u0449\u0438\u0445 \u0441\u0442\u0440\u0435\u043B\u043E\u043A"
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