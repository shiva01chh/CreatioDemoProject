define("CampaignElementShapeForm", [], function() {
	Ext.define("Terrasoft.configuration.CampaignElementShapeForm", {
		alternateClassName: "Terrasoft.CampaignElementShapeForm",

		/**
		 * @public
		 */
		convertNodeTypeInShapeForm: function(nodeType) {
			switch (true) {
				case nodeType === Terrasoft.diagram.UserHandlesConstraint.Event:
					return "circle";
				case nodeType === Terrasoft.diagram.UserHandlesConstraint.Gateway:
					return "rhomb";
				default:
					return "default";
			}
		},
	});
	return Ext.create(Terrasoft.CampaignElementShapeForm);
});
