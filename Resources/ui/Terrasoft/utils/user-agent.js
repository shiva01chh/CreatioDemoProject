Ext.define("Terrasoft.utils.UserAgent", {
	singleton: true,
	_supportedBrowsers: {
		chrome: '84',
		firefox: '80',
		safari: '12',
		'mobile safari': '12',
		edge: '84',
		yandex: '19',
		'webkit': '604',
		'chrome webview': '84'
	},

	/**
	 * @return {Boolean} True if browser is supported.
	 */
	isBrowserSupported: function() {
		let userAgent = null;
		if (window?.UAParser) {
			userAgent = new window.UAParser();
		}
		const browser = userAgent?.getBrowser();
		if (!browser) {
			return false;
		}
		const currentBrowserName = browser.name.toLowerCase();
		const currentBrowserMajorVersion = browser.major;
		const minSupportedBrowserVersion = this._supportedBrowsers[currentBrowserName];
		if (!minSupportedBrowserVersion) {
			return false;
		}
		return parseFloat(currentBrowserMajorVersion) >= parseFloat(minSupportedBrowserVersion);
	},
});
