define("InvoiceApprovalProcessPage_SpecifyApprovalParametersResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ApprovalLabel_caption: "New approval",
		CancelButton_caption: "Cancel",
		CancelButton: "Cancel",
		CloseButton: "Close",
		ContinueInOtherPageButton_caption: "Continue in other page",
		DefaultHeaderCaption: "Title",
		NewRecord: "New record",
		Record: "Record",
		SaveButton: "Save"
	};
	var parametersLocalizableStrings = {
		DelegationPermitted: "Delegation permitted",
		VisaOwner: "Approver",
		ApprovalObjective: "Approval objective"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});