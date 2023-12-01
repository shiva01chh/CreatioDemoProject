define("SetupWebitelParametersPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		HeaderCaption: "Webitel parameters setup",
		UseWebPhoneCaption: "Use web phone",
		IsAutoLoginCaption: "Auto-connection",
		UseVideoCaption: "Use video",
		UseWebitelPanelCaption: "Use Webitel CTI",
		UseNotificationSoundCaption: "Sound notification on incoming call"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});