define("ReleaseTeamDetail", ["terrasoft", "ConfigurationGrid",
		"ConfigurationGridGenerator", "ConfigurationGridUtilities"],
	function(Terrasoft) {
		return {
			entitySchemaName: "ReleaseTeam",
			attributes: {
				IsEditable: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: true
				},
				ReleaseStatusDefValue: {
					dataValueType: Terrasoft.DataValueType.STRING,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: "ReleaseStatusDefValue"
				}
			},
			mixins: {
				ConfigurationGridUtilites: "Terrasoft.ConfigurationGridUtilities"
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"className": "Terrasoft.ConfigurationGrid",
						"generator": "ConfigurationGridGenerator.generatePartial",
						"generateControlsConfig": {bindTo: "generatActiveRowControlsConfig"},
						"changeRow": {bindTo: "changeRow"},
						"unSelectRow": {bindTo: "unSelectRow"},
						"onGridClick": {bindTo: "onGridClick"},
						"initActiveRowKeyMap": {bindTo: "initActiveRowKeyMap"},
						"activeRowActions": [
							{
								"className": "Terrasoft.Button",
								"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "save",
								"markerValue": "save",
								"imageConfig": {"bindTo": "Resources.Images.SaveIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "cancel",
								"markerValue": "cancel",
								"imageConfig": {"bindTo": "Resources.Images.CancelIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "remove",
								"markerValue": "remove",
								"imageConfig": {"bindTo": "Resources.Images.RemoveIcon"}
							}
						],
						"listedZebra": true,
						"activeRowAction": {bindTo: "onActiveRowAction"}
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				init: function() {
					if (!Terrasoft.SysSettings.cachedSettings[this.ReleaseStatusDefValue]) {
						this.Terrasoft.SysSettings.querySysSettings("ReleaseStatusDef", null);
					}
					this.callParent(arguments);
				},
				/**
				 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "Responsible";
				}
			}
		};
	});
