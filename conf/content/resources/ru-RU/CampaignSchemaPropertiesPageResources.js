﻿define("CampaignSchemaPropertiesPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessInformationText: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignDesigner\u0022 target=\u0022_blank\u0022\u003E\u0414\u0435\u0442\u0430\u043B\u044C\u043D\u0435\u0435\u003C/a\u003E \u043E \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F\u0445.",
		DefaultCampaignFireTimeCaption: "\u041F\u0435\u0440\u0438\u043E\u0434 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E",
		HasCriticalExecutionLateness: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u043A\u0440\u0438\u0442\u0438\u0447\u043D\u043E\u0435 \u0432\u0440\u0435\u043C\u044F \u0437\u0430\u0434\u0435\u0440\u0436\u043A\u0438 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438",
		LatenessDecisionDaysNumber: "\u0414\u043D\u0438",
		LatenessDecisionHoursNumber: "\u0427\u0430\u0441\u044B",
		LatenessUnitCaption: "\u0415\u0434\u0438\u043D\u0438\u0446\u044B \u0437\u0430\u0434\u0435\u0440\u0436\u043A\u0438",
		LatenessUnitQuantity: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E",
		NegativeCriticalExecutionLatenessErrorText: "\u0414\u043E\u043B\u0436\u043D\u043E \u0431\u044B\u0442\u044C \u043F\u043E\u043B\u043E\u0436\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u043C",
		CriticalExecutionLatenessHint: "\u0415\u0441\u043B\u0438 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0437\u0430\u043F\u0443\u0449\u0435\u043D\u0430 \u0432 \u0442\u0435\u0447\u0435\u043D\u0438\u0435 \u0443\u043A\u0430\u0437\u0430\u043D\u043D\u043E\u0433\u043E \u043F\u0435\u0440\u0438\u043E\u0434\u0430, \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F \u0431\u0443\u0434\u0435\u0442 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u043E\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u0430, \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439 \u043F\u043E\u043B\u0443\u0447\u0438\u0442 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0435.",
		DefaultTimeZoneBeforeSavingMessage: "\u041F\u043E\u043B\u0435 \u00AB\u0427\u0430\u0441\u043E\u0432\u043E\u0439 \u043F\u043E\u044F\u0441\u00BB \u0431\u0443\u0434\u0435\u0442 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043E \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u043C \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E - UTC (00:00). \u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u044D\u0442\u043E\u0433\u043E \u043F\u043E\u043B\u044F \u0432 \u043A\u0430\u0440\u0442\u043E\u0447\u043A\u0435 \u0441\u0432\u043E\u0439\u0441\u0442\u0432 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438.",
		DefaultFirePeriodBeforeSavingMessage: "\u041F\u043E\u043B\u0435 \u00AB\u041F\u0435\u0440\u0438\u043E\u0434 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E\u00BB \u0431\u0443\u0434\u0435\u0442 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043E \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u043C \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E - 1 \u0447\u0430\u0441. \u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u044D\u0442\u043E\u0433\u043E \u043F\u043E\u043B\u044F \u0432 \u043A\u0430\u0440\u0442\u043E\u0447\u043A\u0435 \u0441\u0432\u043E\u0439\u0441\u0442\u0432 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438.",
		DefaultCampaignCaption: "\u041C\u0430\u0440\u043A\u0435\u0442\u0438\u043D\u0433\u043E\u0432\u0430\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F",
		EmptyCaptionValidationMessage: "\u0412\u0432\u0435\u0434\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435",
		CaptionLengthValidationMessage: "\u041F\u0440\u0435\u0432\u044B\u0448\u0435\u043D\u0430 \u0434\u043E\u043F\u0443\u0441\u0442\u0438\u043C\u0430\u044F \u0434\u043B\u0438\u043D\u0430 \u0442\u0435\u043A\u0441\u0442\u0430 ({0}/{1})"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignSchemaPropertiesPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});