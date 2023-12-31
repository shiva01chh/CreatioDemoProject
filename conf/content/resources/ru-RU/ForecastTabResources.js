﻿define("ForecastTabResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Add: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		Actions: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ViewOptions: "\u0412\u0438\u0434",
		CalculateFactPotentialCaption: "\u0420\u0430\u0441\u0441\u0447\u0438\u0442\u0430\u0442\u044C \u0444\u0430\u043A\u0442 \u0438 \u043F\u043E\u0442\u0435\u043D\u0446\u0438\u0430\u043B",
		CalculateFactPotentialCompleteMessage: "\u0420\u0430\u0441\u0447\u0435\u0442 \u0444\u0430\u043A\u0442\u0430 \u0438 \u043F\u043E\u0442\u0435\u043D\u0446\u0438\u0430\u043B\u0430 \u0437\u0430\u043F\u0443\u0449\u0435\u043D. \u041F\u043E \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0438 \u0440\u0430\u0441\u0447\u0435\u0442\u0430 \u0432\u044B \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u0435 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0435.",
		EditRightsMenuItemCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432",
		SetPeriod: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043F\u0435\u0440\u0438\u043E\u0434\u044B",
		Summary: "\u0418\u0442\u043E\u0433\u043E",
		Reload: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ConfigurationButtonHint: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0438\u0437\u043C\u0435\u0440\u0435\u043D\u0438\u0435",
		CalculateFactPotentialCaptionUIV2: "\u0420\u0430\u0441\u0441\u0447\u0438\u0442\u0430\u0442\u044C \u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		CalculateFactPotentialCompleteMessageUIV2: "\u0420\u0430\u0441\u0447\u0435\u0442 \u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0437\u0430\u043F\u0443\u0449\u0435\u043D. \u041F\u043E \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0438 \u0440\u0430\u0441\u0447\u0435\u0442\u0430 \u0432\u044B \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u0435 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0435.",
		ColumnsListMenuItem: "\u0421\u043F\u0438\u0441\u043E\u043A \u043A\u043E\u043B\u043E\u043D\u043E\u043A",
		PeriodsExceededErrorCaption: "\u0412\u044B\u0431\u0440\u0430\u043D\u043E \u0441\u043B\u0438\u0448\u043A\u043E\u043C \u043C\u043D\u043E\u0433\u043E \u043F\u0435\u0440\u0438\u043E\u0434\u043E\u0432 \u0434\u043B\u044F \u0440\u0430\u0441\u0447\u0451\u0442\u0430. \u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430, \u0441\u043E\u043A\u0440\u0430\u0442\u0438\u0442\u0435 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u043F\u0435\u0440\u0438\u043E\u0434\u043E\u0432 \u0434\u043E 24-\u0445 \u0438 \u043F\u043E\u0432\u0442\u043E\u0440\u043D\u043E \u0437\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u0435 \u0440\u0430\u0441\u0447\u0435\u0442.",
		Calculate: "\u0420\u0430\u0441c\u0447\u0438\u0442\u0430\u0442\u044C",
		FullscreenButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0432 \u043D\u043E\u0432\u043E\u0439 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435",
		PopupBlockedMessage: "\u0411\u0440\u0430\u0443\u0437\u0435\u0440 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0431\u043B\u043E\u043A\u0438\u0440\u0443\u0435\u0442 \u0432\u0441\u043F\u043B\u044B\u0432\u0430\u044E\u0449\u0438\u0435 \u043E\u043A\u043D\u0430. \u0414\u043B\u044F \u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E\u0439 \u0440\u0430\u0431\u043E\u0442\u044B \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F \u0432\u043A\u043B\u044E\u0447\u0438\u0442\u0435 \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0435\u043D\u0438\u0435 \u0432c\u043F\u043B\u044B\u0432\u0430\u044E\u0449\u0438\u0445 \u043E\u043A\u043E\u043D.",
		AddByEntityCaption: "\u0434\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		AddByFolderCaption: "\u0434\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0438\u0437 \u0433\u0440\u0443\u043F\u043F\u044B",
		DeleteConfirmationMessage: "\u0412\u044B \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u0442\u0435\u043B\u044C\u043D\u043E \u0445\u043E\u0442\u0438\u0442\u0435 \u0443\u0434\u0430\u043B\u0438\u0442\u044C \u0437\u0430\u043F\u0438\u0441\u044C \u0022{0}\u0022?",
		CalculationInProgressCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u0440\u0430\u0441\u0447\u0435\u0442",
		OnlyFirstNItems: "\u0421\u043B\u0438\u0448\u043A\u043E\u043C \u043C\u043D\u043E\u0433\u043E \u043F\u0435\u0440\u0438\u043E\u0434\u043E\u0432 \u0434\u043B\u044F \u0440\u0430\u0441\u0441\u0447\u0435\u0442\u0430. \u0411\u0443\u0434\u0443\u0442 \u0432\u044B\u0431\u0440\u0430\u043D\u044B \u0442\u043E\u043B\u044C\u043A\u043E \u043F\u0435\u0440\u0432\u044B\u0435 {0}"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CalculateIcon: {
			source: 3,
			params: {
				schemaName: "ForecastTab",
				resourceItemName: "CalculateIcon",
				hash: "7854e585e89a768384704c2936de6b2a",
				resourceItemExtension: ".svg"
			}
		},
		FullscreenIcon: {
			source: 3,
			params: {
				schemaName: "ForecastTab",
				resourceItemName: "FullscreenIcon",
				hash: "08d89bd0b1c1162fc12bbbbb97c60f41",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});