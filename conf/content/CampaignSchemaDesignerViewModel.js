﻿Terrasoft.configuration.Structures["CampaignSchemaDesignerViewModel"] = {innerHierarchyStack: ["CampaignSchemaDesignerViewModel"]};
define("CampaignSchemaDesignerViewModel", ["CampaignSchemaDesignerViewModelResources", "CampaignConnectorManager",
		"CampaignFlowSchemaValidator", "CampaignElementMixin", "CampaignSchemaManager",
		"CampaignElementSchemaManager", "AcademyUtilities", "CampaignSchemaDesignerViewModelMixin"],
	function(resources, campaignConnectorManager, campaignFlowSchemaValidator) {
	/**
	 * @class Terrasoft.Designers.CampaignSchemaDesignerViewModel
	 */
	Ext.define("Terrasoft.Designers.CampaignSchemaDesignerViewModel", {
		extend: "Terrasoft.Designers.ProcessSchemaDesignerViewModel",
		alternateClassName: "Terrasoft.CampaignSchemaDesignerViewModel",

		mixins: {
			campaignElementMixin: "Terrasoft.CampaignElementMixin",
			schemaDesignerMixin: "Terrasoft.CampaignSchemaDesignerViewModelMixin"
		},

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#schemaManager
		 * @overridden
		 */
		schemaManager: Terrasoft.CampaignSchemaManager,

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#contextHelpCode
		 * @overridden
		 */
		contextHelpCode: "CampaignDesigner",

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#urlHashPrefix
		 * @overridden
		 */
		urlHashPrefix: "campaign",

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesignerViewModel#elementSchemaManager
		 * @overridden
		 */
		elementSchemaManager: Terrasoft.CampaignElementSchemaManager,

		/**
		 * Instance of CampaignConnectorManager
		 * @type {Terrasoft.CampaignConnectorManager}
		 */
		connectorManager: campaignConnectorManager,

		/**
		 * Instance of CampaignFlowSchemaValidator
		 * @type {Terrasoft.CampaignFlowSchemaValidator}
		 */
		flowSchemaValidator: campaignFlowSchemaValidator,

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#onSchemaLoaded
		 * @overridde
		 */
		onSchemaLoaded: function(schema) {
			this.mixins.schemaDesignerMixin.onSchemaLoaded.call(this, schema);
		},

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#onItemDrop
		 * @override
		 */
		onItemDrop: function(event) {
			var item = event.element.tag.element;
			var itemInstance = this.elementSchemaManager.createInstance(item.managerItemUId);
			if (!itemInstance.emptyDiagramCaption) {
				var caption = itemInstance.caption.getValue();
				if (!caption) {
					caption = item.caption.getValue();
				}
				itemInstance.caption = Ext.create("Terrasoft.LocalizableString", {cultureValues: caption});
			}
			var itemContainer = this.$Schema.findItemByName(event.containerName);
			itemInstance.containerUId = itemContainer.uId;
			itemInstance.parent = itemContainer.name;
			itemInstance.uId = Terrasoft.generateGUID();
			itemInstance.position = itemInstance.getCenterPosition(event.localX, event.localY);
			itemInstance.isValidateExecuted = false;
			this.onGenerateItemNameAndCaption(itemInstance);
			var items = this.get("Items");
			items.add(itemInstance.name, itemInstance);
			this.loadPropertiesPage(itemInstance.name);
			return false;
		},

		/**
		 * @inheritdoc Terrasoft.core.mixins.ProcessSchemaDesignerCopyMixin#createItemCopy
		 * @overriden
		 */
		createItemCopy: function() {
			var item = this.callParent(arguments);
			return item.prepareCopy();
		},

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#onConnectorsNodesChange
		 * @overridden
		 * Change transition connections. If targetNode is empty (targetRefUId is empty guid), shows sequence flow element
		 * properties page, if panel is visible.
		 * else creates new connector with specific type we needed
		 * @private
		 * @param {Object[]} connectors Sequence flow diagram config array.
		 */
		onConnectorsNodesChange: function(connectors) {
			Terrasoft.each(connectors, function(connector) {
				var transition = this.getItemByName(connector.name);
				var targetItem = this.getItemByName(connector.targetNode);
				var sourceItem = this.getItemByName(connector.sourceNode);
				var isNewTransition = Terrasoft.isEmptyGUID(transition.targetRefUId);
				if (!isNewTransition &&
						transition.flowType === Terrasoft.ProcessSchemaEditSequenceFlowType.CONDITIONAL &&
						transition.sourceRefUId !== sourceItem.uId) {
					this.updateConnector(transition, sourceItem, targetItem);
				}
				this.updateSourceAndTarget(transition, connector, sourceItem, targetItem);
				this.loadPropertiesPage(connector.name);
			}, this);
			this.clearSearchResult();
		},

		/**
		 * Updates transition type if needed.
		 * @param  {Terrasoft.SequenceFlowelement} transition current transition.
		 * @param  {CampaignSchemaElement} sourceItem source element.
		 * @param  {CampaignSchemaElement} targetItem target element.
		 * @return {void}
		 */
		updateConnector: function(transition, sourceItem, targetItem) {
			var diagramElements = this.get("Items");
			var oldName = transition.name;
			diagramElements.remove(transition);
			transition = this.connectorManager.createTransition(transition,
					sourceItem, targetItem);
			transition.name = oldName;
			diagramElements.add(oldName, transition);
		},

		/**
		 * Sets new source and target data parameters
		 * @param  {Terrasoft.SequenceFlowelement} transition current transition
		 * @param  {object} connector Connector object
		 * @param  {CampaignSchemaElement} sourceItem source element
		 * @param  {CampaignSchemaElement} targetItem target element
		 * @return {void}
		 */
		updateSourceAndTarget: function(transition, connector, sourceItem, targetItem) {
			transition.setSource({
				sourcePort: connector.sourcePort,
				sourceRefUId: sourceItem.uId
			});
			transition.setTarget({
				targetPort: connector.targetPort,
				targetRefUId: targetItem.uId
			});
		},

		/**
		 * @inheritdoc Terrasoft.BaseSchemaDesigner#onSandboxInitialized
		 * @overridde
		 */
		onSandboxInitialized: function() {
			this.callParent(arguments);
			this.registerSandboxMessages(this.sandbox);
		},

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesignerViewModel5X#onGenerateItemNameAndCaption
		 * @override
		 */
		onGenerateItemNameAndCaption: function(item) {
			var items = this.get("Items");
			var index = 1;
			var defName = item.name;
			var defType = item.elementType;
			var key = defName + index;
			var inheritedElements = this.get("Schema").inheritedElements;
			while (this.containsCaseInsensitive(items, index, defType) ||
					this.containsCaseInsensitive(inheritedElements, index, defType)) {
				index++;
				key = defName + index;
			}
			item.name = key;
			var cultureValues = item.caption.cultureValues;
			Terrasoft.each(cultureValues, function(value, culture) {
				if (value) {
					cultureValues[culture] = value + " " + index;
				}
			});
			return false;
		},

		/**
		 * @inheritdoc Terrasoft.Designers.ProcessSchemaDesignerViewModel5X#containsCaseInsensitive
		 * @override
		 */
		containsCaseInsensitive: function(list, index, defType) {
			return list.collection.items.some(function(el) {
				var elementNumberStr = el.name.match(/\d/g).join("");
				var elementNumber = parseInt(elementNumberStr, 10);
				var elementType = el.elementType || "";
				return elementType.toUpperCase() === defType.toUpperCase() &&
					elementNumber === index;
			});
		},

		/**
		 * @inheritdoc Terrasoft.Designers.BaseProcessSchemaDesignerViewModel#validateViewModel
		 * @override
		 */
		validateViewModel: function(callback, scope) {
			this.mixins.schemaDesignerMixin.validateViewModel.call(this, callback, scope);
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#validate
		 * @override
		 */
		validate: function() {
			var baseResult = this.callParent(arguments);
			return this.mixins.schemaDesignerMixin.validate.call(this, baseResult);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesignerViewModel#getSchemaInstance
		 * @override
		 */
		getSchemaInstance: function(schemaUId, callback, scope) {
			var callbackFn = this.getSchemaInstanceCallbackFn(callback, scope);
			this.callParent([schemaUId, callbackFn, scope]);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesignerViewModel#onAfterSchemaSaved
		 * @override
		 */
		onAfterSchemaSaved: function() {
			this.callParent(arguments);
			this.mixins.schemaDesignerMixin.onAfterSchemaSaved.call(this);
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesignerViewModel#handleCtrlAltKeyDown
		 * @override
		 */
		handleCtrlAltKeyDown: function(event) {
			return false;
		},

		/**
		 * @inheritdoc Terrasoft.BaseProcessSchemaDesignerViewModel#getSaveButtonMenuItems
		 * @override
		 */
		getSaveButtonMenuItems: function() {
			return [];
		}
	});
	return Terrasoft.CampaignSchemaDesignerViewModel;
});


