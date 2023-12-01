﻿define("Orders_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		addRecord_fqbv4qt_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		AccountAddress_label: "\u0410\u0434\u0440\u0435\u0441 \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0430",
		AccountCategory_ariaLabel: "Dropdown",
		AccountIndustry_ariaLabel: "Dropdown",
		AccountLabel_caption: "\u0418\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F \u043E \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0435",
		AccountWeb_caption: "Web link",
		addRecord_dbyq7n8_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_gge12ha_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_mb4zwk4_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_xx9pdmu_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		ApprovalListExpansionPanel_title: "\u0412\u0438\u0437\u044B",
		ApprovalListRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ApprovalListSearch_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		ApprovalsTab_caption: "\u0421\u043E\u0433\u043B\u0430\u0441\u043E\u0432\u0430\u043D\u0438\u0435",
		AttachmentAddButtonCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		AttachmentRefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		AttachmentsTabContainerCaption: "\u0424\u0430\u0439\u043B\u044B",
		BackButton: "\u041D\u0430\u0437\u0430\u0434",
		CancelButton: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CloseButton: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		ContactAddress_label: "\u0410\u0434\u0440\u0435\u0441 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		ContactEmail_caption: "Email address",
		ContactMobilePhone_caption: "Phone number",
		ContactPreferredLanguage_ariaLabel: "Dropdown",
		CustomerProfileTabContainer_caption: "\u041F\u0440\u043E\u0444\u0438\u043B\u044C \u043A\u043B\u0438\u0435\u043D\u0442\u0430",
		CustomerProfileTabContainerHeaderLabel_caption: "\u041F\u0440\u043E\u0444\u0438\u043B\u044C \u043A\u043B\u0438\u0435\u043D\u0442\u0430",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		DocumentsExpansionPanel_title: "\u0414\u043E\u043A\u0443\u043C\u0435\u043D\u0442\u044B",
		DocumentsExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		DocumentsRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		DocumentsSearch_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		DocumentsTab_caption: "\u0414\u043E\u043A\u0443\u043C\u0435\u043D\u0442\u044B",
		ExpansionPanel_dbtaxlc_title: "Expanded list",
		FeedTabContainerCaption: "\u041B\u0435\u043D\u0442\u0430",
		GeneralInfoTab_caption: "\u041F\u0440\u043E\u0434\u0443\u043A\u0442\u044B",
		GridDetail_tviz7gfDS_DiscountPercent: "Discount",
		GridDetailAddBtn_n0rv6tu_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		GridDetailExportDataBtn_thhv3as_caption: "Export to Excel",
		GridDetailImportDataBtn_pu57mnb_caption: "Data import",
		GridDetailRefreshBtn_0of7x3y_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		GridDetailSearchFilter_v38rkqs_placeholder: "Search",
		GridDetailSettingsBtn_i02a9fi_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		InstallmentPlanExpansionPanel_title: "\u0413\u0440\u0430\u0444\u0438\u043A \u043F\u043E\u0441\u0442\u0430\u0432\u043E\u043A \u0438 \u043E\u043F\u043B\u0430\u0442",
		InstallmentPlanRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		InstallmentPlanSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		InvoicesAddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		InvoicesExpansionPanel_title: "\u0421\u0447\u0435\u0442\u0430",
		InvoicesExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		InvoicesImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		InvoicesRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		InvoicesSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		InvoicesSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		NewRecord: "\u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		OrderInfoLabel_caption: "\u0418\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F \u043F\u043E \u0437\u0430\u043A\u0430\u0437\u0443",
		PaymentDeliveryTab_caption: "\u041E\u043F\u043B\u0430\u0442\u0430 \u0438 \u0434\u043E\u0441\u0442\u0430\u0432\u043A\u0430",
		ProductsAddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		ProductsExpansionPanel_title: "\u041F\u0440\u043E\u0434\u0443\u043A\u0442\u044B",
		ProductsExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		ProductsImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		ProductsRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ProductsSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		ProductsSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		Record: "\u0417\u0430\u043F\u0438\u0441\u044C",
		SaveButton: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SendForApprovalButton_caption: "\u041E\u0442\u043F\u0440\u0430\u0432\u0438\u0442\u044C \u043D\u0430 \u0432\u0438\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		SetRecordRightsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432",
		Timeline_caption: "Timeline",
		Timeline_label: "Timeline",
		TimelineTab_caption: "\u0422\u0430\u0439\u043C\u043B\u0430\u0439\u043D",
		TotalWidgetTitle_caption: "\u0418\u0442\u043E\u0433\u043E, $",
		TotalWidgetValue_caption: "3,492.00",
		InstallmentPlanImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		InstallmentPlanExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		InstallmentPlanSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});