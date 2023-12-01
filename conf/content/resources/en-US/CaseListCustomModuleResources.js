define("CaseListCustomModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddCaseButtonCaption: "New",
		PageCaption: "Search for similar cases",
		SearchSimilarTabCaption: "Similar records search",
		CaseTabCaption: "Parent case search",
		SelectButtonCaption: "Select",
		CaseDetailCaption: "Cases"
	};
	var parametersLocalizableStrings = {
		ServiceItem: "Case",
		TotalPages: "Number of pages",
		CurrentPageNumber: "Current page number",
		Result: "Result",
		PageTitle: "Page caption",
		HidePageNumbers: "Hide page numbers",
		CaseId: "Parameter 2"
	};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "InfoSpriteImage",
				hash: "344fae7f2f126afb5e90749fe4b77a54",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "CaseListCustomModule",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});