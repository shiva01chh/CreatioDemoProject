﻿define("SysXssProtectRuleViolation", ["terrasoft", "ext-base", "SysXssProtectRuleViolationResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SysXssProtectRuleViolation", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SysXssProtectRuleViolation",
			singleton: true,
			uId: "e322ec8a-e1da-4bf9-b18d-eec2a834e5fb",
			name: "SysXssProtectRuleViolation",
			caption: resources.localizableStrings.SysXssProtectRuleViolationCaption,
			administratedByRecords: false,
			administratedByOperations: true,
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
				BlockedUrl: {
					uId: "06bd7a19-d81c-fbc4-69f1-6cff531af383",
					name: "BlockedUrl",
					caption: resources.localizableStrings.BlockedUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Agent: {
					uId: "213a9f0e-a50b-4222-47e3-081f3c54739f",
					name: "Agent",
					caption: resources.localizableStrings.AgentCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				IPAddress: {
					uId: "19ae0516-df8a-2275-2c7a-293111116b02",
					name: "IPAddress",
					caption: resources.localizableStrings.IPAddressCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				UserLogin: {
					uId: "8691d75a-c6c3-8e92-0c8a-88ee951f12f8",
					name: "UserLogin",
					caption: resources.localizableStrings.UserLoginCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ViolationDate: {
					uId: "32f990cf-095f-3dce-c679-d58ed8a403bd",
					name: "ViolationDate",
					caption: resources.localizableStrings.ViolationDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				EntitySchemaName: {
					uId: "5bdc24f9-0dae-dc6b-26f3-7ef47cd90cd2",
					name: "EntitySchemaName",
					caption: resources.localizableStrings.EntitySchemaNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				ViolatedRule: {
					uId: "00592191-22b2-dde9-3a6d-a24d03c1cde7",
					name: "ViolatedRule",
					caption: resources.localizableStrings.ViolatedRuleCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				ViolatedRuleType: {
					uId: "8b4c0a4d-5cfe-658c-4ce5-226718816c20",
					name: "ViolatedRuleType",
					caption: resources.localizableStrings.ViolatedRuleTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysXssProtectRuleType",
					referenceSchema: {
						name: "SysXssProtectRuleType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				}
			}
		});
		return Terrasoft.SysXssProtectRuleViolation;
	});