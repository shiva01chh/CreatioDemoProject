define("SysInstalledApp", ["terrasoft", "ext-base", "SysInstalledAppResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SysInstalledApp", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SysInstalledApp",
			singleton: true,
			uId: "91d3eeb0-086c-4143-b671-dd2b77634d39",
			name: "SysInstalledApp",
			caption: resources.localizableStrings.SysInstalledAppCaption,
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
				Name: {
					uId: "736c30a7-c0ec-4fa9-b034-2552b319b633",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				Description: {
					uId: "9e53fd7c-dde4-4502-a64c-b9e34148108b",
					name: "Description",
					caption: resources.localizableStrings.DescriptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Code: {
					uId: "13aad544-ec30-4e76-a373-f0cff3202e24",
					name: "Code",
					caption: resources.localizableStrings.CodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 250
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
				Maintainer: {
					uId: "5420bb26-d1bc-4732-8c82-372e1e870cdc",
					name: "Maintainer",
					caption: resources.localizableStrings.MaintainerCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				InstallDate: {
					uId: "aad2b3b4-a300-4468-bca3-ce64c6308a76",
					name: "InstallDate",
					caption: resources.localizableStrings.InstallDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LastUpdate: {
					uId: "934b7730-1761-4b06-9429-dcf70712663c",
					name: "LastUpdate",
					caption: resources.localizableStrings.LastUpdateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				MarketplaceLink: {
					uId: "9b0af75c-6cb3-4826-9244-ce4f82f760d7",
					name: "MarketplaceLink",
					caption: resources.localizableStrings.MarketplaceLinkCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				HelpLink: {
					uId: "b4fcdf44-2fd7-4144-a7ac-f0499af1f29c",
					name: "HelpLink",
					caption: resources.localizableStrings.HelpLinkCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				FileLink: {
					uId: "9b1eb4c0-e32e-4a5d-8345-a4cd2eb79ea6",
					name: "FileLink",
					caption: resources.localizableStrings.FileLinkCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SupportEmail: {
					uId: "95b9bde0-84ef-4a32-93d7-a18b08cb93f9",
					name: "SupportEmail",
					caption: resources.localizableStrings.SupportEmailCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				OrderLink: {
					uId: "2b224027-2933-49e7-b508-3adbeac9f399",
					name: "OrderLink",
					caption: resources.localizableStrings.OrderLinkCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SysInstalledAppStatus: {
					uId: "9c9e5d69-f096-4e6c-833c-5296db9d68b4",
					name: "SysInstalledAppStatus",
					caption: resources.localizableStrings.SysInstalledAppStatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysInstalledAppStatus",
					referenceSchema: {
						name: "SysInstalledAppStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				IconBackground: {
					uId: "5f10bf59-890d-51c1-9bd3-63b1c6f1fe52",
					name: "IconBackground",
					caption: resources.localizableStrings.IconBackgroundCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: "#FF4013"
					},
					size: 50
				},
				SysAppIcon: {
					uId: "d4bad5e8-9a59-399a-0f1e-1c80ebc4f075",
					name: "SysAppIcon",
					caption: resources.localizableStrings.SysAppIconCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysAppIcons",
					referenceSchema: {
						name: "SysAppIcons",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "1a1ee397-d500-4dff-9006-98626855b7e9"
						}
					}
				},
				IsDeleteDeny: {
					uId: "1f2718fc-2d34-d61e-d542-227e6bca9605",
					name: "IsDeleteDeny",
					caption: resources.localizableStrings.IsDeleteDenyCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: false
					}
				},
				Checksum: {
					uId: "7cb6351b-6acc-e834-0c7a-88abf422bfd1",
					name: "Checksum",
					caption: resources.localizableStrings.ChecksumCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				NeedUpdate: {
					uId: "be0cdfa6-c4f4-aecd-0d55-76b4d410453f",
					name: "NeedUpdate",
					caption: resources.localizableStrings.NeedUpdateCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				VersionForUpdate: {
					uId: "d8249844-d703-06e8-f401-3fbde82715e2",
					name: "VersionForUpdate",
					caption: resources.localizableStrings.VersionForUpdateCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				Version: {
					uId: "ebf523f3-ef86-11c1-9062-533e155fdd78",
					name: "Version",
					caption: resources.localizableStrings.VersionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				MarketplaceAppId: {
					uId: "5dd7f89c-0d6c-41ac-9932-9c778e931701",
					name: "MarketplaceAppId",
					caption: resources.localizableStrings.MarketplaceAppIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				RunParams: {
					uId: "2add1918-6c17-ee72-310b-09268428a17b",
					name: "RunParams",
					caption: resources.localizableStrings.RunParamsCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				RunType: {
					uId: "cf9a68be-abff-380b-708b-442b38faa647",
					name: "RunType",
					caption: resources.localizableStrings.RunTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysInstalledAppRunType",
					referenceSchema: {
						name: "SysInstalledAppRunType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.SysInstalledApp;
	});