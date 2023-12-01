﻿define("EventPageV2Resources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		GeneralInfoTabCaption: "General information",
		EventTypeCaption: "Type",
		OwnerCaption: "Owner",
		EventStatusCaption: "Status",
		groupCaption: "",
		StartDateCaption: "Start",
		EndDateCaption: "End",
		GoalCaption: "Goal",
		TerritoryCaption: "Territory",
		IndustryCaption: "Industry",
		ActualResponseCaption: "Actual response",
		group1Caption: "Financial indicators",
		PrimaryBudgetedCostCaption: "Expected budget, base currency",
		PrimaryExpectedRevenueCaption: "Expected revenue, base currency",
		PrimaryActualCostCaption: "Actual cost, base currency",
		PrimaryActualRevenueCaption: "Actual revenue, base currency",
		EventPage3TabCaption: "Audience",
		EventPage4TabCaption: "History",
		EventPage5TabCaption: "Attachments and notes",
		WarningWrongDate: "Could not save event as the start date of the event can not be greater than the end date.",
		ContactListCaption: "List of contacts",
		LastUpdateDateCaption: "Last updated on",
		ContactCountCaption: "Number of contacts",
		UpdateContactListCaption: "update list of contacts",
		QueueTasksLabelText: "Tasks in progress: ETA ~ {0} min"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		TagButtonIcon: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "TagButtonIcon",
				hash: "749c444773b4d39e64c4f6938fdf6d76",
				resourceItemExtension: ".svg"
			}
		},
		BackButtonImage: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "BackButtonImage",
				hash: "638af7d7df9879b2c8f3b1bb7eb0f788",
				resourceItemExtension: ".png"
			}
		},
		CloseButtonImage: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "CloseButtonImage",
				hash: "511593df65946d88744783400c622cdb",
				resourceItemExtension: ".png"
			}
		},
		ProcessButtonImage: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "ProcessButtonImage",
				hash: "b2718527a6bf360a3e641e9cb3a00904",
				resourceItemExtension: ".svg"
			}
		},
		QuickAddButtonImage: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "QuickAddButtonImage",
				hash: "bbcac9c59db676c3f206809cbdbd3244",
				resourceItemExtension: ".png"
			}
		},
		AnalyticsDataIcon: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "AnalyticsDataIcon",
				hash: "797f9955cfd47e5ca74c16a682de6853",
				resourceItemExtension: ".svg"
			}
		},
		GridSettingsIcon: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "GridSettingsIcon",
				hash: "c4949763b4bc893604fbb2d5d458a028",
				resourceItemExtension: ".svg"
			}
		},
		OpenChangeLogBtnImage: {
			source: 3,
			params: {
				schemaName: "EventPageV2",
				resourceItemName: "OpenChangeLogBtnImage",
				hash: "cbebcb32589828e1055caf62150ff717",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});