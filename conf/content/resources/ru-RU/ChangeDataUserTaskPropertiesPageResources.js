﻿define("ChangeDataUserTaskPropertiesPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessInformationText: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0434\u043B\u044F \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0437\u0430\u043F\u0438\u0441\u0435\u0439 \u0432 \u0443\u043A\u0430\u0437\u0430\u043D\u043D\u043E\u043C \u043E\u0431\u044A\u0435\u043A\u0442\u0435. \u0412\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u043E\u043F\u0440\u0435\u0434\u0435\u043B\u0438\u0442\u044C, \u043A\u0430\u043A\u0438\u0435 \u0438\u043C\u0435\u043D\u043D\u043E \u0437\u0430\u043F\u0438\u0441\u0438 \u0432\u044B\u0431\u0440\u0430\u043D\u043D\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u043D\u0443\u0436\u043D\u043E \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0432 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u0435. \u0422\u0430\u043A\u0436\u0435 \u0432\u044B \u043C\u043E\u0436\u0435\u0442\u0435 \u0432\u0432\u0435\u0441\u0442\u0438 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F, \u043D\u0430 \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438 \u0438\u0437\u043C\u0435\u043D\u044F\u0442\u0441\u044F \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u0432\u044B\u0431\u0440\u0430\u043D\u043D\u044B\u0445 \u043A\u043E\u043B\u043E\u043D\u043E\u043A.\n\n\u0415\u0441\u043B\u0438 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E, \u0447\u0442\u043E\u0431\u044B \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044C \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043B \u0437\u0430\u043F\u0438\u0441\u0438 \u0432\u0440\u0443\u0447\u043D\u0443\u044E, \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u044D\u043B\u0435\u043C\u0435\u043D\u0442 [\u041E\u0442\u043A\u0440\u044B\u0442\u044C \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u0443 \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F] \u0438 \u0432 \u043F\u043E\u043B\u0435 [\u0420\u0435\u0436\u0438\u043C \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F] \u0443\u043A\u0430\u0436\u0438\u0442\u0435 \u201C\u0420\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u0442\u044C \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u044E\u0449\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C\u201D. \u003Ca href=\u0022#\u0022 data-context-help-code=\u0022ChangeDataUserTaskPropertiesPage\u0022\u003E\u041F\u0435\u0440\u0435\u0439\u0442\u0438...\u003C/a\u003E",
		EntitySchemaSelectCaption: "\u0414\u0430\u043D\u043D\u044B\u0435 \u043A\u0430\u043A\u043E\u0433\u043E \u043E\u0431\u044A\u0435\u043A\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u044C?",
		FilterUnitCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u0442\u044C \u0432\u0441\u0435 \u0437\u0430\u043F\u0438\u0441\u0438, \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0449\u0438\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044E",
		ColumnValuesLabelCaption: "\u041A\u0430\u043A\u0438\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u044F \u043F\u043E\u043B\u0435\u0439 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u0434\u043B\u044F \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u043D\u044B\u0445 \u0437\u0430\u043F\u0438\u0441\u0435\u0439?",
		AddRecordColumnValuesButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043F\u043E\u043B\u0435"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ChangeDataUserTaskPropertiesPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});