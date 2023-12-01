Terrasoft.configuration.Structures["ServiceEnterpriseIntro"] = {innerHierarchyStack: ["ServiceEnterpriseIntro"], structureParent: "SimpleIntro"};
define('ServiceEnterpriseIntroStructure', ['ServiceEnterpriseIntroResources'], function(resources) {return {schemaUId:'163bfbd6-8d7c-49d1-841e-259fc0ba257c',schemaCaption: "Service intro page", parentSchemaName: "SimpleIntro", packageName: "ServiceEnterpriseDefSettings", schemaName:'ServiceEnterpriseIntro',parentSchemaUId:'bb057159-e980-45c5-9e98-e93dc287e20a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceEnterpriseIntro", ["ServiceEnterpriseIntroResources", "css!IntroPageCSS"],
	function(resources) {
		return {
			attributes: {},
			methods: {},
			diff: [
				{
					"operation": "remove",
					"name": "MobileAppLinksPanel"
				},
				{
					"operation": "insert",
					"name": "ServiceTile",
					"propertyName": "items",
					"parentName": "LeftContainer",
					"index": 1,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"generator": "MainMenuTileGenerator.generateMainMenuTile",
						"caption": {"bindTo": "Resources.Strings.ServiceCaption"},
						"cls": "service-tile itil-service-transitions-tile",
						"icon": resources.localizableImages.ServiceIcon,
						"items": []
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "CaseSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.CaseSectionCaption"},
						"tag": "SectionModuleV2/CaseSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ProblemSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ProblemSectionCaption"},
						"tag": "SectionModuleV2/ProblemSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ConfItemSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ConfItemSectionCaption"},
						"tag": "SectionModuleV2/ConfItemSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ChangeSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ChangeSectionCaption"},
						"tag": "SectionModuleV2/ChangeSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ReleaseSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ReleaseSectionCaption"},
						"tag": "SectionModuleV2/ReleaseSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ServiceItemSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ServiceSectionCaption"},
						"tag": "SectionModuleV2/ServiceItemSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "ServicePactSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.ServicePactSectionCaption"},
						"tag": "SectionModuleV2/ServicePactSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "QueueItemSection",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.QueueSectionCaption"},
						"tag": "SectionModuleV2/QueueItemSection/",
						"click": {"bindTo": "onNavigateTo"}
					}
				},
				{
					"operation": "insert",
					"propertyName": "items",
					"parentName": "ServiceTile",
					"name": "OperatorSingleWindowModule",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "Resources.Strings.OperatorSingleWindowSectionCaption"},
						"tag": "OperatorSingleWindowModule/",
						"click": {"bindTo": "onNavigateTo"}
					}
				}
			]
		};
	}
);


