﻿define("CampaignSplitGatewayPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PageCaption: "How to split the audience?",
		EqualizeSplitCheckboxLabelCaption: "Equalize",
		DefaultFlowCaption: "Campaign flow",
		BlankSlateCaption: "No outgoing flows",
		SplitGatewayPropertiesHint: "If the number of participants cannot be divided as specified, the random split algorithm is applied",
		BlankSlateDetails: "Add new outgoing flows from element for audience split customization",
		BlankSlateDetailsHighlight: "Add",
		AddParameterButtonCaption: "Add parameter",
		CaptionCaption: "Title",
		CloseButtonCaption: "Close",
		DeleteMenuItemCaption: "Delete",
		DescriptionCaption: "Description",
		DuplicateNameMessage: "Element with this code already exists.",
		DuplicateParameterNameMessage: "Parameter with this code already exists.",
		EditMenuItemCaption: "Edit",
		ElementPropertyNotFoundExceptionMessage: "Property \u0027{0}\u0027 not found in item \u0027{1}\u0027",
		EmptyParametersMessage: "Element has no parameters",
		ExtendedModeCaption: "Advanced mode",
		IgnoreMultiInstanceErrorsCaption: "Continue execution on errors",
		InavalidMappingColumn: "Invalid formula",
		IsLoggingCaption: "Enable logging",
		MappingPlaceholderCaption: "Select value",
		MultiInstanceExecutionModeCaption: "Execution mode",
		NameCaption: "Code",
		ParametersTabCaption: "Parameters",
		PrimaryModeCaption: "Primary mode",
		ProcessInformationText: "The element randomly splits the audience before the next step. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignSplitGatewayElement\u0022 target=\u0022_blank\u0022\u003ELearn more\u003C/a\u003E",
		ProcessSchemaParameterEditPageCaption: "Insert parameter",
		RecepientTip: "Specify the email address of the recipient. You can select a specific email address or define it based on information from other process items.",
		SaveButtonCaption: "Save",
		SerializeToDBCaption: "Serialize in DB",
		SettingsTabCaption: "Settings",
		UseBackgroundModeCaption: "Run following elements in the background",
		WrongNameMessage: "Invalid value. Use symbols: a-z, A-Z, 0-9. \u003C/br\u003E Symbol: 0-9 cannot be first."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		BlankSlateImage: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "BlankSlateImage",
				hash: "8e7cacd4931c4b2e44ea606c77149579",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignSplitGatewayPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});