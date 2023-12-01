define("AdCampaign_ListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "DateRangeQuickFilter",
				"values": {
					"_filterOptions": {
						"expose": [
							{
								"attribute": "DateRangeQuickFilter_ImpressionsIndicatorWidget_df7608a779d36e176797a430652e9ca9",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ImpressionsIndicatorWidget_df7608a779d36e176797a430652e9ca9",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ClicksIndicatorWidget_24f7993d33602b0eb1625d7f2538717f",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ClicksIndicatorWidget_24f7993d33602b0eb1625d7f2538717f",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_AmountSpentIndicatorWidget_3fb8377aaba48f64dbc94173e191afb5",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "AmountSpentIndicatorWidget_3fb8377aaba48f64dbc94173e191afb5",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_8d349afc9bc2864c729927c7a9cf9736",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "AmountSpentChartWidget_8d349afc9bc2864c729927c7a9cf9736",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ClicksChartWidget_464ebdbca5479fa5904323ba79f2b68c",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ClicksChartWidget_464ebdbca5479fa5904323ba79f2b68c",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ImpressionsChartWidget_23f80117b7e0e10d4ca240b136864f87",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ImpressionsChartWidget_23f80117b7e0e10d4ca240b136864f87",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ContactsIndicatorWidget_c4e4dab2c954a43a54be7fee7cbb877e",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ContactsIndicatorWidget_c4e4dab2c954a43a54be7fee7cbb877e",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_44a5eabcec6eaeabc3919dc4a0468599",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "AmountSpentChartWidget_44a5eabcec6eaeabc3919dc4a0468599",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_6356646b8938a89f1f0764cfc11dfbd2",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "AmountSpentChartWidget_6356646b8938a89f1f0764cfc11dfbd2",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ClicksChartWidget_68b40e06737e552dccf415f7988fe7bd",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ClicksChartWidget_68b40e06737e552dccf415f7988fe7bd",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ClicksChartWidget_a2e22590fa14e38f9198d29367dad203",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ClicksChartWidget_a2e22590fa14e38f9198d29367dad203",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							},
							{
								"attribute": "DateRangeQuickFilter_ImpressionsChartWidget_c8ce443881362c406769310334c06068",
								"converters": [
									{
										"converter": "crt.QuickFilterAttributeConverter",
										"args": [
											{
												"target": {
													"viewAttributeName": "ImpressionsChartWidget_c8ce443881362c406769310334c06068",
													"filterColumn": "DataRangeDate"
												},
												"quickFilterType": "date-range"
											}
										]
									}
								]
							}
						],
						"from": "DateRangeQuickFilter_Value"
					}
				}
			},
			{
				"operation": "merge",
				"name": "ImpressionsIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "ClicksIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 3,
						"row": 1,
						"colSpan": 2,
						"rowSpan": 1
					}
				}
			},
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
				"name": "AmountSpentChartWidget",
				"values": {
					"config": {
						"title": "#ResourceString(AmountSpentChartWidget_title)#",
						"color": "blue",
						"theme": "without-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "orange",
								"type": "spline",
								"label": "#ResourceString(AmountSpentChartWidget_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "AmountSpentChartWidget_8d349afc9bc2864c729927c7a9cf9736",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"0796e02c-504e-4869-ae18-f589e42aa2a2": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "AdCampaign.AdAccountCurrency"
														},
														"isAggregative": false,
														"dataValueType": 1,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 1,
																"value": "USD"
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_8d349afc9bc2864c729927c7a9cf9736",
													"loadOnChange": false
												}
											]
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
														"columnPath": "PrimaryAmountSpent"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 2,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							},
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(AmountSpentChartWidget_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "AmountSpentChartWidget_44a5eabcec6eaeabc3919dc4a0468599",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"c05aefb6-e66d-4ddb-b83d-77776c70f434": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "AdCampaign.AdAccountCurrency"
														},
														"isAggregative": false,
														"dataValueType": 1,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 1,
																"value": "USD"
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_44a5eabcec6eaeabc3919dc4a0468599",
													"loadOnChange": true
												}
											]
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
														"columnPath": "Submissions"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 2,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							},
							{
								"color": "violet",
								"type": "bar",
								"label": "#ResourceString(AmountSpentChartWidget_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "AmountSpentChartWidget_6356646b8938a89f1f0764cfc11dfbd2",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"5b222d2b-e889-4f0b-959f-e1e54fb823e7": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "AdCampaign.AdAccountCurrency"
														},
														"isAggregative": false,
														"dataValueType": 1,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 1,
																"value": "USD"
															}
														}
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_AmountSpentChartWidget_6356646b8938a89f1f0764cfc11dfbd2",
													"loadOnChange": true
												}
											]
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
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 2,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "ImpressionsChartWidget",
				"values": {
					"config": {
						"title": "#ResourceString(ImpressionsChartWidget_title)#",
						"color": "blue",
						"theme": "without-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "celestial-blue",
								"type": "spline",
								"label": "#ResourceString(ImpressionsChartWidget_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "ImpressionsChartWidget_23f80117b7e0e10d4ca240b136864f87",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"2703bfcb-0cd6-48a9-b32e-18dcda2fcc00": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "AdCampaign.Platform"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "AdPlatform",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Facebook",
																		"Id": "111c1ea6-f147-4711-b34d-5a7718211f0c",
																		"value": "111c1ea6-f147-4711-b34d-5a7718211f0c",
																		"displayValue": "Facebook"
																	}
																}
															}
														]
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_ImpressionsChartWidget_23f80117b7e0e10d4ca240b136864f87",
													"loadOnChange": false
												}
											]
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
														"columnPath": "Impressions"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							},
							{
								"color": "dark-green",
								"type": "spline",
								"label": "#ResourceString(ImpressionsChartWidget_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "ImpressionsChartWidget_c8ce443881362c406769310334c06068",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"2703bfcb-0cd6-48a9-b32e-18dcda2fcc00": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "AdCampaign.Platform"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "AdPlatform",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Google",
																		"Id": "51c8cbfd-c16e-4e53-9cfe-c6d769884ac4",
																		"value": "51c8cbfd-c16e-4e53-9cfe-c6d769884ac4",
																		"displayValue": "Google"
																	}
																}
															}
														]
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_ImpressionsChartWidget_c8ce443881362c406769310334c06068",
													"loadOnChange": false
												}
											]
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
														"columnPath": "Impressions"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "ClicksChartWidget",
				"values": {
					"config": {
						"title": "#ResourceString(ClicksChartWidget_title)#",
						"color": "blue",
						"theme": "without-fill",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "",
								"formatting": {
									"type": "number",
									"thousandAbbreviation": {
										"enabled": true
									}
								}
							}
						},
						"series": [
							{
								"color": "dark-green",
								"type": "spline",
								"label": "#ResourceString(ClicksChartWidget_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "ClicksChartWidget_464ebdbca5479fa5904323ba79f2b68c",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_ClicksChartWidget_464ebdbca5479fa5904323ba79f2b68c",
													"loadOnChange": false
												}
											]
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
														"columnPath": "Clicks"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							},
							{
								"color": "celestial-blue",
								"type": "bar",
								"label": "#ResourceString(ClicksChartWidget_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "ClicksChartWidget_68b40e06737e552dccf415f7988fe7bd",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_ClicksChartWidget_68b40e06737e552dccf415f7988fe7bd",
													"loadOnChange": true
												}
											]
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
														"columnPath": "Submissions"
													},
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0
												}
											}
										},
										"dependencies": [
											{
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							},
							{
								"color": "violet",
								"type": "bar",
								"label": "#ResourceString(ClicksChartWidget_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"attribute": "ClicksChartWidget_a2e22590fa14e38f9198d29367dad203",
										"schemaName": "AdCampaignDailyInsights",
										"filters": {
											"filter": {
												"items": {
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "AdCampaignDailyInsights"
											},
											"filterAttributes": [
												{
													"attribute": "DateRangeQuickFilter_ClicksChartWidget_a2e22590fa14e38f9198d29367dad203",
													"loadOnChange": true
												}
											]
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
												"attributePath": "AdCampaign",
												"relationPath": "PDS.Id"
											}
										],
										"rowCount": 50,
										"grouping": {
											"type": "by-date-part",
											"column": [
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 1
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 3
													}
												},
												{
													"orderDirection": 0,
													"orderPosition": -1,
													"isVisible": true,
													"expression": {
														"expressionType": 1,
														"functionArgument": {
															"expressionType": 0,
															"columnPath": "DataRangeDate"
														},
														"functionType": 3,
														"datePartType": 4
													}
												}
											]
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								},
								"dataLabel": {
									"display": false
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "AdCampaignList",
				"values": {
					"columns": [
						{
							"id": "e0fe3ed4-41f3-f9aa-0934-3bfdb8cf2044",
							"code": "PDS_CampaignName",
							"path": "CampaignName",
							"caption": "#ResourceString(PDS_CampaignName)#",
							"dataValueType": 28,
							"width": 252
						},
						{
							"id": "aecb307a-27b9-ccf0-3140-68d2b66d3367",
							"code": "PDS_Platform",
							"path": "Platform",
							"caption": "#ResourceString(PDS_Platform)#",
							"dataValueType": 10,
							"referenceSchemaName": "AdPlatform",
							"width": 143
						},
						{
							"id": "6861802f-1f7e-2e16-03cf-64f8b81acbfd",
							"code": "PDS_Status",
							"path": "Status",
							"caption": "#ResourceString(PDS_Status)#",
							"dataValueType": 10,
							"referenceSchemaName": "AdCampaignStatus",
							"width": 131
						},
						{
							"id": "dc989460-d330-8830-6a7c-fc642565aa27",
							"code": "PDS_PrimaryAmountSpent",
							"path": "PrimaryAmountSpent",
							"caption": "#ResourceString(PDS_PrimaryAmountSpent)#",
							"dataValueType": 32,
							"width": 160
						},
						{
							"id": "f6949ca9-a1b7-b143-7aa9-a6c5e3ea6460",
							"code": "PDS_AdAccountCurrency",
							"path": "AdAccountCurrency",
							"caption": "#ResourceString(PDS_AdAccountCurrency)#",
							"dataValueType": 27,
							"width": 114
						},
						{
							"id": "e7184a9a-cc48-bd8b-3082-092981d8217f",
							"code": "PDS_Submissions",
							"path": "Submissions",
							"caption": "#ResourceString(PDS_Submissions)#",
							"dataValueType": 4,
							"width": 147
						},
						{
							"id": "c69aea07-b201-e599-8924-2061da25d5c7",
							"code": "PDS_CostPerSubmission",
							"path": "CostPerSubmission",
							"caption": "#ResourceString(PDS_CostPerSubmission)#",
							"dataValueType": 32,
							"width": 224
						},
						{
							"id": "eaf2d358-39f2-2845-c624-460803bcbd90",
							"code": "PDS_Contacts",
							"path": "Contacts",
							"caption": "#ResourceString(PDS_Contacts)#",
							"dataValueType": 4,
							"width": 170
						},
						{
							"id": "a9e3589e-7229-7879-f2eb-aa9ceeca0f38",
							"code": "PDS_CostPerContact",
							"path": "CostPerContact",
							"caption": "#ResourceString(PDS_CostPerContact)#",
							"dataValueType": 32,
							"width": 214
						},
						{
							"id": "b60911bd-9b83-405c-dabe-edc5b9f1c98d",
							"code": "PDS_Impressions",
							"path": "Impressions",
							"caption": "#ResourceString(PDS_Impressions)#",
							"dataValueType": 4,
							"width": 138
						},
						{
							"id": "7fd6ff23-44d4-33ac-40cc-7d86a8e7ea83",
							"code": "PDS_Clicks",
							"path": "Clicks",
							"caption": "#ResourceString(PDS_Clicks)#",
							"dataValueType": 4,
							"width": 114
						},
						{
							"id": "94eeb71a-939c-45be-5801-0a6ca808d591",
							"code": "PDS_CPM",
							"path": "CPM",
							"caption": "#ResourceString(PDS_CPM)#",
							"dataValueType": 32,
							"width": 114
						},
						{
							"id": "58c7405e-16ce-d2f7-a596-2e9dadf2ca5d",
							"code": "PDS_CTR",
							"path": "CTR",
							"caption": "#ResourceString(PDS_CTR)#",
							"dataValueType": 32,
							"width": 114
						},
						{
							"id": "52cbfadb-6d89-bd9c-fba9-c4e20d96e67c",
							"code": "PDS_CPC",
							"path": "CPC",
							"caption": "#ResourceString(PDS_CPC)#",
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
								"attribute": "ContactsIndicatorWidget_c4e4dab2c954a43a54be7fee7cbb877e",
								"schemaName": "AdCampaignDailyInsights",
								"filters": {
									"filter": {
										"items": {
											"b2db1250-da4b-4b8b-9df6-53c0c90fefa0": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "AdCampaign.AdAccountCurrency"
												},
												"isAggregative": false,
												"dataValueType": 1,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 1,
														"value": "USD"
													}
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "AdCampaignDailyInsights"
									},
									"filterAttributes": [
										{
											"attribute": "DateRangeQuickFilter_ContactsIndicatorWidget_c4e4dab2c954a43a54be7fee7cbb877e",
											"loadOnChange": true
										}
									]
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
										"attributePath": "AdCampaign",
										"relationPath": "PDS.Id"
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
							"entitySchemaName": "AdCampaign",
							"attributes": {
								"CampaignName": {
									"path": "CampaignName"
								},
								"Platform": {
									"path": "Platform"
								},
								"Status": {
									"path": "Status"
								},
								"PrimaryAmountSpent": {
									"path": "PrimaryAmountSpent"
								},
								"AdAccountCurrency": {
									"path": "AdAccountCurrency"
								},
								"Impressions": {
									"path": "Impressions"
								},
								"Clicks": {
									"path": "Clicks"
								},
								"CPM": {
									"path": "CPM"
								},
								"CTR": {
									"path": "CTR"
								},
								"CPC": {
									"path": "CPC"
								}
							}
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
				"parentName": "DataGridContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "move",
				"name": "ClicksTab",
				"parentName": "ChartsTabPanel",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"Items": {
					"viewModelConfig": {
						"attributes": {
							"PDS_Submissions": {
								"modelConfig": {
									"path": "PDS.Submissions"
								}
							},
							"PDS_CostPerSubmission": {
								"modelConfig": {
									"path": "PDS.CostPerSubmission"
								}
							},
							"PDS_Contacts": {
								"modelConfig": {
									"path": "PDS.Contacts"
								}
							},
							"PDS_CostPerContact": {
								"modelConfig": {
									"path": "PDS.CostPerContact"
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
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