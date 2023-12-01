define("ItemSectionGridRowViewModel", ["ItemSectionGridRowViewModelResources",
		"BaseSectionGridRowViewModel"],
	function(resources) {
		/**
		 * @class Terrasoft.configuration.QueueGridRowViewModel
		 * ##### ###### ############# ###### #######.
		 */
		Ext.define("Terrasoft.configuration.ItemSectionGridRowViewModel", {
			extend: "Terrasoft.BaseSectionGridRowViewModel",
			alternateClassName: "Terrasoft.ItemSectionGridRowViewModel",

			Ext: null,

			Terrasoft: null,

			sandbox: null,

			columns: {},
			/**
			 * ########## ######### ###### ######## ###.
			 * @returns {String} ######### ######.
			 */
			getOpenServiceModelPageCaption: function() {
				return resources.localizableStrings.OpenServiceModelPageCaption;
			}
		});
	});
