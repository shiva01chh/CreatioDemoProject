﻿define("LeadDefaultsPageV2", ["LeadDefaultsPageV2Resources", "ConfigurationEnums", "Lead"],
	function(resources, enums, lead) {
		return {
			entitySchemaName: "LandingLeadDefaults",
			attributes: {
				/**
				 * List of available columns.
				 */
				LeadColumns: {
					dataValueType: this.Terrasoft.DataValueType.ENUM,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isCollection: true
				},
				/**
				 * Currently selected column.
				 */
				LeadConfigurableColumn: {
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"caption": resources.localizableStrings.ColumnNameCaption,
					"isRequired": true
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"name": "Name",
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"bindTo": "LeadConfigurableColumn",
						"layout": {"column": 0, "row": 1, "colSpan": 10},
						"dataValueType": this.Terrasoft.DataValueType.ENUM,
						"labelConfig": {
							"visible": true,
							"caption": resources.localizableStrings.ColumnNameCaption
						},
						"controlConfig": {
							"className": "Terrasoft.ComboBoxEdit",
							"change": {
								"bindTo": "onLeadColumnChanged"
							},
							"prepareList": {
								"bindTo": "prepareLeadColumns"
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "ValueContainer",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"layout": {"column": 0, "row": 2, "colSpan": 10},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "TextValue",
					"values": {
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							"bindTo": "TextValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "IntegerValue",
					"values": {
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							bindTo: "IntegerValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "FloatValue",
					"values": {
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							bindTo: "FloatValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "BooleanValue",
					"values": {
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"visible": {
							bindTo: "BooleanValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "DateTimeValue",
					"values": {
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							bindTo: "DateTimeValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "DateValue",
					"values": {
						"bindTo": "DateTimeValue",
						"dataValueType": this.Terrasoft.DataValueType.DATE,
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							bindTo: "DateValueVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ValueContainer",
					"propertyName": "items",
					"name": "LookupValue",
					"values": {
						"bindTo": "LookupValue",
						"labelConfig": {
							"caption": {
								"bindTo": "Resources.Strings.ColumnValueCaption"
							}
						},
						"isRequired": true,
						"visible": {
							bindTo: "LookupValueVisible"
						},
						"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareLookupValueList"
							}
						}
					}
				},
				{
					"operation": "merge",
					"name": "ViewOptionsButton",
					"values": {
						"visible": false
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {

				/**
				 * @inheritdoc BasePageV2#initActionButtonMenu
				 * @overridden
				 */
				initActionButtonMenu: this.Terrasoft.emptyFn,

				/**
				 * ########## ######### ######## ########### ######.
				 * @param {Object} item ###### ######## ########### ######.
				 * @private
				 */
				onLeadColumnChanged: function(item) {
					if (item && item.value) {
						this.set("ColumnUId", item.value);
						this.set("ColumnCaption", item.displayValue);
						this.clearUnusedDefaultsColumns();
						var leadConfigurableColumn = this.getLeadConfigurableColumn();
						this.updateMarkupVisibility(leadConfigurableColumn.dataValueType);
						var guidValue = this.get("GuidValue");
						if (guidValue && leadConfigurableColumn.dataValueType === Terrasoft.DataValueType.LOOKUP) {
							this.loadLookupDisplayValue("LookupValue", guidValue);
						}
					}
				},

				/**
				 * ########## ######## ######## ### ########## #### #######.
				 * @protected
				 * @param {Number} valueType ### ######.
				 * @return {String} ######## ########.
				 */
				getMarkupAttributeName: function(valueType) {
					var result = "";
					switch (valueType) {
						case Terrasoft.DataValueType.GUID:
							result = "Text";
							break;
						case Terrasoft.DataValueType.TEXT:
							result = "Text";
							break;
						case Terrasoft.DataValueType.INTEGER:
							result = "Integer";
							break;
						case Terrasoft.DataValueType.FLOAT:
							result = "Float";
							break;
						case Terrasoft.DataValueType.MONEY:
							result = "Float";
							break;
						case Terrasoft.DataValueType.DATE_TIME:
							result = "DateTime";
							break;
						case Terrasoft.DataValueType.LOOKUP:
							result = "Lookup";
							break;
						case Terrasoft.DataValueType.BOOLEAN:
							result = "Boolean";
							break;
					}
					return result + "Value";
				},

				/**
				 * ######### ####### ############## #######.
				 * @protected
				 */
				clearUnusedDefaultsColumns: function() {
					var leadConfigurableColumn = this.getLeadConfigurableColumn();
					var markupAttributeName = this.getMarkupAttributeName(leadConfigurableColumn.dataValueType);
					var markupAttributeNames = this.getMarkupAttributeNames();
					Terrasoft.each(markupAttributeNames, function(attribute) {
						if (markupAttributeName !== attribute) {
							this.set(attribute, null);
						}
					}, this);
				},

				/**
				 * ############# ######### ##### ### ########## #### ####.
				 * @protected
				 * @param {Number} valueType ### ###### ########## #### ####.
				 */
				updateMarkupVisibility: function(valueType) {
					var markupAttributeName = this.getMarkupAttributeName(valueType);
					var markupAttributeNames = this.getMarkupAttributeNames();
					Terrasoft.each(markupAttributeNames, function(attributeName) {
						this.set(attributeName + "Visible", attributeName === markupAttributeName);
					}, this);
				},

				/**
				 * ########## ##### #########.
				 * @protected
				 * @return {Array} ###### ######## #########.
				 */
				getMarkupAttributeNames: function() {
					return ["BooleanValue", "DateTimeValue", "DateValue", "IntegerValue", "FloatValue", "TextValue",
						"LookupValue"];
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getLookupPageConfig
				 * @overridden
				 */
				getLookupPageConfig: function() {
					var leadConfigurableColumn = this.getLeadConfigurableColumn();
					var config = {
						entitySchemaName: leadConfigurableColumn.referenceSchemaName,
						multiSelect: false,
						columnName: "LookupValue"
					};
					return config;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getLookupQuery
				 * @overridden
				 */
				getLookupQuery: function(filterValue, columnName) {
					if (columnName !== "LookupValue") {
						return this.callParent(arguments);
					}
					var leadConfigurableColumn = this.getLeadConfigurableColumn();
					var referenceSchemaName = leadConfigurableColumn.referenceSchemaName;
					var entitySchemaQuery = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: referenceSchemaName,
						rowCount: 1
					});
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "value");
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "displayValue");
					return entitySchemaQuery;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getLinkUrl
				 * @overridden
				 */
				getLinkUrl: function() {
					return {};
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					var leadConfigurableColumn = this.getLeadConfigurableColumn();
					var markupAttributeName = this.getMarkupAttributeName(leadConfigurableColumn.dataValueType);
					var value = this.get(markupAttributeName);
					if (leadConfigurableColumn.dataValueType === Terrasoft.DataValueType.LOOKUP) {
						this.set("GuidValue", value && value.value);
					} else {
						this.set("GuidValue", null);
					}
					var resultObject = {
						success: this.validate(),
						message: this.getValidationMessage()
					};
					resultObject = this.validateConfigurableColumnValue(resultObject);
					if (this.validateResponse(resultObject)) {
						var displayValue = Terrasoft.getTypedStringValue(value, leadConfigurableColumn.dataValueType);
						this.set("DisplayValue", displayValue);
						this.callParent(arguments);
					}
				},

				/**
				 * ######### ######### ######## ### ############### #######.
				 * @protected
				 * @param {Object} resultObject ######### #########.
				 * @return {Object} ######### #########.
				 */
				validateConfigurableColumnValue: function(resultObject) {
					if (resultObject.success === true) {
						var leadConfigurableColumn = this.getLeadConfigurableColumn();
						var markupAttributeName = this.getMarkupAttributeName(leadConfigurableColumn.dataValueType);
						var leadConfigurableValue = this.get(markupAttributeName);
						if (Ext.isEmpty(leadConfigurableValue)) {
							resultObject.success = false;
							resultObject.message = resources.localizableStrings.ConfigurableColumnValueMessage;
							var info = {
								invalidMessage: resources.localizableStrings.ConfigurableColumnValueMessage,
								isValid: false
							};
							this.validationInfo.set(markupAttributeName, info);
							return resultObject;
						}
					}
					return resultObject;
				},

				/**
				 * @inheritDoc BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					var itemValue = this.get("ColumnUId");
					var itemDisplayValue = this.get("ColumnCaption");
					if (itemValue) {
						var leadConfigurableColumn = this.getListValue(itemValue, itemDisplayValue);
						this.set("LeadConfigurableColumn", leadConfigurableColumn);
					}
				},

				/**
				 * #########, ######### ## ########, # ###### ##############.
				 * @return {Boolean} ######### ########.
				 * @private
				 */
				isPageInEditState: function() {
					return this.get("Operation") === enums.CardStateV2.EDIT;
				},

				/**
				 * Prepare dropdown list.
				 * @param {String} filter
				 * @param {Terrasoft.Collection} list
				 * @private
				 */
				prepareLeadColumns: function(filter, list) {
					var leadColumns = this.get("LeadColumns");
					if (this.Ext.isEmpty(leadColumns)) {
						this.initializeLeadColumns(function() {
							this.reloadLeadColumnsList(list);
						}, this);
					} else {
						this.reloadLeadColumnsList(list);
					}

				},

				/**
				 * Reloads collection of the dropdown list items.
				 */
				reloadLeadColumnsList: function(list) {
					var availableColumns = this.get("LeadColumns");
					if ((list instanceof Terrasoft.Collection) && !this.Ext.isEmpty(availableColumns)) {
						list.clear();
						list.loadAll(availableColumns);
					}
				},

				/**
				 * ########## ###### ######## ########### ######.
				 * @param {String} value ########.
				 * @param {String} displayValue ############ ########.
				 * @return {Object} ###### ######## ########### ######.
				 * @private
				 */
				getListValue: function(value, displayValue) {
					return {
						value: value,
						displayValue: displayValue
					};
				},

				/**
				 * ########## ###### ####### ####, ## uId #######.
				 * @param {String} columnId uId #######.
				 * @returns {Object} ###### #######.
				 * @private
				 */
				getLeadConfigurableColumn: function() {
					var columnUId = this.get("ColumnUId");
					return lead.getColumnByUId(columnUId);
				},


				/**
				 * Initializes dropdown list of the available columns of the Lead.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope Execution context.
				 * @private
				 */
				initializeLeadColumns: function(callback, scope) {
					var items = [];
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						"rootSchemaName": this.entitySchemaName
					});
					esq.addColumn("ColumnUId");
					esq.filters.add(Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Landing", this.get("Landing").value));
					esq.getEntityCollection(function(response) {
						if (response && response.success) {
							var currentUId = this.get("ColumnUId");
							Terrasoft.each(lead.columns, function(column) {
								if (column.usageType === 0) {
									if (!this.containsColumnUId(response.collection, column.uId)) {
										items.push(this.getListValue(column.uId, column.caption));
									} else if (currentUId === column.uId && this.isPageInEditState()) {
										items.push(this.getListValue(column.uId, column.caption));
									}
								}
							}, this);
							items.sort(function(a, b) {
								return a.displayValue > b.displayValue ? 1 : a.displayValue < b.displayValue ? -1 : 0;
							});
							this.set("LeadColumns", this.convertArrayToObject(items));
						}
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * ############### ###### # ###### ## ##########.
				 * @param {Array} array ######.
				 * @returns {Object} ###### — ######### ##############.
				 * @private
				 */
				convertArrayToObject: function(array) {
					var object = {};
					Terrasoft.each(array, function(element) {
						object[element.value] = element;
					}, this);
					return object;
				},

				/**
				 * ######### ######## ## ######### ####### # ######## uId.
				 * @param {Terrasoft.Collection} collection #########
				 * @param {Object} value uId #######.
				 * @returns {boolean} ######### ########.
				 * @private
				 */
				containsColumnUId: function(collection, value) {
					var result = false;
					collection.each(function(item) {
						if (item.values.ColumnUId === value) {
							result = true;
						}
					}, this);
					return result;
				}
			}
		};
	});
