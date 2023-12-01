[
	{
		"operation": "insert",
		"name": "settings",
		"values": {
			"entitySchemaName": "Case",
			"settingsType": "GridPage",
			"items": [],
			"subtitleItems": [],
			"groupItems": [],
			"operation": "insert",
			"localizableStrings": {},
			"diffV2": "[{\"operation\":\"insert\",\"name\":\"Case_Model_Column_RegisteredOn\",\"parentName\":\"Case_Model\",\"propertyName\":\"columns\",\"values\":{\"alias\":\"Case.RegisteredOn\",\"orderDirection\":2,\"orderPosition\":0,\"isVisible\":true,\"expression\":{\"expressionType\":0,\"columnPath\":\"RegisteredOn\"}}},{\"operation\":\"merge\",\"name\":\"Case_Controller\",\"values\":{\"searchExpressions\":[{\"name\":\"Case_Controller_SearchExpression_Number\",\"leftCondition\":\"Number\"},{\"name\":\"Case_Controller_SearchExpression_Symptoms\",\"leftCondition\":\"Symptoms\"}]}},{\"operation\":\"insert\",\"name\":\"Case_SortOptions_RegisteredOn\",\"propertyName\":\"sortOptions\",\"parentName\":\"Case_ListScreen_Tools_ListSortToolItem\",\"values\":{\"property\":\"RegisteredOn\"}},{\"operation\":\"merge\",\"name\":\"Case_ListItem_Body_Symptoms\",\"values\":{\"label\":{\"visible\":false}}}]"
		}
	},
	{
		"operation": "insert",
		"name": "f8045403-7580-45e2-bd33-a6795f9362f6",
		"values": {
			"row": 0,
			"content": "Number",
			"columnName": "Number",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "items",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "e5615adf-f7d9-4e47-b1d3-ce374494fe4b",
		"values": {
			"row": 0,
			"content": "Status",
			"columnName": "Status",
			"dataValueType": 10,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "subtitleItems",
		"index": 0
	},
	{
		"operation": "insert",
		"name": "17f82aca-6ee5-4146-9a5c-29a95b5e9be4",
		"values": {
			"row": 1,
			"content": "Resolution time",
			"columnName": "SolutionDate",
			"dataValueType": 7,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "subtitleItems",
		"index": 1
	},
	{
		"operation": "insert",
		"name": "7d7a0de3-94b3-4b3d-bed0-56f1da3f1e08",
		"values": {
			"row": 0,
			"content": "Description",
			"columnName": "Symptoms",
			"dataValueType": 1,
			"operation": "insert"
		},
		"parentName": "settings",
		"propertyName": "groupItems",
		"index": 0
	}
]