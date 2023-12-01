/**
 * Prepares current page to loading a bootstrap module (that should be specified in 'data-loadbootstrap' attribute)
 * and loads this module.
 */
(function() {
	const baseUrl = getBaseUrl();
	let coreResourcesPath;
	let cacheBustingQueryString;

	/**
	 * Returns script HTML-element of bootstrap loader.
	 */
	function getBootstrapLoaderScriptElement() {
		const script = document.querySelector("script[data-loadbootstrap]");
		if (!script) {
			throw "Please specify 'data-loadbootstrap' attribute!";
		}
		return script;
	}

	/**
	 * Returns value of "data-" attribute which was specified in bootstrap loader script element.
	 * @param attributeName Name of the attribute, without "data-" prefix.
	 * @returns {string} Value of the attribute.
	 */
	function getBootstrapLoaderScriptDataAttribute(attributeName) {
		const script = getBootstrapLoaderScriptElement();
		return script.getAttribute("data-" + attributeName);
	}

	/**
	 * Returns base URL that is used for all script/style tags and requests.
	 * @returns {string} Base URL of the application with a trailing slash.
	 */
	function getBaseUrl() {
		return (getBootstrapLoaderScriptDataAttribute("baseurl") || "") + "/";
	}

	/**
	 * Returns URL of the endpoint that should be used for loading of additional client scripts from the server.
	 */
	function getClientScriptEndpointUrl() {
		const prefix = document.cookie.match(new RegExp('(^| )' + 'UserType' + '=([^;]+)'))?.[2] === 'SSP' ? 'ssp/' : '';
		const defaultEndpointPrefix = `${prefix}ServiceModel/ClientScriptService.svc`;
		const defaultEndpointMethod = "GenerateLoginScripts";
		const endpointPrefix =
			getBootstrapLoaderScriptDataAttribute("clientscriptendpointprefix") || defaultEndpointPrefix;
		const endpointMethod =
			getBootstrapLoaderScriptDataAttribute("clientscriptendpoint") || defaultEndpointMethod;
		return baseUrl + endpointPrefix + '/' + endpointMethod;
	}

	/**
	 * Builds query string with a unique file version identifier to tell the browser that a new version of the file is available.
	 * @param {String} cacheBustingQueryParam Value of the parameter to be used in the cache busting string.
	 */
	function buildCacheBustingQueryString(cacheBustingQueryParam) {
		return "v=" + cacheBustingQueryParam;
	}

	/**
	 * Appends 'script' tag for JS-file with specified source URL to current position in HTML.
	 * @param {String} url URL of script source file.
	 * @param {String} [customCacheBustingQueryParam] Value of the parameter to be used in the cache busting string instead of default value.
	 * @return {HTMLScriptElement} Script element.
	 */
	function appendScriptWithUrl(url, customCacheBustingQueryParam) {
		const script = document.createElement("script");
		script.type = "text/javascript";
		script.src = url + "?" + (customCacheBustingQueryParam
			? buildCacheBustingQueryString(customCacheBustingQueryParam)
			: cacheBustingQueryString);
		document.head.appendChild(script);
		return script;
	}

	/**
	 * Appends 'link' tag for CSS-file with specified source URL to current position in HTML.
	 * @param {String} url URL of CSS source file.
	 */
	function appendCssLinkWithUrl(url) {
		const link = document.createElement("link");
		link.type = "text/css";
		link.rel = "stylesheet";
		link.href = url + "?" + cacheBustingQueryString;
		document.head.appendChild(link);
		return link;
	}

	/**
	 * Waits for loading of specified HTML elements and calls callback function after it.
	 * @param {Array} elements Array of loading HTML elements.
	 * @param {Function} callback The function to be called after finishing loading.
	 */
	function onLoadAll(elements, callback) {
		let elementsToLoad = elements.length;
		if (!elementsToLoad) {
			callback();
		}
		elements.forEach(function(element) {
			element.onload = function() {
				elementsToLoad--;
				if (elementsToLoad === 0) {
					callback();
					return;
				}
			}
		});
	}

	/**
	 * Builds full path of core resource file.
	 * @param {String} resourceRelativePath Relative path of core resource file.
	 */
	function buildCoreResourceUrl(resourceRelativePath) {
		return coreResourcesPath + resourceRelativePath;
	}

	/**
	 * Receives URL of bootstrap file to load.
	 */
	function getLoadBootstrapUrl() {
		const bootstrapModulesPath = "Terrasoft/amd/";
		return buildCoreResourceUrl(bootstrapModulesPath + getBootstrapLoaderScriptDataAttribute("loadbootstrap"));
	}

	/**
	 * Configures RequireJs by initial modules before loading bootstrap module.
	 */
	function configureRequireJs() {
		const jQueryPath = Terrasoft?.scriptVersionPath?.jQuery || "jQuery/jQuery-3.5.1";
		const requirePathsConfig = {
			"configuration-loader": "Terrasoft/amd/configuration-loader",
			"configuration-bootstraps": "Terrasoft/amd/configuration-bootstraps",
			"require-config": "Terrasoft/amd/require-config",
			"require-url-config": "Terrasoft/amd/require-url-config",
			"core-base": "Terrasoft/amd/core-base",
			"bootstrap": "Terrasoft/amd/bootstrap",
			"performanceLogger": "Terrasoft/amd/performanceLogger",
			"performancecountermanager": "Terrasoft/amd/performancecountermanager",
			"crtrxjs": "Terrasoft/amd/crtrxjs",
			"process-designer-component": "Terrasoft/designers/process-designer-component/main",
			"voice-to-text-component": "Terrasoft/controls/mixins/voice-to-text-button/main",
			"jQuery": jQueryPath,
			"jQuery-easing": "jQueryEasing/jQuery-easing",
			"jsrender": "jsrender/jsrender",
			"ts-diagram-require-configurator": "ts-diagram-module/ts-diagram-require-configurator",
			"ts-common-all": "ts-diagram-module/ts-common-all",
			"ts-diagram": "ts-diagram-module/ts-diagram",
			"process-schema-diagram": "Terrasoft/designers/process-schema-designer/process-schema-diagram",
			"process-schema-diagram-5x": "Terrasoft/designers/process-schema-designer/process-schema-diagram-5x",
			"ckeditor-base": "CKEditor/ckeditor",
			"html2canvas": "html2canvas/html2canvas",
			"classList-shim": "normalize/classList-shim",
			"pathSeg-polyfill": "normalize/pathSeg-polyfill",
			"login-view-utils": "Terrasoft/amd/login-view-utils",
			"ssoutils": "Terrasoft/utils/sso/ssoutils",
			"open-id-start-sso-client-provider": "Terrasoft/utils/sso/providers/open-id-start-sso-client-provider",
			"saml-start-sso-client-provider": "Terrasoft/utils/sso/providers/saml-start-sso-client-provider",
			"login-model-utils": "Terrasoft/amd/login-model-utils",
			"two-factor-auth-utils": "Terrasoft/utils/two-factor-auth/two-factor-auth-utils",
			"chartjs": "ng-core/src/chartjs",
			"chartjs-label": "Chartjs/chartjs-plugin-labels",
			"chartjs-defaults": "Chartjs/chartjs-defaults",
			"chartjs-funnel": "ng-core/src/chartjs-funnel-plugin",
			"chartjs-gauge": "Chartjs/Gauge",
			"ng-core": "ng-core/src/main",
			"ng-scripts": "ng-core/src/scripts",
			"ng-polyfills": "ng-core/src/polyfills",
			"ng-polyfill-webcomp": "ng-core/src/polyfill-webcomp",
			"numeral": "Numeral/numeral.min",
			"user-agent": "Terrasoft/utils/user-agent",
			"user-agent-parser": "user-agent-parser/user-agent-parser.min",
			"@creatio-devkit/common": "creatio-devkit-common/creatio-devkit-common.umd",
			"@creatio/sdk": "creatio-devkit-common/creatio-sdk.umd",
			"@creatio/utils": "creatio-utils/creatio-utils.umd"
		};
		Object.keys(requirePathsConfig).forEach(function(key) {
			let requiredPath = requirePathsConfig[key];
			if (Terrasoft.scriptVersionPath && Terrasoft.scriptVersionPath[key]) {
				requiredPath = Terrasoft.scriptVersionPath[key];
			}
			requirePathsConfig[key] = buildCoreResourceUrl(requiredPath);
		});
		requirePathsConfig["loadbootstrap"] = getLoadBootstrapUrl();
		requirejs.config({
			paths: requirePathsConfig,
			shim: {
				"jQuery-easing": { "deps": ["jQuery"] },
				"ts-common-all": { "deps": ["jQuery-easing", "ts-diagram-require-configurator"] },
				"ts-diagram": { "deps": ["ts-common-all", "jsrender"] },
				"voice-to-text-component": { "deps": ["ng-core"] },
				"process-designer-component": { "deps": ["ng-core"] },
				"process-schema-diagram": { "deps": ["ts-diagram"] },
				"process-schema-diagram-5x": { "deps": ["process-schema-diagram"] },
				"loadbootstrap": { "deps": ["classList-shim", "pathSeg-polyfill", "jQuery"] },
				"chartjs-label": { "deps": ["chartjs"] },
				"chartjs-defaults": { "deps": ["chartjs-label"] },
				"chartjs-funnel": { "deps": ["chartjs"] },
				"chartjs-gauge": { "deps": ["chartjs"] },
				"ng-core": { "deps": ["ng-scripts"] },
				"ng-scripts": { "deps": ["ng-polyfills", "ng-polyfill-webcomp"] },
				"user-agent": { "deps": [ "user-agent-parser" ] },
				"@creatio/utils": { "deps": [ "@creatio-devkit/common" ] },
			},
			map: {
				'*': {
					'ej-diagram': 'ts-diagram'
				}
			},
			urlArgs: cacheBustingQueryString,
			baseUrl: baseUrl
		});
	}
	
	function loadInDebugMode() {
		const requireUrl = baseUrl + buildCoreResourceUrl("requirejs/require.js");
		appendScriptWithUrl(requireUrl).onload = () => {
			const coreUrl = baseUrl + coreResourcesPath;
			requirejs.config({
				baseUrl: coreUrl + "Terrasoft/amd/"
			});
			Terrasoft.scriptVersionPath = {jQuery: "jQuery-3.5.1"};
			require([coreUrl + "Terrasoft/amd/bootstrap.configuration.js"], () => {});
		};
	}

	function getIsRtlMode () {
		const resources = Terrasoft.Resources;
		const cultureSettings = resources && resources.CultureSettings;
		const isRtlMode = cultureSettings && cultureSettings.isRightToLeft;
		return Boolean(isRtlMode);
	}

	function loadInReleaseMode() {
		const nameCssFile = getIsRtlMode()
			? "combined/all-combined-rtl.css"
			: "combined/all-combined.css";
		onLoadAll([
			appendCssLinkWithUrl(baseUrl + buildCoreResourceUrl(nameCssFile)),
			appendScriptWithUrl(baseUrl + buildCoreResourceUrl("combined/all-combined.js"))
		],  () => {
			const requireUrl = baseUrl + buildCoreResourceUrl("requirejs/require.js");
			appendScriptWithUrl(requireUrl).onload = () => {
				configureRequireJs();
				require(["loadbootstrap"], () => {});
			};
		});
	}

	appendScriptWithUrl(getClientScriptEndpointUrl(), Date.now().toString()).onload = function() {
		if (!window.Terrasoft) {
			throw "The global object 'Terrasoft' is not initialized yet, the page can not be loaded."
		}
		coreResourcesPath = Terrasoft.coreModulesPath || "";
		cacheBustingQueryString = buildCacheBustingQueryString(Terrasoft.coreVersion || "0.0.0.0");
		if (Terrasoft.isDebug) {
			loadInDebugMode();
		} else {
			loadInReleaseMode();
		}
	};
})();
