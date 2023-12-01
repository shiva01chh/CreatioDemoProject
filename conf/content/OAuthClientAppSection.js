Terrasoft.configuration.Structures["OAuthClientAppSection"] = {innerHierarchyStack: ["OAuthClientAppSection"], structureParent: "BaseSectionV2"};
define('OAuthClientAppSectionStructure', ['OAuthClientAppSectionResources'], function(resources) {return {schemaUId:'9ba85552-ee9b-ffe2-50dd-7a1113412405',schemaCaption: "OAuthClientAppSection", parentSchemaName: "BaseSectionV2", packageName: "OAuth20", schemaName:'OAuthClientAppSection',parentSchemaUId:'7912fb69-4fee-429f-8b23-93943c35d66d',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("OAuthClientAppSection", [],
	function() {
		return {
			entitySchemaName: "OAuthClientApp",
			attributes: {
				"SecurityOperationName": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: "CanManageAdministration"
				}
			},
			methods: {
				getDefaultDataViews: function() {
					var dataViews = this.callParent(arguments);
					delete dataViews.AnalyticsDataView;
					return dataViews;
				},

				getModuleCaption: function() {
					return this.get("Resources.Strings.SectionCaption");
				},

				initEditPages: function() {
					this.callParent(arguments);
					var editPages = this.get("EditPages");
					var typeUId = this.Terrasoft.GUID_EMPTY;
					if (this.Ext.isEmpty(editPages.find(typeUId))) {
						editPages.add(typeUId, this.Ext.create("Terrasoft.BaseViewModel", {
							values: {
								Id: typeUId,
								Caption: this.get("Resources.Strings.EditPageCaption"),
								Click: {bindTo: "addRecord"},
								Tag: typeUId,
								SchemaName: "OAuthClientAppPage"
							}
						}));
					}
				},

				addDefaultResource: function() {
					this.callService({
						serviceName: "OAuthConfigService",
						methodName: "AddDefaultResource",
					}, function(response) {
						if (!response.AddDefaultResourceResult.success) {
							Terrasoft.showMessage(response.AddDefaultResourceResult.errorInfo.message);
						} else {
							var message = this.get("Resources.Strings.DefaultResourceSuccessMessage");
							Terrasoft.showMessage(message);
						}
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getSectionActions
				 * @overridden
				 */
				getSectionActions: function() {
					var actions = this.callParent(arguments);
					actions.clear();
					actions.addItem(this.createAddDefaultResourceButton());
					return actions;
				},

				/**
				 * Creates add default resource button.
				 * @protected
				 */
				createAddDefaultResourceButton: function() {
					return this.getButtonMenuItem({
						"Caption": {"bindTo": "Resources.Strings.AddDefaultResourceButtonCaption"},
						"Click": {"bindTo": "addDefaultResource"},
						"Visible": true,
						"Enabled": true,
						"IsEnabledForSelectedAll": true
					});
				}
			},
			diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGridActiveRowCopyAction",
				"values": {
					"visible": false
				}
			}
			]/**SCHEMA_DIFF*/
		};
	});

