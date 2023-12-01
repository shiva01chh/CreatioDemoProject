Terrasoft.configuration.Structures["ConfItemPage"] = {innerHierarchyStack: ["ConfItemPageCMDB", "ConfItemPageServiceModel", "ConfItemPageChange", "ConfItemPage"], structureParent: "BaseModulePageV2"};
define('ConfItemPageCMDBStructure', ['ConfItemPageCMDBResources'], function(resources) {return {schemaUId:'21af711b-1d9b-4911-a611-f699ef456565',schemaCaption: "ConfItemPage", parentSchemaName: "BaseModulePageV2", packageName: "Release", schemaName:'ConfItemPageCMDB',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemPageServiceModelStructure', ['ConfItemPageServiceModelResources'], function(resources) {return {schemaUId:'faab7497-0b62-4ae0-9e6e-d105089db2d1',schemaCaption: "ConfItemPage", parentSchemaName: "ConfItemPageCMDB", packageName: "Release", schemaName:'ConfItemPageServiceModel',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ConfItemPageCMDB",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemPageChangeStructure', ['ConfItemPageChangeResources'], function(resources) {return {schemaUId:'154de4c0-3eba-4cd5-a208-824707695bac',schemaCaption: "ConfItemPage", parentSchemaName: "ConfItemPageServiceModel", packageName: "Release", schemaName:'ConfItemPageChange',parentSchemaUId:'21af711b-1d9b-4911-a611-f699ef456565',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ConfItemPageServiceModel",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemPageStructure', ['ConfItemPageResources'], function(resources) {return {schemaUId:'f676fe3b-0cdc-4bd3-a9cf-33e8234c84ba',schemaCaption: "ConfItemPage", parentSchemaName: "ConfItemPageChange", packageName: "Release", schemaName:'ConfItemPage',parentSchemaUId:'154de4c0-3eba-4cd5-a208-824707695bac',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ConfItemPageChange",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ConfItemPageCMDBResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ConfItemPageCMDB", ["BaseFiltersGenerateModule", "BusinessRuleModule", "HierarchicalRecordsUtilities",
		"RelationshipsRecordsUtilities"],
	function(BaseFiltersGenerateModule, BusinessRuleModule) {
		return {
			entitySchemaName: "ConfItem",
			details: /**SCHEMA_DETAILS*/{
				"Activity": {
					"schemaName": "ConfItemActivityDetail",
					"entitySchemaName": "Activity",
					"filter": {
						"detailColumn": "ConfItem",
						"masterColumn": "Id"
					}
				},
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "ConfItemFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ConfItem"
					}
				},
				"Case": {
					"schemaName": "CaseConfItemDetail",
					"entitySchemaName": "ConfItemInCase",
					"filter": {
						"detailColumn": "ConfItem",
						"masterColumn": "Id"
					}
				},
				"User": {
					"schemaName": "ConfItemUserDetail",
					"entitySchemaName": "ConfItemUser",
					"filter": {
						"detailColumn": "ConfItem",
						"masterColumn": "Id"
					}
				},
				"ConfItemAddress": {
					"schemaName": "ConfItemAddressDetail",
					"entitySchemaName": "ConfItemAddress",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ConfItem"
					}
				},
				"Component": {
					"schemaName": "ConfItemComponentDetail",
					"entitySchemaName": "ConfItem",
					"filter": {
						"detailColumn": "ParentConfItem",
						"masterColumn": "Id"
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
					"name": "Category",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Category",
						"caption": {
							"bindTo": "Resources.Strings.CategoryCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Type",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Type",
						"caption": {
							"bindTo": "Resources.Strings.TypeCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Model",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Model",
						"caption": {
							"bindTo": "Resources.Strings.ModelCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "SerialNumber",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "SerialNumber",
						"caption": {
							"bindTo": "Resources.Strings.SerialNumberCaption"
						},
						"contentType": this.Terrasoft.ContentType.SHORT_TEXT,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "InventoryNumber",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "InventoryNumber",
						"caption": {
							"bindTo": "Resources.Strings.InventoryNumberCaption"
						},
						"contentType": this.Terrasoft.ContentType.SHORT_TEXT,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "Owner",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Owner",
						"caption": {
							"bindTo": "Resources.Strings.OwnerCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "ActualStatusGroup_GridLayout",
					"propertyName": "items",
					"index": 5
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
					"name": "ActualStatusGroup_GridLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 0
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
						"bindTo": "Status",
						"caption": {
							"bindTo": "Resources.Strings.StatusCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "PurchaseDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "PurchaseDate",
						"caption": {
							"bindTo": "Resources.Strings.PurchaseDateCaption"
						},
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "ActualStatusGroup_GridLayout",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "CancelDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "CancelDate",
						"enabled": {
							"bindTo": "CancelDateEnabled"
						},
						"caption": {
							"bindTo": "Resources.Strings.CancelDateCaption"
						},
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "ActualStatusGroup_GridLayout",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "WarrantyUntil",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "WarrantyUntil",
						"caption": {
							"bindTo": "Resources.Strings.WarrantyUntilCaption"
						},
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "ActualStatusGroup_GridLayout",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "ParentConfItem",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ParentConfItem",
						"caption": {
							"bindTo": "Resources.Strings.ParentConfItemCaption"
						},
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "ActualStatusGroup_GridLayout",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "HistoryTab",
					"values": {
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.HistoryTabCaption"
						}
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Case",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ConfItemAddress",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "User",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Component",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "NotesFilesTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.NotesFilesTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "Files",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "NotesFilesTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "NotesControlGroup",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.NotesGroupCaption"
						}
					},
					"parentName": "NotesFilesTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Notes",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
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
					},
					"parentName": "NotesControlGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Activity",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 1
				}
			]/**SCHEMA_DIFF*/,
			messages: {
				/**
				 * @message UpdateConfItemPage
				 * Updates configuration item page.
				 */
				"UpdateConfItemPage": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				HierarchicalRecordsUtilities: "Terrasoft.HierarchicalRecordsUtilities",
				RelationshipsRecordsUtilities: "Terrasoft.RelationshipsRecordsUtilities"
			},
			attributes: {
				"Owner": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {filter: BaseFiltersGenerateModule.OwnerFilter}
				},
				"Status": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					dependencies: [
						{
							columns: ["Status"],
							methodName: "onStatusChanged"
						}
					],
					lookupListConfig: {
						columns: ["IsFinal"]
					}
				},
				"Model": {
					lookupListConfig: {
						filter: function() {
							return this.getModelFilters();
						}
					}
				},
				"ParentConfItem": {
					lookupListConfig: {
						filter: function() {
							var masterRecordId = this.get("Id");
							var parentRecord = this.get("ParentConfItem");
							return this.mixins.RelationshipsRecordsUtilities.getHierarchicalFilter.call(this,
									masterRecordId, parentRecord, "ParentConfItem");
						}
					}
				}
			},
			methods: {
				onLookupResult: function(args) {
					if (args.columnName !== "ParentConfItem" || this.isNewMode()) {
						this.callParent(arguments);
					}  else {
						var selectedItems = args.selectedRows.getItems();
						if(selectedItems.length !== 0) {
							var serviceArgs = {
								parentElement: selectedItems[0],
								childId: [this.get("Id")],
								schemaName: "ConfItem",
								parentColumnName:"ParentConfItemId",
								lookupParentColumnName: "ParentConfItem"
							};
							this.mixins.RelationshipsRecordsUtilities.callHierarchicalService.call(this, serviceArgs);
						}
					}
				},
				/**
				 * @inheritDoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 *
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("UpdateConfItemPage", this.onUpdateConfItemPage, this);
				},

				/**
				 * Updates configuration item page.
				 * @private
				 */
				onUpdateConfItemPage: function() {
					this.updateDetail({
						detail: "ConfItemAddress"
					});
					this.save();
				},
				/**
				 * On status field change handler.
				 * @protected
				 */
				onStatusChanged: function() {
					var status = this.get("Status");
					if (!status) {
						return;
					}
					if (status.IsFinal) {
						var cancelDate = this.get("CancelDate");
						if (Ext.isDate(cancelDate)) {
							return;
						}
						cancelDate = new Date();
						cancelDate = new Date(cancelDate.setMilliseconds(0));
						cancelDate = new Date(cancelDate.setSeconds(0));
						cancelDate = new Date(cancelDate.setMinutes(0));
						cancelDate = new Date(cancelDate.setHours(0));
						this.set("CancelDate", cancelDate);
						this.set("CancelDateEnabled", true);
					} else {
						this.set("CancelDate", null);
						this.set("CancelDateEnabled", false);
					}
				},

				/**
				 * Return Model filter group.
				 * @protected
				 * @returns {Terrasoft.FilterGroup}
				 */
				getModelFilters: function() {
					var model = this.get("Model");
					if (!model) {
						return;
					}
					var filtersCollection = this.Terrasoft.createFilterGroup();
					filtersCollection.add("NotAlreadySelectedModelFilter",
						this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL,
							"Id", model.value));
					return filtersCollection;
				},

				/**
				 * Before parent configuration items load.
				 */
				onLoadParentConfItem: function() {
					this.mixins.HierarchicalRecordsUtilities.onLoadParent.call(this);
				},

				/**
				 * On parent configuration items load.
				 */
				onPrepareParentConfItem: function(filter) {
					this.mixins.HierarchicalRecordsUtilities.onPrepareParent.call(this, filter);
				},

				/**
				 * Returns filters for parent configuration item field.
				 * @overridden
				 * @private
				 * @param {String} columnName Column name
				 * @return {Terrasoft.FilterGroup}
				 */
				getLookupQueryFilters: function(columnName) {
					var parentColumnName = this.get("ParentColumnName");
					var parentFilters = this.get(parentColumnName + "Filters");
					var filterGroup = this.callParent([columnName]);
					if (columnName === parentColumnName && parentFilters) {
						filterGroup.add(parentFilters);
					}
					return filterGroup;
				},

				/**
				 * Returns ESQ for lookup columns.
				 * @overridden
				 * @private
				 * @param {String} filterValue PrimaryDisplayColumn filter
				 * @param {String} columnName ViewModel column name
				 * @param {Boolean} isLookup Is Field lookup
				 * @return {Terrasoft.EntitySchemaQuery}
				 */
				getLookupQuery: function(filterValue, columnName, isLookup) {
					var parentColumnName = this.get("ParentColumnName");
					var parentFilters = this.get(parentColumnName + "Filters");
					var entitySchemaQuery = this.callParent([filterValue, columnName, isLookup]);
					if (columnName === parentColumnName && parentFilters) {
						entitySchemaQuery.filters.add(parentColumnName + "Filter", parentFilters);
					}
					return entitySchemaQuery;
				},

				/**
				 * @inheritDoc Terrasoft.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1065);
					this.callParent(arguments);
				}
			},
			rules: {
				"Model": {
					"FiltrationModelByCategory": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "ConfItemType.ConfItemCategory",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Category"
					},
					"FiltrationModelByType": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "ConfItemType",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Type"
					}
				},
				"Type": {
					"FiltrationTypeByCategory": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"autoClean": true,
						"baseAttributePatch": "ConfItemCategory",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "Category"
					}
				}
			},
			userCode: {}
		};
	});

define('ConfItemPageServiceModelResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ConfItemPageServiceModel", [],
	function() {
		return {
			entitySchemaName: "ConfItem",
			messages: {
				/**
				 * @message UpdateRelationshipDetail
				 * ######### ###### ############ ##
				 */
				"UpdateRelationshipDetail": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			details: /**SCHEMA_DETAILS*/{
				"ServiceItem": {
					"schemaName": "ServiceInConfItemDetail",
					"filterMethod": "getServiceItemDetailFilter",
					"defaultValues": {
						"ConfItem": {
							"masterColumn": "Id"
						}
					}
				},
				"ConfItemRelationship": {
					"schemaName": "ConfItemRelationshipDetail",
					"filterMethod": "getConfItemRelationshipDetailFilter",
					"defaultValues": {
						"ConfItemA": {
							"masterColumn": "Id"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "RelationshipTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.RelationshipTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "RelationshipControlGroup",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"visible": false,
						"items": []
					},
					"parentName": "RelationshipTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ServiceItem",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "RelationshipTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ConfItemRelationship",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "RelationshipTab",
					"propertyName": "items",
					"index": 2
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * ############# ## ####### ########## ######.
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("UpdateRelationshipDetail", this.onUpdateRelationshipDetail, this);
				},
				/**
				 * ######### ###### ## ########.
				 */
				onUpdateRelationshipDetail: function() {
					this.updateDetail({
						detail: "ConfItemRelationship"
					});
				},

				/**
				 * ####### ####### ###### ConfItemRelationship.
				 * @return {Terrasoft.createFilterGroup}
				 */
				getConfItemRelationshipDetailFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.add("ConfItemFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ConfItemA", this.get("Id")));
					return filterGroup;
				},

				/**
				 * ####### ####### ###### ServiceItem.
				 * @return {Terrasoft.createFilterGroup}
				 */
				getServiceItemDetailFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.add("ConfItemFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ConfItem", this.get("Id")));
					return filterGroup;
				},
				/**
				 * ########## ####### ## ######## "########## ###########".
				 * ### ####### ## ###### "########## ###########" ########### ######## ########### ###.
				 */
				openServiceModelModule: function() {
					var defaultValues = [{
						"id": this.getCurrentRecordId(),
						"schemaName": this.getEntitySchemaName(),
						"name": this.get("Name")
					}];
					this.openCardInChain({
						"schemaName": "ServiceModelPage",
						"moduleId": this.sandbox.id + "_ServiceModelPage",
						"isSeparateMode": false,
						"defaultValues": defaultValues
					});
				},
				/**
				 * ######### ######## # ###### ######## ## ######## ############## ############.
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.callParent(arguments);
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Tag": "openServiceModelModule",
						"Caption": this.get("Resources.Strings.OpenServiceModelModuleCaption"),
						"Enabled": !this.isNewMode()
					}));
					return actionMenuItems;
				}
			}
		};
	});

define('ConfItemPageChangeResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ConfItemPageChange", [],
    function() {
        return {
            entitySchemaName: "ConfItem",
            details: /**SCHEMA_DETAILS*/{
                "Change": {
                    "schemaName": "ChangeInConfItemDetail",
                    "entitySchemaName": "ChangeConfItem",
                    "filter": {
                        "masterColumn": "Id",
                        "detailColumn": "ConfItem"
                    }
                }
            }/**SCHEMA_DETAILS*/,
            diff: /**SCHEMA_DIFF*/[
                {
                    "operation": "insert",
                    "name": "Change",
                    "values": {
                        "itemType": this.Terrasoft.ViewItemType.DETAIL
                    },
                    "parentName": "HistoryTab",
                    "propertyName": "items",
                    "index": 2
                }
            ]/**SCHEMA_DIFF*/
        };
    });

define("ConfItemPage", [],
    function() {
        return {
            entitySchemaName: "ConfItem",
            details: /**SCHEMA_DETAILS*/{
                "Release": {
                    "schemaName": "ReleaseInConfItemDetail",
                    "entitySchemaName": "ReleaseConfItem",
                    "filter": {
                        "masterColumn": "Id",
                        "detailColumn": "ConfItem"
                    }
                }
            }/**SCHEMA_DETAILS*/,
            diff: /**SCHEMA_DIFF*/[
                {
                    "operation": "insert",
                    "name": "Release",
                    "values": {
                        "itemType": this.Terrasoft.ViewItemType.DETAIL
                    },
                    "parentName": "HistoryTab",
                    "propertyName": "items",
                    "index": 3
                }
            ]/**SCHEMA_DIFF*/
        };
    });


