﻿define("CampaignAddToEventSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0432 \u043C\u0435\u0440\u043E\u043F\u0440\u0438\u044F\u0442\u0438\u0435",
		AsyncWithoutIncomingsMessage: "\u0412 \u0441\u0445\u0435\u043C\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0435\u0441\u0442\u044C \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0431\u0435\u0437 \u0432\u0445\u043E\u0434\u044F\u0449\u0438\u0445 \u0441\u0442\u0440\u0435\u043B\u043E\u043A"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "TitleImage",
				hash: "e7412153f08bc0a42f1060c5e6112a85",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "SmallImage",
				hash: "aa1ab4e230a9158eb3e8ae03c77c6593",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignAddToEventSchema",
				resourceItemName: "LargeImage",
				hash: "50874aef26b9e59b6f0f74e459a416d9",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});