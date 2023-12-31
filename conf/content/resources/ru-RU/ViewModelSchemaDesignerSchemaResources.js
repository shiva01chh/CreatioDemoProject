﻿define("ViewModelSchemaDesignerSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		DesignerAddItemCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		DesignerSaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		DesignerCancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		DesignerAddGroupItemCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0433\u0440\u0443\u043F\u043F\u0443 \u043F\u043E\u043B\u0435\u0439",
		DesignerAddDetailItemCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0434\u0435\u0442\u0430\u043B\u044C",
		DesignerSortItemCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u043F\u043E\u0437\u0438\u0446\u0438\u044E",
		ExistingFieldsControlGroupCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u044E\u0449\u0443\u044E \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		NewFieldsControlGroupCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043D\u043E\u0432\u0443\u044E \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		DesignerUnregisteredDetailCaption: "\u0414\u0435\u0442\u0430\u043B\u044C \u043D\u0435 \u0437\u0430\u0440\u0435\u0433\u0438\u0441\u0442\u0440\u0438\u0440\u043E\u0432\u0430\u043D\u0430: {0}",
		DesignerDetailCaption: "\u0414\u0435\u0442\u0430\u043B\u044C: {0}",
		DesignerEditControlGroupCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0433\u0440\u0443\u043F\u043F\u044B \u043F\u043E\u043B\u0435\u0439",
		DesignerEditTitleCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A",
		DesignerEditTabCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u0432\u043A\u043B\u0430\u0434\u043A\u0438",
		NotUsedRequiredFieldsMessage: "\u041D\u0430 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0443 \u043D\u0435 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u044B \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0438\u0435 \u043E\u0431\u044F\u0437\u0430\u0442\u0435\u043B\u044C\u043D\u044B\u0435 \u043F\u043E\u043B\u044F:\n{0}",
		DesignerSettingsButtonCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430",
		DesignerRemoveButtonCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		DesignerErrorInfoTitleMessage: "\u041D\u0435\u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E \u043D\u0430\u0441\u0442\u0440\u043E\u0438\u0442\u044C \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0443.",
		DesignerErrorInfoDescriptionMessage: "\u0414\u043B\u044F \u0434\u0430\u043D\u043D\u043E\u0439 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B \u043D\u0435\u0442 \u0432\u043E\u0437\u043C\u043E\u0436\u043D\u043E\u0441\u0442\u0438 \u0432\u044B\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0443 \u043F\u0440\u0438 \u043F\u043E\u043C\u043E\u0449\u0438 \u043C\u0430\u0441\u0442\u0435\u0440\u0430. \u041E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443 \u0441\u0438\u0441\u0442\u0435\u043C\u044B",
		NewFieldsDisabledToolTipMessage: "\u0414\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u0435 \u043D\u043E\u0432\u044B\u0445 \u043F\u043E\u043B\u0435\u0439, \u0434\u043B\u044F \u0441\u0445\u0435\u043C, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u044F\u0432\u043B\u044F\u044E\u0442\u0441\u044F \u043F\u0440\u0435\u0434\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u0438\u0435\u043C \u0432 \u0411\u0414, \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u043D\u043E.  \u041E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443 \u0441\u0438\u0441\u0442\u0435\u043C\u044B.",
		NewFieldsDisabledMessage: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u043D\u044B",
		NewTabNameModalBox: "\u041D\u043E\u0432\u0430\u044F \u0432\u043A\u043B\u0430\u0434\u043A\u0430",
		NewWidgetsControlGroupCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0432\u0438\u0434\u0436\u0435\u0442",
		NewWidgetChartCaption: "\u0413\u0440\u0430\u0444\u0438\u043A",
		NewWidgetMetricCaption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u0435\u043B\u044C",
		NewWidgetGaugeCaption: "\u0428\u043A\u0430\u043B\u0430",
		NewWidgetListCaption: "\u0421\u043F\u0438\u0441\u043E\u043A",
		NewWidgetPipeLineCaption: "\u0412\u043E\u0440\u043E\u043D\u043A\u0430 \u043F\u0440\u043E\u0434\u0430\u0436",
		NewWidgetWebPageCaption: "Web-\u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0430",
		NewWidgetCustomWidgetCaption: "\u041F\u0440\u043E\u0438\u0437\u0432\u043E\u043B\u044C\u043D\u044B\u0439 \u0432\u0438\u0434\u0436\u0435\u0442",
		WidgetInNewSectionWarning: "\u0427\u0442\u043E\u0431\u044B \u0434\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0432\u0438\u0434\u0436\u0435\u0442, \u0441\u043D\u0430\u0447\u0430\u043B\u0430 \u0441\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u0435 \u0432\u0430\u0448 \u043D\u043E\u0432\u044B\u0439 \u0440\u0430\u0437\u0434\u0435\u043B",
		FieldUsedInRulesMessage: "\u041F\u043E\u043B\u0435 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0430\u0445:",
		RemoveBusinessRulesButtonCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0430",
		ColumnIsInheritedMessage: "\u041F\u043E\u043B\u0435 \u0441\u043E\u0437\u0434\u0430\u043D\u043E \u0432 \u0440\u043E\u0434\u0438\u0442\u0435\u043B\u044C\u0441\u043A\u043E\u0439 \u0441\u0445\u0435\u043C\u0435 \u0438 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u0443\u0434\u0430\u043B\u0435\u043D\u043E",
		RemoveColumnDesignItemMenuItemCaption: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		AddDataModelButton: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0434\u0430\u043D\u043D\u044B\u0445",
		WidgetsCaption: "\u0412\u0438\u0434\u0436\u0435\u0442\u044B",
		NewParameterCaption: "\u041D\u043E\u0432\u044B\u0439 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440",
		NewColumnCaption: "\u041D\u043E\u0432\u0430\u044F \u043A\u043E\u043B\u043E\u043D\u043A\u0430",
		ExistingColumnsCaption: "\u0421\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u044E\u0449\u0438\u0435 \u043A\u043E\u043B\u043E\u043D\u043A\u0438",
		ExistingParametersCaption: "\u0421\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u044E\u0449\u0438\u0435 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B",
		ElementsCaption: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442\u044B",
		PageElements: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442\u044B \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		DataModelEditMenuItem: "\u0420\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u0442\u044C",
		DataModelRemoveMenuItem: "\u0423\u0434\u0430\u043B\u0438\u0442\u044C",
		DataModelRemoveConfirmation: "\u0412\u044B \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u0442\u0435\u043B\u044C\u043D\u043E \u0445\u043E\u0442\u0438\u0442\u0435 \u0443\u0434\u0430\u043B\u0438\u0442\u044C \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0434\u0430\u043D\u043D\u044B\u0445: {0}?",
		DataModelBindsToColumnMessage: "\u041D\u0435 \u0443\u0434\u0430\u043B\u043E\u0441\u044C \u0443\u0434\u0430\u043B\u0438\u0442\u044C. \u041D\u0430 \u044D\u0442\u043E \u043F\u043E\u043B\u0435 \u0441\u0441\u044B\u043B\u0430\u0435\u0442\u0441\u044F \u0438\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0434\u0430\u043D\u043D\u044B\u0445",
		DataSourceUsedInRules: "\u0418\u0441\u0442\u043E\u0447\u043D\u0438\u043A \u0434\u0430\u043D\u043D\u044B\u0445 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0432 \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u0430\u0432\u0438\u043B\u0430\u0445:",
		DuplicateNameMessage: "\u042D\u043B\u0435\u043C\u0435\u043D\u0442 \u0441 \u0442\u0430\u043A\u0438\u043C \u0438\u043C\u0435\u043D\u0435\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442",
		SaveMessage: "\u0412\u0441\u0435 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0431\u0443\u0434\u0443\u0442 \u0441\u043E\u0445\u0440\u0430\u043D\u0435\u043D\u044B. \u041F\u0440\u043E\u0434\u043E\u043B\u0436\u0438\u0442\u044C?",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DesignerSettingsImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "DesignerSettingsImage",
				hash: "8f441a2b861d5114cbf2f5a753eff766",
				resourceItemExtension: ".png"
			}
		},
		DesignerRemoveImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "DesignerRemoveImage",
				hash: "1e5cff372195ec0d67d8514afe612fed",
				resourceItemExtension: ".png"
			}
		},
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "EmptyInfoImage",
				hash: "84410c143d7a4e3bfdbeda3db0408fca",
				resourceItemExtension: ".png"
			}
		},
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "InfoSpriteImage",
				hash: "15d4e5358792ef12351d7d6caa59dfb2",
				resourceItemExtension: ".png"
			}
		},
		AddDataModelButtonImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "AddDataModelButtonImage",
				hash: "6c51b373f7347e0d88add1b1f8d83c01",
				resourceItemExtension: ".svg"
			}
		},
		PageElementsImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "PageElementsImage",
				hash: "1b803497f291af03c0f61ca7fc67c995",
				resourceItemExtension: ".svg"
			}
		},
		PageParametersImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "PageParametersImage",
				hash: "a465b42219ca05e901f1a7700ddb346e",
				resourceItemExtension: ".svg"
			}
		},
		DataSource: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "DataSource",
				hash: "27fa920b92126f0bbd55da29b475511a",
				resourceItemExtension: ".svg"
			}
		},
		DataModelMenuImage: {
			source: 3,
			params: {
				schemaName: "ViewModelSchemaDesignerSchema",
				resourceItemName: "DataModelMenuImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});