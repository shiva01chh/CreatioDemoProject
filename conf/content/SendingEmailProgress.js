define("SendingEmailProgress", ["terrasoft", "ext-base", "SendingEmailProgressResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.SendingEmailProgress", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.SendingEmailProgress",
			singleton: true,
			uId: "c5938a65-78bf-fb90-1585-0221ab3f1c6b",
			name: "SendingEmailProgress",
			caption: resources.localizableStrings.SendingEmailProgressCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				PreparedRecipientsCount: {
					uId: "de736c98-eb3a-39e4-fb67-fc3e823971bb",
					name: "PreparedRecipientsCount",
					caption: resources.localizableStrings.PreparedRecipientsCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ModifiedOn: {
					uId: "c61ff70c-94b9-86c3-a608-cd26b0de9fd4",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Id: {
					uId: "add5da20-9aa7-0ee9-4996-f15ae4cea919",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				BulkEmail: {
					uId: "9a6357a5-edd0-a753-5581-24b09b199988",
					name: "BulkEmail",
					caption: resources.localizableStrings.BulkEmailCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmail",
					referenceSchema: {
						name: "BulkEmail",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ProcessedRecipientCount: {
					uId: "6b952ef2-b04a-6f0f-fc21-a32b79ea600e",
					name: "ProcessedRecipientCount",
					caption: resources.localizableStrings.ProcessedRecipientCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ReceivedInitialResponseCount: {
					uId: "ef66dda2-6f89-a219-5710-c102f8b9412e",
					name: "ReceivedInitialResponseCount",
					caption: resources.localizableStrings.ReceivedInitialResponseCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.SendingEmailProgress;
	});