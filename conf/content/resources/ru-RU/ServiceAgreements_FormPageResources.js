﻿define("ServiceAgreements_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GridDetailSearchFilter_xky7p65_placeholder: "Search",
		GridDetailImportDataBtn_2iui5ze_caption: "Data import",
		GridDetailExportDataBtn_86v8c8q_caption: "Export to Excel",
		GridDetailSettingsBtn_4f0xlzk_caption: "Actions",
		GridDetailRefreshBtn_d9dg1pp_caption: "Refresh",
		GridDetailAddBtn_k1hrc5b_caption: "New",
		ExpansionPanel_c9gf0bh_title: "Service recipients",
		addRecord_3ok2cmj_caption: "Add new",
		addRecord_zb4my2r_caption: "Add new",
		addRecord_o0novp4_caption: "Add new",
		addRecord_a3wxnrt_caption: "Add new",
		addRecord_1f56dia_caption: "Add new",
		ServiceRecipientsRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ServiceRecipientsSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		GridDetailSearchFilter_gh8z01y_placeholder: "Search",
		GridDetailImportDataBtn_qukq886_caption: "Data import",
		GridDetailExportDataBtn_f8frxif_caption: "Export to Excel",
		GridDetailSettingsBtn_ac6uu1y_caption: "Actions",
		GridDetailRefreshBtn_hg1j1um_caption: "Refresh",
		GridDetailAddBtn_3qfcd1h_caption: "New",
		ExpansionPanel_241ukdf_title: "Service recipients",
		GridDetailSearchFilter_a4wkgx3_placeholder: "Search",
		GridDetailImportDataBtn_wmmf3ni_caption: "Data import",
		GridDetailExportDataBtn_9uzotmf_caption: "Export to Excel",
		GridDetailSettingsBtn_snaham7_caption: "Actions",
		GridDetailRefreshBtn_4ok1vso_caption: "Refresh",
		GridDetailAddBtn_ow8bu8c_caption: "New",
		ExpansionPanel_9hxk0eq_title: "Services",
		TabContainer_6ipl1ss_caption: "\u0418\u0441\u0442\u043E\u0440\u0438\u044F \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439",
		GridDetailSearchFilter_v9udmk0_placeholder: "Search",
		GridDetailImportDataBtn_9v0xcbp_caption: "Data import",
		GridDetailExportDataBtn_1lecmt6_caption: "Export to Excel",
		GridDetailSettingsBtn_vun9t8m_caption: "Actions",
		GridDetailRefreshBtn_obmjo3f_caption: "Refresh",
		GridDetailAddBtn_3iqrzc1_caption: "New",
		ExpansionPanel_v5dftap_title: "Cases",
		CasesSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		CasesImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		CasesExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		CasesSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		CasesRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		CasesExpansionPanel_title: "\u041E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u044F",
		ServicesSearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		ServicesImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		ServicesExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		ServicesSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ServicesAddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		ServicesRefreshButton_caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		ServicesExpansionPanel_title: "\u0414\u043E\u0441\u0442\u0443\u043F\u043D\u044B\u0435 \u0441\u0435\u0440\u0432\u0438\u0441\u044B \u0432 \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u0435",
		ServiceRecipientsExpansionPanel_title: "\u041E\u0431\u044A\u0435\u043A\u0442\u044B \u043E\u0431\u0441\u043B\u0443\u0436\u0438\u0432\u0430\u043D\u0438\u044F",
		ServiceRecipientsImportDataButton_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		ServiceRecipientsExportDataButton_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		ServiceRecipientsSettingsButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		Label_eay1yqv_caption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		MenuItem_tizwwo4_caption: "Menu item",
		GeneralInfoLabel_caption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		ServicesList_310bc671: "\u0421\u0435\u0440\u0432\u0438\u0441",
		AttachmentAddButtonCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		AttachmentRefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		AttachmentsTabContainerCaption: "\u0424\u0430\u0439\u043B\u044B",
		BackButton: "\u041D\u0430\u0437\u0430\u0434",
		CancelButton: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CloseButton: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		FeedTabContainerCaption: "\u041B\u0435\u043D\u0442\u0430",
		GeneralInfoTab_caption: "\u0423\u0441\u043B\u043E\u0432\u0438\u044F \u0434\u043E\u0433\u043E\u0432\u043E\u0440\u0430",
		NewRecord: "\u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		Record: "\u0417\u0430\u043F\u0438\u0441\u044C",
		SaveButton: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SetRecordRightsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});