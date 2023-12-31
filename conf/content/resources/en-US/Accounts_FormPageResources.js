﻿define("Accounts_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		RecommendedProductSearchFilter_placeholder: "Search",
		GridDetailImportDataBtn_03wom8t_caption: "Data import",
		RecommendedProductExportDataButton_caption: "Export to Excel",
		RecommendedProductSettingsButton_caption: "Actions",
		RecommendedProductRefreshButton_caption: "Refresh",
		GridDetailAddBtn_6b3ust1_caption: "New",
		RecommendedProductExpansionPanel_title: "Recommended products",
		OpportunitySearchFilter_placeholder: "Search",
		OpportunityImportDataButton_caption: "Data import",
		OpportunityExportDataButton_caption: "Export to Excel",
		OpportunitySettingsButton_caption: "Actions",
		OpportunityRefreshButton_caption: "Refresh",
		OpportunityAddButton_caption: "New",
		OpportunityExpansionPanel_title: "Opportunities",
		AccountCategory_placeholder: "Select category",
		addRecord_3bs3f03_caption: "Add new",
		addRecord_fhp55rg_caption: "Add new",
		AddressAddButton_caption: "New",
		AddressExpansionPanel_title: "Addresses",
		AddressExportDataButton_caption: "Export to Excel",
		AddressImportDataButton_caption: "Data import",
		AddressRefreshButton_caption: "Refresh",
		AddressSearchFilter_placeholder: "Search",
		AddressSettingsButton_caption: "Actions",
		AlternativeName_placeholder: "Enter other name",
		AnnualRevenue_placeholder: "Select revenue",
		AttachmentAddButtonCaption: "Upload",
		AttachmentRefreshButtonCaption: "Refresh",
		AttachmentsTabContainerCaption: "Attachments",
		BackButton: "Back",
		CancelButton: "Cancel",
		CloseButton: "Close",
		ContactsAddButton_caption: "New",
		ContactsExpansionPanel_title: "Contacts",
		ContactsExportDataButton_caption: "Export to Excel",
		ContactsImportDataButton_caption: "Data import",
		ContactsRefreshButton_caption: "Refresh",
		ContactsSearchFilter_placeholder: "Search",
		ContactsSettingsButton_caption: "Actions",
		DefaultHeaderCaption: "Page title",
		DocumentAddButton_caption: "New",
		DocumentExpansionPanel_title: "Documents",
		DocumentExportDataButton_caption: "Export to Excel",
		DocumentmportDataButton_caption: "Data import",
		DocumentRefreshButton_caption: "Refresh",
		DocumentSearchFilter_placeholder: "Search",
		DocumentSettingsButton_caption: "Actions",
		EmployeesNumber_placeholder: "Select employees number",
		FeedTabContainerCaption: "Feed",
		GeneralInfoTab_caption: "Account info",
		GridDetailAddBtn_8epadep_caption: "New",
		GridDetailExportDataBtn_ssiwb80_caption: "Export to Excel",
		GridDetailImportDataBtn_xganuq6_caption: "Data import",
		GridDetailRefreshBtn_msrri9a_caption: "Refresh",
		GridDetailSearchFilter_thtkccr_placeholder: "Search",
		GridDetailSettingsBtn_8j1uh8h_caption: "Actions",
		Industry_placeholder: "Select industry",
		LeadAddButton_caption: "New",
		LeadExpansionPanel_title: "MQL/SQL",
		LeadExportDataButton_caption: "Export to Excel",
		LeadImportDataButton_caption: "Data import",
		LeadRefreshButton_caption: "Refresh",
		LeadSearchFilter_placeholder: "Search",
		LeadSettingsButton_caption: "Actions",
		NewRecord: "New record",
		Owner_placeholder: "Select owner",
		Ownership_placeholder: "Select entity",
		PageTitle_caption: "Page title",
		Phone_placeholder: "Enter phone number",
		PrimaryContact_placeholder: "Select primary contact",
		PrimaryContactExpansionPanel_title: "Primary contact",
		Record: "Record",
		RelationshipButton_caption: "Relationships",
		SalesTab_caption: "Sales",
		SaveButton: "Save",
		SetRecordRightsButtonCaption: "Set up access rights",
		Timeline_caption: "Timeline",
		Timeline_label: "Timeline",
		TimelineTab_caption: "Timeline",
		Type_placeholder: "Select type",
		Web_placeholder: "Enter web",
		ServiceAgreementsSearchFilter_placeholder: "Search",
		ServiceAgreementsImportDataButton_caption: "Data import",
		ServiceAgreementsExportDataButton_caption: "Export to Excel",
		ServiceAgreementsSettingsButton_caption: "Actions",
		ServiceAgreementsRefreshButton_caption: "Refresh",
		GridDetailAddBtn_776x8oo_caption: "New",
		ServiceAgreementsExpansionPanel_title: "Service agreements",
		ServiceAgreementsList_1cf40713: "Title",
		ServiceAgreementsList_df16588b: "Owner",
		ServiceAgreementsList_480040bd: "Status",
		ServiceAgreementsList_41b15d43: "Number",
		ServiceAgreementsListDS_ServicePact: "Service agreement",
		AccountCommunicationOptionsAddButton_caption: "Add communication option",
		CasesAddButton_caption: "New",
		CasesExpansionPanel_title: "Cases",
		CasesExportDataButton_caption: "Export to Excel",
		CasesImportDataButton_caption: "Data import",
		CasesRefreshButton_caption: "Refresh",
		CasesSearchFilter_placeholder: "Search",
		CasesSettingsButton_caption: "Actions",
		ServiceTab_caption: "Service",
		LeadConversionScore_tooltip: "The score indicates the probability of creating a Lead associated with the Account. The value is calculated with the ML model",
		BillingInfoExpansionPanel_title: "Banking details",
		GridDetailSearchFilter_zeotc7u_placeholder: "Search",
		GridDetailImportDataBtn_ghwso4q_caption: "Data import",
		GridDetailExportDataBtn_aumpyxy_caption: "Export to Excel",
		GridDetailSettingsBtn_lv7bn4j_caption: "Actions",
		GridDetailRefreshBtn_oabjslj_caption: "Refresh",
		GridDetailAddBtn_6zkpmj1_caption: "New",
		ExpansionPanel_gqzom9h_title: "Expanded list",
		BillingInfoSearchFilter_placeholder: "Search",
		BillingInfoImportDataButton_caption: "Data import",
		BillingInfoExportDataButton_caption: "Export to Excel",
		BillingInfoRefreshButton_caption: "Refresh",
		BillingInfoAddButton_caption: "New",
		BankingDetailsExportDataButton_caption: "Export to Excel",
		BankingDetailsSearchFilter_placeholder: "Search",
		BankingDetailsDataButton_caption: "Data import",
		BankingDetailsSettingsButton_caption: "Actions",
		BankingDetailsRefreshButton_caption: "Refresh",
		BankingDetailsAddButton_caption: "New",
		OrderSearchFilter_placeholder: "Search",
		OrderImportDataButton_caption: "Data import",
		OrderExportDataButton_caption: "Export to Excel",
		OrderSettingsButton_caption: "Actions",
		OrderRefreshButton_caption: "Refresh",
		OrderAddButton_caption: "New",
		OrderExpansionPanel_title: "Orders",
		ContractSearchFilter_placeholder: "Search",
		ContractImportDataButton_caption: "Data import",
		ContractExportDataButton_caption: "Export to Excel",
		ContractSettingsButton_caption: "Actions",
		ContractRefreshButton_caption: "Refresh",
		ContractAddButton_caption: "New",
		ContractExpansionPanel_title: "Contracts",
		InvoiceSearchFilter_placeholder: "Search",
		InvoiceImportDataButton_caption: "Data import",
		InvoiceExportDataButton_caption: "Export to Excel",
		InvoiceSettingsButton_caption: "Actions",
		InvoiceRefreshButton_caption: "Refresh",
		InvoiceAddButton_caption: "New",
		InvoiceExpansionPanel_title: "Invoices"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});