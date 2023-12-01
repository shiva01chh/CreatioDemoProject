﻿Terrasoft.configuration.Structures["AccountFacebookSearchSchema"] = {innerHierarchyStack: ["AccountFacebookSearchSchema"], structureParent: "FacebookSearchSchema"};
define('AccountFacebookSearchSchemaStructure', ['AccountFacebookSearchSchemaResources'], function(resources) {return {schemaUId:'a4c49319-27fa-47b2-89f1-a444af2b3af7',schemaCaption: "AccountFacebookSearchSchema", parentSchemaName: "FacebookSearchSchema", packageName: "FacebookIntegration", schemaName:'AccountFacebookSearchSchema',parentSchemaUId:'54522531-9cba-4dfb-93a0-c4c474ed4419',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("AccountFacebookSearchSchema", ["ConfigurationConstants"], function(ConfigurationConstants) {
	return {
		methods: {
			/**
			 * @inheritdoc Terrasoft.FacebookSearchSchema#getSelectedItems
			 * @overridden
			 */
			getSelectedItems: function() {
				var selectedRows = this.get("SelectedRows");
				var selectedItems = this.Ext.create("Terrasoft.Collection");
				var gridData = this.get("GridData");
				Terrasoft.each(selectedRows, function(rowId) {
					var item = gridData.get(rowId);
					item.set("CommunicationType", ConfigurationConstants.CommunicationTypes.Facebook);
					selectedItems.add(item);
				}, this);
				return selectedItems;
			},

			/**
			 * @inheritdoc Terrasoft.FacebookSearchSchema#getSelectButtonEnabled
			 * @overridden
			 */
			getSelectButtonEnabled: function() {
				var selectedRows = this.get("SelectedRows");
				var activeRowExist = (selectedRows.length > 0);
				return activeRowExist;
			},

			/**
			 * @inheritdoc Terrasoft.FacebookSearchSchema#getFacebookSearchLink
			 * @overridden
			 */
			getFacebookSearchLink: function(searchText) {
				return "https://www.facebook.com/search/results/?q=" + encodeURI(searchText) + "&type=pages";
			}
		},

		diff: [
			{
				"operation": "merge",
				"name": "SocialSearchResultGrid",
				"values": {
					"multiSelect": true,
					"columnsConfig": [
						{
							cols: 2,
							key: {
								name: "Photo",
								bindTo: "Photo",
								type: "grid-listed-icon"
							}
						},
						{
							cols: 6,
							key: {
								name: "Name",
								type: "text"
							},
							link: {"bindTo": "getNameLink"}
						},
						{
							cols: 4,
							key: {
								name: "Category",
								bindTo: "Category",
								type: "text"
							}
						},
						{
							cols: 4,
							key: {
								name: "Web",
								bindTo: "Web",
								type: "text"
							}
						},
						{
							cols: 3,
							key: {
								name: "Phone",
								bindTo: "Phone",
								type: "text"
							}
						},
						{
							cols: 3,
							key: {
								name: "Country",
								bindTo: "Country",
								type: "text"
							}
						},
						{
							cols: 2,
							key: {
								name: "City",
								bindTo: "City",
								type: "text"
							}
						}
					]
				}
			},
			{
				"operation": "remove",
				"name": "SearchHelpTextLabel"
			}
		]
	};
});


