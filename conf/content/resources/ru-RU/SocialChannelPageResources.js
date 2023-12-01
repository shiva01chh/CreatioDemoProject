﻿define("SocialChannelPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SubscribeButtonCaption: "\u041F\u043E\u0434\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F",
		UnsubscribeButtonCaption: "\u041E\u0442\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F",
		AllUsersPublisherRights: "\u0412\u0441\u0435 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438 \u043C\u043E\u0433\u0443\u0442 \u043F\u0443\u0431\u043B\u0438\u043A\u043E\u0432\u0430\u0442\u044C \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u044F",
		EditorsPublisherRights: "\u0422\u043E\u043B\u044C\u043A\u043E \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438 \u0441 \u043F\u0440\u0430\u0432\u043E\u043C \u043D\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435 \u043A\u0430\u043D\u0430\u043B\u0430 \u043C\u043E\u0433\u0443\u0442 \u043F\u0443\u0431\u043B\u0438\u043A\u043E\u0432\u0430\u0442\u044C \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u044F",
		PublisherRightKind: "\u0420\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u0435 \u043F\u0443\u0431\u043B\u0438\u043A\u0430\u0446\u0438\u0438 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0439"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		SocialChannelImage: {
			source: 3,
			params: {
				schemaName: "SocialChannelPage",
				resourceItemName: "SocialChannelImage",
				hash: "3a2f64d3488d6a622fce21b5679c1dd4",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});