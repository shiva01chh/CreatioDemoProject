 define("BulkEmailAudienceSchemaLookupSection",
 		["BulkEmailAudienceSchema", "BulkEmailAudienceSchemaLookupSectionResources"],
	 function(RootSchema, resources) {
		return {
			entitySchemaName: "BulkEmailAudienceSchema",
			attributes: {
				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#UseSectionHeaderCaption
				 * @override
				 */
				"UseSectionHeaderCaption": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				}
			},
			methods: {

				/**
				 * @private
				 */
				_getExistedBulkEmailRecordsEsq: function(schemaIds) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "BulkEmail"
					});
					esq.columns.clear();
					var filter = Terrasoft.createColumnInFilterWithParameters(
						"[BulkEmailAudienceSchema:Id:AudienceSchemaId].Id", schemaIds);
					esq.filters.addItem(filter);
					esq.addAggregationSchemaColumn("Id", Terrasoft.AggregationType.COUNT, "Count");
					return esq;
				},

				/**
				 * @private
				 */
				_canEditEntityObject: function(items, count) {
					if (count > 0) {
						var message = (items.length > 1)
							? resources.localizableStrings.CouldNotDeleteAudienceSchemaMulti
							: resources.localizableStrings.CouldNotDeleteAudienceSchemaSingle;
						message = Ext.String.format(message, count);
						this.showInformationDialog(message);
						return false;
					}
					return true;
				},

				/**
				 * @inheritdoc Terrasoft.LinkedEntitySchemaLookupSection#formatColumnPath
				 * @override
				 */
				formatColumnPath: function(path, columnName) {
					return path;
				},

				/**
				 * @inheritdoc Terrasoft.BaseDataView#getActiveViewCaption
				 * @override
				 */
				getActiveViewCaption: function() {
					return RootSchema.caption;
				},

				/**
				 * @inheritdoc Terrasoft.BaseLookupConfigurationSection#checkCanDelete
				 * @override
				 */
				checkCanDelete: function(items, callback, scope) {
					var parentMethod = this.getParentMethod(this, arguments);
					var esq = scope._getExistedBulkEmailRecordsEsq(items);
					esq.getEntityCollection(function(response) {
						var result = response.collection.first();
						var count = result.get("Count");
						if (scope._canEditEntityObject(items, count)) {
							parentMethod();
						}
					});
				}

			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	});
