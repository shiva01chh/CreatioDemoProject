define("VwConfItemRelationship", ["terrasoft", "ext-base", "VwConfItemRelationshipResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.VwConfItemRelationship", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.VwConfItemRelationship",
			singleton: true,
			uId: "65578748-393a-4f5b-a7d7-58bd2f49da66",
			name: "VwConfItemRelationship",
			caption: resources.localizableStrings.VwConfItemRelationshipCaption,
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
				ConfItemA: {
					uId: "01612ecc-abf7-4399-af90-6e9e507fd2bd",
					name: "ConfItemA",
					caption: resources.localizableStrings.ConfItemACaption,
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
				ConfItemB: {
					uId: "e1c56d8a-583c-4067-bae7-420eade26979",
					name: "ConfItemB",
					caption: resources.localizableStrings.ConfItemBCaption,
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
					uId: "611377a0-ae64-4d0f-b50e-c15db72bac75",
					name: "DependencyCategory",
					caption: resources.localizableStrings.DependencyCategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
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
					uId: "fc83d1eb-1845-4b41-b836-d6b2c8cadf6a",
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
				IsCopy: {
					uId: "6c1f9b9c-dbda-472c-84a4-ff3cff97e215",
					name: "IsCopy",
					caption: resources.localizableStrings.IsCopyCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DependencyTypeCategory: {
					uId: "5d31fa0e-0297-4690-a668-cc08862638bd",
					name: "DependencyTypeCategory",
					caption: resources.localizableStrings.DependencyTypeCategoryCaption,
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
				DependencyTypeReverseName: {
					uId: "c42c10c3-8b0e-4481-ac0d-3b75c0896a80",
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
		return Terrasoft.VwConfItemRelationship;
	});