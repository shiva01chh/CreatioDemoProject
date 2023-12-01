﻿define("SocialAddressDetail", ["Country", "Region", "City"], function(Country, Region, City) {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.SocialAnniversaryDetail#createSocialEntityDataRows
			 * @overridden
			 */
			createSocialEntityDataRows: function(config) {
				if (!config) {
					return;
				}
				var socialNetworkData = config.socialNetworkData;
				if (this.Ext.isEmpty(socialNetworkData)) {
					return;
				}
				this.getLocationData({socialNetworkData: socialNetworkData}, function(locationsData) {
					var countries = locationsData.Country;
					var regions = locationsData.Region;
					var cities = locationsData.City;
					var collection = this.Ext.create("Terrasoft.Collection");
					this.Terrasoft.each(socialNetworkData, function(entity) {
						var country = countries[entity.country];
						var region = regions[entity.region];
						var state = regions[entity.state];
						var city = cities[entity.city];
						var dataRow = {
							"Zip": entity.zip
						};
						if (country) {
							dataRow.Country = country;
							delete entity.country;
						}
						if (state) {
							dataRow.Region = state;
							delete entity.state;
						} else if (region) {
							dataRow.Region = region;
							delete entity.region;
						}
						if (city) {
							dataRow.City = city;
							delete entity.city;
						}
						dataRow.Address = this.getFormattedAddress(entity);
						var isAddressValid = this.validateAddress(dataRow);
						if (isAddressValid) {
							collection.add(dataRow);
						}
					}, this);
					config.callback.call(config.scope || this, collection);
				}, this);
			},

			/**
			 * ########## ############ ##### ####### ###### ######.
			 * @private
			 * @param {String} location.street #####
			 * @param {String} location.city #####
			 * @param {String} location.region ######
			 * @param {String} location.state ####
			 * @param {String} location.country ######
			 * @return {String} ############ ##### ####### ###### ######.
			 */
			getFormattedAddress: function(location) {
				var locationInfo = [location.street, location.city, location.region, location.state, location.country];
				return locationInfo.filter(function(item) {
					return item;
				}).join(", ");
			},

			/**
			 * ######### ######## ### #### ######## # ############ #####, ########, ######, #######.
			 * @private
			 * @param {Object} config ############ ######.
			 * @param {Object} config.socialNetworkData ##### ######## ########### ######.
			 * @param {Function} callback ####### ######### ######.
			 * @param {Object} scope ######## ########## ####### ######### ######.
			 */
			getLocationData: function(config, callback, scope) {
				var batchQuery = this.Ext.create("Terrasoft.BatchQuery");
				this.Terrasoft.each(config.socialNetworkData, function(entity) {
					var country = entity.country;
					if (country) {
						var countryQuery = this.getEntityDataQuery(Country, country);
						batchQuery.add(countryQuery);
					}
					var region = entity.region;
					if (region) {
						var regionQuery = this.getEntityDataQuery(Region, region);
						batchQuery.add(regionQuery);
					}
					var state = entity.state;
					if (state) {
						var stateQuery = this.getEntityDataQuery(Region, state);
						batchQuery.add(stateQuery);
					}
					var city = entity.city;
					if (city) {
						var cityQuery = this.getEntityDataQuery(City, city);
						batchQuery.add(cityQuery);
					}
				}, this);
				var result = {
					Country: {},
					Region: {},
					City: {}
				};
				if (batchQuery.queries.length === 0) {
					return callback.call(scope, result);
				}
				batchQuery.execute(function(response) {
					if (!response.success) {
						throw new Terrasoft.UnknownException();
					}
					this.Terrasoft.each(response.queryResults, function(queryResult) {
						var rows = queryResult.rows;
						if (rows.length === 0) {
							return;
						}
						var row = rows.pop();
						var resultObj = result[row.name] = result[row.name] || {};
						resultObj[row.displayValue] = {
							value: row.value,
							displayValue: row.displayValue
						};
					}, this);
					callback.call(scope, result);
				}, this);
			},

			/**
			 * @private
			 * @param {Object} rootSchema ##### ######, # ####### ########### ######.
			 * @param {String} primaryDisplayColumnValue ######## ############ ####### ## ######## ###########
			 * #########.
			 * @return {Object} ###### #######.
			 */
			getEntityDataQuery: function(rootSchema, primaryDisplayColumnValue) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchema: rootSchema,
					rowCount: 1
				});
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "value");
				esq.addMacrosColumn(this.Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "displayValue");
				esq.addParameterColumn(rootSchema.name, this.Terrasoft.DataValueType.TEXT, "name");
				esq.filters.addItem(this.Terrasoft.createPrimaryDisplayColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, primaryDisplayColumnValue));
				return esq;
			},

			/**
			 * ######### ############ ########## ##### ######.
			 * @param {Object} row ######, ########## ######## ######.
			 * @return {Boolean} ######### ########.
			 */
			validateAddress: function(row) {
				var result = true;
				this.Terrasoft.each(row, function(value) {
					result = (result && !this.Ext.isEmpty(value));
					return result;
				}, this);
				return result;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
