define("CampaignQueueResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		CampaignQueueCaption: "Campaign queue for delayed campaign execution",
		IdCaption: "Id",
		CreatedOnCaption: "Created on",
		CreatedByCaption: "Created by",
		ModifiedOnCaption: "Modified on",
		ModifiedByCaption: "Modified by",
		ProcessListenersCaption: "Active processes",
		ContactCaption: "Contact",
		CampaignItemCaption: "Campaign step",
		ExpirationPeriodCaption: "Record life time",
		CampaignParticipantCaption: "Campaign participant",
		LinkedEntityIdCaption: "Linked entity identifier ",
		EntitySchemaUIdCaption: "Unique identifier of linked entity schema"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});