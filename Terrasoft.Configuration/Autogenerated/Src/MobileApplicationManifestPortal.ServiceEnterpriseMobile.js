{
	"SyncOptions": {
		"ModelDataImportConfig": [
			{
				"Name": "Case",
				"SyncColumns": [
					"ServicePact",
					"ServiceItem",
					"ConfItem"
				]
			},
			{
				"Name": "ServicePact",
				"SyncColumns": []
			},
			{
				"Name": "ServiceItem",
				"SyncColumns": []
			},
			{
				"Name": "ConfItem",
				"SyncColumns": []
			}
		]
	},
	"Models": {
		"Case": {
			"RequiredModels": [
				"ServicePact",
				"ServiceItem",
				"ConfItem"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileCaseRecordPageSettingsPortal"
			]
		}
	}
}