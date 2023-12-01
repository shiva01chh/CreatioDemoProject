﻿define("DetailWizardResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		NewDetailWizardCaption: "\u041D\u043E\u0432\u0430\u044F \u0434\u0435\u0442\u0430\u043B\u044C",
		SavingEntitySchemasMessage: "\u0421\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u0435 \u0441\u0445\u0435\u043C \u043E\u0431\u044A\u0435\u043A\u0442\u043E\u0432",
		UpdatingDBStructureMessage: "\u041E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u0441\u0442\u0440\u0443\u043A\u0442\u0443\u0440\u044B \u0411\u0414",
		CompilingMessage: "\u041A\u043E\u043C\u043F\u0438\u043B\u044F\u0446\u0438\u044F",
		SavingClientUnitSchemasMessage: "\u0421\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u0435 \u043A\u043B\u0438\u0435\u043D\u0442\u0441\u043A\u0438\u0445 \u0441\u0445\u0435\u043C",
		SchemaRegistrationMessage: "\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044F \u0441\u0445\u0435\u043C",
		PageRegistrationMessage: "\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u044F \u0441\u0442\u0440\u0430\u043D\u0438\u0446",
		SavingSuccessMessage: "\u0418\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0443\u0441\u043F\u0435\u0448\u043D\u043E \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u044B",
		CurrentPackageIdIsEmpty: "\u0421\u0438\u0441\u0442\u0435\u043C\u043D\u0430\u044F \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0027\u0422\u0435\u043A\u0443\u0449\u0438\u0439 \u043F\u0430\u043A\u0435\u0442\u0027 \u043D\u0435 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u0430",
		MainSettingsStepCaption: "\u0414\u0435\u0442\u0430\u043B\u044C",
		PageDesignerStepCaption: "\u0421\u0442\u0440\u0430\u043D\u0438\u0446\u0430",
		CurrentPackageNotFound: "\u041F\u0430\u043A\u0435\u0442 \u0438\u0437 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u0439 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u0027\u0422\u0435\u043A\u0443\u0449\u0438\u0439 \u043F\u0430\u043A\u0435\u0442\u0027 \u043D\u0435 \u043D\u0430\u0439\u0434\u0435\u043D",
		RightsErrorMessage: "\u0423 \u0432\u0430\u0441 \u043D\u0435\u0442 \u043F\u0440\u0430\u0432 \u043D\u0430 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F. \u041E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u043C\u0443 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443.",
		MainSettingsCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u044B\u0435 \u0441\u0432\u043E\u0439\u0441\u0442\u0432\u0430",
		SetPackageNameInfo: "\u0421\u0438\u0441\u0442\u0435\u043C\u043D\u0430\u044F \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0022\u0422\u0435\u043A\u0443\u0449\u0438\u0439 \u043F\u0430\u043A\u0435\u0442\u0022 \u043D\u0435 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u0430. \u0412\u0441\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0431\u0443\u0434\u0443\u0442 \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u044B \u0432 \u043F\u0430\u043A\u0435\u0442 \u0022{0}\u0022. \u0414\u043B\u044F \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u043F\u0430\u043A\u0435\u0442\u0430 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u0443\u044E \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0443.",
		RegeneratingClientBundles: "\u041E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043A\u043B\u0438\u0435\u043D\u0442\u0441\u043A\u0438\u0445 \u0441\u0445\u0435\u043C",
		BusinessRulesStepCaption: "\u0411\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u0430\u0432\u0438\u043B\u0430",
		BusinessProcessesCaption: "\u0411\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		DetailSysModuleEntityAbsentMessage: "\u0412 \u0431\u0430\u0437\u0435 \u0434\u0430\u043D\u043D\u044B\u0445 \u0445\u0440\u0430\u043D\u044F\u0442\u0441\u044F \u043D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u044B\u0435 \u0434\u0430\u043D\u043D\u044B\u0435, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u043F\u043E\u0437\u0432\u043E\u043B\u044F\u044E\u0442 \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0434\u0435\u0442\u0430\u043B\u044C. \u0412 \u0442\u0430\u0431\u043B\u0438\u0446\u0435 \u0027SysModuleEntity\u0027 \u043D\u0435\u0442 \u0437\u0430\u043F\u0438\u0441\u0435\u0439 \u0441 \u0027EntitySchemaUId\u0027 = \u0027{0}\u0027, \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0449\u0435\u0439 \u044D\u0442\u043E\u0439 \u0434\u0435\u0442\u0430\u043B\u0438 \u0432 \u0442\u0430\u0431\u043B\u0438\u0446\u0435 \u0027SysDetail\u0027."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});