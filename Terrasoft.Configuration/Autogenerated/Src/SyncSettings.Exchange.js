define("SyncSettings", ["SyncSettingsResources"], function() {
	return {
		entitySchemaName: "MailboxSyncSettings",

		methods: {
			/**
			 * @inheritdoc SyncSettings#initTabs
			 * @overridden
			 */
			initTabs: function() {
				if(!this.isCalendarSyncLicensed) {
					var tabsCollection = this.get("TabsCollection");
					tabsCollection.removeByKey("ActivitySettingsTab");
				}
				if(this.getIsFeatureDisabled("ContactsSyncEnabled")) {
					var tabsCollection = this.get("TabsCollection");
					tabsCollection.removeByKey("ContactSettingsTab");
				}
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc SyncSettings#setActiveTab
			 * @overridden
			 */
			setActiveTab: function(activeTabName) {
				if(this.getIsFeatureDisabled("ContactsSyncEnabled") && this.get("ActiveTabName") === "ContactSettingsTab") {
					this.set("ActiveTabName", "EmailSettingsTab");
					this.set("EmailSettingsTab", true);
				} else {
					this.callParent(arguments);
				}
			},

		},

		diff: [
			{
				"operation": "insert",
				"parentName": "TabsPanel",
				"name": "ActivitySettingsTab",
				"propertyName": "tabs",
				"values": {
					"caption": {"bindTo": "Resources.Strings.ActivitySettingsTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ActivitySettingsTab",
				"name": "ActivitySettingsModule",
				"propertyName": "items",
				"values": {
					"moduleId": "SyncSettings_ActivitySyncSettingsSchemaModule",
					"itemType": Terrasoft.ViewItemType.MODULE,
					"moduleName": "SyncSettingsTabModule",
					"instanceConfig": {
						"isSchemaConfigInitialized": true,
						"schemaName": "ActivitySyncSettingsTab",
						"defaultValues": [{
							"name": "TabName",
							"value": "ActivitySyncSettingsTab"
						}],
						"useHistoryState": false
					},
					"afterrerender": {"bindTo": "afterrerender"}
				}
			},
			{
				"operation": "insert",
				"parentName": "TabsPanel",
				"name": "ContactSettingsTab",
				"propertyName": "tabs",
				"values": {
					"caption": {"bindTo": "Resources.Strings.ContactSettingsTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ContactSettingsTab",
				"name": "ContactSettingsModule",
				"propertyName": "items",
				"values": {
					"moduleId": "SyncSettings_ContactSyncSettingsSchemaModule",
					"itemType": Terrasoft.ViewItemType.MODULE,
					"moduleName": "SyncSettingsTabModule",
					"instanceConfig": {
						"isSchemaConfigInitialized": true,
						"schemaName": "ContactSyncSettingsTab",
						"defaultValues": [{
							"name": "TabName",
							"value": "ContactSettingsTab"
						}],
						"useHistoryState": false
					},
					"afterrerender": {"bindTo": "afterrerender"}
				}
			}
		]
	};
});
