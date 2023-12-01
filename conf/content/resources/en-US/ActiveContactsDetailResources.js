define("ActiveContactsDetailResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AvailableLicensesCaption: "Available licenses:",
		ActiveContactMessageInfo: "The count of used active contacts licenses on {0}: is available {1}, the total number is {2}.",
		ActiveContactMessageAttention: "The count of active contacts licenses running out. On {0}: is available {1}, the total paid is {2}.",
		ActiveContactMessageWarning: "The count of used active contacts is out of the limit. On {0}: is available {1}, the total paid is {2}.",
		ActiveContactExceededMessageWarning: "The count of used active contacts is out of the limit. On {0}: licenses exceeded by {1}, the total paid is {2}.",
		NoLicensetMessage: "It is needed to add active contacts licenses to the system ",
		Caption: "",
		FieldsGroupCollapseButtonHint: "Collapse/expand"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ActiveContactsDetail",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ActiveContactsDetail",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});