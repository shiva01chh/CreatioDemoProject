﻿define("DuplicatesSearchNotificationTargetLoader", ["DeduplicationConstants", "BaseNotificationTargetLoader"],
		function(DeduplicationConstants) {
			Ext.define("Terrasoft.configuration.DuplicatesSearchNotificationTargetLoader", {
				extend: "Terrasoft.BaseNotificationTargetLoader",
				alternateClassName: "Terrasoft.DuplicatesSearchNotificationTargetLoader",

				/**
				 * @inheritdoc Terrasoft.BaseNotificationTargetLoader#loadFromViewModel
				 * @overridden
				 */
				loadFromViewModel: function(config) {
					this.loadPage(config.get("SchemaName"));
				},

				/**
				 * @inheritdoc Terrasoft.BaseNotificationTargetLoader#loadFromPopup
				 * @overridden
				 */
				loadFromPopup: function(config) {
					this.loadPage(config.id.split("_")[0]);
				},

				/**
				 * Loads page.
				 * @private
				 * @param {String} schemaName Name of schema.
				 */
				loadPage: function(schemaName) {
					const historyState = this.sandbox.publish("GetHistoryState");
					const state = historyState.state || {};
					const isNewPage = DeduplicationConstants.features.getIsLazyDuplicatesPageEnabled();
					const page = isNewPage ? "LazyDuplicatesPageV2" : "DuplicatesPageV2";
					const hash = Ext.String.format("CardModuleV2/{0}/{1}", page, schemaName);
					this.sandbox.publish("ReplaceHistoryState", {
						stateObj: state,
						hash: hash,
						silent: false
					});
				}
			});

			return Terrasoft.DuplicatesSearchNotificationTargetLoader;
		});
