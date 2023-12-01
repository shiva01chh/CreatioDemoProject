Terrasoft.configuration.Structures["ServiceInServicePactDetailPage"] = {innerHierarchyStack: ["ServiceInServicePactDetailPage"], structureParent: "BasePageV2"};
define('ServiceInServicePactDetailPageStructure', ['ServiceInServicePactDetailPageResources'], function(resources) {return {schemaUId:'f263118b-ff17-4fe9-9cfb-bb5aba92007a',schemaCaption: "Detail edit page schema - Service in service contract", parentSchemaName: "BasePageV2", packageName: "CrtSLMITILService7x", schemaName:'ServiceInServicePactDetailPage',parentSchemaUId:'d3cc497c-f286-4f13-99c1-751c468733c0',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceInServicePactDetailPage", ["CaseServiceUtility"],
	function() {
		return {
			entitySchemaName: "ServiceInServicePact",
			attributes: {
				"ReactionTimeUnit": {
					"lookupListConfig": {
						orders: [{columnPath: "Position"}]
					}
				},
				"SolutionTimeUnit": {
					"lookupListConfig": {
						orders: [{columnPath: "Position"}]
					}
				},
				"Calendar": {
					lookupListConfig: {
						hideActions: true
					}
				}
			},
			columns: {},
			details: {
				"TimeToPrioritizeDetail": {
					"schemaName": "TimeToPrioritizeDetailV2",
					"entitySchemaName": "TimeToPrioritize",
					"filter": {
						masterColumn: "Id",
						detailColumn: "ServiceInServicePact"
					}
				}
			},
			messages: {},
			mixins: {
				/**
				 * @class CaseServiceUtility implements work with service item on page.
				 */
				CaseServiceUtility: "Terrasoft.CaseServiceUtility"
			},
			methods: {
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
			diff: [
				{
					"operation": "merge",
					"propertyName": "items",
					"name": "Tabs",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "merge",
					"propertyName": "items",
					"name": "actions",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "merge",
					"name": "ViewOptionsButton",
					"values": {
						"visible": false
					}
				},
				{
					"operation": "insert",
					"name": "TimeToPrioritizeTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": "Time to prioritize tab",
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "TimeToPrioritizeTab",
					"propertyName": "items",
					"name": "TimeToPrioritizeDetail",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "insert",
					"name": "ServiceItem",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ServiceItem",
						"caption": {
							"bindTo": "Resources.Strings.ServiceItemCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						},
						"enabled": false
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "ServicePact",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ServicePact",
						"caption": {
							"bindTo": "Resources.Strings.ServicePactCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						},
						"enabled": false
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ReactionTimeValue",
					"values": {
						"layout": {
							"column": 10,
							"row": 2,
							"colSpan": 2,
							"rowSpan": 1
						},
						"bindTo": "ReactionTimeValue",
						"caption": {
							"bindTo": "Resources.Strings.ReactionTimeValueCaption"
						},
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
							"column": 0,
							"row": 2,
							"colSpan": 9,
							"rowSpan": 1
						},
						"bindTo": "ReactionTimeUnit",
						"caption": {
							"bindTo": "Resources.Strings.ReactionTimeValueCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "SolutionTimeValue",
					"values": {
						"layout": {
							"column": 10,
							"row": 3,
							"colSpan": 2,
							"rowSpan": 1
						},
						"bindTo": "SolutionTimeValue",
						"caption": {
							"bindTo": "Resources.Strings.SolutionTimeValueCaption"
						},
						"labelConfig": {
							"visible": false
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 5
				},
				{
					"operation": "insert",
					"name": "SolutionTimeUnit",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 9,
							"rowSpan": 1
						},
						"bindTo": "SolutionTimeUnit",
						"caption": {
							"bindTo": "Resources.Strings.SolutionTimeValueCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 6
				},
				{
					"operation": "insert",
					"name": "Status",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Status",
						"caption": {
							"bindTo": "Resources.Strings.StatusCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 7
				},
				{
					"operation": "insert",
					"name": "Calendar",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Calendar",
						"caption": {
							"bindTo": "Resources.Strings.CalendarCaption"
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 8
				}
			]
		};
	});


