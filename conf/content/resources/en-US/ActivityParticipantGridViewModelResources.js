define("ActivityParticipantGridViewModelResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		UnknownTip: "Unknown",
		DeclinedTip: "Declined",
		InDoubtTip: "In Doubt",
		AcceptedTip: "Accepted"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		InvitationDeclinedIcon: {
			source: 3,
			params: {
				schemaName: "ActivityParticipantGridViewModel",
				resourceItemName: "InvitationDeclinedIcon",
				hash: "9804715f4ea7c6a2c5c9ba72dea394de",
				resourceItemExtension: ".png"
			}
		},
		InDoubtIcon: {
			source: 3,
			params: {
				schemaName: "ActivityParticipantGridViewModel",
				resourceItemName: "InDoubtIcon",
				hash: "f15d780e142355fd33465254b0588dfb",
				resourceItemExtension: ".png"
			}
		},
		InvitationAcceptedIcon: {
			source: 3,
			params: {
				schemaName: "ActivityParticipantGridViewModel",
				resourceItemName: "InvitationAcceptedIcon",
				hash: "07b9d6ca466b6ad5c0252a26681cbd8e",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});