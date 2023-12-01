Terrasoft.configuration.Structures["MobileCaseRecordPageSettingsPortal"] = {innerHierarchyStack: ["MobileCaseRecordPageSettingsPortalCaseMobile", "MobileCaseRecordPageSettingsPortal"]};

define('MobileCaseRecordPageSettingsPortalStructure', ['MobileCaseRecordPageSettingsPortalResources'], function(resources) {return {schemaUId:'dc28edc8-3522-46c3-894a-a73b9f4ba2fe',schemaCaption: "MobileCaseRecordPageSettingsPortal", parentSchemaName: "MobileCaseRecordPageSettingsPortalCaseMobile", packageName: "ServiceEnterpriseMobile", schemaName:'MobileCaseRecordPageSettingsPortal',parentSchemaUId:'c67a26d8-041c-47df-ab0a-5b54f12d0ded',extendParent:true,type:Terrasoft.SchemaType.NONE,entitySchema:'',name:'',extend:"MobileCaseRecordPageSettingsPortalCaseMobile",schemaDifferences:function(){

}};});
define('MobileCaseRecordPageSettingsPortalCaseMobileResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
[
	{
		"operation": "insert",
		"name": "settings",
		"values": {
			"entitySchemaName": "Case",
			"settingsType": "RecordPage",
			"details": [],
			"columnSets": [],
			"localizableStrings": {
				"SocialMessageDetailCaptionCase_caption": "Feed",
				"primaryColumnSetCase_caption": "General information",
				"CaseMessageHistoryDetailStandardDetailCase_caption": "Processing",
				"FileDetailV2EmbeddedDetailCase_caption": "Attachments"
			},
			"operation": "insert",
			"diffV2": "[{\"operation\":\"remove\",\"name\":\"Case_Action_Save_Button\"},{\"operation\":\"remove\",\"name\":\"Case_RelatedTab\"},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_Symptoms\",\"values\":{\"maxLines\":5,\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_Status\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_ResponseDate\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_SolutionDate\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_Category\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"ViewConfig\",\"values\":{\"title\":\"$Number\"}},{\"operation\":\"insert\",\"name\":\"Case_Model_Column_Number\",\"parentName\":\"Case_Model\",\"propertyName\":\"columns\",\"values\":{\"alias\":\"Case.Number\",\"orderDirection\":0,\"orderPosition\":-1,\"isVisible\":true,\"expression\":{\"expressionType\":0,\"columnPath\":\"Number\"}}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab\",\"values\":{\"position\":1}},{\"operation\":\"merge\",\"name\":\"FileDetailV2EmbeddedDetail_Tab_Body\",\"values\":{\"changeMode\":1}},{\"operation\":\"insert\",\"name\":\"CaseMessageHistoryDetailStandardDetail_Tab\",\"parentName\":\"Case_Tabs\",\"propertyName\":\"items\",\"values\":{\"position\":0,\"text\":\"#ResourceString(CaseMessageHistoryDetailStandardDetailCase_caption)\",\"body\":{}}},{\"operation\":\"insert\",\"name\":\"CaseMessageHistoryDetailStandardDetail_Tab_Body\",\"parentName\":\"CaseMessageHistoryDetailStandardDetail_Tab\",\"propertyName\":\"body\",\"values\":{\"type\":\"Messaging\",\"itemLayout\":\"\",\"controller\":\"$Case.CaseMessageHistory\",\"enableAttachments\":true,\"enableMentions\":false,\"reverse\":true,\"changeMode\":7}},{\"operation\":\"merge\",\"name\":\"Case_Controllers\",\"values\":{\"CaseMessageHistory\":{}}},{\"operation\":\"insert\",\"name\":\"Case_Controllers_CaseMessageHistory_Controller\",\"parentName\":\"Case_Controllers\",\"propertyName\":\"CaseMessageHistory\",\"values\":{\"type\":\"CaseMessagingController\",\"model\":{}}},{\"operation\":\"insert\",\"name\":\"Case_Controllers_CaseMessageHistory_Model\",\"parentName\":\"Case_Controllers_CaseMessageHistory_Controller\",\"propertyName\":\"model\",\"values\":{\"type\":\"CaseMessagingModel\",\"parentFilter\":{\"parentColumnName\":\"Case\",\"masterColumnName\":\"Id\"},\"entityName\":\"CaseMessageHistory\",\"columns\":[]}},{\"operation\":\"insert\",\"name\":\"FileDetailV2EmbeddedDetail_Tab\",\"parentName\":\"Case_Tabs\",\"propertyName\":\"items\",\"values\":{\"position\":2,\"text\":\"#ResourceSystemString(Tab.Attachments)\",\"body\":{}}},{\"operation\":\"insert\",\"name\":\"FileDetailV2EmbeddedDetail_Tab_Body\",\"parentName\":\"FileDetailV2EmbeddedDetail_Tab\",\"propertyName\":\"body\",\"values\":{\"type\":\"Attachments\",\"controller\":\"$Case.CaseFile\",\"changeMode\":1}},{\"operation\":\"merge\",\"name\":\"Case_Controllers\",\"values\":{\"CaseFile\":{}}},{\"operation\":\"insert\",\"name\":\"Case_FileDetailV2EmbeddedDetail_Controller\",\"parentName\":\"Case_Controllers\",\"propertyName\":\"CaseFile\",\"values\":{\"type\":\"AttachmentsController\",\"editColumns\":[],\"model\":{},\"autoUpdateCacheEnabled\":false}},{\"operation\":\"insert\",\"name\":\"Case_FileDetailV2EmbeddedDetail_Model\",\"parentName\":\"Case_FileDetailV2EmbeddedDetail_Controller\",\"propertyName\":\"model\",\"values\":{\"type\":\"CaseAttachmentsModel\",\"parentColumnName\":\"Case\",\"masterColumnName\":\"Id\",\"entityName\":\"CaseFile\",\"columns\":[]}}]"
		}
	},
	{
		"operation": "insert",
		"name": "primaryColumnSet",
		"values": {
			"items": [],
			"rows": 1,
			"entitySchemaName": "Case",
			"caption": "primaryColumnSetCase_caption",
			"position": 0,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "e34dac1d-4d7e-48b9-b4ad-996174a81870",
		"values": {
			"row": 0,
			"content": "Description",
			"columnName": "Symptoms",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "c49421c4-137b-438e-bd96-225f04828cf2",
		"values": {
			"row": 1,
			"content": "Status",
			"columnName": "Status",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "a03325a6-6c0d-4bb4-83af-77750466adf1",
		"values": {
			"row": 2,
			"content": "Response time",
			"columnName": "ResponseDate",
			"dataValueType": 7,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 2
	},
	{
		"operation": "insert",
		"name": "2cbdcee3-acbc-4306-8375-fbd5a6a530a3",
		"values": {
			"row": 3,
			"content": "Resolution time",
			"columnName": "SolutionDate",
			"dataValueType": 7,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 3
	},
	{
		"operation": "insert",
		"name": "0b78f76a-2671-4144-8f06-974d2966276e",
		"values": {
			"row": 4,
			"content": "Category",
			"columnName": "Category",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 4
	},
	{
		"operation": "insert",
		"name": "FileDetailV2EmbeddedDetail",
		"values": {
			"items": [],
			"rows": 1,
			"isDetail": true,
			"filter": {
				"detailColumn": "Case",
				"masterColumn": "Id"
			},
			"detailSchemaName": "FileDetailV2",
			"entitySchemaName": "CaseFile",
			"caption": "FileDetailV2EmbeddedDetailCase_caption",
			"detailType": "File",
			"generator": {
				"xclass": "Terrasoft.FileAndLinksEmbeddedDetailGenerator"
			},
			"displaySeparator": false,
			"businessRules": [],
			"maxRows": 3,
			"position": 1,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "30fc2b24-684e-4fa4-9cb3-bcfa1e6fba97",
		"values": {
			"row": 0,
			"content": "Data",
			"columnName": "Data",
			"dataValueType": 13,
			"displayColumn": "Name",
			"label": "MobileConstantsFileLabel",
			"placeHolder": "MobileConstantsFileLabel",
			"operation": "insert"
		},
		"parentName": "FileDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "427ebb28-d33b-4de6-b54d-45bf939cd969",
		"values": {
			"row": 1,
			"content": "Type",
			"columnName": "Type",
			"dataValueType": 10,
			"hidden": true,
			"operation": "insert"
		},
		"parentName": "FileDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "db8b2bd4-a35e-4dbf-94e9-f009c1b0c498",
		"values": {
			"row": 2,
			"content": "Name",
			"columnName": "Name",
			"dataValueType": 1,
			"label": "MobileConstantsLinkLabel",
			"placeHolder": "MobileConstantsLinkLabel",
			"viewType": "url",
			"operation": "insert"
		},
		"parentName": "FileDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 2
	},
	{
		"operation": "insert",
		"name": "CaseFileFileAndLinksEditPageVisibilityRule",
		"values": {
			"ruleType": "Terrasoft.FileAndLinksBusinessRule",
			"operation": "insert"
		},
		"parentName": "FileDetailV2EmbeddedDetail",
		"propertyName": "businessRules",
		"index": 0
	}
]
[
	{
		"operation": "insert",
		"name": "29aca9c9-351c-4651-b1e7-a8416574a824",
		"values": {
			"row": 5,
			"content": "SLA",
			"columnName": "ServicePact",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 5
	},
	{
		"operation": "insert",
		"name": "83c3086f-7796-4ab4-a1c2-9ece2af8ab55",
		"values": {
			"row": 6,
			"content": "Service",
			"columnName": "ServiceItem",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 6
	},
	{
		"operation": "insert",
		"name": "e03abee3-cf2f-4074-b2a6-9eda0f60a1b7",
		"values": {
			"row": 7,
			"content": "Configuration item",
			"columnName": "ConfItem",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 7
	},
	{
		"operation": "merge",
		"name": "settings",
		"values": {
			"diffV2": "[{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_ServicePact\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_ServiceItem\",\"values\":{\"readOnly\":true}},{\"operation\":\"merge\",\"name\":\"Case_PrimaryTab_Body_primaryColumnSet_ConfItem\",\"values\":{\"readOnly\":true}}]"
		}
	}
]

