﻿Terrasoft.configuration.Structures["CampaignStartEventPage"] = {innerHierarchyStack: ["CampaignStartEventPage"], structureParent: "CampaignBaseEventPage"};
define('CampaignStartEventPageStructure', ['CampaignStartEventPageResources'], function(resources) {return {schemaUId:'b2399020-e496-4a6a-bfae-7e6d5df562a9',schemaCaption: "Edit page for event element", parentSchemaName: "CampaignBaseEventPage", packageName: "CrtEventInCampaign7x", schemaName:'CampaignStartEventPage',parentSchemaUId:'8d3dc052-22b7-c899-0dad-b23308e67487',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Schema of campaign Event element page
 * Parent: CampaignBaseEventPage
 */
define("CampaignStartEventPage", [],
	function() {
		return {
			attributes: {
				/**
				 * Flag to indicate state of participants' recurring entrance by signal.
				 * @type {Boolean}
				 */
				"IsRecurring": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"value": false,
					"onChange": "onIsRecurringChanged"
				}
			},
			methods: {
				/**
				 * @private
				 */
				_isRecurringAllowed: function() {
					return Terrasoft.Features.getIsEnabled("CampaignSignalRecurringEntrance");
				},

				/**
				 * @private
				 */
				_getEventFilter: function(schemaName, eventId) {
					var eventFilter = Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Event", eventId);
					var filterGroup = Ext.create("Terrasoft.FilterGroup");
					filterGroup.rootSchemaName = schemaName;
					filterGroup.logicalOperation = Terrasoft.LogicalOperatorType.AND;
					filterGroup.addItem(eventFilter);
					var serializedFilter = filterGroup.serialize({
						serializeFilterManagerInfo: true
					});
					var deserializedFilters = Terrasoft.deserialize(serializedFilter);
					var serializedFilterData = {
						className: "Terrasoft.FilterGroup",
						serializedFilterEditData: serializedFilter,
						dataSourceFilters: deserializedFilters.serialize()
					};
					return Terrasoft.encode(serializedFilterData);
				},

				/**
				 * Handles change of recurring sign
				 * @public
				 */
				onIsRecurringChanged: function(model, value) {
					var element = this.get("ProcessElement");
					element.isRecurring = value;
					element.updateMarkers();
				},

				/**
				 * @inheritdoc BaseCampaignSchemaElementPage#getContextHelpCode
				 * @overridden
				 */
				getContextHelpCode: function() {
					return "CampaignStartEventElement";
				},

				/**
				 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#initParameters
				 * @override
				 */
				initParameters: function(element) {
					this.callParent(arguments);
					this.$IsRecurring = element.isRecurring;
				},

				/**
				 * @inheritdoc EntityCampaignSchemaElementPage#clearPageParameters
				 * @override
				 */
				clearPageParameters: function() {
					this.callParent(arguments);
					this.set("IsRecurring", false);
				},

				/**
				 * @inheritdoc Terrasoft.ProcessFlowElementPropertiesPage#saveValues
				 * @override
				 */
				saveValues: function() {
					this.callParent(arguments);
					var element = this.$ProcessElement;
					element.isRecurring = this.$IsRecurring;
					element.signalEntityId = element.eventId;
					var targetEntitySchema = Terrasoft.EntitySchemaManager.findItemByName("EventTarget");
					element.entitySchemaUId = targetEntitySchema.uId;
					element.entityFilters = this._getEventFilter(targetEntitySchema.name, element.eventId);
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "RecurringAddContainer",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": "$_isRecurringAllowed",
						"layout": {
							"column": 0,
							"row": 9,
							"colSpan": 24
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "RecurringAddLayout",
					"propertyName": "items",
					"parentName": "RecurringAddContainer",
					"className": "Terrasoft.GridLayoutEdit",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "IsRecurringLabel",
					"parentName": "RecurringAddLayout",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.IsRecurringLabel",
						"classes": {
							"labelClass": ["t-title-label-proc"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "IsRecurring",
					"parentName": "RecurringAddLayout",
					"propertyName": "items",
					"values": {
						"wrapClass": ["t-checkbox-control"],
						"caption": "$Resources.Strings.IsRecurringCaption",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 23
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "RecurringAddLayout",
					"propertyName": "items",
					"name": "RecurringAddHint",
					"values": {
						"layout": {"column": 23, "row": 1, "colSpan": 1},
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": "$Resources.Strings.IsRecurringHint",
						"controlConfig": {
							"classes": {
								"wrapperClass": "t-checkbox-information-button"
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);


