﻿Terrasoft.configuration.Structures["BaseClientConnector"] = {innerHierarchyStack: ["BaseClientConnector"]};
define("BaseClientConnector", ["ExecuteCommandRequest"], function() {
	/**
	 * @class Terrasoft.configuration.SocialNetworkClientConnector
	 * ##### ########### ###### # ########## ##### # #######.
	 */
	Ext.define("Terrasoft.configuration.social.BaseClientConnector", {
		extend: "Terrasoft.core.BaseObject",
		alternateClassName: "Terrasoft.BaseClientConnector",

		//region Properties: Private

		consumerKey: "",
		consumerSecret: "",
		consumerVersion: "",
		type: "",
		user: "",
		socialAccount: null,
		serviceRequestClassName: "",

		//endregion

		//region Methods: Private

		/**
		 * ########## ######### ## ######.
		 * @private
		 * @param {Object} errorInfo ########## ## ######.
		 * @returns
		 */
		getConnectorErrorMessage: function(errorInfo) {
			var template = "{0}: {1}\n{2}";
			return Ext.String.format(template, errorInfo.errorCode, errorInfo.message, errorInfo.stackTrace);
		},

		setInitialConsumerInfo: function(callback, scope) {
			this.getConsumerInfo(function(response) {
				if (!response.success) {
					return callback.call(scope, response);
				}
				var consumerInfo = response.consumerInfo;
				var consumerKey = this.consumerKey = consumerInfo.key;
				if (!consumerKey) {
					throw new Terrasoft.NullOrEmptyException({
						message: "consumerKey"
					});
				}
				var consumerVersion = this.consumerVersion = consumerInfo.version;
				if (!consumerVersion) {
					throw new Terrasoft.NullOrEmptyException({
						message: "consumerVersion"
					});
				}
				callback.call(scope, response);
			}, this);
		},

		setInitialSocialAccountInfo: function(callback, scope) {
			this.findSocialAccountInfo(function(response) {
				if (!response.success) {
					return callback.call(scope, response);
				}
				this.socialAccount = response.socialAccountInfo;
				callback.call(scope, response);
			}, this);

		},

		getServiceRequestConfig: function(config) {
			delete config.className;
			if (!config.contractName) {
				delete config.contractName;
			}
			return Ext.apply({}, config, {
				user: this.user,
				type: this.type
			});
		},

		validateGetServiceRequestConfig: function(config) {
			if (!config) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
					argumentName: "config"
				});
			}
			var className = config.className || this.serviceRequestClassName;
			if (!className) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
					argumentName: "serviceRequestClassName"
				});
			}
		},

		/**
		 * ######### ######### ######## ##### ####### ###### ## ####### #######.
		 * @private
		 * @param {Object} config #########.
		 * @param {String} config.accessToken ###### #######.
		 * @param {String} config.socialId ############# ############ ## ####### #######.
		 */
		validateCreateSocialAccountConfig: function(config) {
			var accessToken = config.accessToken;
			if (!accessToken) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
					argumentName: "config.accessToken"
				});
			}
			var socialId = config.socialId;
			if (!socialId) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
					argumentName: "config.socialId"
				});
			}
		},

		/**
		 * ########## ########## # ########## ## ####### #######.
		 * @private
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		getConsumerInfo: function(callback, scope) {
			var request = this.getServiceRequest({
				contractName: "GetConsumerInfo"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.logConnectorError(response.errorInfo);
				}
			}, this);
		},

		//endregion

		//region Methods: Protected

		/**
		 * ######### # ### ######### ## ######.
		 * @protected
		 * @param {Object} errorInfo ########## ## ######.
		 */
		logConnectorError: function(errorInfo) {
			if (errorInfo.handled) {
				return;
			}
			var message = this.getConnectorErrorMessage(errorInfo);
			this.log(message, Terrasoft.LogMessageType.ERROR);
		},

		/**
		 * ########## ######### ## ######.
		 * @protected
		 * @param {Object} errorInfo ########## ## ######.
		 */
		throwConnectorError: function(errorInfo) {
			throw new Terrasoft.UnknownException({
				message: this.getConnectorErrorMessage(errorInfo)
			});
		},

		getServiceRequest: function(config) {
			this.validateGetServiceRequestConfig(config);
			var className = config.className || this.serviceRequestClassName;
			var requestConfig = this.getServiceRequestConfig(config);
			return Ext.create(className, requestConfig);
		},

		/**
		 * ############# ###### #######.
		 * @protected
		 * @param {Object} config ######### #########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		setAccessToken: function(config, callback, scope) {
			var accessToken = config.accessToken;
			if (!accessToken) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
					argumentName: "accessToken"
				});
			}
			var request = this.getServiceRequest({
				contractName: "SetAccessToken",
				accessToken: accessToken
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.throwConnectorError(response.errorInfo);
				}
			}, this);
		},

		/**
		 * ########## ###### #######.
		 * @protected
		 * @param {Object} config ######### #########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		getAccessToken: function(config, callback, scope) {
			this.findAccessToken(config, function(response) {
				if (!response.accessToken) {
					throw new Terrasoft.ItemNotFoundException({
						message: "AccessToken"
					});
				}
				callback.call(scope, response);
			}, this);
		},

		/**
		 * ########## ###### #######.
		 * @protected
		 * @param {Object} config ######### #########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		findAccessToken: function(config, callback, scope) {
			var request = this.getServiceRequest({
				contractName: "FindAccessToken"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.logConnectorError(response.errorInfo);
				}
			}, this);
		},

		//endregion

		//region Methods: Public

		/**
		 * ############# Api ### ###### # ####### ########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		init: function(callback, scope) {
			this.setInitialConsumerInfo(function(response) {
				if (!response.success) {
					return callback.call(scope, response);
				}
				this.setInitialSocialAccountInfo(callback, scope);
			}, this);
		},

		/**
		 * ####### ####### ###### ## ####### #######.
		 * @param {Object} config ######### ########.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		createSocialAccount: function(config, callback, scope) {
			this.validateCreateSocialAccountConfig(config);
			var request = this.getServiceRequest({
				contractName: "CreateSocialAccount",
				accessToken: config.accessToken,
				socialId: config.socialId
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.throwConnectorError(response.errorInfo);
				}
			}, this);
		},

		/**
		 * ######### ####### ####### ###### ## ####### #######.
		 * @param {Object} config ######### ####### ######.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		checkSocialAccount: function(config, callback, scope) {
			var request = this.getServiceRequest({
				contractName: "CheckSocialAccount"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.logConnectorError(response.errorInfo);
				}
			}, this);
		},

		/**
		 * ########## ########## ## ####### ###### ## ####### #######.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		getSocialAccountInfo: function(callback, scope) {
			var request = this.getServiceRequest({
				contractName: "GetSocialAccountInfo"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.throwConnectorError(response.errorInfo);
				}
			}, this);
		},

		/**
		 * ########## ########## ## ####### ###### ## ####### #######.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		findSocialAccountInfo: function(callback, scope) {
			var request = this.getServiceRequest({
				contractName: "FindSocialAccountInfo"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.logConnectorError(response.errorInfo);
				}
			}, this);
		},

		/**
		 * ####### ####### ###### ## ####### #######.
		 * @param {Object} config ######### ####### ######.
		 * @param {Function} callback ####### ######### ######.
		 * @param {Object} scope ######## ###### ####### ######### ######.
		 */
		deleteSocialAccount: function(config, callback, scope) {
			var request = this.getServiceRequest({
				contractName: "DeleteSocialAccount"
			});
			request.execute(function(response) {
				callback.call(scope, response);
				if (!response.success) {
					this.throwConnectorError(response.errorInfo);
				}
			}, this);
		}

		//endregion
	});
});


