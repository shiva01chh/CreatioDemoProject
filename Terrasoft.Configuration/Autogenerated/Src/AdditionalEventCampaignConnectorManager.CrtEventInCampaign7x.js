 define("AdditionalEventCampaignConnectorManager", [], function() {
    Ext.define("Terrasoft.AdditionalEventCampaignConnectorManager", {
        override: "Terrasoft.CampaignConnectorManager",    
        initMappingCollection: function() {
            this.callParent(arguments);
			this.connectorTypesMappingCollection.addIfNotExists("CampaignAddToEventSchema",
                "Terrasoft.ProcessEventConditionalTransitionSchema");
			this.connectorTypesMappingCollection.addIfNotExists("CampaignStartEventSchema",
                "Terrasoft.ProcessEventConditionalTransitionSchema");
        },
        fillAdditionalProperties: function(prevElement, newElement) {
			if (newElement.getTypeInfo().typeName === "ProcessEventConditionalTransitionSchema") {
				newElement.hasResponseCondition = this._setValue(prevElement.hasResponseCondition, false);
				newElement.eventResponseCollection = this._setValue(prevElement.eventResponseCollection, null);
			}
        }
    });
});