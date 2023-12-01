﻿define("LeadQualificationResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		LeadQualificationCaption: "\u041A\u0432\u0430\u043B\u0438\u0444\u0438\u0446\u0438\u0440\u0443\u0435\u043C\u044B\u0439 \u043B\u0438\u0434",
		IdCaption: "Id",
		CreatedOnCaption: "\u0414\u0430\u0442\u0430 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u044F",
		CreatedByCaption: "\u0421\u043E\u0437\u0434\u0430\u043B",
		ModifiedOnCaption: "\u0414\u0430\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F",
		ModifiedByCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B",
		ProcessListenersCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		NameCaption: "\u041B\u0438\u0434",
		ContactBusinessPhoneCaption: "\u0420\u0430\u0431\u043E\u0447\u0438\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		ContactMobilePhoneCaption: "\u041C\u043E\u0431\u0438\u043B\u044C\u043D\u044B\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		ContactEmailCaption: "Email",
		AccountBusinessPhoneCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		AccountFaxCaption: "\u0424\u0430\u043A\u0441",
		AccountWebsiteCaption: "\u0418\u043D\u0442\u0435\u0440\u043D\u0435\u0442",
		ContactCaption: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442",
		AccountCaption: "\u041A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442",
		GenderCaption: "\u041F\u043E\u043B",
		FullJobTitleCaption: "\u041F\u043E\u043B\u043D\u043E\u0435 \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u0434\u043E\u043B\u0436\u043D\u043E\u0441\u0442\u0438",
		LeadContactNameCaption: "\u0424\u0418\u041E",
		JobCaption: "\u0414\u043E\u043B\u0436\u043D\u043E\u0441\u0442\u044C",
		DepartmentCaption: "\u0414\u0435\u043F\u0430\u0440\u0442\u0430\u043C\u0435\u043D\u0442",
		SalutationCaption: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0435",
		DearCaption: "\u041F\u0440\u0438\u0432\u0435\u0442\u0441\u0442\u0432\u0438\u0435",
		AnnualRevenueCaption: "\u0413\u043E\u0434\u043E\u0432\u043E\u0439 \u043E\u0431\u043E\u0440\u043E\u0442",
		EmployeesNumberCaption: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u043E\u0432",
		AccountCategoryCaption: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u044F",
		IndustryCaption: "\u041E\u0442\u0440\u0430\u0441\u043B\u044C",
		OwnershipCaption: "\u0424\u043E\u0440\u043C\u0430 \u0441\u043E\u0431\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u0441\u0442\u0438",
		LeadAccountNameCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		DecisionRoleCaption: "\u0420\u043E\u043B\u044C",
		LeadTypeCaption: "\u0422\u0438\u043F \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u0438",
		LeadTypeRipenessCaption: "\u0417\u0440\u0435\u043B\u043E\u0441\u0442\u044C \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u0438",
		LeadContactAddressTypeCaption: "\u0422\u0438\u043F \u0430\u0434\u0440\u0435\u0441\u0430",
		LeadContactCountryCaption: "\u0421\u0442\u0440\u0430\u043D\u0430",
		LeadContactRegionCaption: "\u041E\u0431\u043B\u0430\u0441\u0442\u044C/\u0448\u0442\u0430\u0442",
		LeadContactCityCaption: "\u0413\u043E\u0440\u043E\u0434",
		LeadContactZipCaption: "\u0418\u043D\u0434\u0435\u043A\u0441",
		LeadContactAddressCaption: "\u0410\u0434\u0440\u0435\u0441",
		LeadSourceCaption: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A",
		LeadAccountAddressTypeCaption: "\u0422\u0438\u043F \u0430\u0434\u0440\u0435\u0441\u0430",
		LeadAccountCountryCaption: "\u0421\u0442\u0440\u0430\u043D\u0430",
		LeadAccountRegionCaption: "\u041E\u0431\u043B\u0430\u0441\u0442\u044C/\u0448\u0442\u0430\u0442",
		LeadAccountCityCaption: "\u0413\u043E\u0440\u043E\u0434",
		LeadAccountZipCaption: "\u0418\u043D\u0434\u0435\u043A\u0441",
		LeadAccountAddressCaption: "\u0410\u0434\u0440\u0435\u0441"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});