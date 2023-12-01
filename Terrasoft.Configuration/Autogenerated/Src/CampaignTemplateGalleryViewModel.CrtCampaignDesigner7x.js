 define("CampaignTemplateGalleryViewModel", ["CampaignTemplateGalleryViewModelResources"],
	function(resources) {
	Ext.define("Terrasoft.configuration.CampaignTemplateGalleryViewModel", {
		extend: "Terrasoft.BaseViewModel",
		alternateClassName: "Terrasoft.CampaignTemplateGalleryViewModel",

		Ext: null,
		Terrasoft: null,
		sandbox: null,

		messages: {
			/**
			 * @message CampaignTemplateSelected
			 * Emit campaign template selected action.
			 */
			"CampaignTemplateSelected": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message CampaignTemplateSelected
			 * Emit campaign template selected action.
			 */
			"CampaignTemplateGalleryCanceled": {
				"mode": this.Terrasoft.MessageMode.PTP,
				"direction": this.Terrasoft.MessageDirectionType.PUBLISH
			}
		},

		/**
		 * @inheritDoc Terrasoft.BaseViewModel#constructor
		 * @protected
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			this.sandbox.registerMessages(this.messages);
		},

		onTemplateSelected: function(templateId) {
			this.sandbox.publish("CampaignTemplateSelected", templateId, [this.sandbox.id]);
		},

		onGalleryViewCanceled: function() {
			this.sandbox.publish("CampaignTemplateGalleryCanceled", null, [this.sandbox.id]);
		}

	});

	return Terrasoft.CampaignTemplateGalleryViewModel;

});
