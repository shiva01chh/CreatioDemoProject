define("MLSimilarCase", ["terrasoft", "ext-base", "MLSimilarCaseResources"],
	function(Terrasoft, Ext, resources) {
		Ext.define("Terrasoft.data.models.MLSimilarCase", {
			extend: "Terrasoft.BaseEntitySchema",
			alternateClassName: "Terrasoft.MLSimilarCase",
			singleton: true,
			uId: "44bb92b4-4d75-34f2-8554-4c11b85272be",
			name: "MLSimilarCase",
			caption: resources.localizableStrings.MLSimilarCaseCaption,
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
				PredictionQuality: {
					uId: "c369279c-93e1-06fb-c931-93749605231a",
					name: "PredictionQuality",
					caption: resources.localizableStrings.PredictionQualityCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "MLPredictionQuality",
					referenceSchema: {
						name: "MLPredictionQuality",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					},
					defaultValue: {
						source: Terrasoft.EntitySchemaColumnDefSource.CONST,
						value: {
							value: "50cd941e-4bb0-4239-8bc4-99ebcf40a43d"
						}
					}
				},
				Score: {
					uId: "64bbb652-a85b-5e12-5072-8535d377cb7f",
					name: "Score",
					caption: resources.localizableStrings.ScoreCaption,
					dataValueType: Terrasoft.DataValueType.FLOAT,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					size: 20,
					precision: 4
				},
				PredictionDate: {
					uId: "d84b4aaa-d1bf-c69b-9987-c8453a36bf5c",
					name: "PredictionDate",
					caption: resources.localizableStrings.PredictionDateCaption,
					dataValueType: Terrasoft.DataValueType.DATE_TIME,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false
				},
				MLModel: {
					uId: "e709bc42-a654-c7fd-cccf-0b349bd63b43",
					name: "MLModel",
					caption: resources.localizableStrings.MLModelCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "MLModel",
					referenceSchema: {
						name: "MLModel",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Name"
					}
				},
				SimilarCase: {
					uId: "6f1637aa-79e8-8dff-e529-4eee74d7e52c",
					name: "SimilarCase",
					caption: resources.localizableStrings.SimilarCaseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Case",
					referenceSchema: {
						name: "Case",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Number"
					}
				},
				ParentCase: {
					uId: "33d44497-c431-4f89-6b9a-6ef9f3465463",
					name: "ParentCase",
					caption: resources.localizableStrings.ParentCaseCaption,
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					usageType: 0,
					isInherited: false,
					isValueCloneable: true,
					isSensitiveData: false,
					isLookup: true,
					referenceSchemaName: "Case",
					referenceSchema: {
						name: "Case",
						primaryColumnName: "Id",
						primaryDisplayColumnName: "Number"
					}
				}
			}
		});
		return Terrasoft.MLSimilarCase;
	});