﻿define("CampaignSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		TypeCaption: "\u041A\u0430\u043C\u043F\u0430\u043D\u0438\u044E",
		PropertiesPageCaption: "\u041A\u0430\u043C\u043F\u0430\u043D\u0438\u044F",
		LoopWithoutDelayedTransitionsMessage: "\u0412\u044B \u0441\u043E\u0445\u0440\u0430\u043D\u044F\u0435\u0442\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044E \u0441 \u0446\u0438\u043A\u043B\u0438\u0447\u043D\u043E\u0439 \u0441\u0445\u0435\u043C\u043E\u0439. \u0412 \u0441\u0432\u044F\u0437\u0438 \u0441 \u043E\u0441\u043E\u0431\u0435\u043D\u043D\u043E\u0441\u0442\u044F\u043C\u0438 \u0441\u0445\u0435\u043C\u044B, \u0434\u043B\u044F \u0441\u0432\u044F\u0437\u0438 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u0432 \u0446\u0438\u043A\u043B\u0430 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043F\u043E\u0442\u043E\u043A \u0022\u041F\u0435\u0440\u0435\u0445\u043E\u0434 \u0441 \u0443\u0441\u043B\u043E\u0432\u0438\u0435\u043C\u0022 \u0438 \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u0437\u0430\u0434\u0435\u0440\u0436\u043A\u0443 \u043F\u0435\u0440\u0435\u0434 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435\u043C \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u0432 \u0432 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430\u0445 \u043F\u043E\u0442\u043E\u043A\u0430. \u0415\u0441\u043B\u0438 \u0432\u044B \u0441\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u0435 \u0438 \u0437\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044E \u0431\u0435\u0437 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439, \u043B\u043E\u0433\u0438\u043A\u0430 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\u0445\u0435\u043C\u044B \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043D\u0430\u0440\u0443\u0448\u0435\u043D\u0430."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TitleImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchema",
				resourceItemName: "TitleImage",
				hash: "57f1241a319f56e8fa03819ce08d724e",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});