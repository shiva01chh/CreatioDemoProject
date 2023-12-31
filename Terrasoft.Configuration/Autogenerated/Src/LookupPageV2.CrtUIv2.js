﻿define("LookupPageV2", ["ext-base", "MaskHelper", "LookupPageViewGenerator", "LookupPageViewModelGenerator"],
	function(Ext) {

		var lookupPage = Ext.define("Terrasoft.configuration.LookupPageV2", {
			extend: "Terrasoft.BaseSchemaModule",
			alternateClassName: "Terrasoft.LookupPageV2",

			Ext: null,
			sandbox: null,
			Terrasoft: null,

			headerView: null,

			lookupInfo: null,

			initSchemaName: function() {
				var lookupInfo = this.lookupInfo = this.sandbox.publish("LookupInfo", null, [this.sandbox.id]);
				this.schemaName = "BaseLookupPageV2";
				this.entitySchemaName = lookupInfo.entitySchemaName;
			},

			initHistoryState: Terrasoft.emptyFn,

			generateSchemaStructure: function(callback, scope) {
				this.sandbox.requireModuleDescriptors([this.entitySchemaName], function() {
				//todo ###### ######## #######, ### ###### ###### ########### ###########
					var config = {
						schemaName: this.schemaName,
						entitySchemaName: this.entitySchemaName,
						profileKey: this.getProfileKey()
					};
					this.schemaBuilder.build(config, function(viewModelClass, viewConfig) {
						callback.call(scope, viewModelClass, viewConfig);
					}, this);
				}, this);
			},

			getProfileKey: function() {
				return this.entitySchemaName + "_GridSettings";
			},

			/**
			 *
			 * @param viewModelClass
			 * @return {viewModelClass}
			 */
			createViewModel: function(viewModelClass) {
				return this.Ext.create(viewModelClass, {
					Ext: this.Ext,
					sandbox: this.sandbox,
					Terrasoft: this.Terrasoft,
					values: {
						LookupInfo: this.lookupInfo
					}
				});
			},
			/** ########### #############
			 * @param {Ext.Element} renderTo ###### ## #########, # ####### ##### ############ #############
			 */
			render: function() {
				var renderTo = Terrasoft.LookupUtilities.getGridContainer();
				var headerRenderTo = Terrasoft.LookupUtilities.getFixedHeaderContainer();

				var containerName = this.schemaName + this.autoGeneratedContainerSuffix;
				var headerContainerName = this.schemaName + this.autoGeneratedContainerSuffix + "header"; //todo
				var viewModel = this.viewModel;
				var view = this.view;
				var headerView = this.headerView;
				if (!view || view.destroyed || !headerView || headerView.destroyed) {
					view = this.view = this.Ext.create("Terrasoft.Container", {
						id: containerName,
						selectors: {wrapEl: "#" +  containerName},
						classes: {wrapClassName: ["schema-wrap", "one-el"]},
						items: Terrasoft.deepClone(this.viewConfig[1]) //todo
					});
					headerView = this.headerView = this.Ext.create("Terrasoft.Container", {
						id: headerContainerName,
						selectors: {wrapEl: "#" +  headerContainerName},
						classes: {wrapClassName: ["schema-wrap", "one-el"]},
						items: Terrasoft.deepClone(this.viewConfig[0]) //todo
					});

					view.bind(viewModel);
					view.render(renderTo);
					headerView.bind(viewModel);
					headerView.render(headerRenderTo);
				} else {
					view.reRender(0, renderTo);
					headerView.reRender(0, headerRenderTo);
				}
				viewModel.headerRenderTo = headerRenderTo.id;
				viewModel.renderTo = renderTo.id;
				viewModel.onRender();
			}
		});
		return lookupPage;
	});


