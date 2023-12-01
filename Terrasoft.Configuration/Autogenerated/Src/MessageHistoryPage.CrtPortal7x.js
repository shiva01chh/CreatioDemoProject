 define("MessageHistoryPage", [],
	function() {
		return {
			methods: {
				
				/**
				 * @private
				 */
				_getHasVisibleMessagesConfig: function() {
					var caseId = this.get("relationEntityId");
					const config = {
						serviceName: "CasePortalService",
						methodName: "IsCaseHasVisibleMessages",
						scope: this,
						data: {
							caseId: caseId
						}
					};
					return config;
				},
				
				/**
				 * @inheritdoc Terrasoft.MessageHistoryPage#loadInitialHistoryMessages
				 * @overridden
				 */
				loadInitialHistoryMessages: function() {
					this.callParent(arguments);
					if (this.Terrasoft.isCurrentUserSsp()) {
						var config = this._getHasVisibleMessagesConfig();
						this.callService(config, function (hasVisibleMessages) {
							if (!hasVisibleMessages) {
								var historyBySectionFilter = this.get("historyBySectionFilter");
								var initMessageCount = this.get("InitMessageCount") * 2;
								this.loadMessages(initMessageCount, historyBySectionFilter);
							}
						});
					}
				},
			},
			diff: []
		};
	}
);