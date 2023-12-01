﻿define("CampaignStartSignalPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ObjectEntityCaption: "\u0414\u043E\u0431\u0430\u0432\u043B\u044F\u0442\u044C \u0443\u0447\u0430\u0441\u0442\u043D\u0438\u043A\u043E\u0432 \u043F\u0440\u0438 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0438/\u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0438 \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		EntityColumnsInformationText: "\u041A\u043E\u043B\u043E\u043D\u043A\u0438 \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u043D\u0435 \u0443\u043A\u0430\u0437\u0430\u043D\u044B. \u0422\u0440\u0438\u0433\u0433\u0435\u0440 \u0431\u0443\u0434\u0435\u0442 \u0441\u0440\u0430\u0431\u0430\u0442\u044B\u0432\u0430\u0442\u044C \u043F\u0440\u0438 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0438 \u043B\u044E\u0431\u043E\u0439 \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		IsRecurringLabel: "\u041F\u0440\u0430\u0432\u0438\u043B\u0430 \u0443\u0447\u0430\u0441\u0442\u0438\u044F",
		IsRecurringCaption: "\u041F\u043E\u0432\u0442\u043E\u0440\u043D\u044B\u0439 \u0432\u0445\u043E\u0434",
		IsRecurringHint: "\u0421\u0432\u043E\u0439\u0441\u0442\u0432\u043E \u0440\u0435\u0433\u0443\u043B\u0438\u0440\u0443\u0435\u0442 \u043F\u0440\u0430\u0432\u0438\u043B\u0430 \u0443\u0447\u0430\u0441\u0442\u0438\u044F \u0432 \u0441\u043B\u0443\u0447\u0430\u0435 \u043F\u043E\u0432\u0442\u043E\u0440\u043D\u043E\u0433\u043E \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0443\u0447\u0430\u0441\u0442\u043D\u0438\u043A\u0430 \u043F\u043E \u0441\u0438\u0433\u043D\u0430\u043B\u0443.\n\u0415\u0441\u043B\u0438 \u043E\u0442\u043C\u0435\u0447\u0435\u043D\u043E - \u043F\u0440\u043E\u0448\u043B\u043E\u0435 \u0443\u0447\u0430\u0441\u0442\u0438\u0435 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430 \u0431\u0443\u0434\u0435\u0442 \u043F\u0440\u0438\u043E\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043E.\n\u0415\u0441\u043B\u0438 \u043F\u0443\u0441\u0442\u043E - \u0431\u0443\u0434\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D \u0444\u0440\u0430\u0433\u043C\u0435\u043D\u0442 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0434\u043E \u0437\u0430\u0434\u0435\u0440\u0436\u043A\u0438 \u043F\u043E \u0432\u0440\u0435\u043C\u0435\u043D\u0438.",
		SaveTemplateButtonText: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SelectFromLookupButtonText: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C \u0438\u0437 \u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0430",
		ElementConfigCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430",
		ElementConfigHintText: "\u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0441\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u0434\u043B\u044F \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u043D\u0438\u044F \u0432 \u0434\u0440\u0443\u0433\u0438\u0445 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F\u0445. \u0428\u0430\u0431\u043B\u043E\u043D \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043A \u0441\u043E\u0445\u0440\u0430\u043D\u044F\u0435\u0442\u0441\u044F \u0432 \u003Ca href=\u0022ViewModule.aspx#LookupSectionModule/BaseLookupConfigurationSection/CampaignElementTemplate\u0022 target=\u0022_blank\u0022\u003E\u0441\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u003C/a\u003E",
		AddParameterButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440",
		AddRecordColumnValuesButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		AnyFieldCaption: "\u041B\u044E\u0431\u043E\u0433\u043E \u043F\u043E\u043B\u044F",
		AnySelectedFieldCaption: "\u041B\u044E\u0431\u043E\u0433\u043E \u043F\u043E\u043B\u044F \u0438\u0437 \u0432\u044B\u0431\u0440\u0430\u043D\u043D\u044B\u0445",
		BackgroundModePriority0Caption: "\u0411\u0440\u0430\u0442\u044C \u0438\u0437 \u0441\u0432\u043E\u0439\u0441\u0442\u0432\u0430 \u0411\u041F",
		BackgroundModePriority300Caption: "\u0412\u044B\u0441\u043E\u043A\u0438\u0439",
		BackgroundModePriority200Caption: "\u0421\u0440\u0435\u0434\u043D\u0438\u0439",
		BackgroundModePriority100Caption: "\u041D\u0438\u0437\u043A\u0438\u0439",
		BackgroundModePriorityCaption: "\u041F\u0440\u0438\u043E\u0440\u0438\u0442\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u0432 \u0444\u043E\u043D\u0435",
		CaptionCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		CustomValidatorInvalidMessage: "\u041D\u0435 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043E \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435",
		DeletedEntityChangeTypeCaption: "\u0423\u0434\u0430\u043B\u0435\u043D\u0438\u0435 \u0437\u0430\u043F\u0438\u0441\u0438",
		DeletedObjectSignalFilterCaption: "\u0417\u0430\u043F\u0438\u0441\u044C \u0434\u043E\u043B\u0436\u043D\u0430 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u043E\u0432\u0430\u0442\u044C \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C",
		DeleteMenuItemCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		DescriptionCaption: "\u041E\u043F\u0438\u0441\u0430\u043D\u0438\u0435",
		DuplicateNameMessage: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442 \u0441 \u0442\u0430\u043A\u0438\u043C \u043A\u043E\u0434\u043E\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442.",
		DuplicateParameterNameMessage: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u0441 \u0442\u0430\u043A\u0438\u043C \u043A\u043E\u0434\u043E\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442.",
		EditMenuItemCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C",
		ElementPropertyNotFoundExceptionMessage: "\u0421\u0432\u043E\u0439\u0441\u0442\u0432\u043E \u0027{0}\u0027 \u043D\u0435 \u043D\u0430\u0439\u0434\u0435\u043D\u043E \u0432 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0435 \u0027{1}\u0027",
		EmptyParametersMessage: "\u0423 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u043D\u0435\u0442 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432",
		EntityCaption: "\u041E\u0431\u044A\u0435\u043A\u0442",
		EntityChangeTypeCaption: "\u041A\u0430\u043A\u043E\u0435 \u0441\u043E\u0431\u044B\u0442\u0438\u0435 \u0434\u043E\u043B\u0436\u043D\u043E \u043F\u0440\u043E\u0438\u0437\u043E\u0439\u0442\u0438?",
		EntityColumnsLookupPageCaption: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		ExpectChangesCaption: "\u0422\u0440\u0438\u0433\u0433\u0435\u0440 \u0441\u0440\u0430\u0431\u043E\u0442\u0430\u0435\u0442 \u043F\u0440\u0438 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0438 \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0445 \u043A\u043E\u043B\u043E\u043D\u043E\u043A:",
		ExtendedModeCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u0439 \u0440\u0435\u0436\u0438\u043C",
		FilterInformationText: "\u0424\u0438\u043B\u044C\u0442\u0440 \u043F\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0443 \u043D\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D. \u0422\u0440\u0438\u0433\u0433\u0435\u0440 \u0431\u0443\u0434\u0435\u0442 \u0441\u0440\u0430\u0431\u0430\u0442\u044B\u0432\u0430\u0442\u044C \u043F\u043E \u0432\u0441\u0435\u043C \u0437\u0430\u043F\u0438\u0441\u044F\u043C \u044D\u0442\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		IgnoreMultiInstanceErrorsCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0430\u0442\u044C \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u043F\u0440\u0438 \u043D\u0430\u043B\u0438\u0447\u0438\u0438 \u043E\u0448\u0438\u0431\u043E\u043A",
		InavalidMappingColumn: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0444\u043E\u0440\u043C\u0443\u043B\u0435",
		InsertedEntityChangeTypeCaption: "\u0414\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u0437\u0430\u043F\u0438\u0441\u0438",
		InsertedObjectSignalFilterCaption: "\u0414\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043D\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C \u0434\u043E\u043B\u0436\u043D\u0430 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u043E\u0432\u0430\u0442\u044C \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C",
		IsLoggingCaption: "\u0416\u0443\u0440\u043D\u0430\u043B\u0438\u0440\u043E\u0432\u0430\u0442\u044C",
		MappingPlaceholderCaption: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435",
		MultiInstanceExecutionModeCaption: "\u0420\u0435\u0436\u0438\u043C \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F",
		NameCaption: "\u0418\u043C\u044F",
		ObjectSignalCaption: "\u041F\u043E\u043B\u0443\u0447\u0435\u043D \u0441\u0438\u0433\u043D\u0430\u043B \u043E\u0442 \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		ParametersTabCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B",
		PrimaryModeCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u0440\u0435\u0436\u0438\u043C",
		ProcessInformationText: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442 \u0434\u043B\u044F \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0443\u0447\u0430\u0441\u0442\u043D\u0438\u043A\u0430 \u0432 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044E \u043F\u0440\u0438 \u043F\u043E\u044F\u0432\u043B\u0435\u043D\u0438\u0438 \u0437\u0430\u043F\u0438\u0441\u0438, \u043A\u043E\u0442\u043E\u0440\u0430\u044F \u0443\u0434\u043E\u0432\u043B\u0435\u0442\u0432\u043E\u0440\u044F\u0435\u0442 \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignSignalElement\u0022 target=\u0022_blank\u0022\u003E\u0414\u0435\u0442\u0430\u043B\u044C\u043D\u0435\u0435\u003C/a\u003E",
		ProcessSchemaParameterEditPageCaption: "\u0412\u0441\u0442\u0430\u0432\u043A\u0430 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430",
		RecepientTip: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u0430\u0434\u0440\u0435\u0441 \u044D\u043B\u0435\u043A\u0442\u0440\u043E\u043D\u043D\u043E\u0439 \u043F\u043E\u0447\u0442\u044B \u043F\u043E\u043B\u0443\u0447\u0430\u0442\u0435\u043B\u044F. \u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u043A\u043E\u043D\u043A\u0440\u0435\u0442\u043D\u044B\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0430\u0434\u0440\u0435\u0441\u0430 \u043B\u0438\u0431\u043E \u043E\u043F\u0440\u0435\u0434\u0435\u043B\u044F\u0442\u044C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u0438 \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0430\u043D\u0438\u0438 \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u0438 \u0432 \u0434\u0440\u0443\u0433\u0438\u0445 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430\u0445 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430.",
		RecommendationCaption: "\u0421\u0438\u0433\u043D\u0430\u043B \u043A\u0430\u043A\u043E\u0433\u043E \u0442\u0438\u043F\u0430 \u043F\u043E\u043B\u0443\u0447\u0435\u043D?",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SerializeToDBCaption: "\u0421\u0435\u0440\u0438\u0430\u043B\u0438\u0437\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0432 \u0411\u0414",
		SettingsTabCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		SignalCaption: "\u0421\u0438\u0433\u043D\u0430\u043B",
		SimpleSignalCaption: "\u041F\u043E\u043B\u0443\u0447\u0435\u043D \u043F\u0440\u043E\u0438\u0437\u0432\u043E\u043B\u044C\u043D\u044B\u0439 \u0441\u0438\u0433\u043D\u0430\u043B",
		UpdatedEntityChangeTypeCaption: "\u0418\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435 \u0437\u0430\u043F\u0438\u0441\u0438",
		UpdatedObjectSignalFilterCaption: "\u041F\u043E\u0441\u043B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u044C \u0434\u043E\u043B\u0436\u043D\u0430 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u043E\u0432\u0430\u0442\u044C \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C",
		UseBackgroundModeCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0432 \u0444\u043E\u043D\u043E\u0432\u043E\u043C \u0440\u0435\u0436\u0438\u043C\u0435",
		WrongNameMessage: "\u0412\u0432\u0435\u0434\u0435\u043D\u043E \u043D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435. \u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u0441\u0438\u043C\u0432\u043E\u043B\u044B: a-z, A-Z, 0-9. \u003C/br\u003E \u0421\u0438\u043C\u0432\u043E\u043B: 0-9 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043F\u0435\u0440\u0432\u044B\u043C."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});