﻿define("FormSubmitResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		FormSubmitCaption: "\u0417\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043D\u0430\u044F \u0432\u0435\u0431-\u0444\u043E\u0440\u043C\u0430",
		IdCaption: "Id",
		CreatedOnCaption: "\u0414\u0430\u0442\u0430 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u044F",
		CreatedByCaption: "\u0421\u043E\u0437\u0434\u0430\u043B",
		ModifiedOnCaption: "\u0414\u0430\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F",
		ModifiedByCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B",
		ProcessListenersCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		ContactCaption: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442",
		FormDataCaption: "\u0414\u0430\u043D\u043D\u044B\u0435",
		WebFormCaption: "\u0412\u0435\u0431 \u0444\u043E\u0440\u043C\u0430",
		PhoneNumberCaption: "\u041D\u043E\u043C\u0435\u0440 \u0442\u0435\u043B\u0435\u0444\u043E\u043D\u0430",
		EmailCaption: "Email",
		LastNameCaption: "\u0424\u0430\u043C\u0438\u043B\u0438\u044F",
		FirstNameCaption: "\u0418\u043C\u044F",
		FullNameCaption: "\u0424\u0418\u041E",
		CountryStrCaption: "\u0421\u0442\u0440\u0430\u043D\u0430 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		CountryCaption: "\u0421\u0442\u0440\u0430\u043D\u0430",
		AccountIndustryStrCaption: "\u041E\u0442\u0440\u0430\u0441\u043B\u044C (\u0441\u0442\u0440\u043E\u043A\u0430)",
		AccountIndustryCaption: "\u041E\u0442\u0440\u0430\u0441\u043B\u044C",
		JobTitleCaption: "\u0414\u043E\u043B\u0436\u043D\u043E\u0441\u0442\u044C",
		ContactDecisionRoleStrCaption: "\u0420\u043E\u043B\u044C (\u0441\u0442\u0440\u043E\u043A\u0430)",
		ContactDecisionRoleCaption: "\u0420\u043E\u043B\u044C",
		WorkEmailCaption: "\u0420\u0430\u0431\u043E\u0447\u0438\u0439 email",
		AccountEmployeesNumberStrCaption: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u043E\u0432 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		AccountEmployeesNumberCaption: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u043E\u0432",
		AccountCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0430",
		WebsiteCaption: "Website",
		GenderCaption: "\u041F\u043E\u043B",
		TimeZoneCaption: "\u0427\u0430\u0441\u043E\u0432\u043E\u0439 \u043F\u043E\u044F\u0441",
		TerritoryCaption: "\u0422\u0435\u0440\u0440\u0438\u0442\u043E\u0440\u0438\u044F",
		CityStrCaption: "\u0413\u043E\u0440\u043E\u0434 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		CityCaption: "\u0413\u043E\u0440\u043E\u0434",
		BirthDateCaption: "\u0414\u0430\u0442\u0430 \u0440\u043E\u0436\u0434\u0435\u043D\u0438\u044F",
		PasswordCaption: "\u041F\u0430\u0440\u043E\u043B\u044C",
		LinkedInProfileUrlCaption: "LinkedIn \u043F\u0440\u043E\u0444\u0438\u043B\u044C",
		RegisterMethodCaption: "\u0421\u043F\u043E\u0441\u043E\u0431 \u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u0438",
		NotesCaption: "\u0417\u0430\u043C\u0435\u0442\u043A\u0438",
		SourceCaption: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A",
		ChannelCaption: "\u041A\u0430\u043D\u0430\u043B",
		UtmCampaignStrCaption: "utm_campaign",
		UtmMediumStrCaption: "utm_medium",
		UtmSourceStrCaption: "utm_source",
		ReferrerCaption: "\u0421\u0430\u0439\u0442 \u043F\u0435\u0440\u0435\u0445\u043E\u0434\u0430",
		WebFormDataCaption: "\u0414\u0430\u043D\u043D\u044B\u0435 \u0438\u0437 \u0432\u0435\u0431-\u0444\u043E\u0440\u043C\u044B",
		LandingPageURLCaption: "URL \u043B\u0435\u043D\u0434\u0438\u043D\u0433\u043E\u0432\u043E\u0439 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		UtmTermStrCaption: "utm_term",
		UtmContentStrCaption: "utm_content",
		CustomerNeedCaption: "\u0422\u0438\u043F \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u0438",
		BulkEmailCaption: "\u0420\u0430\u0441\u0441\u044B\u043B\u043A\u0430",
		CampaignCaption: "\u041A\u0430\u043C\u043F\u0430\u043D\u0438\u044F",
		AdCampaignCaption: "\u0420\u0435\u043A\u043B\u0430\u043C\u043D\u0430\u044F \u043A\u0430\u043C\u043F\u0430\u043D\u0438\u044F",
		EventCaption: "\u041C\u0435\u0440\u043E\u043F\u0440\u0438\u044F\u0442\u0438\u0435"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});