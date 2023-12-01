﻿define("AccountResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AccountCaption: "\u041A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442",
		IdCaption: "Id",
		NameCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		OwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439",
		CreatedOnCaption: "\u0414\u0430\u0442\u0430 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u044F",
		CreatedByCaption: "\u0421\u043E\u0437\u0434\u0430\u043B",
		ModifiedOnCaption: "\u0414\u0430\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F",
		ModifiedByCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B",
		ProcessListenersCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		OwnershipCaption: "\u0424\u043E\u0440\u043C\u0430 \u0441\u043E\u0431\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u0441\u0442\u0438",
		PrimaryContactCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u043A\u043E\u043D\u0442\u0430\u043A\u0442",
		ParentCaption: "\u0420\u043E\u0434\u0438\u0442\u0435\u043B\u044C\u0441\u043A\u0438\u0439 \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442",
		IndustryCaption: "\u041E\u0442\u0440\u0430\u0441\u043B\u044C",
		CodeCaption: "\u041A\u043E\u0434",
		TypeCaption: "\u0422\u0438\u043F",
		PhoneCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		AdditionalPhoneCaption: "\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		FaxCaption: "\u0424\u0430\u043A\u0441",
		WebCaption: "\u0421\u0430\u0439\u0442",
		AddressTypeCaption: "\u0422\u0438\u043F \u0430\u0434\u0440\u0435\u0441\u0430",
		AddressCaption: "\u0410\u0434\u0440\u0435\u0441",
		CityCaption: "\u0413\u043E\u0440\u043E\u0434",
		RegionCaption: "\u041E\u0431\u043B\u0430\u0441\u0442\u044C/\u0448\u0442\u0430\u0442",
		ZipCaption: "\u0418\u043D\u0434\u0435\u043A\u0441",
		CountryCaption: "\u0421\u0442\u0440\u0430\u043D\u0430",
		AccountCategoryCaption: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u044F",
		EmployeesNumberCaption: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u043E\u0432",
		AnnualRevenueCaption: "\u0413\u043E\u0434\u043E\u0432\u043E\u0439 \u043E\u0431\u043E\u0440\u043E\u0442",
		NotesCaption: "\u0417\u0430\u043C\u0435\u0442\u043A\u0438",
		LogoCaption: "\u041B\u043E\u0433\u043E\u0442\u0438\u043F \u043A\u043E\u043C\u043F\u0430\u043D\u0438\u0438",
		AlternativeNameCaption: "\u0410\u043B\u044C\u0442\u0435\u0440\u043D\u0430\u0442\u0438\u0432\u043D\u044B\u0435 \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u044F",
		GPSNCaption: "GPS N",
		GPSECaption: "GPS E",
		CompletenessCaption: "\u041F\u043E\u043B\u043D\u043E\u0442\u0430 \u043D\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F \u0434\u0430\u043D\u043D\u044B\u043C\u0438",
		AccountLogoCaption: "\u041B\u043E\u0433\u043E\u0442\u0438\u043F \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0430",
		AUMCaption: "AUM",
		LeadConversionScoreCaption: "\u0420\u0435\u0439\u0442\u0438\u043D\u0433 \u043F\u0435\u0440\u0435\u0432\u043E\u0434\u0430 \u0432 \u041B\u0438\u0434",
		PriceListCaption: "\u041F\u0440\u0430\u0439\u0441-\u043B\u0438\u0441\u0442"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});