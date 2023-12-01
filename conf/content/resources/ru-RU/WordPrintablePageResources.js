﻿define("WordPrintablePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ReportCaptionLabel: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u043E\u0442\u0447\u0435\u0442\u0430",
		ShowInSectionLabel: "\u041E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0442\u044C \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435",
		ShowInCardLabel: "\u041E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0442\u044C \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u0437\u0430\u043F\u0438\u0441\u0438",
		MacrosListDetailCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u043F\u043E\u043B\u044F \u043E\u0442\u0447\u0435\u0442\u0430",
		TablePartsDetailCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u0442\u0430\u0431\u043B\u0438\u0446\u044B \u043E\u0442\u0447\u0435\u0442\u0430",
		MacrosListDetailInfoButtonText: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u043F\u043E\u043B\u044F, \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u043A\u043E\u0442\u043E\u0440\u044B\u0445 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u0432 \u043E\u0442\u0447\u0435\u0442\u0435.\n\u0422\u0430\u043A\u0436\u0435 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u0434\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0435 \u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E\u0441\u0442\u0438 \u003Ca href=\u0022https://academy.terrasoft.ru/docs/developer/komponenty_prilozheniya/otchety/ms_word/obzor\u0022 target=\u0022_blank\u0022\u003E\u0431\u0430\u0437\u043E\u0432\u044B\u0445 \u043C\u0430\u043A\u0440\u043E\u0441\u043E\u0432\u003C/a\u003E",
		TablePartsDetailInfoButtonText: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u0434\u0430\u043D\u043D\u044B\u0435, \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0430\u043D\u0438\u0438 \u043A\u043E\u0442\u043E\u0440\u044B\u0445 \u0431\u0443\u0434\u0443\u0442 \u0444\u043E\u0440\u043C\u0438\u0440\u043E\u0432\u0430\u0442\u044C\u0441\u044F \u0442\u0430\u0431\u043B\u0438\u0446\u044B \u0432 \u043E\u0442\u0447\u0435\u0442\u0435",
		EmptyDetailMessageCaption: "\u041D\u0435\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		InfoBlockCaption: "\u0412\u0430\u0436\u043D\u043E \u0437\u043D\u0430\u0442\u044C",
		InfoBlockStepsCaption: "\u0427\u0442\u043E\u0431\u044B \u043D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043E\u0442\u0447\u0435\u0442:",
		InfoBlockStep1: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u003Ca href=\u0022https://academy.terrasoft.ru/documents?product=administration\u0026ver=7\u0026id=1412\u0022 target=\u0022_blank\u0022\u003E\u043F\u043B\u0430\u0433\u0438\u043D\u003C/a\u003E Microsoft Word.",
		InfoBlockStep2: "\u0414\u043E\u0431\u0430\u0432\u044C\u0442\u0435 \u043F\u043E\u043B\u044F \u0438 \u0442\u0430\u0431\u043B\u0438\u0447\u043D\u044B\u0435 \u0447\u0430\u0441\u0442\u0438 \u043E\u0442\u0447\u0435\u0442\u0430. \u0412\u0441\u0435 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u043D\u0430\u0445\u043E\u0434\u044F\u0442\u0441\u044F \u043D\u0430 \u044D\u0442\u043E\u0439 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435.",
		InfoBlockStep3: "\u0412 Microsoft Word \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u0448\u0430\u0431\u043B\u043E\u043D \u043E\u0442\u0447\u0435\u0442\u0430, \u0430 \u0437\u0430\u0442\u0435\u043C \u0441\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u0435 \u0435\u0433\u043E \u0432 Creatio \u043F\u043E \u0441\u043F\u0435\u0446\u0438\u0430\u043B\u044C\u043D\u043E\u043C\u0443 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044E \u0432 \u043F\u043B\u0430\u0433\u0438\u043D\u0435.",
		InfoBlockDescription: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u044E\u0449\u0438\u0439 \u0448\u0430\u0431\u043B\u043E\u043D \u0434\u043B\u044F \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0432\u044B \u0441\u043C\u043E\u0436\u0435\u0442\u0435 \u0438\u0437 \u043F\u043B\u0430\u0433\u0438\u043D\u0430. \u0414\u043B\u044F \u044D\u0442\u043E\u0433\u043E \u043E\u0442\u043A\u0440\u043E\u0439\u0442\u0435 Microsoft Word \u0438 \u0432\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043D\u0443\u0436\u043D\u044B\u0439 \u0448\u0430\u0431\u043B\u043E\u043D \u0438\u0437 \u0441\u043F\u0438\u0441\u043A\u0430.",
		InfoBlockAcademyLinkCaption: "\u0423\u0437\u043D\u0430\u0439\u0442\u0435 \u0431\u043E\u043B\u044C\u0448\u0435 \u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0435 \u043E\u0442\u0447\u0435\u0442\u043E\u0432 Microsoft Word \u0432 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438.",
		InfoBlockAcademyLink: "https://academy.terrasoft.ru/documents?product=administration\u0026ver=7\u0026id=1247",
		TablePartsHeaderLabel: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u0442\u0430\u0431\u043B\u0438\u0446\u044B",
		EditButtonHint: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C",
		RemoveButtonHint: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		FileImportContainerDescription: "\u0414\u043B\u044F \u0442\u043E\u0433\u043E, \u0447\u0442\u043E\u0431\u044B \u0441\u043A\u0430\u0447\u0430\u0442\u044C \u043D\u0430 \u041F\u041A \u0438\u043B\u0438 \u0437\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C \u0448\u0430\u0431\u043B\u043E\u043D \u043E\u0442\u0447\u0435\u0442\u0430 Word \u0432 Creatio \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u043D\u0438\u0436\u0435:",
		FileImportDragAndDropContainerCaption: "\u041F\u0435\u0440\u0435\u0442\u0430\u0449\u0438\u0442\u0435 \u0448\u0430\u0431\u043B\u043E\u043D *.docx \u0441\u044E\u0434\u0430 \u0438\u043B\u0438",
		FileImportInvalidFileTypeMessage: "\u041D\u0435\u0432\u0435\u0440\u043D\u044B\u0439 \u0444\u043E\u0440\u043C\u0430\u0442 \u0437\u0430\u0433\u0440\u0443\u0436\u0430\u0435\u043C\u043E\u0433\u043E \u0444\u0430\u0439\u043B\u0430. \u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u0435 \u0444\u0430\u0439\u043B \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 *.docx.",
		FileImportUploadFileButtonCaption: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0444\u0430\u0439\u043B",
		FileImportDownloadTemplateFileCaption: "\u0421\u043A\u0430\u0447\u0430\u0442\u044C \u0448\u0430\u0431\u043B\u043E\u043D",
		FileImportUploadTemplateFileCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C \u0448\u0430\u0431\u043B\u043E\u043D",
		TemplateSuccessfullyUploadedMessage: "\u0428\u0430\u0431\u043B\u043E\u043D \u0431\u044B\u043B \u0443\u0441\u043F\u0435\u0448\u043D\u043E \u0437\u0430\u0433\u0440\u0443\u0436\u0435\u043D",
		Template404UploadError: "O\u0442\u0447\u0451\u0442 c \u0443\u043A\u0430\u0437\u0430\u043D\u043D\u044B\u043C \u0438\u0434\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0442\u043E\u0440\u043E\u043C \u043E\u0442\u0441\u0443\u0442\u0441\u0442\u0432\u0443\u0435\u0442.",
		Template405UploadError: "\u041D\u0430 \u0434\u0430\u043D\u043D\u044B\u0439 \u043C\u043E\u043C\u0435\u043D\u0442 \u0441\u0435\u0440\u0432\u0438\u0441 \u043D\u0435 \u0434\u043E\u0441\u0442\u0443\u043F\u0435\u043D.",
		Template406UploadError: "Creatio \u043D\u0435 \u0441\u043C\u043E\u0433\u043B\u0430 \u0440\u0430\u0441\u043F\u043E\u0437\u043D\u0430\u0442\u044C \u0444\u0430\u0439\u043B. \u0412\u043E\u0437\u043C\u043E\u0436\u043D\u043E \u043E\u043D \u043F\u0443\u0441\u0442, \u0437\u0430\u0448\u0438\u0444\u0440\u043E\u0432\u0430\u043D \u0438\u043B\u0438 \u043F\u043E\u0432\u0440\u0435\u0436\u0434\u0435\u043D. \u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u0435 \u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u044B\u0439 \u0444\u0430\u0439\u043B \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 *.docx.",
		TemplateGeneralUploadError: "\u0427\u0442\u043E-\u0442\u043E \u043F\u043E\u0448\u043B\u043E \u043D\u0435 \u0442\u0430\u043A.",
		FileImportInvalidSizeMessage: "\u0424\u0430\u0439\u043B \u043D\u0435 \u0431\u044B\u043B \u0437\u0430\u0433\u0440\u0443\u0436\u0435\u043D \u0438\u0437-\u0437\u0430 \u043E\u0433\u0440\u0430\u043D\u0438\u0447\u0435\u043D\u0438\u044F \u043C\u0430\u043A\u0441\u0438\u043C\u0430\u043B\u044C\u043D\u043E\u0433\u043E \u0440\u0430\u0437\u043C\u0435\u0440\u0430 \u0444\u0430\u0439\u043B\u0430 ({0} \u041C\u0431){1}.",
		CopyButtonHint: "\u041A\u043E\u043F\u0438\u0440\u043E\u0432\u0430\u0442\u044C",
		AcademyDesignerUrl: "https://academy.terrasoft.ru/documents/sales-enterprise/7-8-0/kak-nastroit-polya-stranicy#XREF_49522",
		ActionButtonCaption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		BeginProcessButtonMenuItemCaption: "\u041D\u0430\u0447\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CanCustomizeWarning: "\u041E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u0435 {0} \u0430\u0442\u0440\u0438\u0431\u0443\u0442, \u0432\u043C\u0435\u0441\u0442\u043E \u043F\u0435\u0440\u0435\u0433\u0440\u0443\u0437\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0439 \u0444\u0443\u043D\u043A\u0446\u0438\u0435\u0439 \u043C\u0435\u0442\u043E\u0434\u0430 {1}",
		ClearButtonHint: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043F\u043E\u043B\u0435",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		ColumnFilterInvalidFormatException: "\u041D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u0430 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u044F \u043F\u043E \u043A\u043E\u043B\u043E\u043D\u043A\u0435 {0}",
		ContinueProcessButtonMenuItemCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		DelayExecutionButtonCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043F\u043E\u0437\u0436\u0435",
		FieldLockHint: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435",
		FieldsGroupCollapseButtonHint: "\u0421\u0432\u0435\u0440\u043D\u0443\u0442\u044C/\u0420\u0430\u0437\u0432\u0435\u0440\u043D\u0443\u0442\u044C",
		FieldValidationError: "\u041F\u043E\u043B\u0435 \u0022{0}\u0022: {1}",
		HeaderTipAcademyBtnCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043D\u0430 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438",
		HeaderTipCaption: "\u0412 Creatio 7.8 \u0443\u043B\u0443\u0447\u0448\u0435\u043D \u0432\u043D\u0435\u0448\u043D\u0438\u0439 \u0432\u0438\u0434 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipContent: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B\u043E\u0441\u044C \u0440\u0430\u0441\u043F\u043E\u043B\u043E\u0436\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u0435\u0439 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435. \u0417\u0434\u0435\u0441\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442\u0441\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0442\u0435 \u043F\u043E\u043B\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u044B\u043B\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0432\u0430\u043C\u0438 \u0432 \u0445\u043E\u0434\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\n\u0441\u0438\u0441\u0442\u0435\u043C\u043E\u0439. \u0414\u043B\u044F \u0443\u0434\u043E\u0431\u0441\u0442\u0432\u0430 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u0441\u0442\u0438\u0442\u044C \u044D\u0442\u0438 \u043F\u043E\u043B\u044F \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u044C \u0437\u0430\u043F\u0438\u0441\u0438 (\u0441\u043B\u0435\u0432\u0430) \u0438\u043B\u0438 \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u044C \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u0441 \u043F\u043E\u043C\u043E\u0449\u044C\u044E \u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B.",
		HeaderTipDesignerBtnCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0435\u0439\u0447\u0430\u0441",
		HeaderTipNotShowBtnCaption: "\u0411\u043E\u043B\u044C\u0448\u0435 \u043D\u0435 \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u044D\u0442\u043E \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435",
		IncrementMaskSuffix: "CodeMask",
		IncrementNumberSuffix: "LastNumber",
		NewRecordPageCaptionSuffix: ": \u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		OpenListSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043F\u0438\u0441\u043A\u0430",
		OpenNewSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		OpenSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		PageContainsUnsavedChanges: "\u0423 \u0432\u0430\u0441 \u0435\u0441\u0442\u044C \u043D\u0435\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u043D\u044B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u0443\u0434\u0443\u0442 \u0443\u0442\u0435\u0440\u044F\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		PageHeaderTemplate: "{0} / {1}",
		PrintButtonCaption: "\u041F\u0435\u0447\u0430\u0442\u044C",
		ProcessEntryPointButtonCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u043E \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0443",
		ProsessButtonCaption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		QuickAddButtonHint: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u0443\u044E \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u044C",
		RequiredFieldIsEmptyCaption: "\u0414\u043B\u044F \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438, \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435 {0}",
		SaveButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u043D\u0438\u0442\u044C",
		SaveEditButtonHint: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C (Ctrl\u002BEnter)",
		TabControlScrollLeftHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043B\u0435\u0432\u043E",
		TabControlScrollRightHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043F\u0440\u0430\u0432\u043E",
		ViewOptionsButtonCaption: "\u0412\u0438\u0434"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "AddTablePartIcon",
				hash: "b11840aa9348d9fd899b60ae858049d4",
				resourceItemExtension: ".png"
			}
		},
		EditTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "EditTablePartIcon",
				hash: "bfa74c173dd5e19deb25bbfea4c8e8f4",
				resourceItemExtension: ".svg"
			}
		},
		DeleteTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "DeleteTablePartIcon",
				hash: "3fb6fd3ff62f2e034a562effe92797e9",
				resourceItemExtension: ".svg"
			}
		},
		InfoBlockIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "InfoBlockIcon",
				hash: "08c12172d20c0926ec5731d7af079b53",
				resourceItemExtension: ".png"
			}
		},
		FileImportEmptyFileImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportEmptyFileImage",
				hash: "9d99e0183abbfda84ee859aa557b6bef",
				resourceItemExtension: ".png"
			}
		},
		FileImportErrorFileImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportErrorFileImage",
				hash: "d4222016d16f215c574962f02d154ca9",
				resourceItemExtension: ".png"
			}
		},
		FileImportWordIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportWordIcon",
				hash: "923b887731f81456b4743c2950366855",
				resourceItemExtension: ".png"
			}
		},
		FileImportDeleteTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportDeleteTemplateIcon",
				hash: "42b5b815fe5ef39879666f4595bd892b",
				resourceItemExtension: ".png"
			}
		},
		FileImportUploadTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportUploadTemplateIcon",
				hash: "0f4758efe5e8a937c5870a5ce4153902",
				resourceItemExtension: ".png"
			}
		},
		FileImportDownloadTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportDownloadTemplateIcon",
				hash: "5b9ce4a5d057cb47179b1dcfeb373cb5",
				resourceItemExtension: ".png"
			}
		},
		CopyTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "CopyTablePartIcon",
				hash: "07a9eac5c56f1e2b11f1f564eabb0651",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});