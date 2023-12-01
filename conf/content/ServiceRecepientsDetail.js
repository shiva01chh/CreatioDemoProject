﻿Terrasoft.configuration.Structures["ServiceRecepientsDetail"] = {innerHierarchyStack: ["ServiceRecepientsDetail"], structureParent: "BaseGridDetailV2"};
define('ServiceRecepientsDetailStructure', ['ServiceRecepientsDetailResources'], function(resources) {return {schemaUId:'75e68f3c-b035-475b-9f98-830c6a328ccf',schemaCaption: "Service item recipients detail schema", parentSchemaName: "BaseGridDetailV2", packageName: "CrtSLMITILService7x", schemaName:'ServiceRecepientsDetail',parentSchemaUId:'01eb38ee-668a-42f0-999d-c2534f979089',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceRecepientsDetail", [],
	function() {
		return {
			entitySchemaName: "VwServiceRecepients",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
				 * @overridden
				 */
				getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

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
				 * @inheritDoc Terrasoft.BaseGridDetailV2#initDefaultCaption
				 * @override
				 */
				initDefaultCaption: function() {
					if (this.Terrasoft.isCurrentUserSsp()) {
						this.set("Caption", this.get("Resources.Strings.ActiveServices"));
					} else {
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritDoc Terrasoft.BaseGridDetailV2#getFilters
				 * @override
				 */
				getFilters: function() {
					const filters = this.callParent(arguments);
					if (this.Terrasoft.isCurrentUserSsp()) {
						const filterGroup = new Terrasoft.createFilterGroup();
						filterGroup.add("Active", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Service.Status.Active", true)
						);
						filterGroup.add("ActiveServicePact", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "ServicePact.Status.IsActive", true)
						);
						filterGroup.add("EndDateServicePact", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.GREATER_OR_EQUAL,
							"ServicePact.EndDate", this.Terrasoft.endOfDay(new Date()))
						);
						filters.add(filterGroup);
					}
					return filters;
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});


