define("BulkEmailAudienceDetailResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		DetailCaption: "Audience",
		ActionsButtonCaption: "Actions",
		AddButtonCaption: "New",
		AddContactCaption: "Add contact",
		AddContactFolderCaption: "Add contact folder",
		Caption: "",
		ContactsOfOneWillBeAdded: "The contacts from {0} folder will be added to the audience. A message about its completion will appear in the notification area.",
		ContactsWillBeAdded: "The contacts from {0} folders will be added to the audience. A message about its completion will appear in the notification area.",
		CopyMenuCaption: "Copy",
		DeleteAllConfirmationMessage: "Are you sure you want to delete all items from bulk email audience?",
		DeleteAllMenuCaption: "Remove audience",
		DeleteConfirmationMessage: "Are you sure that you want to delete the selected record?",
		DeleteMenuCaption: "Delete",
		DeleteSelectedConfirmationMessage: "Are you sure you want to delete the selected items from bulk email audience?",
		DeleteSelectedMenuCaption: "Delete selected records",
		DetailWizardMenuCaption: "Detail setup",
		EditMenuCaption: "Edit",
		ExportListToExcelFileButtonCaption: "Export to Excel",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		InfoButtonDetailBulkEmailMessage: "The audience displays the list of contacts added as the email recipients.Each contact\u0027s response will be shown here.",
		InfoButtonDetailTriggerEmailMessage: "Personal responses will be displayed after receiving them from email provider",
		LoadMoreButtonCaption: "Show more",
		ManageAudienceMenuCaption: "Manage audience",
		ManageAudienceSchemasCaption: "Manage objects",
		MasterRecordIdErrorMessage: "MasterRecordId parameter is not initialized in {0} detail, with hash {1}",
		MultiDeleteConfirmationMessage: "Are you sure that you want to delete the selected records?",
		MultiModeMenuCaption: "Select multiple records",
		OpenObjectChangeLogSettingsCaption: "Change log setup",
		OpenRecordChangeLogCaption: "View change log",
		OperationAccessDenied: "Current user does not have sufficient permissions to run \u0022{0}\u0022",
		ProcessButtonHint: "Run process by record",
		QuickFilterCaption: "Apply filter",
		RecipientsAddedMessage: "{0} contacts out of {1} added",
		RecordRightsSetupMenuItemCaption: "Set up access rights",
		RelationshipButtonHint: "By the child connections",
		RemoveQuickFilterCaption: "Hide filter",
		SchemaLocalizableString1: "",
		SetupGridMenuCaption: "Columns setup",
		SetupTotalMenuCaption: "Summaries setup",
		SingleModeMenuCaption: "Cancel multiple selection",
		SortMenuCaption: "Sort by",
		ToolsButtonHint: "Actions",
		UsageInSplitTestMessage: "Bulk email audience editing is locked. The bulk email is being used in split test.",
		ViewButtonCaption: "View",
		WarningChangeRecipientList: "Changes to the recipients list can be made only for planned or paused bulk emails",
		WarningDeleteRecipient: "Deleted {0} out of {1} records. Only records with \u0022Planned\u0022, \u0022Send error\u0022 or \u0022Canceled\u0022"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultAudienceSchemaImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "DefaultAudienceSchemaImage",
				hash: "d0eb80bba509fcf096c2d6342a202e0f",
				resourceItemExtension: ".svg"
			}
		},
		ManageAudienceSchemasImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ManageAudienceSchemasImage",
				hash: "e477e4299455ce3fdb7d5e5c5d5403a4",
				resourceItemExtension: ".svg"
			}
		},
		InfoSpriteImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "InfoSpriteImage",
				hash: "15d4e5358792ef12351d7d6caa59dfb2",
				resourceItemExtension: ".png"
			}
		},
		LoadMoreIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "LoadMoreIcon",
				hash: "010a38d79ad1acb4726eb1dae1d7f14c",
				resourceItemExtension: ".png"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		},
		RelationshipButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "RelationshipButtonImage",
				hash: "057ce8936048a846d19c7a9644c93a2b",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		ExportToExcelBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ExportToExcelBtnImage",
				hash: "1883b16fe86f1acadfc158894338fc09",
				resourceItemExtension: ".svg"
			}
		},
		ImageFilter: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ImageFilter",
				hash: "ef37ab38ddacefd3ba86c6bbcf4e7501",
				resourceItemExtension: ".svg"
			}
		},
		SortIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "SortIcon",
				hash: "f5e0b50ec74a47fb66f7d7d403b760c3",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "GridSettingsIcon",
				hash: "3f4eb707ce7f259fce295490879a8f9b",
				resourceItemExtension: ".svg"
			}
		},
		FilterIcon20: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "FilterIcon20",
				hash: "124f910abe91ebe4045613a9c5b379d1",
				resourceItemExtension: ".svg"
			}
		},
		ObjectChangeLogSettingsBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "ObjectChangeLogSettingsBtnImage",
				hash: "f0169f1a725a65ec76c564d5e9705277",
				resourceItemExtension: ".svg"
			}
		},
		OpenRecordChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "BulkEmailAudienceDetail",
				resourceItemName: "OpenRecordChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});