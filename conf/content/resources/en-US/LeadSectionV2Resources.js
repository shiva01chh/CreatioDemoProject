define("LeadSectionV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ActionsButtonCaption: "Actions",
		AddChartButtonCaption: "New chart",
		AddDynamicFolderButtonCaption: "Dynamic",
		AddFolderButtonCaption: "New folder",
		AddQuickFilter: "Add filter",
		AddRecordButtonCaption: "New",
		AddStaticFolderButtonCaption: "Static",
		AnalyticsDataViewCaption: "Open dashboards",
		BackButtonHint: "Show vertical view",
		BeginProcessButtonMenuItemCaption: "Start process",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		ChartListHeaderCaption: "Charts",
		CloseButtonCaption: "Close",
		CombinedModeTagsButtonHint: "Tags",
		ConfigureLeadTypes: "Set up customer needs",
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DashboardsDataViewHint: "Dashboards",
		DeleteChart: "Are you sure that you want to delete the selected items?",
		DeleteChartButtonCaption: "Delete",
		DeleteConfirmationMessage: "Are you sure that you want to delete the selected record?",
		DeleteRecordButtonCaption: "Delete",
		DiscardChangesButtonCaption: "Cancel",
		DisqualificationButtonCaption: "Disqualify",
		DisqualifyGroupCaption: "Disqualify",
		DisqualifyLeadLost: "Lost",
		DisqualifyLeadNoConnection: "Unable to connect",
		DisqualifyLeadNotInterested: "No longer interested",
		DuplicatesActionCaptionPattern: "Show duplicate \u0027{0}\u0027",
		EditChartButtonCaption: "Edit",
		EditRightsCaption: "Set up access rights",
		EmptyDynamicGroupDescription: "Clear the filter or change its conditions.",
		EmptyDynamicGroupRecommendation: "",
		EmptyDynamicGroupTitle: "There are no records matching the group settings.",
		EmptyFilterDescription: "Clear the filter or change its conditions.",
		EmptyFilterRecommendation: "",
		EmptyFilterTitle: "There are no records matching the filter criteria.",
		EmptyGroupDescription: "Add records to the group.",
		EmptyGroupRecommendation: "Learn more about this feature from the {0}Academy{1}.",
		EmptyGroupTitle: "The selected static folder is empty.",
		EmptyInfoDescription: "Add a new record to make it look prettier.",
		EmptyInfoRecommendation: "Learn more about this section from the {0}Academy{1}.",
		EmptyInfoTitle: "This section has no records.",
		ExcludeFromFolderButtonCaption: "Exclude from folder",
		ExportListToExcelFileButtonCaption: "Export to Excel",
		ExportListToFileButtonCaption: "Export list to file",
		FiltersCaption: "Filter",
		FindDuplicatesButtonCaption: "Find duplicates",
		GridDataViewCaption: "Open records list",
		GroupMenuItemCaption: "Group",
		HideLeftPanelButtonCaption: "Hide section panel",
		HideVerticalViewButtonHint: "Hide vertical view",
		IncludeInFolderButtonCaption: "Add to folder",
		LeadScoredBody: "Predictive lead score is {0}",
		LeadScoredTitle: "Lead \u0022{0}\u0022",
		ListDataViewHint: "List",
		ManageWebForms: "Manage landing pages of external resources",
		MoveDownMenuItemCaption: "Down",
		MoveUpMenuItemCaption: "Up",
		MultiDeleteConfirmationMessage: "Are you sure that you want to delete the selected records?",
		MultiTagButtonCaption: "Add tag",
		OpenAnalyticsViewButtonCaption: "Analytics",
		OpenChangeLogMenuCaption: "View change log",
		OpenGridSettingsCaption: "Select fields to display",
		OpenListSettingsCaption: "List setup",
		OpenNewSectionDesignerButtonCaption: "Open new section wizard",
		OpenObjectChangeLogSettingsCaption: "Change log setup",
		OpenPageDesignerButtonCaption: "Open page designer",
		OpenSectionDesignerButtonCaption: "Open section wizard",
		OpenSummarySettingsModuleButtonCaption: "Set up summaries",
		OperationAccessDenied: "Current user does not have sufficient permissions to run \u0022{0}\u0022",
		PrintButtonCaption: "Print",
		PrintFormButtonCaption: "Printables",
		ProcessEntryPointButtonCaption: "Move down the process",
		ProsessButtonCaption: "Run process",
		QualifyLeadCaption: "Qualify",
		QualifyLeadProcessUId: "3B3E3806-A913-4BE0-9AFD-FCDF681C0DFF",
		QualifyStatusDistributionCaption: "Distribute",
		QualifyStatusQualificationCaption: "Qualify",
		QualifyStatusTranslationForSaleCaption: "Proceed to handoff",
		QueryOptimizationFailedRecommendation: "Please try changing the filter parameters or contact technical support.",
		QueryOptimizationFailedTitle: "Unfortunately, your filter could not be processed within the time allotted.",
		QuickAddButtonHint: "Add related activity",
		ReExecuteMessage: "We are doing our best to optimize your filter. This will not take long.",
		ReportListHeaderCaption: "Reports",
		ReportsButtonCaption: "Reports",
		RunProsessButtonCaption: "Run process",
		SaveRecordButtonCaption: "Save",
		ScoreLeadActionCaption: "Evaluate predictive score",
		ScoreLeadActionGeneralErrorMessage: "Action has been finished with failure. You can find details in the application log",
		ScoreLeadActionNoModelsErrorMessage: "There are no predictive lead scoring models available",
		ScrollTopCaption: "Up",
		SectionQuickFilterButtonCaption: "Quick filter",
		SelectAllButtonCaption: "Select all",
		SelectedFolderButtonCaption: "Folders",
		SelectMultipleRecordsButtonCaption: "Select multiple records",
		SelectOneRecordButtonCaption: "Cancel multiple selection",
		ShowAllFoldersButtonCaption: "Show all folders",
		ShowOnMap: "Show on map",
		ShowRightPanelButtonCaption: "Show notification panel",
		SortButtonCaption: "Sort by",
		SortMenuCaption: "Sort by",
		SubscribeCaption: "Follow the feed",
		UnGroupMenuItemCaption: "Ungroup",
		UnselectAllButtonCaption: "Deselect all",
		UnsubscribeCaption: "Unfollow the feed",
		ViewOptionsButtonCaption: "View",
		Caption: "Leads"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		QualificationProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "QualificationProcessButtonImage",
				hash: "26887aba2ff694652d0458946db6083b",
				resourceItemExtension: ".png"
			}
		},
		QualificationProcessActionImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "QualificationProcessActionImage",
				hash: "866879ee69e50f1900d3c42457a00284",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "EmptyInfoImage",
				hash: "84410c143d7a4e3bfdbeda3db0408fca",
				resourceItemExtension: ".png"
			}
		},
		EmptyFilterImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "EmptyFilterImage",
				hash: "7bf68ba9d5b686f7e46b0e23e89821bb",
				resourceItemExtension: ".png"
			}
		},
		EmptyGroupImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "EmptyGroupImage",
				hash: "be776f867efb6ad7e233612d77f19c12",
				resourceItemExtension: ".png"
			}
		},
		EmptyDynamicGroupImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "EmptyDynamicGroupImage",
				hash: "3d0048d99789c16848dbee2239555758",
				resourceItemExtension: ".png"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		ToggleSectionButton: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "ToggleSectionButton",
				hash: "7e47411934e85e6cf9834ebc72cff3e6",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "SortIcon",
				hash: "c0d8dfe7b1416f4c916f1d82523355ae",
				resourceItemExtension: ".svg"
			}
		},
		SummariesIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "SummariesIcon",
				hash: "f1f5f60ee306afca15aa461aac0fdad8",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		DataLoadFailedImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "DataLoadFailedImage",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		},
		AddTagsButtonImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "AddTagsButtonImage",
				hash: "c4683cf6e3fd3e28b391ff180a9c9c3d",
				resourceItemExtension: ".svg"
			}
		},
		ShowDuplicatesBtnImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "ShowDuplicatesBtnImage",
				hash: "fa120a8db42142879bc508b69c6a5993",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		MLIcon: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "MLIcon",
				hash: "4f57fdf4d632a5cf20224be92c743b28",
				resourceItemExtension: ".png"
			}
		},
		MLIconSvg: {
			source: 3,
			params: {
				schemaName: "LeadSectionV2",
				resourceItemName: "MLIconSvg",
				hash: "5e9f2e2d41f9dcec78d998245d4afe27",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});