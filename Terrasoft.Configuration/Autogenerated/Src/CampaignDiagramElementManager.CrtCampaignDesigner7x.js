define("CampaignDiagramElementManager", ["CampaignElementShapeForm", "CampaignEnums",
		"CampaignElementSchemaManager"], function(campaignElementShapeForm, CampaignEnums) {
	Ext.define("Terrasoft.manager.CampaignDiagramElementManager", {
		extend: "Terrasoft.core.BaseObject",
		alternateClassName: "Terrasoft.CampaignDiagramElementManager",

		singleton: true,

		/**
		 * Collection of available campaign diagram elements.
		 * @private
		 */
		_items: new Terrasoft.Collection(),

		/**
		 * Flag to indicate that instance of manager is initialized.
		 * @type {Boolean}
		 */
		initialized: false,

		/**
		 * @private
		 */
		_isElement: function(item) {
			return item.nodeType !== Terrasoft.diagram.UserHandlesConstraint.Lane
				&& item.nodeType !== Terrasoft.diagram.UserHandlesConstraint.LaneSet;
		},

		/**
		 * @private
		 */
		_getDiagramNodeType: function(element) {
			if (element.nodeType === Terrasoft.diagram.UserHandlesConstraint.Connector) {
				return null;
			}
			if (element.incomingConnectionsLimit === 0) {
				return CampaignEnums.CampaignDiagramNodeTypes.START;
			}
			if (element.outgoingConnectionsLimit === 0
					|| Terrasoft.isEmpty(element.getConnectionUserHandles())) {
				return CampaignEnums.CampaignDiagramNodeTypes.END;
			}
			return CampaignEnums.CampaignDiagramNodeTypes.INTERMEDIATE;
		},

		/**
		 * @private
		 */
		_createDiagramItem: function(element) {
			var typeName = element.name;
			if (element.nodeType === Terrasoft.diagram.UserHandlesConstraint.Connector) {
				typeName = "connection";
			}
			return {
				type: typeName,
				className: element.typeName,
				schemaInstanceId: element.instanceId,
				paletteImage: element.smallImage && Terrasoft.ImageUrlBuilder.getUrl(element.smallImage),
				titleImage: element.largeImage && Terrasoft.ImageUrlBuilder.getUrl(element.largeImage),
				caption: element.caption.toString(),
				size: element.size,
				shapeFormType: campaignElementShapeForm.convertNodeTypeInShapeForm(element.nodeType),
				diagramNodeType: this._getDiagramNodeType(element)
			};
		},

		/**
		 * @private
		 */
		_initItems: function() {
			var items = new Terrasoft.Collection();
			var elements = Terrasoft.CampaignElementSchemaManager.getItems();
			Terrasoft.each(elements, function(element) {
				if (this._isElement(element.instance)) {
					var diagramItem = this._createDiagramItem(element.instance);
					items.add(diagramItem.className, diagramItem);
				}
			}, this);
			this._items.reloadAll(items);
		},

		/**
		 * Initializes diagram elements collection based on campaign element schema manager.
		 */
		initialize: function(callback, scope) {
			var callbackFn = function() {
				this._initItems();
				this.initialized = true;
				callback.call(scope);
			};
			if (!Terrasoft.CampaignElementSchemaManager.initialized) {
				Terrasoft.CampaignElementSchemaManager.initialize(callbackFn, this);
			} else {
				callbackFn.call(this);
			}
		},

		/**
		 * Returns collection of all campaign giagram elements.
		 * @throws {Terrasoft.exceptions.InvalidObjectState} Throws Terrasoft.exceptions.InvalidObjectState
		 * if manager have not been initialized yet.
		 * @returns {Terrasoft.Collection} Items.
		 */
		getItems: function() {
			if (!this.initialized) {
				throw new Terrasoft.exceptions.InvalidObjectState();
			}
			return this._items;
		},

		/**
		 * Returns collection of campaign elements.
		 * @returns {Terrasoft.Collection} Items.
		 */
		getDiagramElements: function() {
			return this._items.filterByFn(function(x) {
				return x.type !== "connection";
			});
		},

		/**
		 * Returns item by specific element class name.
		 * @param {String} typeName Diagram element type name.
		 * @returns {Object} Diagram item.
		 */
		findItemByClassName: function(className) {
			return this._items.findByFn(function(item) {
				return item.className === className;
			});
		}
	});
	return Terrasoft.CampaignDiagramElementManager;
});
