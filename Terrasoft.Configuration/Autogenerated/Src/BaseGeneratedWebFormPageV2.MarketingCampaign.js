 define("BaseGeneratedWebFormPageV2", ["BaseGeneratedWebFormPageV2Resources", "css!BaseGeneratedWebFormPageV2CSS"],
	function() {
		return {
			attributes: {
				/**
				 * Matomo API Address.
				 */
				"MatomoAPIAddress": {
					"value": "",
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {
				/**
				 * @inheritdoc BaseGeneratedWebFormPageV2#loadSysSettings
				 * @override
				 */
				loadSysSettings: function(callback, scope) {
					var parentMethod = this.getParentMethod();
					var sysSettings = ["MatomoAPIAddress"];
					Terrasoft.SysSettings.querySysSettings(sysSettings, function(settings) {
						this.set("MatomoAPIAddress", settings.MatomoAPIAddress);
						parentMethod.call(this, callback, scope);
					}, this);
				},

				/**
				 * @inheritdoc BaseGeneratedWebFormPageV2#getTrackingCodeTemplate
				 * @override
				 */
				getTrackingCodeTemplate: function() {
					var codeTemplate = this.callParent();
					var matomoAPIAddress = this.get("MatomoAPIAddress");
					if (Ext.isEmpty(matomoAPIAddress)) {
						return codeTemplate;
					}
					var matomoCodeTemplate = this.get("Resources.Strings.MatomoCodeTemplate");
					var matomoAddress = "\"" + matomoAPIAddress + "\"";
					var matomoDomain = matomoAPIAddress.replace("https:", "").replaceAll("/", "");
					matomoCodeTemplate = matomoCodeTemplate.split("##matomoAddress##").join(matomoAddress);
					matomoCodeTemplate = matomoCodeTemplate.split("##matomoDomain##").join(matomoDomain);
					return codeTemplate + matomoCodeTemplate;
				},

				/**
				 * @inheritdoc BaseGeneratedWebFormPageV2#getCreateObjectServiceCall
				 * @override
				 */
				getCreateObjectServiceCall: function() {
					var createObjectServiceCall = this.callParent();
					var matomoAPIAddress = this.get("MatomoAPIAddress");
					if (Ext.isEmpty(matomoAPIAddress)) {
						return createObjectServiceCall;
					}
					var matomoColumns = this.get("Resources.Strings.MatomoColumnsTemplate");
					createObjectServiceCall = matomoColumns.split("##serviceCall##").join(createObjectServiceCall);
					return createObjectServiceCall;
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
 	});
