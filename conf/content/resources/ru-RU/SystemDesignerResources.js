define("SystemDesignerResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessCaption: "\u041F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		UsersCaption: "\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438 \u0438 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		IntegrationCaption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0438 \u0438\u043D\u0442\u0435\u0433\u0440\u0430\u0446\u0438\u0438",
		SystemSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		SystemViewCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0432\u043D\u0435\u0448\u043D\u0435\u0433\u043E \u0432\u0438\u0434\u0430",
		ConfigurationCaption: "\u041A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u0447\u0438\u043A\u043E\u043C",
		ProcessLibraryLinkCaption: "\u0411\u0438\u0431\u043B\u0438\u043E\u0442\u0435\u043A\u0430 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u0432",
		ProcessLogLinkCaption: "\u0416\u0443\u0440\u043D\u0430\u043B \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u0432",
		ObjectRightsManagementLinkCaption: "\u041F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430 \u043D\u0430 \u043E\u0431\u044A\u0435\u043A\u0442\u044B",
		OperationRightsManagementLinkCaption: "\u041F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430 \u043D\u0430 \u043E\u043F\u0435\u0440\u0430\u0446\u0438\u0438",
		AuditLogLinkCaption: "\u0416\u0443\u0440\u043D\u0430\u043B \u0430\u0443\u0434\u0438\u0442\u0430",
		ExcelImportLinkCaption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445 \u0438\u0437 Excel",
		LookupsLinkCaption: "\u0421\u043F\u0440\u0430\u0432\u043E\u0447\u043D\u0438\u043A\u0438",
		SectionDesignerLinkCaption: "\u041C\u0430\u0441\u0442\u0435\u0440 \u0440\u0430\u0437\u0434\u0435\u043B\u043E\u0432",
		MobileAppDesignerLinkCaption: "\u041C\u0430\u0441\u0442\u0435\u0440 \u043C\u043E\u0431\u0438\u043B\u044C\u043D\u043E\u0433\u043E \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F",
		ConfigurationLinkCaption: "\u0423\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u0435\u0439",
		SysWorkplaceLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0440\u0430\u0431\u043E\u0447\u0438\u0445 \u043C\u0435\u0441\u0442",
		SysLogoManagementLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043A\u043E\u0440\u043F\u043E\u0440\u0430\u0442\u0438\u0432\u043D\u043E\u0439 \u0441\u0438\u043C\u0432\u043E\u043B\u0438\u043A\u0438",
		SysColorManagementLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0446\u0432\u0435\u0442\u0430 \u043F\u0430\u043D\u0435\u043B\u0438 \u0440\u0430\u0437\u0434\u0435\u043B\u043E\u0432",
		RightsErrorMessage: "\u0423 \u0432\u0430\u0441 \u043D\u0435\u0442 \u043F\u0440\u0430\u0432 \u043D\u0430 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F. \u041E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u043C\u0443 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443.",
		WebFormsLinkCaption: "\u0426\u0435\u043B\u0435\u0432\u044B\u0435 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		LdapLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0438\u043D\u0442\u0435\u0433\u0440\u0430\u0446\u0438\u0438 \u0441 LDAP",
		ButtonCaption: "\u041F\u0435\u0440\u0435\u0439\u0442\u0438",
		BannerCaption: "\u0414\u043E\u043A\u0443\u043C\u0435\u043D\u0442\u0430\u0446\u0438\u044F \u043F\u043E BPMS",
		BannerHint: "\u0443\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u0431\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0430\u043C\u0438",
		MobileAppCaption: "\u041C\u043E\u0431\u0438\u043B\u044C\u043D\u0430\u044F \u0432\u0435\u0440\u0441\u0438\u044F",
		AndroidUrl: "https://play.google.com/store/apps/details?id=com.creatio.mobileapp",
		IosUrl: "https://itunes.apple.com/us/app/bpmonline-mobile-7/id708432450?mt=8",
		LinkedInUrl: "https://linkedin.bpmonline.com",
		GoogleUrl: "https://plus.google.com/u/0/116164135679912261451/posts",
		TwitterUrl: "https://twitter.bpmonline.com",
		FacebookUrl: "https://facebook.bpmonline.com",
		YoutubeUrl: "https://youtube.bpmonline.com",
		DetailWizardLinkCaption: "\u041C\u0430\u0441\u0442\u0435\u0440 \u0434\u0435\u0442\u0430\u043B\u0435\u0439",
		SdkCaption: "\u0420\u0443\u043A\u043E\u0432\u043E\u0434\u0441\u0442\u0432\u043E \u043F\u043E \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u043A\u0435 \u043D\u0430 \u043F\u043B\u0430\u0442\u0444\u043E\u0440\u043C\u0435 Creatio",
		CommunityCaption: "\u041D\u0430\u0439\u0442\u0438 \u043E\u0442\u0432\u0435\u0442\u044B",
		CommunityUrl: "http://www.community.terrasoft.ru/",
		OrgRolesLinkCaption: "\u041E\u0440\u0433\u0430\u043D\u0438\u0437\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0435 \u0440\u043E\u043B\u0438",
		FuncRolesLinkCaption: "\u0424\u0443\u043D\u043A\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u044B\u0435 \u0440\u043E\u043B\u0438",
		UsersLinkCaption: "\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438 \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		SysSettingsLinkCaption: "\u0421\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438",
		MandrillSettingsLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0438\u043D\u0442\u0435\u0433\u0440\u0430\u0446\u0438\u0438 \u0441 Mandrill",
		WindowsUrl: "",
		DuplicatesSettingsLinkCaption: "\u041F\u0440\u0430\u0432\u0438\u043B\u0430 \u043F\u043E\u0438\u0441\u043A\u0430 \u0434\u0443\u0431\u043B\u0435\u0439",
		SocialAccountsCaption: "\u0421\u0432\u044F\u0436\u0438\u0442\u0435\u0441\u044C \u0441 \u043D\u0430\u043C\u0438",
		CommunityLabel: "\u0421\u043E\u043E\u0431\u0449\u0435\u0441\u0442\u0432\u043E",
		AndroidLabel: "Google play",
		IosLabel: "App Store",
		WindowsLabel: "",
		AcademyCaption: "\u0412\u0438\u0434\u0435\u043E\u043A\u0443\u0440\u0441\u044B. \u0422\u0440\u0435\u043D\u0438\u043D\u0433\u0438. \u0422\u0435\u0441\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		FileImportLinkCaption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		TranslationSectionCaption: "\u041F\u0435\u0440\u0435\u0432\u043E\u0434\u044B",
		LanguageSectionCaption: "\u042F\u0437\u044B\u043A\u0438",
		PackageMarketCaption: "Creatio package market",
		ProcessDesignerLinkCaption: "\u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u0432",
		ScoringModelCaption: "\u0421\u043A\u043E\u0440\u0438\u043D\u0433\u043E\u0432\u044B\u0435 \u043C\u043E\u0434\u0435\u043B\u0438",
		SiteEventTypeCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0442\u0440\u0435\u043A\u0438\u043D\u0433\u0430 \u0441\u043E\u0431\u044B\u0442\u0438\u0439 \u0441\u0430\u0439\u0442\u0430",
		OpenBulkEmailEventLogCaption: "\u0416\u0443\u0440\u043D\u0430\u043B \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0438 email-\u0440\u0430\u0441\u0441\u044B\u043B\u043E\u043A",
		ResourceTpl: "Resources.Strings.{0}",
		InstallConfirmationMessage: "\u0412\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u043C\u043E\u0436\u0435\u0442 \u0437\u0430\u043D\u044F\u0442\u044C \u0434\u043B\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u0432\u0440\u0435\u043C\u044F.  \u041F\u043E \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0438 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043A\u0438 \u0432\u044B \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u0435 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0435. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		InstallPackageDenied: "\u0423 \u0432\u0430\u0441 \u043D\u0435\u0442 \u043F\u0440\u0430\u0432 \u043D\u0430 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		InstallPackageSuccess: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u043A\u0430 \u043F\u0430\u043A\u0435\u0442\u0430 \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0430 \u0443\u0441\u043F\u0435\u0448\u043D\u043E",
		InstallPackageFailed: "\u0412\u043E \u0432\u0440\u0435\u043C\u044F \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043A\u0438 \u0432\u043E\u0437\u043D\u0438\u043A\u043B\u0438 \u043F\u0440\u043E\u0431\u043B\u0435\u043C\u044B",
		InstallPackageEmptyUrl: "\u041F\u0443\u0442\u044C \u043A \u0445\u0440\u0430\u043D\u0438\u043B\u0438\u0449\u0443 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043F\u0443\u0441\u0442\u044B\u043C",
		ApplicationHubCaption: "\u0426\u0435\u043D\u0442\u0440 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0439",
		InstallWebitelAnyVoipCaption: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u043A\u0430 \u043F\u0430\u043A\u0435\u0442\u0430 \u0022Webitel AnyVoip\u0022",
		UpdateWebitelAnyVoipCaption: "\u041E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043F\u0430\u043A\u0435\u0442\u0430 \u0022Webitel AnyVoip\u0022",
		FeaturesPage: "\u041D\u043E\u0432\u0430\u044F \u0444\u0443\u043D\u043A\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u043E\u0441\u0442\u044C",
		PortalUsersLinkCaption: "External \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438",
		MarketplaceCaption: "\u041A\u0430\u0442\u0430\u043B\u043E\u0433 \u0440\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u0438\u0439 \u0438 \u0431\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u0432",
		MarketplaceUrl: "https://marketplace.terrasoft.ru/",
		MarketplaceLabel: "Marketplace",
		ApplicationManagementCaption: "\u0423\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044F\u043C\u0438",
		GettingStartedCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u0443",
		GettingStartedLabel: "\u0411\u044B\u0441\u0442\u0440\u044B\u0439 \u0441\u0442\u0430\u0440\u0442",
		GettingStartedUrl: "https://academy.terrasoft.ru/getting-started",
		PageWizardLinkCaption: "\u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446",
		PortalMainPageManagementLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0433\u043B\u0430\u0432\u043D\u043E\u0439 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		PortalSetupCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043F\u043E\u0440\u0442\u0430\u043B\u0430",
		PortalOrganizationalRolesLinkCaption: "\u041E\u0440\u0433\u0430\u043D\u0438\u0437\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0435 \u0440\u043E\u043B\u0438 \u0434\u043B\u044F external \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0435\u0439",
		PortalFunctionalRolesLinkCaption: "\u0424\u0443\u043D\u043A\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u044B\u0435 \u0440\u043E\u043B\u0438 \u0434\u043B\u044F external \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0435\u0439",
		WebServicesCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0438\u043D\u0442\u0435\u0433\u0440\u0430\u0446\u0438\u0438 \u0441 \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441\u0430\u043C\u0438",
		MLModelSectionCaption: "\u041C\u043E\u0434\u0435\u043B\u0438 \u043C\u0430\u0448\u0438\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u0443\u0447\u0435\u043D\u0438\u044F",
		UseOldOpportunityManagementProcess: "\u041D\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441 \u043A\u043E\u0440\u043F\u043E\u0440\u0430\u0442\u0438\u0432\u043D\u044B\u0445 \u043F\u0440\u043E\u0434\u0430\u0436 7.8",
		UseOpportunityManagementProcess780: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441 \u043A\u043E\u0440\u043F\u043E\u0440\u0430\u0442\u0438\u0432\u043D\u044B\u0445 \u043F\u0440\u043E\u0434\u0430\u0436 7.8",
		SocialLeadGenLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0435\u0440\u0432\u0438\u0441\u0430 \u043B\u0438\u0434\u043E\u0433\u0435\u043D\u0438\u0440\u0430\u0446\u0438\u0438 \u0441\u043E\u0446\u0438\u0430\u043B\u044C\u043D\u044B\u0445 \u0441\u0435\u0442\u0435\u0439",
		ChangeLogLinkCaption: "\u0416\u0443\u0440\u043D\u0430\u043B \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0439",
		ChatSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0447\u0430\u0442\u043E\u0432",
		ExtAccessSectionCaption: "\u0414\u043E\u0441\u0442\u0443\u043F \u0432\u043D\u0435\u0448\u043D\u0438\u0445 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u0439",
		InstallBonusInSalesCaption: "\u0423\u0441\u0442\u0430\u043D\u043E\u0432\u043A\u0430 \u043F\u0430\u043A\u0435\u0442\u0430 \u0022\u0421\u0438\u0441\u0442\u0435\u043C\u0430 \u043C\u043E\u0442\u0438\u0432\u0430\u0446\u0438\u0438\u0022",
		LicenseManagerLinkCaption: "\u041C\u0435\u043D\u0435\u0434\u0436\u0435\u0440 \u043B\u0438\u0446\u0435\u043D\u0437\u0438\u0439",
		OAuthSectionCaption: "\u0418\u043D\u0442\u0435\u0433\u0440\u0430\u0446\u0438\u0438 \u0441 OAuth 2.0 \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u0435\u0439",
		PortalOrganizationSetupLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u043F\u0440\u043E\u0444\u0438\u043B\u044F \u043E\u0440\u0433\u0430\u043D\u0438\u0437\u0430\u0446\u0438\u0438",
		ReportSetupLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043E\u0442\u0447\u0435\u0442\u043E\u0432",
		SspProfileContactSetupLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u043F\u0440\u043E\u0444\u0438\u043B\u044F external \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F",
		TrackingSettingsLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u0435\u0440\u0432\u0438\u0441\u0430 \u0442\u0440\u0435\u043A\u0438\u043D\u0433\u0430 \u0441\u043E\u0431\u044B\u0442\u0438\u0439",
		UpdateBonusInSalesCaption: "\u041E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u0435 \u043F\u0430\u043A\u0435\u0442\u0430 \u0022\u0421\u0438\u0441\u0442\u0435\u043C\u0430 \u043C\u043E\u0442\u0438\u0432\u0430\u0446\u0438\u0438\u0022",
		SsoSettingsCaption: "\u041A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u044F Single Sign On",
		SetupAppearanceLinkCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0432\u043D\u0435\u0448\u043D\u0435\u0433\u043E \u0432\u0438\u0434\u0430",
		LicOperationAccessDeniedMessage: "\u0414\u0430\u043D\u043D\u0430\u044F \u0444\u0443\u043D\u043A\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u043E\u0441\u0442\u044C \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u043D\u0430 \u0434\u043B\u044F \u0432\u0430\u0448\u0435\u0433\u043E \u043F\u043B\u0430\u043D\u0430 \u043F\u043E\u0434\u043F\u0438\u0441\u043A\u0438 Creatio. \u0418\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u043F\u043B\u0430\u043D \u043D\u0430 Enterprise, \u0447\u0442\u043E\u0431\u044B \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u044C \u0434\u043E\u0441\u0442\u0443\u043F \u043A \u0444\u0443\u043D\u043A\u0446\u0438\u043E\u043D\u0430\u043B\u044C\u043D\u043E\u0441\u0442\u0438.",
		EditionsComparePageButtonCaption: "\u0421\u0440\u0430\u0432\u043D\u0438\u0442\u044C \u0432\u0441\u0435 \u043F\u043B\u0430\u043D\u044B"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		ProcessIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "ProcessIcon",
				hash: "b870c39ce0673f575b49db8cf315a1b1",
				resourceItemExtension: ".png"
			}
		},
		UsersIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "UsersIcon",
				hash: "8d716f8ff873e6183b70e12acef52ed7",
				resourceItemExtension: ".png"
			}
		},
		IntegrationIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "IntegrationIcon",
				hash: "3a3f3e8dea075ec8a773ee93f89d8918",
				resourceItemExtension: ".png"
			}
		},
		SystemSettingsIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "SystemSettingsIcon",
				hash: "1b7a59b9bf01a6d7091db009024a69cc",
				resourceItemExtension: ".png"
			}
		},
		SystemViewIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "SystemViewIcon",
				hash: "587e3a468d4877f183b6f1d33155ee98",
				resourceItemExtension: ".png"
			}
		},
		ConfigurationIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "ConfigurationIcon",
				hash: "94c8818f373f68c97a69fb32bd19da6f",
				resourceItemExtension: ".png"
			}
		},
		TwitterIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "TwitterIcon",
				hash: "43ef41cba1450cadf1eb65f93a7b0d25",
				resourceItemExtension: ".svg"
			}
		},
		FacebookIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "FacebookIcon",
				hash: "27130fdf43a9e78bf3f36e626a3e1781",
				resourceItemExtension: ".svg"
			}
		},
		GoogleIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "GoogleIcon",
				hash: "b2c07233caac08d4f65769e921a4d232",
				resourceItemExtension: ".svg"
			}
		},
		YoutubeIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "YoutubeIcon",
				hash: "16f3900d772354c3ce0af6c68f0c5226",
				resourceItemExtension: ".svg"
			}
		},
		LinkedinIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "LinkedinIcon",
				hash: "76b4011e0b60d2e1c264706026ba938f",
				resourceItemExtension: ".svg"
			}
		},
		AcademyBanner: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "AcademyBanner",
				hash: "b34cc15228761c3274d07b3c4a906382",
				resourceItemExtension: ".svg"
			}
		},
		Arrow: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "Arrow",
				hash: "c23876260284897a31b25a1d37eeaf45",
				resourceItemExtension: ".png"
			}
		},
		BPMSbanner: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "BPMSbanner",
				hash: "df7ec875ea9036874b5d612fa331aabf",
				resourceItemExtension: ".jpg"
			}
		},
		playBtn: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "playBtn",
				hash: "d0b9ed0adb16bd51facb13c3bd92b555",
				resourceItemExtension: ".png"
			}
		},
		playBtnActive: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "playBtnActive",
				hash: "5225f87b6257a3dd4a411ebf44702bd9",
				resourceItemExtension: ".png"
			}
		},
		AndroidIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "AndroidIcon",
				hash: "385d1b4f9e6d5d385239801b140a8c09",
				resourceItemExtension: ".svg"
			}
		},
		IosIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "IosIcon",
				hash: "83443f1c07e583d16de6a799b8a8dd54",
				resourceItemExtension: ".svg"
			}
		},
		CommunityIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "CommunityIcon",
				hash: "d4e1e0d9b779b248a17771e7f80aa52c",
				resourceItemExtension: ".svg"
			}
		},
		WindowsIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "WindowsIcon"
			}
		},
		InstallExtensionsIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "InstallExtensionsIcon",
				hash: "12b99eabcdf7d342d149012ff0f0f550",
				resourceItemExtension: ".svg"
			}
		},
		MarketplaceIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "MarketplaceIcon",
				hash: "79bf31568c3cc50782a3860592d58825",
				resourceItemExtension: ".svg"
			}
		},
		GettingStartedIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "GettingStartedIcon",
				hash: "670d3ae90708491a0350e89d73bca20f",
				resourceItemExtension: ".svg"
			}
		},
		SdkIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "SdkIcon",
				hash: "25fb98ad79924e87ec09066cb96e7abe",
				resourceItemExtension: ".svg"
			}
		},
		PortalIcon: {
			source: 3,
			params: {
				schemaName: "SystemDesigner",
				resourceItemName: "PortalIcon",
				hash: "4a9215e8670b6191ef288a19577c53e3",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});