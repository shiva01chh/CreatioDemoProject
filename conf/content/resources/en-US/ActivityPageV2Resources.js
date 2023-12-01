﻿define("ActivityPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ESNTabCaption: "Feed",
		SubscribeCaption: "Follow the feed",
		UnsubscribeCaption: "Unfollow the feed",
		SubscribedInformationDialog: "You are now following feed: {0}",
		UnsubscribedInformationDialog: "You have stopped following feed: {0}",
		SaveButtonCaption: "Save",
		CancelButtonCaption: "Cancel",
		ActionButtonCaption: "Actions",
		GeneralInfoTabCaption: "General information",
		InvoiceFileNotesTabCaption: "Attachments and notes",
		ActivityParticipantTabCaption: "Participants",
		ActivityLineTabCaption: "Feed",
		ActivityFileNotesTabCaption: "Attachments and notes",
		RemindToOwnerCaption: "Remind owner",
		RemindToAuthorCaption: "Remind reporter",
		ActionPageDesignerButtonCaption: "Page designer",
		ActionRightsPageButtonCaption: "Access rights",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		AdditionalControlGroup: "Additional",
		LinksControlGroupCaption: "Connected to",
		RemindControlGroupCaption: "Reminders",
		ResultControlGroupCaption: "Result",
		TaskMainHeaderCaption: "Task",
		CallMainHeaderCaption: "Call",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		NewRecordPageCaptionSuffix: ": New record",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		RemindDateCaption: "Remind on",
		StartDateGreaterDueDate: "The value in the \u0022Due\u0022 field should be greater than the value in the \u0022Start\u0022 field",
		ActivityResultInProcessModeRequire: "When working in the context of a process, the Result field must be filled in",
		FullProjectNameChangedWithoutProjectSelectionWarning: "The value in the \u0022Project\u0022 field is not correct",
		SchedulerDataViewCaption: "Open calendar",
		ProjectResourceElementMissing: "Contact {0} is not specified in the project\u0027s list of resources. Do you want to add a new record to the list of resources?",
		StartDateGreaterDueDateSmallMessage: "End date/time exceeds start date/end time",
		InsertParticipantsMessage: "Add the filtered employees to the participants list?",
		EmailTabCaption: "Email",
		TagButtonHint: "Tags",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldLockHint: "Non-editable field",
		ClearButtonHint: "Clear value",
		ConnectionWithProjectDetailCaption: "Connected to project",
		OwnerTip: "Full name of the record owner. Select the owner from the contacts registered as users in the system.",
		ContactTip: "A contact for whom the activity was created. The lookups are filtered by the account specified in the activity",
		OpportunityTip: "An opportunity connected to the activity. The lookups are filtered by the account specified in the activity",
		OrderTip: "An order connected to the activity. The lookups are filtered by the opportunity specified in the activity",
		InvoiceTip: "An invoice connected to the activity. The lookups are filtered by the opportunity, contact and account specified in the activity",
		DocumentTip: "A document connected to the activity. The lookups are filtered by the opportunity, contact and account specified in the activity",
		FullProjectNameTip: "The project task for which the activity was created. This activity may be used later to calculate project work hours",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		FullProjectCaption: "Project/task",
		CallTabCaption: "Calls",
		JoinMeetingButtonHint: "Join",
		JoinMeetingButtonCaption: "Join",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		BeginProcessButtonMenuItemCaption: "Start process",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		CloseButtonCaption: "Close",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DelayExecutionButtonCaption: "Perform later",
		EditRightsCaption: "Set up access rights",
		FieldValidationError: "Field \u0022{0}\u0022: {1}",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenChangeLogMenuCaption: "View change log",
		OpenListSettingsCaption: "List setup",
		OpenSectionDesignerButtonCaption: "Open page designer",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		PrintButtonCaption: "Print",
		ProcessEntryPointButtonCaption: "Move down the process",
		ProsessButtonCaption: "Run process",
		QuickAddButtonHint: "Add related activity",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		TabVisaCaption: "Approvals",
		TimelineTabCaption: "Timeline",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		},
		JoinCameraIcon: {
			source: 3,
			params: {
				schemaName: "ActivityPageV2",
				resourceItemName: "JoinCameraIcon",
				hash: "da1f1ae66410c17ede772884533443c2",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});