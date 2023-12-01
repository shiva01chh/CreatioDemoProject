define("OpportunityPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		OpportunityPageV28TabCaption: "Leads",
		Client: "Customer",
		TagButtonHint: "Tags",
		CustomerContacts: "Contacts",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldLockHint: "Non-editable field",
		ClearButtonHint: "Clear value",
		StageTip: "Current opportunity stage. When the value in this field is changed, it is recorded in the [Stage history] detail.",
		DueDateTip: "Planned or actual date to close the opportunity. This field is completed automatically and becomes non-editable when the opportunity moves to the final stage",
		ProbabilityTip: "The maximum value for this field depends on the current opportunity stage, configured in the [Opportunity stages] lookup",
		ClientTip: "A company or individual for whom the opportunity was created. Records from the [Accounts] and [Contacts] section are available in this field. \u003Ca href=\u0022#\u0022 data-context-help-id=\u00221571\u0022 \u003ERead more\u003C/a\u003E",
		MoodTip: "Choose an emoticon to reflect your mood towards the current opportunity",
		OwnerTip: "Full name of the owner of the record. Select the owner from the contacts registered as users in the system",
		CompletenessHint: "Percentage of profile completion. Click on the indicator to view which data you need to complete the profile.",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		DaysInFunnelCaption: "days in funnel",
		DaysAtStageCaption: "Days at current stage:",
		DescriptionGroupCaption: "Description",
		LeadTypeCaption: "Customer need",
		DecisionMakerCaption: "Decision maker",
		ProbabilityCaption: "probability",
		MoodCaption: "manager mood",
		SaveButtonCaption: "Save",
		CancelButtonCaption: "Cancel",
		ActionButtonCaption: "Actions",
		GeneralInfoTabCaption: "Opportunity details",
		ProductsTabCaption: "Products",
		VisaTabCaption: "Approvals",
		HistoryTabCaption: "Opportunity history",
		NotesTabCaption: "Attachments and notes",
		SendToVisaCaption: "Send for approval",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		NewRecordPageCaptionSuffix: ": New record",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		OpportunityBudgetTermsBlockCaption: "Budget and terms",
		FirstOpportunityCaption: "New customer",
		SecondOpportunityCaption: "Existing customer",
		TacticAndCompetitorTabCaption: "Tactics and competitors",
		HistoryCustomerTabCaption: "Customer history",
		OpportunityManagementItemCaption: "Run corporate sale process",
		ProbabilityInvalidCaption: "Enter value from 0 to 100",
		ProbabilityIsGreaterThenMaxProbabilityByStageMessageCaption: "Maximum probability for this stage is ",
		CustomerOpportunitiesCaption: "Opportunities",
		CustomerActivitiesCaption: "Activities",
		CustomerFilesCaption: "Attachments and notes",
		CustomerNotesCaption: "Account notes",
		SetOwnerActionCaption: "Assign owner",
		OwnerLookupCaption: "Owner",
		ProcessNotFound: "Corporate sale process not found. To be able to run the process, specify it in the \u0022Corporate sale process\u0022 system setting",
		CurrentOpportunityNotFound: "Current opportunity not found",
		ChangeActivityOwnerQuestion: "Do you want to change {0} to {1} in all uncompleted activities?",
		MoodListCaption: "Sales rep\u0027s mood",
		ProcessAlreadyRunning: "Corporate sale process is already started for this opportunity.",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		ProbabilityMetricHint: "You can change the probability in the \u0022Probability, %\u0022 field on the \u0022Opportunity details\u0022 tab",
		DelayExecutionButtonCaption: "Perform later",
		ProcessEntryPointButtonCaption: "Move down the process",
		CloseButtonCaption: "Close",
		ViewOptionsButtonCaption: "View",
		OpenSectionDesignerButtonCaption: "Open page designer",
		FieldValidationError: "Field \u0022{0}\u0022: {1}",
		PrintButtonCaption: "Print",
		OpenListSettingsCaption: "List setup",
		ProsessButtonCaption: "Run process",
		BeginProcessButtonMenuItemCaption: "Start process",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		QuickAddButtonHint: "Add related activity",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		TabVisaCaption: "Approvals",
		TimelineTabCaption: "Timeline",
		ESNTabCaption: "Feed",
		SubscribeCaption: "Follow the feed",
		UnsubscribeCaption: "Unfollow the feed",
		SubscribedInformationDialog: "You are now following feed: {0}",
		UnsubscribedInformationDialog: "You have stopped following feed: {0}",
		PredictiveProbabilityCaption: "predictive probability",
		PredictiveProbabilityMetricHint: "Opportunity win probability based on historical patterns and real-time data of the opportunity. \u003Ca href=\u0022#\u0022 data-context-help-id=\u00221874\u0022 \u003EDetails...\u003C/a\u003E",
		EditRightsCaption: "Set up access rights",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenChangeLogMenuCaption: "View change log",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BantIcon: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "BantIcon",
				hash: "0547617eeb9a36daf55cedeb815555b9",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "OpportunityPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});