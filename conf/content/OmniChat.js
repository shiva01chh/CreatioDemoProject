define("OmniChat", ["terrasoft", "ext-base", "OmniChatResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.OmniChat", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.OmniChat",
			singleton: true,
			uId: "af1f685c-315b-4b44-a957-c5094417a57a",
			name: "OmniChat",
			caption: resources.localizableStrings.OmniChatCaption,
			administratedByRecords: true,
			administratedByOperations: true,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Name",
			hierarchicalColumnName: "Parent",
			columns: {
				Id: {
					uId: "ae0e45ca-c495-4fe7-a39d-3ab7278e1617",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
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
					usageType: 0,
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
					usageType: 0,
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
					usageType: 0,
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
					usageType: 0,
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
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Name: {
					uId: "67848ab7-5076-4042-8d04-d453e8594f70",
					name: "Name",
					caption: resources.localizableStrings.NameCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					size: 250
				},
				Notes: {
					uId: "8be12635-e9dd-4630-ad28-074d9672a4c3",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				Status: {
					uId: "43ef8c52-8676-4017-a487-8581d0ea9324",
					name: "Status",
					caption: resources.localizableStrings.StatusCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "OmnichannelChatStatus",
					referenceSchema: {
						name: "OmnichannelChatStatus",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				CloseDate: {
					uId: "f890ff68-8d2b-477e-b0f7-240fab4fd0ad",
					name: "CloseDate",
					caption: resources.localizableStrings.CloseDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ChatPreview: {
					uId: "d55b14b1-cb05-4579-9d83-853531befffe",
					name: "ChatPreview",
					caption: resources.localizableStrings.ChatPreviewCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Conversation: {
					uId: "af6b40ee-b2ee-41fa-b33d-5c76dce95647",
					name: "Conversation",
					caption: resources.localizableStrings.ConversationCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Contact: {
					uId: "fb75ff5f-90ad-4019-ae63-2b2cf692b178",
					name: "Contact",
					caption: resources.localizableStrings.ContactCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
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
				Channel: {
					uId: "23bfa443-4d1e-4860-b7fc-dee0383b1ea0",
					name: "Channel",
					caption: resources.localizableStrings.ChannelCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Channel",
					referenceSchema: {
						name: "Channel",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Operator: {
					uId: "fa37d391-2c0c-44b6-ba1c-3a50d64a884f",
					name: "Operator",
					caption: resources.localizableStrings.OperatorCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysAdminUnit",
					referenceSchema: {
						name: "SysAdminUnit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				UnprocessedMsgCount: {
					uId: "bb0e997b-f55c-45fd-a149-5984673e1adc",
					name: "UnprocessedMsgCount",
					caption: resources.localizableStrings.UnprocessedMsgCountCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ChatStartDate: {
					uId: "cc93e303-6f66-4cdd-983f-8d629403fd48",
					name: "ChatStartDate",
					caption: resources.localizableStrings.ChatStartDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ChatEndDate: {
					uId: "901df6c9-420f-4ec1-a174-a8954bd062c7",
					name: "ChatEndDate",
					caption: resources.localizableStrings.ChatEndDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				FirstReplyTime: {
					uId: "944e05ae-5ef0-4167-98e1-882b0b7a7eb9",
					name: "FirstReplyTime",
					caption: resources.localizableStrings.FirstReplyTimeCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				AcceptDate: {
					uId: "f2fe4a2d-10b4-4952-8606-38b15b52fd9f",
					name: "AcceptDate",
					caption: resources.localizableStrings.AcceptDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DirectedOperator: {
					uId: "d6561ed7-fb7d-4e02-ba1a-c1bd600c2b65",
					name: "DirectedOperator",
					caption: resources.localizableStrings.DirectedOperatorCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "SysAdminUnit",
					referenceSchema: {
						name: "SysAdminUnit",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ChatDuration: {
					uId: "b00e71bf-99b3-4724-bf44-f698c0c6664f",
					name: "ChatDuration",
					caption: resources.localizableStrings.ChatDurationCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				CompletionDate: {
					uId: "ef2f4850-268a-478b-8471-7694fb959a1a",
					name: "CompletionDate",
					caption: resources.localizableStrings.CompletionDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Case: {
					uId: "f0df491d-5d4d-a931-d796-8d95880c95c6",
					name: "Case",
					caption: resources.localizableStrings.CaseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Case",
					referenceSchema: {
						name: "Case",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Number"
					}
				},
				Parent: {
					uId: "48b8e671-53f7-4eae-6b3f-cca16452276c",
					name: "Parent",
					caption: resources.localizableStrings.ParentCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "OmniChat",
					referenceSchema: {
						name: "OmniChat",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				LastMessageDirection: {
					uId: "d3c3aba2-4968-2a93-a1e7-aa323e526679",
					name: "LastMessageDirection",
					caption: resources.localizableStrings.LastMessageDirectionCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Queue: {
					uId: "da57acfd-0dc2-2b58-82f8-37c6f5f9c567",
					name: "Queue",
					caption: resources.localizableStrings.QueueCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "ChatQueue",
					referenceSchema: {
						name: "ChatQueue",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Lead: {
					uId: "21174400-e09d-7cfb-7f05-9e660c07844c",
					name: "Lead",
					caption: resources.localizableStrings.LeadCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Lead",
					referenceSchema: {
						name: "Lead",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "LeadName"
					}
				}
			}
		});
		return Terrasoft.OmniChat;
	});