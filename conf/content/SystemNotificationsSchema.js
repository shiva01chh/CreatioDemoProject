﻿Terrasoft.configuration.Structures["SystemNotificationsSchema"] = {innerHierarchyStack: ["SystemNotificationsSchemaCrtNUI", "SystemNotificationsSchemaReports", "SystemNotificationsSchemaCrtUIv2", "SystemNotificationsSchemaFileImport", "SystemNotificationsSchemaSocialLeadGen", "SystemNotificationsSchemaCoreForecast", "SystemNotificationsSchema"], structureParent: "BaseNotificationsSchema"};
define('SystemNotificationsSchemaCrtNUIStructure', ['SystemNotificationsSchemaCrtNUIResources'], function(resources) {return {schemaUId:'ec93bd1a-6cb6-44a8-adfb-a9b3599f8bd1',schemaCaption: "Schema of system notifications", parentSchemaName: "BaseNotificationsSchema", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaCrtNUI',parentSchemaUId:'362d1b69-b8e7-442d-8d48-f701591b493a',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaReportsStructure', ['SystemNotificationsSchemaReportsResources'], function(resources) {return {schemaUId:'76f7b1de-23ff-4f50-aff0-0c5c14292cef',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaCrtNUI", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaReports',parentSchemaUId:'ec93bd1a-6cb6-44a8-adfb-a9b3599f8bd1',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaCrtNUI",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaCrtUIv2Structure', ['SystemNotificationsSchemaCrtUIv2Resources'], function(resources) {return {schemaUId:'95ef8633-e4ce-44f1-bab5-9ca6426d2308',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaReports", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaCrtUIv2',parentSchemaUId:'76f7b1de-23ff-4f50-aff0-0c5c14292cef',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaReports",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaFileImportStructure', ['SystemNotificationsSchemaFileImportResources'], function(resources) {return {schemaUId:'a926e569-d5fb-4013-bc4f-1482553254f6',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaCrtUIv2", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaFileImport',parentSchemaUId:'95ef8633-e4ce-44f1-bab5-9ca6426d2308',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaCrtUIv2",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaSocialLeadGenStructure', ['SystemNotificationsSchemaSocialLeadGenResources'], function(resources) {return {schemaUId:'885a1efc-1564-4a76-9a70-6a6b92f383d3',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaFileImport", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaSocialLeadGen',parentSchemaUId:'a926e569-d5fb-4013-bc4f-1482553254f6',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaFileImport",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaCoreForecastStructure', ['SystemNotificationsSchemaCoreForecastResources'], function(resources) {return {schemaUId:'a431f7d8-7b5b-41fd-a82f-d9e251144bf3',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaSocialLeadGen", packageName: "BulkEmail", schemaName:'SystemNotificationsSchemaCoreForecast',parentSchemaUId:'885a1efc-1564-4a76-9a70-6a6b92f383d3',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaSocialLeadGen",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaStructure', ['SystemNotificationsSchemaResources'], function(resources) {return {schemaUId:'8671fc50-4495-450b-840c-9c458dc08176',schemaCaption: "Schema of system notifications", parentSchemaName: "SystemNotificationsSchemaCoreForecast", packageName: "BulkEmail", schemaName:'SystemNotificationsSchema',parentSchemaUId:'a431f7d8-7b5b-41fd-a82f-d9e251144bf3',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SystemNotificationsSchemaCoreForecast",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SystemNotificationsSchemaCrtNUIResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SystemNotificationsSchemaCrtNUI", ["SystemNotificationsSchemaResources", "ConfigurationConstants"],
	function(resources, ConfigurationConstants) {
		return {
			properties: {
				readOnOpenInAngularHost: true
			},
			entitySchemaName: "Reminding",
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseNotificationsSchema#init
				 * @overridden
				 */
				init: function() {
					var isSkipUpdateCounters = true;
					this.callParent(arguments);
					this.markNewNotificationsAsRead(isSkipUpdateCounters);
				},

				/**
				 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationType
				 * @overridden
				 */
				getNotificationType: function() {
					return ConfigurationConstants.Reminding.Notification;
				},

				/**
				 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationGroup
				 * @overridden
				 */
				getNotificationGroup: function() {
					return ConfigurationConstants.NotificationGroup.Notification;
				},
				
				/**
				 * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
				 * @overridden
				 */
				onNotificationSubjectClick: function() {
					var loaderName = this.get("LoaderName");
					if (loaderName !== "FolderConverter") {
						this.callParent(arguments);
						return;
					}
					var schemaName = this.get("SchemaName");
					this.openEntitySection(schemaName);
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "NotificationItemContainer",
					"parentName": "Notification",
					"propertyName": "items",
					"values": {
						"id": "notificationItemContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"selectors": {
							"wrapEl": "#notificationItemContainer"
						},
						"wrapClass": ["system-notification-item-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "NotificationItemTopContainer",
					"parentName": "NotificationItemContainer",
					"propertyName": "items",
					"values": {
						"id": "notificationItemTopContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"selectors": {
							"wrapEl": "#notificationItemTopContainer"
						},
						"wrapClass": ["system-notification-item-top-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "NotificationImage",
					"parentName": "NotificationItemTopContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getNotificationImage",
						"onPhotoChange": Terrasoft.emptyFn,
						"readonly": true,
						"classes": {"wrapClass": ["system-notification-icon-class"]},
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage"
					}
				},
				{
					"operation": "insert",
					"name": "NotificationDate",
					"parentName": "NotificationItemTopContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "getNotificationDate"},
						"classes": {"labelClass": ["subject-text-labelClass"]}
					}
				},
				{
					"operation": "insert",
					"name": "NotificationEntity",
					"parentName": "NotificationItemTopContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "getNotificationEntity"},
						"classes": {"labelClass": ["subject-text-labelClass"]}
					}
				},
				{
					"operation": "insert",
					"name": "NotificationItemBottomContainer",
					"parentName": "NotificationItemContainer",
					"propertyName": "items",
					"values": {
						"id": "notificationItemBottomContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"selectors": {
							"wrapEl": "#notificationItemBottomContainer"
						},
						"wrapClass": ["system-notification-item-bottom-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "NotificationSubjectCaption",
					"parentName": "NotificationItemBottomContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "getNotificationSubjectCaption"},
						"click": {"bindTo": "onNotificationSubjectClick"},
						"classes": {"labelClass": ["subject-text-labelClass", "label-link", "label-url"]},
						"domAttributes": {"bindTo": "getNotificationLinkAttributes"}
					}
				}
			]
		};
	});

define('SystemNotificationsSchemaReportsResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SystemNotificationsSchemaReports", ["PrintReportUtilitiesResources"],
		function(printUtilitiesResources) {
			return {
				entitySchemaName: "Reminding",
				attributes: {
					/**
					 * @private
					 */
					"NotificationConfig": {
						"dataValueType": this.Terrasoft.DataValueType.CUSTOM_OBJECT,
						"value": null
					}
				},
				methods: {
					
					/**
					 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationLinkAttributes
					 * @overridden
					 */
					getNotificationLinkAttributes: function() {
						if (this.isSuccessReportNotification()) {
							return { activelink: true };
						}
						return this.callParent(arguments);
					},
					
					/**
					 * @inheritdoc Terrasoft.BaseNotificationsSchema#onNotificationSubjectClick
					 * @overridden
					 */
					onNotificationSubjectClick: function () {
						if (this.isSuccessReportNotification()) {
							const config = this.getNotificationConfig();
							const href = Ext.String.format("../rest/{0}/{1}/{2}",
									config.serviceName,
									config.methodName,
									config.taskId);
							Terrasoft.download(href, config.reportName);
							return;
						}
						this.callParent(arguments);
					},
					
					/**
					 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationSubjectCaption
					 * @overridden
					 */
					getNotificationSubjectCaption: function() {
						if (this.isReportNotification()) {
							return this.isSuccessReportNotification()
									? this.get("Resources.Strings.ReportNotificationSubject")
									: Ext.String.format(printUtilitiesResources
													.localizableStrings.AsynGenerationErrorPopupBodyTpl,
											this.getNotificationConfig().reportName);
						}
						return this.callParent(arguments);
					},
					
					/**
					 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationEntity
					 * @overridden
					 */
					getNotificationEntity: function() {
						if (this.isReportNotification()) {
							return this.isSuccessReportNotification()
									? Ext.String.format(this.get("Resources.Strings.ReportNotificationHeaderTpl"),
											this.getNotificationConfig().reportName)
									: Terrasoft.emptyString;
						}
						return this.callParent(arguments);
					},
					
					/**
					 * Returns true if report notification.
					 * @protected
					 * @returns {Boolean} True if report notification.
					 */
					isReportNotification: function() {
						return this.get("SchemaName") === "SysModuleReport";
					},
					
					/**
					 * Returns true if success report generation notification.
					 * @protected
					 * @returns {Boolean} True if success report generation notification.
					 */
					isSuccessReportNotification: function() {
						return this.isReportNotification() && this.getNotificationConfig().success;
					},
					
					/**
					 * Returns notification config.
					 * @protected
					 * @returns {String|Object} Notification config.
					 */
					getNotificationConfig: function() {
						if (this.$NotificationConfig) {
							return this.$NotificationConfig;
						}
						const config = this.get("Config");
						try {
							this.$NotificationConfig = JSON.parse(config);
						} catch (e) {
							this.$NotificationConfig = config || {};
						}
						return this.$NotificationConfig;
					},
					
					
					/**
					 * @inheritdoc Terrasoft.BaseNotificationsSchema#addColumns
					 * @overridden
					 */
					addColumns: function(select) {
						this.callParent(arguments);
						select.addColumn("Config");
					}
				},
				diff: []
			};
		});

define('SystemNotificationsSchemaCrtUIv2Resources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SystemNotificationsSchemaCrtUIv2", [], function() {
	return {
		methods: {
			/**
			 * Returns true if license generation notification.
			 * @private
			 * @returns {Boolean} True if license generation notification.
			 */
			_isLicenseNotification: function() {
				return this.get("LoaderName") === "ExpireLicenseNotificationProcess";
			},

			/**
			 * Returns true if it is notification abot app update available.
			 * @private
			 * @returns {Boolean} True if it is notification about app update available.
			 */
			_isAppUpdateAvailableNotification: function() {
				return this.get("LoaderName") === "PushNotificationAboutAppUpdateAvailableProcess";
			},

			/**
			 * Returns notification subject redirect url.
			 * @private
			 * @returns {String} Url to update app if it is single item to update otherwise app hub url.
			 */
			_getNotificationSubjectRedirectUrl: function() {
				if (this._isLicenseNotification()) {
					return Terrasoft.combinePath(Terrasoft.workspaceBaseUrl, "ClientApp/#/LicenseManager");
				}
				if (!this._isAppUpdateAvailableNotification()) {
					return undefined;
				}
				const config = this.getNotificationConfig();
				const appHubUrl = Terrasoft.combinePath(Terrasoft.workspaceBaseUrl, "ClientApp/#/ApplicationManagement");
				return config.isSingleUpdateAvailable
					? Terrasoft.combinePath(appHubUrl, "InstallFromMarketplace", config.marketplaceAppId)
					: appHubUrl;
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				const redirectUrl = this._getNotificationSubjectRedirectUrl();
				if (redirectUrl) {
					window.open(redirectUrl, "_blank");
					return;
				}
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationImage
			 * @overridden
			 */
			getNotificationImage: function() {
				if (this._isAppUpdateAvailableNotification()) {
					imageResource = this.get("Resources.Images.UpdateIsAvailableIcon");
					return this.Terrasoft.ImageUrlBuilder.getUrl(imageResource);
				}
				return this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationLinkAttributes
			 * @overridden
			 */
			getNotificationLinkAttributes: function() {
				if (!this._isLicenseNotification()) {
					return this.callParent(arguments);
				}
				return { activelink: true };
			},
		},
		diff: []
	};
});

define('SystemNotificationsSchemaFileImportResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SystemNotificationsSchemaFileImport", ["TagConstantsV2", "ModuleUtils", "FileImportServiceRequest",
		"css!SystemNotificationsSchemaCSS"], function(TagConstantsV2, ModuleUtils) {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				var loaderName = this.get("LoaderName");
				if (loaderName !== "ImportSession") {
					this.callParent(arguments);
					return;
				}
				var importSessionId = this.get("SubjectId");
				var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "Nui",
						"ViewModule.aspx?vm=FileImportWizard#FileImportModule/FileImportResultPage",
						importSessionId);
				window.open(url, "_blank");
			},

			/**
			 * On import notification link click handler.
			 */
			onImportNotificationLinkClick: function() {
				this.getImportData(this.get("SubjectId"), this.openSectionWithImportTags, this);
			},

			/**
			 * Gets import data.
			 * @private
			 * @param {String} importSessionId Session unique identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			getImportData: function(importSessionId, callback, scope) {
				var config = {
					contractName: "GetImportSessionInfo",
					importSessionId: importSessionId
				};
				var request = this.createFileImportRequest(config);
				request.execute(function(response) {
					this.Ext.callback(callback, scope, [response]);
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#processNotificationsCollection
			 * @overridden
			 */
			processNotificationsCollection: function(notificationsCollection) {
				this.callParent(arguments);
				notificationsCollection.each(function(notification) {
					if (notification.get("LoaderName") === "ImportSession") {
						this.getImportData(notification.get("SubjectId"), function(response) {
							notification.set("ImportedRowsCount", response.importedRowsCount);
							notification.set("TotalRowsCount", response.totalRowsCount);
							notification.set("RootSchemaName", response.rootSchemaName);
						}, this);
					}
				}, this);
			},

			/**
			 * On import notification log link click handler.
			 */
			onImportNotificationLogLinkClick: function() {
				this.sandbox.publish("PushHistoryState", {
					hash: this.Terrasoft.combinePath("LookupSectionModule", "FileImportLookupSection", "ExcelImportLog")
				});
			},

			/**
			 * Returns true if import notification initialized.
			 * @return {Boolean}
			 */
			getIsImportNotificationInitialized: function() {
				return this.get("SubjectId") && this.getIsLoadedFromImport();
			},

			/**
			 * Returns log link visibility.
			 * @return {Boolean} Log link visibility.
			 */
			isImportLogLinkVisible: function() {
				if (!this.getIsImportNotificationInitialized()) {
					return false;
				}
				var totalRowsCount = this.get("TotalRowsCount");
				var importedRowsCount = this.get("ImportedRowsCount");
				return (totalRowsCount !== importedRowsCount);
			},

			/**
			 * Returns data link visibility.
			 * @return {Boolean} Data link visibility.
			 */
			isImportDataLinkVisible: function() {
				var moduleStructure = ModuleUtils.getModuleStructureByName(this.get("RootSchemaName"));
				if (!this.getIsImportNotificationInitialized() || this.Ext.isEmpty(moduleStructure) ||
						this.Ext.isEmpty(moduleStructure.sectionSchema)) {
					return false;
				}
				var importedRowsCount = this.get("ImportedRowsCount");
				return (importedRowsCount > 0);
			},

			/**
			 * Creates file import request.
			 * @private
			 * @param {Object} config File import request config.
			 * @return {Terrasoft.FileImportServiceRequest} File import request.
			 */
			createFileImportRequest: function(config) {
				return this.Ext.create("Terrasoft.FileImportServiceRequest", config);
			},

			/**
			 * Opens section with import tags.
			 * @private
			 * @param {Object} importSessionInfo Import session info.
			 */
			openSectionWithImportTags: function(importSessionInfo) {
				var moduleStructure = ModuleUtils.getModuleStructureByName(importSessionInfo.rootSchemaName);
				var sectionSchema =  moduleStructure.sectionSchema;
				var sectionModule = moduleStructure.sectionModule;
				var storage = Terrasoft.configuration.Storage.Filters = Terrasoft.configuration.Storage.Filters || {};
				var sessionFilters = storage[sectionSchema] = storage[sectionSchema] || {};
				sessionFilters.TagFilters = [{ tags: importSessionInfo.importTags }];
				var historyState = this.sandbox.publish("GetHistoryState");
				var state = historyState.state ? Terrasoft.deepClone(historyState.state): {};
				state.moduleId = sectionModule + '_' + sectionSchema;
				state.moduleName = sectionModule;
   				state.schemaName = sectionSchema;
				this.sandbox.publish("PushHistoryState", {
					stateObj: state,
					hash: this.Terrasoft.combinePath(sectionModule, sectionSchema)
				});
			},

			/**
			 * Returns true if notification loaded from import session.
			 * @private
			 * @return {Boolean}
			 */
			getIsLoadedFromImport: function() {
				return this.get("LoaderName") === "ImportSession";
			},

			/**
			 * Returns true if notification doesn't load from import session.
			 * @private
			 * @return {Boolean}
			 */
			getIsNotLoadedFromImport: function() {
				return !this.getIsLoadedFromImport();
			}
		},
		diff: [
			{
				"operation": "merge",
				"name": "NotificationSubjectCaption",
				"values": {
					"visible": {"bindTo": "getIsNotLoadedFromImport"}
				}
			},
			{
				"operation": "insert",
				"name": "ImportNotificationCaption",
				"parentName": "NotificationItemBottomContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "getNotificationSubjectCaption"},
					"classes": {"labelClass": ["subject-text-labelClass", "import-message"]},
					"visible": {"bindTo": "getIsLoadedFromImport"}
				}
			},
			{
				"operation": "insert",
				"name": "ImportNotificationLogLink",
				"parentName": "NotificationItemBottomContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.ImportNotificationLogLinkCaption"},
					"visible": {"bindTo": "isImportLogLinkVisible"},
					"click": {"bindTo": "onImportNotificationLogLinkClick"},
					"classes": {"labelClass": ["subject-text-labelClass", "label-link", "label-url", "import-message"]}
				}
			},
			{
				"operation": "insert",
				"name": "ImportNotificationLink",
				"parentName": "NotificationItemBottomContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "Resources.Strings.ImportNotificationLinkCaption"},
					"visible": {"bindTo": "isImportDataLinkVisible"},
					"click": {"bindTo": "onImportNotificationLinkClick"},
					"classes": {"labelClass": ["subject-text-labelClass", "label-link", "label-url", "import-message"]}
				}
			}
		]
	};
});

define('SystemNotificationsSchemaSocialLeadGenResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
 define("SystemNotificationsSchemaSocialLeadGen", [], function() {
    return {
        methods: {
            /**
             * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
             * @overridden
             */
            onNotificationSubjectClick: function() {
                var loaderName = this.get("LoaderName");
              	switch(loaderName){
                	case "LeadGenLog":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break;
                    case "LeadGenWebhooks":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings");
               			window.open(url, "_blank");
                  	break; 
                    case "SocialLeadGeneration_ProcessingIncomingMessages":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings");
               			window.open(url, "_blank");
                  	break; 
                     case "SocialLeadGeneration_LoadingLeads":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                     case "SocialLeadGeneration_ConsistencyCheck":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                    break; 
                     case "SocialLeadGeneration_LeadCreation":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                	default:
                    	this.callParent(arguments);
                    	return;
             	}
           }
        },
        diff: []
    };
});
define('SystemNotificationsSchemaCoreForecastResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SystemNotificationsSchemaCoreForecast", ["ConfigurationConstants"], function(Constants) {
	return {
		methods: {
			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationImage
			 * @overridden
			 */
			getNotificationImage: function() {
				if (this._isForecastNotification()) {
					return this.getImageUrlBySchemaName("Forecast");
				} else {
					return this.callParent(arguments);
				}
			},

			/**
			 * @private
			 */
			_isForecastNotification: function() {
				return this.$SchemaName === Constants.Forecast.SchemaName ||
						this.$SchemaName === "ForecastSheet";
			},

			/**
			 * @private
			 */
			_openForecastModule: function() {
				this.sandbox.publish("PushHistoryState", {hash: "ForecastsModule"});
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				if (this._isForecastNotification()) {
					this._openForecastModule();
				} else {
					this.callParent(arguments);
				}
			}
		}
	};
});

define("SystemNotificationsSchema", ["TagConstantsV2", "ModuleUtils", "FileImportServiceRequest",
		"css!SystemNotificationsSchemaCSS"], function(TagConstantsV2, ModuleUtils) {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				var loaderName = this.get("LoaderName");
				if (loaderName !== "ActualizeActiveContactsProcess") {
					this.callParent(arguments);
					return;
				}
				var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "Nui",
					"ViewModule.aspx#DashboardsModule");
				window.open(url, "_blank");
			}
		
		},
		diff: []
	};
});


