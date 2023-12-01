﻿define("SimilarLeadResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SimilarLeadCaption: "\u041F\u043E\u0445\u043E\u0436\u0430\u044F \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u044C",
		IdCaption: "Id",
		CreatedOnCaption: "\u0414\u0430\u0442\u0430 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u044F",
		CreatedByCaption: "\u0421\u043E\u0437\u0434\u0430\u043B",
		ModifiedOnCaption: "\u0414\u0430\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F",
		ModifiedByCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B",
		NotesCaption: "\u0417\u0430\u043C\u0435\u0442\u043A\u0438",
		AccountCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0430",
		ContactCaption: "\u0424\u0418\u041E \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		TitleCaption: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0435",
		FullJobTitleCaption: "\u041F\u043E\u043B\u043D\u043E\u0435 \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u0434\u043E\u043B\u0436\u043D\u043E\u0441\u0442\u0438",
		StatusCaption: "\u0421\u0442\u0430\u0442\u0443\u0441",
		InformationSourceCaption: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u0438",
		IndustryCaption: "\u041E\u0442\u0440\u0430\u0441\u043B\u044C",
		AnnualRevenueCaption: "\u0413\u043E\u0434\u043E\u0432\u043E\u0439 \u043E\u0431\u043E\u0440\u043E\u0442",
		EmployeesNumberCaption: "\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u043E\u0432",
		BusinesPhoneCaption: "\u0420\u0430\u0431\u043E\u0447\u0438\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		MobilePhoneCaption: "\u041C\u043E\u0431\u0438\u043B\u044C\u043D\u044B\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		EmailCaption: "Email",
		FaxCaption: "\u0424\u0430\u043A\u0441",
		WebsiteCaption: "Web",
		AddressTypeCaption: "\u0422\u0438\u043F \u0430\u0434\u0440\u0435\u0441\u0430",
		CountryCaption: "\u0421\u0442\u0440\u0430\u043D\u0430",
		RegionCaption: "\u041E\u0431\u043B\u0430\u0441\u0442\u044C/\u0448\u0442\u0430\u0442",
		CityCaption: "\u0413\u043E\u0440\u043E\u0434",
		ZipCaption: "\u0418\u043D\u0434\u0435\u043A\u0441",
		AddressCaption: "\u0410\u0434\u0440\u0435\u0441",
		DoNotUseEmailCaption: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C email",
		DoNotUsePhoneCaption: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		DoNotUseFaxCaption: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u0444\u0430\u043A\u0441",
		DoNotUseSMSCaption: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C SMS",
		DoNotUseMailCaption: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043F\u043E\u0447\u0442\u0443",
		CommentaryCaption: "\u041A\u043E\u043C\u043C\u0435\u043D\u0442\u0430\u0440\u0438\u0439",
		QualifiedContactCaption: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442",
		QualifiedAccountCaption: "\u041A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442",
		LeadNameCaption: "\u041B\u0438\u0434",
		ProcessListenersCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		CountryStrCaption: "\u0421\u0442\u0440\u0430\u043D\u0430 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		RegionStrCaption: "\u041E\u0431\u043B\u0430\u0441\u0442\u044C/\u0448\u0442\u0430\u0442 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		CityStrCaption: "\u0413\u043E\u0440\u043E\u0434 (\u0441\u0442\u0440\u043E\u043A\u0430)",
		WebFormCaption: "\u041B\u0435\u043D\u0434\u0438\u043D\u0433",
		LeadTypeCaption: "\u0422\u0438\u043F \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u0438",
		LeadTypeStatusCaption: "\u0417\u0440\u0435\u043B\u043E\u0441\u0442\u044C \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u0438",
		LeadDisqualifyReasonCaption: "\u041F\u0440\u0438\u0447\u0438\u043D\u0430 \u0434\u0438\u0441\u043A\u0432\u0430\u043B\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u0438",
		AccountCategoryCaption: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u044F",
		AccountOwnershipCaption: "\u0424\u043E\u0440\u043C\u0430 \u0441\u043E\u0431\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u0441\u0442\u0438",
		DepartmentCaption: "\u0414\u0435\u043F\u0430\u0440\u0442\u0430\u043C\u0435\u043D\u0442",
		GenderCaption: "\u041F\u043E\u043B",
		JobCaption: "\u0414\u043E\u043B\u0436\u043D\u043E\u0441\u0442\u044C",
		DecisionRoleCaption: "\u0420\u043E\u043B\u044C",
		QualifyStatusCaption: "\u0421\u0442\u0430\u0434\u0438\u044F \u043B\u0438\u0434\u0430",
		DearCaption: "\u041F\u0440\u0438\u0432\u0435\u0442\u0441\u0442\u0432\u0438\u0435",
		QualificationProcessIdCaption: "QualificationProcessId",
		OwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439",
		RemindToOwnerCaption: "\u041D\u0430\u043F\u043E\u043C\u0438\u043D\u0430\u043D\u0438\u0435 \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u043C\u0443",
		SalesOwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439 \u0437\u0430 \u043F\u0440\u043E\u0434\u0430\u0436\u0443",
		BudgetCaption: "\u0411\u044E\u0434\u0436\u0435\u0442",
		MeetingDateCaption: "\u0414\u0430\u0442\u0430 \u0438 \u0432\u0440\u0435\u043C\u044F \u0432\u0441\u0442\u0440\u0435\u0447\u0438",
		DecisionDateCaption: "\u0414\u0430\u0442\u0430 \u043F\u0440\u0438\u043D\u044F\u0442\u0438\u044F \u0440\u0435\u0448\u0435\u043D\u0438\u044F",
		ShowDistributionPageCaption: "\u041E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0442\u044C \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0443 \u0440\u0430\u0441\u043F\u0440\u0435\u0434\u0435\u043B\u0435\u043D\u0438\u044F",
		BpmHrefCaption: "BpmHref",
		BpmRefCaption: "\u0421\u0430\u0439\u0442 \u043F\u0435\u0440\u0435\u0445\u043E\u0434\u0430",
		RegisterMethodCaption: "\u041A\u0430\u043A \u0437\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D",
		LeadSourceCaption: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A",
		LeadMediumCaption: "\u041A\u0430\u043D\u0430\u043B",
		OpportunityDepartmentCaption: "\u041D\u0430\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043F\u0440\u043E\u0434\u0430\u0436\u0438",
		IdentificationPassedCaption: "\u0418\u0434\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u044F \u043F\u0440\u043E\u0439\u0434\u0435\u043D\u0430",
		CampaignCaption: "\u041A\u0430\u043C\u043F\u0430\u043D\u0438\u044F",
		BulkEmailCaption: "\u0420\u0430\u0441\u0441\u044B\u043B\u043A\u0430",
		QualifiedCaption: "\u041A\u0432\u0430\u043B\u0438\u0444\u0438\u0446\u0438\u0440\u043E\u0432\u0430\u043D",
		SaleParticipantCaption: "\u0423\u0447\u0430\u0441\u0442\u043D\u0438\u043A \u043F\u0440\u043E\u0434\u0430\u0436",
		QualifiedPercentCaption: "% \u043A\u0432\u0430\u043B\u0438\u0444\u0438\u0446\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u044B\u0445",
		SalePercentCaption: "% \u043F\u0440\u043E\u0434\u0430\u0436",
		StartLeadManagementProcessCaption: "\u0417\u0430\u043F\u0443\u0441\u043A\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441 \u043F\u0440\u0438 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u0438 \u043B\u0438\u0434\u0430",
		SaleTypeCaption: "\u0422\u0438\u043F \u043F\u0440\u043E\u0434\u0430\u0436\u0438",
		ScoreCaption: "\u0420\u0435\u0439\u0442\u0438\u043D\u0433",
		QualificationPassedCaption: "\u041A\u0432\u0430\u043B\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u044F \u043F\u0440\u043E\u0439\u0434\u0435\u043D\u0430",
		EventCaption: "\u041C\u0435\u0440\u043E\u043F\u0440\u0438\u044F\u0442\u0438\u0435",
		NextActualizationDateCaption: "\u0414\u0430\u0442\u0430 \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0435\u0439 \u0430\u043A\u0442\u0443\u0430\u043B\u0438\u0437\u0430\u0446\u0438\u0438",
		BpmSessionIdCaption: "BpmSessionId",
		PredictiveScoreCaption: "\u041F\u0440\u0435\u0434\u0438\u043A\u0442\u0438\u0432\u043D\u044B\u0439 \u0440\u0435\u0439\u0442\u0438\u043D\u0433",
		MovedToFinalStateOnCaption: "\u0414\u0430\u0442\u0430 \u043F\u0435\u0440\u0435\u0432\u043E\u0434\u0430 \u0432 \u043A\u043E\u043D\u0435\u0447\u043D\u0443\u044E \u0441\u0442\u0430\u0434\u0438\u044E ",
		OpportunityCaption: "\u041F\u0440\u043E\u0434\u0430\u0436\u0430",
		PartnerCaption: "\u041F\u0430\u0440\u0442\u043D\u0435\u0440",
		PartnerOwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439 \u043F\u0430\u0440\u0442\u043D\u0435\u0440\u0430 \u0437\u0430 \u0441\u0434\u0435\u043B\u043A\u0443",
		PartnerTypeCaption: "\u0422\u0438\u043F \u043F\u0430\u0440\u0442\u043D\u0435\u0440\u0430",
		GroupCaption: "\u0413\u0440\u0443\u043F\u043F\u0430 \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0445",
		LeadTypeDetailsCaption: "\u0422\u0438\u043F \u043B\u0438\u0434\u0430",
		UtmCampaignStrCaption: "utm_campaign",
		UtmSourceStrCaption: "utm_source",
		UtmMediumStrCaption: "utm_medium",
		UtmContentStrCaption: "utm_content",
		UtmTermStrCaption: "utm_term",
		SalesChannelCaption: "\u041A\u0430\u043D\u0430\u043B \u043F\u0440\u043E\u0434\u0430\u0436\u0438",
		ProductSuggestionsCaption: "\u041F\u0440\u0435\u0434\u043B\u043E\u0436\u0435\u043D\u0438\u044F \u043F\u043E \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u0430\u043C",
		BusinessCaseCaption: "\u0411\u0438\u0437\u043D\u0435\u0441 \u043F\u043E\u0442\u0440\u0435\u0431\u043D\u043E\u0441\u0442\u044C",
		ClosingDetailsCaption: "\u0421\u0432\u0435\u0434\u0435\u043D\u0438\u044F \u043E \u0437\u0430\u043A\u0440\u044B\u0442\u0438\u0438",
		LeadGenExtendedLeadInfoCaption: "\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F \u043E \u043B\u0438\u0434\u0435",
		SocialMetadataCaption: "\u0421\u043E\u0446\u0438\u0430\u043B\u044C\u043D\u044B\u0435 \u043C\u0435\u0442\u0430\u0434\u0430\u043D\u043D\u044B\u0435",
		OrderCaption: "\u0417\u0430\u043A\u0430\u0437"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});