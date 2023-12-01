﻿define("SchemaDesigner", ["ext-base", "terrasoft", "ej-diagram", "process-schema-diagram", "SchemaDesignerResources",
		"BaseViewModule"],
	function(Ext, Terrasoft) {
		/**
		 * @class Terrasoft.configuration.SchemaDesigner
		 * Class of schemes designer.
		 */
		Ext.define("Terrasoft.configuration.SchemaDesigner", {
			extend: "Terrasoft.BaseViewModule",
			alternateClassName: "Terrasoft.SchemaDesigner",

			/**
			 * Schema designer instance. Type of designer calculated by hash.
			 * @private
			 * @type {Terrasoft.BaseSchemaDesigner}
			 */
			designer: null,

			/**
			 * Manager of schemes.
			 * @private
			 * @type {Object}
			 */
			schemaManager: null,

			/**
			 * @inheritdoc Terrasoft.BaseViewModule#diff
			 * @overridden
			 */
			diff: null,

			/**
			 * @inheritdoc Terrasoft.BaseViewModule#onHistoryStateChanged
			 * Hides base implementation, becouse designer does not support loading schemes by historyState
			 * @overridden
			 */
			onHistoryStateChanged: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseViewModule#loadMainPanelsModules
			 * Hides base implementation, becouse designer does not load nested modules.
			 * @overridden
			 */
			loadMainPanelsModules: function() {
				var currentState = this.sandbox.publish("GetHistoryState");
				var hash = currentState.hash.historyState;
				this.initDesigner({
					hash: hash
				});
				if (!this.designer) {
					return;
				}
				this.designer.render({
					renderTo: this.renderTo,
					sandbox: this.sandbox
				});
			},

			/**
			 * Parse received hash string and return config.
			 * @param {String} hash Hash
			 * @private
			 * @return {Object}
			 * @return {String} return.designerName Designer type name.
			 * @return {String} return.id Schema UId.
			 * @return {String} return.packageId Package UId.
			 */
			parseHash: function(hash) {
				var params = hash.split("/");
				var designer = params[0];
				var schemaId = params[1];
				var packageId = params[2];
				return {
					designerName: designer || "",
					id: (schemaId === "add") ? "" : schemaId,
					packageId: packageId
				};
			},

			/**
			 * @private
			 */
			getDesignerClassName: function(designerName, oldClassName, newClassName) {
				if (Terrasoft.endsWith(designerName, "Old")) {
					return oldClassName;
				}
				if (Terrasoft.endsWith(designerName, "New")) {
					return newClassName;
				}
				return Terrasoft.Features.getIsEnabled("UseProcessDiagramComponent")
					? newClassName
					: oldClassName;
			},

			/**
			 * Initialize schema designer (see {@link #designer}) by hash.
			 * @private
			 * @param {Object} config Configuration object.
			 * @param {String} config.hash Hash.
			 */
			initDesigner: function(config) {
				let designer;
				const params = this.parseHash(config.hash);
				const designerName = params.designerName;
				switch (designerName) {
					case "process":
					case "processOld":
					case "processNew":
						const processSchemaDesigner = this.getDesignerClassName(designerName,
							"Terrasoft.ProcessSchemaDesigner", "Terrasoft.ProcessSchemaDesignerNew");
						designer = Ext.create(processSchemaDesigner, {
							sandbox: this.sandbox,
							schemaUId: params.id,
							packageUId: params.packageId
						});
						break;
					case "entityProcess":
					case "entityProcessOld":
					case "entityProcessNew":
						const embeddedProcessSchemaDesigner = this.getDesignerClassName(designerName,
							"Terrasoft.EmbeddedProcessSchemaDesigner", "Terrasoft.EmbeddedProcessSchemaDesignerNew");
						designer = Ext.create(embeddedProcessSchemaDesigner, {
							sandbox: this.sandbox,
							schemaUId: params.id,
							packageUId: params.packageId
						});
						break;
					case "processLog":
					case "processLogOld":
					case "processLogNew":
						const processSchemaDesignerLog = this.getDesignerClassName(designerName,
							"Terrasoft.ProcessSchemaDesignerLog", "Terrasoft.ProcessSchemaDesignerLogNew");
						designer = Ext.create(processSchemaDesignerLog, {
							sandbox: this.sandbox,
							sysProcessLogId: params.id
						});
						break;
					case "packageDependenciesDiagram":
					case "packageDependenciesDiagramOld":
					case "packageDependenciesDiagramNew":
						const packageDependenciesDiagram = this.getDesignerClassName(designerName,
							"Terrasoft.PackageDependenciesDiagram", "Terrasoft.PackageDependenciesDiagramNew");
						designer = Ext.create(packageDependenciesDiagram, {
							sandbox: this.sandbox
						});
						break;
					case "dcmLog":
						designer = new Terrasoft.DcmSchemaDesignerLogNew({
							sandbox: this.sandbox,
							sysProcessLogId: params.id
						});
						break;
				}
				this.designer = designer;
			},

			/**
			 * Render designer.
			 * @param {Ext.Element} renderTo Container to render designer.
			 */
			render: function(renderTo) {
				this.renderTo = renderTo;
				this.loadNonVisibleModules();
			},

			/**
			 * @overridden
			 * @inheritdoc Terrasoft.BaseObject#onDestroy
			 */
			onDestroy: function() {
				var designer = this.designer;
				if (designer) {
					designer.destroy();
				}
				this.callParent(arguments);
			}

		});

		return Terrasoft.SchemaDesigner;
	});
