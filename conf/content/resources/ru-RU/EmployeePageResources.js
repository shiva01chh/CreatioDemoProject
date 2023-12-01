﻿define("EmployeePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CareerTabCaption: "\u041A\u0430\u0440\u044C\u0435\u0440\u0430",
		CareerGeneralInfoGroupCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		NameCaption: "\u0424\u0418\u041E",
		BaseInfoTabCaption: "\u041E\u0441\u043D\u043E\u0432\u043D\u0430\u044F \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F",
		PhoneCaption: "\u0420\u0430\u0431\u043E\u0447\u0438\u0439 \u0442\u0435\u043B\u0435\u0444\u043E\u043D",
		EmailCaption: "Email",
		BirthDateCaption: "\u0414\u0430\u0442\u0430 \u0440\u043E\u0436\u0434\u0435\u043D\u0438\u044F",
		GenderCaption: "\u041F\u043E\u043B",
		DateIsLessThanDateMessageTemplate: "\u0417\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u044F \u0022{1}\u0022 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u043F\u043E\u043B\u044F \u0022{0}\u0022",
		UserIsActiveCaption: "\u0410\u043A\u0442\u0438\u0432\u0435\u043D",
		UserNameCaption: "\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C",
		AdministrationTabCaption: "\u0410\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435",
		SysAdminUnitGeneralInfoGroupCaption: "\u0418\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u044F \u043E \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0435",
		ContactTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435, \u0437\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u043F\u0440\u0438 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u0438 \u0437\u0430\u043F\u0438\u0441\u0438",
		PhoneTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0417\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u0438 \u00AB\u0421\u0440\u0435\u0434\u0441\u0442\u0432\u0430 \u0441\u0432\u044F\u0437\u0438\u00BB \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430 \u0438\u043B\u0438 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		EmailTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0417\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u0438 \u00AB\u0421\u0440\u0435\u0434\u0441\u0442\u0432\u0430 \u0441\u0432\u044F\u0437\u0438\u00BB \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430 \u0438\u043B\u0438 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		BirthDateTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0417\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u043D\u0430 \u0434\u0435\u0442\u0430\u043B\u0438 \u00AB\u0417\u043D\u0430\u043C\u0435\u043D\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u0435 \u0441\u043E\u0431\u044B\u0442\u0438\u044F\u00BB \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430 \u0438\u043B\u0438 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430",
		GenderTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0417\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430 ",
		SysAdminUnitTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0417\u0430\u043F\u043E\u043B\u043D\u044F\u0435\u0442\u0441\u044F \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438, \u0435\u0441\u043B\u0438 \u0434\u043B\u044F \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430 \u0432 \u0441\u0438\u0441\u0442\u0435\u043C\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C",
		UserIsActiveTipMessage: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435. \u0418\u0437\u043C\u0435\u043D\u044F\u0435\u0442\u0441\u044F \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u00AB\u041F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u0438\u00BB"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		DefaultPhoto: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "DefaultPhoto",
				hash: "ed12916b583407914f22afb2a4581d7f",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "EmployeePage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});