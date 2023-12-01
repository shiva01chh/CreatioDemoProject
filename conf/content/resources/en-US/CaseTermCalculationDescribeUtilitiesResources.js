define("CaseTermCalculationDescribeUtilitiesResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		TermsAcademyUrlTemplate: "https://academy.creatio.com/documents/service-enterprise/{0}/calculating-response-and-resolution-deadlines-using-strategies?document=service%20enterprise",
		DefaultProductVersion: "7-15",
		ui_ReactionTime: "Response time",
		ui_SolutionTime: "Resolution time",
		ui_CaseParameters: "Case parameters",
		ui_DeadlineCalculationSchema: "Deadline calculation strategy",
		ui_TermsCalculation: "Calculation of deadline",
		ui_WorkingDay: "Working days",
		ui_WorkingHour: "Working hours",
		ui_Hour: "Calendar hours",
		ui_WorkingMinute: "Working minutes",
		ui_Minute: "Calendar minutes",
		ui_CalculatedResponseTime: "Calculated response time",
		ui_CalculatedResolutionTime: "Calculated resolution time",
		CloseButtonCaption: "Close",
		ui_Total: "Total",
		ui_Date: "Date",
		ui_DayOfWeek: "Day of week",
		ui_DayType: "Day type",
		ui_CaseProcessingTime: "Case processing time",
		ui_Calendar: "Calendar",
		ui_AlternateRule: "Alternate rule",
		ui_RegistrationDate: "Registration date",
		ui_WorkingDayCaption: "Working day",
		ui_DayOffCaption: "Day off",
		ui_AtTheDateOfCalculation: "As of calculation date",
		ui_Spent: "Time used",
		ui_RemainingTime: "Time left",
		ui_NotSpecified: "Is not specified, can\u0027t calculate term",
		ui_DayShort: "D",
		ui_HourShort: "H",
		ui_MinuteShort: "M",
		ui_Day: "Calendar day",
		TermCalculationErrorMessage: "Failed to get term calculation data. Please try again later",
		ui_CalendarTimeZoneTooltip: "The time zone specified in the Support Calendar is used to display the dates",
		ui_Timezone: "Timezone"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TermCalculationErrorImage: {
			source: 3,
			params: {
				schemaName: "CaseTermCalculationDescribeUtilities",
				resourceItemName: "TermCalculationErrorImage",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});