define("AddTaskMiniPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "PageTitle"
			},
			{
				"operation": "merge",
				"name": "ContinueInOtherPageButton",
				"values": {
					"visible": "$CardState | crt.IsEqual : 'add'",
					"color": "default"
				}
			},
			{
				"operation": "insert",
				"name": "NewTaskLabel",
				"values": {
					"type": "crt.Label",
					"caption": "$StringAttribute_wc5fiop",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContinueInEditPageButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ContinueInEditPageButton_caption)#",
					"color": "default",
					"disabled": false,
					"size": "medium",
					"iconPosition": "only-icon",
					"visible": "$CardState | crt.IsEqual : 'edit'",
					"icon": "open-button-icon",
					"clicked": {
						"request": "crt.UpdateRecordRequest",
						"params": {
							"entityName": "Activity",
							"recordId": "$Parameter_9mb096a"
						}
					},
					"clickMode": "default"
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Subject",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.StringAttribute_wc5fiop",
					"labelPosition": "above",
					"control": "$StringAttribute_wc5fiop",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_h9pzaab",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Start",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DateTimePicker",
					"pickerType": "datetime",
					"label": "$Resources.Strings.DateTimeAttribute_0187iux",
					"labelPosition": "above",
					"control": "$DateTimeAttribute_0187iux"
				},
				"parentName": "GridContainer_h9pzaab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "End",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DateTimePicker",
					"pickerType": "datetime",
					"label": "$Resources.Strings.DateTimeAttribute_x9yww5x",
					"labelPosition": "above",
					"control": "$DateTimeAttribute_x9yww5x"
				},
				"parentName": "GridContainer_h9pzaab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Category",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_48nfm46",
					"labelPosition": "above",
					"control": "$LookupAttribute_48nfm46",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": "",
					"mode": "List"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Status",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_8xg616y",
					"labelPosition": "above",
					"control": "$LookupAttribute_8xg616y",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": "",
					"mode": "List"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Owner",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_k2s6y20",
					"labelPosition": "above",
					"control": "$LookupAttribute_k2s6y20",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"StringAttribute_wc5fiop": {
						"modelConfig": {
							"path": "ActivityDS.Title"
						}
					},
					"DateTimeAttribute_0187iux": {
						"modelConfig": {
							"path": "ActivityDS.StartDate"
						}
					},
					"DateTimeAttribute_x9yww5x": {
						"modelConfig": {
							"path": "ActivityDS.DueDate"
						}
					},
					"LookupAttribute_48nfm46": {
						"modelConfig": {
							"path": "ActivityDS.ActivityCategory"
						}
					},
					"LookupAttribute_8xg616y": {
						"modelConfig": {
							"path": "ActivityDS.Status"
						}
					},
					"LookupAttribute_k2s6y20": {
						"modelConfig": {
							"path": "ActivityDS.Owner"
						}
					},
					"Parameter_9mb096a": {
						"modelConfig": {
							"path": "ActivityDS.Id"
						}
					},
					"ShowInSchedulerAttribute": {
						"modelConfig": {
							"path": "ActivityDS.ShowInScheduler"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"ActivityDS": {
							"type": "crt.EntityDataSource",
							"scope": "page",
							"config": {
								"entitySchemaName": "Activity"
							}
						}
					},
					"primaryDataSourceName": "ActivityDS"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});