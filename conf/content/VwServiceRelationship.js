define("VwServiceRelationship", ["terrasoft", "ext-base", "VwServiceRelationshipResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.VwServiceRelationship", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.VwServiceRelationship",
			singleton: true,
			uId: "3708db29-d754-44ad-95ce-aaf09d2a6138",
			name: "VwServiceRelationship",
			caption: resources.localizableStrings.VwServiceRelationshipCaption,
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
					isValueCloneable: true,
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
					isValueCloneable: false,
					isSensitiveData: false
				},
				ServiceItemA: {
					uId: "b8e4c88a-40bc-45b3-95c2-e86a16b8c171",
					name: "ServiceItemA",
					caption: resources.localizableStrings.ServiceItemACaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
				ServiceItemB: {
					uId: "084788d9-7402-4915-a184-d2055ec901ca",
					name: "ServiceItemB",
					caption: resources.localizableStrings.ServiceItemBCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
				DependencyCategory: {
					uId: "2f4c5305-cdf0-42e4-9d80-2771c71a71b5",
					name: "DependencyCategory",
					caption: resources.localizableStrings.DependencyCategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
					uId: "e366773d-03be-4eda-9610-28e02598f4cb",
					name: "DependencyType",
					caption: resources.localizableStrings.DependencyTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
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
					uId: "7f69409e-99e2-4124-ba84-5e34db4f5da4",
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
					uId: "e14c3235-52f9-4667-ae7c-4538c3fff7cb",
					name: "DependencyTypeReverseName",
					caption: resources.localizableStrings.DependencyTypeReverseNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				IsCopy: {
					uId: "77bd3e91-ad4e-4623-90f5-0012628bd25d",
					name: "IsCopy",
					caption: resources.localizableStrings.IsCopyCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.VwServiceRelationship;
	});