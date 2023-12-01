﻿Terrasoft.configuration.Structures["BaseWidgetComponent"] = {innerHierarchyStack: ["BaseWidgetComponent"]};
   define("BaseWidgetComponent", [], function() {
	Ext.define("Terrasoft.controls.BaseWidgetComponent", {
		extend: "Terrasoft.controls.Component",
		alternateClassName: "Terrasoft.BaseWidgetComponent",

		widgetConfig: null,

		/**
		 * @inheritDoc
		 * @override
		 */
		tpl: null,
		
		/**
		 * @inheritDoc
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			Ext.apply(tplData, {
				widgetConfig: this.widgetConfig,
			});
			return tplData;
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getSelectors: function() {
			return {
				wrapEl: "#" + this.id + "-wrap",
				widgetEl: "#" + this.id
			};
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const widgetBindConfig = {
				widgetConfig: {
					changeMethod: "setWidgetConfig"
				}
			};
			Ext.apply(widgetBindConfig, bindConfig);
			return widgetBindConfig;
		},

		setWidgetConfig: function(widgetConfig) {
			if (!widgetConfig) {
				return;
			}
			this.widgetConfig = widgetConfig;
			if (this.rendered) {
				this.setElementConfig();
			}
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		onAfterRender: function() {
			this.callParent(arguments);
			if (this.widgetConfig) {
				this.setElementConfig();
			}
		},
		
		setElementConfig: function() {
			this.widgetEl.dom.config = Terrasoft.deepClone(this.widgetConfig);
		},

	});

	return Terrasoft.BaseWidgetComponent;

});


