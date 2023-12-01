﻿define('LeadEditPageDesigner', ['ext-base', 'core', 'terrasoft', 'sandbox', 'StructureExplorerUtilities',
	'LeadEditPageDesignerViewGenerator', 'LeadEditPageDesignerViewModelGenerator', 'LeadEditPageDesignerHelper'],
	function(Ext, core, Terrasoft, sandbox, StructureExplorerUtilities,
			viewGenerator, viewModelGenerator, LeadEditPageDesignerHelper) {
		function createConstructor(context) {
			var viewModel;
			var info;
			var viewRenderTo;
			var parentSchemaName;
			var recordId;
			var cardSchema = null;
			var cardView = null;
			var mainViewRenderTo = null;
			var Ext = context.Ext;
			var sandbox = context.sandbox;
			var Terrasoft = context.Terrasoft;

			function loadCardView(renderTo) {
				mainViewRenderTo = renderTo;
				var state = sandbox.publish('GetHistoryState').state;
				if (viewModel && (state.action !== "view")) {
					var generatedViewConfig = viewGenerator.generate();
					var config = Ext.clone(generatedViewConfig);
					var genView = Ext.create(config.className || 'Terrasoft.Container', config);
					genView.bind(viewModel);
					genView.render(renderTo);
					var modificationsList = viewModel.get('ModificationsList');
					var cardRenderTo = Ext.get('autoGeneratedContainer');
					var generatedCardViewConfig = viewGenerator.generateCard(cardSchema, info, modificationsList);
					cardView = Ext.create(generatedCardViewConfig.className || 'Terrasoft.Container',
						generatedCardViewConfig);
					cardView.bind(viewModel);
					cardView.render(cardRenderTo);
					var currentElement = viewModel.getCurrentElement();
					if (currentElement) {
						viewModel.highlightContainer(currentElement);
					}
					return;
				}
				var schemaName = state.schemaName  || '';
				parentSchemaName = state.parentSchemaName || '';
				recordId = state.recordId || '';
				var action = state.action || '';
				if (schemaName) {
					var map = {};
					map[schemaName] = {
						sandbox: 'sandbox_' + sandbox.id,
						'ext-base': 'ext_' + Ext.id
					};
					requirejs.config({
						map: map
					});
					require([schemaName], function(schema) {
						schema.name = schemaName;
						cardSchema = createSchema(schema);
						cardSchema.action = action;
						LeadEditPageDesignerHelper.loadWebFormLeadColumns(recordId, action,
							function(schemaLeadColumns) {
								LeadEditPageDesignerHelper.addWebFormLeadColumns(cardSchema, schemaLeadColumns);
								var viewModelConfig = createViewModelClassBySchema(cardSchema);
								viewModel = Ext.create(viewModelConfig.name, {
									values: {
										recordId: recordId,
										Columns: schemaLeadColumns,
										activeItemActions: viewGenerator.getItemActionsConfig()
									}
								});
								viewModel.entitySchemaInfo = viewModelConfig.entitySchemaInfo;
								viewModel.getSandbox = function() {
									return sandbox;
								};
								var allLeadColumns = viewModelConfig.entitySchema.columns;
								Terrasoft.each(allLeadColumns, function(item) {
									var itemIsEnabled =
										viewModelConfig.getColumnAddItemEnabledPropertyName(item.name);
									viewModel.set(itemIsEnabled, true);
								});
								schemaLeadColumns.getItems().forEach(function(item) {
									var itemIsEnabled =
										viewModelConfig.getColumnAddItemEnabledPropertyName(item.name);
									viewModel.set(itemIsEnabled, false);
								});
								var generatedViewConfig = viewGenerator.generate();
								var view = Ext.create(generatedViewConfig.className || 'Terrasoft.Container',
									generatedViewConfig);
								viewRenderTo = renderTo;
								view.bind(viewModel);
								view.render(viewRenderTo);
								loadCommandLine();
								var cardRenderTo = Ext.get('autoGeneratedContainer');
								var generatedCardViewConfig = viewGenerator.generateCard(cardSchema, info);
								cardView = Ext.create(generatedCardViewConfig.className || 'Terrasoft.Container',
									generatedCardViewConfig);
								cardView.bind(viewModel);
								cardView.render(cardRenderTo);
								viewModel.highlightFirst();

							}, viewModel);
					});
				}
			}
			function createSchema(schemaConfig) {
				schemaConfig.userCode.call(schemaConfig);
				return schemaConfig;
			}
			function createViewModelClassBySchema(schema) {
				info = this.info =  {
					details: [],
					rules: [],
					columns: [],
					dependencies: [],
					filters: [],
					sysSettings: []
				};
				var basePanelConfig = {
					bindings: schema.bindings,
					action: schema.action,
					info: info,
					useInfoButtons: false
				};
				var viewModelConfig = viewModelGenerator.generate(schema, info);
				viewModelConfig.cancel = function() {
					var cardSchemaModuleName = cardSchema.name;
					requirejs.undef(cardSchemaModuleName);
					sandbox.publish('BackHistoryState');
				};
				viewModelConfig.publish = function(eventName, eventArguments, tags) {
					return sandbox.publish(eventName, eventArguments, tags);
				};

				viewModelConfig.addNewColumn = function(columnName, columnconfig, containerId) {
					var columnRenderTo = Ext.get('autoGeneratedLeftContainer');
					LeadEditPageDesignerHelper.addWebFormLeadColumn(schema, columnconfig, false);
					var columnConfig = viewGenerator.generateSchemaItemView(columnconfig, basePanelConfig);
					viewGenerator.updateItemsForEditStructure(columnConfig.items || columnConfig);
					var columnView = Ext.create(columnConfig.className || 'Terrasoft.Container',
						columnConfig);
					columnView.bind(viewModel);
					columnView.render(columnRenderTo);
					viewModel.setCurrentElement(
						{
							itemName: columnName,
							containerId: containerId
						}
					);
				};
				viewModelConfig.OpenColumnPage = function(config, callback) {
					if (!this.columnPagePageParamsById) {
						this.columnPagePageParamsById = [];
					}
					var scope = this;
					var handler = function(args) {
						callback.call(scope, args);
					};
					var ColumnPageId = sandbox.id + '_ColumnPage';
					sandbox.subscribe('GetColumnInfo', function() {
						scope.columnPagePageParamsById[ColumnPageId] = config;
						return scope.columnPagePageParamsById[ColumnPageId];
					}, [ColumnPageId]);

					var params = sandbox.publish('GetHistoryState');
					sandbox.publish('PushHistoryState', {hash: params.hash.historyState});
					sandbox.loadModule('ColumnPage', {
						renderTo: mainViewRenderTo,
						id: ColumnPageId,
						keepAlive: true
					});
					sandbox.subscribe('PushColumnInfo', handler, [ColumnPageId]);
				};
				viewModelConfig.addLeadColumn = function(column) {
					var schemaLeadColumns = this.get('Columns');
					if (!schemaLeadColumns.contains(column.columnPath)) {
						schemaLeadColumns.add(column.columnPath, column);
						LeadEditPageDesignerHelper.addWebFormLeadColumn(cardSchema, column, false);
					}
				};
				viewModelConfig.editLeadColumn = function(column) {
					var schemaLeadColumns = this.get('Columns');
					if (schemaLeadColumns.contains(column.columnPath)) {
						var oldLeadColumn = schemaLeadColumns.get(column.columnPath);
						var index = schemaLeadColumns.indexOf(oldLeadColumn);
						schemaLeadColumns.remove(oldLeadColumn);
						schemaLeadColumns.insert(index, column.columnPath, column);
					} else {
						schemaLeadColumns.add(column.columnPath, column);
					}
					LeadEditPageDesignerHelper.replaceWebFormLeadColumn(cardSchema, column);
				};
				viewModelConfig.getSavingColumnsData = function() {
					var schemaLeadColumns = this.get('Columns');
					Terrasoft.each(schemaLeadColumns.getItems(), function(item) {
						var currentCaption = this.get(item.columnPath);
						item.caption = (!Ext.isEmpty(currentCaption)) ? currentCaption : item.caption;
					}, this);

					return LeadEditPageDesignerHelper.getWebFormLeadColumnsData(schemaLeadColumns);
				};
				viewModelConfig.getElementByName = function(name) {
					var container = LeadEditPageDesignerHelper.getWebFormLeadColumnsContainer(cardSchema.schema);
					for (var i = 0; i < container.length; i++) {
						if (container[i].name === name) {
							return container[i];
						}
					}
				};
				viewModelConfig.sandbox = sandbox;
				Ext.define(viewModelConfig.name, viewModelConfig);
				return viewModelConfig;
			}
			function loadCommandLine() {
				var commandLineContainer = Ext.get('card-command-line-container');
				sandbox.loadModule('CommandLineModule', {
					renderTo: commandLineContainer
				});
			}
			function init() {
				var state = sandbox.publish('GetHistoryState');
				var currentHash = state.hash;
				var currentState = state.state || {};
				if (currentState.moduleId === sandbox.id) {
					return;
				}
				var newState = Terrasoft.deepClone(currentState);
				newState.moduleId = sandbox.id;
				sandbox.publish('ReplaceHistoryState', {
					stateObj: newState,
					pageTitle: null,
					hash: currentHash.historyState,
					silent: true,
					action: currentState.action
				});
			}
			return Ext.define('LeadEditPageDesigner', {
				init: init,
				render: function(renderTo) {
					loadCardView(renderTo, this);
				},
				destroy: function() {
					this.callParent(arguments);
				}
			});
		}
		return createConstructor;
	});
