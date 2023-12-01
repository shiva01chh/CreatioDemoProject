 require(["CampaignElementSchemaManager", 
		  	"ProcessLandingConditionalTransitionSchema", 
			"CampaignLandingSchema",
		  	"CampaignStartLandingSchema", 
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessLandingConditionalTransitionSchema" },
		{ itemType: "Terrasoft.CampaignStartLandingSchema" },
		{ itemType: "Terrasoft.CampaignLandingSchema" }
	);
});