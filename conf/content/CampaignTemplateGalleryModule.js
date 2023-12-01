Terrasoft.configuration.Structures["CampaignTemplateGalleryModule"] = {innerHierarchyStack: ["CampaignTemplateGalleryModule"]};
define("CampaignTemplateGalleryModule", ["CampaignTemplateGalleryModuleResources", "CampaignDesignerComponent",
		"css!CampaignTemplateGalleryModule", "CampaignTemplateGallery", "CampaignTemplateGalleryViewModel",
		"BaseModule", "CampaignGallery"], function(resources) {
	Ext.define("Terrasoft.configuration.CampaignTemplateGalleryModule", {
		extend: "Terrasoft.configuration.BaseModule",
		alternateClassName: "Terrasoft.CampaignTemplateGalleryModule",

		Ext: null,
		sandbox: null,
		Terrasoft: null,

		view: null,
		model: null,

		/**
		 * @private
		 */
		_renderGallery: function(renderTo) {
			this.view = this.createGalleryView();
			this.view.bind(this.model);
			this.view.setResources(resources);
			this.view.render(renderTo);
			this.view.setResources(resources);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#init
		 * @override
		 */
		init: function() {
			this.sandbox.registerMessages(this.messages);
			this.model = this.createGalleryViewModel();
			this.callParent(arguments);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#render
		 * @override
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			if (!renderTo.dom) {
				renderTo = Ext.get(renderTo.id);
			}
			this._renderGallery(renderTo);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#destroy
		 * @override
		 */
		destroy: function() {
			if (this.view) {
				this.view.destroy();
			}
			if (this.model) {
				this.model.destroy();
			}
			this.callParent(arguments);
		},

		createGalleryView: function() {
			return Ext.create("Terrasoft.CampaignTemplateGallery", {
				templateSelected: {"bindTo": "onTemplateSelected"},
				galleryViewCanceled: { "bindTo": "onGalleryViewCanceled" }
			});
		},

		createGalleryViewModel: function() {
			return Ext.create("Terrasoft.CampaignTemplateGalleryViewModel", {
				sandbox: this.sandbox,
				Ext: this.Ext,
				Terrasoft: this.Terrasoft
			});
		}

	});
	return Terrasoft.CampaignTemplateGalleryModule;
});


