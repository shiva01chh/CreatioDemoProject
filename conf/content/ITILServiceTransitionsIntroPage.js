Terrasoft.configuration.Structures["ITILServiceTransitionsIntroPage"] = {innerHierarchyStack: ["ITILServiceTransitionsIntroPage"], structureParent: "SimpleIntro"};
define('ITILServiceTransitionsIntroPageStructure', ['ITILServiceTransitionsIntroPageResources'], function(resources) {return {schemaUId:'5a99d63a-3d12-49ad-92c1-3e8e631cc25b',schemaCaption: "ITIL Service intro page", parentSchemaName: "SimpleIntro", packageName: "ServiceEnterpriseDefSettings", schemaName:'ITILServiceTransitionsIntroPage',parentSchemaUId:'bb057159-e980-45c5-9e98-e93dc287e20a',extendParent:false,type:Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
define("ITILServiceTransitionsIntroPage", ["ITILServiceTransitionsIntroPageResources", "css!IntroPageCSS"],
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
				}
			]
		};
	}
);


