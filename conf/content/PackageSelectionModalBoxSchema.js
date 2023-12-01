﻿Terrasoft.configuration.Structures["PackageSelectionModalBoxSchema"] = {innerHierarchyStack: ["PackageSelectionModalBoxSchema"]};
define('PackageSelectionModalBoxSchemaStructure', ['PackageSelectionModalBoxSchemaResources'], function(resources) {return {schemaUId:'bd7d952a-bcdc-4766-a2e3-fd3cb174eb5b',schemaCaption: "PackageSelectionModalBoxSchema", parentSchemaName: "", packageName: "CrtNUI", schemaName:'PackageSelectionModalBoxSchema',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("PackageSelectionModalBoxSchema", ["ModalBox", "PackageHelper",
	"PackageSelectionModalBoxSchemaResources", "css!PackageSelectionModalBoxSchemaCSS"],
	function(ModalBox, PackageHelper) {
		return {
			messages: {
				/**
				 * @message Selected result.
				 */
				"SelectedPackageResult": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {
				/**
				 * SysPackage.
				 */
				"SysPackage": {
					"dataValueType": Terrasoft.DataValueType.ENUM,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true
				},
				/**
				 * Collection of available packages.
				 */
				"SysPackageList": {
					"dataValueType": this.Terrasoft.DataValueType.COLLECTION,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {

				// region Methods: Private

				_checkSysPackageProFileValue: function(sysPackage) {
					if (!sysPackage) {
						return false;
					}

					var packageList = this.$SysPackageList;
					var findPackage = packageList.find(sysPackage.value);
					return !!findPackage;
				},

				// endregion

				// region Methods: Protected

				/**
				 * Save user profile.
				 * @protected
				 */
				saveUserProfile: function() {
					const profileKey = this.getProfileKey();
					const syspackage = this.$SysPackage;
					this.Terrasoft.saveUserProfile(profileKey, {
						SysPackage: syspackage
					}, false);
				},

				/**
				 * Publish selected result.
				 * @protected
				 */
				publishResultMessage: function() {
					var sysPackage = this.$SysPackage;
					this.sandbox.publish("SelectedPackageResult", {
						SysPackage: {
							Id: sysPackage.value,
							Name: sysPackage.displayValue,
							UId: sysPackage.UId
						}
					}, [this.sandbox.id]);
				},

				/**
				 * Return profile key.
				 * @protected
				 * @override
				 * @return {String} Key.
				 */
				getProfileKey: function() {
					return "PackageSelectionModalBoxSchemaProfile";
				},

				/**
				 * Initialize attributes.
				 * @protected
				 */
				initSysPackageProfileData: function() {
					var sysPackage = this.$Profile && this.$Profile.SysPackage;
					if (this._checkSysPackageProFileValue(sysPackage)) {
						this.$SysPackage = sysPackage;
					}
				},

				/**
				 * Initialize syspackage collection.
				 * @protected
				 */
				initSysPackageList: function() {
					this.$SysPackageList = new Terrasoft.Collection();
				},

				/**
				 * Loads values into PackageList collection.
				 * @protected
				 * @param {Object} filterValue Filter value.
				 * @param {Terrasoft.Collection} list List of comboboxEdit values.
				 * @param {Function} callback The callback function.
				 * @param {Object} scope The scope of callback function.
				 */
				prepareSysPackageList: function(filterValue, list, callback, scope) {
					if (!list) {
						return;
					}

					PackageHelper.getAvailablePackages(function(collection) {
						list.clear();
						if (!collection) {
							return;
						}
						var packagesList = {};
						collection.each(function(item) {
							var listItem = {
								value: item.get("Id"),
								displayValue: item.get("Name"),
								UId: item.get("UId")
							};
							packagesList[item.get("Id")] = listItem;
						}, this);
						list.loadAll(packagesList);
						this.Ext.callback(callback, scope);
					}, this);
				},

				// endregion

				// region Methods: Public

				/**
				 * @inheritdoc BaseSchemaModuleV2#init
				 * @override
				 */
				init: function(callback, scope) {
					this.initSysPackageList();
					this.callParent([function() {
						callback.call(scope);
						this.prepareSysPackageList(null, this.$SysPackageList, this.initSysPackageProfileData, this);
					}, this]);
				},

				/**
				 * Cancel button handler.
				 */
				onCancelClick: function() {
					this.closeModalBox();
				},

				/**
				 * Close modal box.
				 */
				closeModalBox: function() {
					ModalBox.close();
				},

				/**
				 * Save button handler.
				 */
				onSaveButtonClick: function() {
					if (!this.validate()) {
						return;
					}
					this.saveUserProfile();
					this.publishResultMessage();
					this.closeModalBox();
				}

				// endregion

			},
			diff: [
				{
					"operation": "insert",
					"name": "PackageSelectionEditContainer",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["package-selection-edit-container"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "PackageSelectionEditCaption",
					"parentName": "PackageSelectionEditContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.PackageSelectionModalBoxCaption"
						},
						"classes": {
							"labelClass": ["package-selection-edit-caption"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "PackageSelectionValueField",
					"parentName": "PackageSelectionEditContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "SysPackage",
						"caption": {
							"bindTo": "Resources.Strings.PackageSelectionFieldCaption"
						},
						"controlConfig": {
							"classes": ["package-selection-edit-value-field"],
							"className": "Terrasoft.ComboBoxEdit",
							"list": {
								"bindTo": "SysPackageList"
							},
							"prepareList": {
								"bindTo": "prepareSysPackageList"
							},
							"value": {
								"bindTo": "SysPackage"
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "PackageSelectionEditButtonContainer",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["package-selection-edit-button-container"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "SaveButton",
					"parentName": "PackageSelectionEditButtonContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {
							"bindTo": "Resources.Strings.SaveButtonCaption"
						},
						"click": { "bindTo": "onSaveButtonClick" },
						"style": Terrasoft.controls.ButtonEnums.style.BLUE,
						"classes": { "textClass": "actions-button-margin-right" }
					}
				},
				{
					"operation": "insert",
					"name": "CancelButton",
					"parentName": "PackageSelectionEditButtonContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {
							"bindTo": "Resources.Strings.CancelButtonCaption"
						},
						"click": { "bindTo": "onCancelClick" },
						"style": Terrasoft.controls.ButtonEnums.style.GRAY,
						"classes": { "textClass": "actions-button-margin-right" }
					}
				}
			]
		};
	});


