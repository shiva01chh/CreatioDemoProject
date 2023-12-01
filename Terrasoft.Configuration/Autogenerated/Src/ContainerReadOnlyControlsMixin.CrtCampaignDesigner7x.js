define("ContainerReadOnlyControlsMixin", [""], function() {
	Ext.define("Terrasoft.configuration.mixins.ContainerReadOnlyControlsMixin", {
		alternateClassName: "Terrasoft.ContainerReadOnlyControlsMixin",

		/**
		 * @private
		 */
		_processControls: function(component, isEnabled) {
			if (!component) {
				return;
			}
			component.setEnabled(isEnabled);
			Terrasoft.each(component.items, function(item) {
				this._processControls(item, isEnabled);
			}, this);
		},

		/**
		 * Actualizes component's controls readonly state.
		 * @public
		 * @param {Boolean} isReadOnly Flag for controls state.
		 * @param {String} containerId Component container id.
		 */
		setControlsReadOnly: function(isReadOnly, containerId) {
			var component = Ext.getCmp(containerId);
			this._processControls(component, !isReadOnly);
		}
	});
});
