define("Release", ["terrasoft", "ext-base", "ReleaseResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.Release", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.Release",
			singleton: true,
			uId: "0bf3a274-e5da-4fc7-94c4-3ae233598714",
			name: "Release",
			caption: resources.localizableStrings.ReleaseCaption,
			administratedByRecords: true,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Number",
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
					uId: "01b5fe20-d534-4f5b-a29c-68919cf82187",
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
				Number: {
					uId: "cde36d11-02ce-4432-b7f2-d47e6bdd4a5e",
					name: "Number",
					caption: resources.localizableStrings.NumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					size: 50
				},
				Description: {
					uId: "2ce63b1d-2436-4cf9-9fa2-1af60486e97c",
					name: "Description",
					caption: resources.localizableStrings.DescriptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 500
				},
				ScheduledReleaseDate: {
					uId: "6e6c9702-4579-44c9-b3e1-3292bcdd76a9",
					name: "ScheduledReleaseDate",
					caption: resources.localizableStrings.ScheduledReleaseDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				PlannedLabor: {
					uId: "848384a8-996a-43d0-8a7c-d4ac370d927d",
					name: "PlannedLabor",
					caption: resources.localizableStrings.PlannedLaborCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ReleasedOn: {
					uId: "ed1ac00a-35d0-49cf-a98b-c7727a743407",
					name: "ReleasedOn",
					caption: resources.localizableStrings.ReleasedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				DevelopmentFinishedOn: {
					uId: "1351f672-5491-4478-b989-c14ca07fc932",
					name: "DevelopmentFinishedOn",
					caption: resources.localizableStrings.DevelopmentFinishedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				TestingFinishedOn: {
					uId: "676954b6-2543-40d6-a7c7-c66a16f30f20",
					name: "TestingFinishedOn",
					caption: resources.localizableStrings.TestingFinishedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				DeploymentFinishedOn: {
					uId: "2593ddf4-7121-451e-8ab3-c7930ae36a16",
					name: "DeploymentFinishedOn",
					caption: resources.localizableStrings.DeploymentFinishedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ActualLabor: {
					uId: "26913998-0c91-4ec2-8ea7-a5056e318c11",
					name: "ActualLabor",
					caption: resources.localizableStrings.ActualLaborCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ActualDevelopmentLabor: {
					uId: "85a73cbf-9bfe-46fa-aeb1-ca38b8071b36",
					name: "ActualDevelopmentLabor",
					caption: resources.localizableStrings.ActualDevelopmentLaborCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ActualTestingLabor: {
					uId: "7c4c7e8d-fa44-477c-9f39-64161076afe8",
					name: "ActualTestingLabor",
					caption: resources.localizableStrings.ActualTestingLaborCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ActualDeploymentLabor: {
					uId: "07f0e60b-e26b-492d-bdd3-38fc356a8e15",
					name: "ActualDeploymentLabor",
					caption: resources.localizableStrings.ActualDeploymentLaborCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Status: {
					uId: "b5bd8c19-aeea-4e9b-893e-a17447e80c13",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ReleaseStatus",
					referenceSchema: {
						name: "ReleaseStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ReleaseStatusDef"
					}
				},
				Type: {
					uId: "2db0a991-0c65-4cde-b77e-de49aa699b69",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ReleaseType",
					referenceSchema: {
						name: "ReleaseType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ReleaseTypeDef"
					}
				},
				Priority: {
					uId: "6cc600e8-2a43-45a8-9d9e-8c99fbb066d5",
					name: "Priority",
					caption: resources.localizableStrings.PriorityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ReleasePriority",
					referenceSchema: {
						name: "ReleasePriority",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ReleasePriorityDef"
					}
				},
				Notes: {
					uId: "e2bab1e9-4524-466c-afe8-f154160fbe4f",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.Release;
	});