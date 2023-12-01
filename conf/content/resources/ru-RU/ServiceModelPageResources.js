define("ServiceModelPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PageCaption: "\u0421\u0435\u0440\u0432\u0438\u0441\u043D\u043E-\u0440\u0435\u0441\u0443\u0440\u0441\u043D\u0430\u044F \u043C\u043E\u0434\u0435\u043B\u044C",
		ApplyButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u043D\u0438\u0442\u044C",
		CleanButtonCaption: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C",
		DependencyCategoryContainerCaption: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u0438 \u0441\u0432\u044F\u0437\u0435\u0439",
		IsInfluenceCategoryCaption: "\u0412\u043B\u0438\u044F\u044E\u0449\u0430\u044F",
		IsDependenceCategoryCaption: "\u0417\u0430\u0432\u0438\u0441\u0438\u043C\u0430\u044F",
		ObjectTypesContainerCaption: "\u0422\u0438\u043F\u044B \u043E\u0431\u044A\u0435\u043A\u0442\u043E\u0432",
		IsConfItemTypeCaption: "\u041A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0435 \u0435\u0434\u0438\u043D\u0438\u0446\u044B",
		IsServiceItemTypeCaption: "\u0421\u0435\u0440\u0432\u0438\u0441\u044B",
		StatusContainerCaption: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435 \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		IsActiveStatusCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u043E\u0435",
		IsInactiveStatusCaption: "\u041D\u0435\u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0435",
		ConfItemStatusContainerCaption: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u044F \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0445 \u0435\u0434\u0438\u043D\u0438\u0446",
		AddConfItemStatusButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435",
		ConfItemCategoryCaption: "\u041A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u0438 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0445 \u0435\u0434\u0438\u043D\u0438\u0446",
		AddConfItemCategoryButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u0430\u0442\u0435\u0433\u043E\u0440\u0438\u044E",
		ConfItemTypeCaption: "\u0422\u0438\u043F\u044B \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0445 \u0435\u0434\u0438\u043D\u0438\u0446",
		AddConfItemTypeButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0442\u0438\u043F",
		ConfItemModelCaption: "\u041C\u043E\u0434\u0435\u043B\u0438 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u044B\u0445 \u0435\u0434\u0438\u043D\u0438\u0446",
		AddConfItemModelButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043C\u043E\u0434\u0435\u043B\u044C"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "AddButtonImage",
				hash: "caced161aa399aee1ed279cd006e14cd",
				resourceItemExtension: ".png"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ServiceModelPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});