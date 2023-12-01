﻿define("SectionEntitySelectMixin", ["ext-base", "terrasoft", "SectionInWorkplaceManager"], function(Ext, Terrasoft) {
	Ext.define("Terrasoft.configuration.mixins.SectionEntitySelectMixin", {
		alternateClassName: "Terrasoft.SectionEntitySelectMixin",

		//region Methods: Protected

		/**
		 * Creates an EntitySchemaDesignerUtilities class.
		 * @protected
		 * @return EntitySchemaDesignerUtilities class.
		 */
		getEntitySchemaDesignerUtilities: function() {
			const packageUId = this.getPackageUId();
			return Terrasoft.PackageAwareEntitySchemaDesignerUtilities.create(packageUId);
		},

		//endregion

		//region Methods: Public

		/**
		 * Returns not virtual entity schema list for current package sorted by caption.
		 * @param {Function} callback Callback function.
		 * @param {Terrasoft.Collection} callback.items Entity schema list.
		 * @param {Object} scope Execution scope.
		 */
		getEntitySchemaList: function(callback, scope) {
			Terrasoft.chain(
				function(next) {
					Terrasoft.SectionInWorkplaceManager.initialize(null, next, this);
				},
				function() {
					const utils = this.getEntitySchemaDesignerUtilities();
					utils.findEntitySchemaItems(callback, scope);
				},
				this
			);
		},

		/**
		 * Filters entities by registered section modules.
		 * @param {Terrasoft.core.collections.Collection} entityList Entity collection.
		 * @return {Terrasoft.core.collections.Collection}
		 */
		filterEntityListBySections: function(entityList) {
			var modules = Terrasoft.configuration.ModuleStructure;
			var sections = Terrasoft.SectionInWorkplaceManager.items.getItems();
			return entityList.filter(function(entity) {
				var module = modules[entity.name];
				return module && sections.some(function(item) {
						return item.section.value === module.moduleId;
					});
			});
		}

		//endregion
	});
});
