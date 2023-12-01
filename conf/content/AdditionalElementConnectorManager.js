Terrasoft.configuration.Structures["AdditionalElementConnectorManager"] = {innerHierarchyStack: ["AdditionalElementConnectorManager"]};
  define("AdditionalElementConnectorManager", [], function() {
    Ext.define("Terrasoft.AdditionalElementConnectorManager", {
        override: "Terrasoft.CampaignConnectorManager",    
        initMappingCollection: function() {
            this.callParent(arguments);
			this.connectorTypesMappingCollection.addIfNotExists("CampaignEventSchema",
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

