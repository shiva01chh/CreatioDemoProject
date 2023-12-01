Terrasoft.configuration.Structures["CaseDetailSelectModule"] = {innerHierarchyStack: ["CaseDetailSelectModule"], structureParent: "BaseGridDetailV2"};
define('CaseDetailSelectModuleStructure', ['CaseDetailSelectModuleResources'], function(resources) {return {schemaUId:'99b160c2-48ce-4410-aafb-458fe7b22bc1',schemaCaption: "Detail schema - Cases in selection module", parentSchemaName: "BaseGridDetailV2", packageName: "IncidentManagement", schemaName:'CaseDetailSelectModule',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("CaseDetailSelectModule", ["ConfigurationEnums", "BaseDetailV2"],
	function(enums) {
		return {
			entitySchemaName: "Case",
			extend: "CaseDetail",
			attributes: {},
			messages: {
				/**
				 * @message DetailActiveRowChanged
				 * ########## # ######### ######## ###### ## ######.
				 * @param {Object} ############ ########### ########.
				 */
				"DetailActiveRowChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {
				/**
				 * ############## ######
				 * @protected
				 * @overridden
				 */
				initDetailOptions: function() {
					this.callParent();
					this.set("IsDetailCollapsed", false);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#editRecord
				 * @overridden
				 */
				editRecord: function(record) {
					var activeRow = record || this.getActiveRow();
					if (!activeRow) {
						return;
					}
					var primaryColumnValue = activeRow.get(activeRow.primaryColumnName);
					var typeColumnValue = this.getTypeColumnValue(activeRow);
					this.openCard(enums.CardStateV2.EDIT, typeColumnValue, primaryColumnValue);
				},

				/**
				 * ########## ######### ######### ###### # #######
				 * @protected
				 * @param {String} rowId ############# ######### ######
				 */
				onActiveRowChanged: function(rowId) {
					if (rowId === this.get("activeRow")) {
						return;
					}
					if (!rowId) {
						rowId = this.get("activeRow");
					}
					if (!rowId) {
						return;
					}
					var gridData = this.getGridData();
					var config = {
						activeRow: gridData.get(rowId),
						entitySchemaName: this.entitySchemaName
					};
					this.sandbox.publish("DetailActiveRowChanged", config, [this.sandbox.id]);
				}
			},
			diff: [
				{
					"operation": "merge",
					"name": "Detail",
					"values": {
						"caption": "",
						"collapsed": false,
						"isHeaderVisible": false,
						"markerValue": "CaseListControl"
					}
				},
				{
					"operation": "merge",
					"name": "DataGrid",
					"values": {
						"selectRow": {"bindTo": "onActiveRowChanged"}
					}
				},
				{
					"operation": "remove",
					"name": "AddRecordButton"
				},
				{
					"operation": "remove",
					"name": "ActionsButton"
				}
			]
		};
	});


