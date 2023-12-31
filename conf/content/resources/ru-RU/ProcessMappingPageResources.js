﻿define("ProcessMappingPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		TabParametersMappingCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430",
		TabElementsMappingCaption: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430",
		TabSysSettingsMappingCaption: "\u0421\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		TabValueMappingCaption: "\u0412\u044B\u0431\u043E\u0440 \u0438\u0437 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430",
		TabSystemVariablesMappingCaption: "\u0421\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u043D\u043D\u044B\u0435",
		TabFunctionsMappingCaption: "\u0424\u0443\u043D\u043A\u0446\u0438\u0438",
		TabDateTimeMappingCaption: "\u0414\u0430\u0442\u0430 \u0438 \u0432\u0440\u0435\u043C\u044F",
		HeaderCaption: "\u0424\u043E\u0440\u043C\u0443\u043B\u0430",
		PlaceholderCaption: "\u0414\u0432\u0430\u0436\u0434\u044B \u0449\u0435\u043B\u043A\u043D\u0438\u0442\u0435 \u043D\u0430 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u043D\u0430 \u043E\u0434\u043D\u043E\u0439 \u0438\u0437 \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u043D\u0438\u0436\u0435, \u0447\u0442\u043E\u0431\u044B \u0434\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0435\u0433\u043E \u0432 \u0444\u043E\u0440\u043C\u0443\u043B\u0443",
		ValueMappingLookupSchemaPlaceholder: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043E\u0431\u044A\u0435\u043A\u0442",
		HeaderCaptionParametersMapping: "\u0412\u044B\u0431\u043E\u0440 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430",
		HeaderCaptionLookupMapping: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430",
		HeaderSysSettingsMappingCaption: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u0439 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		ElementParametersMappingCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430",
		FormulaHelpButtonCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043E \u0444\u043E\u0440\u043C\u0443\u043B\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "ProcessMappingPage",
				resourceItemName: "CloseIcon",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});