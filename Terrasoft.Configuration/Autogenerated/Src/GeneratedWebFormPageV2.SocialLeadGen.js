define("GeneratedWebFormPageV2",
	[
		"GeneratedWebFormPageV2Resources",
		"css!SocialLeadGenGeneratedWebFormPageV2CSS"
	], function(resources) {
		return {
			attributes: {
				"IsLeadGenSubscribed": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"SocialPageId": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				"SocialPageName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				"SocialFormName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				"CreatioUrl": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: Terrasoft.loaderBaseUrl.replace(/\/\s*$/, "")
				},
				"LeadGenToggle": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"LeadGenToggleEnabled": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"LeadGenToggleHintText": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				"IsLeadGenEnabledStatus": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				"IsAccountExists": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"IsAccountEnabled": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"ActivePanelCode": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				}
			},
			methods: {
				/**
				 * @private
				 */
				_getLeadGenFeatureState: function() {
					return this.Terrasoft.Features.getIsEnabled("SocialLeadGen");
				},

				/**
				 * @private
				 */
				_getFacebookIcon: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.LeadGenFacebookIcon"));
				},

				/**
				 * @private
				 */
				_accountSettingsPanelVisibility: function() {
					return (this.get("ActivePanelCode") === "ACCOUNT_SETTINGS" && this.get("LeadGenToggle"));
				},

				/**
				 * @private
				 */
				_leadGenSettingsPanelVisibility: function() {
					return (this.get("ActivePanelCode") === "LEADGEN_SETTINGS" && this.get("LeadGenToggle"));
				},

				/**
				 * @private
				 */
				_getPageLink: function(value) {
					return {
						"url": value ? "https://facebook.com/" + this.get("SocialPageId") : "",
						"caption": value,
					};
				},

				/**
				 * @private
				 */
				_getDirection: function() {
					return this.Terrasoft.getIsRtlMode() ? "rtl" : "ltr";
				},

				/**
				 * @private
				 */
				_showCloudIntegrationErrorMessage: function() {
					Terrasoft.utils.showMessage({
						caption: resources.localizableStrings.LeadGenIntegrationErrorCaption,
						style: this.Terrasoft.MessageBoxStyles.RED
					});
				},

				/**
				 * @private
				 */
				_getLeadGenSubscribtionPanelCaption: function() {
					var localizableStrings = resources.localizableStrings;
					return this.get("IsLeadGenSubscribed") ?
						localizableStrings.LeadGenConnectedCaption :
						localizableStrings.LeadGenSubscribtionPanelLabelCaption;
				},

				/**
				 * @private
				 */
				_applyToggleState: function(state) {
					switch (state) {
						case 'active':
							this.set("LeadGenToggleEnabled", true)
							this.set("LeadGenToggleHintText", '');
							break;
						case 'loading':
							this.set("LeadGenToggleEnabled", false)
							this.set("LeadGenToggleHintText", resources.localizableStrings.LeadGenIntegrationLoadingCaption);
							break;
						case 'error':
							this.set("LeadGenToggleEnabled", false)
							this.set("LeadGenToggleHintText", resources.localizableStrings.LeadGenIntegrationErrorCaption);
							break;
						default:
							throw new Error('Invalid toggle state'); 
					}
				},

				/**
				 * @private
				 */
				_getLeadGenSubscribtion: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "GetSubscribtion",
						data: {
							subscribtionRequest: {
								LandingId: this.$PrimaryColumnValue
							}
						}
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.GetSubscribtionResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_deleteLeadGenSubscribtion: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "DeleteSubscribtion",
						data: {
							unsubscribtionRequest: {
								LandingId: this.$PrimaryColumnValue
							}
						}
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.DeleteSubscribtionResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_getLeadGenAccount: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "GetAccount",
						data: {}
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.GetAccountResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_createLeadGenAccount: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "CreateAccount",
						data: {
							createAccountRequest: {
								CreatioDomain: this.get("CreatioUrl")
							}
						}
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.CreateAccountResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_updateLeadGenAccount: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "UpdateAccount",
						data: {
							updateAccountRequest: {
								CreatioDomain: this.get("CreatioUrl")
							}
						}
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.CreateAccountResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_generateLeadGenSessionToken: function(onSuccess, onFailure, scope) {
					var config = {
						serviceName: "SocialLeadGenService",
						methodName: "GenerateSessionToken"
					};
					this.callService(config, function(responseData, response) {
						if (response.status === 200) {
							var result = responseData.GenerateSessionTokenResult;
							onSuccess.call(scope, result);
						} else {
							onFailure.call(scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_applyLeadGenSubscribtionInfo: function(response) {
					this.set("IsLeadGenSubscribed", response.IsLeadGenSubscribed);
					this.set("SocialPageId", response.PageId);
					this.set("SocialPageName", response.PageName);
					this.set("SocialFormName", response.FormName);
				},

				/**
				 * @private
				 */
				_loadLeadGenSubscribtionInfo: function(toggleRelated) {
					this._applyToggleState('loading');
					this._getLeadGenSubscribtion(function(response) {
						this._applyToggleState('active');
						if (toggleRelated) {
							this.set("LeadGenToggle", response.IsLeadGenSubscribed);
						}
						this._applyLeadGenSubscribtionInfo(response);
					}, this._showCloudIntegrationErrorMessage, this);
				},

				/**
				 * @private
				 */
				_loadLeadGenAccountInfo: function() {
					this._applyToggleState('loading');
					this._getLeadGenAccount(
						function(response) {
							this.set("IsAccountExists", response.IsAccountExists);
							this.set("IsAccountEnabled", response.IsAccountEnabled);
							if (response.IsAccountExists) {
								this.set("CreatioUrl", response.CreatioUrl);
								this.set("ActivePanelCode", "LEADGEN_SETTINGS");
								this._loadLeadGenSubscribtionInfo(true);
							} else {
								this._applyToggleState('active');
								this.set("ActivePanelCode", "ACCOUNT_SETTINGS");
							}
						}, 
						function() {
							this._applyToggleState('error');
						},
						this
					);
				},

				/**
				 * @private
				 */
				_onCreateUpdateAccountClick: function() {
					const onAccountChanged = function() {
						this.set("IsAccountExists", true);
						this.set("IsAccountEnabled", true);
						this.set("ActivePanelCode", "LEADGEN_SETTINGS");
					};
					if (this.get("IsAccountExists")) {
						this._updateLeadGenAccount(onAccountChanged, this._showCloudIntegrationErrorMessage, this);
					} else {
						this._createLeadGenAccount(onAccountChanged, this._showCloudIntegrationErrorMessage, this);
					}
				},

				/**
				 * @private
				 */
				_onEditAccountClick: function() {
					this.set("ActivePanelCode", "ACCOUNT_SETTINGS");
				},

				/**
				 * @private
				 */
				_onSelectResourceClick: function() {
					this._generateLeadGenSessionToken(function(response) {
						var url = response.AccountServiceUrl + "/app?" +
							"locale=" + Terrasoft.Resources.CultureSettings.currentCultureName + "&" +
							"dir=" + this._getDirection() + "&" +
							"social_network=facebook&" +
							"session_token=" + response.SessionToken + "&" +
							"web_form_id=" + this.$PrimaryColumnValue + "&" +
							"landing_type=lead";
						window.open(url);
					}, this._showCloudIntegrationErrorMessage, this);
				},

				/**
				 * @private
				 */
				_onPageLinkClick: function(url) {
					window.open(url, "_blank");
					return false;
				},

				/**
				 * @private
				 */
				_onRefreshClick: function() {
					this._loadLeadGenSubscribtionInfo(false);
				},

				/**
				 * @private
				 */
				_onLeadGenToggleClick: function() {
					if (this.get("IsLeadGenSubscribed") && !this.get("LeadGenToggle")) {
						this._deleteLeadGenSubscribtion(function(response) {
							this._applyLeadGenSubscribtionInfo(response);
						},
						this._showCloudIntegrationErrorMessage, this);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.set("LeadGenToggle", false);
					this.set("LeadGenToggleEnabled", false);
					if (this._getLeadGenFeatureState()) {
						if (this.isNew) {
							this.set("LeadGenToggleHintText", resources.localizableStrings.LeadGenIntegrationSaveRequired);
						} else {
							this._loadLeadGenAccountInfo();
						}
					}
				}
			},
			diff: [
				{
					"name": "LeadGenSettingsPanel",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"operation": "insert",
					"index": 1,
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"classes": {
							"wrapClassName": ["leadgen-settings-panel"]
						},
						"visible": "$_getLeadGenFeatureState"
					}
				},
				{
					"name": "LeadGenSettingsPanelHeaderContainer",
					"parentName": "LeadGenSettingsPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "header-container",
						"layout": { "column": 0, "row": 0, "colSpan": 24 },
						"items": [
							{
								"name": "FacebookIcon",
								"layout": { "column": 0, "row": 0, "colSpan": 2 },
								"getSrcMethod": "_getFacebookIcon",
								"readonly": true,
								"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
								"classes": {
									"wrapClass": ["header-container-icon"]
								},
							},
							{
								"name": "LeadGenSettingsPanelLabel",
								"layout": { "column": 2, "row": 0, "colSpan": 18 },
								"itemType": Terrasoft.ViewItemType.LABEL,
								"caption": "$Resources.Strings.LeadGenHeaderCaption",
								"classes": {
									"labelClass": ["header-container-label"]
								}
							},
							{
								"name": "LeadGenToggle",
								"layout": { "column": 20, "row": 0, "colSpan": 4 },
								"className": "Terrasoft.ToggleEdit",
								"click": "$_onLeadGenToggleClick",
								"labelConfig": {
									"visible": false
								},
								"enabled": "$LeadGenToggleEnabled",
								"hint": "$LeadGenToggleHintText",
								"classes": {
									"wrapClassName": ["header-container-toggle"]
								}
							}
						]
					}
				},
				//account settions panel
				{
					"name": "LeadGenAccountSectionPanel",
					"parentName": "LeadGenSettingsPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"layout": { "column": 0, "row": 2, "colSpan": 24 },
						"classes": {
							"wrapClassName": ["leadgen-settings-section-panel"]
						},
						"visible": "$_accountSettingsPanelVisibility"
					}
				},
				{
					"name": "LeadGenAccountSectionPanelLabel",
					"parentName": "LeadGenAccountSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"layout": { "column": 0, "row": 0, "colSpan": 24 },
						"caption": "$Resources.Strings.LeadGenAccountPanelLabelCaption",
						"classes": {
							"labelClass": ["section-panel-label"]
						}
					}
				},
				{
					"name": "CreatioUrlFieldContainer",
					"parentName": "LeadGenAccountSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "field-wrapper",
						"layout": { "column": 0, "row": 1, "colSpan": 24 },
						"items": [
							{
								"name": "CreatioUrlLabel",
								"itemType": Terrasoft.ViewItemType.LABEL,
								"caption": "$Resources.Strings.LeadGenCreatioUrlFieldCaption",
								"classes": {
									"labelClass": ["field-label"]
								}
							},
							{
								"name": "CreatioUrl",
								"labelConfig": {
									"visible": false
								}
							}
						],
					}
				},
				{

					"name": "AccountActionButtonsContainer",
					"parentName": "LeadGenAccountSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"name": "CreateLeadGenAccountButton",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "action-buttons-wrapper reverse",
						"layout": { "column": 0, "row": 3, "colSpan": 24 },
						"items": [{
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"caption": "$Resources.Strings.LeadGenConfirmationButtonCaption",
							"click": "$_onCreateUpdateAccountClick",
							"imageConfig": {
								"source": this.Terrasoft.ImageSources.URL,
								"url": this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.LeadGenRightIcon)
							},
							"classes": {
								"wrapperClass": ["button-wrapper"],
								"textClass": "button-text",
								"imageClass": ["button-image"]
							}
						}]
					}
				},
				//subscribtion settings panel
				{
					"name": "LeadGenSubscribtionSectionPanel",
					"parentName": "LeadGenSettingsPanel",
					"propertyName": "items",
					"operation": "insert",
					"index": 1,
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"layout": { "column": 0, "row": 1, "colSpan": 24 },
						"classes": {
							"wrapClassName": ["leadgen-settings-section-panel"]
						},
						"visible": "$_leadGenSettingsPanelVisibility"
					}
				},
				{
					"name": "LeadGenSubscribtionSectionPanelLabel",
					"parentName": "LeadGenSubscribtionSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"layout": { "column": 0, "row": 0, "colSpan": 24 },
						"caption": "$_getLeadGenSubscribtionPanelCaption",
						"classes": {
							"labelClass": ["section-panel-label"]
						}
					}
				},
				{
					"name": "PageFieldContainer",
					"parentName": "LeadGenSubscribtionSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "field-wrapper",
						"layout": { "column": 0, "row": 1, "colSpan": 24 },
						"items": [
							{
								"name": "PageLabel",
								"itemType": Terrasoft.ViewItemType.LABEL,
								"caption": "$Resources.Strings.LeadGenPageFieldCaption",
								"classes": {
									"labelClass": ["field-label"]
								}
							},
							{
								"name": "PageLink",
								"showValueAsLink": true,
								"labelConfig": {
									"visible": false
								},
								"bindTo": "SocialPageName",
								"href": {
									"bindTo": "SocialPageName",
									"bindConfig": { "converter": "_getPageLink" }
								},
								"controlConfig": {
									"enabled": false,
									"className": "Terrasoft.TextEdit",
									"linkclick": { bindTo: "_onPageLinkClick" }
								}
							}
						],
					}
				},
				{
					"name": "FormFieldContainer",
					"parentName": "LeadGenSubscribtionSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "field-wrapper",
						"layout": { "column": 0, "row": 2, "colSpan": 24 },
						"items": [
							{
								"name": "SocialFormLabel",
								"itemType": Terrasoft.ViewItemType.LABEL,
								"caption": "$Resources.Strings.LeadGenFormFieldCaption",
								"classes": {
									"labelClass": ["field-label"]
								}
							},
							{
								"name": "SocialFormName",
								"labelConfig": {
									"visible": false
								},
								"controlConfig": {
									"enabled": false
								}
							}
						]
					}
				},
				{
					"name": "SubscribtionActionButtonsContainer",
					"parentName": "LeadGenSubscribtionSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": "action-buttons-wrapper",
						"layout": { "column": 0, "row": 3, "colSpan": 24 },
						"items": [{
							"name": "SelectSourceButton",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"layout": { "column": 0, "row": 3, "colSpan": 14 },
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"caption": "$Resources.Strings.LeadGenSourceButtonCaption",
							"click": "$_onSelectResourceClick",
							"imageConfig": {
								"source": this.Terrasoft.ImageSources.URL,
								"url": this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.LeadGenSettingsIcon)
							},
							"classes": {
								"wrapperClass": ["button-wrapper"],
								"textClass": "button-text",
								"imageClass": ["button-image"]
							}
						},
						{
							"name": "RefreshSourceButton",
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"caption": "$Resources.Strings.LeadGenRefreshButtonCaption",
							"click": "$_onRefreshClick",
							"imageConfig": {
								"source": this.Terrasoft.ImageSources.URL,
								"url": this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.LeadGenRefreshIcon)
							},
							"classes": {
								"wrapperClass": ["button-wrapper"],
								"textClass": "button-text",
								"imageClass": ["button-image"]
							}
						}
						]
					}
				},
				{
					"name": "EditLeadGenAccountButton",
					"parentName": "LeadGenSubscribtionSectionPanel",
					"propertyName": "items",
					"operation": "insert",
					"values": {
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"layout": { "column": 0, "row": 5, "colSpan": 24 },
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "$Resources.Strings.LeadGenEditButtonCaption",
						"click": "$_onEditAccountClick",
						"classes": {
							"wrapperClass": ["button-wrapper"],
							"textClass": "button-text",
						}
					}
				}
			]
		};
	}
);