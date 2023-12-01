define("BulkEmailEventLogDetail", [], function() {
	return {
		entitySchemaName: "BulkEmailEventLog",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "AddRecordButton"
			},
			{
				"operation": "remove",
				"name": "AddTypedRecordButton"
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			getCopyRecordMenuItem: Terrasoft.emptyFn,
			getEditRecordMenuItem: Terrasoft.emptyFn,
			getDeleteRecordMenuItem: Terrasoft.emptyFn
		}
	};
});
