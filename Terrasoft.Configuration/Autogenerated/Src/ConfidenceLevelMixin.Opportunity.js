define("ConfidenceLevelMixin", ["ext-base"], function(Ext) {
	Ext.define("Terrasoft.configuration.mixins.ConfidenceLevelMixin", {
		alternateClassName: "Terrasoft.ConfidenceLevelMixin",
		
		defaultOpportunityMoodId: "ed4a5b8b-8b1e-45e8-838f-40c468726413",

		/**
		 * Load OpportunityMood lookup records.
		 * @param {Function} callback Callback function.
		 * @param {Object} scope Callback scope.
		 */
		loadOpportunityMoodValues: function(callback, scope) {
			const esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "OpportunityMood"
			});
			esq.addColumn("Id");
			esq.addColumn("Name");
			esq.addColumn("Image");
			const percentColumn = esq.addColumn("Percent");
			percentColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
			percentColumn.orderPosition = 0;
			esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
				"RecordInactive", 0));
			esq.getEntityCollection(function(result) {
				if (result.success && result.collection) {
					const defaultIcon = result.collection.collection.getByKey(this.defaultOpportunityMoodId);
					result.collection.collection.removeAtKey(this.defaultOpportunityMoodId);
					const moodValues = result.collection.getItems() || [];
					const confidenceIcons = this.convertOpportunityMoodCollection(moodValues, defaultIcon);
					this.set("ConfidenceIcons", confidenceIcons);
				}
				this.Ext.callback(callback, scope);
			}, this);
		},

		/**
		 * Converts opportunity mood collection to confidence icons model collection.
		 * @protected
		 * @param {Array} opportunityMoodCollection Opportunity mood collection.
		 * @param {Object} defaultIcon Default image item.
		 * @return {Array} Confidence icons model collection.
		 */
		convertOpportunityMoodCollection: function(opportunityMoodCollection, defaultIcon) {
			const config = this.getConfidenceLevelConfig();
			const maxValue = config.sliderConfig.maxValue;
			let isNotAssignedArea = true;
			const result = this.Terrasoft.map(opportunityMoodCollection, function(item) {
				const imageId = item.get("Image").value;
				var imageUrl = this._formImageUrl(imageId);
				if (maxValue <= item.get("Percent")) {
					isNotAssignedArea = false;
				}
				return {
					"id": item.get("Id"),
					"name": item.get("Name"),
					"percentage": item.get("Percent"),
					"icon": imageUrl
				}
			}, this);
			if (isNotAssignedArea && defaultIcon.get("Image")) {
				const defaultImageId = defaultIcon.get("Image").value;
				const imageUrl = this._formImageUrl(defaultImageId);
				result.push({
					"id": Terrasoft.generateGUID(),
					"name": "",
					"percentage": maxValue,
					"icon": imageUrl
				});
			}
			return result;
		},

		//region Methods: Private

		/**
		 * @private
		 */
		_formImageUrl: function(imageId) {
			const imageConfig = {
				source: Terrasoft.ImageSources.SYS_IMAGE,
				params: {
					primaryColumnValue: imageId
				}
			};
			return Terrasoft.ImageUrlBuilder.getUrl(imageConfig);
		},

		/**
		 * @private
		 */
		_loadConfidenceLevelWidgetModule: function() {
			if (!this.getIsConfidenceLevelWidgetVisible() || this.$IsConfidenceLevelWidgetLoaded) {
				return;
			}
			this.Terrasoft.require(["ConfidenceLevelWidgetModule"], function() {
				this.sandbox.loadModule("ConfidenceLevelWidgetModule", {
					renderTo: "ConfidenceLevelWidgetContainer"
				});
				this.$IsConfidenceLevelWidgetLoaded = true;
			}, this);
		},

		/**
		 * @private
		 */
		_getConfidenceLevelWidgetSandboxId: function() {
			return this.sandbox.id + "_ConfidenceLevelWidgetModule";
		},

		//endregion

		/**
		 * Returns ConfidenceLevel config.
		 * @return {Object} ConfidenceLevel config.
		 */
		getConfidenceLevelConfig: function() {
			return {
				caption: this.get("Resources.Strings.ConfidenceLevelCaption"),
				sliderConfig: {
					value: this.get("MoodValue"),
					step: 5,
					minValue: 0,
					maxValue: 100,
				},
				metrics: this.getMetrics(),
				confidenceIcons: this.get("ConfidenceIcons")
			};
		},

		/**
		 * Handle slider value change.
		 @param {String} value Slider value.
		*/
		onSliderValueChanged: function(value) {
			this.set("MoodValue", value);
		},

		/**
		 * Handles confidence icon change value event.
		 * @param {String} iconId Icon identifier.
		 */
		onConfidenceIconChanged: function(iconId) {
			const mood = this.get("Mood");
			const moodId = mood && mood.value;
			if (moodId !== iconId) {
				const moodValue = this.$ConfidenceIcons.filter(x=> x.id === iconId)[0];
				if (moodValue) {
					this.set("Mood", {
						id: iconId,
						value: iconId,
						displayValue: moodValue.name,
						Percent: moodValue.percentage,
						primaryImageValue: moodValue.icon.split("/").reverse()[0]
					});
				} else {
					this.set("Mood", { value: iconId });
				}
				
			}
		},

		/**
		 * Returns metric values config.
		 * @return [{Object}] metrics array.
		 */
		getMetrics: function() {
			let metrics =  [
				{
					"caption": this.get("Resources.Strings.DaysInFunnelWidgetCaption"),
					"value": this.$DaysInFunnel
				}
			];
			if (this.columns.PredictiveProbability) {
				metrics.splice(0, 0,
					{
						"caption": this.columns.PredictiveProbability.caption,
						"value": this.Ext.String.format("{0}%", this.$PredictiveProbability || 0)
					});
			}
			return metrics;
		},         

		/**
		 * Refresh ConfidenceLevelWidget values.
		 */
		refreshConfidenceLevelWidget: function() {
			this.sandbox.publish("UpdateConfidenceLevelWidgetValues", null, [this._getConfidenceLevelWidgetSandboxId()]);
		},

		/**
		 * Confidence level widget columns change handler.
		 */
		onConfidenceWidgetColumnChanged: function() {
			if (this.get("ConfidenceLevelWidgetFeatureEnabled")) {
				this.refreshConfidenceLevelWidget();
			}
		}
	});
});
