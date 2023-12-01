﻿define("ApplicationPage", ["terrasoft", "ext-base", "ApplicationPageResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.ApplicationPage", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.ApplicationPage",
			singleton: true,
			uId: "6e3987b3-c3d6-4902-9ba7-4f28c6f8f029",
			name: "ApplicationPage",
			caption: resources.localizableStrings.ApplicationPageCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				Id: {
					uId: "5a25e41d-f073-771a-0eb2-2da08ca742a2",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				PackageUId: {
					uId: "f5fd2219-389e-3e60-e95c-dc22be46d406",
					name: "PackageUId",
					caption: resources.localizableStrings.PackageUIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				UId: {
					uId: "14ac57c1-5195-558b-ef35-4fa49d31bb23",
					name: "UId",
					caption: resources.localizableStrings.UIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ModifiedOn: {
					uId: "d8eb7579-e1c4-3e88-b0eb-094d967c9091",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Caption: {
					uId: "6eb5acae-3d96-0bf5-4d99-87d116ef914c",
					name: "Caption",
					caption: resources.localizableStrings.CaptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Name: {
					uId: "251fc201-caf9-3f60-75a5-4ef63df7d403",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				Application: {
					uId: "44e4b2a2-7b6b-37ad-e441-6c77a1f4d2d9",
					name: "Application",
					caption: resources.localizableStrings.ApplicationCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysInstalledApp",
					referenceSchema: {
						name: "SysInstalledApp",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				PreviewImage: {
					uId: "0e22d10d-38de-c1c1-0827-89ed74e20326",
					name: "PreviewImage",
					caption: resources.localizableStrings.PreviewImageCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysImage",
					referenceSchema: {
						name: "SysImage",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "c65fd9dc-80e2-4a03-8984-61b5a013de11"
						}
					}
				},
				SchemaType: {
					uId: "0f6bb402-6c2b-52d3-77fe-89673b17ab96",
					name: "SchemaType",
					caption: resources.localizableStrings.SchemaTypeCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.ApplicationPage;
	});