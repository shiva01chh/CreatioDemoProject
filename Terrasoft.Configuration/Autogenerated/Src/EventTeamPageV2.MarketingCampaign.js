define("EventTeamPageV2", ["terrasoft"],
	function(Terrasoft) {
		return {
			entitySchemaName: "EventTeam",
			// TODO: ###### #### ###### # ########## ######## isRequired, ####### # ######### ##### ### #########
			attributes: {
				"Campaign": {dataValueType: Terrasoft.DataValueType.LOOKUP, isRequired: false}
			},
			// TODO: #### ## ########## # ####### ###### ########## ##### userCode, ##### ########## ####### ######
			userCode: {
				viewModel: function(viewModel) {
					delete viewModel.columns.Campaign;
				}
			},
			methods: {
				setContact: function() {
					if (this.get("Contact")) {
						this.set("Contact", undefined);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Tabs",
					"parentName": "CardContentContainer",
					"propertyName": "items",
					"values": {
						itemType: Terrasoft.ViewItemType.TAB_PANEL,
						activeTabChange: {bindTo: "activeTabChange"},
						activeTabName: {bindTo: "ActiveTabName"},
						classes: {wrapClass: ["tab-panel-margin-bottom"]},
						tabs: [],
						visible: false
					}
				},
				{
					"operation": "insert",
					"name": "TeamPageGeneralTabContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "TeamPageGeneralTabContainer",
					"propertyName": "items",
					"name": "TeamPageGeneralBlock",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "TeamParticipant",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"bindTo": "Event",
						controlConfig: {
							enabled: false
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Contact",
					"values": {
						"bindTo": "Contact",
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Account",
					"values": {
						"bindTo": "Account",
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Role",
					"values": {
						"bindTo": "Role",
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12
						},
						"contentType": "Terrasoft.ContentType.ENUM"
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Notes",
					"values": {
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"bindTo": "Notes",
						"layout": {
							"column": 0,
							"row": 5,
							"rowSpan": 1,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "merge",
					"parentName": "LeftContainer",
					"propertyName": "items",
					"name": "actions",
					"values": {
						itemType: Terrasoft.ViewItemType.BUTTON,
						visible: false
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"Contact": {
					"FiltrationContactByAccount": {
						"ruleType": 1,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "Account",
						"comparisonType": 3,
						"type": 1,
						"attribute": "Account"
					}
				}
			}
		};
	});
