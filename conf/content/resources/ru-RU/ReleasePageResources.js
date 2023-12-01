define("ReleasePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		RegistrationInformationTabCaption: "\u0420\u0435\u0433\u0438\u0441\u0442\u0440\u0430\u0446\u0438\u043E\u043D\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		PlanningImplementationTabCaption: "\u041F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0438 \u0440\u0435\u0430\u043B\u0438\u0437\u0430\u0446\u0438\u044F",
		CloseTabCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u0438\u0435",
		NotesFilesTabCaption: "\u0424\u0430\u0439\u043B\u044B \u0438 \u043F\u0440\u0438\u043C\u0435\u0447\u0430\u043D\u0438\u044F",
		NameCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		NumberCaption: "\u041D\u043E\u043C\u0435\u0440",
		DescriptionCaption: "\u041E\u043F\u0438\u0441\u0430\u043D\u0438\u0435",
		StatusCaption: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435",
		PriorityCaption: "\u041F\u0440\u0438\u043E\u0440\u0438\u0442\u0435\u0442",
		TypeCaption: "\u0422\u0438\u043F",
		ScheduledReleaseDateCaption: "\u041F\u043B\u0430\u043D. \u0434\u0430\u0442\u0430 \u0440\u0435\u043B\u0438\u0437\u0430",
		PlannedLaborCaption: "\u041F\u043B\u0430\u043D. \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B (\u0447\u0430\u0441\u043E\u0432)",
		ReleasedOnCaption: "\u0424\u0430\u043A\u0442. \u0434\u0430\u0442\u0430 \u0440\u0435\u043B\u0438\u0437\u0430",
		DevelopmentFinishedOnCaption: "\u0424\u0430\u043A\u0442. \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0435 \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u043A\u0438",
		TestingFinishedOnCaption: "\u0424\u0430\u043A\u0442. \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0435 \u0442\u0435\u0441\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F",
		DeploymentFinishedOnCaption: "\u0424\u0430\u043A\u0442. \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0435 \u0440\u0430\u0437\u0432\u0435\u0440\u0442\u044B\u0432\u0430\u043D\u0438\u044F",
		ActualLaborCaption: "\u0424\u0430\u043A\u0442. \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B",
		ActualDevelopmentLaborCaption: "\u0424\u0430\u043A\u0442. \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B \u043D\u0430 \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u043A\u0443",
		ActualTestingLaborCaption: "\u0424\u0430\u043A\u0442. \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B \u043D\u0430 \u0442\u0435\u0441\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		ActualDeploymentLaborCaption: "\u0424\u0430\u043A\u0442. \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B \u043D\u0430 \u0440\u0430\u0437\u0432\u0435\u0440\u0442\u044B\u0432\u0430\u043D\u0438\u0435",
		ReleaseGroupCaption: "\u0424\u0430\u043A\u0442\u0438\u0447\u0435\u0441\u043A\u0438\u0435 \u0441\u0440\u043E\u043A\u0438",
		LaborGroupCaption: "\u0424\u0430\u043A\u0442\u0438\u0447\u0435\u0441\u043A\u0438\u0435 \u0442\u0440\u0443\u0434\u043E\u0437\u0430\u0442\u0440\u0430\u0442\u044B"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ReleasePage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});