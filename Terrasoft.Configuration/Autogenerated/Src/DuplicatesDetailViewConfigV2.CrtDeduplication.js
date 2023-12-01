﻿define("DuplicatesDetailViewConfigV2", ["DuplicatesDetailViewConfigV2Resources", "MultilineLabel",
		"css!DeduplicationModuleCSS", "css!MultilineLabel", "css!DetailModuleV2"],
	function(resources) {
		Ext.define("Terrasoft.configuration.DuplicatesDetailViewConfig", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.DuplicatesDetailViewConfig",

			viewModelClass: null,

			/**
			 * Returns the view configuration of the module.
			 * @param {Object} config Configuration.
			 * @returns {Object} The view configuration of the module.
			 */
			generate: function(config) {
				var instanceId = this.instanceId;
				var listedConfig = JSON.parse(config.gridConfig);
				return [
					this.getRootContainerViewConfig(instanceId, listedConfig)
				];
			},
			
			/**
			 * @protected
			 */
			getRootContainerViewConfig: function(instanceId, listedConfig) {
				return {
					"name": instanceId + "ModuleContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {wrapClassName: ["detail duplicates-detail"]},
					"markerValue": {"bindTo": "Caption"},
					"items": this.getRootContainerItems(instanceId, listedConfig)
				};
			},
			
			/**
			 * @protected
			 */
			getRootContainerItems: function(instanceId, listedConfig) {
				return [
					this.getDuplicatesDetailHeaderContainer(instanceId),
					this.getDuplicatesDetailGridContainer(instanceId, listedConfig)
				];
			},
			
			/**
			 * @protected
			 */
			getDuplicatesDetailHeaderContainer: function(instanceId) {
				return {
					"name": instanceId + "ControlsContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {wrapClassName: ["duplicates-controls-container"]},
					"items": this.getHeaderContainerItems(instanceId)
				};
			},
			
			/**
			 * @protected
			 */
			getHeaderContainerItems: function (instanceId) {
				return [
					this.getHeaderCaptionViewConfig(instanceId),
					this.getSelectAllButtonViewConfig(instanceId),
					this.getActionButtonsViewConfig(instanceId)
				];
			},
			
			/**
			 * @protected
			 */
			getHeaderCaptionViewConfig: function(instanceId) {
				return {
					"name": instanceId + "LabelContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {wrapClassName: ["left-container-wrapClass"]},
					"items": [
						{
							"name": instanceId + "Label",
							"itemType": Terrasoft.ViewItemType.LABEL,
							"caption": {"bindTo": "Caption"},
							"classes": {
								"labelClass": ["t-label duplicates-header-label"]
							}
						}
					]
				};
			},
			
			/**
			 * @protected
			 */
			getSelectAllButtonViewConfig: function(instanceId) {
				return {
					"name": instanceId + "SelectAllLabelContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {wrapClassName: ["left-container-wrapClass"]},
					"items": [
						{
							"name": instanceId + "SelectAllLabel",
							"className": "Terrasoft.MultilineLabel",
							"contentVisible": true,
							"itemType": Terrasoft.ViewItemType.LABEL,
							"caption": {"bindTo": "SelectAllCaption"},
							"click": {"bindTo": "onSelectAllClick"},
							"markerValue": "SelectAll",
							"classes": {
								"labelClass": ["t-label duplicates-header-label"]
							}
						}
					]
				};
			},
			
			/**
			 * @protected
			 */
			getActionButtonsViewConfig: function(instanceId) {
				return {
					"name": instanceId + "ButtonsContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						wrapClassName: [
							"right-container-wrapClass ts-controlgroup-tools duplicates-detail-buttons"
						]
					},
					"items": [
						this.getMergeButtonViewConfig(instanceId),
						this.getNoDuplicateViewConfig(instanceId)
					]
				};
			},
			
			/**
			 * @protected
			 */
			getMergeButtonViewConfig: function (instanceId) {
				return {
					"name": instanceId + "MergeButton",
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"caption": {"bindTo": "MergeButtonCaption"},
					"enabled": {"bindTo": "IsMergeButtonEnabled"},
					"click": {"bindTo": "onMergeButtonClick"},
					"markerValue": "MergeButton",
					"classes": {
						"wrapperClass": "right-container-wrapClass",
						"textClass": "t-btn-style-transparent actions-button-margin-right"
					},
					"tips": [
						{
							"name": instanceId + "MergeButtonTip",
							"content": resources.localizableStrings.MergeButtonHint
						}
					]
				};
			},
			
			/**
			 * @protected
			 */
			getNoDuplicateViewConfig: function (instanceId) {
				return {
					"name": instanceId + "NotDoublesButton",
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"caption": resources.localizableStrings.NotDoublesButtonCaption,
					"click": {"bindTo": "onNotDoublesButtonClick"},
					"enabled": {
						"bindTo": "SelectedRowsCount",
						"bindConfig": {
							"converter": function (selectedRowsCount) {
								if (Terrasoft.Features.getIsDisabled("BulkESDeduplication")) {
									return true;
								}
								return parseInt(selectedRowsCount) > 0;
							}
						}
					},
					"markerValue": "NotDoublesButton",
					"classes": {
						"wrapperClass": "right-container-wrapClass",
						"textClass": "t-btn-style-transparent"
					},
					"tips": [
						{
							"name": instanceId + "NotDoublesButtonTip",
							"content": resources.localizableStrings.NotDoublesButtonHint
						}
					]
				};
			},
			
			/**
			 * @protected
			 */
			getDuplicatesDetailGridContainer: function (instanceId, listedConfig) {
				return {
					"name": instanceId + "GridContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						"wrapClassName": ["grid-dataview-container-wrapClass"]
					},
					"items": this.getGridContainerItems(instanceId, listedConfig)
				};
			},
			
			/**
			 * @protected
			 */
			getGridContainerItems: function (instanceId, listedConfig) {
				return [
					this.getDuplicatesDetailGridViewConfig(instanceId, listedConfig)
				];
			},
			
			/**
			 * @protected
			 */
			getDuplicatesDetailGridViewConfig: function (instanceId, listedConfig) {
				return {
					"name": instanceId + "DataGrid",
					"itemType": Terrasoft.ViewItemType.GRID,
					"collection": {"bindTo": "GridData"},
					"selectedRows": {"bindTo": "SelectedRows"},
					"selectRow": {"bindTo": "onSelectRow"},
					"unSelectRow": {"bindTo": "onUnSelectRow"},
					"linkClick": {"bindTo": "linkClicked"},
					"type": "listed",
					"multiSelect": true,
					"listedZebra": true,
					"safeBind": true,
					"primaryDisplayColumnName": "Name",
					"listedConfig": {
						"name": instanceId + "DataGridTiledConfig",
						"captionsConfig": listedConfig.captionsConfig,
						"columnsConfig": listedConfig.columnsConfig,
						"items": listedConfig.items
					}
				};
			}
			
		});
	});
