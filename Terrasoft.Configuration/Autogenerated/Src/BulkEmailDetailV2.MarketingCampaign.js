﻿define("BulkEmailDetailV2", [],
function() {
	return {
		entitySchemaName: "BulkEmail",
		attributes: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"type": "listed",
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "NameListedGridColumn",
								"bindTo": "Name",
								"type": "text",
								"position": {
									"column": 0,
									"colSpan": 24
								}
							}
						]
					},
					"tiledConfig": {
						"name": "DataGridTiledConfig",
						"grid": {
							"columns": 24,
							"rows": 1
						},
						"items": [
							{
								"name": "NameTiledGridColumn",
								"bindTo": "Name",
								"type": "text",
								"position": {
									"row": 1,
									"column": 0,
									"colSpan": 24
								},
								"captionConfig": {
									"visible": false
								}
							}
						]
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @overridden
			 */
			getDeleteRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * ########## ######### ###### ########## ######.
			 * @protected
			 * @return {Boolean} ######### ###### ########## ######.
			 */
			getAddRecordButtonVisible: function() {
				return false;
			},

			/**
			 * ########## ######### ###### # #### ########## ######.
			 * @protected
			 * @return {Boolean} ######### ###### # #### ########## ######.
			 */
			getAddTypedRecordButtonVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @overridden
			 */
			getSwitchGridModeMenuItem: Terrasoft.emptyFn
		}
	};
});
