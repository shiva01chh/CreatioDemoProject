  require(["CampaignElementSchemaManager", 
			"ProcessEmailConditionalTransitionSchema",
			"MarketingEmailSchema",
		 ], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.ProcessEmailConditionalTransitionSchema" },
		{ itemType: "Terrasoft.MarketingEmailSchema" }
	);
});