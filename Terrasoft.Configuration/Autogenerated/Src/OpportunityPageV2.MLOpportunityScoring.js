﻿define("OpportunityPageV2", ["MLConfigurationConsts", "MLPredictionPageMixin"],
	function(MLConfigurationConsts) {
		return {
			entitySchemaName: "Opportunity",
			mixins: ["Terrasoft.MLPredictionPageMixin"],
			attributes: {
				"TrainedScoreModelExists": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			details: /**SCHEMA_DETAILS*/ {
				"RecommendedProduct": {
					"schemaName": "OpportunityRecommendedProductDetail",
					"filterMethod": "recommendedProductDetailFilterMethod",
					"defaultValues": {
						Opportunity: { name: "Opportunity", masterColumn: "Id" },
						Contact: { masterColumn: "Contact" },
						Account: { masterColumn: "Account" }
					}
				}
			} /**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.queryWasAnyModelTrained("PredictiveProbability", MLConfigurationConsts.ProblemTypes.Scoring);
				},

				getProbabilityMetricValue: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("PredictiveProbability");
				},

				getProbabilityMetricCaption: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("Resources.Strings.PredictiveProbabilityCaption");
				},

				getProbabilityMetricHint: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("Resources.Strings.PredictiveProbabilityMetricHint");
				},

				recommendedProductDetailFilterMethod: function() {
					const filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					if (this.$Contact) {
						filterGroup.add("ContactFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Contact", this.get("Contact").value));
					} else if (this.$Account) {
						filterGroup.add("AccountFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Account", this.get("Account").value));
					}
					return filterGroup;
				},

				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					const recommendedProductDetailId = this.getDetailId("RecommendedProduct");
					this.sandbox.subscribe("DetailChanged", function() {
						this.sandbox.publish("UpdateDetail", {
							reloadAll: true
						}, [this.getDetailId("OpportunityProduct")]);
					}, this, [recommendedProductDetailId]);
				},
			},
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "insert",
					"name": "RecommendedProduct",
					"parentName": "ProductsTab",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"items": []
					}
				},
			] /**SCHEMA_DIFF*/
		};
	});
