﻿Terrasoft.configuration.Structures["DcmVersionsDetail"] = {innerHierarchyStack: ["DcmVersionsDetail"], structureParent: "ProcessVersionsDetail"};
define('DcmVersionsDetailStructure', ['DcmVersionsDetailResources'], function(resources) {return {schemaUId:'4d131ab8-b0b1-459c-b566-8b4230d72ff6',schemaCaption: "DcmVersionsDetail", parentSchemaName: "ProcessVersionsDetail", packageName: "DcmLibrary", schemaName:'DcmVersionsDetail',parentSchemaUId:'d7b6b0ae-2b7e-43d3-845b-d8eebaaf9f14',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Page schema for dcm versions detail.
 * Parent: ProcessVersionsDetail.
 */
define("DcmVersionsDetail", ["DcmVersionsDetailResources"],
	function() {
		return {

			/**
			 * Entity schema name.
			 * @type {String}
			 */
			entitySchemaName: "VwSysDcmLib",
			methods: {

				/**
				 * @inheritdoc Terrasoft.GridUtilities#initQueryColumns
				 * @overridden
				 */
				initQueryColumns: function(esq) {
					this.callParent(arguments);
					esq.addColumn("Filters", "SerializedFilters");
					esq.addColumn("StageColumnUId", "SchemaStageColumnUId");
				},

				/**
				 * @inheritdoc ProcessVersionsDetail#setActiveVersion
				 * @override
				 */
				setActiveVersion: function() {
					this.showBodyMask();
					const activeRow = this.getActiveRow();
					const newVersionUId = activeRow.get("UId");
					const newVersionId = this.get("ActiveRow");
					const previousVersionId = this.get("MasterRecordId");
					const versionChangeInfo = {
						previousVersionId: previousVersionId,
						activeVersionId: newVersionId
					};
					const filters = activeRow.get("SerializedFilters");
					const stageColumnUId = activeRow.get("SchemaStageColumnUId");
					const callback = function(response, errorMessage) {
						if (errorMessage) {
							this.hideBodyMask();
							this.showInformationDialog(errorMessage);
						} else {
							this.onActiveVersionChanged(versionChangeInfo);
						}
					};
					const dcmSettingsId = this._findDcmSettingsId(newVersionUId);
					const config = {
						schemaUId: newVersionUId,
						filters: filters,
						stageColumnUId: stageColumnUId,
						dcmSettingsId: dcmSettingsId
					};
					Terrasoft.DcmSchemaManager.setIsActualVersion(config, callback, this);
				},

				/**
				 * @inheritdoc ProcessVersionsDetail#openProcessDesigner
				 * @override
				 */
				openProcessDesigner: function(processSchemaUId) {
					const schemaUId = processSchemaUId || this.get("ActiveRow");
					Terrasoft.ProcessModuleUtilities.showDcmSchemaDesignerById(schemaUId);
					this.set("ProcessActionTag", "OpenProcess");
					this.sendGoogleTagManagerData();
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#getGridDataColumns
				 * @overridden
				 */
				getGridDataColumns: function() {
					const gridDataColumns = this.callParent(arguments);
					if (!gridDataColumns.UId) {
						gridDataColumns.UId = {
							path: "UId"
						}
					}
					return gridDataColumns;
				},

				/**
				 * @inheritdoc ProcessVersionsDetail#addExecutionTraceOptions
				 * @override
				 */
				addExecutionTraceOptions: Terrasoft.emptyFn,

				/**
				 * Returns DCM settings Id.
				 * @private
				 * @param {String} schemaUId Schema unique identifier.
				 * return {String|null}
				 */
				_findDcmSettingsId: function(schemaUId) {
					const manager = Terrasoft.SysDcmSchemaInSettingsManager;
					const dcmSchemaInSettingsItem = manager.findItemBySysDcmSchemaUId(schemaUId);
					return dcmSchemaInSettingsItem && dcmSchemaInSettingsItem.getSysDcmSettings();
				}
			}
		};
	}
);

