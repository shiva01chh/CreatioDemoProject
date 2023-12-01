 define("ActiveContactsDetail", ["ActiveContactsDetailResources", "InformationButtonResources", "css!ActiveContactsDetailCSS"],
	function(resources, informationButtonResources) {
		return {
			entitySchemaName: null,
			attributes: {
				"ImageMassageContent": {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				"AvailableLicensesValue": {
					dataValueType: Terrasoft.DataValueType.TEXT
				},				
				"ImageStyle": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.TEXT,
				},
				"ImageConfig": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				},
				"IsVisible": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				"WarningStatusDomAttribute": {
					"dataValueType": this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {
				/**
				 * Get active contact lic info from server
				 * @private
				 */
				_getActiveContactsLicInfo: function() {
					let config = {
						serviceName: "CustomLicPackageService",
						methodName: "GetActiveContactsLicInfo"
					};
					this.callService(config,
						function(response) {
							if (!response || !response.GetActiveContactsLicInfoResult) {
								return;
							}
							let responseObject = response.GetActiveContactsLicInfoResult;
							let availableLicensesValues = this._getLicenseIndicatorConfig(responseObject);
							this._setLicenseIndicatorConfig(availableLicensesValues);
						}, this);
				},

				/**
				 * Build availableLicensesValues object
				 * @private
				 */
				_getLicenseIndicatorConfig: function(responseObject) {
					let activeContactsWarningThreshold = Terrasoft.SysSettings.getCachedSysSetting("ActiveContactsWarningThreshold");
					let usedLicensesPercentage = responseObject.ActiveContactCount/responseObject.PaidContactCount * 100;
					let availableLicensesValue = 
						this._numberValueConvertor(responseObject.PaidContactCount - responseObject.ActiveContactCount,
						" ");
					let licenseIndicatorState;
					if (isNaN(usedLicensesPercentage)) {
						licenseIndicatorState = this._getNoLicenseState();
					} else if (usedLicensesPercentage < 100 - activeContactsWarningThreshold) {
						licenseIndicatorState = this._getInfoState(responseObject, availableLicensesValue);
					} else if (usedLicensesPercentage < 100) {
						licenseIndicatorState = this._getAttentionState(responseObject, availableLicensesValue);
					} else if (usedLicensesPercentage == 100) {
						licenseIndicatorState = this._getWarningState(responseObject, availableLicensesValue);
					} else {
						licenseIndicatorState = this._getExceededWarningState(responseObject, availableLicensesValue);
					}
					return licenseIndicatorState;
				},

				/**
				 * Convert number to string with some separator.
				 * @private
				 */
				_numberValueConvertor: function(number) {
					let absValue = Math.abs(number);
					return absValue.toLocaleString(Terrasoft.Resources.CultureSettings.currentCultureName);
				},

				/**
				 * Convert date to local date as string
				 * @private
				 */
				_dateValueConvertor: function(value) {
					let result = "";
					let dateValue = new Date(value);
					if (Ext.isDate(dateValue) && !isNaN(dateValue.getDate())) {
						let datePart = Ext.Date.dateFormat(dateValue, Terrasoft.Resources.CultureSettings.dateFormat);
						let timePart = Ext.Date.dateFormat(dateValue, Terrasoft.Resources.CultureSettings.timeFormat);
						result = Ext.String.format("{0} {1}", datePart, timePart);
					}
					return result;
				},

				/**
				 * Build availableLicensesValues when there is no license.
				 * @private
				 */
				_getNoLicenseState: function() {
					let activeContactMessage = this.get("Resources.Strings.NoLicensetMessage");
					return {
						availableLicensesContent: activeContactMessage,
						imageStyle: Terrasoft.TipStyle.RED,
						availableLicensesValue: 0,
						imageConfig: informationButtonResources.localizableImages.WarningIcon,
						warningStatusDomAttribute: { "warning-status": "warning" }
					};
				},

				/**
				 * Build availableLicensesValues with success state.
				 * @private
				 */
				_getInfoState: function(responseObject, availableLicensesValue) {
					let activeContactMessage = this.get("Resources.Strings.ActiveContactMessageInfo");
					let availableLicensesContent = Ext.String.format(activeContactMessage, 
						this._dateValueConvertor(responseObject.ActualizationDate), availableLicensesValue, this._numberValueConvertor(responseObject.PaidContactCount));
					return {
						availableLicensesContent: availableLicensesContent,
						imageStyle: Terrasoft.TipStyle.GREEN,
						availableLicensesValue: availableLicensesValue,
						imageConfig: informationButtonResources.localizableImages.DefaultIcon,
						warningStatusDomAttribute: { "warning-status": "info" }
					};
				},

				/**
				 * Build availableLicensesValues with attention state.
				 * @private
				 */
				_getAttentionState: function(responseObject, availableLicensesValue) {
					let activeContactMessage = this.get("Resources.Strings.ActiveContactMessageAttention");
					let availableLicensesContent = Ext.String.format(activeContactMessage, 
						this._dateValueConvertor(responseObject.ActualizationDate), availableLicensesValue, this._numberValueConvertor(responseObject.PaidContactCount));
					return {
						availableLicensesContent: availableLicensesContent,
						imageStyle: Terrasoft.TipStyle.YELLOW,
						availableLicensesValue: availableLicensesValue,
						imageConfig: informationButtonResources.localizableImages.AttentionIcon,
						warningStatusDomAttribute: { "warning-status": "attention" }
					};
				},

				/**
				 * Build availableLicensesValues with warning state when count of available licenses is 0.
				 * @private
				 */
				_getWarningState: function(responseObject, availableLicensesValue) {
					let activeContactMessage = this.get("Resources.Strings.ActiveContactMessageWarning");
					let availableLicensesContent = Ext.String.format(activeContactMessage, 
						this._dateValueConvertor(responseObject.ActualizationDate), availableLicensesValue, this._numberValueConvertor(responseObject.PaidContactCount));
					return {
						availableLicensesContent: availableLicensesContent,
						imageStyle: Terrasoft.TipStyle.RED,
						availableLicensesValue: availableLicensesValue,
						imageConfig: informationButtonResources.localizableImages.WarningIcon,
						warningStatusDomAttribute: { "warning-status": "warning" }
					};
				},

				/**
				 * Build availableLicensesValues with warning state when count of available licenses are below 0.
				 * @private
				 */
				_getExceededWarningState: function(responseObject, availableLicensesValue) {
					let activeContactMessage = this.get("Resources.Strings.ActiveContactExceededMessageWarning");
					let availableLicensesContent = Ext.String.format(activeContactMessage, 
						this._dateValueConvertor(responseObject.ActualizationDate), availableLicensesValue, this._numberValueConvertor(responseObject.PaidContactCount));
					return {
						availableLicensesContent: availableLicensesContent,
						imageStyle: Terrasoft.TipStyle.RED,
						availableLicensesValue: 0,
						imageConfig: informationButtonResources.localizableImages.WarningIcon,
						warningStatusDomAttribute: { "warning-status": "warning" }
					};
				},

				/**
				 * Set attributes.
				 * @private
				 */
				_setLicenseIndicatorConfig: function(availableLicensesValues) {
					this.set("ImageMassageContent", availableLicensesValues.availableLicensesContent);
					this.set("ImageStyle", availableLicensesValues.imageStyle);
					this.set("AvailableLicensesValue", availableLicensesValues.availableLicensesValue);
					this.set("ImageConfig", availableLicensesValues.imageConfig);
					this.set("WarningStatusDomAttribute", availableLicensesValues.warningStatusDomAttribute);
					this.set("IsVisible", true);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDetailV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this._getActiveContactsLicInfo();
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "AvailableLicensesLabel",
					"parentName": "Detail",
					"index": 1,
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Resources.Strings.AvailableLicensesCaption"},
						"labelClass": ["active-contacts-inicator-label mt-6"],
						"visible": {"bindTo": "IsVisible"},
					}
				},
				{
					"operation": "insert",
					"name": "AvailableLicensesValue",
					"parentName": "Detail",
					"index": 2,
					"propertyName": "items",
					"values": {
						"domAttributes" : { "bindTo": "WarningStatusDomAttribute" },
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "AvailableLicensesValue"},
						"labelClass": ["active-contacts-inicator-value mr-8 mt-6"],
						"visible": {"bindTo": "IsVisible"},
					}
				},
				{
					"operation": "insert",
					"parentName": "Detail",
					"index": 3,
					"propertyName": "items",
					"name": "AvailableLicensesIcon",
					"values": {
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content":  {"bindTo": "ImageMassageContent"},
						"style": {"bindTo": "ImageStyle"},
						"controlConfig": {
							"classes": {
								"wrapperClass": ["send-button-info"]
							},
							"visible": {"bindTo": "IsVisible"},
							"imageConfig": {"bindTo": "ImageConfig"}
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
