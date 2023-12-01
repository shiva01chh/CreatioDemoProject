﻿define("OpportunityFunnelModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		YesterdayCaption: "\u0412\u0447\u0435\u0440\u0430",
		TodayCaption: "\u0421\u0435\u0433\u043E\u0434\u043D\u044F",
		TomorrowCaption: "\u0417\u0430\u0432\u0442\u0440\u0430",
		PastWeekCaption: "\u041F\u0440\u043E\u0448\u043B\u0430\u044F \u043D\u0435\u0434\u0435\u043B\u044F",
		CurrentWeekCaption: "\u0422\u0435\u043A\u0443\u0449\u0430\u044F \u043D\u0435\u0434\u0435\u043B\u044F",
		NextWeekCaption: "\u0421\u043B\u0435\u0434\u0443\u044E\u0449\u0430\u044F \u043D\u0435\u0434\u0435\u043B\u044F",
		PastMonthCaption: "\u041F\u0440\u043E\u0448\u043B\u044B\u0439 \u043C\u0435\u0441\u044F\u0446",
		CurrentMonthCaption: "\u0422\u0435\u043A\u0443\u0449\u0438\u0439 \u043C\u0435\u0441\u044F\u0446",
		NextMonthCaption: "\u0421\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0439 \u043C\u0435\u0441\u044F\u0446",
		ClearCaption: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C",
		PeriodToLabelCaption: "\u043F\u043E",
		EmptyDateDisplayValue: "\u043D\u0435 \u043E\u0433\u0440\u0430\u043D\u0438\u0447\u0435\u043D\u043E",
		StartDatePlaceholder: "\u003C\u041D\u0430\u0447\u0430\u043B\u043E\u003E",
		DueDatePlaceholder: "\u003C\u0417\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0435\u003E",
		StageConversionCaption: "\u041A\u043E\u043D\u0432\u0435\u0440\u0441\u0438\u044F \u0441\u0442\u0430\u0434\u0438\u0438",
		ToFirstStageConversionCaption: "\u041A \u043F\u0435\u0440\u0432\u043E\u0439 \u0441\u0442\u0430\u0434\u0438\u0438",
		ConversionByCountCaption: "\u041F\u043E \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u0443",
		SelectPeriodHint: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C \u043F\u0435\u0440\u0438\u043E\u0434",
		RemoveButtonHint: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C \u0444\u0438\u043B\u044C\u0442\u0440",
		DrillDownCaption: "\u0423\u0433\u043B\u0443\u0431\u0438\u0442\u044C\u0441\u044F \u0432 \u044D\u043B\u0435\u043C\u0435\u043D\u0442",
		ShowDataCaption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435",
		ChartChangeTypeCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0442\u0438\u043F \u0434\u0438\u0430\u0433\u0440\u0430\u043C\u043C\u044B",
		ShowChartCaption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C \u0434\u0438\u0430\u0433\u0440\u0430\u043C\u043C\u0443",
		SetupGridMenuCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		SortMenuCaption: "\u0421\u043E\u0440\u0442\u0438\u0440\u043E\u0432\u043A\u0430",
		LoadMoreButtonCaption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435",
		ExportListToFileButtonCaption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0441\u043F\u0438\u0441\u043E\u043A \u0432 \u0444\u0430\u0439\u043B",
		BooleanFieldTrueCaption: "\u0414\u0430",
		BooleanFieldFalseCaption: "\u041D\u0435\u0442",
		QueryDataLimitMessage: "\u0412\u043D\u0438\u043C\u0430\u043D\u0438\u0435!\n\u041F\u0440\u0438 \u0437\u0430\u0434\u0430\u043D\u043D\u043E\u043C \u0443\u0441\u043B\u043E\u0432\u0438\u0438 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438 \u0434\u043B\u044F \u0441\u0435\u0440\u0438\u0438(\u0438\u0439): {0}, \u043F\u0440\u0435\u0432\u044B\u0448\u0435\u043D \u043B\u0438\u043C\u0438\u0442 \u043A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u0439 ({1} \u0448\u0442.), \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u044B\u0439 \u0432 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u0439 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0435 \u0022\u041E\u0433\u0440\u0430\u043D\u0438\u0447\u0435\u043D\u0438\u0435 \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u0434\u0430\u043D\u043D\u044B\u0445 \u0433\u0440\u0430\u0444\u0438\u043A\u0430\u0022.\n\u041E\u0442\u043E\u0431\u0440\u0430\u0437\u0438\u0442\u044C \u0432\u0441\u0435?",
		SettingsButtonHint: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0435\u043D\u0438\u0435",
		DrillUpButtonHint: "\u0412\u0435\u0440\u043D\u0443\u0442\u044C\u0441\u044F \u043A \u043F\u0440\u0435\u0434\u044B\u0434\u0443\u0449\u0435\u043C\u0443 \u0432\u0438\u0434\u0443",
		ExportListToExcelFileButtonCaption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		MonthPeriodButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "MonthPeriodButtonImage",
				hash: "2402caae5b4f9b135ab281673811c24f",
				resourceItemExtension: ".png"
			}
		},
		WeekPeriodButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "WeekPeriodButtonImage",
				hash: "903a764689486184aab44be9ad089dd4",
				resourceItemExtension: ".png"
			}
		},
		DayPeriodButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "DayPeriodButtonImage",
				hash: "60d5bab38f94828a54714d4625d41098",
				resourceItemExtension: ".png"
			}
		},
		RemoveButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "RemoveButtonImage",
				hash: "42b5b815fe5ef39879666f4595bd892b",
				resourceItemExtension: ".png"
			}
		},
		Settings: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "Settings",
				hash: "fe36cfab3b2a4678c406b8e54197a9b3",
				resourceItemExtension: ".svg"
			}
		},
		DrillUp: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "DrillUp",
				hash: "3c398f7853f1a36a28482a3080d46c34",
				resourceItemExtension: ".svg"
			}
		},
		DrillHome: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "DrillHome",
				hash: "ac7f3e129228702b06183b30b857975f",
				resourceItemExtension: ".png"
			}
		},
		LoadMoreIcon: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "LoadMoreIcon",
				hash: "010a38d79ad1acb4726eb1dae1d7f14c",
				resourceItemExtension: ".png"
			}
		},
		QueryDataLimitImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "QueryDataLimitImage",
				hash: "74e2c33c404b6db5a8f1af7500320c06",
				resourceItemExtension: ".svg"
			}
		},
		FullScreenImg: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "FullScreenImg",
				hash: "77c5f8c0e5f06fafa63383a812d8ed93",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "OpportunityFunnelModule",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});