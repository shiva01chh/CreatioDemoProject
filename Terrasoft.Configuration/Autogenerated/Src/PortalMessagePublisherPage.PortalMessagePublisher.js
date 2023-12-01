define("PortalMessagePublisherPage", ["PortalMessagePublisherPageResources",  "ConfigurationConstants",
		"ExtendedHtmlEditModuleUtilities", "ExtendedHtmlEditModule", "MessagePublisherAttachmentUtilities",
		"SchemaBuilderV2"],
		function(resources, ConfigurationConstants) {
			return {
				entitySchemaName: "PortalMessage",
				mixins: {
					ExtendedHtmlEditModuleUtilities: "Terrasoft.ExtendedHtmlEditModuleUtilities",
					MessagePublisherAttachmentUtilities: "Terrasoft.MessagePublisherAttachmentUtilities",
					/**
					 * @class Terrasoft.EmailImageMixin
					 * Mixin for inserting images.
					 */
					EmailImageMixin: "Terrasoft.EmailImageMixin",
				},
				attributes: {
					/**
					 * Entities list.
					 */
					entitiesList: {
						"dataValueType": this.Terrasoft.DataValueType.COLLECTION,
						"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
					},
					"PortalEditControlHintText": {
						dataValueType: this.Terrasoft.DataValueType.TEXT
					},
					"Message": {
						"dataValueType": this.Terrasoft.DataValueType.TEXT,
						"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
						"value": ""
					}
				},
				methods: {
					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#init
					 * @overridden
					 */
					init: function() {
						this.callParent(arguments);
						this.set("entitiesList", this.Ext.create("Terrasoft.Collection"));
						this.initDefaultValues();
						this.initAttachmentsViewData();
						this.initCollection();
						this.mixins.MessagePublisherAttachmentUtilities.init.call(this);
						this.initImageUrlTpl();
						if (!this.get("Images")) {
							this.set("Images", this.Ext.create("Terrasoft.BaseViewModelCollection"));
						}
					},

					/**
					 * @inheritdoc Terrasoft.MessagePublisherAttachmentUtilities#getAttachments
					 * @overridden
					 */
					getAttachments: function(callback, scope) {
						if (this.Terrasoft.Features.getIsEnabled("SecurePortalMessageFileInHistory")) {
							const config = this._getServiceConfig();
							this.callService(config, function(response) {
								if (response && response.GetPortalMessageFilesResult) {
									this._loadResponseToList(response.GetPortalMessageFilesResult.PortalMessageFiles);
									Ext.callback(callback, scope);
								}
							}, this);
						} else {
							this.mixins.MessagePublisherAttachmentUtilities.getAttachments.call(this, callback);
						}
					},

					/**
					 * @private
					 */
					_loadResponseToList: function(files) {
						const viewModels = Ext.create("Terrasoft.Collection");
						Terrasoft.each(files, function (file) {
							file.filesList = this.get("FilesList");
							const viewModelConfig = {
								values: file,
								Ext: this.Ext,
								Terrasoft: this.Terrasoft,
								sandbox: this.sandbox
							};
							const viewModel = this.Ext.create(this.get("AttachmentViewModelClass"),
								viewModelConfig);
							viewModels.addIfNotExists(file.Id, viewModel);
						}, this);
						this.get("FilesList").reloadAll(viewModels);
					},

					/**
					 * @private
					 */
					_getServiceConfig: function () {
						return {
							"serviceName": "PortalMessageFileService",
							"methodName": "GetPortalMessageFiles",
							"data": {
								"portalMessageId": this.get("PrimaryColumnValue"),
								"readingOptions": {
									"rowCount": 50,
									"lastValue": Terrasoft.GUID_EMPTY
								}
							}
						};
					},


					/**
					 * Initializes attachments view data (viewModelClass and viewConfig).
					 * @private
					 */
					initAttachmentsViewData: function() {
						var schemaName = "PortalPublisherAttachmentPage";
						var builderConfig = {
							schemaName: schemaName,
							entitySchemaName: null,
							profileKey: schemaName
						};
						var schemaBuilder = this.Ext.create("Terrasoft.SchemaBuilder");
						schemaBuilder.build(builderConfig, function(viewModelClass, viewConfig) {
							this.set("AttachmentViewModelClass", viewModelClass);
							this.set("AttachmentViewConfig", viewConfig);
						}, this);
					},

					/**
					 * Initializes collection.
					 * @private
					 */
					initCollection: function() {
						var collectionName = "FilesList";
						var collection = this.get(collectionName);
						if (!collection) {
							collection = this.Ext.create("Terrasoft.Collection");
							this.set(collectionName, collection);
						} else {
							collection.clear();
						}
					},

					/**
					 * Initializes default values.
					 * @protected
					 */
					initDefaultValues: function() {
						this.set("isToolbarVisible", false);
						var isSspUser = this.Terrasoft.CurrentUser.userType === this.Terrasoft.UserType.SSP;
						this.set(
							"PortalEditControlHintText", isSspUser
								? resources.localizableStrings.WritePortalPostHintOnPortal
								: resources.localizableStrings.WritePortalPostHint
						);
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#getServiceConfig
					 * @overridden
					 */
					getServiceConfig: function() {
						return {
							className: "Terrasoft.Configuration.PortalMessagePublisher"
						};
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#publishMessage
					 * @overridden
					 */
					publishMessage: function() {
						var complainMessage = arguments[0] && arguments[0].Message;
						var message = this.get("Message") || complainMessage;
						if (this.Ext.isEmpty(message)) {
							this.showInformationDialog(this.get("Resources.Strings.EmptyMessageError"));
							return;
						}
						this.callParent(arguments);
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#onPublished
					 * @overridden
					 */
					onPublished: function() {
						this.callParent(arguments);
						this.set("Message", "");
						var listItems = this.get("FilesList");
						listItems.clear();
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#getPublishMaskCaption
					 * @overridden
					 */
					getPublishMaskCaption: function() {
						return this.get("Resources.Strings.PortalMaskCaption");
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessagePublisherPage#getPublishData
					 * @overridden
					 */
					getPublishData: function() {
						var publishData = this.callParent(arguments);
						var message = this.get("Message");
						publishData.push({"Key": "Message", "Value": message});
						return publishData;
					},

					/**
					 * @private
					 */
					_getInsertQuery: function() {
						const insert = this.Ext.create("Terrasoft.InsertQuery", {
							rootSchemaName: this.entitySchemaName
						});
						insert.setParameterValue("Id", this.get("PrimaryColumnValue"),
							this.Terrasoft.DataValueType.GUID);
						insert.setParameterValue("EntitySchemaUId", Terrasoft.GUID_EMPTY,
							this.Terrasoft.DataValueType.GUID);
						insert.setParameterValue("EntityId", Terrasoft.GUID_EMPTY,
							this.Terrasoft.DataValueType.GUID);
						insert.setParameterValue("Message", this.get("Resources.Strings.DraftBodyMessage"),
							this.Terrasoft.DataValueType.TEXT);
						insert.setParameterValue("IsNotPublished", true,
							this.Terrasoft.DataValueType.BOOLEAN);
						return insert;
					},
					
					/**
					 * @private
					 */
					_isMasterRecordValid: function(masterRecordId) {
						var config = this.getListenerRecordData();
						if (!config) {
							return true;
						}
						return config.relationSchemaRecordId === masterRecordId;
					},

					/**
					 * Inserts entity.
					 * @private
					 */
					insertEntity: function() {
						const insert = this._getInsertQuery();
						insert.execute(function(response) {
							if (response && response.success) {
								this.set("IsInserted", response.success);
								this.uploadFile();
							}
						}, this);
					},

					/**
					 * Returns attachment view config.
					 * @protected
					 * @virtual
					 * @param {Object} itemConfig Attachment config.
					 * @param {Object} file loaded file data.
					 */
					getItemViewConfig: function(itemConfig, file) {
						var fullViewConfig = this.get("AttachmentViewConfig");
						if (fullViewConfig.length > 0) {
							var attachmentWrapContainerIndex = 0;
							for (var i = 0; i < fullViewConfig.length; i++) {
								if (fullViewConfig[i].id === "AttachmentWrapContainer") {
									attachmentWrapContainerIndex = i;
									break;
								}
							}
							itemConfig.config = fullViewConfig[attachmentWrapContainerIndex];
						}
						this.addImage(file);
					},

					/**
					 * Add uploaded image to images collection.
					 * @protected
					 * @virtual
					 * @param {Object} file loaded file data.
					 */
					addImage: function (file) {
						if (file) {
							const fileName = file.get("Name");
							const fileTypes = this.get("FileTypes");
							if (!fileTypes) {
								return;
							}
							if (fileTypes[fileName] && fileTypes[fileName].match(/^image/)) {
								const image = this.Ext.create("Terrasoft.BaseViewModel", {
									values: {
										fileName: fileName,
										url: "../rest/FileService/GetFile/" +
											ConfigurationConstants.SysSchema.PortalMessageFile + "/" + file.get("Id")
									}
								});
								const imagesCollection = this.get("Images");
								if (imagesCollection) {
									imagesCollection.add(imagesCollection.getUniqueKey(), image);
								}
							}
						}
					},

					/**
					 * @inheritDoc Terrasoft.BaseMessagePublisherPage#onNewCardSaved
					 * @overridden
					 */
					onNewCardSaved: function(masterData) {
						if (masterData && !this._isMasterRecordValid(masterData.masterRecordId)) {
							return;
						}
						if (!this.get("Message")) {
							return;
						}
						this.publishMessage();
					},

					/**
					 * @inheritdoc Terrasoft.EmailImageMixin#getUploadSingleFileConfig
					 * @overridden
					 */
					getUploadSingleFileConfig: function(file, callback, scope) {
						const config = this.mixins.EmailImageMixin.getUploadSingleFileConfig.call(this, file, callback, scope);
						config.additionalParams.UseAdminRights = false;
						return config;
					},

					/**
					 * Image pasted event handler. Pasts to message body image pasted from buffer.
					 * @public
					 * @param {Object} item Pasted from buffer file config object.
					 */
					onImagePasted: function(item) {
						let file;
						if (item && this.Ext.isFunction(item.getAsFile)) {
							file = item.getAsFile();
						}
						const args = [file, this.get("PrimaryColumnValue"), this.onComplete.bind(this), this];
						if (this.get("IsInserted")) {
							this.insertImageFromBuffer(args);
							return;
						}
						const insert = this._getInsertQuery();
						insert.execute(function(response) {
							if (response && response.success) {
								this.set("IsInserted", true);
								this.insertImageFromBuffer(args);
							}
						}, this);
					},

					/**
					 * @inheritdoc Terrasoft.MessagePublisherAttachmentUtilities#onComplete
					 * @overridden
					 */
					onComplete: function() {
						this.mixins.MessagePublisherAttachmentUtilities.onComplete.call(this);
						this.onDropzoneHover(false);
					},

					/**
					 * @inheritdoc Terrasoft.EmailImageMixin#getFileEntitySchemaName
					 * @overridden
					 */
					getFileEntitySchemaName: function() {
						return "PortalMessageFile";
					},

					/**
					 * @inheritdoc Terrasoft.EmailImageMixin#getFileEntityMasterColumnName
					 * @overridden
					 */
					getFileEntityMasterColumnName: function() {
						return "PortalMessage";
					},

					/**
					 * @inheritdoc Terrasoft.EmailImageMixin#getFileSchemaUId
					 * @overridden
					 */
					getFileSchemaUId: function() {
						return ConfigurationConstants.SysSchema.PortalMessageFile;
					},

					/**
					 * @inheritDoc Terrasoft.BaseMessagePublisherPage#isNeedToBePublished
					 * @overridden
					 */
					isNeedToBePublished: function() {
						return Boolean(this.get("Message"));
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "PortalMessageBody",
						"values": {
							"bindTo": "Message",
							"contentType": this.Terrasoft.ContentType.RICH_TEXT,
							"generator": "InlineTextEditViewGenerator.generate",
							"labelConfig": {
								"visible": true
							},
							"markerValue": "PortalMessageBody",
							"placeholder": {
								"bindTo": "PortalEditControlHintText"
							},
							"controlConfig": {
								"inlineTextControlConfig": {
									"ckeditorDefaultConfig": {
										"allowedContent": true,
										"removeButtons": "bpmonlinemacros",
									}
								},
								"images": {
									"bindTo": "Images"
								},
								"imagePasted": {
									"bindTo": "onImagePasted"
								}
							}
						},
						"parentName": "BodyContainer",
						"propertyName": "items"
					},
					{
						"operation": "insert",
						"name": "AttachFileButton",
						"propertyName": "items",
						"parentName": "PublisherBottomContainer",
						"values": {
							"itemType": this.Terrasoft.ViewItemType.BUTTON,
							"style": this.Terrasoft.controls.ButtonEnums.style.DEFAULT,
							"iconAlign": this.Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
							"imageConfig": {
								"bindTo": "getAttachFileButtonImageConfig"
							},
							"tag": "attachFileButton",
							"fileUpload": true,
							"filesSelected": {"bindTo": "onAttachFileSelected"},
							"click": {
								"bindTo": "onAttachFileButtonClick"
							},
							"enabled": {
								"bindTo": "IsPublishButtonEnabled"
							},
							"classes": {
								"imageClass": ["attachFileButtonImage"]
							},
							"markerValue": "AttachFileButton"
						}
					},
					{
						"operation": "insert",
						"name": "FilesList",
						"parentName": "ModulePageContainer",
						"propertyName": "items",
						"values": {
							"generateId": false,
							"generator": "ConfigurationItemGenerator.generateContainerList",
							"idProperty": "Id",
							"collection": "FilesList",
							"onGetItemConfig": "getItemViewConfig",
							"isAsync": true
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});
