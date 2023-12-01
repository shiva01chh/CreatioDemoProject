Terrasoft.configuration.Structures["BaseServiceModelRelationshipDetail"] = {innerHierarchyStack: ["BaseServiceModelRelationshipDetail"], structureParent: "BaseGridDetailV2"};
define('BaseServiceModelRelationshipDetailStructure', ['BaseServiceModelRelationshipDetailResources'], function(resources) {return {schemaUId:'d20907cd-a859-435d-a2ea-c5c8d80c2b19',schemaCaption: "BaseServiceModelRelationshipDetail", parentSchemaName: "BaseGridDetailV2", packageName: "ServiceModel", schemaName:'BaseServiceModelRelationshipDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("BaseServiceModelRelationshipDetail", ["terrasoft", "ConfigurationGrid", "ConfigurationGridGenerator",
	"ConfigurationGridUtilities"],
	function(Terrasoft) {
		return {
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"className": "Terrasoft.ConfigurationGrid",
						"generator": "ConfigurationGridGenerator.generatePartial",
						"generateControlsConfig": {bindTo: "generateActiveRowControlsConfig"},
						"changeRow": {"bindTo": "changeRow"},
						"unSelectRow": {"bindTo": "unSelectRow"},
						"onGridClick": {"bindTo": "onGridClick"},
						"initActiveRowKeyMap": {"bindTo": "initActiveRowKeyMap"},
						"activeRowActions": [
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "save",
								"markerValue": "save",
								"imageConfig": {"bindTo": "Resources.Images.SaveIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "cancel",
								"markerValue": "cancel",
								"imageConfig": {"bindTo": "Resources.Images.CancelIcon"}
							},
							{
								"className": "Terrasoft.Button",
								"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
								"tag": "remove",
								"markerValue": "remove",
								"imageConfig": {"bindTo": "Resources.Images.RemoveIcon"}
							}
						],
						"listedZebra": true,
						"activeRowAction": {"bindTo": "onActiveRowAction"}
					}
				}
			]/**SCHEMA_DIFF*/,
			mixins: {
				/**
				 * @class ConfigurationGridUtilities ########### ####### ###### ############## #######.
				 */
				ConfigurationGridUtilities: "Terrasoft.ConfigurationGridUtilities"
			},
			attributes: {
				"IsEditable": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": true
				}

			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseGridDetail#updateDetail
				 * @overridden
				 */
				updateDetail: function() {
					this.callParent(arguments);
					this.reloadGridData();
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#prepareResponseCollection
				 * @overridden
				 */
				prepareResponseCollection: function(collection) {
					this.callParent(arguments);
					collection.each(function(item) {
						var dependencyCategory = item.get("DependencyCategory");
						var dependencyTypeCategory = item.get("DependencyTypeCategory");
						if (dependencyCategory != null && dependencyTypeCategory != null &&
							dependencyTypeCategory.value !== dependencyCategory.value) {
							var dependencyType = item.get("DependencyType");
							var reverseTypeName = item.get("LczReverseTypeName");
							dependencyType.displayValue = reverseTypeName;
						}
					}, this);
				},
				
				/**
				 * @inheritdoc Terrasoft.GridUtilities#initQueryColumns
				 * @overridden
				 */
				initQueryColumns: function(esq) {
					this.callParent(arguments);
					esq.addColumn("DependencyType.ReverseTypeName", "LczReverseTypeName");
				},

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilities#getCellControlsConfig
				 * @overridden
				 */
				getCellControlsConfig: function(entitySchemaColumn) {
					var columnName = entitySchemaColumn.name;
					var enabled = (entitySchemaColumn.usageType !== Terrasoft.EntitySchemaColumnUsageType.None) &&
						!this.Ext.Array.contains(this.systemColumns, columnName);
					var config = {
						itemType: Terrasoft.ViewItemType.MODEL_ITEM,
						name: columnName,
						labelConfig: {visible: false},
						caption: entitySchemaColumn.caption,
						enabled: enabled
					};
					if (columnName === "DependencyType") {
						config.prepareList = {"bindTo": "getDependencyTypeList"};
					}
					if (columnName === "DependencyCategory") {
						config.enabled = {"bindTo": "getDependencyCategoryEnabled"};
					}
					if (entitySchemaColumn.dataValueType === Terrasoft.DataValueType.LOOKUP) {
						config.showValueAsLink = false;
					}
					if (entitySchemaColumn.dataValueType !== Terrasoft.DataValueType.DATE_TIME &&
						entitySchemaColumn.dataValueType !== Terrasoft.DataValueType.BOOLEAN) {
						config.focused = {"bindTo": "Is" + columnName + "Focused"};
					}
					return config;
				},
				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
				 * @overridden
				 */
				getFilterDefaultColumnName: function() {
					return "DependencyCategory";
				}
			}
		};
	});


