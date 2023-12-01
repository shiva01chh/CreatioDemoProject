﻿define("ProjectResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		ProjectCaption: "\u041F\u0440\u043E\u0435\u043A\u0442",
		IdCaption: "Id",
		CreatedOnCaption: "\u0414\u0430\u0442\u0430 \u0441\u043E\u0437\u0434\u0430\u043D\u0438\u044F",
		CreatedByCaption: "\u0421\u043E\u0437\u0434\u0430\u043B",
		ModifiedOnCaption: "\u0414\u0430\u0442\u0430 \u0438\u0437\u043C\u0435\u043D\u0435\u043D\u0438\u044F",
		ModifiedByCaption: "\u0418\u0437\u043C\u0435\u043D\u0438\u043B",
		NotesCaption: "\u0417\u0430\u043C\u0435\u0442\u043A\u0438",
		ProcessListenersCaption: "\u0410\u043A\u0442\u0438\u0432\u043D\u044B\u0435 \u043F\u0440\u043E\u0446\u0435\u0441\u0441\u044B",
		NameCaption: "\u041D\u0430\u0437\u0432\u0430\u043D\u0438\u0435",
		AccountCaption: "\u041A\u043E\u043D\u0442\u0440\u0430\u0433\u0435\u043D\u0442",
		ContactCaption: "\u041A\u043E\u043D\u0442\u0430\u043A\u0442",
		ProjectEntryTypeCaption: "\u0422\u0438\u043F \u0437\u0430\u043F\u0438\u0441\u0438 \u043F\u0440\u043E\u0435\u043A\u0442\u0430",
		TypeCaption: "\u0422\u0438\u043F",
		OwnerCaption: "\u041E\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0435\u043D\u043D\u044B\u0439",
		StatusCaption: "\u0421\u043E\u0441\u0442\u043E\u044F\u043D\u0438\u0435",
		StartDateCaption: "\u041D\u0430\u0447\u0430\u043B\u043E",
		EndDateCaption: "\u0417\u0430\u0432\u0435\u0440\u0448\u0435\u043D\u0438\u0435",
		DurationCaption: "\u0414\u043B\u0438\u0442\u0435\u043B\u044C\u043D\u043E\u0441\u0442\u044C",
		DeadlineCaption: "\u041A\u0440\u0430\u0439\u043D\u0438\u0439 \u0441\u0440\u043E\u043A",
		SupplierCaption: "\u041F\u043E\u0441\u0442\u0430\u0432\u0449\u0438\u043A",
		OpportunityCaption: "\u041F\u0440\u043E\u0434\u0430\u0436\u0430",
		ParentProjectCaption: "\u0420\u043E\u0434\u0438\u0442\u0435\u043B\u044C\u0441\u043A\u0438\u0439 \u044D\u043B\u0435\u043C\u0435\u043D\u0442",
		ActualCompletionCaption: "% \u0432\u044B\u043F\u043E\u043B\u043D\u0435\u043D\u0438\u044F",
		IsAutoCalcCompletionCaption: "\u0420\u0430\u0441\u0441\u0447\u0438\u0442\u044B\u0432\u0430\u0442\u044C \u0430\u0432\u0442\u043E\u043C\u0430\u0442\u0438\u0447\u0435\u0441\u043A\u0438",
		PlanIncomeCaption: "\u041F\u043B\u0430\u043D. \u0434\u043E\u0445\u043E\u0434",
		FactIncomeCaption: "\u0424\u0430\u043A\u0442. \u0434\u043E\u0445\u043E\u0434",
		IncomeDevCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0434\u043E\u0445\u043E\u0434\u0430",
		IncomeDevPercCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0434\u043E\u0445\u043E\u0434\u0430, %",
		PlanExternalCostCaption: "\u041F\u043B\u0430\u043D. \u0441\u043C\u0435\u0442\u043D. \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C",
		FactExternalCostCaption: "\u0424\u0430\u043A\u0442. \u0441\u043C\u0435\u0442\u043D. \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C",
		ExternalCostDevCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0441\u043C\u0435\u0442\u043D. \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u0438",
		PlanExternalDevPercCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0441\u043C\u0435\u0442\u043D. \u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u0438, %",
		PlanExpenseCaption: "\u041F\u043B\u0430\u043D. \u043F\u0440\u044F\u043C\u043E\u0439 \u0440\u0430\u0441\u0445\u043E\u0434",
		FactExpenseCaption: "\u0424\u0430\u043A\u0442. \u043F\u0440\u044F\u043C\u043E\u0439 \u0440\u0430\u0441\u0445\u043E\u0434",
		ExpenseDevCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u043F\u0440\u044F\u043C\u044B\u0445 \u0440\u0430\u0441\u0445\u043E\u0434\u043E\u0432",
		ExpenseDevPercCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u043F\u0440\u044F\u043C\u044B\u0445 \u0440\u0430\u0441\u0445\u043E\u0434\u043E\u0432, %",
		PlanInternalCostCaption: "\u041F\u043B\u0430\u043D. \u0441\u0435\u0431\u0435\u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C",
		FactInternalCostCaption: "\u0424\u0430\u043A\u0442. \u0441\u0435\u0431\u0435\u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u044C",
		InternalCostDevCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0441\u0435\u0431\u0435\u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u0438",
		PlanInternalDevPercCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u0441\u0435\u0431\u0435\u0441\u0442\u043E\u0438\u043C\u043E\u0441\u0442\u0438, %",
		PlanMarginCaption: "\u041F\u043B\u0430\u043D. \u043C\u0430\u0440\u0436\u0430",
		PlanMarginPercCaption: "\u041F\u043B\u0430\u043D. \u043C\u0430\u0440\u0436\u0430, %",
		FactMarginCaption: "\u0424\u0430\u043A\u0442. \u043C\u0430\u0440\u0436\u0430",
		FactMarginPercCaption: "\u0424\u0430\u043A\u0442 \u043C\u0430\u0440\u0436\u0430, %",
		MarginDevCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u043C\u0430\u0440\u0436\u0438",
		MarginDevPercCaption: "\u041E\u0442\u043A\u043B\u043E\u043D\u0435\u043D\u0438\u0435 \u043C\u0430\u0440\u0436\u0438, %",
		PositionCaption: "\u041F\u043E\u0437\u0438\u0446\u0438\u044F"
	};
	var localizableImages = {};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages};
});