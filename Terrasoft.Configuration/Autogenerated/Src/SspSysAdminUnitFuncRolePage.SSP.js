﻿define("SspSysAdminUnitFuncRolePage", [],
	function() {
		return {
			entitySchemaName: "VwSysAdminUnit",
			attributes: {
				"SecurityOperationName": {
					"dataValueType": this.Terrasoft.DataValueType.STRING,
					"value": "CanAdministratePortalUsers"
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "IPRangeTab"
				}
			]/**SCHEMA_DIFF*/,
			methods: {}
		};
	});
