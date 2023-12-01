define("CommunicationPanel", ["terrasoft"],
	function(Terrasoft) {
		return {
			messages: {},
			attributes: {},
			methods: {
				/**
				 * Defines whether current user is portal or not.
				 * @private
				 * @return {boolean} true - if current user is not portal user
				 */
				getIsNotPortalUser: function() {
					return !Terrasoft.isCurrentUserSsp();
				},
				/**
				 * Determines whether the current user will have access to the email panel
				 * @private
				 * @return {boolean} true - if current user has access to email panel
				 */
				getIsEmailAvailable: function() {
					return !Terrasoft.isCurrentUserSsp() && !Terrasoft.isCurrentUserDataInputRestricted();
				}
			},
			diff: [
				{
					"operation": "merge",
					"name": "email",
					"values": {
						"visible": {
							"bindTo": "getIsEmailAvailable"
						}
					}
				},
				{
					"operation": "merge",
					"name": "remindings",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "esnFeed",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "centerNotification",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "processDashboard",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				}
			]
		};
	});
