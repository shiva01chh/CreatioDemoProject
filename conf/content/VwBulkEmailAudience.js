define("VwBulkEmailAudience", ["terrasoft", "ext-base", "VwBulkEmailAudienceResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.VwBulkEmailAudience", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.VwBulkEmailAudience",
			singleton: true,
			uId: "a152f9dc-4f24-4d68-a7ae-8389fdcfab83",
			name: "VwBulkEmailAudience",
			caption: resources.localizableStrings.VwBulkEmailAudienceCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				BulkEmail: {
					uId: "c6b32c69-e01a-41e6-af78-dfd5b8a6b28e",
					name: "BulkEmail",
					caption: resources.localizableStrings.BulkEmailCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
					uId: "540a362a-98fa-e27c-6cc1-48be5b2aa067",
					name: "BulkEmailResponse",
					caption: resources.localizableStrings.BulkEmailResponseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
					uId: "eac82b2e-089f-c11d-4d10-98aa0c0f0fde",
					name: "Clicks",
					caption: resources.localizableStrings.ClicksCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Contact: {
					uId: "d2782e56-8c60-48d1-995c-e768ac9c1e52",
					name: "Contact",
					caption: resources.localizableStrings.ContactCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
				CreatedOn: {
					uId: "bee5b170-ad9a-4a1e-8b31-bc0b9f3978c9",
					name: "CreatedOn",
					caption: resources.localizableStrings.CreatedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				EmailAddress: {
					uId: "64829cee-7320-4514-8da5-506ee6cd952b",
					name: "EmailAddress",
					caption: resources.localizableStrings.EmailAddressCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: true,
					size: 250
				},
				Id: {
					uId: "789f6e45-5684-4dab-93f1-cd89b87ec2bb",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 1,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true
				},
				IsSent: {
					uId: "9d733eaf-93ab-4f44-9819-7047e0ce5ba2",
					name: "IsSent",
					caption: resources.localizableStrings.IsSentCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LinkedEntity: {
					uId: "264fa2b6-3224-4fb2-a719-a2bb56fb25e7",
					name: "LinkedEntity",
					caption: resources.localizableStrings.LinkedEntityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Opens: {
					uId: "a0fe8e03-aa08-36c3-ac52-7c74068f8612",
					name: "Opens",
					caption: resources.localizableStrings.OpensCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Replica: {
					uId: "e6f3b61d-d974-4577-934a-e807f0d42003",
					name: "Replica",
					caption: resources.localizableStrings.ReplicaCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "DCReplica",
					referenceSchema: {
						name: "DCReplica",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Caption"
					}
				},
				SessionId: {
					uId: "330e9712-ecf6-435e-ad84-0d26b8bdd0b6",
					name: "SessionId",
					caption: resources.localizableStrings.SessionIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ModifiedOn: {
					uId: "ffc16f31-3330-b561-aead-960215f0e8a2",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ProviderName: {
					uId: "d6156479-ad24-73c3-bc98-137f5772eecf",
					name: "ProviderName",
					caption: resources.localizableStrings.ProviderNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 50
				},
				ResponseDetails: {
					uId: "39014c0c-47fa-ba90-077f-4e213396ff5a",
					name: "ResponseDetails",
					caption: resources.localizableStrings.ResponseDetailsCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailResponseDetails",
					referenceSchema: {
						name: "BulkEmailResponseDetails",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Details"
					}
				},
				ResponseReason: {
					uId: "69286b63-346d-0ab0-533b-baa0bd192149",
					name: "ResponseReason",
					caption: resources.localizableStrings.ResponseReasonCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailResponseReason",
					referenceSchema: {
						name: "BulkEmailResponseReason",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.VwBulkEmailAudience;
	});