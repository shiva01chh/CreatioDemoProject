Terrasoft.configuration.Structures["SysUserProfilePage"] = {innerHierarchyStack: ["SysUserProfilePage"], structureParent: "PageWithTabsFreedomTemplate"};
define('SysUserProfilePageStructure', ['SysUserProfilePageResources'], function(resources) {return {schemaUId:'ed7ac55a-c3a9-4f8d-943c-1afc44843007',schemaCaption: "User profile page", parentSchemaName: "PageWithTabsFreedomTemplate", packageName: "CrtUIv2", schemaName:'SysUserProfilePage',parentSchemaUId:'3b2e117f-8c6b-4ca5-80a2-7ebb497cddf9',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("SysUserProfilePage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(devkit)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "PageTitle",
				"values": {
					"caption": "$FullName"
				}
			},
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"color": "default",
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "remove",
				"name": "SetRecordRightsButton"
			},
			{
				"operation": "remove",
				"name": "ActionsButton"
			},
			{
				"operation": "remove",
				"name": "TagSelect"
			},
			{
				"operation": "remove",
				"name": "CardButtonToggleGroup"
			},
			{
				"operation": "remove",
				"name": "CardToolsContainer"
			},
			{
				"operation": "remove",
				"name": "CardToggleContainer"
			},
			{
				"operation": "remove",
				"name": "MainHeaderBottom"
			},
			{
				"operation": "merge",
				"name": "CardContentWrapper",
				"values": {
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"visible": true,
					"color": "transparent",
					"borderRadius": "none"
				}
			},
			{
				"operation": "merge",
				"name": "SideContainer",
				"values": {
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "small"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap"
				}
			},
			{
				"operation": "merge",
				"name": "SideAreaProfileContainer",
				"values": {
					"columns": [
						"minmax(64px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "medium"
					},
					"visible": true
				}
			},
			{
				"operation": "merge",
				"name": "Tabs",
				"values": {
					"styleType": "default",
					"mode": "tab",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "remove",
				"name": "GeneralInfoTab"
			},
			{
				"operation": "remove",
				"name": "GeneralInfoTabContainer"
			},
			{
				"operation": "remove",
				"name": "CardToggleTabPanel"
			},
			{
				"operation": "remove",
				"name": "FeedTabContainer"
			},
			{
				"operation": "remove",
				"name": "FeedTabContainerHeaderContainer"
			},
			{
				"operation": "remove",
				"name": "FeedTabContainerHeaderLabel"
			},
			{
				"operation": "remove",
				"name": "AttachmentsTabContainer"
			},
			{
				"operation": "remove",
				"name": "AttachmentsTabContainerHeaderContainer"
			},
			{
				"operation": "remove",
				"name": "AttachmentsTabContainerHeaderLabel"
			},
			{
				"operation": "remove",
				"name": "AttachmentAddButton"
			},
			{
				"operation": "remove",
				"name": "AttachmentRefreshButton"
			},
			{
				"operation": "insert",
				"name": "Button_additional_settings",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(Button_additional_settings_caption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"clicked": {
						"request": "crt.OpenUserProfilePageRequest"
					},
					"clickMode": "default",
					"layoutConfig": {}
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AddTotpButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(AddTotpButtonCaption)#",
					"color": "default",
					"disabled": false,
					"size": "large",
					"iconPosition": "only-text",
					"visible": "$IsTotpVisible",
					"clicked": {
						"request": "crt.AddTotpRequest"
					},
					"clickMode": "default",
					"layoutConfig": {}
				},
				"parentName": "ActionButtonsContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "UserCompactProfile",
				"values": {
					"type": "crt.UserCompactProfile",
					"readonly": false,
					"referenceColumn": "$Id",
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"visible": true
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LoginEmailFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
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
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "SideAreaProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Login",
				"values": {
					"layoutConfig": {},
					"type": "crt.Input",
					"multiline": false,
					"label": "#ResourceString(Login_label)#",
					"labelPosition": "above",
					"control": "$Username",
					"visible": true,
					"placeholder": "",
					"tooltip": "",
					"readonly": true
				},
				"parentName": "LoginEmailFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailInput_3u1xtv3",
				"values": {
					"layoutConfig": {},
					"type": "crt.EmailInput",
					"label": "$Resources.Strings.Email",
					"labelPosition": "above",
					"control": "$Email",
					"visible": "$IsEmailVisible",
					"readonly": true,
					"placeholder": "#ResourceString(EmailInput_3u1xtv3_placeholder)#",
					"tooltip": "#ResourceString(EmailInput_3u1xtv3_tooltip)#"
				},
				"parentName": "LoginEmailFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "TabContainer_BasicInfo",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(TabContainer_BasicInfo_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_BasicInfoInner",
				"values": {
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
					"padding": {
						"top": "medium",
						"right": "none",
						"bottom": "large",
						"left": "none"
					},
					"color": "primary",
					"borderRadius": "none",
					"visible": true
				},
				"parentName": "TabContainer_BasicInfo",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "GridContainer_InnerColumns",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
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
						"rowGap": "medium"
					},
					"items": [],
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
				"parentName": "GridContainer_BasicInfoInner",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ComboBox_Language",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LanguageLookup",
					"labelPosition": "above",
					"control": "$LanguageLookup",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(ComboBox_Language_tooltip)#"
				},
				"parentName": "GridContainer_InnerColumns",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ComboBox_TimeZone",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.TimeZoneLookup",
					"labelPosition": "above",
					"control": "$TimeZoneLookup",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "#ResourceString(TimeZonePlaceholder)#",
					"tooltip": "#ResourceString(ComboBox_TimeZone_tooltip)#"
				},
				"parentName": "GridContainer_InnerColumns",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ComboBox_DateTimeFormat",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.DateTimeFormatLookup",
					"labelPosition": "above",
					"control": "$DateTimeFormatLookup",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "#ResourceString(DateFimeFormatPlaceholder)#",
					"tooltip": "#ResourceString(ComboBox_DateTimeFormat_tooltip)#"
				},
				"parentName": "GridContainer_InnerColumns",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Checkbox_EnablePopups",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Checkbox",
					"label": "$Resources.Strings.EnablePopups",
					"labelPosition": "right",
					"control": "$EnablePopups",
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(Checkbox_EnablePopups_tooltip)#"
				},
				"parentName": "GridContainer_InnerColumns",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Checkbox_DisableAdvancedVisualEffects",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Checkbox",
					"label": "$Resources.Strings.DisableAdvancedVisualEffects",
					"labelPosition": "right",
					"control": "$DisableAdvancedVisualEffects",
					"tooltip": "#ResourceString(Checkbox_DisableAdvancedVisualEffects_tooltip)#"
				},
				"parentName": "GridContainer_InnerColumns",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "TabContainer_PasswordSettings",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(TabContainer_PasswordSettings_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "GridContainer_PasswordSettings",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "medium"
					},
					"items": [],
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
				"parentName": "TabContainer_PasswordSettings",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FlexContainer_PasswordSettings",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
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
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "small",
					"wrap": "nowrap"
				},
				"parentName": "GridContainer_PasswordSettings",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CurrentPasswordInput",
				"values": {
					"layoutConfig": {},
					"type": "crt.PasswordInput",
					"label": "#ResourceString(CurrentPasswordInput_label)#",
					"control": "$CurrentPassword",
					"placeholder": "",
					"tooltip": "",
					"readonly": false,
					"multiline": false,
					"labelPosition": "above",
					"visible": true
				},
				"parentName": "FlexContainer_PasswordSettings",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NewPasswordInput",
				"values": {
					"layoutConfig": {},
					"type": "crt.PasswordInput",
					"label": "#ResourceString(NewPasswordInput_label)#",
					"control": "$NewUserPassword",
					"placeholder": "",
					"tooltip": "",
					"readonly": false,
					"multiline": false,
					"labelPosition": "above",
					"visible": true
				},
				"parentName": "FlexContainer_PasswordSettings",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "RepeatNewPasswordInput",
				"values": {
					"layoutConfig": {},
					"type": "crt.PasswordInput",
					"label": "#ResourceString(RepeatNewPasswordInput_label)#",
					"control": "$ConfirmUserPassword",
					"placeholder": "",
					"tooltip": "",
					"readonly": false,
					"multiline": false,
					"labelPosition": "above",
					"visible": true
				},
				"parentName": "FlexContainer_PasswordSettings",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ConfirmationCodeContainer",
				"values": {
					"type": "crt.GridContainer",
					"layoutConfig": {},
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "medium"
					},
					"items": [],
					"visible": "$ConfirmationCodeInputVisible",
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "FlexContainer_PasswordSettings",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ConfirmationCodeInput",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.PasswordInput",
					"label": "#ResourceString(ConfirmationCodeInputLabel)#",
					"control": "$ConfirmationCode",
					"placeholder": "",
					"tooltip": "",
					"readonly": false,
					"multiline": false,
					"labelPosition": "above"
				},
				"parentName": "ConfirmationCodeContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ButtonSendTextCode",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Button",
					"caption": "#ResourceString(SendSmsButtonCaption)#",
					"color": "default",
					"size": "extra-large",
					"iconPosition": "only-text",
					"visible": "$TextCodeTwoFactorAuthFlowEnabled",
					"menuItems": [],
					"clickMode": "default",
					"clicked": {
						"request": "crt.SendTextCodeRequest"
					}
				},
				"parentName": "ConfirmationCodeContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Button_Change_Password",
				"values": {
					"layoutConfig": {},
					"type": "crt.Button",
					"caption": "#ResourceString(Button_Change_Password_caption)#",
					"color": "accent",
					"disabled": "$ButtonChangePasswordDisabled",
					"size": "large",
					"iconPosition": "only-text",
					"visible": true,
					"menuItems": [],
					"clickMode": "default",
					"clicked": {
						"request": "crt.ChangeUserPasswordRequest"
					}
				},
				"parentName": "FlexContainer_PasswordSettings",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"IsChangesTrackingEnabled": {
					"value": true
				},
				"IsEmailVisible": {
					"value": true
				},
				"CardState": {
					"value": "edit"
				},
				"ButtonChangePasswordDisabled": {
					"value": true
				},
				"ConfirmationCodeInputVisible": {
					"value": false
				},
				"IsTotpVisible": {
					"value": false
				},
				"CurrentPassword": {
					"value": "",
					"validators": {
						"required": {
							"type": "crt.Required"
						}
					}
				},
				"NewUserPassword": {
					"value": "",
					"validators": {
						"required": {
							"type": "crt.Required"
						},
						"complexity": {
							"type": "crt.UserPasswordComplexity"
						},
						"history": {
							"type": "crt.UserPasswordHistory"
						},
						"usernameEqual": {
							"type": "crt.UserPasswordLoginEquality"
						}
					}
				},
				"ConfirmUserPassword": {
					"value": "",
					"validators": {
						"required": {
							"type": "crt.Required"
						},
						"equal": {
							"type": "crt.PasswordsDoNotMatch",
							"params": {
								"message": "#ResourceString(PasswordsDoNotMatch)#"
							}
						}
					}
				},
				"ConfirmationCode": {
					"value": "",
					"validators": {
						"required": {
							"type": "crt.Required"
						}
					}
				},
				"LanguageLookup": {
					"modelConfig": {
						"path": "SysUserProfileDS.Language"
					}
				},
				"TimeZoneLookup": {
					"modelConfig": {
						"path": "SysUserProfileDS.TimeZone"
					}
				},
				"DateTimeFormatLookup": {
					"modelConfig": {
						"path": "SysUserProfileDS.DateTimeFormat"
					}
				},
				"EnablePopups": {
					"modelConfig": {
						"path": "SysUserProfileDS.EnablePopups"
					}
				},
				"DisableAdvancedVisualEffects": {
					"modelConfig": {
						"path": "SysUserProfileDS.DisableAdvancedVisualEffects"
					}
				},
				"Username": {
					"modelConfig": {
						"path": "SysUserProfileDS.Username"
					}
				},
				"FullName": {
					"modelConfig": {
						"path": "SysUserProfileDS.FullName"
					}
				},
				"Email": {
					"modelConfig": {
						"path": "SysUserProfileDS.Email"
					}
				},
				"Photo": {
					"modelConfig": {
						"path": "SysUserProfileDS.Photo"
					}
				},
				"Id": {
					"modelConfig": {
						"path": "SysUserProfileDS.Id"
					}
				},
				"TextCodeTwoFactorAuthFlowEnabled": {
					"value": false
				},
				"TextCodeTwoFactorAuthFlowIsPrimary": {
					"value": false
				},
				"TotpTwoFactorAuthFlowEnabled": {
					"value": false
				},
				"TotpEnabledForCurrentUser": {
					"value": false
				},
				"Enable2FA": {
					"value": false
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"SysUserProfileDS": {
					"type": "crt.EntityDataSource",
					"scope": "page",
					"config": {
						"entitySchemaName": "SysUserProfile"
					}
				}
			},
			"primaryDataSourceName": "SysUserProfileDS"
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: 'crt.SaveRecordRequest',
				handler: async (request, next) => {
					result = await next?.handle(request);
					if (result) {
						const httpClientService = new devkit.HttpClientService();
						const endpoint = "/rest/SysUserProfileRefreshService/RefreshCurrentUser";
						const response = await httpClientService.post(endpoint);
						if (response?.body?.success && response?.body?.errorInfo === null) {
							window.location.reload(true);
						}
					}
				}
			},
			{
				request: 'crt.HandleViewModelInitRequest',
				handler: async (request, next) => {
					const handlerChain = devkit.HandlerChainService.instance;
					await handlerChain.process({
						type: 'crt.LoadDataRequest',
						$context: request.$context,
						config: {
							loadType: "reload"
						},
						dataSourceName: "SysUserProfileDS"
					});
					const email = await request.$context.Email;
					const userName = await request.$context.Username;
					request.$context.IsEmailVisible = email != '' && email !== userName;
					await handlerChain.process({
						type: 'crt.GetAuthenticationSettingsRequest',
						$context: request.$context,
						config: {
							loadType: "reload"
						}
					});
					const enable2FA = await request.$context.Enable2FA;
					const totpTwoFactorAuthFlowEnabled = await request.$context.TotpTwoFactorAuthFlowEnabled;
					const totpEnabledForCurrentUser = await request.$context.TotpEnabledForCurrentUser;
					request.$context.ConfirmationCodeInputVisible = enable2FA;
					request.$context.IsTotpVisible = enable2FA 
						&& totpTwoFactorAuthFlowEnabled
						&& !totpEnabledForCurrentUser.GetCurrentUserTotpStateResult;
				}
			},
			{
				request: "crt.LoadDataRequest",
				handler: async (request, next) => {
					var languageDataSourceName = 'LanguageLookup_List_DS';
					if(request.dataSourceName !== languageDataSourceName) {
						return await next?.handle(request);
					}
					request.parameters.push({
						type: "filter",
						value: {
							"items": {
								"8533d26b-cedc-4a3f-b701-c58775182a8d": {
									"filterType": 1,
									"comparisonType": 3,
									"isEnabled": true,
									"trimDateTimeParameterToDate": false,
									"leftExpression": {
										"expressionType": 0,
										"columnPath": "[SysCulture:Language].Active"
									},
									"isAggregative": false,
									"dataValueType": 1,
									"rightExpression": {
										"expressionType": 2,
										"parameter": {
											"dataValueType": 12,
											"value": 1
										}
									}
								}
							},
							"logicalOperation": 0,
							"isEnabled": true,
							"filterType": 6,
							"rootSchemaName": "SysLanguage"
						}
					});
					return await next?.handle(request);
				}
			},
			{
				request: "crt.HandleViewModelAttributeChangeRequest",
				handler: async (request, next) => {
					if (request.attributeName === 'CurrentPassword' || request.attributeName === 'NewUserPassword'
							|| request.attributeName === 'ConfirmUserPassword'
							|| request.attributeName === 'ConfirmationCode') {
						request.$context.ButtonChangePasswordDisabled = true;
						const currentPasswordValue = await request.$context.CurrentPassword;
						const newUserPasswordValue = await request.$context.NewUserPassword;
						const confirmUserPasswordValue = await request.$context.ConfirmUserPassword;
						const username = await request.$context.Username;
						if (newUserPasswordValue !== confirmUserPasswordValue) {
							await request.$context.enableAttributeValidator('ConfirmUserPassword', 'equal');
						} else {
							await request.$context.disableAttributeValidator('ConfirmUserPassword', 'equal');
						}
						if (username.toLowerCase() === newUserPasswordValue.toLowerCase()) {
							await request.$context.enableAttributeValidator('NewUserPassword', 'usernameEqual');
						} else {
							await request.$context.disableAttributeValidator('NewUserPassword', 'usernameEqual');
						}
						if (newUserPasswordValue === currentPasswordValue) {
							await request.$context.enableAttributeValidator('NewUserPassword', 'history');
						} else {
							await request.$context.disableAttributeValidator('NewUserPassword', 'history');
						}
						const enable2FA = await request.$context.Enable2FA;
						if (enable2FA) {
							await request.$context.enableAttributeValidator('ConfirmationCode', 'required');
						} else {
							await request.$context.disableAttributeValidator('ConfirmationCode', 'required');
						}
						if ((!enable2FA || request.$context.formApiModel.controls.ConfirmationCode.status === 'VALID')
								&& request.$context.formApiModel.controls.CurrentPassword.status === 'VALID'
								&& request.$context.formApiModel.controls.NewUserPassword.status === 'VALID' 
								&& request.$context.formApiModel.controls.ConfirmUserPassword.status === 'VALID') {
							request.$context.ButtonChangePasswordDisabled = false;
						}
					}
					return next?.handle(request);
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{
			"crt.PasswordsDoNotMatch": {
				"validator": function (config) {
					return function (control) {
						return control.value === '' ? null: {
							"crt.PasswordsDoNotMatch": { message: config.message }
						};
					};
				},
				"params": [
					{
						"name": "message"
					}
				],
				"async": false
			}
		}/**SCHEMA_VALIDATORS*/
	};
});

