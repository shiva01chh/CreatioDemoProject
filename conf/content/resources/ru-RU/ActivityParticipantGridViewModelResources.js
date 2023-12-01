﻿define("ActivityParticipantGridViewModelResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		UnknownTip: "\u041D\u0435 \u0438\u0437\u0432\u0435\u0441\u0442\u043D\u043E",
		DeclinedTip: "\u041F\u0440\u0438\u0433\u043B\u0430\u0448\u0435\u043D\u0438\u0435 \u043E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u043E",
		InDoubtTip: "\u0412\u043E\u0437\u043C\u043E\u0436\u043D\u043E",
		AcceptedTip: " \u041F\u0440\u0438\u0433\u043B\u0430\u0448\u0435\u043D\u0438\u0435 \u043F\u0440\u0438\u043D\u044F\u0442\u043E"
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