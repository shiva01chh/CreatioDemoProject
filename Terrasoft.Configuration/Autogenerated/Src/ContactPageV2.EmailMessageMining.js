﻿define("ContactPageV2", ["ContactPageV2Resources", "css!ContactPageV2CSS", "EmailEnrichmentMixin"], function() {
		return {
			messages: {

				/**
				 * Update contact enrichment page visibility.
				 */
				"ContactPageV2OnSavedResponse": {
					"mode": Terrasoft.MessageMode.PTP,
					"direction": Terrasoft.MessageDirectionType.PUBLISH
				}
			},

			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onSaved
				 * @overridden
				 */
				onSaved: function(response) {
					var savedRecordConfig = {
						success: response.success,
						contactId: this.getPrimaryColumnValue(),
						contactName: this.getPrimaryDisplayColumnValue()
					};
					this.sandbox.publish("ContactPageV2OnSavedResponse", savedRecordConfig, [this.sandbox.id]);
					this.callParent(arguments);
				}

				//endregion

			}
		};
	});
