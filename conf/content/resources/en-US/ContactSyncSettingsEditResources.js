define("ContactSyncSettingsEditResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultIcon: {
			source: 3,
			params: {
				schemaName: "ContactSyncSettingsEdit",
				resourceItemName: "DefaultIcon",
				hash: "6d7c8e1aa1605996771b79307f848376",
				resourceItemExtension: ".png"
			}
		},
		CloseModal: {
			source: 3,
			params: {
				schemaName: "ContactSyncSettingsEdit",
				resourceItemName: "CloseModal",
				hash: "42b5b815fe5ef39879666f4595bd892b",
				resourceItemExtension: ".png"
			}
		},
		ErrorIcon: {
			source: 3,
			params: {
				schemaName: "ContactSyncSettingsEdit",
				resourceItemName: "ErrorIcon",
				hash: "04a5c38f6c374acc1d1620a916062fbe",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});