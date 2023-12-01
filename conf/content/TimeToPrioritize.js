define("TimeToPrioritize", ["terrasoft", "ext-base", "TimeToPrioritizeResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.TimeToPrioritize", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.TimeToPrioritize",
			singleton: true,
			uId: "f0740e3e-3dce-4594-9495-b306e3d1751c",
			name: "TimeToPrioritize",
			caption: resources.localizableStrings.TimeToPrioritizeCaption,
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
				CasePriority: {
					uId: "b1b5135e-fd3e-44e4-800e-77e2e4ea1dc7",
					name: "CasePriority",
					caption: resources.localizableStrings.CasePriorityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "CasePriority",
					referenceSchema: {
						name: "CasePriority",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ReactionTimeUnit: {
					uId: "063dffcd-c5db-49d4-be17-325e1933c532",
					name: "ReactionTimeUnit",
					caption: resources.localizableStrings.ReactionTimeUnitCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "TimeUnit",
					referenceSchema: {
						name: "TimeUnit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ReactionTimeValue: {
					uId: "90bded78-97f2-4922-a5c5-b7dbed3b2fa2",
					name: "ReactionTimeValue",
					caption: resources.localizableStrings.ReactionTimeValueCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				SolutionTimeUnit: {
					uId: "eab15b3f-a9be-4d9f-893a-ed4637ea145f",
					name: "SolutionTimeUnit",
					caption: resources.localizableStrings.SolutionTimeUnitCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "TimeUnit",
					referenceSchema: {
						name: "TimeUnit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SolutionTimeValue: {
					uId: "7d9d92cb-2044-4e16-8ad8-0674199646c0",
					name: "SolutionTimeValue",
					caption: resources.localizableStrings.SolutionTimeValueCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ServiceInServicePact: {
					uId: "6a37ee82-3cac-42a4-859f-64998d01f90e",
					name: "ServiceInServicePact",
					caption: resources.localizableStrings.ServiceInServicePactCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ServiceInServicePact",
					referenceSchema: {
						name: "ServiceInServicePact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "ConcatName"
					}
				}
			}
		});
		return Terrasoft.TimeToPrioritize;
	});