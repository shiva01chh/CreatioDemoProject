﻿define("PreviewDynamicContentBuilderResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		SegmentLabelCaption: "\u0412\u044B\u0431\u043E\u0440 \u0441\u0435\u0433\u043C\u0435\u043D\u0442\u043E\u0432 \u0434\u043B\u044F \u043F\u0440\u0435\u0434\u0432\u0430\u0440\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0433\u043E \u043F\u0440\u043E\u0441\u043C\u043E\u0442\u0440\u0430",
		ApplyButtonCaption: "\u041F\u0440\u0438\u043C\u0435\u043D\u0438\u0442\u044C",
		DefaultBlockCaption: "Default",
		DefaultBlockInfoButtonTip: "\u042D\u0442\u043E\u0442 \u0431\u043B\u043E\u043A \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430 \u0431\u0443\u0434\u0435\u0442 \u0438\u0433\u043D\u043E\u0440\u0438\u0440\u043E\u0432\u0430\u0442\u044C\u0441\u044F \u0434\u043B\u044F \u043A\u043E\u043D\u0442\u0430\u043A\u0442\u043E\u0432, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0442 \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438",
		BlockGroupCaptionTemplate: "\u0414\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u0438\u0439 \u0431\u043B\u043E\u043A {0}",
		EmptyReplicaWarning: "\u041D\u0438 \u0432 \u043E\u0434\u043D\u043E\u0439 \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0439 \u0433\u0440\u0443\u043F\u043F\u0435 \u043D\u0435 \u043D\u0430\u0441\u0442\u0440\u043E\u0435\u043D default \u0431\u043B\u043E\u043A.\u003Cbr\u003E\u041F\u043E\u043B\u0443\u0447\u0430\u0442\u0435\u043B\u044F\u043C, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0442 \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C \u043F\u0440\u0430\u0432\u0438\u043B \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430, \u0431\u0443\u0434\u0435\u0442 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D \u043E\u0442\u043A\u043B\u0438\u043A \u0022\u041D\u0435 \u043E\u0442\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u043E (\u0448\u0430\u0431\u043B\u043E\u043D \u043E\u0442\u0441\u0443\u0442\u0441\u0442\u0432\u0443\u0435\u0442)\u0022.\u003Cbr\u003E\u003Cbr\u003E\u0414\u0430\u043D\u043D\u0430\u044F \u0432\u0430\u043B\u0438\u0434\u0430\u0446\u0438\u044F \u0441\u043E\u0437\u0434\u0430\u043D\u0430 \u0441 \u0446\u0435\u043B\u044C\u044E \u043F\u0440\u0435\u0434\u043E\u0442\u0432\u0440\u0430\u0449\u0435\u043D\u0438\u044F \u043E\u0442\u043F\u0440\u0430\u0432\u043A\u0438 \u043F\u0443\u0441\u0442\u043E\u0433\u043E \u043F\u0438\u0441\u044C\u043C\u0430.",
		NoDefaultContentHint: "\u0428\u0430\u0431\u043B\u043E\u043D \u0440\u0430\u0441\u0441\u044B\u043B\u043A\u0438 \u043D\u0435 \u0441\u043E\u0434\u0435\u0440\u0436\u0438\u0442 \u043A\u043E\u043D\u0442\u0435\u043D\u0442 \u043F\u043E \u0443\u043C\u043E\u043B\u0447\u0430\u043D\u0438\u044E. \u041F\u043E\u043B\u0443\u0447\u0430\u0442\u0435\u043B\u044F\u043C, \u043A\u043E\u0442\u043E\u0440\u044B\u0435 \u043D\u0435 \u0441\u043E\u043E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044E\u0442 \u0443\u0441\u043B\u043E\u0432\u0438\u044F\u043C \u043F\u0440\u0430\u0432\u0438\u043B \u0434\u0438\u043D\u0430\u043C\u0438\u0447\u0435\u0441\u043A\u043E\u0433\u043E \u043A\u043E\u043D\u0442\u0435\u043D\u0442\u0430, \u0431\u0443\u0434\u0435\u0442 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D \u043E\u0442\u043A\u043B\u0438\u043A \u0022\u041D\u0435 \u043E\u0442\u043F\u0440\u0430\u0432\u043B\u0435\u043D\u043E (\u0448\u0430\u0431\u043B\u043E\u043D \u043E\u0442\u0441\u0443\u0442\u0441\u0442\u0432\u0443\u0435\u0442)\u0022",
		SelectReplicaToPreviewContent: "\u003Cdiv style=\u0022text-align:center;color:#a2a2a2;padding:20px\u0022\u003E\u041F\u043E\u0436\u0430\u043B\u0443\u0439\u0441\u0442\u0430, \u0432\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0432\u0430\u0440\u0438\u0430\u043D\u0442 \u0448\u0430\u0431\u043B\u043E\u043D\u0430\u003C/div\u003E"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CloseIcon: {
			source: 3,
			params: {
				schemaName: "PreviewDynamicContentBuilder",
				resourceItemName: "CloseIcon",
				hash: "63f0a846ac338fa8ced85b5685fa15f6",
				resourceItemExtension: ".png"
			}
		},
		ExpandIcon: {
			source: 3,
			params: {
				schemaName: "PreviewDynamicContentBuilder",
				resourceItemName: "ExpandIcon",
				hash: "d12ba2dcc89318c4b1647a1942c45b0e",
				resourceItemExtension: ".svg"
			}
		},
		DefaultBlockInfoButtonImage: {
			source: 3,
			params: {
				schemaName: "PreviewDynamicContentBuilder",
				resourceItemName: "DefaultBlockInfoButtonImage",
				hash: "33d44fbb5a791276ddbae2f046e70b8b",
				resourceItemExtension: ".png"
			}
		},
		BackIcon: {
			source: 3,
			params: {
				schemaName: "PreviewDynamicContentBuilder",
				resourceItemName: "BackIcon",
				hash: "6143f8f0bd6c2b027dc3ae5c825c9e2a",
				resourceItemExtension: ".svg"
			}
		},
		EmptyReplicaIcon: {
			source: 3,
			params: {
				schemaName: "PreviewDynamicContentBuilder",
				resourceItemName: "EmptyReplicaIcon",
				hash: "25e896cdece5a8acfc34cc4ee540b441",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});