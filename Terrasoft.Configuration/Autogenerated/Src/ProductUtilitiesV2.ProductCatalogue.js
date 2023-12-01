define("ProductUtilitiesV2", ["DiscountUtils", "MoneyModule", "MoneyUtilsMixin", "ConfigurationConstants"],
	function(DiscountUtils, MoneyModule) {
		/**
		 * @class Terrasoft.configuration.ProductUtilities
		 * ############### #####
		 */
		Ext.define("Terrasoft.configuration.ProductUtilities", {
			alternateClassName: "Terrasoft.ProductUtilities",

			extend: "Terrasoft.BaseObject",

			/**
			 * ########## ######## ##### ### ###########
			 * @public
			 * @type {Terrasoft.Resources.CultureSettings}
			 */
			NumberGroupSizes: Terrasoft.Resources.CultureSettings.numberGroupSizes,

			/**
			 * ####### ############# ########## ######## #####
			 * @public
			 * @type {Boolean}
			 */
			UseThousandSeparator: true,

			/**
			 * ########### ######## #####
			 * @public
			 * @type {Terrasoft.Resources.CultureSettings}
			 */
			ThousandSeparator: Terrasoft.Resources.CultureSettings.thousandSeparator,

			/**
			 * ###### ############ ##### # ####### #####
			 * @protected
			 * @overridden
			 * @type {RegExp}
			 */
			DecimalSeparatorsRe: /[,.]/,

			/**
			 * ########### ##### # ########## ##### #####
			 * @overridden
			 * @type {Terrasoft.Resources.CultureSettings}
			 */
			DecimalSeparator: Terrasoft.Resources.CultureSettings.decimalSeparator,

			/**
			 * ######## ########## ##### ##### (########## #### ##### ###########)
			 * @overridden
			 * @type {Number}
			 */
			DecimalPrecision: Terrasoft.SysValue.CURRENT_MONEY_DISPLAY_PRECISION,

			DisplayNumberConfig: null,

			/**
			 * ######## ######### ######### #### # #######.
			 * @type {Object}
			 */
			PriceWithTaxes: null,

			MoneyModule: MoneyModule,

			mixins: {
				MoneyUtilities: "Terrasoft.MoneyUtilsMixin"
			},

			/**
			 * @inheritdoc Terrasoft.BaseObject#constructor.
			 * @overridden
			 */
			constructor: function() {
				this.callParent(arguments);
				this.initDisplayNumberConfig();
			},

			/**
			 * Columns of binding object, consists (or not) precisions.
			 * {@type Object}
			 */
			columns: null,

			/**
			 * Initializes number configs.
			 * @protected
			 * @overridden
			 */
			initDisplayNumberConfig: function() {
				const thousandSeparator = this.ThousandSeparator;
				this.ThousandSeparatorRe = new RegExp(thousandSeparator, "g");

				this.DisplayNumberConfig = {
					decimalPrecision: this.DecimalPrecision,
					decimalSeparator: this.DecimalSeparator,
					useThousandSeparator: this.UseThousandSeparator,
					thousandSeparator:  this.ThousandSeparator,
					numberGroupSizes: this.NumberGroupSizes
				};
			},
			/**
			 * ########### ###### value # ##### # ###### ####### #########, #### type ##### Terrasoft.DataValueType.INTEGER
			 * ##### ###### ##### #####,
			 * #### type ##### Terrasoft.DataValueType.FLOAT ##### ###### ##### # ######### ######.
			 * #### ######## value ### ##### ####### ###### ### ### ##############.
			 * @protected
			 * @param  {String/Number} value ###### ####### ##### ############# # #####
			 * Terrasoft.DataValueType.INTEGER # Terrasoft.DataValueType.FLOAT
			 * @return {Number} ##### ##### ############## ####### ######
			 */
			parseNumber: function(value) {
				return Terrasoft.parseNumber(value, this.DisplayNumberConfig);
			},

			/**
			 * Formats number string according to conf object settings.
			 * @protected
			 * @param  {Number} value Nubmer to format.
			 * @return {String} Formatted string.
			 */
			getFormattedNumberValue: function(value) {
				const config = Ext.apply({}, this.DisplayNumberConfig);
				return Terrasoft.getFormattedNumberValue(value, config);
			},

			/**
			 * Sets up Quantity and BaseQuantity.
			 * @param {BaseViewModel} productModel Product model.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback Context.
			 */
			setNumberOfBaseUnitsAndBaseQuantity: function(productModel, callback, scope) {
				const unit = productModel.get("Unit");
				if (unit) {
					const quantity = productModel.get("Quantity") || productModel.get("Count") || 0;
					const select = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "ProductUnit"
					});
					select.addColumn("NumberOfBaseUnits");
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Unit.Id", unit.value));
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"Product.Id", productModel.get("RealRecordId")));
					select.execute(function(response) {
						response.collection.each(function(item) {
							unit.NumberOfBaseUnits = item.get("NumberOfBaseUnits");
							productModel.set("BaseQuantity", quantity * item.get("NumberOfBaseUnits"));
						}, this);
						if (response.collection.getCount() < 1) {
							productModel.set("BaseQuantity", quantity);
						}
						if (Ext.isFunction(callback)) {
							callback.call(scope);
						}
					}, this);
				}
			},

			/**
			 * Calculates amount.
			 * @protected
			 */
			calcAmount: function(price, quantity) {
				if (!Ext.isEmpty(price) && !Ext.isEmpty(quantity)) {
					const calculator = this.getMoneyCalculator();
					return calculator.multiply(price, quantity);
				}
				return 0;
			},

			/**
			 * Calculates discount percent.
			 * @param {Number} amount - amount.
			 * @param {Number} discountAmount - discount amount.
			 * @return {Number} Discount percent.
			 * @protected
			 */
			calcDiscountPercent: function(amount, discountAmount) {
				return DiscountUtils.calcDiscountPercent(amount, discountAmount);
			},

			/**
			 * Calculates discount amount.
			 * @param {Number} amount - amount.
			 * @param {Number} discountPercent - discount percent.
			 * @return {Number} Discount amount.
			 * @protected
			 */
			calcDiscountAmount: function(amount, discountPercent) {
				return DiscountUtils.calcDiscountAmount(amount, discountPercent);
			},

			/**
			 * Calculates total amount with discount.
			 * @protected
			 * @returns {number}
			 */
			calcTotalAmountWithDiscount: function(amount, discountAmount) {
				if (Ext.isEmpty(amount)) {
					amount = 0;
				}
				if (Ext.isEmpty(discountAmount)) {
					discountAmount = 0;
				}
				if (discountAmount > amount) {
					discountAmount = amount;
				}
				const calculator = this.getMoneyCalculator();
				return calculator.subtract(amount, discountAmount);
			},

			/**
			 * Calculates tax amount.
			 * @param {Number} amount - amount.
			 * @param {Number} taxPercent - tax percent.
			 * @protected
			 * @returns {Number}.
			 */
			calcTaxAmount: function(amount, taxPercent) {
				if (Ext.isEmpty(taxPercent) || Ext.isEmpty(amount)) {
					return 0;
				}
				if (taxPercent > 100) {
					taxPercent = 100;
				}
				if (this.PriceWithTaxes) {
					return this.getIncludedPercentagePart(amount, taxPercent);
				} else {
					return this.getPercentagePart(amount, taxPercent);
				}
			},

			/**
			 * Calculates total amount.
			 * @protected
			 */
			calcTotalAmount: function(totalAmount, taxAmount) {
				if (!this.PriceWithTaxes) {
					const calculator = this.getMoneyCalculator();
					totalAmount = calculator.add(totalAmount, taxAmount);
				}
				return totalAmount;
			},
			
			/**
			 * @deprecated Use calculateProductValues method instead.
			 */
			calculateProduct: function(productModel, calculatePrimaryAmounts) {
				this.calculateProductValues(productModel, {
					calculatePrimaryAmounts: calculatePrimaryAmounts
				});
			},

			/**
			 * Calculates product price.
			 * @param {Terrasoft.BaseViewModel} productModel Product view model.
			 * @param {Object} config Calculate primary amounts flag.
			 * @param {Boolean} [config.calculatePrimaryAmounts] Calculate primary amounts flag.
			 */
			calculateProductValues: function(productModel, config) {
				config = config || {};
				const baseQuantity =  productModel.get("BaseQuantity") || 0;
				const price = productModel.get("Price") || 0;
				const amount = this.calcAmount(price, baseQuantity);
				const discountPercent = productModel.get("DiscountPercent") || 0;
				const discountAmount = productModel.get("DiscountAmount") || this.calcDiscountAmount(amount, discountPercent);
				const totalAmountWithDiscount = this.calcTotalAmountWithDiscount(amount, discountAmount);
				const discountTax = productModel.get("DiscountTax") || 0;
				const taxAmount = this.calcTaxAmount(totalAmountWithDiscount, discountTax);
				const totalAmount = this.calcTotalAmount(totalAmountWithDiscount, taxAmount);
				productModel.set("Amount", amount);
				productModel.set("DiscountPercent", discountPercent);
				productModel.set("DiscountAmount", discountAmount);
				productModel.set("DiscountTax", discountTax);
				productModel.set("TaxAmount", taxAmount);
				productModel.set("TotalAmount", totalAmount);
				if (config.calculatePrimaryAmounts === true) {
					this.calculatePrimaryAmounts(productModel);
				}
			},

			/**
			 * Returns amount column names.
			 * @protected
			 * @virtual
			 * @return {Array} Amount column names collection.
			 */
			getAmountColumnNames: function() {
				return ["Amount", "TotalAmount", "DiscountAmount",
					"Price", "TaxAmount"];
			},

			/**
			 * Calculates primary amounts of product.
			 * @protected
			 * @param {Terrasoft.BaseViewModel} product Product model.
			 */
			calculatePrimaryAmounts: function(product) {
				const columnNames = this.getAmountColumnNames();
				const division = product.get("CurrencyDivision");
				Terrasoft.each(columnNames, function(columnName) {
					this.MoneyModule.RecalcBaseValue.call(product, "CurrencyRate", columnName, "Primary" + columnName,
						division);
				}, this);
			}
		});
		const productUtilities = Ext.create(Terrasoft.configuration.ProductUtilities);
		return productUtilities;
	});
