﻿define("LeadInQualifyStatus", ["terrasoft", "ext-base", "LeadInQualifyStatusResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.LeadInQualifyStatus", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.LeadInQualifyStatus",
			singleton: true,
			uId: "071aba13-b2b4-4050-aa8f-dab49a65b4b1",
			name: "LeadInQualifyStatus",
			caption: resources.localizableStrings.LeadInQualifyStatusCaption,
			administratedByRecords: false,
			administratedByOperations: true,
			isTrackChangesInDB: false,
			useMasterRecordRights: true,
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
				StartDate: {
					uId: "5dfad129-a300-4625-9da3-8f9aa16968cc",
					name: "StartDate",
					caption: resources.localizableStrings.StartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DueDate: {
					uId: "9329871d-a406-4f91-b5f8-8e914e31b329",
					name: "DueDate",
					caption: resources.localizableStrings.DueDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Owner: {
					uId: "b7b10879-fd03-470d-bdcf-ec591718dc13",
					name: "Owner",
					caption: resources.localizableStrings.OwnerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
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
				Historical: {
					uId: "6b8a78c9-8296-425e-a642-2e2170308d5e",
					name: "Historical",
					caption: resources.localizableStrings.HistoricalCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Lead: {
					uId: "c206c35e-5504-4e34-905b-d59ab54f754e",
					name: "Lead",
					caption: resources.localizableStrings.LeadCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Lead",
					referenceSchema: {
						name: "Lead",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "LeadName"
					}
				},
				QualifyStatus: {
					uId: "e02b4e41-afa4-4124-9d4d-ba9b1ddf14a0",
					name: "QualifyStatus",
					caption: resources.localizableStrings.QualifyStatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "QualifyStatus",
					referenceSchema: {
						name: "QualifyStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.LeadInQualifyStatus;
	});