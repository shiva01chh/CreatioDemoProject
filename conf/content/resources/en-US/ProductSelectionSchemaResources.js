define("ProductSelectionSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AvailableInFormatString: "{1} {2} are added to {0}",
		ModuleCaption: "{0} \u2116{1} product selection",
		CartDataViewHint: "Cart",
		SearchStringPlaceHolder: "Search by product name or code",
		CodeCaption: "Code",
		ProductCatalogueRootCaption: "Catalog",
		LineItemsCaption: "Items:",
		TotalAmountCaption: "Total:",
		SaveButtonCaption: "Save",
		CancelButtonCaption: "Cancel",
		ViewOptionsButtonCaption: "View",
		ColumnSettingsActionCaption: "Select fields to display",
		EmptyBasketDescription: "Add a product to continue working with the cart.",
		EmptyBasketTitle: "The cart has no products.",
		EmptyFilterDescription: "Clear the filter or change its conditions.",
		EmptyFilterTitle: "No products in the catalog match the filter."
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