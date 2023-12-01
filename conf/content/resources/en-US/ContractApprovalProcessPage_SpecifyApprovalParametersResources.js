define("ContractApprovalProcessPage_SpecifyApprovalParametersResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ApprovalLabel_caption: "New approval",
		CancelButton: "Cancel",
		CloseButton: "Close",
		ContinueInOtherPageButton_caption: "Continue in other page",
		DefaultHeaderCaption: "Title",
		NewRecord: "New record",
		Record: "Record",
		SaveButton: "Save"
	};
	var parametersLocalizableStrings = {
		ApprovalObjective: "Approval objective",
		VisaOwner: "Approver",
		DelegationPermitted: "Delegation permitted"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});