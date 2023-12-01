define("UserMktgActivitiesListModuleResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ListHeaderCaption: "\u041C\u043E\u0438 \u043C\u0430\u0440\u043A\u0435\u0442\u0438\u043D\u0433\u043E\u0432\u044B\u0435 \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0438",
		CreateButtonCaption: "\u0421\u043E\u0437\u0434\u0430\u0442\u044C",
		EmptyInfoTitle: "\u0423 \u0412\u0430\u0441 \u043D\u0435\u0442 \u043C\u0430\u0440\u043A\u0435\u0442\u0438\u043D\u0433\u043E\u0432\u044B\u0445 \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u0435\u0439",
		EmptyInfoRecommendation: "\u0421\u043E\u0437\u0434\u0430\u0439\u0442\u0435 {0}\u043D\u043E\u0432\u0443\u044E \u0430\u043A\u0442\u0438\u0432\u043D\u043E\u0441\u0442\u044C{1}."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		EmptyInfoImage: {
			source: 3,
			params: {
				schemaName: "UserMktgActivitiesListModule",
				resourceItemName: "EmptyInfoImage"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});