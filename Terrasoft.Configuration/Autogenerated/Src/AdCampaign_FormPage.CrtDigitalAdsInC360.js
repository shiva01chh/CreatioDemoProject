define("AdCampaign_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "AmountSpentIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 5,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "DailyInsightsList",
				"values": {
					"columns": [
						{
							"id": "c272e952-7daf-9396-6be2-38555754a445",
							"code": "DataGrid_DailyInsightsListDS_DataRangeDate",
							"path": "DataRangeDate",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_DataRangeDate)#",
							"dataValueType": 8,
							"width": 140
						},
						{
							"id": "6f7aeaa3-4239-8cc1-7a4e-beaa4c45caac",
							"code": "DataGrid_DailyInsightsListDS_PrimaryAmountSpent",
							"path": "PrimaryAmountSpent",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_PrimaryAmountSpent)#",
							"dataValueType": 32,
							"width": 167
						},
						{
							"id": "374868c6-eca6-35c9-5c4e-6f5099f864cc",
							"code": "DataGrid_DailyInsightsListDS_Submissions",
							"path": "Submissions",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_Submissions)#",
							"dataValueType": 4,
							"width": 138
						},
						{
							"id": "dc62e06e-9f06-cdf5-6a78-ebebdcdef2a3",
							"code": "DataGrid_DailyInsightsListDS_CostPerSubmission",
							"path": "CostPerSubmission",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_CostPerSubmission)#",
							"dataValueType": 32,
							"width": 210
						},
						{
							"id": "0340985c-4c2e-3321-819b-d52e061e2f45",
							"code": "DataGrid_DailyInsightsListDS_Contacts",
							"path": "Contacts",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_Contacts)#",
							"dataValueType": 4,
							"width": 114
						},
						{
							"id": "2e31c30a-d666-1861-2674-5b8ad6f4994f",
							"code": "DataGrid_DailyInsightsListDS_CostPerContact",
							"path": "CostPerContact",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_CostPerContact)#",
							"dataValueType": 32,
							"width": 176
						},
						{
							"id": "e0412f7c-7e0f-e5fc-4c9d-ba967ef3ad4b",
							"code": "DataGrid_DailyInsightsListDS_Impressions",
							"path": "Impressions",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_Impressions)#",
							"dataValueType": 4,
							"width": 203
						},
						{
							"id": "5ad4171d-243a-c50b-dba1-507a26e8f36c",
							"code": "DataGrid_DailyInsightsListDS_Clicks",
							"path": "Clicks",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_Clicks)#",
							"dataValueType": 4,
							"width": 177
						},
						{
							"id": "239a7137-8eb1-8589-655d-45f1b400f2ef",
							"code": "DataGrid_DailyInsightsListDS_CPM",
							"path": "CPM",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_CPM)#",
							"dataValueType": 32,
							"width": 114
						},
						{
							"id": "dc138a1f-a35d-d516-e86b-1d7798b7d777",
							"code": "DataGrid_DailyInsightsListDS_CTR",
							"path": "CTR",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_CTR)#",
							"dataValueType": 32,
							"width": 114
						},
						{
							"id": "c9021c97-c6c1-1941-c761-024d1ef8094f",
							"code": "DataGrid_DailyInsightsListDS_CPC",
							"path": "CPC",
							"caption": "#ResourceString(DataGrid_DailyInsightsListDS_CPC)#",
							"dataValueType": 32,
							"width": 114
						}
					]
				}
			},
			{
				"operation": "insert",
				"name": "ContactsIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 7,
						"colSpan": 1,
						"rowSpan": 1,
						"row": 1
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(ContactsIndicatorWidget_title)#",
						"data": {
							"providing": {
								"attribute": "ContactsIndicatorWidget_27a932b1fc2b813aca7ded82e16e0eb4",
								"schemaName": "AdCampaignDailyInsights",
								"filters": {
									"filter": {
										"items": {},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "AdCampaignDailyInsights"
									},
									"filterAttributes": []
								},
								"aggregation": {
									"column": {
										"orderDirection": 0,
										"orderPosition": -1,
										"isVisible": true,
										"expression": {
											"expressionType": 1,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Contacts"
											},
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0
										}
									}
								},
								"dependencies": [
									{
										"attributePath": "Id",
										"relationPath": "DataGrid_DailyInsightsListDS.Id"
									}
								]
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"dataSourceConfig": {
							"entitySchemaName": "AdCampaign"
						},
						"text": {
							"template": "#ResourceString(ContactsIndicatorWidget_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "violet"
						},
						"theme": "full-fill"
					},
					"visible": true,
					"sectionBindingColumnRecordId": "$Id"
				},
				"parentName": "CardContentWrapper",
				"propertyName": "items",
				"index": 3
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"DataGrid_DailyInsightsList": {
					"viewModelConfig": {
						"attributes": {
							"DataGrid_DailyInsightsListDS_Submissions": {
								"modelConfig": {
									"path": "DataGrid_DailyInsightsListDS.Submissions"
								}
							},
							"DataGrid_DailyInsightsListDS_CostPerSubmission": {
								"modelConfig": {
									"path": "DataGrid_DailyInsightsListDS.CostPerSubmission"
								}
							},
							"DataGrid_DailyInsightsListDS_Contacts": {
								"modelConfig": {
									"path": "DataGrid_DailyInsightsListDS.Contacts"
								}
							},
							"DataGrid_DailyInsightsListDS_CostPerContact": {
								"modelConfig": {
									"path": "DataGrid_DailyInsightsListDS.CostPerContact"
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"DataGrid_DailyInsightsListDS": {
					"config": {
						"attributes": {
							"Submissions": {
								"path": "Submissions"
							},
							"CostPerSubmission": {
								"path": "CostPerSubmission"
							},
							"Contacts": {
								"path": "Contacts"
							},
							"CostPerContact": {
								"path": "CostPerContact"
							}
						}
					}
				}
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});