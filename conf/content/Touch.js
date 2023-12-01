define("Touch", ["terrasoft", "ext-base", "TouchResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.Touch", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.Touch",
			singleton: true,
			uId: "6895c8a8-7407-460a-90ec-5e5bfbda0fda",
			name: "Touch",
			caption: resources.localizableStrings.TouchCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "SessionId",
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
				City: {
					uId: "dcce3f70-704b-9d25-1c34-7164eaf914bb",
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
				PageReferrer: {
					uId: "27c20e65-ae81-62fe-7cd1-dff5aec1e544",
					name: "PageReferrer",
					caption: resources.localizableStrings.PageReferrerCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Duration: {
					uId: "a3000eb8-3285-8c3a-f3f5-be907b064bd0",
					name: "Duration",
					caption: resources.localizableStrings.DurationCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Domain: {
					uId: "587d6cf8-bc68-2cc8-9556-87f53ca11dc1",
					name: "Domain",
					caption: resources.localizableStrings.DomainCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Language: {
					uId: "cac4c7a1-0abd-456b-7f83-c78e8e9b3045",
					name: "Language",
					caption: resources.localizableStrings.LanguageCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysLanguage",
					referenceSchema: {
						name: "SysLanguage",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				IP: {
					uId: "aaad9878-8fd2-a514-e9a9-cdddf2bc44e8",
					name: "IP",
					caption: resources.localizableStrings.IPCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 50
				},
				Country: {
					uId: "97c2062a-41f4-b9f7-ed78-cb8e7fc02b89",
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
				Contact: {
					uId: "7639c621-2038-8611-fc5a-990848141abc",
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
				UtmTermStr: {
					uId: "3ee8b199-35ed-75fb-eeaf-07f49dc906a4",
					name: "UtmTermStr",
					caption: resources.localizableStrings.UtmTermStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmSourceStr: {
					uId: "ddc7e6ca-715a-5cfa-0b0a-4fdeb1337065",
					name: "UtmSourceStr",
					caption: resources.localizableStrings.UtmSourceStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmMediumStr: {
					uId: "c23f78ef-783c-26ac-38b7-18cf4260d711",
					name: "UtmMediumStr",
					caption: resources.localizableStrings.UtmMediumStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmContentStr: {
					uId: "df37a85c-6872-5ec5-d581-947559c9c3d8",
					name: "UtmContentStr",
					caption: resources.localizableStrings.UtmContentStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmCampaignStr: {
					uId: "755a521e-d7ea-1ef9-7fa5-7458708dbc3c",
					name: "UtmCampaignStr",
					caption: resources.localizableStrings.UtmCampaignStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Platform: {
					uId: "699ca8a2-46d7-111d-c16f-b8b7a6b57a86",
					name: "Platform",
					caption: resources.localizableStrings.PlatformCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "TouchPlatform",
					referenceSchema: {
						name: "TouchPlatform",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Device: {
					uId: "76303777-4460-dd41-c50c-9000807ab0dd",
					name: "Device",
					caption: resources.localizableStrings.DeviceCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "TouchDevice",
					referenceSchema: {
						name: "TouchDevice",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SessionId: {
					uId: "29b8d471-9a85-14d5-a26e-6cda4d071c45",
					name: "SessionId",
					caption: resources.localizableStrings.SessionIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				MatomoVisitorId: {
					uId: "a661c187-cbd0-0b96-a965-baa85f0bb258",
					name: "MatomoVisitorId",
					caption: resources.localizableStrings.MatomoVisitorIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 50
				},
				MatomoUserId: {
					uId: "d75ed5ed-434d-e63d-240e-3d0035ce0b68",
					name: "MatomoUserId",
					caption: resources.localizableStrings.MatomoUserIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 50
				},
				LastActionDateTime: {
					uId: "beb4babe-f44b-d526-ea4a-9e3e9f879fa5",
					name: "LastActionDateTime",
					caption: resources.localizableStrings.LastActionDateTimeCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				PlatformStr: {
					uId: "b042d89a-3c47-1e79-1afb-e84ea64e2212",
					name: "PlatformStr",
					caption: resources.localizableStrings.PlatformStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				LanguageStr: {
					uId: "9725ab52-5efa-d733-e12e-eac103a3e611",
					name: "LanguageStr",
					caption: resources.localizableStrings.LanguageStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				DeviceStr: {
					uId: "7dfa06b7-7c73-ed1b-c4f4-04e303ded95b",
					name: "DeviceStr",
					caption: resources.localizableStrings.DeviceStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				CountryStr: {
					uId: "7c43539c-4ea0-eb2c-fc90-b16cf0c0b94b",
					name: "CountryStr",
					caption: resources.localizableStrings.CountryStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				CityStr: {
					uId: "5c562cd8-3aad-fed0-269d-0b6868d8d5d4",
					name: "CityStr",
					caption: resources.localizableStrings.CityStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				StartDate: {
					uId: "eaa8ecb4-7e57-7bfd-18b7-dd2bcf306bc1",
					name: "StartDate",
					caption: resources.localizableStrings.StartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CountryCode: {
					uId: "d022128f-a95c-d5a4-930d-4fb9c579e1aa",
					name: "CountryCode",
					caption: resources.localizableStrings.CountryCodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				RegionCode: {
					uId: "bb62078b-d456-fea5-3488-c4ed7f53cf87",
					name: "RegionCode",
					caption: resources.localizableStrings.RegionCodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 50
				},
				RegionStr: {
					uId: "d55823be-fe25-bf26-c015-d18e22b0a5c8",
					name: "RegionStr",
					caption: resources.localizableStrings.RegionStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				Region: {
					uId: "1a21cac6-a3d3-b24d-2836-ab4ba6f19932",
					name: "Region",
					caption: resources.localizableStrings.RegionCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Region",
					referenceSchema: {
						name: "Region",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Location: {
					uId: "7e9dd414-409e-4a22-378c-b3ac6468a929",
					name: "Location",
					caption: resources.localizableStrings.LocationCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				ReferrerTypeStr: {
					uId: "a803809d-bc45-d357-1a52-50a5b7a1a529",
					name: "ReferrerTypeStr",
					caption: resources.localizableStrings.ReferrerTypeStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ReferrerNameStr: {
					uId: "5721e532-8d27-9015-48de-2a1eb4e0926d",
					name: "ReferrerNameStr",
					caption: resources.localizableStrings.ReferrerNameStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ReferrerKeyword: {
					uId: "710bdb10-1216-de71-ee15-d90efe737862",
					name: "ReferrerKeyword",
					caption: resources.localizableStrings.ReferrerKeywordCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ReferrerUrl: {
					uId: "1d1ec990-91a2-7b0f-0ef1-a736c55b49e9",
					name: "ReferrerUrl",
					caption: resources.localizableStrings.ReferrerUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ReferrerType: {
					uId: "ed063589-f5dd-1569-922d-0680a60ea906",
					name: "ReferrerType",
					caption: resources.localizableStrings.ReferrerTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ReferrerType",
					referenceSchema: {
						name: "ReferrerType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ReferrerName: {
					uId: "c60baccd-8d38-ccf6-7be7-d82f96068492",
					name: "ReferrerName",
					caption: resources.localizableStrings.ReferrerNameCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ReferrerName",
					referenceSchema: {
						name: "ReferrerName",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				UtmIdStr: {
					uId: "e248b20f-3ed6-89e3-9612-81f30c235bff",
					name: "UtmIdStr",
					caption: resources.localizableStrings.UtmIdStrCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Source: {
					uId: "ff946a34-1b1a-8f4a-a833-28bc82846b5e",
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
					uId: "3e7fef33-647b-0409-0648-2a60ad0d397e",
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
				Notes: {
					uId: "70f795da-44a6-3038-fecc-558ce6932cc8",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AccountEmployeesNumber: {
					uId: "270d3f72-138e-dc36-5e7b-7025301fca30",
					name: "AccountEmployeesNumber",
					caption: resources.localizableStrings.AccountEmployeesNumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				AccountExactNoOfEmployees: {
					uId: "7d0af04a-eca4-4140-4aa7-7e610cfdfce9",
					name: "AccountExactNoOfEmployees",
					caption: resources.localizableStrings.AccountExactNoOfEmployeesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				FacebookProfileUrl: {
					uId: "2420e91a-594e-0978-4d7e-926df1bb8b19",
					name: "FacebookProfileUrl",
					caption: resources.localizableStrings.FacebookProfileUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				Website: {
					uId: "cd608d85-420f-31b1-866a-9fe9e067a075",
					name: "Website",
					caption: resources.localizableStrings.WebsiteCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				LinkedInProfileUrl: {
					uId: "e298f8ea-c262-9b75-85ec-6e95892f94d3",
					name: "LinkedInProfileUrl",
					caption: resources.localizableStrings.LinkedInProfileUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true,
					size: 250
				},
				SubIndustry: {
					uId: "8d6eb347-c2fc-241c-30fb-3eeffd29bfdc",
					name: "SubIndustry",
					caption: resources.localizableStrings.SubIndustryCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Industry: {
					uId: "c4f819ac-38af-ad49-71a4-d0015b553689",
					name: "Industry",
					caption: resources.localizableStrings.IndustryCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Account: {
					uId: "ff2ec5d1-9c18-ae54-c9cc-6cf9231f6ac3",
					name: "Account",
					caption: resources.localizableStrings.AccountCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Account",
					referenceSchema: {
						name: "Account",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				AccountNameText: {
					uId: "ed68034e-5aa2-55d6-e277-003d9e4247d2",
					name: "AccountNameText",
					caption: resources.localizableStrings.AccountNameTextCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				MatomoSiteId: {
					uId: "a2de0570-0a88-cc56-94ac-90e720f661bf",
					name: "MatomoSiteId",
					caption: resources.localizableStrings.MatomoSiteIdCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.Touch;
	});