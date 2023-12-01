﻿Terrasoft.configuration.Structures["PortalUserInvitationMixin"] = {innerHierarchyStack: ["PortalUserInvitationMixin"]};
define("PortalUserInvitationMixin", ["PortalUserInvitationMixinResources", "ConfigurationEnums",
		"ConfigurationConstants", "RightUtilities"],
	function(resources, ConfigurationEnums, ConfigurationConstants, RightUtilities) {
		Ext.define("Terrasoft.configuration.mixins.PortalUserInvitationMixin", {
			alternateClassName: "Terrasoft.PortalUserInvitationMixin",

			/**
			 * Schema name to creating new organization.
			 */
			openPageSchemaName: "OrganizationDetailPage",

			_getValidateEmailsServiceConfig: function(emails) {
				return {
					serviceName: "SspUserManagementService",
					methodName: "ValidateEmails",
					data: {
						request : {
							emails: emails.join()
						}
					}
				};
			},

			_validateEmails: function(emails, callback, scope) {
				var validateEmailsConfig = this._getValidateEmailsServiceConfig(emails);
				this.callService(validateEmailsConfig, function(response) {
					if (response) {
						const result = response.ValidateEmailsResult;
						if (result.success && result.invalidEmails.length === 0) {
							callback.call(scope || this);
						} else if (result.success && result.invalidEmails.length > 0) {
							this._hideBodyMask();
							this.showInformationDialog(resources.localizableStrings.CorporateDomainErrorMessage);
						} else {
							this._hideBodyMask();
							this.showInformationDialog(result.errorInfo.message);
						}
					}
				}, this);
			},

			_getUserEmails: function(contactsId, callback, scope) {
				var esq = Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "ContactCommunication"});
				esq.addColumn("Number");
				var existsFilter = Terrasoft.createColumnInFilterWithParameters("Contact", contactsId);
				var emailFilter = Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "CommunicationType.Name", "Email");
				esq.filters.add("requestFilter", existsFilter);
				esq.filters.add("emailFilter", emailFilter);
				esq.getEntityCollection(function(response) {
					if (!response.success) {
						this.showInformationDialog(response.errorInfo);
						this._hideBodyMask();
					} else {
						var items = response.collection.getItems();
						var emails = items.map(function(item) {
							return item.get("Number");
						});
						callback.call(scope || this, emails);
					}
				}, this);
			},

			/**
			 * Returns SSP user management service config.
			 * @protected
			 * @returns {Object} Service config.
			 */
			getSspUserManagementServiceConfig: function(accountId) {
				return {
					serviceName: "SspUserManagementService",
					methodName: "CheckIfPortalAccountExist",
					data: {
						accountId: accountId
					}
				};
			},

			/**
			 * Returns error message that the organization doesn't exist.
			 * @returns {String} Error message.
			 */
			getOrganizationNotExistErrorMessage: function() {
				return resources.localizableStrings.OrganizationNotExistErrorMessage;
			},

			/**
			 * Returns user creation message depending on the service response.
			 * @protected
			 * @param {Object} users Created users.
			 */
			getCreateUsersMessage: function(users) {
				const failedContactsName = this.getFailedContactNames(users);
				if (this.Ext.isEmpty(failedContactsName)) {
					return resources.localizableStrings.UsersCreatedSuccessMessage;
				}
				if (users.length === failedContactsName.length) {
					const failedUserMsg = this._geFirstErrorMessage(users);
					return this.Ext.String.format(resources.localizableStrings.UsersFailedMessage,
						failedUserMsg);
				}
				return this.Ext.String.format(resources.localizableStrings.SomeUsersFailedMessage,
					failedContactsName.join(", "));
			},

			_geFirstErrorMessage: function(users) {
				return users.filter(function (user) {
					return user.success === false;
				}, this).map(function (failedUser) {
					return this.Ext.String.format(failedUser.error, this._getContactName(failedUser));
				}, this)[0];
			},

			/**
			 * Returns config to call service to create users by existing contacts.
			 * @protected
			 * @param {Array} contactsId Contacts to create.
			 * @returns {Object} Service config.
			 */
			getCreateUsersByContactsServiceConfig: function(contactsId) {
				return {
					serviceName: "SspUserManagementService",
					methodName: "CreateUsersByContactsIds",
					data: {
						request: {
							contactIds: contactsId,
							accountId: this.$MasterRecordId,
							userRoles: []
						}
					}
				};
			},

			/**
			 * Creates users on portal by their contacts identifiers.
			 * @param {Array} contactsId Contact identifiers.
			 * @param callback Callback function that is called after user creation.
			 * @param scope Callback function scope.
			 */
			createUsersByContacts: function(contactsId, callback, scope) {
				if (this.Ext.isEmpty(contactsId)) {
					return;
				}
				Terrasoft.chain(
					function(next) {
						this._getUserEmails(contactsId, next, this);
					},
					function(next, emails) {
						this._validateEmails(emails, next, this);
					},
					function(next) {
						const config = this.getCreateUsersByContactsServiceConfig(contactsId);
						this.callService(config, next, this);
					},
					function(next, response) {
						this.onCreateUsersByContacts(response, callback, scope);
					},
					this);
			},

			/**
			 * Handles response after contact invitation.
			 * @protected
			 * @param {Object} response Service response which contains each contact data.
			 * @param callback Callback function that is called after contact invitation.
			 * @param scope Callback function scope.
			 */
			onCreateUsersByContacts: function(response, callback, scope) {
				const result = response && response.CreateUsersByContactsIdsResult;
				if (result && result.success) {
					if (_.any(result.contactInvites, function(invite) {return invite.success === true;}, this)) {
						this.inviteCreatedUsers(result.contactInvites, callback, scope || this);
					} else {
						const message = this.getCreateUsersMessage(result.contactInvites);
						console.error("Unable to invite portal users: " + JSON.stringify(result.contactInvites));
						this.showInformationDialog(message);
						callback.call(scope || this);
					}
				} else {
					this.showInformationDialog(result.errorInfo.message);
					callback.call(scope || this);
				}
			},

			/**
			 * Invites created portal users.
			 * @protected
			 * @param {Array} contactInvites Array which has information about the result of each portal user creation
			 * process
			 * @param {Function} callback Callback function
			 * @param scope
			 */
			inviteCreatedUsers: function(contactInvites, callback, scope) {
				const message = this.getCreateUsersMessage(contactInvites);
				const inviteUsersButton = this.getInviteButtonConfig();
				const closeButton = this.getCloseButtonConfig();
				this.showConfirmationDialog(message, function(returnCode) {
					if (returnCode === inviteUsersButton.returnCode) {
						const sysAdminUnitIds = contactInvites.filter(function(contact) {
							return contact.success === true;
						}).map(function(user) {
							return user.sysAdminUnitId;
						});
						this.inviteUsers(sysAdminUnitIds, function() {
							callback.call(scope || this);
						}, this);
					} else {
						callback.call(scope || this);
					}
				}, [inviteUsersButton, closeButton], {defaultButton: 0});
			},

			/**
			 * Returns contacts name which users were not created.
			 * @param {Object} contacts Information about each contact.
			 * @returns {Array} Failed contact names.
			 */
			getFailedContactNames: function(contacts) {
				return contacts.filter(function(contact) {
					return contact.success === false;
				}, this).map(function(contact) {
					return this._getContactName(contact);
				}, this);
			},

			_getContactName: function(contact) {
				return contact.name || contact.userName || contact.email;
			},

			/**
			 * Checks if organization by account exists and calls callback function.
			 * @protected
			 * @param accountId Account identifier.
			 * @param callback Callback function that is called after the organization checked.
			 * @param scope Callback function scope.
			 */
			checkOrganization: function(accountId ,callback, scope) {
				const config = this.getSspUserManagementServiceConfig(accountId);
				this.callService(config, function(response) {
					this.onCheckOrganizationResponse(response, callback, scope || this);
				}, this);
			},

			/**
			 * Handles response after checking organization.
			 * @protected
			 * @param {Object} response Service response.
			 * @param {Object} callback Callback function.
			 * @param {Object} scope Scope.
			 */
			onCheckOrganizationResponse: function(response, callback, scope) {
				const result = response && response.CheckIfPortalAccountExistResult;
				if (result && result.success) {
					callback.call(scope || this, result);
				}
			},

			/**
			 * Set rights result from RightService to local scope and call callback function.
			 * @protected
			 * @param {Object} permissions Permissions result from RightService.
			 * @param {Object} callback Callback function.
			 * @param {Object} scope Scope.
			 */
			setRightPermissions: function(permissions, callback, scope) {
				this.Terrasoft.each(permissions, function(operationRight, operationName) {
					scope.set(operationName, operationRight);
				}, this);
				this.Ext.callback(callback, scope);
			},

			/**
			 * Check rights for operation CanManageUsers and CanAdministratePortalUsers.
			 * @param {Object} callback Callback function.
			 * @param {Object} scope Scope.
			 */
			checkRightsPermission:function(callback, scope) {
				RightUtilities.checkCanExecuteOperations(["CanManageUsers", "CanAdministratePortalUsers"],
					function(permissions) {
						this.setRightPermissions(permissions, callback, scope || this);
					}, scope || this
				);
			},

			/**
			 * After rights permission checked.
			 * @protected
			 * @param {Object} accountInfo Account information.
			 */
			onPermissionChecked: function(accountInfo) {
				if (this.get("CanManageUsers") || this.get("CanAdministratePortalUsers")) {
					this.openOrganizationDetailPage(accountInfo);
				} else {
					this.showInformationDialog(resources.localizableStrings.CantAdministratePortalUsers);
				}
			},

			/**
			 * Check rights and opens creation Organization by Account page.
			 * @param {Object} accountInfo Account information.
			 */
			createOrganizationByAccount: function(accountInfo) {
				this.checkRightsPermission(function() { this.onPermissionChecked(accountInfo); }, this);
			},

			/**
			 * Opens creation Organization by Account page.
			 * @param {Object} accountInfo Account information.
			 */
			openOrganizationDetailPage: function(accountInfo) {
				const defaultValues = [{
					name: "PortalAccount",
					value: accountInfo.Id
				},{
					name: "Name",
					value: accountInfo.Name
				}];
				const cardModuleId = this.sandbox.id + this.openPageSchemaName;
				const openCardConfig = {
					moduleId: cardModuleId,
					schemaName: this.openPageSchemaName,
					operation: ConfigurationEnums.CardStateV2.ADD,
					defaultValues: defaultValues
				};
				this.sandbox.publish("OpenCard", openCardConfig, [this.sandbox.id]);
			},

			/**
			 * Shows dialog window with the ability to create new Organization by Account.
			 * @param {Object} accountInfo Account information.
			 */
			showOrganizationInformationDialog: function (accountInfo) {
				const createButtonCaption = resources.localizableStrings.CreateOrganizationButtonCaption;
				const createButtonReturnCode = "create";
				const createButton = this.getBlueDialogButtonConfig(createButtonCaption, createButtonReturnCode);
				const closeButton = this.getCloseButtonConfig();
				this.showConfirmationDialog(this.getOrganizationNotExistErrorMessage(), function(returnCode) {
					if (returnCode === createButton.returnCode) {
						this.createOrganizationByAccount(accountInfo);
					}
				}, [createButton, closeButton], {defaultButton: 0});
			},

			getInviteButtonConfig: function() {
				const inviteUsersButtonCaption = resources.localizableStrings.InviteUsersButtonCaption;
				const inviteUsersButtonReturnCode = "invite";
				return this.getBlueDialogButtonConfig(inviteUsersButtonCaption, inviteUsersButtonReturnCode);
			},

			getCloseButtonConfig:  function() {
				const closeButtonCaption = Terrasoft.Resources.Controls.MessageBox.ButtonCaptionClose;
				const closeButtonReturnCode = Terrasoft.MessageBoxButtons.CLOSE.returnCode;
				return this.getDefaultDialogButtonConfig(closeButtonCaption, closeButtonReturnCode);
			},

			getBlueDialogButtonConfig: function(dialogButtonCaption, dialogButtonCode) {
				const dialogButtonConfig = this.getDialogButtonConfig(dialogButtonCaption, dialogButtonCode);
				dialogButtonConfig.style = Terrasoft.controls.ButtonEnums.style.BLUE;
				return dialogButtonConfig;
			},

			getDefaultDialogButtonConfig: function(dialogButtonCaption, dialogButtonCode) {
				const dialogButtonConfig = this.getDialogButtonConfig(dialogButtonCaption, dialogButtonCode);
				dialogButtonConfig.style = Terrasoft.controls.ButtonEnums.style.DEFAULT;
				return dialogButtonConfig;
			},

			getDialogButtonConfig: function(dialogButtonCaption, dialogButtonCode) {
				return {
					className: "Terrasoft.Button",
					caption: dialogButtonCaption,
					markerValue: dialogButtonCaption,
					returnCode: dialogButtonCode
				};
			},

			/**
			 * Invites users on portal.
			 * @param {Array} selectedUsersId Users identifiers to invite.
			 * @param callback Callback function that is called after user invitation.
			 * @param scope Callback function scope.
			 */
			inviteUsers: function (selectedUsersId ,callback, scope) {
				const config = this.getInviteUsersServiceConfig(selectedUsersId);
				this.callService(config, function(response) {
					this.onInviteUsers(response);
					this.Ext.callback(callback, scope || this);
				}, this);
			},

			/**
			 * Handles response after user invitation.
			 * @param {Object} response Invitation service response.
			 */
			onInviteUsers: function(response) {
				const result = response && response.InviteUsersResult;
				if (result && result.success) {
					const message = this.getUserInvitationMessage(result.contactInvites);
					this.showInformationDialog(message);
				} else {
					this.showInformationDialog(result.errorInfo.message);
				}
			},

			/**
			 * Creates information message which depends on information about the users.
			 * @param {Object} usersInvitesInfo Information about invited users.
			 * @returns {String} Information message.
			 */
			getUserInvitationMessage: function(usersInvitesInfo) {
				const failedContactsName = this.getFailedContactNames(usersInvitesInfo);
				if (this.Ext.isEmpty(failedContactsName)) {
					return resources.localizableStrings.UserSuccessInviteMessage;
				} else {
					return this.Ext.String.format(resources.localizableStrings.SomeUsersWithoutEmailErrorMessage,
						failedContactsName.join(", "));
				}
			},

			/**
			 * Returns config to call service to invite users by their identifiers.
			 * @param {Array} selectedUsersId Users to invite.
			 * @returns {Object} Service config.
			 */
			getInviteUsersServiceConfig: function(selectedUsersId) {
				return {
					serviceName: "SspUserManagementService",
					methodName: "InviteUsers",
					data: {
						request: {
							sysAdminUnitIds: selectedUsersId
						}
					}
				};
			}
		});
	});


