define("CustomerAccessLookupPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ColumnCaptionUrl: "Url",
		ColumnCaptionDescription: "Description",
		ColumnCaptionExpirationDate: "Expiration date",
		Title: "Login to client\u0027s site",
		SelectButtonCaption: "Select",
		CancelButtonCaption: "Cancel",
		ServiceErrorMessage: "Error occurred while retrieving customer access list",
		ClientUriEmptyErrorMessage: "There\u0027s no URI for the selected access\u0027 client. Check client registration (ClientUri)",
		ClientsCheckErrorMessage: "Error occurred while checking client registration",
		NoClientsRegisteredMessage: "No clients registrations found to provide access",
		ColumnCaptionIsSystemOperationsRestricted: "Configuration denied",
		ColumnCaptionIsDataIsolationEnabled: "Data access denied"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "CustomerAccessLookupPage",
				resourceItemName: "CloseIcon",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});