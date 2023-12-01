define("ServiceModelPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PageCaption: "Service and resource model",
		ApplyButtonCaption: "Apply",
		CleanButtonCaption: "Clear",
		DependencyCategoryContainerCaption: "Connection categories",
		IsInfluenceCategoryCaption: "Influencer",
		IsDependenceCategoryCaption: "Dependent",
		ObjectTypesContainerCaption: "Property types",
		IsConfItemTypeCaption: "Configuration items",
		IsServiceItemTypeCaption: "Services",
		StatusContainerCaption: "Object status",
		IsActiveStatusCaption: "Active",
		IsInactiveStatusCaption: "Inactive",
		ConfItemStatusContainerCaption: "CI statuses",
		AddConfItemStatusButtonCaption: "New status",
		ConfItemCategoryCaption: "CI categories",
		AddConfItemCategoryButtonCaption: "New category",
		ConfItemTypeCaption: "CI types",
		AddConfItemTypeButtonCaption: "New type",
		ConfItemModelCaption: "CI models",
		AddConfItemModelButtonCaption: "New model"
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