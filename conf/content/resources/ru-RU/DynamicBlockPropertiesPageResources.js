﻿define("DynamicBlockPropertiesPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SegmentSettingsLabel: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0435\u0433\u043C\u0435\u043D\u0442\u043E\u0432 \u0434\u043B\u044F \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u0431\u043B\u043E\u043A\u0430",
		AddSegmentButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0435\u0433\u043C\u0435\u043D\u0442",
		AddDefaultSegmentButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u043E\u043D\u0442\u0435\u043D\u0442 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E",
		DefaultSegmentHint: "\u0415\u0441\u043B\u0438 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D \u043A\u043E\u043D\u0442\u0435\u043D\u0442 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E, \u0442\u043E Creatio \u043F\u0440\u043E\u043F\u0443\u0441\u0442\u0438\u0442 \u044D\u0442\u043E\u0442 \u0431\u043B\u043E\u043A \u0434\u043B\u044F \u0432\u0441\u0435\u0445 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u043E\u0442\u0432\u0435\u0447\u0430\u044E\u0442 \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C \u0441\u0435\u0433\u043C\u0435\u043D\u0442\u043E\u0432",
		DefaultSegmentCaption: "\u041F\u043E \u0423\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E",
		AddRuleBeforeCreateSegment: " \u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430, \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u043F\u0440\u0430\u0432\u0438\u043B\u0430 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430 \u043D\u0430 \u0432\u043A\u043B\u0430\u0434\u043A\u0435 \u00AB\u041F\u0440\u0430\u0432\u0438\u043B\u0430\u00BB",
		NoAvailableRuleMessage: "\u0414\u043B\u044F \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0448\u0430\u0431\u043B\u043E\u043D\u0430 \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u0443\u0436\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u043D\u044B \u0432\u0441\u0435 \u043F\u0440\u0430\u0432\u0438\u043B\u0430 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430. \u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430, \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u043D\u043E\u0432\u044B\u0435 \u043F\u0440\u0430\u0432\u0438\u043B\u0430 \u0438 \u043F\u043E\u0432\u0442\u043E\u0440\u0438\u0442\u0435 \u043F\u043E\u043F\u044B\u0442\u043A\u0443",
		MaxReplicasCountLimitReached: "\u0428\u0430\u0431\u043B\u043E\u043D \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u043C\u043E\u0436\u0435\u0442 \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u044C \u043D\u0435 \u0431\u043E\u043B\u0435\u0435 {0} \u0432\u0430\u0440\u0438\u0430\u043D\u0442\u043E\u0432 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430. {1}-\u0439 \u0432\u0430\u0440\u0438\u0430\u043D\u0442 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D",
		NotGroupItemSelectedCaption: "\u0412\u044B\u0431\u0440\u0430\u043D\u043D\u044B\u0439 \u044D\u043B\u0435\u043C\u0435\u043D\u0442 \u043D\u0435 \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u0438\u0432\u0430\u0435\u0442 \u0440\u0430\u0431\u043E\u0442\u0443 \u0441 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u0438\u043C \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u043E\u043C. \u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430, \u0432\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0431\u043B\u043E\u043A \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430 \u0434\u043B\u044F \u0440\u0430\u0431\u043E\u0442\u044B \u0441 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u0438\u043C \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u043E\u043C."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddButtonIcon: {
			source: 3,
			params: {
				schemaName: "DynamicBlockPropertiesPage",
				resourceItemName: "AddButtonIcon",
				hash: "82ee0c659590cd80a000af35c1f14d59",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});