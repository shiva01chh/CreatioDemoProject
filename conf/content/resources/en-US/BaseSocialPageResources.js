﻿define("BaseSocialPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		HeaderCaption: "Populating with social networks data",
		NotesControlGroupCaption: "Notes",
		FacebookNotesTemplate: "\u003Cdiv\u003E\u003Cstrong\u003E\u003Cspan style=\u0022color:#46639f\u0022\u003E\u003Cspan style=\u0022font-family:segoe ui\u0022\u003EFacebook\u003C/span\u003E\u003C/span\u003E:\u003C/strong\u003E {0}\u003C/div\u003E\u003Cbr /\u003E"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		FacebookSmallIcon: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "FacebookSmallIcon",
				hash: "6014f7b84eec3781ba07b2483cd9ff12",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "BaseSocialPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});