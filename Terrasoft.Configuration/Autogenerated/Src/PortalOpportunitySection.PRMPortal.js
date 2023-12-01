﻿define("PortalOpportunitySection", ["terrasoft", "PrmPortalFunnelBaseDataProvider"],
	function() {
		return {
			entitySchemaName: "VwPortalOpportunity",
			attributes: {
				"CurrentUserAccount": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP
				}
			},
			diff: /**SCHEMA_DIFF*/ [
			],/**SCHEMA_DIFF*/
			methods: {
					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#getFilters
					 * @overridden
					 */
					getFilters: function() {
						var filters = this.callParent(arguments);
						var currentUserAccount = this.$CurrentUserAccount;
						if (currentUserAccount) {
							filters.add("Partner", this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Partner", currentUserAccount));
						} else {
							filters.add("EmptyFilter", this.Terrasoft.createIsNullFilter(
						this.Ext.create("Terrasoft.ColumnExpression", {columnPath: "Id"})));
						}
						return filters;
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#getModuleCaption
					 * @overridden
					 */
					getModuleCaption: function() {
						var historyState = this.getHistoryStateInfo();
						var cardSchema = historyState.schemas[0];
						var sectionModule = cardSchema ? "" : historyState.module;
						var filters = [{
							property: "entitySchemaName",
							value: this.entitySchemaName
						}, {
							property: "cardSchema",
							value: cardSchema
						}, {
							property: "sectionSchema",
							value: cardSchema
						}, {
							property: "sectionModule",
							value: sectionModule
						}];
						var sectionInfo = this.getFilteredSectionInfo(filters);
						return sectionInfo ? sectionInfo.moduleCaption : "";
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#init
					 * @overriden
					 */
					init: function(){
						this.callParent(arguments);
						this.set("IsAddRecordButtonVisible", false);
						this.set("ActiveRowActions", []);
						this.set("IsGridSettingsMenuVisible", false);
						this._setCurrentUserAccount();
					},

					/**
					 * Set account of current user to attribute
					 * @private
					 */
					_setCurrentUserAccount: function() {
						var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "Contact"
						});
						esq.addColumn("Account");
						esq.getEntity(Terrasoft.SysValue.CURRENT_USER_CONTACT.value, function(result) {
							if (result.success && result.entity.$Account) {
								this.set("CurrentUserAccount", result.entity.$Account.value);
							}
						}, this);
					}
			}
		};
	});
