﻿Terrasoft.configuration.Structures["LeadPageV2"] = {innerHierarchyStack: ["LeadPageV2Lead", "LeadPageV2MLLeadScoring", "LeadPageV2CoreLead", "LeadPageV2WebLeadForm", "LeadPageV2Tracking", "LeadPageV2SocialLeadGen", "LeadPageV2OrderLead", "LeadPageV2PRMBase", "LeadPageV2LeadManagement", "LeadPageV2CoreLeadOpportunity", "LeadPageV2SalesEnterprise", "LeadPageV2MarketingCampaign", "LeadPageV2"], structureParent: "BaseLeadPage"};
define('LeadPageV2LeadStructure', ['LeadPageV2LeadResources'], function(resources) {return {schemaUId:'ddf8941f-92f3-4b10-9f59-faab18c12f46',schemaCaption: "Lead edit page", parentSchemaName: "BaseLeadPage", packageName: "EventTracking", schemaName:'LeadPageV2Lead',parentSchemaUId:'cf9a9556-5840-42c8-803a-32be0512075d',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2MLLeadScoringStructure', ['LeadPageV2MLLeadScoringResources'], function(resources) {return {schemaUId:'d8c1174c-21de-42ff-b645-8bcc951c55e1',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2Lead", packageName: "EventTracking", schemaName:'LeadPageV2MLLeadScoring',parentSchemaUId:'ddf8941f-92f3-4b10-9f59-faab18c12f46',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2Lead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2CoreLeadStructure', ['LeadPageV2CoreLeadResources'], function(resources) {return {schemaUId:'ed37b691-ba3d-495b-a210-4378b5dcbe10',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2MLLeadScoring", packageName: "EventTracking", schemaName:'LeadPageV2CoreLead',parentSchemaUId:'d8c1174c-21de-42ff-b645-8bcc951c55e1',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2MLLeadScoring",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2WebLeadFormStructure', ['LeadPageV2WebLeadFormResources'], function(resources) {return {schemaUId:'c213bab5-e616-4629-955a-c5ea46c2c9e5',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2CoreLead", packageName: "EventTracking", schemaName:'LeadPageV2WebLeadForm',parentSchemaUId:'ed37b691-ba3d-495b-a210-4378b5dcbe10',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2CoreLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2TrackingStructure', ['LeadPageV2TrackingResources'], function(resources) {return {schemaUId:'95440bf6-2c2b-4776-801d-4f29de9cc4ac',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2WebLeadForm", packageName: "EventTracking", schemaName:'LeadPageV2Tracking',parentSchemaUId:'c213bab5-e616-4629-955a-c5ea46c2c9e5',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2WebLeadForm",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2SocialLeadGenStructure', ['LeadPageV2SocialLeadGenResources'], function(resources) {return {schemaUId:'67715c21-744c-4a1b-b2e0-70ed93620f62',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2Tracking", packageName: "EventTracking", schemaName:'LeadPageV2SocialLeadGen',parentSchemaUId:'95440bf6-2c2b-4776-801d-4f29de9cc4ac',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2Tracking",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2OrderLeadStructure', ['LeadPageV2OrderLeadResources'], function(resources) {return {schemaUId:'71c4d3f9-24b7-4f2d-a8aa-47f7c902bd61',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2SocialLeadGen", packageName: "EventTracking", schemaName:'LeadPageV2OrderLead',parentSchemaUId:'67715c21-744c-4a1b-b2e0-70ed93620f62',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2SocialLeadGen",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2PRMBaseStructure', ['LeadPageV2PRMBaseResources'], function(resources) {return {schemaUId:'adfc8833-d9d3-478e-ab15-d9c029d534a3',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2OrderLead", packageName: "EventTracking", schemaName:'LeadPageV2PRMBase',parentSchemaUId:'71c4d3f9-24b7-4f2d-a8aa-47f7c902bd61',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2OrderLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2LeadManagementStructure', ['LeadPageV2LeadManagementResources'], function(resources) {return {schemaUId:'84b3bb47-fbee-472f-ab11-d731fa34e9eb',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2PRMBase", packageName: "EventTracking", schemaName:'LeadPageV2LeadManagement',parentSchemaUId:'adfc8833-d9d3-478e-ab15-d9c029d534a3',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2PRMBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2CoreLeadOpportunityStructure', ['LeadPageV2CoreLeadOpportunityResources'], function(resources) {return {schemaUId:'959925e0-1296-49c3-a373-025966b54486',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2LeadManagement", packageName: "EventTracking", schemaName:'LeadPageV2CoreLeadOpportunity',parentSchemaUId:'84b3bb47-fbee-472f-ab11-d731fa34e9eb',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2LeadManagement",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2SalesEnterpriseStructure', ['LeadPageV2SalesEnterpriseResources'], function(resources) {return {schemaUId:'1690d119-7904-429a-bc08-30b0a8b65b32',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2CoreLeadOpportunity", packageName: "EventTracking", schemaName:'LeadPageV2SalesEnterprise',parentSchemaUId:'959925e0-1296-49c3-a373-025966b54486',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2CoreLeadOpportunity",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2MarketingCampaignStructure', ['LeadPageV2MarketingCampaignResources'], function(resources) {return {schemaUId:'306f6721-2c9b-43a6-b538-27f3c6d8cf97',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2SalesEnterprise", packageName: "EventTracking", schemaName:'LeadPageV2MarketingCampaign',parentSchemaUId:'1690d119-7904-429a-bc08-30b0a8b65b32',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2SalesEnterprise",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2Structure', ['LeadPageV2Resources'], function(resources) {return {schemaUId:'5211bcc2-8278-4f6f-854e-4bbfb4b73512',schemaCaption: "Lead edit page", parentSchemaName: "LeadPageV2MarketingCampaign", packageName: "EventTracking", schemaName:'LeadPageV2',parentSchemaUId:'306f6721-2c9b-43a6-b538-27f3c6d8cf97',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadPageV2MarketingCampaign",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadPageV2LeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2Lead", ["BusinessRuleModule", "ConfigurationConstants", "BaseFiltersGenerateModule"],
		function(BusinessRuleModule, ConfigurationConstants, BaseFiltersGenerateModule) {
			return {
				entitySchemaName: "Lead",
				attributes: {
					"SalesOwner": {
						dataValueType: Terrasoft.DataValueType.LOOKUP,
						lookupListConfig: {filter: BaseFiltersGenerateModule.OwnerFilter}
					}
				},
				details: /**SCHEMA_DETAILS*/{
					Calls: {
						schemaName: "CallDetail",
						filter: {
							masterColumn: "Id",
							detailColumn: "Lead"
						}
					},
					Activities: {
						schemaName: "ActivityDetailV2",
						filter: {
							masterColumn: "Id",
							detailColumn: "Lead"
						},
						defaultValues: {
							Lead: {
								masterColumn: "Id"
							}
						}
					}
				}/**SCHEMA_DETAILS*/,
				methods: {

					/**
					 * @inheritdoc Terrasoft.BasePageV2#getActions
					 * @overridden
					 */
					getActions: function() {
						var actionMenuItems = this.callParent(arguments);
						var disqualifyMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
						disqualifyMenuItems.addItem(this.getButtonMenuItem({
							Caption: {bindTo: "Resources.Strings.DisqualifyLeadLost"},
							Tag: "disqualifyLost"
						}));
						disqualifyMenuItems.addItem(this.getButtonMenuItem({
							Caption: {bindTo: "Resources.Strings.DisqualifyLeadNoConnection"},
							Tag: "disqualifyNoConnection"
						}));
						disqualifyMenuItems.addItem(this.getButtonMenuItem({
							Caption: {bindTo: "Resources.Strings.DisqualifyLeadNotInterested"},
							Tag: "disqualifyNotInterested"
						}));
						return actionMenuItems;
					},

					/**
					 * @inheritdoc Terrasoft.BasePageV2#save
					 * @overridden
					 */
					save: function() {
						if (!this.checkRequiredActionColumns()) {
							return;
						}
						return this.callParent(arguments);
					},

					/**
					 * Opens lead qualification page.
					 */
					qualifyLead: function() {
						var recordId = this.get("Id");
						var token = "CardModuleV2/LeadQualificationPageV2/edit/" + recordId;
						this.sandbox.publish("PushHistoryState", {hash: token});
					},

					/**
					 * Checks required parameters.
					 * @return {Boolean} Validation result.
					 */
					checkRequiredActionColumns: function() {
						var account = this.get("Account");
						var contact = this.get("Contact");
						if (!account && !contact) {
							this.showInformationDialog(this.get("Resources.Strings.RequiredFieldsMessage"));
							return false;
						}
						return true;
					},

					/**
					 * Saves lead.
					 */
					saveLead: function() {
						this.showBodyMask();
						if (!this.checkRequiredActionColumns()) {
							this.hideBodyMask();
							return;
						}
						this.saveEntity(this.qualifyLead, this);
					},

					/**
					 * Launches "Disqualify" action.
					 * @param {Guid} statusId Qualification status.
					 */
					disqualifyLead: function(statusId) {
						if (!this.checkRequiredActionColumns()) {
							return;
						}
						this.showConfirmationDialog(this.get("Resources.Strings.DisqualifyLeadActionMessage"),
							function(returnCode) {
								if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
									this.loadLookupDisplayValue("Status", statusId);
								}
							}, ["yes", "no"]);
					},

					/**
					 * Launches "Disqualify" action with the "Lost" status.
					 */
					disqualifyLost: function() {
						this.disqualifyLead(ConfigurationConstants.Lead.Status.QualifiedAsLost);
					},

					/**
					 * Launches "Disqualify" action with the "No connection" status.
					 */
					disqualifyNoConnection: function() {
						this.disqualifyLead(ConfigurationConstants.Lead.Status.QualifiedAsNoConnection);
					},

					/**
					 * Launches "Disqualify" action with the "Not interested" status.
					 */
					disqualifyNotInterested: function() {
						this.disqualifyLead(ConfigurationConstants.Lead.Status.QualifiedAsNotInterested);
					},

					/**
					 * Updates links in the related activities.
					 * @param {String} linkColumnName Name of the column to be updated.
					 * @param {Guid} recordId Unique identifier.
					 */
					updateActivitiesLink: function(linkColumnName, recordId) {
						var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "Activity"
						});
						esq.addColumn("Id");
						esq.filters.add("LeadFilter",
							esq.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Lead", this.get("Id")));
						esq.getEntityCollection(function(result) {
							var batchQuery = Ext.create("Terrasoft.BatchQuery");
							var collection = result.collection;
							collection.each(function(item) {
								var activityId = item.get("Id");
								var update = Ext.create("Terrasoft.UpdateQuery", {
									rootSchemaName: "Activity"
								});
								update.enablePrimaryColumnFilter(activityId);
								update.setParameterValue(linkColumnName, recordId, this.Terrasoft.DataValueType.GUID);
								batchQuery.add(update);
							});
							batchQuery.execute();
						}, this);
					},

					/**
					 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
					 * @overridden
					 */
					onEntityInitialized: function() {
						var account = this.get("Account");
						if (this.Terrasoft.isGUID(account)) {
							this.set("Account", null);
							this.loadLookupDisplayValue("Account", account);
						}
						var contact = this.get("Contact");
						if (this.Terrasoft.isGUID(contact)) {
							this.set("Contact", null);
							this.loadLookupDisplayValue("Contact", contact);
						}
						var queryParams = this.sandbox.publish("GetHistoryState");
						if (queryParams) {
							var createdmessage = "";
							var queryParamsState = queryParams.state;
							if (queryParamsState.Qualified) {
								if (queryParamsState.contactName && queryParamsState.isContactQualifyAsNew) {
									createdmessage += Ext.String.format(this.get("Resources.Strings.CreatedContactMessage"),
										queryParamsState.contactName);
									queryParamsState.contactName = null;
								}
								if (queryParamsState.accountName && queryParamsState.isAccountQualifyAsNew) {
									if (createdmessage) {
										createdmessage += " ";
									}
									createdmessage += Ext.String.format(this.get("Resources.Strings.CreatedAccountMessage"),
										queryParamsState.accountName);
									queryParamsState.accountName = null;
								}
								if (createdmessage) {
									this.showInformationDialog(createdmessage);
								}
								if (queryParamsState.contactId) {
									this.updateActivitiesLink("Contact", queryParamsState.contactId);
								}
								if (queryParamsState.accountId) {
									this.updateActivitiesLink("Account", queryParamsState.accountId);
								}
								queryParamsState.Qualified = false;
								var currentHash = queryParams.hash;
								var newState = this.Terrasoft.deepClone(queryParams);
								this.sandbox.publish("ReplaceHistoryState", {
									stateObj: newState,
									pageTitle: null,
									hash: currentHash.historyState,
									silent: true
								});
							}
						}
						this.callParent(arguments);
					},

					/**
					 * @inheritdoc Terrasoft.BaseModulePageV2#getFileEntitySchemaName
					 * @overridden
					 */
					getFileEntitySchemaName: function() {
						return "FileLead";
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "LeadEngagementTab",
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 1,
						"values": {
							"caption": {"bindTo": "Resources.Strings.LeadEngagementTabCaption"},
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadEngagementTab",
						"name": "LeadEngagementTabContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.CONTAINER,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadEngagementTabContainer",
						"propertyName": "items",
						"name": "LeadPageSourceGroup",
						"alias": {
							"name": "LeadPageSourceInfo"
						},
						"values": {
							"caption": {bindTo: "Resources.Strings.SourceGroupCaption"},
							"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": []
						},
						"index": 0
					},
					{
						"operation": "insert",
						"parentName": "GeneralInfoTab",
						"propertyName": "items",
						"name": "LeadPageCategorizationContainer",
						"values": {
							"caption": {"bindTo": "Resources.Strings.LeadPageCategorizationBlockCaption"},
							"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": [],
							"controlConfig": {"collapsed": false}
						}
					},
					{
						"operation": "insert",
						"parentName": "GeneralInfoTab",
						"propertyName": "items",
						"name": "LeadPageCommunicationContainer",
						"values": {
							"caption": {bindTo: "Resources.Strings.LeadPageCommunicationBlockCaption"},
							"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": [],
							"controlConfig": {"collapsed": false}
						}
					},
					{
						"operation": "insert",
						"parentName": "GeneralInfoTab",
						"propertyName": "items",
						"name": "LeadPageAddressContainer",
						"values": {
							"caption": {"bindTo": "Resources.Strings.LeadPageAddressBlockCaption"},
							"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": [],
							"controlConfig": {"collapsed": false}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageSourceGroup",
						"propertyName": "items",
						"name": "LeadPageSourceInfoBlock",
						"values": {
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCategorizationContainer",
						"propertyName": "items",
						"name": "LeadPageCategorizationBlock",
						"values": {
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationContainer",
						"propertyName": "items",
						"name": "LeadPageCommunicationBlock",
						"values": {
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressContainer",
						"propertyName": "items",
						"name": "LeadPageAddressBlock",
						"values": {
							"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageSourceInfoBlock",
						"propertyName": "items",
						"name": "LeadMedium",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageSourceInfoBlock",
						"propertyName": "items",
						"name": "LeadSource",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageSourceInfoBlock",
						"propertyName": "items",
						"name": "RegisterMethod",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageGeneralBlock",
						"propertyName": "items",
						"name": "Title",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 10
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageGeneralBlock",
						"propertyName": "items",
						"name": "FullJobTitle",
						"values": {
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCategorizationBlock",
						"propertyName": "items",
						"name": "Industry",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCategorizationBlock",
						"propertyName": "items",
						"name": "AnnualRevenue",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "MobilePhone",
						"values": {
							"layout": {
								"className": "Terrasoft.PhoneEdit",
								"column": 0,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "Email",
						"values": {
							"layout": {
								"column": 0,
								"row": 3,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCategorizationBlock",
						"propertyName": "items",
						"name": "EmployeesNumber",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "Country",
						"values": {
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "Website",
						"values": {
							"layout": {
								"column": 0,
								"row": 4,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "BusinesPhone",
						"values": {
							"className": "Terrasoft.PhoneEdit",
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "DoNotUsePhone",
						"values": {
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "DoNotUseSMS",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "Fax",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "DoNotUseFax",
						"values": {
							"layout": {
								"column": 12,
								"row": 2,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageCommunicationBlock",
						"propertyName": "items",
						"name": "DoNotUseEmail",
						"values": {
							"layout": {
								"column": 12,
								"row": 3,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "AddressType",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "Region",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "City",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "Zip",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageAddressBlock",
						"propertyName": "items",
						"name": "Address",
						"values": {
							"layout": {
								"column": 12,
								"row": 2,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "MeetingDate",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12
							}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "DecisionDate",
						"values": {
							"layout": {
								"column": 12,
								"row": 2,
								"colSpan": 6
							},
							"dataValueType": Terrasoft.DataValueType.DATE
						}
					},
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Calls",
						"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
					},
					{
						"operation": "insert",
						"parentName": "HistoryTab",
						"propertyName": "items",
						"name": "Activities",
						"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
					},
				]/**SCHEMA_DIFF*/,
				rules: {
					"Region": {
						"FiltrationRegionByCountry": {
							ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
							autocomplete: true,
							autoClean: true,
							baseAttributePatch: "Country",
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Country"
						},
						"EnabledRegion": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"City": {
						"FiltrationCityByCountry": {
							ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
							autocomplete: true,
							autoClean: true,
							baseAttributePatch: "Country",
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Country"
						},
						"FiltrationCityByRegion": {
							ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
							autocomplete: true,
							autoClean: true,
							baseAttributePatch: "Region",
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Region"
						},
						"EnabledCity": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"Title": {
						"EnabledTitle": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"Industry": {
						"EnabledIndustry": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"AnnualRevenue": {
						"EnabledAnnualRevenue": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"FullJobTitle": {
						"EnabledFullJobTitle": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"BusinesPhone": {
						"EnabledBusinesPhone": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"DoNotUsePhone": {
						"EnabledDoNotUsePhone": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"DoNotUseSMS": {
						"EnabledDoNotUseSMS": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"Fax": {
						"EnabledFax": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"DoNotUseFax": {
						"EnabledDoNotUseFax": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"DoNotUseEmail": {
						"EnabledDoNotUseEmail": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"AddressType": {
						"EnabledAddressType": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"Zip": {
						"EnabledZip": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					},
					"Address": {
						"EnabledAddress": {
							ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							property: BusinessRuleModule.enums.Property.ENABLED,
							conditions: [{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "Status"
								},
								comparisonType: Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: ConfigurationConstants.Lead.Status.New
								}
							}]
						}
					}
				}
			};
		});

define('LeadPageV2MLLeadScoringResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2MLLeadScoring", ["MLConfigurationConsts", "IconizedProgressBarGenerator", "LeadPageV2Resources",
		"css!LeadPageV2MLCss", "MLPredictionPageMixin"],
		function(MLConfigurationConsts) {
	return {
		entitySchemaName: "Lead",
		messages: {
			/**
			 * Returns entity data for ml prediction & explanation.
			 * @message GetMLExplanationConfig
			 */
			"GetMLExplanationConfig": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			},
			/**
			 * Hides ML explanations module container.
			 * @message HideMLExplanationsModule
			 */
			"HideMLExplanationsModule": {
				mode: this.Terrasoft.MessageMode.PTP,
				direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		mixins: ["Terrasoft.MLPredictionPageMixin"],
		attributes: {
			"TrainedScoreModelExists": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/,
		methods: {
			/**
			 * @private
			 * @return {String} value of predictive score or empty string if score is zero.
			 */
			_getPredictiveScoreCaption: function() {
				return this.$PredictiveScore > 0 ? this.$PredictiveScore : "";
			},
			/**
			 * @private
			 * @return {Boolean} true if predictive score need to be shown.
			 */
			_getIsPredictiveScoreVisible: function() {
				return this.get("TrainedScoreModelExists") && !this.isNewMode();
			},
			/**
			 * Returns column caption for entity column.
			 * @param {String} columnName Entity column name.
			 * @return {String} Caption for entity column.
			 * @private
			 */
			_getEntityColumnCaption: function(columnName) {
				return this.entitySchema.getColumnByName(columnName).caption;
			},

			_sendScoringExplanationAnalytics: function() {
				if (!this.$IsGoogleTagManagerEnabled) {
					return;
				}
				const data = this.getGoogleTagManagerData();
				this.Ext.apply(data, {
					action: "LeadScoringExplanation"
				});
				Terrasoft.GoogleTagManagerUtilities.actionModule(data);
			},

			/**
			 * Recalculates score value and shows explanation for new predicted value.
			 * @protected
			 */
			getPredictiveScoreWithContributions: function() {
				this._sendScoringExplanationAnalytics();
				this.calcPredictiveScoreWithContributions("PredictiveScore");
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#init
			 */
			init: function() {
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc BasePageV2#onEntityInitialized
			 * @override
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.queryWasAnyModelTrained("PredictiveScore", MLConfigurationConsts.ProblemTypes.Scoring);
			}
		},
		modules: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "LeadPredictiveScoreContainer",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"layout": {
						"column": 0,
						"row": 8,
						"colSpan": 24
					},
					"items": [],
					"tips": [{
						"content": {"bindTo": "Resources.Strings.PredictiveScoreTip"}
					}],
					"wrapClass": ["progress-bar-container"],
					"visible": {
						"bindTo": "_getIsPredictiveScoreVisible"
					}
				}
			},
			{
				"operation": "insert",
				"name": "LeadPredictiveScoreLabelContainer",
				"parentName": "LeadPredictiveScoreContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["control-width-15"],
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "LeadPredictiveScoreLabel",
				"parentName": "LeadPredictiveScoreLabelContainer",
				"propertyName": "items",
				"values": {
					"className": "Terrasoft.TipLabel",
					"generateId": false,
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {"bindTo": "_getEntityColumnCaption"},
					"tag": "PredictiveScore"
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPredictiveScoreContainer",
				"propertyName": "items",
				"name": "PredictiveScoreBar",
				"values": {
					"generator": "IconizedProgressBarGenerator.generateProgressBar",
					"controlConfig": {
						"value": "$PredictiveScore",
						"caption": {"bindTo": "_getPredictiveScoreCaption"},
						"captionSuffix": "",
						"sectorsBounds": [0, 49, 79, 100]
					},
					"tips": [],
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"click": "$getPredictiveScoreWithContributions"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('LeadPageV2CoreLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2CoreLead", ["LeadPageV2Resources", "BaseFiltersGenerateModule", "ProcessModuleUtilities",
		"LeadConfigurationConst", "ServiceHelper", "BusinessRuleModule", "ConfigurationEnums", "ConfigurationConstants",
		"BaseProgressBarModule", "EntityHelper", "LeadManagementUtilities",
		"css!BaseProgressBarModule", "css!LeadPageV2CSS", "SearchInInternetUtilities"],
	function(resources, BaseFiltersGenerateModule, ProcessModuleUtilities, LeadConfigurationConst, ServiceHelper,
			BusinessRuleModule, enums, ConfigurationConstants) {
		return {
			entitySchemaName: "Lead",
			mixins: {
				EntityHelper: "Terrasoft.EntityHelper",
				SearchInInternetUtilities: "Terrasoft.SearchInInternetUtilities"
			},
			attributes: {
				"QualifyStatus": {
					lookupListConfig: {
						columns: ["Name", "StageNumber"]
					}
				},

				"UseProcessLeadManagement": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				/**
				 * Caption of the Qualification button.
				 */
				"QualificationProcessButtonCaption": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				/**
				 * Determines when keep the load mask visible.
				 */
				"LockBodyMask": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"QualifiedAccount": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					dependencies: [{
						columns: ["QualifiedContact"],
						methodName: "onQualifiedContactChanged"
					}]
				},
				/**
				 * Deduplication feature enabled flag.
				 */
				"IsDeduplicationEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				},
				"LeadManagementButtonVisible": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			details: /**SCHEMA_DETAILS*/{
				LeadsSimilarSearchResult: {
					schemaName: "LeadsSimilarSearchResultDetailV2",
					entitySchemaName: "Lead",
					filter: {
						masterColumn: "Id",
						detailColumn: "Id"
					}
				},
				SpecificationInLead: {
					schemaName: "LeadSpecificationDetailV2",
					entitySchemaName: "SpecificationInLead",
					filter: {
						masterColumn: "Id",
						detailColumn: "Lead"
					}
				},
				LeadEmail: {
					schemaName: "EmailDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Lead"
					},
					defaultValues: {
						Lead: {
							masterColumn: "Id"
						}
					},
					filterMethod: "getEmailDetailFilter"
				}
			}/**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * Returns filter for Email detail.
				 * @protected
				 * @return {Terrasoft.CompareFilter} Filter object.
				 */
				getEmailDetailFilter: function() {
					var recordId = this.get("Id");
					var filterGroup = new Terrasoft.createFilterGroup();
					filterGroup.add("Lead", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Lead", recordId));
					var emailType = ConfigurationConstants.Activity.Type.Email;
					filterGroup.add("ActivityType", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Type", emailType));
					return filterGroup;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initDefaultTabOnThePage();
					this.initSearchContactInInternetButtonMenu();
					this.initSearchAccountInInternetButtonMenu();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initContainersVisibility
				 * @overridden
				 */
				initContainersVisibility: function() {
					this.callParent(arguments);
					if (!this.getIsFeatureEnabled("OldUI")) {
						this.set("IsActionDashboardContainerVisible", true);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initActionButtonMenu
				 * @param {Object} config Additional parameters.
				 * @overridden
				 */
				initActionButtonMenu: function(config) {
					if (Ext.isEmpty(config) || config.callParent !== true) {
						this.initLeadManagement(function() {
							this.initActionButtonMenu({
								callParent: true,
								args: arguments
							});
						}, this);
					} else {
						this.callParent(config.args);
					}
				},

				/**
				 * Default tab initialization.
				 */
				initDefaultTabOnThePage: function() {
					this.set(this.getDefaultTabName(), true);
				},

				/**
				 * Returns id of qualified contact.
				 * @return {String} Id of qualified contact.
				 */
				getQualifiedContactId: function() {
					var qualifiedContact = this.get("QualifiedContact");
					if (qualifiedContact) {
						return qualifiedContact.value;
					}
				},

				/**
				 * QualifiedContact change event handler.
				 */
				onQualifiedContactChanged: function(callback, scope) {
					this.setQualifiedAccountByQualifiedContact();
					if (callback) {
						scope = scope || this;
						callback.call(scope);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1009);
					this.callParent(arguments);
				},

				/**
				 * Call method of deduplication lead service.
				 * @param {String} methodName Name of method.
				 * @param {Function} callback Callback function.
				 * @param {Object} config Additional parameters.
				 * @param {Object} scope Call context.
				 */
				callDeduplicationLeadServiceMethod: function(methodName, callback, config, scope) {
					ServiceHelper.callService("LeadService", methodName, callback, config, scope);
				},

				/**
				 * Returns query that selects QualifyStatuses.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.EntitySchemaQuery} Query to EntitySchema.
				 */
				getQualifyStatusEntitySchemaQuery: function() {
					var entitySchemaQuery = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "QualifyStatus"
					});
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					return entitySchemaQuery;
				},

				/**
				 * Sets value for the QualifyStatus.
				 * @protected
				 * @virtual
				 * @param {String} qualifyStatusId Unique identifier of the QualifyStatus.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				setQualifyStatus: function(qualifyStatusId, callback, scope) {
					var entitySchemaQuery = this.getQualifyStatusEntitySchemaQuery();
					entitySchemaQuery.getEntity(qualifyStatusId, function(response) {
						var entity = response.entity;
						if (entity) {
							this.set("QualifyStatus", {
								"value": entity.get("Id"),
								"displayValue": entity.get("Name")
							});
						}
						if (callback) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * Initializes default value for the column QualifyStatus.
				 * @protected
				 */
				initDefQualifyStatus: function() {
					var operation = this.get("Operation");
					if (operation === enums.CardStateV2.EDIT) {
						return;
					}
					var qualifyStatusId = this.getQualifyStatus();
					if (qualifyStatusId !== LeadConfigurationConst.LeadConst.QualifyStatus.Qualification) {
						return;
					}
					var qualifiedContactId = this.getQualifiedContactId();
					if (qualifiedContactId && !Terrasoft.isEmptyGUID(qualifiedContactId)) {
						qualifyStatusId = LeadConfigurationConst.LeadConst.QualifyStatus.Distribution;
						this.setQualifyStatus(qualifyStatusId);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					var primaryColumnValue = this.get("PrimaryColumnValue") || this.getPrimaryColumnValue();
					this.set("PrimaryColumnValue", primaryColumnValue);
					if (this.isNew) {
						this.setQualifiedAccountByQualifiedContact();
						this.initDefQualifyStatus();
					}
					this.initLeadManagementControls();
					this.initSearchInInternet();
					this.setIsDeduplicationEnabled();
					this.callParent(arguments);
				},

				/**
				 * Sets qualified account by qualified contact.
				 * @protected
				 */
				setQualifiedAccountByQualifiedContact: function() {
					var qualifiedAccount = this.get("QualifiedAccount");
					if (!qualifiedAccount) {
						var qualifiedContactId = this.getQualifiedContactId();
						if (qualifiedContactId) {
							this.getContactById(qualifiedContactId, this.setQualifiedAccountFormContact);
						}
					}
				},

				/**
				 * Returns contact by identifier.
				 * @param {GUID} contactId The contact identifier.
				 * @param {Function} callback Callback function.
				 * @protected
				 */
				getContactById: function(contactId, callback) {
					this.readEntity("Contact", contactId, ["Account"], callback);
				},

				/**
				 * Sets qualified account from contact.
				 * @param {Terrasoft.BaseViewModel} contact The contact.
				 */
				setQualifiedAccountFormContact: function(contact) {
					var account = contact.get("Account");
					if (account) {
						this.set("QualifiedAccount", account);
					}
				},

				/**
				 * Sets "Deduplication" feature enabled flag.
				 */
				setIsDeduplicationEnabled: function() {
					var isElasticDeduplicationEnabled = this.getIsFeatureEnabled("ESDeduplication");
					var isDeduplicationEnabled = this.getIsFeatureEnabled("Deduplication");
					var isEnabled = isElasticDeduplicationEnabled || isDeduplicationEnabled;
					this.set("IsDeduplicationEnabled", isEnabled);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#validateResponse
				 * @overridden
				 */
				validateResponse: function() {
					var result = this.callParent(arguments);
					if (!result) {
						this.set("LockBodyMask", false);
						this.hideBodyMask();
					}
					return result;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function(response, config) {
					if (config && config.lockBodyMask && !this.isNewMode()) {
						this.set("LockBodyMask", true);
					}
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#hideBodyMask
				 * @overridden
				 */
				hideBodyMask: function() {
					if (this.get("LockBodyMask") !== true) {
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.LeadPageV2#checkRequiredActionColumns
				 * @overridden
				 */
				checkRequiredActionColumns: function() {
					return true;
				},

				/**
				 * Validates that status is equal to Disqualified.
				 * @param {Object} qualifyStatus Status of the lead.
				 * @return {bool} Boolean result.
				 */
				getIsDisqualifiedStatus: function(qualifyStatus) {
					return (qualifyStatus && (qualifyStatus.value ===
						LeadConfigurationConst.LeadConst.QualifyStatus.Disqualified));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onGetEntityInfo
				 * @overridden
				 */
				onGetEntityInfo: function() {
					var entityInfo = this.callParent(arguments) || {};
					entityInfo.QualifyStatus = this.get("QualifyStatus");
					return entityInfo;
				},

				/**
				 * Calls method of the card page.
				 * @param {Object} config Configuration of call.
				 * @return {Object} Result of the method execution.
				 * @overridden
				 */
				onCardAction: function(config) {
					if (Ext.isObject(config)) {
						var method = this[config.methodName];
						return method.apply(config.scope || this, config.args);
					} else {
						return this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getActions
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.callParent(arguments);
					var menuSeparator = this.getButtonMenuItem({
						"Type": "Terrasoft.MenuSeparator"
					});
					actionMenuItems.addItem(menuSeparator);
					var disqualificationMenuItems = this.get("DisqualificationMenuItems");
					disqualificationMenuItems.each(function(item) {
						actionMenuItems.addItem(item);
					});
					return actionMenuItems;
				},

				/**
				 * Get search button menu items for lead Contact.
				 * @protected
				 * @return {Object} Search contact in internet items collection.
				 */
				getSearchContactInInternetMenuItems: function() {
					var searchContactInInternetMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					searchContactInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchLinkedIn"),
						"Enabled": true,
						"Click": {bindTo: "onSearchContactInLinkedInButtonClick"}
					}));
					searchContactInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchFacebook"),
						"Enabled": true,
						"Click": {bindTo: "onSearchContactInFacebookButtonClick"}
					}));
					return searchContactInInternetMenuItems;
				},

				/**
				 * Get search button menu items for lead Account.
				 * @protected
				 * @return {Object} Search account in internet items collection.
				 */
				getSearchAccountInInternetMenuItems: function() {
					var searchAccountInInternetMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					searchAccountInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchLinkedIn"),
						"Enabled": true,
						"Click": {bindTo: "onSearchAccountInLinkedInButtonClick"}
					}));
					searchAccountInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchGoogle"),
						"Enabled": true,
						"Click": {bindTo: "onSearchAccountInGoogleButtonClick"}
					}));
					return searchAccountInInternetMenuItems;
				},

				/**
				 * Initialize search button menu items for lead Contact.
				 * @protected
				 */
				initSearchContactInInternetButtonMenu: function() {
					var searchContactInInternetMenuItems = this.getSearchContactInInternetMenuItems();
					this.set("SearchContactInInternetMenuItems", searchContactInInternetMenuItems);
				},

				/**
				 * Initialize search button menu items for lead Account.
				 * @protected
				 */
				initSearchAccountInInternetButtonMenu: function() {
					var searchAccountInInternetMenuItems = this.getSearchAccountInInternetMenuItems();
					this.set("SearchAccountInInternetMenuItems", searchAccountInInternetMenuItems);
				},

				/**
				 * Search in LinkedIn by lead Contact and Account.
				 * @protected
				 */
				onSearchContactInLinkedInButtonClick: function() {
					var contact = this.get("Contact");
					var account = this.get("Account");
					if (this.Ext.isEmpty(contact) && this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchContactInLinkedInNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						var keywords = [contact, account];
						this.searchInLinkedIn(keywords);
					}
				},

				/**
				 * Search in LinkedIn by lead Account.
				 * @protected
				 */
				onSearchAccountInLinkedInButtonClick: function() {
					var account = this.get("Account");
					if (this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchAccountInLinkedInNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInLinkedIn([account]);
					}
				},

				/**
				 * Search in Facebook by lead Email.
				 * @protected
				 */
				onSearchContactInFacebookButtonClick: function() {
					var email = this.get("Email");
					if (this.Ext.isEmpty(email)) {
						var message = this.get("Resources.Strings.SearchContactInFacebookNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInFacebook([email]);
					}
				},

				/**
				 * Search in Google by lead Account.
				 * @protected
				 */
				onSearchAccountInGoogleButtonClick: function() {
					var account = this.get("Account");
					if (this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchAccountInGoogleNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInGoogle([account]);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#findDuplicatesByActiveRules
				 * @override
				 */
				findDuplicatesByActiveRules: function(callback, scope) {
					const data = this.getElasticDuplicatesServiceData(this.getDuplicatesRuleConfig());
					this.callService({
						data: data,
						serviceName: "DeduplicationServiceV2",
						methodName: "FindSimilarLeads",
						encodeData: false
					}, function(response) {
						this.setLeadsDuplicates(response);
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.DuplicatesSearchUtilitiesV2#getDuplicateSchemaName
				 * @override
				 */
				getDuplicateSchemaName: function() {
					return "Lead";
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getDuplicatesRuleConfig
				 * @override
				 */
				getDuplicatesRuleConfig: function() {
					return {
						findByActiveRules: true,
						excludeUnique: true
					};
				},

				/**
				 * Analize service response and set similar lead filter for detail.
				 * @param {String} response Service response.
				 */
				setLeadsDuplicates: function(response) {
					if (!response) {
						return;
					}
					const similarLeadResult = [];
					const duplicatesOnSaveResult = response.FindSimilarLeadsResult;
					const similarLeadCollection = Ext.isEmpty(duplicatesOnSaveResult)
						? null
						: JSON.parse(duplicatesOnSaveResult);
					if (!Ext.isEmpty(similarLeadCollection)) {
						similarLeadCollection.forEach(function(item) {
							similarLeadResult.push(item.Id);
						}.bind(this));
					}
					this.set("DuplicatesRecords", similarLeadResult);
				},
			},
			modules: /**SCHEMA_MODULES*/{
				"AccountProfile": {
					"config": {
						"schemaName": "LeadAccountProfileSchema",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								masterColumnName: "QualifiedAccount"
							}
						}
					}
				},
				"ContactProfile": {
					"config": {
						"schemaName": "LeadContactProfileSchema",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								masterColumnName: "QualifiedContact"
							}
						}
					}
				}
			}, /**SCHEMA_MODULES*/
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "LeadPageCategorizationContainer"
				},
				{
					"operation": "remove",
					"name": "LeadPageGeneralTabContentGroup"
				},
				{
					"operation": "remove",
					"name": "LeadPageAccountInfo"
				},
				{
					"operation": "remove",
					"name": "LeadPageCommunicationContainer"
				},
				{
					"operation": "remove",
					"name": "LeadPageAddressContainer"
				},
				{
					"operation": "move",
					"name": "Header",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "merge",
					"name": "Header",
					"parentName": "LeftModulesContainer",
					"values": {
						"classes": {
							"wrapClassName": ["profile-container", "autofill-layout"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"name": "AccountProfile",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE
					}
				},
				{
					"operation": "insert",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"name": "ContactProfile",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE
					}
				},
				{
					"operation": "insert",
					"name": "NeedInfoTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1,
					"alias": {
						"name": "NeedInfoTabContainer"
					},
					"values": {
						"caption": {"bindTo": "Resources.Strings.NeedInfoTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "NeedInfoTab",
					"propertyName": "items",
					"name": "SpecificationInLead",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "move",
					"parentName": "NeedInfoTab",
					"propertyName": "items",
					"name": "LeadProduct",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1,
					"name": "LeadsSimilarSearchResult",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL,
						"visible": {"bindTo": "IsDeduplicationEnabled"}
					}
				},
				{
					"operation": "insert",
					"parentName": "NeedInfoTab",
					"name": "LeadTypeControlGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeControlGroup",
					"name": "LeadTypeBlock",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"parentName": "LeftContainer",
					"propertyName": "items",
					"name": "QualificationProcessButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.GREEN,
						"caption": {"bindTo": "QualificationProcessButtonCaption"},
						"markerValue": {"bindTo": "QualificationProcessButtonCaption"},
						"classes": {"wrapperClass": ["actions-button-margin-right"]},
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
						"imageConfig": resources.localizableImages.QualificationProcessButtonImage,
						"click": {"bindTo": "onLeadManagementButtonClick"},
						"layout": {
							"column": 6,
							"row": 0,
							"colSpan": 2
						},
						"visible": {"bindTo": "LeadManagementButtonVisible"}
					}
				},
				{
					"operation": "insert",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"name": "NewLeadDisqualifyReason",
					"values": {
						"bindTo": "LeadDisqualifyReason",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"visible": {
							"bindTo": "QualifyStatus",
							"bindConfig": {"converter": "getIsDisqualifiedStatus"}
						},
					},
					"alias": {
						"name": "LeadDisqualifyReason",
						"excludeProperties": ["layout"],
						"excludeOperations": ["remove", "move"]
					}
				},
				{
					"operation": "insert",
					"name": "SearchInSocialNetworksButton",
					"parentName": "LeadPageRegisterInfoBlock",
					"propertyName": "items",
					"values": {
						"id": "search-social-networks-button",
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"classes": {
							"wrapperClass": ["photo-icon-wrapper"],
							"imageClass": ["field-img-btn"]
						},
						"controlConfig": {
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"iconAlign": this.Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
							"imageConfig": {"bindTo": "Resources.Images.SearchInternetButtonImage"},
							"menu": {
								"items": {
									"bindTo": "SearchContactInInternetMenuItems"
								}
							}
						},
						"layout": {
							"column": 10,
							"row": 0,
							"colSpan": 1
						},
						"markerValue": "searchInSocialNetworksButton"
					}
				},
				{
					"operation": "insert",
					"name": "SearchInGoogleButton",
					"parentName": "LeadPageRegisterInfoBlock",
					"propertyName": "items",
					"values": {
						"id": "search-google-button",
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"classes": {
							"wrapperClass": ["photo-icon-wrapper"],
							"imageClass": ["field-img-btn"]
						},
						"controlConfig": {
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"iconAlign": this.Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
							"imageConfig": {"bindTo": "Resources.Images.SearchInternetButtonImage"},
							"menu": {
								"items": {
									"bindTo": "SearchAccountInInternetMenuItems"
								}
							}
						},
						"layout": {
							"column": 22,
							"row": 0,
							"colSpan": 1
						},
						"markerValue": "searchInGoogleButton"
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeBlock",
					"propertyName": "items",
					"name": "LeadTypeStatus",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"itemType": Terrasoft.ViewItemType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeBlock",
					"propertyName": "items",
					"name": "Commentary",
					"values": {
						"enabled": {"bindTo": "SourceDataEditable"},
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24,
							"rowSpan": 2
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "OpportunityDepartment",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"enabled": {"bindTo": "SourceDataEditable"}
					}
				},
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "LeadEmail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"LeadTypeStatus": {
					"LeadTypeStatusRequired": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"dataValueType": Terrasoft.DataValueType.BOOLEAN,
								"value": true
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"dataValueType": Terrasoft.DataValueType.BOOLEAN,
								"value": true
							}
						}]
					}
				},				
				"Region": {
					"EnabledRegion": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"City": {
					"EnabledCity": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Title": {
					"EnabledTitle": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Industry": {
					"EnabledIndustry": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"AnnualRevenue": {
					"EnabledAnnualRevenue": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"FullJobTitle": {
					"EnabledFullJobTitle": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"BusinesPhone": {
					"EnabledBusinesPhone": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Fax": {
					"EnabledFax": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"AddressType": {
					"EnabledAddressType": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Zip": {
					"EnabledZip": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Address": {
					"EnabledAddress": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Notes": {
					"EnabledNotes": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				}
			}
		};
	});

define('LeadPageV2WebLeadFormResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2WebLeadForm", function() {
	return {
		entitySchemaName: "Lead",
		details: /**SCHEMA_DETAILS*/{
		}/**SCHEMA_DETAILS*/,
		methods: {
			/**
			 * Logic to collapse Unconfirmed data group.
			 * @return {Boolean}
			 */
			getWebFormUnconfirmedDataGroupCollapsed: function() {
				return !this.get("isCheckedEnabled");
			},

			/**
			 * Logic to set visible unconfirmed data group.
			 * @return {Boolean}
			 */
			getWebFormUnconfirmedDataGroupVisible: function() {
				if (this.getWebFormFilledIn()) {
					return false;
				}
				var isAddressUnresolved = !this.Ext.isEmpty(this.get("CountryStr")) && this.Ext.isEmpty(this.get("Country"));
				isAddressUnresolved = isAddressUnresolved || (!this.Ext.isEmpty(this.get("RegionStr")) &&
						this.Ext.isEmpty(this.get("Region")));
				isAddressUnresolved = isAddressUnresolved || (!this.Ext.isEmpty(this.get("CityStr")) &&
						this.Ext.isEmpty(this.get("City")));
				return isAddressUnresolved;
			},

			getWebFormFilledIn: function() {
				return !this.Ext.isEmpty(this.get("WebForm"));
			},
			/**
			 * Toll tip click handler for group "ContactCommunications".
			 * @protected
			 */
			showLeadPageNeedValidationInfoToolTip: function() {
				this.showInformationDialog(this.get("Resources.Strings.LeadPageNeedValidationInfo"));
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"name": "LeadPageNeedValidationGroup",
				"values": {
					"caption": {"bindTo": "Resources.Strings.LeadPageNeedValidationBlockCaption"},
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"tools": [],
					"controlConfig": {
						"collapsed": {"bindTo": "getWebFormUnconfirmedDataGroupCollapsed"}
					},
					"visible": {"bindTo": "getWebFormUnconfirmedDataGroupVisible"}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationGroup",
				"propertyName": "items",
				"name": "LeadPageNeedValidationBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "LeadWebFormInProfile",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.LOOKUP,
					"enabled": false,
					"visible": {"bindTo": "getWebFormFilledIn"},
					"bindTo": "WebForm"
				},
				"alias": {
					"name": "WebFormInProfile",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "WebForm",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"contentType": Terrasoft.ContentType.LOOKUP,
					"enabled": false,
					"bindTo": "WebForm"
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationGroup",
				"propertyName": "tools",
				"name": "LeadPageNeedValidationInfoToolTip",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {"bindTo": "Resources.Images.InfoSpriteImage"},
					"classes": {
						"wrapperClass": "info-button-lead-group",
						"imageClass": "info-button-lead-group-image"
					},
					"showTooltip": false,
					"click": {"bindTo": "showLeadPageNeedValidationInfoToolTip"}
				},
				"index": 1
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "CountryStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.CountryStrCaption"},
					"caption": {"bindTo": "Resources.Strings.CountryStrCaption"},
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "RegionStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.RegionStrCaption"},
					"caption": {"bindTo": "Resources.Strings.RegionStrCaption"},
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "CityStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.CityStrCaption"},
					"caption": {"bindTo": "Resources.Strings.CityStrCaption"},
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "BpmRef",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"enabled": false
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('LeadPageV2TrackingResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2Tracking",
	(function () {
		var dependencies = ["LeadPageV2Resources", "css!TrackingLeadPageV2CSS"];
		if (!Ext.isIEOrEdge) {
			dependencies.push("TrackingEventsFeedElement");
		}
		return dependencies;
	})(),
	function (resources) {
		return {
			entitySchemaName: "Lead",
			attributes: {

				/**
				 * Is should show blank slate.
				 */
				"IsBlankSlateVisible": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				}
			},
			methods: {

				/**
				 * @private
				 */
				_isBlankSlateInvisible: function () {
					return !this.$IsBlankSlateVisible;
				},

				/**
				 * @private
				 */
				_getTrackingFeatureState: function () {
					return this.Terrasoft.Features.getIsEnabled("Tracking");
				},

				/**
				 * @private
				 */
				_setTrackingTabVisibility: function () {
					if (!this._getTrackingFeatureState()) {
						var tabCollection = this.get("TabsCollection");
						if (tabCollection.contains("TrackingEventsTab")) {
							tabCollection.removeByKey("TrackingEventsTab");
						}
					}
				},

				/**
				 * @private
				 */
				_appendTrackingEventFeedDomElement: function () {
					const element = document.createElement("ts-tracking-events-feed");
					element.entityId = this.$PrimaryColumnValue;
					element.resources = resources;
					element.schema = "LEAD";
					element.id = "TrackingEventFeed";
					var eventFeedContainer = document.querySelector("#EventsFeedContainer");
					eventFeedContainer.appendChild(element);
				},

				/**
				 * @private
				 */
				_destroyTrackingEventFeedDomElement: function () {
					var trackingEventFeed = Ext.get("TrackingEventFeed");
					trackingEventFeed.destroy();
				},

				/**
				 * @private
				 */
				_recreateTrackingEventFeedDomElement: function () {
					this._destroyTrackingEventFeedDomElement();
					this._appendTrackingEventFeedDomElement();
				},

				/**
				 * @private
				 */
				_afterEventsFeedContainerRender: function () {
					if (this.$IsBlankSlateVisible) {
						return;
					}
					this._appendTrackingEventFeedDomElement();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function () {
					this.callParent(arguments);
					if (this.$ActiveTabName === "TrackingEventsTab" && !this.$IsBlankSlateVisible) {
						this._recreateTrackingEventFeedDomElement();
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
				 * @overridden
				 */
				onRender: function () {
					this.callParent(arguments);
					this.$IsBlankSlateVisible = this.Ext.isIEOrEdge;
				},

				/**
				 * Returns blank slate icon url.
				 * @protected
				 * @virtual
				 * @return {String} Blank slate icon url.
				 */
				getBlankSlateIcon: function () {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.BlankSlateIcon"));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @override
				 */
				init: function () {
					this.callParent(arguments);
					this._setTrackingTabVisibility();
				}
			},
			diff: [
				{
					"operation": "insert",
					"name": "TrackingEventsTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": "$Resources.Strings.TrackingEventsTabCaption",
						"items": [],
						"styles": {
							"height": "calc(100% - 3.8em)",
							"width": "100%"
						},
						"order": 4
					}
				},
				{
					"operation": "insert",
					"name": "TrackingEventsLayout",
					"parentName": "TrackingEventsTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TrackingEventsContainer",
					"parentName": "TrackingEventsLayout",
					"propertyName": "items",
					"values": {
						"markerValue": "TrackingEventsContainer",
						"id": "TrackingEventsContainer",
						"selectors": { "wrapEl": "#TrackingEventsContainer" },
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"layout": { "column": 0, "row": 0, "rowSpan": 6, "colSpan": 24 },
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoContainer",
					"parentName": "TrackingEventsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"classes": {
							"wrapClassName": ["wrong-browser-info-wrap"]
						},
						"styles": {
							"height": "100%",
							"width": "100%"
						},
						"visible": "$IsBlankSlateVisible",
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoIcon",
					"parentName": "WrongBrowserInfoContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getBlankSlateIcon",
						"readonly": true,
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"classes": {
							"wrapClass": ["wrong-browser-info-icon"]
						},
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24,
							"rowSpan": 5
						}
					}
				},
				{
					"operation": "insert",
					"name": "WrongBrowserInfoDescription",
					"parentName": "WrongBrowserInfoContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.BlankSlateDescription",
						"labelClass": ["wrong-browser-info-description"],
						"layout": {
							"column": 3,
							"row": 6,
							"colSpan": 20,
							"rowSpan": 6
						}
					}
				},
				{
					"operation": "insert",
					"name": "EventsFeedContainer",
					"parentName": "TrackingEventsContainer",
					"propertyName": "items",
					"values": {
						"id": "EventsFeedContainer",
						"items": [],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"afterrender": "$_afterEventsFeedContainerRender",
						"afterrerender": "$_afterEventsFeedContainerRender",
						"visible": "$_isBlankSlateInvisible"
					}
				}
			]
		};
	}
);
define('LeadPageV2SocialLeadGenResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2SocialLeadGen", [], function() {
	return {
		entitySchemaName: "Lead",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"LeadGenExtendedLeadInformationDetail": {
				"schemaName": "LeadGenExtendedLeadInformationDetail",
				"entitySchemaName": "LeadGenExtendedLeadInformation",
				"filter": {
					"detailColumn": "Id",
					"masterColumn": "LeadGenExtendedLeadInfo"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			/**
			 * @private
			 */
			_getSocialLeadGenSectionFeatureState: function () {
				return this.getIsFeatureEnabled("SocialLeadGenSection");
			},
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "NewLeadType",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "NewLeadDisqualifyReason",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "move",
				"name": "NewLeadDisqualifyReason",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "LeadRegisterMethodInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadWebFormInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "LeadWebFormInProfile",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "LeadBudget",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadCreatedOn",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadOwner",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadPredictiveScoreContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 8
					}
				}
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"order": 0
				}
			},
			{
				"operation": "merge",
				"name": "SearchInSocialNetworksButton",
				"values": {
					"layout": {
						"colSpan": 1,
						"rowSpan": 1,
						"column": 10,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "SearchInSocialNetworksButton",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "SearchInGoogleButton",
				"values": {
					"layout": {
						"colSpan": 1,
						"rowSpan": 1,
						"column": 22,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "SearchInGoogleButton",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "Contact",
				"values": {
					"layout": {
						"colSpan": 10,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Account",
				"values": {
					"layout": {
						"colSpan": 10,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "Account",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "Job",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "EmployeesNumber",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "MobilePhone",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "move",
				"name": "MobilePhone",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "merge",
				"name": "Country",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "Email",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "Email",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 8
			},
			{
				"operation": "merge",
				"name": "Website",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "CountryStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "RegionStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "CityStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "LeadGenExtendedLeadInformationDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": "$_getSocialLeadGenSectionFeatureState"
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "merge",
				"name": "NeedInfoTab",
				"values": {
					"order": 1
				}
			},
			{
				"operation": "merge",
				"name": "LeadTypeStatus",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadEngagementTab",
				"values": {
					"order": 2
				}
			},
			{
				"operation": "merge",
				"name": "LeadMedium",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "BpmRef",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "BpmRef",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "LeadSource",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "WebForm",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "move",
				"name": "WebForm",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "RegisterMethod",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "DealSpecificsTab",
				"values": {
					"order": 4
				}
			},
			{
				"operation": "merge",
				"name": "Budget",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "NextActualizationDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "NextActualizationDate",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "SalesOwner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "MeetingDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "DecisionDate",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityDepartment",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "HistoryTab",
				"values": {
					"order": 5
				}
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 7
				}
			},
			{
				"operation": "merge",
				"name": "NotesTab",
				"values": {
					"order": 6
				}
			}
		]/**SCHEMA_DIFF*/
	};
});

define('LeadPageV2OrderLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2OrderLead", ["LeadPageV2Resources", "BusinessRuleModule", "LeadConfigurationConst"],
	function(resources, BusinessRuleModule, LeadConfigurationConst) {
		return {
			entitySchemaName: "Lead",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			attributes: {},
			methods: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "move",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "SalesOwner",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"contentType": Terrasoft.ContentType.LOOKUP,
						"bindTo": "SalesOwner"
					}
				},
				{
					"operation": "move",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "OpportunityDepartment",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"enabled": {"bindTo": "SourceDataEditable"}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "Order",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"Order": {
					"FilterOrderByAccount": {
						ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
						autocomplete: true,
						baseAttributePatch: "Account",
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						attribute: "QualifiedAccount"
					},
					"EnabledOrderForQualifyStatus": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "QualifyStatus"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: LeadConfigurationConst.LeadConst.QualifyStatus.WaitingForSale
							}
						}]
					}
				}
			},
			userCode: {}
		};
	});

define('LeadPageV2PRMBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2PRMBase", ["BusinessRuleModule", "ConfigurationConstants"],
		function(BusinessRuleModule, ConfigurationConstants) {
			return {
				entitySchemaName: "Lead",
				attributes: {
					"PartnersSaleOpportunityType": {
						"dataValueType": Terrasoft.DataValueType.TEXT,
						"value": ConfigurationConstants.Opportunity.Type.PartnerSale
					},
					"Partner": {
						"dependencies": [
							{
								"columns": ["SalesChannel"],
								"methodName": "onSalesChannelChanged"
							},
							{
								"columns": ["Owner"],
								"methodName": "onOwnerChanged"
							}
						],
						"onChange": "autoCompleteOwner",
						"lookupListConfig": {
							"columns": [
								"[VwSystemUsers:Contact:PrimaryContact].Contact"
							]
						}
					},
					"PartnerAccountType": {
						"dataValueType": Terrasoft.DataValueType.GUID,
						"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						"value": ConfigurationConstants.AccountType.Partner
					},
					"Owner": {
						"dataValueType": Terrasoft.DataValueType.LOOKUP,
						"lookupListConfig": {
							"filter": function () {
								return this.getOwnerFilter("SalesChannel");
							},
							"columns": [
								"Account.Type"
							]
						}
					}
				},
				details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"parentName": "ProfileContainer",
						"propertyName": "items",
						"name": "SalesChannel",
						"values": {
							"layout": {
								"column": 0,
								"row": 7,
								"colSpan": 24
							},
							"contentType": Terrasoft.ContentType.ENUM
						}
					},
					{
						"operation": "insert",
						"parentName": "ProfileContainer",
						"propertyName": "items",
						"name": "Partner",
						"values": {
							"layout": {
								"column": 0,
								"row": 8,
								"colSpan": 24
							}
						}
					}
				],
				methods: {

					/**
					 * SalesChannel changed event method handler.
					 */
					onSalesChannelChanged: function() {
						this.clearPartnerIfColumnChange("SalesChannel");
					},

					/**
					 * Handle Owner column change.
					 */
					onOwnerChanged: function() {
						this.fillPartnerByOwner();
					}
				},
				rules: {
					"Partner": {
						"VisibleRule": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"property": BusinessRuleModule.enums.Property.VISIBLE,
							"conditions": [{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "SalesChannel"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "PartnersSaleOpportunityType"
								}
							}]
						},
						"RequiredRule": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"property": BusinessRuleModule.enums.Property.REQUIRED,
							"conditions": [{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "SalesChannel"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "PartnersSaleOpportunityType"
								}
							}]
						},
						"FiltrationPartnerByAccountType": {
							"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
							"autocomplete": true,
							"baseAttributePatch": "Type",
							"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
							"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							"attribute": "PartnerAccountType"
						}
					},
					"Owner": {
						"RequiredRule": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"property": BusinessRuleModule.enums.Property.REQUIRED,
							"conditions": [{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "SalesChannel"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "PartnersSaleOpportunityType"
								}
							}]
						}
					}
				}
		};
	});

define('LeadPageV2LeadManagementResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2LeadManagement", ["css!LeadPageV2ManagementCSS", "SalesReadyLeadLifecycleMixin"], function() {
	return {
		entitySchemaName: "Lead",
		mixins: {
			SalesReadyLeadLifecycleMixin: "Terrasoft.SalesReadyLeadLifecycleMixin"
		},
		modules: /**SCHEMA_MODULES*/{
			"AccountProfileDesc": {
				"config": {
					"schemaName": "LeadAccountProfileSchema",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"parameters": {
						"viewModelConfig": {
							"masterColumnName": "QualifiedAccount"
						}
					}
				}
			},
			"ContactProfileDesc": {
				"config": {
					"schemaName": "LeadContactProfileSchema",
					"isSchemaConfigInitialized": true,
					"useHistoryState": false,
					"parameters": {
						"viewModelConfig": {
							"masterColumnName": "QualifiedContact"
						}
					}
				}
			}
		}/**SCHEMA_MODULES*/,
		messages: {
			/**
			 * @message UpdateCommunicationDetail
			 * Updates detail.
			 */
			"UpdateCommunicationDetail": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},
		},
		attributes: {
			/**
			 * Qualified contact.
			 */
			"QualifiedContact": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				lookupListConfig: {
					columns: ["Email"]
				},
				onChange: "onQualifiedContactChange"
			},

			/**
			 * The qualification stage id.
			 * @type {Boolean}
			 */
			"QualificationStageId": {
				dataValueType: this.Terrasoft.DataValueType.GUID,
				value: "d790a45d-03ff-4ddb-9dea-8087722c582c"
			},
		},
		details: /**SCHEMA_DETAILS*/{
			"ContactCommunicationDetail": {
				"schemaName": "ContactCommunicationDetail",
				"entitySchemaName": "ContactCommunication",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"CallDetail": {
				"schemaName": "CallDetail",
				"entitySchemaName": "Call",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"EmailDetailV2": {
				"schemaName": "EmailDetailV2",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				},
				"defaultValues": {
					"Lead": {
						"masterColumn": "Id"
					}
				},
				"filterMethod": "getEmailDetailFilter"
			},
			"ContactActivityDetailV2": {
				"schemaName": "ActivityDetailV2",
				"entitySchemaName": "Activity",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"AccountActivityDetailV2": {
				"schemaName": "ActivityDetailV2",
				"entitySchemaName": "Activity",
				"filter": {
					"detailColumn": "Account",
					"masterColumn": "QualifiedAccount"
				}
			},
			"ContactAddressDetailV2": {
				"schemaName": "ContactAddressDetailV2",
				"entitySchemaName": "ContactAddress",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"LeadsSimilarSearchResultDetail": {
				"schemaName": "LeadsSimilarSearchResultDetailV2",
				"entitySchemaName": "Lead",
				"filter": {
					"detailColumn": "Id",
					"masterColumn": "Id"
				}
			},
			"ContactCommunicationDetailV2": {
				"schemaName": "ContactCommunicationDetail",
				"entitySchemaName": "ContactCommunication",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"LeadSpecificationDetail": {
				"schemaName": "LeadSpecificationDetailV2",
				"entitySchemaName": "SpecificationInLead",
				"filter": {
					"detailColumn": "Lead",
					"masterColumn": "Id"
				}
			},
			"LeadProductDetailV2": {
				"schemaName": "LeadProductDetailV2",
				"entitySchemaName": "LeadProduct",
				"filter": {
					"detailColumn": "Lead",
					"masterColumn": "Id"
				}
			},
			"AccountCallDetail": {
				"schemaName": "CallDetail",
				"entitySchemaName": "Call",
				"filter": {
					"detailColumn": "Account",
					"masterColumn": "QualifiedAccount"
				}
			},
			"AccountAddressDetail": {
				"schemaName": "AccountAddressDetailV2",
				"entitySchemaName": "AccountAddress",
				"filter": {
					"detailColumn": "Account",
					"masterColumn": "QualifiedAccount"
				}
			},
			"ContactCallDetailV2": {
				"schemaName": "CallDetail",
				"entitySchemaName": "Call",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			},
			"ContactAddressDetail": {
				"schemaName": "ContactAddressDetailV2",
				"entitySchemaName": "ContactAddress",
				"filter": {
					"detailColumn": "Contact",
					"masterColumn": "QualifiedContact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"GeneralInfoTab": {
				"ShowElementOnThePage_GeneralInfoTab": {
					"uId": "f0b371cd-fda2-4239-ac28-c2e2d48de435",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 2,
								"value": "UseTheSalesReadyLeadLifecycle",
								"dataValueType": 12
							},
							"rightExpression": {
								"type": 0,
								"value": false,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"NeedInfoTab": {
				"ShowElementOnThePage_NeedInfoTab": {
					"uId": "3415d680-75a0-4647-9a65-557d215fb60e",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 2,
								"value": "UseTheSalesReadyLeadLifecycle",
								"dataValueType": 12
							},
							"rightExpression": {
								"type": 0,
								"value": false,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"LeadEngagementTab": {
				"ShowElementOnThePage_LeadEngagementTab": {
					"uId": "abac5fb6-cc85-41f3-af63-98dee875f72e",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 2,
								"value": "UseTheSalesReadyLeadLifecycle",
								"dataValueType": 12
							},
							"rightExpression": {
								"type": 0,
								"value": false,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"TrackingEventsTab": {
				"ShowElementOnThePage_TrackingEventsTab": {
					"uId": "344c2fee-4749-4e53-819e-9adc59822654",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 2,
								"value": "UseTheSalesReadyLeadLifecycle",
								"dataValueType": 12
							},
							"rightExpression": {
								"type": 0,
								"value": false,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"DealSpecificsTab": {
				"ShowElementOnThePage_DealSpecificsTab": {
					"uId": "7e99a92b-f341-47dd-bfcc-fbf110ebec10",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 3,
							"leftExpression": {
								"type": 2,
								"value": "UseTheSalesReadyLeadLifecycle",
								"dataValueType": 12
							},
							"rightExpression": {
								"type": 0,
								"value": false,
								"dataValueType": 12
							}
						}
					]
				}
			},
			"AccountActivityDetailV2": {
				"ShowElementOnThePage_AccountActivityDetailV2": {
					"uId": "183e3055-bfb6-4269-91cf-89abbb289464",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedAccount"
							}
						}
					]
				}
			},
			"AccountAddressDetail": {
				"ShowElementOnThePage_AccountAddressDetail": {
					"uId": "207b5dd6-f9fc-484d-ba7f-45f28ecf63b0",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedAccount"
							}
						}
					]
				}
			},
			"AccountCallDetail": {
				"ShowElementOnThePage_AccountCallDetail": {
					"uId": "eafc838a-3217-46c6-a7e9-3d7212810cb9",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedAccount"
							}
						}
					]
				}
			},
			"ContactCallDetailV2": {
				"ShowElementOnThePage_ContactCallDetailV2": {
					"uId": "9ab58bfd-f9e5-45c6-903c-ebfc8fe4ea2e",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 1,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedAccount"
							}
						},
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"ContactAddressDetail": {
				"ShowElementOnThePage_ContactAddressDetail": {
					"uId": "f3f861f5-1af4-4247-91c8-77127e4787cd",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 1,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedAccount"
							}
						},
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"ContactAddressDetailV2": {
				"ShowElementOnThePage_ContactAddressDetailV2": {
					"uId": "e61fe9d0-49a0-4deb-8b87-3be235b62f78",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"ContactActivityDetailV2": {
				"ShowElementOnThePage_ContactActivityDetailV2": {
					"uId": "2f7a3cd0-97ba-472a-9478-886ecf58b99a",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"EmailDetailV2": {
				"ShowElementOnThePage_EmailDetailV2": {
					"uId": "e698125b-623c-47f3-80fe-7f00b46b1902",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"CallDetail": {
				"ShowElementOnThePage_CallDetail": {
					"uId": "2f50b5e3-b196-47f6-8599-e5fc3b1ba8b5",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"ContactCommunicationDetail": {
				"ShowElementOnThePage_ContactCommunicationDetail": {
					"uId": "3d314c48-9eb8-4666-b747-98c681937e70",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			},
			"ContactCommunicationDetailV2": {
				"ShowElementOnThePage_ContactCommunicationDetailV2": {
					"uId": "3d314c48-9eb8-4666-b747-98c681937e71",
					"enabled": true,
					"removed": false,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "QualifiedContact"
							}
						}
					]
				}
			}
		}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			
			//region Methods: Protected

			/**
			 * Updates contact communication detail data.
			 * @protected
			 */
			updateCommunicationDetail: function() {
				var communicationDetailId = this.getDetailId("ContactCommunicationDetail");
				var communicationDetailV2Id = this.getDetailId("ContactCommunicationDetailV2");
				this.sandbox.publish("UpdateCommunicationDetail", null, [communicationDetailId]);
				this.sandbox.publish("UpdateCommunicationDetail", null, [communicationDetailV2Id]);
			},
			
			/**
			 * Handles QualifiedContact field change.
			 * @protected
			 */
			onQualifiedContactChange: function(model, value) {
				if(value) {
					this.updateCommunicationDetail();
				}
			},

			/**
			 * Returns array of detail names that are duplicating on page.
			 * @virtual
			 * @return {String[]} Array of detail names. 
			 */
			getDuplicateDetail: function() {
				return ["ContactCommunicationDetail", "ContactCommunicationDetailV2", "CallDetail", "EmailDetailV2", 
					"ContactActivityDetailV2", "AccountActivityDetailV2", "ContactAddressDetailV2", 
					"LeadsSimilarSearchResultDetail", "LeadSpecificationDetail", "LeadProductDetailV2", 
					"AccountCallDetail", "AccountAddressDetail", "ContactCallDetailV2", "ContactAddressDetail"];	
			},
			
			/**
			 * @inheritdoc Terrasoft.BaseEntityPage#getDetailInfo
			 * @override
			 */
			getDetailInfo: function() {
				const detailInfo = this.callParent(arguments);
				const duplicateDetails = this.getDuplicateDetail();
				if (duplicateDetails.includes(detailInfo.detailName)) {
					detailInfo.detailElementsPrefix = Terrasoft.generateGUID();
				}
				return detailInfo;
			},
			
			/**
			 * @inheritdoc Terrasoft.LeadPageV2#init
			 * @override
			 */
			init: function(callback, scope) {
				const parentInit = this.getParentMethod();
				this.Terrasoft.chain(
					this.loadSalesReadyLeadLifecycleSysSetting,
					this.loadQualifyStatus,
					function() {
						this.initSalesReadyLeadLifecycleTabsVisibility();
						parentInit.call(this, callback, scope);
					}, this);
			},

			/**
			 * Loads qualify status.
			 * @protected
			 */
			loadQualifyStatus: function(callback, scope) {
				if (!this.isNewMode()) {
					this.Ext.callback(callback, scope);
					return;
				}
				if (!this.$UseTheSalesReadyLeadLifecycle) {
					this.$QualifyStatus = {
						value: this.$QualificationStageId
					}
					this.Ext.callback(callback, scope);
				} else {
					this.Terrasoft.SysSettings.querySysSettingsItem(["DefaultLeadStage"], function(result) {
						this.$QualifyStatus = result;
						this.Ext.callback(callback, scope);
					}, this);
				}
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onGetColumnsValues
			 * @override
			 */
			onGetColumnsValues: function(columnNames) {
				var result = this.callParent(arguments);
				if (this.get("UseTheSalesReadyLeadLifecycle")
					&& columnNames.includes("Email")
					&& this.get("QualifiedContact")) {
					result["Email"] = this.$QualifiedContact.Email;
				}
				return result;
			},

			/**
			 * @inheritdoc Terrasoft.LeadManagementUtilities#initLeadManagementButtonVisibility
			 * @override
			 */
			initLeadManagementButtonVisibility: function(entity) {
				if (this.get("UseTheSalesReadyLeadLifecycle")) {
					this.set("LeadManagementButtonVisible", false);
				} else {
					this.callParent(arguments);
				}
			},

			/**
			 * Initializes SalesReadyLeadLifecycle tabs visibility.
			 * @protected
			 */
			initSalesReadyLeadLifecycleTabsVisibility: function () {
				if (!this.get("UseTheSalesReadyLeadLifecycle")) {
					this.setActiveTab("GeneralInfoTab");
					const tabsCollection = this.get("TabsCollection");
					if (tabsCollection.contains("LeadPageMQLTab")) {
						tabsCollection.removeByKey("LeadPageMQLTab");
					}
					if (tabsCollection.contains("LeadPageSQLTab")) {
						tabsCollection.removeByKey("LeadPageSQLTab");
					}
				}	
			},
			//endregion
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "NewLeadType",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "NewLeadDisqualifyReason",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "move",
				"name": "NewLeadDisqualifyReason",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "LeadRegisterMethodInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					},
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle",
						"bindConfig": {
							"converter": "invertBooleanValue"
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadBudget",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					},
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle",
						"bindConfig": {
							"converter": "invertBooleanValue"
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadCreatedOn",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadOwner",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadPredictiveScoreContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 8
					}
				}
			},
			{
				"operation": "move",
				"name": "DuplicatesWidgetContainer",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "move",
				"name": "ProfileContainer",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadProfilesAsc",
				"values": {
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle",
						"bindConfig": {
							"converter": "invertBooleanValue"
						}
					},
					"id": "lead-profiles-container-asc",
					"itemType": 7,
					"items": []
				},
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "AccountProfile",
				"values": {
					"itemType": 4
				},
				"parentName": "LeadProfilesAsc",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContactProfile",
				"values": {
					"itemType": 4
				},
				"parentName": "LeadProfilesAsc",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadProfilesDesc",
				"values": {
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					},
					"id": "lead-profiles-container-desc",
					"itemType": 7,
					"items": []
				},
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ContactProfileDesc",
				"values": {
					"itemType": 4
				},
				"parentName": "LeadProfilesDesc",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AccountProfileDesc",
				"values": {
					"itemType": 4
				},
				"parentName": "LeadProfilesDesc",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadPageMQLTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.LeadPageMQLTabTabCaption"
					},
					"items": [],
					"order": 0
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContactCommunicationDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {"bindTo": "UseTheSalesReadyLeadLifecycle"}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CallDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {"bindTo": "UseTheSalesReadyLeadLifecycle"}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "EmailDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ContactActivityDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AccountActivityDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "ContactAddressDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "LeadsSimilarSearchResultDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageMQLTab",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "LeadPageSQLTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.LeadPageSQLTabTabCaption"
					},
					"items": [],
					"order": 1
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ContactCommunicationDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadPageSQLTabOpportunityPlanningGroup",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.LeadPageSQLTabOpportunityPlanningGroupGroupCaption"
					},
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"markerValue": "added-group",
					"items": []
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadPageSQLTabGridLayout",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "LeadPageSQLTabOpportunityPlanningGroup",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BudgetV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "Budget"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NextActualizationDateV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "NextActualizationDate"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SalesOwnerV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "SalesOwner"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "MeetingDateV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "MeetingDate"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "OpportunityDepartmentV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "OpportunityDepartment"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "CommentarySqlTab",
				"values": {
					"contentType": Terrasoft.ContentType.LONG_TEXT,
					"layout": {
						"colSpan": 0,
						"rowSpan": 0,
						"column": 0,
						"row": 1,
						"layoutName": "LeadPageSQLTabOpportunityPlanningGroup"
					},
					"bindTo": "Commentary"
				},
				"parentName": "LeadPageSQLTabOpportunityPlanningGroup",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "DecisionDateV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 2,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"bindTo": "DecisionDate"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "AccountCallDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ContactCallDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AccountAddressDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "ContactAddressDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "LeadSpecificationDetail",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "LeadProductDetailV2",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail",
					"visible": {
						"bindTo": "UseTheSalesReadyLeadLifecycle"
					}
				},
				"parentName": "LeadPageSQLTab",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"order": 2
				}
			},
			{
				"operation": "merge",
				"name": "SearchInSocialNetworksButton",
				"values": {
					"layout": {
						"colSpan": 1,
						"rowSpan": 1,
						"column": 10,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "SearchInSocialNetworksButton",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "SearchInGoogleButton",
				"values": {
					"layout": {
						"colSpan": 1,
						"rowSpan": 1,
						"column": 22,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "SearchInGoogleButton",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "Contact",
				"values": {
					"layout": {
						"colSpan": 10,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Account",
				"values": {
					"layout": {
						"colSpan": 10,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "Account",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "Job",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "EmployeesNumber",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "MobilePhone",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "move",
				"name": "MobilePhone",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "merge",
				"name": "Country",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "Email",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "Email",
				"parentName": "LeadPageRegisterInfoBlock",
				"propertyName": "items",
				"index": 8
			},
			{
				"operation": "merge",
				"name": "Website",
				"values": {
					"layout": {
						"colSpan": 11,
						"rowSpan": 1,
						"column": 12,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "NeedInfoTab",
				"values": {
					"order": 3
				}
			},
			{
				"operation": "merge",
				"name": "LeadTypeStatus",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadEngagementTab",
				"values": {
					"order": 4
				}
			},
			{
				"operation": "merge",
				"name": "LeadMedium",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadSource",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "RegisterMethod",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "DealSpecificsTab",
				"values": {
					"order": 6
				}
			},
			{
				"operation": "merge",
				"name": "Budget",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "NextActualizationDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "NextActualizationDate",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "SalesOwner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "MeetingDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "DecisionDate",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityDepartment",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "HistoryTab",
				"values": {
					"order": 7
				}
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 9
				}
			},
			{
				"operation": "merge",
				"name": "NotesTab",
				"values": {
					"order": 8
				}
			},
			{
				"operation": "merge",
				"name": "TimelineTab",
				"values": {
					"order": 5
				}
			},
			{
				"operation": "remove",
				"name": "AccountProfile"
			},
			{
				"operation": "remove",
				"name": "ContactProfile"
			}
		]/**SCHEMA_DIFF*/
	};
});

define('LeadPageV2CoreLeadOpportunityResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2CoreLeadOpportunity", ["terrasoft", "OpportunityConfigurationConstants", "LeadConfigurationConst", "BusinessRuleModule"],
		function(Terrasoft, OpportunityConfigurationConstants, LeadConfigurationConst, BusinessRuleModule) {
			return {
				entitySchemaName: "Lead",
				details: /**SCHEMA_DETAILS*/{
				}/**SCHEMA_DETAILS*/,
				attributes: {},
				messages: {
					"GetCurrentOpportunityInfo": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				methods: {

					/**
					 * Returns GUID of opportunity
					 * @returns {Terrasoft.DataValueType.GUID}
					 */
					getUidOpportunity: function() {

						var opportunity = this.get("Opportunity");
						return (opportunity) ? opportunity.value : null;
					},

					/**
					 * Returns the primary opportunity contact
					 * @returns {Terrasoft.EntitySchemaQuery}
					 */
					getOpportunityContactESQ: function() {
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "OpportunityContact"
						});
						select.addColumn("Id");
						select.addColumn("Contact");
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Opportunity", this.getUidOpportunity()));
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "IsMainContact", true));
						return select;
					},

					/**
					 * Returns the opportunity
					 * @returns {Terrasoft.EntitySchemaQuery}
					 */
					getOpportunityESQ: function() {
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "Opportunity"
						});
						select.addColumn("Id");
						select.addColumn("Budget");
						select.addColumn("Owner");
						select.addColumn("Stage");
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Id", this.getUidOpportunity()));
						return select;
					},

					/**
					 * Sets data from the opportunity
					 * @override
					 */
					onEntityInitialized: function() {
						this.callParent(arguments);
						if (this.isNewMode() && this.getUidOpportunity()) {
							this.getOpportunityContactESQ().getEntityCollection(function(response) {
								if (response.success) {
									if (response.collection.getCount() < 1) {
										return;
									}
									var mainContact = response.collection.getByIndex(0);
									this.set("QualifiedContact", mainContact.get("Contact"), Terrasoft.DataValueType.LOOKUP);
								}
							}, this);
							this.getOpportunityESQ().getEntityCollection(function(response) {
								if (response.success) {
									if (response.collection.getCount() < 1) {
										return;
									}
									var mainOpportunity = response.collection.getByIndex(0);
									this.set("Budget", mainOpportunity.get("Budget"), Terrasoft.DataValueType.MONEY);
									this.set("SalesOwner", mainOpportunity.get("Owner"), Terrasoft.DataValueType.LOOKUP);
								}
							}, this);
						}
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "move",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "SalesOwner",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.LOOKUP,
							"bindTo": "SalesOwner"
						}
					},
					{
						"operation": "move",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "OpportunityDepartment",
						"values": {
							"layout": {
								"column": 0,
								"row": 3,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM,
							"enabled": {"bindTo": "SourceDataEditable"}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "Opportunity",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12}
						}
					}
				]/**SCHEMA_DIFF*/,
				rules: {
					"Opportunity": {
						"FilterOpportunityrByAccount": {
							"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
							"autocomplete": true,
							"baseAttributePatch": "Account",
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							"attribute": "QualifiedAccount"
						},
						"EnabledOpportunityForQualifyStatus": {
							"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
							"property": BusinessRuleModule.enums.Property.ENABLED,
							"conditions": [{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "QualifyStatus"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": LeadConfigurationConst.LeadConst.QualifyStatus.TransferForSale
								}
							}, {
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "QualifyStatus"
								},
								"comparisonType": Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": LeadConfigurationConst.LeadConst.QualifyStatus.WaitingForSale
								}
							}]
						}
					}
				},
				userCode: {
				}
			};
		});

define('LeadPageV2SalesEnterpriseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2SalesEnterprise", ["BusinessRuleModule", "LeadConfigurationConst"],
	function(BusinessRuleModule, LeadConfigurationConst) {
		return {
			entitySchemaName: "Lead",
			attributes: {
				"OpportunityOrOrder": {
					"caption": {"bindTo": "Resources.Strings.OpportunityOrOrderCaption"},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["Opportunity", "Order"]
				}
			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "LeadWebFormInProfile",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "LeadWebFormInProfile",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "SalesChannel",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 7
					}
				}
			},
			{
				"operation": "move",
				"name": "SalesChannel",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "merge",
				"name": "Partner",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 9
					}
				}
			},
			{
				"operation": "insert",
				"name": "OpportunityOrOrderV2",
				"values": {
					"markerValue": {
						"bindTo": "Resources.Strings.OpportunityOrOrderCaption"
					},
					"caption": {
						"bindTo": "Resources.Strings.OpportunityOrOrderCaption"
					},
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "LeadPageSQLTabGridLayout"
					},
					"contentType": 5,
					"bindTo": "OpportunityOrOrder"
				},
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "merge",
				"name": "SalesOwnerV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "LeadPageSQLTabGridLayout"
					}
				}
			},
			{
				"operation": "move",
				"name": "SalesOwnerV2",
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "merge",
				"name": "OpportunityDepartmentV2",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "LeadPageSQLTabGridLayout"
					}
				}
			},
			{
				"operation": "move",
				"name": "OpportunityDepartmentV2",
				"parentName": "LeadPageSQLTabGridLayout",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "merge",
				"name": "CountryStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "RegionStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "CityStr",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "BpmRef",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0
					}
				}
			},
			{
				"operation": "move",
				"name": "BpmRef",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "merge",
				"name": "WebForm",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1
					}
				}
			},
			{
				"operation": "move",
				"name": "WebForm",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "OpportunityOrOrder",
				"values": {
					"markerValue": {
						"bindTo": "Resources.Strings.OpportunityOrOrderCaption"
					},
					"caption": {
						"bindTo": "Resources.Strings.OpportunityOrOrderCaption"
					},
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					},
					"contentType": 5,
					"bindTo": "OpportunityOrOrder"
				},
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "merge",
				"name": "SalesOwner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					},
					"caption": {
						"bindTo": "Resources.Strings.DealOwnerCaption"
					}
				}
			},
			{
				"operation": "move",
				"name": "SalesOwner",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "merge",
				"name": "OpportunityDepartment",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "remove",
				"name": "Order"
			},
			{
				"operation": "remove",
				"name": "Opportunity"
			}
		]/**SCHEMA_DIFF*/,
			rules: {
				"OpportunityOrOrder": {
					"EnabledOpportunityOrOrderForQualifyStatus": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "QualifyStatus"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": LeadConfigurationConst.LeadConst.QualifyStatus.TransferForSale
							}
						}, {
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "QualifyStatus"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": LeadConfigurationConst.LeadConst.QualifyStatus.WaitingForSale
							}
						}]
					}
				},
				"Opportunity": {
					"FilterOpportunityrByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "Account",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "QualifiedAccount"
					}
				},
				"Order": {
					"FilterOrderByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "Account",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "QualifiedAccount"
					}
				},
				"MeetingDate": {
					"VisibleMeetingDateByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				},
				"DecisionDate": {
					"VisibleDecisionDateDateByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				},
				"OpportunityDepartment": {
					"VisibleOpportunityDepartmentByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				}
			}
		};
	});

define('LeadPageV2MarketingCampaignResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("LeadPageV2MarketingCampaign", function() {
		return {
			entitySchemaName: "Lead",
			details: /**SCHEMA_DETAILS*/{

			}/**SCHEMA_DETAILS*/,
			methods: {

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "LeadPageSourceInfoBlock",
					"propertyName": "items",
					"name": "Campaign",
					"values": {
						"layout": {"column": 12, "row": 2, "colSpan": 12}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageSourceInfoBlock",
					"propertyName": "items",
					"name": "BulkEmail",
					"values": {
						"layout": {"column": 12, "row": 3, "colSpan": 12}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});

define("LeadPageV2", function() {
	return {
		entitySchemaName: "Lead",
		details: /**SCHEMA_DETAILS*/{
			SiteEvent: {
				schemaName: "SiteEventDetailV2",
				entitySchemaName: "SiteEvent",
				filter: {
					masterColumn: "BpmSessionId",
					detailColumn: "BpmSessionId"
				}
			}
		}/**SCHEMA_DETAILS*/,
		methods: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "LeadEngagementTab",
				"propertyName": "items",
				"name": "SiteEvent",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				},
				"index": 0
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "Event",
				"values": {
					"layout": {
						"column": 12,
						"row": 4,
						"colSpan": 12
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});


