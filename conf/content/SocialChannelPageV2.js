﻿Terrasoft.configuration.Structures["SocialChannelPageV2"] = {innerHierarchyStack: ["SocialChannelPageV2"], structureParent: "BaseModulePageV2"};
define('SocialChannelPageV2Structure', ['SocialChannelPageV2Resources'], function(resources) {return {schemaUId:'6f4d1271-d3a6-4579-a41c-33c1605d7b23',schemaCaption: "SocialChannelPageV2", parentSchemaName: "BaseModulePageV2", packageName: "CrtUIv2", schemaName:'SocialChannelPageV2',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("SocialChannelPageV2", ["BusinessRuleModule", "SocialChannelPageV2Resources", "ImageCustomGeneratorV2"],
		function(BusinessRuleModule, resources) {
			return {
				entitySchemaName: "SocialChannel",
				details: /**SCHEMA_DETAILS*/{
					Subscribers: {
						schemaName: "SubscribersDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "EntityId"
						}
					}
				}/**SCHEMA_DETAILS*/,
				messages: {
					"CanSubscribe": {
						mode: this.Terrasoft.MessageMode.PTP,
						direction: this.Terrasoft.MessageDirectionType.PUBLISH
					},
					"GetRecordInfo": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.SUBSCRIBE
					},
					/**
					 * @message GetMasterRecordEntitySchemaUId
					 * ########## ############# ########.
					 */
					"GetMasterRecordEntitySchemaUId": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.SUBSCRIBE
					},
					/**
					 * @message UpdateIsSubscribed
					 * ######### ######## "IsSubscribed" - ######### ###### "###########" / "##########"
					 */
					"UpdateIsSubscribed": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.SUBSCRIBE
					},
					/**
					 * @message ChannelSaved
					 * ######### ######### # ########## ######.
					 */
					"ChannelSaved": {
						mode: this.Terrasoft.MessageMode.BROADCAST,
						direction: this.Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				properties: {
					/**
					 * Use only own subscription.
					 */
					useOnlyOwnSubscription: false
				},
				methods: {

					/**
					 * ########## ############# ###### ####### #####.
					 * @return {String} ############# ###### ####### #####.
					 */
					getESNFeedSectionSandboxId: function() {
						return "SectionModuleV2_ESNFeedSectionV2_CardModuleV2";
					},

					/**
					 * inheritDoc Terrasoft.BasePageV2#onSaved
					 * @overridden
					 */
					onSaved: function() {
						var model = this.Ext.create("Terrasoft.BaseViewModel", {
							values: {
								isNew: this.isNewMode(),
								PublisherRightKind: this.get("PublisherRightKind"),
								value: this.get(this.entitySchema.primaryColumnName),
								displayValue: this.get(this.entitySchema.primaryDisplayColumnName),
								primaryImageValue: this.get(this.entitySchema.primaryImageColumnName)
							}
						});
						this.sandbox.publish("ChannelSaved", model);
						this.callParent(arguments);
					},

					/**
					 * ########## ######### ######## ######## ### ######## "###########/##########".
					 * @protected
					 * @virtual
					 * @return {Terrasoft.BaseViewModelCollection} ########## ######### ######## ########.
					 */
					getActions: function() {
						var actionMenuItems = this.callParent(arguments);
						if (actionMenuItems.getCount() > 0) {
							var subscribeActions = actionMenuItems.filter(function(item) {
								return item.get("Tag") === "unsubscribeUser" || item.get("Tag") === "subscribeUser";
							});
							if (subscribeActions.getCount() > 0) {
								var subscribeActionsKeys = subscribeActions.getKeys();
								Terrasoft.each(subscribeActionsKeys, function(key) {
									actionMenuItems.removeByKey(key);
								}, this);
							}
						}
						return actionMenuItems;
					},

					/**
					 * ######### ###### "##########".
					 */
					updateSubscribersDetail: function() {
						this.updateDetail({detail: "Subscribers"});
					},

					/**
					 * ######### ######### ####.
					 * @param {Object} image ###### ###########.
					 */
					onImageChange: function(image) {
						var callbackSuccess = function(imageId) {
							var imageData = {
								value: imageId,
								displayValue: "Image"
							};
							this.set(this.primaryImageColumnName, imageData);
						};
						var callbackError = function(imageId, error, xhr) {
							if (xhr.response) {
								var response = Terrasoft.decode(xhr.response);
								if (response.error) {
									Terrasoft.showMessage(response.error);
								}
							}
						};
						var data = {
							onComplete: callbackSuccess,
							onError: callbackError,
							scope: this
						};
						if (image) {
							data.file = image;
							this.Terrasoft.ImageApi.upload(data);
						} else {
							this.set(this.primaryImageColumnName, null);
						}
					},

					/**
					 * ##### ######### ###### ## ###########.
					 * @return {*}
					 */
					getSrcMethod: function() {
						var primaryImageColumnValue = this.get(this.primaryImageColumnName);
						if (primaryImageColumnValue) {
							return this.getSchemaImageUrl(primaryImageColumnValue);
						}
						return this.getDefaultImageURL();
					},

					/**
					 * Returns default image url.
					 * @return {String} Default image url.
					 */
					getDefaultImageURL: function() {
						return this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.DefaultImage);
					},

					/**
					 *
					 * @return {boolean}
					 */
					beforeFileSelected: function() {
						return true;
					},

					/**

					 */
					setCurrentDate: function() {
						var creationDate = new Date();
						this.set("Date", creationDate);
					},

					/**
					 * #####, ############# ##### ############# #######.
					 * @overridden
					 */
					onEntityInitialized: function() {
						this.getIsSubscribed();
						this.setCurrentDate();
						this.callParent(arguments);
					},

					/**
					 * @inheritdoc Terrasoft.BaseModulePageV2#getOwnerColumnName
					 * @overridden
					 */
					getOwnerColumnName: function() {
						return this.entitySchema.columns.CreatedBy.name;
					},

					/**
					 * @inheritdoc Terrasoft.BasePageV2#subscribeDetailsEvents
					 * @overridden
					 */
					subscribeDetailsEvents: function() {
						this.callParent(arguments);
						var detailId = this.getDetailId("Subscribers");
						this.sandbox.subscribe("GetMasterRecordEntitySchemaUId", function() {
							return this.entitySchema.uId;
						}, this, [detailId]);
						this.sandbox.subscribe("UpdateIsSubscribed", function() {
							this.getIsSubscribed();
						}, this, [detailId]);
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "PropertiesTab",
						"parentName": "Tabs",
						"propertyName": "tabs",
						"values": {
							"caption": {"bindTo": "Resources.Strings.PropertiesTabCaption"},
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "ImageContainer",
						"values": {
							"itemType": Terrasoft.ViewItemType.CONTAINER,
							"wrapClass": ["image-edit-container"],
							"layout": {"column": 0, "row": 0, "rowSpan": 2, "colSpan": 3},
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "ImageContainer",
						"propertyName": "items",
						"name": "Image",
						"values": {
							"getSrcMethod": "getSrcMethod",
							"onPhotoChange": "onImageChange",
							"beforeFileSelected": "beforeFileSelected",
							"readonly": false,
							"defaultImage": {"bindTo": "getDefaultImageURL"},
							"layout": {"column": 0, "row": 0, "rowSpan": 2, "colSpan": 2},
							"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
						}
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "Title",
						"values": {
							"bindTo": "Title",
							"layout": {
								"column": 3,
								"row": 0,
								"colSpan": 21
							},
							"controlConfig": {
								"placeholder": {
									"bindTo": "Resources.Strings.TitlePlaceholder"
								}
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "Header",
						"propertyName": "items",
						"name": "Description",
						"values": {
							"bindTo": "Description",
							"layout": {
								"column": 3,
								"row": 1,
								"colSpan": 21,
								"rowSpan": 0
							},
							"controlConfig": {
								"placeholder": {
									"bindTo": "Resources.Strings.DescriptionPlaceholder"
								}
							},
							"contentType": this.Terrasoft.ContentType.LONG_TEXT
						}
					},
					{
						"operation": "insert",
						"parentName": "PropertiesTab",
						"name": "SocialChannelPagePropertiesTabContainer",
						"propertyName": "items",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "PropertiesTab",
						"propertyName": "items",
						"name": "Subscribers",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesTabContainer",
						"propertyName": "items",
						"name": "SocialChannelPagePropertiesTabContentGroup",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesTabContentGroup",
						"propertyName": "items",
						"name": "SocialChannelPagePropertiesBlock",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "ESNTab",
						"name": "SocialChannelPageESNTabContainer",
						"propertyName": "items",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPageESNTabContainer",
						"propertyName": "items",
						"name": "SocialChannelPageESNTabContentGroup",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPageESNTabContentGroup",
						"propertyName": "items",
						"name": "SocialChannelPageESNBlock",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesBlock",
						"propertyName": "items",
						"name": "ColorAndLabelContainer",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"visible": true,
							"layout": {"column": 0, "row": 0, "colSpan": 5},
							"wrapClass": ["control-width-15"],
							"items": []
						}
					},
					{
						"operation": "insert",
						"name": "ColorLabelContainer",
						"parentName": "ColorAndLabelContainer",
						"propertyName": "items",
						"values": {
							"generateId": false,
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"visible": true,
							"items": [],
							"wrapClass": ["label-wrap"]
						}
					},
					{
						"operation": "insert",
						"parentName": "ColorLabelContainer",
						"name": "ColorLabel",
						"propertyName": "items",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.LABEL,
							"caption": {"bindTo": "Resources.Strings.ColorCaption"},
							"classes": {"labelClass": ["colorButtonLabel"]}
						}
					},
					{
						"operation": "insert",
						"name": "ColorContainer",
						"parentName": "ColorAndLabelContainer",
						"propertyName": "items",
						"values": {
							"generateId": false,
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"visible": true,
							"items": [],
							"wrapClass": ["control-wrap color-button"]
						}
					},
					{
						"operation": "insert",
						"parentName": "ColorContainer",
						"propertyName": "items",
						"name": "Color",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.COLOR_BUTTON,
							"value": {"bindTo": "Color"},
							"defaultValue": "#64B8DF",
							"menuItemClassName": Terrasoft.MenuItemType.COLOR_PICKER
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesBlock",
						"propertyName": "items",
						"name": "CreatedBy",
						"values": {
							"layout": {"column": 5, "row": 0, "colSpan": 8},
							"controlConfig": {
								"enabled": false
							},
							"caption": {
								"bindTo": "Resources.Strings.CreatedByCaption"
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesBlock",
						"propertyName": "items",
						"name": "CreatedOn",
						"values": {
							"layout": {"column": 13, "row": 0, "colSpan": 9},
							"controlConfig": {
								"enabled": false
							},
							"caption": {
								"bindTo": "Resources.Strings.CreatedOnCaption"
							}
						}
					},
					{
						"operation": "insert",
						"index": 3,
						"parentName": "LeftContainer",
						"propertyName": "items",
						"name": "SubscribeChannelButton",
						"values": {
							"caption": {"bindTo": "getChangeUserSubscriptionCaption"},
							"enabled": {"bindTo": "getChangeUserSubscriptionIsEnabled"},
							"tag": "changeUserSubscription",
							"itemType": this.Terrasoft.ViewItemType.BUTTON,
							"click": {"bindTo": "onCardAction"},
							"style": Terrasoft.controls.ButtonEnums.style.GREEN,
							"classes": {
								"textClass": ["actions-button-margin-right"]
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesBlock",
						"name": "PublisherRightKindLabel",
						"propertyName": "items",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.PublisherRightKindCaption"
							},
							"itemType": this.Terrasoft.ViewItemType.LABEL,
							"layout": {"column": 0, "row": 2, "colSpan": 24}
						}
					},
					{
						"operation": "insert",
						"parentName": "SocialChannelPagePropertiesBlock",
						"name": "PublisherRightKind",
						"propertyName": "items",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.RADIO_GROUP,
							"value": {
								"bindTo": "PublisherRightKind"
							},
							"items": [],
							"layout": {"column": 0, "row": 3, "colSpan": 24}
						}
					},
					{
						"operation": "insert",
						"parentName": "PublisherRightKind",
						"propertyName": "items",
						"name": "AllUsersPublisherRights",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.AllUsersPublisherRightsCaption"
							},
							"value": true
						}
					},
					{
						"operation": "insert",
						"parentName": "PublisherRightKind",
						"propertyName": "items",
						"name": "EditorsPublisherRights",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.EditorsPublisherRightsCaption"
							},
							"value": false
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});


