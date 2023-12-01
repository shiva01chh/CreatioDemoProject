﻿define("LeadSectionV2", ["terrasoft", "BaseFiltersGenerateModule"],
	function(Terrasoft, BaseFiltersGenerateModule) {
		return {
			entitySchemaName: "Lead",
			columns: {},
			messages: {
				"GetMapsConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseSection#initFixedFiltersConfig
				 * @overridden
				 */
				initFixedFiltersConfig: function() {
						var fixedFilterConfig = {
							entitySchema: this.entitySchema,
							filters: [
								{
									name: "Owner",
									caption: this.get("Resources.Strings.OwnerFilterCaption"),
									dataValueType: Terrasoft.DataValueType.LOOKUP,
									filter: BaseFiltersGenerateModule.OwnerFilter,
									columnName: "Owner"
								}
							]
						};
						this.set("FixedFilterConfig", fixedFilterConfig);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSection#getAddMiniPageDefaultValues
				 * @overridden
				 */
				getAddMiniPageDefaultValues: function() {
					var defaultValues = this.callParent(arguments);
					defaultValues.push({
						name: "IsFromSection",
						value: true
					});
					return defaultValues;
				},

				/**
				 * Initializing context help
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1009);
					this.callParent(arguments);
				},

				/**
				 * Action "Show on map"
				 */
				openShowOnMap: function() {
					this.showBodyMask();
					var items = this.getSelectedItems();
					var select = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Lead"
					});
					select.addColumn("Id");
					select.addColumn("LeadName");
					select.addColumn("Address");
					select.addColumn("City");
					select.addColumn("Region");
					select.addColumn("Country");
					select.filters.add("LeadIdFilter", Terrasoft.createColumnInFilterWithParameters("Id", items));
					select.getEntityCollection(function(result) {
						if (result.success) {
							var mapsConfig = {
								mapsData: []
							};
							result.collection.each(function(item) {
								var fullAddress = [];
								var country = item.get("Country");
								if (country) {
									fullAddress.push(country.displayValue);
								}
								var region = item.get("Region");
								if (region) {
									fullAddress.push(region.displayValue);
								}
								var city = item.get("City");
								if (city) {
									fullAddress.push(city.displayValue);
								}
								var address = item.get("Address");
								fullAddress.push(address);

								var leadName = item.get("LeadName");
								var dataItem = {
									caption: leadName,
									content: "<h2>" + leadName + "</h2><div>" + fullAddress.join(", ") + "</div>",
									address: address ? fullAddress.join(", ") : null
								};
								mapsConfig.mapsData.push(dataItem);
							});
							var uniqueMapsId = Terrasoft.generateGUID();
							var mapsModuleSandboxId = this.sandbox.id + "_MapsModule" + uniqueMapsId;
							this.sandbox.subscribe("GetMapsConfig", function() {
								return mapsConfig;
							}, [mapsModuleSandboxId]);
							this.sandbox.loadModule("MapsModule", {
								id: mapsModuleSandboxId,
								keepAlive: true
							});
						}
						this.hideBodyMask();
					}, this);
				},

				/**
				 * Returns a collection of action section in the register display mode
				 * @protected
				 * @overridden
				 * @return {Terrasoft.BaseViewModelCollection} Returns a collection of action section in the
				 * register display mode
				 */
				getSectionActions: function() {
					var actionMenuItems = this.callParent(arguments);
					actionMenuItems.addItem(this.getButtonMenuItem({
						Type: "Terrasoft.MenuSeparator",
						Caption: ""
					}));
					actionMenuItems.addItem(this.getButtonMenuItem({
						Click: { bindTo: "openShowOnMap" },
						Caption: { "bindTo": "Resources.Strings.ShowOnMap" },
						Enabled: { "bindTo": "isAnySelected" },
						Tag: "ShowOnMap"
					}));
					return actionMenuItems;
				}
			},
			diff: /**SCHEMA_DIFF*/[
				/*{
					"operation": "insert",
					"parentName": "DisqualifyGroupAction",
					"propertyName": "menu",
					"name": "DisqualifyLostLeadAction",
					"values": {
						"caption": { "bindTo": "Resources.Strings.DisqualifyLeadLost" },
						"click": { "bindTo": "onCardAction" },
						"tag": "disqualifyLost"
					}
				},
				{
					"operation": "insert",
					"parentName": "DisqualifyGroupAction",
					"propertyName": "menu",
					"name": "DisqualifyLeadNoConnectionAction",
					"values": {
						"caption": { "bindTo": "Resources.Strings.DisqualifyLeadNoConnection" },
						"click": { "bindTo": "onCardAction" },
						"tag": "disqualifyNoConnection"
					}
				},
				{
					"operation": "insert",
					"parentName": "DisqualifyGroupAction",
					"propertyName": "menu",
					"name": "DisqualifyLeadNotInterestedAction",
					"values": {
						"caption": { "bindTo": "Resources.Strings.DisqualifyLeadNotInterested" },
						"click": { "bindTo": "onCardAction" },
						"tag": "disqualifyNotInterested"
					}
				}*/
			]/**SCHEMA_DIFF*/
		};
	});
