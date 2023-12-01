﻿define("ConfItemDetail", ["terrasoft"],
function() {
	return {
		entitySchemaName: "ConfItem",
		attributes: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"type": this.Terrasoft.GridType.LISTED,
					"listedConfig": {
						"name": "DataGridListedConfig",
						"items": [
							{
								"name": "NameListedGridColumn",
								"bindTo": "Name",
								"type": this.Terrasoft.GridCellType.TEXT,
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
								"type": this.Terrasoft.GridCellType.TEXT,
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
		methods: {},
		messages: {}
	};
});
