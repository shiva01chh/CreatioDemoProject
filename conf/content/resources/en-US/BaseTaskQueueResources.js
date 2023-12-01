define("BaseTaskQueueResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		BaseTaskQueueCaption: "Base entity for tasks queue",
		IdCaption: "Id",
		CreatedOnCaption: "Created on",
		CreatedByCaption: "Created by",
		ModifiedOnCaption: "Modified on",
		ModifiedByCaption: "Modified by",
		ProcessListenersCaption: "Active processes",
		MaxRetryCountCaption: "Max retry count for message",
		MessageTypeCaption: "Message type",
		MessageCaption: "Message in JSON format",
		PriorityCaption: "Priority"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});