 define("DynamicContentHtmlBlockViewModel", ["DynamicContentHtmlBlockViewModelResources",
		"DynamicContentMjBlockViewModel"], function(resources) {

		/**
		 * @class Terrasoft.controls.DynamicContentHtmlBlockViewModel
		 */
		Ext.define("Terrasoft.DynamicContentHtmlBlockViewModel", {
			extend: "Terrasoft.DynamicContentMjBlockViewModel",

			/**
			 * @inheritdoc Terrasoft.BaseContentBlockViewModel#className
			 * @override
			 */
			className: "Terrasoft.DynamicContentHtmlBlock",

			/**
			 * @inheritdoc BaseContentSerializableViewModelMixin#childItemTypes
			 */
			childItemTypes: {
				mjraw: "Terrasoft.ContentSmartHtmlElementViewModel"
			},

			/**
			 * @inheritdoc BaseContentSerializableViewModelMixin#serializableSlicePropertiesCollection
			 * @override
			 */
			serializableSlicePropertiesCollection: ["ItemType", "Styles", "Index", "IsDefault", "Priority",
				"Caption", "Attributes"],

			/**
			 * @inheritdoc Terrasoft.BaseContentBlockViewModel#initResourcesValues
			 * @override
			 */
			initResourcesValues: function(resourcesObj) {
				Ext.apply(resourcesObj.localizableImages, resources.localizableImages);
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseContentBlockViewModel#getToolsConfig
			 * @override
			 */
			getToolsConfig: function() {
				return [];
			},

			/**
			 * @inheritdoc Terrasoft.BaseContentBlockViewModel#getViewConfig
			 * @override
			 */
			getViewConfig: function() {
				var config = this.callParent(arguments);
				Ext.apply(config, {
					"elementSelectedChange": "$onElementSelected"
				});
				return config;
			}
		});

		return Terrasoft.DynamicContentHtmlBlockViewModel;
	}
);
