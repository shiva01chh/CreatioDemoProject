 define("AdditionalLandingCampaignConnectorManager", [], function() {
    Ext.define("Terrasoft.AdditionalLandingCampaignConnectorManager", {
        override: "Terrasoft.CampaignConnectorManager",    
        initMappingCollection: function() {
            this.callParent(arguments);
            this.connectorTypesMappingCollection.addIfNotExists("CampaignLandingSchema",
                "Terrasoft.ProcessLandingConditionalTransitionSchema");
        },
        fillAdditionalProperties: function(prevElement, newElement) {
			if (newElement.getTypeInfo().typeName === "ProcessLandingConditionalTransitionSchema") {
				newElement.stepCompletedCondition = this._setValue(prevElement.stepCompletedCondition, 0);
			}
        }
    });
});