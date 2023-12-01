define("MLColumnSelectionSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddRootSchemaMenuItemCaption: "Object\u0027s columns",
		AddRootSchemaLinkedColumnCaption: "Linked column",
		NoData: "No data available"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		AddColumnMenuIcon: {
			source: 3,
			params: {
				schemaName: "MLColumnSelectionSchema",
				resourceItemName: "AddColumnMenuIcon",
				hash: "db1b0d1a50235c598db887d5529030ae",
				resourceItemExtension: ".svg"
			}
		},
		ClearIcon: {
			source: 3,
			params: {
				schemaName: "MLColumnSelectionSchema",
				resourceItemName: "ClearIcon",
				hash: "018bf133f90a321b1cae38a9d077cbca",
				resourceItemExtension: ".png"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});