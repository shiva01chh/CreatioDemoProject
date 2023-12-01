Terrasoft.configuration.Structures["MarketingCommonUtilities"] = {innerHierarchyStack: ["MarketingCommonUtilities"]};
define("MarketingCommonUtilities", [],
	function() {

		/**
		 * ########## ######### #### # #######, ####### ##### ## ######## url.
		 * @param {String} message ############ #########.
		 * @param {String} url ######.
		 * @param {String} goButtonCaption ######### ###### ########.
		 * @param {Object} scope ######## ##########.
		 */
		function showConfirmationDialogWithGoButton(message, url, goButtonCaption, scope) {
			var goButtonConfig = {
				className: "Terrasoft.Button",
				returnCode: "goButton",
				style: "blue",
				caption: goButtonCaption
			};
			scope.showConfirmationDialog(message,
				function(returnCode) {
					if (returnCode === "goButton") {
						window.open(url);
					}
				}, [goButtonConfig, "cancel"]);
		}

		function showConfirmationDialogWithBtnHandler(message, goButtonCaption, handler, scope) {
			var goButtonConfig = {
				className: "Terrasoft.Button",
				returnCode: "goButton",
				style: "blue",
				caption: goButtonCaption,
				markerValue: goButtonCaption
			};
			scope.showConfirmationDialog(message, handler, [goButtonConfig, "cancel"]);
		}

		return {
			ShowConfirmationDialogWithGoButton: showConfirmationDialogWithGoButton,
			ShowConfirmationDialogWithBtnHandler: showConfirmationDialogWithBtnHandler,
		};
	});


