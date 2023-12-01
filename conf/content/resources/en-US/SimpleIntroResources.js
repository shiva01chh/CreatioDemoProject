define("SimpleIntroResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AcademyCaption: "Tutorials. Trainings. Testing",
		AccountSectionCaption: "Accounts",
		ActivitySectionCaption: "Activities",
		AnalyticsCaption: "Analytics",
		AndroidLabel: "Google play",
		AndroidUrl: "https://play.google.com/store/apps/details?id=com.creatio.mobileapp",
		BannerCaption: "Academy",
		BannerHint: "video, documents, system tests",
		BasisCaption: "General",
		ButtonCaption: "Go to",
		CommunityCaption: "Find answers",
		CommunityLabel: "Community",
		CommunityUrl: "http://www.creatio.com/community/",
		ContactSectionCaption: "Contacts",
		DashboardsSectionCaption: "Dashboards",
		EmployeeSectionCaption: "Employees",
		FacebookUrl: "https://facebook.creatio.com",
		FeedSectionCaption: "Feed",
		GettingStartedCaption: "Lightning fast implementation",
		GettingStartedLabel: "Getting started",
		GettingStartedUrl: "https://academy.creatio.com/getting-started",
		GoogleUrl: "https://plus.google.com/u/0/\u002BBpmonline_plus/posts",
		IosLabel: "App Store",
		IosUrl: "https://itunes.apple.com/us/app/bpmonline-mobile-7/id708432450?mt=8",
		KnowlegebaseSectionCaption: "Knowledge base",
		LinkedInUrl: "https://linkedin.creatio.com",
		MarketplaceCaption: "Add processes, templates and apps to your Creatio",
		MarketplaceLabel: "Marketplace",
		MarketplaceUrl: "https://marketplace.creatio.com/",
		MobileAppCaption: "Mobile version",
		ProfileCaption: "Profile",
		SdkCaption: "Developer\u0027s guide to Creatio platform",
		SectionDesignerCaption: "System designer",
		SettingsCaption: "Admin area",
		SocialAccountsCaption: "Connect with us",
		TwitterUrl: "https://twitter.creatio.com",
		WindowsLabel: "",
		WindowsUrl: "",
		YoutubeUrl: "https://youtube.creatio.com"
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
				hash: "d20c340712aea48adc656782fb3492a0",
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
				hash: "51369be2d145e1cc23b93799e6af99ad",
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
				hash: "6506739e5e7f198f44df61d8dfe26c11",
				resourceItemExtension: ".svg"
			}
		},
		SdkIcon: {
			source: 3,
			params: {
				schemaName: "SimpleIntro",
				resourceItemName: "SdkIcon",
				hash: "6b55d73e8805d47ab6c202ae2691010a",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});