define("AudienceSectionModule", ["SectionModuleV2", "css!SectionModuleV2"], function() {
	/**
	 * @class Terrasoft.configuration.AudienceSectionModule
	 */
	Ext.define("Terrasoft.configuration.AudienceSectionModule", {
		alternateClassName: "Terrasoft.AudienceSectionModule",
		extend: "Terrasoft.SectionModule",

		/**
		 * Suffix to indicate section type for module.
		 * @type {String}
		 */
		sectionSuffix: "SectionV2",

		/**
		 * Suffix to indicate grid view name.
		 * @type {String}
		 */
		gridViewSuffix: "GridSettingsGridDataView",

		/**
		 * @inheritdoc Terrasoft.SectionModule#getProfileKey
		 * @override
		 */
		getProfileKey: function() {
			return this.entitySchemaName + this.sectionSuffix + this.gridViewSuffix;
		},

		/**
		 * Inits entity schema name property from historyState.
		 * @protected
		 */
		initEntitySchemaName: function() {
			var historyState = this.sandbox.publish("GetHistoryState");
			this.entitySchemaName = historyState.state.entitySchema;
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaModule#init
		 * @override
		 */
		init: function(callback, scope) {
			this.initEntitySchemaName();
			this.callParent(arguments);
		},

		/**
		 * @inheritdoc Terrasoft.SectionModule#actualizeCardHistoryState
		 * @override
		 */
		actualizeCardHistoryState: Terrasoft.emptyFn

	});
	return Terrasoft.AudienceSectionModule;
});
