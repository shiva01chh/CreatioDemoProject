﻿define("ObjectFileProcessingUserTaskPropertiesPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		OrderDirectionCaption: "How to sort records?",
		SourceEntitySchemaSelectCaption: "Which object to receive file from?",
		RecordsCaption: "records",
		ReadOnlyCaption: "Read first",
		AddSortingOrderButtonCaption: "Add",
		AddParameterButtonCaption: "Add parameter",
		AfterActivitySaveScriptCaption: "After Activity Saved",
		CaptionCaption: "Title",
		ChangePageSchemaButtonCaption: "Change",
		ChangeReferenceSchemaButtonCaption: "Change",
		ChangeReferenceSchemaWarningMessage: "Are you sure you want to change this object? All field values and filter settings will be lost.",
		ChangeResultActionTypeWarningMessage: "Are you sure you want to change the action? The selected saving settings will be lost.",
		ChangeSchemaWarningMessage: "Are you sure you want to change element schema? All parameters will be lost.",
		CloseButtonCaption: "Close",
		DeleteMenuItemCaption: "Delete",
		DescriptionCaption: "Description",
		DuplicateNameMessage: "Element with this code already exists.",
		DuplicateParameterNameMessage: "Parameter with this code already exists.",
		EditMenuItemCaption: "Edit",
		ElementPropertyNotFoundExceptionMessage: "Property \u0027{0}\u0027 not found in item \u0027{1}\u0027",
		EmptyParametersMessage: "Element has no parameters",
		ExtendedModeCaption: "Advanced mode",
		FilterUnitCaption: "How to filter records?",
		IgnoreMultiInstanceErrorsCaption: "Continue execution on errors",
		InavalidMappingColumn: "Invalid formula",
		InvalidEntitySchemaChange: "Process element cannot be changed",
		IsLoggingCaption: "Enable logging",
		MappingPlaceholderCaption: "Select value",
		MultiInstanceExecutionModeCaption: "Execution mode",
		NameCaption: "Code",
		ParametersTabCaption: "Parameters",
		PrimaryModeCaption: "Primary mode",
		ProcessInformationText: "Hint",
		ProcessSchemaParameterEditPageCaption: "Insert parameter",
		RecepientTip: "Specify the email address of the recipient. You can select a specific email address or define it based on information from other process items.",
		SaveButtonCaption: "Save",
		SchemaAddedMessage: "The \u0022{0}\u0022 has been added. Do you wish to select it in the \u0022{1}\u0022 element?",
		SchemaOutdatedMessage: "The \u0022{0}\u0022 page has been modified. Do you wish to update the parameters of the \u0022{1}\u0022 element?",
		SerializeToDBCaption: "Serialize in DB",
		SettingsTabCaption: "Settings",
		SourceActionType0Caption: "Object attachments",
		SourceActionType1Caption: "Generated report",
		SourceActionTypeCaption: "What is the source of the file?",
		UseBackgroundModeCaption: "Run following elements in the background",
		WrongNameMessage: "Invalid value. Use symbols: a-z, A-Z, 0-9. \u003C/br\u003E Symbol: 0-9 cannot be first."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ObjectFileProcessingUserTaskPropertiesPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});