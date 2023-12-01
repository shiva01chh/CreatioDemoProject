define("ForecastItemViewModel", [
		"ConfigurationEnums",
		"RightUtilities",
		"ForecastItemViewModelResources",
		"ForecastConstants",
		"MiniPageUtilities"],
	function(ConfigurationEnums, RightUtilities, Resources, ForecastConstants) {
	Ext.define("Terrasoft.configuration.ForecastItemViewModel", {
		extend: "Terrasoft.BaseViewModel",
		alternateClassName: "Terrasoft.ForecastItemViewModel",

		Ext: null,
		Terrasoft: null,
		sandbox: null,

		columns: {
			ForecastId: { dataValueType: Terrasoft.DataValueType.TEXT },
			SnapshotId: { dataValueType: Terrasoft.DataValueType.TEXT },
			PeriodsId: { dataValueType: Terrasoft.DataValueType.TEXT },
			Command: { dataValueType: Terrasoft.DataValueType.TEXT },
			BaseUrl: { dataValueType: Terrasoft.DataValueType.TEXT },
			Images: { dataValueType: Terrasoft.DataValueType.COLLECTION },
			MaxDisplayedRecords: { dataValueType: Terrasoft.DataValueType.NUMBER }
		},

		mixins: {
			"MiniPageUtilities": "Terrasoft.MiniPageUtilities"
		},

		messages: {
			/**
			 * Sign forecast column saved.
			 */
			"ForecastColumnSaved": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},

		/**
		 * @inheritDoc Terrasoft.BaseViewModel#constructor
		 * @protected
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			this.sandbox.registerMessages(this.messages);
			this.sandbox.subscribe("ForecastColumnSaved", function(columnTypeId) {
				if (columnTypeId === ForecastConstants.ColumnType.Formula) {
					this.$Command = "forcerefreshcolumns";
				} else {
					this.$Command = "refreshcolumns";
				}
			}, this, [this._getModuleId()]);
			this.$Images = this._getImagesList();
		},

		/**
		 * @private
		 */
		_getImagesList: function() {
			return [{
				name: "empty-blank-slate",
				url: this.Terrasoft.ImageUrlBuilder.getUrl(Resources.localizableImages.EmptyBlankSlate)
			}];
		},

		/**
		 * Returns module identifier.
		 * @return {String} The module identifier.
		 * @private
		 */
		_getModuleId: function() {
			return this.sandbox.id + "_ForecastColumnDesignerMiniPage";
		},

		/**
		 * Handles command finished.
		 */
		onCommandFinished: function() {
			this.$Command = "";
		},

		/**
		 * Shows mini-page.
		 */
		showMiniPage: function(operation, recordId, valuePairs) {
			const miniPageConfig = {
				recordId: recordId,
				miniPageSchemaName: "ForecastColumnDesignerMiniPage",
				entitySchemaName: "ForecastColumn",
				valuePairs: valuePairs,
				operation: operation,
				showDelay: 0,
				moduleId: this._getModuleId(),
				viewGeneratorClassName: "Terrasoft.ViewGenerator"
			};
			this._showMiniPageWithCheckingRights(miniPageConfig);
		},

		/**
		 * @private
		 */
		_showMiniPageWithCheckingRights: function(miniPageConfig) {
			RightUtilities.checkCanEdit({
				schemaName: "ForecastSheet",
				primaryColumnValue: this.$ForecastId
			}, function(result) {
				if (this.Ext.isEmpty(result)) {
					this.openMiniPage(miniPageConfig);
				} else {
					this.showInformationDialog(result);
				}
			}, this);
		},

		/**
		 * Shows mini-page in adding mode.
		 */
		showAddColumnMiniPage: function() {
			const valuePairs = this._getDefaultValues();
			this.showMiniPage(ConfigurationEnums.CardStateV2.ADD, Terrasoft.generateGUID(), valuePairs);
		},

		/**
		 * Shows mini-page in editing mode.
		 * @param {Event} event Event data.
		 * @param {Object} columnData Column data.
		 */
		showEditColumnMiniPage: function(event, columnData) {
			const valuePairs = this._getDefaultValues();
			valuePairs.push({
				"name": "IsSummaryColumn",
				"value": this._getIsSummaryColumn(columnData),
			});
			this.showMiniPage(ConfigurationEnums.CardStateV2.EDIT, columnData.code, valuePairs);
		},

		/**
		 * @private
		 */
		_getDefaultValues: function() {
			return [{
				"name": "Sheet",
				"value": this.$ForecastId
			}, {
				"name": "forecastSourceItemName",
				"value": this.$ForecastSourceItemName
			}];
		},

		/**
		 * @private
		 */
		_getIsSummaryColumn: function(columnData) {
			return columnData.id.indexOf('_summary') !== -1;
		},

		/**
		 * Handles forecast row action click.
		 * @param {Object} event Row action data.
		 */
		onRowActionClick: function(event) {
			this.sandbox.publish("RowActionClick", event, [this.sandbox.id]);
		},

		onSetupColumns: function(data) {
			this.sandbox.publish("ShowDrilldownSetupColumns", data, [this.sandbox.id]);
		},

		/**
		 * Forms filter for object value records.
		 * @protected 
		 * @param {Object} data Object value data.
		 * @return {String} Serialized filter for object value records.
		 */
		getObjectValueFilterString: function(data) {
			const forecastObjValRecordSchemaPath = '[ForecastObjValueRecord:EntityId:Id].';
			const filtersGroup = this.Ext.create("Terrasoft.FilterGroup");
			filtersGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
				this.Terrasoft.ComparisonType.EQUAL, forecastObjValRecordSchemaPath + "RefEntityId", 
				{value: data.refEntityId, displayValue: data.refEntityTitle}, this.Terrasoft.DataValueType.LOOKUP));
			filtersGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
				this.Terrasoft.ComparisonType.EQUAL, forecastObjValRecordSchemaPath + "Column", 
				{value: data.columnId, displayValue: data.columnTitle}, this.Terrasoft.DataValueType.LOOKUP));
			filtersGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
				this.Terrasoft.ComparisonType.EQUAL, forecastObjValRecordSchemaPath + "Period", 
				{value: data.periodId, displayValue: data.periodTitle}, this.Terrasoft.DataValueType.LOOKUP));
			const serializationInfo = filtersGroup.getDefSerializationInfo();
			serializationInfo.serializeFilterManagerInfo = true;
			return filtersGroup.serialize(serializationInfo);
		},
		
		/**
		 * Handles go to section action click.
		 * @param data
		 */
		goToSectionClicked: function(data) {
			const moduleInfo = this.Terrasoft.configuration.ModuleStructure[data.entitySchemaName] || {};
			const sectionSchema =  moduleInfo.sectionSchema;
			const navigationHelper = this.Ext.create("Terrasoft.NavigationHelper", {
				Ext: this.Ext,
				sandbox: this.sandbox
			});
			const navigationConfig = {
				target: "Section",
				options: {
					sectionSchema: moduleInfo.sectionSchema,
					filters: {
							"ForecastColumn":  {
								"displayValue": data.title,
								"value": data.title,
								"filter": this.getObjectValueFilterString(data)
							}
					},
					hideFilterBlock: true
				}
			};
			navigationHelper.navigateTo(navigationConfig);
		},

		/**
		 * Handles inner exception.
		 * @param info Exception information.
		 */
		handleInnerException: function(info) {
			this.showInformationDialog(info.message);
		},

		/**
		 * Handles cell selection.
		 * @param {Object} data Cell selected data.
		 */
		onCellSelected: function(data) {
			this.sandbox.publish("CellSelected", data, [this.sandbox.id]);
		}

	});

	return Terrasoft.ForecastItemViewModel;

});
