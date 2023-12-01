define("Opportunity", ["terrasoft", "ext-base", "OpportunityResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.Opportunity", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.Opportunity",
			singleton: true,
			uId: "ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
			name: "Opportunity",
			caption: resources.localizableStrings.OpportunityCaption,
			administratedByRecords: true,
			administratedByOperations: true,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			primaryDisplayColumnName: "Title",
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
				Title: {
					uId: "790563cf-fd14-4d5d-a5fd-b6eddb10d6d3",
					name: "Title",
					caption: resources.localizableStrings.TitleCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isRequired: true,
					size: 500
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
				Type: {
					uId: "2b2e93bb-c5ac-4478-9e31-306c5bd5ceeb",
					name: "Type",
					caption: resources.localizableStrings.TypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunityType",
					referenceSchema: {
						name: "OpportunityType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Stage: {
					uId: "797ac352-4979-4d28-906f-82feb6dbc9dc",
					name: "Stage",
					caption: resources.localizableStrings.StageCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					isLookup: true,
					referenceSchemaName: "OpportunityStage",
					referenceSchema: {
						name: "OpportunityStage",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "c2067b11-0ee0-df11-971b-001d60e938c6"
						}
					}
				},
				DueDate: {
					uId: "c8f5d6d7-aa99-4295-ade0-4ff6e840655f",
					name: "DueDate",
					caption: resources.localizableStrings.DueDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				},
				CloseReason: {
					uId: "d979bca9-13c3-463b-b279-641c0c51f9df",
					name: "CloseReason",
					caption: resources.localizableStrings.CloseReasonCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunityCloseReason",
					referenceSchema: {
						name: "OpportunityCloseReason",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Owner: {
					uId: "684553a7-a59d-46fa-af4b-fc76e9fe3694",
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
				Notes: {
					uId: "975de813-489f-495b-98ab-e56a8a527e77",
					name: "Notes",
					caption: resources.localizableStrings.NotesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Account: {
					uId: "4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7",
					name: "Account",
					caption: resources.localizableStrings.AccountCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Account",
					referenceSchema: {
						name: "Account",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Category: {
					uId: "fae41c1b-a153-43df-852a-17ab3e608c18",
					name: "Category",
					caption: resources.localizableStrings.CategoryCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunityCategory",
					referenceSchema: {
						name: "OpportunityCategory",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Mood: {
					uId: "c4eab4ef-2c91-43b5-b2a1-df5e60f6c3cd",
					name: "Mood",
					caption: resources.localizableStrings.MoodCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunityMood",
					referenceSchema: {
						name: "OpportunityMood",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "a9f89fe0-dd26-4b96-8736-471d72c428d5"
						}
					}
				},
				IsPrimary: {
					uId: "3aab3a22-ded6-41a6-98bb-4bc7ca20bb06",
					name: "IsPrimary",
					caption: resources.localizableStrings.IsPrimaryCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: true
					}
				},
				Partner: {
					uId: "75ad358c-8d9c-4bbb-83d5-2d9f60d3b7c3",
					name: "Partner",
					caption: resources.localizableStrings.PartnerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Account",
					referenceSchema: {
						name: "Account",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Budget: {
					uId: "4348809e-6f05-426c-8802-958ffe90b176",
					name: "Budget",
					caption: resources.localizableStrings.BudgetCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Probability: {
					uId: "bc62f730-7e4a-4578-953c-1cd9ac58a2b2",
					name: "Probability",
					caption: resources.localizableStrings.ProbabilityCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Amount: {
					uId: "63c0fc1f-ac41-4497-96be-c27201994072",
					name: "Amount",
					caption: resources.localizableStrings.AmountCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false,
					size: 18,
					precision: 2
				},
				Source: {
					uId: "6c76d697-8138-47fc-897c-1f3820c45893",
					name: "Source",
					caption: resources.localizableStrings.SourceCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunitySource",
					referenceSchema: {
						name: "OpportunitySource",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				ResponsibleDepartment: {
					uId: "15f0f091-e66f-42db-807b-f4c2ad6337b6",
					name: "ResponsibleDepartment",
					caption: resources.localizableStrings.ResponsibleDepartmentCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isSimpleLookup: true,
					isLookup: true,
					referenceSchemaName: "OpportunityDepartment",
					referenceSchema: {
						name: "OpportunityDepartment",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Weaknesses: {
					uId: "19429c25-e5dc-4a77-ab74-69bbec821ce4",
					name: "Weaknesses",
					caption: resources.localizableStrings.WeaknessesCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Strength: {
					uId: "9295050c-1727-416a-949d-4684e2b61e3b",
					name: "Strength",
					caption: resources.localizableStrings.StrengthCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Tactic: {
					uId: "d1cf610a-dc34-447b-b637-9970dc4f1b7e",
					name: "Tactic",
					caption: resources.localizableStrings.TacticCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				CheckDate: {
					uId: "7d2e418f-2cac-4b0c-823c-9f431027ce56",
					name: "CheckDate",
					caption: resources.localizableStrings.CheckDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ProcessId: {
					uId: "65715559-fa3f-4781-be93-5f3920b3e8f4",
					name: "ProcessId",
					caption: resources.localizableStrings.ProcessIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Winner: {
					uId: "f460aa34-e072-4804-aa46-f886e60a3852",
					name: "Winner",
					caption: resources.localizableStrings.WinnerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Account",
					referenceSchema: {
						name: "Account",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				Contact: {
					uId: "64a05bfa-350d-4dbf-bfd8-fb579a74f39e",
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
				Completeness: {
					uId: "cf5dc330-48e7-48ac-8b86-06ffb1ae0391",
					name: "Completeness",
					caption: resources.localizableStrings.CompletenessCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Description: {
					uId: "f22a9cf5-213a-427f-aed7-ef864ffff2dd",
					name: "Description",
					caption: resources.localizableStrings.DescriptionCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				LeadType: {
					uId: "6b0dc85d-37b8-41c8-809a-6e30ddaf1f32",
					name: "LeadType",
					caption: resources.localizableStrings.LeadTypeCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "LeadType",
					referenceSchema: {
						name: "LeadType",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				PredictiveProbability: {
					uId: "9ec83c9d-d3f5-4aa0-a26c-22ae9b2657e0",
					name: "PredictiveProbability",
					caption: resources.localizableStrings.PredictiveProbabilityCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 0,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false
				},
				MoodValue: {
					uId: "e07a14cb-fda3-753a-605e-0ef09c1af240",
					name: "MoodValue",
					caption: resources.localizableStrings.MoodValueCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: 45
					}
				},
				Group: {
					uId: "5699743b-e4af-80ae-5c85-b5c5d579ff40",
					name: "Group",
					caption: resources.localizableStrings.GroupCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
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
				ProductSuggestions: {
					uId: "f5062653-cb42-84b9-4a90-f98c62c1e24d",
					name: "ProductSuggestions",
					caption: resources.localizableStrings.ProductSuggestionsCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				BuyingProcess: {
					uId: "9fd4767a-12a6-6bab-7580-cb7a9b56da48",
					name: "BuyingProcess",
					caption: resources.localizableStrings.BuyingProcessCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				WhyNow: {
					uId: "19795861-c6fb-6422-5df1-300248b6c007",
					name: "WhyNow",
					caption: resources.localizableStrings.WhyNowCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				Why: {
					uId: "771088f2-cc14-d3be-386b-7ca3567ff28c",
					name: "Why",
					caption: resources.localizableStrings.WhyCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				What: {
					uId: "5ba0c129-ad9e-99b8-24a4-0cdd1cb40054",
					name: "What",
					caption: resources.localizableStrings.WhatCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				EngagementTactic: {
					uId: "3b23494a-545e-e315-0291-8662f803c238",
					name: "EngagementTactic",
					caption: resources.localizableStrings.EngagementTacticCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				WhyOurCompany: {
					uId: "4d118ec6-2265-2476-0c00-0daf529b8a9f",
					name: "WhyOurCompany",
					caption: resources.localizableStrings.WhyOurCompanyCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 500
				},
				ForecastCommit: {
					uId: "c1dc3a52-1307-a542-c3dd-80019885b826",
					name: "ForecastCommit",
					caption: resources.localizableStrings.ForecastCommitCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false
				},
				DecisionMaker: {
					uId: "8065917d-c17c-b91d-927e-3efb9c8ae041",
					name: "DecisionMaker",
					caption: resources.localizableStrings.DecisionMakerCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: true,
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
				ClosingDetails: {
					uId: "67a48a64-5b7a-6e66-af67-23b1ba41b033",
					name: "ClosingDetails",
					caption: resources.localizableStrings.ClosingDetailsCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				ByProcess: {
					uId: "9ecd00e7-8bc5-4f52-b361-477831d42559",
					name: "ByProcess",
					caption: resources.localizableStrings.ByProcessCaption,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					usageType: 0,
					isInherited: false,
					isValueCloneable: false,
					isSensitiveData: false
				}
			}
		});
		return Terrasoft.Opportunity;
	});