define("login-view-utils", ["ext-base", "terrasoft", "user-agent"], function(Ext, Terrasoft) {
	return {
		/**
		 * Creates login table container.
		 * @param {String} idName container id.
		 */
		createTableContainer: function(idName) {
			return Ext.create("Terrasoft.Container", {
				id: idName,
				selectors: {
					wrapEl: "#" + idName
				},
				classes: {
					wrapClassName: ["login-table-container"]
				}
			});
		},
		/**
		 * Creates login container for row of inputs and messages.
		 * @param {String} idName container id.
		 */
		createRowContainer: function(idName) {
			return Ext.create("Terrasoft.Container", {
				id: idName,
				selectors: {
					wrapEl: "#" + idName
				},
				classes: {
					wrapClassName: ["login-row-container"]
				}
			});
		},
		/**
		 * Creates login container for inputs and messages.
		 * @param {String} idName container id.
		 */
		createCellContainer: function(idName) {
			return Ext.create("Terrasoft.Container", {
				id: idName,
				selectors: {
					wrapEl: "#" + idName
				},
				classes: {
					wrapClassName: ["login-cell-container"]
				}
			});
		},
		/**
		 * Creates label with login page styles.
		 * @param {String} caption label text.
		 */
		createLabel: function(caption) {
			return Ext.create("Terrasoft.Label", {
				caption: caption,
				classes: {
					labelClass: ["login-info-label"]
				}
			});
		},

		/**
		 * Creates container for unsupported browser message.
		 * @return {Terrasoft.Container} Unsupported browser message container.
		 */
		createUnsupportedBrowserContainer: function() {
			const unsupportedBrowserMessage = Ext.create("Terrasoft.Container", {
				classes: {
					wrapClassName: ['message']
				},
				items: [
					Ext.create("Terrasoft.HtmlControl", {
						htmlContent: Terrasoft.Resources.LoginPage.UnsupportedBrowserMessage,
					}),
				]
			});
			return Ext.create("Terrasoft.Container", {
				classes: {
					wrapClassName: ['unsupported-browser']
				},
				items:[unsupportedBrowserMessage],
				visible: false,
			});
		},

		/**
		 * Checks supporting current browser.
		 * @return {Boolean} True if current browser is unsupported.
		 */
		checkIsBrowserUnsupported: function() {
			const unsupportedBrowserInfo = window.unsupportedBrowserInfo || {visible: true};
			if (unsupportedBrowserInfo.visible === false) {
				return false;
			}
			return Terrasoft.utils.UserAgent.isBrowserSupported() === false;
		}
	}
});
