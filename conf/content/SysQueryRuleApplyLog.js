define("SysQueryRuleApplyLog", ["terrasoft", "ext-base", "SysQueryRuleApplyLogResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SysQueryRuleApplyLog", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SysQueryRuleApplyLog",
			singleton: true,
			uId: "923d0996-7e08-47f8-bce7-e74ae7f7a20e",
			name: "SysQueryRuleApplyLog",
			caption: resources.localizableStrings.SysQueryRuleApplyLogCaption,
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
				SysQueryStackTrace: {
					uId: "fb4f1c70-3606-3403-1531-0b74919d1603",
					name: "SysQueryStackTrace",
					caption: resources.localizableStrings.SysQueryStackTraceCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysQueryStackTrace",
					referenceSchema: {
						name: "SysQueryStackTrace",
						primaryColumnName: "Id",
						primaryDisplayColumnName: null
					}
				},
				SysQuerySqlText: {
					uId: "c0e6b3aa-eb71-53b3-98c0-f526d11f93ca",
					name: "SysQuerySqlText",
					caption: resources.localizableStrings.SysQuerySqlTextCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysQuerySqlText",
					referenceSchema: {
						name: "SysQuerySqlText",
						primaryColumnName: "Id",
						primaryDisplayColumnName: null
					}
				},
				SysQueryDetector: {
					uId: "72e650af-7a08-c8c6-d7c6-1ab8ec096fa8",
					name: "SysQueryDetector",
					caption: resources.localizableStrings.SysQueryDetectorCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysQueryDetector",
					referenceSchema: {
						name: "SysQueryDetector",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SysQueryAction: {
					uId: "77635c6a-eb4c-0c7d-f419-f728dca6d10f",
					name: "SysQueryAction",
					caption: resources.localizableStrings.SysQueryActionCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysQueryAction",
					referenceSchema: {
						name: "SysQueryAction",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Message: {
					uId: "58da2805-dda7-416a-52b8-47fccff27d7d",
					name: "Message",
					caption: resources.localizableStrings.MessageCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				RootSchemaName: {
					uId: "5a63d8fa-c91e-c9e0-c5a1-346f5480dcb8",
					name: "RootSchemaName",
					caption: resources.localizableStrings.RootSchemaNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				UserName: {
					uId: "7a5cec88-9cf0-481c-0684-3ea18891567e",
					name: "UserName",
					caption: resources.localizableStrings.UserNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				QueryExecutionTime: {
					uId: "ae3c7412-29a0-a16f-2fe5-5a83bab39cc0",
					name: "QueryExecutionTime",
					caption: resources.localizableStrings.QueryExecutionTimeCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				}
			}
		});
		return Terrasoft.SysQueryRuleApplyLog;
	});