﻿define("SupervisorSingleWindowSectionV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GridDataViewCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u043E\u0447\u0435\u0440\u0435\u0434\u0435\u0439",
		OpenQueueObjectLookupPageActionCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043E\u0440\u0442\u0438\u0440\u043E\u0432\u043A\u0438 \u0432 \u043E\u0447\u0435\u0440\u0435\u0434\u044F\u0445",
		UpdateQueuesActionCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043D\u0430\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u043E\u0447\u0435\u0440\u0435\u0434\u0435\u0439",
		QueueDataViewCaption: "\u041E\u0447\u0435\u0440\u0435\u0434\u0438",
		FillQueueCaption: "\u041D\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0447\u0435\u0440\u0435\u0434\u044C",
		QueuesUpdateProcessStarted: "\u041F\u0440\u043E\u0446\u0435\u0441\u0441 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u044F \u043E\u0447\u0435\u0440\u0435\u0434\u0435\u0439 \u0431\u044B\u043B \u0437\u0430\u043F\u0443\u0449\u0435\u043D.",
		QueuesUpdateProcessAlreadyStarted: "\u041F\u0440\u043E\u0446\u0435\u0441\u0441 \u043E\u0431\u043D\u043E\u0432\u043B\u0435\u043D\u0438\u044F \u043E\u0447\u0435\u0440\u0435\u0434\u0435\u0439 \u043D\u0435 \u0431\u044B\u043B \u0437\u0430\u043F\u0443\u0449\u0435\u043D, \u0442\u0430\u043A \u043A\u0430\u043A \u0443\u0436\u0435 \u0432\u044B\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		GridDataViewIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "GridDataViewIcon",
				hash: "12f77829d9767e323f3647457abf613a",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataViewIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "AnalyticsDataViewIcon",
				hash: "58d3027ef6c189ae1dd2c620dd8fd5aa",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		SettingsButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "SettingsButtonImage",
				hash: "a5df3ed1d5e5511e3e23dc1875cc8769",
				resourceItemExtension: ".png"
			}
		},
		scrollTopImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "scrollTopImage",
				hash: "2e74084b2581060d190bc92231e7bc12",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "EmptyInfoImage",
				hash: "84410c143d7a4e3bfdbeda3db0408fca",
				resourceItemExtension: ".png"
			}
		},
		EmptyFilterImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "EmptyFilterImage",
				hash: "7bf68ba9d5b686f7e46b0e23e89821bb",
				resourceItemExtension: ".png"
			}
		},
		EmptyGroupImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "EmptyGroupImage",
				hash: "be776f867efb6ad7e233612d77f19c12",
				resourceItemExtension: ".png"
			}
		},
		EmptyDynamicGroupImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "EmptyDynamicGroupImage",
				hash: "3d0048d99789c16848dbee2239555758",
				resourceItemExtension: ".png"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		QueuesSettingsDataViewIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "QueuesSettingsDataViewIcon",
				hash: "49e4c1018fc70bbc5d96973c48e80ebb",
				resourceItemExtension: ".png"
			}
		},
		ToggleSectionButton: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "ToggleSectionButton",
				hash: "7e47411934e85e6cf9834ebc72cff3e6",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "SortIcon",
				hash: "c0d8dfe7b1416f4c916f1d82523355ae",
				resourceItemExtension: ".svg"
			}
		},
		SummariesIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "SummariesIcon",
				hash: "f1f5f60ee306afca15aa461aac0fdad8",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		DataLoadFailedImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "DataLoadFailedImage",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		},
		AddTagsButtonImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "AddTagsButtonImage",
				hash: "c4683cf6e3fd3e28b391ff180a9c9c3d",
				resourceItemExtension: ".svg"
			}
		},
		ShowDuplicatesBtnImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "ShowDuplicatesBtnImage",
				hash: "fa120a8db42142879bc508b69c6a5993",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "SupervisorSingleWindowSectionV2",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});