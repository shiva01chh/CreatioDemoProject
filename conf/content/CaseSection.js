Terrasoft.configuration.Structures["CaseSection"] = {innerHierarchyStack: ["CaseSectionCase", "CaseSection"], structureParent: "BaseSectionV2"};
define('CaseSectionCaseStructure', ['CaseSectionCaseResources'], function(resources) {return {schemaUId:'23827614-0f6f-490b-a75b-33c1015ca8a4',schemaCaption: "Section page schema - Cases", parentSchemaName: "BaseSectionV2", packageName: "ServiceEnterpriseDefSettings", schemaName:'CaseSectionCase',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CaseSectionStructure', ['CaseSectionResources'], function(resources) {return {schemaUId:'523902d5-7c8c-4e9e-be96-e1425cc7cb58',schemaCaption: "Section page schema - Cases", parentSchemaName: "CaseSectionCase", packageName: "ServiceEnterpriseDefSettings", schemaName:'CaseSection',parentSchemaUId:'23827614-0f6f-490b-a75b-33c1015ca8a4',extendParent:true,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:"CaseSectionCase",schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define('CaseSectionCaseResources', ['terrasoft'], function(Terrasoft) {
var localizableStrings={

};
var parametersLocalizableStrings={};
var localizableImages={};
return {localizableStrings: localizableStrings, localizableImages: localizableImages, parametersLocalizableStrings: parametersLocalizableStrings};
});
define("CaseSectionCase", ["BaseFiltersGenerateModule", "CheckBoxFixedFilterStyle", "StorageUtilities",
			"ServiceDeskConstants", "CasePageUtilitiesV2", "css!CheckBoxFixedFilterStyle"],
		function(BaseFiltersGenerateModule, CheckBoxFixedFilterStyle, StorageUtilities, ServiceDeskConstants) {
			return {
				entitySchemaName: "Case",
				contextHelpId: "1001",
				mixins: {
					/**
					 * @class CasePageUtilitiesV2 CasePageUtilitiesV2 implements quick save cards in one click.
					 */
					CasePageUtilitiesV2: "Terrasoft.CasePageUtilitiesV2"
				},
				properties: {

					/**
					 * Property key for 'Show closed cases' button.
					 */
					showClosedCasesPropertyName: "showClosedCases"
				},
				attributes: {
					/**
					 * Resolved button menu visibility.
					 */
					"ResolvedButtonMenuVisible": {
						dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
						value: false
					},
					/**
					 * Caption for ResolvedMenu button.
					 */
					"ResolvedButtonMenuCaption": {
						dataValueType: this.Terrasoft.DataValueType.TEXT,
						value: ""
					},
					/**
					 *  Collection name drop-down menu in the function button.
					 */
					"ResolvedButtonMenuItems": {
						dataValueType: this.Terrasoft.DataValueType.COLLECTION
					},
					"IsActive": {
						dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						value: false
					},
					"NeedReloadData": {
						dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						value: false
					},
					"StatusFilterContainerDisplay": {
						dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
						type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						value: true
					},
					/**
					 * Container for custom case section profile.
					 */
					"CaseSectionCustomProfile": {
						dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
						value: null
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "ResolvedButton",
						"parentName": "CombinedModeActionButtonsCardLeftContainer",
						"propertyName": "items",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.BUTTON,
							"caption": {
								"bindTo": "ResolvedButtonMenuCaption"
							},
							"style": this.Terrasoft.controls.ButtonEnums.style.GREEN,
							"classes": {
								"textClass": ["actions-button-margin-right", "resolved-button-padding-border-right"],
								"wrapperClass": ["actions-button-margin-right"],
								"markerClass": ["resolved-button-pos-left"]
							},
							"click": {"bindTo": "onResolvedButtonMenuClick"},
							"menu": {
								"items": {"bindTo": "ResolvedButtonMenuItems"}
							},
							"visible": {
								"bindTo": "ResolvedButtonMenuVisible"
							}
						}
					},//FiltersContainer
					{
						"operation": "insert",
						"name": "IsActiveFiltersContainer",
						"parentName": "FiltersContainer",
						"propertyName": "items",
						"index": 0,
						"values": {
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"visible": {"bindTo": "StatusFilterContainerDisplay"},
							"wrapClass": ["isActive-filter-container-wrapClass"],
							"items": []
						}
					},
					{
						"operation": "insert",
						"parentName": "IsActiveFiltersContainer",
						"propertyName": "items",
						"name": "IsActive",
						"values": {
							"caption": {
								"bindTo": "Resources.Strings.CheckboxFilterCaption"
							},
							"bindTo": "IsActive",
							"controlConfig": {
								"className": "Terrasoft.CheckBoxEdit",
								"checkedchanged": {
									"bindTo": "onCheckboxChecked"
								},
								"checked": {
									"bindTo": "IsActive"
								}
							}
						}
					}
				]/**SCHEMA_DIFF*/,
				messages: {
					/**
					 * @message UpdateResolvedButtonMenu
					 * It is need to update the collection of menu items quick save button after changing status.
					 * @param {Object} Id current status.
					 */
					"UpdateResolvedButtonMenu": {
						mode: this.Terrasoft.MessageMode.PTP,
						direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
					},

					/**
					 * @message OnResolvedButtonMenuClick
					 * Event menu selection buttons quick save.
					 * @param {Object} config menu
					 */
					"OnResolvedButtonMenuClick": {
						mode: this.Terrasoft.MessageMode.PTP,
						direction: this.Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				methods: {

					/**
					 * Adds custom values to the profile.
					 * @param {String} propertyName Property name.
					 * @param {Object} propertyValue Property value.
					 * @private
					 */
					_addPropertyToProfile: function(propertyName, propertyValue) {
						var key = this.getCustomProfileKey();
						var profile = this.$CaseSectionCustomProfile;
						if (!this.Ext.isEmpty(profile)) {
							profile[propertyName] = propertyValue;
							Terrasoft.utils.saveUserProfile(key, profile, false);
							this.$CaseSectionCustomProfile = profile;
						}
					},

					/**
					 * Returns profile key.
					 * @returns {string} Profile key.
					 */
					getCustomProfileKey: function() {
						var schemaName = this.name;
						return schemaName + "CustomSectionData";
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#loadGridDataView
					 * @overridden
					 */
					loadGridDataView: function() {
						this.set("StatusFilterContainerDisplay", true);
						this.callParent(arguments);
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#loadAnalyticsDataView
					 * @overridden
					 */
					loadAnalyticsDataView: function() {
						this.set("StatusFilterContainerDisplay", true);
						this.callParent(arguments);
					},
					/**
					 * Publishes a message to the current state of the registry.
					 * In the state of zavistimosti - Card or sets the style for a Section SectionFiltersContainer.
					 */
					onSectionModeChanged: function() {
						this.callParent(arguments);
						CheckBoxFixedFilterStyle.setFilterContainerStyle(this);
					},

					/**
					 * Event menu selection buttons quick save
					 * @protected
					 */
					onResolvedButtonMenuClick: function() {
						var tagButtonMenu = arguments[0];
						if (!tagButtonMenu) {
							var resolvedButtonMenuItems = this.get("ResolvedButtonMenuItems");
							if (!resolvedButtonMenuItems.isEmpty()) {
								tagButtonMenu = resolvedButtonMenuItems.collection.items[0].values.Tag;
							}
						}
						this.sandbox.publish("OnResolvedButtonMenuClick", tagButtonMenu,
								[this.sandbox.id + "_CardModuleV2"]);
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#changeDataView
					 * @overridden
					 */
					changeDataView: function() {
						this.callParent(arguments);
						if (this.$NeedReloadData) {
							this.reloadGridData();
							this.$NeedReloadData = false; 
						}
					},

					/**
					 * @inheritdoc Terrasoft.BaseSchemaViewModel#initializeProfile
					 * @overridden
					 */
					initializeProfile: function(callback, scope) {
						this.callParent([function() {
							this.requireCustomProfile(callback, scope);
						}, scope || this]);
					},

					/**
					 * Loads case section profile.
					 * @param {Function} callback Callback function.
					 * @param {Object} scope Callback context.
					 */
					requireCustomProfile: function(callback, scope) {
						var key = this.getCustomProfileKey();
						this.requireProfile(function(profile) {
							if (profile) {
								this.$CaseSectionCustomProfile = profile;
								if (!this.Ext.isEmpty(profile[this.showClosedCasesPropertyName])) {
									this.$NeedReloadData = profile[this.showClosedCasesPropertyName];
									this.set("IsActive", profile[this.showClosedCasesPropertyName]);
								}
							}
							Ext.callback(callback, scope);
						}, scope || this, key);
					},

					/**
					 * Initializes the initial values of the model.
					 * @overridden
					 */
					init: function() {
						this.subscribeResolvedButton();
						this.initSatisfactionUpdateProcessJob();
						this.callParent(arguments);
					},

					/**
					 * Subscribes for resolved button events.
					 * @protected
					 */
					subscribeResolvedButton: function() {
						this.initResolvedButtonCollection();
						var resolvedClickSubscriberId = this.sandbox.id + "_CardModuleV2";
						this.sandbox.subscribe("UpdateResolvedButtonMenu", function(recordId) {
							this.initResolvedButtonCollection(recordId);
						}, this, [resolvedClickSubscriberId]);
					},

					/**
					 * Sets initial values for SatisfactionUpdateProcessJob
					 * @protected
					 */
					initSatisfactionUpdateProcessJob: function() {
						this.callSyncJobService(ServiceDeskConstants.SetSatisfactionTaskPeriod,
								"SatisfactionUpdateProcessJob", "SatisfactionUpdateProcess");
						var wasCheckTermSet = StorageUtilities.getItem("wasCheckTermSet");
						if (wasCheckTermSet) {
							return;
						}
						StorageUtilities.setItem(true, "wasCheckTermSet");
						this.Terrasoft.SysSettings.querySysSettingsItem("CaseOverduesCheckTerm",
								this.callOverdueSetter, this);
					},

					/**
					 * Create a scheduler to run the process at intervals.
					 * @param {Integer} value Value of the period in minutes
					 * @param {String} jobname Name of the task scheduler
					 * @param {String} processName The name of the process
					 */
					callSyncJobService: function(value, jobname, processName) {
						var config = {
							serviceName: "SyncJobService",
							methodName: "CreateSyncJob",
							data: {
								request: {
									JobName: jobname,
									ProcessName: processName,
									PeriodInMinutes: value
								}
							}
						};
						this.callService(config, this.Terrasoft.emptyFn, this);
					},

					/**
					 * Create a scheduler start the installation process indicators overdue appeals.
					 * @param {Integer} value The value of the system setting "Term inspection overdue treatment Minutes".
					 * @overridden
					 */
					callOverdueSetter: function(value) {
						this.callSyncJobService(value, "CaseOverduesSettingJob", "CaseOverduesSettingProcess");
					},

					/**
					 * The change in state CheckBox
					 * @param {Object} value The new value of the CheckBox after change.
					 */
					onCheckboxChecked: function(value) {
						this.$NeedReloadData = true;
						this.set("IsActive", value);
						this._addPropertyToProfile(this.showClosedCasesPropertyName, value);
						this.sandbox.publish("FiltersChanged", null, [this.sandbox.id]);
						CheckBoxFixedFilterStyle.onClick(value, this);
						var activeViewName = this.getActiveViewName();
						if (activeViewName === this.get("AnalyticsDataViewName")) {
							this.sandbox.publish("SectionUpdateFilter",
								null, [this.getQuickFilterModuleId()]);
						}
					},

					/**
					 * Initializes the setting of fixed filters.
					 * @overridden
					 */
					initFixedFiltersConfig: function() {
						var fixedFilterConfig = {
							entitySchema: this.entitySchema,
							filters: [
								{
									name: "Owner",
									caption: this.get("Resources.Strings.OwnerFilterCaption"),
									dataValueType: this.Terrasoft.DataValueType.LOOKUP,
									filter: BaseFiltersGenerateModule.OwnerFilter,
									columnName: "Owner",
									defValue: {
										value: this.Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
										displayValue: this.Terrasoft.SysValue.CURRENT_USER_CONTACT.displayValue
									}
								}
							]
						};
						this.set("FixedFilterConfig", fixedFilterConfig);
					},

					/**
					 * Set ID contextual help.
					 * @protected
					 */
					initContextHelp: function() {
						this.set("ContextHelpId", 1063);
						this.callParent(arguments);
					},

					/**
					 *@inheritDoc Terrasoft.GridUtilitiesV2#getFilters
					 *@overriden
					 */
					getFilters: function() {
						var filters = this.callParent(arguments);
						var isFinal = this.get("IsActive");
						if (!isFinal) {
							filters.add("FilterStatus", this.Terrasoft.createColumnFilterWithParameter(
									this.Terrasoft.ComparisonType.EQUAL, "Status.IsFinal", isFinal));
						}
						return filters;
					}
				}
			};
		});

define("CaseSection", [],
	function() {
		return {
			entitySchemaName: "Case",
			messages: {
				/**
				 * @message GetCaseStatus
				 * Send information about case status to section.
				 */
				"SendCaseStatusToSection": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			attributes: {
				/**
				 * Run escalation action enabled.
				 */
				"RunEscalationEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				},
				/**
				 * Run reclasification action enabled.
				 */
				"RunReclasificationEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			diff: /**SCHEMA_DIFF*/[

			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritdoc this.Terrasoft.BaseSection#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initSectionMessages();
				},
				/**
				 * Initializes the initial values of the model.
				 * @protected
				 */
				initSectionMessages: function() {
					var subscriberId = this.sandbox.id + "_CardModuleV2";
					this.sandbox.subscribe("SendCaseStatusToSection", this.onSendCaseStatusToSection, this,
						[subscriberId]);
				},
				/**
				 * On send case status to section handler.
				 * Sets run escalation action enabled.
				 * @protected
				 */
				onSendCaseStatusToSection: function(status) {
					var runEscalationEnabled = this.getRunEscalationEnabled(status);
					this.set("RunEscalationEnabled", runEscalationEnabled);
					this.set("RunReclassificationEnabled", runEscalationEnabled);
				},
				/**
				 * Returns run escalation action enabled.
				 * @protected
				 * @virtual
				 * @return {Boolean} Run escalation action enabled.
				 */
				getRunEscalationEnabled: function(status) {
					return !status.IsFinal && !status.IsResolved;
				}
			}
		};
	});



