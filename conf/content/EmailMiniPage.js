﻿Terrasoft.configuration.Structures["EmailMiniPage"] = {innerHierarchyStack: ["EmailMiniPage"], structureParent: "BaseMiniPageTemplate"};
define('EmailMiniPageStructure', ['EmailMiniPageResources'], function(resources) {return {schemaUId:'7f8c0e15-789e-4f10-a714-7ac07f57a006',schemaCaption: "Email Mini Page", parentSchemaName: "BaseMiniPageTemplate", packageName: "CrtUIv2", schemaName:'EmailMiniPage',parentSchemaUId:'ecdcc8ff-272c-4957-9381-7d74ce17e140',extendParent:false,type:Terrasoft.SchemaType.ANGULAR_SCHEMA,entitySchema:'',name:'',extend:'Terrasoft.model.BaseViewModel',schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]},methods:{},controlsConfig:{},customBindings:{},bindings:{},parameters:{},schemaDifferences:function(){

}};});
define("EmailMiniPage", /**SCHEMA_DEPS*/["@creatio-devkit/common"]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/(devkit)/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "remove",
				"name": "PageTitle"
			},
			{
				"operation": "remove",
				"name": "ContinueInOtherPageButton"
			},
			{
				"operation": "merge",
				"name": "MainContainer",
				"values": {
					"padding": {
						"top": "medium",
						"right": "none",
						"bottom": "none",
						"left": "none"
					}
				}
			},
			{
				"operation": "remove",
				"name": "FooterContainer"
			},
			{
				"operation": "remove",
				"name": "CancelButton"
			},
			{
				"operation": "remove",
				"name": "SaveButton"
			},
			{
				"operation": "insert",
				"name": "Label_NewEmail",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_zr0917j_caption)#)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Label_l6u8t0o",
				"values": {
					"type": "crt.Label",
					"caption": "#MacrosTemplateString(#ResourceString(Label_l6u8t0o_caption)#)#",
					"labelType": "headline-2",
					"labelThickness": "default",
					"labelEllipsis": false,
					"labelColor": "auto",
					"labelBackgroundColor": "transparent",
					"labelTextAlign": "start",
					"visible": true
				},
				"parentName": "MainHeader",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "MessageComposerSelector",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.MessageComposerSelector",
					"items": [],
					"visible": true,
					"defaultChannel": "crt.EmailComposer"
				},
				"parentName": "MainContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "EmailComposer",
				"values": {
					"type": "crt.EmailComposer",
					"classes": [
						"view-element"
					],
					"sortedByColumn": "CreatedOn",
					"data": {
						"uId": "aa682a42-a03c-867e-f8a8-6b376e0cda2d",
						"schemaType": "Email",
						"sortedByColumn": "CreatedOn",
						"typeName": "crt.EmailComposer",
						"caption": "Email"
					},
					"emailComposerCleared": {
						"request": "crt.ClosePageRequest"
					},
					"recordId": "$Id",
					"entitySchemaName": "Activity",
					"defaultSenderRequest": "crt.DefaultSenderComposerRequest",
					"height": 200,
					"headerLabelsWidth": 50,
					"expandOnLoad": true
				},
				"parentName": "MessageComposerSelector",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"Id": {
						"modelConfig": {
							"path": "ActivityDS.Id"
						}
					},
					"SendDate": {
						"modelConfig": {
							"path": "ActivityDS.SendDate"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"ActivityDS": {
							"type": "crt.EntityDataSource",
							"scope": "page",
							"config": {
								"entitySchemaName": "Activity"
							}
						}
					},
					"primaryDataSourceName": "ActivityDS"
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[
			{
				request: "crt.HandleViewModelInitRequest",
				handler: async (request, next) => {
					await next?.handle(request);
					request.$context.events$.subscribe((async (evt) => {
						const modelMode = await request.$context.getPrimaryModelMode();
						if (modelMode === 'update' && evt?.type === 'finish-load-model-attributes' &&
								evt?.payload?.SendDate && evt?.payload?.Id) {
							const recordId = await request.$context.Id;
							const sendDate = await request.$context.SendDate;
							if (!recordId || sendDate) {
								return;
							}
							const handlerChain = devkit.HandlerChainService.instance;
							await new Promise(resolve => setTimeout(resolve, 250));
							handlerChain.process({
								type: 'crt.EditDraftEmailComposerRequest',
								recordId,
								$context: request.$context
							});
						}
					}));
				}
			},
			{
				request: "crt.HandleModelEventRequest",
				handler: async (request, next) => {
					// Do not refresh page data after the live editing notification.
					if (request.modelEvent?.type === 'update') {
						return;
					}
					await next?.handle(request);
				}
			}
		]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});

