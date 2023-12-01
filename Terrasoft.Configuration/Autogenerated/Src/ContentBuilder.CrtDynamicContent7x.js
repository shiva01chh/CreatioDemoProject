﻿define("ContentBuilder", ["ModalBox", "MacrosModule", "ContainerListGenerator", "ContainerList",
	"ContentPreviewBlock", "ContentBuilderHelper", "MacrosUtilities", "css!DynamicContentBuilderCSS"],
function() {
	return {
		messages: {

			"GetDynamicContentEnabled": {
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE,
				mode: Terrasoft.MessageMode.PTP
			}
		},
		attributes: {

			/**
			 * State of dynamic content functionality.
			 */
			"DynamicContentEnabled": {
				"dataValueType": Terrasoft.core.enums.DataValueType.BOOLEAN,
				"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN,
				"value": false
			},

			"Attributes": {
				"dataValueType": Terrasoft.core.enums.DataValueType.COLLECTION,
				"type": Terrasoft.core.enums.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		methods: {

			/**
			 * @inheritdoc BaseContentItemViewModel#serializableSlicePropertiesCollection
			 * @override
			 */
			extendSerializableSlicePropertiesCollection: function() {
				this.serializableSlicePropertiesCollection =
					this.serializableSlicePropertiesCollection.concat(["Attributes"]);
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc ContentBuilder#subscribeMessages
			 * @override
			 */
			subscribeMessages: function() {
				this.callParent(arguments);
				this.sandbox.subscribe("GetDynamicContentEnabled", this.isDynamicContentEnabled, this);
			},

			/**
			 * Returns state of dynamic content functionality.
			 * @protected
			 * @virtual
			 */
			isDynamicContentEnabled: function() {
				return this.$DynamicContentEnabled;
			}
		},
		diff: []
	};
});
