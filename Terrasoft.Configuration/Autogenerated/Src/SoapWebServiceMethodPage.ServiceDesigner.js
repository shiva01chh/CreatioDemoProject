﻿define("SoapWebServiceMethodPage", ["BusinessRuleModule"
], function(BusinessRuleModule) {
	return {
		attributes: {
			SoapAction: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			ServiceType: {
				type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		methods: {
			init: function(callback, scope) {
				this.callParent([
					function () {
						this.$ServiceType = this.$ServiceSchema.type;
						Ext.callback(callback, scope);
					}, this]
				);
			},

			/**
			 * @inheritdoc Terrasoft.WebServiceMethodPage#getDefaultMethodRequestConfig.
			 * @overridden
			 */
			getDefaultMethodRequestConfig: function() {
				return {
					httpMethodType: Terrasoft.services.enums.HttpMethodType.POST,
					contentType: Terrasoft.services.enums.ServiceContentType.XML
				};
			},

			/**
			 * @inheritdoc Terrasoft.WebServiceMethodPage#getDefaultMethodResponseConfig.
			 * @overridden
			 */
			getDefaultMethodResponseConfig: function() {
				return {
					contentType: Terrasoft.services.enums.ServiceContentType.XML
				};
			},

			/**
			 * @inheritdoc Terrasoft.WebServiceMethodPage#getAttributeMap.
			 * @overridden
			 */
			getAttributeMap: function() {
				const attributeMap = this.callParent(arguments);
				return Ext.apply(attributeMap, {
					soapAction: "SoapAction"
				});
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "UseAuthInfo",
				"values": {
					"contentType": Terrasoft.ContentType.LONG_TEXT,
					"layout": {"column": 15, "row": 1, "colSpan": 9},
					"bindTo": "UseAuthInfo",
					"caption": {"bindTo": "Resources.Strings.UseAuthInfoCaption"},
					"enabled": "$CanChangeUseAuthInfo"
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "RequestTimeout",
				"values": {
					"layout": {"column": 15, "row": 0, "colSpan": 9},
					"bindTo": "RequestTimeout",
					"caption": {"bindTo": "Resources.Strings.RequestTimeoutCaption"},
					"enabled": {
						"bindTo": "CanEditSchema"
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "Uri",
				"values": {
					"layout": {"column": 0, "row": 2, "colSpan": 14},
					"bindTo": "Uri",
					"caption": {"bindTo": "Resources.Strings.UriCaption"},
					"enabled": {
						"bindTo": "CanEditSchema"
					},
					"tip": {"content": "$Resources.Strings.UriTip"}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
			{
				"operation": "insert",
				"name": "SoapAction",
				"values": {
					"layout": {"column": 0, "row": 3, "colSpan": 14},
					"bindTo": "SoapAction",
					"caption": "SOAP Action",
					"enabled": {
						"bindTo": "CanEditSchema"
					}
				},
				"parentName": "Header",
				"propertyName": "items"
			},
		]/**SCHEMA_DIFF*/,
		rules: {},
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/
	};
});
