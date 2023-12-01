﻿define("ProductSelectionSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AvailableInFormatString: "\u041F\u0440\u043E\u0434\u0443\u043A\u0442 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D \u0432 {0} \u0432 \u043A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u0435 {1} {2}",
		ModuleCaption: "\u041F\u043E\u0434\u0431\u043E\u0440 \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u043E\u0432 \u0432 {0} \u2116{1}",
		CartDataViewHint: "\u041A\u043E\u0440\u0437\u0438\u043D\u0430",
		SearchStringPlaceHolder: "\u041F\u043E\u0438\u0441\u043A \u043F\u043E \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u044E \u0438\u043B\u0438 \u043A\u043E\u0434\u0443",
		CodeCaption: "\u041A\u043E\u0434",
		ProductCatalogueRootCaption: "Catalog",
		LineItemsCaption: "\u041F\u043E\u0437\u0438\u0446\u0438\u0439:",
		TotalAmountCaption: "\u043D\u0430 \u0441\u0443\u043C\u043C\u0443:",
		SaveButtonCaption: "\u0421\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		ViewOptionsButtonCaption: "\u0412\u0438\u0434",
		ColumnSettingsActionCaption: "\u041D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430 \u043A\u043E\u043B\u043E\u043D\u043E\u043A",
		EmptyBasketDescription: "\u0414\u043E\u0431\u0430\u0432\u044C\u0442\u0435 \u0445\u043E\u0442\u044F \u0431\u044B \u043E\u0434\u0438\u043D \u043F\u0440\u043E\u0434\u0443\u043A\u0442 \u0434\u043B\u044F \u043F\u0440\u043E\u0434\u043E\u043B\u0436\u0435\u043D\u0438\u044F \u0440\u0430\u0431\u043E\u0442\u044B \u0441 \u043A\u043E\u0440\u0437\u0438\u043D\u043E\u0439.",
		EmptyBasketTitle: "\u0412 \u043A\u043E\u0440\u0437\u0438\u043D\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0433\u043E \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u0430.",
		EmptyFilterDescription: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u0435 \u0444\u0438\u043B\u044C\u0442\u0440 \u0438\u043B\u0438 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044F \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438.",
		EmptyFilterTitle: "\u041F\u0440\u0438 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u043E\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0435 \u0432 \u043A\u0430\u0442\u0430\u043B\u043E\u0433\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0433\u043E \u043F\u0440\u043E\u0434\u0443\u043A\u0442\u0430."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		GridDataViewIcon: {
			source: 3,
			params: {
				schemaName: "ProductSelectionSchema",
				resourceItemName: "GridDataViewIcon",
				hash: "a7c84fe2f715bd579f6e51a0e0e840f3",
				resourceItemExtension: ".png"
			}
		},
		BasketDataViewIcon: {
			source: 3,
			params: {
				schemaName: "ProductSelectionSchema",
				resourceItemName: "BasketDataViewIcon",
				hash: "f35ff18b75f126ebfd520c063a28c160",
				resourceItemExtension: ".png"
			}
		},
		EmptyBasketIcon: {
			source: 3,
			params: {
				schemaName: "ProductSelectionSchema",
				resourceItemName: "EmptyBasketIcon",
				hash: "84410c143d7a4e3bfdbeda3db0408fca",
				resourceItemExtension: ".png"
			}
		},
		EmptyFilterIcon: {
			source: 3,
			params: {
				schemaName: "ProductSelectionSchema",
				resourceItemName: "EmptyFilterIcon",
				hash: "7bf68ba9d5b686f7e46b0e23e89821bb",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});