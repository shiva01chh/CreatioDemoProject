﻿define("ProcessFlowElementPropertiesPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessSchemaParameterEditPageCaption: "\u0412\u0441\u0442\u0430\u0432\u043A\u0430 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430",
		EmptyParametersMessage: "\u0423 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u043D\u0435\u0442 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432",
		ParametersTabCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B",
		AddParameterButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440",
		IsLoggingCaption: "\u0416\u0443\u0440\u043D\u0430\u043B\u0438\u0440\u043E\u0432\u0430\u0442\u044C",
		SerializeToDBCaption: "\u0421\u0435\u0440\u0438\u0430\u043B\u0438\u0437\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0432 \u0411\u0414",
		MappingPlaceholderCaption: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435",
		RecepientTip: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u0430\u0434\u0440\u0435\u0441 \u044D\u043B\u0435\u043A\u0442\u0440\u043E\u043D\u043D\u043E\u0439 \u043F\u043E\u0447\u0442\u044B \u043F\u043E\u043B\u0443\u0447\u0430\u0442\u0435\u043B\u044F. \u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u043A\u043E\u043D\u043A\u0440\u0435\u0442\u043D\u044B\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0430\u0434\u0440\u0435\u0441\u0430 \u043B\u0438\u0431\u043E \u043E\u043F\u0440\u0435\u0434\u0435\u043B\u044F\u0442\u044C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u0438 \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0430\u043D\u0438\u0438 \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u0438 \u0432 \u0434\u0440\u0443\u0433\u0438\u0445 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430\u0445 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430.",
		UseBackgroundModeCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u044F\u0442\u044C \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0432 \u0444\u043E\u043D\u043E\u0432\u043E\u043C \u0440\u0435\u0436\u0438\u043C\u0435",
		MultiInstanceExecutionModeCaption: "\u0420\u0435\u0436\u0438\u043C \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F",
		IgnoreMultiInstanceErrorsCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0430\u0442\u044C \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u043F\u0440\u0438 \u043D\u0430\u043B\u0438\u0447\u0438\u0438 \u043E\u0448\u0438\u0431\u043E\u043A",
		BackgroundModePriority100Caption: "\u041D\u0438\u0437\u043A\u0438\u0439",
		BackgroundModePriority200Caption: "\u0421\u0440\u0435\u0434\u043D\u0438\u0439",
		BackgroundModePriority300Caption: "\u0412\u044B\u0441\u043E\u043A\u0438\u0439",
		BackgroundModePriority0Caption: "\u0411\u0440\u0430\u0442\u044C \u0438\u0437 \u0441\u0432\u043E\u0439\u0441\u0442\u0432\u0430 \u0411\u041F",
		BackgroundModePriorityCaption: "\u041F\u0440\u0438\u043E\u0440\u0438\u0442\u0435\u0442 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u0432 \u0444\u043E\u043D\u0435",
		CaptionCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		DeleteMenuItemCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		DescriptionCaption: "\u041E\u043F\u0438\u0441\u0430\u043D\u0438\u0435",
		DuplicateNameMessage: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442 \u0441 \u0442\u0430\u043A\u0438\u043C \u043A\u043E\u0434\u043E\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442.",
		DuplicateParameterNameMessage: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u0441 \u0442\u0430\u043A\u0438\u043C \u043A\u043E\u0434\u043E\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442.",
		EditMenuItemCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C",
		ElementPropertyNotFoundExceptionMessage: "\u0421\u0432\u043E\u0439\u0441\u0442\u0432\u043E \u0027{0}\u0027 \u043D\u0435 \u043D\u0430\u0439\u0434\u0435\u043D\u043E \u0432 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0435 \u0027{1}\u0027",
		ExtendedModeCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u044B\u0439 \u0440\u0435\u0436\u0438\u043C",
		InavalidMappingColumn: "\u041E\u0448\u0438\u0431\u043A\u0430 \u0432 \u0444\u043E\u0440\u043C\u0443\u043B\u0435",
		NameCaption: "\u0418\u043C\u044F",
		PrimaryModeCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u0440\u0435\u0436\u0438\u043C",
		ProcessInformationText: "\u041F\u043E\u0434\u0441\u043A\u0430\u0437\u043A\u0430 \u043F\u043E \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0443",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SettingsTabCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		WrongNameMessage: "\u0412\u0432\u0435\u0434\u0435\u043D\u043E \u043D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435. \u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u0441\u0438\u043C\u0432\u043E\u043B\u044B: a-z, A-Z, 0-9. \u003C/br\u003E \u0421\u0438\u043C\u0432\u043E\u043B: 0-9 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043F\u0435\u0440\u0432\u044B\u043C."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ProcessFlowElementPropertiesPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});