define("SsoOpenIdProvider", ["terrasoft", "ext-base", "SsoOpenIdProviderResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SsoOpenIdProvider", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SsoOpenIdProvider",
			singleton: true,
			uId: "660e6fe9-148b-48c9-86ce-917609c718e8",
			name: "SsoOpenIdProvider",
			caption: resources.localizableStrings.SsoOpenIdProviderCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Name",
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
				SsoProvider: {
					uId: "ac66c105-0e16-d0f1-b322-242c79724262",
					name: "SsoProvider",
					caption: resources.localizableStrings.SsoProviderCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SsoProvider",
					referenceSchema: {
						name: "SsoProvider",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				EndSessionEndpointUrl: {
					uId: "f96adc79-ff8a-defc-1a12-0a40ebb7523b",
					name: "EndSessionEndpointUrl",
					caption: resources.localizableStrings.EndSessionEndpointUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				DiscoveryUrl: {
					uId: "e82bd103-1636-3ed5-d28d-591c8a831291",
					name: "DiscoveryUrl",
					caption: resources.localizableStrings.DiscoveryUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ClientSecret: {
					uId: "a40d4337-5006-7bcd-df28-6ec8eaa76120",
					name: "ClientSecret",
					caption: resources.localizableStrings.ClientSecretCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 500
				},
				ClientID: {
					uId: "e4dc2267-bc58-46eb-f38e-ec2b3376d33a",
					name: "ClientID",
					caption: resources.localizableStrings.ClientIDCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				Url: {
					uId: "321b9c3c-395e-3fcf-d42a-b6d3e50aa8fc",
					name: "Url",
					caption: resources.localizableStrings.UrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Code: {
					uId: "5b2cd02f-ea9a-3608-c35f-18507fa4b730",
					name: "Code",
					caption: resources.localizableStrings.CodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SEQUENCE,
						sequencePrefix: "openid_",
						sequenceNumberOfChars: 1,
					},
					size: 50
				},
				Name: {
					uId: "9c351444-929e-3753-faae-a47881e9361e",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SsoSettingsTemplate: {
					uId: "1d754fa0-2ed8-27d5-9154-e6a00b8e6367",
					name: "SsoSettingsTemplate",
					caption: resources.localizableStrings.SsoSettingsTemplateCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "SsoSettingsTemplate",
					referenceSchema: {
						name: "SsoSettingsTemplate",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				IsDefault: {
					uId: "fb0624b6-1606-06e1-8a04-ed2d649d6668",
					name: "IsDefault",
					caption: resources.localizableStrings.IsDefaultCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.SsoOpenIdProvider;
	});