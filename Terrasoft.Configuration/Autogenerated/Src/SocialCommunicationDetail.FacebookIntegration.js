﻿define("SocialCommunicationDetail", ["ConfigurationConstants", "FacebookSocialCommunicationViewModel"],
		function(ConfigurationConstants) {
	return {
		messages: {

			/**
			 * ######### # ############# ######### ###### ## ########## #####.
			 */
			"GetSocialNetworkData": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * ########## ## ######### ######## ###### ## ########## #####.
			 */
			"SocialNetworkDataLoaded": {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BaseCommunicationDetail#getCommunicationViewModelClassName
			 * @overridden
			 */
			getCommunicationViewModelClassName: function() {
				return "Terrasoft.FacebookSocialCommunicationViewModel";
			},

			/**
			 * @private
			 * @param config
			 */
			addSocialInformation: function(config) {
				var socialInfoSet = config.information;
				if (!socialInfoSet) {
					return;
				}
				if (!this.Ext.isArray(socialInfoSet)) {
					socialInfoSet = [socialInfoSet];
				}
				this.Terrasoft.each(socialInfoSet, function(socialInfo) {
					var splitter = config.splitter;
					var communicationType = config.communicationType;
					var socialNetworkType = config.socialNetworkType;
					if (splitter) {
						this.Terrasoft.each(socialInfo.split(splitter), function(number) {
							this.addSocialCommunicationItem(number, communicationType, socialNetworkType);
						}, this);
					} else {
						this.addSocialCommunicationItem(socialInfo, communicationType, socialNetworkType)
					}
				}, this);
			},

			addSocialCommunicationItem: function(number, communicationType, socialNetworkType) {
				if (!number) {
					return;
				}
				var communication = this.addItem(communicationType);
				communication.set("Number", number);
				communication.set("SocialNetworkType", socialNetworkType);
			},

			/**
			 * @protected
			 * @param {String|Array} webInformation ########## # ############## ######## ## ######## #######.
			 */
			addWebInformation: function(webInformation) {
				this.addSocialInformation({
					information: webInformation,
					communicationType: ConfigurationConstants.CommunicationTypes.Web,
					socialNetworkType: ConfigurationConstants.CommunicationTypes.Facebook,
					splitter: " "
				});
			},

			addEmailInformation: function(emailInformation) {
				this.addSocialInformation({
					information: emailInformation,
					communicationType: ConfigurationConstants.CommunicationTypes.Email,
					socialNetworkType: ConfigurationConstants.CommunicationTypes.Facebook,
					splitter: " "
				});
			},

			addPhoneInformation: function(phoneInformation) {
				this.addSocialInformation({
					information: phoneInformation,
					socialNetworkType: ConfigurationConstants.CommunicationTypes.Facebook,
					splitter: ", "
				});
			},

			/**
			 * ########## ####### ######## ###### ## ########## #####.
			 * @param {Object} facebookEntities ###### ## ########## #####.
			 * @param {String} facebookEntities.website ##### #####.
			 * @param {String} facebookEntities.phone #######.
			 * @param {Array} facebookEntities.emails ###### ########### #######.
			 */
			onSocialNetworkDataLoaded: function(facebookEntities) {
				if (!facebookEntities) {
					return;
				}
				this.Terrasoft.each(facebookEntities, function(facebookEntity) {
					this.addWebInformation(facebookEntity.website);
					this.addPhoneInformation(facebookEntity.phone);
					this.addEmailInformation(facebookEntity.email);
					this.addEmailInformation(facebookEntity.emails);
				}, this);
			},

			/**
			 * @inheritdoc Terrasoft.BaseCommunicationDetail#onContainerListDataLoaded
			 * @overridden
			 */
			onContainerListDataLoaded: function() {
				this.callParent(arguments);
				var communications = this.sandbox.publish("GetSocialNetworkData");
				if (!communications) {
					this.sandbox.subscribe("SocialNetworkDataLoaded", this.onSocialNetworkDataLoaded, this);
				} else {
					this.onSocialNetworkDataLoaded(communications);
				}
			}
		}
	};
});
