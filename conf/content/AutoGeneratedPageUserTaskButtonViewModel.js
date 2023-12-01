﻿Terrasoft.configuration.Structures["AutoGeneratedPageUserTaskButtonViewModel"] = {innerHierarchyStack: ["AutoGeneratedPageUserTaskButtonViewModel"]};
define("AutoGeneratedPageUserTaskButtonViewModel", ["AutoGeneratedPageUserTaskButtonViewModelResources",
	"ProcessUserTaskConstants", "ProcessMiniEditPageMixin"
], function(resources, processUserTaskConstants) {

	/**
	 * Model button for the autogenerated page user task.
	 */
	Ext.define("Terrasoft.model.AutoGeneratedPageUserTaskButtonViewModel", {
		extend: "Terrasoft.BaseModel",
		alternateClassName: "Terrasoft.AutoGeneratedPageUserTaskButtonViewModel",

		Ext: null,
		Terrasoft: null,

		mixins: {
			processMiniEditPageMixin: "Terrasoft.ProcessMiniEditPageMixin"
		},

		columns: {
			"Id": {
				"dataValueType": Terrasoft.DataValueType.GUID
			},
			"Caption": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"Name": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"GenerateSignal": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"IsEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true
			},
			"PerformValidation": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"Style": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"value": {
					"value": Terrasoft.controls.ButtonEnums.style.DEFAULT,
					"displayValue": Terrasoft.Resources.Controls.Button.ButtonStyleDefault
				}
			},
			"StyleCollection": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION
			},
			"Enabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"Visible": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true
			},
			"ParameterEditToolsButtonMenu": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION,
				"value": Ext.create("Terrasoft.BaseViewModelCollection")
			},
			"IsValid": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			/**
			 * Parent module instance.
			 */
			"ParentModule": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
			}
		},

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseModel#constuctor
		 * @protected
		 */
		constructor: function() {
			this.callParent(arguments);
			this.initStyleCollection();
		},

		/**
		 * Initialize style collection.
		 * @protected
		 */
		initStyleCollection: function() {
			var styleCollection = Ext.create("Terrasoft.Collection");
			var buttonStyles = Terrasoft.controls.ButtonEnums.style;
			Terrasoft.each(buttonStyles, function(code) {
				if (code === buttonStyles.GREY) {
					return;
				}
				var item = this.getStyle(code);
				styleCollection.add(code, item);
			}, this);
			this.set("StyleCollection", styleCollection);
		},

		/**
		 * Convert server object to view model attributes.
		 * @protected
		 * @param {Object} values Object.
		 */
		convertServerObjectToViewModelAttributes: function(values) {
			this.set("Id", values.Id);
			this.set("IsEnabled", values.isEnabled);
			this.set("PerformValidation", values.performValidation);
			this.set("Caption", values.caption);
			this.set("Name", values.name);
			this.set("Style", this.getStyle(values.style));
			this.set("GenerateSignal", values.generateSignal);
			this.set("Enabled", values.enabled);
			this.set("ParentCollection", this.parentCollection);
		},

		/**
		 * Returns style value and display value by enum value.
		 * @protected
		 * @param {String} style Style.
		 * @return {Object} Value and display value style.
		 */
		getStyle: function(style) {
			var styleEnum = Terrasoft.controls.ButtonEnums.style;
			if (_.values(styleEnum).indexOf(style) === -1) {
				style = styleEnum.DEFAULT;
			}
			return {
				value: style,
				displayValue: Terrasoft.Button.getStyleCaption(style)
			};
		},

		/**
		 * Convert view model attributes to server object.
		 * @protected
		 * @return {Object} Server style object.
		 */
		convertViewModelAttributesToServerObject: function() {
			var style = this.get("Style") ? this.get("Style").value : null;
			var obj = {
				$type: processUserTaskConstants.SERVER_GENERIC_DICTIONARY,
				Id: this.get("Id"),
				isEnabled: this.get("IsEnabled"),
				performValidation: this.get("PerformValidation"),
				caption: this.get("Caption"),
				name: this.get("Name"),
				style: style,
				generateSignal: this.get("GenerateSignal")
			};
			return obj;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getProcessMiniEditPageName
		 * @protected
		 */
		getProcessMiniEditPageName: function() {
			return "AutoGeneratedPageUserTaskButtonMiniEditPage";
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getActiveItemEditName
		 * @protected
		 */
		getActiveItemEditName: function() {
			return "ProcessButtonEditName";
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getProcessMiniEditPageId
		 * @protected
		 */
		getProcessMiniEditPageId: function() {
			return this.sandbox.id + "buttonedit";
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getAddButtonEnabledProperyName
		 * @protected
		 */
		getAddButtonEnabledProperyName: function() {
			return "IsButtonToolsButtonEnabled";
		},

		/**
		 * Returns marker value for button.
		 * @protected
		 * @return {String} markerValue of button.
		 */
		getMarkerValue: function() {
			var caption = this.get("Caption");
			var parentCollection = this.parentCollection;
			var currentIndex = parentCollection.indexOf(this);
			var markerValue = Ext.String.format("{0}-{1}", caption, currentIndex);
			return markerValue;
		}

		//endregion
	});

	return Terrasoft.AutoGeneratedPageUserTaskButtonViewModel;
});


