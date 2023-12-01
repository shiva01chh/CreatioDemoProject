define("CampaignDiagramComponent", ["CampaignDiagramDataAdapter", "CampaignDesignerComponent"], function() {
	Ext.define("Terrasoft.CampaignDesigner.CampaignDiagramComponent", {
		extend: "Terrasoft.BaseDiagramComponent",
		alternateClassName: "Terrasoft.CampaignDiagramComponent",

		/**
		 * Unique identifier of campaign schema.
		 */
		schemaUId: null,

		/**
		 * @override
		 */
		adapterClassName: "Terrasoft.CampaignDiagramDataAdapter",

		/**
		 * @inheritdoc Terrasoft.controls.Container#tpl
		 */
		tpl: [
			"<div id=\"diagram-{id}\" class=\"{wrapClassName}\">" +
			"<ts-campaign-diagram readonly=\"{readOnly}\"></ts-campaign-diagram>" +
			"</div>"
		],

		/**
		 * Flag to indicate data extensibility mode state.
		 * @type {Boolean}
		 */
		useExtendedMode: true,

		/**
		 * @private
		 */
		_extendItems: function(items) {
			var newItems = items.filterByFn(function(item) {
				return !this.items.findByFn(function(el) {
					return el.uId === item.uId;
				}, this);
			}, this);
			Terrasoft.each(newItems, function(el) {
				this.items.add(el.name, el);
			}, this);
		},

		/**
		 * @private
		 */
		_applyElementData: function(items) {
			var campaignElements = items.filterByFn(function(item) {
				return item instanceof Terrasoft.CampaignBaseElementSchema
					|| item instanceof Terrasoft.ProcessSequenceFlowSchema;
			});
			Terrasoft.each(campaignElements, function(element) {
				element.applyElementData(items);
			}, this);
			this._extendItems(items);
		},

		/**
		 * @override
		 */
		getDiagramDataAdapter: function () {
			var dataAdapter = this.callParent(arguments);
			dataAdapter.badgesConfig = this.badgesConfig || {};
			dataAdapter.useExtendedMode = this.useExtendedMode;
			return dataAdapter;
		},

		/**
		 * @override
		 */
		onCollectionDataLoaded: function(items, newItems) {
			if (newItems && !newItems.isEmpty()) {
				this._applyElementData(newItems);
			}
			this.callParent(arguments);
		},

		/**
		 * @override
		 */
		allowExternalChanges: function() {
			return false;
		},

		updateBadges: function(analyticsData) {
			Terrasoft.each(this.items, function(element) {
				if (!element.size) {
					return true;
				}
				element.stats = {};
				const stats = analyticsData.find(function(item) {
					return item.itemId === element.uId && item;
				});
				if (stats) {
					delete stats.itemId;
					Ext.apply(element.stats, stats);
				}
			}, this);
			this.renderItems();
		},

		/**
		 * @override
		 */
		renderItems: function(items) {
			if (!items) {
				this._applyElementData(this.items);
			}
			items = items || this.items;
			if (items.getCount() > 0) {
				this.callParent([items]);
			}
		},

		/**
		 * Highlights connection on diagram.
		 * @param {Guid} id Connection unique identifier.
		 * @param {Boolean} state Highlight connection state.
		 */
		highlightConnection: function(id, state) {
			var customEvent = this.mixins.customEvent;
			customEvent.publish("highlightConnection", { id: id, state: state });
		},

		/**
		 * Updates element description on diagram.
		 * @param {Guid} id Element unique identifier.
		 * @param {String} description New description value.
		 */
		updateDescription: function(id, description) {
			var customEvent = this.mixins.customEvent;
			customEvent.publish("elementDescriptionChange", { id: id, description: description });
		}
	});
});
