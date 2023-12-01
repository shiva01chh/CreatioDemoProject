Terrasoft.configuration.Structures["Leads_FormPage"] = {innerHierarchyStack: ["Leads_FormPageCrtLead", "Leads_FormPageCrtSimilarLead", "Leads_FormPageCrtTouchPointInLead", "Leads_FormPage"], structureParent: "PageWithTabsFreedomTemplate"};
define('Leads_FormPageCrtLeadStructure', ['Leads_FormPageCrtLeadResources'], function(resources) {return {schemaUId:'925f6863-2ffd-49b9-b3b8-f12232583dfe',schemaCaption: "Leads form page", parentSchemaName: "PageWithTabsFreedomTemplate", packageName: "CrtLeadOppMgmtApp", schemaName:'Leads_FormPageCrtLead',parentSchemaUId:'3b2e117f-8c6b-4ca5-80a2-7ebb497cddf9',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Leads_FormPageCrtSimilarLeadStructure', ['Leads_FormPageCrtSimilarLeadResources'], function(resources) {return {schemaUId:'6de79667-7e7a-41aa-8737-fc7c5ef7f2c8',schemaCaption: "Leads form page", parentSchemaName: "Leads_FormPageCrtLead", packageName: "CrtLeadOppMgmtApp", schemaName:'Leads_FormPageCrtSimilarLead',parentSchemaUId:'925f6863-2ffd-49b9-b3b8-f12232583dfe',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"Leads_FormPageCrtLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Leads_FormPageCrtTouchPointInLeadStructure', ['Leads_FormPageCrtTouchPointInLeadResources'], function(resources) {return {schemaUId:'eb71ad90-3709-42d2-b725-f5d7da72ce30',schemaCaption: "Leads form page", parentSchemaName: "Leads_FormPageCrtSimilarLead", packageName: "CrtLeadOppMgmtApp", schemaName:'Leads_FormPageCrtTouchPointInLead',parentSchemaUId:'6de79667-7e7a-41aa-8737-fc7c5ef7f2c8',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"Leads_FormPageCrtSimilarLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Leads_FormPageStructure', ['Leads_FormPageResources'], function(resources) {return {schemaUId:'bcc8d064-bb14-427a-92e3-6f8f000618cb',schemaCaption: "Leads form page", parentSchemaName: "Leads_FormPageCrtTouchPointInLead", packageName: "CrtLeadOppMgmtApp", schemaName:'Leads_FormPage',parentSchemaUId:'eb71ad90-3709-42d2-b725-f5d7da72ce30',extendParent:true,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:"Leads_FormPageCrtTouchPointInLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define('Leads_FormPageCrtLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("Leads_FormPageCrtLead", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "SaveButton",
				"values": {
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "merge",
				"name": "CancelButton",
				"values": {
					"color": "default",
					"size": "large",
					"iconPosition": "only-text"
				}
			},
			{
				"operation": "remove",
				"name": "SideAreaProfileContainer"
			},
			{
				"operation": "merge",
				"name": "Tabs",
				"values": {
					"styleType": "default",
					"mode": "tab",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "remove",
				"name": "GeneralInfoTab"
			},
			{
				"operation": "remove",
				"name": "GeneralInfoTabContainer"
			},
			{
				"operation": "merge",
				"name": "CardToggleTabPanel",
				"values": {
					"styleType": "default",
					"bodyBackgroundColor": "primary-contrast-500",
					"selectedTabTitleColor": "auto",
					"tabTitleColor": "auto",
					"underlineSelectedTabColor": "auto",
					"headerBackgroundColor": "auto"
				}
			},
			{
				"operation": "merge",
				"name": "Feed",
				"values": {
					"dataSourceName": "PDS",
					"entitySchemaName": "Lead"
				}
			},
			{
				"operation": "merge",
				"name": "AttachmentList",
				"values": {
					"recordColumnName": "Lead",
					"columns": [
						{
							"id": "3fb963b9-dc31-43eb-b899-ecc98131cde8",
							"code": "AttachmentListDS_Name",
							"caption": "#ResourceString(AttachmentListDS_Name)#",
							"dataValueType": 28,
							"width": 200
						}
					]
				}
			},
			{
				"operation": "insert",
				"name": "SideAreaProfileFieldFlexContainer",
				"values": {
					"layoutConfig": {},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "medium",
					"padding": {
						"top": "medium",
						"right": "medium",
						"bottom": "medium",
						"left": "medium"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "SideContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Status",
				"values": {
					"layoutConfig": {},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_dr0vsd0",
					"labelPosition": "above",
					"control": "$LookupAttribute_dr0vsd0",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileFieldFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SideAreaProfileFieldGridContainer",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "small",
						"rowGap": "none"
					},
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
					"layoutConfig": {}
				},
				"parentName": "SideAreaProfileFieldFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadTypeDetails",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_rsim6pt",
					"labelPosition": "above",
					"control": "$LookupAttribute_rsim6pt",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": "",
					"readonly": false
				},
				"parentName": "SideAreaProfileFieldGridContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CustomerInfoFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "primary",
					"borderRadius": "medium",
					"padding": {
						"top": "medium",
						"right": "medium",
						"bottom": "medium",
						"left": "medium"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "SideContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ContactFieldsFlexContainer",
				"values": {
					"layoutConfig": {},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "medium",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "CustomerInfoFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContactLabelContainer",
				"values": {
					"layoutConfig": {},
					"type": "crt.FlexContainer",
					"direction": "row",
					"items": [],
					"fitContent": true,
					"gap": "none",
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "medium",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"wrap": "wrap"
				},
				"parentName": "ContactFieldsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContactLabel",
				"values": {
					"layoutConfig": {},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(ContactLabel_caption)#)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "ContactLabelContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ContactCompactProfile",
				"values": {
					"type": "crt.ContactCompactProfile",
					"readonly": true,
					"visible": true,
					"referenceColumn": "$Parameter_r8t9n2f"
				},
				"parentName": "ContactFieldsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "JobTitle",
				"values": {
					"type": "crt.Input",
					"label": "$Resources.Strings.QualifiedContactJobTitle",
					"control": "$QualifiedContactJobTitle",
					"placeholder": "",
					"tooltip": "",
					"readonly": true,
					"multiline": false,
					"labelPosition": "above",
					"visible": true
				},
				"parentName": "ContactFieldsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ContactCommunicationOptions",
				"values": {
					"type": "crt.CommunicationOptions",
					"readonly": true,
					"columnsCount": 1,
					"showNoDataPlaceholder": true,
					"labelPosition": "above",
					"layoutConfig": {},
					"items": "$CommunicationOptions_f87c6ae",
					"masterRecordColumnName": "Contact",
					"visible": true,
					"masterRecordColumnValue": "$Parameter_r8t9n2f"
				},
				"parentName": "ContactFieldsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "AccountFieldsFlexContainer",
				"values": {
					"layoutConfig": {},
					"type": "crt.FlexContainer",
					"direction": "column",
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
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "CustomerInfoFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "AccountLabelContainer",
				"values": {
					"layoutConfig": {},
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
						"bottom": "medium",
						"left": "none"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "wrap"
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AccountLabel",
				"values": {
					"layoutConfig": {},
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(AccountLabel_caption)#)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "AccountLabelContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AccountCompactProfile",
				"values": {
					"type": "crt.AccountCompactProfile",
					"readonly": true,
					"visible": true,
					"referenceColumn": "$Parameter_3pxm4wn"
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Web",
				"values": {
					"type": "crt.WebInput",
					"label": "$Resources.Strings.QualifiedAccountWeb",
					"control": "$QualifiedAccountWeb",
					"labelPosition": "above",
					"placeholder": "",
					"tooltip": "",
					"needHandleSave": false,
					"caption": "#ResourceString(Web_caption)#",
					"readonly": true,
					"visible": true
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "Type",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedAccountType",
					"ariaLabel": "#ResourceString(Type_ariaLabel)#",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "above",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedAccountType",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Industry",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedAccountIndustry",
					"ariaLabel": "#ResourceString(Industry_ariaLabel)#",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "above",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedAccountIndustry",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "EmployeesNumber",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedAccountEmployeesNumber",
					"ariaLabel": "#ResourceString(EmployeesNumber_ariaLabel)#",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "above",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedAccountEmployeesNumber",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "AnnualRevenue",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedAccountAnnualRevenue",
					"ariaLabel": "#ResourceString(AnnualRevenue_ariaLabel)#",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "above",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedAccountAnnualRevenue",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "AccountFieldsFlexContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "OverviewTab",
				"values": {
					"caption": "#ResourceString(GeneralInfoTab_caption)#",
					"type": "crt.TabContainer",
					"items": [],
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OverviewFieldsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"gap": "none"
				},
				"parentName": "OverviewTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OverviewFieldsContainer",
				"values": {
					"type": "crt.GridContainer",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"rows": "minmax(max-content, 32px)",
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
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
					"layoutConfig": {}
				},
				"parentName": "OverviewFieldsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadType",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_ivqsxmp",
					"labelPosition": "auto",
					"control": "$LookupAttribute_ivqsxmp",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "CreatedOn",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.DateTimePicker",
					"pickerType": "datetime",
					"label": "$Resources.Strings.DateTimeAttribute_1b4r79a",
					"labelPosition": "auto",
					"control": "$DateTimeAttribute_1b4r79a",
					"readonly": true
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "QualifiedContact",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.Parameter_r8t9n2f",
					"labelPosition": "auto",
					"control": "$Parameter_r8t9n2f",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "addRecord_icp70f0",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_icp70f0_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "QualifiedContact",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "QualifiedAccount",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 2,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.Parameter_3pxm4wn",
					"labelPosition": "auto",
					"control": "$Parameter_3pxm4wn",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "addRecord_hd0i1qq",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_hd0i1qq_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "QualifiedAccount",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadName",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "#ResourceString(LeadName_label)#",
					"control": "$LeadName",
					"labelPosition": "auto",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "Group",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_dzve5mq",
					"labelPosition": "auto",
					"control": "$LookupAttribute_dzve5mq",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "Owner",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 4,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_0ljkabs",
					"labelPosition": "auto",
					"control": "$LookupAttribute_0ljkabs",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "addRecord_udcglv2",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_udcglv2_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Owner",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "DetailsFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"gap": "none"
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "insert",
				"name": "Commentary",
				"values": {
					"layoutConfig": {},
					"type": "crt.Input",
					"multiline": true,
					"label": "#ResourceString(Commentary_label)#",
					"labelPosition": "auto",
					"control": "$StringAttribute_cg42kpk",
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "DetailsFlexContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LeadName": {
						"modelConfig": {
							"path": "PDS.LeadName"
						}
					},
					"Parameter_r8t9n2f": {
						"modelConfig": {
							"path": "PDS.QualifiedContact"
						}
					},
					"QualifiedContactJobTitle": {
						"modelConfig": {
							"path": "PDS.QualifiedContactJobTitle"
						}
					},
					"CommunicationOptions_f87c6ae": {
						"isCollection": true,
						"modelConfig": {
							"path": "ContactCommunicationOptionsDS",
							"sortingConfig": {
								"default": [
									{
										"columnName": "CreatedOn",
										"direction": "asc"
									}
								]
							}
						},
						"viewModelConfig": {
							"attributes": {
								"ContactCommunicationOptionsDS_CreatedOn": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.CreatedOn"
									}
								},
								"ContactCommunicationOptionsDS_Number": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.Number"
									}
								},
								"ContactCommunicationOptionsDS_Primary": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.Primary"
									}
								},
								"ContactCommunicationOptionsDS_NonActual": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.NonActual"
									}
								},
								"ContactCommunicationOptionsDS_CommunicationType": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.CommunicationType"
									}
								},
								"ContactCommunicationOptionsDS_CommunicationTypeDisplayFormat": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.CommunicationTypeDisplayFormat"
									}
								},
								"ContactCommunicationOptionsDS_CommunicationTypeName": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.CommunicationTypeName"
									}
								},
								"ContactCommunicationOptionsDS_Id": {
									"modelConfig": {
										"path": "ContactCommunicationOptionsDS.Id"
									}
								}
							}
						}
					},
					"Parameter_3pxm4wn": {
						"modelConfig": {
							"path": "PDS.QualifiedAccount"
						}
					},
					"QualifiedAccountWeb": {
						"modelConfig": {
							"path": "PDS.QualifiedAccountWeb"
						}
					},
					"QualifiedAccountType": {
						"modelConfig": {
							"path": "PDS.QualifiedAccountType"
						}
					},
					"QualifiedAccountIndustry": {
						"modelConfig": {
							"path": "PDS.QualifiedAccountIndustry"
						}
					},
					"QualifiedAccountEmployeesNumber": {
						"modelConfig": {
							"path": "PDS.QualifiedAccountEmployeesNumber"
						}
					},
					"QualifiedAccountAnnualRevenue": {
						"modelConfig": {
							"path": "PDS.QualifiedAccountAnnualRevenue"
						}
					},
					"LookupAttribute_ivqsxmp": {
						"modelConfig": {
							"path": "PDS.LeadType"
						}
					},
					"DateTimeAttribute_1b4r79a": {
						"modelConfig": {
							"path": "PDS.CreatedOn"
						}
					},
					"LookupAttribute_0ljkabs": {
						"modelConfig": {
							"path": "PDS.Owner"
						}
					},
					"StringAttribute_cg42kpk": {
						"modelConfig": {
							"path": "PDS.Commentary"
						}
					},
					"LookupAttribute_dzve5mq": {
						"modelConfig": {
							"path": "PDS.Group"
						}
					},
					"LookupAttribute_dr0vsd0": {
						"modelConfig": {
							"path": "PDS.Status"
						}
					},
					"LookupAttribute_rsim6pt": {
						"modelConfig": {
							"path": "PDS.LeadTypeDetails"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Id",
					"modelConfig"
				],
				"values": {
					"path": "PDS.Id"
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"primaryDataSourceName": "PDS"
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"PDS": {
						"type": "crt.EntityDataSource",
						"config": {
							"entitySchemaName": "Lead",
							"attributes": {
								"QualifiedContactJobTitle": {
									"path": "QualifiedContact.JobTitle",
									"type": "ForwardReference"
								},
								"QualifiedAccountWeb": {
									"path": "QualifiedAccount.Web",
									"type": "ForwardReference"
								},
								"QualifiedAccountType": {
									"path": "QualifiedAccount.Type",
									"type": "ForwardReference"
								},
								"QualifiedAccountIndustry": {
									"path": "QualifiedAccount.Industry",
									"type": "ForwardReference"
								},
								"QualifiedAccountEmployeesNumber": {
									"path": "QualifiedAccount.EmployeesNumber",
									"type": "ForwardReference"
								},
								"QualifiedAccountAnnualRevenue": {
									"path": "QualifiedAccount.AnnualRevenue",
									"type": "ForwardReference"
								}
							}
						},
						"scope": "page"
					},
					"CommunicationOptions_f87c6aeDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "ContactCommunication",
							"attributes": {
								"CreatedOn": {
									"path": "CreatedOn"
								},
								"Number": {
									"path": "Number"
								},
								"Primary": {
									"path": "Primary"
								},
								"NonActual": {
									"path": "NonActual"
								},
								"CommunicationType": {
									"path": "CommunicationType"
								},
								"CommunicationTypeDisplayFormat": {
									"type": "ForwardReference",
									"path": "CommunicationType.DisplayFormat"
								},
								"CommunicationTypeName": {
									"type": "ForwardReference",
									"path": "CommunicationType.Name"
								}
							}
						}
					},
					"ContactCommunicationOptionsDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "ContactCommunication",
							"attributes": {
								"CreatedOn": {
									"path": "CreatedOn"
								},
								"Number": {
									"path": "Number"
								},
								"Primary": {
									"path": "Primary"
								},
								"NonActual": {
									"path": "NonActual"
								},
								"CommunicationType": {
									"path": "CommunicationType"
								},
								"CommunicationTypeDisplayFormat": {
									"type": "ForwardReference",
									"path": "CommunicationType.DisplayFormat"
								},
								"CommunicationTypeName": {
									"type": "ForwardReference",
									"path": "CommunicationType.Name"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"AttachmentListDS",
					"config"
				],
				"values": {
					"entitySchemaName": "FileLead"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
define('Leads_FormPageCrtSimilarLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("Leads_FormPageCrtSimilarLead", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "SimilarLeadExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(SimilarLeadExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true
				},
				"parentName": "OverviewTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SimilarLeadToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "SimilarLeadExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SimilarLeadToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "SimilarLeadToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SimilarLeadRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(SimilarLeadRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "SimilarLeadListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "SimilarLeadToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SimilarLeadSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(SimilarLeadSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "SimilarLeadToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SimilarLeadExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(SimilarLeadExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "SimilarLeadList",
							"filters": "$SimilarLeadList | crt.ToCollectionFilters : 'SimilarLeadList' : $SimilarLeadList_SelectionState"
						}
					}
				},
				"parentName": "SimilarLeadSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SimilarLeadSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(SimilarLeadSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"SimilarLeadList"
					]
				},
				"parentName": "SimilarLeadToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "SimilarLeadListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "SimilarLeadExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SimilarLeadList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"visible": true,
					"fitContent": true,
					"items": "$SimilarLeadList",
					"primaryColumnName": "SimilarLeadListDS_Id",
					"columns": [
						{
							"id": "45c62464-d133-5858-df87-14ad6c0e1840",
							"code": "SimilarLeadListDS_LeadName",
							"caption": "#ResourceString(SimilarLeadListDS_LeadName)#",
							"dataValueType": 30,
							"sticky": true
						},
						{
							"id": "c630c167-17a0-e0fb-cf4c-82bf667c741a",
							"code": "SimilarLeadListDS_QualifyStatus",
							"path": "QualifyStatus",
							"caption": "#ResourceString(SimilarLeadListDS_QualifyStatus)#",
							"dataValueType": 10,
							"referenceSchemaName": "QualifyStatus",
							"sticky": true
						},
						{
							"id": "71ac2dc1-9155-6b88-7e91-5207bea6da95",
							"code": "SimilarLeadListDS_CreatedOn",
							"path": "CreatedOn",
							"caption": "#ResourceString(SimilarLeadListDS_CreatedOn)#",
							"dataValueType": 7
						},
						{
							"id": "b8bd990e-fcd1-15a7-ee80-bfb5e09e9e32",
							"code": "SimilarLeadListDS_Owner",
							"path": "Owner",
							"caption": "#ResourceString(SimilarLeadListDS_Owner)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						},
						{
							"id": "706c2640-8ee5-f238-87ce-1d714a7c0d52",
							"code": "SimilarLeadListDS_QualifiedAccount",
							"path": "QualifiedAccount",
							"caption": "#ResourceString(SimilarLeadListDS_QualifiedAccount)#",
							"dataValueType": 10,
							"referenceSchemaName": "Account"
						},
						{
							"id": "632c0495-294d-b50f-5860-a18f0a83081b",
							"code": "SimilarLeadListDS_QualifiedContact",
							"path": "QualifiedContact",
							"caption": "#ResourceString(SimilarLeadListDS_QualifiedContact)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						}
					],
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"selectionState": "$SimilarLeadList_SelectionState",
					"_selectionOptions": {
						"attribute": "SimilarLeadList_SelectionState"
					}
				},
				"parentName": "SimilarLeadListContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"SimilarLeadList": {
					"isCollection": true,
					"modelConfig": {
						"path": "SimilarLeadListDS",
						"sortingConfig": {
							"default": [
								{
									"direction": "asc",
									"columnName": "LeadName"
								}
							]
						}
					},
					"viewModelConfig": {
						"attributes": {
							"SimilarLeadListDS_LeadName": {
								"modelConfig": {
									"path": "SimilarLeadListDS.LeadName"
								}
							},
							"SimilarLeadListDS_QualifyStatus": {
								"modelConfig": {
									"path": "SimilarLeadListDS.QualifyStatus"
								}
							},
							"SimilarLeadListDS_CreatedOn": {
								"modelConfig": {
									"path": "SimilarLeadListDS.CreatedOn"
								}
							},
							"SimilarLeadListDS_Owner": {
								"modelConfig": {
									"path": "SimilarLeadListDS.Owner"
								}
							},
							"SimilarLeadListDS_QualifiedAccount": {
								"modelConfig": {
									"path": "SimilarLeadListDS.QualifiedAccount"
								}
							},
							"SimilarLeadListDS_QualifiedContact": {
								"modelConfig": {
									"path": "SimilarLeadListDS.QualifiedContact"
								}
							},
							"SimilarLeadListDS_Id": {
								"modelConfig": {
									"path": "SimilarLeadListDS.Id"
								}
							}
						}
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"SimilarLeadListDS": {
					"type": "crt.EntityDataSource",
					"scope": "viewElement",
					"config": {
						"entitySchemaName": "SimilarLead",
						"attributes": {
							"LeadName": {
								"path": "LeadName"
							},
							"QualifyStatus": {
								"path": "QualifyStatus"
							},
							"CreatedOn": {
								"path": "CreatedOn"
							},
							"Owner": {
								"path": "Owner"
							},
							"QualifiedAccount": {
								"path": "QualifiedAccount"
							},
							"QualifiedContact": {
								"path": "QualifiedContact"
							}
						}
					}
				}
			},
			"dependencies": {
				"SimilarLeadListDS": [
					{
						"attributePath": "Id",
						"relationPath": "PDS.Id"
					}
				]
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});
define('Leads_FormPageCrtTouchPointInLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("Leads_FormPageCrtTouchPointInLead", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "DetailsFlexContainer",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 6,
						"colSpan": 2,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "ContactSource",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedContactSource",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "above",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedContactSource",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "SideAreaProfileFieldGridContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ContactChannel",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedContactChannel",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "auto",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedContactChannel",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "insert",
				"name": "ContactRegisterMethod",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 5,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.QualifiedContactRegisterMethod",
					"isAddAllowed": true,
					"showValueAsLink": true,
					"labelPosition": "auto",
					"controlActions": [],
					"listActions": [],
					"tooltip": "",
					"readonly": true,
					"control": "$QualifiedContactRegisterMethod",
					"visible": true,
					"placeholder": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 8
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"QualifiedContactSource": {
					"modelConfig": {
						"path": "PDS.QualifiedContactSource"
					}
				},
				"QualifiedContactChannel": {
					"modelConfig": {
						"path": "PDS.QualifiedContactChannel"
					}
				},
				"QualifiedContactRegisterMethod": {
					"modelConfig": {
						"path": "PDS.QualifiedContactRegisterMethod"
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{
			"dataSources": {
				"PDS": {
					"config": {
						"attributes": {
							"QualifiedContactSource": {
								"path": "QualifiedContact.Source",
								"type": "ForwardReference"
							},
							"QualifiedContactChannel": {
								"path": "QualifiedContact.Channel",
								"type": "ForwardReference"
							},
							"QualifiedContactRegisterMethod": {
								"path": "QualifiedContact.RegisterMethod",
								"type": "ForwardReference"
							}
						}
					}
				}
			}
		}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

define("Leads_FormPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "LeadName",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					}
				}
			},
			{
				"operation": "insert",
				"name": "ProgressBarContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "column",
					"items": [],
					"fitContent": true,
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "small",
						"bottom": "none",
						"left": "small"
					},
					"justifyContent": "start",
					"alignItems": "stretch",
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProgressBar",
				"values": {
					"type": "crt.EntityStageProgressBar",
					"saveOnChange": false,
					"askUserToChangeSchema": true,
					"entityName": "Lead"
				},
				"parentName": "ProgressBarContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadDisqualifyReason",
				"values": {
					"type": "crt.ComboBox",
					"label": "#ResourceString(LeadDisqualifyReason_label)#",
					"labelPosition": "above",
					"control": "$LookupAttribute_mfwvuqd",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": false,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "SideAreaProfileFieldFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "PredictiveScore",
				"values": {
					"type": "crt.NumberInput",
					"label": "#ResourceString(PredictiveScore_label)#",
					"labelPosition": "above",
					"control": "$NumberAttribute_sgdzxor",
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(PredictiveScore_tooltip)#",
					"readonly": true
				},
				"parentName": "SideAreaProfileFieldFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "SalesChannel",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 3,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_1prxdry",
					"labelPosition": "auto",
					"control": "$LookupAttribute_1prxdry",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": [],
					"visible": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "OverviewFieldsContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "ClosingDetails",
				"values": {
					"type": "crt.Input",
					"label": "$Resources.Strings.StringAttribute_1zhbdlz",
					"labelPosition": "auto",
					"control": "$StringAttribute_1zhbdlz",
					"multiline": true,
					"visible": false,
					"placeholder": "#ResourceString(ClosingDetails_placeholder)#",
					"tooltip": ""
				},
				"parentName": "DetailsFlexContainer",
				"propertyName": "items",
				"index": 9
			},
			{
				"operation": "insert",
				"name": "ProcessingTab",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(ProcessingTab_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Timeline",
				"values": {
					"type": "crt.Timeline",
					"items": [],
					"tools": [],
					"hideTools": false,
					"masterSchemaId": "$Id",
					"caption": "#ResourceString(Timeline_caption)#",
					"label": "#ResourceString(Timeline_label)#"
				},
				"parentName": "ProcessingTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TimelineTile_e85dlzd",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"linkedColumn": "Lead",
					"sortedByColumn": "StartDate",
					"data": {
						"uId": "2f81fa05-11ae-400d-8e07-5ef6a620d1ad",
						"schemaName": "Call",
						"schemaType": null,
						"filter": null,
						"columns": [
							{
								"columnName": "StartDate",
								"columnLayout": {
									"column": 1,
									"row": 1,
									"colSpan": 4,
									"rowSpan": 1
								}
							},
							{
								"columnName": "EndDate",
								"columnLayout": {
									"column": 5,
									"row": 1,
									"colSpan": 4,
									"rowSpan": 1
								}
							},
							{
								"columnName": "Duration",
								"columnLayout": {
									"column": 9,
									"row": 1,
									"colSpan": 4,
									"rowSpan": 1
								}
							}
						]
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TimelineTile_dxx01as",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"linkedColumn": "Lead",
					"sortedByColumn": "SendDate",
					"data": {
						"uId": "c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
						"schemaName": "Activity",
						"schemaType": "Email",
						"filter": {
							"columnName": "Type",
							"columnValue": "e2831dec-cfc0-df11-b00f-001d60e938c6",
							"comparisonType": 3
						},
						"columns": [
							{
								"columnName": "Title",
								"columnLayout": {
									"column": 1,
									"row": 1,
									"colSpan": 12,
									"rowSpan": 1
								}
							},
							{
								"columnName": "Body",
								"columnLayout": {
									"column": 1,
									"row": 2,
									"colSpan": 12,
									"rowSpan": 2
								}
							}
						]
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "TimelineTile_fp45h8v",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"linkedColumn": "Lead",
					"sortedByColumn": "StartDate",
					"data": {
						"uId": "c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
						"schemaName": "Activity",
						"schemaType": "Activity",
						"filter": {
							"columnName": "Type",
							"columnValue": "e2831dec-cfc0-df11-b00f-001d60e938c6",
							"comparisonType": 4
						},
						"columns": [
							{
								"columnName": "Title",
								"columnLayout": null
							},
							{
								"columnName": "Status",
								"columnLayout": {
									"column": 1,
									"row": 1,
									"colSpan": 6,
									"rowSpan": 1
								}
							},
							{
								"columnName": "DetailedResult",
								"columnLayout": {
									"column": 1,
									"row": 2,
									"colSpan": 6,
									"rowSpan": 1
								}
							}
						]
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "TimelineTile_jhkhp4d",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"sortedByColumn": "CreatedOn",
					"data": {
						"schemaType": "SysFile"
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "TimelineTile_0ygj57r",
				"values": {
					"type": "crt.TimelineTile",
					"classes": [
						"view-element"
					],
					"sortedByColumn": "CreatedOn",
					"data": {
						"schemaType": "Feed"
					},
					"iconPosition": "only-icon",
					"icon": "star-tab-icon",
					"visible": true
				},
				"parentName": "Timeline",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "MessageComposer",
				"values": {
					"type": "crt.MessageComposerSelector",
					"items": [],
					"classes": [
						"view-element"
					],
					"visible": true,
					"defaultChannel": "crt.FeedComposer"
				},
				"parentName": "Timeline",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailComposer",
				"values": {
					"type": "crt.EmailComposer",
					"classes": [
						"view-element"
					],
					"sortedByColumn": "CreatedOn",
					"data": {
						"uId": "9ed26229-1d47-f18e-7648-3a90498b3bd2",
						"schemaType": "Email",
						"sortedByColumn": "CreatedOn",
						"typeName": "crt.EmailComposer",
						"caption": "Email"
					},
					"recordId": "$Id",
					"defaultSenderRequest": "crt.DefaultSenderComposerRequest",
					"entitySchemaName": "Lead"
				},
				"parentName": "MessageComposer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "FeedComposer",
				"values": {
					"type": "crt.FeedComposer",
					"classes": [
						"view-element"
					],
					"sortedByColumn": "CreatedOn",
					"data": {
						"uId": "278afc55-9180-9be2-895f-5145fda538b7",
						"schemaType": "Feed",
						"sortedByColumn": "CreatedOn",
						"typeName": "crt.FeedComposer",
						"caption": "Feed"
					},
					"feedType": "Record",
					"primaryColumnValue": "$Id",
					"cardState": "$CardState",
					"entitySchemaName": "Lead",
					"dataSourceName": "PDS"
				},
				"parentName": "MessageComposer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "SalesTab",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(SalesTab_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(OpportunityPlanningExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "SalesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "OpportunityPlanningExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "OpportunityPlanningToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningFieldsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "OpportunityPlanningExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningFieldsFlexContainerLeft",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
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
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "OpportunityPlanningFieldsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Budget",
				"values": {
					"type": "crt.NumberInput",
					"label": "#ResourceString(Budget_label)#",
					"labelPosition": "auto",
					"control": "$NumberAttribute_6nr0xsg",
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(Budget_tooltip)#"
				},
				"parentName": "OpportunityPlanningFieldsFlexContainerLeft",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Opportunity",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_wl8vj23",
					"labelPosition": "auto",
					"control": "$LookupAttribute_wl8vj23",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "OpportunityPlanningFieldsFlexContainerLeft",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "addRecord_o3h2431",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_o3h2431_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "Opportunity",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunityPlanningFieldsFlexContainerRight",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.FlexContainer",
					"direction": "column",
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
					"gap": "none",
					"wrap": "nowrap"
				},
				"parentName": "OpportunityPlanningFieldsContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "DecisionDate",
				"values": {
					"type": "crt.DateTimePicker",
					"pickerType": "date",
					"label": "#ResourceString(DecisionDate_label)#",
					"labelPosition": "auto",
					"control": "$DateTimeAttribute_q8nrp29",
					"visible": true,
					"placeholder": "",
					"tooltip": "#ResourceString(DecisionDate_tooltip)#"
				},
				"parentName": "OpportunityPlanningFieldsFlexContainerRight",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "SalesOwner",
				"values": {
					"type": "crt.ComboBox",
					"label": "$Resources.Strings.LookupAttribute_kyciimy",
					"labelPosition": "auto",
					"control": "$LookupAttribute_kyciimy",
					"listActions": [],
					"showValueAsLink": true,
					"controlActions": []
				},
				"parentName": "OpportunityPlanningFieldsFlexContainerRight",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "addRecord_quqpon1",
				"values": {
					"code": "addRecord",
					"type": "crt.ComboboxSearchTextAction",
					"icon": "combobox-add-new",
					"caption": "#ResourceString(addRecord_quqpon1_caption)#",
					"clicked": {
						"request": "crt.CreateRecordFromLookupRequest",
						"params": {}
					}
				},
				"parentName": "SalesOwner",
				"propertyName": "listActions",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "BusinessCase",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 2,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.StringAttribute_cdi5zf7",
					"labelPosition": "auto",
					"control": "$StringAttribute_cdi5zf7",
					"multiline": true,
					"visible": true,
					"placeholder": "#ResourceString(BusinessCase_placeholder)#",
					"tooltip": ""
				},
				"parentName": "OpportunityPlanningFieldsContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ProductSuggestions",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 3,
						"colSpan": 2,
						"rowSpan": 1
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.StringAttribute_s73ygx6",
					"labelPosition": "auto",
					"control": "$StringAttribute_s73ygx6",
					"multiline": true,
					"visible": true,
					"placeholder": "#ResourceString(ProductSuggestions_placeholder)#",
					"tooltip": ""
				},
				"parentName": "OpportunityPlanningFieldsContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ProductsExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(ProductsExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "SalesTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductsToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "ProductsExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductsToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "ProductsToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductsAddButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductsAddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "LeadProduct",
							"defaultValues": [
								{
									"attributeName": "Lead",
									"value": "$Id"
								}
							]
						}
					},
					"visible": false,
					"clickMode": "default"
				},
				"parentName": "ProductsToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductsRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductsRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "ProductsListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "ProductsToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductsSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(ProductsSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "ProductsToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "ProductsExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductsExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "ProductsList",
							"filters": "$ProductsList | crt.ToCollectionFilters : 'ProductsList' : $ProductsList_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "ProductsSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductsImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(ProductsImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "LeadProduct"
						}
					},
					"visible": true
				},
				"parentName": "ProductsSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "ProductsSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(ProductsSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"ProductsList"
					]
				},
				"parentName": "ProductsToolsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "ProductsListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "ProductsExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ProductsList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$ProductsList",
					"primaryColumnName": "ProductsListDS_Id",
					"columns": [
						{
							"id": "051bd06b-a958-d153-df6b-0e999bf6f789",
							"code": "ProductsListDS_Product",
							"path": "Product",
							"caption": "#ResourceString(ProductsListDS_Product)#",
							"dataValueType": 10,
							"referenceSchemaName": "Product",
							"width": 484
						},
						{
							"id": "a3b8f6ae-66ad-9d31-e4aa-e5c2418a143c",
							"code": "ProductsListDS_ProductPrice",
							"path": "Product.Price",
							"caption": "#ResourceString(ProductsListDS_ProductPrice)#",
							"dataValueType": 6,
							"width": 232
						}
					],
					"visible": true,
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": true
						}
					},
					"fitContent": true,
					"selectionState": "$ProductsList_SelectionState",
					"_selectionOptions": {
						"attribute": "ProductsList_SelectionState"
					}
				},
				"parentName": "ProductsListContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "HistoryTab",
				"values": {
					"type": "crt.TabContainer",
					"items": [],
					"caption": "#ResourceString(HistoryTab_caption)#",
					"iconPosition": "only-text",
					"visible": true
				},
				"parentName": "Tabs",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "StageHistoryExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(StageHistoryExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistoryToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "StageHistoryExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistoryToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "StageHistoryToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistoryRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(StageHistoryRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "StageHistoryListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "StageHistoryToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistorySettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(StageHistorySettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "StageHistoryToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "StageHistoryExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(StageHistoryExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "StageHistoryList",
							"filters": "$GridDetail_q6k1kvr | crt.ToCollectionFilters : 'GridDetail_q6k1kvr' : $StageHistoryList_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "StageHistorySettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistorySearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(StageHistorySearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_q6k1kvr"
					]
				},
				"parentName": "StageHistoryToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "StageHistoryListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "StageHistoryExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "StageHistoryList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_q6k1kvr",
					"features": {
						"editable": {
							"enable": false,
							"itemsCreation": false
						}
					},
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "StageHistoryListDS_Id",
					"columns": [
						{
							"id": "ffddf855-8c14-ffe9-b647-0835544c8d37",
							"code": "StageHistoryListDS_QualifyStatus",
							"path": "QualifyStatus",
							"caption": "#ResourceString(StageHistoryListDS_QualifyStatus)#",
							"dataValueType": 10,
							"referenceSchemaName": "QualifyStatus",
							"width": 280
						},
						{
							"id": "8b125526-4abc-a8d5-ffe8-bdb485b3d01d",
							"code": "StageHistoryListDS_StartDate",
							"path": "StartDate",
							"caption": "#ResourceString(StageHistoryListDS_StartDate)#",
							"dataValueType": 7
						},
						{
							"id": "29af74bd-80ec-ec12-ce02-cbc825081be8",
							"code": "StageHistoryListDS_DueDate",
							"path": "DueDate",
							"caption": "#ResourceString(StageHistoryListDS_DueDate)#",
							"dataValueType": 7
						},
						{
							"id": "88b0898d-afbc-efed-b62c-8a4871991cff",
							"code": "StageHistoryListDS_ModifiedBy",
							"path": "ModifiedBy",
							"caption": "#ResourceString(StageHistoryListDS_ModifiedBy)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						}
					],
					"selectionState": "$StageHistoryList_SelectionState",
					"_selectionOptions": {
						"attribute": "StageHistoryList_SelectionState"
					}
				},
				"parentName": "StageHistoryListContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(LeadsByCustomerExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "LeadsByCustomerExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "LeadsByCustomerToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerAddButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadsByCustomerAddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "Lead",
							"defaultValues": [
								{
									"attributeName": "QualifiedAccount",
									"value": "$Parameter_3pxm4wn"
								}
							]
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "LeadsByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadsByCustomerRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "LeadsByCustomerListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "LeadsByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(LeadsByCustomerSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "LeadsByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(LeadsByCustomerExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "LeadsByCustomerList",
							"filters": "$GridDetail_yoxos8p | crt.ToCollectionFilters : 'GridDetail_yoxos8p' : $LeadsByCustomerList_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "LeadsByCustomerSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(LeadsByCustomerImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "Lead"
						}
					},
					"visible": true
				},
				"parentName": "LeadsByCustomerSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(LeadsByCustomerSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_yoxos8p"
					]
				},
				"parentName": "LeadsByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "LeadsByCustomerExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LeadsByCustomerList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_yoxos8p",
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "LeadsByCustomerListDS_Id",
					"columns": [
						{
							"id": "927598a3-3574-697c-3dca-565fb294076c",
							"code": "LeadsByCustomerListDS_LeadName",
							"caption": "#ResourceString(LeadsByCustomerListDS_LeadName)#",
							"dataValueType": 30,
							"width": 328
						},
						{
							"id": "58135ad8-a7f5-77cc-52a5-e8d06e38fd70",
							"code": "LeadsByCustomerListDS_LeadType",
							"path": "LeadType",
							"caption": "#ResourceString(LeadsByCustomerListDS_LeadType)#",
							"dataValueType": 10,
							"referenceSchemaName": "LeadType",
							"width": 221
						},
						{
							"id": "8465f1b1-71cd-bea9-6bff-d9fc69f0ac5d",
							"code": "LeadsByCustomerListDS_QualifyStatus",
							"path": "QualifyStatus",
							"caption": "#ResourceString(LeadsByCustomerListDS_QualifyStatus)#",
							"dataValueType": 10,
							"referenceSchemaName": "QualifyStatus",
							"width": 212
						},
						{
							"id": "03a78cc8-4966-3af7-5b3b-f13b2227a789",
							"code": "LeadsByCustomerListDS_Owner",
							"path": "Owner",
							"caption": "#ResourceString(LeadsByCustomerListDS_Owner)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact"
						},
						{
							"id": "3c03d6a9-8d4e-35b5-50ab-4a4705c96c1d",
							"code": "LeadsByCustomerListDS_CreatedOn",
							"path": "CreatedOn",
							"caption": "#ResourceString(LeadsByCustomerListDS_CreatedOn)#",
							"dataValueType": 7
						}
					],
					"selectionState": "$LeadsByCustomerList_SelectionState",
					"_selectionOptions": {
						"attribute": "LeadsByCustomerList_SelectionState"
					}
				},
				"parentName": "LeadsByCustomerListContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerExpansionPanel",
				"values": {
					"type": "crt.ExpansionPanel",
					"tools": [],
					"items": [],
					"title": "#ResourceString(OpportunitiesByCustomerExpansionPanel_title)#",
					"toggleType": "default",
					"togglePosition": "before",
					"expanded": true,
					"labelColor": "auto",
					"fullWidthHeader": false,
					"titleWidth": 20,
					"padding": {
						"top": "small",
						"bottom": "small",
						"left": "none",
						"right": "none"
					},
					"fitContent": true,
					"visible": true
				},
				"parentName": "HistoryTab",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerToolsContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 24px)",
					"columns": [
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "OpportunitiesByCustomerExpansionPanel",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerToolsFlexContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"gap": "none",
					"alignItems": "center",
					"items": [],
					"layoutConfig": {
						"colSpan": 1,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					}
				},
				"parentName": "OpportunitiesByCustomerToolsContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerAddButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(OpportunitiesByCustomerAddButton_caption)#",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.CreateRecordRequest",
						"params": {
							"entityName": "Opportunity",
							"defaultValues": [
								{
									"attributeName": "Account",
									"value": "$Parameter_3pxm4wn"
								}
							]
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "OpportunitiesByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerRefreshButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(OpportunitiesByCustomerRefreshButton_caption)#",
					"icon": "reload-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.LoadDataRequest",
						"params": {
							"config": {
								"loadType": "reload",
								"useLastLoadParameters": true
							},
							"dataSourceName": "OpportunitiesByCustomerListDS"
						}
					},
					"visible": true,
					"clickMode": "default"
				},
				"parentName": "OpportunitiesByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerSettingsButton",
				"values": {
					"type": "crt.Button",
					"caption": "#ResourceString(OpportunitiesByCustomerSettingsButton_caption)#",
					"icon": "actions-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clickMode": "menu",
					"menuItems": [],
					"visible": true
				},
				"parentName": "OpportunitiesByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerExportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(OpportunitiesByCustomerExportDataButton_caption)#",
					"icon": "export-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ExportDataGridToExcelRequest",
						"params": {
							"viewName": "OpportunitiesByCustomerList",
							"filters": "$GridDetail_qiohu6o | crt.ToCollectionFilters : 'GridDetail_qiohu6o' : $OpportunitiesByCustomerList_SelectionState"
						}
					},
					"visible": true
				},
				"parentName": "OpportunitiesByCustomerSettingsButton",
				"propertyName": "menuItems",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerImportDataButton",
				"values": {
					"type": "crt.MenuItem",
					"caption": "#ResourceString(OpportunitiesByCustomerImportDataButton_caption)#",
					"icon": "import-button-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "Opportunity"
						}
					},
					"visible": true
				},
				"parentName": "OpportunitiesByCustomerSettingsButton",
				"propertyName": "menuItems",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerSearchFilter",
				"values": {
					"type": "crt.SearchFilter",
					"placeholder": "#ResourceString(OpportunitiesByCustomerSearchFilter_placeholder)#",
					"iconOnly": true,
					"targetAttributes": [
						"GridDetail_qiohu6o"
					]
				},
				"parentName": "OpportunitiesByCustomerToolsFlexContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerListContainer",
				"values": {
					"type": "crt.GridContainer",
					"rows": "minmax(max-content, 32px)",
					"columns": [
						"minmax(32px, 1fr)",
						"minmax(32px, 1fr)"
					],
					"gap": {
						"columnGap": "large",
						"rowGap": "none"
					},
					"styles": {
						"overflow-x": "hidden"
					},
					"items": [],
					"visible": true,
					"color": "transparent",
					"borderRadius": "none",
					"padding": {
						"top": "none",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				},
				"parentName": "OpportunitiesByCustomerExpansionPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "OpportunitiesByCustomerList",
				"values": {
					"type": "crt.DataGrid",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 6
					},
					"items": "$GridDetail_qiohu6o",
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "OpportunitiesByCustomerListDS_Id",
					"columns": [
						{
							"id": "3f9ebb5c-bd21-6360-5878-56b6a00f8167",
							"code": "OpportunitiesByCustomerListDS_Title",
							"caption": "#ResourceString(OpportunitiesByCustomerListDS_Title)#",
							"dataValueType": 30,
							"width": 335
						},
						{
							"id": "30177b78-9e40-9751-0b3b-c1ba0e92b9d4",
							"code": "OpportunitiesByCustomerListDS_Stage",
							"path": "Stage",
							"caption": "#ResourceString(OpportunitiesByCustomerListDS_Stage)#",
							"dataValueType": 10,
							"referenceSchemaName": "OpportunityStage",
							"width": 232
						},
						{
							"id": "4b7cbd7f-83ac-2cc7-e749-0b30da18326c",
							"code": "OpportunitiesByCustomerListDS_Amount",
							"path": "Amount",
							"caption": "#ResourceString(OpportunitiesByCustomerListDS_Amount)#",
							"dataValueType": 32,
							"width": 174
						},
						{
							"id": "2b1794d2-3176-c682-c44f-fecb12655cae",
							"code": "OpportunitiesByCustomerListDS_Owner",
							"path": "Owner",
							"caption": "#ResourceString(OpportunitiesByCustomerListDS_Owner)#",
							"dataValueType": 10,
							"referenceSchemaName": "Contact",
							"width": 212
						},
						{
							"id": "e252ad8b-286d-8b88-422d-715ce75ed0ea",
							"code": "OpportunitiesByCustomerListDS_DueDate",
							"path": "DueDate",
							"caption": "#ResourceString(OpportunitiesByCustomerListDS_DueDate)#",
							"dataValueType": 8,
							"width": 177
						}
					],
					"features": {
						"editable": {
							"enable": true,
							"itemsCreation": false
						}
					},
					"selectionState": "$OpportunitiesByCustomerList_SelectionState",
					"_selectionOptions": {
						"attribute": "OpportunitiesByCustomerList_SelectionState"
					}
				},
				"parentName": "OpportunitiesByCustomerListContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NextStepsTabContainer",
				"values": {
					"type": "crt.TabContainer",
					"tools": [],
					"items": [],
					"caption": "#ResourceString(NextStepsTabContainer_caption)#",
					"iconPosition": "left-icon",
					"visible": true,
					"icon": "task-tab-icon"
				},
				"parentName": "CardToggleTabPanel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NextStepsTabContainerHeaderContainer",
				"values": {
					"type": "crt.FlexContainer",
					"direction": "row",
					"alignItems": "center",
					"items": []
				},
				"parentName": "NextStepsTabContainer",
				"propertyName": "tools",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NextStepsTabContainerHeaderLabel",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(NextStepsTabContainerHeaderLabel_caption)#)#",
					"labelType": "headline-3",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "#0D2E4E",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "NextStepsTabContainerHeaderContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "AddNextStepsButton",
				"values": {
					"type": "crt.Button",
					"icon": "add-button-icon",
					"iconPosition": "only-icon",
					"color": "default",
					"size": "medium",
					"clicked": {
						"request": "crt.AddNextStepRequest",
						"params": {
							"entityName": "Activity"
						}
					}
				},
				"parentName": "NextStepsTabContainerHeaderContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "NextSteps",
				"values": {
					"type": "crt.NextSteps",
					"masterSchemaId": "$Id",
					"layoutConfig": {
						"colSpan": 2,
						"column": 1,
						"row": 1,
						"rowSpan": 1
					},
					"masterSchemaName": "Lead"
				},
				"parentName": "NextStepsTabContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"LookupAttribute_1prxdry": {
						"modelConfig": {
							"path": "PDS.SalesChannel"
						}
					},
					"NumberAttribute_6nr0xsg": {
						"modelConfig": {
							"path": "PDS.Budget"
						}
					},
					"LookupAttribute_wl8vj23": {
						"modelConfig": {
							"path": "PDS.Opportunity"
						}
					},
					"DateTimeAttribute_q8nrp29": {
						"modelConfig": {
							"path": "PDS.DecisionDate"
						}
					},
					"LookupAttribute_kyciimy": {
						"modelConfig": {
							"path": "PDS.SalesOwner"
						}
					},
					"StringAttribute_cdi5zf7": {
						"modelConfig": {
							"path": "PDS.BusinessCase"
						}
					},
					"StringAttribute_s73ygx6": {
						"modelConfig": {
							"path": "PDS.ProductSuggestions"
						}
					},
					"ProductsList": {
						"isCollection": true,
						"modelConfig": {
							"path": "ProductsListDS"
						},
						"viewModelConfig": {
							"attributes": {
								"ProductsListDS_Product": {
									"modelConfig": {
										"path": "ProductsListDS.Product"
									}
								},
								"ProductsListDS_ProductPrice": {
									"modelConfig": {
										"path": "ProductsListDS.ProductPrice"
									}
								},
								"ProductsListDS_Id": {
									"modelConfig": {
										"path": "ProductsListDS.Id"
									}
								}
							}
						}
					},
					"GridDetail_q6k1kvr": {
						"isCollection": true,
						"modelConfig": {
							"path": "StageHistoryListDS"
						},
						"viewModelConfig": {
							"attributes": {
								"StageHistoryListDS_QualifyStatus": {
									"modelConfig": {
										"path": "StageHistoryListDS.QualifyStatus"
									}
								},
								"StageHistoryListDS_StartDate": {
									"modelConfig": {
										"path": "StageHistoryListDS.StartDate"
									}
								},
								"StageHistoryListDS_DueDate": {
									"modelConfig": {
										"path": "StageHistoryListDS.DueDate"
									}
								},
								"StageHistoryListDS_ModifiedBy": {
									"modelConfig": {
										"path": "StageHistoryListDS.ModifiedBy"
									}
								},
								"StageHistoryListDS_Id": {
									"modelConfig": {
										"path": "StageHistoryListDS.Id"
									}
								}
							}
						}
					},
					"GridDetail_yoxos8p": {
						"isCollection": true,
						"modelConfig": {
							"path": "LeadsByCustomerListDS"
						},
						"viewModelConfig": {
							"attributes": {
								"LeadsByCustomerListDS_LeadName": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.LeadName"
									}
								},
								"LeadsByCustomerListDS_LeadType": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.LeadType"
									}
								},
								"LeadsByCustomerListDS_QualifyStatus": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.QualifyStatus"
									}
								},
								"LeadsByCustomerListDS_Owner": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.Owner"
									}
								},
								"LeadsByCustomerListDS_CreatedOn": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.CreatedOn"
									}
								},
								"LeadsByCustomerListDS_Id": {
									"modelConfig": {
										"path": "LeadsByCustomerListDS.Id"
									}
								}
							}
						}
					},
					"GridDetail_qiohu6o": {
						"isCollection": true,
						"modelConfig": {
							"path": "OpportunitiesByCustomerListDS"
						},
						"viewModelConfig": {
							"attributes": {
								"OpportunitiesByCustomerListDS_Title": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.Title"
									}
								},
								"OpportunitiesByCustomerListDS_Stage": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.Stage"
									}
								},
								"OpportunitiesByCustomerListDS_Amount": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.Amount"
									}
								},
								"OpportunitiesByCustomerListDS_Owner": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.Owner"
									}
								},
								"OpportunitiesByCustomerListDS_DueDate": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.DueDate"
									}
								},
								"OpportunitiesByCustomerListDS_Id": {
									"modelConfig": {
										"path": "OpportunitiesByCustomerListDS.Id"
									}
								}
							}
						}
					},
					"LookupAttribute_mfwvuqd": {
						"modelConfig": {
							"path": "PDS.LeadDisqualifyReason"
						}
					},
					"StringAttribute_1zhbdlz": {
						"modelConfig": {
							"path": "PDS.ClosingDetails"
						}
					},
					"NumberAttribute_sgdzxor": {
						"modelConfig": {
							"path": "PDS.PredictiveScore"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"ProductsListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "LeadProduct",
							"attributes": {
								"Product": {
									"path": "Product"
								},
								"ProductPrice": {
									"type": "ForwardReference",
									"path": "Product.Price"
								}
							}
						}
					},
					"StageHistoryListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "LeadInQualifyStatus",
							"attributes": {
								"QualifyStatus": {
									"path": "QualifyStatus"
								},
								"StartDate": {
									"path": "StartDate"
								},
								"DueDate": {
									"path": "DueDate"
								},
								"ModifiedBy": {
									"path": "ModifiedBy"
								}
							}
						}
					},
					"LeadsByCustomerListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Lead",
							"attributes": {
								"LeadName": {
									"path": "LeadName"
								},
								"LeadType": {
									"path": "LeadType"
								},
								"QualifyStatus": {
									"path": "QualifyStatus"
								},
								"Owner": {
									"path": "Owner"
								},
								"CreatedOn": {
									"path": "CreatedOn"
								}
							}
						}
					},
					"OpportunitiesByCustomerListDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Opportunity",
							"attributes": {
								"Title": {
									"path": "Title"
								},
								"Stage": {
									"path": "Stage"
								},
								"Amount": {
									"path": "Amount"
								},
								"Owner": {
									"path": "Owner"
								},
								"DueDate": {
									"path": "DueDate"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dependencies"
				],
				"values": {
					"ProductsListDS": [
						{
							"attributePath": "Lead",
							"relationPath": "PDS.Id"
						}
					],
					"StageHistoryListDS": [
						{
							"attributePath": "Lead",
							"relationPath": "PDS.Id"
						}
					],
					"LeadsByCustomerListDS": [
						{
							"attributePath": "QualifiedAccount",
							"relationPath": "PDS.QualifiedAccount"
						}
					],
					"OpportunitiesByCustomerListDS": [
						{
							"attributePath": "Account",
							"relationPath": "PDS.QualifiedAccount"
						}
					]
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

