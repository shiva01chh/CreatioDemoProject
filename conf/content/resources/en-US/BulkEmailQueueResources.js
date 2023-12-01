define("BulkEmailQueueResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		BulkEmailQueueCaption: "BulkEmailQueue",
		IdCaption: "Id",
		CreatedOnCaption: "Created on",
		CreatedByCaption: "Created by",
		ModifiedOnCaption: "Modified on",
		ModifiedByCaption: "Modified by",
		ProcessListenersCaption: "Active processes",
		MaxRetryCountCaption: "Max retry count for message",
		MessageTypeCaption: "Message type",
		MessageCaption: "Message in JSON format",
		BulkEmailCaption: "BulkEmail",
		EstimatedRowsCountCaption: "Estimated rows count",
		EstimatedTimeCaption: "ETA (seconds)",
		PriorityCaption: "Priority"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});