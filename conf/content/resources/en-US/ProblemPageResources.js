define("ProblemPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GeneralInfoTabCaption: "Problem profile",
		NameCaption: "Subject",
		NumberCaption: "Number",
		AuthorCaption: "Reporter",
		TypeCaption: "Type",
		RegisteredOnCaption: "Registration date",
		SymptomsCaption: "Description",
		PriorityCaption: "Priority",
		StatusCaption: "Status",
		OwnerCaption: "Assignee",
		GroupEditCaption: "Assigned team",
		ConfItemCaption: "Configuration item",
		SolutionCaption: "Resolution",
		GeneralInfoTabGroup: "Current status",
		NotesFilesTabCaption: "Files",
		RelationsTabCaption: "Connected to",
		ServiceItemCaption: "Service",
		RelationsGroupCaption: "Connected to",
		SolutionPlanedOnCaption: "Scheduled resolution time",
		SolutionProvidedOnCaption: "Actual resolution time",
		ClosureDateCaption: "Closed on",
		SolutionTabCaption: "Resolution",
		ChangeCaption: "Change",
		OpenServiceModelModuleByConfItemCaption: "Display the configuration dependencies",
		OpenServiceModelModuleByServiceItemCaption: " Display the service dependencies",
		ConfItemErrorMessage: "Specify a configuration item",
		ServiceItemErrorMessage: "Specify service"
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