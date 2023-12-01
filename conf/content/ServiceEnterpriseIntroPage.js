Terrasoft.configuration.Structures["ServiceEnterpriseIntroPage"] = {innerHierarchyStack: ["ServiceEnterpriseIntroPage"], structureParent: "SimpleIntro"};
define('ServiceEnterpriseIntroPageStructure', ['ServiceEnterpriseIntroPageResources'], function(resources) {return {schemaUId:'8bce1187-fde4-4bdf-97ba-da74638e88f5',schemaCaption: "Service intro page", parentSchemaName: "SimpleIntro", packageName: "ServiceEnterpriseDefSettings", schemaName:'ServiceEnterpriseIntroPage',parentSchemaUId:'bb057159-e980-45c5-9e98-e93dc287e20a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ServiceEnterpriseIntroPage", ["ServiceEnterpriseIntroPageResources", "css!IntroPageCSS"],
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


