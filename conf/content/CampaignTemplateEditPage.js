﻿Terrasoft.configuration.Structures["CampaignTemplateEditPage"] = {innerHierarchyStack: ["CampaignTemplateEditPage"]};
define('CampaignTemplateEditPageStructure', ['CampaignTemplateEditPageResources'], function(resources) {return {schemaUId:'4f79ff9c-56e4-6cf3-737b-cf64be94f4ec',schemaCaption: "CampaignTemplateEditPage", parentSchemaName: "", packageName: "CrtCampaignDesigner7x", schemaName:'CampaignTemplateEditPage',parentSchemaUId:'',extendParent:false,type:Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},schemaDifferences:function(){

}};});
/**
 * Preview campaign template before save.
 */
define("CampaignTemplateEditPage", ["CampaignDiagramSvgRenderer", "CampaignTemplateEditPageResources",
		"css!CampaignTemplateEditPage", "ImageView"],
	function(svgRenderer) {
		return {
			properties: {
				/**
				 * Maximum length for template caption field.
				 */
				templateCaptionMaximumLength: 230
			},
			messages: {

				/**
				 * @message TemplateSaved
                 * Indicates user choice to save the template.
				 */
				"TemplateSaved": {
					direction: Terrasoft.MessageDirectionType.PUBLISH,
					mode: Terrasoft.MessageMode.PTP
				},

				/**
				 * @message SaveTemplateCancel
				 * Indicates user choice to cancel template saving process.
				 */
				"SaveTemplateCancel": {
					direction: Terrasoft.MessageDirectionType.PUBLISH,
					mode: Terrasoft.MessageMode.PTP
				}
			},
			attributes: {

				/**
				 * Campaign identifier.
				 * @type {Guid}
				 */
				"CampaignId": {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Template caption.
				 * @type {String}
				 */
				"TemplateCaption": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * Template preview image url string.
				 * @type {String}
				 */
				"PreviewImage" : {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {
				_getBlankSlateImage() {
					return this.get("Resources.Strings.TemplatePreviewScreenshotImage")
				},

				_onCanvasRender: function(canvas) {
					var image = canvas.toDataURL();
					if (image) {
						this.$PreviewImage = image;
						canvas.remove();
					}
				},

				/**
				 * @private
				 */
				_createPreviewScreenshot: function() {
					this.$PreviewImage = this._getBlankSlateImage();
					var svgSelector = "ts-campaign-diagram svg[data-element-id='root1']";
					var targetWidth = 600;
					var targetHeight = 400;
					svgRenderer.svgToCanvas(svgSelector, targetWidth, targetHeight, this._onCanvasRender.bind(this));
				},

				/**
				 * @inheritdoc Terrasoft.BaseViewModel#init
				 * @override
				 */
				init: function() {
					this.callParent(arguments);
					this._createPreviewScreenshot();
				},

				/**
				 * Handler on save button pressed.
				 * Sends message TemplateSaved to CampaignSchemaDesignerNew.
				 * @protected
				 */
				onSaveButtonClick: function() {
					if (this.$TemplateCaption && this.$TemplateCaption !== Terrasoft.emptyString) {
						this.sandbox.publish("TemplateSaved", {
							templateName: this.$TemplateCaption.substring(0, this.templateCaptionMaximumLength),
							previewImage: this.$PreviewImage
						}, [this.sandbox.id]);
					}
				},

				/**
				 * Handler on cancel button pressed.
				 * Sends message SaveTemplateCancel to CampaignSchemaDesignerNew.
				 * @protected
				 */
				onCancelButtonClick: function() {
					this.sandbox.publish("SaveTemplateCancel", null, [this.sandbox.id]);
				},

				/**
				 * Defines if save button is enabled.
				 * @protected
				 * @returns {boolean} Returns true when PreviewImage is loaded and TemplateCaption typed.
				 */
				getIsSaveButtonEnabled: function () {
					return this.$PreviewImage && (this.$PreviewImage !== this._getBlankSlateImage());
				}

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "SaveTemplatePageContainer",
					"propertyName": "items",
					"values": {
						"id": "SaveTemplatePageContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "SaveTemplatePageHeader",
					"parentName": "SaveTemplatePageContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"classes": {
							"wrapClassName": ["header-wrap"]
						},
						"items": [],
						"styles": {
							"height": "100%",
							"width": "100%"
						}
					}
				},
				{
					"operation": "insert",
					"name": "EditPageCaption",
					"parentName": "SaveTemplatePageHeader",
					"propertyName": "items",
					"index": 1,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"markerValue": "EditPageCaption",
						"caption": "$Resources.Strings.TitleCaption",
						"classes": {
							"labelClass": ["t-title-label-template-edit-page"]
						},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 20,
							"rowSpan": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "CloseButton",
					"parentName": "SaveTemplatePageHeader",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.BUTTON,
						"imageConfig": "$Resources.Images.CloseIcon",
						"click": "$onCancelButtonClick",
						"classes": {
							"wrapperClass": ["btn-close"]
						},
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"layout": {
							"column": 23,
							"row": 0,
							"colSpan": 1,
							"rowSpan": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "TemplateCaptionInputCaption",
					"parentName": "SaveTemplatePageHeader",
					"propertyName": "items",
					"index": 1,
					"values": {
						"id": "TemplateCaptionInputCaption",
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.TemplateCaptionLabel",
						"classes": {
							"labelClass": ["t-label t-label-is-required"]
						},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 5,
							"rowSpan": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "TemplateCaption",
					"parentName": "SaveTemplatePageHeader",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.TEXT,
						"placeholder": "$Resources.Strings.TemplateCaptionLabel",
						"wrapClass": ["style-input"],
						"isRequired": true,
						"focused": true,
						"markerValue": "TemplateCaption",
						"labelConfig": {
							"visible": false
						},
						"layout": {
							"column": 5,
							"row": 1,
							"colSpan": 19,
							"rowSpan": 0
						}
					}
				},
				{
					"operation": "insert",
					"name": "PreviewImageContainer",
					"parentName": "SaveTemplatePageContainer",
					"propertyName": "items",
					"values": {
						"id": "PreviewImageContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["template-edit-page-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "PreviewImage",
					"parentName": "PreviewImageContainer",
					"propertyName": "items",
					"values": {
						"id": "PreviewImage",
						"itemType": this.Terrasoft.ViewItemType.COMPONENT,
						"wrapClasses": ["template-edit-page-preview-image"],
						"selectors": {
							"wrapEl": "#previewImage"
						},
						"className": "Terrasoft.ImageView",
						"imageSrc": "$PreviewImage",
						"tag": "PreviewImage"
					}
				},
				{
					"operation": "insert",
					"name": "EditButtonsContainer",
					"parentName": "SaveTemplatePageContainer",
					"propertyName": "items",
					"values": {
						"id": "EditButtonsContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["template-edit-page-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "CancelButton",
					"parentName": "EditButtonsContainer",
					"propertyName": "items",
					"values": {
						"classes": {"textClass": ["actions-button-margin-right"]},
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "Cancel",
						"click": "$onCancelButtonClick",
						"style": Terrasoft.controls.ButtonEnums.style.DEFAULT
					}
				},
				{
					"operation": "insert",
					"name": "SaveButton",
					"parentName": "EditButtonsContainer",
					"propertyName": "items",
					"values": {
						"classes": {"textClass": ["actions-button-margin-right"]},
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "Save",
						"click": "$onSaveButtonClick",
						"style": Terrasoft.controls.ButtonEnums.style.BLUE,
						"enabled": "$getIsSaveButtonEnabled"
					}
				}
			]
		};
	});


