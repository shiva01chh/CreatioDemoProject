Terrasoft.configuration.Structures["ForecastEditableColumnDesigner"] = {innerHierarchyStack: ["ForecastEditableColumnDesigner"]};
define('ForecastEditableColumnDesignerStructure', ['ForecastEditableColumnDesignerResources'], function(resources) {return {schemaUId:'f8d7077b-4a6d-4fe8-95a3-6654f7b42f9a',schemaCaption: "Forecast editable column designer page", parentSchemaName: "", packageName: "CoreForecast", schemaName:'ForecastEditableColumnDesigner',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ForecastEditableColumnDesigner", [], function() {
	return {
		attributes: {
			/**
			 * Column settings.
			 */
			"ColumnSettings": {
				"dataValueType": Terrasoft.DataValueType.OBJECT,
				"value": {}
			},
			/**
			 * Is group cells edit is enabled.
			 */
			"IsGroupEdit": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			}
		},
		messages: {
			/**
			 * @message GetColumnConfig
			 * Returns column config from loaded module.
			 */
			"GetColumnConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		methods: {
			/**
			 * @inheritDoc Terrasoft.BaseSchemaViewModel#init
			 * @override
			 */
			init: function(callback, scope) {
				this._subscribeMessages();
				this.callParent(arguments);
				this.$IsGroupEdit = this.$ColumnSettings.isGroupEdit;
			},

			/**
			 * @private
			 */
			_subscribeMessages: function() {
				this.sandbox.subscribe("GetColumnConfig", this._formColumnConfig, this,
					[this.sandbox.id]);
			},

			/**
			 * @private
			 */
			_formColumnConfig: function() {
				return {
					"isGroupEdit": this.$IsGroupEdit
				};
			},

			/**
			 * Gets if ForecastGroupEdit feature is enabled.
			 * @returns {Boolean} Is ForecastGroupEdit feature enabled.
			 */
			getIsForecastGroupEditEnabled: function() {
				return this.getIsFeatureEnabled("ForecastGroupEdit");
			}
		},
		diff: [
			{
				"name": "ColumnDesigner",
				"operation": "insert",
				"values": {
					"items": [],
					"classes": {"wrapClassName": ["column-designer-container"]},
					"itemType": Terrasoft.ViewItemType.CONTAINER
				}
			},
			{
				"operation": "insert",
				"parentName": "ColumnDesigner",
				"propertyName": "items",
				"name": "IsGroupEdit",
				"values": {
					"bindTo": "IsGroupEdit",
					"visible": {"bindTo": "getIsForecastGroupEditEnabled"},
					"caption": {
						"bindTo": "Resources.Strings.IsGroupEditCaption"
					},
					"controlConfig": {
						"className": "Terrasoft.CheckBoxEdit"
					}
				}
			},
		]
	};
});


