define("SsoSamlAzure_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PartnerIdentityName_label: "Azure AD identifier",
		AdditionalParameters_ExpansionPanel_title: "Additional parameters",
		BackButton: "Back",
		Button_TestSignIn_caption: "Test Sign in",
		CancelButton: "Cancel",
		CloseButton: "Close",
		DefaultHeaderCaption: "Page title",
		GetMetadata_Button_caption: "Get metadata",
		NewRecord: "New record",
		Record: "Record",
		RegisterInIdentity_Label: "Please register Creatio application in Azure portal (admin permissions are required for this operation). Please follow the instructions on Creatio Academy. You can download the metadata file to simplify the configuration.",
		SamlEndpoints_ExpansionPanel_title: "Step 2. Define Azure AD URLs",
		SaveButton: "Save",
		SetIdentityStep_ExpansionPanel_title: "Step 1. Perform configuration in Azure AD",
		SetRecordRightsButtonCaption: "Set up access rights",
		SetSamlParams_Label_caption: "After the application is registered in Azure portal, please fill in Azure data in Creatio."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});