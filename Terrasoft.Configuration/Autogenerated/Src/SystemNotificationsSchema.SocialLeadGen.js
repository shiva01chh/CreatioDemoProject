 define("SystemNotificationsSchema", [], function() {
    return {
        methods: {
            /**
             * @inheritdoc Terrasoft.configuration.BaseNotificationSchema#onNotificationSubjectClick
             * @overridden
             */
            onNotificationSubjectClick: function() {
                var loaderName = this.get("LoaderName");
              	switch(loaderName){
                	case "LeadGenLog":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break;
                    case "LeadGenWebhooks":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings");
               			window.open(url, "_blank");
                  	break; 
                    case "SocialLeadGeneration_ProcessingIncomingMessages":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings");
               			window.open(url, "_blank");
                  	break; 
                     case "SocialLeadGeneration_LoadingLeads":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                     case "SocialLeadGeneration_ConsistencyCheck":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                    break; 
                     case "SocialLeadGeneration_LeadCreation":
                		var url = this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "ClientApp/#/SocialLeadgen/settings?tab=logs");
               			window.open(url, "_blank");
                  	break; 
                	default:
                    	this.callParent(arguments);
                    	return;
             	}
           }
        },
        diff: []
    };
});