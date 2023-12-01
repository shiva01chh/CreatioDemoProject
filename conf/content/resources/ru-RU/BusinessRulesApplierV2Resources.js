﻿define("BusinessRulesApplierV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		InvalidRuleFormatExceptionException: "\u041D\u0435\u0432\u0435\u0440\u043D\u044B\u0439 \u0444\u043E\u0440\u043C\u0430\u0442 \u043F\u0440\u0430\u0432\u0438\u043B\u0430 \u0022{0}\u0022",
		ThrownException: "\u0412 \u043C\u0435\u0442\u043E\u0434\u0435 \u0027{0}\u0027 \u0431\u044B\u043B\u043E \u0432\u044B\u0431\u0440\u043E\u0448\u0435\u043D\u043E \u0438\u0441\u043A\u043B\u044E\u0447\u0435\u043D\u0438\u0435 \u0441 \u0442\u0435\u043A\u0441\u0442\u043E\u043C: \u0027{1}\u0027.",
		ConditionFieldIsPresentedInActionError: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u0430\u0432\u0438\u043B\u0435 \u0022{0}\u0022: \u0443\u0441\u043B\u043E\u0432\u0438\u0435 \u043D\u0435 \u0434\u043E\u043B\u0436\u043D\u043E \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u044C \u043F\u043E\u043B\u0435\u0439 \u0438\u0437 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		InvalidActionColumnError: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0435 \u0022{0}\u0022: \u043A\u043E\u043B\u043E\u043D\u043A\u0430 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u0022{1}\u0022 \u0431\u044B\u043B\u0430 \u0443\u0434\u0430\u043B\u0435\u043D\u0430 \u0438\u043B\u0438 \u043F\u0435\u0440\u0435\u0438\u043C\u0435\u043D\u043E\u0432\u0430\u043D\u0430",
		InvalidSysSetting: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0435: \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u0430\u044F \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0022{0}\u0022 \u0431\u044B\u043B\u0430 \u0443\u0434\u0430\u043B\u0435\u043D\u0430 \u0438\u043B\u0438 \u043F\u0435\u0440\u0435\u0438\u043C\u0435\u043D\u043E\u0432\u0430\u043D\u0430",
		InvalidColumn: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0435: \u043A\u043E\u043B\u043E\u043D\u043A\u0430 \u0022{0}\u0022 \u0431\u044B\u043B\u0430 \u0443\u0434\u0430\u043B\u0435\u043D\u0430 \u0438\u043B\u0438 \u043F\u0435\u0440\u0435\u0438\u043C\u0435\u043D\u043E\u0432\u0430\u043D\u0430",
		InvalidSysValue: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0435: \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0022{0}\u0022 \u0431\u044B\u043B\u043E \u0443\u0434\u0430\u043B\u0435\u043D\u043E \u0438\u043B\u0438 \u043F\u0435\u0440\u0435\u0438\u043C\u0435\u043D\u043E\u0432\u0430\u043D\u043E",
		InvalidTabExceptionMessage: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0435: \u0432\u043A\u043B\u0430\u0434\u043A\u0430 \u0022{0}\u0022 \u0431\u044B\u043B\u0430 \u0443\u0434\u0430\u043B\u0435\u043D\u0430 \u0438\u043B\u0438 \u043F\u0435\u0440\u0435\u0438\u043C\u0435\u043D\u043E\u0432\u0430\u043D\u0430"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});