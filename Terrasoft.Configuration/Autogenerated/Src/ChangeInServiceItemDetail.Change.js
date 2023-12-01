define("ChangeInServiceItemDetail", [],
		function() {
			return {
				entitySchemaName: "ChangeServiceItem",
				methods: {
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
					 * @overridden
					 */
					getCopyRecordMenuItem: this.Terrasoft.emptyFn,
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
					 * @overridden
					 */
					getEditRecordMenuItem: this.Terrasoft.emptyFn,
					/**
					 * Initialize detail config.
					 */
					initConfig: function() {
						this.callParent(arguments);
						var config = this.getConfig();
						config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Change";
						config.sectionEntitySchema = "ServiceItem";
					},
					/**
					 * @inheritdoc Terrasoft.BaseGridDetailV2#init
					 * @overridden
					 */
					init: function() {
						this.callParent(arguments);
						this.initConfig();
					},
					/**
					 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
					 * @overridden
					 */
					getFilterDefaultColumnName: function() {
						return "Change";
					}
				},
				diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
			};
		});
