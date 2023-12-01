﻿define("SupplyPaymentPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		AmountNegative: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0441\u0443\u043C\u043C\u044B \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043E\u0442\u0440\u0438\u0446\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u043C",
		ProductTab: "\u041F\u0440\u043E\u0434\u0443\u043A\u0442\u044B",
		Currency: "\u0412\u0430\u043B\u044E\u0442\u0430",
		CurrencyRate: "\u041A\u0443\u0440\u0441",
		AmountPlanNegative: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u044F \u0022\u0421\u0443\u043C\u043C\u0430, \u043F\u043B\u0430\u043D\u0022 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043E\u0442\u0440\u0438\u0446\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u043C",
		AmountFactNegative: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u044F \u0022\u0421\u0443\u043C\u043C\u0430, \u0444\u0430\u043A\u0442\u0022 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043E\u0442\u0440\u0438\u0446\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u043C",
		PercentageForSupplyIsNotEditableHint: "\u041F\u043E\u043B\u0435 \u0022\u0414\u043E\u043B\u044F, %\u0022 \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u043D\u043E \u0434\u043B\u044F \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0432 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0435",
		PercentageForPaymentsWithProductIsNotEditableHint: "\u041F\u043E\u043B\u0435 \u0022\u0414\u043E\u043B\u044F, %\u0022 \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u043D\u043E \u0434\u043B\u044F \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0432 \u043E\u043F\u043B\u0430\u0442\u0430\u0445, \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0449\u0438\u0445 \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u044B",
		ChangeInvoice: "\u041F\u043E \u043E\u043F\u043B\u0430\u0442\u0435 \u0432\u044B\u0441\u0442\u0430\u0432\u043B\u0435\u043D \u0441\u0447\u0435\u0442. \u0412\u044B \u0445\u043E\u0442\u0438\u0442\u0435 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u0441\u0447\u0435\u0442\u0430?",
		DatePlanTip: "\u041F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u0430\u044F \u0434\u0430\u0442\u0430 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0438 \u0438\u043B\u0438 \u043E\u043F\u043B\u0430\u0442\u044B. \u0420\u0430\u0441\u0441\u0447\u0438\u0442\u044B\u0432\u0430\u0435\u0442\u0441\u044F \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0432 \u0437\u0430\u0432\u0438\u0441\u0438\u043C\u043E\u0441\u0442\u0438 \u043E\u0442 \u0434\u0430\u0442\u044B \u043F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0435\u0433\u043E \u0448\u0430\u0433\u0430 \u0438 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u0430 \u0434\u043D\u0435\u0439 \u043E\u0442\u0441\u0440\u043E\u0447\u043A\u0438. \u041F\u0440\u0438 \u0432\u044B\u0431\u043E\u0440\u0435 \u0442\u0438\u043F\u0430 \u043E\u0442\u0441\u0440\u043E\u0447\u043A\u0438 \u201C\u0424\u0438\u043A\u0441\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u0430\u044F \u0434\u0430\u0442\u0430\u201D \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0432\u0440\u0443\u0447\u043D\u0443\u044E",
		PercentageTip: "\u041F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u044B\u0439 \u043F\u0440\u043E\u0446\u0435\u043D\u0442 \u043E\u043F\u043B\u0430\u0442\u044B \u0438\u043B\u0438 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0438 \u043E\u0442 \u043E\u0431\u0449\u0435\u0439 \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u0438 \u0437\u0430\u043A\u0430\u0437\u0430. \u041F\u0440\u0438 \u0432\u044B\u0431\u043E\u0440\u0435 \u0442\u0438\u043F\u0430 \u0448\u0430\u0433\u0430 \u0432 \u043F\u043E\u043B\u0435 \u0431\u0443\u0434\u0435\u0442 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0443\u043A\u0430\u0437\u0430\u043D \u043F\u0440\u043E\u0446\u0435\u043D\u0442, \u043D\u0435 \u0440\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u043D\u044B\u0439 \u043F\u043E \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0430\u043C \u0438 \u043E\u043F\u043B\u0430\u0442\u0430\u043C \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0437\u0430\u043A\u0430\u0437\u0430. \u041F\u0440\u043E\u0434\u0443\u043A\u0442\u044B, \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043D\u044B\u0435 \u0432 \u0448\u0430\u0433 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0438 \u0438\u043B\u0438 \u043E\u043F\u043B\u0430\u0442\u044B, \u0443\u0447\u0438\u0442\u044B\u0432\u0430\u044E\u0442\u0441\u044F \u043F\u0440\u0438 \u0440\u0430\u0441\u0447\u0435\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F",
		AmountPlanTip: "\u041F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u0430\u044F \u0441\u0443\u043C\u043C\u0430 \u043E\u043F\u043B\u0430\u0442\u044B \u0438\u043B\u0438 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0438. \u0420\u0430\u0441\u0441\u0447\u0438\u0442\u044B\u0432\u0430\u0435\u0442\u0441\u044F \u043E\u0442 \u0434\u043E\u043B\u0438 \u0437\u0430\u043A\u0430\u0437\u0430 \u0438\u043B\u0438 \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0430\u043D\u0438\u0438 \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u043E\u0432, \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043D\u044B\u0445 \u0432 \u0448\u0430\u0433 \u0433\u0440\u0430\u0444\u0438\u043A\u0430 \u043F\u043E\u0441\u0442\u0430\u0432\u043E\u043A \u0438 \u043E\u043F\u043B\u0430\u0442",
		PreviousElementTip: "\u041F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0430\u044F \u043E\u043F\u043B\u0430\u0442\u0430 \u0438\u043B\u0438 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0430, \u043E\u0442 \u0434\u0430\u0442\u044B \u043A\u043E\u0442\u043E\u0440\u043E\u0439 \u0431\u0443\u0434\u0435\u0442 \u0440\u0430\u0441\u0441\u0447\u0438\u0442\u044B\u0432\u0430\u0442\u044C\u0441\u044F \u043F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u0430\u044F \u0434\u0430\u0442\u0430 \u0442\u0435\u043A\u0443\u0449\u0435\u0439 \u043E\u043F\u043B\u0430\u0442\u044B \u0438\u043B\u0438 \u043F\u043E\u0441\u0442\u0430\u0432\u043A\u0438. \u041F\u043E\u043B\u0435 \u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0441\u044F \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u043C \u0434\u043B\u044F \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F, \u0435\u0441\u043B\u0438 \u0432 \u043F\u043E\u043B\u0435 [\u0422\u0438\u043F \u043E\u0442\u0441\u0440\u043E\u0447\u043A\u0438] \u0443\u043A\u0430\u0437\u0430\u043D\u043E \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u201C\u041E\u0442\u0441\u0440\u043E\u0447\u043A\u0430 \u043E\u0442 \u043F\u043B\u0430\u043D\u0430\u201D \u0438\u043B\u0438 \u201C\u041E\u0442\u0441\u0440\u043E\u0447\u043A\u0430 \u043E\u0442 \u0444\u0430\u043A\u0442\u0430\u201D",
		DelayTypeTip: "\u0422\u0438\u043F \u043E\u0442\u0441\u0440\u043E\u0447\u043A\u0438 \u0434\u043B\u044F \u0440\u0430\u0441\u0447\u0435\u0442\u0430 \u043F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u043E\u0439 \u0434\u0430\u0442\u044B \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u0441\u0442\u0432\u0430. \u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u201C\u0424\u0438\u043A\u0441\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u0430\u044F \u0434\u0430\u0442\u0430\u201D \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0434\u043B\u044F \u0443\u043A\u0430\u0437\u0430\u043D\u0438\u044F \u043F\u043B\u0430\u043D\u043E\u0432\u043E\u0439 \u0434\u0430\u0442\u044B \u0432\u0440\u0443\u0447\u043D\u0443\u044E, \u0432\u0441\u0435\u0433\u0434\u0430 \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0435\u0442\u0441\u044F \u0434\u043B\u044F \u043F\u0435\u0440\u0432\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438 \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u0438. \u0417\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u201C\u041E\u0442\u0441\u0440\u043E\u0447\u043A\u0430 \u043E\u0442 \u043F\u043B\u0430\u043D\u0430\u201D \u0438 \u201C\u041E\u0442\u0441\u0440\u043E\u0447\u043A\u0430 \u043E\u0442 \u0444\u0430\u043A\u0442\u0430\u201D \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u044E\u0442\u0441\u044F \u0434\u043B\u044F \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u0440\u0430\u0441\u0447\u0435\u0442\u0430 \u0434\u0430\u0442\u044B \u043E\u0442 \u043F\u043B\u0430\u043D\u0438\u0440\u0443\u0435\u043C\u043E\u0439 \u0438\u043B\u0438 \u0444\u0430\u043A\u0442\u0438\u0447\u0435\u0441\u043A\u043E\u0439 \u0434\u0430\u0442\u044B \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0435\u0433\u043E \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u0441\u0442\u0432\u0430. \u041F\u0440\u0438 \u0432\u044B\u0431\u043E\u0440\u0435 \u044D\u0442\u0438\u0445 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0439 \u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0441\u044F \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u043C \u0434\u043B\u044F \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043F\u043E\u043B\u0435 [\u041F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0438\u0439 \u0448\u0430\u0433]. \u0415\u0441\u043B\u0438 \u0442\u0438\u043F \u043E\u0442\u0441\u0440\u043E\u0447\u043A\u0438 \u2014 \u201C\u041E\u0442\u0441\u0440\u043E\u0447\u043A\u0430 \u043E\u0442 \u0444\u0430\u043A\u0442\u0430\u201D, \u043D\u043E \u043D\u0430 \u043F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0435\u043C \u0448\u0430\u0433\u0435 \u0444\u0430\u043A\u0442\u0438\u0447\u0435\u0441\u043A\u0430\u044F \u0434\u0430\u0442\u0430 \u043D\u0435 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0430, \u0442\u043E \u0440\u0430\u0441\u0447\u0435\u0442 \u0431\u0443\u0434\u0435\u0442 \u043F\u0440\u043E\u0438\u0437\u0432\u043E\u0434\u0438\u0442\u044C\u0441\u044F \u043E\u0442 \u043F\u043B\u0430\u043D\u043E\u0432\u043E\u0439 \u0434\u0430\u0442\u044B \u043F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0435\u0433\u043E \u0448\u0430\u0433\u0430",
		ChangeInvoiceStatusWarning: "\u0412\u044B \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u0442\u0435\u043B\u044C\u043D\u043E \u0445\u043E\u0442\u0438\u0442\u0435 \u043E\u0442\u043C\u0435\u043D\u0438\u0442\u044C \u0441\u0447\u0435\u0442 \u0438 \u043E\u0442\u0432\u044F\u0437\u0430\u0442\u044C \u0435\u0433\u043E \u043E\u0442 \u0433\u0440\u0430\u0444\u0438\u043A\u0430 \u043F\u043E\u0441\u0442\u0430\u0432\u043E\u043A \u0438 \u043E\u043F\u043B\u0430\u0442?"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentPageV2",
				resourceItemName: "TagButtonIcon"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});