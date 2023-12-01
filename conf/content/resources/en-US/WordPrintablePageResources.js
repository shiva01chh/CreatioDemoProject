define("WordPrintablePageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ReportCaptionLabel: "Report name",
		ShowInSectionLabel: "Show in the section list view",
		ShowInCardLabel: "Show in the section record page",
		MacrosListDetailCaption: "Set up report data",
		TablePartsDetailCaption: "Set up report tables",
		MacrosListDetailInfoButtonText: "Select the fields that contain the data to display in the report. You can also use additional features of \u003Ca href=\u0022https://academy.creatio.com/docs/developer/application_components/reports/ms_word/overview\u0022 target=\u0022_blank\u0022\u003Ebasic macros\u003C/a\u003E",
		TablePartsDetailInfoButtonText: "Select the fields that will be used to generate the report tables",
		EmptyDetailMessageCaption: "No data",
		InfoBlockCaption: "Note",
		InfoBlockStepsCaption: "To setup report:",
		InfoBlockStep1: "Install the Microsoft Word \u003Ca href=\u0022https://academy.creatio.com/documents?product=administration\u0026ver=7\u0026id=1412\u0022 target=\u0022_blank\u0022\u003Eplugin\u003C/a\u003E.",
		InfoBlockStep2: "Add the report\u0027s fields and table components. This page contains all the necessary settings.",
		InfoBlockStep3: "Open Microsoft Word and configure the report template. Save your to Creatio by running the corresponding command in the Microsoft Word plug-in.",
		InfoBlockDescription: "You can open an existing template for editing from the plugin. To do this, open Microsoft Word and select the desired template from the list.",
		InfoBlockAcademyLinkCaption: "Learn more about customizing Microsoft Word reports in Creatio Academy.",
		InfoBlockAcademyLink: "https://academy.creatio.com/documents?product=administration\u0026ver=7\u0026id=1247",
		TablePartsHeaderLabel: "Table name",
		EditButtonHint: "Edit",
		RemoveButtonHint: "Delete",
		FileImportContainerDescription: "In order to download to a PC or upload a Word report template to Creatio, use the steps below:",
		FileImportDragAndDropContainerCaption: "Drag and drop *.docx template here or",
		FileImportInvalidFileTypeMessage: "Incorrect file format. Please select an Word file (*.docx).",
		FileImportUploadFileButtonCaption: "Select file",
		FileImportDownloadTemplateFileCaption: "Download template",
		FileImportUploadTemplateFileCaption: "Upload template",
		TemplateSuccessfullyUploadedMessage: "Report template was successfully uploaded",
		Template404UploadError: "The report with current identifier is absent.",
		Template405UploadError: "The service is currently not available.",
		Template406UploadError: "Creatio was unable to parse the file. The file may be empty, encrypted or damaged. Please upload a different *.docx file.",
		TemplateGeneralUploadError: "Something went wrong.",
		FileImportInvalidSizeMessage: "File wasn\u0027t uploaded in case of maximum file size ({0} Mb) restrictions{1}.",
		CopyButtonHint: "Copy",
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
		SaveButtonCaption: "Apply",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		ViewOptionsButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "AddTablePartIcon",
				hash: "b11840aa9348d9fd899b60ae858049d4",
				resourceItemExtension: ".png"
			}
		},
		EditTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "EditTablePartIcon",
				hash: "bfa74c173dd5e19deb25bbfea4c8e8f4",
				resourceItemExtension: ".svg"
			}
		},
		DeleteTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "DeleteTablePartIcon",
				hash: "3fb6fd3ff62f2e034a562effe92797e9",
				resourceItemExtension: ".svg"
			}
		},
		InfoBlockIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "InfoBlockIcon",
				hash: "08c12172d20c0926ec5731d7af079b53",
				resourceItemExtension: ".png"
			}
		},
		FileImportEmptyFileImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportEmptyFileImage",
				hash: "9d99e0183abbfda84ee859aa557b6bef",
				resourceItemExtension: ".png"
			}
		},
		FileImportErrorFileImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportErrorFileImage",
				hash: "d4222016d16f215c574962f02d154ca9",
				resourceItemExtension: ".png"
			}
		},
		FileImportWordIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportWordIcon",
				hash: "923b887731f81456b4743c2950366855",
				resourceItemExtension: ".png"
			}
		},
		FileImportDeleteTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportDeleteTemplateIcon",
				hash: "42b5b815fe5ef39879666f4595bd892b",
				resourceItemExtension: ".png"
			}
		},
		FileImportUploadTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportUploadTemplateIcon",
				hash: "0f4758efe5e8a937c5870a5ce4153902",
				resourceItemExtension: ".png"
			}
		},
		FileImportDownloadTemplateIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "FileImportDownloadTemplateIcon",
				hash: "5b9ce4a5d057cb47179b1dcfeb373cb5",
				resourceItemExtension: ".png"
			}
		},
		CopyTablePartIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "CopyTablePartIcon",
				hash: "07a9eac5c56f1e2b11f1f564eabb0651",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "WordPrintablePage",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});