define("SectionMenuModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		HomePageTitle: "Home"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		DefaultIcon: {
			source: 3,
			params: {
				schemaName: "SectionMenuModule",
				resourceItemName: "DefaultIcon",
				hash: "edb5ee51127129103dc043fd72510000",
				resourceItemExtension: ".png"
			}
		},
		DefaultIconSvg: {
			source: 3,
			params: {
				schemaName: "SectionMenuModule",
				resourceItemName: "DefaultIconSvg",
				hash: "4c421e204b17018308c36c5d9105b121",
				resourceItemExtension: ".svg"
			}
		},
		HomePageSidebarImage: {
			source: 3,
			params: {
				schemaName: "SectionMenuModule",
				resourceItemName: "HomePageSidebarImage",
				hash: "e41ea0f3a405d0b9840b1e232d7a24f8",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});