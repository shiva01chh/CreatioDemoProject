define("ServiceItemPage", [],
	function() {
		return {
			entitySchemaName: "ServiceItem",
			details: /**SCHEMA_DETAILS*/{
				"ConfItem": {
					"schemaName": "ConfItemInServiceDetail",
					"filterMethod": "getConfItemDetailFilter",
					"defaultValues": {
						"ServiceItem": {
							"masterColumn": "Id"
						}
					}
				},
				"ServiceRelationship": {
					"schemaName": "ServiceRelationshipDetail",
					"filterMethod": "getServiceRelationshipDetailFilter",
					"defaultValues": {
						"ServiceItemA": {
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
					"name": "ConfItem",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
					},
					"parentName": "RelationshipTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ServiceRelationship",
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
				 * ####### ####### ###### ###### ServiceRelationship.
				 * @returns {Terrasoft.createFilterGroup}
				 */
				getServiceRelationshipDetailFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.add("ConfItemFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ServiceItemA", this.get("Id")));
					return filterGroup;
				},
				/**
				 * ####### ###### ###### ConfItem.
				 * @returns {Terrasoft.createFilterGroup}
				 */
				getConfItemDetailFilter: function() {
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					filterGroup.add("ConfItemFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "ServiceItem", this.get("Id")));
					return filterGroup;
				},
				/**
				 * ########## ####### ## ######## "########## ###########".
				 * ### ####### ## ###### "########## ###########" ########### ######## ############## ###.
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
