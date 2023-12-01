﻿[
	{
		"operation": "insert",
		"name": "settings",
		"values": {
			"entitySchemaName": "Contact",
			"settingsType": "RecordPage",
			"localizableStrings": {
				"primaryColumnSetContact_caption": "Contact info",
				"ContactCommunicationDetailEmbeddedDetailContact_caption": "Contact communication options ",
				"ContactAddressDetailV2EmbeddedDetailContact_caption": "Contact addresses",
				"jobColumnSetContact_caption": "Current employment",
				"ContactAnniversaryDetailV2EmbeddedDetailContact_caption": "Noteworthy events for contact",
				"ActivityDetailV2StandartDetailContact_caption": "Activities",
				"SocialMessageDetailCaptionContact_caption": "Feed"
			},
			"columnSets": [],
			"operation": "insert",
			"details": [],
			"diffV2": "[{\"operation\":\"remove\",\"name\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout_Number\"},{\"operation\":\"remove\",\"name\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout_CommunicationType\"},{\"operation\":\"insert\",\"name\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout_LaunchNumber\",\"parentName\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout\",\"propertyName\":\"fields\",\"values\":{\"type\":\"ViewField\",\"value\":\"$Number\",\"label\":{\"value\":\"$CommunicationType\"},\"launchConfig\":{\"name\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout_LaunchConfig\",\"bindingColumn\":\"CommunicationType\",\"binding\":{\"ee1c85c3-cfcb-df11-9b2a-001d60e938c6\":\"email\",\"d4a2dc80-30ca-df11-9b2a-001d60e938c6\":\"phone\",\"2b387201-67cc-df11-9b2a-001d60e938c6\":\"phone\",\"6a3fb10c-67cc-df11-9b2a-001d60e938c6\":\"phone\",\"9a7ab41b-67cc-df11-9b2a-001d60e938c6\":\"phone\",\"0da6a26b-d7bc-df11-b00f-001d60e938c6\":\"phone\",\"21c0d693-9a52-43fa-b7f1-c6d8b53975d4\":\"phone\",\"3dddb3cc-53ee-49c4-a71f-e9e257f59e49\":\"phone\",\"e9d91e45-8d92-4e38-95a0-ef8aa28c9e7a\":\"phone\",\"6a8ba927-67cc-df11-9b2a-001d60e938c6\":\"uri\"}}}},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_Address\"},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_AddressType\"},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_City\"},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_Region\"},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_Country\"},{\"operation\":\"remove\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_Zip\"},{\"operation\":\"insert\",\"name\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout_AddressConcat\",\"parentName\":\"ContactAddressDetailV2EmbeddedDetail_ItemLayout\",\"propertyName\":\"fields\",\"values\":{\"type\":\"ViewField\",\"value\":\"#Concat($Address,$City,$Region,$Zip,$Country,\\\", \\\")\",\"label\":{\"value\":\"$AddressType\"},\"launchConfig\":{\"name\":\"ContactCommunicationDetailEmbeddedDetail_ItemLayout_LaunchConfig\",\"type\":\"map\"}}}]"
		}
	},
	{
		"operation": "insert",
		"name": "primaryColumnSet",
		"values": {
			"items": [],
			"rows": 1,
			"entitySchemaName": "Contact",
			"caption": "primaryColumnSetContact_caption",
			"operation": "insert",
			"position": 0
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "eb04facc-0b61-43a4-983a-8c114eec6d1b",
		"values": {
			"row": 0,
			"content": "Full name",
			"columnName": "Name",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "9a4cff61-0594-439e-8b94-874adbea8b61",
		"values": {
			"row": 1,
			"content": "Account",
			"columnName": "Account",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "primaryColumnSet",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "ContactCommunicationDetailEmbeddedDetail",
		"values": {
			"items": [],
			"rows": 1,
			"isDetail": true,
			"filter": {
				"detailColumn": "Contact",
				"masterColumn": "Id"
			},
			"detailSchemaName": "ContactCommunicationDetail",
			"entitySchemaName": "ContactCommunication",
			"caption": "ContactCommunicationDetailEmbeddedDetailContact_caption",
			"operation": "insert",
			"position": 1
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "4e5359c4-9805-4850-b6b5-9da6a38f10ce",
		"values": {
			"row": 1,
			"content": "Number",
			"columnName": "Number",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "ContactCommunicationDetailEmbeddedDetail",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "1a7c0d7f-50f4-48d7-ad5a-f7cf14258271",
		"values": {
			"row": 0,
			"content": "Type",
			"columnName": "CommunicationType",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactCommunicationDetailEmbeddedDetail",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "ContactAddressDetailV2EmbeddedDetail",
		"values": {
			"items": [],
			"rows": 1,
			"isDetail": true,
			"filter": {
				"detailColumn": "Contact",
				"masterColumn": "Id"
			},
			"detailSchemaName": "ContactAddressDetailV2",
			"entitySchemaName": "ContactAddress",
			"caption": "ContactAddressDetailV2EmbeddedDetailContact_caption",
			"operation": "insert",
			"position": 2
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 2
	},
	{
		"operation": "insert",
		"name": "43f1ac43-ddd2-4389-8ccf-782a89bf47c9",
		"values": {
			"row": 0,
			"content": "Address type",
			"columnName": "AddressType",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "df7d53ec-885a-43b7-99ec-14f0e9f36d78",
		"values": {
			"row": 1,
			"content": "Address",
			"columnName": "Address",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "7af60027-7759-456d-848f-de3a7bbd727a",
		"values": {
			"row": 2,
			"content": "City",
			"columnName": "City",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 2
	},
	{
		"operation": "insert",
		"name": "0bc9e17d-d39b-4082-886c-0693181175a4",
		"values": {
			"row": 3,
			"content": "State/province",
			"columnName": "Region",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 3
	},
	{
		"operation": "insert",
		"name": "7fd1d967-c76d-4523-87b8-ea32b6f6da3c",
		"values": {
			"row": 4,
			"content": "Country",
			"columnName": "Country",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 4
	},
	{
		"operation": "insert",
		"name": "322bdac5-8965-4571-8ef1-180e1da25634",
		"values": {
			"row": 5,
			"content": "ZIP/postal code",
			"columnName": "Zip",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "ContactAddressDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 5
	},
	{
		"operation": "insert",
		"name": "jobColumnSet",
		"values": {
			"items": [],
			"rows": 1,
			"entitySchemaName": "Contact",
			"caption": "jobColumnSetContact_caption",
			"operation": "insert",
			"position": 3
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 3
	},
	{
		"operation": "insert",
		"name": "2883d472-fa1c-469a-b83f-ac45fa50c616",
		"values": {
			"row": 1,
			"content": "Department",
			"columnName": "Department",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "jobColumnSet",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "6b01ece7-8756-470c-85da-afc17498fcba",
		"values": {
			"row": 2,
			"content": "Full job title",
			"columnName": "JobTitle",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "jobColumnSet",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "b403e8ed-1be7-4fdb-b188-f810b7908132",
		"values": {
			"row": 0,
			"content": "Job title",
			"columnName": "Job",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "jobColumnSet",
		"propertyName": "items",
		"index": 2
	},
	{
		"operation": "insert",
		"name": "ContactAnniversaryDetailV2EmbeddedDetail",
		"values": {
			"items": [],
			"rows": 1,
			"isDetail": true,
			"filter": {
				"detailColumn": "Contact",
				"masterColumn": "Id"
			},
			"detailSchemaName": "ContactAnniversaryDetailV2",
			"entitySchemaName": "ContactAnniversary",
			"caption": "ContactAnniversaryDetailV2EmbeddedDetailContact_caption",
			"operation": "insert",
			"position": 4
		},
		"parentName": "settings",
		"propertyName": "columnSets",
		"index": 4
	},
	{
		"operation": "insert",
		"name": "42bf4ab2-5129-4254-a6a9-de73d7aca21a",
		"values": {
			"row": 1,
			"content": "Date",
			"columnName": "Date",
			"dataValueType": 8,
			"operation": "insert"
		},
		"parentName": "ContactAnniversaryDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "2ec8b723-edba-4ca0-bd00-006db58a5d13",
		"values": {
			"row": 0,
			"content": "Type",
			"columnName": "AnniversaryType",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "ContactAnniversaryDetailV2EmbeddedDetail",
		"propertyName": "items",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "ActivityDetailV2StandartDetail",
		"values": {
			"caption": "ActivityDetailV2StandartDetailContact_caption",
			"entitySchemaName": "Activity",
			"filter": {
				"detailColumn": "Contact",
				"masterColumn": "Id"
			},
			"detailSchemaName": "ActivityDetailV2",
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "details",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "SocialMessageDetailV2StandartDetail",
		"values": {
			"caption": "SocialMessageDetailCaptionContact_caption",
			"entitySchemaName": "SocialMessage",
			"showForVisibleModule": true,
			"filter": {
				"detailColumn": "EntityId",
				"masterColumn": "Id"
			},
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "details",
		"index": 1
	}
]