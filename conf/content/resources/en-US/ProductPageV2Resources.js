define("ProductPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		PricesTabCaption: "Prices and availability",
		CategoryGroupCaption: "Segmentation",
		BasePriceGroupCaption: "Base price",
		SpecificationTabCaption: "Features",
		ProductInformation: "Product information",
		SelectionInformationTabCaption: "Product selection information",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		ActionButtonCaption: "Actions",
		BeginProcessButtonMenuItemCaption: "Start process",
		CancelButtonCaption: "Cancel",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		ClearButtonHint: "Clear value",
		CloseButtonCaption: "Close",
		CodeTip: "Product code. Check the product code if several products have the same name",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DelayExecutionButtonCaption: "Perform later",
		EditRightsCaption: "Set up access rights",
		FieldLockHint: "Non-editable field",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldValidationError: "Field \u0022{0}\u0022: {1}",
		FilesTabCaption: "Attachments and notes",
		GeneralInfoTabCaption: "General information",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		IncrementMaskSuffix: "CodeMask",
		IncrementNumberSuffix: "LastNumber",
		IsArchiveTip: "Products that should not be offered to the customer. Inactive products are not displayed on the product selection page",
		NewRecordPageCaptionSuffix: ": New record",
		NotesAndFilesTabCaption: "Attachments and notes",
		NotesGroupCaption: "Notes",
		OpenChangeLogMenuCaption: "View change log",
		OpenListSettingsCaption: "List setup",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		OpenSectionDesignerButtonCaption: "Open page designer",
		OwnerTip: "Full name of the record owner. Select the owner from the contacts registered as users in the system.",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		PageHeaderTemplate: "{0} / {1}",
		PriceGroupCaption: "Price",
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
		TagButtonHint: "Tags",
		UrlTip: "A link to the manufacturer\u2019s website",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		DefaultPhoto: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "DefaultPhoto",
				hash: "1ee9c021f5b1fb640064c7292634d10f",
				resourceItemExtension: ".png"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "ProductPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});