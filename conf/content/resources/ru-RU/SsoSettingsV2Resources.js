﻿define("SsoSettingsV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		RefreshButtonCaption: "",
		SearchFilter_placeholder: "",
		Button_rv37f3w_caption: "",
		Button_wbldjlj_caption: "",
		Button_c1n5qgv_caption: "",
		Button_7jo0us3_caption: "",
		TabContainer_i2vhfxs_caption: "",
		TabContainer_y2orwdm_caption: "",
		AddButton_caption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		TabContainer_lmbm2dd_caption: "",
		TabContainer_JIT_caption: "JIT provisioning",
		Label_AdditionalInformation_caption: "\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		TabContainer_SsoProviders_caption: "SSO Identity provider",
		TabContainer_xyznn6k_caption: "",
		Button_g2hjeg5_caption: "",
		Button_g2hjeg5: "",
		Button_JIT_caption: "Just-In-Time provisioning",
		Button_Azure_caption: "Single Sign On \u0447\u0435\u0440\u0435\u0437 Azure AD",
		MenuItem_AddNewProvider_caption: "",
		Button_OneLogin_caption: "Single Sign On \u0447\u0435\u0440\u0435\u0437 OneLogin",
		Button_ADFS_caption: "Single Sign On \u0447\u0435\u0440\u0435\u0437 AD FS",
		TabContainer_JIT_OPENID_caption: "OPENID provisioning",
		Checkbox_UseJIT_tooltip: "Use Just-in-Time Provisioning for general users",
		Checkbox_UseJIT_label: "\u0421\u043E\u0437\u0434\u0430\u0432\u0430\u0442\u044C \u0438 \u043E\u0431\u043D\u043E\u0432\u043B\u044F\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0435\u0439 \u0432\u043E \u0432\u0440\u0435\u043C\u044F \u043B\u043E\u0433\u0438\u043D\u0430 (Just-In-Time Provisioning)",
		Button_y1ig7vh_caption: "Single Sign On via Cognito",
		ExpansionPanel_OpenIdAttributes_title: "OpenID provisioning",
		ExpansionPanel_SamlProvisioning_title: "SAML data to contact fields mapping",
		SaveButton_caption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		ExpansionPanel_SsoProviders_title: "External identity providers",
		ExpansionPanel_OpenIdProvisioning_title: "OpenID data to contact fields mapping",
		SsoSettingsTempate_ColumnCaption: "Protocol",
		EntityID_ColumnCaption: "Entity ID",
		BackButton_caption: "\u041D\u0430\u0437\u0430\u0434",
		Button_18ejr71_caption: "",
		ActionButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		Button_Data_Import: "\u0418\u043C\u043F\u043E\u0440\u0442",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		EmptySectionPlaceholderSubHead: "\u0414\u043E\u0431\u0430\u0432\u044C\u0442\u0435 \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C, \u0438 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0442\u0430\u043A \u043E\u0434\u0438\u043D\u043E\u043A\u043E",
		EmptySectionPlaceholderTitle: "\u0412 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		FilteredEmptySectionPlaceholderSubHead: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u0435 \u0444\u0438\u043B\u044C\u0442\u0440 \u0438\u043B\u0438 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044F \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438",
		FilteredEmptySectionPlaceholderTitle: "\u041F\u0440\u0438 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u043E\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0435 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		ListTitleCaption: "List title",
		MenuItem_ExportToExel_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		MenuItem_ImportFromExel_caption: "Excel",
		OpenLandingDesignerCaption: "Web-\u0444\u043E\u0440\u043C\u044B \u0438 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});