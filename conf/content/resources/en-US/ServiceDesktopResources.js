define("ServiceDesktopResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PlannedVsActualResolvedCasesChartWidget_series_1: "Actually resolved",
		PlannedVsActualResolvedCasesChartWidget_yAxis: "Cases",
		PlannedVsActualResolvedCasesChartWidget_xAxis: "Date",
		PlannedVsActualResolvedCasesChartWidget_series_0: "Planned to resolve",
		PlannedVsActualResolvedCasesChartWidget_title: "Planned vs Actual resolved cases",
		CustomerSatisfactionIndicatorWidget_template: "{0}",
		CustomerSatisfactionIndicatorWidget_title: "Customer satisfaction",
		FirstContactResolutionIndicatorWidget_template: "{0}",
		FirstContactResolutionIndicatorWidget_title: "First contact resolution",
		AverageResolutionTimeIndicatorWidget_template: "{0}",
		AverageResolutionTimeIndicatorWidget_title: "Average resolution time, hours",
		GreetingLabel_caption: "Hello, [#Current user.Recipient Name#]!"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});