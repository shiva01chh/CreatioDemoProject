define("LeadGenExtendedLeadInformation", ["terrasoft", "ext-base", "LeadGenExtendedLeadInformationResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.LeadGenExtendedLeadInformation", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.LeadGenExtendedLeadInformation",
			singleton: true,
			uId: "a94aecd6-9df6-48fa-90ec-fbb726b26d47",
			name: "LeadGenExtendedLeadInformation",
			caption: resources.localizableStrings.LeadGenExtendedLeadInformationCaption,
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
				SocialLeadId: {
					uId: "bee02e43-6239-1101-2ecc-ead727478133",
					name: "SocialLeadId",
					caption: resources.localizableStrings.SocialLeadIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				IsOrganicFacebook: {
					uId: "ba26b1f3-b339-e2ee-fa52-65b22a6b93c0",
					name: "IsOrganicFacebook",
					caption: resources.localizableStrings.IsOrganicFacebookCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				FacebookPlatform: {
					uId: "4b8bc7e0-dcea-23da-065e-523ce4738301",
					name: "FacebookPlatform",
					caption: resources.localizableStrings.FacebookPlatformCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				LeadGenLeadForms: {
					uId: "d59d1aa7-627b-3954-4447-1ae2696fc310",
					name: "LeadGenLeadForms",
					caption: resources.localizableStrings.LeadGenLeadFormsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadGenLeadForms",
					referenceSchema: {
						name: "LeadGenLeadForms",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LeadGenCampaignGroups: {
					uId: "6d2d6a5e-dd3f-9af0-2713-715be88ffcd4",
					name: "LeadGenCampaignGroups",
					caption: resources.localizableStrings.LeadGenCampaignGroupsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadGenCampaignGroups",
					referenceSchema: {
						name: "LeadGenCampaignGroups",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LeadGenCampaigns: {
					uId: "7edb001a-e906-2b7a-86a3-71da50a7cc76",
					name: "LeadGenCampaigns",
					caption: resources.localizableStrings.LeadGenCampaignsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadGenCampaigns",
					referenceSchema: {
						name: "LeadGenCampaigns",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LeadGenAdSets: {
					uId: "9c2e2412-d3a2-def6-fb2b-c50e3266a314",
					name: "LeadGenAdSets",
					caption: resources.localizableStrings.LeadGenAdSetsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadGenAdSets",
					referenceSchema: {
						name: "LeadGenAdSets",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LeadGenAds: {
					uId: "b2e17ef9-574c-717f-c007-cb7d60bcb862",
					name: "LeadGenAds",
					caption: resources.localizableStrings.LeadGenAdsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadGenAds",
					referenceSchema: {
						name: "LeadGenAds",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.LeadGenExtendedLeadInformation;
	});