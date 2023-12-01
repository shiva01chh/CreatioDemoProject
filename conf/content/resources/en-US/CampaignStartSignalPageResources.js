define("CampaignStartSignalPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ObjectEntityCaption: "Add participants when this object is added/updated",
		EntityColumnsInformationText: "There are no selected columns. The trigger will be activated when any column is modified",
		IsRecurringLabel: "Participation rules",
		IsRecurringCaption: "Recurring entrance",
		IsRecurringHint: "Property defines participation rules, in case of recurring entrance by signal.\nIf checked - previous participants will be suspended.\nIf not - flow will be executed till element with delay.",
		SaveTemplateButtonText: "Save",
		SelectFromLookupButtonText: "Select from lookup",
		ElementConfigCaption: "Element settings",
		ElementConfigHintText: "You can save the element settings to use them with other campaigns. The settings are saved to a \u003Ca href=\u0022ViewModule.aspx#LookupSectionModule/BaseLookupConfigurationSection/CampaignElementTemplate\u0022 target=\u0022_blank\u0022\u003Elookup\u003C/a\u003E",
		AddParameterButtonCaption: "Add parameter",
		AddRecordColumnValuesButtonCaption: "Add column",
		AnyFieldCaption: "In any field",
		AnySelectedFieldCaption: "In any of the selected fields",
		BackgroundModePriority0Caption: "By process priority",
		BackgroundModePriority300Caption: "High",
		BackgroundModePriority200Caption: "Medium",
		BackgroundModePriority100Caption: "Low",
		BackgroundModePriorityCaption: "Background execution priority",
		CaptionCaption: "Title",
		CloseButtonCaption: "Close",
		CustomValidatorInvalidMessage: "Missing required field",
		DeletedEntityChangeTypeCaption: "Record deleted",
		DeletedObjectSignalFilterCaption: "The record must meet the filter conditions",
		DeleteMenuItemCaption: "Delete",
		DescriptionCaption: "Description",
		DuplicateNameMessage: "Element with this code already exists.",
		DuplicateParameterNameMessage: "Parameter with this code already exists.",
		EditMenuItemCaption: "Edit",
		ElementPropertyNotFoundExceptionMessage: "Property \u0027{0}\u0027 not found in item \u0027{1}\u0027",
		EmptyParametersMessage: "Element has no parameters",
		EntityCaption: "Object",
		EntityChangeTypeCaption: "Which event should activate the trigger?",
		EntityColumnsLookupPageCaption: "Select columns",
		ExpectChangesCaption: "Trigger activates when the following columns are modified:",
		ExtendedModeCaption: "Advanced mode",
		FilterInformationText: "The filter by object is not set. The trigger will be activated for all records of this object",
		IgnoreMultiInstanceErrorsCaption: "Continue execution on errors",
		InavalidMappingColumn: "Invalid formula",
		InsertedEntityChangeTypeCaption: "Record added",
		InsertedObjectSignalFilterCaption: "The added record must meet filter conditions",
		IsLoggingCaption: "Enable logging",
		MappingPlaceholderCaption: "Select value",
		MultiInstanceExecutionModeCaption: "Execution mode",
		NameCaption: "Code",
		ObjectSignalCaption: "Object signal",
		ParametersTabCaption: "Parameters",
		PrimaryModeCaption: "Primary mode",
		ProcessInformationText: "Use element to instantly add a participant to campaign when new record that meets filter conditions is added or updated. \u003Ca href=\u0022{0}\u0022 data-context-help-code=\u0022CampaignSignalElement\u0022 target=\u0022_blank\u0022\u003ELearn more\u003C/a\u003E",
		ProcessSchemaParameterEditPageCaption: "Insert parameter",
		RecepientTip: "Specify the email address of the recipient. You can select a specific email address or define it based on information from other process items.",
		RecommendationCaption: "Which type of signal is received?",
		SaveButtonCaption: "Save",
		SerializeToDBCaption: "Serialize in DB",
		SettingsTabCaption: "Settings",
		SignalCaption: "Signal",
		SimpleSignalCaption: "Custom signal",
		UpdatedEntityChangeTypeCaption: "Record modified",
		UpdatedObjectSignalFilterCaption: "The modified record must meet filter conditions",
		UseBackgroundModeCaption: "Run following elements in the background",
		WrongNameMessage: "Invalid value. Use symbols: a-z, A-Z, 0-9. \u003C/br\u003E Symbol: 0-9 cannot be first."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "CloseButtonImage",
				hash: "c5d6edb4bb180f8b30301d3dca7a12d8",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "ToolsButtonImage",
				hash: "67b9187f776eb0c57c20bd86b63d4efc",
				resourceItemExtension: ".svg"
			}
		},
		InfoButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "InfoButtonImage",
				hash: "f67a1328d14dbc7091cc94589d7d2148",
				resourceItemExtension: ".svg"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "AddButtonImage",
				hash: "7bc1980b519205382d39ea022bd498f8",
				resourceItemExtension: ".svg"
			}
		},
		AddParameterButton: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "AddParameterButton",
				hash: "a74df1a7d753e6067ab248949eb47d97",
				resourceItemExtension: ".png"
			}
		},
		ParameterEditToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "ParameterEditToolsButtonImage",
				hash: "df03c3177a972b7f3b6987430f988ca3",
				resourceItemExtension: ".svg"
			}
		},
		SaveButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "SaveButtonIcon",
				hash: "8c4342611ee69591c195732b26c55ab2",
				resourceItemExtension: ".svg"
			}
		},
		SelectButtonIcon: {
			source: 3,
			params: {
				schemaName: "CampaignStartSignalPage",
				resourceItemName: "SelectButtonIcon",
				hash: "fce3eafca0cad8b21387fd24ee1313ce",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});