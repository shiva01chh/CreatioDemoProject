Terrasoft.configuration.Structures["PageFreedomTemplate"] = {innerHierarchyStack: ["PageFreedomTemplate"], structureParent: "BasePageTemplate"};
define('PageFreedomTemplateStructure', ['PageFreedomTemplateResources'], function(resources) {return {schemaUId:'0dc09606-c527-4dba-8f5e-bc5786a04943',schemaCaption: "Page Freedom template", parentSchemaName: "BasePageTemplate", packageName: "CrtUIv2", schemaName:'PageFreedomTemplate',parentSchemaUId:'1a29b42d-f75e-48e5-b227-0b29bf0e676d',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("PageFreedomTemplate", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "Main",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"stretch": true,
					"fitContent": false,
					"items": []
				}
			},
			{
				"operation": "move",
				"name": "MainHeader",
				"parentName": "Main",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "move",
				"name": "MainContainer",
				"parentName": "Main",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "MainHeader",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"padding": {
						"top": "large",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"styles": {
						"border": "none",
						"border-bottom-left-radius": 0,
						"border-bottom-right-radius": 0
					}
				}
			},
			{
				"operation": "insert",
				"name": "MainHeaderTop",
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"justifyContent": "space-between",
					"wrap": "nowrap",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "TitleContainer",
				"parentName": "MainHeaderTop",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"items": [],
					"direction": "row",
					"justifyContent": "start",
					"alignItems": "center"
				}
			},
			{
				"operation": "insert",
				"name": "BackButton",
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(BackButton)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "back-button-icon",
					"clicked": {
						"request": "crt.ClosePageRequest"
					}
				}
			},
			{
				"operation": "insert",
				"name": "PageTitle",
				"parentName": "TitleContainer",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.Label",
					"caption": "$HeaderCaption",
					"labelType": "headline-1",
					"labelThickness": "default",
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				}
			},
			{
				"operation": "insert",
				"name": "SetRecordRightsButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 3,
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(SetRecordRightsButtonCaption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "lock-button-icon",
					"clicked": {
						"request": "crt.SetRecordRightsRequest"
					},
					"clickMode": "default"
				}
			},
			{
				"operation": "insert",
				"name": "ActionsButton",
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 4,
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ActionsButtonCaption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-icon",
					"visible": true,
					"icon": "more-button-icon"
				}
			},
			{
				"operation": "move",
				"name": "ActionButtonsContainer",
				"parentName": "MainHeaderTop",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "ActionButtonsContainer",
				"values": {
					"justifyContent": "end"
				}
			},
			{
				"operation": "remove",
				"name": "ActionContainer"
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"color": "primary"
				}
			},
			{
				"operation": "merge",
				"name": "CloseButton",
				"values": {
					"color": "default"
				}
			},
			{
				"operation": "insert",
				"name": "CardButtonToggleGroup",
				"parentName": "CardToggleContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"for": "CardToggleTabPanel",
					"type": "crt.ButtonToggleGroup"
				}
			},
			{
				"operation": "insert",
				"name": "CardContentWrapper",
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"298px",
						"minmax(64px, 1fr)"
					],
					"rows": "1fr",
					"gap": {
						"columnGap": "small",
						"rowGap": "small"
					},
					"padding": {
						"left": "small",
						"right": "small"
					},
					"stretch": true,
					"fitContent": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "SideContainer",
				"parentName": "CardContentWrapper",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"stretch": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "SideAreaProfileContainer",
				"parentName": "SideContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": "minmax(64px, 1fr)",
					"gap": {
						"columnGap": "large"
					},
					"padding": {
						"top": "medium",
						"right": "large",
						"bottom": "medium",
						"left": "large"
					},
					"layoutConfig": {
						"basis": "fit-content"
					},
					"color": "primary",
					"borderRadius": "medium",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "CenterContainer",
				"parentName": "CardContentWrapper",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"wrap": "nowrap",
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"stretch": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "CardContentContainer",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"stretch": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Tabs",
				"parentName": "CardContentContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.TabPanel",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "GeneralInfoTab",
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 0,
				"values": {
					"caption": "#ResourceString(GeneralInfoTab_caption)#",
					"type": "crt.TabContainer",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "GridContainer_lgy57ke",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(32px, max-content)",
					"columns": [
						"minmax(64px, 1fr)",
						"minmax(64px, 1fr)"
					],
					"gap": {
						"columnGap": "large"
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "CardToggleTabPanel",
				"parentName": "CenterContainer",
				"propertyName": "items",
				"index": 1,
				"values": {
					"type": "crt.TabPanel",
					"items": [],
					"mode": "toggle",
					"layoutConfig": {
						"maxWidth": 368,
						"minWidth": 368
					},
					"stretch": true,
					"classes": ["card-toggle-tab-panel", "container-background-color-primary", "container-border-area"]
				}
			},
			{
				"operation": "insert",
				"name": "FeedTabContainer",
				"parentName": "CardToggleTabPanel",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"tools": [],
					"caption": "#ResourceString(FeedTabContainerCaption)#",
					"iconPosition": "left-icon",
					"icon": "feed-icon"
				}
			},
			{
				"operation": "insert",
				"name": "FeedTabContainerHeaderContainer",
				"parentName": "FeedTabContainer",
				"propertyName": "tools",
				"index": 0,
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "FeedTabContainerHeaderLabel",
				"parentName": "FeedTabContainerHeaderContainer",
				"propertyName": "items",
				"index": 0,
				"values": {
					"type": "crt.Label",
					"caption": "#ResourceString(FeedTabContainerCaption)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start"
				}
			},
            {
                "operation": "insert",
                "name": "AttachmentsTabContainer",
                "parentName": "CardToggleTabPanel",
                "propertyName": "items",
                "index": 1,
                "values": {
                    "type": "crt.TabContainer",
                    "items": [],
                    "caption": "#ResourceString(AttachmentsTabContainerCaption)#",
					"iconPosition": "left-icon",
					"icon": "attachments-icon",
                    "tools": []
                }
            },
            {
                "operation": "insert",
                "name": "AttachmentsTabContainerHeaderContainer",
                "parentName": "AttachmentsTabContainer",
                "propertyName": "tools",
                "index": 0,
                "values": {
                    "type": "crt.FlexContainer",
                    "direction": "row",
                    "alignItems": "center",
                    "items": []
                }
            },
            {
                "operation": "insert",
                "name": "AttachmentsTabContainerHeaderLabel",
                "parentName": "AttachmentsTabContainerHeaderContainer",
                "propertyName": "items",
                "index": 0,
                "values": {
                    "type": "crt.Label",
                    "caption": "#ResourceString(AttachmentsTabContainerCaption)#",
                    "labelType": "headline-3",
                    "labelThickness": "default",
                    "labelEllipsis": false,
                    "labelColor": "#0D2E4E",
                    "labelBackgroundColor": "transparent",
                    "labelTextAlign": "start"
                }
            },
            {
                "operation": "insert",
                "name": "AttachmentAddButton",
                "parentName": "AttachmentsTabContainerHeaderContainer",
                "propertyName": "items",
                "index": 1,
                "values": {
                    "type": "crt.Button",
                    "caption": "#ResourceString(AttachmentAddButtonCaption)#",
                    "icon": "upload-button-icon",
                    "iconPosition": "only-icon",
                    "color": "default",
                    "size": "medium",
                    "clicked": {
                        "request": "crt.UploadFileRequest",
                        "params": {
                            "viewElementName": "AttachmentList"
                        }
                    }
                }
            },
            {
                "operation": "insert",
                "name": "AttachmentRefreshButton",
                "parentName": "AttachmentsTabContainerHeaderContainer",
                "propertyName": "items",
                "index": 2,
                "values": {
                    "type": "crt.Button",
                    "caption": "#ResourceString(AttachmentRefreshButtonCaption)#",
                    "icon": "reload-button-icon",
                    "iconPosition": "only-icon",
                    "color": "default",
                    "size": "medium",
                    "clicked": {
                        "request": "crt.LoadDataRequest",
                        "params": {
                            "config": {
                                "loadType": "reload"
                            },
                            "dataSourceName": "AttachmentListDS"
                        }
                    }
                }
            }
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"HeaderCaption": {
					value: "#ResourceString(DefaultHeaderCaption)#"
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});


