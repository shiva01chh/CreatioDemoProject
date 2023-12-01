define("SystemNotificationsSchemaResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ContextHelpCode: "",
		ContextHelpId: "1581",
		EmptyResultMessage: "Learn more about the notifications in the {0}Academy{1}.",
		EmptyResultTitle: "You do not have any notifications that require your attention",
		ImportNotificationLinkCaption: "Open imported records",
		ImportNotificationLogLinkCaption: "Open data import log",
		ObsoleteDecorateItemMethodMessage: "",
		ObsoleteRemoveColumnsMethodMessage: "extension methods addColumns or addFilters",
		ReportNotificationHeaderTpl: "Generated the following report: {0}",
		ReportNotificationSubject: "Download the report"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		EmptyResultImage: {
			source: 3,
			params: {
				schemaName: "SystemNotificationsSchema",
				resourceItemName: "EmptyResultImage",
				hash: "46e5dc9be3ae1086304bef981f46208c",
				resourceItemExtension: ".svg"
			}
		},
		DefaultRemindingIcon: {
			source: 3,
			params: {
				schemaName: "SystemNotificationsSchema",
				resourceItemName: "DefaultRemindingIcon",
				hash: "fc25e15a25188b310d43e0d790d71956",
				resourceItemExtension: ".svg"
			}
		},
		UpdateIsAvailableIcon: {
			source: 3,
			params: {
				schemaName: "SystemNotificationsSchema",
				resourceItemName: "UpdateIsAvailableIcon",
				hash: "0f481f16f80c1c425b058a8a2eb993ec",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});