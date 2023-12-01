define("ForecastMiniPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CreateCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		NewPlanCaption: "\u041D\u043E\u0432\u043E\u0435 \u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		EditPlanCaption: "\u0420\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		SetupHierarchyButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0438\u0435\u0440\u0430\u0440\u0445\u0438\u044E",
		AddingNewObject: "\u0414\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043D\u043E\u0432\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430",
		NewObjectCaptionTemplate: "\u041F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u043F\u043E \u0022{0}\u0022",
		EditColumnCaption: "\u041F\u043B\u0430\u043D",
		PrimaryDisplayColumnNotExistErrorMessage: "\u0414\u043B\u044F \u0432\u044B\u0431\u0440\u0430\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u043D\u0435 \u0443\u043A\u0430\u0437\u0430\u043D \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u0022\u041E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0435\u043C\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435\u0022. \u0414\u043B\u044F \u043E\u0441\u0443\u0449\u0435\u0441\u0442\u0432\u043B\u0435\u043D\u0438\u044F \u0432\u044B\u0431\u043E\u0440\u0430 \u0434\u0430\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430, \u0443\u043A\u0430\u0436\u0438\u0442\u0435 \u044D\u0442\u043E\u0442 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u043B\u0438\u0431\u043E \u043E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0432\u0430\u0448\u0435\u043C\u0443 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u043C\u0443 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443. ",
		MoreDetailsCaption: "\u0414\u0435\u0442\u0430\u043B\u044C\u043D\u0435\u0435 ...",
		MoreDetailsLink: "https://academy.terrasoft.ru/documents/technic-sdk/7-15/sozdanie-shemy-obekta",
		AutoCalculateCaption: "\u0410\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438\u0439 \u0440\u0430\u0441\u0447\u0435\u0442",
		AutoSnapshotCaption: "\u0415\u0436\u0435\u0434\u043D\u0435\u0432\u043D\u043E\u0435 \u0430\u0432\u0442\u043E\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u0435",
		AutoSnapshotTimeCaption: "\u0417\u0430\u043F\u0443\u0441\u043A\u0430\u0442\u044C \u0432",
		GeneralTabCaption: "\u041E\u0431\u0449\u0435\u0435",
		AutomationTabCaption: "\u0410\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0437\u0430\u0446\u0438\u044F"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "AddButtonImage",
				hash: "c15d635407f524f3bbe4f1810b82d315",
				resourceItemExtension: ".png"
			}
		},
		OpenCurrentEntityPageImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "OpenCurrentEntityPageImage",
				hash: "857178d6a8f045a025f4455df129833c",
				resourceItemExtension: ".svg"
			}
		},
		OpenEditModeImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "OpenEditModeImage",
				hash: "f4851d37a323f17fc7a7036b77314b24",
				resourceItemExtension: ".svg"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "CloseButtonImage",
				hash: "240cebbe345223f2c270c01be7949519",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "SaveButtonImage",
				hash: "9d83c749eceae73dbe461501d5b8df55",
				resourceItemExtension: ".svg"
			}
		},
		CancelButtonImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "CancelButtonImage",
				hash: "84b6270935b18aa084d202b7f50696b6",
				resourceItemExtension: ".svg"
			}
		},
		ConnectionsImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "ConnectionsImage",
				hash: "82a2caf9022ddbf42fc6455f36c3df03",
				resourceItemExtension: ".svg"
			}
		},
		AddConnectionIcon: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "AddConnectionIcon",
				hash: "dd20561c78ee86d5e1c4f3befac5cb48",
				resourceItemExtension: ".svg"
			}
		},
		HierarchyImage: {
			source: 3,
			params: {
				schemaName: "ForecastMiniPage",
				resourceItemName: "HierarchyImage",
				hash: "e87f10fdbad699749fb3e8140cf52bdb",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});