Terrasoft.configuration.Structures["SspAccountProfilePage"] = {innerHierarchyStack: ["SspAccountProfilePageSSP", "SspAccountProfilePage"], structureParent: "BasePageV2"};
define('SspAccountProfilePageSSPStructure', ['SspAccountProfilePageSSPResources'], function(resources) {return {schemaUId:'3f258bdb-b9f3-477e-afba-f8d5aab1d4b6',schemaCaption: "Organization page at portal", parentSchemaName: "BasePageV2", packageName: "PortalITILService", schemaName:'SspAccountProfilePageSSP',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SspAccountProfilePageStructure', ['SspAccountProfilePageResources'], function(resources) {return {schemaUId:'dc9669b6-b5f3-4f51-8728-4a89ebf5ee4f',schemaCaption: "Organization page at portal", parentSchemaName: "SspAccountProfilePageSSP", packageName: "PortalITILService", schemaName:'SspAccountProfilePage',parentSchemaUId:'3f258bdb-b9f3-477e-afba-f8d5aab1d4b6',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SspAccountProfilePageSSP",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SspAccountProfilePageSSPResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SspAccountProfilePageSSP", [],
	function() {
		return {
			entitySchemaName: "Account",
			details: /**SCHEMA_DETAILS*/{
				"PortalUserInOrganization": {
					"schemaName": "PortalUserInOrganizationDetail",
					"filter": {
						"masterColumn": "OrganizationId",
						"detailColumn": "PortalAccount"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"visible": true,
						"bindTo": "Name",
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "insert",
					"name": "PrimaryContact",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"visible": true,
						"bindTo": "PrimaryContact",
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12
						},
						"enabled": false
					}
				},
				{
					"operation": "insert",
					"name": "Phone",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"bindTo": "PortalAccountPhone",
						"enabled": true,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "insert",
					"name": "PortalUsersTab",
					"parentName": "Tabs",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.PortalUsersTabCaption"
						},
						"items": []
					},
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "PortalUserInOrganization",
					"parentName": "PortalUsersTab",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"visible": {"bindTo": "getPortalUserInOrganizationDetailVisible"}
					}
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"OrganizationId": {
					"dataValueType": this.Terrasoft.DataValueType.GUID,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"PrimaryContact": {
					"columnPath": "PrimaryContact",
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"caption": {bindTo: "Resources.Strings.PrimaryContactCaption"},
					"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN
				},
				"PortalAccountPhone": {
					"columnPath": "Phone",
					"dataValueType": this.Terrasoft.DataValueType.TEXT,
					"caption": {bindTo: "Resources.Strings.PortalAccountPhoneCaption"},
					"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"enabled": false
				}
			},
			methods: {

				/**
				 * @inheritDoc BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.getSspAccountInfo();
				},

				/**
				 * Get info about SSP account
				 */
				getSspAccountInfo: function() {
					const serviceConfig = {serviceName: "SspUserManagementService", methodName: "GetSspAccountInfo"};
					this.callService(serviceConfig, function(response) {
						const result = response && response.GetSspAccountInfoResult;
						if (result && result.success && result.SspAccountId) {
							this.set("OrganizationId", result.SspAccountId);
						}
					}, this);
				},

				/**
				 * Get portal user in organization detail visibility.
				 * @returns {boolean} detail visibility.
				 */
				getPortalUserInOrganizationDetailVisible: function() {
					return this.get("OrganizationId") === this.get("Id");
				},

				/**
				 * @inheritDoc Terrasoft.BasePageV2.mixins.PrintReportUtilities#initCardPrintForms
				 * @override
				 */
				initCardPrintForms: this.Terrasoft.emptyFn,

				/**
				 * @inheritDoc DuplicatesSearchUtilitiesV2#initPerformSearchOnSave
				 * @override
				 */
				initPerformSearchOnSave: this.Terrasoft.emptyFn
			}
		};
	});

define("SspAccountProfilePage", [],
function() {
	return {
		entitySchemaName: "Account",
		messages: {},
		details: /**SCHEMA_DETAILS*/{
			"Services": {
				"schemaName": "ServiceRecepientsDetail",
				"entitySchemaName": "VwServiceRecepients",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Account"
				}
			},
			"ServicePacts": {
				"schemaName": "ServicePactRecipientsDetail",
				"entitySchemaName": "ServiceObject",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Account"
				}
			},
			"AccountAddress": {
				"schemaName": "AccountAddressDetailV2",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Account"
				}
			},
			"ConfItem": {
				"schemaName": "SSPConfItemInAccountDetail",
				"entitySchemaName": "ConfItemUser",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Account"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "AccountPageServiceTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {"bindTo": "Resources.Strings.MaintenanceTab"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Services",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "AccountPageServiceTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ServicePacts",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "AccountPageServiceTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AccountAddress",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "AccountPageServiceTab",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ConfItem",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL,
					"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
				},
				"parentName": "AccountPageServiceTab",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		methods: {},
		rules: {},
		userCode: {}
	};
});


