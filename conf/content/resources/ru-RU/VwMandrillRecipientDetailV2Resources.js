﻿define("VwMandrillRecipientDetailV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddContactCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u043A\u043E\u043D\u0442\u0430\u043A\u0442",
		AddContactFolderCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0433\u0440\u0443\u043F\u043F\u0443 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432",
		WarningChangeRecipientList: "\u0418\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u0435 \u0441\u043F\u0438\u0441\u043A\u0430 \u043F\u043E\u043B\u0443\u0447\u0430\u0442\u0435\u043B\u0435\u0439 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u043E \u0442\u043E\u043B\u044C\u043A\u043E \u0434\u043B\u044F \u0437\u0430\u043F\u043B\u0430\u043D\u0438\u0440\u043E\u0432\u0430\u043D\u043D\u044B\u0445 \u0438\u043B\u0438 \u043F\u0440\u0438\u043E\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u044B\u0445 \u0440\u0430\u0441\u0441\u044B\u043B\u043E\u043A",
		RecipientsAddedMessage: "\u0414\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043E {0} \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432 \u0438\u0437 {1}",
		WarningDeleteRecipient: "\u0423\u0434\u0430\u043B\u0435\u043D\u043E {0} \u0438\u0437 {1} \u0437\u0430\u043F\u0438\u0441\u0435\u0439. \u041C\u043E\u0433\u0443\u0442 \u0431\u044B\u0442\u044C \u0443\u0434\u0430\u043B\u0435\u043D\u044B \u0442\u043E\u043B\u044C\u043A\u043E \u0437\u0430\u043F\u0438\u0441\u0438 \u0441 \u043E\u0442\u043A\u043B\u0438\u043A\u043E\u043C \u0022\u0412 \u043F\u043B\u0430\u043D\u0430\u0445\u0022, \u0022\u041E\u0448\u0438\u0431\u043A\u0430 \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0438\u0022 \u0438\u043B\u0438 \u0022\u041E\u0442\u043C\u0435\u043D\u0435\u043D\u043E\u0022",
		ContactsWillBeAdded: "\u0412 \u0430\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u044E \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u0431\u0443\u0434\u0443\u0442 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u044B \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u044B {0} \u0433\u0440\u0443\u043F\u043F. \u041F\u043E\u0441\u043B\u0435 \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u044F \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0449\u0435\u0435 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u043F\u043E\u044F\u0432\u0438\u0442\u0441\u044F \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u0438 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0439.",
		ContactsOfOneWillBeAdded: "\u0412 \u0430\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u044E \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u0431\u0443\u0434\u0443\u0442 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u044B \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u044B {0} \u0433\u0440\u0443\u043F\u043F\u044B. \u041F\u043E\u0441\u043B\u0435 \u0437\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u044F \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u0438\u044F \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0449\u0435\u0435 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u0435 \u043F\u043E\u044F\u0432\u0438\u0442\u0441\u044F \u0432 \u043E\u0431\u043B\u0430\u0441\u0442\u0438 \u0443\u0432\u0435\u0434\u043E\u043C\u043B\u0435\u043D\u0438\u0439.",
		UsageInSplitTestMessage: "\u0420\u0430\u0434\u0435\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u0430\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u0438 \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u0437\u0430\u0431\u043B\u043E\u043A\u0438\u0440\u043E\u0432\u0430\u043D\u043E. \u0420\u0430\u0441\u0441\u044B\u043B\u043A\u0430 \u0438\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0432 \u0441\u043F\u043B\u0438\u0442-\u0442\u0435\u0441\u0442\u0435.",
		InfoButtonDetailTriggerEmailMessage: "\u041F\u0435\u0440\u0441\u043E\u043D\u0430\u043B\u044C\u043D\u044B\u0435 \u043E\u0442\u043A\u043B\u0438\u043A\u0438 \u0431\u0443\u0434\u0443\u0442 \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0435\u043D\u044B \u043F\u043E\u0441\u043B\u0435 \u0438\u0445 \u043F\u043E\u043B\u0443\u0447\u0435\u043D\u0438\u044F \u043E\u0442 \u043F\u0440\u043E\u0432\u0430\u0439\u0434\u0435\u0440\u0430",
		InfoButtonDetailBulkEmailMessage: "\u0412 \u0430\u0443\u0434\u0438\u0442\u043E\u0440\u0438\u0438 \u043E\u0442\u043E\u0431\u0440\u0430\u0436\u0430\u0435\u0442\u0441\u044F \u0441\u043F\u0438\u0441\u043E\u043A \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432, \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u043D\u044B\u0445 \u0432 \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0443.\n\n\u0427\u0435\u0440\u0435\u0437 \u043D\u0435\u043A\u043E\u0442\u043E\u0440\u043E\u0435 \u0432\u0440\u0435\u043C\u044F \u0437\u0434\u0435\u0441\u044C \u0442\u0430\u043A\u0436\u0435 \u043C\u043E\u0436\u043D\u043E \u0431\u0443\u0434\u0435\u0442 \u0443\u0432\u0438\u0434\u0435\u0442\u044C \u043E\u0442\u043A\u043B\u0438\u043A \u043A\u0430\u0436\u0434\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u0430, \u043D\u0430\u043F\u0440\u0438\u043C\u0435\u0440 \u041F\u0435\u0440\u0435\u0445\u043E\u0434 \u043F\u043E \u0441\u0441\u044B\u043B\u043A\u0435 \u0438\u043B\u0438 \u041E\u0442\u043F\u0438\u0441\u0430\u043B\u0441\u044F."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "InfoSpriteImage",
				hash: "15d4e5358792ef12351d7d6caa59dfb2",
				resourceItemExtension: ".png"
			}
		},
		LoadMoreIcon: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "LoadMoreIcon",
				hash: "010a38d79ad1acb4726eb1dae1d7f14c",
				resourceItemExtension: ".png"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		},
		RelationshipButtonImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "RelationshipButtonImage",
				hash: "057ce8936048a846d19c7a9644c93a2b",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		ImageFilter: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "ImageFilter",
				hash: "ef37ab38ddacefd3ba86c6bbcf4e7501",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "SortIcon",
				hash: "f5e0b50ec74a47fb66f7d7d403b760c3",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "GridSettingsIcon",
				hash: "3f4eb707ce7f259fce295490879a8f9b",
				resourceItemExtension: ".svg"
			}
		},
		FilterIcon20: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "FilterIcon20",
				hash: "124f910abe91ebe4045613a9c5b379d1",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		OpenRecordChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "VwMandrillRecipientDetailV2",
				resourceItemName: "OpenRecordChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});