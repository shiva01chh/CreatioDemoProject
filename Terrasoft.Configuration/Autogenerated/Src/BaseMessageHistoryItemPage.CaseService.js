define("BaseMessageHistoryItemPage", ["StorageUtilities", "EmailUtilitiesV2", "FormatUtils", "NetworkUtilities",
		"MaskHelper", "MessageConstants", "css!MessageHistoryStyle", "MultilineLabel", "css!MultilineLabel",
		"MultilineFileLabel"],
	function(StorageUtilities, EmailUtilities) {
		return {
			entitySchemaName: "BaseMessageHistory",
			messages: {
				/**
				 * @message CreateCaseFromHistory
				 * Informs publisher that create case from history message.
				 */
				"CreateCaseFromHistory": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {
				/**
				 * Case origin.
				 */
				"CaseOrigin": {
					dataValueType: Terrasoft.DataValueType.GUID
				},

				/**
				 * CreateCaseFromHistoryFeature state.
				 */
				"CreateCaseFromHistoryFeatureState": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				}
			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * Gets highlighted or full message from case history.
				 * @virtual
				 * @returns {String} Selected message.
				 */
				getMessageFromHistory: this.Terrasoft.emptyFn,

				/**
				 * Gets case dependent entities.
				 * @virtual
				 * @param {Object} data Data for portal message.
				 * @returns {Array} Dependent case entities.
				 */
				getDependentEntities: this.Terrasoft.emptyFn,

				/**
				 * Gets case origin esq.
				 * @private
				 * @returns {Terrasoft.EntitySchemaQuery} Case origin esq.
				 */
				_getCaseOriginEsq: function() {
					var esq = this.Ext.create(Terrasoft.EntitySchemaQuery, {
						rootSchemaName: "CaseOrigin"
					});
					esq.addColumn("Id");
					esq.addColumn("Name");
					return esq;
				},

				/**
				 * Creates case origin data store.
				 * @private
				 * @param response Service response.
				 */
				_onCaseOriginCached: function(response) {
					if (response && response.success) {
						var caseOriginCachedCollection = [];
						var caseOriginItems = response.collection.getItems();
						this.Terrasoft.each(caseOriginItems, function(item){
							caseOriginCachedCollection.push({
								value: item.get("Id"),
								displayValue: item.get("Name")
							});
						});
						StorageUtilities.setItem(caseOriginCachedCollection, "CaseOriginCache");
						this._onPrepareCaseDataFromHistory();
					}
				},

				/**
				 * Gets needed case data from message history.
				 * @virtual
				 * @protected
				 * @returns {Object} Case message history data.
				 */
				getHistoryData: function() {
					var message = this.getMessageFromHistory();
					message = EmailUtilities.removeHtmlTags(message);
					message = this.Ext.String.htmlDecode(message);
					var newCaseId = this.Terrasoft.generateGUID();
					return {
						"newCaseId": newCaseId,
						"message": message
					};
				},

				/**
				 * Prepare specific case data from history.
				 * @public
				 */
				prepareCaseDataFromHistory: function() {
					if (this.Ext.isEmpty(StorageUtilities.getItem("CaseOriginCache"))) {
						var caseOriginEsq = this._getCaseOriginEsq();
						caseOriginEsq.getEntityCollection(this._onCaseOriginCached, this);
					} else {
						this._onPrepareCaseDataFromHistory();
					}
				},

				/**
				 * On prepare case data callback.
				 * @private
				 */
				_onPrepareCaseDataFromHistory: function() {
					var historyData = this.getHistoryData();
					var caseOriginId = this.get("CaseOrigin");
					var caseOriginCache = StorageUtilities.getItem("CaseOriginCache");
					historyData.caseOrigin = Terrasoft.findWhere(caseOriginCache, {value: caseOriginId});
					historyData.dependentEntities = this.getDependentEntities(historyData);
					this.sandbox.publish("CreateCaseFromHistory", historyData, [this.sandbox.id]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryItemPage#onSelectedTextButtonClick
				 * @overridden
				 */
				onSelectedTextButtonClick: function() {
					this.prepareCaseDataFromHistory();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.set("CreateCaseFromHistoryFeatureState", this.getIsFeatureEnabled("CreateCaseFromHistory"));
					this.callParent(arguments);
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);
