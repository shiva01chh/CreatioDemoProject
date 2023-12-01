define("MarketingDesktop", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "GridContainer_nfkykjp",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 8,
						"rowSpan": 1
					},
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "medium",
						"left": "none"
					}
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "MrktHelloLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(MrktHelloLabel_caption)#)#",
					"labelType": "large-2",
					"labelThickness": "light",
					"labelEllipsis": false,
					"labelColor": "#FFFFFF",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true,
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					}
				},
				"parentName": "GridContainer_nfkykjp",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SpentBudgetIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 4,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(SpentBudgetIndicatorWidget_title)#",
						"data": {
							"providing": {
								"schemaName": "MktgActivity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "PrimarySpentBudget"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"d288c479-cd67-4b67-a20a-59eab7da5c62": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "StartDate"
												},
												"isAggregative": false,
												"dataValueType": 8,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 10
												}
											},
											"d81544d2-5fe7-4d7b-a375-33b282e02ccc": {
												"filterType": 1,
												"comparisonType": 8,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "StartDate"
												},
												"isAggregative": false,
												"dataValueType": 8,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"functionArgument": {
														"expressionType": 2,
														"parameter": {
															"dataValueType": 4,
															"value": 30
														}
													},
													"macrosType": 25
												}
											}
										},
										"logicalOperation": 1,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "MktgActivity"
									}
								},
								"sectionBindingColumn": {}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ",",
								"decimalPrecision": 0,
								"thousandSeparator": " "
							}
						},
						"text": {
							"template": "#ResourceString(SpentBudgetIndicatorWidget_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "transparent"
						},
						"theme": "glassmorphism"
					},
					"visible": true
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadsIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 5,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(LeadsIndicatorWidget_title)#",
						"data": {
							"providing": {
								"schemaName": "Lead",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 1,
											"aggregationEvalType": 2,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Id"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"db6a1922-1b81-493e-9dbc-45e90fed9d1a": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 10
												}
											},
											"76aa5ebf-9730-41d5-8934-eb13c268c77f": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "CreatedOn"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"functionArgument": {
														"expressionType": 2,
														"parameter": {
															"dataValueType": 4,
															"value": 30
														}
													},
													"macrosType": 25
												}
											}
										},
										"logicalOperation": 1,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Lead"
									}
								},
								"sectionBindingColumn": {}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(LeadsIndicatorWidget_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "transparent"
						},
						"theme": "glassmorphism"
					},
					"visible": true
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "MqlLeadsIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 7,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(MqlLeadsIndicatorWidget_title)#",
						"data": {
							"providing": {
								"schemaName": "Lead",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 1,
											"aggregationEvalType": 2,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Id"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"a83bcb5f-a02a-4653-b085-98ae9f162027": {
												"filterType": 4,
												"comparisonType": 4,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "QualifyStatus"
												},
												"isAggregative": false,
												"dataValueType": 10,
												"referenceSchemaName": "QualifyStatus",
												"rightExpressions": [
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Disqualified",
																"Id": "128c3718-771a-4d1e-9035-6fa135ca5f70",
																"value": "128c3718-771a-4d1e-9035-6fa135ca5f70",
																"displayValue": "Disqualified"
															}
														}
													},
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Qualification",
																"Id": "d790a45d-03ff-4ddb-9dea-8087722c582c",
																"value": "d790a45d-03ff-4ddb-9dea-8087722c582c",
																"displayValue": "Qualification"
															}
														}
													},
													{
														"expressionType": 2,
														"parameter": {
															"dataValueType": 10,
															"value": {
																"Name": "Not interested",
																"Id": "51adc3ec-3503-4b10-a00b-8be3b0e11f08",
																"value": "51adc3ec-3503-4b10-a00b-8be3b0e11f08",
																"displayValue": "Not interested"
															}
														}
													}
												]
											},
											"ae2aa306-0c11-4592-82e7-7ce451bda195": {
												"items": {
													"f4b7ef38-9bc0-4b99-9861-4f0b27fae0e7": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 10
														}
													},
													"feecc935-4f44-4a1a-a51e-7bb71f867ae2": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"functionArgument": {
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 4,
																	"value": 30
																}
															},
															"macrosType": 25
														}
													}
												},
												"logicalOperation": 1,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead",
												"key": "ae2aa306-0c11-4592-82e7-7ce451bda195"
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Lead"
									}
								},
								"sectionBindingColumn": {}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(MqlLeadsIndicatorWidget_template)#",
							"metricMacros": "{0}",
							"fontSizeMode": "medium"
						},
						"layout": {
							"color": "transparent"
						},
						"theme": "glassmorphism"
					},
					"visible": true
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "LeadSourceDynamicChartWidget",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 8,
						"rowSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(LeadSourceDynamicChartWidget_title)#",
						"color": "green",
						"theme": "glassmorphism",
						"scales": {
							"stacked": false,
							"xAxis": {
								"name": "#ResourceString(LeadSourceDynamicChartWidget_xAxis)#",
								"formatting": {
									"type": "string",
									"maxLinesCount": 2,
									"maxLineLength": 10
								}
							},
							"yAxis": {
								"name": "#ResourceString(LeadSourceDynamicChartWidget_yAxis)#",
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
								"color": "orange-red",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Creatio marketing",
																		"Id": "4f7f26f5-facc-47d4-900b-9d9b1eb1c505",
																		"value": "4f7f26f5-facc-47d4-900b-9d9b1eb1c505",
																		"displayValue": "Creatio marketing"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "blue",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Facebook",
																		"Id": "532429b9-5324-407a-9c17-d1fdf4c3abc9",
																		"value": "532429b9-5324-407a-9c17-d1fdf4c3abc9",
																		"displayValue": "Facebook"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "red",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Google",
																		"Id": "a417d1e3-2029-4c17-8e15-c6a586d1a9b7",
																		"value": "a417d1e3-2029-4c17-8e15-c6a586d1a9b7",
																		"displayValue": "Google"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "coral",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_3)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Mailchimp",
																		"Id": "7ea0f0f3-cc41-4516-8ac8-d25f65b18a03",
																		"value": "7ea0f0f3-cc41-4516-8ac8-d25f65b18a03",
																		"displayValue": "Mailchimp"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "light-blue",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_4)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "LinkedIn",
																		"Id": "6c7e2194-0b60-4b1c-a084-20a73d8cb06f",
																		"value": "6c7e2194-0b60-4b1c-a084-20a73d8cb06f",
																		"displayValue": "LinkedIn"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							},
							{
								"color": "light-green",
								"type": "spline",
								"label": "#ResourceString(LeadSourceDynamicChartWidget_series_5)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Lead",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": [
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 3,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												},
												{
													"isVisible": true,
													"expression": {
														"functionType": 3,
														"datePartType": 4,
														"expressionType": 1,
														"functionArgument": {
															"columnPath": "CreatedOn",
															"expressionType": 0
														}
													}
												}
											],
											"type": "by-date-part"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 1,
													"aggregationEvalType": 2,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Id"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ee16d3c3-e31c-4949-af66-9c1993ee6118": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "LeadSource"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "LeadSource",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Другой источник",
																		"Id": "f5e73b24-bd68-45ba-9ec6-dee40a35c615",
																		"value": "f5e73b24-bd68-45ba-9ec6-dee40a35c615",
																		"displayValue": "Другой источник"
																	}
																}
															}
														]
													},
													"2e507ccd-f172-42d1-afcc-977cdf8bb498": {
														"items": {
															"f78a0c6e-0598-43f9-9e67-0e42ceaa11d6": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"macrosType": 16
																}
															},
															"55ef5781-0c35-495d-850d-6e7bfb22aeb3": {
																"filterType": 1,
																"comparisonType": 3,
																"isEnabled": true,
																"trimDateTimeParameterToDate": true,
																"leftExpression": {
																	"expressionType": 0,
																	"columnPath": "CreatedOn"
																},
																"isAggregative": false,
																"dataValueType": 7,
																"rightExpression": {
																	"expressionType": 1,
																	"functionType": 1,
																	"functionArgument": {
																		"expressionType": 2,
																		"parameter": {
																			"dataValueType": 4,
																			"value": 180
																		}
																	},
																	"macrosType": 25
																}
															}
														},
														"logicalOperation": 1,
														"isEnabled": true,
														"filterType": 6,
														"rootSchemaName": "Lead",
														"key": "2e507ccd-f172-42d1-afcc-977cdf8bb498"
													},
													"columnIsNotNullFilter": {
														"comparisonType": 2,
														"filterType": 2,
														"isEnabled": true,
														"isNull": false,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "CreatedOn"
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Lead"
											}
										}
									},
									"formatting": {
										"type": "number",
										"decimalSeparator": ".",
										"decimalPrecision": 0,
										"thousandSeparator": ","
									}
								}
							}
						],
						"seriesOrder": {
							"type": "by-grouping-value",
							"direction": 1
						}
					}
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});