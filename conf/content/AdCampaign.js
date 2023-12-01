define("AdCampaign", ["terrasoft", "ext-base", "AdCampaignResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.AdCampaign", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.AdCampaign",
			singleton: true,
			uId: "0b416432-4385-432a-94ad-c30262cd14da",
			name: "AdCampaign",
			caption: resources.localizableStrings.AdCampaignCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "CampaignName",
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
				CampaignName: {
					uId: "22d97f89-649b-4724-a9ec-8e6b6837fa86",
					name: "CampaignName",
					caption: resources.localizableStrings.CampaignNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				Platform: {
					uId: "f6abfc72-4a5e-b343-b8c3-2823bc1acbf1",
					name: "Platform",
					caption: resources.localizableStrings.PlatformCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AdPlatform",
					referenceSchema: {
						name: "AdPlatform",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Status: {
					uId: "3611441c-7635-f85d-2095-5a8e3f5479f5",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AdCampaignStatus",
					referenceSchema: {
						name: "AdCampaignStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Reach: {
					uId: "be0128c3-f66e-d9a2-43e9-60dd2cfa41bb",
					name: "Reach",
					caption: resources.localizableStrings.ReachCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Impressions: {
					uId: "5d243541-508c-dc33-f874-846b41313ac7",
					name: "Impressions",
					caption: resources.localizableStrings.ImpressionsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AdCampaignId: {
					uId: "6b2b9338-449f-f90a-a406-6f54b5cce048",
					name: "AdCampaignId",
					caption: resources.localizableStrings.AdCampaignIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Frequency: {
					uId: "66f2b583-f108-421a-da14-330055448447",
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
					uId: "d1377aeb-56b8-5004-c9bd-88daea2b8df1",
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
				EndDate: {
					uId: "d929ee0c-41dc-ea27-7746-e2c4290ecdf1",
					name: "EndDate",
					caption: resources.localizableStrings.EndDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				StartDate: {
					uId: "e034a113-1e22-c3b6-28bf-980cebf80447",
					name: "StartDate",
					caption: resources.localizableStrings.StartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CreatedDate: {
					uId: "51248ad3-729b-470f-6d67-12828d5614de",
					name: "CreatedDate",
					caption: resources.localizableStrings.CreatedDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CPM: {
					uId: "87358965-c57f-fa54-f4bb-661ad93c6c54",
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
					uId: "2427e7fc-0ed0-841b-3438-88efbed462d1",
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
					uId: "a03b9cbe-622f-0585-a229-21cc6d0e7284",
					name: "Clicks",
					caption: resources.localizableStrings.ClicksCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AmountSpent: {
					uId: "8474f79a-30ef-2933-e219-875d8e5e431c",
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
				AdAccount: {
					uId: "4074fddc-8655-5c25-c647-c0a054d4fb94",
					name: "AdAccount",
					caption: resources.localizableStrings.AdAccountCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "AdAccount",
					referenceSchema: {
						name: "AdAccount",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				PrimaryAmountSpent: {
					uId: "25e693c0-dad8-5f27-fe41-016e1527f78c",
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
				AdAccountCurrency: {
					uId: "d76971ec-0ae1-c4ae-2cba-656863efb581",
					name: "AdAccountCurrency",
					caption: resources.localizableStrings.AdAccountCurrencyCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 50
				},
				Submissions: {
					uId: "db5700b3-f3f4-3fb4-5675-ac0853b9196b",
					name: "Submissions",
					caption: resources.localizableStrings.SubmissionsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Contacts: {
					uId: "585d1f89-77ad-cd1a-dd11-329728a9b6fc",
					name: "Contacts",
					caption: resources.localizableStrings.ContactsCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CostPerSubmission: {
					uId: "f2d36502-7f87-7c00-b93d-95335de6e5f3",
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
					uId: "8f2a96da-e1b4-6949-025a-2cf695726710",
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
		return Terrasoft.AdCampaign;
	});