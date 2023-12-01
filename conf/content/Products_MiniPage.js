Terrasoft.configuration.Structures["Products_MiniPage"] = {innerHierarchyStack: ["Products_MiniPageCrtProductBase", "Products_MiniPage"], structureParent: "BaseMiniPageTemplate"};
define('Products_MiniPageCrtProductBaseStructure', ['Products_MiniPageCrtProductBaseResources'], function(resources) {return {schemaUId:'5ee82f54-9b86-4a5b-8820-afe8c266a109',schemaCaption: "Products mini page", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtProductCatalogue", schemaName:'Products_MiniPageCrtProductBase',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Products_MiniPageStructure', ['Products_MiniPageResources'], function(resources) {return {schemaUId:'c8ef0fbb-1a56-49b0-a0d1-ad981a11ef3c',schemaCaption: "Products mini page", parentSchemaName: "Products_MiniPageCrtProductBase", packageName: "CrtProductCatalogue", schemaName:'Products_MiniPage',parentSchemaUId:'5ee82f54-9b86-4a5b-8820-afe8c266a109',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"Products_MiniPageCrtProductBase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Products_MiniPageCrtProductBaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("Products_MiniPageCrtProductBase", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "OpenDefaultPageButton",
				"values": {
					"color": "default"
				}
			},
			{
				"operation": "insert",
				"name": "GeneralInfoFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "large",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Image",
				"values": {
					"layoutConfig": {},
					"type": "crt.ImageInput",
					"labelPosition": "auto",
					"value": "$ImageLinkAttribute_pp7jt09",
					"size": "large",
					"borderRadius": "medium",
					"positioning": "cover",
					"visible": true,
					"tooltip": ""
				},
				"parentName": "GeneralInfoFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Type",
				"values": {
					"layoutConfig": {},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_3yf8b4g",
					"labelPosition": "above",
					"control": "$LookupAttribute_3yf8b4g",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "GeneralInfoFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Name",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.StringAttribute_a233ki5",
					"labelPosition": "above",
					"control": "$StringAttribute_a233ki5",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "UnitOfMeasure",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_dkg7a0e",
					"labelPosition": "above",
					"control": "$LookupAttribute_dkg7a0e",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Price",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.NumberInput",
					"label": "$Resources.Strings.NumberAttribute_9mb10oy",
					"labelPosition": "above",
					"control": "$NumberAttribute_9mb10oy",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Currency",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_832nhyh",
					"labelPosition": "above",
					"control": "$LookupAttribute_832nhyh",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 4
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"StringAttribute_a233ki5": {
					"modelConfig": {
						"path": "ProductDS.Name"
					}
				},
				"ImageLinkAttribute_pp7jt09": {
					"modelConfig": {
						"path": "ProductDS.Picture"
					}
				},
				"LookupAttribute_3yf8b4g": {
					"modelConfig": {
						"path": "ProductDS.Type"
					}
				},
				"LookupAttribute_dkg7a0e": {
					"modelConfig": {
						"path": "ProductDS.Unit"
					}
				},
				"NumberAttribute_9mb10oy": {
					"modelConfig": {
						"path": "ProductDS.Price"
					}
				},
				"LookupAttribute_832nhyh": {
					"modelConfig": {
						"path": "ProductDS.Currency"
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"ProductDS": {
					"type": "crt.EntityDataSource",
					"scope": "page",
					"config": {
						"entitySchemaName": "Product"
					}
				}
			},
			"primaryDataSourceName": "ProductDS"
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
define("Products_MiniPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "ComboBox_ynkagif",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 6,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_wsjsloo",
					"labelPosition": "above",
					"control": "$LookupAttribute_wsjsloo",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 5
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LookupAttribute_wsjsloo": {
						"modelConfig": {
							"path": "ProductDS.Category"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

