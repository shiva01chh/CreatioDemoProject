define("NavigationModule", [
	"ext-base",
	"terrasoft",
	"sandbox",
	"ConfigurationConstants"
], function(Ext, Terrasoft, sandbox, { ModuleAliases }) {
	var router = Terrasoft.router.Router;
	let _currentHistoryState, _previousHistoryStates;
	let _isInitialized = false;

	function init() {
		if (!_isInitialized) {
			router.on("stateChanged", onRouterStateChanged, router);
			sandbox.subscribe("PushHistoryState", onPushHistoryState);
			sandbox.subscribe("ReplaceHistoryState", onReplaceHistoryState);
			sandbox.subscribe("GetHistoryState", onGetHistoryState);
			sandbox.subscribe("BackHistoryState", onBackHistoryState);
			sandbox.subscribe("ForwardHistoryState", onForwardHistoryState);
			sandbox.subscribe("GetPreviousHistoryState", () => _previousHistoryStates);
			onRouterStateChanged();
			sandbox.publish("NavigationModuleLoaded");
			_isInitialized = true;
		}
	}

	function onReplaceHistoryState(historyState) {
		const hash = replaceModuleNameWithAlias(historyState.hash);
		router.replaceState(historyState.stateObj, historyState.pageTitle, hash, historyState.silent);
	}

	function onRouterStateChanged() {
		const history = onGetHistoryState();
		_previousHistoryStates = _currentHistoryState;
		_currentHistoryState = history;
		sandbox.publish("HistoryStateChanged", history);
	}

	/**
	 * ########## ######### ######### ####### ########.
	 * ######## ####### ####### ########## ##### ###### ####### # ########## # ie ###### 9
	 * @returns {Object} ######### ######### ####### ########
	 */
	function onGetHistoryState() {
		var hash = router.getHash();
		if (hash.charAt(0) === "/") {
			hash = hash.slice(1);
		}
		hash = replaceAliasWithModuleName(hash);
		var history = {
			state: router.getState(),
			hash: splitHistoryState(hash)
		};
		return history;
	}

	function splitHistoryState(historyState) {
		var params = historyState.split("?")[0].split("[")[0].split("/");
		var history = {};
		history.historyState = historyState;
		history.moduleName = params[0];
		history.entityName = params[1];
		history.operationType = params[2];
		var paramExtra = 3;
		if (params.length > 4 && history.operationType !== "add") {
			paramExtra = 4;
			if (params[3]) {
				history.recordId = params[3];
			}
		}
		if (params.length > 4) {
			var valuePairs = (params.length - paramExtra) / 2;
			history.valuePairs = [];
			for (var i = 0; i < valuePairs; i++) {
				var index = paramExtra + i * 2;
				history.valuePairs[i] = {
					name: params[index],
					value: params[index + 1]
				};
			}
		} else if (params[3]) {
			history.recordId = params[3];
		}
		return history;
	}

	function onPushHistoryState(historyState) {
		var result = sandbox.publish("BeforeHistoryChanging", historyState);
		const hash = replaceModuleNameWithAlias(historyState.hash);
		if (Ext.isEmpty(result) || result) {
			router.pushState(historyState.stateObj, historyState.pageTitle, hash, historyState.silent);
		}
		if (historyState.silent === true) {
			sandbox.publish("RefreshCacheHash");
		}
	}

	function onBackHistoryState() {
		router.back();
	}

	function onForwardHistoryState() {
		router.forward();
	}

	function replaceModuleNameWithAlias(hash) {
		const hashParts = hash.split('/');
		hashParts[0] = ModuleAliases[hashParts[0]] || hashParts[0];
		return hashParts.join('/');
	}

	function replaceAliasWithModuleName(hash) {
		const hashParts = hash.split('/');
		hashParts[0] = getModuleNameByAlias(hashParts[0]) || hashParts[0];
		return hashParts.join('/');
	}

	function getModuleNameByAlias(moduleAlias) {
		for (const moduleName in ModuleAliases) {
			const alias = ModuleAliases[moduleName];
			if (alias === moduleAlias) {
				return moduleName;
			}
		}
		return null;
	}

	return {
		"init": init
	};
});
