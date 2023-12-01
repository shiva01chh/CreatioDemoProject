define("LeadContactProfileSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		AddRecordButtonCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C",
		ClearButtonCaption: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u044C \u043A\u043E\u043B\u043E\u043D\u043A\u0443",
		ErrorOnSaveMessage: "\u041F\u0440\u043E\u0438\u0437\u043E\u0448\u043B\u0430 \u043E\u0448\u0438\u0431\u043A\u0430 \u043F\u0440\u0438 \u043F\u043E\u043F\u044B\u0442\u043A\u0435 \u0441\u043E\u0445\u0440\u0430\u043D\u0438\u0442\u044C \u0437\u0430\u043F\u0438\u0441\u044C. \u0417\u0430 \u0434\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0439 \u0438\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0438\u0435\u0439 \u043E\u0431\u0440\u0430\u0442\u0438\u0442\u0435\u0441\u044C \u043A \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u043E\u043C\u0443 \u0430\u0434\u043C\u0438\u043D\u0438\u0441\u0442\u0440\u0430\u0442\u043E\u0440\u0443.",
		SearchButtonCaption: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C",
		SetActionCaption: "\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0441\u0432\u044F\u0437\u044C",
		SimilarButtonCaption: "\u0412\u044B\u0431\u0440\u0430\u0442\u044C \u0438\u0437 {0} \u043F\u043E\u0445\u043E\u0436\u0438\u0445",
		SimilarButtonFoundHintText: "\u041C\u044B \u043D\u0430\u0448\u043B\u0438 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u044B, \u043A \u043A\u043E\u0442\u043E\u0440\u044B\u043C \u043C\u043E\u0436\u043D\u043E \u043E\u0442\u043D\u0435\u0441\u0442\u0438 \u044D\u0442\u043E\u0442 \u043B\u0438\u0434. \u041D\u0430\u0436\u0430\u0432 \u043D\u0430 \u044D\u0442\u0443 \u043A\u043D\u043E\u043F\u043A\u0443, \u0432\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u043D\u0443\u0436\u043D\u044B\u0439 \u043A\u043E\u043D\u0442\u0430\u043A\u0442 \u0432 \u043F\u043E\u044F\u0432\u0438\u0432\u0448\u0435\u043C\u0441\u044F \u0441\u043F\u0438\u0441\u043A\u0435.",
		SimilarButtonNotFoundHintText: "\u041C\u044B \u043D\u0435 \u043D\u0430\u0448\u043B\u0438 \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u044B, \u043A \u043A\u043E\u0442\u043E\u0440\u044B\u043C \u043C\u043E\u0436\u043D\u043E \u043E\u0442\u043D\u0435\u0441\u0442\u0438 \u044D\u0442\u043E\u0442 \u043B\u0438\u0434."
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		BlankSlateIcon: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "BlankSlateIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		},
		ClearButton: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "ClearButton",
				hash: "e469377aa2358c21942fe57d0e1fef21",
				resourceItemExtension: ".png"
			}
		},
		ProfileIcon: {
			source: 3,
			params: {
				schemaName: "LeadContactProfileSchema",
				resourceItemName: "ProfileIcon",
				hash: "ca1ce7681de14eb36954a0e83a2a550c",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});