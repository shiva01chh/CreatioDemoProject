(function() {
	const isVueLogin = location.search.match(/vue=1/);
	if (isVueLogin) {
		const publicPath = Terrasoft.loaderBaseUrl + "/core/hash/dist/";
		requirejs.config({
			paths: {
				"login-vue": publicPath + "login-vue"
			}
		});
		// TODO : fix it
		window.__webpack_public_path__ = publicPath;
		require(["login-vue"]);
		return;
	}
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
				"user-agent-parser": Terrasoft.workspaceBaseUrl + "/core/hash/user-agent-parser/user-agent-parser.min",
				"user-agent": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/utils/user-agent",
				"login-view-utils": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/amd/login-view-utils",
				"login-model-utils": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/amd/login-model-utils",
				"two-factor-auth-utils": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/utils/two-factor-auth/two-factor-auth-utils",
				"ssoutils": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/utils/sso/ssoutils",
				"open-id-start-sso-client-provider": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/utils/sso/providers/open-id-start-sso-client-provider",
				"saml-start-sso-client-provider": Terrasoft.workspaceBaseUrl + "/core/hash/Terrasoft/utils/sso/providers/saml-start-sso-client-provider",
			},
			shim: {
				"ext-base": {
					exports: "Ext"
				}
			}
		});
	}

	require(["core-modules", "core-base"], function(coreModules, core) {
		const configurationModulesConfig = {};
		const requireBaseUrl = Terrasoft.loaderBaseUrl;
		core.setScope("login");
		core.init(coreModules, configurationModulesConfig, requireBaseUrl);
		Terrasoft.configuration = Terrasoft.configuration || {};
		Terrasoft.configuration.RootSchemaDescriptors = {
			loginModule: {
				"path": Terrasoft.loginModulePath,
				"less": ["loginModule"]
			}
		};
		core.setModuleDescriptors(Terrasoft.configuration.RootSchemaDescriptors);
		core.loadModule("loginModule");
	});
})();
