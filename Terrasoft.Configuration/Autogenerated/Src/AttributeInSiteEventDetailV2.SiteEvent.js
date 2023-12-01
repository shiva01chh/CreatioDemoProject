define("AttributeInSiteEventDetailV2", [],
	function() {
		return {
			entitySchemaName: "AttributeInSiteEvent",
			messages: {},
			methods: {
				/**
				 * ############## ####### # ###### ######## #########.
				 * @protected
				 */
				navigateToSiteEventAttributeSection: function()
				{
					this.sandbox.publish("PushHistoryState", {
						hash: "SectionModuleV2/SiteEventAttributeSectionV2",
						stateObj: {
							schema: "SiteEventAttribute"
						}
					});
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: function() {
					return this.getButtonMenuItem({
						Caption: {"bindTo": "Resources.Strings.OpenSiteEventAttributeSectionButtonCaption"},
						Click: {"bindTo": "navigateToSiteEventAttributeSection"},
						Enabled: true
					});
				},

				/**
				 * ########## ######### ###### ########## ######.
				 * @overridden
				 * @return {Boolean} ######### ###### ########## ######.
				 */
				getAddRecordButtonVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: Terrasoft.emptyFn
			},
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
									"name": "AttributeListedGridColumn",
									"bindTo": "SiteEventAttribute",
									"position": {
										"column": 0,
										"colSpan": 12
									},
									"type": Terrasoft.GridCellType.TITLE
								},
								{
									"name": "StringValueListedGridColumn",
									"bindTo": "StringValue",
									"position": {
										"column": 12,
										"colSpan": 12
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
									"name": "AttributeTiledGridColumn",
									"bindTo": "SiteEventAttribute",
									"position": {"row": 0, "column": 0, "colSpan": 12},
									"type": Terrasoft.GridCellType.TITLE
								},
								{
									"name": "StringValueTiledGridColumn",
									"bindTo": "StringValue",
									"position": {"row": 0, "column": 12, "colSpan": 12}
								}
							]
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
