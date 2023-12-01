Terrasoft.configuration.Structures["ServiceItemPage"] = {innerHierarchyStack: ["ServiceItemPageSLM", "ServiceItemPageSLMITILService", "ServiceItemPageProblem", "ServiceItemPageServiceModel", "ServiceItemPageChange", "ServiceItemPage"], structureParent: "BaseModulePageV2"};
define('ServiceItemPageSLMStructure', ['ServiceItemPageSLMResources'], function(resources) {return {schemaUId:'f14c93b3-06c4-48ae-bb2a-2092645614ad',schemaCaption: "ServiceItemPage", parentSchemaName: "BaseModulePageV2", packageName: "Release", schemaName:'ServiceItemPageSLM',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageSLMITILServiceStructure', ['ServiceItemPageSLMITILServiceResources'], function(resources) {return {schemaUId:'2c80d10e-05cf-45e4-b32b-b4cbcd61f3d7',schemaCaption: "ServiceItemPage", parentSchemaName: "ServiceItemPageSLM", packageName: "Release", schemaName:'ServiceItemPageSLMITILService',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemPageSLM",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageProblemStructure', ['ServiceItemPageProblemResources'], function(resources) {return {schemaUId:'f179549e-9254-4f27-b022-70ce371f2651',schemaCaption: "ServiceItemPage", parentSchemaName: "ServiceItemPageSLMITILService", packageName: "Release", schemaName:'ServiceItemPageProblem',parentSchemaUId:'f14c93b3-06c4-48ae-bb2a-2092645614ad',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemPageSLMITILService",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageServiceModelStructure', ['ServiceItemPageServiceModelResources'], function(resources) {return {schemaUId:'8259b730-4818-4ed7-a748-43617539ef04',schemaCaption: "ServiceItemPage", parentSchemaName: "ServiceItemPageProblem", packageName: "Release", schemaName:'ServiceItemPageServiceModel',parentSchemaUId:'f179549e-9254-4f27-b022-70ce371f2651',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemPageProblem",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageChangeStructure', ['ServiceItemPageChangeResources'], function(resources) {return {schemaUId:'621f26df-c95d-4673-a48d-2ae9dc6e6aec',schemaCaption: "ServiceItemPage", parentSchemaName: "ServiceItemPageServiceModel", packageName: "Release", schemaName:'ServiceItemPageChange',parentSchemaUId:'8259b730-4818-4ed7-a748-43617539ef04',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemPageServiceModel",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageStructure', ['ServiceItemPageResources'], function(resources) {return {schemaUId:'138630b3-028f-4990-83a0-52adbb206f91',schemaCaption: "ServiceItemPage", parentSchemaName: "ServiceItemPageChange", packageName: "Release", schemaName:'ServiceItemPage',parentSchemaUId:'621f26df-c95d-4673-a48d-2ae9dc6e6aec',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ServiceItemPageChange",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ServiceItemPageSLMResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemPageSLM", ["CaseServiceUtility"],
	function() {
		return {
			entitySchemaName: "ServiceItem",
			details: /**SCHEMA_DETAILS*/{
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "ServiceItemFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ServiceItem"
					}
				},
				"Cases": {
					"schemaName": "CaseInServiceItemDetail",
					"entitySchemaName": "Case",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ServiceItem"
					}
				}
			}/**SCHEMA_DETAILS*/,
			mixins: {
				/**
				 * @class CaseServiceUtility implements work with service item on page.
				 */
				CaseServiceUtility: "Terrasoft.CaseServiceUtility"
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Status",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Status",
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "HistoryTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.HistoryTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ReactionTimeValue",
					"values": {
						"layout": {
							"column": 22,
							"row": 1,
							"colSpan": 2,
							"rowSpan": 1
						},
						"bindTo": "ReactionTimeValue",
						"labelConfig": {
							"visible": false
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "ReactionTimeUnit",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 9,
							"rowSpan": 1
						},
						"bindTo": "ReactionTimeUnit",
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "SolutionTimeValue",
					"values": {
						"layout": {
							"column": 22,
							"row": 2,
							"colSpan": 2,
							"rowSpan": 1
						},
						"bindTo": "SolutionTimeValue",
						"labelConfig": {
							"visible": false
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "SolutionTimeUnit",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 9,
							"rowSpan": 1
						},
						"bindTo": "SolutionTimeUnit",
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 5
				},
				{
					"operation": "insert",
					"name": "CaseCategory",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "CaseCategory",
						"contentType": this.Terrasoft.ContentType.ENUM
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 6
				},
				{
					"operation": "insert",
					"name": "NotesFilesTab",
					"values": {
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.NotesFilesTabCaption"
						}
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "Files",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "NotesFilesTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Cases",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 0
				},

				{
					"operation": "insert",
					"name": "NotesControlGroup",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.NotesGroupCaption"
						}
					},
					"parentName": "NotesFilesTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Notes",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					},
					"parentName": "NotesControlGroup",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Calendar",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Calendar",
						"caption": {
							"bindTo": "Resources.Strings.CalendarCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 7
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"ReactionTimeUnit": {
					"lookupListConfig": {
						orders: [
							{columnPath: "Position"}
						]
					}
				},
				"SolutionTimeUnit": {
					"lookupListConfig": {
						orders: [
							{columnPath: "Position"}
						]
					}
				},
				"Calendar": {
					lookupListConfig: {
						hideActions: true
					}
				}

			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1061);
					this.callParent(arguments);
				},
				/**
				 * @inheritdoc Terrasoft.BasePageV2#save
				 * @overridden
				 */
				save: function() {
					this.setAbsoluteValue("ReactionTimeValue");
					this.setAbsoluteValue("SolutionTimeValue");
					this.callParent(arguments);
				}
			},
			rules: {},
			userCode: {}
		};
	});

define('ServiceItemPageSLMITILServiceResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemPageSLMITILService", [],
		function() {
			return {
				entitySchemaName: "ServiceItem",
				details: /**SCHEMA_DETAILS*/{
					"ServicePacts": {
						"schemaName": "ServicePactInServiceDetail",
						"entitySchemaName": "ServiceInServicePact",
						"filter": {
							"masterColumn": "Id",
							"detailColumn": "ServiceItem"
						}
					},
					"ServiceEngineers": {
						"schemaName": "ServiceEngineerDetail",
						"entitySchemaName": "ServiceEngineer",
						"filter": {
							"masterColumn": "Id",
							"detailColumn": "ServiceItem"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "UsersTab",
						"values": {
							"items": [],
							"caption": {
								"bindTo": "Resources.Strings.UsersTabCaption"
							}
						},
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 1
					},
					{
						"operation": "insert",
						"name": "ServicePacts",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.DETAIL
						},
						"parentName": "UsersTab",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "ServiceConditionsTab",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.ServiceConditionsTabCaption"
							},
							"items": []
						},
						"parentName": "Tabs",
						"propertyName": "tabs",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "ServiceEngineers",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.DETAIL
						},
						"parentName": "ServiceConditionsTab",
						"propertyName": "items",
						"index": 0
					},
					{
						"operation": "insert",
						"name": "Owner",
						"values": {
							"layout": {
								"column": 12,
								"row": 0,
								"colSpan": 12,
								"rowSpan": 1
							},
							"bindTo": "Owner",
							"caption": {
								"bindTo": "Resources.Strings.OwnerCaption"
							},
							"contentType": this.Terrasoft.ContentType.LOOKUP,
							"labelConfig": {
								"visible": true
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 1
					},
					{
						"operation": "insert",
						"name": "Category",
						"values": {
							"layout": {
								"column": 12,
								"row": 1,
								"colSpan": 12,
								"rowSpan": 1
							},
							"bindTo": "Category",
							"caption": {
								"bindTo": "Resources.Strings.CategoryCaption"
							},
							"contentType": this.Terrasoft.ContentType.ENUM,
							"labelConfig": {
								"visible": true
							}
						},
						"parentName": "Header",
						"propertyName": "items",
						"index": 2
					},
					{
						"operation": "merge",
						"name": "Name",
						"values": {
							"layout": {
								"column": 0,
								"row": 0,
								"colSpan": 12,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "CaseCategory",
						"values": {
							"layout": {
								"column": 12,
								"row": 2,
								"colSpan": 12,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "ReactionTimeValue",
						"values": {
							"layout": {
								"column": 10,
								"row": 2,
								"colSpan": 2,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "ReactionTimeUnit",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 9,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "SolutionTimeValue",
						"values": {
							"layout": {
								"column": 10,
								"row": 3,
								"colSpan": 2,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "merge",
						"name": "SolutionTimeUnit",
						"values": {
							"layout": {
								"column": 0,
								"row": 3,
								"colSpan": 9,
								"rowSpan": 1
							}
						}
					},
					{
						"operation": "remove",
						"name": "Calendar"
					}
				]/**SCHEMA_DIFF*/,
				attributes: {},
				methods: {},
				rules: {},
				userCode: {}
			};
		});

define('ServiceItemPageProblemResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemPageProblem", [],
	function() {
		return {
			entitySchemaName: "ServiceItem",
			details: /**SCHEMA_DETAILS*/{
				"Problems": {
					"schemaName": "ProblemInServiceItemDetail",
					"entitySchemaName": "Problem",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "ServiceItem"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Problems",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
					},
					"parentName": "HistoryTab",
					"propertyName": "items",
					"index": 2
				}
			]/**SCHEMA_DIFF*/,
			mixins: {},
			attributes: {},
			methods: {},
			rules: {},
			userCode: {}
		};
	});

define('ServiceItemPageServiceModelResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemPageServiceModel", [],
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

define('ServiceItemPageChangeResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ServiceItemPageChange", [],
    function () {
        return {
            entitySchemaName: "ServiceItem",
            details: /**SCHEMA_DETAILS*/{
                "Change": {
                    "schemaName": "ChangeInServiceItemDetail",
                    "entitySchemaName": "ChangeServiceItem",
                    "filter": {
                        "masterColumn": "Id",
                        "detailColumn": "ServiceItem"
                    }
                }
            }/**SCHEMA_DETAILS*/,
            diff: /**SCHEMA_DIFF*/[
                {
                    "operation": "insert",
                    "name": "Change",
                    "values": {
                        "itemType": this.Terrasoft.ViewItemType.DETAIL,
                        "visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
                    },
                    "parentName": "HistoryTab",
                    "propertyName": "items",
                    "index": 3
                }
            ]/**SCHEMA_DIFF*/
        };
    });

define("ServiceItemPage", [],
    function () {
        return {
            entitySchemaName: "ServiceItem",
            details: /**SCHEMA_DETAILS*/{
                "Release": {
                    "schemaName": "ReleaseInServiceItemDetail",
                    "entitySchemaName": "ReleaseServiceItem",
                    "filter": {
                        "masterColumn": "Id",
                        "detailColumn": "ServiceItem"
                    }
                }
            }/**SCHEMA_DETAILS*/,
            diff: /**SCHEMA_DIFF*/[
                {
                    "operation": "insert",
                    "name": "Release",
                    "values": {
                        "itemType": this.Terrasoft.ViewItemType.DETAIL,
                        "visible": Terrasoft.Features.getIsEnabled("ShowServiceITILFunc")
                    },
                    "parentName": "HistoryTab",
                    "propertyName": "items",
                    "index": 2
                }
            ]/**SCHEMA_DIFF*/
        };
    });


