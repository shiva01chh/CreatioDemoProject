define("LeadGenWebhooks", ["terrasoft", "ext-base", "LeadGenWebhooksResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.LeadGenWebhooks", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.LeadGenWebhooks",
			singleton: true,
			uId: "2c694123-ed64-4632-941f-fa80612ee1d5",
			name: "LeadGenWebhooks",
			caption: resources.localizableStrings.LeadGenWebhooksCaption,
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
				SocialCreatedOn: {
					uId: "a0f9c4e9-d84e-ce2f-2d91-01983d5d32fa",
					name: "SocialCreatedOn",
					caption: resources.localizableStrings.SocialCreatedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				WebhookStatusUpdateDate: {
					uId: "956bb4e8-21c5-48ef-9d0e-db19341b9d8b",
					name: "WebhookStatusUpdateDate",
					caption: resources.localizableStrings.WebhookStatusUpdateDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				FormMetadata: {
					uId: "7799280e-3934-3498-e7ea-79d74b4b417c",
					name: "FormMetadata",
					caption: resources.localizableStrings.FormMetadataCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true
				},
				SocialLeadId: {
					uId: "a6599a6b-4e0d-413c-466c-1ee153e14d5a",
					name: "SocialLeadId",
					caption: resources.localizableStrings.SocialLeadIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				LeadGenWebhookStatus: {
					uId: "5a685f86-1bc7-c480-3613-eca6d9ef570c",
					name: "LeadGenWebhookStatus",
					caption: resources.localizableStrings.LeadGenWebhookStatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "LeadGenWebhookStatus",
					referenceSchema: {
						name: "LeadGenWebhookStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LeadGenNetworkType: {
					uId: "99785712-013b-ff66-ee18-eb988dc41762",
					name: "LeadGenNetworkType",
					caption: resources.localizableStrings.LeadGenNetworkTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "LeadGenNetworkType",
					referenceSchema: {
						name: "LeadGenNetworkType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				IntegrationId: {
					uId: "4c8f7de9-19fc-331b-1ef1-b408efe00fcb",
					name: "IntegrationId",
					caption: resources.localizableStrings.IntegrationIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				FormId: {
					uId: "ea28661e-2833-dc25-e4f3-04f8add1b9f6",
					name: "FormId",
					caption: resources.localizableStrings.FormIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				}
			}
		});
		return Terrasoft.LeadGenWebhooks;
	});