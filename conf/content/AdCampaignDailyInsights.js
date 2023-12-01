define("AdCampaignDailyInsights", ["terrasoft", "ext-base", "AdCampaignDailyInsightsResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.AdCampaignDailyInsights", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.AdCampaignDailyInsights",
			singleton: true,
			uId: "cfb6f45d-cba1-4654-a569-26706df96805",
			name: "AdCampaignDailyInsights",
			caption: resources.localizableStrings.AdCampaignDailyInsightsCaption,
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
				Reach: {
					uId: "16fc88ac-879f-adde-e040-a99fcf2c0a01",
					name: "Reach",
					caption: resources.localizableStrings.ReachCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Impressions: {
					uId: "a6aecad4-94e0-1fa8-6e71-c0f57b66c932",
					name: "Impressions",
					caption: resources.localizableStrings.ImpressionsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AdCampaign: {
					uId: "6e6b7468-ca0e-f667-63e1-e7db1c336db7",
					name: "AdCampaign",
					caption: resources.localizableStrings.AdCampaignCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AdCampaign",
					referenceSchema: {
						name: "AdCampaign",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "CampaignName"
					}
				},
				Frequency: {
					uId: "f8e92e18-5124-2aeb-3c6f-344bac636a0f",
					name: "Frequency",
					caption: resources.localizableStrings.FrequencyCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				CTR: {
					uId: "3d74e710-f574-9746-7e46-6c80a881db55",
					name: "CTR",
					caption: resources.localizableStrings.CTRCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				DataRangeDate: {
					uId: "3bdbd201-5e84-28dd-992a-f47ef89911e4",
					name: "DataRangeDate",
					caption: resources.localizableStrings.DataRangeDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CPM: {
					uId: "2b4da3fe-ea96-32b6-5b50-b273c9f161e9",
					name: "CPM",
					caption: resources.localizableStrings.CPMCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				CPC: {
					uId: "ccf671f7-e8c8-9484-0a26-cbdb0d76c663",
					name: "CPC",
					caption: resources.localizableStrings.CPCCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Clicks: {
					uId: "79ed1dd4-c735-f54a-31cd-2fbd03eb9b20",
					name: "Clicks",
					caption: resources.localizableStrings.ClicksCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AmountSpent: {
					uId: "87a095e1-23b5-5436-7092-6343ef5d0b10",
					name: "AmountSpent",
					caption: resources.localizableStrings.AmountSpentCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				PrimaryAmountSpent: {
					uId: "0a9ea231-af65-e8a6-102d-6a42617fc134",
					name: "PrimaryAmountSpent",
					caption: resources.localizableStrings.PrimaryAmountSpentCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Submissions: {
					uId: "288fcffe-b867-ce99-4346-e6ec91160487",
					name: "Submissions",
					caption: resources.localizableStrings.SubmissionsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Contacts: {
					uId: "39f07b02-ee24-fcca-9ca0-fc99dce7f39b",
					name: "Contacts",
					caption: resources.localizableStrings.ContactsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CostPerSubmission: {
					uId: "8ff17f48-a4ca-006e-bcf7-5dd9e46b0943",
					name: "CostPerSubmission",
					caption: resources.localizableStrings.CostPerSubmissionCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				CostPerContact: {
					uId: "3cca6676-06cd-f9fb-bc38-55f890c75de2",
					name: "CostPerContact",
					caption: resources.localizableStrings.CostPerContactCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				}
			}
		});
		return Terrasoft.AdCampaignDailyInsights;
	});