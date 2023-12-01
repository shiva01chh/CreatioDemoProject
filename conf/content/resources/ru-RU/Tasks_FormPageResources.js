﻿define("Tasks_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		addRecord_1g27yyy_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C",
		addRecord_d7tgh1o_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C",
		addRecord_1f3uxqe_caption: "Add new",
		addRecord_2203v7p_caption: "Add new",
		addRecord_dgwsv5d_caption: "Add new",
		addRecord_gd4s8lw_caption: "Add new",
		addRecord_ov8b6oh_caption: "Add new",
		addRecord_s3niqqb_caption: "Add new",
		addRecord_xozmcce_caption: "Add new",
		AttachmentAddButtonCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		AttachmentRefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		AttachmentsTabContainer_caption: "\u0424\u0430\u0439\u043B\u044B",
		AttachmentsTabContainerCaption: "\u0424\u0430\u0439\u043B\u044B",
		BackButton: "\u041D\u0430\u0437\u0430\u0434",
		Button_rupn8sfCaption: "\u0417\u0430\u0433\u0440\u0443\u0437\u0438\u0442\u044C",
		Button_uey36i4Caption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		CancelButton: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CloseButton: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		ExpansionPanel_9kt2jf4_title: "\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		ExpansionPanel_gayd5lc_title: "Attachments",
		ExpansionPanel_hbptvvf_title: "Participants",
		FeedTabContainer_caption: "\u041B\u0435\u043D\u0442\u0430",
		FeedTabContainerCaption: "\u041B\u0435\u043D\u0442\u0430",
		GeneralInfoTab_caption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		GridDetailAddBtn_65zfh1c_caption: "New",
		GridDetailAddBtn_b84d905_caption: "Upload",
		GridDetailAddBtn_j463qn2_caption: "New",
		GridDetailExportDataBtn_jhs983p_caption: "Export to Excel",
		GridDetailExportDataBtn_zajcdyb_caption: "Export to Excel",
		GridDetailImportDataBtn_70xbu27_caption: "Data import",
		GridDetailImportDataBtn_xq02vnt_caption: "Data import",
		GridDetailRefreshBtn_gfethnt_caption: "Refresh",
		GridDetailRefreshBtn_m9f2zlj_caption: "Refresh",
		GridDetailRefreshBtn_nv2l3mt_caption: "Refresh",
		GridDetailSearchFilter_sc547hp_placeholder: "Search",
		GridDetailSearchFilter_ui9rjm1_placeholder: "Search",
		GridDetailSearchFilter_wxs6sib_placeholder: "Search",
		GridDetailSettingsBtn_076nxwc_caption: "Actions",
		GridDetailSettingsBtn_gt57y67_caption: "Actions",
		Label_2i2b8cv_caption: "\u0418\u0441\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u0438",
		Label_7p83djj_caption: "\u041D\u0430\u043F\u043E\u043C\u0438\u043D\u0430\u043D\u0438\u044F",
		Label_7ux4r92_caption: "\u0424\u0430\u0439\u043B\u044B",
		Label_bouo1vp_caption: "\u041B\u0435\u043D\u0442\u0430",
		Label_s2umkbw_caption: "\u0414\u0435\u0442\u0430\u043B\u0438",
		Label_t0rm6mn_caption: "\u0421\u0432\u044F\u0437\u0438",
		NewRecord: "\u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		Notes_placeholder: "\u041D\u0430\u043F\u0438\u0448\u0438\u0442\u0435 \u0437\u0430\u043C\u0435\u0442\u043A\u0438 \u043E\u0431 \u044D\u0442\u043E\u0439 \u0437\u0430\u0434\u0430\u0447\u0435",
		Record: "\u0417\u0430\u043F\u0438\u0441\u044C",
		SaveButton: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		SetRecordRightsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u0440\u0430\u0432",
		TabContainer_4rzb4bw_caption: "\u0421\u0432\u044F\u0437\u0438",
		TabContainer_es7ne17Caption: "\u0424\u0430\u0439\u043B\u044B",
		TabContainer_itw82y1_caption: "Attachments",
		TabContainer_ko8xzk9_caption: "Feed"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});