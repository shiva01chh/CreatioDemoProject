Terrasoft.configuration.Structures["SalesEnterpriseDesktop"] = {innerHierarchyStack: ["SalesEnterpriseDesktop"], structureParent: "CentralAreaDesktopTemplate"};
define('SalesEnterpriseDesktopStructure', ['SalesEnterpriseDesktopResources'], function(resources) {return {schemaUId:'d7575135-83c8-4407-91c5-e3782979a051',schemaCaption: "Sales Enterprise Desktop", parentSchemaName: "CentralAreaDesktopTemplate", packageName: "SalesEnterprise", schemaName:'SalesEnterpriseDesktop',parentSchemaUId:'fbc98c89-0691-479c-bc25-59c11ac2365f',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("SalesEnterpriseDesktop", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "TitleFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 8,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "medium",
						"left": "none"
					},
					"justifyContent": "end",
					"alignItems": "stretch",
					"gap": "large",
					"wrap": "nowrap"
				},
				"parentName": "FixedGridSlot_qwe4asds",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GreetingLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(GreetingLabel_caption)#)#",
					"labelType": "large-2",
					"labelThickness": "light",
					"labelEllipsis": false,
					"labelColor": "#FFFFFF",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "TitleFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TotalOpportunityCountIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(TotalOpportunityCountIndicatorWidget_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
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
										"items": {},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
									}
								},
								"sectionBindingColumn": {
									"path": null
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(TotalOpportunityCountIndicatorWidget_template)#",
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
				"name": "OpportunityAmountCurrentMonthIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 3,
						"row": 2,
						"colSpan": 4,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(OpportunityAmountCurrentMonthIndicatorWidget_title)#",
						"data": {
							"providing": {
								"schemaName": "Opportunity",
								"aggregation": {
									"column": {
										"expression": {
											"expressionType": 1,
											"functionType": 2,
											"aggregationType": 2,
											"aggregationEvalType": 0,
											"functionArgument": {
												"expressionType": 0,
												"columnPath": "Amount"
											}
										}
									}
								},
								"filters": {
									"filter": {
										"items": {
											"2d2f06df-f8b8-46bc-ba12-817fc3a49e65": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": true,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "DueDate"
												},
												"isAggregative": false,
												"dataValueType": 7,
												"rightExpression": {
													"expressionType": 1,
													"functionType": 1,
													"macrosType": 10
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Opportunity"
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
							"template": "#ResourceString(OpportunityAmountCurrentMonthIndicatorWidget_template)#",
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
				"name": "OpenLeadsIndicatorWidget",
				"values": {
					"layoutConfig": {
						"column": 7,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 2
					},
					"type": "crt.IndicatorWidget",
					"config": {
						"title": "#ResourceString(OpenLeadsIndicatorWidget_title)#",
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
											"ffa5320b-31fd-4045-9856-155aef64cf6e": {
												"filterType": 1,
												"comparisonType": 3,
												"isEnabled": true,
												"trimDateTimeParameterToDate": false,
												"leftExpression": {
													"expressionType": 0,
													"columnPath": "QualifyStatus.IsFinal"
												},
												"isAggregative": false,
												"dataValueType": 12,
												"rightExpression": {
													"expressionType": 2,
													"parameter": {
														"dataValueType": 12,
														"value": false
													}
												}
											}
										},
										"logicalOperation": 0,
										"isEnabled": true,
										"filterType": 6,
										"rootSchemaName": "Lead"
									}
								},
								"sectionBindingColumn": {
									"path": null
								}
							},
							"formatting": {
								"type": "number",
								"decimalSeparator": ".",
								"decimalPrecision": 0,
								"thousandSeparator": ","
							}
						},
						"text": {
							"template": "#ResourceString(OpenLeadsIndicatorWidget_template)#",
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
				"name": "PlanVsFactBySalesManagerCurrentQuarterChartWidget",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 8,
						"rowSpan": 4
					},
					"type": "crt.ChartWidget",
					"config": {
						"title": "#ResourceString(PlanVsFactBySalesManagerCurrentQuarterChartWidget_title)#",
						"color": "green",
						"theme": "glassmorphism",
						"scales": {
							"stacked": true,
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
								"color": "coral",
								"type": "line",
								"label": "#ResourceString(PlanVsFactBySalesManagerCurrentQuarterChartWidget_series_0)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "ContactForecast",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": {
												"expression": {
													"expressionType": 0,
													"columnPath": "Contact"
												}
											},
											"type": "by-value"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Value"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"8914270f-bf5d-4d00-ab10-b359bda8d4ad": {
														"filterType": 1,
														"comparisonType": 8,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Period.StartDate"
														},
														"isAggregative": false,
														"dataValueType": 8,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 13
														}
													},
													"fc8ba9cb-0e0f-4c65-9f8d-46635f7379c9": {
														"filterType": 1,
														"comparisonType": 6,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Period.DueDate"
														},
														"isAggregative": false,
														"dataValueType": 8,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 13
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "ContactForecast"
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
								"color": "dark-turquoise",
								"type": "bar",
								"label": "#ResourceString(PlanVsFactBySalesManagerCurrentQuarterChartWidget_series_1)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": {
												"expression": {
													"expressionType": 0,
													"columnPath": "Owner"
												}
											},
											"type": "by-value"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Amount"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"ffafcdc8-5558-4cc3-b3f2-f71aecf3384e": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DueDate"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 13
														}
													},
													"97482482-9120-4e2a-9859-508500e5faed": {
														"filterType": 4,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage"
														},
														"isAggregative": false,
														"dataValueType": 10,
														"referenceSchemaName": "OpportunityStage",
														"rightExpressions": [
															{
																"expressionType": 2,
																"parameter": {
																	"dataValueType": 10,
																	"value": {
																		"Name": "Closed won",
																		"Id": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"value": "60d5310c-5be6-df11-971b-001d60e938c6",
																		"displayValue": "Closed won"
																	}
																}
															}
														]
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
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
								"type": "bar",
								"label": "#ResourceString(PlanVsFactBySalesManagerCurrentQuarterChartWidget_series_2)#",
								"legend": {
									"enabled": true
								},
								"data": {
									"providing": {
										"schemaName": "Opportunity",
										"rowCount": 50,
										"sectionBindingColumn": {},
										"grouping": {
											"column": {
												"expression": {
													"expressionType": 0,
													"columnPath": "Owner"
												}
											},
											"type": "by-value"
										},
										"aggregation": {
											"column": {
												"expression": {
													"expressionType": 1,
													"functionType": 2,
													"aggregationType": 2,
													"aggregationEvalType": 0,
													"functionArgument": {
														"expressionType": 0,
														"columnPath": "Amount"
													}
												}
											}
										},
										"filters": {
											"filter": {
												"items": {
													"761157d5-36fb-49b9-85c7-3215aee53ff2": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": true,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "DueDate"
														},
														"isAggregative": false,
														"dataValueType": 7,
														"rightExpression": {
															"expressionType": 1,
															"functionType": 1,
															"macrosType": 13
														}
													},
													"26d91966-6d3b-42dc-baa2-d14e44d77fca": {
														"filterType": 1,
														"comparisonType": 3,
														"isEnabled": true,
														"trimDateTimeParameterToDate": false,
														"leftExpression": {
															"expressionType": 0,
															"columnPath": "Stage.End"
														},
														"isAggregative": false,
														"dataValueType": 12,
														"rightExpression": {
															"expressionType": 2,
															"parameter": {
																"dataValueType": 12,
																"value": false
															}
														}
													}
												},
												"logicalOperation": 0,
												"isEnabled": true,
												"filterType": 6,
												"rootSchemaName": "Opportunity"
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
							"type": "by-aggregation-value",
							"direction": 1,
							"seriesIndex": 0
						}
					},
					"visible": true
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

