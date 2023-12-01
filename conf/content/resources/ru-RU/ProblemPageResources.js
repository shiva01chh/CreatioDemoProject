define("ProblemPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GeneralInfoTabCaption: "\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		NameCaption: "\u0422\u0435\u043C\u0430",
		NumberCaption: "\u041D\u043E\u043C\u0435\u0440",
		AuthorCaption: "\u0410\u0432\u0442\u043E\u0440",
		TypeCaption: "\u0422\u0438\u043F",
		RegisteredOnCaption: "\u0414\u0430\u0442\u0430 \u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u0438",
		SymptomsCaption: "\u041F\u0440\u0438\u0437\u043D\u0430\u043A\u0438 (\u0421\u0438\u043C\u043F\u0442\u043E\u043C\u044B)",
		PriorityCaption: "\u041F\u0440\u0438\u043E\u0440\u0438\u0442\u0435\u0442",
		StatusCaption: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435",
		OwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439",
		GroupEditCaption: "\u0413\u0440\u0443\u043F\u043F\u0430 \u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0445",
		ConfItemCaption: "\u041A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u0430\u044F \u0435\u0434\u0438\u043D\u0438\u0446\u0430",
		SolutionCaption: "\u0420\u0435\u0448\u0435\u043D\u0438\u0435",
		GeneralInfoTabGroup: "\u0422\u0435\u043A\u0443\u0449\u0435\u0435 \u0441\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435",
		NotesFilesTabCaption: "\u0424\u0430\u0439\u043B\u044B",
		RelationsTabCaption: "\u0412\u0437\u0430\u0438\u043C\u043E\u0441\u0432\u044F\u0437\u0438",
		ServiceItemCaption: "\u0421\u0435\u0440\u0432\u0438\u0441",
		RelationsGroupCaption: "\u0412\u0437\u0430\u0438\u043C\u043E\u0441\u0432\u044F\u0437\u0438",
		SolutionPlanedOnCaption: "\u041F\u043B\u0430\u043D. \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u0435",
		SolutionProvidedOnCaption: "\u0424\u0430\u043A\u0442. \u0440\u0430\u0437\u0440\u0435\u0448\u0435\u043D\u0438\u0435",
		ClosureDateCaption: "\u0414\u0430\u0442\u0430 \u0437\u0430\u043A\u0440\u044B\u0442\u0438\u044F",
		SolutionTabCaption: "\u0420\u0435\u0448\u0435\u043D\u0438\u0435",
		ChangeCaption: "\u0418\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435",
		OpenServiceModelModuleByConfItemCaption: "\u041E\u0442\u043E\u0431\u0440\u0430\u0437\u0438\u0442\u044C \u0437\u0430\u0432\u0438\u0441\u0438\u043C\u043E\u0441\u0442\u0438 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u0438",
		OpenServiceModelModuleByServiceItemCaption: " \u041E\u0442\u043E\u0431\u0440\u0430\u0437\u0438\u0442\u044C \u0437\u0430\u0432\u0438\u0441\u0438\u043C\u043E\u0441\u0442\u0438 \u0441\u0435\u0440\u0432\u0438\u0441\u0430",
		ConfItemErrorMessage: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u0443\u044E \u0435\u0434\u0438\u043D\u0438\u0446\u0443",
		ServiceItemErrorMessage: "\u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u0441\u0435\u0440\u0432\u0438\u0441"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ProblemPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});