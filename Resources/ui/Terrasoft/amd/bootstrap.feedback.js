if (typeof Ext !== "undefined") {
	define("ext-base", [], function() {
		return Ext;
	});
	define("core-modules", [], function() {
		return false;
	});
} else {
	requirejs.config({
		paths: {
			"ext-base": "../../ExtJs/extjs-base-debug",
			"configuration-bootstraps": Terrasoft.coreModulesPath + "Terrasoft/amd/configuration-bootstraps"
		},
		shim: {
			"ext-base": {
				exports: "Ext"
			}
		}
	});
}
require(["configuration-loader"], function(configurationLoader) {
	if (Terrasoft.appFramework === "NETCOREAPP") {
		Terrasoft.feedbackConfig = {
			schemaName: Terrasoft.getQueryParameter(location.href, "schemaName"),
			token: Terrasoft.getQueryParameter(location.href, "token"),
			doLogout: "true"
		};
		configurationLoader.load(Terrasoft.getQueryParameter(location.href, "vm"));
	}
});