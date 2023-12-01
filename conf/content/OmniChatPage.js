﻿Terrasoft.configuration.Structures["OmniChatPage"] = {innerHierarchyStack: ["OmniChatPageOmnichannelMessaging", "OmniChatPage"], structureParent: "BaseModulePageV2"};
define('OmniChatPageOmnichannelMessagingStructure', ['OmniChatPageOmnichannelMessagingResources'], function(resources) {return {schemaUId:'149ba1f5-938e-4a68-bc7e-c5b62ba9c336',schemaCaption: "Edit page: \"Chat\"", parentSchemaName: "BaseModulePageV2", packageName: "Case", schemaName:'OmniChatPageOmnichannelMessaging',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('OmniChatPageStructure', ['OmniChatPageResources'], function(resources) {return {schemaUId:'852bbf5d-c0bc-4fe9-91e6-07ecf250daf5',schemaCaption: "Edit page: \"Chat\"", parentSchemaName: "OmniChatPageOmnichannelMessaging", packageName: "Case", schemaName:'OmniChatPage',parentSchemaUId:'149ba1f5-938e-4a68-bc7e-c5b62ba9c336',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"OmniChatPageOmnichannelMessaging",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('OmniChatPageOmnichannelMessagingResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("OmniChatPageOmnichannelMessaging", ["OmnichannelConsts", "OmniChatUtilities", "OmniChatComponent"],
	function(OmnichannelConsts, OmniChatUtilities) {
	return {
		entitySchemaName: "OmniChat",
		attributes: {
			"Channel": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"lookupListConfig": {
					"columns": [
						"Provider",
						"ChatQueue"
					]
				}
			},
			"ChannelProvider": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": {"bindTo": "Resources.Strings.ChannelProviderCaption"}
			},
			"ChatQueue": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": {"bindTo": "Resources.Strings.ChatQueueCaption"}
			}
		},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "OmniChatFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "OmniChat"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {

			/**
			 * @inheritDoc BasePageV2#onEntityInitialized
			 * @overridden
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.set("ChannelProvider", this.get("Channel").Provider);
				this.set("ChatQueue", this.get("Channel").ChatQueue);
			},

			/**
			 * Chat component rendered action.
			 * @protected
			 */
			chatComponentRendered: function() {
				const omniEl =  Ext.select("ts-omnichannel-messaging-chat-history").elements[0];
				if (omniEl) {
					omniEl.addEventListener("contactClick", OmniChatUtilities.openContactCard.bind(this));
				}
			}
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Contact",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"enabled": false,
					"bindTo": "Contact"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Channel",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"enabled": false,
					"bindTo": "Channel"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ChannelProvider",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"controlConfig": {
						"iconsVisible": true
					},
					"dataValueType": Terrasoft.DataValueType.ENUM,
					"bindTo": "ChannelProvider",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ChatQueue",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"dataValueType": Terrasoft.DataValueType.ENUM,
					"bindTo": "ChatQueue",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ChatDurationContainter",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"values": {
					"id": "ChatDurationContainter",
					"selectors": {"wrapEl": "#ChatDurationContainter"},
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"classes": {
						"wrapClassName": ["chat-duration-container", "profile-container"]
					},
					"items": [],
					"markerValue": "ChatDurationContainter"
				}
			},
			{
				"operation": "insert",
				"name": "ChatStartDate",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					},
					"bindTo": "ChatStartDate",
					"enabled": false
				},
				"parentName": "ChatDurationContainter",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ChatEndDate",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					},
					"bindTo": "ChatEndDate",
					"enabled": false
				},
				"parentName": "ChatDurationContainter",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ChatDurationInMinutes",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					},
					"bindTo": "ChatDuration",
					"enabled": false
				},
				"parentName": "ChatDurationContainter",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "FirstReplyTime",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					},
					"bindTo": "FirstReplyTime",
					"enabled": false
				},
				"parentName": "ChatDurationContainter",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "ConversationTab",
				"values": {
					"items": [],
					"caption": {
						"bindTo": "Resources.Strings.ConversationTabCaption"
					},
					"order": 0
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ChatConversationContainer",
				"parentName": "ConversationTab",
				"propertyName": "items",
				"values": {
					"id": "ChatConversationContainer",
					"selectors": {"wrapEl": "#ChatConversationContainer"},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"markerValue": "ChatConversationContainer",
					"visible": true
				}
			},
			{
				"operation": "insert",
				"name": "ChatConversation",
				"parentName": "ChatConversationContainer",
				"propertyName": "items",
				"values": {
					"id": "ChatConversation",
					"itemType": this.Terrasoft.ViewItemType.COMPONENT,
					"className": "Terrasoft.OmniChatComponent",
					"chatId": {
						"bindTo": "Id"
					},
					"afterrerender": {
						"bindTo": "chatComponentRendered"
					},
					"afterrender": {
						"bindTo": "chatComponentRendered"
					},
				}
			},
			{
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesAndFilesTabCaption"
					},
					"items": [],
					"order": 2
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Files",
				"values": {
					"itemType": 2
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotesControlGroup",
				"values": {
					"itemType": 15,
					"caption": {
						"bindTo": "Resources.Strings.NotesGroupCaption"
					},
					"items": []
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Notes",
				"values": {
					"bindTo": "Notes",
					"dataValueType": 1,
					"contentType": 4,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"imageLoaded": {
							"bindTo": "insertImagesToNotes"
						},
						"images": {
							"bindTo": "NotesImagesCollection"
						}
					}
				},
				"parentName": "NotesControlGroup",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 3
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define("OmniChatPage", [], function() {
	return {
		entitySchemaName: "OmniChat",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Cases": {
				"schemaName": "CaseChatDetail",
				"entitySchemaName": "CaseInChat",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Chat"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
          	{
				"operation": "insert",
				"name": "ChatInformationTab",
				"values": {
					"items": [],
					"caption": {
						"bindTo": "Resources.Strings.ChatInformationTabCaption"
					},
					"order": 1
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Cases",
				"values": {
					"itemType": 2
				},
				"parentName": "ChatInformationTab",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_DIFF*/
	};
});


