define("CampaignSchemaViewer", ["CampaignSchemaViewerResources", "CampaignSchemaViewerViewModel",
		"CampaignDiagramComponent", "CampaignSchemaDesigner", "CampaignAnalyticsDiagram",
		"CampaignElementSchemaManager", "CampaignElementSchemaManagerEx", "CampaignDiagramComponent",
		"CampaignDiagramElementManager", "CampaignSchemaDesignerNew"], function(resources) {
	Ext.define("Terrasoft.configuration.CampaignSchemaViewer", {
		extend: "Terrasoft.CampaignSchemaDesignerNew",
		alternateClassName: "Terrasoft.CampaignSchemaViewer",

		/**
		 * Name of ViewModel class.
		 * @type {String}
		 */
		designerViewModelClassName: "Terrasoft.CampaignSchemaViewerViewModel",

		/**
		 * Campaign diagram.
		 * @private
		 * @type {Terrasoft.Diagram}
		 */
		diagram: null,

		/**
		 * Diagram config.
		 * @override
		 * @type {Object}
		 */
		diagramConfig: {
			classes: {
				wrapClassName: ["ej-diagram", "ts-box-sizing"]
			},
			items: {
				bindTo: "Items"
			}
		},

		/**
		 * Default campaign entity schema unique identifier.
		 * @type {String}
		 */
		entitySchemaUId: null,

		/**
		 * Default campaign unique identifier.
		 * @type {String}
		 */
		entityId: null,

		/**
		 * Designer ViewModel.
		 * @type {Terrasoft.BaseViewModel}
		 */
		designerViewModel: null,

		/**
		 * Container for designer content.
		 * @type {Terrasoft.Container}
		 */
		contentContainer: null,

		/**
		 * Name of schema diagram class name.
		 * @type {String}
		 */
		schemaDiagramClassName: "Terrasoft.CampaignDiagramComponent",

		/**
		 * @inheritdoc Terrasoft.CampaignSchemaDesignerNew
		 * @override
		 */
		readOnly: true,

		/**
		 * @inheritdoc Terrasoft.ProcessSchemaDesigner#getDiagramConfig
		 * @override
		 */
		getDiagramConfig: function() {
			var config = this.callParent(arguments);
			return Ext.apply({}, config, {
				id: this.id
			});
		},

		/**
		 * Gets campaign participants analytics.
		 * @private
		 * @param {Object} filters The analytics filters.
		 * @param {Function} callback The callback function.
		 * @param {Object} scope The context.
		 */
		_getAnalyticsData: function(filters, callback, scope) {
			var dateNow = "\/Date(" + new Date().getTime() + ")\/";
			var startDate, dueDate;
			startDate = dueDate = dateNow;
			var useTimeFilters = !!(filters.startDate && filters.dueDate);
			if (useTimeFilters) {
				startDate = "\/Date(" + filters.startDate.getTime() + ")\/";
				dueDate = "\/Date(" + filters.dueDate.getTime() + ")\/";
			}
			var dataSend = {
				request: {
					campaignId: this.entityId,
					filterStartDate: startDate,
					filterDueDate: dueDate,
					useTimeFilters: useTimeFilters,
					useHistoryData: true
				}
			};
			var config = {
				serviceName: "CampaignService",
				methodName: "GetParticipantsAnalytics",
				data: dataSend
			};
			Terrasoft.ConfigurationServiceProvider.callService.call(this, config, callback, scope);
		},

		/**
		 * @private
		 */
		_updateAnalyticsData: function(showMask) {
			if (showMask) {
				this.maskId = Terrasoft.Mask.show({
					selector: "ts-campaign-diagram .diagram-container",
					timeout: 200
				});
			}
			var config = this.sandbox.publish("GetAnalyticsConfigForViewer", null, [this.sandbox.id]);
			if (!config) {
				return;
			}
			this.diagram.badgesConfig = config.badgesConfig;
			var startDate = config.periodFilter.startDate;
			var dueDate = config.periodFilter.dueDate;
			if ((startDate && dueDate) || (!startDate && !dueDate)) {
				this._getAnalyticsData(config.periodFilter, function(response) {
					var resultData = response.GetParticipantsAnalyticsResult;
					if(resultData.analyticsItems.length) {
						this.diagram.updateBadges(resultData.analyticsItems);
					}
					if (showMask) {
						Terrasoft.Mask.hide(this.maskId);
					}
				}, this);
			}
		},

		/**
		 * Renders design container.
		 * @param {Ext.dom.Element} renderTo Render container.
		 * @protected
		 */
		renderDesignContainer: function(renderTo) {
			if (Terrasoft.Features.getIsEnabled("CampaignViewerReadonlyPropertiesPage")) {
				this.callParent(arguments);
			} else {
				var designContainer = this.designContainer = this.createDesignContainer();
				var designerViewModel = this.designerViewModel = this.createDesignerViewModel();
				designContainer.render(renderTo);
				designContainer.bind(designerViewModel);
			}
			this.designerViewModel.on("initializeBadges", this.onInitializeBadges, this);
			this.designerViewModel.on("reloadDiagram", this.onReloadBadges, this);
			this.designerViewModel.on("initialized", this.onDesignerViewModelInitialized, this);
		},

		/**
		 * Returns config for designer view model.
		 * @override
		 * @return {Object}
		 */
		getDesignerViewModelConfig: function() {
			var config = {
				sandbox: this.sandbox,
				id: this.id,
				values: {
					SchemaUId: this.schemaUId,
					PackageUId: this.packageUId,
					EntitySchemaUId: this.entitySchemaUId,
					EntityId: this.entityId
				}
			};
			if (Terrasoft.Features.getIsEnabled("CampaignViewerReadonlyPropertiesPage")) {
				config = this.callParent(arguments);
			}
			Ext.apply(config.values, { ShowDescriptions: true });
			return config;
		},

		/**
		 * Method to execute additional operations after designer rendered.
		 * @protected
		 */
		onAfterDesignerRender: function() {
			this.designerViewModel.init();
		},

		/**
		 * Returns config for reload diagram button.
		 * @protected
		 */
		getReloadDiagramButtonConfig: function() {
			return {
				id: this.id + "-reload-diagram-btn",
				classes: {
					wrapperClass: "t-btn-image margin-right-0px t-btn-image-left reload-diagram-button"
				},
				click: {
					bindTo: "onReloadDiagramClick"
				},
				hint: resources.localizableStrings.ReloadDiagramButtonHint,
				markerValue: "ReloadDiagramButton"
			};
		},

		/**
		 * Extends toolbox with reload diagram button.
		 * @protected
		 */
		addReloadDiagramButton: function(toolbar) {
			var reloadDiagramButton = Ext.create("Terrasoft.Button", this.getReloadDiagramButtonConfig());
			toolbar.items.splice(0,0, reloadDiagramButton);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesigner#createToolbarContainer
		 * @override
		 */
		createToolbarContainer: function() {
			var toolbar = this.callParent(arguments);
			toolbar.items.clear();
			var rightToolbar = this.createToolbarRightContainer();
			this.addDescriptionToggleButton(rightToolbar);
			this.addReloadDiagramButton(rightToolbar);
			toolbar.add(rightToolbar);
			return toolbar;
		},

		/**
		 * Handler for event "initialized" of DesignerViewModel.
		 * @protected
		 */
		onDesignerViewModelInitialized: function() {
			this.fireEvent("loadcomplete", this);
			this.diagram.initDiagram();
			Terrasoft.Mask.hide(this.maskId);
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaDesigner#createDiagramHeader
		 * @override
		 */
		createDiagramHeader: function() {
			if (Terrasoft.Features.getIsEnabled("CampaignViewerReadonlyPropertiesPage")) {
				var diagramHeader = this.callParent(arguments);
				diagramHeader.items.clear();
				var toolBar = this.createToolbarContainer();
				diagramHeader.add(toolBar);
				return diagramHeader;
			}
			return;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaDesigner#getHelpButtonConfig
		 * @override
		 */
		getHelpButtonConfig: function() {
			var config = this.callParent(arguments);
			Ext.apply(config, {
				visible: false
			});
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaDesigner#getSearchShowButtonConfig
		 * @override
		 */
		 getSearchShowButtonConfig: function() {
			var config = this.callParent(arguments);
			Ext.apply(config, {
				visible: false
			});
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaDesigner#onSandboxInitialized
		 * @override
		 */
		onSandboxInitialized: function() {
			this.callParent();
			var sandbox = this.sandbox;
			sandbox.registerMessages({
				"GetAnalyticsConfigForViewer": {
					direction: Terrasoft.MessageDirectionType.PUBLISH,
					mode: Terrasoft.MessageMode.PTP
				},
				"AnalyticsFiltersChangeForViewer": {
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE,
					mode: Terrasoft.MessageMode.PTP
				},
				"ShowBadgesChangeForViewer": {
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE,
					mode: Terrasoft.MessageMode.PTP
				}
			});
			sandbox.subscribe("AnalyticsFiltersChangeForViewer", this.onAnalyticsFiltersChange,
				this, [this.sandbox.id]);
			sandbox.subscribe("ShowBadgesChangeForViewer", this.onShowBadgesChange, this, [this.sandbox.id]);
		},

		/**
		 * Handles changes of analytics filters.
		 * @param {Object} config The analytics config.
		 */
		onAnalyticsFiltersChange: function(config) {
			var startDate = config.periodFilter.startDate;
			var dueDate = config.periodFilter.dueDate;
			if ((startDate && dueDate) || (!startDate && !dueDate) || config.badgesConfig.showHistory) {
				this._getAnalyticsData(config.periodFilter, function(response) {
					var resultData = response.GetParticipantsAnalyticsResult;
					this.diagram.updateBadges(resultData.analyticsItems);
				}, this);
			} else {
				this.diagram.updateBadges([]);
			}
		},

		/**
		 * Handles changes of analytics visibility.
		 * @param {Object} showBadges The badges visibility config.
		 */
		onShowBadgesChange: function(showBadges) {
			this.diagram.badgesConfig = showBadges;
			this.diagram.renderItems();
		},

		/**
		 * Reloads all badges from DB.
		 */
		onReloadBadges: function() {
			var showMask = true;
			this._updateAnalyticsData(showMask);
		},

		/**
		 * Handles initialization of analytics badges.
		 */
		onInitializeBadges: function() {
			this._updateAnalyticsData();
		}
	});
	return Terrasoft.CampaignSchemaViewer;
});
