 require(["CampaignElementSchemaManager", 
			"ProcessEventConditionalTransitionSchema",
		  	"CampaignStartEventSchema", "CampaignAddToEventSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessEventConditionalTransitionSchema" },
		{ itemType: "Terrasoft.CampaignStartEventSchema" },
		{ itemType: "Terrasoft.CampaignAddToEventSchema" }
	);
});