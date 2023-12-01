define("LeadPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SaveButtonCaption: "Save",
		CancelButtonCaption: "Cancel",
		ActionButtonCaption: "Actions",
		GeneralInfoTabCaption: "Lead info",
		HistoryTabCaption: "History",
		FeedTabCaption: "Feed",
		LeadPageCategorizationBlockCaption: "Segmentation",
		LeadPageCommunicationBlockCaption: "Contact details",
		LeadPageAddressBlockCaption: "Address",
		LeadPageNeedValidationBlockCaption: "Verification required",
		CreatedContactMessage: " Contact record created: {0}.",
		RequiredFieldsMessage: "Please, fill in either the \u0022Contact\u0022 or \u0022Account\u0022 field",
		DisqualifyLeadActionMessage: "Disqualify this lead?",
		CreatedAccountMessage: "Account record created: {0}.",
		QualifyLeadCaption: "Qualify",
		DisqualifyGroupCaption: "Disqualify",
		DisqualifyLeadLost: "Lost",
		DisqualifyLeadNoConnection: "Unable to connect",
		DisqualifyLeadNotInterested: "No longer interested",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		NewRecordPageCaptionSuffix: ": New record",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
		SourceGroupCaption: "Lead engagement",
		CityStrCaption: "City",
		RegionStrCaption: "State/province",
		CountryStrCaption: "Country",
		LeadPageNeedValidationInfo: "Perhaps, some of the landing page fields were filled in incorrectly.Correct the lead address entry error or add new values to the lookup.",
		LeadPageContactInfoCaption: "Contact info",
		LeadPageAccountInfoCaption: "Account info",
		LeadPageGeneralTabContainerCaption: "Lead info",
		QualifiedContactCaption: "Contact",
		QualifiedAccountCaption: "Account",
		AccountNameCaption: "Account name",
		QualifyStatusQualificationCaption: "Qualify",
		QualifyStatusDistributionCaption: "Distribute",
		QualifyStatusTranslationForSaleCaption: "Proceed to handoff",
		ESNTabCaption: "Feed",
		SubscribeCaption: "Follow the feed",
		UnsubscribeCaption: "Unfollow the feed",
		SubscribedInformationDialog: "You are now following feed: {0}",
		UnsubscribedInformationDialog: "You have stopped following feed: {0}",
		LeadPageTransferToSaleInfoCaption: "Handoff to sales",
		LeadPageDistributionInfoCaption: "Lead distribution",
		NeedInfoTabCaption: "Customer need details",
		ContactCaption: "Contact name",
		DearCaption: "Recipient\u0027s name",
		GenderCaption: "Gender",
		TitleCaption: "Title",
		JobCaption: "Job title",
		FullJobTitleCaption: "Full job title",
		DepartmentCaption: "Department",
		DecisionRoleCaption: "Role",
		AccountCategoryCaption: "Category",
		IndustryCaption: "Industry",
		EmployeesNumberCaption: "No. of employees",
		AnnualRevenueCaption: "Annual revenue",
		AccountOwnershipCaption: "Business entity",
		EmailCaption: "Email",
		WebsiteCaption: "Web",
		MobilePhoneCaption: "Mobile phone",
		BusinesPhoneCaption: "Business phone",
		FaxCaption: "Fax",
		CountryCaption: "Country",
		AddressCaption: "Address",
		CityCaption: "City",
		AddressTypeCaption: "Address type",
		RegionCaption: "State/province",
		ZipCaption: "ZIP/postal code",
		TagButtonHint: "Tags",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldLockHint: "Non-editable field",
		ClearButtonHint: "Clear value",
		DisqualificationButtonCaption: "Disqualify",
		SimilarContactsButtonNotFoundHintText: "We didn\u2019t find any contacts that can be linked to this lead.",
		SimilarAccountsButtonNotFoundHintText: "We didn\u2019t find any accounts that can be linked to this lead.",
		SimilarAccountsButtonFoundHintText: "Need text.",
		SimilarContactsButtonFoundHintText: "Need text.",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
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
		OpportunityOrOrderCaption: "Opportunity/Order",
		DealOwnerCaption: "Deal owner",
		AccountActivityDetailV2DetailCaptionOnPage: "Account activities",
		AccountAddressDetailDetailCaptionOnPage: "Account addresses",
		AccountCallDetailDetailCaptionOnPage: "Account calls",
		CallDetailDetailCaptionOnPage: "Calls",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		ContactActivityDetailV2DetailCaptionOnPage: "Contact activities",
		ContactAddressDetailV2DetailCaptionOnPage: "Contact addresses",
		ContactCommunicationDetailDetailCaptionOnPage: "Communication options",
		ContactCommunicationDetailV2DetailCaptionOnPage: "Communication options",
		DealInformationCaption: "Opportunity information",
		DealSpecificsTabCaption: "Opportunity info",
		EditRightsCaption: "Set up access rights",
		EmailDetailV2DetailCaptionOnPage: "Email",
		LeadEngagementTabCaption: "Lead engagement",
		LeadPageMQLTabTabCaption: "MQL",
		LeadPageSQLTabOpportunityPlanningGroupGroupCaption: "Opportunity planning",
		LeadPageSQLTabTabCaption: "SQL",
		LeadProductDetailV2DetailCaptionOnPage: "Products",
		LeadSpecificationDetailDetailCaptionOnPage: "Features",
		LeadsSimilarSearchResultDetailDetailCaptionOnPage: "Similar leads",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenChangeLogMenuCaption: "View change log",
		OrderCaption: "Order",
		PredictiveScoreNotEvaluatedCaption: "not evaluated",
		PredictiveScoreTip: "Lead conversion probability based on historical patterns and real-time data of the lead. \u003Ca href=\u0022#\u0022 data-context-help-id=\u00221863\u0022 \u003EDetails...\u003C/a\u003E",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		SearchAccountInGoogleNotEnoughInfoMessage: "To search on Google you should fill in the field \u0022Account name\u0022",
		SearchAccountInLinkedInNotEnoughInfoMessage: "To search on LinkedIn you should fill in the field \u0022Account name\u0022",
		SearchContactInFacebookNotEnoughInfoMessage: "To search on Facebook you should specify Email",
		SearchContactInLinkedInNotEnoughInfoMessage: "To search on LinkedIn you should fill in at least one of the fields \u0022Contact name\u0022, \u0022Account name\u0022",
		SearchGoogle: "Search in Google",
		TabVisaCaption: "Approvals",
		TimelineTabCaption: "Timeline",
		ContactAddressDetailDetailCaptionOnPage: "Contact addresses",
		ContactCallDetailDetailCaptionOnPage: "",
		ContactCallDetailV2DetailCaptionOnPage: "Contact calls",
		ExtendedLeadInformationDetailDetailCaptionOnPage: "Extended lead information",
		LeadGenExtendedLeadInformationDetailDetailCaptionOnPage: "Extended lead information",
		BlankSlateDescription: "Your browser is not supported. Please use Chrome, Safari or Firefox in order to work with contact event\u0027s history",
		TrackingEventsTabCaption: "Website events",
		LabelNoDataCaption: "There are no website events for this record.",
		LabelLoadingCaption: "Data loading is in progress. This may take a few seconds.",
		ButtonLoadMoreCaption: "Load more",
		ColumnNameCostCaption: "Cost",
		ColumnNameDateTimeCaption: "Date Time",
		ColumnNameEventTypeCaption: "Event Type",
		ColumnNameNameCaption: "Name",
		ColumnNameValueCaption: "Value",
		PropertyDisplayCaption: "Display",
		PropertyLanguageCaption: "Language",
		PropertyPageUrlCaption: "Page url",
		PropertyRefererCaption: "Referer",
		ShowTrackingDataCaption: "Show tracking data",
		PropertyBrowserCaption: "Browser",
		PropertyPlatformCaption: "Platform",
		PropertyLanguagesCaption: "Languages",
		PropertyPixelDepthCaption: "Pixel Depth",
		PropertyColorDepthCaption: "Color Depth",
		PropertyScreenAvailCaption: "Screen Avail",
		SearchFacebook: "Search in Facebook",
		SearchLinkedIn: "Search in LinkedIn"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "BackButtonImage",
				hash: "96d05bdc934e78ab86fd88b37ba48fe9",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		QualificationProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "QualificationProcessButtonImage",
				hash: "26887aba2ff694652d0458946db6083b",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		SimilarContactsButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "SimilarContactsButtonImage",
				hash: "6144c645b6a5ae888e37b60a53e29efa",
				resourceItemExtension: ".png"
			}
		},
		SimilarAccountsButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "SimilarAccountsButtonImage",
				hash: "09560fa82b1f17523c908f1b7d1d9ec6",
				resourceItemExtension: ".png"
			}
		},
		SearchInternetButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "SearchInternetButtonImage",
				hash: "73096457057ad78a7d6efaec73f116ff",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		},
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "BlankSlateIcon",
				hash: "1b81bfab6f136e6c62e7f1bf3fe0e354",
				resourceItemExtension: ".png"
			}
		},
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "LeadPageV2",
				resourceItemName: "InfoSpriteImage",
				hash: "15d4e5358792ef12351d7d6caa59dfb2",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});