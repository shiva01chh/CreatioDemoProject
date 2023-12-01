Terrasoft.configuration.Structures["LeadContactProfileSchema"] = {innerHierarchyStack: ["LeadContactProfileSchemaCoreLead", "LeadContactProfileSchema"], structureParent: "ContactProfileSchema"};
define('LeadContactProfileSchemaCoreLeadStructure', ['LeadContactProfileSchemaCoreLeadResources'], function(resources) {return {schemaUId:'108b6182-8306-4230-8332-85a95ee0fdb0',schemaCaption: "LeadContactProfileSchema", parentSchemaName: "ContactProfileSchema", packageName: "LeadManagement", schemaName:'LeadContactProfileSchemaCoreLead',parentSchemaUId:'f79ed96a-7483-4e04-8bce-4f763be2a520',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadContactProfileSchemaStructure', ['LeadContactProfileSchemaResources'], function(resources) {return {schemaUId:'3bbd00b2-633c-4656-bcb2-5450901df9a9',schemaCaption: "LeadContactProfileSchema", parentSchemaName: "LeadContactProfileSchemaCoreLead", packageName: "LeadManagement", schemaName:'LeadContactProfileSchema',parentSchemaUId:'108b6182-8306-4230-8332-85a95ee0fdb0',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"LeadContactProfileSchemaCoreLead",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('LeadContactProfileSchemaCoreLeadResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
/**
 * Lead contact profile class.
 * @class Terrasoft.LeadContactProfileSchema
 */
define("LeadContactProfileSchemaCoreLead",["LeadContactProfileSchemaResources", "LeadSimilarEntitiesProfileSchemaUtilities",
		"CommunicationOptionsMixin"],
	function(resources) {
		return {
			entitySchemaName: "Contact",
			mixins: {
				LeadSimilarEntitiesUtilities: "Terrasoft.LeadSimilarEntitiesProfileSchemaUtilities",

				/**
				 * @class CommunicationOptionsMixin Mixin, implements communication options usage methods.
				 */
				CommunicationOptionsMixin: "Terrasoft.CommunicationOptionsMixin"
			},
			messages: {
				/**
				 * @message CallCustomer
				 * Starts phone call in CTI panel.
				 */
				"CallCustomer": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message GetEntityInfo
				 * Returns information about master entity for minipage.
				 */
				"GetMiniPageMasterEntityInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {
				/**
				 * Virtual collection of Contact entity primary column values.
				 */
				"SimilarCollection": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					"value": []
				},
				/**
				 * Enabled state of the Similar button.
				 */
				"SimilarButtonEnabled": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				/**
				 * The caption of the Similar button.
				 */
				"SimilarButtonCaption": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: resources.localizableStrings.SimilarButtonCaption
				},
				/**
				 * The hint of the Similar button.
				 */
				"SimilarButtonHintText": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: resources.localizableStrings.SimilarButtonNotFoundHintText
				},

				/**
				 * Related page column name.
				 * @type {String}
				 */
				"RelatedPageRecordColumn": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					value: "Lead"
				}
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseProfileSchema#onCardEntityInitialized
				 * @overridden
				 */
				onCardEntityInitialized: function() {
					this.callParent(arguments);
					this.initSimilarEntityRecordsCollection();
				},

				/**
				 * @inheritdoc Terrasoft.BaseProfileSchema#initEntity
				 * @overridden
				 */
				initEntity: function() {
					this.callParent(arguments);
					this.initSimilarEntityRecordsCollection();
				},

				/**
				 * Starts call in CTI panel.
				 * @param {String} number Phone number to call.
				 * @return {Boolean} False, to stop click event propagation.
				 */
				onCallClick: function(number) {
					return this.callLeadWithRelations(number, this.$Id, this.getProfileRelationFields());
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "BlankSlateContainer",
					"propertyName": "items",
					"name": "SimilarButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"classes": {
							"textClass": "blank-slate-button"
						},
						"caption": {"bindTo": "SimilarButtonCaption"},
						"layout": {
							"column": 4,
							"row": 3,
							"colSpan": 20
						},
						"enabled": true,
						"visible": {"bindTo": "SimilarButtonEnabled"},
						"click": {"bindTo": "onSimilarButtonClick"},
						"tips": []
					}
				},
				{
					"operation": "insert",
					"parentName": "SimilarButton",
					"propertyName": "tips",
					"name": "SimilarButtonTip",
					"values": {
						"content": {"bindTo": "SimilarButtonHintText"},
						"style": Terrasoft.TipStyle.GREEN,
						"behaviour": {
							"displayEvent": Terrasoft.TipDisplayEvent.HOVER
						},
						"tools": []
					}
				},
				{
					"operation": "merge",
					"name": "Job",
					"parentName": "ProfileContentContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "JobTitle",
						"enabled": false,
						"layout": {
							"column": 4,
							"row": 1,
							"colSpan": 20
						}
					}
				},
				{
					"operation": "merge",
					"name": "MobilePhone",
					"parentName": "ProfileContentContainer",
					"propertyName": "items",
					"values": {
						"className": "Terrasoft.PhoneEdit",
						"bindTo": "MobilePhone",
						"enabled": false,
						"layout": {
							"column": 4,
							"row": 2,
							"colSpan": 20
						}
					}
				},
				{
					"operation": "remove",
					"name": "Phone"
				},
				{
					"operation": "remove",
					"name": "Email"
				}
			]/**SCHEMA_DIFF*/
		};
	}
);

define("LeadContactProfileSchema", ["SalesReadyLeadLifecycleMixin"], function() {
		return {
			mixins: {
				SalesReadyLeadLifecycleMixin: "Terrasoft.SalesReadyLeadLifecycleMixin"	
			},
			methods: {

				//region Methods: Protected

				/**
				 * Returns mobile phone field visibility
				 * @protected
				 */
				getMobilePhoneVisibility: function() {
					return !this.get("UseTheSalesReadyLeadLifecycle") 
						&& !this.Ext.isEmpty(this.get("MobilePhone"));
				},

				/**
				 * @inheritdoc Terrasoft.LeadContactProfileSchema#init
				 * @override
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.loadSalesReadyLeadLifecycleSysSetting(callback, scope);
					}, this]);
				},

				//endregion
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "MobilePhone",
					"values": {
						"visible": {
							"bindTo": "getMobilePhoneVisibility"
						}
					}
				},
			]/**SCHEMA_DIFF*/
		};
	}
);


