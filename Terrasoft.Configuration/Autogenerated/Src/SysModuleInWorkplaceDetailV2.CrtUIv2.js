﻿define("SysModuleInWorkplaceDetailV2", ["LocalizableHelper", "ServiceHelper", "SysModuleInWorkplaceDetailV2Resources",
	"InformationButtonResources", "GridUtilities", "DesignTimeEnums",
	"SectionServiceMixin", "ControlGridModule", "SectionInWorkplaceGridViewModel"
], function(LocalizableHelper, ServiceHelper, resources, informationButtonResources) {
	return {
		entitySchemaName: "SysModuleInWorkplace",

		properties: {

			/**
			 * Use Detail wizard for detail
			 */
			useDetailWizard: false,

			/**
			 * List of hidden system modules.
			 * @type {Array}
			 */
			hiddenModuleCodes: ["SysAdminOperation", "SysAdminUnit", "FuncRoles", "VwSysDcmLib", "OAuth20App", "Activity"],

			/**
			 * List of  hidden system modules for SSP workplace.
			 * @type {Array}
			 */
			sspHiddenModuleCodes: ["Contact", "Account"],

			/**
			 * Identifier of 'SectionSchemaViewModule' - new UI module.
			 */
			sectionModuleSchemaUId: '12244568-6d4f-f201-ed26-ac3913021080'
		},

		messages: {
			/**
			 * @message UpdateWorkplaceType
			 * Calls workplace type update for page and detail.
			 */
			"UpdateWorkplaceType": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.BIDIRECTIONAL
			},

			/**
			 * @message HideRightsErrorTip
			 * Hides rights errors tip.
			 */
			"HideRightsErrorTip": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		mixins: {
			/**
			 * @class SectionServiceMixin
			 * Section service mixin.
			 */
			SectionServiceMixin: Terrasoft.SectionServiceMixin
		},

		attributes: {
			/**
			 * Sign that current workplace is portal.
			 */
			"IsCurrentWorkplaceSSP": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN
			},
			/**
			 * Section types enum.
			 * @protected
			 */
			"SectionTypes": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
			},

			/**
			 * Sections those have no ssp sections.
			 * @protected
			 */
			"SectionsWithoutSspSectionIds": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
			}
		},

		methods: {
			
			//region Methods: Private
			
			/**
			 * Check that all selected rows can be added without designer.
			 * @private
			 * @param {Object} selectedRows Selected rows in section lookup page.
			 * @returns {Boolean} True if all selected record can use new Interface Designer. Returns false otherwise.
			 */
			_isAllRowsHasNewDesignerInterface: function(selectedRows) {
				var rows = selectedRows.getItems();
				return Ext.Array.every(rows, function(item) {
					return this._isNewInterfaceDesignerSection(item ? item.value : null, item.SectionModuleSchemaUId);
				}, this);
			},
			/**
			 * @private
			 * @param {Object} module SysModule data.
			 * @param {String} moduleSchemaUId Identifier of module schema UId. 
			 * @returns {Boolean} True if selected record can use new Interface Designer. Returns false otherwise.
			 */
			_isNewInterfaceDesignerSection: function (moduleId, moduleSchemaUId) {
				var isNewInterfaceDesignerSection = false;
				if (moduleId) {
					isNewInterfaceDesignerSection = moduleSchemaUId === this.sectionModuleSchemaUId;
					var structureData = Object.values(Terrasoft.configuration.ModuleStructure)
						.find(function (item) {
							if (item.moduleId === moduleId) {
								return item;
							}
						});
					if (!structureData || !structureData.cardModule) {
						return isNewInterfaceDesignerSection;
					}
					isNewInterfaceDesignerSection = structureData.cardModule === "CardSchemaViewModule";
				}
				return isNewInterfaceDesignerSection;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#onCardSaved
			 * @override
			 */
			onCardSaved: function() {
				this.openSysModuleLookup();
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getAddRecordButtonVisible
			 * @override
			 */
			getAddRecordButtonVisible: function() {
				return this.getToolsVisible();
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecord
			 * @override
			 */
			addRecord: function() {
				this.sandbox.publish("SaveRecord", {
					isSilent: true,
					messageTags: [this.sandbox.id]
				}, [this.sandbox.id]);
			},

			/**
			 * Gets hidden (system) modules filter.
			 * @private
			 * @return {Terrasoft.FilterGroup}
			 */
			getHiddenModulesFilter: function() {
				var hiddenModuleCodes = this.getHiddenModuleCodes();
				var hiddenModulesFilter = Terrasoft.createColumnInFilterWithParameters("Code", hiddenModuleCodes);
				hiddenModulesFilter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
				return hiddenModulesFilter;
			},

			/**
			 * Opens modules lookup.
			 * @private
			 */
			openSysModuleLookup: function() {
				var esq = new Terrasoft.EntitySchemaQuery("SysModuleInWorkplace");
				esq.addColumn("SysModule.Id", "SysModuleId");
				var workplaceId = this.get("MasterRecordId");
				esq.filters.addItem(Terrasoft.createColumnFilterWithParameter("SysWorkplace", workplaceId));
				esq.getEntityCollection(function(result) {
					var existsCollection = [];
					if (result.success) {
						result.collection.each(function(item) {
							existsCollection.push(item.get("SysModuleId"));
						});
					}
					var filterGroup = Terrasoft.createFilterGroup();
					filterGroup.addItem(Terrasoft.createColumnIsNotNullFilter("SectionModuleSchemaUId"));
					var hiddenModulesFilter = this.getHiddenModulesFilter();
					filterGroup.addItem(hiddenModulesFilter);
					if (this.$IsCurrentWorkplaceSSP) {
						this.addSspSectionFilterGroup(filterGroup);
					} else {
						if (this.getIsFeatureEnabled("UseTypedWorkplaces")) {
							this.addGeneralSectionFilters(filterGroup);
						}
					}
					if (existsCollection.length > 0) {
						var existsFilter = Terrasoft.createColumnInFilterWithParameters("Id", existsCollection);
						existsFilter.comparisonType = Terrasoft.ComparisonType.NOT_EQUAL;
						filterGroup.addItem(existsFilter);
					}
					var config = {
						entitySchemaName: "SysModule",
						multiSelect: !this.$IsCurrentWorkplaceSSP,
						filters: filterGroup,
						columns: ["SectionModuleSchemaUId"],
					};
					this.openLookup(config, this.onSectionsSelected, this);
				}, this);
			},

			/**
			 * Adds selected sections to workplace.
			 * @private
			 * @param {Object} selectedRows Selected rows in section lookup page.
			 */
			_addSectionsToWorkplace: function(selectedRows) {
				var rows = this.selectedRows = selectedRows.getItems();
				this._addSectionsToWorkplaceUsingApi(rows);
			},

			/**
			 * Adds selected sections to workplace using workplace API.
			 * @private
			 * @param {Array} selectedRows Selected sections array.
			 */
			_addSectionsToWorkplaceUsingApi: function(rows) {
				var newSectionInWorkplace = [];
				var workplaceId = this.get("MasterRecordId");
				rows.forEach(function(item) {
					newSectionInWorkplace.push({
						"workplaceId": workplaceId,
						"sectionId": item.value
					});
				}, this);
				var generatorFn = function(newItem) {
					return function(next) {
						this._addSectionToWorkplaceUsingApi(newItem, next, this);
					}.bind(this);
				}.bind(this);
				Terrasoft.chainForArray(newSectionInWorkplace, generatorFn, function() {
					this.reloadGridData();
					this.sandbox.publish("UpdateWorkplaceType");
				}, this);
			},

			/**
			 * Adds section to workplace using workplace API.
			 * @private
			 * @param {Object} sectionConfig Section config.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			_addSectionToWorkplaceUsingApi: function(sectionConfig, callback, scope) {
				var serviceConfig = {
					data: {
						"workplaceId": sectionConfig.workplaceId,
						"sectionId": sectionConfig.sectionId
					},
					serviceName: "WorkplaceService",
					methodName: "AddSectionToWorkplace"
				};
				this.callService(serviceConfig, callback, scope);
			},

			/**
			 * Gets module insert query.
			 * @private
			 * @param {Object} item Selected item.
			 */
			getInsertQuery: function(item) {
				var insert = Ext.create("Terrasoft.InsertQuery", {
					rootSchemaName: "SysModuleInWorkplace"
				});
				insert.setParameterValue("SysModule", item.value, Terrasoft.DataValueType.GUID);
				insert.setParameterValue("SysWorkplace", this.get("MasterRecordId"), Terrasoft.DataValueType.GUID);
				return insert;
			},

			/**
			 * Processes item insert query result.
			 * @private
			 * @param {Object} response Response.
			 */
			onItemInsert: function(response) {
				if (!response.success) {
					this.hideBodyMask();
					var errorInfo = response.errorInfo;
					throw new Terrasoft.UnknownException({
						message: errorInfo.message
					});
				}
				var queryResult = response.queryResults;
				var rowIds = [];
				Terrasoft.each(queryResult, function(item) {
					if (item.id) {
						rowIds.push(item.id);
					}
				});
				var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchema: this.entitySchema
				});
				this.initQueryColumns(esq);
				this.initQuerySorting(esq);
				var filter = Terrasoft.createColumnInFilterWithParameters(this.primaryColumnName, rowIds);
				filter.comparisonType = Terrasoft.ComparisonType.EQUAL;
				esq.filters.addItem(filter);
				esq.getEntityCollection(function(response) {
					this.hideBodyMask();
					this.onGridDataLoaded(response);
				}, this);
			},

			/**
			 * Set row count for load grid data.
			 * @private
			 */
			_setRowCount: function() {
				var gridData = this.getGridData();
				var count = gridData && gridData.getCount();
				if (!count) {
					return;
				}
				if (!this.$CanLoadMoreData) {
					count++;
				}
				var profile = this.get("Profile");
				var isTiledGrid = profile && profile.DataGrid && profile.DataGrid.isTiled;
				this.set("RowCount", isTiledGrid ? count : count / 2);
			},

			/**
			 * Sets module position.
			 * @private
			 * @param {String} recordId Record identifier.
			 * @param {Number} position Position.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback execution scope.
			 */
			setPosition: function(recordId, position, callback, scope) {
				var data = {
					tableName: "SysModuleInWorkplace",
					primaryColumnValue: recordId,
					position: position,
					grouppingColumnNames: "SysWorkplaceId"
				};
				this._setRowCount();
				ServiceHelper.callService("RightsService", "SetCustomRecordPosition", callback, data, scope);
			},

			/**
			 * Processes active row action.
			 * @private
			 * @param {String} buttonTag Button tag.
			 */
			onActiveRowAction: function(buttonTag) {
				var position;
				var activeRow = this.getActiveRow();
				switch (buttonTag) {
					case "Up":
						position = activeRow.get("Position");
						if (position > 0) {
							position--;
							this.setPosition(activeRow.get("Id"), position, this.reloadGridData, this);
						}
						break;
					case "Down":
						position = activeRow.get("Position");
						position++;
						this.setPosition(activeRow.get("Id"), position, this.reloadGridData, this);
						break;
					case "PageWizard":
						this.tryOpenSectionWizard(activeRow);
						break;
					case "PageWizardV2":
						this.tryOpenInterfaceDesigner(activeRow, "SysModule.CardSchemaUId");
						break;
					case "ListWizardV2":
						this.tryOpenInterfaceDesigner(activeRow,"SysModule.SectionSchemaUId");
						break;
					default:
						break;
				}
			},

			/**
			 * Returns record last changed values attribute name.
			 * @private
			 * @param {String} recordId Record identifier.
			 * @return {String} Record last changed values attribute name.
			 */
			_getChangedValuesKey: function(recordId) {
				return Ext.String.format("{0}_Changes", recordId);
			},

			/**
			 * Returns record last changed values object.
			 * @private
			 * @param {String} recordId Record identifier.
			 * @return {Object} Record last changed values object.
			 */
			_getRowLastChange: function(recordId) {
				var key = this._getChangedValuesKey(recordId);
				return this.get(key) || {};
			},

			/**
			 * Saves record last changed values object.
			 * @private
			 * @param {String} recordId Record identifier.
			 * @param {Object} changedValues Record changed values.
			 * @return {Object} Record last changed values object.
			 */
			_setRowLastChange: function(recordId, changedValues) {
				var changes = Terrasoft.deepClone(changedValues);
				delete changes.HasErrorsTipVisible;
				var key = this._getChangedValuesKey(recordId);
				this.set(key, changes);
				return changes;
			},

			/**
			 * Opens SSP section wizard tab for selected section.
			 * @private
			 * @param {String} sectionId Section unique identifier.
			 */
			_openSspSectionWizard: function(sectionId) {
				this.openSectionWindow(sectionId, "SspMainSettings", null,
					"/AddSsp/" + this.get("MasterRecordId"));
			},

			//endregion

			//region Methods: Protected

			/**
			 * Subscribes viewmodel to server messages.
			 * @protected
			 */
			subscribeServerChannelEvents: function() {
				this.Terrasoft.ServerChannel.on(this.Terrasoft.EventName.ON_MESSAGE,
					this.onServerChannelMessage, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#destroy
			 * @overridden
			 */
			destroy: function() {
				this.Terrasoft.ServerChannel.un(this.Terrasoft.EventName.ON_MESSAGE,
					this.onServerChannelMessage, this);
				this.callParent(arguments);
			},

			/**
			 * Server message handler. If sender UpdateSectionInWorkplace, updates grid.
			 * @protected
			 * @param {Object} scope Message scope.
			 * @param {Object} message Server messsage.
			 */
			onServerChannelMessage: function(scope, message) {
				if (this.isEmpty(message) || this.isEmpty(message.Header)) {
					return;
				}
				this.processNewSectionMessage(message);
			},

			/**
			 * Updates grid on server message.
			 * @protected
			 * @param {Object} message Server channel message.
			 */
			processNewSectionMessage: function(message) {
				if (message.Header.Sender === "UpdateSectionInWorkplace") {
					this.reloadGridData();
				}
			},

			/**
			 * Gets system modules.
			 * @protected
			 * @return {String[]}
			 */
			getHiddenModuleCodes: function() {
				var codes = this.hiddenModuleCodes;
				if (this.$IsCurrentWorkplaceSSP) {
					codes = codes.concat(this.sspHiddenModuleCodes);
				}
				return codes;
			},

			/**
			 * Processes module select result.
			 * @potected
			 * @param {Object} args Module select information.
			 */
			onSectionsSelected: function(args) {
				var selectedRows = args.selectedRows;
				var isIgnoreOpenWizard = this._isAllRowsHasNewDesignerInterface(args.selectedRows);
				if (!this.$IsCurrentWorkplaceSSP || isIgnoreOpenWizard) {
					this._addSectionsToWorkplace(selectedRows);
				} else {
					this.initGeneralAndSspSections(selectedRows);
				}
			},

			/**
			 * Processed receiving general and portal sections from service.
			 * @overridden
			 * @param {Object} result General and portal sections.
			 * @param {Object} selectedRows Selected rows in section lookup page.
			 */
			processedGeneralAndSspSections: function(result, selectedRows) {
				var generalAndSspSections7x = Ext.Array.filter(result.GetGeneralAndSspSectionsResult, function (item) {
					let parsedItem = JSON.parse(item);
					return !this._isNewInterfaceDesignerSection(parsedItem.Id, parsedItem.moduleSchemaUId);
				}, this);
				if (generalAndSspSections7x) {
					var sectionId = selectedRows.getByIndex(0).value;
					if (generalAndSspSections7x.length === 2) {
						var isSspSectionExists = false;
						var isSelectedSectionSSP = Ext.Array.findBy(generalAndSspSections7x, function(item) {
							var selectedSection = JSON.parse(item);
							var sectionTypes = this.$SectionTypes || {};
							isSspSectionExists = isSspSectionExists || selectedSection.Type === sectionTypes.SSP;
							return selectedSection.Id === sectionId && selectedSection.Type === sectionTypes.SSP;
						}, this);
						if (isSelectedSectionSSP) {
							this._addSectionsToWorkplace(selectedRows);
						} else if (isSspSectionExists) {
							this.showInformationDialog(
								this.get("Resources.Strings.SelectedSectionAlreadyRegisteredAsSSP"));
						} else {
							this._openSspSectionWizard(sectionId);
						}
					} else {
						this._openSspSectionWizard(sectionId);
					}
				}
			},

			/**
			 * Opens section wizard for selected section.
			 * @protected
			 * @param {Terrasoft.configuration.BaseGridRowViewModel} record Active record in detail.
			 */
			tryOpenSectionWizard: function(record) {
				var module = record.get("SysModule");
				var stepName = this.$IsCurrentWorkplaceSSP ? "SspMainSettings" : null;
				if (module && module.value) {
					this.openSectionWindow(module.value, stepName);
				}
			},
			/**
			 * Opens section wizard for selected section.
			 * @protected
			 * @param {Terrasoft.configuration.BaseGridRowViewModel} record Active record in detail.
			 * @param {String} designerColumn Opened schema UId column.
			 */
			tryOpenInterfaceDesigner: function(record, designerColumn) {
				const wizardUrlEnum = Terrasoft.DesignTimeEnums.WizardUrl;
				var schemaId = record.get(designerColumn);
				this.openWizardWindow(wizardUrlEnum.INTERFACE_DESIGNER_URL, null, schemaId);
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridDataColumns
			 * @override
			 */
			getGridDataColumns: function() {
				var gridDataColumns = this.callParent(arguments);
				if (!gridDataColumns.Position) {
					gridDataColumns.Position = {
						path: "Position",
						orderPosition: 0,
						orderDirection: Terrasoft.OrderDirection.ASC
					};
				}
				return gridDataColumns;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#initQueryColumns
			 * @overridde
			 */
			 initQueryColumns: function(esq) {
				this.callParent(arguments);
				esq.addColumn("SysModule.SectionSchemaUId");
				esq.addColumn("SysModule.CardSchemaUId");
				esq.addColumn("SysModule.SectionModuleSchemaUId", "SysModuleSectionModuleSchemaUId")
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([
					function() {
						this.setDetailAttributes();
						this.subscribeServerChannelEvents();
						if (this.$IsCurrentWorkplaceSSP) {
							this.setSectionsWithoutSspSection(callback, scope || this);
							return;
						}
						this.Ext.callback(callback, scope || this);
					}, this
				]);
			},

			/**
			 * Sets SectionsWithoutSspSectionIds.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			setSectionsWithoutSspSection: function(callback, scope) {
				var config = {
					serviceName: "SectionService",
					methodName: "GetSectionsWithoutSspView"
				};
				this.callService(config, function(result) {
					if (result && result.GetSectionsWithoutSspViewResult) {
						this.$SectionsWithoutSspSectionIds = [];
						this.Ext.Array.each(result.GetSectionsWithoutSspViewResult, function(item) {
							this.$SectionsWithoutSspSectionIds.push(JSON.parse(item).Id);
						}, this);
					}
					this.Ext.callback(callback, scope);
				}, this);
			},

			/**
			 * Sets detail attributes.
			 * @protected
			 */
			setDetailAttributes: function() {
				var defaultValues = this.$DefaultValues;
				var isWorkplaceSSPDefValue = Ext.Array.findBy(defaultValues, function(item) {
					return item.name === "IsCurrentWorkplaceSSP";
				}, this);
				this.$IsCurrentWorkplaceSSP = isWorkplaceSSPDefValue ? isWorkplaceSSPDefValue.value : false;
				var sectionTypesDefValue = Ext.Array.findBy(defaultValues, function(item) {
					return item.name === "SectionTypes";
				}, this);
				this.$SectionTypes = sectionTypesDefValue ? sectionTypesDefValue.value : {};
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#subscribeSandboxEvents
			 * @override
			 */
			subscribeSandboxEvents: function() {
				this.callParent(arguments);
				this.sandbox.subscribe("UpdateWorkplaceType", this.updateWorkplaceType, this, [this.sandbox.id]);
			},

			/**
			 * Sets current workplace type property.
			 * @protected
			 * @param {Integer} value Workplace type.
			 */
			updateWorkplaceType: function(value) {
				this.$IsCurrentWorkplaceSSP = value;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @override
			 */
			getEditRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @override
			 */
			getCopyRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
			 * @override
			 */
			getGridRowViewModelClassName: function() {
				return "Terrasoft.SectionInWorkplaceGridViewModel";
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelConfig
			 * @override
			 */
			getGridRowViewModelConfig: function(data) {
				var gridRowViewModelConfig = this.callParent(arguments);
				this.Ext.apply(gridRowViewModelConfig, {
					sandbox: this.sandbox
				});
				var newInterfaceDesignerButtonConfig = {
					IsNewInterfaceDesignerSection: false
				};
				if (Ext.isFunction(this._isNewInterfaceDesignerSection) && data && data.rawData && data.rawData.SysModule) {
					newInterfaceDesignerButtonConfig = {
						IsNewInterfaceDesignerSection: this._isNewInterfaceDesignerSection(
							data.rawData.SysModule ? data.rawData.SysModule.value :  null,
							data.rawData.SysModuleSectionModuleSchemaUId
						)
					};
				}
				Ext.apply(gridRowViewModelConfig.values, newInterfaceDesignerButtonConfig);
				return gridRowViewModelConfig;
			},

			/**
			 * Creates SysModule column control config.
			 * @protected
			 * @param {Object} control Column control options object.
			 */
			getSysModuleControlConfig: function(control) {
				var sectionNameLabel = {
					"className": "Terrasoft.Label",
					"caption": {"bindTo": "SysModule"},
					"markerValue": {"bindTo": "getSysModuleName"},
					"classes": {
						"labelClass": ["sysmodule-name-label"]
					}
				};
				if (!this.$IsCurrentWorkplaceSSP) {
					control.config = sectionNameLabel;
					return;
				}
				control.config = {
					"className": "Terrasoft.Container",
					"classes": {
						"wrapClassName": ["sysmodule-name-container"]
					},
					"items": [
						sectionNameLabel,
						{
							"className": "Terrasoft.InformationButton",
							"imageConfig": informationButtonResources.localizableImages.WarningIcon,
							"visible": {"bindTo": "HasErrors"},
							"markerValue": {"bindTo": "getInformationButtonMarker"},
							"tips": [{
								"tip": {
									"style": Terrasoft.TipStyle.RED,
									"restrictAlignType": Terrasoft.AlignType.RIGHT,
									"markerValue": "SysModuleRightsErrorTip",
									"visible": {"bindTo": "HasErrorsTipVisible"},
									"items": [{
										"className": "Terrasoft.Container",
										"classes": {
											"wrapClassName": ["information-container-wrap"]
										},
										"markerValue": {"bindTo": "Id"},
										"afterrender": {"bindTo": "loadInformationModule"},
										"afterrerender": {"bindTo": "loadInformationModule"},
										"items": []
									}]
								},
								"settings": {
									"displayEvent": Terrasoft.TipDisplayEvent.CLICK
								}
							}]
						}
					]
				};
			},

			/**
			 * Checks is record grid row update needed.
			 * @protected
			 * @param {String} recordId Record identifier.
			 * @param {Object} changedValues Record changed values object.
			 * @return {Boolean} True if update needed. Returns false otherwise.
			 */
			getNeedUpdateRow: function(recordId, changedValues) {
				var prevChange = this._getRowLastChange(recordId);
				var currentChange = this._setRowLastChange(recordId, changedValues);
				return !Ext.Object.equals(prevChange, currentChange);
			},

			/**
			 * Adds ssp section filterGroup with type filter and SectionsWithoutSspSectionIds filter into filterGroup.
			 * @protected
			 * @param {Object} filterGroup filterGroup for SysModuleLookup.
			 */
			addSspSectionFilterGroup: function(filterGroup) {
				const sspFilterGroup = this.Terrasoft.createFilterGroup();
				sspFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
				sspFilterGroup.addItem(this.Terrasoft.createColumnInFilterWithParameters("Id",
					this.$SectionsWithoutSspSectionIds));
				sspFilterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter("Type", this.$SectionTypes.SSP));
				sspFilterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter("SectionModuleSchemaUId", this.sectionModuleSchemaUId));
				filterGroup.addItem(sspFilterGroup);
			},

			/**
			 * Adds GENERAL type section filters.
			 * @protected
			 * @param {Object} filterGroup filterGroup for SysModuleLookup.
			 */
			addGeneralSectionFilters: function(filterGroup) {
				const generalFilterGroup = this.Terrasoft.createFilterGroup("IsGeneralSectionFilters");
				generalFilterGroup.add("IsGeneralTypeFilter", this.Terrasoft.createColumnFilterWithParameter("Type",
					this.$SectionTypes.GENERAL));
				filterGroup.addItem(generalFilterGroup);
			}

			//endregion

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "Detail",
				"values": {
					"wrapClass": ["hide-grid-caption-wrapClass"]
				}
			},
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"className": "Terrasoft.ControlGrid",
					"controlColumnName": "SysModule",
					"applyControlConfig": {"bindTo": "getSysModuleControlConfig"},
					"needUpdateRow": {"bindTo": "getNeedUpdateRow"},
					"activeRowActions": [],
					"activeRowAction": {"bindTo": "onActiveRowAction"},
					"type": "listed",
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "SysModuleGridColumn",
								"bindTo": "SysModule",
								"position": {
									"column": 0,
									"colSpan": 8
								}
							}
						]
					},
					"tiledConfig": {
						"name": "DataGridTiledConfig",
						"grid": {
							"columns": 24,
							"rows": 3
						},
						"items": [
							{
								"name": "SysModuleGridColumn",
								"bindTo": "SysModule",
								"position": {"column": 0, "colSpan": 8}
							}
						]
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowUpButton",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"imageConfig": LocalizableHelper.localizableImages.Up,
					"tag": "Up"
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowDownButton",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"imageConfig": LocalizableHelper.localizableImages.Down,
					"tag": "Down"
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowOpenWizardButton",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"visible": {
						"bindTo": "IsNewInterfaceDesignerSection",
						"bindConfig": {"converter": "invertBooleanValue"}
					},
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.OpenSectionWizardButtonCaption,
					"tag": "PageWizard"
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowOpenListWizardV2Button",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"className": "Terrasoft.Button",
					"visible": {"bindTo": "IsNewInterfaceDesignerSection"},
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.OpenListWizardButtonCaption,
					"tag": "ListWizardV2"
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowOpenPageWizardV2Button",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"values": {
					"visible": {"bindTo": "IsNewInterfaceDesignerSection"},
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.OpenPageWizardButtonCaption,
					"tag": "PageWizardV2"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

