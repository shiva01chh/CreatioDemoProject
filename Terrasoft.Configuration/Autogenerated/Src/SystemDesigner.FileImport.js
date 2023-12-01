﻿define("SystemDesigner", [], function() {
	return {
		methods: {

			//region Methods: Private

			/**
			 * Opens a window to import data from file.
			 * @private
			 */
			navigateToFileImport: function() {
				var importSessionId = this.Terrasoft.generateGUID();
				var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "Nui",
					"ViewModule.aspx?vm=FileImportWizard#FileImportModule/FileImportStartPage",
					importSessionId);
				setTimeout(function() {
					window.open(url, "_blank");
				}, 0);
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritdoc
			 * @overridden
			 */
			getOperationRightsDecoupling: function() {
				var operationRightsDecoupling = this.callParent(arguments);
				operationRightsDecoupling.navigateToFileImport = "CanImportFromExcel";
				return operationRightsDecoupling;
			}

			//endregion

		},
		diff: [
			{
				"operation": "remove",
				"name": "ExcelImport"
			},
			{
				"operation": "insert",
				"index": 0,
				"propertyName": "items",
				"parentName": "IntegrationTile",
				"name": "FileImport",
				"values": {
					"itemType": Terrasoft.ViewItemType.LINK,
					"caption": {"bindTo": "Resources.Strings.FileImportLinkCaption"},
					"tag": "navigateToFileImport",
					"click": {"bindTo": "invokeOperation"}
				}
			}
		]
	};
});
