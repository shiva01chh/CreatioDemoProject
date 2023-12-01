﻿define("OAuthAppScopePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ActionButtonCaption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		ColumnFilterInvalidFormatException: "\u041D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u0430 \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u044F \u043F\u043E \u043A\u043E\u043B\u043E\u043D\u043A\u0435 {0}",
		RequiredFieldIsEmptyCaption: "\u0414\u043B\u044F \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0438, \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u043E\u0435 \u043F\u043E\u043B\u0435 {0}",
		NewRecordPageCaptionSuffix: ": \u041D\u043E\u0432\u0430\u044F \u0437\u0430\u043F\u0438\u0441\u044C",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		DelayExecutionButtonCaption: "\u0412\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043F\u043E\u0437\u0436\u0435",
		ProcessEntryPointButtonCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u043E \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0443",
		CloseButtonCaption: "\u0417\u0430\u043A\u0440\u044B\u0442\u044C",
		ViewOptionsButtonCaption: "\u0412\u0438\u0434",
		OpenSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		FieldValidationError: "\u041F\u043E\u043B\u0435 \u0022{0}\u0022: {1}",
		PrintButtonCaption: "\u041F\u0435\u0447\u0430\u0442\u044C",
		OpenListSettingsCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0441\u043F\u0438\u0441\u043A\u0430",
		ProsessButtonCaption: "\u0417\u0430\u043F\u0443\u0441\u0442\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		BeginProcessButtonMenuItemCaption: "\u041D\u0430\u0447\u0430\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		ContinueProcessButtonMenuItemCaption: "\u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C \u043F\u0440\u043E\u0446\u0435\u0441\u0441",
		QuickAddButtonHint: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0432\u044F\u0437\u0430\u043D\u043D\u0443\u044E \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u044C",
		TabControlScrollLeftHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043B\u0435\u0432\u043E",
		TabControlScrollRightHint: "\u041F\u0440\u043E\u043A\u0440\u0443\u0442\u0438\u0442\u044C \u0432\u043F\u0440\u0430\u0432\u043E",
		FieldsGroupCollapseButtonHint: "\u0421\u0432\u0435\u0440\u043D\u0443\u0442\u044C/\u0420\u0430\u0437\u0432\u0435\u0440\u043D\u0443\u0442\u044C",
		FieldLockHint: "\u041D\u0435\u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u0443\u0435\u043C\u043E\u0435 \u043F\u043E\u043B\u0435",
		ClearButtonHint: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043F\u043E\u043B\u0435",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u043D\u043E\u0432\u044B\u0439 \u0434\u0438\u0437\u0430\u0439\u043D\u0435\u0440 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipCaption: "\u0412 Creatio 7.8 \u0443\u043B\u0443\u0447\u0448\u0435\u043D \u0432\u043D\u0435\u0448\u043D\u0438\u0439 \u0432\u0438\u0434 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		HeaderTipContent: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B\u043E\u0441\u044C \u0440\u0430\u0441\u043F\u043E\u043B\u043E\u0436\u0435\u043D\u0438\u0435 \u043F\u043E\u043B\u0435\u0439 \u043D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0435. \u0417\u0434\u0435\u0441\u044C \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u044E\u0442\u0441\u044F \u0442\u043E\u043B\u044C\u043A\u043E \u0442\u0435 \u043F\u043E\u043B\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u044B\u043B\u0438 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D\u044B \u0432\u0430\u043C\u0438 \u0432 \u0445\u043E\u0434\u0435 \u0440\u0430\u0431\u043E\u0442\u044B \u0441\n\u0441\u0438\u0441\u0442\u0435\u043C\u043E\u0439. \u0414\u043B\u044F \u0443\u0434\u043E\u0431\u0441\u0442\u0432\u0430 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043F\u0435\u0440\u0435\u043C\u0435\u0441\u0442\u0438\u0442\u044C \u044D\u0442\u0438 \u043F\u043E\u043B\u044F \u0432 \u043F\u0440\u043E\u0444\u0438\u043B\u044C \u0437\u0430\u043F\u0438\u0441\u0438 (\u0441\u043B\u0435\u0432\u0430) \u0438\u043B\u0438 \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u044C \u0432\u043A\u043B\u0430\u0434\u043E\u043A \u0441 \u043F\u043E\u043C\u043E\u0449\u044C\u044E \u0414\u0438\u0437\u0430\u0439\u043D\u0435\u0440\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B.",
		HeaderTipDesignerBtnCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0435\u0439\u0447\u0430\u0441",
		HeaderTipAcademyBtnCaption: "\u0423\u0437\u043D\u0430\u0442\u044C \u0431\u043E\u043B\u044C\u0448\u0435 \u043D\u0430 \u0410\u043A\u0430\u0434\u0435\u043C\u0438\u0438",
		AcademyDesignerUrl: "https://academy.terrasoft.ru/documents/sales-enterprise/7-8-0/kak-nastroit-polya-stranicy#XREF_49522",
		HeaderTipNotShowBtnCaption: "\u0411\u043E\u043B\u044C\u0448\u0435 \u043D\u0435 \u043F\u043E\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u044D\u0442\u043E \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435",
		PageContainsUnsavedChanges: "\u0423 \u0432\u0430\u0441 \u0435\u0441\u0442\u044C \u043D\u0435\u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u043D\u044B\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0431\u0443\u0434\u0443\u0442 \u0443\u0442\u0435\u0440\u044F\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		CanCustomizeWarning: "\u041E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u0435 {0} \u0430\u0442\u0440\u0438\u0431\u0443\u0442, \u0432\u043C\u0435\u0441\u0442\u043E \u043F\u0435\u0440\u0435\u0433\u0440\u0443\u0437\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0439 \u0444\u0443\u043D\u043A\u0446\u0438\u0435\u0439 \u043C\u0435\u0442\u043E\u0434\u0430 {1}"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "OAuthAppScopePage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});