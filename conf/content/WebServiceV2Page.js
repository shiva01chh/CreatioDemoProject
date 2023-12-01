﻿Terrasoft.configuration.Structures["WebServiceV2Page"] = {innerHierarchyStack: ["WebServiceV2Page"], structureParent: "BasePageV2"};
define('WebServiceV2PageStructure', ['WebServiceV2PageResources'], function(resources) {return {schemaUId:'09595d4e-0f82-46ba-ad0d-36c7f9f13f02',schemaCaption: "Card schema: \"Web Services\"", parentSchemaName: "BasePageV2", packageName: "ServiceDesigner", schemaName:'WebServiceV2Page',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("WebServiceV2Page", ["WebServiceV2PageResources", "ServiceMetaItemViewModelMixin", "ServiceDesignerUtilities",
		"UriJsonConverter", "JsonServiceMetaDataConverter", "WebServiceWizardWebComponent"],
	function(resources) {
		return {
			entitySchemaName: "VwWebServiceV2",
			mixins: {
				observableItem: "Terrasoft.ObservableItem",
				serviceMetaItemViewModelMixin: "Terrasoft.ServiceMetaItemViewModelMixin"
			},
			messages: {
				/**
				 * Saves ServiceSchema.
				 * @message SaveServiceSchema
				 */
				"SaveServiceSchema": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * Published when ServiceSchema saved.
				 * @message ServiceSchemaSaved
				 */
				"ServiceSchemaSaved": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * Opens service client.
				 * @message OpenServiceClient
				 */
				"OpenServiceClient": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
			},
			properties: {
				useItemInitialValues: true,
				useViewModelToItemBinding: true,
				customEvent: Ext.create("Terrasoft.mixins.CustomEventDomMixin"),
				_openServiceClientEventName: "OpenServiceClient",
				_openAuthenticationPageEventName: "OpenAuthenticationPage"
			},
			attributes: {

				/**
				 * Name.
				 */
				Name: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * Caption.
				 */
				Caption: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * WebService Description.
				 */
				Description: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * WebService URL.
				 */
				BaseUri: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * WebService type.
				 */
				Type: {
					dataValueType: Terrasoft.DataValueType.ENUM,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: Terrasoft.services.enums.ServiceType.REST,
					onChange: "_onTypeChanged",
				},

				/**
				 * WebService type lookup.
				 */
				TypeLookup: {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				},

				/**
				 * Request retry counter.
				 */
				RetryCount: {
					dataValueType: Terrasoft.DataValueType.INTEGER,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Package identifier.
				 */
				PackageUId: {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Current Package Identifier.
				 */
				CurrentPackageUId: {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Custom Package Identifier.
				 */
				CustomPackageUId: {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Package lookup.
				 */
				PackageLookup: {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * Available Packages.
				 */
				AvailablePackages: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Instance of service schema.
				 */
				Schema: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					onChange: "_onSchemaChange"
				},

				/**
				 * Instance of service schema manager item.
				 */
				ManagerItem: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Is allow edit fields.
				 */
				CanEditSchema: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},

				/**
				 * The name of the operation which the user must have access to open the page.
				 */
				SecurityOperationName: {
					dataValueType: Terrasoft.DataValueType.STRING,
					value: "CanManageSolution"
				}
			},
			details: /**SCHEMA_DETAILS*/{
				MethodDetail: {
					schemaName: "WebServiceMethodDetail",
					filter: {
						masterColumn: "Id"
					}
				}
			}/**SCHEMA_DETAILS*/,
			modules: {
				ServiceAuthInfoSettings: {
					moduleId: "ServiceAuthInfoSettingsPageModule",
					moduleName: "ConfigurationModuleV2",
					config: {
						isSchemaConfigInitialized: false,
						schemaName: "ServiceAuthInfoSettingsPage",
						parameters: {
							viewModelConfig: {
								ServiceSchemaUId: {
									attributeValue: "Id"
								}
							}
						},
						useHistoryState: false
					}
				}
			},
			methods: {

				//region Private

				/**
				 * @private
				 */
				_onTypeChanged: function(model, type) {
					this._applyServiceType(type);
				},

				/**
				 * @private
				 */
				_isManagerItemNew: function() {
					var enable = (this.$ManagerItem && this.$ManagerItem.getStatus()) ===
						Terrasoft.ModificationStatus.NEW;
					return enable;
				},

				/**
				 * @private
				 */
				_isManagerItemModified: function() {
					return this.$ManagerItem && this.$ManagerItem.isModified();
				},

				/**
				 * @private
				 */
				_onSchemaChange: function() {
					this.subscribeOnItemChanged(this.$Schema);
					this.$Schema.on("changed", this.updateSaveButton, this);
				},

				/**
				 * @private
				 */
				_applyServiceType: function(type) {
					this.$TypeLookup = {
						value: type,
						displayValue: this._getServiceTypeDisplayValue(type)
					}
				},

				/**
				 * @private
				 */
				_createNewSchema: function(callback, scope) {
					this.$Type = this.getServiceType();
					const defaultProperties = this.getSchemaDefaultProperties();
					Terrasoft.ServiceSchemaManager.createSchemaInstance(defaultProperties, function(schema, managerItem) {
						this.$Schema = schema;
						this._applyServiceType(this.$Type);
						this.applyWizardData();
						this.onServiceSchemaLoaded();
						this.$ManagerItem = managerItem;
						Ext.callback(callback, scope);
					}, this);
				},

				_getServiceTypeDisplayValue: function(serviceType) {
					switch(serviceType) {
						case Terrasoft.services.enums.ServiceType.REST:
							return "REST";
						case Terrasoft.services.enums.ServiceType.SOAP11:
							return "SOAP 1.1";
						case Terrasoft.services.enums.ServiceType.SOAP12:
							return "SOAP 1.2";
					}
				},

				/**
				 * @private
				 */
				_setCanEditSchema: function(callback, scope) {
					Terrasoft.ServiceDesignerUtilities.canEditSchema(this.$Schema, function(result) {
						this.$CanEditSchema = result;
						if (!this.$CanEditSchema) {
							this.unsubscribeAllItems();
							this.showInformationDialog(this.get("Resources.Strings.DenyAccess"));
						}
						Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @private
				 */
				_onManagerItemStatusChanged: function() {
					var showButtons = this._isManagerItemModified() || this._isManagerItemNew();
					this.$ShowSaveButton = showButtons;
					this.$ShowDiscardButton = showButtons;
					this.updateButtonsVisibility();
					this.trigger("change:ManagerItem", this.$ManagerItem);
				},

				/**
				 * @private
				 */
				_initServiceSchema: function(callback, scope) {
					var schemaUId = this.$Id;
					var item = Terrasoft.ServiceSchemaManager.getItems()
						.findByPath("uId", schemaUId);
					if (item) {
						this.$ManagerItem = item;
						item.getInstance(function(instance) {
							this.$Type = instance.type;
							this._applyServiceType(instance.type);
							this.$Schema = instance;
							this.$Schema.saveState();
							this.onServiceSchemaLoaded();
							Ext.callback(callback, scope);
						}, this);
					} else {
						this._createNewSchema(callback, scope);
					}
				},

				/**
				 * @private
				 */
				_initAvailablePackages: function(callback, scope) {
					var schemaPackage = this.$Schema.getPropertyValue("packageUId");
					Terrasoft.chain(
						Terrasoft.PackageManager.getCustomPackageUId,
						function(next, customPackageUId) {
							this.$CustomPackageUId = customPackageUId;
							Terrasoft.PackageManager.getCurrentPackageUId(function(currentPackageUId) {
								this.$CurrentPackageUId = currentPackageUId;
								var packageUIds = [customPackageUId, currentPackageUId];
								if (schemaPackage) {
									packageUIds.push(schemaPackage);
								}
								Terrasoft.PackageManager.getPackageInfo(packageUIds, next, this);
							}, this);
						},
						function(next, packageInfo) {
							Terrasoft.SchemaDesignerUtilities.getAvailablePackages(function(resposne) {
								this.$AvailablePackages = resposne;
								if (!this._isManagerItemNew() && schemaPackage) {
									this.$AvailablePackages[schemaPackage] = packageInfo[schemaPackage];
								}
								Ext.callback(callback, scope);
							}, this);
						},
						this
					);
				},

				_prepareTypeList: function(filter, list) {
					var result = {};
					if(this.$Type === Terrasoft.services.enums.ServiceType.REST) {
						result[Terrasoft.services.enums.ServiceType.REST]= {
							value: Terrasoft.services.enums.ServiceType.REST,
							displayValue: this._getServiceTypeDisplayValue(Terrasoft.services.enums.ServiceType.REST)
						};
					} else {
						result[Terrasoft.services.enums.ServiceType.SOAP12]= {
							value: Terrasoft.services.enums.ServiceType.SOAP12,
							displayValue: this._getServiceTypeDisplayValue(Terrasoft.services.enums.ServiceType.SOAP12)
						};
						result[Terrasoft.services.enums.ServiceType.SOAP11]= {
							value: Terrasoft.services.enums.ServiceType.SOAP11,
							displayValue: this._getServiceTypeDisplayValue(Terrasoft.services.enums.ServiceType.SOAP11)
						};
					}
					list.reloadAll(result);
				},

				/**
				 * @private
				 */
				_preparePackageList: function(filter, list) {
					var result = {};
					Terrasoft.each(this.$AvailablePackages, function(name, uId) {
						result[uId] = {
							value: uId,
							displayValue: name
						};
					}, this);
					list.reloadAll(result);
				},

				/**
				 * @private
				 */
				_getPackageUIdFromHistoryState: function() {
					var historyState = this.sandbox.publish("GetHistoryState");
					var packageUId = "";
					if (historyState && historyState.hash) {
						var hash = historyState.hash;
						var packageFromHistoryState = this.Terrasoft.find(hash.valuePairs, function(item) {
							return item.name === "packageUId";
						}, this);
						packageUId = packageFromHistoryState && packageFromHistoryState.value;
					}
					return packageUId;
				},

				/**
				 * @private
				 */
				_initPackageLookup: function() {
					var packageUId;
					var packageUIdFromHistoryState = this._getPackageUIdFromHistoryState();
					if (this._isManagerItemNew() && packageUIdFromHistoryState) {
						packageUId = packageUIdFromHistoryState;
					} else if (this._isManagerItemNew() && this.$CurrentPackageUId &&
						this.$AvailablePackages[this.$CurrentPackageUId]) {
						packageUId = this.$CurrentPackageUId;
					} else if (this._isManagerItemNew() && this.$CustomPackageUId &&
						this.$AvailablePackages[this.$CustomPackageUId]) {
						packageUId = this.$CustomPackageUId;
					} else if (this.$Schema && !this._isManagerItemNew()) {
						packageUId = this.$Schema.getPropertyValue("packageUId");
					} else {
						packageUId = _.keys(this.$AvailablePackages)[0];
					}
					if (packageUId) {
						this.$PackageLookup = {
							value: packageUId,
							displayValue: this.$AvailablePackages[packageUId]
						};
					} else {
						this.$PackageLookup = null;
					}
				},

				/**
				 * @private
				 */
				_isOAuth20AuthType: function() {
					const authInfo = this.$Schema.authInfo;
					const application = authInfo.values.find("applicationId");
					return authInfo.authType === Terrasoft.services.enums.AuthType.OAuth20 &&
							application && application.value;
				},

				/**
				 * @private
				 */
				_onPackageLookupChanged: function() {
					this.$PackageUId = this.$PackageLookup && this.$PackageLookup.value;
				},

				/**
				 * @private
				 */
				_onTypeLookupChanged: function() {
					this.$Type = this.$TypeLookup && this.$TypeLookup.value;
				},

				/**
				 * @private
				 */
				_validateAvailablePackages: function() {
					var result = true;
					if (this._isManagerItemNew() && Ext.Object.isEmpty(this.$AvailablePackages)) {
						var config = {
							buttons: [{
								className: "Terrasoft.Button",
								returnCode: "OpenAdvancedSettings",
								style: "blue",
								caption: this.get("Resources.Strings.OpenAdvancedSettings")
							}, "cancel"]
						};
						this.showInformationDialog(this.get("Resources.Strings.NoAvailablePackages"), function(code) {
							if (code === "OpenAdvancedSettings") {
								var url = Terrasoft.workspaceBaseUrl +
									"/ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a";
								window.open(url, "_blank");
							}
						}, config);
						result = false;
					}
					return result;
				},

				/**
				 * @private
				 */
				_getOAuthApplicationDataBindingColumns: function() {
					return [
						"Name",
						"ClientClassName",
						"RevokeTokenUrl",
						"UseSharedUser",
						"TokenUrl",
						"AppClassName",
						"AuthorizeUrl",
						"Image",
						"CredentialsLocationInRequest"
					];
				},

				/**
				 * @private
				 */
				_updateBaseUriUserProperty: function(uri, callback, scope) {
					Terrasoft.ProcessSchemaDesignerUtilities.getSchemaIdByUId(this.$Id, function(schemaId) {
						var config = {
							schemaId: schemaId,
							propertyName: "BaseUri",
							propertyValue: uri,
							managerName: "ServiceSchemaManager"
						};
						Terrasoft.SysUserPropertyHelper.setProperty(config, function(response) {
							if (response.success) {
								this.$BaseUri = uri;
							}
							Ext.callback(callback, scope);
						}, this);
					}, this);
				},

				/**
				 * @private
				 */
				_updateSysSettingsPackageData: function(codes, callback, scope) {
					if (!Ext.isEmpty(codes)) {
						const esq = new Terrasoft.EntitySchemaQuery("VwSysSetting");
						esq.filters.addItem(esq.createColumnInFilterWithParameters("Code", codes));
						const packageSchemaDataName = "WebService_SysSettings_" + this.$Schema.name;
						esq.getEntityCollection(function(response) {
							if (response.success) {
								Terrasoft.SchemaDesignerUtilities.updatePackageSchemaData({
									recordList: response.collection.getKeys(),
									entitySchemaName: "SysSettings",
									packageUId: this.$Schema.packageUId,
									packageSchemaDataName: packageSchemaDataName
								}, callback, scope);
							} else {
								Ext.callback(callback, scope);
							}
						}, this);
					} else {
						Ext.callback(callback, scope);
					}
				},

				/**
				 * @private
				 */
				_updateOAuthAuthenticationPackageData: function(callback, scope) {
					Terrasoft.chain(
						this._updateOAuthApplicationPackageData,
						this._updateOAuthScopesPackageData,
						this._updateOAuthIconPackageData,
						function() {
							Ext.callback(callback, scope);
						}, this);
				},

				/**
				 * @private
				 */
				_updateOAuthApplicationPackageData: function(callback, scope) {
					const packageSchemaDataName = "WebService_OAuthApplications_" + this.$Schema.name;
					Terrasoft.SchemaDesignerUtilities.updatePackageSchemaData({
						recordList: [this._getApplicationId()],
						entitySchemaName: "OAuthApplications",
						packageUId: this.$Schema.packageUId,
						packageSchemaDataName: packageSchemaDataName,
						columns: this._getOAuthApplicationDataBindingColumns()
					}, callback, scope || this);
				},

				/**
				 * @private
				 */
				_updateOAuthScopesPackageData: function(callback, scope) {
					const esq = new Terrasoft.EntitySchemaQuery("OAuthAppScope");
					esq.filters.addItem(esq.createColumnInFilterWithParameters("OAuth20App",
							[this._getApplicationId()]));
					const packageSchemaDataName = "WebService_OAuthAppScope_" + this.$Schema.name;
					esq.getEntityCollection(function(response) {
						if (response.success && !response.collection.isEmpty()) {
							Terrasoft.SchemaDesignerUtilities.updatePackageSchemaData({
								recordList: response.collection.getKeys(),
								entitySchemaName: "OAuthAppScope",
								packageUId: this.$Schema.packageUId,
								packageSchemaDataName: packageSchemaDataName
							}, callback, scope || this);
						} else {
							Ext.callback(callback, scope || this);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_updateOAuthIconPackageData: function(callback, scope) {
					const esq = new Terrasoft.EntitySchemaQuery("OAuthApplications");
					esq.addColumn("ImageId");
					const packageSchemaDataName = "WebService_OAuthIcon_SysImage_" + this.$Schema.name;
					esq.getEntity(this._getApplicationId(), function(response) {
						if (response.success && !Ext.isEmpty(response.entity.$Image)) {
							Terrasoft.SchemaDesignerUtilities.updatePackageSchemaData({
								recordList: [response.entity.$Image.value],
								entitySchemaName: "SysImage",
								packageUId: this.$Schema.packageUId,
								packageSchemaDataName: packageSchemaDataName
							}, callback, scope || this);
						} else {
							Ext.callback(callback, scope || this);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_updateServicePackageData: function(callback, scope) {
					Terrasoft.chain(
						function(next) {
							const codes = this.$Schema.getServiceSysSettingsCollection();
							this._updateSysSettingsPackageData(codes, next, scope);
						},
						function() {
							if (this._isOAuth20AuthType()) {
								this._updateOAuthAuthenticationPackageData(callback, scope);
							} else {
								Ext.callback(callback, scope);
							}
						}, this);
				},

				/**
				 * @private
				 */
				_getApplicationId: function() {
					const authInfo = this.$Schema.authInfo;
					const application = authInfo.values.find("applicationId");
					return application.value;
				},

				/**
				 * Reloads workspace explorer items using BroadcastChannel api.
				 */
				_reloadWorkspaceExplorer: function() {
					const channel = new BroadcastChannel2('workspace-explorer-items-reload');
					channel.postMessage();
				},

				/**
				 * Returns map of service client localisations.
				 */
				_getWebServiceTranslation: function() {
					return {
						"ServiceClientHeaderCaption": this.get("Resources.Strings.ServiceClientHeaderCaption"),
						"OpenAuthenticationSettingsButtonCaption": this.get("Resources.Strings.OpenAuthenticationSettingsButtonCaption"),
						"ServiceClientRequestTabCaption": this.get("Resources.Strings.ServiceClientRequestTabCaption"),
						"ServiceClientRequestPrompt": this.get("Resources.Strings.ServiceClientRequestPrompt"),
						"ServiceClientRequestParameters": this.get("Resources.Strings.ServiceClientRequestParameters"),
						"ServiceClientResponseTabCaption": this.get("Resources.Strings.ServiceClientResponseTabCaption"),
						"TreeHeaderValueColumnCaption": this.get("Resources.Strings.TreeHeaderValueColumnCaption"),
						"SendRequestButtonCaption": this.get("Resources.Strings.SendRequestButtonCaption"),
						"RequestParametersEmptyMessage": this.get("Resources.Strings.RequestParametersEmptyMessage"),
						"ServiceClientErrorTabCaption": this.get("Resources.Strings.ServiceClientErrorTabCaption"),
						"ServiceClientErrorTabInfo": this.get("Resources.Strings.ServiceClientErrorTabInfo"),
						"ServiceClientParameterPlaceholder": this.get("Resources.Strings.ServiceClientParameterPlaceholder"),
						"ServiceClientRawRequesCaption": this.get("Resources.Strings.ServiceClientRawRequesCaption"),
						"ServiceClientRawResponseCaption": this.get("Resources.Strings.ServiceClientRawResponseCaption")
					};
				},

				/**
				 * Inits custom event.
				 */
				_initCustomEvent: function() {
					this.customEvent.init();
					this.customEvent.subscribe(this._openAuthenticationPageEventName)
						.subscribe((wizardResult) => {
							this._onOpenAuthenticationPage();
						});
					const translation = this._getWebServiceTranslation();
					this.customEvent.publish("GetWebServiceTranslation", translation);
				},

				/**
				 * Opens auth tab in a separate window by event emit subscription
				 * @private
				 */
				_onOpenAuthenticationPage() {
					const historyState = this.sandbox.publish("GetHistoryState");
					let schemaName = historyState.state.schemaName;
					if (!schemaName) {
						schemaName = historyState.hash.entityName;
					}
					const authenticationPageUrl = Terrasoft.combinePath(Terrasoft.workspaceBaseUrl,
						"Nui/ViewModule.aspx#CardModuleV2", schemaName, "edit", this.$Id,
						"ActiveTab/AuthTab");
					window.open(authenticationPageUrl);
				},

				//endregion

				//region Protected

				/**
				 * @protected
				 */
				applyWizardData: Terrasoft.emptyFn,

				/**
				 * @protected
				 */
				onServiceSchemaLoaded: function () {
					const state = this.sandbox.publish("GetHistoryState");
					if (state.hash.valuePairs && state.hash.valuePairs[0].name === "ActiveTab") {
						this.set("ActiveTabName", state.hash.valuePairs[0].value);
					}
				},

				/**
				 * @protected
				 */
				getServiceType: function() {
					return this.initialConfig && this.initialConfig.values && this.initialConfig.values.serviceType;
				},

				/**
				 * @protected
				 */
				getDefaultMethodConfig: function(schema) {
					return {
						uId: Terrasoft.generateGUID(),
						_serviceSchema: schema
					}
				},

				/**
				 * @protected
				 */
				getSchemaDefaultProperties: function() {
					return {
						uId: this.$Id,
						realUId: this.$Id,
						baseUri: "",
						type: this.$Type
					};
				},

				/**
				 * @protected
				 */
				updateSaveButton: function() {
					if (!this.destroyed) {
						this.$ShowSaveButton = this._isManagerItemModified() && this.$CanEditSchema;
						this.updateButtonsVisibility(this.$ShowSaveButton);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onItemFocused.
				 * @override
				 */
				onItemFocused: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#getColumnCaptionByName.
				 * @override
				 */
				getColumnCaptionByName: function(name) {
					return name === "BaseUri"
						? this.get("Resources.Strings.BaseUriCaption")
						: this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.ServiceMetaItemViewModelMixin#duplicateNameValidator.
				 * @override
				 */
				duplicateNameValidator: function(schemaName) {
					var message = "";
					var items = Terrasoft.ServiceSchemaManager.getItems();
					var duplicateItem = items.findByPath("name", schemaName);
					if (duplicateItem &&
						duplicateItem.uId &&
						duplicateItem.uId !== this.$Schema.uId) {
						message = this.get("Resources.Strings.DuplicateNameMessage");
					}
					return {invalidMessage: message};
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#setValidationConfig
				 * @override
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.setNameValidationConfig();
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @override
				 */
				initEntity: function(callback, scope) {
					this.callParent([function() {
						this.$Id = this.$PrimaryColumnValue || this.$Id || Terrasoft.generateGUID();
						Terrasoft.ServiceSchemaManager.initialize(function() {
							this._initServiceSchema(function() {
								this.$ManagerItem.on("statusChanged", this._onManagerItemStatusChanged, this);
								this._initAvailablePackages(function() {
									this._initPackageLookup();
									if (this._validateAvailablePackages()) {
										this._setCanEditSchema(callback, scope);
									} else {
										Ext.callback(callback, scope);
									}
								}, this);
							}, this);
						}, this);
					}, this]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#copyEntity
				 * @override
				 */
				copyEntity: function(sourceServiceUId, callback, scope) {
					Terrasoft.ServiceSchemaManager.getInstanceByUId(sourceServiceUId, function(sourceService) {
						var item = Terrasoft.ServiceSchemaManager.copySchema(sourceService);
						this.$Id = this.$PrimaryColumnValue = item.uId;
						Ext.callback(callback, scope, [this]);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.ObservableItem#getAttributeMap
				 * @override
				 */
				getAttributeMap: function() {
					return {
						caption: "Caption",
						name: "Name",
						description: "Description",
						baseUri: "BaseUri",
						retryCount: "RetryCount",
						type: "Type",
						packageUId: "PackageUId"
					};
				},

				/**
				 * @inheritdoc Terrasoft.BaseObject#onDestroy
				 * @override
				 */
				onDestroy: function() {
					this.customEvent.destroy();
					this.unsubscribeAllItems();
					if (this.$Schema) {
						this.$Schema.un("changed", this.updateSaveButton, this);
						this.$ManagerItem.un("statusChanged", this._onManagerItemStatusChanged, this);
						this.$Schema.restoreState();
					}
					Terrasoft.ServiceDesignerUtilities.clearSysSettings();
					this.callParent(arguments);
				},

				discardSchemaChanges: function() {
					this.$Schema.restoreState();
				},

				internalSave: function(callback, scope) {
					this.showBodyMask({
						additionalClass: 'save-service-schema-mask'
					});
					this.$ManagerItem.setStatus(Terrasoft.ModificationStatus.MODIFIED);
					this.$ManagerItem.save({}, function(response) {
						this.hideBodyMask();
						if (!response.success) {
							this.showInformationDialog(response.errorInfo.toString());
							Ext.callback(callback, scope, [false]);
							return;
						}
						if (!this.destroyed) {
							this.updateButtonsVisibility(false, {force: true});
						}
						this.changedValues = {};
						this.$Schema.saveState();
						this.sendSaveCardModuleResponse(response.success);
						this._updateServicePackageData(callback, scope);
						this._reloadWorkspaceExplorer();
					}, this);
				},

				onSaveServiceSchemaMessage: function(MethodUId) {
					this.internalSave(function(saveResult) {
						if (saveResult !== false) {
							this.openServiceClient(MethodUId);
						}
					}, this);
				},

				subscribeSandboxEvents: function() {
					this.sandbox.subscribe("SaveServiceSchema", this.onSaveServiceSchemaMessage, this);
					this.sandbox.subscribe("OpenServiceClient", this.onOpenServiceClient, this);
					this.callParent(arguments);
				},

				//endregion

				//region Public

				/**
				 * @inheritdoc Terrasoft.BaseEntityPage#save
				 * @override
				 */
				save: function(callback, scope) {
					this.asyncValidate(function(validationResponse) {
						if (this.validateResponse(validationResponse)) {
							this.internalSave(callback,scope);
						} else {
							Ext.callback(callback, scope);
						}
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @override
				 */
				init: function(callback, scope) {
					var parentMethod = this.getParentMethod();
					this._initCustomEvent();
					Terrasoft.ServiceSchemaManager.reInitialize(function() {
						parentMethod.apply(this, [function() {
							this.on("change:PackageLookup", this._onPackageLookupChanged, this);
							this.on("change:TypeLookup", this._onTypeLookupChanged, this);
							Terrasoft.ServiceDesignerUtilities.initSysSettings(function() {
								Ext.callback(callback, scope);
							}, Terrasoft.ServiceDesignerUtilities);
						}, this]);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onDiscardChangesClick
				 * @override
				 */
				onDiscardChangesClick: function() {
					if (!this._isManagerItemNew()) {
						this.discardSchemaChanges();
						this.$ShowDiscardButton = false;
						this.$ManagerItem.setStatus(Terrasoft.ModificationStatus.NOT_MODIFIED);
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.ContextHelpMixin#getContextHelpConfig.
				 * @override
				 */
				getContextHelpConfig: function() {
					return {
						contextHelpId: "1862",
						contextHelpCode: "WebServiceV2Section"
					};
				},

				/**
				 * @inheritdoc BasePageV2#isChanged
				 * @overridden
				 */
				isChanged: function() {
					return this.$ManagerItem.getStatus() !== Terrasoft.ModificationStatus.NOT_MODIFIED &&
						this.$CanEditSchema;
				},

				/**
				 * Updates base uri property.
				 */
				changeURI: function(callback, scope) {
					//TODO: initial bindind calls function
					if (Ext.isString(callback)) {
						return;
					}
					Terrasoft.showInputBox(null, function(buttonCode, values) {
						if (buttonCode === "ok") {
							var uri = values.uri.value;
							this._updateBaseUriUserProperty(uri, callback, scope);
						} else {
							Ext.callback(callback, scope);
						}
					}, ["ok", "cancel"], this, {
						uri: {
							dataValueType: Terrasoft.DataValueType.TEXT,
							caption: this.get("Resources.Strings.BaseUriCaption"),
							value: this.$BaseUri,
							isRequired: true,
							customConfig: {focused: true}
						}
					});
				},

				/**
				 * Opens service test window for given service method
				 */
				openServiceClient: function(MethodUId) {
					const serializedSchema = this.$Schema.serialize();
					const schemaDto = JSON.parse(serializedSchema);
					const payloadData = {
						serviceSchemaDto: schemaDto,
						methodUId: MethodUId
					};
					this.customEvent.publish(this._openServiceClientEventName, payloadData);
				},

				onOpenServiceClient: function(MethodUId) {
					if (this.$ManagerItem.getStatus() === Terrasoft.ModificationStatus.NOT_MODIFIED) {
						this.openServiceClient(MethodUId);
						return;
					}
					const message = this.get("Resources.Strings.SeveServiceSchemaForServiceClientMessage");
					this.showConfirmationDialog(message, function(result) {
						if (result !== this.Terrasoft.MessageBoxButtons.YES.returnCode) {
							return;
						}
						this.onSaveServiceSchemaMessage(MethodUId);
					}, ["yes", "no"]);
				},

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "CardContentContainer",
					"values": {
						"wrapClass": ["web-service-card-content-container", "center-main-container"]
					}
				},
				{
					"operation": "insert",
					"name": "Caption",
					"values": {
						"layout": {"column": 0, "row": 0, "colSpan": 12},
						"bindTo": "Caption",
						"caption": {"bindTo": "Resources.Strings.CaptionCaption"},
						"enabled": {
							"bindTo": "CanEditSchema"
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {"column": 0, "row": 1, "colSpan": 12},
						"bindTo": "Name",
						"caption": "$Resources.Strings.NameCaption",
						"enabled": "$CanEditSchema",
						"tip": {"content": "$Resources.Strings.CodeHint"}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"layout": {"column": 0, "row": 2, "colSpan": 12, "rowSpan": 2},
						"bindTo": "Description",
						"caption": "$Resources.Strings.DescriptionCaption",
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"enabled": "$CanEditSchema"
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "BaseUri",
					"values": {
						"layout": {"column": 12, "row": 0, "colSpan": 12},
						"bindTo": "BaseUri",
						"caption": {"bindTo": "Resources.Strings.BaseUriCaption"},
						"tip": {"content": "$Resources.Strings.UriHint"},
						"rightIconClick": "$changeURI",
						"controlConfig": {
							"enableRightIcon": {
								"bindTo": "CanEditSchema",
								"bindConfig": {"converter": "invertBooleanValue"}
							},
							"rightIconConfig": resources.localizableImages.EditIcon,
							"readonly": {
								"bindTo": "CanEditSchema",
								"bindConfig": {"converter": "invertBooleanValue"}
							},
							"markerValue": "BaseUri"
						}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Type",
					"values": {
						"layout": {"column": 12, "row": 2, "colSpan": 12},
						"bindTo": "TypeLookup",
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"caption": {"bindTo": "Resources.Strings.TypeCaption"},
						"controlConfig": {
							"prepareList": "$_prepareTypeList",
						},
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "RetryCount",
					"values": {
						"layout": {"column": 12, "row": 1, "colSpan": 12},
						"bindTo": "RetryCount",
						"caption": {"bindTo": "Resources.Strings.RetryCountCaption"},
						"enabled": "$CanEditSchema",
						"tip": {"content": "$Resources.Strings.RetiresHint"}
					},
					"parentName": "Header",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "PackageLookup",
					"values": {
						"layout": {"column": 12, "row": 3, "colSpan": 12},
						"caption": "$Resources.Strings.PackageNameCaption",
						"dataValueType": Terrasoft.DataValueType.ENUM,
						"controlConfig": {
							"className": "Terrasoft.ComboBoxEdit",
							"prepareList": "$_preparePackageList",
							"enabled": {
								"bindTo": "ManagerItem",
								"bindConfig": {"converter": "_isManagerItemNew"}
							}
						},
						"tip": {"content": "$Resources.Strings.PackageHint"}
					}
				},
				{
					"operation": "insert",
					"name": "Methods",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 0,
					"values": {
						"caption": "$Resources.Strings.MethodsTabCaption",
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "Methods",
					"propertyName": "items",
					"name": "MethodDetail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"name": "AuthTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.AuthCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "AuthTab",
					"name": "ServiceAuthInfoSettings",
					"propertyName": "items",
					"values": {
						"classes": {
							"wrapClassName": ["control-width-15", "control-left", "grid-layout-row",
								"module-container", "auth-info-setup-container"]
						},
						"itemType": Terrasoft.ViewItemType.MODULE
					}
				},
				{
					"operation": "insert",
					"name": "NgWebServiceWizardWebComponent",
					"parentName": "CardContentWrapper",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": Terrasoft.ViewItemType.COMPONENT,
						"visible": {"bindTo": "IsSeparateMode"},
						"className": "Terrasoft.WebServiceWizardWebComponent"
					}
				},
			]/**SCHEMA_DIFF*/
		};
	});


