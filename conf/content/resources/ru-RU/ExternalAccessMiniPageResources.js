﻿define("ExternalAccessMiniPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		EmptySettingsMessage: "\u0414\u043B\u044F \u043F\u0440\u0435\u0434\u043E\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0434\u043E\u0441\u0442\u0443\u043F\u0430 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0437\u0430\u043F\u043E\u043B\u043D\u0438\u0442\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438: {0}",
		InfoLabelCaption: "\u0412\u044B \u043F\u0440\u0435\u0434\u043E\u0441\u0442\u0430\u0432\u043B\u044F\u0435\u0442\u0435 \u0441\u043B\u0443\u0436\u0431\u0435 \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u043A\u0438 \u0422\u0435\u0440\u0440\u0430\u0441\u043E\u0444\u0442 \u0434\u043E\u0441\u0442\u0443\u043F \u043A \u0432\u0430\u0448\u0435\u043C\u0443 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044E. \u042D\u0442\u043E \u043F\u043E\u043C\u043E\u0436\u0435\u0442 \u0443\u0441\u043A\u043E\u0440\u0438\u0442\u044C \u0440\u0435\u0448\u0435\u043D\u0438\u0435 \u043E\u0431\u0440\u0430\u0449\u0435\u043D\u0438\u0439 \u0438 \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u0435 \u0442\u0435\u0445\u043D\u0438\u0447\u0435\u0441\u043A\u0438\u0445 \u0440\u0430\u0431\u043E\u0442. \u0423\u043A\u0430\u0436\u0438\u0442\u0435 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u043F\u0440\u0435\u0434\u043E\u0441\u0442\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0434\u043E\u0441\u0442\u0443\u043F\u0430. \u003Ca target=\u0022_blank\u0022 rel=\u0022noopener noreferrer\u0022 href=\u0022{0}\u0022\u003E\u041F\u043E\u0434\u0440\u043E\u0431\u043D\u0435\u0435...\u003C/a\u003E",
		IsDataIsolationEnabledTip: "\u0415\u0441\u043B\u0438 \u0432\u044B \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u043F\u0440\u0438\u0437\u043D\u0430\u043A, \u0442\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u043A\u0438 \u043F\u0440\u0438 \u043F\u043E\u0434\u043A\u043B\u044E\u0447\u0435\u043D\u0438\u0438 \u043D\u0435 \u0441\u043C\u043E\u0436\u0435\u0442 \u0443\u0432\u0438\u0434\u0435\u0442\u044C \u0432\u0430\u0448\u0438 \u0437\u0430\u043F\u0438\u0441\u0438 \u0432\u043E \u0432\u0441\u0435\u0445 \u0440\u0430\u0437\u0434\u0435\u043B\u0430\u0445 \u0441\u0438\u0441\u0442\u0435\u043C\u044B.",
		IsSystemOperationsRestrictedTip: "\u0415\u0441\u043B\u0438 \u0432\u044B \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u0435 \u043F\u0440\u0438\u0437\u043D\u0430\u043A, \u0442\u043E \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A \u043F\u043E\u0434\u0434\u0435\u0440\u0436\u043A\u0438 \u043F\u0440\u0438 \u043F\u043E\u0434\u043A\u043B\u044E\u0447\u0435\u043D\u0438\u0438 \u043D\u0435 \u0441\u043C\u043E\u0436\u0435\u0442 \u0432\u043D\u043E\u0441\u0438\u0442\u044C \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F \u0432 \u043A\u043E\u043D\u0444\u0438\u0433\u0443\u0440\u0430\u0446\u0438\u044E \u0441\u0438\u0441\u0442\u0435\u043C\u044B, \u0443\u043F\u0440\u0430\u0432\u043B\u044F\u0442\u044C \u0440\u043E\u043B\u044F\u043C\u0438 \u0438 \u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u0435\u043B\u044F\u043C\u0438, \u043D\u0430\u0441\u0442\u0440\u0430\u0438\u0432\u0430\u0442\u044C \u043F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430, \u0438\u0437\u043C\u0435\u043D\u044F\u0442\u044C \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u044B\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438, \u043D\u0430\u0441\u0442\u0440\u0430\u0438\u0432\u0430\u0442\u044C \u0431\u0438\u0437\u043D\u0435\u0441 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B \u0438 \u0442. \u0434.",
		DueDateCaption: "\u0414\u0430\u0442\u0430 \u0437\u0430\u043A\u0440\u044B\u0442\u0438\u044F \u0434\u043E\u0441\u0442\u0443\u043F\u0430",
		DueDateTip: "\u0414\u043E\u0441\u0442\u0443\u043F \u043A \u0432\u0430\u0448\u0435\u043C\u0443 \u043F\u0440\u0438\u043B\u043E\u0436\u0435\u043D\u0438\u044E \u0431\u0443\u0434\u0435\u0442 \u0437\u0430\u043A\u0440\u044B\u0442 \u0432 23:59 \u0443\u043A\u0430\u0437\u0430\u043D\u043D\u043E\u0439 \u0434\u0430\u0442\u044B."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "AddButtonImage",
				hash: "c15d635407f524f3bbe4f1810b82d315",
				resourceItemExtension: ".png"
			}
		},
		OpenCurrentEntityPageImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "OpenCurrentEntityPageImage",
				hash: "857178d6a8f045a025f4455df129833c",
				resourceItemExtension: ".svg"
			}
		},
		OpenEditModeImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "OpenEditModeImage",
				hash: "f4851d37a323f17fc7a7036b77314b24",
				resourceItemExtension: ".svg"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "CloseButtonImage",
				hash: "240cebbe345223f2c270c01be7949519",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "SaveButtonImage",
				hash: "9d83c749eceae73dbe461501d5b8df55",
				resourceItemExtension: ".svg"
			}
		},
		CancelButtonImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "CancelButtonImage",
				hash: "84b6270935b18aa084d202b7f50696b6",
				resourceItemExtension: ".svg"
			}
		},
		ConnectionsImage: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "ConnectionsImage",
				hash: "82a2caf9022ddbf42fc6455f36c3df03",
				resourceItemExtension: ".svg"
			}
		},
		AddConnectionIcon: {
			source: 3,
			params: {
				schemaName: "ExternalAccessMiniPage",
				resourceItemName: "AddConnectionIcon",
				hash: "dd20561c78ee86d5e1c4f3befac5cb48",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});