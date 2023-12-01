﻿/**
 * ############### ###### ### ###### # ########.
 */
define("IconHelper", ["ext-base", "terrasoft"], function(Ext, Terrasoft) {

		/**
		 * ####### ############ ###### # #######.
		 * @param config {Object} ############ ###### # #######.
		 * @return {Object} ########## ############ ###### # #######.
		 */
		var createIconButtonConfig = function(config) {
			var buttonConfig = {
				id: "view-button-" + config.name,
				selectors: {
					wrapEl: "#view-button-" + config.name
				},
				tag: config.name,
				hint: config.hint,
				markerValue: config.name,
				className: "Terrasoft.Button",
				style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
				iconAlign: Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
				pressed: {bindTo: config.name + "Active"},
				click: {bindTo: config.func ? config.func : "onViewButtonClick"},
				classes: {
					imageClass: ["view-images-class"],
					pressedClass: ["pressed-button-view"],
					wrapperClass: config.wrapperClass
				}
			};
			if (config.imageClass) {
				buttonConfig.classes.imageClass.push(config.imageClass);
			}
			return buttonConfig;
		};

		return {
			createIconButtonConfig: createIconButtonConfig
		};
	});
