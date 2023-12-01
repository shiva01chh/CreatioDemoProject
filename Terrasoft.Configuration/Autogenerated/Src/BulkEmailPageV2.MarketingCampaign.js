define("BulkEmailPageV2", ["BusinessRuleModule", "MarketingEnums", "BulkEmailHelper", "MarketingCommonUtilities"],
		function(BusinessRuleModule, MarketingEnums, BulkEmailHelper, MarketingCommonUtilities) {
			return {
				entitySchemaName: "BulkEmail",
				details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
				messages: {
					/**
					 * @message ReloadBulkEmailQueueState
					 */
					"ReloadBulkEmailQueueState": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.SUBSCRIBE
					}
				},
				attributes: {
					"IsSystemEmailEnabled": {
						type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: Terrasoft.DataValueType.BOOLEAN,
						dependencies: [
							{
								columns: ["IsSystemEmail"],
								methodName: "showDisclaimerSystemEmail"
							}
						]
					},
					/**
					 * Caption with actual bulk email queue info.
					 * @type {String}
					 */
					"QueueTasksCaption": {
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: this.Terrasoft.DataValueType.TEXT
					},
					/**
					 * Bulk email queue is empty for current email.
					 * @type {Array}
					 */
					"IsQueueEmpty": {
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
						value: false
					}
				},
				methods: {
					/**
					 * @inheritDoc BasePageV2#onEntityInitialized
					 * @overridden
					 */
					onEntityInitialized: function() {
						this.callParent(arguments);
						this.processLaunchOptionColumn();
						this.on("change:LaunchOption", function() {
							this.processLaunchOptionColumn();
						}, this);
						this.checkIgnoreUnsubscribe();
						this.reloadBulkEmailQueueTasks();
					},

					/**
					 * @inheritdoc Terrasoft.BaseBulkEmailPageV2#subscribeMessages
					 * @override
					 */
					subscribeMessages: function() {
						this.sandbox.subscribe("ReloadBulkEmailQueueState", this.reloadBulkEmailQueueTasks, this);
						this.callParent(arguments);
					},

					/**
					 * Sets the availability of SystemEmail checkbox.
					 * @protected
					 */
					checkIgnoreUnsubscribe: function() {
						Terrasoft.SysSettings.querySysSettings(["SystemEmailIgnoreUnsubscribeFromAllMailings"],
							function(settings) {
									var isIgnoreUnsubscribe = settings.SystemEmailIgnoreUnsubscribeFromAllMailings;
									this.set("IsSystemEmailEnabled", isIgnoreUnsubscribe);
								}, this);
					},

					/**
					 * Verification of enabling of system email.
					 * @protected
					 */
					showDisclaimerSystemEmail: function() {
						var isSysEmailValue = this.get("IsSystemEmail");
						if (isSysEmailValue === false) {
							return;
						}
						this.showConfirmationDialog(this.get("Resources.Strings.DisclaimerSystemEmail"),
							function(returnCode) {
								if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
									return;
								}
								this.set("IsSystemEmail", false);
							},
							[ this.Terrasoft.MessageBoxButtons.YES,
								this.Terrasoft.MessageBoxButtons.NO]
						);
					},

					/**
					 * Sets default settings.
					 * @overriden
					 */
					setDefaultEmailValues: function() {
						this.callParent(arguments);
						if (!this.isCopyMode()) {
							this.loadLookupDisplayValue("LaunchOption",
								MarketingEnums.BulkEmailLaunchOption.MASS_MAILING_MANUALY);
						}
					},

					/**
					 * Performs mailing start with the status checking.
					 * @overriden
					 */
					runMandrillMassMailing: function() {
						if (this.isNew) {
							this.runMailingAction();
							return;
						}
						var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: this.entitySchemaName
						});
						var config = {
							serviceName: "BulkEmailAudience",
							methodName: "HasIncompleteTask",
							data: {
								bulkEmailId: this.$Id
							}
						};
						this.callService(config, function(response) {
							if (response.HasIncompleteTaskResult) {
								this.showInformationDialog(
									this.get("Resources.Strings.BulkEmailCantBeExecutedWhileBackgroundTasksIncompleted"));
							} else {
								this.runMailingAction();
							}
						}, this);
					},

					/**
					 * Performs mailing start.
					 * @protected
					 */
					runMailingAction: function() {
						var bulkEmailId = this.get("Id");
						if (this.isAssignedWithCampaign()) {
							if (this.isLaunchedCampaign()) {
								this.showInformationDialog(
									this.get("Resources.Strings.CannotStartMailingForLaunchedCampaign"));
							} else {
								this.showInformationDialog(
									this.get("Resources.Strings.CannotStartMailingForNotLaunchedCampaign"));
							}
							return;
						}
						this.runActionAfterSave(function() {
							if (this.get("IsPublicDemoBuild")) {
								MarketingCommonUtilities.ShowConfirmationDialogWithGoButton(
									this.get("Resources.Strings.DemoDataMessage"),
									this.get("TrialUrl"),
									this.get("Resources.Strings.TryTrialButtonCaption"),
									this
								);
								return;
							}
							this.set("ShowSaveButton", false);
							var startDate = this.get("StartDate");
							var status = this.get("Status");
							var email = {
								id: bulkEmailId,
								status: status.value,
								startDate: startDate
							};
							BulkEmailHelper.RunMailing(email, this);
						});
					},

					/**
					 * Performs mailing stop.
					 * @overriden
					 */
					breakMailingAction: function() {
						if(Terrasoft.Features.getIsEnabled("BulkEmailStop")) {
							let config = {
								confirmationMessage: this.get("Resources.Strings.StopSendingConfirmationMessage")
							}
							this.stopEmailSending(config);
							return;
						}
						const bulkEmailId = this.get("Id");
						if (Terrasoft.Features.getIsEnabled("BulkEmailPause")) {
							BulkEmailHelper.PauseMailing.call(this, bulkEmailId);
						} else {
							BulkEmailHelper.BreakMailing(bulkEmailId, this);
						}
					},
					
					/**
					 * Processing changes of start of mailing options.
					 * @overriden
					 */
					processLaunchOptionColumn: function() {
						var launchOption = this.get("LaunchOption");
						if (!launchOption) {
							return;
						}
						var startDate = this.get("StartDate");
						var status = this.get("Status");
						if (launchOption.value ===
								MarketingEnums.BulkEmailLaunchOption.MASS_MAILING_MANUALY) {
							this.set("SendMailingActionCaption",
									this.get("Resources.Strings.RunMandrillMassMailingActionCaption"));
							this.set("IsSendScheduled", false);
							if (!Ext.isEmpty(startDate) && status.value !== MarketingEnums.BulkEmailStatus.COMPLETED) {
								this.set("StartDate", null);
							}
						} else {
							 var runActionCaption = status.value === MarketingEnums.BulkEmailStatus.START_SCHEDULED
								? this.get("Resources.Strings.RunMandrillMassMailingActionCaption")
								 : this.get("Resources.Strings.RunScheduledMailingActionCaption");
								this.set("SendMailingActionCaption", runActionCaption);
							this.set("IsSendScheduled", true);
							if(Ext.isEmpty(startDate)) {
								var nowDate = BulkEmailHelper.GetCurrentDateWithProfileTimeZone();
								this.set("StartDate", nowDate);
							}
						}
					},

					/**
					 * @inheritDoc BaseBulkEmailPageV2#processStatusColumn
					 * @protected
					 * @overriden
					 */
					processStatusColumn: function() {
						this.callParent(arguments);
						var status = this.get("Status");
						this.processLaunchOptionColumn();
						var isUseUtm = this.get("UseUtm");
						var isBreakEnabled = BulkEmailHelper.GetIsBreakable(status.value);
						var isRunEnabled = BulkEmailHelper.GetIsRunnable(status.value);
						var isTemplateEditable = BulkEmailHelper.IsEmailTemplateEditable(status.value,
							MarketingEnums.BulkEmailCategory.MASS_MAILING);
						var isAssignedWithCampaign = this.isAssignedWithCampaign();
						var isActiveStatus = BulkEmailHelper.GetIsActiveStatus(status.value);
						this.set("IsUtmCheckBoxEnabled", isTemplateEditable);
						this.set("IsUtmEnabled", isUseUtm && isTemplateEditable);
						this.set("IsRunEnabled", isRunEnabled);
						this.sandbox.publish("WeekDayCronEditableChanged", {isEditable: isTemplateEditable});
						this.set("IsRunDisplayed", isRunEnabled);
						this.set("IsTemplateEditable", isTemplateEditable);
						this.set("IsLaunchOptionEnabled", isRunEnabled && !isActiveStatus && !isAssignedWithCampaign);
						this.set("IsBreakEnabled", isBreakEnabled);
						this.set("IsBlankSlatesAudienceVisible", false);
						this.set("IsAnalysisVisible", !isTemplateEditable);
					},

					/**
					 * @inheritdoc Terrasoft.BaseBulkEmailPageV2#onChannelMessage
					 * @override
					 */
					onChannelMessage: function(channel, message) {
						this.callParent(arguments);
						if (message.Header.Sender === "BulkEmailNotifier") {
							this.reloadBulkEmailQueueTasks();
						}
					},

					/**
					 * Returns caption with actual bulk email queue state info.
					 * @protected
					 * @param {Object} estimation Estimation for current bulk email queue tasks' processing.
					 * @returns {String}
					 */
					getQueueTasksCaption: function(estimation) {
						var estimatedTimeInMinutes = Math.round(estimation.EstimatedTime / 60);
						var tasksCaptionTemplate = this.get("Resources.Strings.QueueTasksLabelText");
						return Ext.String.format(tasksCaptionTemplate, estimatedTimeInMinutes);
					},

					/**
					 * Calls service to load actual bulk email queue tasks.
					 * @protected
					 */
					reloadBulkEmailQueueTasks: Terrasoft.debounce(function() {
						var config = {
							serviceName: "BulkEmailAudience",
							methodName: "EstimateTaskExecution",
							data: {
								bulkEmailId: this.getPrimaryColumnValue()
							}
						};
						this.callService(config, function(response) {
							var result = response.EstimateTaskExecutionResult;
							if (result.Success && result.Position > 0) {
								this.$IsQueueEmpty = false;
								this.$QueueTasksCaption = this.getQueueTasksCaption(result);
								this.maskId = Terrasoft.Mask.show({
									caption: "",
									frameVisible: false,
									selector: "#queue-task-spinner"
								});
								return;
							}
							this.$IsQueueEmpty = true;
							this.$QueueTasksCaption = "";
							Terrasoft.Mask.hide(this.maskId);
						}, this);
					}, 2000)
				},
				modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
				dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "IsSystemEmail",
						"values": {
							"layout": {
								"colSpan": 12,
								"rowSpan": 1,
								"column": 12,
								"row": 0,
								"layoutName": "UtmSettingPageGridLayout"
							},
							"labelConfig": {},
							"enabled": {bindTo: "IsSystemEmailEnabled"},
							"visible": {bindTo: "IsSystemEmailEnabled"},
							"bindTo": "IsSystemEmail"
						},
						"parentName": "UtmSettingPageGridLayout",
						"propertyName": "items",
						"index": 7
					},
					{
						"operation": "insert",
						"name": "BulkEmailQueueTasks",
						"parentName": "BulkEmailQueueTasksContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.LABEL,
							"caption": "$QueueTasksCaption",
							"classes": {"labelClass": ["queue-tasks-label"]},
							"markerValue": "BulkEmailQueueTasksLabel"
						}
					},
					{
						"operation": "insert",
						"name": "BulkEmailQueueTasksSpinner",
						"parentName": "BulkEmailQueueTasksContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.CONTAINER,
							"id": "queue-task-spinner",
							"wrapClass": ["queue-task-spinner"]
						}
					},
					{
						"operation": "merge",
						"name": "SendButton",
						"values": {
							enabled: "$IsQueueEmpty"
						}
					}
				]/**SCHEMA_DIFF*/,
				rules: {
					"StartDate": {
						StartDateEnabled: {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							logical: Terrasoft.LogicalOperatorType.AND,
							conditions: [
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "Status"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.NOT_EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: MarketingEnums.BulkEmailStatus.COMPLETED
									}
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "Status"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.NOT_EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: MarketingEnums.BulkEmailStatus.STARTED
									}
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "Status"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.NOT_EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: MarketingEnums.BulkEmailStatus.STARTING
									}
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "Status"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.NOT_EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: MarketingEnums.BulkEmailStatus.BREAKING
									}
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "LaunchOption"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.EQUAL,
									rightExpression: {
										type: BusinessRuleModule.enums.ValueType.CONSTANT,
										value: MarketingEnums.BulkEmailLaunchOption.MASS_MAILING_SCHEDULED
									}
								},
								{
									leftExpression: {
										type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
										attribute: "SplitTest"
									},
									comparisonType: Terrasoft.core.enums.ComparisonType.IS_NULL
								}
							]
						}
					}
				}
			};
		});
