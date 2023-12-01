define("MultipleEmailInput", ["MultipleInput"], function() {
	Ext.define("Terrasoft.controls.MultipleEmailInput", {
		extend: "Terrasoft.MultipleInput",
		alternateClassName: "Terrasoft.MultipleEmailInput",

		/**
		 * @inheritdoc Terrasoft.MultipleInput#inputWrapElFocused.
		 * @override
		 */
		inputWrapElFocused: "base-edit-focus",

		/**
		 * @inheritdoc Terrasoft.Component#initDomEvents
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			this.inputEl.on("keydown", this.onInputElKeyDown, this);
		},

		/**
		 * @inheritdoc Terrasoft.Component#clearDomListeners
		 * @override
		 */
		clearDomListeners: function() {
			this.inputEl.un("keydown", this.onInputElKeyDown, this);
			this.callParent(arguments);
		},

		/**
		 * The "key pressed" event handler in the input field of the control.
		 * @protected
		 */
		onInputElKeyDown: function(e) {
			var key = e.getKey();
			if (key === e.ESC) {
				e.preventDefault();
				e.stopPropagation();
				this.inputEl.dom.value = "";
				this.inputEl.dom.blur();
			}
		},

		/**
		 * @inheritdoc Terrasoft.MultipleInput#onInputElBlur.
		 * @override
		 */
		onInputElBlur: function(e) {
			e.preventDefault();
			e.stopPropagation();
			this.callParent(arguments);
		}
	});
});
