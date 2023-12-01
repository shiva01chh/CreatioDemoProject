define("BulkEmailInProgress", ["terrasoft", "ext-base", "BulkEmailInProgressResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.BulkEmailInProgress", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.BulkEmailInProgress",
			singleton: true,
			uId: "ab8ddf21-3930-472b-8724-d2b2bf8f8257",
			name: "BulkEmailInProgress",
			caption: resources.localizableStrings.BulkEmailInProgressCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "SessionId",
			columns: {
				SessionId: {
					uId: "f1f3a9b2-666b-4cb3-8331-d163079c0b62",
					name: "SessionId",
					caption: resources.localizableStrings.SessionIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 1,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true
				},
				BulkEmailId: {
					uId: "c812ddcd-8e0e-4db3-ac44-94f97402eb9d",
					name: "BulkEmailId",
					caption: resources.localizableStrings.BulkEmailIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 1,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true
				},
				CreatedOn: {
					uId: "c4499e57-3833-472c-b6ea-9b481dc68a75",
					name: "CreatedOn",
					caption: resources.localizableStrings.CreatedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 1,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDateTime"
					}
				},
				PreparedToSendCount: {
					uId: "70a5b2fe-5dc4-938c-20a7-8aaf68fafc85",
					name: "PreparedToSendCount",
					caption: resources.localizableStrings.PreparedToSendCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ModifiedOn: {
					uId: "4cd24c82-7db4-175c-40a1-55536e08fe8a",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				SendCount: {
					uId: "b69a3932-a839-bb4f-01ad-d01348b0635d",
					name: "SendCount",
					caption: resources.localizableStrings.SendCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.BulkEmailInProgress;
	});