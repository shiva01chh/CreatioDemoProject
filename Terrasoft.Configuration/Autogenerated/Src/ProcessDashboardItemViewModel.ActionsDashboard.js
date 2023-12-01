﻿define("ProcessDashboardItemViewModel", ["ProcessDashboardItemViewModelResources", "ProcessModuleUtilities",
			"BaseDashboardItemViewModel"],
	function(resources, ProcessModuleUtilities) {
		Ext.define("Terrasoft.configuration.ProcessDashboardItemViewModel", {
			extend: "Terrasoft.BaseDashboardItemViewModel",
			alternateClassName: "Terrasoft.ProcessDashboardItemViewModel",

			Ext: null,
			sandbox: null,
			Terrasoft: null,

			columns: {
				"ElementCaption": {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				"ProcessData": {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
				},
				"EntityId": {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					dataValueType: Terrasoft.DataValueType.GUID
				},
				"ProcessElement": {
					type: Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
				}
			},

			//region Methods: Private

			/**
			 * @private
			 */
			_getCaptionFromPageSchema: function(headerCaption, executionData) {
				const pageConfig = executionData.pageSchema;
				if (Ext.isObject(pageConfig)) {
					const pageConfigValues = pageConfig.values;
					if (Ext.isObject(pageConfigValues) && Boolean(pageConfigValues.header)) {
						headerCaption = pageConfigValues.header;
					}
				}
				return headerCaption;
			},

			//endregion

			//region Methods: Public

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#initIconSrc
			 * @overridden
			 */
			initIconSrc: function() {
				var iconSrc = resources.localizableImages.IconImage;
				this.set("IconSrc", iconSrc);
			},

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#execute
			 * @overridden
			 */
			execute: function() {
				this.showBodyMask();
				var elementUId = this.getLookupColumnValue("ProcessElement");
				ProcessModuleUtilities.tryShowProcessCard.call(this, elementUId);
			},

			/**
			 * Initialize caption for header of the page.
			 */
			initHeader: function() {
				const executionData = this.get("ExecutionData");
				let headerCaption = this.get("ElementCaption");
				if (!Ext.isEmpty(executionData)) {
					const recommendation = executionData.recommendation;
					if (Ext.isEmpty(recommendation)) {
						headerCaption = executionData.pageCaption || executionData.title || headerCaption;
						headerCaption = this._getCaptionFromPageSchema(headerCaption, executionData);
					} else {
						headerCaption = recommendation;
					}
				}
				if (!Ext.isEmpty(headerCaption)) {
					this.set("Caption", headerCaption);
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#getProcessElementUId
			 * @overridden
			 */
			getProcessElementUId: function() {
				return this.getLookupColumnValue("ProcessElement");
			},

			/**
			 * @inheritdoc Terrasoft.BaseDashboardItemViewModel#setExecutionData
			 * @overridden
			 */
			setExecutionData: function() {
				this.callParent(arguments);
				this.initHeader();
			}

			//endregion

		});
	});
