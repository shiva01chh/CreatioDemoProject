﻿define("SysQueryHandleRule", ["terrasoft", "ext-base", "SysQueryHandleRuleResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SysQueryHandleRule", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SysQueryHandleRule",
			singleton: true,
			uId: "25d4db17-93e6-49e1-82a0-a86aaeb83e03",
			name: "SysQueryHandleRule",
			caption: resources.localizableStrings.SysQueryHandleRuleCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: true,
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
				SysQueryAction: {
					uId: "50d93a6b-d9bc-e018-6361-cfbb3a5a5613",
					name: "SysQueryAction",
					caption: resources.localizableStrings.SysQueryActionCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "SysQueryAction",
					referenceSchema: {
						name: "SysQueryAction",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SysQueryDetector: {
					uId: "a7739811-0a1b-9b78-f61b-6207df99ee34",
					name: "SysQueryDetector",
					caption: resources.localizableStrings.SysQueryDetectorCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "SysQueryDetector",
					referenceSchema: {
						name: "SysQueryDetector",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SysSchema: {
					uId: "ab6fef3c-66e0-fac0-dadf-df9e15de4b94",
					name: "SysSchema",
					caption: resources.localizableStrings.SysSchemaCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "VwEntityObjects",
					referenceSchema: {
						name: "VwEntityObjects",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Title"
					}
				},
				IsActive: {
					uId: "3642de17-f6b1-4a37-27f9-bd0d37aed828",
					name: "IsActive",
					caption: resources.localizableStrings.IsActiveCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: true
					}
				},
				MinRowCount: {
					uId: "672e6557-0ee0-50ed-3d50-78704bac60f7",
					name: "MinRowCount",
					caption: resources.localizableStrings.MinRowCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: 1000
					}
				},
				IsSystem: {
					uId: "d1089d43-6725-e31a-e3fe-18d817c2734e",
					name: "IsSystem",
					caption: resources.localizableStrings.IsSystemCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LogStackTrace: {
					uId: "2e1f6911-afe5-7479-cd92-cc7a5d9b045f",
					name: "LogStackTrace",
					caption: resources.localizableStrings.LogStackTraceCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LogQueryExecutionTime: {
					uId: "488002e3-907e-cef3-3193-ed3a5a2f3e62",
					name: "LogQueryExecutionTime",
					caption: resources.localizableStrings.LogQueryExecutionTimeCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: true
					}
				}
			}
		});
		return Terrasoft.SysQueryHandleRule;
	});