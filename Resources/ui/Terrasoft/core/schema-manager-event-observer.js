Ext.define("Terrasoft.core.SchemaManagerEventObserver", {
	alternateClassName: "Terrasoft.SchemaManagerEventObserver",

	singleton: true,

	constructor: function() {
		Terrasoft.ServerChannel.on(Terrasoft.EventName.ON_MESSAGE, this._onMessageHandler, this);
	},

	/**
	 * @private
	 */
	_onMessageHandler: function(channel, message) {
		if (Ext.isEmpty(message)) {
			return;
		}
		const header = message.Header;
		if (Ext.isEmpty(header) ||
			header.Sender !== "SchemaManagerItemEventNotifier" ||
			(header.BodyTypeName !== "ChangedSchema" && header.BodyTypeName !== "RemovedSchema")) {
			return;
		}
		const body = JSON.parse(message.Body);
		if (body.ManagerName === "ClientUnitSchemaManager") {
			this._setRequireJsConfig(body.Name);
		}
	},

	/**
	 * @private
	 */
	_setRequireJsConfig: function(schemaName) {
		let paths;
		require.undef(schemaName);
		require.undef(schemaName + "Structure");
		const schemaResourcesName = schemaName + "Resources";
		require.undef(schemaResourcesName);
		const suffix = ".js?hash=" + Date.now();
		if (Terrasoft.useStaticFileContent) {
			this.resetBundleRequireConfig();
			const url = Terrasoft.workspaceBaseUrl+ "/conf/content/";
			const schemaUrl = url + schemaName + suffix;
			const schemaResourcesUrl = `${url}resources/${Terrasoft.currentUserCultureName}/${schemaResourcesName}` +
				suffix;
			const emptyResourcesUrl = Terrasoft.coreModulesPath + "Terrasoft/configuration/resources/empty-resources";
			paths = {
				[schemaName]: schemaUrl,
				[schemaResourcesName]: [schemaResourcesUrl, emptyResourcesUrl]
			};
		} else {
			const url = Terrasoft.workspaceBaseUrl+ "/configuration/hash/";
			const schemaUrl = url + schemaName + suffix;
			paths = {[schemaName]: schemaUrl};
		}
		require.config({paths});
	},

	/**
	 * Reset requireJs bundles config.
	 */
	resetBundleRequireConfig: function() {
		let bundles = require.s?.contexts?._?.config?.bundles;
		if (bundles && !Terrasoft.isEmptyObject(bundles)) {
			const resetBundles = Object.fromEntries(Object.keys(bundles).map((key) => [key, []]));
			require.config({
				bundles: resetBundles
			});
		}
	}

});

