﻿define("FindContactsInSocialNetworksModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CloseButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ViewButtonCaption: "\u041F\u0440\u043E\u0441\u043C\u043E\u0442\u0440\u0435\u0442\u044C",
		CreateNewContactButtonCaption: "\u0421\u043E\u0437\u0434\u0430\u0442\u044C \u043A\u043E\u043D\u0442\u0430\u043A\u0442",
		FindButtonCaption: "\u041D\u0430\u0439\u0442\u0438",
		AllSocialNetworksCaption: "\u0412\u0441\u0435 \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u044B",
		SocialAccountColCaption: "\u0418\u043C\u044F \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F",
		SocialMediaColCaption: "\u0421\u043E\u0446. \u0441\u0435\u0442\u044C",
		SearchEditLabelCaption: "\u041F\u043E\u0438\u0441\u043A \u0432 \u0441\u043E\u0446\u0438\u0430\u043B\u044C\u043D\u044B\u0445 \u0441\u0435\u0442\u044F\u0445",
		FilterSocialNetworksLabelCaption: "\u041E\u0442\u0444\u0438\u043B\u044C\u0442\u0440\u043E\u0432\u0430\u0442\u044C \u0440\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u044B \u043F\u043E\u0438\u0441\u043A\u0430 \u043F\u043E \u0441\u043E\u0446\u0438\u0430\u043B\u044C\u043D\u044B\u043C \u0441\u0435\u0442\u044F\u043C",
		ResultsLabelCaption: "\u0420\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442\u044B \u043F\u043E\u0438\u0441\u043A\u0430",
		OKButtonCaption: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C",
		SocialNetworkAuthError: "\u041D\u0435 \u0443\u0434\u0430\u0435\u0442\u0441\u044F \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u0438\u0437 \u0441\u043E\u0446. \u0441\u0435\u0442\u0438. \u041D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0432\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u044E \u0432 ",
		SocialNetworkError: "\u041D\u0435 \u0443\u0434\u0430\u0435\u0442\u0441\u044F \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u0438\u0437 \u0441\u043E\u0446. \u0441\u0435\u0442\u0438 ",
		InfoCaption: "\u0418\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		WindowCaption: "\u041D\u0430\u0439\u0442\u0438 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u044B \u0432 \u0441\u043E\u0446\u0438\u0430\u043B\u044C\u043D\u044B\u0445 \u0441\u0435\u0442\u044F\u0445",
		SocialNetworksError: "\u041D\u0435 \u0443\u0434\u0430\u0435\u0442\u0441\u044F \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u044C \u0434\u0430\u043D\u043D\u044B\u0435 \u0438\u0437 \u0441\u043E\u0446. \u0441\u0435\u0442\u0435\u0439. \u041D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0432\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0430\u0432\u0442\u043E\u0440\u0438\u0437\u0430\u0446\u0438\u044E \u0432 "
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		facebookimg: {
			source: 3,
			params: {
				schemaName: "FindContactsInSocialNetworksModule",
				resourceItemName: "facebookimg",
				hash: "986941b1c64996f2937ed971b927da51",
				resourceItemExtension: ".png"
			}
		},
		twitterimg: {
			source: 3,
			params: {
				schemaName: "FindContactsInSocialNetworksModule",
				resourceItemName: "twitterimg",
				hash: "8a35f2fdd09288dad79f97f2eadc74e6",
				resourceItemExtension: ".png"
			}
		},
		linkedinimg: {
			source: 3,
			params: {
				schemaName: "FindContactsInSocialNetworksModule",
				resourceItemName: "linkedinimg",
				hash: "a912b4ec84c1c51b934816b0418dda52",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});