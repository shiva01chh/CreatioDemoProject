define("QueuePageGridSettingsPage", [], function() {
	return {
		attributes: {
			/**
			 * Related entity column path reverse relation join string.
		 	* @type {String}
		 	*/
			"RelatedEntityColumnPathPrefix": {dataValueType: Terrasoft.DataValueType.STRING}
		},
		methods: {

			//region Methods: protected

			/**
			 * @inheritdoc Terrasoft.GridSettingsPage#init
			 * @override
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.$RelatedEntityColumnPathPrefix = Ext.String.format("[{0}:Id:EntityRecordId]", this.entityColumns.EntityRecordId.referenceSchemaName);
					this.Ext.callback(callback, scope || this);
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.transformColumn#init
			 * @override
			 */
			transformColumn: function(config) {
				var column = config.column;
				if(config.doNotSaveProfile && Ext.String.startsWith(column.metaPath, "EntityRecord")) {
					column.metaPath = this.$RelatedEntityColumnPathPrefix + column.metaPath.replace("EntityRecord", "");
					column.bindTo = column.metaPath;
				}
				return column;
			}

			//endregion
		},
		diff: []
	};
});
 