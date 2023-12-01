﻿define("MarketingHomePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		crtChartWidgetb80d9519368114c216e0377b63db285c_series_0: "Lead",
		crtChartWidgetb80d9519368114c216e0377b63db285c_title: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0438 \u043B\u0438\u0434\u043E\u0432 (\u0437\u0430 \u0432\u0441\u0435 \u0432\u0440\u0435\u043C\u044F)",
		crtIndicatorWidget797789e552e77d0c9ba0363314051e37_template: "{0}",
		crtIndicatorWidget797789e552e77d0c9ba0363314051e37_title: "\u041A\u043B\u0438\u043A\u043E\u0432 (\u0432\u0441\u0435\u0433\u043E), %",
		crtIndicatorWidget7a6f5c2844364fd706e6456a0fbbfb8a_template: "{0}",
		crtIndicatorWidget7a6f5c2844364fd706e6456a0fbbfb8a_title: "\u041E\u0442\u043A\u0440\u044B\u0442\u0438\u0439 (\u0432\u0441\u0435\u0433\u043E), %",
		crtIndicatorWidget906aac6d9c703bdba5ff9f5501b3938f_template: "{0}",
		crtIndicatorWidget906aac6d9c703bdba5ff9f5501b3938f_title: "\u0414\u043E\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u043E \u043F\u0438\u0441\u0435\u043C (\u0432\u0441\u0435\u0433\u043E)",
		crtIndicatorWidget2418d31ea32224483ec9e8684921d6ea_template: "{0}",
		crtIndicatorWidget2418d31ea32224483ec9e8684921d6ea_title: "\u041E\u0442\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u043E \u043F\u0438\u0441\u0435\u043C (\u0432\u0441\u0435\u0433\u043E)",
		crtChartWidgetb2ba2e9520220457e9e21dd267a27ef6_series_0: "Campaign participant",
		crtChartWidgetb2ba2e9520220457e9e21dd267a27ef6_title: "\u0410\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0439",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_5: "\u0414\u0440\u0443\u0433\u0438\u0435 \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0438",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_4: "LinkedIn",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_3: "Mailchimp",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_2: "Google",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_1: "Facebook",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_series_0: "Creatio marketing",
		crtChartWidgetdd155a1563595aa6895acb50cc5af4d2_title: "\u0414\u0438\u043D\u0430\u043C\u0438\u043A\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439 \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u043E\u0432 \u043B\u0438\u0434\u043E\u0432",
		crtChartWidget032679006c82fcfbb531ff6e5ec24fec_series_1: "\u041D\u043E\u0432\u044B\u0435 \u043B\u0438\u0434\u044B",
		crtChartWidget032679006c82fcfbb531ff6e5ec24fec_series_0: "\u0410\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0439",
		crtChartWidget032679006c82fcfbb531ff6e5ec24fec_title: "\u0410\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u0439 \u0026 \u041D\u043E\u0432\u044B\u0435 \u043B\u0438\u0434\u044B ",
		crtChartWidget1ca09c1a19366f751fd90815a0ca4567_series_0: "PRM portal marketing activity",
		crtChartWidget1ca09c1a19366f751fd90815a0ca4567_title: "\u0420\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u0435 \u0431\u044E\u0434\u0436\u0435\u0442\u0430 \u043F\u043E \u043A\u0430\u043D\u0430\u043B\u0430\u043C",
		crtIndicatorWidgetf31e2dc73d33b8f64bd6d71625236ac1_template: "${0}",
		crtIndicatorWidgetf31e2dc73d33b8f64bd6d71625236ac1_title: "\u0420\u0435\u0430\u043B\u0438\u0437\u043E\u0432\u0430\u043D\u043E \u0438\u0437 \u0431\u044E\u0434\u0436\u0435\u0442\u0430",
		crtIndicatorWidget76003462724c35d31805b63c6bd265f2_template: "$ {0}",
		crtIndicatorWidget76003462724c35d31805b63c6bd265f2_title: "\u041C\u0430\u0440\u043A\u0435\u0442\u0438\u043D\u0433\u043E\u0432\u044B\u0439 \u0431\u044E\u0434\u0436\u0435\u0442",
		crtChartWidget399cc3213bad7c1ea175bbce18f80361_series_1: "\u041B\u0438\u0434\u044B \u043F\u0435\u0440\u0435\u0432\u0435\u0434\u0435\u043D\u043D\u044B\u0435 \u0432 \u043F\u0440\u043E\u0434\u0430\u0436\u0443",
		crtChartWidget399cc3213bad7c1ea175bbce18f80361_series_0: "\u0414\u0438\u0441\u043A\u0432\u0430\u043B\u0438\u0444\u0438\u0446\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u044B\u0435 \u043B\u0438\u0434\u044B",
		crtChartWidget399cc3213bad7c1ea175bbce18f80361_title: "\u0414\u0438\u0441\u043A\u0432\u0430\u043B\u0438\u0444\u0438\u0446\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u044B\u0435 \u043B\u0438\u0434\u044B \u0026 \u041B\u0438\u0434\u044B \u043F\u0435\u0440\u0435\u0432\u0435\u0434\u0435\u043D\u043D\u044B\u0435 \u0432 \u043F\u0440\u043E\u0434\u0430\u0436\u0443",
		crtChartWidgeteea66beca592feebe59ef4793e17621e_series_0: "Opportunity",
		crtChartWidgeteea66beca592feebe59ef4793e17621e_title: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A\u0438 \u043F\u0440\u043E\u0434\u0430\u0436 (\u0437\u0430 \u0432\u0441\u0435 \u0432\u0440\u0435\u043C\u044F)",
		crtChartWidgetc7095e73e779dd43a7a8add2fcf15c5c_series_0: "Lead",
		crtChartWidgetc7095e73e779dd43a7a8add2fcf15c5c_title: "\u0414\u0435\u043B\u0435\u043D\u0438\u0435 \u043B\u0438\u0434\u043E\u0432 \u043F\u043E \u0438\u043D\u0434\u0443\u0441\u0442\u0440\u0438\u044F\u043C (\u0437\u0430 \u0432\u0441\u0435 \u0432\u0440\u0435\u043C\u044F)",
		crtChartWidget964db88ecf832d2d0f3a02eb2f8856f4_series_0: "Lead",
		crtChartWidget964db88ecf832d2d0f3a02eb2f8856f4_title: "\u0414\u0435\u043B\u0435\u043D\u0438\u0435 \u043B\u0438\u0434\u043E\u0432 \u043F\u043E \u0440\u0435\u0433\u0438\u043E\u043D\u0430\u043C (\u0437\u0430 \u0432\u0441\u0435 \u0432\u0440\u0435\u043C\u044F)",
		TabContainer_cfcjc87_caption: "Bounce \u043C\u043E\u043D\u0438\u0442\u043E\u0440\u0438\u043D\u0433",
		TabContainer_73ey3m7_caption: "\u041E\u0431\u0437\u043E\u0440",
		ChartWidget_ok4jsu5_series_7: "Will Retry",
		ChartWidget_ok4jsu5_series_6: "Unknown Recipient",
		ChartWidget_ok4jsu5_series_5: "Spam Reject",
		ChartWidget_ok4jsu5_series_4: "Recipient Blocked",
		ChartWidget_ok4jsu5_series_3: "Other",
		ChartWidget_ok4jsu5_series_2: "Mailbox Problem",
		ChartWidget_ok4jsu5_series_1: "IP Reputation Issue",
		ChartWidget_ok4jsu5_yAxis: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E",
		ChartWidget_ok4jsu5_xAxis: "\u0414\u0430\u0442\u0430",
		ChartWidget_ok4jsu5_series_0: "Domain Not Found",
		ChartWidget_ok4jsu5_title: "\u041D\u0435\u0434\u043E\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u043D\u044B\u0435 \u043F\u0438\u0441\u044C\u043C\u0430 (\u043F\u043E\u0441\u043B. 365 \u0434\u043D\u0435\u0439)",
		ChartWidget_e0gq934_series_0: "\u0414\u0435\u0442\u0430\u043B\u0438 \u043E\u0442\u043A\u043B\u0438\u043A\u0430",
		ChartWidget_e0gq934_title: "\u041E\u0448\u0438\u0431\u043A\u0438 (\u043F\u043E\u0441\u043B. 7 \u0434\u043D\u0435\u0439)",
		ChartWidget_b4x5fmx_series_0: "Bulk email response details",
		ChartWidget_b4x5fmx_title: "Bounces (\u043F\u043E\u0441\u043B. 7 \u0434\u043D\u0435\u0439)",
		IndicatorWidget_mamvlal_template: "{0}",
		IndicatorWidget_mamvlal_title: "\u041E\u0448\u0438\u0431\u043E\u043A \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0438",
		IndicatorWidget_fin6r1c_template: "{0}",
		IndicatorWidget_fin6r1c_title: "Soft Bounce",
		IndicatorWidget_7gljzkf_template: "{0}",
		IndicatorWidget_7gljzkf_title: "Hard Bounce"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});