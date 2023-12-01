define("BulkEmailSectionV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		MandrillSettingsActionCaption: "Mandrill settings",
		SendButtonCaption: "Start sending",
		MandrillInteractionTargetNotFound: "Error while starting. The target audience does not contain recipients whose responses are: \u00ABPlanned\u00BB, \u00ABGeneral request error\u00BB, \u00ABRejected\u00BB",
		MandrillMassMailingSuccessMessage: "Bulk email start completed successfully",
		MandrillMassMailingFailsMessage: "Bulk email start has failed",
		SendTestEmailActionCaption: "Send test email",
		CantDeleteMessageCaption: "The bulk email could be deleted if its status is \u0022Planned\u0022 or \u0022Draft\u0022.",
		GoToSplitTestsCaption: "Go to Split tests",
		BreakButtonCaption: "Stop sending",
		SendMailingActionHint: "To start sending a trigger email, you need to start the campaign connected to it.\nConnect the trigger email to the campaign and start it. The emails will be sent automatically.",
		GoToBpmonlineCloudIntegrationCaption: "Setup domain to receive email responses",
		GoToBpmonlineCloudIntegrationCaptionV2: "Email settings",
		OpenBulkEmailEventLogCaption: "Mailing log",
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
		ContinueProcessButtonMenuItemCaption: "Continue process",
		DashboardsDataViewHint: "Dashboards",
		DeleteChart: "Are you sure that you want to delete the selected items?",
		DeleteChartButtonCaption: "Delete",
		DeleteConfirmationMessage: "Are you sure that you want to delete the selected record?",
		DeleteRecordButtonCaption: "Delete",
		DiscardChangesButtonCaption: "Cancel",
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
		ListDataViewHint: "List",
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
		QueryOptimizationFailedRecommendation: "Please try changing the filter parameters or contact technical support.",
		QueryOptimizationFailedTitle: "Unfortunately, your filter could not be processed within the time allotted.",
		QuickAddButtonHint: "Add related activity",
		ReExecuteMessage: "We are doing our best to optimize your filter. This will not take long.",
		ReportListHeaderCaption: "Reports",
		ReportsButtonCaption: "Reports",
		RunProsessButtonCaption: "Run process",
		SaveRecordButtonCaption: "Save",
		ScrollTopCaption: "Up",
		SectionQuickFilterButtonCaption: "Quick filter",
		SelectAllButtonCaption: "Select all",
		SelectedFolderButtonCaption: "Folders",
		SelectMultipleRecordsButtonCaption: "Select multiple records",
		SelectOneRecordButtonCaption: "Cancel multiple selection",
		ShowAllFoldersButtonCaption: "Show all folders",
		ShowRightPanelButtonCaption: "Show notification panel",
		SortButtonCaption: "Sort by",
		SortMenuCaption: "Sort by",
		SubscribeCaption: "Follow the feed",
		UnGroupMenuItemCaption: "Ungroup",
		UnselectAllButtonCaption: "Deselect all",
		UnsubscribeCaption: "Unfollow the feed",
		ViewOptionsButtonCaption: "View",
		Caption: "Email"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BulkEmailImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "BulkEmailImage"
			}
		},
		TriggerEmailImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "TriggerEmailImage"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		ToggleSectionButton: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "ToggleSectionButton",
				hash: "7e47411934e85e6cf9834ebc72cff3e6",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "SortIcon",
				hash: "c0d8dfe7b1416f4c916f1d82523355ae",
				resourceItemExtension: ".svg"
			}
		},
		SummariesIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "SummariesIcon",
				hash: "f1f5f60ee306afca15aa461aac0fdad8",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		DataLoadFailedImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "DataLoadFailedImage",
				hash: "addbd12b1b53bcb56b1580c71598f4e6",
				resourceItemExtension: ".svg"
			}
		},
		AddTagsButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "AddTagsButtonImage",
				hash: "c4683cf6e3fd3e28b391ff180a9c9c3d",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		ShowDuplicatesBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailSectionV2",
				resourceItemName: "ShowDuplicatesBtnImage",
				hash: "fa120a8db42142879bc508b69c6a5993",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});