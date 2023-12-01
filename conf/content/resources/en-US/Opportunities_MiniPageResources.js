define("Opportunities_MiniPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		DueDate_label: "Expected close date",
		Amount_label: "Total contract value",
		DueDate_placeholder: "Enter the expected closing date of the sale",
		DueDate_tooltip: "Enter the expected closing date of the sale. This field is completed automatically and becomes non-editable when the opportunity moves to the final stage",
		Amount_tooltip: "Enter the potential revenue to be associated with the contract as a result of the winning sale. This field is completed automatically when products are added to the opportunity",
		CancelButton: "Cancel",
		CloseButton: "Close",
		ContinueInOtherPageButton_caption: "Continue in other page",
		DefaultHeaderCaption: "Title",
		NewRecord: "New record",
		Record: "Record",
		SaveButton: "Save"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});