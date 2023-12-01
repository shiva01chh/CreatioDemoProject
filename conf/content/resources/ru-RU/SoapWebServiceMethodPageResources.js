﻿define("SoapWebServiceMethodPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		UriTip: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435 \u0443\u0437\u043B\u0430 XML, \u043A\u043E\u0442\u043E\u0440\u044B\u0439 \u044F\u0432\u043B\u044F\u0435\u0442\u0441\u044F \u043A\u043E\u0440\u043D\u0435\u0432\u044B\u043C \u0432\u043D\u0443\u0442\u0440\u0438 \u0026#x3C;soap:Body\u0026#x3E;. \u0427\u0430\u0441\u0442\u043E \u0441\u043E\u0432\u043F\u0430\u0434\u0430\u0435\u0442 \u0441 \u043D\u0430\u0437\u0432\u0430\u043D\u0438\u0435\u043C \u043E\u043F\u0435\u0440\u0430\u0446\u0438\u0438 \u0432 WSDL. \u041D\u0430\u043F\u0440\u0438\u043C\u0435\u0440, \u044D\u0442\u043E \u0431\u0443\u0434\u0435\u0442 \u0022MessageElementName\u0022 \u0432 \u0441\u043B\u0435\u0434\u0443\u044E\u0449\u0435\u043C \u0442\u0435\u043B\u0435 \u0437\u0430\u043F\u0440\u043E\u0441\u0430:\n\u0026#x3C;soap:Body\u0026#x3E;\n    \u0026#x3C;MessageElementName\u0026#x3E;\n        \u0026#x3C;Parameters\u0026#x3E;\n            ...\n        \u0026#x3C;/Parameters\u0026#x3E;\n    \u0026#x3C;/MessageElementName\u0026#x3E;\n\u0026#x3C;/soap:Body\u0026#x3E;",
		AccessDeny: "\u041F\u0430\u043A\u0435\u0442, \u0432 \u043A\u043E\u0442\u043E\u0440\u043E\u043C \u043D\u0430\u0445\u043E\u0434\u0438\u0442\u0441\u044F \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441, \u043D\u0435\u0434\u043E\u0441\u0442\u0443\u043F\u0435\u043D \u0434\u043B\u044F \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u044F \u0438\u043B\u0438 \u0443 \u0432\u0430\u0441 \u043D\u0435\u0442 \u043F\u0440\u0430\u0432 \u043D\u0430 \u0440\u0435\u0434\u0430\u043A\u0442\u0438\u0440\u043E\u0432\u0430\u043D\u0438\u0435 \u044D\u0442\u043E\u0433\u043E \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441\u0430. \u0418\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0441\u0438\u0441\u0442\u0435\u043C\u043D\u0443\u044E \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0443 \u0022\u0422\u0435\u043A\u0443\u0449\u0438\u0439 \u043F\u0430\u043A\u0435\u0442\u0022 \u0438\u043B\u0438 \u043F\u043E\u043B\u0443\u0447\u0438\u0442\u0435 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u044B\u0435 \u043F\u0440\u0430\u0432\u0430 \u0434\u043E\u0441\u0442\u0443\u043F\u0430.",
		AddressHint: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0432 \u0430\u0434\u0440\u0435\u0441\u0435 \u043C\u0435\u0442\u043E\u0434\u0430 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u0432\u043D\u0443\u0442\u0440\u0438 \u0444\u0438\u0433\u0443\u0440\u043D\u044B\u0445 \u0441\u043A\u043E\u0431\u043E\u043A {}. \u041F\u043E\u043B\u043D\u044B\u0439 \u0430\u0434\u0440\u0435\u0441 \u0432\u044B\u0437\u043E\u0432\u0430 \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441\u0430 \u0444\u043E\u0440\u043C\u0438\u0440\u0443\u0435\u0442\u0441\u044F \u043A\u0430\u043A \u0022URI \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441\u0430\u0022 \u002B \u0022\u0410\u0434\u0440\u0435\u0441 \u043C\u0435\u0442\u043E\u0434\u0430\u0022 \u002B \u0022?\u0022\u002B \u0022\u041D\u0430\u0431\u043E\u0440 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432 \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u0447\u0435\u0440\u0435\u0437 \u0440\u0430\u0437\u0434\u0435\u043B\u0438\u0442\u0435\u043B\u044C \u0026\u0022",
		CancelButtonCaption: "\u041E\u0442\u043C\u0435\u043D\u0430",
		CodeCaption: "\u041A\u043E\u0434 (\u043D\u0430 \u0430\u043D\u0433\u043B\u0438\u0439\u0441\u043A\u043E\u043C)",
		CodeHint: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0435\u0442\u0441\u044F \u0440\u0430\u0437\u0440\u0430\u0431\u043E\u0442\u0447\u0438\u043A\u0430\u043C\u0438 \u0434\u043B\u044F \u0432\u0437\u0430\u0438\u043C\u043E\u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044F \u0441 \u0432\u0435\u0431-\u0441\u0435\u0440\u0432\u0438\u0441\u043E\u043C \u0432 \u043F\u0440\u043E\u0433\u0440\u0430\u043C\u043C\u043D\u043E\u043C \u043A\u043E\u0434\u0435 Creatio",
		ContentTypeCaption: "\u0422\u0438\u043F \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u043C\u043E\u0433\u043E",
		DefaultParameterValue: "\u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435",
		DuplicateNameMessage: "\u041C\u0435\u0442\u043E\u0434 \u0441 \u0442\u0430\u043A\u0438\u043C \u043A\u043E\u0434\u043E\u043C \u0443\u0436\u0435 \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u0443\u0435\u0442.",
		FullUriCaption: "\u041F\u043E\u043B\u043D\u044B\u0439 \u0430\u0434\u0440\u0435\u0441",
		HttpMethodTypeCaption: "\u0422\u0438\u043F \u0437\u0430\u043F\u0440\u043E\u0441\u0430",
		MethodCaptionPrefix: "\u041C\u0435\u0442\u043E\u0434",
		MethodNameCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		OkButtonCaption: "",
		QuickSetupButtonCaption: "\u0411\u044B\u0441\u0442\u0440\u0430\u044F \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0430",
		QuickSetupCurlButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u0440 \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 cURL",
		QuickSetupEmptyUriMessage: "\u0412 \u043F\u043E\u043B\u0435 \u0022\u0410\u0434\u0440\u0435\u0441 \u043C\u0435\u0442\u043E\u0434\u0430\u0022 \u043D\u0435 \u043D\u0430\u0439\u0434\u0435\u043D\u043E \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432. \u0414\u043B\u044F \u043F\u0440\u0430\u0432\u0438\u043B\u044C\u043D\u043E\u0439 \u043D\u0430\u0441\u0442\u0440\u043E\u0439\u043A\u0438 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0430\u0434\u0440\u0435\u0441\u0430 \u043C\u0435\u0442\u043E\u0434\u0430 \u043D\u0435\u043E\u0431\u0445\u043E\u0434\u0438\u043C\u043E \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u0432\u043D\u0443\u0442\u0440\u0438 \u0444\u0438\u0433\u0443\u0440\u043D\u044B\u0445 \u0441\u043A\u043E\u0431\u043E\u043A {}, \u0438\u043B\u0438 \u0443\u043A\u0430\u0437\u044B\u0432\u0430\u0442\u044C \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u043F\u043E\u0441\u043B\u0435 \u0441\u0438\u043C\u0432\u043E\u043B\u0430 \u0022?\u0022.",
		QuickSetupJsonRequestButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u0440 \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 JSON",
		QuickSetupJsonResponseButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u0440 \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 JSON",
		QuickSetupRawRequestButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u0440 \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 RAW",
		QuickSetupRawResponseButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u0440 \u0432 \u0444\u043E\u0440\u043C\u0430\u0442\u0435 RAW",
		QuickSetupUriButtonCaption: "\u041F\u043E \u043F\u043E\u043B\u044E \u0022\u0410\u0434\u0440\u0435\u0441 \u043C\u0435\u0442\u043E\u0434\u0430\u0022",
		RequestExampleSeparatorCaption: "\u041F\u043E \u043F\u0440\u0438\u043C\u0435\u0440\u0443 \u0432\u044B\u0437\u043E\u0432\u0430",
		RequestTabCaption: "\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0432\u044B\u0437\u043E\u0432\u0430",
		RequestTimeoutCaption: "\u0422\u0430\u0439\u043C-\u0430\u0443\u0442 \u043E\u0442\u0432\u0435\u0442\u0430, \u043C\u0441",
		ResponseExampleSeparatorCaption: "\u041F\u043E \u043F\u0440\u0438\u043C\u0435\u0440\u0443 \u043E\u0442\u0432\u0435\u0442\u0430",
		ResponseTabCaption: "\u041E\u0431\u0440\u0430\u0431\u043E\u0442\u043A\u0430 \u043E\u0442\u0432\u0435\u0442\u0430",
		SaveButtonCaption: "O\u043A",
		UriCaption: "\u041A\u043E\u0434 \u044D\u043B\u0435\u043C\u0435\u043D\u0442\u0430 \u0441\u043E\u043E\u0431\u0449\u0435\u043D\u0438\u044F",
		UseAuthInfoCaption: "\u0418\u0441\u043F\u043E\u043B\u044C\u0437\u043E\u0432\u0430\u0442\u044C \u0430\u0443\u0442\u0435\u043D\u0442\u0438\u0444\u0438\u043A\u0430\u0446\u0438\u044E",
		WrongNameMessage: "\u0412\u0432\u0435\u0434\u0435\u043D\u043E \u043D\u0435\u043A\u043E\u0440\u0440\u0435\u043A\u0442\u043D\u043E\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435. \u0418\u0441\u043F\u043E\u043B\u044C\u0437\u0443\u0439\u0442\u0435 \u0441\u0438\u043C\u0432\u043E\u043B\u044B: a-z, A-Z, 0-9. \u003C/br\u003E \u0421\u0438\u043C\u0432\u043E\u043B: 0-9 \u043D\u0435 \u043C\u043E\u0436\u0435\u0442 \u0431\u044B\u0442\u044C \u043F\u0435\u0440\u0432\u044B\u043C.",
		WrongPrefixMessage: "\u041A\u043E\u0434 \u0434\u043E\u043B\u0436\u0435\u043D \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u044C \u043F\u0440\u0435\u0444\u0438\u043A\u0441 \u0022{0}\u0022",
		WrongRequestTypeMessage: "\u0427\u0442\u043E\u0431\u044B \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u0438\u0442\u044C \u0442\u0438\u043F \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u0022GET\u0022, \u0432 \u0432\u044B\u0437\u043E\u0432\u0435 \u043D\u0435 \u0434\u043E\u043B\u0436\u043D\u043E \u0431\u044B\u0442\u044C \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u043E\u0432 \u0441 \u0442\u0438\u043F\u043E\u043C \u0022\u041F\u0430\u0440\u0430\u043C\u0435\u0442\u0440 \u0442\u0435\u043B\u0430 \u0437\u0430\u043F\u0440\u043E\u0441\u0430\u0022. \u0423\u0434\u0430\u043B\u0438\u0442\u0435 \u044D\u0442\u0438 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0438\u043B\u0438 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0438\u0445 \u0442\u0438\u043F \u0438 \u043F\u043E\u0432\u0442\u043E\u0440\u0438\u0442\u0435 \u043F\u043E\u043F\u044B\u0442\u043A\u0443.",
		WrongUriMessage: "\u0412 \u043F\u043E\u043B\u0435 \u0022\u0410\u0434\u0440\u0435\u0441 \u043C\u0435\u0442\u043E\u0434\u0430\u0022 \u043D\u0430\u0439\u0434\u0435\u043D \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440, \u043A\u043E\u0442\u043E\u0440\u044B\u0439 \u043D\u0435 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D \u0432 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0432\u044B\u0437\u043E\u0432\u0430: {0}. \u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0435\u0433\u043E \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438?",
		WrongUrisBracketsMessage: "\u041D\u0435 \u0445\u0432\u0430\u0442\u0430\u0435\u0442 \u043E\u0442\u043A\u0440\u044B\u0442\u043E\u0439 \u0022{\u0022 \u0438\u043B\u0438 \u0437\u0430\u043A\u0440\u044B\u0442\u043E\u0439 \u0022}\u0022 \u0444\u0438\u0433\u0443\u0440\u043D\u043E\u0439 \u0441\u043A\u043E\u0431\u043A\u0438 \u0438\u043B\u0438 \u0435\u0441\u0442\u044C \u0432\u043B\u043E\u0436\u0435\u043D\u043D\u044B\u0435 \u0441\u043A\u043E\u0431\u043A\u0438, \u043D\u0430\u043F\u0440\u0438\u043C\u0435\u0440, \u0022{{parameter}}\u0022.",
		WrongUrisEmptyBracketsMessage: "\u0412 \u0441\u0442\u0440\u043E\u043A\u0435 \u0441\u043E\u0434\u0435\u0440\u0436\u0430\u0442\u0441\u044F \u0444\u0438\u0433\u0443\u0440\u043D\u044B\u0435 \u0441\u043A\u043E\u0431\u043A\u0438 \u0022{}\u0022 \u0431\u0435\u0437 \u0442\u0435\u043A\u0441\u0442\u0430 \u0432\u043D\u0443\u0442\u0440\u0438. \u041D\u0430\u043F\u0438\u0448\u0438\u0442\u0435 \u043C\u0435\u0436\u0434\u0443 \u043D\u0438\u043C\u0438 \u043A\u043E\u0434 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u0430 \u0430\u0434\u0440\u0435\u0441\u0430 \u0437\u0430\u043F\u0440\u043E\u0441\u0430 \u0438\u043B\u0438 \u0443\u0434\u0430\u043B\u0438\u0442\u0435 \u0441\u0438\u043C\u0432\u043E\u043B\u044B \u0022{}\u0022.",
		WrongUrisMessage: "\u0412 \u043F\u043E\u043B\u0435 \u0022\u0410\u0434\u0440\u0435\u0441 \u043C\u0435\u0442\u043E\u0434\u0430\u0022 \u043D\u0430\u0439\u0434\u0435\u043D\u044B \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u0434\u043E\u0431\u0430\u0432\u043B\u0435\u043D\u044B \u0432 \u043F\u0430\u0440\u0430\u043C\u0435\u0442\u0440\u044B \u0432\u044B\u0437\u043E\u0432\u0430: {0}.\n\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0438\u0445 \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438?"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "SoapWebServiceMethodPage",
				resourceItemName: "CloseIcon",
				hash: "563de164682be35ef981066b7287177c",
				resourceItemExtension: ".svg"
			}
		},
		WizardIcon: {
			source: 3,
			params: {
				schemaName: "SoapWebServiceMethodPage",
				resourceItemName: "WizardIcon",
				hash: "b60a2ec813def6ff992e7c7633d56887",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});