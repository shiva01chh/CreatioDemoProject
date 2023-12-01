Terrasoft.configuration.Structures["MobileApplicationManifestPortal"] = {innerHierarchyStack: ["MobileApplicationManifestPortalSSP", "MobileApplicationManifestPortalCaseMobile", "MobileApplicationManifestPortal"]};



define('MobileApplicationManifestPortalSSPResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"Features": {
		"UseMobileDynamicLink": {
			"CustomSchemas": [
				"MobileDynamicLinkReceiver"
			]
		},
		"UseMobileSummaries": {
			"CustomSchemas": [
				"MobileSummariesData"
			]
		},
		"UseMobileFolders": {
			"CustomSchemas": [
				"MobileFoldersData",
				"MobileFoldersStore"
			],
			"ApplicationRequiredModels": [
				"BaseFolder",
				"FolderType"
			]
		}
	},
	"UseOptimisticEditing": true,
	"UseUTC": true,
	"ModuleGroups": {
		"main": {
			"Position": 0
		}
	},
	"DefaultModuleImageId": "MobileImageListDefaultModuleImage",
	"DefaultModuleImageIdV2": "MobileImageListDefaultModuleImageV2",
	"CustomSchemas": [
		"MobileImageList",
		"MobileCss",
		"MobileUtilities",
		"MobileConstants",
		"MobileServiceHelper",
		"MobilePushNotificationReceiver",
		"BaseLocalNotificationManager",
		"MobileLocalNotificationManager",
		"MobileActionShareLink"
	],
	"SyncOptions": {
		"ImportPageSize": 1000,
		"PagesInImportTransaction": 5,
		"UseBatchExport": true,
		"UseSkipToken": true,
		"SysSettingsImportConfig": [
			"MobileApplicationMode",
			"CollectMobileAppUsageStatistics",
			"CanCollectMobileUsageStatistics",
			"MobileAppUsageStatisticsEmail",
			"MobileAppUsageStatisticsStorePeriod",
			"MobileSectionsWithSearchOnly",
			"MobileShowMenuOnApplicationStart",
			"MobileAppCheckUpdatePeriod",
			"ShowMobileLocalNotifications",
			"MobileLogoImage",
			"RunMobileSyncInService",
			"NotifyMobileUserAboutAppUpdate",
			"EnableMobileErrorLog",
			"MobileDataSyncFrequency",
			"UseMobileLastKnownLocation",
			"UseMobileCertificateAuthentication",
			"MobileEmailForPermissionRequests",
			"MobileAmplitudeApiKey",
			"DataServiceQueryTimeout",
			"MaxFileSize",
			"FileExtensionsAllowList"
		],
		"SysLookupsImportConfig": [
			"MobileApplicationMode"
		],
		"ModelDataImportConfig": [
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
			}
		]
	},
	"Modules": {
		"Contact": {
			"Group": "main",
			"Model": "Contact",
			"IconV2": {
				"ImageId": "MobileImageListContactModuleImageV2"
			},
			"Hidden": true
		},
		"Account": {
			"Group": "main",
			"Model": "Account",
			"IconV2": {
				"ImageId": "MobileImageListAccountModuleImageV2"
			},
			"Hidden": true
		},
		"Activity": {
			"Group": "main",
			"Model": "Activity",
			"IconV2": {
				"ImageId": "MobileImageListActivityModuleImageV2"
			},
			"Hidden": true
		},
		"Contract": {
			"Group": "main",
			"Model": "Contract",
			"IconV2": {
				"ImageId": "MobileImageListContractModuleImageV2"
			},
			"Hidden": true
		},
		"Document": {
			"Group": "main",
			"Model": "Document",
			"IconV2": {
				"ImageId": "MobileImageListDocumentModuleImageV2"
			},
			"Hidden": true
		},
		"Order": {
			"Group": "main",
			"Model": "Order",
			"IconV2": {
				"ImageId": "MobileImageListOrderModuleImageV2"
			},
			"Hidden": true
		},
		"Forecast": {
			"Group": "main",
			"Model": "Forecast",
			"IconV2": {
				"ImageId": "MobileImageListPlanningModuleImageV2"
			},
			"Hidden": true
		},
		"Product": {
			"Group": "main",
			"Model": "Product",
			"IconV2": {
				"ImageId": "MobileImageListProductModuleImageV2"
			},
			"Hidden": true
		},
		"Project": {
			"Group": "main",
			"Model": "Project",
			"IconV2": {
				"ImageId": "MobileImageListProjectModuleImageV2"
			},
			"Hidden": true
		},
		"Invoice": {
			"Group": "main",
			"Model": "Invoice",
			"IconV2": {
				"ImageId": "MobileImageListInvoiceModuleImageV2"
			},
			"Hidden": true
		},
		"Request": {
			"Group": "main",
			"Model": "Request",
			"IconV2": {
				"ImageId": "MobileImageListRequestModuleImageV2"
			},
			"Hidden": true
		},
		"Listing": {
			"Group": "main",
			"Model": "Listing",
			"IconV2": {
				"ImageId": "MobileImageListListingModuleImageV2"
			},
			"Hidden": true
		},
		"SocialMessage": {
			"Group": "main",
			"Model": "SocialMessage",
			"IconV2": {
				"ImageId": "MobileImageListFeedModuleImageV2"
			},
			"Hidden": true
		},
		"ConfItem": {
			"Group": "main",
			"Model": "ConfItem",
			"IconV2": {
				"ImageId": "MobileImageListConfigurationModuleImageV2"
			},
			"Hidden": true
		},
		"Case": {
			"Group": "main",
			"Model": "Case",
			"IconV2": {
				"ImageId": "MobileImageListTreatmentModuleImageV2"
			},
			"Hidden": true
		},
		"Problem": {
			"Group": "main",
			"Model": "Problem",
			"IconV2": {
				"ImageId": "MobileImageListProblemModuleImageV2"
			},
			"Hidden": true
		},
		"ServicePact": {
			"Group": "main",
			"Model": "ServicePact",
			"IconV2": {
				"ImageId": "MobileImageListServiceContractModuleImageV2"
			},
			"Hidden": true
		},
		"ServiceItem": {
			"Group": "main",
			"Model": "ServiceItem",
			"IconV2": {
				"ImageId": "MobileImageListServiceModuleImageV2"
			},
			"Hidden": true
		},
		"Campaign": {
			"Group": "main",
			"Model": "Campaign",
			"IconV2": {
				"ImageId": "MobileImageListCampaignModuleImageV2"
			},
			"Hidden": true
		},
		"KnowledgeBase": {
			"Group": "main",
			"Model": "KnowledgeBase",
			"IconV2": {
				"ImageId": "MobileImageListKnowledgeBaseModuleImageV2"
			},
			"Title": "KnowledgeBaseSectionTitle",
			"Hidden": true
		},
		"BulkEmail": {
			"Group": "main",
			"Model": "BulkEmail",
			"IconV2": {
				"ImageId": "MobileImageListEmailModuleImageV2"
			},
			"Hidden": true
		},
		"Event": {
			"Group": "main",
			"Model": "Event",
			"IconV2": {
				"ImageId": "MobileImageListActionModuleImageV2"
			},
			"Hidden": true
		},
		"SocialSubscription": {
			"Group": "main",
			"Model": "SocialSubscription",
			"IconV2": {
				"ImageId": "MobileImageListSubscriptionModuleImageV2"
			},
			"Hidden": true
		},
		"Lead": {
			"Group": "main",
			"Model": "Lead",
			"IconV2": {
				"ImageId": "MobileImageListLeadModuleImageV2"
			},
			"Hidden": true
		},
		"Opportunity": {
			"Group": "main",
			"Model": "Opportunity",
			"IconV2": {
				"ImageId": "MobileImageListOpportunityModuleImageV2"
			},
			"Hidden": true
		},
		"SysDashboard": {
			"Group": "main",
			"Model": "SysDashboard",
			"IconV2": {
				"ImageId": "MobileImageListDashboardModuleImageV2"
			},
			"Hidden": true
		},
		"Approval": {
			"Group": "main",
			"Model": "Approval",
			"IsFlutterPage": true,
			"ScreenName": "ApprovalsScreen",
			"IconV2": {
				"ImageId": "MobileImageListApprovalModuleImage"
			},
			"Hidden": true
		}
	},
	"ApplicationRequiredModels": ["Contact", "Account", "SysImage", "DuplicatesHistory", "SysModule", "SysAdminUnit", "SysSchema", "VwSysEntitySchemaInWorkspace", "VwRemindings", "SysAdminUnitInRole"]
}
define('MobileApplicationManifestPortalCaseMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
{
	"onboardingName": "Portal",
	"SyncOptions": {
		"SysLookupsImportConfig": [
			"CaseStatus",
			"CasePriority",
			"MessageNotifier",
			"CaseCategory",
			"CaseStatusDef",
			"CasePriorityDef",
			"CaseOriginDef",
			"CaseServiceLevelDef",
			"MobileDefaultCaseOrigin"
		],
		"SysSettingsImportConfig": [
			"CaseStatusDef",
			"CasePriorityDef",
			"CaseOriginDef",
			"CaseServiceLevelDef"
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
					"Priority",
					"Account",
					"Contact",
					"Category",
					"SolutionDate",
					"ResponseDate"
				],
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "Case",
					"items": {
						"ActualStateFilter": {
							"logicalOperation": 1,
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
				"Name": "MessageNotifier",
				"SyncColumns": []
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
					"Name",
					"Data",
					"Size"
				]
			},
			{
				"Name": "CaseCategory",
				"SyncColumns": []
			},
			{
				"Name": "CaseMessageHistory",
				"SyncColumns": [
					"CreatedOn",
					"CreatedBy",
					"Message",
					"Case",
					"RecordId",
					"MessageNotifier",
					"Id"
				],
				"QueryFilter": {
					"filterType": 6,
					"isEnabled": true,
					"logicalOperation": 0,
					"items": {
						"CaseIdNotNullFilter": {
							"comparisonType": 2,
							"filterType": 2,
							"isEnabled": true,
							"isNull": false,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Id"
							}
						},
						"HistoryV2ClassNameFilter": {
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "MessageNotifier.HistoryV2ClassName"
							},
							"comparisonType": 2,
							"isEnabled": true,
							"trimDateTimeParameterToDate": false,
							"filterType": 2,
							"isNull": false
						},
						"MessageNotifierFilter": {
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "MessageNotifier"
							},
							"comparisonType": 4,
							"isEnabled": true,
							"trimDateTimeParameterToDate": false,
							"filterType": 1,
							"rightExpression": {
								"expressionType": 2,
								"parameter": {
									"dataValueType": 1,
									"value": "ed501edb-8ebf-4c76-a35d-6f23be243043"
								}
							}
						},
						"MessageNotifierBySectionFilter": {
							"filterType": 6,
							"isEnabled": true,
							"logicalOperation": 1,
							"items": {
								"fb98b21c-0e00-4286-ba82-bf352f9590ea": {
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "[MessageNotifierBySection:MessageNotifier:MessageNotifier].Section"
									},
									"comparisonType": 3,
									"isEnabled": true,
									"trimDateTimeParameterToDate": false,
									"filterType": 1,
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 1,
											"value": "302a835d-fb19-4335-a9a4-ef9cd7df6006"
										}
									}
								},
								"512a5598-0c5e-48da-8375-6d39cc1dd442": {
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "[MessageNotifier:AliasNotifier:MessageNotifier].[MessageNotifierBySection:MessageNotifier:Id].Section"
									},
									"comparisonType": 3,
									"isEnabled": true,
									"trimDateTimeParameterToDate": false,
									"filterType": 1,
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 1,
											"value": "302a835d-fb19-4335-a9a4-ef9cd7df6006"
										}
									}
								}
							}
						}
					}
				}
			},
			{
				"Name": "FileType",
				"SyncColumns": []
			}
		]
	},
	"Modules": {
		"Case": {
			"Group": "main",
			"Model": "Case",
			"Position": 0,
			"Title": "CaseSectionTitle",
			"Hidden": false,
			"Icon": {
				"ImageId": "MobileImageListTreatmentModuleImage"
			},
			"IconV2": {
				"ImageId": "MobileImageListTreatmentModuleImageV2"
			},
			"screens": {
				"start": {
					"schemaName": "MobileCaseGridPageSettingsPortal"
				},
				"edit": {
					"schemaName": "MobileCaseRecordPageSettingsPortal"
				},
				"add": {
					"schemaName": "MobileCaseMiniPagePortal"
				}
			}
		}
	},
	"Models": {
		"Case": {
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
				"Activity",
				"CaseCategory",
				"CaseMessageHistory",
				"PortalMessage",
				"PortalMessageFile",
				"ActivityFile",
				"MessageNotifier"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileCaseRecordPageSettingsPortal",
				"MobileCaseGridPageSettingsPortal",
				"MobileCaseMiniPagePortal"
			]
		},
		"SocialMessage": {
			"RequiredModels": [],
			"ModelExtensions": [],
			"PagesExtensions": []
		},
		"CaseMessageHistory": {
			"RequiredModels": [],
			"ModelExtensions": [],
			"PagesExtensions": []
		}
	},
	"ApplicationRequiredModels": ["Case"]
}
{
	"SyncOptions": {
		"ModelDataImportConfig": [
			{
				"Name": "Case",
				"SyncColumns": [
					"ServicePact",
					"ServiceItem",
					"ConfItem"
				]
			},
			{
				"Name": "ServicePact",
				"SyncColumns": []
			},
			{
				"Name": "ServiceItem",
				"SyncColumns": []
			},
			{
				"Name": "ConfItem",
				"SyncColumns": []
			}
		]
	},
	"Models": {
		"Case": {
			"RequiredModels": [
				"ServicePact",
				"ServiceItem",
				"ConfItem"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileCaseRecordPageSettingsPortal"
			]
		}
	}
}

