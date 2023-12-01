define("CampaignSchemaDesignerViewModelMixinResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CampaignWarningMessageCaption: "Warnings:",
		CampaignErrorMessageCaption: "Campaign elements set up errors and other errors:",
		CampaignFlowSchemaIsNotValidCaption: "There are mistakes in campaign scheme",
		TimeZoneMigrationInfoMessage: "Version 7.12 has a new setting - \u0022Default campaign time zone\u0022. All time settings in conditional flows are displayed according to the default time zone that was set on update: UTC (00:00). This will not influence the campaign run schedule. You can set another value in the field \u0022Time zone\u0022 on campaign properties page.",
		TimeZoneMigrationInfoMessageBoxCaption: "Changes in new version"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});