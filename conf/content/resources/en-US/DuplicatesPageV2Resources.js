﻿define("DuplicatesPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ContactHeaderCaption: "Duplicate contacts",
		HeaderLabelCaption: "This is the list of duplicates according to the duplicates rules. {0}How does it work{1}?",
		DuplicatesRulesSetupCaption: "Setup duplicates rules",
		AccountHeaderCaption: "Duplicate accounts",
		HeaderCaption: "Duplicates",
		AccountHeaderLabelCaption: "This is the list of duplicate accounts found according to the duplicates rules. {0}How does it work{1}?",
		ContactHeaderLabelCaption: "This is the list of duplicate contacts found according to the duplicates rules. {0}How does it work{1}?",
		FindDuplicatesButtonCaption: "Find duplicates",
		ContactEmptyInfoTitleLabelCaption: "Good job! Your database seems to have no duplicate contacts. Now it\u0027s a good time to enjoy a cup of coffee.",
		AccountEmptyInfoTitleLabelCaption: "Good job! Your database seems to have no duplicate accounts. Now it\u0027s a good time to enjoy a cup of coffee.",
		FirstRunInfoTitleLabelCaption: "Looks like you haven\u0027t searched for duplicates yet.",
		EmptyInfoDescriptionLabelCaption: "Things change quickly. You can always run another search to fight duplicates again.",
		FirstRunInfoDescriptionLabelCaption: "You can go to Actions and run the search now.",
		ConfirmationRunDeduplicationMessage: "Before we start the search, we\u0027ll have to clear all the previous search results.\nDo you want to continue?",
		SearchInProcessInfoTitleLabelCaption: "Duplicate search is running.",
		SearchInProcessInfoDescriptionLabelCaption: "This will take a few minutes. When it is completed, you will receive a notification.",
		FindContactDuplicatesButtonCaption: "Run duplicate contacts search",
		FindAccountDuplicatesButtonCaption: "Run duplicate accounts search",
		SearchInProcessMarker: "SearchInProcess",
		FirstRunMarker: "FirstRun",
		ItemsIsEmptyMarker: "ItemsIsEmpty",
		CommonErrorMessage: "We\u0027re sorry, for some reason we were not able to run the search engine. Please try again later or contact your administrator for help.",
		InProgressMessage: "We\u0027re investigating your customer base right now to find any records that are duplicates. Please hold on, and we\u0027ll send you a notification once we\u0027re done.",
		SuccessMessage: "Search executed successfully.",
		PageHeaderMask: "Duplicates search in the \u0027{0}\u0027 section",
		FindDuplicatesButtonCaptionPattern: "Run duplicate search",
		SearchIsInProcessErrorMessage: "Duplicate search was launched earlier. Wait until current Duplicate search will finish, before starting new search.",
		SetUpBulkDeduplicationRules: "Duplicate search rules are missing or disabled. To start the search, please setup the rules.",
		GroupSummaryCaption: "Groups:",
		DuplicatesSummaryCaption: "Duplicates:",
		FilterButtonCaption: "Filters",
		EmptyCollectionWithFiltersDescription: "Clear the filter or change its conditions.",
		EmptyCollectionWithFiltersTitle: "There are no records matching the filter criteria.",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		ActionButtonCaption: "Actions",
		BeginProcessButtonMenuItemCaption: "Start process",
		CancelButtonCaption: "Cancel",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		ClearButtonHint: "Clear value",
		CloseButtonCaption: "Close",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DelayExecutionButtonCaption: "Perform later",
		FieldLockHint: "Non-editable field",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldValidationError: "Field \u0022{0}\u0022: {1}",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		IncrementMaskSuffix: "CodeMask",
		IncrementNumberSuffix: "LastNumber",
		NewRecordPageCaptionSuffix: ": New record",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenListSettingsCaption: "List setting",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		OpenSectionDesignerButtonCaption: "Open page designer",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		PageHeaderTemplate: "{0} / {1}",
		PrintButtonCaption: "Print",
		ProcessEntryPointButtonCaption: "Move down the process",
		ProsessButtonCaption: "Run process",
		QuickAddButtonHint: "Add related activity",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		SaveButtonCaption: "Save",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		TabVisaCaption: "Approvals",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		ItemsIsEmptyImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "ItemsIsEmptyImage",
				hash: "1c610ecf8ac0bf0e371ec139b1c064f7",
				resourceItemExtension: ".png"
			}
		},
		FirstRunImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "FirstRunImage",
				hash: "a2ff13843ab8d03fd9628b1b59853a1c",
				resourceItemExtension: ".png"
			}
		},
		SearchInProcessImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "SearchInProcessImage",
				hash: "c7eb00adf5e60ac74cff287205f768b1",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "DuplicatesPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});