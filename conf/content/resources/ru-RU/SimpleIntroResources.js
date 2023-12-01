define("SimpleIntroResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AcademyCaption: "\u0412\u0438\u0434\u0435\u043E\u043A\u0443\u0440\u0441\u044B. \u0422\u0440\u0435\u043D\u0438\u043D\u0433\u0438. \u0422\u0435\u0441\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		AccountSectionCaption: "\u041A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442\u044B",
		ActivitySectionCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0438",
		AnalyticsCaption: "\u0410\u043D\u0430\u043B\u0438\u0442\u0438\u043A\u0430",
		AndroidLabel: "Google play",
		AndroidUrl: "https://play.google.com/store/apps/details?id=com.creatio.mobileapp",
		BannerCaption: "\u0410\u043A\u0430\u0434\u0435\u043C\u0438\u044F",
		BannerHint: "\u0432\u0438\u0434\u0435\u043E, \u0434\u043E\u043A\u0443\u043C\u0435\u043D\u0442\u0430\u0446\u0438\u044F, \u0442\u0435\u0441\u0442\u044B \u043F\u043E \u0441\u0438\u0441\u0442\u0435\u043C\u0435",
		BasisCaption: "\u0411\u0430\u0437\u0438\u0441",
		ButtonCaption: "\u041F\u0435\u0440\u0435\u0439\u0442\u0438",
		CommunityCaption: "\u041D\u0430\u0439\u0442\u0438 \u043E\u0442\u0432\u0435\u0442\u044B",
		CommunityLabel: "\u0421\u043E\u043E\u0431\u0449\u0435\u0441\u0442\u0432\u043E",
		CommunityUrl: "http://www.community.terrasoft.ru/",
		ContactSectionCaption: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442\u044B",
		DashboardsSectionCaption: "\u0418\u0442\u043E\u0433\u0438",
		EmployeeSectionCaption: "\u0421\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0438",
		FacebookUrl: "https://facebook.bpmonline.com",
		FeedSectionCaption: "\u041B\u0435\u043D\u0442\u0430",
		GettingStartedCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u0443",
		GettingStartedLabel: "\u0411\u044B\u0441\u0442\u0440\u044B\u0439 \u0441\u0442\u0430\u0440\u0442",
		GettingStartedUrl: "https://academy.terrasoft.ru/getting-started",
		GoogleUrl: "https://plus.google.com/u/0/116164135679912261451/posts",
		IosLabel: "App Store",
		IosUrl: "https://itunes.apple.com/us/app/bpmonline-mobile-7/id708432450?mt=8",
		KnowlegebaseSectionCaption: "\u0411\u0430\u0437\u0430 \u0437\u043D\u0430\u043D\u0438\u0439",
		LinkedInUrl: "https://linkedin.bpmonline.com",
		MarketplaceCaption: "\u041A\u0430\u0442\u0430\u043B\u043E\u0433 \u0440\u0430\u0441\u0448\u0438\u0440\u0435\u043D\u0438\u0439 \u0438 \u0431\u0438\u0437\u043D\u0435\u0441-\u043F\u0440\u043E\u0446\u0435\u0441\u0441\u043E\u0432",
		MarketplaceLabel: "Marketplace",
		MarketplaceUrl: "https://marketplace.terrasoft.ru/",
		MobileAppCaption: "\u041C\u043E\u0431\u0438\u043B\u044C\u043D\u0430\u044F \u0432\u0435\u0440\u0441\u0438\u044F",
		ProfileCaption: "\u041F\u0440\u043E\u0444\u0438\u043B\u044C",
		SdkCaption: "\u0420\u0443\u043A\u043E\u0432\u043E\u0434\u0441\u0442\u0432\u043E \u043F\u043E \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u043A\u0435 \u043D\u0430 \u043F\u043B\u0430\u0442\u0444\u043E\u0440\u043C\u0435 Creatio",
		SectionDesignerCaption: "\u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		SettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430",
		SocialAccountsCaption: "\u0421\u0432\u044F\u0436\u0438\u0442\u0435\u0441\u044C \u0441 \u043D\u0430\u043C\u0438",
		TwitterUrl: "https://twitter.bpmonline.com",
		WindowsLabel: "",
		WindowsUrl: "",
		YoutubeUrl: "https://youtube.bpmonline.com"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BasisIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "BasisIcon",
				hash: "ccfff62c06041d371df216666fd52f2c",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "AnalyticsIcon",
				hash: "e0afa28e80304523ecb2c9f082f0e359",
				resourceItemExtension: ".png"
			}
		},
		SettingsIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "SettingsIcon",
				hash: "55e2588377df0f44825c672efe6ac3e6",
				resourceItemExtension: ".png"
			}
		},
		TwitterIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "TwitterIcon",
				hash: "7aa901beb76b86258ea1a804e0b044dc",
				resourceItemExtension: ".png"
			}
		},
		FacebookIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "FacebookIcon",
				hash: "98b7d23eeb74ed21d56089017a8b06fa",
				resourceItemExtension: ".png"
			}
		},
		GoogleIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "GoogleIcon",
				hash: "d774f7a8fef770f7c9ae4aaa8fdfa0f2",
				resourceItemExtension: ".png"
			}
		},
		YoutubeIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "YoutubeIcon",
				hash: "c1dd9961d661bebe88f6ca960f5fcd46",
				resourceItemExtension: ".png"
			}
		},
		LinkedinIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "LinkedinIcon",
				hash: "e4db49574f3282926a7f5959d7318d80",
				resourceItemExtension: ".png"
			}
		},
		AcademyBanner: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "AcademyBanner",
				hash: "b34cc15228761c3274d07b3c4a906382",
				resourceItemExtension: ".svg"
			}
		},
		Arrow: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "Arrow",
				hash: "c23876260284897a31b25a1d37eeaf45",
				resourceItemExtension: ".png"
			}
		},
		playBtn: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "playBtn",
				hash: "d0b9ed0adb16bd51facb13c3bd92b555",
				resourceItemExtension: ".png"
			}
		},
		playBtnActive: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "playBtnActive",
				hash: "5225f87b6257a3dd4a411ebf44702bd9",
				resourceItemExtension: ".png"
			}
		},
		AndroidIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "AndroidIcon",
				hash: "385d1b4f9e6d5d385239801b140a8c09",
				resourceItemExtension: ".svg"
			}
		},
		IosIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "IosIcon",
				hash: "83443f1c07e583d16de6a799b8a8dd54",
				resourceItemExtension: ".svg"
			}
		},
		CommunityIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "CommunityIcon",
				hash: "d4e1e0d9b779b248a17771e7f80aa52c",
				resourceItemExtension: ".svg"
			}
		},
		WindowsIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "WindowsIcon"
			}
		},
		MarketplaceIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "MarketplaceIcon",
				hash: "79bf31568c3cc50782a3860592d58825",
				resourceItemExtension: ".svg"
			}
		},
		GettingStartedIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "GettingStartedIcon",
				hash: "670d3ae90708491a0350e89d73bca20f",
				resourceItemExtension: ".svg"
			}
		},
		SdkIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "SdkIcon",
				hash: "25fb98ad79924e87ec09066cb96e7abe",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});