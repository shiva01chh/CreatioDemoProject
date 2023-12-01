﻿define("EntityColumnPropertiesPageModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		NumberDataTypeCaption: "\u0422\u043E\u0447\u043D\u043E\u0441\u0442\u044C",
		TextDateTypeCaption: "\u0414\u043B\u0438\u043D\u0430 \u0441\u0442\u0440\u043E\u043A\u0438",
		DateTypeCaption: "\u0424\u043E\u0440\u043C\u0430\u0442",
		SelectValueCaption: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0438\u0437 \u0441\u043F\u0438\u0441\u043A\u0430",
		LookupSchemaDoesNotHavePrimaryDisplayColumnMsg: "\u0423 \u0432\u044B\u0431\u0440\u0430\u043D\u043D\u043E\u0433\u043E \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430 \u043D\u0435 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043E \u0441\u0432\u043E\u0439\u0441\u0442\u0432\u043E \u0022\u041E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0435\u043C\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u0022. \u042D\u0442\u043E \u043D\u0435 \u043F\u043E\u0437\u0432\u043E\u043B\u0438\u0442 \u0432\u044B\u0431\u0438\u0440\u0430\u0442\u044C \u0438\u0437 \u043D\u0435\u0433\u043E \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F. \u0423\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u044D\u0442\u043E \u0441\u0432\u043E\u0439\u0441\u0442\u0432\u043E \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u0022\u0423\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u0435\u0439\u0022 \u0438 \u043F\u043E\u0432\u0442\u043E\u0440\u0438\u0442\u0435 \u043F\u043E\u043F\u044B\u0442\u043A\u0443.",
		EditCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C",
		EditLookupCaption: "\u0421\u043F\u0440\u0430\u0432\u0438\u0447\u043D\u0438\u043A",
		NewLookupCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A",
		DeleteRecordsCaption: "\u0423\u0434\u0430\u043B\u044F\u0442\u044C \u0437\u0430\u043F\u0438\u0441\u0438 \u0438\u0437 {0} \u0441 \u044D\u0442\u0438\u043C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u043C",
		BlockDeletionCaption: "\u0411\u043B\u043E\u043A\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0443\u0434\u0430\u043B\u0435\u043D\u0438\u0435, \u0435\u0441\u043B\u0438 \u0435\u0441\u0442\u044C \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u044B\u0435 \u0437\u0430\u043F\u0438\u0441\u0438 \u0432 {0} \u0441 \u044D\u0442\u0438\u043C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u043C",
		LookupValueDeletionCaption: "\u041F\u0440\u0438 \u0443\u0434\u0430\u043B\u0435\u043D\u0438\u0438 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430:",
		LookupCaption: "\u0421\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A",
		ListCaption: "\u0412\u044B\u043F\u0430\u0434\u0430\u044E\u0449\u0438\u0439 \u0441\u043F\u0438\u0441\u043E\u043A",
		SelectionWindowCaption: "\u0412\u0441\u043F\u043B\u044B\u0432\u0430\u044E\u0449\u0435\u0435 \u043E\u043A\u043D\u043E",
		LookupViewCaption: "\u0412\u0438\u0434 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430",
		DataSourceCaption: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0434\u0430\u043D\u043D\u044B\u0445",
		UndoButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0438\u0442\u044C",
		ChangeTypeMessage: "\u0415\u0441\u043B\u0438 \u043A\u043E\u043B\u043E\u043D\u043A\u0430 \u0022{0}\u0022 \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 \u0434\u0430\u043D\u043D\u044B\u0435, \u0442\u043E \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435 \u0442\u0438\u043F\u0430 \u043C\u043E\u0436\u0435\u0442 \u043F\u0440\u0438\u0432\u0435\u0441\u0442\u0438 \u043A \u043F\u043E\u0442\u0435\u0440\u0435 \u0434\u0430\u043D\u043D\u044B\u0445 \u043F\u0440\u0438 \u043D\u0435\u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E\u0441\u0442\u0438 \u0438\u0445 \u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E\u0433\u043E \u043F\u0440\u0435\u043E\u0431\u0440\u0430\u0437\u043E\u0432\u0430\u043D\u0438\u044F. \u0420\u0435\u043A\u043E\u043C\u0435\u043D\u0434\u0443\u0435\u0442\u0441\u044F \u0432\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0440\u0435\u0437\u0435\u0440\u0432\u043D\u043E\u0435 \u043A\u043E\u043F\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0434\u0430\u043D\u043D\u044B\u0445 \u043F\u0435\u0440\u0435\u0434 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435\u043C.",
		EditabilityCaption: "\u0414\u043E\u0441\u0442\u0443\u043F\u043D\u043E\u0441\u0442\u044C \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		DuplicateColumnNameMessage: "\u041A\u043E\u043B\u043E\u043D\u043A\u0430 \u0441 \u0442\u0430\u043A\u0438\u043C \u0438\u043C\u0435\u043D\u0435\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442",
		WrongPrefixMessage: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u0434\u043E\u043B\u0436\u043D\u043E \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u044C \u043F\u0440\u0435\u0444\u0438\u043A\u0441 \u0022{0}\u0022",
		isMultilineTextLabel: "\u041C\u043D\u043E\u0433\u043E\u0441\u0442\u0440\u043E\u0447\u043D\u044B\u0439 \u0442\u0435\u043A\u0441\u0442",
		MakeCopy: "\u041A\u043E\u043F\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u043F\u0440\u0438 \u043A\u043E\u043F\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0438 \u0437\u0430\u043F\u0438\u0441\u0438",
		HideTitle: "\u0421\u043A\u0440\u044B\u0432\u0430\u0442\u044C \u0437\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		ReadOnly: "\u0422\u043E\u043B\u044C\u043A\u043E \u0447\u0442\u0435\u043D\u0438\u0435",
		IsRequiredOnPageLabel: "\u041E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u0434\u043B\u044F \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435",
		IsRequired: "\u041E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435",
		LabelCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435",
		DesignerCaption: "\u041A\u043E\u043B\u043E\u043D\u043A\u0430",
		NewColumnCaption: "\u041D\u043E\u0432\u0430\u044F \u043A\u043E\u043B\u043E\u043D\u043A\u0430",
		CreateLookupTooltipCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A",
		EditLookupTooltipCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});