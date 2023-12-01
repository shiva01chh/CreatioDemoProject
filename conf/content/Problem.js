define("Problem", ["terrasoft", "ext-base", "ProblemResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.Problem", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.Problem",
			singleton: true,
			uId: "7ec5366d-8edf-4b7d-b94b-2bc2655cf230",
			name: "Problem",
			caption: resources.localizableStrings.ProblemCaption,
			administratedByRecords: true,
			administratedByOperations: true,
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
					uId: "f96d7882-6059-4f58-8e6a-c9a7e614023c",
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
					uId: "574a4f31-52cd-4a5c-b8a1-2da99b212660",
					name: "Number",
					caption: resources.localizableStrings.NumberCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Author: {
					uId: "67655160-1c27-4456-b640-4bb6dc555258",
					name: "Author",
					caption: resources.localizableStrings.AuthorCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
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
				Type: {
					uId: "99123097-7f1e-4325-8e72-bc5e8d8234d6",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ProblemType",
					referenceSchema: {
						name: "ProblemType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				RegisteredOn: {
					uId: "f980bbae-7e0c-41fd-95b0-5022a732930a",
					name: "RegisteredOn",
					caption: resources.localizableStrings.RegisteredOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDate"
					}
				},
				Symptoms: {
					uId: "7029e40a-1b15-40d4-9769-a79009536522",
					name: "Symptoms",
					caption: resources.localizableStrings.SymptomsCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Priority: {
					uId: "2adca2da-1a99-483a-9728-edad77793cf9",
					name: "Priority",
					caption: resources.localizableStrings.PriorityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ProblemPriority",
					referenceSchema: {
						name: "ProblemPriority",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ProblemPriorityDef"
					}
				},
				Status: {
					uId: "76e8a108-58ed-4727-868a-2d0511faef1f",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ProblemStatus",
					referenceSchema: {
						name: "ProblemStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SETTINGS,
						value: "ProblemStatusDef"
					}
				},
				Owner: {
					uId: "3caee6bf-941e-46ca-8724-a06dca363fa2",
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
					}
				},
				Group: {
					uId: "3caba9d5-6aee-496c-983f-a15353486ba5",
					name: "Group",
					caption: resources.localizableStrings.GroupCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysAdminUnit",
					referenceSchema: {
						name: "SysAdminUnit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ConfItem: {
					uId: "1342beaa-1f8a-4c7e-9775-a484773bb210",
					name: "ConfItem",
					caption: resources.localizableStrings.ConfItemCaption,
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
				Solution: {
					uId: "8e542091-eec4-441a-86d4-1c2ad8ad6857",
					name: "Solution",
					caption: resources.localizableStrings.SolutionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ServiceItem: {
					uId: "7204fbfe-4186-4833-8b81-e959648b0f51",
					name: "ServiceItem",
					caption: resources.localizableStrings.ServiceItemCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ServiceItem",
					referenceSchema: {
						name: "ServiceItem",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SolutionPlanedOn: {
					uId: "ab13bde7-59e9-46a2-88b3-f72f9a549536",
					name: "SolutionPlanedOn",
					caption: resources.localizableStrings.SolutionPlanedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SolutionProvidedOn: {
					uId: "4ed67c7c-6634-441d-9021-3f96887aa80b",
					name: "SolutionProvidedOn",
					caption: resources.localizableStrings.SolutionProvidedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ClosureDate: {
					uId: "dbc268c1-d869-449e-bf55-37a876d49f5b",
					name: "ClosureDate",
					caption: resources.localizableStrings.ClosureDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Change: {
					uId: "e2139c27-ea75-4281-a489-8dff2f312395",
					name: "Change",
					caption: resources.localizableStrings.ChangeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Change",
					referenceSchema: {
						name: "Change",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Number"
					}
				}
			}
		});
		return Terrasoft.Problem;
	});