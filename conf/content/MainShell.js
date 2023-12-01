Terrasoft.configuration.Structures["MainShell"] = {innerHierarchyStack: ["MainShellCrtUIv2", "MainShellSalesEnterprise", "MainShell"], structureParent: "BaseShell"};
define('MainShellCrtUIv2Structure', ['MainShellCrtUIv2Resources'], function(resources) {return {schemaUId:'89f9e77f-2095-4a02-b212-66924f229dab',schemaCaption: "Main shell layout with vertical navigation", parentSchemaName: "BaseShell", packageName: "SalesEnterprise_Marketing_ServiceEnt", schemaName:'MainShellCrtUIv2',parentSchemaUId:'b55d348b-a0aa-4622-a73d-87be774af348',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('MainShellSalesEnterpriseStructure', ['MainShellSalesEnterpriseResources'], function(resources) {return {schemaUId:'c9f138fc-d38a-42f9-9ff2-79d6229ca928',schemaCaption: "Main shell layout with vertical navigation", parentSchemaName: "MainShellCrtUIv2", packageName: "SalesEnterprise_Marketing_ServiceEnt", schemaName:'MainShellSalesEnterprise',parentSchemaUId:'89f9e77f-2095-4a02-b212-66924f229dab',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"MainShellCrtUIv2",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('MainShellStructure', ['MainShellResources'], function(resources) {return {schemaUId:'4017f6db-add6-4efb-b1ba-d572629b47a2',schemaCaption: "Main shell layout with vertical navigation", parentSchemaName: "MainShellSalesEnterprise", packageName: "SalesEnterprise_Marketing_ServiceEnt", schemaName:'MainShell',parentSchemaUId:'c9f138fc-d38a-42f9-9ff2-79d6229ca928',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"MainShellSalesEnterprise",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('MainShellCrtUIv2Resources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
// Parent: BaseShell
define("MainShellCrtUIv2", /**SCHEMA_DEPS*/["@creatio-devkit/common", "css!CardSchemaViewModule", "css!MainShellCSS"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(devkit)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "ShellHeader",
				"values": {
					"type": "crt.FlexContainer",
					"fitContent": true,
					"items": []
				},
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ShellHeaderToolbar",
				"values": {
					"type": "crt.AppToolbar",
					"createRecord": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "@event.entityName",
							"entityPageName": "@event.entityPageName",
							"defaultValues": "@event.defaultValues"
						}
					},
					"navigationPanelVisibleChange": {
						"request": "crt.NavigationPanelChangeVisibleRequest",
						"params": {
							"isVisible": "@event"
						}
					},
					"navigationPanelVisible": "$WorkplaceNavigationPanelVisibleAttribute",
					"rightPanelButtonClicked": {
						"request": "crt.ChangeRightPanelContentRequest",
						"params": {
							"selectedPanel": "@event"
						}
					},
					"notificationsPanelHasNewNotifications": "$NotificationsPanelHasNewNotifications",
					"communicationsPanelHasNewMessages": "$CommunicationsPanelHasNewMessages",
					"currentRightPanelTab": "$RightPanelSelectedTab",
					"communicationItemsInfo": "$ActiveCommunicationsInfo",
					"communicationIndicatorClicked": {
						"request": "crt.CommunicationIndicatorClickedRequest"
					}
				},
				"parentName": "ShellHeader",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ShellContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"wrap": "nowrap",
					"padding": {
						"left": "small",
						"right": "small"
					},
					"classes": "$ShellContainerClasses",
					"stretch": true,
					"items": []
				},
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LeftNavigationPanel",
				"values": {
					"type": "crt.NavigationPanel",
					"classes": [
						"remove-outside-horizontal-padding"
					],
					"stretch": true
				},
				"parentName": "ShellContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CenterContainer",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"classes": ["center-container"],
					"items": [],
					"borderRadius": "medium",
					"padding": "none",
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"stretch": true
				},
				"parentName": "ShellContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RouterOutlet",
				"values": {
					"type": "crt.RouterOutlet",
					"contentBackgroundChanged": {
						"request": "crt.ContentDisplayedStateChangedRequest"
					}
				},
				"parentName": "CenterContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RightPanelContainer",
				"values": {
					"layoutConfig": {
						"width": 424,
						"minWidth": 0
					},
					"type": "crt.TabPanel",
					"items": [],
					"mode": "toggle",
					"isToggleTabHeaderVisible": false,
					"bodyBackgroundColor": "primary-contrast-100",
					"visible": "$RightPanelSelectedTab | crt.IsRightPanelVisible",
					"selectedTab": "$RightPanelSelectedTab",
					"classes": [
						"right-panel-modules-container",
						"right-panel-container"
					],
					"visibilityStrategyMode": "hide"
				},
				"parentName": "ShellContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "CommunicationPanelSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "CtiPanelModule",
					"doNotRender": true
				},
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "OauthSettingsModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "OauthSettingsModule",
					"doNotRender": true
				},
				"propertyName": "items",
				"index": 5
			},
			//TODO https://creatio.atlassian.net/browse/RND-31252
			{
				"operation": "insert",
				"name": "CommunicationPanel",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "#ResourceString(CommunicationPanelContainer_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "tiles-tab-icon"
				},
				"parentName": "RightPanelContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CommunicationPanelItemsContainer",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "row",
					"wrap": "nowrap",
					"classes": [
						"communication-panel-item-container"
					]
				},
				"parentName": "CommunicationPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CommunicationsPanelItemsToggleButtons",
				"values": {
					"for": "CommunicationsPanelItemsTabPanel",
					"type": "crt.ButtonToggleGroup",
					"allowUntoggle": false,
					"direction": "column",
					"size": "extra-large",
					"iconSize": "extra-large",
					"contentAlign": "center",
					"tooltipPosition": {
						"originX": "end",
						"originY": "center",
						"overlayX": "start",
						"overlayY": "center"
					}
				},
				"parentName": "CommunicationPanelItemsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CommunicationsPanelItemsTabPanel",
				"values": {
					"type": "crt.TabPanel",
					"items": [],
					"mode": "toggle",
					"styleType": "default",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto",
					"isToggleTabHeaderVisible": true,
					"classes": [
						"communications-panel-items-tab-panel"
					],
					"allowToggleClose": false,
					"selectedTab": {
						"value": "FeedsTab"
					}
				},
				"parentName": "CommunicationPanelItemsContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "FeedsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(FeedsTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-feeds"
				},
				"parentName": "CommunicationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FeedTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "FeedsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FeedLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(FeedsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "FeedTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FeedsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column",
					"classes": [
						"ts-feed-container"
					]
				},
				"parentName": "FeedsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Feed",
				"values": {
					"type": "crt.Feed",
					"feedType": "User",
					"primaryColumnValue": "$Id",
					"cardState": "$CardState",
					"entitySchemaName": null,
					"dataSourceName": null,
					"visible": true
				},
				"parentName": "FeedsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CtiTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(CtiTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-calls"
				},
				"parentName": "CommunicationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "CtiTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "CtiTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CtiLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(CtiTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "CtiTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CtiTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column",
					"classes": [
						"ts-cti-container"
					]
				},
				"parentName": "CtiTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CtiPanelModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "CtiPanelModule"
				},
				"parentName": "CtiTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(EmailsTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-emails"
				},
				"parentName": "CommunicationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "EmailsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "EmailsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(EmailsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "EmailsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "EmailsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "EmailModule"
				},
				"parentName": "EmailsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ChatsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(ChatsTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-chats"
				},
				"parentName": "CommunicationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ChatsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "ChatsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ChatsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(ChatsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "ChatsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ChatsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"id": "OmniChatModule_WrapContainer",
					"direction": "column"
				},
				"parentName": "ChatsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OmniChatModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "OmniChatModule"
				},
				"parentName": "ChatsTabItems",
				"propertyName": "items",
				"index": 0
			},
			//TODO https://creatio.atlassian.net/browse/RND-31253
			{
				"operation": "insert",
				"name": "NotificationsPanel",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "Notifications",
					"iconPosition": "only-icon",
					"icon": "bell-tab-icon"
				},
				"parentName": "RightPanelContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "NotificationsPanelToolsContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "NotificationsPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotificationsPanelItemsContainer",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "row",
					"wrap": "nowrap",
					"classes": [
						"ts-notifications-container",
						"communication-panel-item-container"
					]
				},
				"parentName": "NotificationsPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotificationsPanelItemsToggleButtons",
				"values": {
					"for": "NotificationsPanelItemsTabPanel",
					"type": "crt.ButtonToggleGroup",
					"allowUntoggle": false,
					"direction": "column",
					"size": "extra-large",
					"iconSize": "extra-large",
					"contentAlign": "center",
					"tooltipPosition": {
						"originX": "end",
						"originY": "center",
						"overlayX": "start",
						"overlayY": "center"
					}
				},
				"parentName": "NotificationsPanelItemsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotificationsPanelItemsTabPanel",
				"values": {
					"type": "crt.TabPanel",
					"items": [],
					"mode": "toggle",
					"styleType": "default",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto",
					"isToggleTabHeaderVisible": true,
					"allowToggleClose": false,
					"selectedTab": {
						"value": "ReminderTab"
					}
				},
				"parentName": "NotificationsPanelItemsContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ReminderTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(ReminderTab_caption)#",
					"iconPosition": "only-icon",
					"icon": "right-panel-reminding-notifications"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ReminderTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "ReminderTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ReminderLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(ReminderTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "ReminderTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ReminderTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "ReminderTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ReminderNotificationsSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "ReminderNotificationsSchema"
					}
				},
				"parentName": "ReminderTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EsnNotificationsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(EsnNotificationsTab_caption)#",
					"iconPosition": "only-icon",
					"icon": "right-panel-esn-notifications"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "EsnNotificationsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "EsnNotificationsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EsnNotificationsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(EsnNotificationsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "EsnNotificationsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EsnNotificationsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "EsnNotificationsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ESNNotificationSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "ESNNotificationSchema"
					}
				},
				"parentName": "EsnNotificationsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "VisaNotificationsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(VisaNotificationsTab_caption)#",
					"iconPosition": "only-icon",
					"icon": "right-panel-visa-notifications"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "VisaNotificationsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "VisaNotificationsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "VisaNotificationsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(VisaNotificationsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "VisaNotificationsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "VisaNotificationsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "VisaNotificationsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "VisaNotificationsSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "VisaNotificationsSchema"
					}
				},
				"parentName": "VisaNotificationsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AnniversaryNotificationsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(AnniversaryNotificationsTab_caption)#",
					"iconPosition": "only-icon",
					"icon": "right-panel-anniversary-notifications"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AnniversaryNotificationsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "AnniversaryNotificationsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AnniversaryNotificationsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(AnniversaryNotificationsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "AnniversaryNotificationsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AnniversaryNotificationsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "AnniversaryNotificationsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AnniversaryNotificationsSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "AnniversaryNotificationsSchema"
					}
				},
				"parentName": "AnniversaryNotificationsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemNotificationsTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(SystemNotificationsTab_caption)#",
					"iconPosition": "only-icon",
					"icon": "right-panel-system-notifications"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "SystemNotificationsTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "SystemNotificationsTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemNotificationsLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(SystemNotificationsTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "SystemNotificationsTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemNotificationsTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "SystemNotificationsTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SystemNotificationsSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "SystemNotificationsSchema"
					}
				},
				"parentName": "SystemNotificationsTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BusinessProcessTab",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "",
					"title": "#ResourceString(BusinessProcessTab_caption)#",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "right-panel-business-processes"
				},
				"parentName": "NotificationsPanelItemsTabPanel",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "BusinessProcessTabTools",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "BusinessProcessTab",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BusinessProcessLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(BusinessProcessTab_caption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "var(--crt-palette-foreground-500)",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				},
				"parentName": "BusinessProcessTabTools",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BusinessProcessTabItems",
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "column"
				},
				"parentName": "BusinessProcessTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProcessDashboardSchema",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "BaseSchemaModuleV2",
					"instanceConfig": {
						"useHistoryState": false,
						"isSchemaConfigInitialized": true,
						"schemaName": "ProcessDashboardSchema"
					}
				},
				"parentName": "BusinessProcessTabItems",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AngularAdapterModule",
				"values": {
					"type": "crt.ModuleLoader",
					"module": "AngularAdapterModule"
				},
				"index": 3
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"RightPanelSelectedTab": {
					"value": null,
					"change": {
						request: 'crt.SetupApplicationBackgroundEffectRequest'
					}
				},
				"NotificationsPanelHasNewNotifications": {
					value: false
				},
				"ShellContainerClasses": {
					value: []
				},
				"CommunicationsPanelHasNewMessages": {
					value: false
				},
				"ActiveCommunicationsInfo": {
					value: null
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: 'crt.ContentDisplayedStateChangedRequest',
				handler: async (request, next) => {
					const viewModel = request.$context
					const shellContainerClasses = [];
					// TODO: RND-31574
					const isContentShown = request.$initialEvent;
					if (isContentShown) {
						shellContainerClasses.push('content-schema');
					} else {
						shellContainerClasses.push('desktop-schema');
					}
					viewModel.ShellContainerClasses = shellContainerClasses;
					return next?.handle(request);
				}
			},
			{
				request: 'crt.HandleViewModelInitRequest',
				handler: async (request, next) => {
					const viewModel = request.$context;
					const handlerChainService = new devkit.HandlerChainService();
					await handlerChainService.process({
						type: 'crt.SetupApplicationBackgroundEffectRequest',
						$context: viewModel
					});
					return next?.handle(request);
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

define('MainShellSalesEnterpriseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("MainShellSalesEnterprise", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"WorkplaceNavigationPanelCurrentGroupAttribute": {
					value: "7196040b-b04c-4c3d-b04d-72d814997f19" // Sales Workplace as default
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
define("MainShell", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"WorkplaceNavigationPanelCurrentGroupAttribute": {
					value: "536c82a9-733c-4498-a9e0-8809ff1ff9eb" // CRM Workplace as default
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

