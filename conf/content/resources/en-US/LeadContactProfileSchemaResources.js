define("LeadContactProfileSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddRecordButtonCaption: "New",
		ClearButtonCaption: "Clear column",
		ErrorOnSaveMessage: "An error occurred while saving. Please contact your system administrator for more information.",
		SearchButtonCaption: "Search",
		SetActionCaption: "Add relationship",
		SimilarButtonCaption: "Select from {0} similar",
		SimilarButtonFoundHintText: "We have found several contacts that can be linked to this lead. Click here to choose one from the list.",
		SimilarButtonNotFoundHintText: "We didn\u2019t find any contacts that can be linked to this lead."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "BlankSlateIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		},
		ClearButton: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "ClearButton",
				hash: "e469377aa2358c21942fe57d0e1fef21",
				resourceItemExtension: ".png"
			}
		},
		ProfileIcon: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "ProfileIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});