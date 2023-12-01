define("FormSubmit", ["terrasoft", "ext-base", "FormSubmitResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.FormSubmit", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.FormSubmit",
			singleton: true,
			uId: "5e2c524a-666f-491c-ba9f-ce03e82bb015",
			name: "FormSubmit",
			caption: resources.localizableStrings.FormSubmitCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				Id: {
					uId: "ae0e45ca-c495-4fe7-a39d-3ab7278e1617",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "AutoGuid"
					}
				},
				CreatedOn: {
					uId: "e80190a5-03b2-4095-90f7-a193a960adee",
					name: "CreatedOn",
					caption: resources.localizableStrings.CreatedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDateTime"
					}
				},
				CreatedBy: {
					uId: "ebf6bb93-8aa6-4a01-900d-c6ea67affe21",
					name: "CreatedBy",
					caption: resources.localizableStrings.CreatedByCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentUserContact"
					}
				},
				ModifiedOn: {
					uId: "9928edec-4272-425a-93bb-48743fee4b04",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDateTime"
					}
				},
				ModifiedBy: {
					uId: "3015559e-cbc6-406a-88af-07f7930be832",
					name: "ModifiedBy",
					caption: resources.localizableStrings.ModifiedByCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentUserContact"
					}
				},
				ProcessListeners: {
					uId: "3fabd836-6a53-4d8d-9069-6df88d9dae1e",
					name: "ProcessListeners",
					caption: resources.localizableStrings.ProcessListenersCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Contact: {
					uId: "ddeea9d7-0297-e076-a745-e13d9e5f82fa",
					name: "Contact",
					caption: resources.localizableStrings.ContactCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				FormData: {
					uId: "2220684f-17b1-3020-5dfb-726b1bec7aae",
					name: "FormData",
					caption: resources.localizableStrings.FormDataCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true
				},
				WebForm: {
					uId: "932ed00e-939a-45dd-5927-cdbd22b2555b",
					name: "WebForm",
					caption: resources.localizableStrings.WebFormCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "GeneratedWebForm",
					referenceSchema: {
						name: "GeneratedWebForm",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				PhoneNumber: {
					uId: "91652a8d-9a8e-d841-aa2f-e813adf5501c",
					name: "PhoneNumber",
					caption: resources.localizableStrings.PhoneNumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				Email: {
					uId: "60543d87-6b8e-10b6-70e2-6c15b85f9b01",
					name: "Email",
					caption: resources.localizableStrings.EmailCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				LastName: {
					uId: "9d06059b-cb2b-0b7b-600c-1e0967c538dd",
					name: "LastName",
					caption: resources.localizableStrings.LastNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				FirstName: {
					uId: "19c0ec89-d01e-3ae8-2b58-8e8789ef9bf0",
					name: "FirstName",
					caption: resources.localizableStrings.FirstNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				FullName: {
					uId: "d9109991-f009-62af-c402-94e87c06b950",
					name: "FullName",
					caption: resources.localizableStrings.FullNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				CountryStr: {
					uId: "06de216d-2012-b890-bc88-33e56984e177",
					name: "CountryStr",
					caption: resources.localizableStrings.CountryStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Country: {
					uId: "56c7be66-5860-b898-5911-e26d26c549f5",
					name: "Country",
					caption: resources.localizableStrings.CountryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Country",
					referenceSchema: {
						name: "Country",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				AccountIndustryStr: {
					uId: "db8be8e6-102e-375a-8661-46f4a3d4ef5d",
					name: "AccountIndustryStr",
					caption: resources.localizableStrings.AccountIndustryStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				AccountIndustry: {
					uId: "82e275c1-f6df-442b-5cd1-082958db2223",
					name: "AccountIndustry",
					caption: resources.localizableStrings.AccountIndustryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AccountIndustry",
					referenceSchema: {
						name: "AccountIndustry",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				JobTitle: {
					uId: "b277c977-a832-6e1a-76f9-a82464f34d8d",
					name: "JobTitle",
					caption: resources.localizableStrings.JobTitleCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				ContactDecisionRoleStr: {
					uId: "b550da91-2bbe-02dc-6a21-2f08ee160407",
					name: "ContactDecisionRoleStr",
					caption: resources.localizableStrings.ContactDecisionRoleStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ContactDecisionRole: {
					uId: "7ccd1763-1d18-c948-24b7-81de914679d3",
					name: "ContactDecisionRole",
					caption: resources.localizableStrings.ContactDecisionRoleCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ContactDecisionRole",
					referenceSchema: {
						name: "ContactDecisionRole",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				WorkEmail: {
					uId: "39e7fd9c-181d-892f-d73d-d158228393f4",
					name: "WorkEmail",
					caption: resources.localizableStrings.WorkEmailCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				AccountEmployeesNumberStr: {
					uId: "e18e183c-9f33-00ba-27ef-874c5351b9ae",
					name: "AccountEmployeesNumberStr",
					caption: resources.localizableStrings.AccountEmployeesNumberStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				AccountEmployeesNumber: {
					uId: "8bc0a2a8-5b9a-af2b-d14c-812917b0fa5b",
					name: "AccountEmployeesNumber",
					caption: resources.localizableStrings.AccountEmployeesNumberCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AccountEmployeesNumber",
					referenceSchema: {
						name: "AccountEmployeesNumber",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name",
						primaryOrderColumnName: "Position"
					}
				},
				Account: {
					uId: "f76fb12d-be24-1473-9580-0a7ec0863ca9",
					name: "Account",
					caption: resources.localizableStrings.AccountCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Website: {
					uId: "1fd35b2e-f581-dd53-2493-69980e8473f7",
					name: "Website",
					caption: resources.localizableStrings.WebsiteCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Gender: {
					uId: "0768a9af-adb8-4d74-2d47-a3f6a5568b5e",
					name: "Gender",
					caption: resources.localizableStrings.GenderCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "Gender",
					referenceSchema: {
						name: "Gender",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				TimeZone: {
					uId: "072d2f20-1ead-da2a-07fd-aed691895bc7",
					name: "TimeZone",
					caption: resources.localizableStrings.TimeZoneCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "TimeZone",
					referenceSchema: {
						name: "TimeZone",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Territory: {
					uId: "4a889680-5048-c0ac-afce-2e9623527c34",
					name: "Territory",
					caption: resources.localizableStrings.TerritoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Territory",
					referenceSchema: {
						name: "Territory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				CityStr: {
					uId: "76426879-16d2-810f-ffe0-cb8bb21de15e",
					name: "CityStr",
					caption: resources.localizableStrings.CityStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				City: {
					uId: "ac3b7e0a-e945-fe1f-8518-3ed9538f1ed0",
					name: "City",
					caption: resources.localizableStrings.CityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "City",
					referenceSchema: {
						name: "City",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				BirthDate: {
					uId: "5b05e9e4-777a-aab8-8e51-fca4f73768b7",
					name: "BirthDate",
					caption: resources.localizableStrings.BirthDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true
				},
				Password: {
					uId: "3f58443b-2a56-a020-610b-f3fa42b6f165",
					name: "Password",
					caption: resources.localizableStrings.PasswordCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				LinkedInProfileUrl: {
					uId: "21cbd581-7d16-2b88-bbf6-498e7391ea61",
					name: "LinkedInProfileUrl",
					caption: resources.localizableStrings.LinkedInProfileUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 500
				},
				RegisterMethod: {
					uId: "ffee3041-b8da-713f-2dd5-b1a05b25d42a",
					name: "RegisterMethod",
					caption: resources.localizableStrings.RegisterMethodCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "RegisterMethod",
					referenceSchema: {
						name: "RegisterMethod",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Notes: {
					uId: "a5bf46da-927f-9ee1-b237-238ab555244a",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Source: {
					uId: "f6f63fd0-2a29-1a7b-6155-6955f6ebbf8b",
					name: "Source",
					caption: resources.localizableStrings.SourceCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadSource",
					referenceSchema: {
						name: "LeadSource",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Channel: {
					uId: "770eec1e-8865-d31e-d5e9-2316e9d43ccb",
					name: "Channel",
					caption: resources.localizableStrings.ChannelCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadMedium",
					referenceSchema: {
						name: "LeadMedium",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				UtmCampaignStr: {
					uId: "e2030317-bd2a-4659-c644-d41e57bbc131",
					name: "UtmCampaignStr",
					caption: resources.localizableStrings.UtmCampaignStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmMediumStr: {
					uId: "80af1dea-87ef-0c6a-c71c-273e668c041c",
					name: "UtmMediumStr",
					caption: resources.localizableStrings.UtmMediumStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmSourceStr: {
					uId: "19171333-92fc-63fe-6597-fbce780c10fb",
					name: "UtmSourceStr",
					caption: resources.localizableStrings.UtmSourceStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Referrer: {
					uId: "d2e6d144-9c60-ad54-86ba-002c482dfc29",
					name: "Referrer",
					caption: resources.localizableStrings.ReferrerCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				WebFormData: {
					uId: "bbb89b2c-6155-490f-8f42-c9ab1f84a39a",
					name: "WebFormData",
					caption: resources.localizableStrings.WebFormDataCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "WebFormData",
					referenceSchema: {
						name: "WebFormData",
						primaryColumnName: "Id",
						primaryDisplayColumnName: null
					}
				},
				LandingPageURL: {
					uId: "8484e41b-79f9-6d85-1e7f-76c10a1f75fc",
					name: "LandingPageURL",
					caption: resources.localizableStrings.LandingPageURLCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				UtmTermStr: {
					uId: "41d289da-8dde-9e0c-6abd-53d4a7c70c9a",
					name: "UtmTermStr",
					caption: resources.localizableStrings.UtmTermStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmContentStr: {
					uId: "a64062d6-1320-fec2-41c7-a6a6be5181a0",
					name: "UtmContentStr",
					caption: resources.localizableStrings.UtmContentStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				CustomerNeed: {
					uId: "5d780019-f37e-0d2a-82d3-1252c587ee91",
					name: "CustomerNeed",
					caption: resources.localizableStrings.CustomerNeedCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadType",
					referenceSchema: {
						name: "LeadType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				BulkEmail: {
					uId: "941af094-54cd-3d00-3543-12b2cb1ac35d",
					name: "BulkEmail",
					caption: resources.localizableStrings.BulkEmailCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmail",
					referenceSchema: {
						name: "BulkEmail",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Campaign: {
					uId: "0f3eb59b-a64c-17c8-9fb8-cc40c2903530",
					name: "Campaign",
					caption: resources.localizableStrings.CampaignCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Campaign",
					referenceSchema: {
						name: "Campaign",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				AdCampaign: {
					uId: "4b012dd0-0497-0e64-ded7-c6011b6405a2",
					name: "AdCampaign",
					caption: resources.localizableStrings.AdCampaignCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AdCampaign",
					referenceSchema: {
						name: "AdCampaign",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "CampaignName"
					}
				},
				Event: {
					uId: "c3fdcfad-f1e9-dee1-60d7-883b9362e057",
					name: "Event",
					caption: resources.localizableStrings.EventCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Event",
					referenceSchema: {
						name: "Event",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.FormSubmit;
	});