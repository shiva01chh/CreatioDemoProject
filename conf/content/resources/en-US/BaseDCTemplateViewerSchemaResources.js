define("BaseDCTemplateViewerSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Title: "Template",
		InvalidSenderDomainMessage: "The email domain is not confirmed, which might significantly affect email deliverability. Add domain and get settings to confirm it \u003Ca href=\u0022\u0022\u003Ehere\u003C/a\u003E.",
		ValidSenderDomainMessage: "Sending domain was successfully verified for sending emails",
		SenderMacroValidationMessage: "Could not save bulk email: the field value must be specified either as a string or as a macro.",
		SenderMacroInfoMessage: "Your sender is specified as a macro. Creatio will send emails only from verified sender domains. Any emails, whose sender domain is not verified will not be sent. The response for such emails will be \u201CCanceled (Sender\u0027s domain not verified)\u201D"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		ToggleListButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseDCTemplateViewerSchema",
				resourceItemName: "ToggleListButtonImage",
				hash: "7bc3932d679a675779c0a19c7b0e2dca",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});