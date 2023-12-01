define("BaseOpportunityPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GeneralInfoTabCaption: "Opportunity details",
		Client: "Customer",
		ClientTip: "A company or individual for whom the opportunity was created. Records from the [Accounts] and [Contacts] section are available in this field. \u003Ca href=\u0022#\u0022 data-context-help-id=\u00221571\u0022 \u003ERead more\u003C/a\u003E",
		DecisionMakerCaption: "Decision maker",
		TacticAndCompetitorTabCaption: "Tactics and competitors",
		ProductsTabCaption: "Products",
		HistoryTabCaption: "Opportunity history",
		NotesTabCaption: "Attachments and notes",
		MoodListCaption: "Sales rep\u0027s mood",
		MoodTip: "Choose an emoticon to reflect your mood towards the current opportunity",
		MoodCaption: "manager mood",
		DaysInFunnelCaption: "days in funnel",
		DescriptionGroupCaption: "Description",
		FirstOpportunityCaption: "New customer",
		SecondOpportunityCaption: "Existing customer",
		ProbabilityTip: "The maximum value for this field depends on the current opportunity stage, configured in the [Opportunity stages] lookup",
		OwnerTip: "Full name of the owner of the record. Select the owner from the contacts registered as users in the system",
		DaysAtStageCaption: "Days at current stage:",
		DueDateTip: "Planned or actual date to close the opportunity. This field is completed automatically and becomes non-editable when the opportunity moves to the final stage",
		ProbabilityMetricHint: "You can change the probability in the \u0022Probability, %\u0022 field on the \u0022Opportunity details\u0022 tab",
		ProbabilityCaption: "probability",
		ChangeActivityOwnerQuestion: "Do you want to change {0} to {1} in all uncompleted activities?",
		ProbabilityInvalidCaption: "Enter value from 0 to 100",
		ProbabilityIsGreaterThenMaxProbabilityByStageMessageCaption: "Maximum probability for this stage is ",
		VisaTabCaption: "Approvals",
		SendToVisaCaption: "Send for approval",
		OpportunityBudgetTermsBlockCaption: "Budget and terms",
		HistoryCustomerTabCaption: "Customer history",
		OpportunityManagementItemCaption: "Run corporate sale process",
		CustomerOpportunitiesCaption: "Opportunities",
		CustomerActivitiesCaption: "Activities",
		CustomerFilesCaption: "Attachments and notes",
		CustomerNotesCaption: "Account notes",
		SetOwnerActionCaption: "Assign owner",
		OwnerLookupCaption: "Owner",
		ProcessNotFound: "Corporate sale process not found. To be able to run the process, specify it in the \u0022Corporate sale process\u0022 system setting",
		CurrentOpportunityNotFound: "Current opportunity not found",
		ProcessAlreadyRunning: "Corporate sale process is already started for this opportunity.",
		CustomerContacts: "Contacts",
		StageTip: "Current opportunity stage. When the value in this field is changed, it is recorded in the [Stage history] detail.",
		CompletenessHint: "Percentage of profile completion. Click on the indicator to view which data you need to complete the profile.",
		DaysInFunnelWidgetCaption: "Days in funnel",
		ConfidenceLevelCaption: "Confidence Level",
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
		BantIcon: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "BantIcon",
				hash: "0547617eeb9a36daf55cedeb815555b9",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "BaseOpportunityPage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});