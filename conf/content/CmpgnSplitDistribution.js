define("CmpgnSplitDistribution", ["terrasoft", "ext-base", "CmpgnSplitDistributionResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.CmpgnSplitDistribution", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.CmpgnSplitDistribution",
			singleton: true,
			uId: "c0a19d8c-c24c-366f-b622-3ebeee65c2a8",
			name: "CmpgnSplitDistribution",
			caption: resources.localizableStrings.CmpgnSplitDistributionCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "CampaignParticipantId",
			columns: {
				TransitionId: {
					uId: "3ea1f095-7b79-9ce0-3e31-a41df33e8c2a",
					name: "TransitionId",
					caption: resources.localizableStrings.TransitionIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CampaignParticipantId: {
					uId: "178f886d-49f4-c78c-4d84-722de4b14e80",
					name: "CampaignParticipantId",
					caption: resources.localizableStrings.CampaignParticipantIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true
				}
			}
		});
		return Terrasoft.CmpgnSplitDistribution;
	});