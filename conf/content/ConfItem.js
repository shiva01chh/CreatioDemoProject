define("ConfItem", ["terrasoft", "ext-base", "ConfItemResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.ConfItem", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.ConfItem",
			singleton: true,
			uId: "ad707075-cf25-40bf-85c1-f5da38cf0d5d",
			name: "ConfItem",
			caption: resources.localizableStrings.ConfItemCaption,
			administratedByRecords: true,
			administratedByOperations: true,
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
				Name: {
					uId: "4ea61b17-b7e6-4e10-942f-246339e0ff07",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				Type: {
					uId: "527ad368-46be-41f3-9e14-2032eb0740f4",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ConfigItemType",
					referenceSchema: {
						name: "ConfigItemType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Model: {
					uId: "e2f4f7d7-6bbc-4ef7-a49e-f7822d8b1764",
					name: "Model",
					caption: resources.localizableStrings.ModelCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ConfigItemModel",
					referenceSchema: {
						name: "ConfigItemModel",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SerialNumber: {
					uId: "f6afc6ee-bf06-40c0-8017-268324098d4c",
					name: "SerialNumber",
					caption: resources.localizableStrings.SerialNumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				InventoryNumber: {
					uId: "48b3f5ba-fe8d-43cf-9e57-2ba888714986",
					name: "InventoryNumber",
					caption: resources.localizableStrings.InventoryNumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 250
				},
				Status: {
					uId: "c45e1755-3c1f-4b0d-bd6b-c602aac23cbf",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ConfigItemStatus",
					referenceSchema: {
						name: "ConfigItemStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ConfigurationItemStatusDef"
					}
				},
				PurchaseDate: {
					uId: "43b4722d-6adc-4b8a-b14a-864d13d4d579",
					name: "PurchaseDate",
					caption: resources.localizableStrings.PurchaseDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				CancelDate: {
					uId: "80540aed-fffb-41bc-96e4-ac16b34e51c8",
					name: "CancelDate",
					caption: resources.localizableStrings.CancelDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				WarrantyUntil: {
					uId: "3582c7f2-22db-47d1-99f7-92606faa635e",
					name: "WarrantyUntil",
					caption: resources.localizableStrings.WarrantyUntilCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Owner: {
					uId: "dc05841e-7887-4c81-abde-19d16764ff88",
					name: "Owner",
					caption: resources.localizableStrings.OwnerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
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
				ParentConfItem: {
					uId: "eca77133-6ed4-4215-96df-5ff5332bfa0a",
					name: "ParentConfItem",
					caption: resources.localizableStrings.ParentConfItemCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ConfItem",
					referenceSchema: {
						name: "ConfItem",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Category: {
					uId: "4a483263-4df5-41ac-907d-44ac80791399",
					name: "Category",
					caption: resources.localizableStrings.CategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ConfigItemCategory",
					referenceSchema: {
						name: "ConfigItemCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Notes: {
					uId: "b341a593-74f0-46d2-8f57-9b3167a1513b",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Country: {
					uId: "4d9aba72-ae48-40dc-93d8-f185f5db8e24",
					name: "Country",
					caption: resources.localizableStrings.CountryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Country",
					referenceSchema: {
						name: "Country",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Region: {
					uId: "fe477f7c-fac9-43fb-b3be-60c2365f58ae",
					name: "Region",
					caption: resources.localizableStrings.RegionCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Region",
					referenceSchema: {
						name: "Region",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				City: {
					uId: "457b1dc5-10f6-4f7c-98f3-9cbc12f7f6af",
					name: "City",
					caption: resources.localizableStrings.CityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "City",
					referenceSchema: {
						name: "City",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Street: {
					uId: "63a0ae99-7719-48cc-a857-0389e7f8d0cd",
					name: "Street",
					caption: resources.localizableStrings.StreetCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Address: {
					uId: "0da4fb4f-9441-4bf2-a7fb-5ec07a5de470",
					name: "Address",
					caption: resources.localizableStrings.AddressCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				}
			}
		});
		return Terrasoft.ConfItem;
	});