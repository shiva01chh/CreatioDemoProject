Terrasoft.configuration.Structures["AccountBillingInfo_ModalPage"] = {innerHierarchyStack: ["AccountBillingInfo_ModalPage"], structureParent: "BaseMiniPageTemplate"};
define('AccountBillingInfo_ModalPageStructure', ['AccountBillingInfo_ModalPageResources'], function(resources) {return {schemaUId:'f5c32a7d-172a-4394-91ba-a24955491c25',schemaCaption: "Account billing info modal page", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtOrderContractMgmtApp", schemaName:'AccountBillingInfo_ModalPage',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("AccountBillingInfo_ModalPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "ContinueInOtherPageButton"
			},
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					]
				}
			},
			{
				"operation": "insert",
				"name": "Name",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.StringAttribute_hhllwah",
					"labelPosition": "above",
					"control": "$StringAttribute_hhllwah"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Manager",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_e1bazdh",
					"labelPosition": "above",
					"control": "$LookupAttribute_e1bazdh",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "addRecord_vhe9m1s",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_vhe9m1s_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Manager",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Country",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_mt0unw1",
					"labelPosition": "above",
					"control": "$LookupAttribute_mt0unw1",
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
				"name": "ChiefAccountant",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_ctp5go9",
					"labelPosition": "above",
					"control": "$LookupAttribute_ctp5go9",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "addRecord_zrfub3k",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_zrfub3k_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "ChiefAccountant",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LegalEntity",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": false,
					"label": "$Resources.Strings.StringAttribute_4ricyni",
					"labelPosition": "above",
					"control": "$StringAttribute_4ricyni"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "BankingDetails",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.StringAttribute_c5rxuu1",
					"labelPosition": "above",
					"control": "$StringAttribute_c5rxuu1",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "Description",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"multiline": true,
					"label": "$Resources.Strings.StringAttribute_esjhaqr",
					"labelPosition": "above",
					"control": "$StringAttribute_esjhaqr",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 6
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LookupAttribute_mt0unw1": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.Country"
						}
					},
					"LookupAttribute_e1bazdh": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.AccountManager"
						}
					},
					"StringAttribute_c5rxuu1": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.BillingInfo"
						}
					},
					"StringAttribute_hhllwah": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.Name"
						}
					},
					"LookupAttribute_ctp5go9": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.ChiefAccountant"
						}
					},
					"StringAttribute_4ricyni": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.LegalUnit"
						}
					},
					"StringAttribute_esjhaqr": {
						"modelConfig": {
							"path": "AccountBillingInfoDS.Description"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"AccountBillingInfoDS": {
							"type": "crt.EntityDataSource",
							"scope": "page",
							"config": {
								"entitySchemaName": "AccountBillingInfo"
							}
						}
					},
					"primaryDataSourceName": "AccountBillingInfoDS"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

