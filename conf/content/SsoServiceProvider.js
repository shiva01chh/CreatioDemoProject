define("SsoServiceProvider", ["terrasoft", "ext-base", "SsoServiceProviderResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SsoServiceProvider", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SsoServiceProvider",
			singleton: true,
			uId: "53edc668-0d2f-492a-9d23-012e04ad8786",
			name: "SsoServiceProvider",
			caption: resources.localizableStrings.SsoServiceProviderCaption,
			administratedByRecords: false,
			administratedByOperations: true,
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
				UseJit: {
					uId: "6aed5469-304a-5418-29c5-29d7c1f1e533",
					name: "UseJit",
					caption: resources.localizableStrings.UseJitCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SamlUserRole: {
					uId: "188e9396-2cf2-5092-5843-33bd154ead60",
					name: "SamlUserRole",
					caption: resources.localizableStrings.SamlUserRoleCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: "role"
					},
					size: 250
				},
				SamlUserName: {
					uId: "fff5b6f8-26c6-0a74-b2a5-957f9cf6ccc4",
					name: "SamlUserName",
					caption: resources.localizableStrings.SamlUserNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				LocalCertificateThumbprint: {
					uId: "1e9b4bc0-4fe6-8a7b-8e68-6f62af4014b4",
					name: "LocalCertificateThumbprint",
					caption: resources.localizableStrings.LocalCertificateThumbprintCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				AssertionConsumerServiceUrl: {
					uId: "e86551a3-eec0-150a-2f9c-d7d918e2332f",
					name: "AssertionConsumerServiceUrl",
					caption: resources.localizableStrings.AssertionConsumerServiceUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				Name: {
					uId: "937feb82-bbe6-308b-3642-ccfc0ccc2cb6",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				SsoIdentityProvider: {
					uId: "cdad8252-1f7d-94fe-abb4-88345cbc4667",
					name: "SsoIdentityProvider",
					caption: resources.localizableStrings.SsoIdentityProviderCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SsoIdentityProvider",
					referenceSchema: {
						name: "SsoIdentityProvider",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "DisplayName"
					}
				},
				SspUseJit: {
					uId: "881e327e-b234-a01c-1dce-158bbdb87e6a",
					name: "SspUseJit",
					caption: resources.localizableStrings.SspUseJitCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ServiceUniqueColumn: {
					uId: "088d7e27-71a2-8263-8866-1c6f9566ee2a",
					name: "ServiceUniqueColumn",
					caption: resources.localizableStrings.ServiceUniqueColumnCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: false
					}
				},
				SingleLogoutServiceUrl: {
					uId: "1c123d02-c31b-3863-b6ef-d639138929e3",
					name: "SingleLogoutServiceUrl",
					caption: resources.localizableStrings.SingleLogoutServiceUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				}
			}
		});
		return Terrasoft.SsoServiceProvider;
	});