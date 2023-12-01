Terrasoft.configuration.Structures["SspProfileContactPage"] = {innerHierarchyStack: ["SspProfileContactPageSSP", "SspProfileContactPage"], structureParent: "BaseModulePageV2"};
define('SspProfileContactPageSSPStructure', ['SspProfileContactPageSSPResources'], function(resources) {return {schemaUId:'f79c8996-d0aa-4c4d-bc2e-7803bc66d929',schemaCaption: "Contact page at portal profile", parentSchemaName: "BaseModulePageV2", packageName: "PortalITILService", schemaName:'SspProfileContactPageSSP',parentSchemaUId:'d62293c0-7f14-44b1-b547-735fb40499cd',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SspProfileContactPageStructure', ['SspProfileContactPageResources'], function(resources) {return {schemaUId:'0d403172-2bcd-43f7-bc8e-403f6c544188',schemaCaption: "Contact page at portal profile", parentSchemaName: "SspProfileContactPageSSP", packageName: "PortalITILService", schemaName:'SspProfileContactPage',parentSchemaUId:'f79c8996-d0aa-4c4d-bc2e-7803bc66d929',extendParent:true,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"SspProfileContactPageSSP",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('SspProfileContactPageSSPResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={

};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("SspProfileContactPageSSP", ["EmailHelper", "SspProfileContactPageResources", "CommunicationSynchronizerMixin"],
	function(EmailHelper, resources) {
		return {
			entitySchemaName: "Contact",
			mixins: {
				CommunicationSynchronizerMixin: "Terrasoft.CommunicationSynchronizerMixin"
			},
			attributes: {
				"Email": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"isRequired": true,
					"dependencies": [
						{
							"columns": ["Email"],
							"methodName": "syncEntityWithCommunicationDetail"
						}
					]
				},

				"MobilePhone": {
					"dependencies": [
						{
							"columns": ["MobilePhone"],
							"methodName": "syncEntityWithCommunicationDetail"
						}
					]
				},

				"Phone": {
					"dependencies": [
						{
							"columns": ["Phone"],
							"methodName": "syncEntityWithCommunicationDetail"
						}
					]
				},

				/**
				* @inheritdoc Terrasoft.BaseDataView#UseTagModule
				* @override
				*/
				"UseTagModule": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				},

				"CommunicationDetailName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "ContactCommunication"
				},

				"JobTitle": {
					dependencies: [
						{
							columns: ["Job"],
							methodName: "jobChanged"
						}
					]
				}
			},
			messages: {
				/**
				 * @message GetCommunicationsSynchronizedByDetail
				 * Requests communications synchronized by detail.
				 */
				"GetCommunicationsSynchronizedByDetail": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				/**
				 * @message SyncCommunication
				 * Synchronizes communications.
				 */
				"SyncCommunication": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			details: /**SCHEMA_DETAILS*/{
				ContactCommunication: {
					schemaName: "SspContactCommunicationDetail",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				},
				ContactAddress: {
					schemaName: "ContactAddressDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Contact"
					}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "ESNTab"
				},
				{
					"operation": "insert",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"name": "ContactPhotoContainer",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24,
							"rowSpan": 1
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["image-edit-container"],
						"items": []
					},
					"alias": {
						"name": "PhotoContainer",
						"excludeOperations": ["remove", "move"]
					}
				},
				{
					"operation": "insert",
					"parentName": "ContactPhotoContainer",
					"propertyName": "items",
					"name": "Photo",
					"values": {
						"getSrcMethod": "_getContactImage",
						"onPhotoChange": "_onPhotoChange",
						"readonly": false,
						"defaultImage": {"bindTo": "_getContactDefaultImage"},
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
					}
				},
				{
					"operation": "insert",
					"name": "Name",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Name"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "SalutationType",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "SalutationType"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Gender",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Gender"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Job",
					"values": {
						"contentType": this.Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Job"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "JobTitle",
					"values": {
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "JobTitle"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "MobilePhone",
					"values": {
						"layout": {
							"column": 0,
							"row": 6,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "MobilePhone"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Phone",
					"values": {
						"layout": {
							"column": 0,
							"row": 7,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Phone"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Email",
					"values": {
						"layout": {
							"column": 0,
							"row": 8,
							"colSpan": 24,
							"rowSpan": 1
						},
						"bindTo": "Email"
					},
					"parentName": "ProfileContainer",
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "GeneralInfoTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 0,
					"values": {
						"caption": {"bindTo": "Resources.Strings.GeneralInfoTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "ContactCommunication",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"name": "ContactAddress",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritDoc Terrasoft.BasePageV2#save
				 * @override
				 */
				save: function() {
					this.clearChangedValuesSynchronizedByDetail();
					this.callParent(arguments);
				},

				/**
				 * @inherit#oc Terrasoft.configuration.BaseSchemaViewModel#setValidationConfig
				 * @override
				 */
				setValidationConfig: function() {
					this.callParent(arguments);
					this.addColumnValidator("Email", EmailHelper.getEmailValidator);
				},

				jobChanged: function() {
					const job = this.get("Job");
					const jobTitle = this.get("JobTitle");
					if (this.isNotEmpty(job) && this.isEmpty(jobTitle)) {
						this.set("JobTitle", job.displayValue);
					}
				},

				_getContactImage: function() {
					const primaryImageColumnValue = this.get(this.primaryImageColumnName);
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this._getContactDefaultImage();
				},

				_getContactDefaultImage: function() {
					return Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultPhoto"));
				},

				_onPhotoChange: function(photo) {
					if (!photo) {
						this.set(this.primaryImageColumnName, null);
						return;
					}
					Terrasoft.ImageApi.upload({
						file: photo,
						onComplete: this._onPhotoUploaded,
						onError: this._onPhotoChangeError,
						scope: this
					});
				},

				_onPhotoChangeError: function(imageId, error, xhr) {
					if (xhr.response) {
						const response = Terrasoft.decode(xhr.response);
						if (response.error) {
							Terrasoft.showMessage(response.error);
						}
					}
				},

				_onPhotoUploaded: function(imageId) {
					const imageData = {
						value: imageId,
						displayValue: "Photo"
					};
					this.set(this.primaryImageColumnName, imageData);
				},

				/**
				* @inheritDoc Terrasoft.BaseDataView#initActionButtonMenu
				* @override
				*/
				initActionButtonMenu: Terrasoft.emptyFn,

				/**
				 * @inheritDoc DuplicatesSearchUtilitiesV2#initPerformSearchOnSave
				 * @override
				 */
				initPerformSearchOnSave: Terrasoft.emptyFn

			}
		};
	});

define("SspProfileContactPage", ["ServiceFilterMixin"],
function() {
	return {
		mixins: {
			/**
			 * @class Terrasoft.configuration.mixins.ServiceFilterMixin.
			 */
			ServiceFilterMixin: "Terrasoft.ServiceFilterMixin"
		},
		entitySchemaName: "Contact",
		messages: {},
		details: /**SCHEMA_DETAILS*/{
			"Services": {
				"schemaName": "ServiceRecepientsDetail",
				"entitySchemaName": "VwServiceRecepients",
				"filterMethod": "getServicesFilter",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Contact"
				}
			},
			"ServicePacts": {
				"schemaName": "ServicePactRecipientsDetail",
				"entitySchemaName": "ServiceObject",
				"filterMethod": "getServicesPactFilter",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "Contact"
				}
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ContactPageServiceTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {"bindTo": "Resources.Strings.MaintenanceTab"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Services",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "ContactPageServiceTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "ServicePacts",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.DETAIL
				},
				"parentName": "ContactPageServiceTab",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_DIFF*/,
		attributes: {},
		methods: {
			/**
			 * @inheritDoc Terrasoft.BasePageV2#onEntityInitialized
			 * @overridden
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.initServiceFilterMixin();
			},

			/**
			 * Returns service item filter.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getServicesFilter: function() {
				return this.mixins.ServiceFilterMixin.getServicesFilter("Service.Id",
					"[VwServiceRecepients:Service:Id]");
			},

			/**
			 * Returns service pact filter.
			 * @protected
			 * @returns {Terrasoft.FilterGroup} Filter group.
			 */
			getServicesPactFilter: function() {
				return this.mixins.ServiceFilterMixin.getServicesFilter("ServicePact.Id",
					"[ServiceObject:ServicePact:Id]");
			},

			/**
			 * Initialize ServiceFilter mixin.
			 * @protected
			 */
			initServiceFilterMixin: function() {
				this.mixins.ServiceFilterMixin.init({
					contact: this.$Id,
					account: this.$Account,
					department:  this.$Department
				});
			}
		},
		rules: {},
		userCode: {}
	};
});


