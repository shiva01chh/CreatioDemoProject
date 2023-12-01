define("ProblemInCaseDetail", ["ProblemInCaseDetailResources"],
function() {
	return {
		entitySchemaName: "ProblemInCase",
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"rowDataItemMarkerColumnName": "Problem.Number"
				}
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		messages: {},
		methods: {
			/**
			 * @inheritDoc Terrasoft.BaseManyToManyGridDetail#initConfig
			 * @overridden
			 */
			initConfig: function() {
				this.callParent(arguments);
				var config = this.getConfig();
				config.lookupEntitySchema = config.lookupConfig.entitySchemaName = "Problem";
				config.sectionEntitySchema = "Case";
				config.lookupConfig.multiselect = true;
			},

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#init
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
				return "Problem";
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
			 * @overridden
			 */
			addDetailWizardMenuItems: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: this.Terrasoft.emptyFn
		}
	};
});
