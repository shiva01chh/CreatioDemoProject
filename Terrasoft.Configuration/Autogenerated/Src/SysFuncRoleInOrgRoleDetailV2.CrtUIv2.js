﻿define("SysFuncRoleInOrgRoleDetailV2", ["terrasoft"],
	function(Terrasoft) {
		return {
			entitySchemaName: "SysFuncRoleInOrgRole",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
				 * @overridden
				 */
				addDetailWizardMenuItems: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getAddRecordButtonEnabled
				 * @overridden
				 */
				getAddRecordButtonEnabled: function() {
					return true;
				},

				/**
				 * ######### ###### # ###### ######. ####### ####### ######.
				 * @inheritdoc SysFuncRoleChiefInOrgRoleDetailV2#loadGridData
				 * @overridden
				 */
				loadGridData: function() {
					this.beforeLoadGridData();
					var esq = this.getGridDataESQ();
					this.initQueryColumns(esq);
					this.initQuerySorting(esq);
					this.initQueryFilters(esq);
					this.initQueryOptions(esq);
					this.initQueryEvents(esq);
					esq.getEntityCollection(function(response) {
						this.destroyQueryEvents(esq);
						this.onGridDataLoaded(response);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.SysFuncRoleChiefInOrgRoleDetailV2#getRoleLookupFilter
				 * @overridden
				 */
				getRoleLookupFilter: function() {
					var filters = Terrasoft.createFilterGroup();
					var typeFilter = this.Terrasoft.createColumnInFilterWithParameters("SysAdminUnitTypeValue",
						this.getFilterRoleType());
					var notExistsFilter = this.Terrasoft.createNotExistsFilter(
						"[SysFuncRoleInOrgRole:FuncRole:Id].Id");
					var subFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						"OrgRole",
						this.get("MasterRecordId"));
					notExistsFilter.subFilters.addItem(subFilter);
					filters.addItem(notExistsFilter);
					filters.addItem(typeFilter);
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.SysFuncRoleChiefInOrgRoleDetailV2#addCallback
				 * @overridden
				 */
				addCallback: function(args) {
					var config = {};
					if (this.isOrgRolesDetail()) {
						config = {
							serviceName: "AdministrationService",
							methodName: "AddFuncRoleInOrgRoles",
							data: {
								orgRoleIds: this.Ext.encode(args.selectedRows.getKeys()),
								funcRoleId: this.get("MasterRecordId")
							}
						};
					} else {
						config = {
							serviceName: "AdministrationService",
							methodName: "AddFuncRolesInOrgRole",
							data: {
								orgRoleId: this.get("MasterRecordId"),
								funcRoleIds: this.Ext.encode(args.selectedRows.getKeys())
							}
						};
					}
					this.showBodyMask();
					this.callService(config, function(response) {
						if (this.isOrgRolesDetail()) {
							response.message = response.AddFuncRoleInOrgRolesResult;
						} else {
							response.message = response.AddFuncRolesInOrgRoleResult;
						}
						response.success = this.Ext.isEmpty(response.message);
						if (this.validateResponse(response)) {
							this.hideBodyMask();
							this.reloadGridData();
						}
					}, this);
				},

                /**
                 * @overridden
                 * @return {String} ### #######.
                 */
                getFilterDefaultColumnName: function() {
					if (this.isOrgRolesDetail()) {
						return "OrgRole";
					} else {
						return "FuncRole";
					}
                },

				/**
				 * @protected
				 * @inheritdoc SysFuncRoleChiefInOrgRoleDetailV2#getFilters
				 * @overridden
				 * @return {Terrasoft.FilterGroup}
				 **/
				getFilters: function() {
					var filters = this.get("DetailFilters");
					var serializationInfo = filters.getDefSerializationInfo();
					serializationInfo.serializeFilterManagerInfo = true;
					var deserializedFilters = Terrasoft.deserialize(filters.serialize(serializationInfo));
					deserializedFilters.add("Filter", this.get("Filter"));
					return deserializedFilters;
				}
			}
		};
	});
