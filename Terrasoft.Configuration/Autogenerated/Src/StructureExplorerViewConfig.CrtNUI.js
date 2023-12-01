﻿define("StructureExplorerViewConfig", ["StructureExplorerViewConfigResources"], function(resources) {
	/**
	 * Class for StructureExplorerViewConfig.
	 */
	Ext.define("Terrasoft.configuration.StructureExplorerViewConfig", {
		extend: "Terrasoft.core.BaseObject",
		alternateClassName: "Terrasoft.StructureExplorerViewConfig",

		getContainerConfig: function(id) {
			return {
				className: "Terrasoft.Container",
				items: [],
				id: id,
				selectors: {
					wrapEl: "#" + id
				}
			};
		},

		getItemContainerConfig: function(id, index) {
			return {
				className: "Terrasoft.Container",
				items: [],
				id: id + index,
				selectors: {
					wrapEl: "#" + id + index
				},
				classes: {
					wrapClassName: ["itemContainer"]
				},
				styles: {
					wrapStyles: {
						margin: "18px 0px 0px " + (35 * index) + "px"
					}
				}
			};
		},

		generateMainView: function() {
			var viewConfig = this.getContainerConfig("autoGeneratedContainer");
			var headerConfig = this.getContainerConfig("header");
			var utilsConfig = this.getContainerConfig("utils");
			var leftPanelConfig = this.getContainerConfig("autoGeneratedLeftContainer");
			var bottomPanelConfig = this.getContainerConfig("autoGeneratedBottomContainer");
			var mainPanelConfig = this.getContainerConfig("autoGeneratedMainContainer");
			var firstItemConfig = this.getContainerConfig("firstItemConfig");
			var buttonsConfig = [];
			headerConfig.items = [
				{
					className: "Terrasoft.Label",
					markerValue: this.getHeaderCaption(),
					caption: this.getHeaderCaption(),
					classes: {
						labelClass: ["header-name"]
					},
					width: "auto"
				},
				{
					className: "Terrasoft.Button",
					caption: "",
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					imageConfig: resources.localizableImages.CloseIcon,
					markerValue: "closeButton",
					classes: {
						wrapperClass: ["close-btn-user-class"]
					},
					click: {
						bindTo: "onCancelClick"
					}
				}
			];
			var buttonConfig = {
				className: "Terrasoft.Button",
				margin: "0px 10px 0px 0px"
			};
			var firstButtonConfig = {
				caption: this.getSaveButtonCaption(),
				style: Terrasoft.controls.ButtonEnums.style.GREEN,
				click: {
					bindTo: "select"
				},
				markerValue: "select-button"
			};
			var cancelButton = Ext.apply({}, {
				style: Terrasoft.controls.ButtonEnums.style.DEFAULT,
				caption: resources.localizableStrings.CancelButtonText,
				click: {
					bindTo: "onCancelClick"
				},
				markerValue: "cancel-button"
			}, buttonConfig);
			buttonsConfig.push(Ext.apply({}, firstButtonConfig, buttonConfig));
			buttonsConfig.push(cancelButton);
			utilsConfig.items = [
				{
					className: "Terrasoft.Container",
					id: "utils-left",
					selectors: {
						wrapEl: "#utils-left"
					},
					items: buttonsConfig
				}
			];
			firstItemConfig.items = [{
				className: "Terrasoft.Container",
				id: "RootEntityContainer",
				selectors: {
					wrapEl: "#RootEntityContainer"
				},
				items: [{
					className: "Terrasoft.Container",
					id: "itemButtonsContainer",
					selectors: {
						wrapEl: "#itemButtonsContainer"
					},
					items: [{
						className: "Terrasoft.Button",
						visible: {
							bindTo: "ExpandVisible"
						},
						click: {
							bindTo: "expand"
						},
						markerValue: "addObject",
						imageConfig: resources.localizableImages.ExpandImage,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT
					}, {
						className: "Terrasoft.Button",
						visible: {
							bindTo: "RemoveVisible"
						},
						click: {
							bindTo: "close"
						},
						imageConfig: resources.localizableImages.CloseImage,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT
					}]
				}, {
					className: "Terrasoft.Label",
					caption: {
						bindTo: "caption"
					},
					classes: {
						labelClass: ["object-name"]
					},
					width: "auto"
				}]
			}];
			leftPanelConfig.items = [];
			bottomPanelConfig.visible = {
				bindTo: "IsBottomPanelVisible"
			};
			bottomPanelConfig.items = [
				{
					className: "Terrasoft.Label",
					caption: resources.localizableStrings.ItemsName
				}, {
					className: "Terrasoft.ComboBoxEdit",
					enabled: {
						bindTo: "ComboBoxListEnabled"
					},
					id: "itemComboBox",
					selectors: {
						wrapEl: "#itemComboBox"
					},
					keydown: {
						bindTo: "onKeyDown"
					},
					isRequired: true,
					value: {
						bindTo: "EntitySchemaColumn"
					},
					list: {
						bindTo: "EntitySchemaColumnList"
					},
					placeholder: resources.localizableStrings.ItemsPlaceHolder,
					prepareList: {
						bindTo: "getItems"
					},
					markerValue: resources.localizableStrings.ItemsName
				}
			];
			mainPanelConfig.items = [leftPanelConfig, bottomPanelConfig];
			viewConfig.items = [headerConfig, utilsConfig, firstItemConfig, mainPanelConfig];
			return viewConfig;
		},

		generateItemView: function(index) {
			var viewConfig = this.getItemContainerConfig("autoGeneratedContainer", index);
			viewConfig.items = [
				{
					className: "Terrasoft.Container",
					id: "itemButtonsContainer" + index,
					classes: {
						wrapClassName: ["expandCloseButtonsContainer"]
					},
					selectors: {
						wrapEl: "#itemButtonsContainer" + index
					},
					items: [{
						className: "Terrasoft.Button",
						tag: "ButtonExpand",
						enabled: {
							bindTo: "ExpandEnable"
						},
						visible: {
							bindTo: "ExpandVisible"
						},
						click: {
							bindTo: "expand"
						},
						imageConfig: resources.localizableImages.ExpandImage,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT
					}, {
						className: "Terrasoft.Button",
						tag: "ButtonClose",
						enabled: true,
						visible: {
							bindTo: "RemoveVisible"
						},
						click: {
							bindTo: "close"
						},
						imageConfig: resources.localizableImages.CloseImage,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT
					}]
				}, {
					className: "Terrasoft.Button",
					tag: "ButtonRemove",
					enabled: true,
					visible: {
						bindTo: "CloseVisible"
					},
					click: {
						bindTo: "remove"
					},
					classes: {
						wrapperClass: ["removeButton"]
					},
					imageConfig: resources.localizableImages.DeleteImage,
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT
				}, {
					className: "Terrasoft.Container",
					id: "elementContainer" + index,
					classes: {
						wrapClassName: ["elementContainer"]
					},
					selectors: {
						wrapEl: "#elementContainer" + index
					},
					items: {
						id: "schemaLookup" + index,
						className: "Terrasoft.ComboBoxEdit",
						enabled: {
							bindTo: "ComboBoxListEnabled"
						},
						visible: true,
						isRequired: true,
						readonly: false,
						value: {
							bindTo: "EntitySchemaColumn"
						},
						list: {
							bindTo: "EntitySchemaColumnList"
						},
						prepareList: {
							bindTo: "getItems"
						},
						change: {
							bindTo: "ComboBoxListChange"
						},
						classes: {
							wrapClass: ["itemCombobox"]
						},
						placeholder: resources.localizableStrings.ElementsPlaceHolder,
						markerValue: {
							bindTo: "getMarkerValue"
						}
					}
				}
			];
			return viewConfig;
		},

		//region Methods: Protected

		/**
		 * Gets structure explorer header caption.
		 * @protected
		 * @return {Object} Structure explorer header caption.
		 */
		getHeaderCaption: function() {
			return resources.localizableStrings.HeaderCaption;
		},

		/**
		 * Gets structure explorer header caption.
		 * @protected
		 * @return {Object} Structure explorer header caption.
		 */
		getSaveButtonCaption: function() {
			return resources.localizableStrings.SelectButtonText;
		}

		//endregion

	});
	return Terrasoft.StructureExplorerViewConfig;
});
