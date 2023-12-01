﻿Terrasoft.configuration.Structures["SimpleTaskAddModule"] = {innerHierarchyStack: ["SimpleTaskAddModule"]};
//todo ############# ######
define("SimpleTaskAddModule", ["SimpleTaskAddModuleResources", "ConfigurationEnums",  "ConfigurationConstants",
		"ProcessModuleUtilities", "BaseModule"],
	function(resources, ConfigurationEnums, ConfigurationConstants, ProcessModuleUtilities) {
		/**
		 * @class Terrasoft.configuration.SimpleTaskAddModule
		 * ##### SimpleTaskAddModule ############ ### ########## ###### ## ############ #### # ##########
		 */
		Ext.define("Terrasoft.configuration.SimpleTaskAddModule", {
			alternateClassName: "Terrasoft.SimpleTaskAddModule",
			extend: "Terrasoft.BaseModule",

			Ext: null,
			sandbox: null,
			Terrasoft: null,

			/**
			 * ############ ######### ########## #### ######## ########## ######.
			 */
			viewConfig: {
				schema: {
					viewConfig: [{
						"name": "ModalLayout",
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [
							{
								"name": "ButtonsContainer",
								"itemType": Terrasoft.ViewItemType.CONTAINER,
								"classes": {"wrapClassName": ["right-buttons-container-wrap"]},
								"layout": {
									"column": 0,
									"row": 0,
									"colSpan": 24
								},
								"items": [
									{
										"name": "ModifyTaskButton",
										"click": {"bindTo": "onOpenCardInChain"},
										"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
										"itemType": Terrasoft.ViewItemType.BUTTON,
										"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
										"imageConfig": {"bindTo": "getModifyActivityIcon"},
										"visible": {"bindTo": "getSmartButtonVisibility"},
										"classes": {
											"wrapperClass": ["modify-activity-button-wrap"]
										}
									}
								]
							},
							{
								"name": "Title",
								"id": "titleInputEl",
								"selectors": {"wrapEl": "#titleInputEl"},
								"contentType": this.Terrasoft.ContentType.LONG_TEXT,
								"labelConfig": {
									"visible": false
								},
								"layout": {
									"column": 0,
									"row": 1,
									"rowSpan": 1,
									"colSpan": 24
								},
								"focused": {
									"bindTo": "IsTitleInputFocused"
								}
							},
							{
								"name": "leftButtonsContainer",
								"itemType": Terrasoft.ViewItemType.CONTAINER,
								"classes": {"wrapClassName": ["right-buttons-container-wrap"]},
								"layout": {
									"column": 0,
									"row": 2,
									"colSpan": 24
								},
								"items": [
									{
										"name": "SmartButton",
										"click": {"bindTo": "onSmartButtonClick"},
										"caption": {"bindTo": "SmartButtonCaption"},
										"style": Terrasoft.controls.ButtonEnums.style.GREEN,
										"itemType": Terrasoft.ViewItemType.BUTTON,
										"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
										"classes": {"wrapperClass": ["smartButton-wrap"]},
										"visible": {"bindTo": "getSmartButtonVisibility"},
										"tag": "smart",
										"menu": [
											{
												"id": "InProgressStatus",
												"caption": resources.localizableStrings.InProgress,
												"markerValue": resources.localizableStrings.InProgress,
												"click": {"bindTo": "onSmartButtonClick"},
												"tag": "394D4B84-58E6-DF11-971B-001D60E938C6"
											},
											{
												"id": "FinishedStatus",
												"caption": resources.localizableStrings.Finished,
												"markerValue": resources.localizableStrings.Finished,
												"click": {"bindTo": "onSmartButtonClick"},
												"tag": ConfigurationConstants.Activity.Status.Done
											},
											{
												"id": "NotStartedStatus",
												"caption": resources.localizableStrings.NotStarted,
												"markerValue": resources.localizableStrings.NotStarted,
												"click": {"bindTo": "onSmartButtonClick"},
												"tag": ConfigurationConstants.Activity.Status.NotStarted
											},
											{
												"id": "CanceledStatus",
												"caption": resources.localizableStrings.Canceled,
												"markerValue": resources.localizableStrings.Canceled,
												"click": {"bindTo": "onSmartButtonClick"},
												"tag": ConfigurationConstants.Activity.Status.Cancel
											}
										]
									},
									{
										"name": "SaveButton",
										"click": {"bindTo": "save"},
										"caption": resources.localizableStrings.SaveButtonCaption,
										"style": Terrasoft.controls.ButtonEnums.style.BLUE,
										"itemType": Terrasoft.ViewItemType.BUTTON,
										"classes": {"textClass": ["save-button-wrap"]}
									},
									{
										"name": "CancelButton",
										"click": {"bindTo": "onCancelButtonClick"},
										"caption": resources.localizableStrings.CancelButtonCaption,
										"itemType": Terrasoft.ViewItemType.BUTTON,
										"classes": {"textClass": ["cancel-button-wrap"]}
									}
								]
							}
						]
					}]
				}
			},

			/**
			 * ############ ###### ########## #### ######## ########## ######.
			 */
			viewModelConfig: {
				schemaName: "ActivityPageV2",
				profileKey: "ActivityPageV2",
				itemId: ""
			},

			attributes: {
				"SmartButtonCaption": {
					dataValue: this.Terrasoft.DataValueType.TEXT,
					value: this.Ext.String.format(
						resources.localizableStrings.SetAs,
						resources.localizableStrings.Finished)
				}
			},

			getSmartButtonVisibility: function() {
				return (this.get("mode") === "normal");
			},

			/**
			 * ########## ######## ########## DOM-######## ######.
			 * @return {String}
			 */
			getModuleMarkerValue: function() {
				var isEntityInitialized = this.get("IsEntityInitialized");
				return isEntityInitialized
					? resources.localizableStrings.ModuleInitializedMarker
					: resources.localizableStrings.ModuleMarker;
			},

			onSmartButtonClick: function() {
				var statusId = arguments[arguments.length - 1];
				if (statusId === "smart") {
					statusId = (this.get("Status") || {}).value;
					if (!statusId) {
						return;
					}
					statusId = (statusId === ConfigurationConstants.Activity.Status.Done)
						? ConfigurationConstants.Activity.Status.NotStarted
						: ConfigurationConstants.Activity.Status.Done;
				}
				this.set("Status", {
					value: statusId
				});
				if (!this.get("ProcessListeners")) {
					this.save();
				} else {
					this.sandbox.publish("OpenItem", null, [this.sandbox.id]);
					this.removeViewModel();
				}
			},

			initSmartButtonCaption: function() {
				var statusId = (this.get("Status") || {}).value;
				if (statusId) {
					var statusDisplayValue = (statusId === ConfigurationConstants.Activity.Status.Done)
						? resources.localizableStrings.NotStarted
						: resources.localizableStrings.Finished;
					this.set("SmartButtonCaption",
						this.Ext.String.format(resources.localizableStrings.SetAs, statusDisplayValue));
				}
			},

			getSimpleModuleWidth: function() {
				return (this.get("mode") === "normal") ? 500 : 340;
			},

			/**
			 * ######### ######## ##### ########## ########
			 */
			onSaved: function() {
				this.hideBodyMask();
				this.removeViewModel(this.get("Id"));
				this.insertParticipants();
			},

			/**
			 * ######### ######## ########## ###### # ########### ########## ## #########
			 * @private
			 */
			onOpenCardInChain: function() {
				var prcElId = this.get("ProcessElementId");
				var recordId = this.get("Id");
				//TODO: #CRM-3404 ######## ################ #### ########## ## ######## # ##########
				if (ProcessModuleUtilities.tryShowProcessCard.call(this, prcElId, recordId)) {
					return;
				}
				var cardModuleId = this.sandbox.id + "_CardModule";
				var schemaName = this.name;
				var defaultValues = [];
				defaultValues.push({
					name: "Participants",
					value: this.get("Participants")
				});
				defaultValues.push({
					name: "Title",
					value: this.get("Title")
				});
				defaultValues.push({
					name: "StartDate",
					value: this.get("StartDate")
				});
				defaultValues.push({
					name: "DueDate",
					value: this.get("DueDate")
				});
				this.showBodyMask();
				var primaryColumnValue = this.get("PrimaryColumnValue");
				var openCardConfig = {
					id: primaryColumnValue,
					moduleId: cardModuleId,
					schemaName: schemaName,
					operation: primaryColumnValue
						? ConfigurationEnums.CardStateV2.EDIT
						: ConfigurationEnums.CardStateV2.ADD,
					defaultValues: defaultValues
				};
				this.sandbox.subscribe("GetScheduleItemTitle", function() {
					return this.get("Title");
				}, this);
				this.sandbox.publish("OpenCardInChain", openCardConfig);
				this.removeViewModel();
			},
			/**
			 * ########## ######### # ######## ###### #### ######## ########## ######.
			 * @private
			 */
			onCancelButtonClick: function() {
				this.removeViewModel();
			},

			/**
			 * Delete current view model.
			 * @private
			 * @param {String|*} recordId Id of the current record for update in scheduler.
			 */
			removeViewModel: function(recordId) {
				this.sandbox.publish("RemoveViewModel", {
					viewModel: this,
					recordId: recordId
				});
				this.sandbox.unsubscribePtp("GetScheduleItemTitle", []);
				this.destroy();
			},

			/**
			 * ######### ######### #### ######## ########## ######.
			 * @private
			 * @return {String} ######### #### ######## ########## ######.
			 */
			getSimpleModuleCaption: function() {
				var startDate = this.get("StartDate");
				var dueDate = this.get("DueDate");
				if (!startDate || !dueDate) {
					return "";
				}
				var cultureSettings = Terrasoft.Resources.CultureSettings;
				var shortDayNames = cultureSettings.shortDayNames;
				var captionTemplate = resources.localizableStrings.ModuleCaptionTemplate;
				var shortDayTemplate = resources.localizableStrings.ShortDayStringTemplate;
				var startDayName = "";
				var dueDayName = this.Ext.String.format(shortDayTemplate, dueDate.getDate(),
					shortDayNames[dueDate.getDay()]);
				if (dueDate.getDate() !== startDate.getDate()) {
					startDayName = this.Ext.String.format(shortDayTemplate, startDate.getDate(),
						shortDayNames[startDate.getDay()]);
				}
				var caption = this.Ext.String.format(
					captionTemplate, this.Ext.Date.format(startDate, cultureSettings.timeFormat),
					startDayName, this.Ext.Date.format(dueDate, cultureSettings.timeFormat), dueDayName);
				return caption;
			},

			/**
			 * ########## ############ ########### ###### ########### ##########.
			 * @private
			 * @return {Object} ############ ########### ###### ########### ##########.
			 */
			getModifyActivityIcon: function() {
				return {
					source: this.Terrasoft.ImageSources.URL,
					url: this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.ModifyTaskIcon)
				};
			},

			/**
			 * ######### ###### #### ######## ########## ###### ## ############.
			 * @private
			 * @param {Object} config ############ ######.
			 * @param {Function} callback #######, ####### ##### ####### ##### ######## ######.
			 */
			getViewModel: function(config, callback) {
				var schemaBuilder = this.Ext.create("Terrasoft.SchemaBuilder");
				var generatorConfig = this.Terrasoft.deepClone(config);
				schemaBuilder.build(generatorConfig, function(viewModelClass) {
					var viewModel = this.Ext.create(viewModelClass, {
						Ext: this.Ext,
						sandbox: this.sandbox,
						Terrasoft: this.Terrasoft,
						values: {
							PrimaryColumnValue: config.itemId,
							IsSeparateMode: false,
							Operation: config.itemId
								? ConfigurationEnums.CardStateV2.EDIT
								: ConfigurationEnums.CardStateV2.ADD,
							IsInChain: false,
							mode: config.mode
						}
					});
					viewModel.set("IsTitleInputFocused", false);
					viewModel.onSaved = this.onSaved;
					viewModel.onOpenCardInChain = this.onOpenCardInChain;
					viewModel.onCancelButtonClick = this.onCancelButtonClick;
					viewModel.removeViewModel = this.removeViewModel;
					viewModel.getSimpleModuleCaption = this.getSimpleModuleCaption;
					viewModel.getModifyActivityIcon = this.getModifyActivityIcon;
					viewModel.onSmartButtonClick = this.onSmartButtonClick;
					viewModel.initSmartButtonCaption = this.initSmartButtonCaption;
					viewModel.getSimpleModuleWidth = this.getSimpleModuleWidth;
					viewModel.getSmartButtonVisibility = this.getSmartButtonVisibility;
					viewModel.getModuleMarkerValue = this.getModuleMarkerValue;
					this.viewConfig.viewModelClass = viewModelClass;
					if (callback) {
						callback.call(this, viewModel);
					}
				}, this);
			},

			/**
			 * ######### ###### ############# #### ######## ########## ###### ## ############.
			 * @private
			 * @param {Object} config ############ #############.
			 * @param {Function} callback #######, ####### ##### ####### ##### ######## #############.
			 */
			getView: function(config, callback) {
				var viewGenerator = this.Ext.create("Terrasoft.ViewGenerator");
				var generatorConfig = this.Terrasoft.deepClone(config);
				viewGenerator.generate(generatorConfig, function(viewConfig) {
					var containerId = "SimpleTaskAddContainer";
					var view = this.Ext.create("Terrasoft.Container", {
						id: containerId,
						selectors: {wrapEl: "#" +  containerId},
						classes: {wrapClassName: ["simple-task-add-module-wrap"]},
						markerValue: {bindTo: "getModuleMarkerValue"},
						items: viewConfig
					});
					if (callback) {
						callback.call(this, view);
					}
				}, this);
			},

			/**
			 * ########## ######### # ######## ###### #### ######## ########## ######.
			 * @private
			 * @param {Object} config ############ ######
			 * @param {String} config.scheduleItem ############# ######
			 * @param {String} config.cardSchemaName ### ##### ########
			 */
			onGetViewModelMessage: function(config) {
				this.viewModelConfig.itemId = (config && config.scheduleItem) ? config.scheduleItem : null;
				if (config && config.cardSchemaName) {
					this.viewModelConfig.schemaName = config.cardSchemaName;
					this.viewModelConfig.profileKey = config.cardSchemaName;
				}
				this.viewModelConfig.mode = config.mode;
				this.getViewModel(this.viewModelConfig, function(viewModel) {
					this.sandbox.publish("SimpleTaskViewModelCreated", viewModel);
				});
			},

			/**
			 * ####### # ############ ############# #### ######## ########## ######.
			 * @private
			 * @param {Object} args ######### ### ######### #############.
			 */
			onGetRenderViewMessage: function(args) {
				var renderTo = args.renderTo;
				var viewModel = args.viewModel;
				this.getView(this.viewConfig, function(view) {
					view.bind(viewModel);
					viewModel.initEntity(function() {
						this.set("IsEntityInitialized", true);
						if (this.isAddMode() || this.isCopyMode()) {
							this.setDefActivityValues();
						}
						this.initSmartButtonCaption();
						this.hideBodyMask();
					}, viewModel);
					view.render(this.Ext.get(renderTo));
					var pressedKeys = this.sandbox.publish("GetSchedulerSelectionPressedKeys", null, [this.sandbox.id]);
					if (pressedKeys.length) {
						viewModel.set("Title", Ext.String.capitalize(pressedKeys));
					}
					viewModel.set("IsTitleInputFocused", true);
				});
			},

			/**
			 * ############# ## #########, ####### ########### ######.
			 * @private
			 */
			subscribeSandboxEvents: function() {
				this.sandbox.subscribe("GetSimpleTaskAddViewModel", this.onGetViewModelMessage, this);
				this.sandbox.subscribe("RenderSimpleTaskAddView", this.onGetRenderViewMessage, this);
			},

			/**
			 * ############## ######### ######## ######.
			 * @param callback #######, ####### ##### ####### ##### ############# ######.
			 * @param scope ####### #########.
			 */
			init: function(callback, scope) {
				this.subscribeSandboxEvents();
				if (callback) {
					callback.call(scope);
				}
			}
		});
		return Terrasoft.SimpleTaskAddModule;
	});


