﻿define("ApplicationSection", ["terrasoft", "ext-base", "ApplicationSectionResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.ApplicationSection", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.ApplicationSection",
			singleton: true,
			uId: "12a20dab-8fb7-464f-af4c-7cb5bf6e1f8d",
			name: "ApplicationSection",
			caption: resources.localizableStrings.ApplicationSectionCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Caption",
			columns: {
				ApplicationId: {
					uId: "e222d9e3-9d8b-b489-db62-cb969726b935",
					name: "ApplicationId",
					caption: resources.localizableStrings.ApplicationIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Caption: {
					uId: "bb77df05-4141-81ae-05a1-37d8ba1f0abf",
					name: "Caption",
					caption: resources.localizableStrings.CaptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				Id: {
					uId: "ae907638-8379-fc62-3309-011276491aaf",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				SchemaType: {
					uId: "541d11ae-52f4-55c6-7b75-db60467790b8",
					name: "SchemaType",
					caption: resources.localizableStrings.SchemaTypeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SectionSchemaUId: {
					uId: "070999ac-79ba-19b1-6c82-176b517a228d",
					name: "SectionSchemaUId",
					caption: resources.localizableStrings.SectionSchemaUIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Code: {
					uId: "dac70b92-7fc8-59bd-22ce-8fad8b4a33b6",
					name: "Code",
					caption: resources.localizableStrings.CodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				LogoId: {
					uId: "377c946b-d567-7fa0-6d9c-9e3d42e82822",
					name: "LogoId",
					caption: resources.localizableStrings.LogoIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Type: {
					uId: "6294424a-ff0d-a552-c9a4-106c17ec3b22",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Description: {
					uId: "23812baa-f4bc-6eac-a98b-9e7a933f8e09",
					name: "Description",
					caption: resources.localizableStrings.DescriptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ModifiedOn: {
					uId: "a838da6f-a251-df9a-c124-15534aeef0c5",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				EntitySchemaName: {
					uId: "55a950dc-04d9-f174-0f39-23f87c1ca4a6",
					name: "EntitySchemaName",
					caption: resources.localizableStrings.EntitySchemaNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				IconBackground: {
					uId: "1a6be5b1-cc2d-b4fd-3eb5-978d2d108faa",
					name: "IconBackground",
					caption: resources.localizableStrings.IconBackgroundCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				}
			}
		});
		return Terrasoft.ApplicationSection;
	});