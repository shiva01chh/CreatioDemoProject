Terrasoft.configuration.Structures["ProblemSection"] = {innerHierarchyStack: ["ProblemSection"], structureParent: "BaseSectionV2"};
define('ProblemSectionStructure', ['ProblemSectionResources'], function(resources) {return {schemaUId:'d41bde6e-9711-41fa-8bd9-f56f2b381cdf',schemaCaption: "Page schema - Problems section", parentSchemaName: "BaseSectionV2", packageName: "Problem", schemaName:'ProblemSection',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ProblemSection", ["terrasoft", "BaseFiltersGenerateModule", "CheckBoxFixedFilterStyle",
		"css!CheckBoxFixedFilterStyle"],
	function(Terrasoft, BaseFiltersGenerateModule, CheckBoxFixedFilterStyle) {
		return {
			entitySchemaName: "Problem",
			contextHelpId: "1001",
			properties: {

				/**
				 * Property key for 'Show closed Problems' button.
				 */
				showClosedProblemsPropertyName: "showClosedProblems"
			},
			attributes: {
				"IsActive": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				},
				"NeedReloadData": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				},
				/**
				 * Container for custom Problem section profile.
				 */
				"ProblemSectionCustomProfile": {
					dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT,
					value: null
				}
			},
			diff: /**SCHEMA_DIFF*/[
				//FiltersContainer
				{
					"operation": "insert",
					"name": "IsActiveFiltersContainer",
					"parentName": "FiltersContainer",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
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
							"checkedchanged": {"bindTo": "onCheckboxChecked"},
							"checked": {"bindTo": "IsActive"}
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			messages: {},
			methods: {
				
				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#onSectionModeChanged
				 * @overridden
				 */
				onSectionModeChanged: function() {
					this.callParent(arguments);
					CheckBoxFixedFilterStyle.setFilterContainerStyle(this);
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
				 * Adds custom values to the profile.
				 * @param {String} propertyName Property name.
				 * @param {Object} propertyValue Property value.
				 * @private
				 */
				_addPropertyToProfile: function(propertyName, propertyValue) {
					var key = this.getCustomProfileKey();
					var profile = this.$ProblemSectionCustomProfile;
					if (!this.Ext.isEmpty(profile)) {
						profile[propertyName] = propertyValue;
						Terrasoft.utils.saveUserProfile(key, profile, false);
						this.$ProblemSectionCustomProfile = profile;
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
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#initializeProfile
				 * @overridden
				 */
				initializeProfile: function(callback, scope) {
					this.callParent([function() {
						this.requireCustomProfile(callback, scope);
					}, scope || this]);
				},

				/**
				 * Loads Problem section profile.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback context.
				 */
				requireCustomProfile: function(callback, scope) {
					var key = this.getCustomProfileKey();
					this.requireProfile(function(profile) {
						if (profile) {
							this.$ProblemSectionCustomProfile = profile;
							if (!this.Ext.isEmpty(profile[this.showClosedProblemsPropertyName])) {
								this.$NeedReloadData = profile[this.showClosedProblemsPropertyName];
								this.set("IsActive", profile[this.showClosedProblemsPropertyName]);
							}
						}
						Ext.callback(callback, scope);
					}, scope || this, key);
				},

				/**
				 * Changing the state of the CheckBox.
				 * @param {Object} value CheckBox value.
				 */
				onCheckboxChecked: function(value) {
					this.$NeedReloadData = true;
					this.set("IsActive", value);
					this._addPropertyToProfile(this.showClosedProblemsPropertyName, value);
					this.sandbox.publish("FiltersChanged", null, [this.sandbox.id]);
					CheckBoxFixedFilterStyle.onClick(value, this);
					var activeViewName = this.getActiveViewName();
					if (activeViewName === this.get("AnalyticsDataViewName")) {
						this.sandbox.publish("SectionUpdateFilter",
							null, [this.getQuickFilterModuleId()]);
					}
				},

				/**
				 * Adds or removes IsActiveFilter to filter collection.
				 * @protected
				 * @param {Terrasoft.Collection} filterCollection Filter collection.
				 */
				getFilters: function() {
					var filters = this.callParent(arguments);
					var isFinal = this.get("IsActive");
					if (!isFinal) {
						filters.add("FilterStatus", this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Status.IsFinal", isFinal));
					}
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#initFixedFiltersConfig
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
				 * @inheritdoc Terrasoft.ContextHelpMixin#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1064);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#setGridOffsetClass
				 * @overridden
				 */
				setGridOffsetClass: function(linesCount) {
					this.callParent([linesCount + 1]);
				}
			}
		};
	});


