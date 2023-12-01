define("ServiceEnterpriseHomePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		crtChartWidget6156c3ce685eb8c0675d5630c24321cf_series_0: "Case",
		crtChartWidget6156c3ce685eb8c0675d5630c24321cf_title: "\u0423\u0440\u043E\u0432\u0435\u043D\u044C \u0443\u0434\u043E\u0432\u043B\u0435\u0442\u0432\u043E\u0440\u0435\u043D\u043D\u043E\u0441\u0442\u0438 \u0440\u0435\u0448\u0435\u043D\u0438\u0435\u043C \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439",
		crtIndicatorWidget2efb8e0318eaf237831c550975cb8891_template: "{0}",
		crtIndicatorWidget2efb8e0318eaf237831c550975cb8891_title: "\u0421\u0440\u0435\u0434\u043D\u044F\u044F \u043E\u0446\u0435\u043D\u043A\u0430",
		crtIndicatorWidget5df3bc04a346ac31605597dd4db2cd25_template: "{0}",
		crtIndicatorWidget5df3bc04a346ac31605597dd4db2cd25_title: "\u041E\u0446\u0435\u043D\u0435\u043D\u043E \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439",
		crtIndicatorWidget1f84359932987d396c1866b2aa38ba03_template: "{0}",
		crtIndicatorWidget1f84359932987d396c1866b2aa38ba03_title: "\u0421\u0440\u0435\u0434\u043D\u044F\u044F \u043F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0441\u0442\u044C \u0440\u0435\u0448\u0435\u043D\u0438\u044F, \u0447\u0430\u0441\u043E\u0432",
		crtIndicatorWidgetd4b6d82386c78947005c7d016680f4bf_template: "{0}",
		crtIndicatorWidgetd4b6d82386c78947005c7d016680f4bf_title: "\u0420\u0435\u0448\u0435\u043D\u043E \u0441 \u043F\u0435\u0440\u0432\u043E\u0433\u043E \u0440\u0430\u0437\u0430",
		crtChartWidgetb18ce75bd995502dffa0305011afe479_series_0: "Case",
		crtChartWidgetb18ce75bd995502dffa0305011afe479_title: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u0438 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439",
		crtChartWidget28ef0973a8a14b3aca71633a2f2e3f5d_series_1: "\u0424\u0430\u043A\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0440\u0435\u0448\u0435\u043D\u043E",
		crtChartWidget28ef0973a8a14b3aca71633a2f2e3f5d_yAxis: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0435",
		crtChartWidget28ef0973a8a14b3aca71633a2f2e3f5d_xAxis: "\u0414\u0435\u043D\u044C",
		crtChartWidget28ef0973a8a14b3aca71633a2f2e3f5d_series_0: "\u0417\u0430\u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u043E \u0440\u0435\u0448\u0438\u0442\u044C",
		crtChartWidget28ef0973a8a14b3aca71633a2f2e3f5d_title: "\u041F\u043B\u0430\u043D-\u0444\u0430\u043A\u0442 \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u044F \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439",
		crtIndicatorWidgetb5a7d31cf2bb938967912a810961a274_template: "{0}",
		crtIndicatorWidgetb5a7d31cf2bb938967912a810961a274_title: "\u041F\u0440\u043E\u0441\u0440\u043E\u0447\u0435\u043D\u043E \u043F\u043E \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u044E",
		crtIndicatorWidgetd0098b075e752979d980efb26a3309ed_template: "{0}",
		crtIndicatorWidgetd0098b075e752979d980efb26a3309ed_title: "\u041F\u0440\u043E\u0441\u0440\u043E\u0447\u0435\u043D\u043E \u043F\u043E \u0440\u0435\u0430\u043A\u0446\u0438\u0438",
		crtChartWidget71615f3b5806d655c1d528aa86aa759a_series_0: "Case",
		crtChartWidget71615f3b5806d655c1d528aa86aa759a_title: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F \u043F\u043E \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u043C",
		crtChartWidget2dd3123ba3d4bd6cace277ef578ffb23_series_0: "Case",
		crtChartWidget2dd3123ba3d4bd6cace277ef578ffb23_title: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F \u043F\u043E \u0441\u0435\u0440\u0432\u0438\u0441\u0430\u043C",
		crtChartWidget8fccb539466ff5cef60775000471bad3_series_0: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F",
		crtChartWidget8fccb539466ff5cef60775000471bad3_title: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0438 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});