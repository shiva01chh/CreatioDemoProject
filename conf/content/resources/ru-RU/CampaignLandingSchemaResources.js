define("CampaignLandingSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "\u041B\u0435\u043D\u0434\u0438\u043D\u0433",
		AsyncWithoutIncomingsMessage: "\u0412 \u0441\u0445\u0435\u043C\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0435\u0441\u0442\u044C \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0431\u0435\u0437 \u0432\u0445\u043E\u0434\u044F\u0449\u0438\u0445 \u0441\u0442\u0440\u0435\u043B\u043E\u043A"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "TitleImage",
				hash: "36509169995b1bd08b81e7601b00cfb6",
				resourceItemExtension: ".svg"
			}
		},
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "LargeImage",
				hash: "58daf4c89d0ab06ff7b97bb46dd5c30c",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignLandingSchema",
				resourceItemName: "SmallImage",
				hash: "043b5c058db62b7cd916a1d83da99231",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});