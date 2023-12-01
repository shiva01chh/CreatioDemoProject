define("SsoSamlBase_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SetSamlParams_Label_caption: "After the application is registered in your SAML provider, please fill in SAML data in Creatio.",
		RegisterInIdentity_Label: "Please register Creatio application on the SAML provider side (admin permissions are required for this operation). Please follow the instructions on Creatio Academy. You can download the metadata file to simplify the configuration.",
		GetMetadata_Button_caption: "Get metadata",
		AdditionalParameters_ExpansionPanel_title: "Additional parameters",
		SamlEndpoints_ExpansionPanel_title: "Step 2. Define SAML provider URLs",
		SetIdentityStep_ExpansionPanel_title: "Step 1. Perform configuration of your SAML provider",
		Button_TestSignIn_caption: "Test Sign in",
		BackButton: "Back",
		CancelButton: "Cancel",
		CloseButton: "Close",
		DefaultHeaderCaption: "Page title",
		NewRecord: "New record",
		Record: "Record",
		SaveButton: "Save",
		SetRecordRightsButtonCaption: "Set up access rights"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});