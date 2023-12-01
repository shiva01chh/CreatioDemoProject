define("CampaignDesigner", ["ext-base", "terrasoft", "css!CampaignDesignerCSS",
		"SchemaDesigner", "CampaignSchemaDesigner", "CampaignSchemaDesignerNew","SchemaBuilderV2"],
	function(Ext, Terrasoft) {
		/**
		 * @class Terrasoft.configuration.CampaignDesigner
		 */
		Ext.define("Terrasoft.configuration.CampaignDesigner", {
			extend: "Terrasoft.SchemaDesigner",
			alternateClassName: "Terrasoft.CampaignDesigner",

			schemaDesignerName: "Terrasoft.CampaignSchemaDesignerNew",

			/**
			 * @inheritdoc Terrasoft.SchemaDesigner#parseHash
			 * @override
			 */
			parseHash: function(hash) {
				var params = hash.split("/");
				var designer = params[0];
				var schemaUId = params[1];
				var entityId = params[2];
				var entitySchemaUId = params[3];
				return {
					designerName: designer,
					schemaUId: (schemaUId === "add") ? "" : schemaUId,
					entityId: entityId,
					entitySchemaUId: entitySchemaUId
				};
			},
			prepareBootstrap: function(next) {
				var schemaBuilderName = "Terrasoft.SchemaBuilder";
				var schemaBuilder = this.Ext.create(schemaBuilderName);
				var generatorConfig = {
					schemaName: "BootstrapModulesV2",
					profileKey: "BootstrapModulesV2"
				};
				schemaBuilder.requireAllSchemaHierarchy(generatorConfig, next, this);
			},
			/**
			 * @inheritDoc Terrasoft.BaseViewModule
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.Terrasoft.chain(
						this.prepareBootstrap,
						function() {
							if (callback) {
								callback.call(scope || this);
							}
						}, this);
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.SchemaDesigner#initDesigner
			 * @overridden
			 */
			initDesigner: function(config) {
				this.callParent(arguments);
				var params = this.parseHash(config.hash);
				this.designer = this.Ext.create(this.schemaDesignerName, {
					sandbox: this.sandbox,
					schemaUId: params.schemaUId,
					entityId: params.entityId,
					entitySchemaUId: params.entitySchemaUId
				});
			}
		});

		return Terrasoft.configuration.CampaignDesigner;
	}
);
