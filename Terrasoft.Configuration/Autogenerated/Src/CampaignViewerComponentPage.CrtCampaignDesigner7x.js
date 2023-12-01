define("CampaignViewerComponentPage", ["ConfigurationEnums"],
	function (ConfigurationEnums) {
		return {
			mixins: {
			},
			properties: {
				isViewerLoaded: false,
				isAnalyticsFiltersLoaded: false,
				entitySchemaName: "Campaign"
			},
			messages: {
				/**
				 * @message GetSchemaViewerConfig
				 * Returns settings for the viewer module.
				 */
				"GetSchemaViewerConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				
				/**
				 * @message AnalyticsFiltersChange
				 * Sends config when time filters changed in CampaignSchemaViewerFilters.
				 */
				"AnalyticsFiltersChange": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message ShowBadgesChange
				 * Sends config when badges config changed in CampaignSchemaViewerFilters.
				 */
				"ShowBadgesChange": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				/**
				 * @message GetAnalyticsConfig
				 * Returns config with full analytics from CampaignSchemaViewerFilters.
				 */
				"GetAnalyticsConfig": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message AnalyticsFiltersChangeForViewer
				 * Sends analytics filters changes to the schema viewer.
				 */
				"AnalyticsFiltersChangeForViewer": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message ShowBadgesChangeForViewer
				 * Sends badges visibility changes to the schema viewer.
				 */
				"ShowBadgesChangeForViewer": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message GetAnalyticsConfigForViewer
				 * Returns analytics settings for the schema viewer.
				 */
				"GetAnalyticsConfigForViewer": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			attributes: {
				"Id": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"CampaignSchemaUId": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"PlaceholderImageId": {
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: this.Terrasoft.DataValueType.STRING,
					value: "9F60D134-1233-4CCA-BEB6-3F2DA0135D45"
				}
			},
			modules: /**SCHEMA_MODULES*/ {
				"CampaignSchemaViewerFilters": {
					"config": {
						"schemaName": "CampaignSchemaViewerFilters",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								"CardSchemaName": {
									"propertyValue": "name"
								},
								"CampaignId": {
									"attributeValue": "Id"
								}
							}
						}
					}
				}
			},
			methods: {
				isDiagramDesigned: function() {
					return Boolean(this.get("CampaignSchemaUId"));
				},
				
				isDiagramNotDesigned: function() {
					return !this.isDiagramDesigned();
				},
				
				getPlaceholderImage: function() {
					return this.getSysImageUrl(this.$PlaceholderImageId);
				},
				
				getSysImageUrl: function(sysImageId) {
					var imageConfig = {
						source: Terrasoft.ImageSources.SYS_IMAGE,
						params: {
							primaryColumnValue: sysImageId
						}
					};
					return Terrasoft.ImageUrlBuilder.getUrl(imageConfig);
				},

				_extendWithEntityColumns: function () {
					var entityColumns = {};
					Terrasoft.each(this.entitySchema.columns, function (entitySchemaColumn, columnName) {
						var column = Ext.apply(entitySchemaColumn, {
							"columnPath": entitySchemaColumn.name,
							"type": Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
							"modelName": this.entitySchema.name
						});
						entityColumns[columnName] = column;
					}, this);
					this.columns = Ext.apply(this.columns, entityColumns);
				},

				isNewMode: function () {
					return this.$Operation === ConfigurationEnums.CardStateV2.ADD;
				},

				subscribeMessages: function () {
					var campaignViewerModuleId = this.getCampaignViewerModuleId();
					var schemaViewerFiltersModuleId = this.getSchemaViewerFiltersModuleId();
					this.sandbox.subscribe("GetSchemaViewerConfig", this.onGetCampaignViewerConfig, this,
						[campaignViewerModuleId]);
					this.sandbox.subscribe("GetAnalyticsConfigForViewer", this.onGetAnalyticsConfig, this,
						[campaignViewerModuleId]);
					this.sandbox.subscribe("AnalyticsFiltersChange", this.onAnalyticsFiltersChange, this,
						[schemaViewerFiltersModuleId]);
					this.sandbox.subscribe("ShowBadgesChange", this.onShowBadgesChange, this,
						[schemaViewerFiltersModuleId]);
				},

				init: function (callback, scope) {
					this.entitySchema = { name: this.entitySchemaName };
					this.callParent([function () {
						this.subscribeMessages();
						Terrasoft.chain(
							function (next) {
								this.getEntitySchemaByName(this.entitySchemaName, next, this);
							},
							function (next, entitySchema) {
								this.entitySchema = entitySchema || {};
								this._extendWithEntityColumns();
								this.subscribeViewModelEvents();
								this.loadEntity(this.$Id, next, this);
							},
							function () {
								callback.call(scope);
							}, this
						);
					}, this]);
				},

				onAnalyticsFiltersChange: function(filtersConfig) {
					this.isAnalyticsFiltersLoaded = true;
					if (this.isViewerLoaded) {
						var schemaViewerModuleId = this.getCampaignViewerModuleId();
						this.sandbox.publish("AnalyticsFiltersChangeForViewer", filtersConfig, [schemaViewerModuleId]);
					}
				},

				onShowBadgesChange: function(badgesConfig) {
					this.isAnalyticsFiltersLoaded = true;
					if (this.isViewerLoaded) {
						var schemaViewerModuleId = this.getCampaignViewerModuleId();
						this.sandbox.publish("ShowBadgesChangeForViewer", badgesConfig, [schemaViewerModuleId]);
					}
				},

				onGetAnalyticsConfig: function() {
					this.isViewerLoaded = true;
					var filtersModuleId = this.getSchemaViewerFiltersModuleId();
					return this.isAnalyticsFiltersLoaded
						? this.sandbox.publish("GetAnalyticsConfig", null, [filtersModuleId])
						: null;
				},

				onGetCampaignViewerConfig: function() {
					return {
						schemaUId: this.$CampaignSchemaUId,
						entityId: this.$Id,
						entitySchemaUId: this.entitySchema.uId
					};
				},

				getCampaignViewerModuleId: function () {
					return this.getModuleId("CampaignSchemaViewerModuleId");
				},

				getSchemaViewerFiltersModuleId: function() {
					return this.getModuleId("CampaignSchemaViewerFilters");
				},

				loadCampaignViewerModule: function () {
					this.sandbox.loadModule("CampaignSchemaViewerModule", {
						renderTo: "CampaignSchemaViewerModuleContainer",
						id: this.getCampaignViewerModuleId()
					});
					this.isViewerLoaded = true;
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "CampaignViewerComponentPageContainer",
					"values": {
						"id": "CampaignSchemaViewerModuleWrapContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["campaign-viewer-component-page-wrap"],
						"items": []
					},
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "NotSelectedImage",
					"parentName": "CampaignViewerComponentPageContainer",
					"propertyName": "items",
					"values": {
						"markerValue": "NotSelectedImage",
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"onPhotoChange": Terrasoft.emptyFn,
						"getSrcMethod": "getPlaceholderImage",
						"classes": {
							"wrapClass": ["not-selected-image"]
						},
						"visible": "$isDiagramNotDesigned",
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "NotSelectedLabel",
					"parentName": "CampaignViewerComponentPageContainer",
					"propertyName": "items",
					"values": {
						"markerValue": "NotSelectedLabel",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["description-container"],
						"visible": "$isDiagramNotDesigned",
						"items": [
							{
								"itemType": Terrasoft.ViewItemType.LABEL,
								"classes": {
									"labelClass": [
										"description-label"
									],
									"wrapClass": [
										"description-wrap"
									]
								},
								"caption": { bindTo: "Resources.Strings.EmptyPageCaption" }
							}
						]
					}
				},
				{
					"operation": "insert",
					"name": "AnalyticsHeaderContainer",
					"parentName": "CampaignViewerComponentPageContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"classes": {
							"wrapClassName": ["campaign-analytics-header-container"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "CampaignSchemaViewerFilters",
					"parentName": "AnalyticsHeaderContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"colSpan": 22,
							"rowSpan": 1,
							"column": 0,
							"row": 0,
							"layoutName": "PropertiesContainer"
						},
						"itemType": this.Terrasoft.ViewItemType.MODULE,
						"visible": "$isDiagramDesigned"
					}
				},
				{
					"operation": "insert",
					"name": "CampaignSchemaViewerContainer",
					"parentName": "CampaignViewerComponentPageContainer",
					"propertyName": "items",
					"values": {
						"id": "CampaignAnaliticsContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"afterrender": {"bindTo": "loadCampaignViewerModule"},
						"afterrerender": {"bindTo": "loadCampaignViewerModule"},
						"wrapClass": ["schema-viewer-container"],
						"items": [],
						"visible": "$isDiagramDesigned"
					}
				},
				{
					"operation": "insert",
					"name": "CampaignSchemaViewerModuleContainer",
					"parentName": "CampaignSchemaViewerContainer",
					"values": {
						"id": "CampaignSchemaViewerModuleContainer",
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"items": []
					},
					"propertyName": "items"
				},
			]
		};
	});
