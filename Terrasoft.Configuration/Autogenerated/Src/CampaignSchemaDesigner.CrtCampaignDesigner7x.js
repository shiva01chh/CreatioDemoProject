define("CampaignSchemaDesigner", ["CampaignSchemaDesignerResources", "CampaignSchemaDesignerViewModel",
		"CampaignSchemaDesignerLeftToolbar", "CampaignSchemaDiagram", "CampaignDiagramComponent",
		"CampaignElementSchemaManager", "CampaignElementSchemaManagerEx"], function(resources) {
	Ext.define("Terrasoft.Designers.CampaignSchemaDesigner", {
		extend: "Terrasoft.ProcessSchemaDesigner",
		alternateClassName: "Terrasoft.CampaignSchemaDesigner",

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesigner#designerViewModelClassName
		 * @overridden
		 */
		designerViewModelClassName: "Terrasoft.CampaignSchemaDesignerViewModel",

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesigner#propertiesEditModule
		 * @overridden
		 */
		propertiesEditModule: "CampaignSchemaElementPropertiesEdit",

		/**
		 * Name of left toolbar class.
		 * @protected
		 * @type {String}
		 */
		leftToolbarClassName: "Terrasoft.CampaignSchemaDesignerLeftToolbar",

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesigner#leftToolbarHeaderButtonCaption
		 * @overridden
		 */
		leftToolbarHeaderButtonCaption: resources.localizableStrings.LeftToolbarCaption,

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
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesigner#schemaDiagramClassName
		 * @override
		 */
		schemaDiagramClassName: "Terrasoft.CampaignSchemaDiagram",

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesigner#getDesignerViewModelConfig
		 * @override
		 */
		getDesignerViewModelConfig: function() {
			var config = this.callParent(arguments);
			config.values.EntitySchemaUId = this.entitySchemaUId;
			config.values.EntityId = this.entityId;
			return config;
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesigner#getSchemaPropertiesButtonConfig
		 * @override
		 */
		getSchemaPropertiesButtonConfig: function() {
			var config = this.callParent(arguments);
			config.hint = resources.localizableStrings.PropertiesButtonHint;
			return config;
		},

		/**
		 * Preload process images that are used for dragging.
		 * @override
		 */
		preloadDragImages: Terrasoft.emptyFn,

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesigner#initDesignerManagers
		 * @override
		 */
		initDesignerManagers: function(callback, scope) {
			this.superclass.superclass.initDesignerManagers(function() {
				Terrasoft.chain(
					function(next) {
						Terrasoft.ProcessFlowElementSchemaManager.initialize(next, this);
					},
					function(next) {
						Terrasoft.CampaignElementSchemaManager.initialize(next, this);
					},
					function() {
						callback.call(scope);
					}
				);
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.ProcessSchemaDesigner#createToolbarLeftContainer
		 * @override
		 */
		createToolbarLeftContainer: function() {
			var lczStrings = resources.localizableStrings;
			var elementCopyMenuItem = Ext.create("Terrasoft.MenuItem", {
				caption: lczStrings.CopyElementMenuItemCaption,
				onItemClick: this.onCopyElementClick.bind(this),
				tag: "CopyElement"
			});
			var elementPasteMenuItem = Ext.create("Terrasoft.MenuItem", {
				caption: lczStrings.PasteElementMenuItemCaption,
				onItemClick: this.onPasteElementClick.bind(this),
				tag: "PasteElement"
			});
			return {
				className: "Terrasoft.Container",
				id: this.id + "-toolbar-left",
				classes: {
					wrapClassName: ["toolbar-left"]
				},
				items: [
					{
						className: "Terrasoft.Button",
						id: this.id + "-save-btn",
						caption: lczStrings.SaveButtonCaption,
						style: Terrasoft.controls.ButtonEnums.style.GREEN,
						click: {bindTo: "save"},
						hint: lczStrings.SaveButtonHint
					},
					{
						className: "Terrasoft.Button",
						id: this.id + "-run-btn",
						caption: lczStrings.RunButtonCaption,
						style: Terrasoft.controls.ButtonEnums.style.BLUE,
						click: {bindTo: "onRunProcessClick"},
						hint: lczStrings.RunButtonHint,
						visible: false
					},
					{
						className: "Terrasoft.Button",
						id: this.id + "-actions-btn",
						caption: lczStrings.ActionsButtonCaption,
						classes: {
							wrapperClass: ["t-btn-actions"]
						},
						menu: {
							items: [
								elementCopyMenuItem,
								elementPasteMenuItem
							]
						}
					}
				]
			};
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesigner#createCaptionContainer
		 * @override
		 */
		createCaptionContainer: function() {
			var captionLabel = Ext.create("Terrasoft.Label", {
				id: this.id + "-caption",
				caption: {
					bindTo: "SchemaCaption"
				},
				markerValue: "SchemaCaption",
				classes: {
					labelClass: ["label-caption"]
				}
			});
			var captionContainer = Ext.create("Terrasoft.Container", {
				id: this.id + "-diagram-caption-ct",
				classes: {
					wrapClassName: ["control-width-15 ts-box-sizing diagram-caption-ct"]
				},
				items: [
					captionLabel
				]
			});
			return captionContainer;
		}
	});
	return Terrasoft.CampaignSchemaDesigner;
});
