Terrasoft.configuration.Structures["PortalMktgActivityEditPage"] = {innerHierarchyStack: ["PortalMktgActivityEditPageMktgActivitiesPortal", "PortalMktgActivityEditPage"], structureParent: "BaseModulePageV2"};
define('PortalMktgActivityEditPageMktgActivitiesPortalStructure', ['PortalMktgActivityEditPageMktgActivitiesPortalResources'], function(resources) {return {schemaUId:'175041ba-b949-4b5e-ae71-164b6a5af186',schemaCaption: "Portal marketing activity edit page", parentSchemaName: "BaseModulePageV2", packageName: "PRMMktgActivitiesPortal", schemaName:'PortalMktgActivityEditPageMktgActivitiesPortal',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('PortalMktgActivityEditPageStructure', ['PortalMktgActivityEditPageResources'], function(resources) {return {schemaUId:'9768c730-2e00-4324-bbf0-b01ab5de7506',schemaCaption: "Portal marketing activity edit page", parentSchemaName: "PortalMktgActivityEditPageMktgActivitiesPortal", packageName: "PRMMktgActivitiesPortal", schemaName:'PortalMktgActivityEditPage',parentSchemaUId:'175041ba-b949-4b5e-ae71-164b6a5af186',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"PortalMktgActivityEditPageMktgActivitiesPortal",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('PortalMktgActivityEditPageMktgActivitiesPortalResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("PortalMktgActivityEditPageMktgActivitiesPortal", ["terrasoft", "TimezoneUtils", "PortalMktgActivitiesConstants", "MoneyModule",
		"MultiCurrencyEdit", "MultiCurrencyEditUtilities"],
	function(Terrasoft, TimezoneUtils, PortalMktgActivitiesConstants, MoneyModule) {
		return {
			entitySchemaName: "MktgActivity",
			details: /**SCHEMA_DETAILS*/{
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "MktgActivityFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "MktgActivity"
					}
				}
			}/**SCHEMA_DETAILS*/,
			mixins: {
				MultiCurrencyEditUtilities: "Terrasoft.MultiCurrencyEditUtilities"
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

			methods : {

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.mixins.MultiCurrencyEditUtilities.init.call(this);
					if (this.isAddMode() || this.isCopyMode()) {
						this.selectDefaultStatus(function(status) {
							this.set("Status", status);
						}, this);
					}
				},

				/**
				 * Select default status.
				 * @param {Function} callback
				 * @param {Object} scope
				 */
				selectDefaultStatus: function(callback, scope) {
					var defaultStatusId = PortalMktgActivitiesConstants.OnApprovalStatusId;
					var select = this.getStatusSelectQuery(defaultStatusId);
					select.getEntityCollection(function(responce) {
						if(responce && responce.success) {
							var items = responce.collection.getItems();
							var status = {
								value: defaultStatusId,
								displayValue: items[0].values.Name
							};
							callback.call(scope, status);
						}
					});
				},

				/**
				 * Return query for select default status.
				 * @param {GUID} defaultStatusId - Default status id.
				 * @returns {Terrasoft.EntitySchemaQuery}
				 */
				getStatusSelectQuery: function(defaultStatusId) {
					var select = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "MktgActivityStatus"
					});
					select.addColumn("Name");
					var filter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "Id",
							defaultStatusId);
					select.filters.add("IdFilter", filter);
					return select;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					var startDate = Ext.Date.format(this.get("StartDate"),"Y-m-d");
					var endDate = Ext.Date.format(this.get("DueDate"),"Y-m-d");
					if (!this.validateDate(startDate, endDate)) {
						Terrasoft.utils.showInformation(this.get("Resources.Strings.StartEndDateErrorMessage"));
						return;
					}
					this.callParent(arguments);
				},

				/**
				 * Validate date.
				 * @private
				 * @returns {boolean}
				 */
				validateDate: function(startDate, endDate) {
					if (startDate > endDate) {
						return false;
					}
					return true;
				},

				/**
				 * Lock fields in EditMode
				 * @returns {boolean}
				 */
				isFieldsEditable: function() {
					return !this.isEditMode();
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

				/**
				 * @overriden
				 * Initialize card actions
				 */
				initActionButtonMenu: function() {
					this.set("ActionsButtonVisible", false);
				}
			},
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
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
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
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
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
						},
						"enabled": false
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
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
					"operation": "remove",
					"name": "ESNTab"
				},
				{
					"operation": "insert",
					"name": "StartDate",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
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
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						}
					},
					"parentName": "GeneralInfoGridLayout",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoGridLayout",
					"propertyName": "items",
					"name": "PlannedBudget",
					"values": {
						"bindTo": "PlannedBudget",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						},
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
						"layout":  {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": false,
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
					"name": "NotesAndFilesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.NotesFilesTabCaption"},
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

define("PortalMktgActivityEditPage", ["PortalMktgActivitiesConstants", "ConfigurationConstants", "terrasoft"],
	function(PortalMktgActivitiesConstants, ConfigurationConstants) {
		return {
			entitySchemaName: "MktgActivity",
			details: /**SCHEMA_DETAILS*/{

			}/**SCHEMA_DETAILS*/,
			attributes: {
				Fund: {
					lookupListConfig: {
						filter: function() {
							return this.getParntershipActiveStatusFilter();
						}
					}
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Fund",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						},
						"visible": false
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
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
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
						},
						"enabled": {
							"bindTo": "isFieldsEditable"
						}
					},
					"parentName": "MarketingActivityControlGroup_GridLayout",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/,
			rules: {},
			methods: {

				/**
				 * Create filter for active partnership status.
				 * protected
				 * @returns {Object}
				 */
				getParntershipActiveStatusFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("ActivePartnership", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"Partnership.IsActive", 1));
					return filterGroup;
				},

				/**
				 * Sets MktgActivity default type.
				 * @protected
				 * @virtual
				 */
				setMktgActivityDefaultType: function() {
					this.$MktgActivityType = {
						value: ConfigurationConstants.MktgActivity.Type.PartnersActivityType
					};
				},

				/**
				* @inheritdoc Terrasoft.configuration.BaseSchemaViewModel#setDefaultValues
				* @overriden
				*/
				setDefaultValues: function(callback, scope) {
					this.callParent([function() {
						this.setMktgActivityDefaultType();
						var account = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT.value;
						if (!this.Terrasoft.isEmptyGUID(account)) {
							this.$Account = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT;
							var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
								rootSchemaName: "Fund"
							});
							var typeFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
								"FundType", PortalMktgActivitiesConstants.FundType.Marketing);
							var joinFilter = "=[Partnership:Id:Partnership].Account";
							var filterGroup = new this.Terrasoft.createFilterGroup();
							filterGroup.addItem(
									Terrasoft.createColumnFilterWithParameter(
											Terrasoft.ComparisonType.EQUAL,
											joinFilter,
											account
									)
							);
							filterGroup.addItem(
									Terrasoft.createColumnFilterWithParameter(
											Terrasoft.ComparisonType.EQUAL,
											"=[Partnership:Id:Partnership].IsActive", true));
							esq.filters.addItem(filterGroup);
							esq.filters.addItem(typeFilter);
							esq.getEntityCollection(function(response) {
								if (response && response.success) {
									var collection = response.collection;
									if (collection && collection.getCount() > 0) {
										var mktgFund = collection.getByIndex(0);
										this.set("Fund", {
											value: mktgFund.values.Id
										});
									}
									callback.call(scope);
								}
							}, this);
						} else {
							callback.call(scope);
						}
					}, this]);
				}
			},
			userCode: {}
		};
	});


