define("BaseServiceModelRelationshipEditPage", [],
	function() {
		return {
			attributes: {
				"DependencyType": {
					"type": Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"dependencies": [
						{
							"columns": ["DependencyCategory"],
							"methodName": "onDependencyCategoryChanged"
						}
					]
				},
				"DependencyCategory": {
					"type": Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"dependencies": [
						{
							"columns": ["DependencyType"],
							"methodName": "onDependencyTypeChanged"
						}
					]
				},
				"DependencyTypeFilterColumnName": {
					"dataValueType": Terrasoft.DataValueType.TEXT
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
						filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.NOT_EQUAL,
							"Id",
							sectionColumn.value));
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
					var dependencyCategory = this.get("DependencyCategory");
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
					var dependencyCategory = this.get("DependencyCategory");
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
							this.set("DependencyCategory", dependencyCategory);
						}
					}, this);
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
				 * @protected
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
						this.get("DependencyTypeFilterColumnName"),
						true,
						scope.Terrasoft.DataValueType.BOOLEAN));
					var dependencyCategory = scope.get("DependencyCategory");
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
				}
			}
		};
	});
