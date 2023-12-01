﻿define("MLTextSimilarityModelPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ListPredictResultSchemaCaption: "\u041E\u0431\u044A\u0435\u043A\u0442",
		ListPredictResultObjectCaption: "\u041F\u043E\u0445\u043E\u0436\u0435\u0435 \u043D\u0430",
		ListPredictResultSubjectCaption: "\u041F\u043E\u0445\u043E\u0436\u0435\u0435 \u0434\u043B\u044F",
		ResultSavingGroupCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u043E\u0432",
		ListPredictResultDateCaption: "\u0414\u0430\u0442\u0430 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0430",
		ListPredictResultModelCaption: "\u041C\u043E\u0434\u0435\u043B\u044C \u043C\u0430\u0448\u0438\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F",
		ListPredictResultValueCaption: "\u0412\u0435\u0440\u043E\u044F\u0442\u043D\u043E\u0441\u0442\u044C",
		SimilarObjectSchemaCaption: "\u0418\u0441\u043A\u0430\u0442\u044C \u043F\u043E\u0445\u043E\u0436\u0435\u0435 \u043D\u0430 (\u0421\u0443\u0431\u044A\u0435\u043A\u0442)",
		SimilarObjectSelectionColumnsGroupCaption: "\u041F\u043E \u0434\u0430\u043D\u043D\u044B\u043C \u043A\u0430\u043A\u0438\u0445 \u043A\u043E\u043B\u043E\u043D\u043E\u043A \u0438\u0441\u043A\u0430\u0442\u044C \u043F\u043E\u0445\u043E\u0436\u0435\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435?",
		SimilarObjectColumnSelectionTipText: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438 \u0441\u0443\u0431\u044A\u0435\u043A\u0442\u0430, \u0434\u043B\u044F \u0434\u0430\u043D\u043D\u044B\u0445 \u043A\u043E\u0442\u043E\u0440\u044B\u0445 \u0431\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C\u0441\u044F \u043F\u043E\u0438\u0441\u043A \u043F\u043E\u0445\u043E\u0436\u0438\u0445 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0439",
		TrainingFilterDataInfoButtonText: "\u0412\u044B\u0431\u043E\u0440\u043A\u0430 \u0434\u043B\u044F \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F \u043C\u043E\u0434\u0435\u043B\u0438 \u043F\u043E\u0438\u0441\u043A\u0430 \u043F\u043E\u0445\u043E\u0436\u0438\u0445 \u043E\u0431\u044A\u0435\u043A\u0442\u043E\u0432. \u041F\u043E\u0441\u043B\u0435 \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F \u043C\u043E\u0434\u0435\u043B\u044C  \u0431\u0443\u0434\u0435\u0442 \u0438\u0441\u043A\u0430\u0442\u044C \u043F\u043E\u0445\u043E\u0436\u0438\u0435 \u0434\u0430\u043D\u043D\u044B\u0435 \u0442\u043E\u043B\u044C\u043A\u043E \u0441\u0440\u0435\u0434\u0438 \u0442\u0435\u0445 \u043E\u0431\u044A\u0435\u043A\u0442\u043E\u0432, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0432\u043A\u043B\u044E\u0447\u0435\u043D\u044B \u0432 \u0434\u0430\u043D\u043D\u0443\u044E \u0432\u044B\u0431\u043E\u0440\u043A\u0443.",
		SubjectObjectSchemasTipContent: "\u0411\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D \u043F\u043E\u0438\u0441\u043A \u0441\u0440\u0435\u0434\u0438 \u0432\u0441\u0435\u0445 \u0437\u0430\u043F\u0438\u0441\u0435\u0439 \u0022\u041E\u0431\u044A\u0435\u043A\u0442\u0430\u0022 \u043F\u043E\u0438\u0441\u043A\u0430, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0438\u043C\u0435\u044E\u0442 \u0441\u0445\u043E\u0434\u0441\u0442\u0432\u043E \u0441 \u0022\u0421\u0443\u0431\u044A\u0435\u043A\u0442\u043E\u043C\u0022",
		PredictionSchemaCaption: "\u0418\u0441\u043A\u0430\u0442\u044C \u043F\u043E\u0445\u043E\u0436\u0435\u0435 \u043D\u0430 (\u0421\u0443\u0431\u044A\u0435\u043A\u0442)",
		AcademyDesignerUrl: "https://academy.terrasoft.ru/documents/sales-enterprise/7-8-0/kak-nastroit-polya-stranicy#XREF_49522",
		ActionButtonCaption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		AddRootSchemaLinkedColumnCaption: "\u0421\u0432\u044F\u0437\u0430\u043D\u043D\u0443\u044E \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		AddRootSchemaMenuItemCaption: "\u041A\u043E\u043B\u043E\u043D\u043A\u0443 \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		AdvancedModelParametersGroupCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u0435 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u043C\u043E\u0434\u0435\u043B\u0438",
		AdvancedModelSettingsTabCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		AdvancedQuerySettingsGroupCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0434\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438 \u0440\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u043C\u0438 \u0441\u0440\u0435\u0434\u0441\u0442\u0432\u0430\u043C\u0438?",
		AdvancedQuerySettingsGroupInfoButtonContent: "\u041E\u043F\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u043E \u043F\u043E\u0437\u0432\u043E\u043B\u044F\u0435\u0442 \u0441\u0444\u043E\u0440\u043C\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0437\u0430\u043F\u0440\u043E\u0441 \u043D\u0430 \u0432\u044B\u0431\u043E\u0440\u043A\u0443 \u0434\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0445 \u043A\u043E\u043B\u043E\u043D\u043E\u043A, \u043E\u0442 \u043A\u043E\u0442\u043E\u0440\u044B\u0445 \u0437\u0430\u0432\u0438\u0441\u0438\u0442 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435. \u003Ca target=\u0022_blank\u0022 rel=\u0022noopener noreferrer\u0022 href=\u0022https://academy.terrasoft.ua/docs/node/2295\u0022\u003E\u041F\u043E\u0434\u0440\u043E\u0431\u043D\u0435\u0435...\u003C/a\u003E",
		AdvancedSettingsGroupCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		AutomaticRetrainToggleEditCaption: "\u0410\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u043E\u0431\u043D\u043E\u0432\u043B\u044F\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C",
		BatchPredictionFilterLabelCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C \u0432\u0441\u0435 \u0437\u0430\u043F\u0438\u0441\u0438, \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0449\u0438\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044E",
		BatchPredictionSettingsGroupCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0444\u043E\u043D\u043E\u0432\u043E\u0433\u043E \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u044F \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u043E\u0432 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		BatchPredictionStartMethodToggleEditCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0444\u043E\u043D\u043E\u0432\u043E\u0435 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u043E\u0432 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0432 \u043F\u0435\u0440\u0438\u043E\u0434 \u043E\u043A\u043D\u0430 \u043E\u0431\u0441\u043B\u0443\u0436\u0438\u0432\u0430\u043D\u0438\u044F",
		BeginProcessButtonMenuItemCaption: "\u041D\u0430\u0447\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		BusinessProcessAcademyCaption: "\u041A\u0430\u043A \u043D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0431\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u043E\u0446\u0435\u0441\u0441 \u0441 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435\u043C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CanCustomizeWarning: "\u041E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u0435 {0} \u0430\u0442\u0440\u0438\u0431\u0443\u0442, \u0432\u043C\u0435\u0441\u0442\u043E \u043F\u0435\u0440\u0435\u0433\u0440\u0443\u0437\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0439 \u0444\u0443\u043D\u043A\u0446\u0438\u0435\u0439 \u043C\u0435\u0442\u043E\u0434\u0430 {1}",
		ChangeQueueItemDateButtonCaption: "\u0417\u0430\u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u043D\u0430 \u0434\u0430\u0442\u0443",
		ChooseObjectStepCaption: "\u0428\u0410\u0413 1. \u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043E\u0431\u044A\u0435\u043A\u0442, \u0434\u043B\u044F \u043A\u043E\u0442\u043E\u0440\u043E\u0433\u043E \u0431\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C\u0441\u044F \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		ChooseObjectStepTipCaption: "\u0414\u043B\u044F \u044D\u0442\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u0431\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C\u0441\u044F \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F",
		ClassificationAcademyCaption: "\u041A\u0430\u043A \u0441\u043E\u0437\u0434\u0430\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u043E\u0433\u043E \u043F\u043E\u043B\u044F",
		ClearButtonHint: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043F\u043E\u043B\u0435",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		ColumnFilterInvalidFormatException: "\u041D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u0430 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u044F \u043F\u043E \u043A\u043E\u043B\u043E\u043D\u043A\u0435 {0}",
		ContinueProcessButtonMenuItemCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		DelayExecutionButtonCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043F\u043E\u0437\u0436\u0435",
		EditRightsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430",
		ESNTabCaption: "\u041B\u0435\u043D\u0442\u0430",
		FAQContainerCaption: "\u0427\u0430\u0441\u0442\u043E \u0437\u0430\u0434\u0430\u0432\u0430\u0435\u043C\u044B\u0435 \u0432\u043E\u043F\u0440\u043E\u0441\u044B",
		FieldLockHint: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435",
		FieldsGroupCollapseButtonHint: "\u0421\u0432\u0435\u0440\u043D\u0443\u0442\u044C/\u0420\u0430\u0437\u0432\u0435\u0440\u043D\u0443\u0442\u044C",
		FieldValidationError: "\u041F\u043E\u043B\u0435 \u0022{0}\u0022: {1}",
		FilterForTrainingGroupCaption: "\u041A\u0430\u043A\u0438\u0435 \u0437\u0430\u043F\u0438\u0441\u0438 \u0434\u043E\u043B\u0436\u043D\u044B \u043F\u043E\u043F\u0430\u0441\u0442\u044C \u0432 \u043E\u0431\u0443\u0447\u0430\u044E\u0449\u0443\u044E \u0432\u044B\u0431\u043E\u0440\u043A\u0443?",
		HeaderTipAcademyBtnCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043D\u0430 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438",
		HeaderTipCaption: "\u0412 Creatio 7.8 \u0443\u043B\u0443\u0447\u0448\u0435\u043D \u0432\u043D\u0435\u0448\u043D\u0438\u0439 \u0432\u0438\u0434 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipContent: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B\u043E\u0441\u044C \u0440\u0430\u0441\u043F\u043E\u043B\u043E\u0436\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u0435\u0439 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435. \u0417\u0434\u0435\u0441\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442\u0441\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0442\u0435 \u043F\u043E\u043B\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u044B\u043B\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0432\u0430\u043C\u0438 \u0432 \u0445\u043E\u0434\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\n\u0441\u0438\u0441\u0442\u0435\u043C\u043E\u0439. \u0414\u043B\u044F \u0443\u0434\u043E\u0431\u0441\u0442\u0432\u0430 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u0441\u0442\u0438\u0442\u044C \u044D\u0442\u0438 \u043F\u043E\u043B\u044F \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u044C \u0437\u0430\u043F\u0438\u0441\u0438 (\u0441\u043B\u0435\u0432\u0430) \u0438\u043B\u0438 \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u044C \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u0441 \u043F\u043E\u043C\u043E\u0449\u044C\u044E \u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B.",
		HeaderTipDesignerBtnCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0435\u0439\u0447\u0430\u0441",
		HeaderTipNotShowBtnCaption: "\u0411\u043E\u043B\u044C\u0448\u0435 \u043D\u0435 \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u044D\u0442\u043E \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435",
		IncrementMaskSuffix: "CodeMask",
		IncrementNumberSuffix: "LastNumber",
		LowerMetricTip: "\u0412\u0432\u0435\u0434\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043A\u0430\u0447\u0435\u0441\u0442\u0432\u0430 \u043C\u043E\u0434\u0435\u043B\u0438, \u043D\u0438\u0436\u0435 \u043A\u043E\u0442\u043E\u0440\u043E\u0433\u043E \u044D\u043A\u0437\u0435\u043C\u043F\u043B\u044F\u0440 \u043C\u043E\u0434\u0435\u043B\u0438 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C\u0441\u044F \u0434\u043B\u044F \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F.",
		MLServiceAcademyCaption: "\u0421\u0435\u0440\u0432\u0438\u0441 \u043C\u0430\u0448\u0438\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F",
		ModelSettingsTabCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B",
		MultipleQueueItemsFoundError: "\u041D\u0430\u0439\u0434\u0435\u043D\u043E \u0431\u043E\u043B\u0435\u0435 \u043E\u0434\u043D\u043E\u0433\u043E \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u0438 \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u044B\u0445 \u0441 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u043C. \u0418\u0434\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0442\u043E\u0440 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430: {0}",
		NewRecordPageCaptionSuffix: ": \u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		NoData: "\u041D\u0435\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		NotesAndFilesTabCaption: "\u0424\u0430\u0439\u043B\u044B \u0438 \u043F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		NotesGroupCaption: "\u041F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		NotesTabCaption: "\u0424\u0430\u0439\u043B\u044B \u0438 \u043F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		NoTrainingData: "\u0414\u043B\u044F \u043F\u043E\u043B\u0443\u0447\u0435\u043D\u0438\u044F \u0434\u0430\u043D\u043D\u044B\u0445 \u043E \u0432\u0430\u0436\u043D\u043E\u0441\u0442\u0438 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432 \u043F\u0440\u043E\u0432\u0435\u0434\u0438\u0442\u0435 \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u0435 \u043C\u043E\u0434\u0435\u043B\u0438",
		OpenChangeLogMenuCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0436\u0443\u0440\u043D\u0430\u043B \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439",
		OpenListSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043F\u0438\u0441\u043A\u0430",
		OpenNewSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		OpenSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		PageContainsUnsavedChanges: "\u0423 \u0432\u0430\u0441 \u0435\u0441\u0442\u044C \u043D\u0435\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u043D\u044B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u0443\u0434\u0443\u0442 \u0443\u0442\u0435\u0440\u044F\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		PageHeaderTemplate: "{0} / {1}",
		ParametersAutofittingTipContent: "\u041C\u044B \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u043F\u043E\u0434\u0431\u0438\u0440\u0430\u0435\u043C \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0434\u043B\u044F \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F \u043C\u043E\u0434\u0435\u043B\u0438 \u0441 \u043D\u0430\u0438\u0432\u044B\u0441\u0448\u0438\u043C \u043A\u0430\u0447\u0435\u0441\u0442\u0432\u043E\u043C. \u0414\u043B\u044F \u0431\u043E\u043B\u0435\u0435 \u0442\u043E\u0447\u043D\u043E\u0433\u043E \u043F\u043E\u0434\u0431\u043E\u0440\u0430 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u0441\u043F\u0438\u0441\u043E\u043A \u0432\u043E\u0437\u043C\u043E\u0436\u043D\u044B\u0445 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432",
		PedictionEnabledTip: "\u0412\u043A\u043B\u044E\u0447\u0438\u0442\u0435/\u0432\u044B\u043A\u043B\u044E\u0447\u0438\u0442\u0435 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0441 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u043D\u0438\u0435\u043C \u043C\u043E\u0434\u0435\u043B\u0438. \u0414\u043B\u044F \u0443\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u043F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0435\u043D\u0438\u0435\u043C \u043C\u043E\u0434\u0435\u043B\u0438 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u043F\u043E\u043B\u0435 [\u041F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0430\u0442\u044C \u0447\u0435\u0440\u0435\u0437, \u0434\u043D\u0435\u0439].",
		PostponeQueueItemButtonCaption: "\u0412\u0435\u0440\u043D\u0443\u0442\u044C \u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u044C",
		PostponeQueueItemError: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432\u043E\u0437\u0432\u0440\u0430\u0449\u0435\u043D\u0438\u044F \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u044C. \u0421\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u043E\u0431 \u043E\u0448\u0438\u0431\u043A\u0435: {0}",
		PredictedResultColumnGroupCaption: "\u0412 \u043A\u0430\u043A\u0443\u044E \u043A\u043E\u043B\u043E\u043D\u043A\u0443 \u0441\u043E\u0445\u0440\u0430\u043D\u044F\u0442\u044C \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F?",
		PredictedResultColumnGroupInfoButtonContent: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0443, \u0432 \u043A\u043E\u0442\u043E\u0440\u0443\u044E \u0431\u0443\u0434\u0435\u0442 \u0441\u043E\u0445\u0440\u0430\u043D\u044F\u0442\u044C\u0441\u044F \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		PredictionSettingsStepCaption: "\u0428\u0410\u0413 3. \u041D\u0430\u0441\u0442\u0440\u043E\u0439\u0442\u0435 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		PredictionSettingsStepTipCaption: "\u0423\u0437\u043D\u0430\u0439\u0442\u0435 \u0432 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438, \u043A\u0430\u043A \u003Ca href=\u0022https://academy.terrasoft.ua/docs/node/2295\u0022\u003E\u0441\u043E\u0441\u0442\u0430\u0432\u0438\u0442\u044C \u0432\u044B\u0440\u0430\u0436\u0435\u043D\u0438\u0435 \u0434\u043B\u044F \u0432\u044B\u0431\u043E\u0440\u043A\u0438 \u0434\u0430\u043D\u043D\u044B\u0445 \u043D\u0430 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435\u003C/a\u003E",
		PredictionTabCaption: "\u041F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		PredictiveAnalysisAcademyCaption: "\u041F\u0440\u0435\u0434\u0438\u043A\u0442\u0438\u0432\u043D\u044B\u0439 \u0430\u043D\u0430\u043B\u0438\u0437 \u0434\u0430\u043D\u043D\u044B\u0445",
		PrintButtonCaption: "\u041F\u0435\u0447\u0430\u0442\u044C",
		ProcessEntryPointButtonCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u043E \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0443",
		ProsessButtonCaption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		QueueItemIsEmptyError: "\u0421\u0442\u0440\u0430\u043D\u0438\u0446\u0430 \u043D\u0435 \u0441\u0432\u044F\u0437\u0430\u043D\u0430 \u0441 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u043C \u043E\u0447\u0435\u0440\u0435\u0434\u0438 \u0435\u0434\u0438\u043D\u043E\u0433\u043E \u043E\u043A\u043D\u0430. \u0414\u0435\u0439\u0441\u0442\u0432\u0438\u0435 \u043E\u0442\u043C\u0435\u043D\u0435\u043D\u043E.",
		QueueItemPostponeFailedMessage: "\u041E\u0448\u0438\u0431\u043A\u0430 \u043F\u0440\u0438 \u0432\u043E\u0437\u0432\u0440\u0430\u0449\u0435\u043D\u0438\u0438 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u044C",
		QueueItemPostponeSucceedMessage: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442 \u0443\u0441\u043F\u0435\u0448\u043D\u043E \u0432\u043E\u0437\u0432\u0440\u0430\u0449\u0435\u043D \u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u044C",
		QuickAddButtonHint: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u0443\u044E \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u044C",
		RecommendationAcademyCaption: "\u041A\u0430\u043A \u0441\u043E\u0437\u0434\u0430\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C \u0440\u0435\u043A\u043E\u043C\u0435\u043D\u0434\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0439 \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		RegressionAcademyCaption: "\u041A\u0430\u043A \u0441\u043E\u0437\u0434\u0430\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0447\u0438\u0441\u043B\u043E\u0432\u043E\u0433\u043E \u043F\u043E\u043B\u044F",
		RequiredFieldIsEmptyCaption: "\u0414\u043B\u044F \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438, \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435 {0}",
		RetrainLabelCaption: "\u041F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0430\u0442\u044C \u0447\u0435\u0440\u0435\u0437, \u0434\u043D\u0435\u0439",
		RetrainTip: "\u0412\u0432\u0435\u0434\u0438\u0442\u0435 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0434\u043D\u0435\u0439, \u0447\u0435\u0440\u0435\u0437 \u043A\u043E\u0442\u043E\u0440\u043E\u0435 \u043C\u043E\u0434\u0435\u043B\u044C \u0431\u0443\u0434\u0435\u0442 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u043F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0435\u043D\u0430. \u0415\u0441\u043B\u0438 \u0432\u0430\u043C \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u043E\u0442\u043A\u043B\u044E\u0447\u0438\u0442\u044C \u043F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0435\u043D\u0438\u0435 \u043C\u043E\u0434\u0435\u043B\u0438, \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u0432 0.",
		RootEntityCaption: "\u0418\u0441\u043A\u0430\u0442\u044C \u043F\u043E\u0445\u043E\u0436\u0435\u0435 \u0441\u0440\u0435\u0434\u0438 (\u041E\u0431\u044A\u0435\u043A\u0442)",
		RootSchemaNotSet: "\u041E\u0431\u044A\u0435\u043A\u0442 \u043D\u0435 \u0432\u044B\u0431\u0440\u0430\u043D",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SaveEditButtonHint: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C (Ctrl\u002BEnter)",
		SavePageConfirmation: "\u0412\u0441\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0431\u0443\u0434\u0443\u0442 \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		ScoringAcademyCaption: "\u041A\u0430\u043A \u043D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043E\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u0435 \u0440\u0435\u0439\u0442\u0438\u043D\u0433\u0430 \u0437\u0430\u043F\u0438\u0441\u0435\u0439",
		StatsTabCaption: "\u0421\u0442\u0430\u0442\u0438\u0441\u0442\u0438\u043A\u0430 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u043D\u0438\u044F",
		SubscribeCaption: "\u041F\u043E\u0434\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F \u043D\u0430 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043B\u0435\u043D\u0442\u044B",
		SubscribedInformationDialog: "\u0412\u044B \u043F\u043E\u0434\u043F\u0438\u0441\u0430\u043D\u044B \u043D\u0430 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043B\u0435\u043D\u0442\u044B: {0}",
		TabControlScrollLeftHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043B\u0435\u0432\u043E",
		TabControlScrollRightHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043F\u0440\u0430\u0432\u043E",
		TabVisaCaption: "\u0412\u0438\u0437\u044B",
		TagButtonHint: "\u0422\u0435\u0433\u0438",
		TargetColumnGroup_Filters_Caption: "\u041A\u0430\u043A\u0438\u0435 \u0437\u0430\u043F\u0438\u0441\u0438 \u0441\u0447\u0438\u0442\u0430\u0442\u044C \u0443\u0441\u043F\u0435\u0448\u043D\u044B\u043C\u0438?",
		TargetColumnGroupCaption: "\u041A\u0430\u043A\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u0442\u044C?",
		TargetColumnGroupInfoButton_Filters_Content: "\u0424\u0438\u043B\u044C\u0442\u0440, \u043F\u043E \u043A\u043E\u0442\u043E\u0440\u043E\u043C\u0443 \u0438\u0437 \u043E\u0431\u0443\u0447\u0430\u044E\u0449\u0435\u0439 \u0432\u044B\u0431\u043E\u0440\u043A\u0438 \u043E\u043F\u0440\u0435\u0434\u0435\u043B\u044F\u044E\u0442\u0441\u044F \u0437\u0430\u043F\u0438\u0441\u0438 \u0441 \u0443\u0441\u043F\u0435\u0448\u043D\u044B\u043C \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u043E\u043C \u0441\u043A\u043E\u0440\u0438\u043D\u0433\u0430",
		TargetColumnGroupInfoButtonContent: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0443, \u043A\u043E\u0442\u043E\u0440\u0430\u044F \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 \u0430\u043A\u0442\u0443\u0430\u043B\u044C\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u0443\u0435\u043C\u043E\u0439 \u0432\u0435\u043B\u0438\u0447\u0438\u043D\u044B \u0432 \u043E\u0431\u0443\u0447\u0430\u044E\u0449\u0435\u0439 \u0432\u044B\u0431\u043E\u0440\u043A\u0435",
		TimelineTabCaption: "\u0425\u0440\u043E\u043D\u043E\u043B\u043E\u0433\u0438\u044F",
		TopFeaturesCaption: "\u0422\u043E\u043F \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432 \u044D\u043A\u0437\u0435\u043C\u043F\u043B\u044F\u0440\u0430 \u043C\u043E\u0434\u0435\u043B\u0438 \u043E\u0431\u0443\u0447\u0435\u043D\u043D\u043E\u0433\u043E {0}",
		TrainingQueryFieldsGroupCaption: "\u041E\u0442 \u043A\u0430\u043A\u0438\u0445 \u043A\u043E\u043B\u043E\u043D\u043E\u043A \u0437\u0430\u0432\u0438\u0441\u0438\u0442 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435?",
		TrainingQueryFieldsGroupInfoButtonContent: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438 \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F, \u043F\u043E \u0434\u0430\u043D\u043D\u044B\u043C \u043A\u043E\u0442\u043E\u0440\u044B\u0445 \u0431\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C\u0441\u044F \u043F\u043E\u0438\u0441\u043A",
		TrainingSettingsGroupCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F \u043C\u043E\u0434\u0435\u043B\u0438",
		TrainingSettingsInfoButtonCaption: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u044F \u043C\u043E\u0434\u0435\u043B\u0438, \u0447\u0442\u043E\u0431\u044B \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u0438\u0432\u0430\u0442\u044C \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u044B\u0439 \u0443\u0440\u043E\u0432\u0435\u043D\u044C \u043A\u0430\u0447\u0435\u0441\u0442\u0432\u0430 \u043F\u0440\u043E\u0433\u043D\u043E\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		TrainingStatusNotificationTitle: "\u041E\u0431\u0443\u0447\u0435\u043D\u0438\u0435 \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u043E",
		TrainingTabCaption: "\u041E\u0431\u0443\u0447\u0435\u043D\u0438\u0435",
		TrainModelActionCaption: "\u041E\u0431\u0443\u0447\u0438\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C",
		TrainModelActionFailedMessage: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u0435 \u0437\u0430\u0432\u0435\u0440\u0448\u0438\u043B\u043E\u0441\u044C \u0441 \u043E\u0448\u0438\u0431\u043A\u043E\u0439. \u041F\u043E\u0434\u0440\u043E\u0431\u043D\u043E\u0441\u0442\u0438 - \u0432 \u0436\u0443\u0440\u043D\u0430\u043B\u0435 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F",
		TrainModelActionSucceedMessage: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u0435 \u0443\u0441\u043F\u0435\u0448\u043D\u043E \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u043E. \u0422\u0435\u043A\u0443\u0449\u0435\u0435 \u0441\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435 \u0441\u0435\u0441\u0441\u0438\u0438: {0}",
		TrainModelActionTimedOutMessage: "\u041F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F \u0437\u0430\u0439\u043C\u0435\u0442 \u0435\u0449\u0435 \u043D\u0435\u043A\u043E\u0442\u043E\u0440\u043E\u0435 \u0432\u0440\u0435\u043C\u044F. \u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u0435 \u0442\u0435\u043A\u0443\u0449\u0435\u0435 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u0435 \u043F\u043E\u0432\u0442\u043E\u0440\u043D\u043E \u0447\u0435\u0440\u0435\u0437 \u043D\u0435\u0441\u043A\u043E\u043B\u044C\u043A\u043E \u043C\u0438\u043D\u0443\u0442 \u0434\u043B\u044F \u043F\u043E\u043B\u0443\u0447\u0435\u043D\u0438\u044F \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u0430",
		TrainModelActionWrongConfigMessage: "\u041E\u0448\u0438\u0431\u043A\u0430 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u0438. \u041F\u0440\u043E\u0432\u0435\u0440\u044C\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u0439 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u0022API-\u043A\u043B\u044E\u0447 \u043E\u0431\u043B\u0430\u0447\u043D\u044B\u0445 \u0441\u0435\u0440\u0432\u0438\u0441\u043E\u0432\u0022 \u0438 \u043F\u043E\u043B\u044F [Url \u0441\u0435\u0440\u0432\u0438\u0441\u0430] \u0432 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0435 [\u0417\u0430\u0434\u0430\u0447\u0438 \u043C\u0430\u0448\u0438\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F]",
		TrainModelButtonCaption_Finished: "\u041F\u0435\u0440\u0435\u043E\u0431\u0443\u0447\u0438\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C",
		TrainModelButtonCaption_InProgress: "\u0418\u0434\u0435\u0442 \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u0435",
		TrainModelButtonCaption_NotStarted: "\u041E\u0431\u0443\u0447\u0438\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C",
		UnsubscribeCaption: "\u041E\u0442\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F \u043E\u0442 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0439 \u043B\u0435\u043D\u0442\u044B",
		UnsubscribedInformationDialog: "\u0412\u044B \u043E\u0442\u043F\u0438\u0441\u0430\u043D\u044B \u043E\u0442 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0439 \u043B\u0435\u043D\u0442\u044B: {0}",
		ViewOptionsButtonCaption: "\u0412\u0438\u0434"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		FAQIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "FAQIcon",
				hash: "898f30139a1507ab891cddc467938206",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		ClearIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "ClearIcon",
				hash: "018bf133f90a321b1cae38a9d077cbca",
				resourceItemExtension: ".png"
			}
		},
		ClearIconHover: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "ClearIconHover",
				hash: "e469377aa2358c21942fe57d0e1fef21",
				resourceItemExtension: ".png"
			}
		},
		AddColumnMenuIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "AddColumnMenuIcon",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		MLIcon: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "MLIcon",
				hash: "4f57fdf4d632a5cf20224be92c743b28",
				resourceItemExtension: ".png"
			}
		},
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "EmptyInfoImage",
				hash: "84410c143d7a4e3bfdbeda3db0408fca",
				resourceItemExtension: ".png"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		},
		ConsultationBanner: {
			source: 3,
			params: {
				schemaName: "MLTextSimilarityModelPage",
				resourceItemName: "ConsultationBanner",
				hash: "6d968a4801d3901037b1b97cc7a77f7c",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});