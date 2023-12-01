define("CampaignDeduplicatorSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "\u0418\u0441\u043A\u043B\u044E\u0447\u0438\u0442\u044C \u0434\u0443\u0431\u043B\u0438",
		AsyncWithoutIncomingsMessage: "\u0412 \u0441\u0445\u0435\u043C\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0435\u0441\u0442\u044C \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0431\u0435\u0437 \u0432\u0445\u043E\u0434\u044F\u0449\u0438\u0445 \u0441\u0442\u0440\u0435\u043B\u043E\u043A"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		LargeImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "LargeImage",
				hash: "d2026ba1c9a1accd0aad3cddb484eef6",
				resourceItemExtension: ".svg"
			}
		},
		SmallImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "SmallImage",
				hash: "172c06b1e941b5bc823f1fbf36cd4210",
				resourceItemExtension: ".svg"
			}
		},
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignDeduplicatorSchema",
				resourceItemName: "TitleImage",
				hash: "40b6c42e14dd80eea2bec7bad26e0741",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});