define("AddCampaignParticipantPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProcessInformationText: "Participants who meet specified folder or filter conditions are added to the campaign once this element is executed. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignAddCampaignParticipantElement\u0022 target=\u0022_blank\u0022\u003ELearn more\u003C/a\u003E",
		FolderText: "Which folder to add participants from?",
		IsRecurringLabel: "Element Settings",
		IsRecurringCaption: "Re-entering campaign",
		DaysNumberCaption: "Quantity of days before next campaign entrance",
		NegativeNumberErrorText: "Must be positive",
		RecurringAddHint: "Option allows recurring entrance into campaign. If contact already participates - previous entrance will be suspended.",
		AudienceSourceFolderCaption: "Records in a specific folder",
		AudienceSourceFilterCaption: "Records that match a custom filter",
		AudienceSourceTypeLabel: "Specify which records will be converted to the campaign audience",
		AudienceSchemaLabelCaption: "Select an object (entity) that holds the campaign audience data"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "AddCampaignParticipantPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});