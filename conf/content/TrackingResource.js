define("TrackingResource", ["terrasoft", "ext-base", "TrackingResourceResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.TrackingResource", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.TrackingResource",
			singleton: true,
			uId: "87d7834d-e6fb-449f-a1bd-dbb57679ad87",
			name: "TrackingResource",
			caption: resources.localizableStrings.TrackingResourceCaption,
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
				Name: {
					uId: "fd8dbf8b-c885-432e-993b-1fd43b15277e",
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
				Source: {
					uId: "5c57f67a-bcf3-4eb7-b3ae-cb3d8a1f8527",
					name: "Source",
					caption: resources.localizableStrings.SourceCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				IsActive: {
					uId: "f08e1ecc-dc92-474c-87e9-3386c0dd685c",
					name: "IsActive",
					caption: resources.localizableStrings.IsActiveCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				IsDeleted: {
					uId: "e5d64707-88bb-4c9b-baed-c0fc22d918b4",
					name: "IsDeleted",
					caption: resources.localizableStrings.IsDeletedCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Project: {
					uId: "eb8ffd47-256d-427f-8467-d6f0fc67f5a2",
					name: "Project",
					caption: resources.localizableStrings.ProjectCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "TrackingProject",
					referenceSchema: {
						name: "TrackingProject",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.TrackingResource;
	});