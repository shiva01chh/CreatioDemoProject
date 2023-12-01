Terrasoft.configuration.Structures["MobileApplicationManifestDefaultWorkplace"] = {innerHierarchyStack: ["MobileApplicationManifestDefaultWorkplaceCrtMobile7x", "MobileApplicationManifestDefaultWorkplaceCrtCustomer360Mobile", "MobileApplicationManifestDefaultWorkplaceESN", "MobileApplicationManifestDefaultWorkplaceMobile", "MobileApplicationManifestDefaultWorkplaceInvoiceMobile", "MobileApplicationManifestDefaultWorkplaceLead", "MobileApplicationManifestDefaultWorkplaceOpportunity", "MobileApplicationManifestDefaultWorkplaceCoreLeadOpportunity", "MobileApplicationManifestDefaultWorkplaceSLMITILService", "MobileApplicationManifestDefaultWorkplaceCaseMobile", "MobileApplicationManifestDefaultWorkplaceServiceEnterpriseMobile", "MobileApplicationManifestDefaultWorkplace"]};
define('MobileApplicationManifestDefaultWorkplaceCrtCustomer360MobileStructure', ['MobileApplicationManifestDefaultWorkplaceCrtCustomer360MobileResources'], function(resources) {return {schemaUId:'4e3a5743-4bef-460d-9496-52f6bd168b19',schemaCaption: "MobileApplicationManifestDefaultWorkplace", parentSchemaName: "", packageName: "MarketingCampaignMobile", schemaName:'MobileApplicationManifestDefaultWorkplaceCrtCustomer360Mobile',parentSchemaUId:'2a46e6b2-9ff1-4b56-9e6b-fe3cb1afc109',extendParent:true,type:Terrasoft.SchemaType.NONE,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schemaDifferences:function(){

}};});






define('MobileApplicationManifestDefaultWorkplaceCrtMobile7xResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{}
define('MobileApplicationManifestDefaultWorkplaceCrtCustomer360MobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"SyncOptions": {
		"SysSettingsImportConfig": [
			"DefaultMessageLanguage"
		],
		"ModelDataImportConfig": [
			{
				"Name": "SysImage",
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"items": {
						"ExistContactPhoto": {
							"filterType": 5,
							"comparisonType": 15,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"subFilters": {
								"items": {},
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "Contact",
								"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
							}
						}
					}
				},
				"RequiredDataFilter": {
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"logicalOperation": 0,
					"items": {
						"CurrentContact": {
							"filterType": 1,
							"comparisonType": 3,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							}
						}
					}
				},
				"SyncColumns": [
					"Name",
					"HasRef",
					{
						"Name": "PreviewData",
						"UseRecordIdAsFileName": true,
						"ImportBinaryData": true
					}
				]
			},
			"FileType",
			{
				"Name": "Contact",
				"SyncColumns": [
					"Name",
					"JobTitle",
					"MobilePhone",
					"Owner",
					"Dear",
					"SalutationType",
					"Gender",
					"Account",
					"Type",
					"Email",
					"Language",
					"Job",
					"Address"
				]
			},
			{
				"Name": "ContactSalutationType",
				"SyncColumns": []
			},
			{
				"Name": "Gender",
				"SyncColumns": []
			},
			{
				"Name": "Account",
				"SyncColumns": [
					"Name",
					"Owner",
					"Ownership",
					"PrimaryContact",
					"Industry",
					"Phone",
					"Web",
					"AccountCategory",
					"EmployeesNumber",
					"AnnualRevenue",
					"AlternativeName"
				]
			},
			{
				"Name": "ContactType",
				"SyncColumns": []
			},
			{
				"Name": "SysLanguage",
				"SyncColumns": []
			},
			{
				"Name": "ContactCareer",
				"SyncColumns": [
					"Contact",
					"Account",
					"Department",
					"Job",
					"Primary",
					"StartDate"
				]
			},
			{
				"Name": "Department",
				"SyncColumns": []
			},
			{
				"Name": "Job",
				"SyncColumns": []
			},
			{
				"Name": "AccountOwnership",
				"SyncColumns": []
			},
			{
				"Name": "AccountIndustry",
				"SyncColumns": []
			},
			{
				"Name": "AccountCategory",
				"SyncColumns": []
			},
			{
				"Name": "AccountEmployeesNumber",
				"SyncColumns": []
			},
			{
				"Name": "AccountAnnualRevenue",
				"SyncColumns": []
			},
			{
				"Name": "AccountAddress",
				"SyncColumns": [
					"AddressType",
					"Country",
					"Region",
					"City",
					"Address",
					"Zip",
					"Account"
				]
			},
			{
				"Name": "AddressType",
				"SyncColumns": []
			},
			{
				"Name": "Country",
				"SyncColumns": []
			},
			{
				"Name": "Region",
				"SyncColumns": []
			},
			{
				"Name": "City",
				"SyncColumns": []
			}
		]
	},
	"Features": {
		"UseMobileCustomer360": {
			"Modules": {
				"Contact": {
					"screens": {
						"start": {
							"schemaName": "MobileFUIContactGridPageSettingsDefaultWorkplace"
						},
						"edit": {
							"schemaName": "MobileFUIContactRecordPageSettingsDefaultWorkplace"
						}
					},
					"Hidden": false
				},
				"Account": {
					"screens": {
						"start": {
							"schemaName": "MobileFUIAccountGridPageSettingsDefaultWorkplace"
						},
						"edit": {
							"schemaName": "MobileFUIAccountRecordPageSettingsDefaultWorkplace"
						}
					},
					"Hidden": false
				}
			},
			"Models": {
				"Account": {
					"RequiredModels": [
						"Account",
						"Contact",
						"AccountFile",
						"AccountAddress",
						"AddressType",
						"Country",
						"Region",
						"City",
						"AccountOwnership",
						"AccountIndustry",
						"AccountCategory",
						"AccountEmployeesNumber",
						"AccountAnnualRevenue",
						"Job",
						"SysLanguage"
					],
					"PagesExtensions": [
						"MobileFUIAccountRecordPageSettingsDefaultWorkplace",
						"MobileFUIAccountGridPageSettingsDefaultWorkplace"
					]
				},
				"Contact": {
					"RequiredModels": [
						"Contact",
						"ContactFile",
						"ContactSalutationType",
						"Gender",
						"Account",
						"ContactType",
						"SysLanguage",
						"ContactCareer",
						"Department",
						"Job",
						"ContactAddress",
						"AddressType",
						"Country",
						"Region",
						"City"
					],
					"PagesExtensions": [
						"MobileFUIContactRecordPageSettingsDefaultWorkplace",
						"MobileFUIContactGridPageSettingsDefaultWorkplace"
					]
				}
			},
			"SyncOptions": {
				"SysLookupsImportConfig": [
					"Communication",
					"ComTypebyCommunication"
				],
				"ModelDataImportConfig": [
					{
						"Name": "Communication",
						"SyncColumns": [
							"Name",
							"Code",
							{
								"Name": "ImageLink",
								"ImportBinaryData": true
							}
						]
					},
					{
						"Name": "ComTypebyCommunication",
						"SyncColumns": [
							"Communication",
							"CommunicationType"
						]
					},
					{
						"Name": "CommunicationType",
						"SyncColumns": [
							"Name",
							"UseforContacts",
							"UseforAccounts",
							"DisplayFormat",
							{
								"Name": "ImageLink",
								"ImportBinaryData": true
							}
						]
					}
				]
			}
		}
	},
	"Modules": {},
	"Models": {},
	"ModuleGroups": {
		"main": {}
	},
	"UseUTC": true
}
define('MobileApplicationManifestDefaultWorkplaceESNResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"Modules": {
		"SocialMessage": {
			"Position": 4,
			"Hidden": false
		}
	}
}

define('MobileApplicationManifestDefaultWorkplaceMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"Modules": {
		"Contact": {
			"Hidden": false
		},
		"Account": {
			"Hidden": false
		},
		"Activity": {
			"Hidden": false,
			"syncRules": ["ActivityModule"]
		},
		"SysDashboard": {
			"Hidden": false
		},
		"Approval": {
			"Hidden": false
		}
	},
	"CustomSchemas": [
		"MobileActivityActionsUtilities",
		"MobileActivityCacheManager",
		"MobileSysAdminUnitCacheManager"
	],
	"SyncOptions": {
		"SyncRules": {
			"ActivityModule": {
				"importOptions": {
					"adapterType": "Entity",
					"entityName": "Activity",
					"columns": [
						"Title",
						"StartDate",
						"DueDate",
						"Status",
						"Result",
						"DetailedResult",
						"ActivityCategory",
						"Priority",
						"Owner",
						"Account",
						"Contact",
						"ShowInScheduler",
						"Author",
						"Type",
						"AllowedResult",
						"ProcessElementId"
					],
					"filters": {
						"logicalOperation": 0,
						"filterType": 6,
						"rootSchemaName": "Activity",
						"items": {
							"ActivityParticipant": {
								"filterType": 5,
								"comparisonType": 15,
								"subFilters": {
									"logicalOperation": 0,
									"filterType": 6,
									"rootSchemaName": "ActivityParticipant",
									"items": {
										"detailedFilter": {
											"filterType": 1,
											"rightExpression": {
												"expressionType": 1,
												"functionType": 1,
												"macrosType": 2
											},
											"leftExpression": {
												"expressionType": 0,
												"columnPath": "Participant"
											},
											"comparisonType": 3
										}
									},
									"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
								},
								"leftExpression": {
									"expressionType": 0,
									"columnPath": "[ActivityParticipant:Activity].Id"
								}
							},
							"StartDateFilter": {
								"filterType": 1,
								"rightExpression": {
									"expressionType": 1,
									"functionType": 1,
									"functionArgument": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 4,
											"value": 7
										}
									},
									"macrosType": 25
								},
								"leftExpression": {
									"expressionType": 0,
									"columnPath": "StartDate"
								},
								"comparisonType": 8
							},
							"DueDateFilter": {
								"filterType": 1,
								"rightExpression": {
									"expressionType": 1,
									"functionType": 1,
									"functionArgument": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 4,
											"value": 7
										}
									},
									"macrosType": 24
								},
								"leftExpression": {
									"expressionType": 0,
									"columnPath": "DueDate"
								},
								"comparisonType": 6
							},
							"TypeFilter": {
								"filterType": 1,
								"rightExpression": {
									"expressionType": 2,
									"parameter": {"dataValueType": 10, "value": "e2831dec-cfc0-df11-b00f-001d60e938c6"}
								},
								"leftExpression": {"expressionType": 0, "columnPath": "Type"},
								"comparisonType": 4
							}
						}
					}
				},
				"related": [{
					"ruleName": "ActivityModule_Particapants"
				}]
			},
			"ActivityModule_Particapants": {
				"importOptions": {
					"adapterType": "Entity",
					"entityName": "ActivityParticipant",
					"columns": [
						"Activity",
						"Participant",
						"Participant.Photo"
					],
					"filters": {
						"logicalOperation": 0,
						"filterType": 6,
						"rootSchemaName": "ActivityParticipant",
						"items": {
							"ActivityFilter": {
								"filterType": 5,
								"comparisonType": 15,
								"leftExpression": {
									"expressionType": 0,
									"columnPath": "Activity.[ActivityParticipant:Activity].Id"
								},
								"subFilters": {
									"logicalOperation": 0,
									"filterType": 6,
									"rootSchemaName": "ActivityParticipant",
									"items": {
										"ParticipantFilter": {
											"filterType": 1,
											"comparisonType": 3,
											"leftExpression": {
												"expressionType": 0,
												"columnPath": "Participant"
											},
											"rightExpression": {
												"expressionType": 1,
												"functionType": 1,
												"macrosType": 2
											}
										},
										"StartDateFilter": {
											"filterType": 1,
											"rightExpression": {
												"expressionType": 1,
												"functionType": 1,
												"functionArgument": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 4,
														"value": 7
													}
												},
												"macrosType": 25
											},
											"leftExpression": {
												"expressionType": 0,
												"columnPath": "Activity.StartDate"
											},
											"comparisonType": 8
										},
										"DueDateFilter": {
											"filterType": 1,
											"rightExpression": {
												"expressionType": 1,
												"functionType": 1,
												"functionArgument": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 4,
														"value": 7
													}
												},
												"macrosType": 24
											},
											"leftExpression": {
												"expressionType": 0,
												"columnPath": "Activity.DueDate"
											},
											"comparisonType": 6
										},
										"TypeFilter": {
											"filterType": 1,
											"rightExpression": {
												"expressionType": 2,
												"parameter": {"dataValueType": 10, "value": "e2831dec-cfc0-df11-b00f-001d60e938c6"}
											},
											"leftExpression": {"expressionType": 0, "columnPath": "Activity.Type"},
											"comparisonType": 4
										},
										"ShowInSchedulerFilter": {
											"filterType": 1,
											"rightExpression": {"expressionType": 2, "parameter": {"dataValueType": 12, "value": true}},
											"leftExpression": {"expressionType": 0, "columnPath": "Activity.ShowInScheduler"},
											"comparisonType": 3
										}
									},
									"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
								}
							}
						}
					}
				}
			}
		},
		"ModelDataImportConfig": [
			{
				"Name": "Activity",
				"SyncFilter": {
					"property": "Participant",
					"modelName": "ActivityParticipant",
					"assocProperty": "Activity",
					"operation": "Terrasoft.FilterOperations.Any",
					"valueIsMacros": true,
					"value": "Terrasoft.ValueMacros.CurrentUserContact"
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "Activity",
					"items": {
						"ActivityParticipant": {
							"filterType": 5,
							"comparisonType": 15,
							"subFilters": {
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "ActivityParticipant",
								"items": {
									"detailedFilter": {
										"filterType": 1,
										"rightExpression": {
											"expressionType": 1,
											"functionType": 1,
											"macrosType": 2
										},
										"leftExpression": {
											"expressionType": 0,
											"columnPath": "Participant"
										},
										"comparisonType": 3
									}
								},
								"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[ActivityParticipant:Activity].Id"
							}
						}
					}
				},
				"ExpandLookups": true,
				"SyncColumns": [
					"Title",
					"StartDate",
					"DueDate",
					"Status",
					"Result",
					"DetailedResult",
					"ActivityCategory",
					"Priority",
					"Owner",
					"Account",
					"Contact",
					"ShowInScheduler",
					"Author",
					"Type",
					"AllowedResult",
					"ProcessElementId"
				]
			},
			{
				"Name": "ActivityParticipant",
				"SyncByParentObjectWithRights": "Activity",
				"HistoricalColumns": ["Activity.ModifiedOn"],
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "ActivityParticipant",
					"items": {
						"ActivityFilter": {
							"filterType": 5,
							"comparisonType": 15,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Activity.[ActivityParticipant:Activity].Id"
							},
							"subFilters": {
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "ActivityParticipant",
								"items": {
									"ParticipantFilter": {
										"filterType": 1,
										"comparisonType": 3,
										"leftExpression": {
											"expressionType": 0,
											"columnPath": "Participant"
										},
										"rightExpression": {
											"expressionType": 1,
											"functionType": 1,
											"macrosType": 2
										}
									}
								},
								"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
							}
						}
					}
				},
				"ExpandLookups": ["Participant"],
				"SyncColumns": [
					"Activity",
					"Participant",
					"Participant.Photo"
				]
			},
			{
				"Name": "ActivityCategoryResultEntry",
				"SyncColumns": [
					"ActivityResult",
					"ActivityCategory"
				]
			},
			{
				"Name": "ActivityCorrespondence",
				"SyncColumns": [
					"Activity",
					"IsDeleted",
					"SourceActivityId",
					"SourceAccount",
					"CreatedInBPMonline"
				]
			},
			{
				"Name": "Contact",
				"ExpandLookups": true,
				"RequiredDataFilter": {
					"filterType": 6,
					"rootSchemaName": "Contact",
					"logicalOperation": 0,
					"items": {
						"CurrentContact": {
							"filterType": 1,
							"comparisonType": 3,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Id"
							},
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							}
						}
					}
				},
				"SyncColumns": [
					"Name",
					"Account",
					"Department",
					"JobTitle",
					"Photo",
					"Job"
				]
			},
			{
				"Name": "ContactAddress",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"AddressType",
					"Country",
					"Region",
					"City",
					"Address",
					"Zip",
					"Contact",
					"Primary"
				]
			},
			{
				"Name": "ContactAnniversary",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"Date",
					"AnniversaryType",
					"Contact"
				]
			},
			{
				"Name": "ContactCommunication",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"Number",
					"CommunicationType",
					"Contact",
					"SearchNumber"
				]
			},
			{
				"Name": "Account",
				"ExpandLookups": true,
				"SyncColumns": [
					"Name",
					"PrimaryContact",
					"Industry",
					"GPSN",
					"GPSE",
					"Address",
					"Type",
					"AccountCategory"
				]
			},
			{
				"Name": "AccountAddress",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"AddressType",
					"Country",
					"Region",
					"City",
					"Address",
					"Zip",
					"Account",
					"Primary"
				]
			},
			{
				"Name": "AccountAnniversary",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"Date",
					"AnniversaryType",
					"Account"
				]
			},
			{
				"Name": "AccountCommunication",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"Number",
					"CommunicationType",
					"Account",
					"SearchNumber"
				]
			},
			{
				"Name": "SysImage",
				"SyncFilter": {
					"property": "HasRef",
					"value": true
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"items": {
						"ExistContactPhoto": {
							"filterType": 5,
							"comparisonType": 15,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"subFilters": {
								"items": {},
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "Contact",
								"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
							}
						}
					}
				},
				"RequiredDataFilter": {
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"logicalOperation": 0,
					"items": {
						"CurrentContact": {
							"filterType": 1,
							"comparisonType": 3,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							}
						}
					}
				},
				"SyncColumns": [
					"Name",
					"HasRef",
					{
						"Name": "PreviewData",
						"UseRecordIdAsFileName": true,
						"ImportBinaryData": true
					}
				]
			},
			"FileType",
			{
				"Name": "Department",
				"SyncColumns": []
			},
			{
				"Name": "ActivityPriority",
				"SyncColumns": []
			},
			{
				"Name": "ActivityType",
				"SyncColumns": []
			},
			{
				"Name": "ActivityCategory",
				"SyncColumns": [
					"ActivityType"
				]
			},
			{
				"Name": "ActivityStatus",
				"SyncColumns": [
					"Finish"
				]
			},
			{
				"Name": "CommunicationType",
				"SyncColumns": [
					"UseforContacts",
					"UseforAccounts"
				]
			},
			{
				"Name": "AddressType",
				"SyncColumns": [
					"ForAccount",
					"ForContact"
				]
			},
			{
				"Name": "Country",
				"SyncColumns": []
			},
			{
				"Name": "Region",
				"SyncColumns": [
					"Country"
				]
			},
			{
				"Name": "City",
				"SyncColumns": [
					"Country",
					"Region"
				]
			},
			{
				"Name": "AnniversaryType",
				"SyncColumns": []
			},
			{
				"Name": "AccountIndustry",
				"SyncColumns": []
			},
			{
				"Name": "ActivityResult",
				"SyncColumns": [
					"Category"
				]
			},
			{
				"Name": "ActivityParticipantRole",
				"SyncColumns": [
					"Code"
				]
			},
			{
				"Name": "KnowledgeBase",
				"SyncColumns": [
					"Code",
					"Type"
				]
			},
			{
				"Name": "KnowledgeBaseType",
				"SyncColumns": [
					"Description"
				]
			},
			{
				"Name": "KnowledgeBaseFile",
				"SyncColumns": [
					"Notes",
					{
						"Name": "Data",
						"UseRecordIdAsFileName": false,
						"ImportBinaryData": true
					},
					"Type",
					"KnowledgeBase",
					"Name",
					"Size",
					"CreatedOn",
					"CreatedBy"
				]
			},
			{
				"Name": "Job",
				"SyncColumns": []
			},
			{
				"Name": "AccountType",
				"SyncColumns": []
			},
			{
				"Name": "AccountCategory",
				"SyncColumns": []
			}
		]
	},
	"Models": {
		"Activity": {
			"Grid": "MobileActivityGridPage",
			"Preview": "MobileActivityPreviewPage",
			"Edit": "MobileActivityEditPage",
			"RequireLookupColumnsModels": true,
			"RequiredModels": [
				"Activity",
				"Account",
				"ActivityCategory",
				"ActivityCategoryResultEntry",
				"ActivityPriority",
				"ActivityParticipant",
				"ActivityParticipantRole",
				"ParticipantResponse",
				"ActivityResult",
				"ActivityStatus",
				"ActivityType",
				"Contact",
				"SysImage",
				"SysAdminUnit",
				"ActivityCorrespondence",
				"FileType",
				"EmailSendStatus",
				"EmailType",
				"KnowledgeBase",
				"KnowledgeBaseType",
				"KnowledgeBaseFile",
				"CallDirection"
			],
			"ModelExtensions": [
				"MobileActivityModelConfig"
			],
			"PagesExtensions": [
				"MobileActivityRecordPageSettingsDefaultWorkplace",
				"MobileActivityGridPageSettingsDefaultWorkplace",
				"MobileActivityActionsSettingsDefaultWorkplace",
				"MobileActivityModuleConfig",
				"MobileActivityImportHelper",
				"MobileActivityGridPageDataV2",
				"MobileActivityGridPageViewV2",
				"MobileActivityGridPageControllerV2"
			]
		},
		"Contact": {
			"Preview": "MobileContactPreviewPage",
			"RequiredModels": [
				"Account",
				"Contact",
				"ContactCommunication",
				"CommunicationType",
				"Department",
				"ContactAddress",
				"AddressType",
				"Country",
				"Region",
				"City",
				"ContactAnniversary",
				"AnniversaryType",
				"Activity",
				"SysImage",
				"FileType",
				"ActivityPriority",
				"ActivityType",
				"ActivityCategory",
				"ActivityStatus",
				"Job"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileContactRecordPageSettingsDefaultWorkplace",
				"MobileContactGridPageSettingsDefaultWorkplace",
				"MobileContactActionsSettingsDefaultWorkplace",
				"MobileContactModuleConfig"
			]
		},
		"Account": {
			"Preview": "MobileAccountPreviewPage",
			"RequiredModels": [
				"Account",
				"Contact",
				"AccountIndustry",
				"Activity",
				"AccountCommunication",
				"CommunicationType",
				"AccountAddress",
				"AccountAnniversary",
				"ActivityResult",
				"ActivityCategory",
				"ActivityPriority",
				"ActivityType",
				"ActivityStatus",
				"ActivityCategoryResultEntry",
				"AddressType",
				"AnniversaryType",
				"City",
				"Country",
				"Region",
				"SysImage",
				"FileType",
				"AccountType",
				"AccountCategory"
			],
			"ModelExtensions": [
				"MobileAccountModelConfig"
			],
			"PagesExtensions": [
				"MobileAccountRecordPageSettingsDefaultWorkplace",
				"MobileAccountGridPageSettingsDefaultWorkplace",
				"MobileAccountActionsSettingsDefaultWorkplace",
				"MobileAccountModuleConfig"
			]
		},
		"SysDashboard": {
			"CacheConfig": {
				"Disable": true
			},
			"RequiredModels": [
				"SysDashboard",
				"SysModule"
			]
		},
		"ContactAddress": {
			"ModelExtensions": [
				"MobileContactAddressModelConfig"
			]
		},
		"AccountAddress": {
			"ModelExtensions": [
				"MobileAccountAddressModelConfig"
			]
		},
		"ContactCommunication": {
			"ModelExtensions": [
				"MobileContactCommunicationModelConfig"
			]
		},
		"ContactAnniversary": {
			"ModelExtensions": [
				"MobileContactAnniversaryModelConfig"
			]
		},
		"AccountCommunication": {
			"ModelExtensions": [
				"MobileAccountCommunicationModelConfig"
			]
		},
		"AccountAnniversary": {
			"ModelExtensions": [
				"MobileAccountAnniversaryModelConfig"
			]
		},
		"ActivityParticipant": {
			"Grid": "MobileActivityParticipantGridPage",
			"ModelExtensions": [
				"MobileActivityParticipantModelConfig"
			],
			"PagesExtensions": [
				"MobileActivityParticipantGridPageView",
				"MobileActivityParticipantGridPageController",
				"MobileActivityParticipantModuleConfig"
			]
		},
		"KnowledgeBase": {
			"RequiredModels": [
				"KnowledgeBase",
				"KnowledgeBaseType",
				"FileType",
				"KnowledgeBaseFile"
			],
			"PagesExtensions": [
				"MobileKnowledgeBaseModuleConfig"
			]
		},
		"KnowledgeBaseType": {
			"RequiredModels": [
				"KnowledgeBaseType"
			]
		},
		"KnowledgeBaseFile": {
			"RequiredModels": [
				"KnowledgeBaseFile",
				"KnowledgeBaseType"
			],
			"ModelExtensions": [
				"MobileKnowledgeBaseFileModelConfig"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceInvoiceMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"SyncOptions": {
		"SysLookupsImportConfig": [
			"InvoicePaymentStatus",
			"Currency"
		],
		"ModelDataImportConfig": [
			{
				"Name": "Invoice",
				"SyncColumns": [
					"Number",
					"Account",
					"Owner",
					"PaymentStatus",
					"PrimaryAmount",
					"Currency",
					"Amount",
					"DueDate",
					"PaymentAmount"
				]
			},
			{
				"Name": "Account",
				"SyncColumns": []
			},
			{
				"Name": "Contact",
				"SyncColumns": []
			},
			{
				"Name": "InvoicePaymentStatus",
				"SyncColumns": []
			},
			{
				"Name": "Currency",
				"SyncColumns": []
			},
			{
				"Name": "SocialMessage",
				"SyncColumns": [
					"EntityId"
				]
			},
			{
				"Name": "InvoiceVisa",
				"SyncColumns": [
					"Objective",
					"VisaOwner",
					"Status",
					"IsCanceled",
					"Invoice"
				],
				"QueryFilter": {
					"filterType": 6,
					"isEnabled": true,
					"logicalOperation": 0,
					"items": {
						"CurrentUser": {
							"comparisonType": 15,
							"filterType": 5,
							"isEnabled": true,
							"leftExpression": {
								"columnPath": "[SysAdminUnitInRole:SysAdminUnitRoleId:VisaOwner].Id",
								"expressionType": 0
							},
							"subFilters": {
								"filterType": 6,
								"isEnabled": true,
								"items": {
									"detailedFilter": {
										"comparisonType": 3,
										"filterType": 1,
										"isEnabled": true,
										"leftExpression": {
											"columnPath": "SysAdminUnit",
											"expressionType": 0
										},
										"rightExpression": {
											"expressionType": 1,
											"functionType": 1,
											"macrosType": 1
										},
										"trimDateTimeParameterToDate": false
									}
								},
								"logicalOperation": 0,
								"rootSchemaName": "SysAdminUnitInRole",
								"key": "069e89d5-96d6-4268-a4ae-93fd7f97f3e4"
							},
							"trimDateTimeParameterToDate": false
						},
						"StatusNotFinal": {
							"filterType": 6,
							"isEnabled": true,
							"items": {
								"item0": {
									"comparisonType": 1,
									"filterType": 2,
									"isEnabled": true,
									"isNull": true,
									"leftExpression": {
										"columnPath": "Status",
										"expressionType": 0
									},
									"trimDateTimeParameterToDate": false
								},
								"item1": {
									"comparisonType": 3,
									"filterType": 1,
									"isEnabled": true,
									"leftExpression": {
										"columnPath": "Status.IsFinal",
										"expressionType": 0
									},
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 12,
											"value": false
										}
									},
									"trimDateTimeParameterToDate": false
								}
							},
							"logicalOperation": 1
						},
						"IsNotCanceled": {
							"comparisonType": 3,
							"filterType": 1,
							"isEnabled": true,
							"leftExpression": {
								"columnPath": "IsCanceled",
								"expressionType": 0
							},
							"rightExpression": {
								"expressionType": 2,
								"parameter": {
									"dataValueType": 12,
									"value": false
								}
							},
							"trimDateTimeParameterToDate": false
						}
					}
				}
			},
			{
				"Name": "SysAdminUnit",
				"SyncColumns": []
			}
		]
	},
	"Modules": {
		"Invoice": {
			"Group": "main",
			"Model": "Invoice",
			"Position": 6,
			"Hidden": false
		}
	},
	"Models": {
		"Invoice": {
			"RequiredModels": [
				"Invoice",
				"InvoicePaymentStatus",
				"Account",
				"Contact",
				"Currency",
				"SocialMessage",
				"InvoiceVisa",
				"SysAdminUnit",
				"VisaStatus"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileInvoiceActionsSettingsDefaultWorkplace",
				"MobileInvoiceGridPageSettingsDefaultWorkplace",
				"MobileInvoiceRecordPageSettingsDefaultWorkplace"
			]
		},
		"SocialMessage": {
			"RequiredModels": [],
			"ModelExtensions": [],
			"PagesExtensions": []
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"SyncOptions": {
		"SyncRules": {
			"ActivityModule": {
				"importOptions": {
					"columns": [
						"Lead"
					]
				}
			}
		},
		"ModelDataImportConfig": [
			{
				"Name": "Lead",
				"SyncColumns": [
					"Account",
					"Contact",
					"LeadName",
					"FullJobTitle",
					"Industry",
					"BusinesPhone",
					"MobilePhone",
					"Email",
					"Fax",
					"Website",
					"Address",
					"City",
					"Region",
					"Country",
					"Zip",
					"AddressType",
					"InformationSource",
					"Commentary",
					"Status",
					"LeadType",
					"Owner",
					"LeadMedium",
					"QualifyStatus",
					"CreatedOn"
				]
			},
			{
				"Name": "Contact",
				"SyncColumns": []
			},
			{
				"Name": "Account",
				"SyncColumns": []
			},
			{
				"Name": "LeadStatus",
				"SyncColumns": [
					"Active"
				]
			},
			{
				"Name": "Activity",
				"SyncColumns": [
					"Lead"
				]
			},
			{
				"Name": "ActivityParticipant",
				"SyncColumns": [
					"Activity",
					"Participant"
				]
			},
			{
				"Name": "ActivityParticipantRole",
				"SyncColumns": []
			},
			{
				"Name": "InformationSource",
				"SyncColumns": []
			},
			{
				"Name": "AccountIndustry",
				"SyncColumns": []
			},
			{
				"Name": "AddressType",
				"SyncColumns": []
			},
			{
				"Name": "Country",
				"SyncColumns": []
			},
			{
				"Name": "Region",
				"SyncColumns": []
			},
			{
				"Name": "City",
				"SyncColumns": []
			},
			{
				"Name": "LeadTypeStatus",
				"SyncColumns": []
			},
			{
				"Name": "QualifyStatus",
				"SyncColumns": []
			},
			{
				"Name": "ActivityPriority",
				"SyncColumns": []
			},
			{
				"Name": "ActivityType",
				"SyncColumns": []
			},
			{
				"Name": "ActivityCategory",
				"SyncColumns": []
			},
			{
				"Name": "ActivityStatus",
				"SyncColumns": []
			},
			{
				"Name": "LeadRegisterMethod",
				"SyncColumns": []
			},
			{
				"Name": "LeadType",
				"SyncColumns": []
			},
			{
				"Name": "LeadMedium",
				"SyncColumns": []
			}
		],
		"SysSettingsImportConfig": []
	},
	"Modules": {
		"Lead": {
			"Position": 3,
			"Hidden": false
		}
	},
	"Models": {
		"Account": {
			"RequiredModels": [
				"Lead"
			]
		},
		"Activity": {
			"PagesExtensions": [
				"MobileActivityRecordPageSettingsDefaultWorkplace",
				"MobileActivityLeadModuleConfig"
			],
			"ModelExtensions": []
		},
		"Lead": {
			"Preview": "MobileLeadPreviewPage",
			"ModelExtensions": [
				"MobileLeadModelConfig"
			],
			"PagesExtensions": [
				"MobileLeadRecordPageSettingsDefaultWorkplace",
				"MobileLeadGridPageSettingsDefaultWorkplace",
				"MobileLeadActionsSettingsDefaultWorkplace",
				"MobileLeadModuleConfig"
			],
			"RequiredModels": [
				"Lead",
				"LeadMedium",
				"QualifyStatus",
				"LeadTypeStatus",
				"LeadRegisterMethod"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceOpportunityResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"CustomSchemas": [
		"MobileLookupGridOpportunityPageConfig",
		"MobileOpportunityUtilities"
	],
	"SyncOptions": {
		"SyncRules": {
			"ActivityModule": {
				"importOptions": {
					"columns": [
						"Opportunity"
					]
				}
			}
		},
		"SysSettingsImportConfig": [],
		"ModelDataImportConfig": [
			{
				"Name": "Account",
				"SyncColumns": []
			},
			{
				"Name": "Opportunity",
				"SyncFilter": {
					"property": "Owner",
					"valueIsMacros": true,
					"value": "Terrasoft.ValueMacros.CurrentUserContact"
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "Opportunity",
					"items": {
						"OwnerCurrentUser": {
							"filterType": 1,
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Owner"
							},
							"comparisonType": 3
						}
					}
				},
				"SyncColumns": [
					"Title",
					"Type",
					"Stage",
					"Account",
					"Amount",
					"Probability",
					"Budget",
					"Owner",
					"Contact",
					"Mood",
					"DueDate",
					"LeadType"
				]
			},
			{
				"Name": "OpportunityType",
				"SyncColumns": []
			},
			{
				"Name": "OpportunityStage",
				"SyncColumns": [
					"End",
					"MaxProbability",
					"Number"
				]
			},
			{
				"Name": "Activity",
				"SyncColumns": [
					"Opportunity"
				]
			},
			{
				"Name": "OpportunityContact",
				"SyncByParentObjectWithRights": "Opportunity",
				"SyncFilter": {
					"property": "Opportunity.Owner",
					"valueIsMacros": true,
					"value": "Terrasoft.ValueMacros.CurrentUserContact"
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "OpportunityContact",
					"items": {
						"OpportunityOwnerCurrentUser": {
							"filterType": 1,
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Opportunity.Owner"
							},
							"comparisonType": 3
						}
					}
				},
				"SyncColumns": [
					"Opportunity",
					"Contact",
					"IsMainContact",
					"Role",
					"Influence",
					"ContactMotivator",
					"ContactLoyality"
				]
			},
			{
				"Name": "Contact",
				"SyncColumns": []
			},
			{
				"Name": "OppContactRole",
				"SyncColumns": []
			},
			{
				"Name": "OppContactInfluence",
				"SyncColumns": []
			},
			{
				"Name": "OppContactLoyality",
				"SyncColumns": [
					"Position"
				]
			},
			{
				"Name": "OpportunityProductInterest",
				"SyncByParentObjectWithRights": "Opportunity",
				"SyncColumns": [
					"Opportunity",
					"Product",
					"OfferResult",
					"Quantity",
					"OfferDate",
					"Comment"
				]
			},
			{
				"Name": "Product",
				"SyncColumns": []
			},
			{
				"Name": "PropositionResult",
				"SyncColumns": []
			},
			{
				"Name": "FileType",
				"SyncColumns": []
			},
			{
				"Name": "OpportunityFile",
				"SyncByParentObjectWithRights": "Opportunity",
				"SyncColumns": [
					"Opportunity",
					"Type",
					"Data",
					"Size",
					"Name",
					"CreatedOn",
					"CreatedBy"
				],
				"SyncFilter": {
					"property": "Opportunity.Owner",
					"valueIsMacros": true,
					"value": "Terrasoft.ValueMacros.CurrentUserContact"
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "OpportunityFile",
					"items": {
						"OpportunityOwnerCurrentUser": {
							"filterType": 1,
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Opportunity.Owner"
							},
							"comparisonType": 3
						}
					}
				}
			},
			{
				"Name": "OpportunityOfferResult",
				"SyncColumns": []
			},
			{
				"Name": "OpportunityProbability",
				"SyncColumns": []
			},
			{
				"Name": "ActivityPriority",
				"SyncColumns": []
			},
			{
				"Name": "ActivityType",
				"SyncColumns": []
			},
			{
				"Name": "ActivityCategory",
				"SyncColumns": []
			},
			{
				"Name": "ActivityStatus",
				"SyncColumns": [
					"Finish"
				]
			},
			{
				"Name": "ActivityParticipant",
				"SyncColumns": [
					"Activity",
					"Participant"
				]
			},
			{
				"Name": "ActivityParticipantRole",
				"SyncColumns": []
			},
			{
				"Name": "AccountCommunication",
				"SyncColumns": []
			},
			{
				"Name": "CommunicationType",
				"SyncColumns": []
			},
			{
				"Name": "AccountAddress",
				"SyncColumns": []
			},
			{
				"Name": "AddressType",
				"SyncColumns": []
			},
			{
				"Name": "Country",
				"SyncColumns": []
			},
			{
				"Name": "Region",
				"SyncColumns": []
			},
			{
				"Name": "City",
				"SyncColumns": []
			},
			{
				"Name": "AccountAnniversary",
				"SyncColumns": []
			},
			{
				"Name": "AnniversaryType",
				"SyncColumns": []
			},
			{
				"Name": "OpportunityMood",
				"SyncColumns": []
			},
			{
				"Name": "LeadType",
				"SyncColumns": []
			}
		]
	},
	"Modules": {
		"Opportunity": {
			"Position": 5,
			"Hidden": false
		}
	},
	"Models": {
		"Account": {
			"PagesExtensions": [
				"MobileAccountRecordPageSettingsDefaultWorkplace"
			]
		},
		"Activity": {
			"ModelExtensions": [
				"MobileActivityOpportunityModelConfig"
			],
			"PagesExtensions": [
				"MobileActivityRecordPageSettingsDefaultWorkplace",
				"MobileActivityOpportunityModuleConfig"
			]
		},
		"Opportunity": {
			"Preview": "MobileOpportunityPreviewPage",
			"Edit": "MobileOpportunityEditPage",
			"ModelExtensions": [
				"MobileOpportunityModelConfig"
			],
			"PagesExtensions": [
				"MobileOpportunityRecordPageSettingsDefaultWorkplace",
				"MobileOpportunityGridPageSettingsDefaultWorkplace",
				"MobileOpportunityActionsSettingsDefaultWorkplace",
				"MobileOpportunityModuleConfig"
			],
			"RequiredModels": [
				"Opportunity",
				"Account",
				"Contact",
				"OpportunityStage",
				"OpportunityMood",
				"OpportunityType",
				"LeadType",
				"OpportunityContact",
				"OppContactRole",
				"OppContactInfluence",
				"OppContactLoyality",
				"OpportunityProductInterest",
				"Product",
				"PropositionResult",
				"OpportunityFile"
			]
		},
		"OpportunityContact": {
			"ModelExtensions": [
				"MobileOpportunityContactModelConfig"
			],
			"RequiredModels": [
				"OpportunityContact",
				"Opportunity",
				"Contact",
				"OpportunityType",
				"OpportunityStage",
				"OpportunityProbability"
			]
		},
		"OpportunityProductInterest": {
			"ModelExtensions": [
				"MobileOpportunityProductInterestModelConfig"
			]
		},
		"SysDashboard": {
			"PagesExtensions": [
				"MobileDashboardPageConfig"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceCoreLeadOpportunityResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"SyncOptions": {
		"ModelDataImportConfig": [
			{
				"Name": "LeadType",
				"SyncColumns": []
			}
		]
	},
	"Modules": {},
	"Models": {
		"Opportunity": {
			"RequiredModels": [
				"LeadType"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceSLMITILServiceResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"SyncOptions": {
		"ModelDataImportConfig": [
			{
				"Name": "Case",
				"SyncColumns": [
					"SupportLevel"
				]
			},
			{
				"Name": "RoleInServiceTeam",
				"SyncColumns": []
			}
		]
	},
	"Models": {
		"Case": {
			"RequiredModels": [
				"RoleInServiceTeam"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceCaseMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"CustomSchemas": [
		"MobileCaseCss",
		"MobileCaseUtilities"
	],
	"SyncOptions": {
		"SyncRules": {
			"ActivityModule": {
				"importOptions": {
					"columns": [
						"Case"
					]
				}
			}
		},
		"SysSettingsImportConfig": [
			"CaseStatusDef",
			"CasePriorityDef",
			"CaseOriginDef",
			"CaseServiceLevelDef",
			"MobileDefaultCaseOrigin"
		],
		"ModelDataImportConfig": [
			{
				"Name": "Case",
				"ExpandLookups": true,
				"SyncColumns": [
					"Number",
					"RegisteredOn",
					"Subject",
					"Status",
					"Symptoms",
					"Owner",
					"Priority",
					"Account",
					"Contact",
					"Category",
					"Group"
				],
				"SyncFilter": {
					"type": "Terrasoft.FilterTypes.Group",
					"logicalOperation": "Terrasoft.FilterLogicalOperations.And",
					"subfilters": [
						{
							"compareType": "Terrasoft.ComparisonTypes.GreaterOrEqual",
							"property": "RegisteredOn",
							"valueIsMacros": true,
							"value": "Terrasoft.ValueMacros.CurrentDate",
							"macrosParams": {
								"datePart": "d",
								"value": -30
							}
						},
						{
							"type": "Terrasoft.FilterTypes.Group",
							"logicalOperation": "Terrasoft.FilterLogicalOperations.Or",
							"subfilters": [
								{
									"property": "Owner",
									"compareType": "Terrasoft.ComparisonTypes.Equal",
									"valueIsMacros": true,
									"value": "Terrasoft.ValueMacros.CurrentUserContact"
								},
								{
									"property": "Owner",
									"compareType": "Terrasoft.ComparisonTypes.NotEqual",
									"isNot": true,
									"value": null
								}
							]
						},
						{
							"type": "Terrasoft.FilterTypes.Group",
							"logicalOperation": "Terrasoft.FilterLogicalOperations.Or",
							"subfilters": [
								{
									"compareType": "Terrasoft.ComparisonTypes.GreaterOrEqual",
									"property": "RegisteredOn",
									"valueIsMacros": true,
									"value": "Terrasoft.ValueMacros.CurrentDate",
									"macrosParams": {
										"datePart": "d",
										"value": -7
									}
								},
								{
									"property": "Status.IsFinal",
									"value": false
								}
							]
						}
					]
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "Case",
					"items": {
						"RegistredOnPrevious30Days": {
							"filterType": 1,
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 25,
								"functionArgument": {
									"expressionType": 2,
									"parameter": {
										"dataValueType": 4,
										"value": 30
									}
								}
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "RegisteredOn"
							},
							"comparisonType": 8,
							"trimDateTimeParameterToDate": true
						},
						"OwnerFilter": {
							"logicalOperation": 1,
							"filterType": 6,
							"rootSchemaName": "Case",
							"items": {
								"OwnerCurrentUser": {
									"filterType": 1,
									"rightExpression": {
										"expressionType": 1,
										"functionType": 1,
										"macrosType": 2
									},
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "Owner"
									},
									"comparisonType": 3
								},
								"OwnerEmpty": {
									"filterType": 2,
									"isNull": true,
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "Owner"
									}
								}
							}
						},
						"ActualStateFilter": {
							"logicalOperation": 1,
							"filterType": 6,
							"rootSchemaName": "Case",
							"items": {
								"RegistredOnPrevious7Days": {
									"filterType": 1,
									"rightExpression": {
										"expressionType": 1,
										"functionType": 1,
										"macrosType": 25,
										"functionArgument": {
											"expressionType": 2,
											"parameter": {
												"dataValueType": 4,
												"value": 7
											}
										}
									},
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "RegisteredOn"
									},
									"comparisonType": 8,
									"trimDateTimeParameterToDate": true
								},
								"StatusNotFinal": {
									"filterType": 1,
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 12,
											"value": false
										}
									},
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "Status.IsFinal"
									},
									"comparisonType": 3
								}
							}
						}
					}
				}
			},
			{
				"Name": "CaseStatus",
				"SyncColumns": [
					"Name",
					"IsFinal"
				]
			},
			{
				"Name": "CasePriority",
				"SyncColumns": []
			},
			{
				"Name": "CaseOrigin",
				"SyncColumns": []
			},
			{
				"Name": "CaseFile",
				"SyncByParentObjectWithRights": "Case",
				"SyncColumns": [
					"Case",
					"Type",
					"Data",
					"Size",
					"Name",
					"CreatedOn",
					"CreatedBy"
				]
			},
			{
				"Name": "VwMobileCaseMessageHistory",
				"SyncByParentObjectWithRights": "Case",
				"SyncColumns": [
					"OwnerName",
					"OwnerPhoto",
					"Message",
					"MessageNotifier",
					"RecordId",
					"HasAttachment",
					"Case",
					"Id",
					"Recepient"
				]
			},
			{
				"Name": "MessageNotifier",
				"SyncColumns": [
					"Name",
					"Description"
				]
			},
			{
				"Name": "Activity",
				"SyncColumns": [
					"Case"
				]
			},
			{
				"Name": "CaseCategory",
				"SyncColumns": []
			}
		]
	},
	"Modules": {
		"Case": {
			"Group": "main",
			"Model": "Case",
			"Position": 3,
			"Title": "CaseSectionTitle",
			"Hidden": false
		}
	},
	"Models": {
		"Case": {
			"Grid": "MobileCaseGridPage",
			"Preview": "MobileCasePreviewPage",
			"Edit": "MobileCaseEditPage",
			"CacheConfig": {
				"AssociatedModels": [
					"VwMobileCaseMessageHistory"
				]
			},
			"RequiredModels": [
				"Case",
				"CaseStatus",
				"CasePriority",
				"CaseOrigin",
				"SocialMessage",
				"Contact",
				"Account",
				"CaseFile",
				"FileType",
				"KnowledgeBase",
				"KnowledgeBaseFile",
				"VwMobileCaseMessageHistory",
				"Activity",
				"CaseCategory"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileCaseActionsSettingsDefaultWorkplace",
				"MobileCaseGridPageSettingsDefaultWorkplace",
				"MobileCaseRecordPageSettingsDefaultWorkplace",
				"MobileCaseModuleConfig",
				"MobileCaseModelConfig",
				"MobileCaseGridPageView",
				"MobileCaseGridPageController",
				"MobileCasePreviewPageView",
				"MobileCasePreviewPageController",
				"MobileCaseEditPageView",
				"MobileCaseEditPageController"
			]
		},
		"VwMobileCaseMessageHistory": {
			"Grid": "MobileCaseMessageHistoryGridPage",
			"Preview": "MobileCaseMessageHistoryPreviewPage",
			"RequiredModels": [
				"Case",
				"MessageNotifier",
				"VwMobileCaseMessageHistory"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileCaseMessageHistoryActionsSettingsDefaultWorkplace",
				"MobileCaseMessageHistoryGridPageSettingsDefaultWorkplace",
				"MobileCaseMessageHistoryRecordPageSettingsDefaultWorkplace",
				"MobileCaseMessageHistoryModuleConfig",
				"MobileCaseMessageHistoryGridPageView",
				"MobileCaseMessageHistoryGridPageController"
			]
		}
	}
}
define('MobileApplicationManifestDefaultWorkplaceServiceEnterpriseMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"Features": {
		"UseMobileCase": {
			"Models": {
				"Case": {
					"Preview": "MobileServiceCasePreviewPage",
					"PagesExtensions": [
						"MobileCaseEscalationPage",
						"MobileServiceCasePreviewPageController"
					]
				}
			}
		}
	}
}
{
	"SyncOptions": {
		"SysSettingsImportConfig": [],
		"ModelDataImportConfig": [
			{
				"Name": "ContactCommunication",
				"SyncColumns": [
					"NonActual"
				]
			}
		]
	},
	"Modules": {},
	"Models": {
		"Contact": {
			"PagesExtensions": [
				"MarketingCampaignMobileContactModuleConfig"
			]
		}
	}
}

