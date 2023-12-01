  require(["CampaignElementSchemaManager", "CampaignEventSchema"], function() {
    var coreElementClassNames = Terrasoft.CampaignElementSchemaManager.coreElementClassNames;
    coreElementClassNames.push(
		{ itemType: "Terrasoft.CampaignEventSchema" }
	);
});