﻿Terrasoft.configuration.Structures["RecommendationModuleUtilities"] = {innerHierarchyStack: ["RecommendationModuleUtilities"]};
define("RecommendationModuleUtilities", ["LoadProcessModules", "ProcessModuleUtilities"],
		function(LoadProcessModules, ProcessModuleUtilities) {
	/**
	 * @class Terrasoft.configuration.mixins.RecommendationModuleUtilities
	 * ######, ########### ###### # ####### RecommendationModule
	 */
	Ext.define("Terrasoft.configuration.mixins.RecommendationModuleUtilities", {
		alternateClassName: "Terrasoft.RecommendationModuleUtilities",

		/**
		 *
		 */
		activitySchemaName: "Activity",

		/**
		 *
		 */
		loadRecommendationModule: function() {
			if (!this.get("IsProcessMode")) {
				return;
			}
			var data = this.sandbox.publish("GetProcessExecData");
			if (!data) {
				return;
			}
			var entitySchemaName = data.entitySchemaName;
			if (entitySchemaName !== this.activitySchemaName || data.autoGeneratedPage || data.preconfiguredPage) {
				this.sandbox.loadModule("RecommendationModule", {
					renderTo: "RecommendationModuleContainer"
				});
			}
		}
	});
	return Terrasoft.RecommendationModuleUtilities;
});


