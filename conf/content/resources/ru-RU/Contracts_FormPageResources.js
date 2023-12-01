﻿define("Contracts_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Owner_tooltip: "\u0424\u0418\u041E \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u043E\u0433\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430. \u0412\u044B\u0431\u043E\u0440 \u0438\u0437 \u0441\u043F\u0438\u0441\u043A\u0430 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432, \u043F\u043E \u043A\u043E\u0442\u043E\u0440\u044B\u043C \u0437\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		addRecord_jw0oh71_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_948r1p3_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_2425btr_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		addRecord_yizlc6v_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		SubordinateContractListAddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		ParentContract_tooltip: "\u0414\u043E\u0433\u043E\u0432\u043E\u0440, \u043A\u043E\u0442\u043E\u0440\u043E\u043C\u0443 \u043F\u043E\u0434\u0447\u0438\u043D\u0435\u043D \u0434\u0430\u043D\u043D\u044B\u0439 \u0434\u043E\u043A\u0443\u043C\u0435\u043D\u0442. \u0414\u043E\u0441\u0442\u0443\u043F\u043D\u043E \u0434\u043B\u044F \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0434\u043B\u044F \u0441\u043F\u0435\u0446\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u0439 \u0438 \u0434\u043E\u043F. \u0441\u043E\u0433\u043B\u0430\u0448\u0435\u043D\u0438\u0439. \u0411\u0443\u0434\u0435\u0442 \u0437\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u043E \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u043F\u0440\u0438 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0438 \u0437\u0430\u043F\u0438\u0441\u0435\u0439 \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u044C [\u041F\u043E\u0434\u0447\u0438\u043D\u0435\u043D\u043D\u044B\u0435 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u044B]",
		Amount_tooltip: "Total contract amount. If the contract is created based on an order, the field becomes non-editable and is calculated as a total amount of products in the contract. The products are copied to the contract from the order. The field is editable, if the contract is not connected to an order",
		OurBankingDetails_tooltip: "\u041F\u043B\u0430\u0442\u0435\u0436\u043D\u044B\u0435 \u0440\u0435\u043A\u0432\u0438\u0437\u0438\u0442\u044B \u0432\u0430\u0448\u0435\u0439 \u043A\u043E\u043C\u043F\u0430\u043D\u0438\u0438. \u0421\u043F\u0438\u0441\u043E\u043A \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0439 \u043F\u043E\u043B\u044F \u0444\u043E\u0440\u043C\u0438\u0440\u0443\u0435\u0442\u0441\u044F \u043D\u0430 \u043E\u0441\u043D\u043E\u0432\u0435 \u0434\u0435\u0442\u0430\u043B\u0438 [\u041F\u043B\u0430\u0442\u0435\u0436\u043D\u044B\u0435 \u0440\u0435\u043A\u0432\u0438\u0437\u0438\u0442\u044B] \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u0432\u0430\u0448\u0435\u0439 \u043A\u043E\u043C\u043F\u0430\u043D\u0438\u0438",
		AccountBankingDetails_tooltip: "\u041F\u043B\u0430\u0442\u0435\u0436\u043D\u044B\u0435 \u0440\u0435\u043A\u0432\u0438\u0437\u0438\u0442\u044B \u043A\u043B\u0438\u0435\u043D\u0442\u0430. \u0414\u043B\u044F \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u043D\u043E\u0432\u043E\u0433\u043E \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0432 \u043F\u043E\u043B\u0435 \u043F\u0435\u0440\u0435\u0439\u0434\u0438\u0442\u0435 \u043A \u0434\u0435\u0442\u0430\u043B\u0438 [\u041F\u043B\u0430\u0442\u0435\u0436\u043D\u044B\u0435 \u0440\u0435\u043A\u0432\u0438\u0437\u0438\u0442\u044B] \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u043A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u0430",
		ContractDetailsTab_caption: "\u041F\u0430\u0441\u043F\u043E\u0440\u0442 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u0430",
		ApprovalListExpansionPanel_title: "\u0412\u0438\u0437\u044B",
		SendForApprovalButton_caption: "\u041E\u0442\u043F\u0440\u0430\u0432\u0438\u0442\u044C \u043D\u0430 \u0432\u0438\u0437\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		ApprovalsTab_caption: "\u0412\u0438\u0437\u044B",
		ApprovalListRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ProductListRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		SubordinateContractListRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		SubordinateContractsExpansionPanel_title: "\u041F\u043E\u0434\u0447\u0438\u043D\u0435\u043D\u043D\u044B\u0435 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u044B",
		ApprovalListSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		ProductListSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ProductListSearchFilter_placeholder: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ProductListAddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		SubordinateContractListImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		SubordinateContractListExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		SubordinateContractListSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		SubordinateContractListSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		PrintButton_caption: "\u041F\u0435\u0447\u0430\u0442\u044C",
		ProductsExpansionPanel_title: "\u041F\u0440\u043E\u0434\u0443\u043A\u0442\u044B",
		ContractInfoLabel_caption: "\u0418\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F \u043F\u043E \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u0443",
		ProductsImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		ProductsExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		AttachmentAddButtonCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		AttachmentRefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		AttachmentsTabContainerCaption: "\u0424\u0430\u0439\u043B\u044B",
		BackButton: "\u041D\u0430\u0437\u0430\u0434",
		CancelButton: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CloseButton: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		FeedTabContainerCaption: "\u041B\u0435\u043D\u0442\u0430",
		GeneralInfoTab_caption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		NewRecord: "\u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		Record: "\u0417\u0430\u043F\u0438\u0441\u044C",
		SaveButton: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SetRecordRightsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});