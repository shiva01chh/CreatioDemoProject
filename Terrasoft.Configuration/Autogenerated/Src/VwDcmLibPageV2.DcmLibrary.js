﻿/**
 * Parent: VwProcessLibPageV2
 */
define("VwDcmLibPageV2", ["VwDcmLibPageV2Resources", "DcmUtilities", "SysDcmSchemaInSettingsManager"],
	function() {
		return {
			entitySchemaName: "VwSysDcmLib",
			attributes: {
				"StageFilterValue": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"StageColumnName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			details: /**SCHEMA_DETAILS*/{
				DcmVersions: {
					schemaName: "DcmVersionsDetail",
					filterMethod: "dcmVersionsDetailFilterMethod"
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "ModulesTab"
				},
				{
					"operation": "remove",
					"name": "SubProcessesTab"
				},
				{
					"operation": "remove",
					"name": "ProcessLogTab"
				},
				{
					"operation": "remove",
					"name": "ProcessVersions"
				},
				{
					"operation": "remove",
					"name": "GranteesTab"
				},
				{
					"operation": "merge",
					"name": "IsTracingContainer",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "merge",
					"name": "Enabled",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12
						},
						"enabled": false,
						"bindTo": "IsActive",
					}
				},
				{
					"operation": "merge",
					"name": "SysPackage",
					"values": {
						"enabled": false,
						"bindTo": "Package",
					}
				},
				{
					"operation": "merge",
					"name": "AddToRunButton",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "insert",
					"name": "StageFilters",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12
						},
						"enabled": false,
						"bindTo": "StageFilterValue",
						"caption": {
							"bindTo": "Resources.Strings.StageFilterValueCaption"
						},
						"textSize": "Default"
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 5
				},
				{
					"operation": "insert",
					"name": "StageColumn",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12
						},
						"enabled": false,
						"bindTo": "StageColumnName",
						"caption": {
							"bindTo": "Resources.Strings.StageColumnCaption"
						},
						"textSize": "Default"
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 6
				},
				{
					"operation": "insert",
					"name": "DcmVersions",
					"parentName": "VersionsTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/,
			messages: {
				"NavigateTo": {
					mode: Terrasoft.MessageMode.BROADCAST,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {
				init: function() {
					this.callParent(arguments);
					this.set("HasAnyDcm", false);
					this.set("HasActiveDcm", false);
				},

				/**
				 * Creates filters for dcm versions detail.
				 * @private
				 */
				dcmVersionsDetailFilterMethod: function() {
					const masterRecordId = this.get("Parent").value || this.get("Id");
					return Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"VersionParentId", masterRecordId, Terrasoft.DataValueType.GUID);
				},

				/**
				 * @inheritdoc Terrasoft.BaseVwProcessLibPageV2#warmUpProcessSchema
				 * @override
				 */
				warmUpProcessSchema: function() {
					Terrasoft.SysDcmSchemaInSettingsManager.initialize({}, Terrasoft.emptyFn, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseVwProcessLibPageV2#initTracingAttribute
				 * @override
				 */
				initTracingAttribute: function(callback, scope) {
					Ext.callback(callback, scope);
				},

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this._setStageFilterValue();
					this._setStageColumnName();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initActionButtonMenu
				 * @overridden
				 */
				initActionButtonMenu: function() {
					this.set("ActionsButtonVisible", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseVwProcessLibPageV2#onOpenProcessDesignerButtonClick
				 * @override
				 */
				onOpenProcessDesignerButtonClick: function() {
					const schemaUId = this.get(this.primaryColumnName);
					Terrasoft.ProcessModuleUtilities.showDcmSchemaDesignerById(schemaUId);
					this.set("ProcessActionTag", "OpenProcess");
					this.sendGoogleTagManagerData();
				},

				/**
				 * @private
				 */
				_setStageFilterValue: function() {
					let filters = this.get("Filters");
					if (!filters) {
						return;
					}
					filters = Terrasoft.deserialize(filters);
					Terrasoft.EntitySchemaManager.getInstanceByUId(this.get("EntitySchemaUId"), function(schema) {
						const displayFilters = Terrasoft.DcmUtilities.getStageFiltersDisplayValue(filters, schema);
						this.set("StageFilterValue", displayFilters);
					}, this);
				},

				/**
				 * @private
				 */
				_setStageColumnName: function() {
					const stageColumnUId = this.get("StageColumnUId");
					const entitySchemaUId = this.get("EntitySchemaUId");
					const dots = "\u22ef";
					this.set("StageColumnName", dots);
					Terrasoft.DcmUtilities.getStageColumnDisplayName(stageColumnUId, entitySchemaUId, function(displayName) {
						this.set("StageColumnName", displayName);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.VwProcessLibPageV2#onActiveVersionChanged
				 * @override
				 */
				onActiveVersionChanged: function(changeData) {
					this.sandbox.publish("NavigateTo", {
						target: "Page",
						options: {
							silent: true,
							replaceState: true,
							sectionSchema: "VwDcmLibSection",
							mode: "edit",
							recordId: changeData.activeVersionId
						}
					});
					this.callParent(arguments);
				}

			},
			rules: {}
		};
	});
