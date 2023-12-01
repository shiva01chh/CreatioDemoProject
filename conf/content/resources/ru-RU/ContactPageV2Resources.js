﻿define("ContactPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CommunicationChannelsTabCaption: "\u041A\u0430\u043D\u0430\u043B\u044B \u043A\u043E\u043C\u043C\u0443\u043D\u0438\u043A\u0430\u0446\u0438\u0438",
		ContactPageServiceTab: "\u041E\u0431\u0441\u043B\u0443\u0436\u0438\u0432\u0430\u043D\u0438\u0435",
		ContactResourcesCaption: "\u0420\u0435\u0441\u0443\u0440\u0441\u044B \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		GeneralInfoTabCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		JobTabCaption: "\u041C\u0435\u0441\u0442\u043E \u0440\u0430\u0431\u043E\u0442\u044B",
		HistoryTabCaption: "\u0418\u0441\u0442\u043E\u0440\u0438\u044F",
		ActivitiesTabCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0438",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ActionButtonCaption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ColumnFilterInvalidFormatException: "\u041D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u0430 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u044F \u043F\u043E \u043A\u043E\u043B\u043E\u043D\u043A\u0435 {0}",
		RequiredFieldIsEmptyCaption: "\u0414\u043B\u044F \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438, \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435 {0}",
		RibbonTabCaption: "\u041B\u0435\u043D\u0442\u0430",
		FillSocialDataCaption: "\u0417\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u043C\u0438 \u0438\u0437 \u0441\u043E\u0446. \u0441\u0435\u0442\u0435\u0439",
		FillContactQuestion: "\u0414\u043B\u044F \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0443\u043A\u0430\u0437\u0430\u0442\u044C \u0445\u043E\u0442\u044F \u0431\u044B \u043E\u0434\u043D\u0443 \u0443\u0447\u0435\u0442\u043D\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C \u0434\u043B\u044F \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430 \u0432 \u0441\u043E\u0446. \u0441\u0435\u0442\u044F\u0445.",
		NewRecordPageCaptionSuffix: ": \u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		ContactCareerInfoChanged: "\u0414\u0430\u043D\u043D\u044B\u0435 \u043E \u043C\u0435\u0441\u0442\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u044B. \u0421\u043B\u0435\u0434\u0443\u0435\u0442 \u043B\u0438 \u0434\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u044C \u041A\u0430\u0440\u044C\u0435\u0440\u0430?",
		OpenContactCardQuestion: "\u0414\u043B\u044F \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0443\u043A\u0430\u0437\u0430\u0442\u044C \u0445\u043E\u0442\u044F \u0431\u044B \u043E\u0434\u043D\u0443 \u0443\u0447\u0435\u0442\u043D\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C \u0434\u043B\u044F \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430 \u0432 \u0441\u043E\u0446. \u0441\u0435\u0442\u044F\u0445",
		TagButtonHint: "\u0422\u0435\u0433\u0438",
		TabControlScrollLeftHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043B\u0435\u0432\u043E",
		TabControlScrollRightHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043F\u0440\u0430\u0432\u043E",
		FieldsGroupCollapseButtonHint: "\u0421\u0432\u0435\u0440\u043D\u0443\u0442\u044C/\u0420\u0430\u0437\u0432\u0435\u0440\u043D\u0443\u0442\u044C",
		FieldLockHint: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435",
		ClearButtonHint: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043F\u043E\u043B\u0435",
		OwnerTip: "\u0424\u0418\u041E \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u0433\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430. \u0412\u044B\u0431\u043E\u0440 \u0438\u0437 \u0441\u043F\u0438\u0441\u043A\u0430 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432, \u043F\u043E \u043A\u043E\u0442\u043E\u0440\u044B\u043C \u0437\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipCaption: "\u0412 Creatio 7.8 \u0443\u043B\u0443\u0447\u0448\u0435\u043D \u0432\u043D\u0435\u0448\u043D\u0438\u0439 \u0432\u0438\u0434 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipContent: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B\u043E\u0441\u044C \u0440\u0430\u0441\u043F\u043E\u043B\u043E\u0436\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u0435\u0439 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435. \u0417\u0434\u0435\u0441\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442\u0441\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0442\u0435 \u043F\u043E\u043B\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u044B\u043B\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0432\u0430\u043C\u0438 \u0432 \u0445\u043E\u0434\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\n\u0441\u0438\u0441\u0442\u0435\u043C\u043E\u0439. \u0414\u043B\u044F \u0443\u0434\u043E\u0431\u0441\u0442\u0432\u0430 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u0441\u0442\u0438\u0442\u044C \u044D\u0442\u0438 \u043F\u043E\u043B\u044F \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u044C \u0437\u0430\u043F\u0438\u0441\u0438 (\u0441\u043B\u0435\u0432\u0430) \u0438\u043B\u0438 \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u044C \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u0441 \u043F\u043E\u043C\u043E\u0449\u044C\u044E \u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B.",
		HeaderTipDesignerBtnCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0435\u0439\u0447\u0430\u0441",
		HeaderTipAcademyBtnCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043D\u0430 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438",
		AcademyDesignerUrl: "https://academy.terrasoft.ru/documents/sales-enterprise/7-8-0/kak-nastroit-polya-stranicy#XREF_49522",
		HeaderTipNotShowBtnCaption: "\u0411\u043E\u043B\u044C\u0448\u0435 \u043D\u0435 \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u044D\u0442\u043E \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435",
		DelayExecutionButtonCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043F\u043E\u0437\u0436\u0435",
		ProcessEntryPointButtonCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u043E \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0443",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		ViewOptionsButtonCaption: "\u0412\u0438\u0434",
		OpenSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		FieldValidationError: "\u041F\u043E\u043B\u0435 \u0022{0}\u0022: {1}",
		PrintButtonCaption: "\u041F\u0435\u0447\u0430\u0442\u044C",
		OpenListSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043F\u0438\u0441\u043A\u0430",
		ProsessButtonCaption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		BeginProcessButtonMenuItemCaption: "\u041D\u0430\u0447\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		ContinueProcessButtonMenuItemCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		QuickAddButtonHint: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u0443\u044E \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u044C",
		PageContainsUnsavedChanges: "\u0423 \u0432\u0430\u0441 \u0435\u0441\u0442\u044C \u043D\u0435\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u043D\u044B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u0443\u0434\u0443\u0442 \u0443\u0442\u0435\u0440\u044F\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		CompletenessLabel: "\u041F\u043E\u043B\u043D\u043E\u0442\u0430 \u043F\u0440\u043E\u0444\u0438\u043B\u044F",
		CompletenessHint: "\u0421\u0442\u0435\u043F\u0435\u043D\u044C \u043D\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043D\u043E\u0441\u0442\u0438 \u0434\u0430\u043D\u043D\u044B\u043C\u0438 \u043F\u0440\u043E\u0444\u0438\u043B\u044F. \u041D\u0430\u0436\u043C\u0438\u0442\u0435 \u043D\u0430 \u0448\u043A\u0430\u043B\u0443, \u0447\u0442\u043E\u0431\u044B \u043F\u043E\u0441\u043C\u043E\u0442\u0440\u0435\u0442\u044C, \u043A\u0430\u043A\u0438\u0445 \u0434\u0430\u043D\u043D\u044B\u0445 \u043D\u0435 \u0445\u0432\u0430\u0442\u0430\u0435\u0442 \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u0435.",
		FillContactWithSocialNetworksDataActionCaption: "\u041E\u0431\u043E\u0433\u0430\u0442\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u043C\u0438 \u0438\u0437 \u0441\u043E\u0446. \u0441\u0435\u0442\u0435\u0439",
		ESNTabCaption: "\u041B\u0435\u043D\u0442\u0430",
		SubscribeCaption: "\u041F\u043E\u0434\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F \u043D\u0430 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043B\u0435\u043D\u0442\u044B",
		UnsubscribeCaption: "\u041E\u0442\u043F\u0438\u0441\u0430\u0442\u044C\u0441\u044F \u043E\u0442 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0439 \u043B\u0435\u043D\u0442\u044B",
		SubscribedInformationDialog: "\u0412\u044B \u043F\u043E\u0434\u043F\u0438\u0441\u0430\u043D\u044B \u043D\u0430 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043B\u0435\u043D\u0442\u044B: {0}",
		UnsubscribedInformationDialog: "\u0412\u044B \u043E\u0442\u043F\u0438\u0441\u0430\u043D\u044B \u043E\u0442 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0439 \u043B\u0435\u043D\u0442\u044B: {0}",
		CanCustomizeWarning: "\u041E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u0435 {0} \u0430\u0442\u0440\u0438\u0431\u0443\u0442, \u0432\u043C\u0435\u0441\u0442\u043E \u043F\u0435\u0440\u0435\u0433\u0440\u0443\u0437\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0439 \u0444\u0443\u043D\u043A\u0446\u0438\u0435\u0439 \u043C\u0435\u0442\u043E\u0434\u0430 {1}",
		TabVisaCaption: "\u0412\u0438\u0437\u044B",
		PreferredLanguageTipMessage: "\u003Cp\u003E\u042D\u0442\u043E\u0442 \u044F\u0437\u044B\u043A \u0431\u0443\u0434\u0435\u0442 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C\u0441\u044F \u0434\u043B\u044F \u0432\u044B\u0431\u043E\u0440\u0430 \u0448\u0430\u0431\u043B\u043E\u043D\u043E\u0432 \u043F\u0440\u0438 \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0435 email-\u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0439 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0443. \u0415\u0441\u043B\u0438 \u0448\u0430\u0431\u043B\u043E\u043D \u043D\u0430 \u0443\u043A\u0430\u0437\u0430\u043D\u043D\u043E\u043C \u044F\u0437\u044B\u043A\u0435 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u043D\u0430\u0439\u0434\u0435\u043D, \u0442\u043E Creatio \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442 \u0448\u0430\u0431\u043B\u043E\u043D \u043D\u0430 \u003Ca href=\u0022../Nui/ViewModule.aspx#CardModuleV2/SysSettingPage/edit/8fc03719-87fe-4652-add0-3c1038607af8\u0022\u003E\u044F\u0437\u044B\u043A\u0435 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E\u003C/a\u003E. \u0414\u043B\u044F \u0432\u044B\u0431\u043E\u0440\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u043D\u044B \u0442\u043E\u043B\u044C\u043A\u043E \u0430\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u044F\u0437\u044B\u043A\u0438. \u041F\u0435\u0440\u0435\u0439\u0442\u0438 \u0432 \u003Ca href=\u0022../Nui/ViewModule.aspx#LookupSectionModule/CustomerLanguagesLookupSection\u0022\u003E\u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A \u00AB\u042F\u0437\u044B\u043A\u0438\u00BB\u003C/a\u003E \u0434\u043B\u044F \u0443\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u044F\u0437\u044B\u043A\u0430\u043C\u0438\u003C/p\u003E",
		EditRightsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430",
		SaveEditButtonHint: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C (Ctrl\u002BEnter)",
		OpenChangeLogMenuCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0436\u0443\u0440\u043D\u0430\u043B \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439",
		NotesGroupCaption: "\u041F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		NotesAndFilesTabCaption: "\u0424\u0430\u0439\u043B\u044B \u0438 \u043F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		ShowTrackingDataCaption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u0442\u0440\u0435\u043A\u0438\u043D\u0433\u0430",
		TrackingEventsTabCaption: "\u0421\u043E\u0431\u044B\u0442\u0438\u044F \u0441\u0430\u0439\u0442\u0430",
		BlankSlateDescription: "\u0412\u0430\u0448 \u0431\u0440\u0430\u0443\u0437\u0435\u0440 \u043D\u0435 \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u0438\u0432\u0430\u0435\u0442\u0441\u044F.\n\u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 Chrome, Safari \u0438\u043B\u0438 Firefox \u0434\u043B\u044F \u0440\u0430\u0431\u043E\u0442\u044B \u0441 \u0438\u0441\u0442\u043E\u0440\u0438\u0435\u0439 \u0441\u043E\u0431\u044B\u0442\u0438\u0439 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		ColumnNameDateTimeCaption: "\u0412\u0440\u0435\u043C\u044F \u0438 \u0434\u0430\u0442\u0430",
		ColumnNameEventTypeCaption: "\u0422\u0438\u043F \u0441\u043E\u0431\u044B\u0442\u0438\u044F",
		ColumnNameNameCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		ColumnNameValueCaption: "\u0421\u043E\u0434\u0435\u0440\u0436\u0430\u043D\u0438\u0435",
		ColumnNameCostCaption: "\u0421\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C",
		PropertyPageUrlCaption: "URL \u0421\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		PropertyRefererCaption: "URL \u0421\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0430",
		PropertyLanguageCaption: "\u042F\u0437\u044B\u043A",
		PropertyDisplayCaption: "\u041C\u043E\u043D\u0438\u0442\u043E\u0440",
		ButtonLoadMoreCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C \u0435\u0449\u0435",
		ConfirmedCaption: "\u041F\u043E\u0434\u0442\u0432\u0435\u0440\u0436\u0434\u0435\u043D",
		EnrichCloudCaption: "\u041D\u0430\u0439\u0434\u0435\u043D\u044B \u0434\u0430\u043D\u043D\u044B\u0435",
		TimelineTabCaption: "\u0425\u0440\u043E\u043D\u043E\u043B\u043E\u0433\u0438\u044F",
		LabelLoadingCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u0437\u0430\u0433\u0440\u0443\u0437\u043A\u0430 \u0434\u0430\u043D\u043D\u044B\u0445. \u042D\u0442\u043E \u043C\u043E\u0436\u0435\u0442 \u0437\u0430\u043D\u044F\u0442\u044C \u043D\u0435\u0441\u043A\u043E\u043B\u044C\u043A\u043E \u0441\u0435\u043A\u0443\u043D\u0434.",
		LabelNoDataCaption: "\u0414\u043B\u044F \u044D\u0442\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438 \u043D\u0435\u0442 \u0434\u0430\u043D\u043D\u044B\u0445 \u043E \u0441\u043E\u0431\u044B\u0442\u0438\u044F\u0445 \u0441\u0430\u0439\u0442\u0430.",
		PropertyBrowserCaption: "\u0411\u0440\u0430\u0443\u0437\u0435\u0440",
		PropertyColorDepthCaption: "\u0413\u043B\u0443\u0431\u0438\u043D\u0430 \u0446\u0432\u0435\u0442\u0430",
		PropertyLanguagesCaption: "\u042F\u0437\u044B\u043A\u0438",
		PropertyPixelDepthCaption: "\u0413\u043B\u0443\u0431\u0438\u043D\u0430 \u043F\u0438\u043A\u0441\u0435\u043B\u044F",
		PropertyPlatformCaption: "\u041F\u043B\u0430\u0442\u0444\u043E\u0440\u043C\u0430",
		PropertyScreenAvailCaption: "\u0414\u043E\u0441\u0442\u0443\u043F\u043D\u043E\u0435 \u043F\u0440\u043E\u0441\u0442\u0440\u0430\u043D\u0441\u0442\u0432\u043E \u044D\u043A\u0440\u0430\u043D\u0430",
		EngagementTabTabCaption: "\u041F\u0440\u0438\u0432\u043B\u0435\u0447\u0435\u043D\u0438\u0435",
		FormSubmitDetailDetailCaptionOnPage: "\u0417\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043D\u044B\u0435 \u0432\u0435\u0431-\u0444\u043E\u0440\u043C\u044B",
		TouchDetailDetailCaptionOnPage: "\u0421\u0435\u0441\u0441\u0438\u0438 \u043D\u0430 \u0441\u0430\u0439\u0442\u0435",
		RelationshipTabCaption: "\u0412\u0437\u0430\u0438\u043C\u043E\u0441\u0432\u044F\u0437\u0438"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultPhoto: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "DefaultPhoto",
				hash: "ed12916b583407914f22afb2a4581d7f",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		},
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "BlankSlateIcon",
				hash: "1b81bfab6f136e6c62e7f1bf3fe0e354",
				resourceItemExtension: ".png"
			}
		},
		EnrichCloudIcon: {
			source: 3,
			params: {
				schemaName: "ContactPageV2",
				resourceItemName: "EnrichCloudIcon",
				hash: "588f9021245791159b6a98d86790d502",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});