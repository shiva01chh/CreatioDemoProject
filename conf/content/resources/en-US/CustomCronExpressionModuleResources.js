define("CustomCronExpressionModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		DefaultCronDescription: "Every day",
		InvalidCronPartsException: "Cron expression should starts with 0 * * characters",
		CronExpressionInfoButtonHint: "Please use \u0027Execution time\u0027 settings to set hours and minutes of Timer execution.",
		CronExpressionInfoTextPattern: "{0} \u003Ca href=\u0022https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontriggers.html#cron-expressions\u0022 target=\u0022_blank\u0022\u003E{1}\u003C/a\u003E {2}.",
		CronExpressionInfoButtonCaption: "about cron expressions",
		CronExpressionInfoButtonPattern: "{0} \u003Ca href=\u0022https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontriggers.html#cron-expressions\u0022 target=\u0022_blank\u0022\u003E{1}\u003C/a\u003E {2}.",
		CustomCronExpressionLabel: "Cron expression",
		ReadMoreCaption: "Read more"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});