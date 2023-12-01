Terrasoft.configuration.Structures["SoapServiceParameterPage"] = {innerHierarchyStack: ["SoapServiceParameterPage"], structureParent: "ServiceParameterPage"};
define('SoapServiceParameterPageStructure', ['SoapServiceParameterPageResources'], function(resources) {return {schemaUId:'838620a4-6fac-f31e-9f61-888c851742e4',schemaCaption: "SoapServiceParameterPage", parentSchemaName: "ServiceParameterPage", packageName: "ServiceDesigner", schemaName:'SoapServiceParameterPage',parentSchemaUId:'3c5bc346-0b9a-41ba-a554-a2b8f3166538',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("SoapServiceParameterPage", ["ServiceEnums"], function() {
	return {
		mixins: {},
		messages: {},
		properties: {},
		modules: {},
		attributes: {
			/**
			 * Sequence element name.
			 */
			"SequenceElementName": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		methods: {

			//region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.ServiceParameterPage#getAttributeMap
			 * @override
			 */
			getAttributeMap: function() {
				const attributeMap = this.callParent(arguments);
				return Ext.apply(attributeMap, {
					sequenceElementName: "SequenceElementName",
				});
			},

			/**
			 * @inheritdoc Terrasoft.ServiceParameterPage#onIsArrayChange
			 * @override
			 */
			onIsArrayChange: function() {
				if (!this.$IsArray) {
					this.$SequenceElementName = "item";
				}
				this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.ServiceParameterPage#getTrackedAttributes
			 * @override
			 */
			getTrackedAttributes: function() {
				const attributes = this.callParent(arguments);
				attributes.push("SequenceElementName");
				return attributes;
			},

			/**
			 * @inheritdoc Terrasoft.ServiceParameterPage#getPathPlaceholder
			 * @override
			 */
			getPathPlaceholder: function() {
				if (this.$ParameterType === Terrasoft.services.enums.ServiceParameterType.BODY) {
					return "";
				}
				return this.callParent(arguments);
			},

			getAvailableServiceParameterTypes: function() {
				return [
					Terrasoft.services.enums.ServiceParameterType.BODY,
					Terrasoft.services.enums.ServiceParameterType.HTTP_HEADER,
					Terrasoft.services.enums.ServiceParameterType.COOKIE
				];
			},

			//endregion

			//region Methods: Public

			/**
			 * Returns true if sequence item type allowed for parameter.
			 */
			isSequenceElementNameVisible: function() {
				return this.$Schema && this.$IsArray;
			},

			/**
			 * Returns hint for sequence element name.
			 * @public
			 * @return {String} sequence element name hint.
			 */
			getSequenceElementNameHint: function() {
				switch (this.$DataValueTypeName) {
					case Terrasoft.services.enums.DataValueTypeName.Object:
						return this.get("Resources.Strings.SequenceObjectElementNameTip");
					default:
						return this.get("Resources.Strings.SequenceElementNameTip");
				}
			},

			//endregion

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "ParameterEditContainer",
				"propertyName": "items",
				"name": "SequenceElementName",
				"index": 6,
				"values": {
					"layout": {"column": 0, "row": 3, "colSpan": 8},
					"bindTo": "SequenceElementName",
					"caption": "$Resources.Strings.SequenceElementNameCaption",
					"controlConfig": {
						"markerValue": "ParameterSequenceElementNameMarker"
					},
					"visible": {"bindTo": "isSequenceElementNameVisible"},
					"enabled": "$CanEditSchema",
					"classes": {"wrapClassName": ["grid-layout-row"]},
					"tip": {"content": "$getSequenceElementNameHint"}
				}
			},
		]/**SCHEMA_DIFF*/
	};
});


