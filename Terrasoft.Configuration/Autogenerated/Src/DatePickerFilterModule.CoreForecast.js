define("DatePickerFilterModule", ["DatePickerFilterComponent"], function() {
	Ext.define("Terrasoft.configuration.DatePickerFilterModule", {
		extend: "Terrasoft.configuration.BaseModule",
		alternateClassName: "Terrasoft.DatePickerFilterModule",

		Ext: null,
		sandbox: null,
		Terrasoft: null,

		view: null,
		type: 0,
		messages: {

			/**
			 * @message SnapshotDateChanged
			 * On date changed on datepicker.
			 */
			"SnapshotDateChanged": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message ValidateDate
			 * Validate date from datepicker.
			 */
			"ValidateDate": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},

		/**
		 * Checks if date from datepicker is valid for displaying.
		 * @public
		 * @param {Date}  date Datepicker date.
		 * @returns {Boolean} Is date valid.
		 */
		validateDate: function(date) {
			return this.sandbox.publish("ValidateDate", date, [this.sandbox.id]);
		},

		/**
		 * @inheritdoc Terrasoft.BaseGridDetailV2#init
		 * @overridden
		 */
		init: function() {
			this.callParent(arguments);
			this.sandbox.registerMessages(this.messages);
		},

		/**
		 * Renders datetime picker to application.
		 * @param {Object} renderTo Element to rendering.
		 * @private
		 */
		_renderDatePickerFilter: function(renderTo) {
			this.view = Ext.create("Terrasoft.DatePickerFilterComponent", {
				type: this.type,
				filterFunction: this.validateDate.bind(this),
				dateChanged: { "bindTo": "onDateChanged" },
			});
			this.view.bind(this);
			this.view.render(renderTo);
		},

		onDateChanged: function(date) {
			this.sandbox.publish("SnapshotDateChanged", date, [this.sandbox.id]);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#render
		 * @override
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			if (!renderTo.dom) {
				renderTo = Ext.get(renderTo.id);
			}
			this._renderDatePickerFilter(renderTo);
		},

		/**
		 * @inheritDoc Terrasoft.BaseModule#destroy
		 * @override
		 */
		destroy: function() {
			if (this.view) {
				this.view.destroy();
			}
			this.callParent(arguments);
		}

	});

	return Terrasoft.DatePickerFilterModule;

});
