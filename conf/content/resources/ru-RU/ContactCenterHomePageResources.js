define("ContactCenterHomePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		crtChartWidget9726d63a71a03c6cddd866837466bf2b_series_3: "\u041F\u0438\u0441\u044C\u043C\u0430",
		crtChartWidget9726d63a71a03c6cddd866837466bf2b_series_2: "\u0417\u0432\u043E\u043D\u043A\u0438",
		crtChartWidget9726d63a71a03c6cddd866837466bf2b_series_1: "\u0427\u0430\u0442\u044B",
		crtChartWidget9726d63a71a03c6cddd866837466bf2b_series_0: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F",
		crtChartWidget9726d63a71a03c6cddd866837466bf2b_title: "\u041C\u043E\u0438 \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0438",
		crtChartWidgetdad38bed0482bae2242bd17b35779e45_series_0: "Case",
		crtChartWidgetdad38bed0482bae2242bd17b35779e45_title: "\u041F\u0440\u0438\u043E\u0440\u0438\u0442\u0435\u0442\u044B \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439 \u0432 \u0440\u0430\u0431\u043E\u0442\u0435",
		crtChartWidgeta481328fc81142273189008e01653ebf_series_0: "Case",
		crtChartWidgeta481328fc81142273189008e01653ebf_title: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u044F \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439 \u0432 \u0440\u0430\u0431\u043E\u0442\u0435",
		crtIndicatorWidgetfd86095737d5108a5f2bd617a5927f0e_template: "{0}",
		crtIndicatorWidgetfd86095737d5108a5f2bd617a5927f0e_title: "\u0421\u0440\u0435\u0434\u043D\u0435\u0435 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u043F\u0438\u0441\u0435\u043C",
		crtIndicatorWidgete54311953d1c11e362529e284250181f_template: "{0}",
		crtIndicatorWidgete54311953d1c11e362529e284250181f_title: "\u0421\u0440\u0435\u0434\u043D\u044F\u044F \u043F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0441\u0442\u044C \u0437\u0432\u043E\u043D\u043A\u043E\u0432, \u043C\u0438\u043D\u0443\u0442",
		crtIndicatorWidget7d69b944e3725f03bebe564967e73fde_template: "{0}",
		crtIndicatorWidget7d69b944e3725f03bebe564967e73fde_title: "\u0421\u0440\u0435\u0434\u043D\u044F\u044F \u043E\u0446\u0435\u043D\u043A\u0430 \u043F\u043E \u043C\u043E\u0438\u043C \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F\u043C",
		crtIndicatorWidgetef54470f777dcae1081684e6aaa2c389_template: "{0}",
		crtIndicatorWidgetef54470f777dcae1081684e6aaa2c389_title: "\u041E\u0436\u0438\u0434\u0430\u044E\u0442 \u043E\u0442\u0432\u0435\u0442\u0430 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F",
		crtIndicatorWidgetd49c93e93a93a77185ef130cf5a692c1_template: "{0}",
		crtIndicatorWidgetd49c93e93a93a77185ef130cf5a692c1_title: "\u0420\u0435\u0448\u0435\u043D\u043D\u044B\u0435 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F",
		crtIndicatorWidget3967fb6c1eae87dea92a309c74d4194d_template: "{0}",
		crtIndicatorWidget3967fb6c1eae87dea92a309c74d4194d_title: "\u041C\u043E\u0438 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F \u0432 \u0440\u0430\u0431\u043E\u0442\u0435",
		crtChartWidget196acc26ccef8b4a83cbf85032871740_series_0: "Case",
		crtChartWidget196acc26ccef8b4a83cbf85032871740_title: "\u0423\u0440\u043E\u0432\u0435\u043D\u044C \u0443\u0434\u043E\u0432\u043B\u0435\u0442\u0432\u043E\u0440\u0435\u043D\u043D\u043E\u0441\u0442\u0438 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F\u043C\u0438 \u043F\u043E \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u043C",
		crtChartWidget2709e25260fee39e4e4d6a1cecdd7e34_series_0: "Case",
		crtChartWidget2709e25260fee39e4e4d6a1cecdd7e34_title: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u044F \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});