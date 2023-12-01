﻿define("Tasks_DetailResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ActionsButtonCaption: "Actions",
		AddButtonCaption: "New",
		Caption: "Tasks",
		CopyMenuCaption: "Copy",
		DeleteConfirmationMessage: "Are you sure that you want to delete the selected record?",
		DeleteMenuCaption: "Delete",
		DetailWizardMenuCaption: "Detail setup",
		EditMenuCaption: "Edit",
		ExportListToExcelFileButtonCaption: "Export to Excel",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		LoadMoreButtonCaption: "Show more",
		MasterRecordIdErrorMessage: "MasterRecordId parameter is not initialized in {0} detail, with hash {1}",
		MultiDeleteConfirmationMessage: "Are you sure that you want to delete the selected records?",
		MultiModeMenuCaption: "Select multiple records",
		OpenObjectChangeLogSettingsCaption: "Change log setup",
		OpenRecordChangeLogCaption: "View change log",
		OperationAccessDenied: "Current user does not have sufficient permissions to run \u0022{0}\u0022",
		ProcessButtonHint: "Run process by record",
		QuickFilterCaption: "Apply filter",
		RecordRightsSetupMenuItemCaption: "Set up access rights",
		RelationshipButtonHint: "By the child connections",
		RemoveQuickFilterCaption: "Hide filter",
		SchemaLocalizableString1: "",
		SetupGridMenuCaption: "Columns setup",
		SetupTotalMenuCaption: "Summaries setup",
		SingleModeMenuCaption: "Cancel multiple selection",
		SortMenuCaption: "Sort by",
		ToolsButtonHint: "Actions",
		ViewButtonCaption: "View"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		LoadMoreIcon: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "LoadMoreIcon",
				hash: "010a38d79ad1acb4726eb1dae1d7f14c",
				resourceItemExtension: ".png"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		},
		RelationshipButtonImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "RelationshipButtonImage",
				hash: "057ce8936048a846d19c7a9644c93a2b",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		ImageFilter: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "ImageFilter",
				hash: "ef37ab38ddacefd3ba86c6bbcf4e7501",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "SortIcon",
				hash: "f5e0b50ec74a47fb66f7d7d403b760c3",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "GridSettingsIcon",
				hash: "3f4eb707ce7f259fce295490879a8f9b",
				resourceItemExtension: ".svg"
			}
		},
		FilterIcon20: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "FilterIcon20",
				hash: "124f910abe91ebe4045613a9c5b379d1",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		OpenRecordChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "Tasks_Detail",
				resourceItemName: "OpenRecordChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});