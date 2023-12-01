﻿Terrasoft.configuration.Structures["ContactCommunicationDetailV2"] = {innerHierarchyStack: ["ContactCommunicationDetailV2"], structureParent: "BaseDetailV2"};
define('ContactCommunicationDetailV2Structure', ['ContactCommunicationDetailV2Resources'], function(resources) {return {schemaUId:'8318f1f3-7757-4ff7-95f4-3646afa95620',schemaCaption: "Contact communication options", parentSchemaName: "BaseDetailV2", packageName: "CrtUIv2", schemaName:'ContactCommunicationDetailV2',parentSchemaUId:'3052ff9d-521d-4a6d-ba92-04a2261e1ea8',extendParent:false,type:Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ContactCommunicationDetailV2", ["ContactCommunicationDetailV2Resources", "terrasoft", "ViewUtilities",
	"ConfigurationConstants", "ModalBox",
	"LookupUtilities", "BaseCommunicationViewModel", "ConfigurationItemGenerator", "BaseDetailV2"],
	function(resources, Terrasoft, ViewUtilities, ConfigurationConstants, ModalBox) {
		return {
			entitySchemaName: "ContactCommunication",

			attributes: {

				/**
				 * ######### ######### #### ###### "########"
				 */
				ToolsMenuItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######### ######### #### ###### "########"
				 */
				PhonesMenuItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######### ###. ##### #### ###### "########"
				 */
				SocialNetworksMenuItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######### ##### ####### #####
				 */
				MenuItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ####### "###### #########"
				 */
				IsDataLoaded: {dataValueType: Terrasoft.DataValueType.BOOLEAN},

				/**
				 * ######### ####### ##### ## ########
				 */
				DeletedItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######### ######### #### "###### ## #############"
				 */
				RestrictionsMenuItems: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######### ######## ## #############
				 */
				RestrictionsCollection: {dataValueType: Terrasoft.DataValueType.COLLECTION},

				/**
				 * ######## ##### ####### #####
				 */
				"CommunicationTypes" : {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.COLLECTION
				}
			},
			messages: {

				/**
				 * @message ResultSelectedRows
				 * ### ###### LookupUtilities
				 */
				"ResultSelectedRows": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 *
				 */
				"UpdateCardProperty": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},



				"ValidateDetail": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"DetailValidated": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				"SaveDetail": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"DetailSaved": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			methods: {
				//TODO delete
				getDataGridName: function() {
					return "";
				},

				/**
				 * #########, ######## ## ### ######## ##### ##### ## ##### ###. #####.
				 * @private
				 * @param {String} communicationType ######## #### ########.
				 * @return {Boolean} ######## ## ### ######## ##### ##### ## ##### ###. #####.
				 */
				isSocialNetworkType: function(communicationType) {
					communicationType = communicationType.value || communicationType;
					return ConfigurationConstants.SocialNetworksCommunicationTypes.indexOf(communicationType) !== -1;
				},

				isPhoneType: function(communicationType) {
					communicationType = communicationType.value || communicationType;
					return ConfigurationConstants.PhonesCommunicationTypes.indexOf(communicationType) !== -1;
				},

				/**
				 * ######### ######### ####.
				 * @param {String} moduleName ######## ######.
				 * @private
				 */
				closeModalBox: function(moduleName) {
					var modalBoxContainer = this.get("ModalBoxContainer");
					if (modalBoxContainer) {
						ModalBox.close();
					}
					this.sandbox.unloadModule(this.sandbox.id + "_" + moduleName);
				},

				/**
				 * ############ ######## ###### ###### # ########## #####.
				 * @private
				 */
				onLookUpClick: function() {
					var modalBoxSize = {
						minHeight : "1",
						minWidth : "1",
						maxHeight : "100",
						maxWidth : "100"
					};
					var modalBoxContainer = ModalBox.show(modalBoxSize);
					this.set("ModalBoxContainer", modalBoxContainer);
					ModalBox.setSize(820, 600);
					this.sandbox.loadModule("FindContactsInSocialNetworksModule", {
						renderTo: modalBoxContainer
					});
					this.sandbox.subscribe("ResultSelectedRows", function() {
						this.closeModalBox("FindContactsInSocialNetworksModule");
					}, this, [this.sandbox.id + "_FindContactsInSocialNetworksModule"]);
				},

				/**
				 * ############## ######### ######### ####.
				 * @private
				 */
				getToolsMenuItems: function() {
					var menuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					var communicationTypes = this.get("CommunicationTypes");
					var phonesMenuItems = Ext.create("Terrasoft.BaseViewModelCollection");
					var socialNetworksMenuItems = Ext.create("Terrasoft.BaseViewModelCollection");
					var phonesMenuItem = Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Caption: this.get("Resources.Strings.PhoneMenuItem"),
							Id: Terrasoft.utils.generateGUID(),
							Items: phonesMenuItems
						}
					});
					var socialNetworksMenuItem = Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Caption: this.get("Resources.Strings.SocialNetworksMenuItem"),
							Id: Terrasoft.utils.generateGUID(),
							Items: socialNetworksMenuItems
						}
					});
					communicationTypes.each(function(item) {
						var menuItem = this.getButtonMenuItem(item);
						var typeId = item.get("Id");
						if (this.isPhoneType(typeId)) {
							phonesMenuItems.addItem(menuItem);
							return;
						}
						if (this.isSocialNetworkType(typeId)) {
							socialNetworksMenuItems.addItem(menuItem);
							return;
						}
						menuItems.addItem(menuItem);
					}, this);

					menuItems.addItem(phonesMenuItem);
					menuItems.addItem(socialNetworksMenuItem);
					var restrictionsItem = this.getRestrictionsMenuItem();
					menuItems.addItem(restrictionsItem);
					return menuItems;
				},

				/**
				 * ########## ##### #### #### "###### ## #########".
				 * @protected
				 * @return {Terrasoft.BaseViewModel} ###### ############# ###### ####.
				 */
				getRestrictionsMenuItem: function() {
					var restrictionsMenuItems = Ext.create("Terrasoft.BaseViewModelCollection");
					var restrictionsItem = Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Caption: this.get("Resources.Strings.DoNotUseCommunicationCaption"),
							Id: Terrasoft.utils.generateGUID(),
							Items: restrictionsMenuItems
						}
					});
					var restrictions = this.getRestrictions();
					Terrasoft.each(restrictions, function(restrictionConfig, restrictionName) {
						var restrictionMenuItem = this.Ext.create("Terrasoft.BaseViewModel", {
							values: {
								Id: Terrasoft.utils.generateGUID(),
								Caption: restrictionConfig.Caption,
								Tag: restrictionName,
								Click: { bindTo: "doNotUseCommunication" }
							}
						});
						restrictionsMenuItems.addItem(restrictionMenuItem);
					}, this);
					return restrictionsItem;
				},

				/**
				 * ########## ####### ## #############.
				 * @protected
				 * @return {Object} ######, ####### ######## ######## ######## ## #############.
				 */
				getRestrictions: function() {
					return {
						"DoNotUseEmail": {
							"RestrictCaption": this.get("Resources.Strings.DoNotUseEmail"),
							"Caption": this.get("Resources.Strings.DoNotUseEmailCaption")
						},
						"DoNotUseCall": {
							"RestrictCaption": this.get("Resources.Strings.DoNotUseCall"),
							"Caption": this.get("Resources.Strings.DoNotUseCallCaption")
						},
						"DoNotUseSms": {
							"RestrictCaption": this.get("Resources.Strings.DoNotUseSms"),
							"Caption": this.get("Resources.Strings.DoNotUseSmsCaption")
						},
						"DoNotUseFax": {
							"RestrictCaption": this.get("Resources.Strings.DoNotUseFax"),
							"Caption": this.get("Resources.Strings.DoNotUseFaxCaption")
						},
						"DoNotUseMail": {
							"RestrictCaption": this.get("Resources.Strings.DoNotUseMail"),
							"Caption": this.get("Resources.Strings.DoNotUseMailCaption")
						}
					};
				},

				getButtonMenuItem: function(item) {
					var name = item.get("Name");
					var value = item.get("Id");
					return Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Id: value,
							Caption: name,
							Tag: value,
							Click: { bindTo: "addItem" }
						}
					});
				},

				/**
				 * ########## ####### ####### #### ######## ## ############# ####### #####.
				 * @param {String} tag ##### ###### ####.
				 */
				doNotUseCommunication: function(tag) {
					if (this.get("IsDetailCollapsed")) {
						return;
					}
					var restrictions = this.getRestrictions();
					var collection = this.get("RestrictionsCollection");
					if (!collection.contains(tag)) {
						collection.add(tag, this.getRestrictionsCollectionItem(tag, restrictions[tag].RestrictCaption));
						this.changeCardPageButtonsVisibility(true);
					}
				},

				/**
				 * ########## ##### ######### CheckBox-#.
				 */
				onCheckChange: function() {
					this.setSaveDiscardButtonsVisible(true);
				},

				/**
				 * ########## ############ ######## "###### ## #############".
				 * @param {Object} itemConfig ###### ## ############ ######## # ContainerList.
				 * @param {Terrasoft.BaseViewModel} item #######, ### ######## ###### ########## ########## view.
				 */
				getRestrictionsItemConfig: function(itemConfig, item) {
					//todo: lazy init
					var config = ViewUtilities.getContainerConfig(
							"restrictions-container", ["restrictions-container-class", "control-width-15"]);
					itemConfig.config = config;
					var checkBoxLabelConfig = {
						className: "Terrasoft.Label",
						caption: {bindTo: "Name"},
						classes: {labelClass: ["detail-label-user-class"]},
						inputId: item.get("Id") + "-el"
					};
					var checkBoxEditConfig = {
						className: "Terrasoft.CheckBoxEdit",
						id: item.get("Id"),
						checked: {bindTo: "Value"},
						checkedchanged: {bindTo: "onCheckChange"}
					};
					config.items.push(checkBoxLabelConfig, checkBoxEditConfig);
				},

				/**
				 * ########## ############ ######## ######## #####.
				 * @param {Object} itemConfig ###### ## ############ ######## # ContainerList.
				 * @private
				 */
				getItemViewConfig: function(itemConfig) {
					var itemViewConfig = this.get("itemViewConfig");
					if (itemViewConfig) {
						itemConfig.config = itemViewConfig;
						return;
					}
					var config = ViewUtilities.getContainerConfig("item-view",
						["detail-edit-container-user-class", "control-width-15"]);
					var typeMenuItems = [];
					var communicationTypes = this.get("CommunicationTypes");
					communicationTypes.each(function(item) {
						var name = item.get("Name");
						var value = item.get("Id");
						typeMenuItems.push({
							id: value,
							caption: name,
							tag: value,
							click: { bindTo: "typeChanged" }
						});
					}, this);
					var typeButtonConfig = {
						id: "type",
						className: "Terrasoft.Button",
						classes: {
							wrapperClass: ["label-wrap", "detail-type-btn-user-class"],
							textClass: ["detail-type-btn-inner-user-class"]
						},
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						selectors: {wrapEl: "#type"},
						caption: {
							bindTo: "CommunicationType",
							bindConfig: { converter: "typedStringValueConverter" }
						},
						menu: { items: typeMenuItems }
					};
					var deleteButtonConfig = {
						id: "delete",
						className: "Terrasoft.Button",
						classes: {
							wrapperClass: "detail-delete-btn-user-class",
							imageClass: ["detail-delete-btn-image-user-class", "close-button-background-no-repeat"]
						},
						imageConfig: resources.localizableImages.DeleteIcon,
						style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						selectors: {wrapEl: "#delete"},
						click: {bindTo: "deleteItem"}
					};
					var editConfig = {
						id: "edit",
						className: "Terrasoft.TextEdit",
						classes: {wrapClass: ["communication-lookup-img-user-class", "detail-edit-user-class"]},
						rightIconClasses: ["lookup-edit-right-icon"],
						value: { bindTo: "Number" },
						readonly: {
							bindTo: "CommunicationType",
							bindConfig: { converter: "isSocialNetworkType" }
						},
						enableRightIcon: {
							bindTo: "CommunicationType",
							bindConfig: { converter: "isSocialNetworkType" }
						},
						rightIconClick: { bindTo: "onLookUpClick" }
					};
					config.items.push(typeButtonConfig, editConfig, deleteButtonConfig);
					itemConfig.config = config;
					this.set("itemViewConfig", config);
				},

				/**
				 * ####### ####### ######### "###### ## #############".
				 * @param {String} id ############# ####### ## #############.
				 * @param {String} name ### ####### ## #############.
				 * @return {Terrasoft.BaseViewModel} ###### ############# ########## ########.
				 */
				getRestrictionsCollectionItem: function(id, name) {
					var collectionItem = Ext.create("Terrasoft.BaseViewModel", {
						values: {
							Name: name,
							Id: id,
							Value: true
						}
					});
					collectionItem.sandbox = this.sandbox;
					collectionItem.onCheckChange = this.onCheckChange;
					collectionItem.setSaveDiscardButtonsVisible = this.setSaveDiscardButtonsVisible;
					return collectionItem;
				},

				/**
				 * ######### ######### "###### ## #############".
				 */
				getEntityRestrictions: function() {
					var restrictions = ["DoNotUseEmail", "DoNotUseCall", "DoNotUseSms", "DoNotUseFax", "DoNotUseMail"];
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "Contact"});
					Terrasoft.each(restrictions, function(item) {
						select.addColumn(item);
					}, this);
					select.getEntity(this.get("MasterRecordId"), function(response) {
						if (!response.success) {
							return;
						}
						var entity = response.entity;
						var collection = this.get("RestrictionsCollection");
						collection.clear();
						Terrasoft.each(restrictions, function(restrictionName) {
							if (entity.get(restrictionName)) {
								var restrictionCaption = this.get("Resources.Strings." + restrictionName);
								var restrictionsCollectionItem =
									this.getRestrictionsCollectionItem(restrictionName, restrictionCaption);
								collection.add(restrictionName, restrictionsCollectionItem);
							}
						}, this);
					}, this);
				},

				/**
				 * ######### ######## #####.
				 * @private
				 * @param {Function} callback ####### ######### ######.
				 * @param {Terrasoft.BaseSchemaViewModel} scope ######## ########## ####### ######### ######.
				 */
				loadContainerListData: function(callback, scope) {
					if (this.get("IsDetailCollapsed")) {
						callback.call(scope);
						return;
					}
					var collection = this.get("Collection");
					collection.clear();
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchema: this.entitySchema,
						rowViewModelClassName: "Terrasoft.BaseCommunicationViewModel"
					});
					select.addColumn(this.primaryDisplayColumnName);
					var createdOnColumn = select.addColumn("CreatedOn");
					createdOnColumn.orderDirection = Terrasoft.OrderDirection.ASC;
					select.addColumn("Id");
					select.addColumn("CommunicationType");
					select.addColumn("Position");
					select.addColumn("SocialMediaId");
					select.addColumn("SearchNumber");
					select.addColumn("Contact");
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"[CommunicationType:Id:CommunicationType].UseforContacts", true));
					select.filters.addItem(this.get("Filter"));
					select.getEntityCollection(function(response) {
						if (response.success) {
							var entityCollection = response.collection;
							var communicationTypes = this.get("CommunicationTypes");
							entityCollection.each(function(item) {
								item.columns = this.columns;
								item.sandbox = this.sandbox; // todo: ### ### ContainerList
								item.set("CommunicationTypes", communicationTypes);
							}, this);
							collection.loadAll(entityCollection);
							this.set("IsDataLoaded", true);
						}
						callback.call(scope);
					}, this);
					this.getEntityRestrictions();
				},

				/**
				 * ########## ###### "#########" # "######" ########, ## ####### ######### ######.
				 * @param {Boolean} isVisible #### ######, ## ###### "#########" # "######" ######## ############.
				 */
				setSaveDiscardButtonsVisible: function(isVisible) {
					var options = ["ShowSaveButton", "ShowDiscardButton"];
					Terrasoft.each(options, function(option) {
						this.sandbox.publish("UpdateCardProperty", {
							key: option,
							value: isVisible
						}, [this.sandbox.id]);
					}, this);
				},

				/**
				 * ########## ###### "#########" # "######" ########, ## ####### ######### ######.
				 * @param {Boolean} isVisible #### ######, ## ###### "#########" # "######" ######## ############.
				 */
				changeCardPageButtonsVisibility: function(isVisible) {
					this.setSaveDiscardButtonsVisible(isVisible);
				},

				/**
				 * ########## ######### ######## #####.
				 * @param {Terrasoft.BaseViewModel} item ########## #######.
				 * @param {Object} config ######## ######## ######### ########.
				 */
				onItemChanged: function(item, config) {
					if (config && config.OperationType === "Delete") {
						this.deleteItem(item);
					}
					this.changeCardPageButtonsVisibility(true);
				},

				/**
				 * ####### ######## ##### # ######.
				 * @param {Terrasoft.BaseViewModel} item ######## #####.
				 */
				deleteItem: function(item) {
					var deletedItems = this.get("DeletedItems");
					var collection = this.get("Collection");
					collection.removeByKey(item.get("Id"));
					deletedItems.addItem(item);
				},

				/**
				 * ######### ######## ##### ## ######.
				 * @private
				 * @param {String} tag ############# ######## #####.
				 * return {Terrasoft.BaseCommunicationViewModel} ######## #####.
				 */
				addItem: function(tag) {
					if (this.get("IsDetailCollapsed")) {
						return;
					}
					var communicationTypes = this.get("CommunicationTypes");
					var communicationType = communicationTypes.get(tag);
					var newItem = this.Ext.create("Terrasoft.BaseCommunicationViewModel", {
						entitySchema: this.entitySchema,
						columns: this.columns
					});
					newItem.set("CommunicationTypes", communicationTypes);
					newItem.sandbox = this.sandbox;
					newItem.setDefaultValues(function() {
						newItem.set("CommunicationType", {
							value: communicationType.get("Id"),
							displayValue: communicationType.get("Name")
						});
						newItem.set("Contact", {
							value: this.get("MasterRecordId")
						});
						var itemKey = newItem.get("Id");
						var collection = this.get("Collection");
						collection.add(itemKey, newItem);
						this.changeCardPageButtonsVisibility(true);
					}, this);
					return newItem;
				},

				/**
				 * ######### ######## ###### ######.
				 * @private
				 */
				loadData: function(callback, scope) {
					this.initCommunicationTypes(function() {
						var toolsMenuItems = this.getToolsMenuItems();
						var menuItems = this.get("ToolsMenuItems");
						menuItems.clear();
						menuItems.loadAll(toolsMenuItems);
						this.loadContainerListData(callback, scope);
					}, this);
				},

				/**
				 * ############## #########.
				 */
				initCollections: function() {
					var collection = this.get("Collection");
					collection.on("itemChanged", this.onItemChanged, this);
					this.set("ToolsMenuItems", this.Ext.create("Terrasoft.BaseViewModelCollection"));
					this.set("RestrictionsCollection", Ext.create("Terrasoft.BaseViewModelCollection"));
					this.set("DeletedItems",
						this.Ext.create("Terrasoft.BaseViewModelCollection", { entitySchema: this.entitySchema }));
				},

				initCommunicationTypes: function(callback, scope) {
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "CommunicationType"});
					select.addColumn("Id");
					select.addColumn("Name");
					select.filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
						"UseforContacts", true));
					select.getEntityCollection(function(response) {
						if (response.success) {
							var entityCollection = response.collection;
							this.set("CommunicationTypes", entityCollection);
						}
						callback.call(scope);
					}, this);
				},

				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("ResultSelectedRows", this.save, this, [this.sandbox.id]);
					this.sandbox.subscribe("ValidateDetail", this.validateDetail, this, [this.sandbox.id]);
					this.sandbox.subscribe("SaveDetail", this.save, this, [this.sandbox.id]);

				},

				validateDetail: function() {
					var resultObject = {
						success: this.validateItems()
					};
					if (!resultObject.success) {
						resultObject.message = this.getValidationMessage();
					}
					this.sandbox.publish("DetailValidated", resultObject, [this.sandbox.id]);
					return true;
				},

				getValidationMessage: function(message) {
					var messageTemplate = this.get("Resources.Strings.ValidationErrorTemplate");
					return this.Ext.String.format(messageTemplate,
						this.get("Resources.Strings.DetailCaption") + (message ? ":" + message : ""));
				},

				/**
				 * ############## ######.
				 * @private
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.initCollections();
						this.loadData(callback, scope);
					}, this]);
				},

				/**
				 * ########## ############# # ########### ######.
				 * @param {Boolean} isCollapsed ######### ## ######.
				 * @private
				 */
				onDetailCollapsedChanged: function(isCollapsed) {
					this.callParent(arguments);
					this.set("IsDetailCollapsed", isCollapsed);
					if (!isCollapsed && !this.get("IsDataLoaded")) {
						this.loadContainerListData(Terrasoft.emptyFn);
					}
				},

				/**
				 * ######### ######.
				 * @private
				 */
				updateDetail: function() {
					this.callParent(arguments);
					var detailInfo = this.sandbox.publish("GetDetailInfo", null, [this.sandbox.id]) || {};
					this.set("MasterRecordId", detailInfo.masterRecordId);
					this.set("DetailColumnName", detailInfo.detailColumnName);
					this.set("Filter", detailInfo.filter);
					this.set("CardPageName", detailInfo.cardPageName);
					this.set("SchemaName", detailInfo.schemaName);
					this.set("DefaultValues", detailInfo.defaultValues);
					this.set("IsDataLoaded", false);
					this.loadContainerListData(Terrasoft.emptyFn);
					var deletedItems = this.get("DeletedItems");
					deletedItems.clear();
				},

				/**
				 * ######### ######### ### ######## ## ############# ####### #####.
				 */
				getSaveRestrictionsQuery: function() {
					var collection = this.get("RestrictionsCollection");
					if (collection.isEmpty()) {
						return null;
					}
					var update = Ext.create("Terrasoft.UpdateQuery", { rootSchemaName: "Contact" });
					update.enablePrimaryColumnFilter(this.get("MasterRecordId"));
					collection.each(function(item) {
						update.setParameterValue(item.get("Id"), item.get("Value"), Terrasoft.DataValueType.BOOLEAN);
					}, this);
					return update;
				},

				/**
				 * ####### ######## #####.
				 */
				getDeleteItemsQueries: function() {
					var deletedItems = this.get("DeletedItems");
					var deleteQueries = [];
					deletedItems.each(function(item) {
						var primaryColumnValue = item.get(item.primaryColumnName);
						var deleteQuery = item.getDeleteQuery();
						deleteQuery.enablePrimaryColumnFilter(primaryColumnValue);
						deleteQueries.push(deleteQuery);
					}, this);
					return deleteQueries;
				},

				/**
				 * ######### ########## # ##### ######## #####.
				 */
				getSaveItemsQueries: function() {
					var collection = this.get("Collection");
					var saveQueries = [];
					collection.each(function(item) {
						if (item.isChanged() && item.validate()) {
							saveQueries.push(item.getSaveQuery());
						}
					}, this);
					return saveQueries;
				},

				validateItems: function() {
					var collection = this.get("Collection");
					var result = true;
					collection.each(function(item) {
						return (result = !item.isChanged() || item.validate());
					}, this);
					return result;
				},

				/**
				 * ######### ######### ######. ########### ### ####### ## ###### ######### ########, ####### ########
				 * ######.
				 */
				save: function() {
					var restrictionsQuery = this.getSaveRestrictionsQuery();
					var queries = restrictionsQuery ? [restrictionsQuery] : [];
					var saveQueries = this.getSaveItemsQueries();
					queries = queries.concat(saveQueries);
					var deleteQueries = this.getDeleteItemsQueries();
					queries = queries.concat(deleteQueries);
					if (Ext.isEmpty(queries)) {
						this.publishSaveResponse({
							success: true
						});
						return true;
					}
					var batchQuery = Ext.create("Terrasoft.BatchQuery");
					Terrasoft.each(queries, function(query) {
						batchQuery.add(query);
					}, this);
					batchQuery.execute(this.onSaved, this);
					return true;
				},

				onSaved: function(response) {
					var message = response.ResponseStatus && response.ResponseStatus.Message;
					if (response.success && !message) {
						var deletedItems = this.get("DeletedItems");
						var collection = this.get("Collection");
						collection.each(function(item) {
							item.isNew = false;
							item.changedValues = null;
						}, this);
						deletedItems.clear();
						this.publishSaveResponse(response);
					} else {
						this.publishSaveResponse({
							success: false,
							message: this.getValidationMessage(message)
						});
					}
				},

				publishSaveResponse: function(config) {
					this.sandbox.publish("DetailSaved", config, [this.sandbox.id]);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Detail",
					"values": {
						caption: {bindTo: "Resources.Strings.DetailCaption"}
					}
				},
				{
					"operation": "insert",
					"name": "CommunicationsContainer",
					"parentName": "Detail",
					"propertyName": "items",
					"values":
					{
						generator: "ConfigurationItemGenerator.generateContainerList",
						idProperty: "Id",
						collection: "Collection",
						observableRowNumber: 10,
						onGetItemConfig: "getItemViewConfig"
					}
				},
				{
					"operation": "insert",
					"name": "RestrictionsContainer",
					"parentName": "Detail",
					"propertyName": "items",
					"values":
					{
						generator: "ConfigurationItemGenerator.generateContainerList",
						idProperty: "Id",
						collection: "RestrictionsCollection",
						observableRowNumber: 10,
						onGetItemConfig: "getRestrictionsItemConfig"
					}
				},
				{
					"operation": "insert",
					"name": "AddButton",
					"parentName": "Detail",
					"propertyName": "tools",
					"values": {
						visible: {bindTo: "getToolsVisible"},
						itemType: Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.AddButtonCaption"},
						controlConfig: {
							menu: {
								items: {bindTo: "ToolsMenuItems"}
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});


