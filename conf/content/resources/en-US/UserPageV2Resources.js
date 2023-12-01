define("UserPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SaveButtonCaption: "Save",
		CancelButtonCaption: "Cancel",
		ActionButtonCaption: "Actions",
		ColumnFilterInvalidFormatException: "Filtering by the {0} column is configured incorrectly",
		RequiredFieldIsEmptyCaption: "Fill in the required {0} field to save the record",
		NewRecordPageCaptionSuffix: ": New record",
		IncrementNumberSuffix: "LastNumber",
		IncrementMaskSuffix: "CodeMask",
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
		GeneralInfoTabCaption: "General information",
		AuthControlGroupCaption: "Authentication",
		AuthUseForm: "Creatio authentication",
		AuthUseLdap: "LDAP authentication",
		PasswordCaption: "Password",
		PasswordConfirmationCaption: "Password confirmation",
		UserNameCaption: "Username",
		PasswordMissMatchMessageCaption: "Passwords do not match",
		UserPageHeader: "User",
		UserNameNotUnique: "Administration object with this name or email already exists.",
		AccessRulesTabCaption: "Access rules",
		RolesTabCaption: "Roles",
		SysLicUserTabCaption: "Licenses",
		GrantedRightsTabCaption: "Rights delegation",
		SysLicPackageCaption: "Name",
		ActiveCaption: "Active",
		PasswordMask: "123456789",
		LicAvailableCountCaption: "{0} of {1} available",
		CheckLicensesCaption: "Select all",
		UncheckLicensesCaption: "Clear all",
		DeleteButtonCaption: "Delete",
		DeleteUserMessage: "Are you sure you want to delete this user?",
		DeleteErrorMessage: "Unable to delete the selected user: the user is connected to other objects.",
		PortalUserCaption: "External user",
		OurCompanyUserCaption: "Company employee",
		TypeCaption: "Type",
		ServerLicAvailableCountCaption: "Issued {0} of unlimited",
		SpecifyPasswordMessage: "Specify the value",
		TagButtonHint: "Tags",
		TabControlScrollLeftHint: "Scroll left",
		TabControlScrollRightHint: "Scroll right",
		FieldsGroupCollapseButtonHint: "Collapse/expand",
		FieldLockHint: "Non-editable field",
		ClearButtonHint: "Clear value",
		PageHeaderTemplate: "{0} / {1}",
		OpenNewSectionDesignerButtonCaption: "Open new page designer",
		QuickAddButtonHint: "Add related activity",
		HeaderTipCaption: "Page appearance has been improved in Creatio 7.8",
		HeaderTipContent: "The page field layout has changed. Only the fields that you configured for the previous version are displayed here. For your convenience, you can move these fields to the record profile (on the left) or to the tab array using the Page Designer.",
		HeaderTipDesignerBtnCaption: "Set up now",
		HeaderTipAcademyBtnCaption: "Learn more at the Academy",
		AcademyDesignerUrl: "http://academy.bpmonline.com/documents/docs/product/bpm\u0027online%20sales/enterprise/7.8.0/BPMonlineHelp/chapter_section_wizard/section_wizard_page_fields_setup.htm#XREF_49522",
		HeaderTipNotShowBtnCaption: "Do not show this message again",
		PageContainsUnsavedChanges: "You have unsaved changes that will be lost. Continue?",
		CanCustomizeWarning: "Define {0} attribute instead of overriding function {1} to empty",
		TabVisaCaption: "Approvals",
		NotesGroupCaption: "Notes",
		NotesAndFilesTabCaption: "Attachments and notes",
		ChangeUserConnectionTypeMessage: "All user roles will be deleted. Continue changing the type?",
		SessionGroupCaption: "Session settings",
		SessionTimeoutTitle: "User session timeout, min",
		EditRightsCaption: "Set up access rights",
		SaveEditButtonHint: "Save (Ctrl\u002BEnter)",
		OpenChangeLogMenuCaption: "View change log",
		OrganizationCaption: "Organization",
		CreateWebitelUserQuestion: "Create a Webitel for this contact?",
		WebitelUserErrorCreationMessage: "Unable to create Webitel user for the added employee",
		AuthControlGroupHintCaption: "Select Creatio authentication if you are going to add users to Creatio directly. Select LDAP authentication if you are going to synchronize users with Active Directory or OpenLDAP. In this case, the username must match the name from a LDAP lookup.",
		LDAPNotAvailableHintCaption: "LDAP authentication is not available for Growth plan. Upgrade your subscription to Enterprise",
		LDAPExternalNotAvailableHintCaption: "This option is not available for external users.",
		BlockedUserLabelCaption: "User is blocked after a series of attempts to enter the wrong password during login",
		UnblockErrorMessage: "Unable to unblock this user",
		UnblockSuccessMessage: "The user has been successfully unblocked. Login available",
		UnblockUserButtonCaption: "Unblock",
		UserEmailCaption: "Email",
		UserEmailNotUnique: "",
		UserNameTip: "Serves as Creatio login. Manage the field availability for external users via the \u201CAllow use Username as login to Creatio for External users\u201D system setting",
		UserNamePlaceholder: "Not available for external users",
		PhoneCaption: "Phone"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		DefaultPhoto: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "DefaultPhoto",
				hash: "4b177430ad9dfd06fb56c61bfd4f9b60",
				resourceItemExtension: ".jpg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "ToolsButtonImage",
				hash: "1e35a244fbf576117229fbd866db69ac",
				resourceItemExtension: ".png"
			}
		},
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "UserPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});