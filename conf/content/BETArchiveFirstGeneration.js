define("BETArchiveFirstGeneration", ["terrasoft", "ext-base", "BETArchiveFirstGenerationResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.BETArchiveFirstGeneration", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.BETArchiveFirstGeneration",
			singleton: true,
			uId: "f49f5bde-8333-5d3f-9b45-e2d72dfe7a2d",
			name: "BETArchiveFirstGeneration",
			caption: resources.localizableStrings.BETArchiveFirstGenerationCaption,
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
				BulkEmail: {
					uId: "c0c04f91-bec0-4c97-a3e3-341610a1ae2f",
					name: "BulkEmail",
					caption: resources.localizableStrings.BulkEmailCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "BulkEmail",
					referenceSchema: {
						name: "BulkEmail",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				BulkEmailResponse: {
					uId: "91b87361-603a-4602-b7dc-09b46423343e",
					name: "BulkEmailResponse",
					caption: resources.localizableStrings.BulkEmailResponseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailResponse",
					referenceSchema: {
						name: "BulkEmailResponse",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "14769602-ebda-40b1-91d5-ea9d623e2400"
						}
					}
				},
				Clicks: {
					uId: "d49bd700-f47a-4b08-9922-cd4f490b6489",
					name: "Clicks",
					caption: resources.localizableStrings.ClicksCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Contact: {
					uId: "8b85ee02-7cd9-4f86-a938-d44f8fc1d41a",
					name: "Contact",
					caption: resources.localizableStrings.ContactCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				EmailAddress: {
					uId: "b7bd7279-4f36-41f7-8b24-d0db933828ee",
					name: "EmailAddress",
					caption: resources.localizableStrings.EmailAddressCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: true,
					isRequired: true,
					size: 250
				},
				LinkedEntityId: {
					uId: "87ba1b0a-c890-4a54-8e95-d2ffce5f0520",
					name: "LinkedEntityId",
					caption: resources.localizableStrings.LinkedEntityIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false
				},
				MandrillId: {
					uId: "357bfa16-8ce0-4384-9903-8a654a337c88",
					name: "MandrillId",
					caption: resources.localizableStrings.MandrillIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "AutoGuid"
					}
				},
				Opens: {
					uId: "78e6abd9-ae00-45df-9a15-89e0319c58c8",
					name: "Opens",
					caption: resources.localizableStrings.OpensCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ProviderName: {
					uId: "685ad3c0-62ef-9f9b-2d9f-c56322916b58",
					name: "ProviderName",
					caption: resources.localizableStrings.ProviderNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				ResponseDetails: {
					uId: "508975cf-20e4-2070-2267-c2451cda192c",
					name: "ResponseDetails",
					caption: resources.localizableStrings.ResponseDetailsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailResponseDetails",
					referenceSchema: {
						name: "BulkEmailResponseDetails",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Details"
					}
				}
			}
		});
		return Terrasoft.BETArchiveFirstGeneration;
	});