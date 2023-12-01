﻿define("ContactCommunicationDetailResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Caption: "Communication options",
		DoNotUseEmail: "Do not use email",
		DoNotUseCall: "Do not use phone",
		DoNotUseSms: "Do not use SMS",
		DoNotUseFax: "Do not use fax",
		DoNotUseMail: "Do not use mail",
		DoNotUseEmailCaption: "Email",
		DoNotUseCallCaption: "Phone",
		DoNotUseSmsCaption: "SMS",
		DoNotUseFaxCaption: "Fax",
		DoNotUseMailCaption: "Mail",
		DoNotUseCommunicationCaption: "Do not use",
		NonTopicalAddressCaptionMenu: "Invalid",
		TopicalAddressCaptionMenu: "Valid",
		ErrorRemoveMandrillBounce: "Could not remove contact\u0027s email from Mandrill blacklist",
		NonActualCaption: "(invalid)"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DeleteIcon: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "DeleteIcon",
				hash: "2e4fa1864bb9b72bbd9f737c1bc74a10",
				resourceItemExtension: ".png"
			}
		},
		LookUpIcon: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "LookUpIcon",
				hash: "57863da6f1677afa7b6645da0602e9e8",
				resourceItemExtension: ".png"
			}
		},
		CheckboxIcon: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "CheckboxIcon",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		},
		CallIcon: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "CallIcon",
				hash: "4ec95834ae39df226c6c6cbe578cadd0",
				resourceItemExtension: ".png"
			}
		},
		AddButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "AddButtonImage",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ToolsButtonImage: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "ToolsButtonImage",
				hash: "48d545549ca4ddb13d7a7bb58f60ed5e",
				resourceItemExtension: ".svg"
			}
		},
		FacebookLinkImage: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "FacebookLinkImage",
				hash: "bb4854d6e2bd0365da65973850f2672b",
				resourceItemExtension: ".png"
			}
		},
		TwitterLinkImage: {
			source: 3,
			params: {
				schemaName: "ContactCommunicationDetail",
				resourceItemName: "TwitterLinkImage",
				hash: "3f434f54d75c08a2406dff80adbbde30",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});