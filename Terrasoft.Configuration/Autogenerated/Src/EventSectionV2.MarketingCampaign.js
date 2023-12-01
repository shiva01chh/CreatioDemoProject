define("EventSectionV2", ["SegmentsStatusUtils"],
function(SegmentsStatusUtils) {
	return {
		entitySchemaName: "Event",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		messages: {},
		methods: {
			/**
			 * @private
			 */
			_loadActiveContactsModule(renderToContainer) {
				var loadModuleConfig = {
					renderTo: renderToContainer,
					keepAlive: false,
					instanceConfig: {
						useHistoryState: false,
						schemaName: "ActiveContactsDetail",
						isSchemaConfigInitialized: true
					}
				};
				this.sandbox.loadModule("BaseSchemaModuleV2", loadModuleConfig);
			},

			/**
			 * ##### ######## "######## ###### #####".
			 * @protected
			 */
			updateContactList: function() {
				var activeRow = this.getActiveRow();
				var eventId = activeRow.get("Id");
				this.callService({
					serviceName: "MandrillService",
					methodName: "UpdateTargetAudience",
					data: {schemaName: "Event", recordId: eventId}
				}, this.onUpdateContactListLaunched, this);
			},

			/*
			 * ########## ######## # #########.
			 * @protected
			 */
			onUpdateContactListLaunched: function() {
				var scope = this;
				setTimeout(function() {
					var activeRow = scope.getActiveRow();
					var eventId = activeRow.get("Id");
					if (scope.get("IsCardVisible")) {
						scope.editRecord(eventId);
					}
				}, SegmentsStatusUtils.timeoutBeforeUpdate);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSectionV2#onRender
			 * @overridden
			 */
			onRender: function() {
				this.callParent(arguments);
				this._loadActiveContactsModule("ActiveContactsContainer");
			},

			/**
			 * @inheritdoc Terrasoft.BaseDataView#onRender
			 * @overridden
			 */
			initCardViewOptionsButtonMenu: function() {
				this.callParent(arguments);
				this._loadActiveContactsModule("ActiveContactsSectionContainer");
			},

			/**
			 * @inheritdoc Terrasoft.BaseDataView#closeCard
			 * @overridden
			 */
			closeCard: function() {
				this.callParent(arguments);
				this._loadActiveContactsModule("ActiveContactsContainer");
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ActiveContactsContainer",
				"parentName": "SeparateModeActionButtonsRightContainer",
				"index": 0,
				"propertyName": "items",
				"values": {
					"id": "ActiveContactsContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						"wrapClassName": ["active-contacts-container"]
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "ActiveContactsSectionContainer",
				"parentName": "CombinedModeActionButtonsCardRightContainer",
				"index": 0,
				"propertyName": "items",
				"values": {
					"id": "ActiveContactsSectionContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"classes": {
						"wrapClassName": ["active-contacts-container"]
					},
					"items": []
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
