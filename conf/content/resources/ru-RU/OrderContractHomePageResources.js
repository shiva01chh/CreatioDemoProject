﻿define("OrderContractHomePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ContractsCreatedChartWidget_series_0: "\u0414\u043E\u0433\u043E\u0432\u043E\u0440",
		ContractsCreatedChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u043E\u0432 \u043F\u043E \u043C\u0435\u0441\u044F\u0446\u0430\u043C",
		InvoicesCreatedChartWidget_series_0: "\u0421\u0447\u0435\u0442",
		InvoicesCreatedChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0441\u0447\u0435\u0442\u043E\u0432 \u043F\u043E \u043C\u0435\u0441\u044F\u0446\u0430\u043C",
		OrdersCreatedChartWidget_series_0: "\u0417\u0430\u043A\u0430\u0437",
		OrdersCreatedChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0437\u0430\u043A\u0430\u0437\u043E\u0432 \u043F\u043E \u043C\u0435\u0441\u044F\u0446\u0430\u043C",
		ChartWidget_wi4z1ws_series_0: "Contract",
		ChartWidget_wi4z1ws_title: "Contracts by status",
		ChartWidget_qgvayvj_series_0: "Contract",
		ChartWidget_qgvayvj_title: "Contracts created (monthly)",
		ChartWidget_anaj6zg_series_0: "Invoice",
		ChartWidget_anaj6zg_title: "invoices by status",
		ChartWidget_merhd6a_series_0: "Invoice",
		ChartWidget_merhd6a_title: "Invoices created (monthly)",
		OrdersByStatusChartWidget_series_0: "\u0417\u0430\u043A\u0430\u0437",
		OrdersByStatusChartWidget_title: "\u0420\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u0435 \u0437\u0430\u043A\u0430\u0437\u043E\u0432 \u043F\u043E \u0441\u0442\u0430\u0442\u0443\u0441\u0430\u043C",
		ChartWidget_eyfwrk2_series_0: "Order",
		ChartWidget_eyfwrk2_title: "Orders created (monthly)",
		ChartWidget_djbhe0q_series_0: "Order",
		ChartWidget_djbhe0q_title: "Orders by status",
		AmountOpenOrdersIndicatorWidget_template: "{0}",
		AmountOpenOrdersIndicatorWidget_title: "$ \u041E\u0442\u043A\u0440\u044B\u0442\u044B\u0435 \u0437\u0430\u043A\u0430\u0437\u044B - \u0442\u0435\u043A\u0443\u0449\u0438\u0439 \u043C\u0435\u0441\u044F\u0446",
		IndicatorWidget_x6r2o4n_template: "{0}",
		IndicatorWidget_x6r2o4n_title: "Average order margin",
		IndicatorWidget_1cqufv2_template: "{0}",
		IndicatorWidget_1cqufv2_title: "# Open orders - CM",
		IndicatorWidget_2k21igd_template: "{0}",
		IndicatorWidget_2k21igd_title: "$ Open orders - CM",
		IndicatorWidget_f7l1d5n_template: "{0}",
		IndicatorWidget_f7l1d5n_title: "# Unpaid invoices - CM",
		OrdersByChannelsChartWidget_series_0: "Order",
		OrdersByChannelsChartWidget_title: "Orders by channel",
		OrderByChannelsChartWidget_series_0: "Order",
		OrderByChannelsChartWidget_title: "Orders by channels",
		IndicatorWidget_osjb0uh_template: "{0}",
		IndicatorWidget_osjb0uh_title: "Total order amount",
		ChartWidget_2ci9ftl_series_0: "Order",
		ChartWidget_2ci9ftl_title: "Order dynamics by number",
		ChartWidget_060bryj_series_0: "Order",
		ChartWidget_060bryj_title: "Order dynamics by amount",
		OrdersCreatedVSOrdersClosedChartWidget_series_2: "\u0417\u0430\u043A\u0440\u044B\u0442\u043E",
		OrdersCreatedVSOrdersClosedChartWidget_series_1: "\u0412 \u0440\u0430\u0431\u043E\u0442\u0435",
		OrdersCreatedVSOrdersClosedChartWidget_series_0: "\u0421\u043E\u0437\u0434\u0430\u043D\u043E",
		OrdersCreatedVSOrdersClosedChartWidget_title: "$ \u0421\u043E\u0437\u0434\u0430\u043D\u043D\u044B\u0435 \u0438 \u0437\u0430\u043A\u0440\u044B\u0442\u044B\u0435 \u0437\u0430\u043A\u0430\u0437\u044B",
		TotalOrderAmountIndicatorWidget_template: "{0}",
		TotalOrderAmountIndicatorWidget_title: "\u041E\u0431\u0449\u0430\u044F \u0441\u0443\u043C\u043C\u0430 \u0437\u0430\u043A\u0430\u0437\u043E\u0432",
		AnnualAttainmentIndicatorWidget_template: "{0}",
		AnnualAttainmentIndicatorWidget_title: "\u0414\u043E\u0441\u0442\u0438\u0436\u0435\u043D\u0438\u044F \u0437\u0430 \u0433\u043E\u0434",
		TotalOrderCountIndicatorWidget_template: "{0}",
		TotalOrderCountIndicatorWidget_title: "\u041E\u0431\u0449\u0435\u0435 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0437\u0430\u043A\u0430\u0437\u043E\u0432",
		QuarterlyAttainmentIndicatorWidget_template: "{0}",
		QuarterlyAttainmentIndicatorWidget_title: "\u0414\u043E\u0441\u0442\u0438\u0436\u0435\u043D\u0438\u044F \u0437\u0430 \u043A\u0432\u0430\u0440\u0442\u0430\u043B",
		ContractsByStatusChartWidget_series_0: "\u0414\u043E\u0433\u043E\u0432\u043E\u0440",
		ContractsByStatusChartWidget_title: "\u0420\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u0435 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u043E\u0432 \u043F\u043E \u0441\u0442\u0430\u0442\u0443\u0441\u0430\u043C",
		InvoicesByStatusChartWidget_series_0: "\u0421\u0447\u0435\u0442",
		InvoicesByStatusChartWidget_title: "\u0420\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u0435 \u0441\u0447\u0435\u0442\u043E\u0432 \u043F\u043E \u0441\u0442\u0430\u0442\u0443\u0441\u0430\u043C",
		UnpaidSnvoicesIndicatorWidget_template: "{0}",
		UnpaidSnvoicesIndicatorWidget_title: "# \u041D\u0435\u043E\u043F\u043B\u0430\u0447\u0435\u043D\u043D\u044B\u0435 \u0441\u0447\u0435\u0442\u0430 - \u0442\u0435\u043A\u0443\u0449\u0438\u0439 \u043C\u0435\u0441\u044F\u0446",
		OrdersMarginIndicatorWidgeto4n_template: "{0}",
		OrdersMarginIndicatorWidgeto4n_title: "\u0421\u0440\u0435\u0434\u043D\u044F\u044F \u043C\u0430\u0440\u0436\u0430 \u043F\u043E \u0437\u0430\u043A\u0430\u0437\u0430\u043C",
		NumberOpenOrdersIndicatorWidget_template: "{0}",
		NumberOpenOrdersIndicatorWidget_title: "# \u041E\u0442\u043A\u0440\u044B\u0442\u044B\u0435 \u0437\u0430\u043A\u0430\u0437\u044B - \u0442\u0435\u043A\u0443\u0449\u0438\u0439 \u043C\u0435\u0441\u044F\u0446",
		OrdersByChannelChartWidget_series_0: "\u0417\u0430\u043A\u0430\u0437",
		OrdersByChannelChartWidget_title: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0438 \u0437\u0430\u043A\u0430\u0437\u043E\u0432",
		OrderDynamicsByNumberChartWidget_series_0: "\u0417\u0430\u043A\u0430\u0437",
		OrderDynamicsByNumberChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0437\u0430\u043A\u0430\u0437\u043E\u0432 \u043F\u043E \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u0443",
		OrderDynamicsByAmountChartWidget_series_0: "\u0417\u0430\u043A\u0430\u0437",
		OrderDynamicsByAmountChartWidget_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0437\u0430\u043A\u0430\u0437\u043E\u0432 \u043F\u043E \u0441\u0443\u043C\u043C\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});