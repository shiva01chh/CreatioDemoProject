define("SysWorkplace", ["terrasoft", "ext-base", "SysWorkplaceResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SysWorkplace", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SysWorkplace",
			singleton: true,
			uId: "f54121e1-d75d-42e0-b790-bc8aa0bb216c",
			name: "SysWorkplace",
			caption: resources.localizableStrings.SysWorkplaceCaption,
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
				Position: {
					uId: "bd12ea8e-2bc2-42bf-925a-3ab766cc0b9f",
					name: "Position",
					caption: resources.localizableStrings.PositionCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Name: {
					uId: "215e82ee-20b0-4aa2-af3b-ff06cbc6da52",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				IsPersonal: {
					uId: "cd8bcb82-b061-468d-bcce-a5a9312866e4",
					name: "IsPersonal",
					caption: resources.localizableStrings.IsPersonalCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LoaderId: {
					uId: "8fe2b261-a69f-4846-bf82-f36e564d0aa4",
					name: "LoaderId",
					caption: resources.localizableStrings.LoaderIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: "3707a058-e6a8-4d2c-99cc-d01d9e6b70c6"
					}
				},
				SysApplicationClientType: {
					uId: "445c4583-2f21-4d2b-a6ba-c33108797ae0",
					name: "SysApplicationClientType",
					caption: resources.localizableStrings.SysApplicationClientTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysApplicationClientType",
					referenceSchema: {
						name: "SysApplicationClientType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "195785b4-f55a-4e72-ace3-6480b54c8fa5"
						}
					}
				},
				Type: {
					uId: "dae36990-bfb4-4f13-ae18-1b18b6081983",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysWorkplaceType",
					referenceSchema: {
						name: "SysWorkplaceType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "000a9225-728b-4778-a951-c42439ffe024"
						}
					}
				},
				HomePageUId: {
					uId: "d3a42fb5-39c6-09fc-54d1-5071e61f145e",
					name: "HomePageUId",
					caption: resources.localizableStrings.HomePageUIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				UseOnlyShell: {
					uId: "13abfaf9-679b-7bc5-fa9a-fc593be03f90",
					name: "UseOnlyShell",
					caption: resources.localizableStrings.UseOnlyShellCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.SysWorkplace;
	});