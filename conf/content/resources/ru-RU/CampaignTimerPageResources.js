﻿define("CampaignTimerPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessInformationText: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442 \u0422\u0430\u0439\u043C\u0435\u0440 \u0434\u043B\u044F \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u0432\u0440\u0435\u043C\u0435\u043D\u0438, \u043F\u0435\u0440\u0438\u043E\u0434\u0430 \u0438\u043B\u0438 \u0442\u0430\u0439\u043C\u0437\u043E\u043D\u044B \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u043E\u0432, \u043D\u0430\u043F\u0440\u0438\u043C\u0435\u0440, \u0434\u043B\u044F \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0438 \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u0442\u043E\u043B\u044C\u043A\u043E \u0432 \u0440\u0430\u0431\u043E\u0447\u0438\u0435 \u0434\u043D\u0438 \u0438 \u0440\u0430\u0431\u043E\u0447\u0435\u0435 \u0432\u0440\u0435\u043C\u044F. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignTimerElement\u0022 target=\u0022_blank\u0022\u003E\u0414\u0435\u0442\u0430\u043B\u044C\u043D\u0435\u0435...\u003C/a\u003E",
		OptionalStartTimeLabel: "\u0414\u0430\u0442\u0430 \u0438 \u0432\u0440\u0435\u043C\u044F \u043D\u0430\u0447\u0430\u043B\u0430",
		OptionalEndTimeLabel: "\u0414\u0430\u0442\u0430 \u0438 \u0432\u0440\u0435\u043C\u044F \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u044F",
		ExpressionTypeCaption: "\u041F\u0435\u0440\u0438\u043E\u0434\u0438\u0447\u043D\u043E\u0441\u0442\u044C \u0437\u0430\u043F\u0443\u0441\u043A\u0430 \u0442\u0430\u0439\u043C\u0435\u0440\u0430",
		ExpressionTypeSingleRunCaption: "\u041E\u0434\u043D\u043E\u043A\u0440\u0430\u0442\u043D\u043E",
		ExpressionTypeDayCaption: "\u041A\u0430\u0436\u0434\u044B\u0439 \u0434\u0435\u043D\u044C",
		ExpressionTypeWeekCaption: "\u041D\u0435\u0434\u0435\u043B\u044F",
		ExpressionTypeMonthCaption: "\u041C\u0435\u0441\u044F\u0446",
		ExpressionTypeCustomCronExpressionCaption: "\u0414\u0440\u0443\u0433\u0430\u044F \u043F\u0435\u0440\u0438\u043E\u0434\u0438\u0447\u043D\u043E\u0441\u0442\u044C",
		SingleRunValidationMessage: "\u0412\u044B\u0431\u0440\u0430\u043D\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043C\u0435\u043D\u044C\u0448\u0435 \u0442\u0435\u043A\u0443\u0449\u0435\u0439 \u0434\u0430\u0442\u044B \u0438 \u0432\u0440\u0435\u043C\u0435\u043D\u0438",
		InvalidTimerPeriodMessage: "\u0412\u0440\u0435\u043C\u044F \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u044F \u043D\u0435 \u0434\u043E\u043B\u0436\u043D\u043E \u043F\u0440\u0435\u0432\u044B\u0448\u0430\u0442\u044C \u0438\u043B\u0438 \u0440\u0430\u0432\u043D\u044F\u0442\u044C\u0441\u044F \u0432\u0440\u0435\u043C\u0435\u043D\u0438 \u043D\u0430\u0447\u0430\u043B\u0430",
		SingleRunStartDateTimeLabel: "\u0414\u0430\u0442\u0430 \u0438 \u0432\u0440\u0435\u043C\u044F \u0437\u0430\u043F\u0443\u0441\u043A\u0430",
		TimerPeriodCaption: "\u041F\u0435\u0440\u0438\u043E\u0434 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u0442\u0430\u0439\u043C\u0435\u0440\u0430",
		TimePeriodEndCaption: "\u043F\u043E",
		TimePeriodStartCaption: "\u0441",
		TimePeriodOptionCaption: "\u041F\u0435\u0440\u0438\u043E\u0434",
		ExactTimeOptionCaption: "\u0422\u043E\u0447\u043D\u043E\u0435 \u0432\u0440\u0435\u043C\u044F",
		ExecutionTimeLabel: "\u0412\u0440\u0435\u043C\u044F \u0437\u0430\u043F\u0443\u0441\u043A\u0430",
		OptionalTimeZoneLabel: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u0447\u0430\u0441\u043E\u0432\u043E\u0439 \u043F\u043E\u044F\u0441",
		UseCustomTimeZoneHint: "\u0417\u0434\u0435\u0441\u044C \u043C\u043E\u0436\u043D\u043E \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u0447\u0430\u0441\u043E\u0432\u043E\u0439 \u043F\u043E\u044F\u0441 \u0434\u043B\u044F \u044D\u0442\u043E\u0433\u043E \u0422\u0430\u0439\u043C\u0435\u0440\u0430. \u0415\u0441\u043B\u0438 \u0447\u0430\u0441\u043E\u0432\u043E\u0439 \u043F\u043E\u044F\u0441 \u043D\u0435 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D, \u0442\u043E \u0422\u0430\u0439\u043C\u0435\u0440 \u0440\u0430\u0431\u043E\u0442\u0430\u0435\u0442 \u0441\u043E\u0433\u043B\u0430\u0441\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043A \u0447\u0430\u0441\u043E\u0432\u043E\u0433\u043E \u043F\u043E\u044F\u0441\u0430 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignTimerPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});