define("CtiPanel", ["terrasoft", "ProcessModuleUtilities", "CtiConstants", "CtiPanelResources",
		"ContainerListGenerator", "css!CTIProcessActionsCSS"],
	function(Terrasoft, ProcessModuleUtilities, CtiConstants, Resources) {
		return {
			attributes: {
				/**
				 * ######### ####### ######## ####### ######### cti ######.
				 * @private
				 * @type {Terrasoft.Collection}
				 */
				"ProcessActionsCollection": {
					"dataValueType": Terrasoft.DataValueType.COLLECTION
				},

				/**
				 * ######### ######## ####### #########.
				 * @private
				 * @type {Boolean}
				 */
				"IsProcessActionExists": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				},

				/**
				 * ####### ####, ### ####### ########## - ######## ####### ######.
				 * @private
				 * @type {Boolean}
				 */
				"IsCurrentUserContactCenterOperator": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"value": false
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * ############# ######### ###### ######## ## ####### #########.
				 * @private
				 * @param {Function} callback ####### ######### ######.
				 */
				setProcessActionsVisibility: function(callback) {
					Terrasoft.SysSettings.querySysSettings(["ContactCenterOperatorsFolder"],
						function(sysSettingsValue) {
							var contactCenterOperatorsFolder = sysSettingsValue.ContactCenterOperatorsFolder;
							if (Ext.isEmpty(contactCenterOperatorsFolder)) {
								return;
							}
							var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
								rootSchemaName: "SysUserInRole"
							});
							esq.addAggregationSchemaColumn("Id", Terrasoft.AggregationType.COUNT, "Count");
							esq.filters.add("ContactCenterOperatorsFilter", Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "SysRole", contactCenterOperatorsFolder.value));
							esq.filters.add("CurrentUserFilter", Terrasoft.createColumnFilterWithParameter(
								Terrasoft.ComparisonType.EQUAL, "SysUser", Terrasoft.SysValue.CURRENT_USER.value));
							esq.getEntityCollection(function(result) {
								if (!result.success) {
									return;
								}
								var item = result.collection.getByIndex(0);
								this.set("IsCurrentUserContactCenterOperator", item.get("Count") > 0);
								callback();
							}, this);
						}, this);
				},

				/**
				 * ######### ## ## ###### ########.
				 * @private
				 * @param {Function} callback ####### ######### ######. ########## ### ###### ###### ########.
				 */
				selectProcessActions: function(callback) {
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "CTIProcessAction"
					});
					esq.isDistinct = true;
					esq.addColumn("Id", "Id");
					esq.addColumn("Name", "Name");
					esq.addColumn("ProcessSchema.Name", "ProcessSchemaName");
					var positionColumn = esq.addColumn("Position");
					positionColumn.orderDirection = Terrasoft.OrderDirection.ASC;
					esq.getEntityCollection(function(result) {
						if (!result.success) {
							return;
						}
						var actions = result.collection;
						actions.each(function(action) {
							callback(action);
						});
					});
				},

				/**
				 * Add new action to cti panel actions.
				 * @protected
				 * @param {Terrasoft.BaseViewModel} entity Action entity.
				 * @param {Terrasoft.Collection} actions Cti panel actions.
				 */
				addProcessAction: function(entity, actions) {
					const actionId = entity.get("Id");
					const action = Ext.create("Terrasoft.BaseViewModel", {
						values: {
							"Id": actionId,
							"Name": entity.get("Name"),
							"ProcessName": entity.get("ProcessSchemaName")
						},
						methods: {
							onProcessActionClick: function() {
								let processName = this.get("ProcessName");
								let parameters = this.getActionProcessParameters(processName);
								ProcessModuleUtilities.runProcess(processName, parameters);
							},
							getActionProcessParameters: this.getActionProcessParameters.bind(this)
						}
					});
					action.sandbox = this.sandbox;
					actions.add(actionId, action);
					this.set("IsProcessActionExists", true);
				},

				/**
				 * Gets process run parameters.
				 * @private
				 * @return {Object} parameters Process run parameters.
				 * @return {String} parameters.PhoneNumber Phone number.
				 * @return {Guid} parameters.DatabaseUId Call unique identifier.
				 * @return {String} [parameters.ContactId] Contact identifier.
				 * @return {String} [parameters.AccountId] Account identifier.
				 */
				getActionProcessParameters: function() {
					let parameters = {
						PhoneNumber: this.getLastAbonentNumber(),
						CallId: this.getCurrentDatabaseUId()
					};
					const subscriberKey = this.get("IdentifiedSubscriberKey");
					if (!subscriberKey) {
						return parameters;
					}
					const subscriberCollection = this.get("IdentifiedSubscriberPanelCollection");
					const subscriberPanel = subscriberCollection.get(subscriberKey);
					switch (subscriberPanel.get("Type")) {
						case CtiConstants.SubscriberTypes.Contact:
						case CtiConstants.SubscriberTypes.Employee:
							parameters.ContactId = subscriberPanel.get("Id");
							break;
						case CtiConstants.SubscriberTypes.Account:
							parameters.AccountId = subscriberPanel.get("Id");
							break;
						default:
							break;
					}
					return parameters;
				},

				/**
				 * ########## ########## ###### ######## ####### #########.
				 * @return {Boolean} #### ###### ######## ######## - true, ##### - false.
				 */
				getIsProcessActionsGroupVisible: function() {
					return this.get("IsProcessActionExists") && this.getIsCallExists();
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc CtiPanel#initCollections
				 * @overridden
				 */
				initCollections: function() {
					this.set("ProcessActionsCollection", Ext.create("Terrasoft.Collection"));
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc
				 * @protected
				 * @overridden
				 */
				initOnConnected: function() {
					this.callParent(arguments);
					this.setProcessActionsVisibility(this.loadProcessActions.bind(this));
				},

				/**
				 * ######### ########### ######## ####### #########.
				 * @protected
				 */
				loadProcessActions: function() {
					var actions = this.get("ProcessActionsCollection");
					if (!actions.isEmpty() || !this.get("IsCurrentUserContactCenterOperator")) {
						return;
					}
					this.selectProcessActions(function(entity) {
						this.addProcessAction(entity, actions);
					}.bind(this));
				}

				//endregion

			},
			diff: [
				{
					"operation": "insert",
					"parentName": "ctiPanelMainContainer",
					"name": "ProcessActionsGroupContainer",
					"propertyName": "items",
					"values": {
						"id": "ProcessActionsGroupContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "ProcessActionsGroupContainer",
					"name": "ProcessActionsGroup",
					"propertyName": "items",
					"values": {
						"id": "ProcessActionsGroup",
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"markerValue": "ProcessActionsGroup",
						"selectors": {"wrapEl": "#ProcessActionsGroup"},
						"caption": {"bindTo": "Resources.Strings.ProcessActionsGroupCaption"},
						"visible": {"bindTo": "getIsProcessActionsGroupVisible"},
						"items": [],
						"controlConfig": {
							"collapsed": false
						}
					}
				},
				{
					"operation": "insert",
					"name": "ProcessActionsListContainer",
					"parentName": "ProcessActionsGroup",
					"propertyName": "items",
					"values": {
						"id": "ProcessActionsListContainer",
						"itemType": Terrasoft.ViewItemType.GRID,
						"markerValue": "ProcessActionsListContainer",
						"selectors": {"wrapEl": "#ProcessActionsListContainer"},
						"idProperty": "Id",
						"collection": {"bindTo": "ProcessActionsCollection"},
						"generator": "ContainerListGenerator.generatePartial",
						"defaultItemConfig": {
							"className": "Terrasoft.Container",
							"id": "processActionContainer",
							"classes": {
								"wrapClassName": ["cti-process-action-container"]
							},
							"items": [
								{
									"className": "Terrasoft.Button",
									"caption": {"bindTo": "Name"},
									"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
									"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
									"classes": {
										"wrapperClass": ["cti-process-action-button"],
										"textClass": "cti-process-action-button-text",
										"imageClass": "cti-process-action-button-image"
									},
									"imageConfig": Resources.localizableImages.ProcessActionImage,
									"click": {"bindTo": "onProcessActionClick"},
									"markerValue": {"bindTo": "Name"}
								}
							]
						}
					}
				}
			]
		};
	}
);
