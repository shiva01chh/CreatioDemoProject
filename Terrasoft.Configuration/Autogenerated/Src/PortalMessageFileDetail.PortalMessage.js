﻿define("PortalMessageFileDetail", [], function () {
	return {
		messages: {
			/**
			* @message HideFileDetailContainer
			* Switch FileDetailContainer, visibility into off mode.
			* FileDetailContainer defined in parent page.
			*/
			"HideFileDetailContainer": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.PUBLISH
			}
		},

		methods: {

			/**
			 * @private
			 */
			_isNeedLoadDataFromService: function() {
				return this.Terrasoft.Features.getIsEnabled("SecurePortalMessageFileInHistory");
			},

			_getLastValue: function() {
				const lastElement = this.getGridData().last();
				return lastElement ? lastElement.$Id : Terrasoft.GUID_EMPTY;
			},

			/**
			 * @private
			 */
			_getServiceConfig: function () {
				const lastValue = this._getLastValue();
				const rowsCount = this.getRowCount();
				return {
					"serviceName": "PortalMessageFileService",
					"methodName": "GetPortalMessageFiles",
					"data": {
						"portalMessageId": this.$MasterRecordId,
						"readingOptions": {
							"rowCount": rowsCount,
							"lastValue": lastValue
						}
					}
				};
			},

			/**
			 * @inheritdoc Terrasoft.FileDetailV2#loadContainerListData
			 * @override
			 */
			loadContainerListData: function(callback) {
				this._isNeedLoadDataFromService() ? this.loadFilesFromService(callback) : this.callParent(arguments);
			},

			/**
			 * Load portal message file from service.
			 * @protected
			 */
			loadFilesFromService: function(callback) {
				const config = this._getServiceConfig();
				this.callService(config, function(response) {
					if (response && response.GetPortalMessageFilesResult) {
						this.loadResponseToGrid(response.GetPortalMessageFilesResult.PortalMessageFiles);
						this.manageMasterCardContainerVisibilty();
					}
					Ext.callback(callback, this);
				}, this);
			},

			/**
			 * Load files received from web service into detail grid.
			 * @protected
			 * @param {Array} files
			 */
			loadResponseToGrid: function(files) {
				const canLoadMoreData = this.getShowMoreButtonVisibility(files.length);
				this.set("CanLoadMoreData", canLoadMoreData); 
				const viewModels = Ext.create("Terrasoft.Collection");
				Terrasoft.each(files, function (file) {
					const viewModel = this.createViewModelFromServiceResponse(file);
					viewModels.addIfNotExists(file.Id, viewModel);
				}, this);
				const gridData = this.getGridData();
				gridData.loadAll(viewModels);
			},

			/**
			 * Hide detail container in master card of no files was loaded into grid.
			 * @protected
			 */
			manageMasterCardContainerVisibilty: function() {
				const renderedItems = this.getGridData().getItems();
				if (renderedItems.length === 0) {
					this.sandbox.publish("HideFileDetailContainer", null, [this.sandbox.id]);
				}
			},

			/**
			 * Return value for CanLoadMoreData attribute.
			 * @protected
			 * @param {Number} arrayLength
			 * @returns {Boolean} True, if detail can load more data.
			 */
			getShowMoreButtonVisibility: function(arrayLength) {
				const rowCount = this.getRowCount();
				return arrayLength >= rowCount;
			},

			/**
			 * Returns href to portal message file service.
			 * @public
			 * @return {Boolean} Href to portal message file service.
			 */
			getPortalMessageFileServiceHref: function (data) {
				var workspaceBaseUrl = Terrasoft.utils.uri.getConfigurationWebServiceBaseUrl();
				return workspaceBaseUrl + "/rest/PortalMessageFileService/GetPortalMessageFile/" + data.historySchemaName + "/" + data.parentHistorySchemaRecordId + "/" + data.fileId;
			},

			/**
			* Initializes ViewModel instance by query result.
			* @protected
			* @param {Object} values data for ImageListViewModel, recieved from web-service.
			* @returns {Terrasoft.ImageListViewModel} viewmodel for portal message file.
			*/
			createViewModelFromServiceResponse: function (values) {
				const parentRecordValues = this.sandbox.publish("GetColumnsValues", ["Id", "HistorySchemaName"], [this.sandbox.id]);
				const viewModelClassName = this.getGridRowViewModelClassName();
				const viewModelConfig = this.getAdditionalViewModelConfig();
				viewModelConfig.values = values;
				viewModelConfig.entitySchema = this.getGridEntitySchema();
				const viewModel = Ext.create(viewModelClassName, viewModelConfig);
				this.bindItemViewModelMethods(viewModel);
				if (Terrasoft.isCurrentUserSsp()) {
					viewModel.getFileServiceHref = this.getPortalMessageFileServiceHref.bind(this,
						{
							parentHistorySchemaRecordId: parentRecordValues.Id,
							historySchemaName: parentRecordValues.HistorySchemaName,
							fileId: values.Id
						});
				}
				this.decorateItem(viewModel);
				return viewModel;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});