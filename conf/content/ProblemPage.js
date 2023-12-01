Terrasoft.configuration.Structures["ProblemPage"] = {innerHierarchyStack: ["ProblemPageProblem", "ProblemPageServiceModel", "ProblemPage"], structureParent: "BaseModulePageV2"};
define('ProblemPageProblemStructure', ['ProblemPageProblemResources'], function(resources) {return {schemaUId:'c64dea89-3a24-4c17-9120-f1495f8f560e',schemaCaption: "ProblemPage", parentSchemaName: "BaseModulePageV2", packageName: "Change", schemaName:'ProblemPageProblem',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ProblemPageServiceModelStructure', ['ProblemPageServiceModelResources'], function(resources) {return {schemaUId:'507cf2d7-c022-410e-b639-7482a06dac23',schemaCaption: "ProblemPage", parentSchemaName: "ProblemPageProblem", packageName: "Change", schemaName:'ProblemPageServiceModel',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ProblemPageProblem",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ProblemPageStructure', ['ProblemPageResources'], function(resources) {return {schemaUId:'69054371-5be2-45aa-89ee-340d1ff718a0',schemaCaption: "ProblemPage", parentSchemaName: "ProblemPageServiceModel", packageName: "Change", schemaName:'ProblemPage',parentSchemaUId:'c64dea89-3a24-4c17-9120-f1495f8f560e',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"ProblemPageServiceModel",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('ProblemPageProblemResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ProblemPageProblem", ["BaseFiltersGenerateModule", "ServiceDeskConstants", "ConfigurationConstants"],
	function(BaseFiltersGenerateModule, ServiceDeskConstants, ConfigurationConstants) {
		return {
			entitySchemaName: "Problem",
			details: /**SCHEMA_DETAILS*/{
				"Files": {
					"schemaName": "FileDetailV2",
					"entitySchemaName": "ProblemFile",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Problem"
					}
				},
				"Case": {
					"schemaName": "CaseInProblemDetail",
					"entitySchemaName": "ProblemInCase",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Problem"
					}
				},
				"Activities": {
					"schemaName": "ActivityDetailV2",
					"entitySchemaName": "Activity",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Problem"
					}
				},
				"EmailDetailV2": {
					"schemaName": "EmailDetailV2",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Problem"
					},
					"filterMethod": "getEmailDetailFilter"
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 16,
							"rowSpan": 1
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Number",
					"values": {
						"layout": {
							"column": 16,
							"row": 0,
							"colSpan": 8,
							"rowSpan": 1
						},
						"bindTo": "Number",
						"caption": {
							"bindTo": "Resources.Strings.NumberCaption"
						},
						"enabled": false
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Symptoms",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Symptoms",
						"caption": {
							"bindTo": "Resources.Strings.SymptomsCaption"
						},
						"contentType": this.Terrasoft.ContentType.LONG_TEXT,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "Owner",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
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
					"index": 3
				},
				{
					"operation": "insert",
					"name": "Status",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
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
					"index": 4
				},
				{
					"operation": "insert",
					"name": "Group",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Group",
						"caption": {
							"bindTo": "Resources.Strings.GroupEditCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "Header",
					"propertyName": "items",
					"index": 5
				},
				{
					"operation": "insert",
					"name": "Priority",
					"values": {
						"layout": {
							"column": 12,
							"row": 3,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Priority",
						"caption": {
							"bindTo": "Resources.Strings.PriorityCaption"
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
					"name": "GeneralInfoTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.GeneralInfoTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "CurrentStatusGroupLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Type",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Type",
						"caption": {
							"bindTo": "Resources.Strings.TypeCaption"
						},
						"contentType": this.Terrasoft.ContentType.ENUM,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "insert",
					"name": "Author",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Author",
						"caption": {
							"bindTo": "Resources.Strings.AuthorCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "ServiceItem",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ServiceItem",
						"caption": {
							"bindTo": "Resources.Strings.ServiceItemCaption"
						}
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "RegisteredOn",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "RegisteredOn",
						"caption": {
							"bindTo": "Resources.Strings.RegisteredOnCaption"
						},
						"enabled": false
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 3
				},
				{
					"operation": "insert",
					"name": "ConfItem",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ConfItem",
						"caption": {
							"bindTo": "Resources.Strings.ConfItemCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						}
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 4
				},
				{
					"operation": "insert",
					"name": "SolutionPlanedOn",
					"values": {
						"layout": {
							"column": 12,
							"row": 2,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "SolutionPlanedOn",
						"caption": {
							"bindTo": "Resources.Strings.SolutionPlanedOnCaption"
						},
						"enabled": true
					},
					"parentName": "CurrentStatusGroupLayout",
					"propertyName": "items",
					"index": 5
				},
				{
					"operation": "insert",
					"name": "Case",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "SolutionTab",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.SolutionTabCaption"
						},
						"items": []
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "SolutionRichText_gridLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "SolutionContainer",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"parentName": "SolutionTab",
					"propertyName": "items",
					"name": "Activities",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"index": 2
				},
				{
					"operation": "insert",
					"parentName": "SolutionTab",
					"propertyName": "items",
					"name": "EmailDetailV2",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL
					},
					"index": 3
				},
				{
					"operation": "insert",
					"name": "Solution",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": true
						},
						"bindTo": "Solution",
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					},
					"parentName": "SolutionRichText_gridLayout",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "insert",
					"parentName": "SolutionTab",
					"propertyName": "items",
					"name": "SolutionContainer",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "SolutionFooter_gridLayout",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"parentName": "SolutionContainer",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "SolutionProvidedOn",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "SolutionProvidedOn",
						"caption": {
							"bindTo": "Resources.Strings.SolutionProvidedOnCaption"
						},
						"enabled": true
					},
					"parentName": "SolutionFooter_gridLayout",
					"propertyName": "items",
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ClosureDate",
					"values": {
						"layout": {
							"column": 12,
							"row": 1,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "ClosureDate",
						"caption": {
							"bindTo": "Resources.Strings.ClosureDateCaption"
						},
						"enabled": true
					},
					"parentName": "SolutionFooter_gridLayout",
					"propertyName": "items",
					"index": 3
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
					"index": 2
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
				}

			]/**SCHEMA_DIFF*/,
			attributes: {
				"Owner": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {filter: BaseFiltersGenerateModule.OwnerFilter}
				},
				"Author": {
					dataValueType: this.Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {filter: BaseFiltersGenerateModule.OwnerFilter}
				},
				"ConfItem": {
					lookupListConfig: {
						dataValueType: this.Terrasoft.DataValueType.LOOKUP,
						columns: ["Type"]
					}
				},
				"Group": {
					lookupListConfig: {
						filter: function() {
							return this.Terrasoft.createColumnInFilterWithParameters("SysAdminUnitTypeValue", [
								ServiceDeskConstants.SysAdminUnitType.Organization.Value,
								ServiceDeskConstants.SysAdminUnitType.Division.Value,
								ServiceDeskConstants.SysAdminUnitType.Managers.Value,
								ServiceDeskConstants.SysAdminUnitType.Team.Value
							]);
						}
					}
				},
				"Priority": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						orders: [
							{
								columnPath: "Priority"
							}
						]
					}
				}
			},
			methods: {
				/**
				 * ####### ######### ############# ########.
				 * ############# ################ ##### ### ##### # ########## #########!
				 * @overridden
				 */
				onEntityInitialized: function() {
					if (this.isAddMode() || this.isCopyMode()) {
						this.getIncrementCode(function(response) {
							this.set("Number", response);
						});
					}
					this.callParent(arguments);
				},

				/**
				 * ############# ############# ########### #######.
				 * @protected
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1064);
					this.callParent(arguments);
				},

				/**
				 * ######## ###### ### ###### "Email".
				 * @return {Terrasoft.createFilterGroup}
				 */
				getEmailDetailFilter: function() {
					var filterGroup = this.Terrasoft.createFilterGroup();
					filterGroup.add("IdFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Problem", this.get("Id")));
					filterGroup.add("EmailFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Type", ConfigurationConstants.Activity.Type.Email));
					return filterGroup;
				}
			},
			rules: {},
			userCode: {}
		};
	});

define('ProblemPageServiceModelResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("ProblemPageServiceModel", ["ProblemPageResources"],
	function(resourses) {
		return {
			entitySchemaName: "Problem",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			attributes: {},
			methods: {
				/**
				 * ######### ########-######### ######.
				 * @param {Object} item ####### ###
				 * @param {String} schemaName ######## ##### ######## ###
				 * @paran {String} errorMessage ######### ## ######
				 */
				openServiceModelModule: function(item, schemaName, errorMessage) {
					if (!item) {
						this.showInformationDialog(errorMessage);
						return;
					}
					var defaultValues = [{
						"id": item.value,
						"schemaName": schemaName,
						"name": item.displayValue
					}];
					this.openCardInChain({
						"schemaName": "ServiceModelPage",
						"moduleId": this.sandbox.id + "_ServiceModelPage",
						"isSeparateMode": false,
						"defaultValues": defaultValues
					});
				},
				/**
				 * ########## ####### ## ######## "########## ########### ## #######".
				 * ### ####### ## ###### "########## ########### ## #######" ########### ######## ########### ###.
				 */
				openServiceModelModuleByServiceItem: function() {
					var serviceItem = this.get("ServiceItem");
					this.openServiceModelModule(serviceItem, "ServiceItem",
						resourses.localizableStrings.ServiceItemErrorMessage);
				},
				/**
				 * ########## ####### ## ######## "########## ########### ## ##".
				 * ### ####### ## ###### "########## ########### ## ##" ########### ######## ########### ###.
				 */
				openServiceModelModuleByConfItem: function() {
					var confItem = this.get("ConfItem");
					this.openServiceModelModule(confItem, "ConfItem",
						resourses.localizableStrings.ConfItemErrorMessage);
				},
				/**
				 * ######### ######## # ###### ######## ## ######## ############## ########.
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.callParent(arguments);
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Tag": "openServiceModelModuleByServiceItem",
						"Caption": resourses.localizableStrings.OpenServiceModelModuleByServiceItemCaption,
						"Enabled": !this.isNewMode()
					}));
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Tag": "openServiceModelModuleByConfItem",
						"Caption": resourses.localizableStrings.OpenServiceModelModuleByConfItemCaption,
						"Enabled": !this.isNewMode()
					}));
					return actionMenuItems;
				}
			},
			rules: {},
			userCode: {}
		};
	});

define("ProblemPage", ["BaseFiltersGenerateModule", "ServiceDeskConstants"],
	function() {
		return {
			entitySchemaName: "Problem",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "Change",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12,
							"rowSpan": 1
						},
						"bindTo": "Change",
						"caption": {
							"bindTo": "Resources.Strings.ChangeCaption"
						},
						"enabled": true
					},
					"parentName": "SolutionRichText_gridLayout",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "merge",
					"name": "Solution",
					"values": {
						"contentType": this.Terrasoft.ContentType.RICH_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						}
					},
					"parentName": "SolutionRichText_gridLayout",
					"propertyName": "items",
					"index": 1
				}
			]/**SCHEMA_DIFF*/,
			attributes: {},
			methods: {},
			rules: {},
			userCode: {}
		};
	});


