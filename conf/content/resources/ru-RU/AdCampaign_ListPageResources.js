﻿define("AdCampaign_ListPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ClicksChartWidget_series_0: "Facebook",
		ClicksChartWidget_series_2: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		AmountSpentChartWidget_series_2: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		AmountSpentChartWidget_series_0: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442, $",
		ContactsIndicatorWidget_title: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		ContactsIndicatorWidget_template: "{0}",
		PDS_CostPerContact: "\u0426\u0435\u043D\u0430 \u0437\u0430 \u043A\u043E\u043D\u0442\u0430\u043A\u0442",
		PDS_Contacts: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		PDS_CostPerSubmission: "\u0426\u0435\u043D\u0430 \u0437\u0430 \u0432\u0435\u0431-\u0444\u043E\u0440\u043C\u0443",
		PDS_Submissions: "\u0412\u0435\u0431-\u0444\u043E\u0440\u043C\u044B",
		ActionButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		AdAccountsFacebookContainerAddButton_caption: "\u041F\u043E\u0434\u043A\u043B\u044E\u0447\u0438\u0442\u044C \u0430\u043A\u043A\u0430\u0443\u043D\u0442",
		AdAccountsGoogleContainerAddButton_caption: "\u041F\u043E\u0434\u043A\u043B\u044E\u0447\u0438\u0442\u044C \u0430\u043A\u043A\u0430\u0443\u043D\u0442",
		AdAccountsQuickFilter_config_caption: "\u0420\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0435 \u0430\u043A\u043A\u0430\u0443\u043D\u0442\u044B",
		AdAccountsTabContainer_caption: "\u0420\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0435 \u0430\u043A\u043A\u0430\u0443\u043D\u0442\u044B",
		AdAccountsTabContainerFacebookContainerDescriptionLabel_caption: "\u041F\u043E\u0437\u0432\u043E\u043B\u044F\u0435\u0442 \u0440\u0430\u0437\u043C\u0435\u0449\u0430\u0442\u044C \u0440\u0435\u043A\u043B\u0430\u043C\u0443 \u0432 Facebook, Instagram, Messenger \u0438 Audience Network",
		AdAccountsTabContainerFacebookContainerMainLabel_caption: "Facebook",
		AdAccountsTabContainerGoogleContainerDescriptionLabel_caption: "\u041F\u043E\u0437\u0432\u043E\u043B\u044F\u0435\u0442 \u0440\u0430\u0437\u043C\u0435\u0449\u0430\u0442\u044C \u0440\u0435\u043A\u043B\u0430\u043C\u0443 \u0432 Google Search, Display, YouTube \u0438 Google Shopping",
		AdAccountsTabContainerGoogleContainerMainLabel_caption: "Google",
		AdAccountsTabContainerHeaderLabel_caption: "\u0420\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0435 \u0430\u043A\u043A\u0430\u0443\u043D\u0442\u044B",
		AdCampaignListLabel_caption: "\u0421\u0443\u043C\u043C\u0430\u0440\u043D\u044B\u0435 \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u044B \u043F\u043E \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F\u043C",
		AdCampaignStartSyncButton_caption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u0441\u0438\u043D\u0445\u0440\u043E\u043D\u0438\u0437\u0430\u0446\u0438\u044E",
		AmountSpentChartWidget_series_1: "\u0417\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043D\u044B\u0435 \u0444\u043E\u0440\u043C\u044B",
		AmountSpentChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439 \u0437\u0430\u0442\u0440\u0430\u0442, $",
		AmountSpentIndicatorWidget_template: "{0}",
		AmountSpentIndicatorWidget_title: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442, $",
		AmountSpentTabConteiner_caption: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		Button_Data_Import: "\u0418\u043C\u043F\u043E\u0440\u0442",
		ClicksChartWidget_series_1: "\u0417\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043D\u044B\u0435 \u0444\u043E\u0440\u043C\u044B",
		ClicksChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u043A\u043B\u0438\u043A\u043E\u0432",
		ClicksIndicatorWidget_template: "{0}",
		ClicksIndicatorWidget_title: "\u041A\u043B\u0438\u043A\u0438",
		DataGrid_AdAccountsTabContainerFacebookGridDS_ConnectionStatus: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435 \u043F\u043E\u0434\u043A\u043B\u044E\u0447\u0435\u043D\u0438\u044F",
		DataGrid_AdAccountsTabContainerFacebookGridDS_ConnectionStatusDS_Name: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		DateRangeQuickFilter_config_caption: "\u0414\u0438\u0430\u043F\u0430\u0437\u043E\u043D \u0434\u0430\u043D\u043D\u044B\u0445",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		EmptyFacebookAdAccountPlaceholderTitle: "\u0410\u043A\u043A\u0430\u0443\u043D\u0442 \u043D\u0435 \u043F\u043E\u0434\u043A\u043B\u044E\u0447\u0435\u043D",
		EmptySectionPlaceholderSubHead: "\u0414\u043E\u0431\u0430\u0432\u044C\u0442\u0435 \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C, \u0438 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0442\u0430\u043A \u043E\u0434\u0438\u043D\u043E\u043A\u043E",
		EmptySectionPlaceholderTitle: "\u0412 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		FilteredEmptySectionPlaceholderSubHead: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u0435 \u0444\u0438\u043B\u044C\u0442\u0440 \u0438\u043B\u0438 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044F \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438",
		FilteredEmptySectionPlaceholderTitle: "\u041F\u0440\u0438 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u043E\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0435 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		HelpTabContainer_caption: "\u041F\u043E\u043C\u043E\u0449\u044C",
		HelpTabContainerFlexContainerDescriptionLabel_caption: "",
		HelpTabContainerFlexContainerMainLabel_caption: "\u0420\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0432 Creatio",
		ImageInput_FacebookImage_label: "Image to upload",
		ImpressionsChartWidget_series_1: "Google",
		ImpressionsChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u043F\u043E\u043A\u0430\u0437\u043E\u0432",
		ImpressionsIndicatorWidget_template: "{0}",
		ImpressionsIndicatorWidget_title: "\u041F\u043E\u043A\u0430\u0437\u044B",
		Label_55l5g18_caption: "",
		Label_670ovdf_caption: "",
		Label_Help_caption: "\u041F\u043E\u043C\u043E\u0449\u044C",
		ListActionButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ListTitleCaption: "List title",
		MenuItem_ExcelExport_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		MenuItem_ExportToExel_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		MenuItem_ImportFromExel_caption: "Excel",
		MenuItem_StartSync_caption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u0441\u0438\u043D\u0445\u0440\u043E\u043D\u0438\u0437\u0430\u0446\u0438\u044E",
		OpenLandingDesignerCaption: "Web-\u0444\u043E\u0440\u043C\u044B \u0438 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		PDS_AdAccountCurrency: "\u0412\u0430\u043B\u044E\u0442\u0430",
		PDS_CampaignName: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		PDS_Clicks: "\u041A\u043B\u0438\u043A\u0438",
		PDS_CPC: "CPC",
		PDS_CPM: "CPM",
		PDS_CTR: "CTR, %",
		PDS_Impressions: "\u041F\u043E\u043A\u0430\u0437\u044B",
		PDS_Platform: "\u041F\u043B\u0430\u0442\u0444\u043E\u0440\u043C\u0430",
		PDS_PrimaryAmountSpent: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		PDS_Status: "\u0421\u0442\u0430\u0442\u0443\u0441",
		SearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		TabContainer_AmountSpent_caption: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		TabContainer_Clicks_caption: "\u041A\u043B\u0438\u043A\u0438",
		TabContainer_Impressions_caption: "\u041F\u043E\u043A\u0430\u0437\u044B",
		PDS_AmountSpent: "\u0421\u0443\u043C\u043C\u0430 \u0437\u0430\u0442\u0440\u0430\u0442",
		ImpressionsChartWidget_series_0: "Facebook",
		HelpTabContainerFlexContainerDescriptionLabel3_caption: "\u0410\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438\u0439 \u0438\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445 \u0438\u0437 \u0440\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0445 \u043F\u043B\u0430\u0442\u0444\u043E\u0440\u043C \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u0435\u0436\u0435\u0434\u043D\u0435\u0432\u043D\u043E.",
		HelpTabContainerFlexContainerDescriptionLabel2_caption: "\u0412 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0438 \u0443\u0436\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0434\u0438\u0430\u0433\u0440\u0430\u043C\u043C\u044B \u0438 \u0433\u0440\u0430\u0444\u0438\u043A\u0438, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u043D\u043E\u0432\u044B\u0445 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432 \u0438 \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C \u043F\u0440\u0438\u0432\u043B\u0435\u0447\u0435\u043D\u0438\u044F \u043E\u0434\u043D\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430. \u042D\u0442\u0438 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0440\u0430\u0441\u0441\u0447\u0438\u0442\u044B\u0432\u0430\u044E\u0442\u0441\u044F \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0430\u043D\u0438\u0438 \u0434\u0430\u043D\u043D\u044B\u0445 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0439, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0438\u043C\u043F\u043E\u0440\u0442\u0438\u0440\u0443\u044E\u0442\u0441\u044F \u0432 Creatio \u0438\u0437 \u0440\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0445 \u043F\u043B\u0430\u0442\u0444\u043E\u0440\u043C \u0431\u043B\u0430\u0433\u043E\u0434\u0430\u0440\u044F UTM-\u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430\u043C.",
		HelpTabContainerFlexContainerDescriptionLabel1_caption: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u0440\u0430\u0437\u0434\u0435\u043B \u0420\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0435 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0438 \u0434\u043B\u044F \u0430\u043D\u0430\u043B\u0438\u0437\u0430 \u044D\u0444\u0444\u0435\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0438 \u0432\u0430\u0448\u0438\u0445 \u0440\u0435\u043A\u043B\u0430\u043C\u043D\u044B\u0445 \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0439 \u043D\u0430 Google Ads, Facebook \u0438 \u0434\u0440\u0443\u0433\u0438\u0445 \u043F\u043B\u0430\u0442\u0444\u043E\u0440\u043C\u0430\u0445, \u0430 \u0442\u0430\u043A\u0436\u0435 \u0434\u043B\u044F \u043A\u043E\u043D\u0442\u0440\u043E\u043B\u044F \u0437\u0430\u0442\u0440\u0430\u0442 \u043D\u0430 \u043F\u0440\u0438\u0432\u043B\u0435\u0447\u0435\u043D\u0438\u0435 \u043A\u043B\u0438\u0435\u043D\u0442\u043E\u0432."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});