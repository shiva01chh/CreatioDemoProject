define("ForecastHistDrilldown", ["terrasoft", "ext-base", "ForecastHistDrilldownResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.ForecastHistDrilldown", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.ForecastHistDrilldown",
			singleton: true,
			uId: "91e9246b-3256-19c6-1751-831c815fb4ac",
			name: "ForecastHistDrilldown",
			caption: resources.localizableStrings.ForecastHistDrilldownCaption,
			administratedByRecords: false,
			administratedByOperations: false,
			isTrackChangesInDB: false,
			useMasterRecordRights: false,
			masterRecordSchemaName: "",
			primaryColumnName: "Id",
			columns: {
				Id: {
					uId: "ae0e45ca-c495-4fe7-a39d-3ab7278e1617",
					name: "Id",
					caption: resources.localizableStrings.IdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isRequired: true,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "AutoGuid"
					}
				},
				CreatedOn: {
					uId: "e80190a5-03b2-4095-90f7-a193a960adee",
					name: "CreatedOn",
					caption: resources.localizableStrings.CreatedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDateTime"
					}
				},
				CreatedBy: {
					uId: "ebf6bb93-8aa6-4a01-900d-c6ea67affe21",
					name: "CreatedBy",
					caption: resources.localizableStrings.CreatedByCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentUserContact"
					}
				},
				ModifiedOn: {
					uId: "9928edec-4272-425a-93bb-48743fee4b04",
					name: "ModifiedOn",
					caption: resources.localizableStrings.ModifiedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentDateTime"
					}
				},
				ModifiedBy: {
					uId: "3015559e-cbc6-406a-88af-07f7930be832",
					name: "ModifiedBy",
					caption: resources.localizableStrings.ModifiedByCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 1,
					isInherited: true,
					isValueCloneable: false,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Contact",
					referenceSchema: {
						name: "Contact",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.SYSTEM_VALUE,
						value: "CurrentUserContact"
					}
				},
				ProcessListeners: {
					uId: "3fabd836-6a53-4d8d-9069-6df88d9dae1e",
					name: "ProcessListeners",
					caption: resources.localizableStrings.ProcessListenersCaption,
					dataValueType: Terrasoft.DataValueType.INTEGER,
					usageType: 2,
					isInherited: true,
					isValueCloneable: true,
					isSensitiveData: false
				},
				DeletedOn: {
					uId: "e6bfecae-a833-9e0f-5424-a683b32a0f0e",
					name: "DeletedOn",
					caption: resources.localizableStrings.DeletedOnCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Snapshot: {
					uId: "bcc6ad53-abde-5966-cdce-e80bf14370c5",
					name: "Snapshot",
					caption: resources.localizableStrings.SnapshotCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ForecastSnapshot",
					referenceSchema: {
						name: "ForecastSnapshot",
						primaryColumnName: "Id",
						primaryDisplayColumnName: null
					}
				},
				EntityDisplayValue: {
					uId: "eb777a75-3cff-86dd-e6d8-a64c40ef56f7",
					name: "EntityDisplayValue",
					caption: resources.localizableStrings.EntityDisplayValueCaption,
					dataValueType: Terrasoft.DataValueType.TEXT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 250
				},
				RefEntityId: {
					uId: "66d37ead-7e44-7c50-63ab-664fb2d27581",
					name: "RefEntityId",
					caption: resources.localizableStrings.RefEntityIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				EntityId: {
					uId: "c0b61af4-d1b8-4cef-0cf9-02977bd296d2",
					name: "EntityId",
					caption: resources.localizableStrings.EntityIdCaption,
					dataValueType: Terrasoft.DataValueType.GUID,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				Period: {
					uId: "cd64cd6e-b55d-0c98-cfb8-e6b65a90f8a4",
					name: "Period",
					caption: resources.localizableStrings.PeriodCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Period",
					referenceSchema: {
						name: "Period",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name",
						primaryOrderColumnName: "StartDate"
					}
				},
				Column: {
					uId: "0ee2f18b-35bd-2dc7-66a6-b1693bff01d7",
					name: "Column",
					caption: resources.localizableStrings.ColumnCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "ForecastColumn",
					referenceSchema: {
						name: "ForecastColumn",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Title"
					}
				},
				Value: {
					uId: "c4aa693e-818c-cc0c-9d62-7a80408692c3",
					name: "Value",
					caption: resources.localizableStrings.ValueCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 18,
					precision: 2
				}
			}
		});
		return Terrasoft.ForecastHistDrilldown;
	});