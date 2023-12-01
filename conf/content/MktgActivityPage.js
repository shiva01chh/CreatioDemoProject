Terrasoft.configuration.Structures["MktgActivityPage"] = {innerHierarchyStack: ["MktgActivityPageCampaignPlannerNew", "MktgActivityPage"], structureParent: "BaseModulePageV2"};
define('MktgActivityPageCampaignPlannerNewStructure', ['MktgActivityPageCampaignPlannerNewResources'], function(resources) {return {schemaUId:'a24f8c1e-1b98-4608-87a0-1f1e380b0bdd',schemaCaption: "MktgActivityPage", parentSchemaName: "BaseModulePageV2", packageName: "PRMMktgActivitiesPortal", schemaName:'MktgActivityPageCampaignPlannerNew',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('MktgActivityPageStructure', ['MktgActivityPageResources'], function(resources) {return {schemaUId:'b5be9482-c29e-4fd4-85bc-dec992f77493',schemaCaption: "MktgActivityPage", parentSchemaName: "MktgActivityPageCampaignPlannerNew", packageName: "PRMMktgActivitiesPortal", schemaName:'MktgActivityPage',parentSchemaUId:'a24f8c1e-1b98-4608-87a0-1f1e380b0bdd',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"MktgActivityPageCampaignPlannerNew",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('MktgActivityPageCampaignPlannerNewResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("MktgActivityPageCampaignPlannerNew", ["terrasoft", "MoneyModule", "MultiCurrencyEdit", "MultiCurrencyEditUtilities"],
		function(Terrasoft, MoneyModule) {
			return {
				entitySchemaName: "MktgActivity",
				mixins: {
					MultiCurrencyEditUtilities: "Terrasoft.MultiCurrencyEditUtilities"
				},
				messages: {
					"SelectedSideBarItemChanged": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				attributes: {
					/**
					 * Currency
					 */
					"Currency": {
						lookupListConfig: {
							columns: ["Division"]
						}
					},
					/**
					 * Currency rate
					 */
					"CurrencyRate": {
						dataValueType: Terrasoft.DataValueType.FLOAT,
						dependencies: [
							{
								columns: ["Currency"],
								methodName: "setCurrencyRate"
							}
						]
					},
					/**
					 * Currency rate list.
					 */
					"CurrencyRateList": {
						dataValueType: this.Terrasoft.DataValueType.COLLECTION,
						value: this.Ext.create("Terrasoft.Collection")
					},
					/**
					 * Currency button menu list.
					 */
					"CurrencyButtonMenuList": {
						dataValueType: this.Terrasoft.DataValueType.COLLECTION,
						value: this.Ext.create("Terrasoft.BaseViewModelCollection")
					},
					/**
					 * Planned budget
					 */
					"PlannedBudget": {
						dataValueType: Terrasoft.DataValueType.FLOAT,
						dependencies: [
							{
								columns: ["CurrencyRate"],
								methodName: "recalculatePlannedBudget"
							}
						]
					},
					/**
					 * Planned budget, base currency
					 */
					"PrimaryPlannedBudget": {
						dataValueType: Terrasoft.DataValueType.FLOAT,
						dependencies: [
							{
								columns: ["PlannedBudget"],
								methodName: "recalculatePrimaryPlannedBudget"
							}
						]
					},
					/**
					 * Spent budget
					 */
					"SpentBudget": {
						dataValueType: Terrasoft.DataValueType.FLOAT,
						dependencies: [
							{
								columns: ["CurrencyRate"],
								methodName: "recalculateSpentBudget"
							}
						]
					},
					/**
					 * Spent budget, base currency
					 */
					"PrimarySpentBudget": {
						dataValueType: Terrasoft.DataValueType.FLOAT,
						dependencies: [
							{
								columns: ["SpentBudget"],
								methodName: "recalculatePrimarySpentBudget"
							}
						]
					}
				},
				methods: {
					/**
					 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
					 * @overridden
					 */
					onEntityInitialized: function() {
						this.callParent(arguments);
						this.mixins.MultiCurrencyEditUtilities.init.call(this);
					},

					/**
					 * @inheritdoc Terrasoft.BasePageV2#getHeader
					 * @overridden
					 */
					getHeader: function() {
						return this.entitySchema.caption;
					},

					/**
					 * Sets currency rate value
					 * @protected
					 */
					setCurrencyRate: function() {
						var currentDateTime = this.getSysDefaultValue(Terrasoft.SystemValueType.CURRENT_DATE_TIME);
						MoneyModule.LoadCurrencyRate.call(this, "Currency", "CurrencyRate", currentDateTime);
					},

					/**
					 * Calculates planned budget
					 * @protected
					 */
					recalculatePlannedBudget: function() {
						MoneyModule.RecalcCurrencyValue.call(this, "CurrencyRate", "PlannedBudget", "PrimaryPlannedBudget",
								this.getCurrencyDivision());
					},

					/**
					 * Calculates planned budget in the base currency
					 * @protected
					 */
					recalculatePrimaryPlannedBudget: function() {
						MoneyModule.RecalcBaseValue.call(this, "CurrencyRate", "PlannedBudget", "PrimaryPlannedBudget",
								this.getCurrencyDivision());
					},

					/**
					 * Calculates spent budget
					 * @protected
					 */
					recalculateSpentBudget: function() {
						MoneyModule.RecalcCurrencyValue.call(this, "CurrencyRate", "SpentBudget", "PrimarySpentBudget",
								this.getCurrencyDivision());
					},

					/**
					 * Calculates spent budget in the base currency
					 * @protected
					 */
					recalculatePrimarySpentBudget: function() {
						MoneyModule.RecalcBaseValue.call(this, "CurrencyRate", "SpentBudget", "PrimarySpentBudget",
								this.getCurrencyDivision());
					},

					/**
					 * Returns currency division
					 * @protected
					 */
					getCurrencyDivision: function() {
						var currency = this.get("Currency");
						return currency && currency.Division;
					},

					changeSelectedSideBarMenu: function() {
						var moduleStructure = this.getModuleStructure("CampaignPlanner");
						if (moduleStructure) {
							var hash = moduleStructure.sectionModule + "/";
							if (moduleStructure.sectionSchema) {
								hash += moduleStructure.sectionSchema + "/";
							}
							this.sandbox.publish("SelectedSideBarItemChanged", hash, ["sectionMenuModule"]);
						} else {
							this.callParent(arguments);
						}
					}

				},
				details: /**SCHEMA_DETAILS*/{
					Files: {
						schemaName: "FileDetailV2",
						entitySchemaName: "MktgActivityFile",
						filter: {
							masterColumn: "Id",
							detailColumn: "MktgActivity"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "Name",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 24,
								"rowSpan": 1
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "Channel",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 1
					},
					{
						"operation": "insert",
						"name": "Status",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 2
					},
					{
						"operation": "insert",
						"name": "Owner",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 3
					},
					{
						"operation": "insert",
						"name": "CampaignPlanner",
						"values": {
							"layout": {
								"column": 12,
								"row": 2,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 4
					},
					{
						"operation": "insert",
						"name": "GeneralInfoTab",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.GeneralInfoTabCaption"
							},
							"items": []
						},
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "group",
						"values": {
							"itemType": 15,
							"caption": {
								"bindTo": "Resources.Strings.groupCaption"
							},
							"items": [],
							"controlConfig": {
								"collapsed": false
							}
						},
						"parentName": "GeneralInfoTab",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "GeneralInfoGridLayout",
						"values": {
							"itemType": 0,
							"items": []
						},
						"parentName": "group",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"parentName": "GeneralInfoGridLayout",
						"propertyName": "items",
						"name": "PlannedBudget",
						"values": {
							"bindTo": "PlannedBudget",
							"layout": {"column": 0, "row": 0, "colSpan": 12, "rowSpan": 1},
							"primaryAmount": "PrimaryPlannedBudget",
							"currency": "Currency",
							"rate": "CurrencyRate",
							"primaryAmountEnabled": false,
							"generator": "MultiCurrencyEditViewGenerator.generate"
						},
						"index": 0
					},
					{
						"operation": "insert",
						"parentName": "GeneralInfoGridLayout",
						"propertyName": "items",
						"name": "SpentBudget",
						"values": {
							"bindTo": "SpentBudget",
							"layout": {"column": 0, "row": 1, "colSpan": 12, "rowSpan": 1},
							"primaryAmount": "PrimarySpentBudget",
							"currency": "Currency",
							"rate": "CurrencyRate",
							"primaryAmountEnabled": false,
							"generator": "MultiCurrencyEditViewGenerator.generate"
						},
						"index": 1
					},
					{
						"operation": "insert",
						"name": "StartDate",
						"values": {
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "GeneralInfoGridLayout",
						"propertyName": "items",
						"index": 2
					},
					{
						"operation": "insert",
						"name": "DueDate",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12,
								"rowSpan": 1
							}
						},
						"parentName": "GeneralInfoGridLayout",
						"propertyName": "items",
						"index": 3
					},
					{
						"operation": "insert",
						"name": "NotesAndFilesTab",
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 3,
						"values": {
							"caption": {"bindTo": "Resources.Strings.NotesAndFilesTabCaption"},
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "NotesAndFilesTab",
						"propertyName": "items",
						"name": "Files",
						"values": {
							"itemType": Terrasoft.ViewItemType.DETAIL
						}
					},
					{
						"operation": "insert",
						"name": "NotesControlGroup",
						"parentName": "NotesAndFilesTab",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
							"items": [],
							"caption": {"bindTo": "Resources.Strings.NotesGroupCaption"}
						}
					},
					{
						"operation": "insert",
						"parentName": "NotesControlGroup",
						"propertyName": "items",
						"name": "Notes",
						"values": {
							"contentType": Terrasoft.ContentType.RICH_TEXT,
							"layout": {"column": 0, "row": 0, "colSpan": 24},
							"labelConfig": {
								"visible": false
							},
							"controlConfig": {
								"imageLoaded": {
									"bindTo": "insertImagesToNotes"
								},
								"images": {
									"bindTo": "NotesImagesCollection"
								}
							}
						}
					}
				]/**SCHEMA_DIFF*/,
				rules: {},
				userCode: {}
			};
		});

define("MktgActivityPage", ["BusinessRuleModule", "ConfigurationConstants", "PartnersOwnerMixin", "terrasoft"],
	function(BusinessRuleModule, ConfigurationConstants) {
		return {
			entitySchemaName: "MktgActivity",
			details: /**SCHEMA_DETAILS*/{
			}/**SCHEMA_DETAILS*/,
			mixins: {
				/**
				 * Mixin represents methods for partners owners.
				 */
				PartnersOwnerMixin: "Terrasoft.PartnersOwnerMixin"
			},
			attributes: {
				"PartnersActivityType": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"value": ConfigurationConstants.MktgActivity.Type.PartnersActivityType
				},
				"Account": {
					"dependencies": [
						{
							"columns": ["MktgActivityType"],
							"methodName": "onMktgActivityTypeChanged"
						},
						{
							"columns": ["Owner"],
							"methodName": "fillPartnerByOwner"
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
				"Fund": {
					"lookupListConfig": {
						"filter": function() {
							return this.getCurrentPartnershipFundFilter();
						}
					}
				},
				"Owner": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"filter": function () {
							return this.getOwnerFilter("MktgActivityType");
						},
						"columns": [
							"Account.Type"
						]
					}
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.initializeDefaultValues("Account", this.get("PartnersActivityType"));
				},

				/**
				 * MktgActivityType changed event method handler.
				 */
				onMktgActivityTypeChanged: function() {
					this.clearPartnerIfColumnChange("MktgActivityType");
				},

				/**
				 * Create filter for fund.
				 * protected
				 * @returns {Object}
				 */
				getCurrentPartnershipFundFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("ActivePartnership", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"Partnership.IsActive", 1));
					filterGroup.add("CurrentPartnership", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"Partnership", this.get("Partnership").value));
					return filterGroup;
				}
				
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "MktgActivityType",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Account",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Fund",
					"values": {
						"layout": {
							"column": 0,
							"row": 6,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Partnership",
					"values": {
						"layout": {
							"column": 12,
							"row": 5,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Url",
					"values": {
						"layout": {
							"column": 12,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "MarketingActivityControlGroup",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.MarketingActivityGroupCaption"
						}
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "MarketingActivityControlGroup_GridLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "MarketingActivityControlGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Description",
					"values": {
						"layout": {
							"column": 1,
							"row": 0,
							"colSpan": 20,
							"rowSpan": 3
						},
						"contentType": this.Terrasoft.ContentType.LONG_TEXT,
						"labelConfig": {
							"visible": false
						}
					},
					"parentName": "MarketingActivityControlGroup_GridLayout",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"Partnership": {
					"VisibleRule": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "MktgActivityType"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PartnersActivityType"
							}
						}]
					}
				},
				"Account": {
					"VisibleRule": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "MktgActivityType"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PartnersActivityType"
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
				"Fund": {
					"VisibleRule": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "MktgActivityType"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "PartnersActivityType"
							}
						}]
					}
				}
			},
			userCode: {}
		};
	});


