﻿define("ActivitySectionSchedulerViewModel", ["ext-base", "terrasoft", "BaseSectionGridRowViewModel",
		"ActivitySectionGridRowViewModel", "MeetingInvitationsMixin"],
	function(Ext, Terrasoft) {

		Ext.define("Terrasoft.configuration.ActivitySectionSchedulerViewModel", {
			extend: "Terrasoft.ActivitySectionGridRowViewModel",
			alternateClassName: "Terrasoft.ActivitySectionSchedulerViewModel",
			mixins: [
				 "Terrasoft.MeetingInvitationsMixin"
			],

			/**
			 * @inheritdoc Terrasoft.model.BaseViewModel#constructor
			 * @override
			 */
			constructor: function() {
				this.callParent(arguments);
				this.debounceSaveEntityFunc = Terrasoft.debounce(function(callback, scope) {
					this.canUserChangeMeeting(scope.$Id, () => {
						this.saveEntity(function(response) {
							if (response && response.success) {
								scope.$OldStartDate = null;
								scope.$OldDueDate = null;
							}
							Ext.callback(callback, scope, [response]);
							this.confirmInvitationsSending(scope.$Id);
						}, scope);
					}, () => {
						this.set("StartDate", scope.$OldStartDate);
						this.set("DueDate", scope.$OldDueDate);
					});
				 }, 500);
			},

			/**
			 * Start date on change event handler.
			 * @protected
			 * @param {Date} date New date value.
			 */
			onStartDateChanged: function(date) {
				if (!this.get("OldStartDate")) {
					this.set("OldStartDate", this.$StartDate);
				}
				this.callParent(arguments);
			},

			/**
			 * Due date on change event handler.
			 * @protected
			 * @param {Date} date New date value.
			 */
			onDueDateChanged: function(date) {
				if (!this.get("OldDueDate")) {
					this.set("OldDueDate", this.$DueDate);
				}
				this.callParent(arguments);
			},
	});
	return Terrasoft.ActivitySectionSchedulerViewModel;
 });
