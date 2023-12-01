define("PageUtilities", ["@creatio/utils"], function(creatioUtils) {
	/**
	 * @class Terrasoft.configuration.mixins.PageUtilities
	 * Contains utility methods used by page.
	 */
	Ext.define("Terrasoft.configuration.mixins.PageUtilities", {
		alternateClassName: "Terrasoft.PageUtilities",

		//region Properties: Private

		/**
		 * Default card module.
		 * @private
		 * @type {String}
		 */
		defaultCardModule: "CardModuleV2",

		//endregion

		//region Methods: Protected

		/**
		 * Finds lookup column attribute value.
		 * @protected
		 * @virtual
		 * @param {String} columnName Lookup column name.
		 * @param {Object} attribute Lookup column attribute.
		 * @return {Object} Value of card schema type lookup column.
		 */
		findLookupColumnAttributeValue: function(columnName, attribute) {
			return this.get && (this.get(columnName + "." + attribute) || this.get(attribute));
		},

		//endregion

		//region Methods: Public

		/**
		 * Opens target page.
		 * @param {Object} config Target page config
		 * @param {String} config.entitySchemaName Name of page entity schema.
		 * @param {String} config.columnName Column name of target record.
		 * @param {String} config.value Value of target record.
		 * @param {Object} config.historyState PushHistoryState additional config.
		 */
		openPage: function(config) {
			var entitySchemaName = config.entitySchemaName;
			var columnName = config.columnName || "";
			var value = config.value || "";
			var cardSchema = this.getCardSchemaName(entitySchemaName, columnName, value);
			var cardModule = Terrasoft.ModuleUtils.getCardModule({
				entityName: entitySchemaName,
				cardSchema: cardSchema,
				defaultModule: this.defaultCardModule,
			});
			var path = Terrasoft.combinePath(cardModule, cardSchema, "edit", value);
			var historyStateConfig = {hash: path};
			if (config.historyState) {
				Ext.apply(historyStateConfig, config.historyState);
			}
			this.sandbox.publish("PushHistoryState", historyStateConfig);
		},

		/**
		 * Returns page name from modulePages array found by type column.
		 * Retrieves type value from the view model.
		 * @private
		 * @param {String} columnName Name of the lookup column to be found.
		 * @param {String} attribute Name of the type column.
		 * @param {Array} modulePages Array of the module or entity edit pages.
		 * @return {String} Typed page name.
		 */
		_getCardSchemaNameByType: function(columnName, attribute, modulePages, entitySchemaName, defaultValues) {
			var cardSchemaType = this.findLookupColumnAttributeValue(columnName, attribute);
			var filteredPagesByType = modulePages.filter(function(item) {
				return ((item.UId === (cardSchemaType && cardSchemaType.value) && !item?.actions?.add) && item.cardSchema);
			});
			if (!filteredPagesByType.length) {
				const options = {
					action: 'add',
					entityName: entitySchemaName,
					defaultValues
				};
				return creatioUtils.NavigationUtils.getPageForAction(options)?.cardSchema;
			}
			var page = !Ext.isEmpty(filteredPagesByType) && filteredPagesByType.shift();
			return (page && page.cardSchema) || null;
		},

		/**
		 * Gets the name of the entity editing cards.
		 * @param {String} entitySchemaName Name of entity schema.
		 * @param {String} columnName Column Name.
		 * @return {String} Name of the entity editing cards.
		 */
		getCardSchemaName: function(entitySchemaName, columnName, defaultValues = []) {
			var structure = this.getEntityStructure(entitySchemaName) || this.getModuleStructure(entitySchemaName);
			if (!structure) {
				throw new Terrasoft.ItemNotFoundException();
			}
			var cardSchemaName = structure.cardSchema;
			var attribute = structure && structure.attribute;
			var modulePages = Terrasoft.deepClone(structure.pages);
			var defaultPage = modulePages && modulePages.shift();
			if (attribute) {
				var typedCardName = this._getCardSchemaNameByType(columnName, attribute, structure.pages, entitySchemaName, defaultValues);
				cardSchemaName = typedCardName || cardSchemaName;
			}
			cardSchemaName = cardSchemaName || (defaultPage && defaultPage.cardSchema);
			return cardSchemaName;
		},

		/**
		 * Returns structure of the module.
		 * @param {String} moduleName Name of the module.
		 * @return {Object} Structure of the module.
		 */
		getModuleStructure: function(moduleName) {
			return Terrasoft.ModuleUtils.getModuleStructureByName(moduleName || this.entitySchemaName);
		},

		/**
		 * Returns entity schema information from entity structure for entitySchemaName.
		 * If it is not specified, use entitySchemaName field of the current class instance.
		 * @protected
		 * @param {String} [entitySchemaName] Entity schema name.
		 * @return {Object} Entity schema information.
		 */
		getEntityStructure: function(entitySchemaName) {
			return Terrasoft.ModuleUtils.getEntityStructureByName(entitySchemaName || this.entitySchemaName);
		},

		/**
		 * Returns sign that exists edit page schema for subscriber entity schema.
		 * @protected
		 * @param {String} schemaName Subscriber entity schema name.
		 * @return {String} Sign that exists edit page schema for subscriber entity schema.
		 */
		hasEntityEditPage: function(schemaName) {
			const entityStructure = this.getEntityStructure(schemaName);
			if (!entityStructure) {
				return false;
			}
			const pages = entityStructure.pages;
			if (pages.length > 0) {
				return Boolean(pages[0]?.cardSchema);
			}
			return false;
		}

		//endregion
	});

	return Terrasoft.PageUtilities;
});
