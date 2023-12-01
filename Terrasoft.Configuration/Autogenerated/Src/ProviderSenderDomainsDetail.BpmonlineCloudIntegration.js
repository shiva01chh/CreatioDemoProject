﻿ define("ProviderSenderDomainsDetail", ["ProviderSenderDomainsDetailResources", "ConfigurationGridUtilities",
		"ConfigurationGrid", "BpmonlineCloudServiceApi", "BpmonlineCloudIntegrationEnums", "ContainerList",
		"ContainerListGenerator"],
	function(resources) {
		return {
			entitySchemaName: "DomainInfo",
			messages: {
				/**
				 * @message GetSenderDomainsInfo
				 * Gets the sender domains info.
				 */
				"GetSenderDomainsInfo": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message DomainSelected
				 * Domain selected.
				 */
				"DomainSelected": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {
				/**
				 * Active item identifier.
				 */
				"SelectedProviderId": {
					dataValueType: this.Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Replica collection.
				 */
				"ProvidersCollection": {
					columnPath: "ProvidersCollection",
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					isCollection: true,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				IsEditable: {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: true
				},
			},
			mixins: {
				ConfigurationGridUtilities: "Terrasoft.ConfigurationGridUtilities"
			},
			methods: {

				/**
				 * Creates row from domain and adds it to collection.
				 * @param {Object} domainInfo The senders domain info.
				 * @param {Terrasoft.Collection} collection.
				 */
				 addDomainToCollection: function(domainInfo, collection, isLastItem, domainsCount) {
					var id = this.Terrasoft.generateGUID();
					this.createNewRow(id, null, function(row) {
						this.applyDomainInfo(row, domainInfo);
						collection.add(id, row);
						if (isLastItem && collection.collection.length == domainsCount) {
							this.fillGridData(collection);
						}
					});
				},

				/**
				 * Applies domain info to the row.
				 * @param {Terrasoft.BaseViewModel} row Row to be saved.
				 * @param {Object} domainInfo The senders domain info.
				 */
				applyDomainInfo: function(row, domainInfo) {
					var status = this.getIsDKIMVerified(domainInfo.Status);
					row.set("Domain", domainInfo.Domain);
					row.set("Key", domainInfo.Key);
					row.set("SpfKey", domainInfo.SpfKey);
					row.set("Mx", domainInfo.Mx);
					row.set("DKIMVerified", status);
					row.set("IsNew", false);
				},

				/**
				 * Fills grid data by domains info.
				 * @param {Array[]} domains.
				 */
				fillGridDataByDomainsInfo: function(domains) {
					var collection = this.Ext.create("Terrasoft.Collection");
					this.Terrasoft.each(domains, function(domainInfo) {
						var currentIndex = domains.indexOf(domainInfo);
						var isLastItem = currentIndex == domains.length - 1;
						this.addDomainToCollection(domainInfo, collection, isLastItem, domains.length);
					}, this);
				},

				/**
				 * Is last domain index.
				 * @param {Number} errorCode Error code.
				 * @param {String} errorMessage Error message.
				 */
				isLastDomainIndex: function(domains, domainInfo, collection) {
					var currentIndex = domains.indexOf(domainInfo);
					var isLastItem = currentIndex == domains.length - 1;
					return isLastItem
				},

				/**
				 * Determines that is status is active or not.
				 * @param {String} status.
				 * @return {Boolean}.
				 */
				getIsDKIMVerified: function(status) {
					return status === "active";
				},

				/**
				 * Handles the senders domain info.
				 * @param {Object} domainsInfo The senders domain info.
				 */
				onGetDomainsInfo: function(domainsInfo) {
					if(!domainsInfo.Domains) {
						this.fillGridData(null);
					} else {
						this.fillGridDataByDomainsInfo(domainsInfo.Domains);
					}
				},

				/**
				 * Fills frid by the specified domain data.
				 * @param {Array[]} collection The specified domain data.
				 */
				 fillGridData: function(collection) {
					this.onGridDataLoaded({
						collection: collection,
						success: true
					});
				},

				/**
				 * Gets the sender domains info.
				 */
				getDomainsInfo: function() {
					var data = {
						callback: this.onGetDomainsInfo,
						providerName: this.getSelectedProviderName(),
						scope: this
					};
					this.sandbox.publish("GetSenderDomainsInfo", data, [this.sandbox.id]);
				},
				
				getSelectedProviderName: function() {
					return this.$SelectedProviderId
						? this.$ProvidersCollection.get(this.$SelectedProviderId).$Name
						: this.$ProvidersCollection.first().$Name;
				},

				/**
				 * Saves domain.
				 * @param {Terrasoft.BaseViewModel} row Row to be saved.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Execution context.
				 */
				saveDomain: function(row, callback, scope) {
					var domain = row.get("Domain");
					var activeProviderName = this.$ProvidersCollection.get(this.$SelectedProviderId).$Name;
					var data = {
						addSenderDomainsInfoRequest: {
							domain: domain,
							providerName: activeProviderName
						}
					};
					Terrasoft.BpmonlineCloudServiceApi.addSenderDomainsInfoByProvider(data, function(response) {
						var domainsInfo = response.DomainsInfo;
						var responseCode = Terrasoft.BpmonlineCloudIntegration.enums.ResponseCode;
						var isSuccess = (domainsInfo && (domainsInfo.Code === responseCode.SUCCESS)
							&& !this.Ext.isEmpty(domainsInfo.Domains));
						if (isSuccess) {
							var domains = domainsInfo.Domains;
							var domainInfo = {};
							domains.forEach(function (item) {
								if (item.Domain === domain) {
									domainInfo = item;
								}
							});
							this.onSaveDomainSuccess(row, domainInfo, callback, scope);
						} else {
							var errorCode = (domainsInfo.Code || responseCode.SERVICE_UNAVAILABLE);
							this.onSaveDomainError(errorCode, domainsInfo.Message);
						}
					}, this);
				},

				/**
				 * Handles click event on replica item.
				 * @param {Guid} itemId Selected item identifier.
				 */
				onItemClick: function(itemId) {
					if (itemId === this.$SelectedProviderId) {
						return;
					}
					this.$SelectedProviderId = itemId;
					this.showBodyMask();
					this.reloadGridData();
				},

				/**
				 * On "Save" success handler.
				 * @param {Terrasoft.BaseViewModel} row.
				 * @param {Object} domainInfo The senders domain info.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Execution context.
				 */
				onSaveDomainSuccess: function(row, domainInfo, callback, scope) {
					this.applyDomainInfo(row, domainInfo);
					this.Ext.callback(callback, scope || this);
				},

				/**
				 * On "Save" error handler.
				 * @param {Number} errorCode Error code.
				 * @param {String} errorMessage Error message.
				 */
				onSaveDomainError: function(errorCode, errorMessage) {
					var message = Terrasoft.BpmonlineCloudServiceApi.getMessageByResponseCode(errorCode);
					message = this.Ext.String.format(message, errorMessage || "");
					this.showInformationDialog(message);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#loadGridData
				 * @overridden
				 */
				loadGridData: function() {
					if (this.$SelectedProviderId) {
						this.getDomainsInfo();
					} else {
						this.$SelectedProviderId = null;
						this.$ProvidersCollection = this.Ext.create("Terrasoft.BaseViewModelCollection");
						this.fillAvailableProviders(function() {
							this.selectFirstProviderItem();
						}, this);
					}
				},

				/**
				 * Select first replica item.
				 * @protected
				 */
				selectFirstProviderItem: function() {
					var firstItem = this.$ProvidersCollection.first();
					if (firstItem) {
						this.onItemClick(firstItem.$Id);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addColumnLink
				 * @overridden
				 */
				addColumnLink: Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#sortColumn
				 * @overridden
				 */
				sortColumn: Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#onDetailCollapsedChanged
				 * @overridden
				 */
				onDetailCollapsedChanged: Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#onUpdateItem
				 * @overridden
				 */
				onUpdateItem: Ext.emptyFn,

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#getIsRowChanged
				 * @overridden
				 */
				getIsRowChanged: function(row) {
					return (row instanceof Terrasoft.BaseViewModel) && row.get("IsNew");
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#initCanLoadMoreData
				 * @overridden
				 */
				initCanLoadMoreData: function() {
					this.set("CanLoadMoreData", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getToolsVisible
				 * @overridden
				 */
				getToolsVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getAddRecordButtonVisible
				 * @overridden
				 */
				getAddRecordButtonVisible: function() {
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getIsCardValid
				 * @overridden
				 */
				getIsCardValid: function() {
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#initDetailOptions
				 * @overridden
				 */
				initDetailOptions: function() {
					this.set("IsDetailCollapsed", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
				 * @override
				 */
				onRender: function() {
					this.callParent(arguments);
					this.selectFirstProviderItem();
				},

				fillAvailableProviders: function(callback, scope) {
					var serviceConfig = {
						serviceName: "MailingService",
						methodName: "GetAvailableProviders",
						data: null
					};
					this.callService(serviceConfig, function(response) {
						if (response && response.availableProviders) {
							var tempCollection = Ext.create("Terrasoft.BaseViewModelCollection");
							this.Terrasoft.each(response.availableProviders, function (sourceItem) {
								if (sourceItem.isConnected) {
									var tempItem = this.createItemViewModel(sourceItem);
									tempCollection.add(tempItem.$Id, tempItem);
								}
							}, this);
							this.$ProvidersCollection.clear();
							this.$ProvidersCollection.loadAll(tempCollection);
							if (callback) {
								callback.call(scope);
							}
						}
					});
				},

				/**
				 * Creates item view model.
				 * @param {Object} item Item data values.
				 * @return {Terrasoft.BaseModel} Item view model.
				 */
				createItemViewModel: function(item) {
					var id = Terrasoft.generateGUID();
					return this.Ext.create("Terrasoft.BaseModel", {
						values: {
							Id: id,
							Name: item.providerName
						}
					});
				},

				reloadDetailData: function() {
					this.reloadGridData();
					this.fillAvailableProviders(this.selectFirstProviderItem, this);
				},

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#systemColumns
				 * @overridden
				 */
				systemColumns: ["Id", "DKIMVerified"],

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#getCellControlsConfig
				 * @overridden
				 */
				getCellControlsConfig: function(entitySchemaColumn) {
					var config = this.mixins.ConfigurationGridUtilities.getCellControlsConfig.apply(this, arguments);
					if (!this.Ext.Array.contains(this.systemColumns, entitySchemaColumn.name)) {
						config.enabled = {bindTo: "IsNew"};
					}
					return config;
				},

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#saveRowChanges
				 * @overridden
				 */
				saveRowChanges: function(row, callback, scope) {
					if (row && this.getIsRowChanged(row)) {
						if (row.validate()) {
							this.saveDomain(row, callback, scope);
						} else {
							var message = row.getValidationMessage();
							this.showInformationDialog(message);
						}
					} else {
						this.Ext.callback(callback, scope || this);
					}
				},

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#onActiveRowAction
				 * @overridden
				 */
				onActiveRowAction: function(tag, rowId) {
					switch (tag) {
						case "cancel":
							this.discardChanges(rowId);
							break;
						case "save":
							this.onActiveRowSave(rowId);
							break;
					}
				},

				/**
				 * Handles "selectRow" event of the DataGrid.
				 * @param {String} domainId Identifier of the selected domain.
				 * @private
				 */
				rowSelected: function(domainId) {
					var domains = this.get("Collection");
					if (domains instanceof this.Terrasoft.Collection && domains.contains(domainId)) {
						var domain = domains.get(domainId);
						this.sandbox.publish("DomainSelected", domain, [this.sandbox.id]);
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "SenderDomainsInnerContainer",
					"parentName": "Detail",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["provider-list-inner-container"]
						},
						"items": []
					},
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "SenderDomainsLeftContainer",
					"parentName": "SenderDomainsInnerContainer",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["provider-list-left-container"]
						},
						"items": []
					},
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "SenderDomainsRightContainer",
					"parentName": "SenderDomainsInnerContainer",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["provider-list-right-container"]
						},
						"items": []
					},
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "MailingProviders",
					"parentName": "SenderDomainsLeftContainer",
					"propertyName": "items",
					"values": {
						"idProperty": "Id",
						"rowCssSelector": ".provider-item",
						"itemType": this.Terrasoft.ViewItemType.GRID,
						"collection": {
							"bindTo": "ProvidersCollection"
						},
						"generator": "ContainerListGenerator.generatePartial",
						"selectableRowCss": "provider-item",
						"itemPrefix": "View",
						"dataItemIdPrefix": "provider-item",
						"isAsync": false,
						"activeItem": {
							"bindTo": "SelectedProviderId"
						},
						"onItemClick": {
							"bindTo": "onItemClick"
						},
						"defaultItemConfig": {
							"className": "Terrasoft.Container",
							"id": "provider-item-view",
							"selectors": {
								"wrapEl": "#provider-item-view"
							},
							"classes": {
								"wrapClassName": ["provider-item-wrapper-container"]
							},
							"items": [{
								"className": "Terrasoft.Label",
								"classes": {
									"labelClass": ["label-wrap"]
								},
								"caption": {
									"bindTo": "Name"
								},
								"markerValue": {
									"bindTo": "Name"
								}
							}]
						}
					}
				},
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"className": "Terrasoft.ConfigurationGrid",
						"generator": "ConfigurationGridGenerator.generatePartial",
						"rowDataItemMarkerColumnName": "Domain",
						"generateControlsConfig": {"bindTo": "generateActiveRowControlsConfig"},
						"unSelectRow": {"bindTo": "unSelectRow"},
						"changeRow": {"bindTo": "changeRow"},
						"selectRow": {"bindTo": "rowSelected"},
						"onGridClick": {"bindTo": "onGridClick"},
						"initActiveRowKeyMap": {"bindTo": "initActiveRowKeyMap"},
						"activeRowAction": {"bindTo": "onActiveRowAction"},
						"activeRowActions": [],
						"isEmptyCaption": resources.localizableStrings.IsEmptyDomainsGrid
					}
				},
				{
					"operation": "move",
					"name": "DataGrid",
					"parentName": "SenderDomainsRightContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "activeRowActionSave",
					"parentName": "DataGrid",
					"propertyName": "activeRowActions",
					"values": {
						"className": "Terrasoft.Button",
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"tag": "save",
						"markerValue": "save",
						"imageConfig": {"bindTo": "Resources.Images.SaveIcon"},
						"visible": {"bindTo": "IsNew"}
					}
				},
				{
					"operation": "insert",
					"name": "activeRowActionCancel",
					"parentName": "DataGrid",
					"propertyName": "activeRowActions",
					"values": {
						"className": "Terrasoft.Button",
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"tag": "cancel",
						"markerValue": "cancel",
						"imageConfig": {"bindTo": "Resources.Images.CancelIcon"},
						"visible": {"bindTo": "IsNew"}
					}
				},
				{
					"operation": "insert",
					"name": "RefreshButton",
					"parentName": "Detail",
					"propertyName": "tools",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.BUTTON,
						"click": {"bindTo": "reloadDetailData"},
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"caption": {"bindTo": "Resources.Strings.RefreshButtonCation"}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
