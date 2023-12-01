﻿define("GridUtilitiesV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AscendingDirectionCaption: "\u043F\u043E \u0432\u043E\u0437\u0440\u0430\u0441\u0442\u0430\u043D\u0438\u044E",
		DescendingDirectionCaption: "\u043F\u043E \u0443\u0431\u044B\u0432\u0430\u043D\u0438\u044E",
		DependencyWarningMessage: "\u0412\u044B\u0431\u0440\u0430\u043D\u043D\u044B\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0443\u0434\u0430\u043B\u0438\u0442\u044C \u043D\u0435\u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E, \u0442\u0430\u043A \u043A\u0430\u043A \u043E\u043D\u0438 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u044E\u0442\u0441\u044F \u0432 \u0434\u0440\u0443\u0433\u0438\u0445 \u043E\u0431\u044A\u0435\u043A\u0442\u0430\u0445.",
		RightLevelWarningMessage: "\u0412\u044B\u0431\u0440\u0430\u043D\u043D\u044B\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0443\u0434\u0430\u043B\u0438\u0442\u044C \u043D\u0435\u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E, \u0442\u0430\u043A \u043A\u0430\u043A \u0443 \u0412\u0430\u0441 \u043D\u0435\u0442 \u043F\u0440\u0430\u0432 \u043D\u0430 \u0443\u0434\u0430\u043B\u0435\u043D\u0438\u0435 \u044D\u0442\u0438\u0445 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u0432.",
		RecordsAddedToStaticFolder: "\u0412 \u0433\u0440\u0443\u043F\u043F\u0443 {0} \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043E {1} \u0437\u0430\u043F\u0438\u0441\u0435\u0439",
		AddRecordsToStaticFolderErrorMessage: "\u041F\u0440\u0438 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0438 \u0437\u0430\u043F\u0438\u0441\u0435\u0439 \u0432 \u0433\u0440\u0443\u043F\u043F\u0443 \u043F\u0440\u043E\u0438\u0437\u043E\u0448\u043B\u0430 \u043E\u0448\u0438\u0431\u043A\u0430. \u041E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u043C\u0443 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443.",
		LicenceNotFound: "\u0423 \u0432\u0430\u0441 \u043E\u0442\u0441\u0443\u0442\u0441\u0442\u0432\u0443\u0435\u0442 \u043B\u0438\u0446\u0435\u043D\u0437\u0438\u044F \u0434\u043B\u044F \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u044D\u0442\u043E\u0439 \u043E\u043F\u0435\u0440\u0430\u0446\u0438\u0438. \u0421\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0439 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440 \u043C\u043E\u0436\u0435\u0442 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u043D\u0430\u0431\u043E\u0440 \u043F\u0440\u0435\u0434\u043E\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u043D\u044B\u0445 \u043B\u0438\u0446\u0435\u043D\u0437\u0438\u0439 \u0432 \u043C\u0435\u043D\u0435\u0434\u0436\u0435\u0440\u0435 \u043B\u0438\u0446\u0435\u043D\u0437\u0438\u0439 \u0438\u043B\u0438 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F",
		DataInputRestrictedDeleteMessage: "\u041D\u0435\u0434\u043E\u0441\u0442\u0430\u0442\u043E\u0447\u043D\u043E \u043F\u0440\u0430\u0432 \u0434\u043B\u044F \u0443\u0434\u0430\u043B\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438 \u0438\u043B\u0438 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u043B\u0438\u0446\u0435\u043D\u0437\u0438\u044F \u0441 \u043E\u0433\u0440\u0430\u043D\u0438\u0447\u0435\u043D\u043D\u044B\u043C \u0434\u043E\u0441\u0442\u0443\u043F\u043E\u043C"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});