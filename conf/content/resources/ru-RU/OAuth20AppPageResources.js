﻿define("OAuth20AppPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		TagButtonHint: "\u0422\u0435\u0433\u0438",
		TabControlScrollLeftHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043B\u0435\u0432\u043E",
		TabControlScrollRightHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043F\u0440\u0430\u0432\u043E",
		FieldsGroupCollapseButtonHint: "\u0421\u0432\u0435\u0440\u043D\u0443\u0442\u044C/\u0420\u0430\u0437\u0432\u0435\u0440\u043D\u0443\u0442\u044C",
		FieldLockHint: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435",
		ClearButtonHint: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043F\u043E\u043B\u0435",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ActionButtonCaption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ColumnFilterInvalidFormatException: "\u041D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u0430 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u044F \u043F\u043E \u043A\u043E\u043B\u043E\u043D\u043A\u0435 {0}",
		RequiredFieldIsEmptyCaption: "\u0414\u043B\u044F \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438, \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435 {0}",
		NewRecordPageCaptionSuffix: ": \u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
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
		HeaderTipCaption: "\u0412 Creatio 7.8 \u0443\u043B\u0443\u0447\u0448\u0435\u043D \u0432\u043D\u0435\u0448\u043D\u0438\u0439 \u0432\u0438\u0434 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipContent: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B\u043E\u0441\u044C \u0440\u0430\u0441\u043F\u043E\u043B\u043E\u0436\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u0435\u0439 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435. \u0417\u0434\u0435\u0441\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442\u0441\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0442\u0435 \u043F\u043E\u043B\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u044B\u043B\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0432\u0430\u043C\u0438 \u0432 \u0445\u043E\u0434\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\n\u0441\u0438\u0441\u0442\u0435\u043C\u043E\u0439. \u0414\u043B\u044F \u0443\u0434\u043E\u0431\u0441\u0442\u0432\u0430 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u0441\u0442\u0438\u0442\u044C \u044D\u0442\u0438 \u043F\u043E\u043B\u044F \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u044C \u0437\u0430\u043F\u0438\u0441\u0438 (\u0441\u043B\u0435\u0432\u0430) \u0438\u043B\u0438 \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u044C \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u0441 \u043F\u043E\u043C\u043E\u0449\u044C\u044E \u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B.",
		HeaderTipDesignerBtnCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0435\u0439\u0447\u0430\u0441",
		HeaderTipAcademyBtnCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043D\u0430 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438",
		AcademyDesignerUrl: "https://academy.terrasoft.ru/documents/sales-enterprise/7-8-0/kak-nastroit-polya-stranicy#XREF_49522",
		HeaderTipNotShowBtnCaption: "\u0411\u043E\u043B\u044C\u0448\u0435 \u043D\u0435 \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u044D\u0442\u043E \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435",
		PageContainsUnsavedChanges: "\u0423 \u0432\u0430\u0441 \u0435\u0441\u0442\u044C \u043D\u0435\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u043D\u044B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u0443\u0434\u0443\u0442 \u0443\u0442\u0435\u0440\u044F\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		CanCustomizeWarning: "\u041E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u0435 {0} \u0430\u0442\u0440\u0438\u0431\u0443\u0442, \u0432\u043C\u0435\u0441\u0442\u043E \u043F\u0435\u0440\u0435\u0433\u0440\u0443\u0437\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0439 \u0444\u0443\u043D\u043A\u0446\u0438\u0435\u0439 \u043C\u0435\u0442\u043E\u0434\u0430 {1}",
		Tabe9ae4951TabLabelTabCaption: "\u041D\u0430c\u0442\u0440\u043E\u0439\u043A\u0438 OAuth",
		Schema1Detail28a4d31fDetailCaptionOnPage: "\u0420\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u044F (scopes)",
		Schema2Detaila82ca02cDetailCaptionOnPage: "\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438",
		ClientIdf10c9178a2cf45abb99c16e863fdd780LabelCaption: "Client ID",
		SecretKey4853fd5d43cc4fc39f51b5303d2f481aLabelCaption: "Client secret",
		CannotReadClientSecret: "\u041E\u0448\u0438\u0431\u043A\u0430 \u043F\u0440\u0438 \u043F\u043E\u043F\u044B\u0442\u043A\u0435 \u0437\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C Client Secret",
		Tabe9ae4951TabLabelGroup9c0d9295GroupCaption: "",
		ClientIdfd8147359bc641c2b33fb403d4f60656LabelCaption: "Client ID",
		SecretKey75a66b3121af46e28c55818e6d8c5054LabelCaption: "Client secret",
		UsersTabCaption: "\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438",
		UseSharedUserCaption: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043E\u0431\u0449\u0438\u0439 \u0434\u043E\u0441\u0442\u0443\u043F",
		RedirectUrlInfoLabelLabelCaption: "",
		UseSharedUserTip: "\u0412\u0441\u0435 \u0437\u0430\u043F\u0440\u043E\u0441\u044B \u043F\u043E API \u0431\u0443\u0434\u0443\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C\u0441\u044F \u043E\u0442 \u0438\u043C\u0435\u043D\u0438 \u043E\u0434\u043D\u043E\u0433\u043E \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F \u0432\u043D\u0435\u0448\u043D\u0435\u0433\u043E \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F.",
		ClientIdTip: "\u0422\u0430\u043A\u0436\u0435 \u043C\u043E\u0436\u0435\u0442 \u043D\u0430\u0437\u044B\u0432\u0430\u0442\u044C\u0441\u044F \u0022Application ID\u0022 (\u0438\u0434\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0442\u043E\u0440 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F) \u0438\u043B\u0438 \u0022Consumer ID\u0022, \u0438\u043B\u0438 \u0022Public key\u0022 (\u043F\u0443\u0431\u043B\u0438\u0447\u043D\u044B\u0439 \u043A\u043B\u044E\u0447).",
		SecretKeyTip: "\u0422\u0430\u043A\u0436\u0435 \u043C\u043E\u0436\u0435\u0442 \u043D\u0430\u0437\u044B\u0432\u0430\u0442\u044C\u0441\u044F \u0022Application secret\u0022 (\u0441\u0435\u043A\u0440\u0435\u0442\u043D\u044B\u0439 \u043A\u043B\u044E\u0447 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F) \u0438\u043B\u0438 Consumer secret, \u0438\u043B\u0438 Secret key.",
		TokenUrlTip: "\u0427\u0430\u0441\u0442\u043E \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 .../token \u0438\u043B\u0438 .../access_token.\n\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442 \u043A\u043E\u0434 \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u0438, Client ID \u0438 Client secret, \u0447\u0442\u043E\u0431\u044B \u0432\u0435\u0440\u043D\u0443\u0442\u044C \u0442\u043E\u043A\u0435\u043D \u0434\u043E\u0441\u0442\u0443\u043F\u0430.",
		AuthorizeUrlTip: "\u0427\u0430\u0441\u0442\u043E \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 .../authorize. \u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0432\u043D\u0430\u0447\u0430\u043B\u0435 \u0430\u0443\u0442\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u0438 \u043F\u043E OAuth 2.0.\n\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442 Client ID \u0438 \u043D\u0430\u0431\u043E\u0440 \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u0439 (scopes), \u0438 \u0432\u043E\u0437\u0432\u0440\u0430\u0449\u0430\u0435\u0442 \u043A\u043E\u0434 \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u0438 \u043F\u043E\u0441\u043B\u0435 \u0442\u043E\u0433\u043E, \u043A\u0430\u043A \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C \u0440\u0430\u0437\u0440\u0435\u0448\u0438\u0442 \u0434\u043E\u0441\u0442\u0443\u043F.",
		RevokeTokenUrlTip: "\u0427\u0430\u0441\u0442\u043E \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 .../revoke.\n\u042D\u0442\u043E - \u043D\u0435\u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435. \u041F\u0440\u0438 \u044D\u0442\u043E\u043C, \u0435\u0441\u043B\u0438 \u043E\u043D\u043E \u043D\u0435 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043E, \u043C\u043E\u0433\u0443\u0442 \u0431\u044B\u0442\u044C \u0441\u043B\u043E\u0436\u043D\u043E\u0441\u0442\u0438, \u0435\u0441\u043B\u0438 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C:\n1. \u0410\u0432\u0442\u043E\u0440\u0438\u0437\u0443\u0435\u0442\u0441\u044F \u0432 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0438.\n2. \u0423\u0434\u0430\u043B\u0438\u0442 \u0441\u0432\u043E\u0439 \u0442\u043E\u043A\u0435\u043D \u0438\u0437 Creatio.\n3. \u0421\u043D\u043E\u0432\u0430 \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0443\u0435\u0442\u0441\u044F \u0432 \u044D\u0442\u043E\u043C \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0438.",
		RedirectUrlHelpLine1: "\u0417\u0430\u043F\u0440\u043E\u0441\u00A0\u0431\u0443\u0434\u0435\u0442\u00A0\u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u044C\u00A0redirect\u00A0URL\u00A0=\u00A0",
		RedirectUrlHelpLine2: "\u0423\u0431\u0435\u0434\u0438\u0442\u0435\u0441\u044C, \u0447\u0442\u043E \u044D\u0442\u043E\u0442 redirect URL \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D \u0432 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430\u0445 \u0432\u0430\u0448\u0435\u0433\u043E \u0432\u043D\u0435\u0448\u043D\u0435\u0433\u043E \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F",
		TokenUrlPlaceholder: "https://example.com/oauth2/token",
		AuthUrlPlaceholder: "https://example.com/oauth2/authorize",
		RevokeUrlPlaceholder: "https://example.com/oauth2/revoke",
		UsePersonalAccountsCaption: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043B\u0438\u0447\u043D\u044B\u0435 \u0443\u0447\u0435\u0442\u043D\u044B\u0435 \u0437\u0430\u043F\u0438\u0441\u0438 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0435\u0439",
		LoginSharedUserCaption: "\u0410\u0432\u0442\u043E\u0440\u0438\u0437\u043E\u0432\u0430\u0442\u044C\u0441\u044F",
		LoginCallbackFailed: "\u041E\u0448\u0438\u0431\u043A\u0430 \u043F\u0440\u0438 \u043F\u043E\u043F\u044B\u0442\u043A\u0435 \u0432\u044B\u0437\u0432\u0430\u0442\u044C \u0441\u0435\u0440\u0432\u0438\u0441 \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u0438 OAuth",
		RadioGroupCaption: "\u041A\u0430\u043A\u0443\u044E \u0443\u0447\u0435\u0442\u043D\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C",
		FaqSettingUpOauthUrlText: "\u041A\u0430\u043A \u043D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0435 OAuth 2.0",
		FaqTypicalIssuesUrlText: "\u0422\u0438\u043F\u0438\u0447\u043D\u044B\u0435 \u043E\u0448\u0438\u0431\u043A\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		FaqHeaderText: "\u0427\u0430\u0441\u0442\u043E \u0437\u0430\u0434\u0430\u0432\u0430\u0435\u043C\u044B\u0435 \u0432\u043E\u043F\u0440\u043E\u0441\u044B",
		CredentialsLocationCaption: "\u041E\u0442\u043F\u0440\u0430\u0432\u043B\u044F\u0442\u044C client id \u0438 secret \u0432 \u0437\u0430\u043F\u0440\u043E\u0441\u0435 \u0442\u043E\u043A\u0435\u043D\u0430",
		CredentialsLocationTip: "\u0412\u043B\u0438\u044F\u0435\u0442 \u043D\u0430 \u0441\u0442\u0440\u0443\u043A\u0442\u0443\u0440\u0443 \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u043F\u043E\u043B\u0443\u0447\u0435\u043D\u0438\u044F \u0438 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u044F \u0442\u043E\u043A\u0435\u043D\u0430. \u0417\u0430\u0447\u0430\u0441\u0442\u0443\u044E \u043F\u0440\u0430\u0432\u0438\u043B\u044C\u043D\u044B\u0439 \u0441\u043F\u043E\u0441\u043E\u0431 \u043E\u043F\u0438\u0441\u0430\u043D \u0432 \u0434\u043E\u043A\u0443\u043C\u0435\u043D\u0442\u0430\u0446\u0438\u0438 \u043F\u043E \u0430\u0443\u0442\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u0438 \u0432\u043E \u0432\u043D\u0435\u0448\u043D\u0435\u0439 \u0441\u0438\u0441\u0442\u0435\u043C\u0435. "
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		InfoImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "InfoImage",
				hash: "3b85678707bfb489696f19e09a33acca",
				resourceItemExtension: ".png"
			}
		},
		DefaultAppIcon: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "DefaultAppIcon",
				hash: "74d0bd728776773ffe8aec1eefd77457",
				resourceItemExtension: ".svg"
			}
		},
		FAQIcon: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "FAQIcon",
				hash: "33b69a203f6e15eecb7c3e02b1a77920",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "OAuth20AppPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});