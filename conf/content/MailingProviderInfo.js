define("MailingProviderInfo", ["terrasoft", "ext-base", "MailingProviderInfoResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.MailingProviderInfo", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.MailingProviderInfo",
			singleton: true,
			uId: "e048d9e5-0fbb-43cd-9930-3bfd1c1c9acb",
			name: "MailingProviderInfo",
			caption: resources.localizableStrings.MailingProviderInfoCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				IsDefault: {
					uId: "62424342-b7fc-3e33-3ac5-584aff09b5cf",
					name: "IsDefault",
					caption: resources.localizableStrings.IsDefaultCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Id: {
					uId: "abd5e6e0-a4dc-b6d0-db8a-77df664ba511",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "AutoGuid"
					}
				},
				ProviderName: {
					uId: "720b0633-97e0-5610-11e4-1069e9372018",
					name: "ProviderName",
					caption: resources.localizableStrings.ProviderNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 500
				},
				IsConnected: {
					uId: "3ac88923-16c1-5cff-274f-e9087988ee56",
					name: "IsConnected",
					caption: resources.localizableStrings.IsConnectedCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 50
				}
			}
		});
		return Terrasoft.MailingProviderInfo;
	});