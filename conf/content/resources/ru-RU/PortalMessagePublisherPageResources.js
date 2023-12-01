﻿define("PortalMessagePublisherPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		WritePortalPostHint: "\u0412\u0430\u0448\u0435 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u0431\u0443\u0434\u0435\u0442 \u043E\u043F\u0443\u0431\u043B\u0438\u043A\u043E\u0432\u0430\u043D\u043E \u043D\u0430 \u043F\u043E\u0440\u0442\u0430\u043B\u0435",
		WritePortalPostHintOnPortal: "\u041E\u0441\u0442\u0430\u0432\u044C\u0442\u0435 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u0434\u043B\u044F \u0421\u043B\u0443\u0436\u0431\u044B \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u043A\u0438",
		DraftBodyMessage: "DRAFT",
		PortalMaskCaption: "\u0421\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u043E\u043F\u0443\u0431\u043B\u0438\u043A\u043E\u0432\u0430\u043D\u043E",
		OversizedFilesErrorMessage: "\u0421\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0435 \u0444\u0430\u0439\u043B\u044B \u043D\u0435 \u0431\u044B\u043B\u0438 \u0437\u0430\u0433\u0440\u0443\u0436\u0435\u043D\u044B \u0438\u0437-\u0437\u0430 \u043E\u0433\u0440\u0430\u043D\u0438\u0447\u0435\u043D\u0438\u044F \u043C\u0430\u043A\u0441\u0438\u043C\u0430\u043B\u044C\u043D\u043E\u0433\u043E \u0440\u0430\u0437\u043C\u0435\u0440\u0430 \u0444\u0430\u0439\u043B\u0430 ({0} \u041C\u0431): {1}",
		EmptyMessageError: "\u041F\u0443\u0441\u0442\u043E\u0435 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		ToolbarVisibilityButtonImage: {
			source: 3,
			params: {
				schemaName: "PortalMessagePublisherPage",
				resourceItemName: "ToolbarVisibilityButtonImage",
				hash: "e00cdf2dfbf00fac7b8837a2e9227aef",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});