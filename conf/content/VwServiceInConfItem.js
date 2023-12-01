define("VwServiceInConfItem", ["terrasoft", "ext-base", "VwServiceInConfItemResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.VwServiceInConfItem", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.VwServiceInConfItem",
			singleton: true,
			uId: "f352fdd7-1847-46e6-a7bc-cd3772b42761",
			name: "VwServiceInConfItem",
			caption: resources.localizableStrings.VwServiceInConfItemCaption,
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
				ServiceItem: {
					uId: "4fdd0a6e-8cc1-4c8c-8c97-b73350649bbb",
					name: "ServiceItem",
					caption: resources.localizableStrings.ServiceItemCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ServiceItem",
					referenceSchema: {
						name: "ServiceItem",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ConfItem: {
					uId: "cf52e41d-0007-463e-9df4-96091daffa73",
					name: "ConfItem",
					caption: resources.localizableStrings.ConfItemCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ConfItem",
					referenceSchema: {
						name: "ConfItem",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				DependencyCategory: {
					uId: "bb0bb68a-4f72-483c-b4d7-66febe2ddcc1",
					name: "DependencyCategory",
					caption: resources.localizableStrings.DependencyCategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "DependencyCategory",
					referenceSchema: {
						name: "DependencyCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				DependencyCategoryReverse: {
					uId: "582f8b4a-aec6-4bfc-aa4b-6c0752cf9ede",
					name: "DependencyCategoryReverse",
					caption: resources.localizableStrings.DependencyCategoryReverseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "DependencyCategory",
					referenceSchema: {
						name: "DependencyCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				DependencyType: {
					uId: "cc92151e-2069-436f-af46-e22d9f6d1332",
					name: "DependencyType",
					caption: resources.localizableStrings.DependencyTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "DependencyType",
					referenceSchema: {
						name: "DependencyType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				DependencyTypeCategory: {
					uId: "fb18483d-ee4b-4bd2-b0e3-2fc96e3c32f2",
					name: "DependencyTypeCategory",
					caption: resources.localizableStrings.DependencyTypeCategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "DependencyCategory",
					referenceSchema: {
						name: "DependencyCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				DependencyTypeReverseName: {
					uId: "70e64548-4af6-4245-88c6-aa88dfc02606",
					name: "DependencyTypeReverseName",
					caption: resources.localizableStrings.DependencyTypeReverseNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				}
			}
		});
		return Terrasoft.VwServiceInConfItem;
	});