﻿Terrasoft.configuration.Structures["HomePageInWorkplaceUtils"] = {innerHierarchyStack: ["HomePageInWorkplaceUtils"]};
 define("HomePageInWorkplaceUtils", ["profile!clientWorkplaceMenuProfile"], function() {
	return {
		/**
		 * Returns current workplace structure.
		 * @public
		 * @param {String} workplaceId Workplace identifier.
		 * @returns {Object}
		 */
		getCurrentWorkplace: function(workplaceId) {
			const workplaces = Terrasoft.configuration?.WorkplacesStructure?.Workplaces ?? [];
			return workplaces.find((w) => w.workplaceId === workplaceId) || workplaces[0];
		},
		/**
		 * Returns current workplace structure async.
		 * @public
		 * @returns {Promise<Object>}
		 */
		getCurrentWorkplaceAsync: function() {
			return new Promise((resolve) => {
				require(["profile!clientWorkplaceMenuProfile"], ({workplaceId}) => {
					resolve(this.getCurrentWorkplace(workplaceId));
				});
			});
		},
		/**
		 * Return current workplace module name.
		 * @public
		 * @param {Object} workplace Workplace structure.
		 * @returns {String}
		 */
		getCurrentWorkplaceModuleName: function(workplace) {
			const modules = workplace?.modules ?? [];
			return modules[0]?.moduleName;
		},
		/**
		 * Opens current workplace default section async.
		 * @public
		 * @param {Object} sandbox Message sandbox.
		 * @returns {Promise<void>}
		 */
		openCurrentWorkplaceDefaultSectionAsync: async function(sandbox) {
			let hash;
			const workplace = await this.getCurrentWorkplaceAsync();
			if (workplace?.homePageSchemaName &&
				Terrasoft.ServerSchemaType[workplace?.homePageSchemaType] === Terrasoft.SchemaType.ANGULAR_SCHEMA) {
				hash = `HomePage/${workplace.homePageSchemaName}`;
			} else if (workplace?.homePageSchemaName) {
				hash = `IntroPage/${workplace.homePageSchemaName}`;
			} else {
				const moduleName = await this.getCurrentWorkplaceModuleName(workplace);
				const module = Terrasoft.configuration.ModuleStructure[moduleName];
				if (module) {
					hash = `${module.sectionModule}/${module.sectionSchema ?? ''}`;
				}
			}
			if (hash) {
				sandbox.publish("PushHistoryState", {hash});
				sandbox.publish("SelectedSideBarItemChanged", hash, ["sectionMenuModule"]);
			}
		}
	};
});
 

