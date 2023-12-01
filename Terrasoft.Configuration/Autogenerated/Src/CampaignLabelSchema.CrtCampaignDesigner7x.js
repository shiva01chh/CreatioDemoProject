 Ext.define("Terrasoft.manager.CampaignLabelSchema", {
	extend: "Terrasoft.manager.ProcessLabelSchema",
	alternateClassName: "Terrasoft.CampaignLabelSchema",

	/**
	 * @type {String}
	 */
	description: null,

	/**
	 * @type {Boolean}
	 */
	isDescription: false,

	/**
	 * @inheritdoc Terrasoft.manager.BaseSchema#getSerializableProperties
	 * @override
	 */
	getSerializableProperties: function() {
		var baseSerializableProperties = this.callParent(arguments);
		return Ext.Array.push(baseSerializableProperties, ["description"]);
	}

});
