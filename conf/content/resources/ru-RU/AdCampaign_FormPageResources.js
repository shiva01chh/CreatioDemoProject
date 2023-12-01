﻿define("AdCampaign_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ContactsIndicatorWidget_title: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		ContactsIndicatorWidget_template: "{0}",
		DataGrid_DailyInsightsListDS_CostPerContact: "\u0426\u0435\u043D\u0430 \u0437\u0430 \u043A\u043E\u043D\u0442\u0430\u043A\u0442",
		DataGrid_DailyInsightsListDS_Contacts: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		DataGrid_DailyInsightsListDS_CostPerSubmission: "\u0426\u0435\u043D\u0430 \u0437\u0430 \u0432\u0435\u0431-\u0444\u043E\u0440\u043C\u0443",
		DataGrid_DailyInsightsListDS_Submissions: "\u0412\u0435\u0431-\u0444\u043E\u0440\u043C\u044B",
		AmountSpentChartWidget_series_0: "\u041A\u043B\u0438\u043A\u0438",
		AmountSpentChartWidget_series_1: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		AmountSpentChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439 \u0437\u0430\u0442\u0440\u0430\u0442",
		AmountSpentIndicatorWidget_template: "{0}",
		AmountSpentIndicatorWidget_title: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		AmountSpentTab_caption: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		AttachmentAddButtonCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		AttachmentRefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		AttachmentsTabContainerCaption: "\u0424\u0430\u0439\u043B\u044B",
		BackButton: "\u041D\u0430\u0437\u0430\u0434",
		CancelButton: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ClicksIndicatorWidget_template: "{0}",
		ClicksIndicatorWidget_title: "\u041A\u043B\u0438\u043A\u0438",
		CloseButton: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		DailyInsightsExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		DailyInsightsListLabel_caption: "\u0415\u0436\u0435\u0434\u043D\u0435\u0432\u043D\u0430\u044F \u0430\u043D\u0430\u043B\u0438\u0442\u0438\u043A\u0430",
		DailyInsightsListSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		DailyInsightsStartSyncButton_caption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u0441\u0438\u043D\u0445\u0440\u043E\u043D\u0438\u0437\u0430\u0446\u0438\u044E",
		DataGrid_DailyInsightsListDS_Clicks: "\u041A\u043B\u0438\u043A\u0438",
		DataGrid_DailyInsightsListDS_CPC: "CPC",
		DataGrid_DailyInsightsListDS_CPM: "CPM",
		DataGrid_DailyInsightsListDS_CTR: "CTR, %",
		DataGrid_DailyInsightsListDS_DataRangeDate: "\u0414\u0430\u0442\u0430",
		DataGrid_DailyInsightsListDS_Impressions: "\u041F\u043E\u043A\u0430\u0437\u044B",
		DataGrid_DailyInsightsListDS_PrimaryAmountSpent: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		DateRangeQuickFilter_config_caption: "\u0414\u0438\u0430\u043F\u0430\u0437\u043E\u043D \u0434\u0430\u043D\u043D\u044B\u0445",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		FeedTabContainerCaption: "\u041B\u0435\u043D\u0442\u0430",
		GeneralInfoTab_caption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		ImageInput_FacebookImage_label: "Image to upload",
		ImageInput_GoogleImage_label: "Image to upload",
		ImpressionsIndicatorWidget_template: "{0}",
		ImpressionsIndicatorWidget_title: "\u041F\u043E\u043A\u0430\u0437\u044B",
		NewRecord: "\u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		Record: "\u0417\u0430\u043F\u0438\u0441\u044C",
		SaveButton: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SetRecordRightsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});