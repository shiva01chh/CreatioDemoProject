define("OpportunityMoodPage", ["OpportunityMoodPageResources", "ImageCustomGeneratorV2"],
	function(resources) {
		return {
			entitySchemaName: "OpportunityMood",
			attributes: {
				/**
				 * Is ConfidenceLevel widget feature enabled.
				 */
				"ConfidenceLevelWidgetFeatureEnabled": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": Terrasoft.Features.getIsEnabled("ConfidenceLevelWidget")
				},
			},
			methods: {
				/**
				 * @private
				 * @return {Object} responseHandler
				 */
				_getImageApiResponseHandler: function() {
					return {
						onComplete: this.processImageApiSuccessResponse,
						onError: this.processImageApiErrorResponse,
						scope: this
					};
				},

				/**
				 * Processing image api upload success response.
				 * @return {String} Default image url.
				 */
				processImageApiSuccessResponse: function(imageId) {
					let imageData = {
						value: imageId,
						displayValue: "Image"
					};
					this.set(this.primaryImageColumnName, imageData);
				},

				/**
				 * Processing image api upload error response.
				 * @return {String} Default image url.
				 */
				processImageApiErrorResponse: function(imageId, error, uploadResult) {
					if (uploadResult.response) {
						let response = Terrasoft.decode(uploadResult.response);
						if (response.error) {
							Terrasoft.showMessage(response.error);
						}
					}
				},
				
				/**
				 * Get image url.
				 * @return {*}
				 */
				getSrcMethod: function() {
					let primaryImageColumnValue = this.get(this.primaryImageColumnName);
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this.getDefaultImageURL();
				},
				
				/**
				 * Returns default image url.
				 * @return {String} Default image url.
				 */
				getDefaultImageURL: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.DefaultImage);
				},

				/**
				 * Processing image changes.
				 * @param {Object} image Image object.
				 */
				onImageChange: function(image) {
					if (image) {
						let data = this._getImageApiResponseHandler();
						data.file = image;
						this.Terrasoft.ImageApi.upload(data);
					} else {
						this.set(this.primaryImageColumnName, null);
					}
				},	
				
				/**
				 * Validates Percent column.
				 * @protected
				 * @param {Function} callback Callback function
				 * @param {Terrasoft.BaseSchemaViewModel} scope Callback scope
				 */
				percentColumnValidator: function(callback, scope) {
					var percent = this.get("Percent");
					var id = this.get("Id");
					var result = {
						success: true
					};
					if (!this.changedValues || this.Ext.isEmpty(this.changedValues.Percent)) {
						this.Ext.callback(callback, scope || this, [result]);
					} else {
						var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: this.entitySchemaName
						});
						select.addColumn("Percent");
						select.filters.addItem(select.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.NOT_EQUAL, "Id", id));
						select.filters.addItem(select.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"Percent", percent));
						select.getEntityCollection(function(response, scope) {
							if (response.success) {
								if (response.collection.getCount() > 0) {
									result.message = this.get("Resources.Strings.PercentMustBeUnique");
									result.success = false;
								}
							} else {
								return;
							}
							Ext.callback(callback, scope || this, [result]);
						}, scope);
					}
				},
				
				/**
				 * @inheritDoc BasePageV2#asyncValidate
				 * @overridden
				 */
				asyncValidate: function(callback, scope) {
					this.callParent([function(response) {
						if (!this.validateResponse(response)) {
							return;
						}
						Terrasoft.chain(
							function(next) {
								if (!this.$ConfidenceLevelWidgetFeatureEnabled) {
									next();
									return;
								}
								this.percentColumnValidator(function(response) {
									if (this.validateResponse(response)) {
										next();
									}
								}, this);
							},
							function(next) {
								callback.call(scope, response);
								next();
							}, this);
					}, this]);
				},
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Name",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"colSpan": 12,
							"column": 2,
							"row": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "Position",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"colSpan": 12,
							"column": 14,
							"row": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "Percent",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"colSpan": 12,
							"column": 14,
							"row": 0
						},
						"visible": {"bindTo": "ConfidenceLevelWidgetFeatureEnabled"}
					}
				},
				{
					"operation": "merge",
					"name": "Description",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"layout": {
							"colSpan": 24,
							"column": 2,
							"row": 1
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "ImageContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["image-edit-container"],
						"layout": {"column": 0, "row": 0, "rowSpan": 2, "colSpan": 2},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ImageContainer",
					"propertyName": "items",
					"name": "Image",
					"values": {
						"getSrcMethod": "getSrcMethod",
						"onPhotoChange": "onImageChange",
						"beforeFileSelected": true,
						"readonly": false,
						"defaultImage": {"bindTo": "getDefaultImageURL"},
						"layout": {"column": 0, "row": 0, "rowSpan": 2, "colSpan": 2},
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
					}
				},
			]/**SCHEMA_DIFF*/
		};
	});
