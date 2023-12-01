define("BulkEmailSplitPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GeneralInfoTabCaption: "General information",
		RecipientPercentCaption: "% of recipients to be added to test:",
		StartDateCaption: "Test start date",
		StartManualCaption: "Run test manually",
		SelectAudienceCaption: "Select the audience to participate in the split test",
		StartDateGroupCaption: "When should the test start",
		StartDateRadioCaption: "Start test at the specified time",
		StartManualRadioCaption: "Run test manually",
		StartTestUpdateTargetMessage: "Start error: Audience is being added",
		StartTestEmptyTargetMessage: "Start error: Add an audience",
		StartTestTestRunningTargetMessage: "Start error: Test is already started",
		StartTestDateEmptyMessage: "Start error: Specify test start date",
		StartTestSuccessfulMessage: "Split test has been scheduled for the specified time",
		TestParametersCaption: "Bulk emails",
		AudienceTestCaption: "Audience",
		RunTestCaption: "Start",
		TestResultsCaption: "Results",
		EmailIndicatorsControlGroupCaption: "Unique by test summary",
		RunSplitTestCaption: "Run test",
		AbandonSplitTestCaption: "Stop test",
		StartDateHeadersCaption: "Send time",
		RecipientPercentTooltip: "For example, if you set 20% and add 100 persons in the test audience, then each test audience of each bulk email will include 10 randomly selected contacts. You can only modify the percentage prior to adding groups to the split test audience.",
		StartDateValidationError: "Specify the value",
		StartDateValidationMessage: "To start the test at the scheduled time, enter the test start date and time",
		IncorrectRecipientPercentMessage: "Enter a value in the range of 0.1 - 100",
		IndicatorCaptionForOpens: "Opens",
		IndicatorCaptionForClicks: "Clicks",
		IndicatorCaptionForSoftBounce: "Soft Bounce",
		IndicatorCaptionForHardBounce: "Hard Bounce",
		IndicatorCaptionForUnsubscribe: "Unsubscribes",
		IndicatorCaptionForSpam: "Spam complaints",
		ConfirmationRunTestMessage: "Start split test?",
		StartDateActualValidationMessage: "The planned date of the split test has already passed.",
		StartDateActualValidationAsk: "Run the test now?",
		DetermineWinnerGroupCaption: "Which email wins the test",
		DetermineWinnerLabel: "When the split test is started, the bulk emails included in it will be sent automatically. \u003Cbr\u003ETo find which bulk email has better conversion, analyze the feedback after sending the bulk email (2 to 72 hours depending on the bulk email type).\u003Cbr\u003E\u003Cbr\u003EIf you want to send the bulk email to contacts from your target segment that have not been included in the test bulk email recipients list:\u003Cbr\u003E1) copy the bulk email from the test with best conversion;\u003Cbr\u003E2) use the dynamic folders in the Contacts section to select the bulk email audience.",
		StartTesteEmailAlreadyRunMessage: "Unable to start the split test: bulk emails have already been started.",
		AbandonTesteEmailAlreadyRunMessage: "Unable to cancel the split test: bulk emails have already been started.",
		BulkEmailDetailCaption: "Email stats comparison",
		TryTrialButtonCaption: "Get a trial version",
		DemoDataMessage: "You cannot send emails in Creatio marketing demo version. If you want to use split tests for your bulk emails, get a free 14 day trial version.",
		BulkSplitTestStartErrorDefaultMessage: "Could start split test.\n\nTry once again or contact your system administrator to check integration settings.",
		LicDashboardBtnCaption: "Check the licenses",
		ActiveContactsNotEnoughMsg: "The number of active contacts exceeds the number of purchased licenses. Contact your manager to purchase additional licenses.",
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
		EditRightsCaption: "Set up access rights",
		ESNTabCaption: "Feed",
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
		OpenChangeLogMenuCaption: "View change log",
		OpenListSettingsCaption: "List setup",
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
		SubscribeCaption: "Follow the feed",
		SubscribedInformationDialog: "You are now following feed: {0}",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		TabVisaCaption: "Approvals",
		TagButtonHint: "Tags",
		TimelineTabCaption: "Timeline",
		UnsubscribeCaption: "Unfollow the feed",
		UnsubscribedInformationDialog: "You have stopped following feed: {0}",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "InfoSpriteImage",
				hash: "15d4e5358792ef12351d7d6caa59dfb2",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSplitPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});