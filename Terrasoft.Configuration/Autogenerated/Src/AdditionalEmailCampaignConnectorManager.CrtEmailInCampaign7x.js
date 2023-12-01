  define("AdditionalEmailCampaignConnectorManager", [], function() {
    Ext.define("Terrasoft.AdditionalEmailCampaignConnectorManager", {
        override: "Terrasoft.CampaignConnectorManager",    
        initMappingCollection: function() {
            this.callParent(arguments);
            this.connectorTypesMappingCollection.addIfNotExists("MarketingEmailSchema",
                "Terrasoft.ProcessEmailConditionalTransitionSchema");
        },
        additionalBeforeChange: function(prevTransition, sourceItem, targetItem) {
            var connectorTypeName = connectorType.split(".")[1];
			if (transition.getTypeInfo().typeName === connectorTypeName &&
					sourceItem.getTypeInfo().typeName === "MarketingEmailSchema") {
				transition.hyperlinkId = null;
			}
        },
        fillAdditionalProperties: function(prevElement, newElement) {
            if (newElement.getTypeInfo().typeName === "ProcessEmailConditionalTransitionSchema") {
				newElement.emailResponseId = this._setValue(prevElement.emailResponseId, null);
				newElement.isResponseBasedStart = this._setValue(prevElement.isResponseBasedStart, false);
				newElement.hyperlinkId = this._setValue(prevElement.hyperlinkId, null);
			}
        }
    });
});