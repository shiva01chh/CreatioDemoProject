define("ForecastTabResources", ["terrasoft"], function(Terrasoft) {
	var localizableStrings = {
		Add: "Add",
		Actions: "Actions",
		ViewOptions: "View",
		CalculateFactPotentialCaption: "Calculate \u0022Closed\u0022 and \u0022Pipeline\u0022 columns",
		CalculateFactPotentialCompleteMessage: "\u0022Closed\u0022 and \u0022Pipeline\u0022 columns calculation in progress. You will be notified on completion.",
		EditRightsMenuItemCaption: "Set up access rights",
		SetPeriod: "Set up time periods",
		Summary: "Total",
		Reload: "Refresh",
		ConfigurationButtonHint: "Configuration button",
		CalculateFactPotentialCaptionUIV2: "Recalculate forecast columns",
		CalculateFactPotentialCompleteMessageUIV2: "Forecast columns calculation in progress. You will be notified on completion.",
		ColumnsListMenuItem: "List of columns",
		PeriodsExceededErrorCaption: "Too many periods for calculation. Please reduce the number of periods to 24 and re-run calculation.",
		Calculate: "Calculate",
		FullscreenButtonCaption: "Open in new page",
		PopupBlockedMessage: "Pop-up windows are blocked in browser. Enable pop-up windows in your browser for correct operation of application.",
		AddByEntityCaption: "add",
		AddByFolderCaption: "add by forder",
		DeleteConfirmationMessage: "Are you sure that you want to delete \u0022{0}\u0022 record?",
		CalculationInProgressCaption: "In progress",
		OnlyFirstNItems: "Too many periods for calculation. Only first {0} will be selected"
	};
	var parametersLocalizableStrings = {};
	var localizableImages = {
		CalculateIcon: {
			source: 3,
			params: {
				schemaName: "ForecastTab",
				resourceItemName: "CalculateIcon",
				hash: "7854e585e89a768384704c2936de6b2a",
				resourceItemExtension: ".svg"
			}
		},
		FullscreenIcon: {
			source: 3,
			params: {
				schemaName: "ForecastTab",
				resourceItemName: "FullscreenIcon",
				hash: "08d89bd0b1c1162fc12bbbbb97c60f41",
				resourceItemExtension: ".svg"
			}
		}
	};
	return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});