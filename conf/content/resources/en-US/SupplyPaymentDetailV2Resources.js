﻿define("SupplyPaymentDetailV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Installment plan",
		DeleteMenuDisableState: "Uncompleted",
		NoItems: "Please, select a step",
		TypeNotMatch: "Invoice can only be generated by the \u0022Payment\u0022 type steps",
		InvoicesCreated: "Number of invoices created: {1}{0}",
		ExistInvoice: "An invoice already exists for this step",
		InvoiceProductName: "Payment for order No. {0} dated {1}",
		SetTemplateButtonCaption: "Use installment plan template",
		SetTemplateActionWarning: "Current installment plan will be deleted. Continue?",
		CreateInvoice: "Generate invoice?",
		ThereIsDefTemplateWarning: "Default template found in the system. Ignore?",
		CreateContract: "Create contract?",
		GenerateContractMenuCaption: "Create contract",
		Payment: "Payment",
		Delivery: "Delivery",
		Invoice: "Invoice",
		Contract: "Contract",
		RebindContract: "Rebind the contract?",
		DivideProduct: "Products should relate to different contracts. Agreed?",
		FieldsGroupCollapseButtonHint: "Collapse/Expand",
		NewStageButtonCaption: "New stage",
		InvoiceInsertError: "Error while creating new invoice. {0}. \u003Ca href=\u0022{1}\u0022 target=\u0022_blank\u0022 style=\u0022position:relative\u0022 onclick=\u0022event.stopPropagation();\u0022\u003ERead more\u003C/a\u003E. ",
		InvoiceErrorArticleUrl: "https://academy.bpmonline.com/documents/sales-enterprise/7-8/how-set-page-fields#XREF_49522"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		LoadMoreIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "LoadMoreIcon",
				hash: "010a38d79ad1acb4726eb1dae1d7f14c",
				resourceItemExtension: ".png"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		},
		RelationshipButtonImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "RelationshipButtonImage",
				hash: "057ce8936048a846d19c7a9644c93a2b",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		ImageFilter: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "ImageFilter",
				hash: "ef37ab38ddacefd3ba86c6bbcf4e7501",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "SortIcon",
				hash: "f5e0b50ec74a47fb66f7d7d403b760c3",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "GridSettingsIcon",
				hash: "3f4eb707ce7f259fce295490879a8f9b",
				resourceItemExtension: ".svg"
			}
		},
		FilterIcon20: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "FilterIcon20",
				hash: "124f910abe91ebe4045613a9c5b379d1",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		OpenRecordChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "SupplyPaymentDetailV2",
				resourceItemName: "OpenRecordChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});