define("AcademyUrlData", ["terrasoft", "ext-base", "AcademyUrlDataResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.AcademyUrlData", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.AcademyUrlData",
			singleton: true,
			uId: "6ebcd9a3-4075-c977-9ff2-0905420c2ee8",
			name: "AcademyUrlData",
			caption: resources.localizableStrings.AcademyUrlDataCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "ContextHelpId",
			columns: {
				Id: {
					uId: "e3449fea-35c6-c2e8-7cfd-4246960d49c3",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				UseLmsDocumentation: {
					uId: "96c8943c-0046-8034-b640-567284d3d47a",
					name: "UseLmsDocumentation",
					caption: resources.localizableStrings.UseLmsDocumentationCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ConfigurationVersion: {
					uId: "9d67317d-8393-94b0-7e9b-31925aa9f79d",
					name: "ConfigurationVersion",
					caption: resources.localizableStrings.ConfigurationVersionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				ProductEdition: {
					uId: "ff48e8bc-0811-7ef9-630c-0da7f0a93ec1",
					name: "ProductEdition",
					caption: resources.localizableStrings.ProductEditionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				ContextHelpId: {
					uId: "49637441-35e4-cdda-9400-c8085fc2da68",
					name: "ContextHelpId",
					caption: resources.localizableStrings.ContextHelpIdCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				EnableContextHelp: {
					uId: "900e6c57-ba9c-fd9b-e463-46e8ab560a73",
					name: "EnableContextHelp",
					caption: resources.localizableStrings.EnableContextHelpCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LMSUrl: {
					uId: "a3997651-3d01-e060-f334-3f0d0e53601a",
					name: "LMSUrl",
					caption: resources.localizableStrings.LMSUrlCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Code: {
					uId: "f5589e0f-b171-42c8-9c8e-447a2ff1b611",
					name: "Code",
					caption: resources.localizableStrings.CodeCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				}
			}
		});
		return Terrasoft.AcademyUrlData;
	});