define('%AppCode%_HomePage', /**SCHEMA_DEPS*/ [] /**SCHEMA_DEPS*/, function /**SCHEMA_ARGS*/ () /**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/ [
			{
				operation: 'insert',
				name: 'IndicatorWidget_29uq73w',
				values: {
					layoutConfig: {
						column: 1,
						row: 1,
						colSpan: 3,
						rowSpan: 2,
					},
					type: 'crt.IndicatorWidget',
					config: {
						title: '#ResourceString(IndicatorWidget_29uq73w_title)#',
						data: {
							providing: {
								schemaName: 'Activity',
								aggregation: {
									column: {
										expression: {
											expressionType: 1,
											functionType: 2,
											aggregationType: 1,
											aggregationEvalType: 2,
											functionArgument: {
												expressionType: 0,
												columnPath: 'Id',
											},
										},
									},
								},
								filters: {
									filter: {
										items: {
											'e752b6d2-fa68-4f6e-a54f-55aa34f38b9c':
												{
													filterType: 4,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: false,
													leftExpression: {
														expressionType: 0,
														columnPath:
															'ActivityCategory',
													},
													isAggregative: false,
													dataValueType: 10,
													referenceSchemaName:
														'ActivityCategory',
													rightExpressions: [
														{
															expressionType: 2,
															parameter: {
																dataValueType: 10,
																value: {
																	Name: 'Meeting',
																	Id: '42c74c49-58e6-df11-971b-001d60e938c6',
																	value: '42c74c49-58e6-df11-971b-001d60e938c6',
																	displayValue:
																		'Meeting',
																},
															},
														},
													],
												},
											'f9b3340b-5e52-4e73-bd10-8fe373f2d9a1':
												{
													filterType: 1,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: true,
													leftExpression: {
														expressionType: 0,
														columnPath: 'StartDate',
													},
													isAggregative: false,
													dataValueType: 7,
													rightExpression: {
														expressionType: 1,
														functionType: 1,
														macrosType: 4,
													},
												},
										},
										logicalOperation: 0,
										isEnabled: true,
										filterType: 6,
										rootSchemaName: 'Activity',
									},
								},
							},
							formatting: {
								type: 'number',
								decimalSeparator: '.',
								decimalPrecision: 0,
								thousandSeparator: ',',
							},
						},
						text: {
							template:
								'#ResourceString(IndicatorWidget_29uq73w_template)#',
							metricMacros: '{0}',
							fontSizeMode: 'medium',
						},
						layout: {
							color: 'bright-red',
						},
						theme: 'full-fill',
					},
					selected: true,
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'IndicatorWidget_u2e631r',
				values: {
					layoutConfig: {
						column: 4,
						colSpan: 3,
						rowSpan: 2,
						row: 1,
					},
					type: 'crt.IndicatorWidget',
					config: {
						title: '#ResourceString(IndicatorWidget_u2e631r_title)#',
						data: {
							providing: {
								schemaName: 'Activity',
								aggregation: {
									column: {
										expression: {
											expressionType: 1,
											functionType: 2,
											aggregationType: 1,
											aggregationEvalType: 2,
											functionArgument: {
												expressionType: 0,
												columnPath: 'Id',
											},
										},
									},
								},
								filters: {
									filter: {
										items: {
											'e752b6d2-fa68-4f6e-a54f-55aa34f38b9c':
												{
													filterType: 4,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: false,
													leftExpression: {
														expressionType: 0,
														columnPath:
															'ActivityCategory',
													},
													isAggregative: false,
													dataValueType: 10,
													referenceSchemaName:
														'ActivityCategory',
													rightExpressions: [
														{
															expressionType: 2,
															parameter: {
																dataValueType: 10,
																value: {
																	Name: 'Meeting',
																	Id: '42c74c49-58e6-df11-971b-001d60e938c6',
																	value: '42c74c49-58e6-df11-971b-001d60e938c6',
																	displayValue:
																		'Meeting',
																},
															},
														},
													],
												},
											'27849a34-f6fd-4652-b7c0-ae1193ff375a':
												{
													filterType: 1,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: true,
													leftExpression: {
														expressionType: 0,
														columnPath: 'StartDate',
													},
													isAggregative: false,
													dataValueType: 7,
													rightExpression: {
														expressionType: 1,
														functionType: 1,
														macrosType: 4,
													},
												},
										},
										logicalOperation: 0,
										isEnabled: true,
										filterType: 6,
										rootSchemaName: 'Activity',
									},
								},
							},
							formatting: {
								type: 'number',
								decimalSeparator: '.',
								decimalPrecision: 0,
								thousandSeparator: ',',
							},
						},
						text: {
							template:
								'#ResourceString(IndicatorWidget_u2e631r_template)#',
							metricMacros: '{0}',
							fontSizeMode: 'medium',
						},
						layout: {
							color: 'bright-red',
						},
						theme: 'full-fill',
					},
					selected: true,
					dragging: false,
					currentLayoutConfig: {
						column: 4,
						row: 1,
						rowSpan: 2,
						colSpan: 3,
					},
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 1,
			},
			{
				operation: 'insert',
				name: 'IndicatorWidget_0nzarb5',
				values: {
					layoutConfig: {
						column: 7,
						colSpan: 3,
						rowSpan: 2,
						row: 1,
					},
					type: 'crt.IndicatorWidget',
					config: {
						title: '#ResourceString(IndicatorWidget_0nzarb5_title)#',
						data: {
							providing: {
								schemaName: 'Activity',
								aggregation: {
									column: {
										expression: {
											expressionType: 1,
											functionType: 2,
											aggregationType: 1,
											aggregationEvalType: 2,
											functionArgument: {
												expressionType: 0,
												columnPath: 'Id',
											},
										},
									},
								},
								filters: {
									filter: {
										items: {
											'dc1a0533-087d-48fd-acb4-b8adfd31874a':
												{
													filterType: 1,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: false,
													leftExpression: {
														expressionType: 0,
														columnPath: 'Owner',
													},
													isAggregative: false,
													dataValueType: 10,
													referenceSchemaName:
														'Contact',
													rightExpression: {
														expressionType: 1,
														functionType: 1,
														macrosType: 2,
													},
												},
											'7b758df3-827f-46ab-b673-eb6069e32df3':
												{
													filterType: 4,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: false,
													leftExpression: {
														expressionType: 0,
														columnPath: 'Status',
													},
													isAggregative: false,
													dataValueType: 10,
													referenceSchemaName:
														'ActivityStatus',
													rightExpressions: [
														{
															expressionType: 2,
															parameter: {
																dataValueType: 10,
																value: {
																	Name: 'Completed',
																	Id: '4bdbb88f-58e6-df11-971b-001d60e938c6',
																	value: '4bdbb88f-58e6-df11-971b-001d60e938c6',
																	displayValue:
																		'Completed',
																},
															},
														},
													],
												},
											'3552ad36-f3ff-4825-835c-4c8ee2978bfa':
												{
													items: {
														'116a6cc3-96ee-47e9-94ba-1f486f8ceabb':
															{
																filterType: 1,
																comparisonType: 3,
																isEnabled: true,
																trimDateTimeParameterToDate: true,
																leftExpression:
																	{
																		expressionType: 0,
																		columnPath:
																			'StartDate',
																	},
																isAggregative: false,
																dataValueType: 7,
																rightExpression:
																	{
																		expressionType: 1,
																		functionType: 1,
																		macrosType: 7,
																	},
															},
														'3fb52290-5aca-42cc-9a71-41dc36577119':
															{
																filterType: 1,
																comparisonType: 3,
																isEnabled: true,
																trimDateTimeParameterToDate: true,
																leftExpression:
																	{
																		expressionType: 0,
																		columnPath:
																			'DueDate',
																	},
																isAggregative: false,
																dataValueType: 7,
																rightExpression:
																	{
																		expressionType: 1,
																		functionType: 1,
																		macrosType: 7,
																	},
															},
													},
													logicalOperation: 1,
													isEnabled: true,
													filterType: 6,
													rootSchemaName: 'Activity',
													key: '3552ad36-f3ff-4825-835c-4c8ee2978bfa',
												},
										},
										logicalOperation: 0,
										isEnabled: true,
										filterType: 6,
										rootSchemaName: 'Activity',
									},
								},
							},
							formatting: {
								type: 'number',
								decimalSeparator: '.',
								decimalPrecision: 0,
								thousandSeparator: ',',
							},
						},
						text: {
							template:
								'#ResourceString(IndicatorWidget_0nzarb5_template)#',
							metricMacros: '{0}',
							fontSizeMode: 'medium',
						},
						layout: {
							color: 'bright-red',
						},
						theme: 'full-fill',
					},
					selected: true,
					dragging: false,
					currentLayoutConfig: {
						column: 4,
						row: 1,
						rowSpan: 2,
						colSpan: 3,
					},
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 2,
			},
			{
				operation: 'insert',
				name: 'IndicatorWidget_lxqxrkr',
				values: {
					layoutConfig: {
						column: 10,
						colSpan: 3,
						rowSpan: 2,
						row: 1,
					},
					type: 'crt.IndicatorWidget',
					config: {
						title: '#ResourceString(IndicatorWidget_lxqxrkr_title)#',
						data: {
							providing: {
								schemaName: 'Activity',
								aggregation: {
									column: {
										expression: {
											expressionType: 1,
											functionType: 2,
											aggregationType: 1,
											aggregationEvalType: 2,
											functionArgument: {
												expressionType: 0,
												columnPath: 'Id',
											},
										},
									},
								},
								filters: {
									filter: {
										items: {
											'e752b6d2-fa68-4f6e-a54f-55aa34f38b9c':
												{
													filterType: 4,
													comparisonType: 3,
													isEnabled: true,
													trimDateTimeParameterToDate: false,
													leftExpression: {
														expressionType: 0,
														columnPath: 'Status',
													},
													isAggregative: false,
													dataValueType: 10,
													referenceSchemaName:
														'ActivityStatus',
													rightExpressions: [
														{
															expressionType: 2,
															parameter: {
																dataValueType: 10,
																value: {
																	Name: 'Not started',
																	Id: '384d4b84-58e6-df11-971b-001d60e938c6',
																	value: '384d4b84-58e6-df11-971b-001d60e938c6',
																	displayValue:
																		'Not started',
																},
															},
														},
														{
															expressionType: 2,
															parameter: {
																dataValueType: 10,
																value: {
																	Name: 'In progress',
																	Id: '394d4b84-58e6-df11-971b-001d60e938c6',
																	value: '394d4b84-58e6-df11-971b-001d60e938c6',
																	displayValue:
																		'In progress',
																},
															},
														},
													],
												},
											'27849a34-f6fd-4652-b7c0-ae1193ff375a':
												{
													filterType: 1,
													comparisonType: 5,
													isEnabled: true,
													trimDateTimeParameterToDate: true,
													leftExpression: {
														expressionType: 0,
														columnPath: 'DueDate',
													},
													isAggregative: false,
													dataValueType: 7,
													rightExpression: {
														expressionType: 1,
														functionType: 1,
														macrosType: 21,
													},
												},
										},
										logicalOperation: 0,
										isEnabled: true,
										filterType: 6,
										rootSchemaName: 'Activity',
									},
								},
							},
							formatting: {
								type: 'number',
								decimalSeparator: '.',
								decimalPrecision: 0,
								thousandSeparator: ',',
							},
						},
						text: {
							template:
								'#ResourceString(IndicatorWidget_lxqxrkr_template)#',
							metricMacros: '{0}',
							fontSizeMode: 'medium',
						},
						layout: {
							color: 'bright-red',
						},
						theme: 'full-fill',
					},
					selected: true,
					dragging: false,
					currentLayoutConfig: {
						column: 4,
						row: 1,
						rowSpan: 2,
						colSpan: 3,
					},
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 3,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanel_0btdkfz',
				values: {
					layoutConfig: {
						column: 1,
						row: 3,
						colSpan: 6,
						rowSpan: 4,
					},
					type: 'crt.ExpansionPanel',
					items: [],
					title: '#ResourceString(ExpansionPanel_0btdkfz_title)#',
					toggleType: 'default',
					togglePosition: 'before',
					expanded: true,
					labelColor: '#004fd6',
					fullWidthHeader: true,
					titleWidth: '90',
					tools: [],
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 4,
			},
			{
				operation: 'insert',
				name: 'GridContainer_0676vwe',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 32px)',
					columns: ['minmax(64px, 1fr)', 'minmax(64px, 1fr)'],
					gridContainerType: 'expansionPanelContent',
					gap: {
						columnGap: 24,
						rowGap: 0,
					},
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName: 'ExpansionPanel_0btdkfz',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'DataGrid_mmsxe5n',
				values: {
					layoutConfig: {
						column: 1,
						row: 1,
						colSpan: 2,
						rowSpan: 6,
					},
					type: 'crt.DataGrid',
					items: '$DataGrid_mmsxe5n',
					primaryColumnName: 'DataGrid_mmsxe5nDS_Id',
					columns: [
						{
							id: '5218abf5-c699-c9d6-0257-23e4b42f3eab',
							code: 'DataGrid_mmsxe5nDS_Title',
							caption:
								'#ResourceString(DataGrid_mmsxe5nDS_Title)#',
							dataValueType: 30,
							width: 264.921875,
						},
						{
							id: 'ae2c8c51-48ce-20de-0d23-2959835bf3a9',
							code: 'DataGrid_mmsxe5nDS_DueDate',
							caption:
								'#ResourceString(DataGrid_mmsxe5nDS_DueDate)#',
							dataValueType: 7,
							width: 135.984375,
						},
					],
					selected: true,
				},
				parentName: 'GridContainer_0676vwe',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'GridContainer_xfqm28d',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 24px)',
					gridContainerType: 'expansionPanelTools',
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName: 'ExpansionPanel_0btdkfz',
				propertyName: 'tools',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'GridContainer_435tavt',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 12px)',
					columns: ['minmax(32px, 1fr)'],
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName: 'GridContainer_xfqm28d',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'FlexContainer_hu4e1uo',
				values: {
					type: 'crt.FlexContainer',
					direction: 'row',
					items: [],
					layoutConfig: {
						colSpan: 1,
						column: 1,
						row: 1,
						rowSpan: 1,
					},
				},
				parentName: 'GridContainer_435tavt',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanel_bvcq8v0',
				values: {
					layoutConfig: {
						column: 7,
						row: 3,
						colSpan: 6,
						rowSpan: 4,
					},
					type: 'crt.ExpansionPanel',
					items: [],
					title: '#ResourceString(ExpansionPanel_bvcq8v0_title)#',
					toggleType: 'default',
					togglePosition: 'before',
					expanded: true,
					labelColor: '#004fd6',
					fullWidthHeader: true,
					titleWidth: '90',
					tools: [],
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 5,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanelGridContainer_d6e63326-3d3b-8d4c-d854-499191c0d6a6',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 32px)',
					columns: ['minmax(64px, 1fr)', 'minmax(64px, 1fr)'],
					gridContainerType: 'expansionPanelContent',
					gap: {
						columnGap: 24,
						rowGap: 0,
					},
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName: 'ExpansionPanel_bvcq8v0',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'DataGrid_4n8e7js',
				values: {
					layoutConfig: {
						column: 1,
						row: 1,
						colSpan: 2,
						rowSpan: 6,
					},
					type: 'crt.DataGrid',
					items: '$DataGrid_4n8e7js',
					primaryColumnName: 'DataGrid_4n8e7jsDS_Id',
					columns: [
						{
							id: 'fd198821-b1af-2005-0d81-3c9c745afd8a',
							code: 'DataGrid_4n8e7jsDS_Title',
							caption:
								'#ResourceString(DataGrid_4n8e7jsDS_Title)#',
							dataValueType: 30,
							width: 284.9305725097656,
						},
						{
							id: '75b10aa3-6cd1-5373-65bc-0cde4ba3e240',
							code: 'DataGrid_4n8e7jsDS_DueDate',
							caption:
								'#ResourceString(DataGrid_4n8e7jsDS_DueDate)#',
							dataValueType: 7,
							width: 166.98958587646484,
						},
					],
					selected: true,
				},
				parentName:
					'ExpansionPanelGridContainer_d6e63326-3d3b-8d4c-d854-499191c0d6a6',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanelToolsGridContainer_c2029885-5988-c6cc-57ec-4ee1fb0fd72d',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 24px)',
					gridContainerType: 'expansionPanelTools',
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName: 'ExpansionPanel_bvcq8v0',
				propertyName: 'tools',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanelToolsInnerGridContainer_be31a5a8-36b9-175a-73ff-8390ce9f46b2',
				values: {
					type: 'crt.GridContainer',
					rows: 'minmax(max-content, 12px)',
					columns: ['minmax(32px, 1fr)'],
					styles: {
						'overflow-x': 'hidden',
					},
					items: [],
				},
				parentName:
					'ExpansionPanelToolsGridContainer_c2029885-5988-c6cc-57ec-4ee1fb0fd72d',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'ExpansionPanelToolsInnerFlexContainer_8066c266-e2b4-f108-9110-1b3787fa5811',
				values: {
					type: 'crt.FlexContainer',
					direction: 'row',
					items: [],
					layoutConfig: {
						colSpan: 1,
						column: 1,
						row: 1,
						rowSpan: 1,
					},
				},
				parentName:
					'ExpansionPanelToolsInnerGridContainer_be31a5a8-36b9-175a-73ff-8390ce9f46b2',
				propertyName: 'items',
				index: 0,
			},
			{
				operation: 'insert',
				name: 'ChartWidget_n11hrz9',
				values: {
					layoutConfig: {
						column: 1,
						row: 7,
						colSpan: 6,
						rowSpan: 4,
					},
					type: 'crt.ChartWidget',
					config: {
						title: '#ResourceString(ChartWidget_n11hrz9_title)#',
						color: 'orange-red',
						theme: 'partial-fill',
						scales: {
							stacked: false,
							xAxis: {
								name: '',
								formatting: {
									type: 'string',
									maxLinesCount: 2,
									maxLineLength: 10,
								},
							},
							yAxis: {
								name: '',
								formatting: {
									type: 'number',
									thousandAbbreviation: {
										enabled: true,
									},
								},
							},
						},
						series: [
							{
								type: 'doughnut',
								label: '#ResourceString(ChartWidget_n11hrz9_series_0)#',
								legend: {
									enabled: false,
								},
								data: {
									providing: {
										schemaName: 'Activity',
										rowCount: 50,
										grouping: {
											column: {
												expression: {
													expressionType: 0,
													columnPath: 'Status',
												},
											},
											type: 'by-value',
										},
										aggregation: {
											column: {
												expression: {
													expressionType: 1,
													functionType: 2,
													aggregationType: 1,
													aggregationEvalType: 2,
													functionArgument: {
														expressionType: 0,
														columnPath: 'Id',
													},
												},
											},
										},
										filters: {
											filter: {
												items: {
													'3b27de58-9835-4e4d-9c53-73eb64eb934a':
														{
															filterType: 1,
															comparisonType: 3,
															isEnabled: true,
															trimDateTimeParameterToDate: false,
															leftExpression: {
																expressionType: 0,
																columnPath:
																	'Owner',
															},
															isAggregative: false,
															dataValueType: 10,
															referenceSchemaName:
																'Contact',
															rightExpression: {
																expressionType: 1,
																functionType: 1,
																macrosType: 2,
															},
														},
													'ecb728b7-5c1f-44c5-8028-5f84e8ee47f0':
														{
															filterType: 1,
															comparisonType: 3,
															isEnabled: true,
															trimDateTimeParameterToDate: true,
															leftExpression: {
																expressionType: 0,
																columnPath:
																	'StartDate',
															},
															isAggregative: false,
															dataValueType: 7,
															rightExpression: {
																expressionType: 1,
																functionType: 1,
																macrosType: 4,
															},
														},
													columnIsNotNullFilter: {
														comparisonType: 2,
														filterType: 2,
														isEnabled: true,
														isNull: false,
														trimDateTimeParameterToDate: false,
														leftExpression: {
															expressionType: 0,
															columnPath:
																'Status',
														},
													},
												},
												logicalOperation: 0,
												isEnabled: true,
												filterType: 6,
												rootSchemaName: 'Activity',
											},
										},
									},
									formatting: {
										type: 'number',
										decimalSeparator: '.',
										thousandSeparator: ',',
									},
								},
							},
						],
						seriesOrder: {
							type: 'by-grouping-value',
							direction: 2,
						},
					},
					selected: true,
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 6,
			},
			{
				operation: 'insert',
				name: 'ChartWidget_n7o7jd1',
				values: {
					layoutConfig: {
						column: 7,
						colSpan: 6,
						rowSpan: 4,
						row: 7,
					},
					type: 'crt.ChartWidget',
					config: {
						title: '#ResourceString(ChartWidget_n7o7jd1_title)#',
						color: 'orange-red',
						theme: 'partial-fill',
						scales: {
							stacked: false,
							xAxis: {
								name: '',
								formatting: {
									type: 'string',
									maxLinesCount: 2,
									maxLineLength: 10,
								},
							},
							yAxis: {
								name: '',
								formatting: {
									type: 'number',
									thousandAbbreviation: {
										enabled: true,
									},
								},
							},
						},
						series: [
							{
								color: 'bright-red',
								type: 'line',
								label: '#ResourceString(ChartWidget_n7o7jd1_series_0)#',
								legend: {
									enabled: false,
								},
								data: {
									providing: {
										schemaName: 'Activity',
										rowCount: 50,
										grouping: {
											column: [
												{
													isVisible: true,
													expression: {
														functionType: 3,
														datePartType: 1,
														expressionType: 1,
														functionArgument: {
															columnPath:
																'DueDate',
															expressionType: 0,
														},
													},
												},
												{
													isVisible: true,
													expression: {
														functionType: 3,
														datePartType: 3,
														expressionType: 1,
														functionArgument: {
															columnPath:
																'DueDate',
															expressionType: 0,
														},
													},
												},
											],
											type: 'by-date-part',
										},
										aggregation: {
											column: {
												expression: {
													expressionType: 1,
													functionType: 2,
													aggregationType: 1,
													aggregationEvalType: 2,
													functionArgument: {
														expressionType: 0,
														columnPath: 'Id',
													},
												},
											},
										},
										filters: {
											filter: {
												items: {
													'3b27de58-9835-4e4d-9c53-73eb64eb934a':
														{
															filterType: 1,
															comparisonType: 3,
															isEnabled: true,
															trimDateTimeParameterToDate: false,
															leftExpression: {
																expressionType: 0,
																columnPath:
																	'Owner',
															},
															isAggregative: false,
															dataValueType: 10,
															referenceSchemaName:
																'Contact',
															rightExpression: {
																expressionType: 1,
																functionType: 1,
																macrosType: 2,
															},
														},
													'2ffbadaf-a042-482e-8849-ba8f42f924b3':
														{
															items: {
																'ecb728b7-5c1f-44c5-8028-5f84e8ee47f0':
																	{
																		filterType: 1,
																		comparisonType: 3,
																		isEnabled: true,
																		trimDateTimeParameterToDate: true,
																		leftExpression:
																			{
																				expressionType: 0,
																				columnPath:
																					'StartDate',
																			},
																		isAggregative: false,
																		dataValueType: 7,
																		rightExpression:
																			{
																				expressionType: 1,
																				functionType: 1,
																				functionArgument:
																					{
																						expressionType: 2,
																						parameter:
																							{
																								dataValueType: 4,
																								value: 30,
																							},
																					},
																				macrosType: 25,
																			},
																	},
																'e572f0d6-f6f2-49c7-9e4b-ec146232d082':
																	{
																		filterType: 1,
																		comparisonType: 3,
																		isEnabled: true,
																		trimDateTimeParameterToDate: true,
																		leftExpression:
																			{
																				expressionType: 0,
																				columnPath:
																					'StartDate',
																			},
																		isAggregative: false,
																		dataValueType: 7,
																		rightExpression:
																			{
																				expressionType: 1,
																				functionType: 1,
																				macrosType: 4,
																			},
																	},
															},
															logicalOperation: 1,
															isEnabled: true,
															filterType: 6,
															rootSchemaName:
																'Activity',
															key: '2ffbadaf-a042-482e-8849-ba8f42f924b3',
														},
													columnIsNotNullFilter: {
														comparisonType: 2,
														filterType: 2,
														isEnabled: true,
														isNull: false,
														trimDateTimeParameterToDate: false,
														leftExpression: {
															expressionType: 0,
															columnPath:
																'DueDate',
														},
													},
												},
												logicalOperation: 0,
												isEnabled: true,
												filterType: 6,
												rootSchemaName: 'Activity',
											},
										},
									},
									formatting: {
										type: 'number',
										decimalSeparator: '.',
										thousandSeparator: ',',
									},
								},
							},
						],
						seriesOrder: {
							type: 'by-grouping-value',
							direction: 2,
						},
					},
					selected: true,
					dragging: false,
					currentLayoutConfig: {
						column: 7,
						row: 10,
						rowSpan: 4,
						colSpan: 6,
					},
				},
				parentName: 'Main',
				propertyName: 'items',
				index: 7,
			},
		] /**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/ {
			attributes: {
				DataGrid_4n8e7js: {
					isCollection: true,
					modelConfig: {
						path: 'DataGrid_4n8e7jsDS',
						sortingConfig: {
							default: [
								{
									direction: 'asc',
									columnName: 'DueDate',
								},
							],
						},
						filterAttributes: [
							{
								loadOnChange: true,
								name: 'DataGrid_4n8e7js_PredefinedFilter',
							},
						],
					},
					viewModelConfig: {
						attributes: {
							DataGrid_4n8e7jsDS_Title: {
								modelConfig: {
									path: 'DataGrid_4n8e7jsDS.Title',
								},
							},
							DataGrid_4n8e7jsDS_DueDate: {
								modelConfig: {
									path: 'DataGrid_4n8e7jsDS.DueDate',
								},
							},
							DataGrid_4n8e7jsDS_Id: {
								modelConfig: {
									path: 'DataGrid_4n8e7jsDS.Id',
								},
							},
						},
					},
				},
				DataGrid_4n8e7js_PredefinedFilter: {
					value: {
						items: {
							'23b6a76d-66d4-43af-9106-b94b2c774ef9': {
								filterType: 1,
								comparisonType: 5,
								isEnabled: true,
								trimDateTimeParameterToDate: true,
								leftExpression: {
									expressionType: 0,
									columnPath: 'DueDate',
								},
								isAggregative: false,
								dataValueType: 7,
								rightExpression: {
									expressionType: 1,
									functionType: 1,
									macrosType: 21,
								},
							},
							'22848e2d-de7a-4f2c-a60e-006c344c69f5': {
								filterType: 1,
								comparisonType: 3,
								isEnabled: true,
								trimDateTimeParameterToDate: false,
								leftExpression: {
									expressionType: 0,
									columnPath: 'Owner',
								},
								isAggregative: false,
								dataValueType: 10,
								referenceSchemaName: 'Contact',
								rightExpression: {
									expressionType: 1,
									functionType: 1,
									macrosType: 2,
								},
							},
							'd8e1a569-7d96-4ede-9031-803cec5c5c2e': {
								filterType: 4,
								comparisonType: 3,
								isEnabled: true,
								trimDateTimeParameterToDate: false,
								leftExpression: {
									expressionType: 0,
									columnPath: 'Status',
								},
								isAggregative: false,
								dataValueType: 10,
								referenceSchemaName: 'ActivityStatus',
								rightExpressions: [
									{
										expressionType: 2,
										parameter: {
											dataValueType: 10,
											value: {
												Name: 'Not started',
												Id: '384d4b84-58e6-df11-971b-001d60e938c6',
												value: '384d4b84-58e6-df11-971b-001d60e938c6',
												displayValue: 'Not started',
											},
										},
									},
									{
										expressionType: 2,
										parameter: {
											dataValueType: 10,
											value: {
												Name: 'In progress',
												Id: '394d4b84-58e6-df11-971b-001d60e938c6',
												value: '394d4b84-58e6-df11-971b-001d60e938c6',
												displayValue: 'In progress',
											},
										},
									},
								],
							},
						},
						logicalOperation: 0,
						isEnabled: true,
						filterType: 6,
						rootSchemaName: 'Activity',
					},
				},
				DataGrid_mmsxe5n: {
					isCollection: true,
					modelConfig: {
						path: 'DataGrid_mmsxe5nDS',
						filterAttributes: [
							{
								loadOnChange: true,
								name: 'DataGrid_mmsxe5n_PredefinedFilter',
							},
						],
						sortingConfig: {
							default: [
								{
									direction: 'asc',
									columnName: 'DueDate',
								},
							],
						},
					},
					viewModelConfig: {
						attributes: {
							DataGrid_mmsxe5nDS_Title: {
								modelConfig: {
									path: 'DataGrid_mmsxe5nDS.Title',
								},
							},
							DataGrid_mmsxe5nDS_DueDate: {
								modelConfig: {
									path: 'DataGrid_mmsxe5nDS.DueDate',
								},
							},
							DataGrid_mmsxe5nDS_Id: {
								modelConfig: {
									path: 'DataGrid_mmsxe5nDS.Id',
								},
							},
						},
					},
				},
				DataGrid_mmsxe5n_PredefinedFilter: {
					value: {
						items: {
							'41ad0901-6000-4234-b5bc-62d3a3fde528': {
								filterType: 1,
								comparisonType: 3,
								isEnabled: true,
								trimDateTimeParameterToDate: false,
								leftExpression: {
									expressionType: 0,
									columnPath: 'Owner',
								},
								isAggregative: false,
								dataValueType: 10,
								referenceSchemaName: 'Contact',
								rightExpression: {
									expressionType: 1,
									functionType: 1,
									macrosType: 2,
								},
							},
							'41e7ae71-2e03-4de1-b6f2-850dfc1e5e22': {
								filterType: 1,
								comparisonType: 3,
								isEnabled: true,
								trimDateTimeParameterToDate: true,
								leftExpression: {
									expressionType: 0,
									columnPath: 'StartDate',
								},
								isAggregative: false,
								dataValueType: 7,
								rightExpression: {
									expressionType: 1,
									functionType: 1,
									macrosType: 4,
								},
							},
							'e5411c30-5746-48b6-ab4a-5b08a60718b3': {
								filterType: 4,
								comparisonType: 3,
								isEnabled: true,
								trimDateTimeParameterToDate: false,
								leftExpression: {
									expressionType: 0,
									columnPath: 'Status',
								},
								isAggregative: false,
								dataValueType: 10,
								referenceSchemaName: 'ActivityStatus',
								rightExpressions: [
									{
										expressionType: 2,
										parameter: {
											dataValueType: 10,
											value: {
												Name: 'Not started',
												Id: '384d4b84-58e6-df11-971b-001d60e938c6',
												value: '384d4b84-58e6-df11-971b-001d60e938c6',
												displayValue: 'Not started',
											},
										},
									},
									{
										expressionType: 2,
										parameter: {
											dataValueType: 10,
											value: {
												Name: 'In progress',
												Id: '394d4b84-58e6-df11-971b-001d60e938c6',
												value: '394d4b84-58e6-df11-971b-001d60e938c6',
												displayValue: 'In progress',
											},
										},
									},
								],
							},
						},
						logicalOperation: 0,
						isEnabled: true,
						filterType: 6,
						rootSchemaName: 'Activity',
					},
				},
				FolderTree_cuczhs5_visible: {
					value: true,
				},
				FolderTree_cuczhs5_items: {
					isCollection: true,
					viewModelConfig: {
						attributes: {
							Id: {},
							Name: {},
							ParentId: {},
							FilterData: {},
						},
					},
				},
				FolderTree_cuczhs5_active_folder_id: {},
				FolderTree_cuczhs5_active_folder_name: {},
				FolderTree_cuczhs5_active_folder_filter: {
					value: {},
				},
			},
		} /**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/ {
			dataSources: {
				DataGrid_4n8e7jsDS: {
					type: 'crt.EntityDataSource',
					hiddenInPageDesigner: true,
					config: {
						entitySchemaName: 'Activity',
					},
				},
				DataGrid_mmsxe5nDS: {
					type: 'crt.EntityDataSource',
					hiddenInPageDesigner: true,
					config: {
						entitySchemaName: 'Activity',
					},
				},
			},
		} /**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/ [] /**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/ {} /**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/ {} /**SCHEMA_VALIDATORS*/,
	};
});
