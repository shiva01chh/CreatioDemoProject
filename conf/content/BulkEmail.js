define("BulkEmail", ["terrasoft", "ext-base", "BulkEmailResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.BulkEmail", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.BulkEmail",
			singleton: true,
			uId: "95fbcf9c-e36d-4acd-8b5a-d657de6e30a8",
			name: "BulkEmail",
			caption: resources.localizableStrings.BulkEmailCaption,
			administratedByRecords: true,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Name",
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
					uId: "975137ab-181c-4e96-b4d9-66e55474b28d",
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
				Owner: {
					uId: "179852a9-99a4-40d7-9a0d-1b1354528eab",
					name: "Owner",
					caption: resources.localizableStrings.OwnerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
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
					uId: "ba9154c4-cbaf-44bc-a613-fc75abe5d0e4",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailType",
					referenceSchema: {
						name: "BulkEmailType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "2909d41f-2797-4c45-9f3f-9835eb88e515"
						}
					}
				},
				Status: {
					uId: "61488596-901e-457a-b02d-c2fea49f75c3",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailStatus",
					referenceSchema: {
						name: "BulkEmailStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "32848d61-3792-4b06-a183-eaf1d1769897"
						}
					}
				},
				StartDate: {
					uId: "eedcc192-9bd0-4870-b471-e2935e03e269",
					name: "StartDate",
					caption: resources.localizableStrings.StartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SenderName: {
					uId: "bb7976b3-0b0a-4623-bf51-f7d5d7127b24",
					name: "SenderName",
					caption: resources.localizableStrings.SenderNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SenderEmail: {
					uId: "a7b7ea13-8870-409d-8dec-d91dcef2770f",
					name: "SenderEmail",
					caption: resources.localizableStrings.SenderEmailCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				SendStartDate: {
					uId: "93fd7ba3-6f59-4bb6-b242-54fbb8c960a8",
					name: "SendStartDate",
					caption: resources.localizableStrings.SendStartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SendDueDate: {
					uId: "4098b376-f4a4-43b9-9c2a-83a0ed5bb111",
					name: "SendDueDate",
					caption: resources.localizableStrings.SendDueDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Clicks: {
					uId: "ea77b054-19e8-4f5a-acad-426389d56b27",
					name: "Clicks",
					caption: resources.localizableStrings.ClicksCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Opens: {
					uId: "2b38e45b-4d3e-4f8b-94e6-e2f6a2286c9b",
					name: "Opens",
					caption: resources.localizableStrings.OpensCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				SoftBounce: {
					uId: "f220825a-b9e8-439b-9379-a9abc4784ecb",
					name: "SoftBounce",
					caption: resources.localizableStrings.SoftBounceCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				HardBounce: {
					uId: "08ad2aad-2a2f-485c-a056-3575826d5856",
					name: "HardBounce",
					caption: resources.localizableStrings.HardBounceCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Unsubscribe: {
					uId: "538a2dca-73f7-4535-bc5c-80d2a1dac4d7",
					name: "Unsubscribe",
					caption: resources.localizableStrings.UnsubscribeCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Spam: {
					uId: "60c0d829-5d8b-4b3c-9941-5ea47ba88aa5",
					name: "Spam",
					caption: resources.localizableStrings.SpamCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				ClicksCount: {
					uId: "69026123-bf84-463f-b512-d0e138aaa535",
					name: "ClicksCount",
					caption: resources.localizableStrings.ClicksCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				OpensCount: {
					uId: "0b997f26-118b-422c-85c8-665334844ad5",
					name: "OpensCount",
					caption: resources.localizableStrings.OpensCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SoftBounceCount: {
					uId: "7340a01b-ae07-471d-96f0-c3e59cb5a506",
					name: "SoftBounceCount",
					caption: resources.localizableStrings.SoftBounceCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				HardBounceCount: {
					uId: "93d105bd-60a0-44bd-9d51-82e5b55c0b28",
					name: "HardBounceCount",
					caption: resources.localizableStrings.HardBounceCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				UnsubscribeCount: {
					uId: "c19c69e9-a4f5-4967-82fc-c4ae2169e56f",
					name: "UnsubscribeCount",
					caption: resources.localizableStrings.UnsubscribeCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SpamCount: {
					uId: "3ad234c8-e65c-4261-bd4f-dd5153614592",
					name: "SpamCount",
					caption: resources.localizableStrings.SpamCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				RecipientCount: {
					uId: "2c873902-d974-4c19-8ff7-b33beebe0337",
					name: "RecipientCount",
					caption: resources.localizableStrings.RecipientCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: 0
					}
				},
				LastActualizeDate: {
					uId: "da45936d-12c4-44f5-9dbf-93dccfcb27bc",
					name: "LastActualizeDate",
					caption: resources.localizableStrings.LastActualizeDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				TemplateSubject: {
					uId: "3e65fbaf-d5dd-431d-a2b9-2badabbaacf5",
					name: "TemplateSubject",
					caption: resources.localizableStrings.TemplateSubjectCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				TemplateBody: {
					uId: "9ec4de0a-6c4f-4634-b5af-df256380edb7",
					name: "TemplateBody",
					caption: resources.localizableStrings.TemplateBodyCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: true
				},
				DeliveredCount: {
					uId: "b5ee5edb-5d5b-4438-be3c-ba043ef3f561",
					name: "DeliveredCount",
					caption: resources.localizableStrings.DeliveredCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				NotDeliveredCount: {
					uId: "46e0c161-0fd6-4300-9bdd-eb4f68dcbe34",
					name: "NotDeliveredCount",
					caption: resources.localizableStrings.NotDeliveredCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				InQueueCount: {
					uId: "d224320e-5b42-4e13-afe3-27eb41d49285",
					name: "InQueueCount",
					caption: resources.localizableStrings.InQueueCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				CanceledCount: {
					uId: "4084cb33-7820-4578-b8b9-87ced0ca3b9d",
					name: "CanceledCount",
					caption: resources.localizableStrings.CanceledCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				BlankEmailCount: {
					uId: "b1896082-56f9-4cf8-aedb-25ff3dfc2727",
					name: "BlankEmailCount",
					caption: resources.localizableStrings.BlankEmailCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				IncorrectEmailCount: {
					uId: "9d65ede6-b98b-455a-821b-90cf0e7cd064",
					name: "IncorrectEmailCount",
					caption: resources.localizableStrings.IncorrectEmailCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				UnreachableEmailCount: {
					uId: "ca45c924-d210-40ce-9b87-b720a73a3040",
					name: "UnreachableEmailCount",
					caption: resources.localizableStrings.UnreachableEmailCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				DoNotUseEmailCount: {
					uId: "e2a193cf-9dd4-4246-9d53-49daeadf5892",
					name: "DoNotUseEmailCount",
					caption: resources.localizableStrings.DoNotUseEmailCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				UnsubscribedByTypeCount: {
					uId: "ad9e52d0-1f2b-442c-b960-ce42914243ca",
					name: "UnsubscribedByTypeCount",
					caption: resources.localizableStrings.UnsubscribedByTypeCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DuplicateEmailCount: {
					uId: "efa2e7d3-8633-4a52-a400-30924f08f0f4",
					name: "DuplicateEmailCount",
					caption: resources.localizableStrings.DuplicateEmailCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				RejectedCount: {
					uId: "89232498-d4f6-4b83-b20d-2572c1571f85",
					name: "RejectedCount",
					caption: resources.localizableStrings.RejectedCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				CommonErrorCount: {
					uId: "2a285982-5a92-48f1-b639-8479545c4721",
					name: "CommonErrorCount",
					caption: resources.localizableStrings.CommonErrorCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				InvalidAddresseeCount: {
					uId: "2c1e0609-ac0a-4c38-b860-8f5388f297d7",
					name: "InvalidAddresseeCount",
					caption: resources.localizableStrings.InvalidAddresseeCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				PercentWeight: {
					uId: "eae57226-68ed-4856-8246-c5ec4606529b",
					name: "PercentWeight",
					caption: resources.localizableStrings.PercentWeightCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				PercentActiveWeight: {
					uId: "c2a9de1b-9bd4-44bb-b3ac-7d4448d346d0",
					name: "PercentActiveWeight",
					caption: resources.localizableStrings.PercentActiveWeightCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				PercentInactiveWeight: {
					uId: "d785e098-20e4-438e-9a96-ac93fb86a156",
					name: "PercentInactiveWeight",
					caption: resources.localizableStrings.PercentInactiveWeightCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				SendCount: {
					uId: "2a905616-fe78-440c-b1fb-d046b98410ee",
					name: "SendCount",
					caption: resources.localizableStrings.SendCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				CommunicationLimitCount: {
					uId: "0006f192-a00c-4372-82d8-24df40e8782e",
					name: "CommunicationLimitCount",
					caption: resources.localizableStrings.CommunicationLimitCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				UtmSource: {
					uId: "b2d54128-352b-409c-8d9f-864222172044",
					name: "UtmSource",
					caption: resources.localizableStrings.UtmSourceCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmMedium: {
					uId: "545c4f53-5c13-4c18-99b3-12713feafb07",
					name: "UtmMedium",
					caption: resources.localizableStrings.UtmMediumCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmCampaign: {
					uId: "6a54fc79-6db3-495e-8752-c15f3de1371f",
					name: "UtmCampaign",
					caption: resources.localizableStrings.UtmCampaignCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmTerm: {
					uId: "d145dfd4-03eb-4bd1-ae1a-ec1046c2290c",
					name: "UtmTerm",
					caption: resources.localizableStrings.UtmTermCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UtmContent: {
					uId: "c0ecb652-be4e-4e14-91a1-dc17c4eabe25",
					name: "UtmContent",
					caption: resources.localizableStrings.UtmContentCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Domains: {
					uId: "c38d1340-1f04-4106-893b-c123256082ed",
					name: "Domains",
					caption: resources.localizableStrings.DomainsCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				UseUtm: {
					uId: "71c597c9-94dd-4efe-b2d9-d6989621653a",
					name: "UseUtm",
					caption: resources.localizableStrings.UseUtmCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				StatisticDate: {
					uId: "271d3ef0-6520-479c-8067-5b212d91e534",
					name: "StatisticDate",
					caption: resources.localizableStrings.StatisticDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ResponseProcessingCompleted: {
					uId: "5d100c2f-01b7-4216-9bf7-6bf20af49d30",
					name: "ResponseProcessingCompleted",
					caption: resources.localizableStrings.ResponseProcessingCompletedCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Category: {
					uId: "e38eb3e2-20d5-4b11-aa34-c2fe23348070",
					name: "Category",
					caption: resources.localizableStrings.CategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailCategory",
					referenceSchema: {
						name: "BulkEmailCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "8cec06ed-2643-46f7-ab00-352acbc3bd8a"
						}
					}
				},
				LaunchOption: {
					uId: "c5bf86d5-4624-4470-b6b1-0d3d8755dba1",
					name: "LaunchOption",
					caption: resources.localizableStrings.LaunchOptionCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailLaunchOption",
					referenceSchema: {
						name: "BulkEmailLaunchOption",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "6f72c1b4-810b-4ef9-bc20-879372c8e2c2"
						}
					}
				},
				TemplateConfig: {
					uId: "167e049c-00ae-41c5-bfc2-856eae2880c9",
					name: "TemplateConfig",
					caption: resources.localizableStrings.TemplateConfigCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DeliveryError: {
					uId: "7030ab07-36cf-4227-8bce-55f97a1e5120",
					name: "DeliveryError",
					caption: resources.localizableStrings.DeliveryErrorCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: 0
					}
				},
				IsSystemEmail: {
					uId: "467b5d60-a7b3-4cf2-b607-0b77bc504ff9",
					name: "IsSystemEmail",
					caption: resources.localizableStrings.IsSystemEmailCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				TemplateNotFoundCount: {
					uId: "f986de1b-eccd-4409-a145-a7ef9d4116c3",
					name: "TemplateNotFoundCount",
					caption: resources.localizableStrings.TemplateNotFoundCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				SendersDomainNotVerifiedCount: {
					uId: "1f2d242f-785a-4c0f-9942-6caac23d668a",
					name: "SendersDomainNotVerifiedCount",
					caption: resources.localizableStrings.SendersDomainNotVerifiedCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				SendersNameNotValidCount: {
					uId: "2d960dec-c57c-4412-8667-022cbacf5373",
					name: "SendersNameNotValidCount",
					caption: resources.localizableStrings.SendersNameNotValidCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AudienceSchema: {
					uId: "2f9ae67f-dd2a-457c-80e5-5fe0882a88e8",
					name: "AudienceSchema",
					caption: resources.localizableStrings.AudienceSchemaCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailAudienceSchema",
					referenceSchema: {
						name: "BulkEmailAudienceSchema",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "DisplayName"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "2db96695-3d62-40e4-9f31-2f1fff23eefb"
						}
					}
				},
				IsAudienceInited: {
					uId: "9734ab99-efb5-46bc-b625-a52b9951bfd9",
					name: "IsAudienceInited",
					caption: resources.localizableStrings.IsAudienceInitedCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: false
					}
				},
				ThrottlingMode: {
					uId: "e19995c0-0799-7e7b-ba0a-1befde6c131d",
					name: "ThrottlingMode",
					caption: resources.localizableStrings.ThrottlingModeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailThrottlingMode",
					referenceSchema: {
						name: "BulkEmailThrottlingMode",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "8bfdb047-5833-4498-8365-5b83f3f1fd63"
						}
					}
				},
				Priority: {
					uId: "9a8c9082-ccfd-394e-df50-de23c790054a",
					name: "Priority",
					caption: resources.localizableStrings.PriorityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "BulkEmailPriority",
					referenceSchema: {
						name: "BulkEmailPriority",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "7f472a85-9865-4a56-96d2-f6decb26e0ca"
						}
					}
				},
				ExpirationDate: {
					uId: "0a35dfc6-dcb9-1fd0-44c9-f90622cf4b40",
					name: "ExpirationDate",
					caption: resources.localizableStrings.ExpirationDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				BusinessTimeEnd: {
					uId: "b8421a17-59a8-5353-5ec0-e8c67221a5f2",
					name: "BusinessTimeEnd",
					caption: resources.localizableStrings.BusinessTimeEndCaption,
					dataValueType: Terrasoft.DataValueType.TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: new Date("2021-01-29T23:59:00.000")
					}
				},
				BusinessTimeStart: {
					uId: "92815ba2-919c-b6e1-b095-408aab9fb28e",
					name: "BusinessTimeStart",
					caption: resources.localizableStrings.BusinessTimeStartCaption,
					dataValueType: Terrasoft.DataValueType.TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: new Date("2021-01-29T00:00:00.000")
					}
				},
				DeliveryScheduleDays: {
					uId: "91e53dbc-866a-7934-ff55-9e5558359b90",
					name: "DeliveryScheduleDays",
					caption: resources.localizableStrings.DeliveryScheduleDaysCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 50
				},
				DeliverySchedule: {
					uId: "54749ce9-d65e-229d-8739-65f7ea97fdf1",
					name: "DeliverySchedule",
					caption: resources.localizableStrings.DeliveryScheduleCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "EmailDeliverySchedule",
					referenceSchema: {
						name: "EmailDeliverySchedule",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "71b47d54-7ef9-4443-b9e6-faae213eea33"
						}
					}
				},
				ThrottlingQueue: {
					uId: "253496e7-cad2-1027-1cb0-fa4dd7181bcc",
					name: "ThrottlingQueue",
					caption: resources.localizableStrings.ThrottlingQueueCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "EmailThrottlingQueue",
					referenceSchema: {
						name: "EmailThrottlingQueue",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "44239c7e-f1c4-41df-a6ee-7e7205449c8b"
						}
					}
				},
				ExpiredCount: {
					uId: "416be0a3-2703-e665-d832-7170d3e909b1",
					name: "ExpiredCount",
					caption: resources.localizableStrings.ExpiredCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				TimeZone: {
					uId: "c84180d9-e4a3-ce6d-8920-093e20f33445",
					name: "TimeZone",
					caption: resources.localizableStrings.TimeZoneCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "TimeZone",
					referenceSchema: {
						name: "TimeZone",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "8bc71d34-55d8-df11-9b2a-001d60e938c6"
						}
					}
				},
				StoppedSummaryCount: {
					uId: "6fb691c3-9a6c-3859-b9c1-18a9dca54e82",
					name: "StoppedSummaryCount",
					caption: resources.localizableStrings.StoppedSummaryCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				StoppedManuallyCount: {
					uId: "3dfd79d6-54ec-3be5-a6c8-aaea068daca2",
					name: "StoppedManuallyCount",
					caption: resources.localizableStrings.StoppedManuallyCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				StoppedInProviderCount: {
					uId: "6b07e6b6-00d4-726e-9f72-870285fe5597",
					name: "StoppedInProviderCount",
					caption: resources.localizableStrings.StoppedInProviderCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ExpiredSummaryCount: {
					uId: "d9d80b39-8f01-0cd9-cd13-5e1397a56765",
					name: "ExpiredSummaryCount",
					caption: resources.localizableStrings.ExpiredSummaryCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				ExpiredInProviderCount: {
					uId: "5177a1fb-d654-4a2b-8b2c-75d5f1010b6b",
					name: "ExpiredInProviderCount",
					caption: resources.localizableStrings.ExpiredInProviderCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				DelayBetweenEmail: {
					uId: "443ae6ca-2069-ac9e-9a32-1c44118a64f5",
					name: "DelayBetweenEmail",
					caption: resources.localizableStrings.DelayBetweenEmailCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DailyLimit: {
					uId: "8019ee41-ff67-82fa-a872-e704b374d38d",
					name: "DailyLimit",
					caption: resources.localizableStrings.DailyLimitCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: 1
					}
				},
				ProviderName: {
					uId: "2e0f5a7b-6245-49eb-8cfc-a8c27a93ece6",
					name: "ProviderName",
					caption: resources.localizableStrings.ProviderNameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 50
				},
				Notes: {
					uId: "ea0bf113-a0a3-4b5c-b3b7-c82f8f10c610",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Campaign: {
					uId: "6f3b2c62-03a2-4a6a-802b-5c3445e6b534",
					name: "Campaign",
					caption: resources.localizableStrings.CampaignCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Campaign",
					referenceSchema: {
						name: "Campaign",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SplitTest: {
					uId: "c232104d-92cb-4f42-a880-1400a1ddc4c4",
					name: "SplitTest",
					caption: resources.localizableStrings.SplitTestCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "BulkEmailSplit",
					referenceSchema: {
						name: "BulkEmailSplit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SegmentsStatus: {
					uId: "d15639a2-9a71-b629-a2a7-c4559f716a1c",
					name: "SegmentsStatus",
					caption: resources.localizableStrings.SegmentsStatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SegmentStatus",
					referenceSchema: {
						name: "SegmentStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "fa360d2c-1658-49ad-9152-22479fdc0c12"
						}
					}
				}
			}
		});
		return Terrasoft.BulkEmail;
	});