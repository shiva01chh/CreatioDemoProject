﻿define("PreconfiguredEntityPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		ActionButtonCaption: "Actions",
		ActivitiesTabCaption: "Activities",
		BeginProcessButtonMenuItemCaption: "Start process",
		CancelButtonCaption: "Cancel",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		ClearButtonHint: "Clear value",
		CloseButtonCaption: "Close",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		ContactCareerInfoChanged: "Information about contact job experience was changed. Add new record on the Job experience detail?",
		ContactResourcesCaption: "Contact resources",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DelayExecutionButtonCaption: "Perform later",
		EditRightsCaption: "Set up access rights",
		FieldLockHint: "Non-editable field",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldValidationError: "Field \u0022{0}\u0022: {1}",
		FillContactQuestion: "At least one social network profile must be specified for the contact in order to run this action.",
		FillSocialDataCaption: "Fill in with data from social networks",
		GeneralInfoTabCaption: "Contact info",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		HistoryTabCaption: "History",
		IncrementMaskSuffix: "CodeMask",
		IncrementNumberSuffix: "LastNumber",
		JobTabCaption: "Current employment",
		NewRecordPageCaptionSuffix: ": New record",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenChangeLogMenuCaption: "View change log",
		OpenContactCardQuestion: "To perform the action, specify at least one social network account for the contact",
		OpenListSettingsCaption: "List setup",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		OpenSectionDesignerButtonCaption: "Open page designer",
		OwnerTip: "Full name of the record owner. Select the owner from the contacts registered as users in the system.",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		PageHeaderTemplate: "{0} / {1}",
		PreferredLanguageTipMessage: "\u003Cp\u003EContact\u0027s preferred language. Creatio will use email templates in this language for email notifications. If a template in the contact\u0027s preferred language is unavailable, Creatio will use a \u003Ca href=\u0022../Nui/ViewModule.aspx#CardModuleV2/SysSettingPage/edit/8fc03719-87fe-4652-add0-3c1038607af8\u0022\u003Edefault language\u003C/a\u003E template. You can select only active languages. Go to the \u003Ca href=\u0022../Nui/ViewModule.aspx#LookupSectionModule/CustomerLanguagesLookupSection\u0022\u003ELanguages lookup\u003C/a\u003E to activate/deactivate languages\u003C/p\u003E",
		PrintButtonCaption: "Print",
		ProcessEntryPointButtonCaption: "Move down the process",
		ProsessButtonCaption: "Run process",
		QuickAddButtonHint: "Add related activity",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		RibbonTabCaption: "Feed",
		SaveButtonCaption: "Save",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		TabVisaCaption: "Approvals",
		TagButtonHint: "Tags",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {
		TextParameter1: "TextParameter1",
		LookupParameter1: "LookupParameter1"
	};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		},
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "BlankSlateIcon",
				hash: "1b81bfab6f136e6c62e7f1bf3fe0e354",
				resourceItemExtension: ".png"
			}
		},
		EnrichCloudIcon: {
			source: 3,
			params: {
				schemaName: "PreconfiguredEntityPageV2",
				resourceItemName: "EnrichCloudIcon",
				hash: "588f9021245791159b6a98d86790d502",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});