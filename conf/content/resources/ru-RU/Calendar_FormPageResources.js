﻿define("Calendar_FormPageResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		RefreshButtonCaption: "\u041E\u0431\u043D\u043E\u0432\u0438\u0442\u044C",
		SearchFilter_placeholder: "\u041F\u043E\u0438\u0441\u043A",
		SearchFilter_81tgtdz_placeholder: "Search",
		QuickFilter_qbosx6o_config_caption: "\u0421\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A",
		QuickFilter_qbosx6o_caption: "Quick filter",
		QuickFilter_svcbj7p_config_caption: "\u0414\u0430\u0442\u0430",
		QuickFilter_svcbj7p_caption: "Quick filter",
		Button_xf59yjn_caption: "Refresh",
		QuickFilter_MyTasks_config_caption: "\u0422\u043E\u043B\u044C\u043A\u043E \u043C\u043E\u0438 \u0437\u0430\u0434\u0430\u0447\u0438",
		QuickFilter_ro08tuf_config_caption: "\u0422\u043E\u043B\u044C\u043A\u043E \u043C\u043E\u0438 \u0437\u0430\u0434\u0430\u0447\u0438",
		QuickFilter_ro08tuf_caption: "Quick filter",
		QuickFilter_CanceledTasks_config_caption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C \u043E\u0442\u043C\u0435\u043D\u0435\u043D\u043D\u044B\u0435 \u0437\u0430\u0434\u0430\u0447\u0438",
		QuickFilter_xgh1gh9_config_caption: "Show canceled tasks",
		QuickFilter_xgh1gh9_caption: "Quick filter",
		QuickFilter_qbosx6o_config_hint: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430",
		QuickFilter_svcbj7p_config_hint: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0434\u0430\u0442\u0443",
		QuickFilter_Employee_config_hint: "\u0412\u044B\u0431\u0435\u0440\u0438\u0442\u0435 \u0441\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A\u0430",
		QuickFilter_Employee_config_caption: "\u0421\u043E\u0442\u0440\u0443\u0434\u043D\u0438\u043A",
		MenuItem_f38t0gt_caption: "Data import",
		MenuItem_ImportFromExcel_caption: "\u0418\u043C\u043F\u043E\u0440\u0442 \u0434\u0430\u043D\u043D\u044B\u0445",
		MenuItem_a43zlot_caption: "\u041F\u043E\u043A\u0430\u0437\u0430\u0442\u044C/\u0441\u043A\u0440\u044B\u0442\u044C \u0432\u044B\u0445\u043E\u0434\u043D\u044B\u0435",
		MenuItem_ExportToExel2_caption: "",
		RefreshButton_caption: "",
		ActionButton_caption: "\u0414\u0435\u0439\u0441\u0442\u0432\u0438\u044F",
		Button_Data_Import: "\u0418\u043C\u043F\u043E\u0440\u0442",
		DefaultHeaderCaption: "\u0417\u0430\u0433\u043E\u043B\u043E\u0432\u043E\u043A \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B",
		EmptySectionPlaceholderSubHead: "\u0414\u043E\u0431\u0430\u0432\u044C\u0442\u0435 \u043D\u043E\u0432\u0443\u044E \u0437\u0430\u043F\u0438\u0441\u044C, \u0438 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435 \u0431\u0443\u0434\u0435\u0442 \u0442\u0430\u043A \u043E\u0434\u0438\u043D\u043E\u043A\u043E",
		EmptySectionPlaceholderTitle: "\u0412 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		FilteredEmptySectionPlaceholderSubHead: "\u041E\u0447\u0438\u0441\u0442\u0438\u0442\u0435 \u0444\u0438\u043B\u044C\u0442\u0440 \u0438\u043B\u0438 \u0438\u0437\u043C\u0435\u043D\u0438\u0442\u0435 \u0443\u0441\u043B\u043E\u0432\u0438\u044F \u0444\u0438\u043B\u044C\u0442\u0440\u0430\u0446\u0438\u0438",
		FilteredEmptySectionPlaceholderTitle: "\u041F\u0440\u0438 \u0443\u0441\u0442\u0430\u043D\u043E\u0432\u043B\u0435\u043D\u043D\u043E\u043C \u0444\u0438\u043B\u044C\u0442\u0440\u0435 \u0432 \u0440\u0430\u0437\u0434\u0435\u043B\u0435 \u043D\u0435\u0442 \u043D\u0438 \u043E\u0434\u043D\u043E\u0439 \u0437\u0430\u043F\u0438\u0441\u0438",
		ListTitleCaption: "List title",
		MenuItem_ExportToExel_caption: "\u042D\u043A\u0441\u043F\u043E\u0440\u0442 \u0432 Excel",
		MenuItem_ImportFromExel_caption: "Excel",
		OpenLandingDesignerCaption: "Web-\u0444\u043E\u0440\u043C\u044B \u0438 \u0441\u0442\u0440\u0430\u043D\u0438\u0446\u044B"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});