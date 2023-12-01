Terrasoft.configuration.Structures["ServiceInConfItemEditPage"] = {innerHierarchyStack: ["ServiceInConfItemEditPage"], structureParent: "BaseModulePageV2"};
define('ServiceInConfItemEditPageStructure', ['ServiceInConfItemEditPageResources'], function(resources) {return {schemaUId:'9aa193fb-bf36-4baf-af9d-171ee13cdb31',schemaCaption: "Object edit page - \"Connected configuration service\"", parentSchemaName: "BaseModulePageV2", packageName: "ServiceModel", schemaName:'ServiceInConfItemEditPage',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceInConfItemEditPage", ["StorageUtilities", "ServiceInConfItemEditPageResources"],
	function(StorageUtilities, resources) {
		return {
			entitySchemaName: "VwServiceInConfItem",
			attributes: {
				"ServiceItem": {
					"lookupListConfig": {
						"filter": function() {
							return this.getLookupFilter("ServiceItem", "ConfItem");
						}
					}
				},
				"ConfItem": {
					"lookupListConfig": {
						"filter": function() {
							return this.getLookupFilter("ConfItem", "ServiceItem");
						}
					}
				},
				"DependencyType": {
					"dependencies": [
						{
							columns: ["DependencyCategory", "DependencyCategoryReverse"],
							methodName: "onDependencyCategoryChanged"
						}
					]
				},
				"DependencyCategory": {
					"dependencies": [
						{
							columns: ["DependencyType"],
							methodName: "onDependencyTypeChanged"
						}
					]
				},
				"DependencyCategoryReverse": {
					"dependencies": [
						{
							columns: ["DependencyType"],
							methodName: "onDependencyTypeChanged"
						}
					]
				}
			},
			methods: {
				/**
				 * ######## ###### ### ########### #### # #######
				 * @param {String} detailColumnName ### #### ########### #### ###### # ####### ########
				 * @param {String} sectionColumnName ### #### ########### #### ####### # ####### ########
				 * @return {Terrasoft.createFilterGroup}
				 */
				getLookupFilter: function(detailColumnName, sectionColumnName) {
					var filters = this.Terrasoft.createFilterGroup();
					var sectionColumn = this.get(sectionColumnName);
					if (sectionColumn && sectionColumn.value !== Terrasoft.GUID_EMPTY) {
						var typeFilter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							sectionColumnName,
							sectionColumn.value);
						var notExistsFilter = this.Terrasoft.createNotExistsFilter(
							"[" + this.entitySchemaName + ":" + detailColumnName + ":Id].Id");
						notExistsFilter.subFilters.addItem(typeFilter);
						filters.addItem(notExistsFilter);
					}
					return filters;
				},

				/**
				 * ####### #### "### ###########", ### ######### #### "######### ###########".
				 */
				onDependencyCategoryChanged: function() {
					var dependencyType = this.get("DependencyType");
					if (dependencyType == null) {
						return;
					}
					var dependencyCategoryColumnName = this.getCategoryColumnName();
					var dependencyCategory = this.get(dependencyCategoryColumnName);
					if (dependencyCategory == null) {
						this.set("DependencyType", null);
						return;
					}
					var dependencyTypeCategory = this.get("DependencyTypeCategory");
					if (dependencyCategory.value === dependencyTypeCategory.value) {
						return;
					}
					this.set("DependencyType", null);
				},

				/**
				 * ######### #### "######### ###########, ### ######### #### "### ###########".
				 */
				onDependencyTypeChanged: function() {
					var dependencyType = this.get("DependencyType");
					if (dependencyType == null) {
						return;
					}
					var dependencyCategoryColumnName = this.getCategoryColumnName();
					var dependencyCategory = this.get(dependencyCategoryColumnName);
					if (dependencyCategory != null) {
						return;
					}
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "DependencyType"
					});
					esq.addColumn("DependencyCategory");
					esq.getEntity(dependencyType.value, function(result) {
						if (result.success) {
							var dependencyCategory = result.entity.get("DependencyCategory");
							this.set("DependencyTypeCategory", dependencyCategory);
							this.set(dependencyCategoryColumnName, dependencyCategory);
						}
					}, this);
				},

				/**
				 * ######## ### ####### "######### ########### ########"
				 */
				getCategoryColumnName: function() {
					var currentSectionName = StorageUtilities.getItem("ServiceModelCurrentSectionName");
					return currentSectionName === "ServiceItemSection"
						? "DependencyCategory"
						: "DependencyCategoryReverse";
				},

				/**
				 * ########## ####### ########### ######## "######### ########### ########".
				 * @return {Terrasoft.DataValueType.BOOLEAN} ####### ########### ########
				 */
				getDependencyCategoryEnabled: function() {
					return this.isNew;
				},

				/**
				 * ########## ###### ##### ########### ########.
				 * @return {Terrasoft.DataValueType.COLLECTION} ###### ##### ########### ########
				 */
				getDependencyTypeList: function() {
					this.getDependencyTypeEsq(function(esq, dependencyCategory, scope) {
						esq.getEntityCollection(function(result) {
							scope.fillDependencyTypeList(result, dependencyCategory);
						}, scope);
					}, this);
				},

				/**
				 * ######### ######### EntitySchemaQuery "### ########### ########" ### ###### ########## #####
				 * @protected
				 * @param {Function} callback ####### ############ ######### "##### ############ ########"
				 * @param {Terrasoft.BaseSchemaViewModel} scope ######## ########## callback-#######
				 */
				getDependencyTypeEsq: function(callback, scope) {
					var dependencyTypeSelect = Ext.create("Terrasoft.EntitySchemaQuery",
						{rootSchemaName: "DependencyType"});
					dependencyTypeSelect.addColumn("Id");
					dependencyTypeSelect.addColumn("Name");
					dependencyTypeSelect.addColumn("ReverseTypeName");
					dependencyTypeSelect.addColumn("DependencyCategory");
					dependencyTypeSelect.filters.add(scope.Terrasoft.createColumnFilterWithParameter(
						scope.Terrasoft.ComparisonType.EQUAL,
						"ForServiceConfItem",
						true,
						scope.Terrasoft.DataValueType.BOOLEAN));
					var dependencyCategoryColumnName = this.getCategoryColumnName();
					var dependencyCategory = this.get(dependencyCategoryColumnName);
					callback(dependencyTypeSelect, dependencyCategory, scope);
				},

				/**
				 * ######### ###### ##### ########### ########.
				 * @protected
				 * @param {Object} response ##### ## ###### ##### ########### ########.
				 * @param {Terrasoft.ENTITY_COLUMN} dependencyCategory ####### "######### ########### #######"
				 */
				fillDependencyTypeList: function(response, dependencyCategory) {
					var list = this.get("DependencyTypeList");
					if (response.success) {
						var responseItems = response.collection.getItems();
						var columnList = {};
						this.Terrasoft.each(responseItems, function(item) {
							var id = item.get("Id");
							var name = item.get("Name");
							var reverseTypeName = item.get("ReverseTypeName");
							if (dependencyCategory == null) {
								columnList[name + id] = {
									value: item.get("Id"),
									displayValue: item.get("Name")
								};
								columnList[reverseTypeName + id] = {
									value: item.get("Id"),
									displayValue: item.get("ReverseTypeName")
								};
							} else {
								var dependencyTypeCategory = item.get("DependencyCategory");
								if (dependencyCategory.value === dependencyTypeCategory.value) {
									columnList[name + id] = {
										value: item.get("Id"),
										displayValue: item.get("Name")
									};
								} else {
									columnList[reverseTypeName + id] = {
										value: item.get("Id"),
										displayValue: item.get("ReverseTypeName")
									};
								}
							}
						});
						list.clear();
						list.loadAll(columnList);
					}
				},
				/**
				 * @inheritDoc Terrasoft.BasePageV2#validateColumn
				 * @overridden
				 */
				validateColumn: function(columnName) {
					var result = {
						isValid: this.callParent(arguments)
					};
					var dependencyCategoryColumnName = this.getCategoryColumnName();
					if (dependencyCategoryColumnName !== columnName) {
						return result.isValid;
					}
					var dependencyCategory = this.get(dependencyCategoryColumnName);
					var isValid = !this.Ext.isEmpty(dependencyCategory);
					if (!isValid) {
						result.invalidMessage = resources.localizableStrings.DependencyCategoryErrorMessage;
						result.isValid = false;
					}
					this.validationInfo.set(columnName, result);
					return result.isValid;
				}
			}
		};
	});


