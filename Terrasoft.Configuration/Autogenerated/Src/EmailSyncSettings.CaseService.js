define("EmailSyncSettings", ["AcademyUtilities"],
	function(AcademyUtilities) {
		return {
			entitySchemaName: "MailboxSyncSettings",
			attributes: {
				"HelpUrl": {
					"value": "",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {

				/**
				 * @inheritDoc Terrasoft.BaseSyncSettingsTab#init.
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.set("LanguageList", this.Ext.create(this.Terrasoft.Collection));
					this.initHelpUrl();
				},

				/**
				 * @inheritDoc Terrasoft.BaseSyncSettingsTab#getDefValuesConfig.
				 * @overridden
				 */
				getDefValuesConfig: function() {
					var config = this.callParent(arguments);
					config.columns.push("MessageLanguage");
					return config;
				},

				/**
				 * @inheritDoc Terrasoft.EmailSyncSettings#getUpdateQuery.
				 * @overridden
				 */
				getUpdateQuery: function(){
					var messageLanguage = Ext.isEmpty(this.get("MessageLanguage")) ? null :
							this.get("MessageLanguage").value;
					var update = this.callParent(arguments);
					update.setParameterValue("MessageLanguage",
								messageLanguage, Terrasoft.DataValueType.GUID);
					return update;
				},

				/**
				 * Return link to the academy.
				 * @param {String} text Caption with macros.
				 * @returns {String} Caption with url.
				 * @private
				 */
				getUrlText: function(text) {
					var url = this.get("HelpUrl");
					var startTag = "";
					var finishTag = "";
					if (!Ext.isEmpty(url)) {
						startTag = "<a target=\"_blank\" href=\"" + url + "\">";
						finishTag = "</a>";
					}
					text = Ext.String.format(text, startTag, finishTag);
					return text;
				},

				/**
				 * Initializes Academy link.
				 * @private
				 */
				initHelpUrl: function() {
					var config = {
						contextHelpCode: "AccountPageV2",
						contextHelpId: "1001",
						scope: this
					};
					config.callback = function(url) {
						this.set("HelpUrl", url);
					};
					AcademyUtilities.getUrl(config);
				},

				/**
				 * Get caption with hint.
				 * @private
				 * @returns {String} Url text.
				 */
				getMessageLanguageHint: function (){
					var messageLanguageCaption = this.get("Resources.Strings.MessageLanguageTip");
					return this.getUrlText(messageLanguageCaption);
				},

				/**
				 * Prepares language list.
				 * @protected
				 * @virtual
				 * @param {String} searchText Text to search.
				 * @param {Terrasoft.Collection} list Language list.
				 */
				onPrepareLanguageList: function(searchText, list) {
					var esq = this.createSysLanguageQuery(searchText);
					esq.getEntityCollection(function(response) {
						if (response && response.success) {
							var languageList = {};
							var languages = response.collection;
							languages.each(function(language) {
								var id = language.get("Id");
								languageList[id] = {
									value: id,
									displayValue: language.get("Name"),
									code: language.get("Code")
								};
							}, this);
							list.clear();
							list.loadAll(languageList);
						}
					}, this);
				},

				/**
				 * Initializes entity schema query columns.
				 * @private
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 */
				initSysLanguageQueryColumns: function(esq) {
					esq.addColumn("Name");
					var codeColumn = esq.addColumn("Code");
					codeColumn.orderPosition = 0;
					codeColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
				},

				/**
				 * Initializes entity schema query filters.
				 * @private
				 * @param {Terrasoft.EntitySchemaQuery} esq Entity schema query.
				 * @param {String} searchText Text to search.
				 */
				initSysLanguageQueryFilters: function(esq, searchText) {
					var filters = esq.filters;
					var filterGroup = new this.Terrasoft.createFilterGroup();
					filterGroup.add("ActiveLanguage", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "IsUsed", 1));
					filterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.CONTAIN, "Name", searchText));
					filters.add(filterGroup);
				},

				/**
				 * Creates "SysLanguage" entity schema query.
				 * @param {String} searchText Text to search.
				 * @return {Terrasoft.EntitySchemaQuery}
				 */
				createSysLanguageQuery: function(searchText) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SysLanguage"
					});
					this.initSysLanguageQueryColumns(esq);
					this.initSysLanguageQueryFilters(esq, searchText);
					return esq;
				},

				/**
				 * Check feature status.
				 */
				isMultiLanguage: function() {
					return false;
				}
			},
			diff: [
				{
					"operation": "insert",
					"propertyName": "items",
					"name": "MessageLanguage",
					"values": {
						"caption": {"bindTo": "Resources.Strings.MessageLanguage"},
						"tip": {
							"content": {"bindTo": "getMessageLanguageHint"}
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": {"bindTo": "onPrepareLanguageList"},
							"list": {"bindTo": "LanguageList"},
							"filterComparisonType": Terrasoft.StringFilterType.CONTAIN,
							"minSearchCharsCount": 3
						},
						"visible": {
							"bindTo": "isMultiLanguage"
						},
						"wrapClass": ["language-edit"]
					},
					index: 8
				}
			]
		};
	});
